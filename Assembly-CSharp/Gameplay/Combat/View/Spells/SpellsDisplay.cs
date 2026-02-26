using System;
using System.Collections.Generic;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	public class SpellsDisplay : AbstractCombatSpellsDisplay
	{
		// Token: 0x0600382B RID: 14379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x87E2", Offset = "0x87E2", VA = "0x87E2")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		undefined4 Gameplay_Combat_View_Spells_SpellsDisplay__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  return 0;
		}
		*/

		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B13")]
		public new GameObject gameObject
		{
			[Token(Token = "0x600382C")]
			[Address(RVA = "0x87E3", Offset = "0x87E3", VA = "0x87E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x87E4", Offset = "0x87E4", VA = "0x87E4", Slot = "11")]
		public override CombatSpellButton GetNexButton()
		{
		/* --- GHIDRA: GetNexButton ---
		void Gameplay_Combat_View_Spells_SpellsDisplay__GetNexButton(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a566ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellButton__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellButton__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		    DAT_ram_00a566ef = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(param1_01 + 0xc)) {
		    do {
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (param1_01,param2_00,
		                             Method_System_Collections_Generic_List_CombatSpellButton__get_Item__);
		      if (*(int *)(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		      }
		      Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___get_Selected
		                (param1_00,
		                 **(undefined4 **)(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x5c),
		                 Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__set_Data__
		                );
		      param2_00 = param2_00 + 1;
		      param1_01 = *(int *)(param1 + 0x18);
		    } while (param2_00 < *(int *)(param1_01 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x87E5", Offset = "0x87E5", VA = "0x87E5", Slot = "12")]
		public override void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Gameplay_Combat_View_Spells_SpellsDisplay__Reset(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint uVar5;
		  int iVar6;
		  uint uVar7;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a566f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatSpellButton__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatSpellButton__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_CombatSpellButton__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellButton__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellButton__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellButton__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CombatSpellButton___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a566f0 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_18,param1[6],
		             Method_System_Collections_Generic_List_CombatSpellButton__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                       Method_System_Collections_Generic_List_Enumerator_CombatSpellButton__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c69fda;
		    }
		    if (iVar2 == 0) goto code_r0x80c6a030;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_10._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c69fda:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80c6a030:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = param1[6];
		      iVar2 = *(int *)(iVar6 + 0xc);
		      *(undefined4 *)(iVar6 + 0xc) = 0;
		      *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar2,0);
		      }
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      local_4 = 0;
		      if (0 < (int)uVar5) {
		        do {
		          iVar6 = param1[5];
		          uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (param1,0);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          uVar3 = func_ii_6805(iVar6,uVar3,
		                               Method_UnityEngine_Object_Instantiate_CombatSpellButton___);
		          if (*(int *)(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		          }
		          Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___get_Selected
		                    (uVar3,**(undefined4 **)
		                             (Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x5c),
		                     Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__set_Data__
		                    );
		          iVar6 = func_ii_4443(&local_4,0);
		          if (iVar6 == 0) {
		            iVar6 = StringLiteral_5;
		          }
		          UnityEngine_Texture2D___ctor(uVar3,iVar6,0);
		          iVar6 = Method_System_Collections_Generic_List_CombatSpellButton__Add__;
		          iVar2 = param1[6];
		          *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		          uVar7 = *(uint *)(iVar2 + 0xc);
		          if (uVar7 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		            *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		            *(undefined4 *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = uVar3;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		          local_4 = local_4 + 1;
		          bVar1 = 1 < uVar5;
		          uVar5 = uVar5 - 1;
		        } while (bVar1);
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x20b,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x87E6", Offset = "0x87E6", VA = "0x87E6", Slot = "10")]
		protected override void HandleCountChanged()
		{
		/* --- GHIDRA: HandleCountChanged ---
		void Gameplay_Combat_View_Spells_SpellsDisplay__HandleCountChanged(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellButton___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatSpellButton__TypeInfo);
		    DAT_ram_00a566f1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_CombatSpellButton__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,10,Method_System_Collections_Generic_List_CombatSpellButton___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x87E7", Offset = "0x87E7", VA = "0x87E7")]
		public SpellsDisplay()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Spells_SpellsDisplay___ctor(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_FakeCombatSpellData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		    DAT_ram_00a566f2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_FakeCombatSpellData_TypeInfo);
		  Gameplay_Combat_Model_CombatSpellData___ctor(param1_00,0);
		  **(undefined4 **)(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CombatSpellButton _spellPrefab;

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<CombatSpellButton> _currentButtons;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FakeCombatSpellData _fakeData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_gameObject ---
		undefined4 Gameplay_Combat_View_Spells_SpellsDisplay__get_gameObject(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a566ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellButton__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellButton__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		    DAT_ram_00a566ee = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x18),param2_00,
		                         Method_System_Collections_Generic_List_CombatSpellButton__get_Item__);
		      iVar3 = *(int *)(iVar1 + 0x4c);
		      if (*(int *)(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo);
		      }
		      if (iVar3 == **(int **)(Gameplay_Combat_View_Spells_SpellsDisplay_TypeInfo + 0x5c)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

}
