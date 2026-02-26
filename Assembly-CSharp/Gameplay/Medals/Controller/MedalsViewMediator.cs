using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Medals.Controller.Filters;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;
using UI.Tabs;

namespace Gameplay.Medals.Controller
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	public class MedalsViewMediator : AbstractViewMediator<MedalsModel, MedalsEvents, MedalsController, MedalsWindow>
	{
		// Token: 0x0600259F RID: 9631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600259F")]
		[Address(RVA = "0x76E0", Offset = "0x76E0", VA = "0x76E0")]
		public MedalsViewMediator(MedalsModel model, MedalsEvents events, MedalsController controller)
		{
		/* --- GHIDRA: <GetCurrentTabs>b__14_1 ---
		void Gameplay_Medals_Controller_MedalsViewMediator___GetCurrentTabs_b__14_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ddc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		    DAT_ram_00a57ddc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <GetCurrentTabs>b__14_0 ---
		undefined4
		Gameplay_Medals_Controller_MedalsViewMediator___GetCurrentTabs_b__14_0
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x24);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_Controller_MedalsViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57dd1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator_FiltersViewOnChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator_TabBarOnChangeEvent__);
		    DAT_ram_00a57dd1 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalsViewMediator_TabBarOnChangeEvent__,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalsViewMediator_FiltersViewOnChangedEvent__,0);
		    UI_Filters_FiltersView__add_ChangedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0x20) = *(undefined4 *)(param1[2] + 8);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0x24) = *(undefined4 *)(param1[2] + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x44) + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(*(int *)(param1[2] + 0x10) == *(int *)(param1[2] + 8)),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalsViewMediator_TabBarOnChangeEvent__,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalsViewMediator_FiltersViewOnChangedEvent__,0);
		    UI_Filters_FiltersView__get_PriceFilterButton(uVar3,uVar1,0);
		    Gameplay_Medals_Controller_MedalsViewMediator__FiltersViewOnChangedEvent(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 9) != '\0') {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		      uVar1 = Gameplay_Medals_Controller_MedalsViewMediator__FilterMedals(param1,param1);
		      UI_Tabs_TabBar__HandleSelected(uVar3,uVar1,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                (*(undefined4 *)(iVar2 + 0x3c),0,0,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000712 RID: 1810
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000712")]
		public override MedalsWindow View
		{
			[Token(Token = "0x60025A0")]
			[Address(RVA = "0x76E1", Offset = "0x76E1", VA = "0x76E1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x76E2", Offset = "0x76E2", VA = "0x76E2")]
		private void FiltersViewOnChangedEvent()
		{
		/* --- GHIDRA: FiltersViewOnChangedEvent ---
		void Gameplay_Medals_Controller_MedalsViewMediator__FiltersViewOnChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dd2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_BaseWindow_MedalsWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_IMedalFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IMedalFilter__GetEnumerator__
		              );
		    DAT_ram_00a57dd2 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[6],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IMedalFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e62e5e;
		    }
		    if (iVar3 == 0) goto code_r0x80e62eb4;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[6],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__get_Item__
		                              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e62e5e;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e62e5e;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                       *(undefined4 *)(*(int *)(iVar3 + 0x44) + 0x38),uVar2,
		                       Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Medals_Controller_Filters_IMedalFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80e62deb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Medals_Controller_Filters_IMedalFilter_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e62deb:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e62e5e:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e62eb4:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar6 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_MedalsWindowArgs__get_WindowArgs__);
		      if (*(int *)(iVar6 + 0x20) != 0) {
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar6 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_MedalsWindowArgs__get_WindowArgs__);
		        param1[9] = *(int *)(iVar6 + 0x20);
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x97,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0x76E3", Offset = "0x76E3", VA = "0x76E3")]
		private void SetFiltersData()
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0x76E4", Offset = "0x76E4", VA = "0x76E4")]
		private void SelectDefaultTab()
		{
		/* --- GHIDRA: SelectDefaultTab ---
		void Gameplay_Medals_Controller_MedalsViewMediator__SelectDefaultTab
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Medals_Controller_MedalsViewMediator__TabBarOnChangeEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x76E5", Offset = "0x76E5", VA = "0x76E5")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		/* WARNING: Removing unreachable block (ram,0x80e63876) */
		
		void Gameplay_Medals_Controller_MedalsViewMediator__TabBarOnChangeEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  uint uVar9;
		  int iVar10;
		  int *piVar11;
		  int local_28;
		  undefined1 *puStack_24;
		  undefined8 local_20;
		  undefined1 local_18 [8];
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57dd3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalsCategoryData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalsCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_Chest_MedalsCategoryData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalViewClickCallback__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_MedalTabBarItemData__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo);
		    DAT_ram_00a57dd3 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  Gameplay_Medals_Controller_MedalsViewMediator__RedrawCurrentTab(param1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar3 + 0x3c),0);
		  if (piVar4 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar4 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar4 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo + 0xb8) * 4 +
		                -4) != UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo)) {
		      System_Activator__CreateInstance(piVar4,UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = 0;
		  if (*(int *)(piVar4[8] + 8) == 1) {
		    uVar2 = *(undefined4 *)(param1[2] + 0x1c);
		  }
		  else if (*(int *)(piVar4[8] + 8) == 2) {
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(param1[2] + 0x18),piVar4[5],
		                       Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		                      );
		  }
		  uVar2 = Gameplay_Medals_Controller_MedalsViewMediator__PreparePaymentCategoryFilter
		                    (param1,uVar2,&local_4,&local_8,piVar4);
		  iVar3 = unnamed_function_1417(System_Collections_Generic_List_MedalsCategoryData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,Method_System_Collections_Generic_List_MedalsCategoryData___ctor__);
		  uVar5 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_28,uVar5,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		            );
		  local_10 = local_20;
		  local_28 = 0;
		  puStack_24 = local_18;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_18,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		    if (iVar6 == 0) break;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = local_10._4_4_;
		    iVar10 = import::env::invoke_ii
		                       (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                        Gameplay_Inventory_View_Chest_MedalsCategoryData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar2,uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		    *(undefined4 *)(iVar10 + 0xc) = uVar7;
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e63b5f;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		          puVar8 = (undefined4 *)(piVar11[1] * 8 + iVar6 + 0x178);
		          goto code_r0x80e6399e;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                        Core_Gameplay_IGame_TypeInfo,0x17);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e63b25:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		code_r0x80e6399e:
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii(*puVar8,piVar4,puVar8[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e63b25;
		    DAT_ram_009d3e38 = 0;
		    uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x69,uVar7,uVar5,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9d,uVar5,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63b5f;
		    }
		    *(undefined4 *)(iVar10 + 8) = uVar5;
		    iVar6 = Method_System_Collections_Generic_List_MedalsCategoryData__Add__;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar3 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(iVar3 + 8) + uVar9 * 4 + 0x10) = iVar10;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,iVar10,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e63b5f:
		        iVar10 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar10 == iVar6) {
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar10 = *piVar4;
		          iVar6 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_28 = iVar10;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		code_r0x80e63bac:
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 0) {
		              if ((iVar6 == 0) ||
		                 ((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) &&
		                  (((iVar6 != 4 && (iVar6 != 5)) && (iVar6 == 6)))))) {
		                iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                   (param1,*(undefined4 *)(*param1 + 0x15c));
		                uVar5 = *(undefined4 *)(iVar10 + 0x40);
		                uVar2 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		                UnityEngine_UIElements_VisualElement__get_layout
		                          (uVar2,param1,
		                           Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalViewClickCallback__
		                           ,0);
		                Gameplay_Inventory_View_Chest_MedalsGridView__TabBarOnChangeEvent
		                          (uVar5,iVar3,uVar2,(uint)*(byte *)(param1 + 7),0);
		                iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                  (param1,*(undefined4 *)(*param1 + 0x15c));
		                UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		                          (*(undefined4 *)(iVar3 + 0x44),local_4,local_8,0);
		              }
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9e,&local_28);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  iVar6 = 6;
		  iVar10 = local_28;
		  goto code_r0x80e63bac;
		}
		*/

		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x76E6", Offset = "0x76E6", VA = "0x76E6")]
		private void RedrawCurrentTab()
		{
		/* --- GHIDRA: RedrawCurrentTab ---
		void Gameplay_Medals_Controller_MedalsViewMediator__RedrawCurrentTab(int param1,undefined4 param2)
		
		{
		  undefined1 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57dd4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Aggregate_MedalData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_MedalData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_MedalData___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalData__MedalData__MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Medals_Controller_MedalsViewMediator___c__PreparePaymentCategoryFilter_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Medals_Controller_MedalsViewMediator___c__PreparePaymentCategoryFilter_b__12_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26057);
		    DAT_ram_00a57dd4 = '\x01';
		  }
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_26057,0);
		  iVar3 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),uVar2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__
		                    );
		  if (iVar3 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),uVar2,
		                       Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                      );
		    if (*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c);
		    iVar3 = puVar4[2];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		        puVar4 = *(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c)
		        ;
		      }
		      uVar5 = *puVar4;
		      iVar3 = unnamed_function_1417(System_Func_MedalData__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar3,uVar5,
		                 Method_Gameplay_Medals_Controller_MedalsViewMediator___c__PreparePaymentCategoryFilter_b__12_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c) + 8) =
		           iVar3;
		    }
		    uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (uVar2,iVar3,Method_System_Linq_Enumerable_OrderBy_MedalData__uint___);
		    uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_MedalData___);
		    if (*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c);
		    iVar3 = puVar4[3];
		    if (iVar3 == 0) {
		      if (*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo);
		        puVar4 = *(undefined4 **)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c)
		        ;
		      }
		      uVar5 = *puVar4;
		      iVar3 = unnamed_function_1417(System_Func_MedalData__MedalData__MedalData__TypeInfo);
		      System_Threading_Tasks_Task_object___get_Factory
		                (iVar3,uVar5,
		                 Method_Gameplay_Medals_Controller_MedalsViewMediator___c__PreparePaymentCategoryFilter_b__12_1__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Medals_Controller_MedalsViewMediator___c_TypeInfo + 0x5c) + 0xc) =
		           iVar3;
		    }
		    iVar3 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                      (uVar2,iVar3,Method_System_Linq_Enumerable_Aggregate_MedalData___);
		    iVar6 = *(int *)(param1 + 0x20);
		    *(undefined4 *)(iVar6 + 8) = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 8) + 0x14) + 0xc);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Int32Enum__object___Dispose
		                      (iVar3,0);
		    *(undefined4 *)(iVar6 + 0xc) = uVar2;
		    uVar1 = 1;
		  }
		  *(undefined1 *)(*(int *)(*(int *)(param1 + 0x20) + 0x10) + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x76E7", Offset = "0x76E7", VA = "0x76E7")]
		private void PreparePaymentCategoryFilter()
		{
		/* --- GHIDRA: PreparePaymentCategoryFilter ---
		/* WARNING: Removing unreachable block (ram,0x80e6440a) */
		/* WARNING: Removing unreachable block (ram,0x80e64795) */
		
		undefined4
		Gameplay_Medals_Controller_MedalsViewMediator__PreparePaymentCategoryFilter
		          (int param1,undefined4 param2,int *param3,int *param4,undefined4 param5)
		
		{
		  undefined4 param3_00;
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int local_50;
		  undefined8 *local_4c;
		  int local_48;
		  undefined1 *local_44;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_MedalData___set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_MedalData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_Filters_IMedalFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IMedalFilter__GetEnumerator__
		              );
		    DAT_ram_00a57dd5 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__List_MedalData___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,Method_System_Collections_Generic_Dictionary_uint__List_MedalData____ctor__);
		  *param3 = 0;
		  *param4 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Keys__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_40,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_MedalData___GetEnumerator__
		            );
		  local_8 = local_38;
		  local_48 = 0;
		  local_44 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_MedalData___MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80e64839;
		    }
		    iVar8 = local_48;
		    if (iVar3 == 0) goto code_r0x80e64880;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = local_8._4_4_;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param2,local_8._4_4_,
		                       Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80e64839;
		    }
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_40,uVar2,Method_System_Collections_Generic_List_MedalData__GetEnumerator__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80e64839;
		    }
		    local_18 = local_38;
		    local_20 = CONCAT44(puStack_3c,local_40);
		    local_50 = 0;
		    local_4c = &local_20;
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                         Method_System_Collections_Generic_List_Enumerator_MedalData__MoveNext__);
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar8 == 0) goto code_r0x80e64763;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = local_18._4_4_;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9f,
		                         *(undefined4 *)(param1 + 0x18),
		                         Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMedalFilter__get_Values__
		                        );
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_40,uVar2,
		                 Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__IMedalFilter__GetEnumerator__
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		      local_28 = local_38;
		      local_30 = CONCAT44(puStack_3c,local_40);
		      local_40 = 0;
		      puStack_3c = &local_30;
		      do {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_30,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__IMedalFilter__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e64382:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar8 == iVar6) {
		            piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		            local_40 = *piVar7;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_v(0x123);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            uVar4 = 1;
		            if (iVar8 != 1) goto code_r0x80e643d8;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar8 = global_1;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa4,&local_40);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 1) goto code_r0x80e648d5;
		          goto code_r0x80e6471c;
		        }
		        if (uVar4 == 0) break;
		        piVar7 = local_28._4_4_;
		        iVar8 = *local_28._4_4_;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (Gameplay_Medals_Controller_Filters_IMedalFilter_TypeInfo == *piVar9) {
		              puVar5 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0xd0);
		              goto code_r0x80e64333;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_28._4_4_,
		                            Gameplay_Medals_Controller_Filters_IMedalFilter_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e64382;
		code_r0x80e64333:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii(*puVar5,piVar7,iVar3,puVar5[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e64382;
		      } while (iVar8 != 0);
		      uVar4 = uVar4 ^ 1;
		code_r0x80e643d8:
		      if (local_40 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_40);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80e648ec;
		        break;
		      }
		      uVar1 = 1;
		      iVar8 = *(int *)(param1 + 0x20);
		      if (((*(char *)(*(int *)(iVar8 + 0x10) + 0x10) != '\0') && (*(int *)(iVar3 + 0x10) == 0)) &&
		         (*(int *)(*(int *)(*(int *)(iVar3 + 8) + 0x14) + 0xc) == *(int *)(iVar8 + 8))) {
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa3,iVar3,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        uVar1 = (uint)(uVar1 <= *(uint *)(iVar8 + 0xc));
		      }
		      if ((uVar1 & uVar4) != 0) {
		        iVar8 = *(int *)(param1 + 0x24);
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (*(undefined4 *)(iVar8 + 0xc),*(undefined4 *)(iVar8 + 0x20),iVar3,
		                           *(undefined4 *)(iVar8 + 0x14));
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar8 != 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,param1_00,
		                             param3_00,
		                             Method_System_Collections_Generic_Dictionary_uint__List_MedalData___ContainsKey__
		                            );
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar8 == 0) {
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Collections_Generic_List_MedalData__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar2,
		                       Method_System_Collections_Generic_List_MedalData___ctor__);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param1_00,param3_00,
		                       uVar2,
		                       Method_System_Collections_Generic_Dictionary_uint__List_MedalData___set_Item__
		                      );
		            if (DAT_ram_009d3e38 == 1) break;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,param1_00,
		                             param3_00,
		                             Method_System_Collections_Generic_Dictionary_uint__List_MedalData___get_Item__
		                            );
		          iVar8 = Method_System_Collections_Generic_List_MedalData__Add__;
		          if (DAT_ram_009d3e38 == 1) break;
		          *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		          uVar4 = *(uint *)(iVar6 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		            *(uint *)(iVar6 + 0xc) = uVar4 + 1;
		            *(int *)(*(int *)(iVar6 + 8) + uVar4 * 4 + 0x10) = iVar3;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,iVar3,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		            if (DAT_ram_009d3e38 == 1) break;
		          }
		          *param3 = *(int *)(*(int *)(iVar3 + 0xc) + 0x10) + *param3;
		          *param4 = *(int *)(*(int *)(*(int *)(iVar3 + 8) + 8) + 0x10) + *param4;
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar8 = global_1;
		code_r0x80e6471c:
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar3 != iVar8) {
		code_r0x80e647fa:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa5,&local_50);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) goto code_r0x80e648d5;
		      goto code_r0x80e64839;
		    }
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_50 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x80e647fa;
		    }
		code_r0x80e64763:
		    if (local_50 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_50);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		code_r0x80e648ec:
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		code_r0x80e64839:
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar8) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar8 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_48 = iVar8;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		code_r0x80e64880:
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 0) {
		            return param1_00;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa6,&local_48);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        import::env::__resumeException(uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e648d5:
		      DAT_ram_009d3e38 = 0;
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x76E8", Offset = "0x76E8", VA = "0x76E8")]
		private Dictionary<uint, List<MedalData>> FilterMedals(Dictionary<uint, List<MedalData>> rawData, out int achievedCount, out int totalCount)
		{
		/* --- GHIDRA: FilterMedals ---
		/* WARNING: Removing unreachable block (ram,0x80e6332e) */
		/* WARNING: Removing unreachable block (ram,0x80e63297) */
		
		int Gameplay_Medals_Controller_MedalsViewMediator__FilterMedals(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dd6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Any_KeyValuePair_uint__List_MedalData_____);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__Dictionary_uint__List_MedalData____Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__Dictionary_uint__List_MedalData____MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__Dictionary_uint__List_MedalData____get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_uint__List_MedalData____bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__Dictionary_uint__List_MedalData____GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Insert__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalTabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator__GetCurrentTabs_b__14_0__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_MedalTabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_MedalTabBarItemData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9110);
		    DAT_ram_00a57dd6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x18),
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_uint__Dictionary_uint__List_MedalData____GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,local_10,
		                         Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__Dictionary_uint__List_MedalData____MoveNext__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e63430;
		      }
		      iVar7 = local_20;
		      if (iVar3 == 0) goto code_r0x80e63479;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = local_8._4_4_;
		      uVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                         *(undefined4 *)(*(int *)(param1 + 8) + 0x18),local_8._4_4_,
		                         Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__List_MedalData____get_Item__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e63430;
		      }
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Func_KeyValuePair_uint__List_MedalData____bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e6338d:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e63430;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x98,param2_00,param1,
		                 Method_Gameplay_Medals_Controller_MedalsViewMediator__GetCurrentTabs_b__14_0__,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e6338d;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x99,uVar4,param2_00,
		                         Method_System_Linq_Enumerable_Any_KeyValuePair_uint__List_MedalData_____);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e63430;
		      }
		    } while (iVar3 == 0);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63430;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6a,uVar4,uVar2,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63430;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63430;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9a,uVar4,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63430;
		    }
		    *(undefined4 *)(iVar7 + 0x14) = uVar2;
		    *(undefined4 *)(iVar7 + 0x10) = uVar4;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Medals_Model_MedalTabBarItemData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e63430;
		    }
		    *(undefined4 *)(iVar3 + 8) = 2;
		    *(int *)(iVar7 + 0x20) = iVar3;
		    iVar3 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar1 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar6 + 1;
		      *(int *)(*(int *)(iVar1 + 8) + uVar6 * 4 + 0x10) = iVar7;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,iVar7,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e63430:
		        iVar7 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar3) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar7 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x80e63479:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            iVar7 = unnamed_function_1417(UI_Tabs_TabBarItemData_MedalTabBarItemData__TypeInfo);
		            if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_GameLocalization_TypeInfo);
		            }
		            uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9110,1,0,1,0,0,0,0);
		            *(undefined4 *)(iVar7 + 0x14) = 0;
		            *(undefined4 *)(iVar7 + 0x10) = uVar2;
		            iVar3 = unnamed_function_1417(Gameplay_Medals_Model_MedalTabBarItemData_TypeInfo);
		            *(undefined4 *)(iVar3 + 8) = 1;
		            *(int *)(iVar7 + 0x20) = iVar3;
		            System_Collections_Generic_List_IntPtr___AddWithResize
		                      (iVar1,0,iVar7,Method_System_Collections_Generic_List_TabBarItemData__Insert__
		                      );
		            return iVar1;
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9b,&local_20);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          import::env::__resumeException(uVar2);
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
		    }
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x76E9", Offset = "0x76E9", VA = "0x76E9")]
		private List<TabBarItemData> GetCurrentTabs()
		{
		/* --- GHIDRA: GetCurrentTabs ---
		void Gameplay_Medals_Controller_MedalsViewMediator__GetCurrentTabs
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param4;
		  int param2_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57dd7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57dd7 = '\x01';
		  }
		  param2_00 = *(int *)(param2 + 0x48);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x130);
		        goto code_r0x80e64a8f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e64a8f:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param3_00 = *(undefined4 *)(param2_00 + 0x10);
		  param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                     (param1,*(undefined4 *)(*param1 + 0x14c));
		  Core_Gameplay_Managers_MedalsManager__ShowMedalInfoWindow(param1_00,param2_00,param3_00,param4,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0x76EA", Offset = "0x76EA", VA = "0x76EA")]
		private void MedalViewClickCallback(MedalView view)
		{
		/* --- GHIDRA: MedalViewClickCallback ---
		void Gameplay_Medals_Controller_MedalsViewMediator__MedalViewClickCallback
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57dd8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator_InitEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalRemovedEventHandler__);
		    DAT_ram_00a57dd8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Medals_Controller_MedalsViewMediator_InitEventHandler__,
		               0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417
		                      (Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo);
		    Gameplay_Medals_Events_MedalsEvents___ctor
		              (uVar3,param1,
		               Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalChangedEventHandler__,
		               param1);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalRemovedEventHandler__,0)
		    ;
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Medals_Controller_MedalsViewMediator_InitEventHandler__,
		               0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417
		                      (Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo);
		    Gameplay_Medals_Events_MedalsEvents___ctor
		              (uVar3,param1,
		               Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalChangedEventHandler__,
		               param1);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Medals_Controller_MedalsViewMediator_MedalRemovedEventHandler__,0)
		    ;
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar5;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000713 RID: 1811
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000713")]
		public override MedalsEvents Events
		{
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x76EB", Offset = "0x76EB", VA = "0x76EB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x76EC", Offset = "0x76EC", VA = "0x76EC")]
		private void MedalChangedEventHandler(MedalData medalData, uint medalId)
		{
		/* --- GHIDRA: MedalChangedEventHandler ---
		void Gameplay_Medals_Controller_MedalsViewMediator__MedalChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57dd9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    DAT_ram_00a57dd9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  iVar2 = *(int *)(iVar1 + 0x14);
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0x20),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		  if (iVar2 == *(int *)(*(int *)(*(int *)(iVar1 + 8) + 0x1c) + 0xc)) {
		    Gameplay_Medals_Controller_MedalsViewMediator__TabBarOnChangeEvent(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AC")]
		[Address(RVA = "0x76ED", Offset = "0x76ED", VA = "0x76ED")]
		private void MedalRemovedEventHandler(uint medalId)
		{
		/* --- GHIDRA: MedalRemovedEventHandler ---
		void Gameplay_Medals_Controller_MedalsViewMediator__MedalRemovedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  param2_00 = Gameplay_Medals_Controller_MedalsViewMediator__FilterMedals(param1,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x76EE", Offset = "0x76EE", VA = "0x76EE")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Medals_Controller_MedalsViewMediator__InitEventHandler(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57dda == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__Dispose__
		              );
		    DAT_ram_00a57dda = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalsWindow__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x76EF", Offset = "0x76EF", VA = "0x76EF", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4
		Gameplay_Medals_Controller_MedalsViewMediator__Dispose
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ddb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_MedalData___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_uint__List_MedalData___get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalsViewMediator__GetCurrentTabs_b__14_1__);
		    DAT_ram_00a57ddb = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 4);
		  uVar1 = unnamed_function_1417(System_Func_MedalData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_Medals_Controller_MedalsViewMediator__GetCurrentTabs_b__14_1__,0);
		  uVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_Any_MedalData___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04001493 RID: 5267
		[Token(Token = "0x4001493")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, IMedalFilter> _filters;

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0x1C")]
		private bool _saleEnabled;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0x20")]
		private PaymentCategoryFilter _paymentCategoryFilter;

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0x24")]
		private Predicate<MedalData> _customFilter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Medals_Controller_MedalsViewMediator__set_View(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Medals_Controller_MedalsViewMediator__FiltersViewOnChangedEvent(param1,param1);
		  Gameplay_Medals_Controller_MedalsViewMediator__TabBarOnChangeEvent(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Medals_Controller_MedalsViewMediator__set_Events
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Medals_Controller_MedalsViewMediator__TabBarOnChangeEvent(param1,param1);
		  return;
		}
		*/

}
