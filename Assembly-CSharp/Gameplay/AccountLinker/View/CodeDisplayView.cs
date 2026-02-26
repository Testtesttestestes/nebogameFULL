using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	public class CodeDisplayView : MonoBehaviour
	{
		// Token: 0x06005749 RID: 22345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005749")]
		[Address(RVA = "0xA4C4", Offset = "0xA4C4", VA = "0xA4C4")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_AccountLinker_View_CodeDisplayView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5890f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_View_CodeDisplayView_HandleClickOnCodeField__);
		    DAT_ram_00a5890f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_View_CodeDisplayView_HandleClickOnCodeField__,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600574A RID: 22346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574A")]
		[Address(RVA = "0xA4C5", Offset = "0xA4C5", VA = "0xA4C5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_AccountLinker_View_CodeDisplayView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58910 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4417);
		    DAT_ram_00a58910 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x10);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x2cc));
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		  if (iVar2 == 0) {
		    Core_ExternAppMethods__SendLogToWeb(uVar1,0);
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = func_ii_7508(StringLiteral_4417,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,1,param3_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574B")]
		[Address(RVA = "0xA4C6", Offset = "0xA4C6", VA = "0xA4C6")]
		private void HandleClickOnCodeField(PointerEventData obj)
		{
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600574D RID: 22349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011CD")]
		public string Code
		{
			[Token(Token = "0x600574C")]
			[Address(RVA = "0xA4C7", Offset = "0xA4C7", VA = "0xA4C7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600574D")]
			[Address(RVA = "0xA4C8", Offset = "0xA4C8", VA = "0xA4C8")]
			set
			{
			}
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574E")]
		[Address(RVA = "0xA4C9", Offset = "0xA4C9", VA = "0xA4C9")]
		private void HandleCodeChanged()
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600574F")]
		[Address(RVA = "0xA4CA", Offset = "0xA4CA", VA = "0xA4CA")]
		public CodeDisplayView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_AccountLinker_View_CodeDisplayView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58911 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12548);
		    DAT_ram_00a58911 = '\x01';
		  }
		  return StringLiteral_12548;
		}
		*/

		}

		// Token: 0x04002F4B RID: 12107
		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _codeTextField;

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandlerOnCodeField;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x18")]
		private string _code;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Code ---
		void Gameplay_AccountLinker_View_CodeDisplayView__get_Code
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x18),param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x18) = param2;
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Code ---
		void Gameplay_AccountLinker_View_CodeDisplayView__set_Code(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x2d4))
		  ;
		  return;
		}
		*/

}
