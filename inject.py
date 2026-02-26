# -*- coding: utf-8 -*-
import os
import json
import re

# ================= НАСТРОЙКИ =================
JSONL_FILE = "game_code.json"         # Имя вашего файла от Ghidra
TARGET_DIR = "Assembly-CSharp"        # Имя папки с исходниками из dnSpy
# =============================================

def process():
    if not os.path.exists(JSONL_FILE):
        print(f"Error: Could not find {JSONL_FILE}")
        return
    if not os.path.exists(TARGET_DIR):
        print(f"Error: Could not find directory {TARGET_DIR}")
        return

    print("1. Grouping decompiled code by class...")
    class_methods = {}
    total_loaded = 0

    # Читаем потоковый JSONL
    with open(JSONL_FILE, 'r', encoding='utf-8') as f:
        for line in f:
            if not line.strip(): continue
            try:
                data = json.loads(line)
                for key, code in data.items():
                    if "$$" not in key: continue
                    
                    # Разбиваем Core.Animations.AlphaSpineUI$$SetAlpha
                    cls_full, method_full = key.split("$$", 1)
                    cls_name = cls_full.split(".")[-1] # Берем только AlphaSpineUI
                    
                    # Очищаем имя метода (убираем <bool> и т.д. для простого поиска)
                    method_base = method_full.split("<")[0]
                    
                    if cls_name not in class_methods:
                        class_methods[cls_name] = []
                    class_methods[cls_name].append((method_base, method_full, code))
                    total_loaded += 1
            except Exception as e:
                continue

    print(f"Loaded {total_loaded} functions across {len(class_methods)} classes.")

    print("2. Indexing .cs files...")
    cs_files = {}
    for root, dirs, files in os.walk(TARGET_DIR):
        for file in files:
            if file.endswith(".cs"):
                name_without_ext = file[:-3]
                cs_files[name_without_ext] = os.path.join(root, file)
                
    print(f"Found {len(cs_files)} C# files.")

    print("3. Injecting code...")
    injected_count = 0
    fallback_count = 0

    for cls_name, methods in class_methods.items():
        if cls_name not in cs_files:
            continue # Если файла нет, пропускаем (возможно это скрытый класс компилятора)

        filepath = cs_files[cls_name]
        with open(filepath, 'r', encoding='utf-8') as f:
            content = f.read()

        modified = False
        unmatched_methods = []

        for method_base, method_full, code in methods:
            # Оформляем код Ghidra как красивый комментарий
            ghidra_comment = f"\n\t\t/* --- GHIDRA: {method_full} ---\n"
            ghidra_comment += "\n".join("\t\t" + line for line in code.strip().splitlines())
            ghidra_comment += "\n\t\t*/\n"

            # Определяем, что искать
            search_name = method_base
            if method_base == ".ctor" or method_base == ".cctor":
                search_name = cls_name # Конструкторы в C# называются как класс
            elif method_base.startswith("get_") or method_base.startswith("set_"):
                # Свойства сложно парсить регуляркой, отправим их в блок Fallback
                unmatched_methods.append((method_full, ghidra_comment))
                continue

            # Регулярка: ищем имя метода, возможные <T>, скобки (), и открывающую {
            pattern = r"(\b" + re.escape(search_name) + r"\s*(?:<[^>]+>)?\s*\([^)]*\)\s*\{)"
            
            # Пытаемся заменить первую найденную фигурную скобку на скобку + наш комментарий
            new_content, count = re.subn(pattern, r"\1" + ghidra_comment.replace('\\', '\\\\'), content, count=1)
            
            if count > 0:
                content = new_content
                injected_count += 1
                modified = True
            else:
                unmatched_methods.append((method_full, ghidra_comment))

        # Если что-то не нашлось (свойства, перегрузки), дописываем в конец файла перед последней '}'
        if unmatched_methods:
            fallback_block = "\n\t// ================= UNMATCHED GHIDRA CODE =================\n"
            for m_full, g_comment in unmatched_methods:
                fallback_block += g_comment + "\n"
            
            # Находим последнюю закрывающую скобку класса/неймспейса и вставляем перед ней
            last_brace_idx = content.rfind('}')
            if last_brace_idx != -1:
                content = content[:last_brace_idx] + fallback_block + content[last_brace_idx:]
                fallback_count += len(unmatched_methods)
                modified = True

        if modified:
            with open(filepath, 'w', encoding='utf-8') as f:
                f.write(content)

    print("-" * 50)
    print("DONE!")
    print(f"Perfectly injected inside methods: {injected_count}")
    print(f"Appended to bottom of files (properties/overloads): {fallback_count}")
    print("Enjoy your readable project!")

if __name__ == "__main__":
    process()