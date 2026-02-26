using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	public class CraftFiltersView : MonoBehaviour
	{
		// Token: 0x1400016D RID: 365
		// (add) Token: 0x06003408 RID: 13320 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003409 RID: 13321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400016D")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6003408")]
			[Address(RVA = "0x8435", Offset = "0x8435", VA = "0x8435")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003409")]
			[Address(RVA = "0x8436", Offset = "0x8436", VA = "0x8436")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x8437", Offset = "0x8437", VA = "0x8437")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Craft_View_CraftFiltersView__Init(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param1_00;
		  uint uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57ccf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__get_IsOn__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtikulTypeFilters__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters__Remove__);
		    DAT_ram_00a57ccf = '\x01';
		  }
		  iVar1 = Gameplay_ArtifactComparer_View_SkillSelector_SkillSelectorItemView__get_SkillId
		                    (param2,
		                     Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__get_IsOn__);
		  iVar3 = Method_System_Collections_Generic_List_ArtikulTypeFilters__Add__;
		  param2_00 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = *(int *)(param1 + 0x18);
		  if (iVar1 == 0) {
		    func_ii_4876(param1_00,param2_00,
		                 Method_System_Collections_Generic_List_ArtikulTypeFilters__Remove__);
		  }
		  else {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38)
		                );
		    }
		  }
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x8438", Offset = "0x8438", VA = "0x8438")]
		private void FilterToggleClickedEventHandler(AbstractFilterToggleView<ArtikulTypeFilters> view)
		{
		/* --- GHIDRA: FilterToggleClickedEventHandler ---
		void Gameplay_Craft_View_CraftFiltersView__FilterToggleClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57cd0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		    DAT_ram_00a57cd0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtikulTypeFilters___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340C")]
		[Address(RVA = "0x8439", Offset = "0x8439", VA = "0x8439")]
		public CraftFiltersView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_View_CraftFiltersView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57cd1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftFiltersView___c_TypeInfo);
		    DAT_ram_00a57cd1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001C4D RID: 7245
		[Token(Token = "0x4001C4D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterToggleView _filterPrefab;

		// Token: 0x04001C4E RID: 7246
		[Token(Token = "0x4001C4E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x04001C4F RID: 7247
		[Token(Token = "0x4001C4F")]
		[FieldOffset(Offset = "0x18")]
		public List<ArtikulTypeFilters> ActiveFilters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void Gameplay_Craft_View_CraftFiltersView__add_ChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57ccd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57ccd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ChangedEvent ---
		void Gameplay_Craft_View_CraftFiltersView__remove_ChangedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 uVar8;
		  undefined4 param2_00;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57cce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__add_FilterToggleClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Action_AbstractFilterToggleView_ArtikulTypeFilters___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftFiltersView_FilterToggleClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_FilterToggleView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Craft_View_CraftFiltersView___c__Init_b__6_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftFiltersView___c_TypeInfo);
		    DAT_ram_00a57cce = '\x01';
		  }
		  local_4 = (int *)0x0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e4675b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e4675b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetGameFiledGems(uVar3,0x80,0);
		  if (*(int *)(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo + 0x5c);
		  iVar6 = puVar7[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo);
		      puVar7 = *(undefined4 **)(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo + 0x5c);
		    }
		    uVar8 = *puVar7;
		    iVar6 = unnamed_function_1417(System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,uVar8,Method_Gameplay_Craft_View_CraftFiltersView___c__Init_b__6_0__,0);
		    *(int *)(*(int *)(Gameplay_Craft_View_CraftFiltersView___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar1 = 0;
		  uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar3,iVar6,Method_System_Linq_Enumerable_OrderBy_ArtikulTypeFilters__uint___);
		  piVar5 = (int *)func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e4688a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                System_Collections_Generic_IEnumerable_ArtikulTypeFilters__TypeInfo,
		                                0);
		code_r0x80e4688a:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar7 = (undefined4 *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e4695e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e46c1b:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e46c23;
		    }
		code_r0x80e4695e:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e46c1b;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x80e46c6c;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo == *piVar9) {
		          puVar7 = (undefined4 *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e46a38;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ArtikulTypeFilters__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e46be9:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e46c23;
		    }
		code_r0x80e46a38:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e46be9;
		    uVar8 = *(undefined4 *)(param1 + 0x14);
		    param2_00 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e46c23;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,
		                               uVar8,Method_UnityEngine_Object_Instantiate_FilterToggleView___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e46c23;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar5 + 0xe8),piVar5,uVar3,*(undefined4 *)(*piVar5 + 0xec));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e46c23;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_AbstractFilterToggleView_ArtikulTypeFilters___TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_Craft_View_CraftFiltersView_FilterToggleClickedEventHandler__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x4c,piVar5,uVar3,
		               Method_UI_Filters_AbstractFilterToggleView_ArtikulTypeFilters__add_FilterToggleClickedEvent__
		              );
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e46c23:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar6 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e46c6c:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e46ce4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e46ce4:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x4d,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
