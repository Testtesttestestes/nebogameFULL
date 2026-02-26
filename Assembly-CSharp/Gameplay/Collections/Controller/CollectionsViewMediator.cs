using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Controller.Filters;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;

namespace Gameplay.Collections.Controller
{
	// Token: 0x020009E8 RID: 2536
	[Token(Token = "0x20009E8")]
	public class CollectionsViewMediator : AbstractViewMediator<CollectionsModel, CollectionsEvents, CollectionsController, CollectionsWindow>
	{
		// Token: 0x06003C95 RID: 15509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x8B5C", Offset = "0x8B5C", VA = "0x8B5C")]
		public CollectionsViewMediator(CollectionsModel model, CollectionsEvents events, CollectionsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_Controller_CollectionsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57ee0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Controller_CollectionsViewMediator_InitEventHandler__);
		    DAT_ram_00a57ee0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_InitEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_InitEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000BEE RID: 3054
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEE")]
		public override CollectionsEvents Events
		{
			[Token(Token = "0x6003C96")]
			[Address(RVA = "0x8B5D", Offset = "0x8B5D", VA = "0x8B5D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (set) Token: 0x06003C97 RID: 15511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEF")]
		public override CollectionsWindow View
		{
			[Token(Token = "0x6003C97")]
			[Address(RVA = "0x8B5E", Offset = "0x8B5E", VA = "0x8B5E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x8B5F", Offset = "0x8B5F", VA = "0x8B5F")]
		private void FrescoButtonClickedHandler()
		{
		/* --- GHIDRA: FrescoButtonClickedHandler ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__FrescoButtonClickedHandler
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
		  
		  if (DAT_ram_00a57ee3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_Filters_ICollectionFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__ICollectionFilter__GetEnumerator__
		              );
		    DAT_ram_00a57ee3 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[6],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__ICollectionFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e7bf30;
		    }
		    if (iVar3 == 0) goto code_r0x80e7bf86;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[6],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__get_Item__
		                              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e7bf30;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e7bf30;
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
		        if (Gameplay_Collections_Controller_Filters_ICollectionFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x80e7bebd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Collections_Controller_Filters_ICollectionFilter_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e7bebd:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e7bf30:
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
		code_r0x80e7bf86:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar6 = func_ii_8093(uVar2,
		                           Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                          );
		      if (*(int *)(iVar6 + 0x28) != 0) {
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar6 = func_ii_8093(uVar2,
		                             Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                            );
		        param1[7] = *(int *)(iVar6 + 0x28);
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xdc,&local_18);
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

		// Token: 0x06003C99 RID: 15513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x8B60", Offset = "0x8B60", VA = "0x8B60")]
		private void SetFiltersData()
		{
		/* --- GHIDRA: SetFiltersData ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__SetFiltersData
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57ee4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__get_Count__
		              );
		    DAT_ram_00a57ee4 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x40),0);
		  uVar3 = *(undefined4 *)(iVar1 + 0x14);
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1[2] + 0x1c),uVar3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    local_4 = *(undefined4 *)(param1[2] + 0x28);
		  }
		  iVar1 = Gameplay_Collections_Controller_CollectionsViewMediator__RedrawCurrentTab
		                    (param1,local_4,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Collections_View_CollectionsWindow__OnClose(param1_00,iVar1,param1);
		  uVar3 = Gameplay_Collections_Model_CollectionsModel__DetermineCollectionRank
		                    (param1[2],iVar1,uVar3,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		            (*(undefined4 *)(iVar2 + 0x44),uVar3,*(undefined4 *)(iVar1 + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x8B61", Offset = "0x8B61", VA = "0x8B61")]
		private void RedrawCurrentTab()
		{
		/* --- GHIDRA: RedrawCurrentTab ---
		/* WARNING: Removing unreachable block (ram,0x80e7cbcf) */
		
		int Gameplay_Collections_Controller_CollectionsViewMediator__RedrawCurrentTab
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int *piVar11;
		  int iVar12;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  int local_20;
		  int **local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a57ee5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_Filters_ICollectionFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__ICollectionFilter__GetEnumerator__
		              );
		    DAT_ram_00a57ee5 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar4 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar4,
		             Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs___ctor__
		            );
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_CollectionListElement_CollectionListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e7c754;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_CollectionListElement_CollectionListElementArgs__TypeInfo
		                                ,0);
		code_r0x80e7c754:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  local_20 = 0;
		  local_1c = &local_4;
		code_r0x80e7c779:
		  do {
		    do {
		      do {
		        piVar10 = local_4;
		        iVar12 = *local_4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar6 = (undefined4 *)(iVar12 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e7c823;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7c867:
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80e7cd64;
		        }
		code_r0x80e7c823:
		        DAT_ram_009d3e38 = 0;
		        iVar12 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		        piVar10 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e7c867;
		        if (iVar12 == 0) goto code_r0x80e7cdab;
		        iVar12 = *local_4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_CollectionListElement_CollectionListElementArgs__TypeInfo
		                == *piVar11) {
		              puVar6 = (undefined4 *)(iVar12 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x80e7c912;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_CollectionListElement_CollectionListElementArgs__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7c9e9:
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80e7cd64;
		        }
		code_r0x80e7c912:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e7c9e9;
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x9f,
		                           *(undefined4 *)(param1 + 0x18),
		                           Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__get_Values__
		                          );
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80e7cd64;
		        }
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                  (&local_30,uVar7,
		                   Method_System_Collections_Generic_Dictionary_ValueCollection_FilterInfo_FilterType__ICollectionFilter__GetEnumerator__
		                  );
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80e7cd64;
		        }
		        local_10 = local_28;
		        local_18 = CONCAT44(puStack_2c,local_30);
		        local_30 = 0;
		        puStack_2c = &local_18;
		        do {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_18,
		                             Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_FilterInfo_FilterType__ICollectionFilter__MoveNext__
		                            );
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7cb47:
		            DAT_ram_009d3e38 = 0;
		            uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar12 = global_1;
		            iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar12 == iVar8) {
		              piVar10 = (int *)import::env::__cxa_begin_catch(uVar7);
		              iVar8 = *piVar10;
		              iVar3 = 0;
		              DAT_ram_009d3e38 = 0;
		              local_30 = iVar8;
		              import::env::invoke_v(0x123);
		              iVar12 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              uVar2 = 1;
		              if (iVar12 != 1) goto code_r0x80e7cba1;
		              uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar12 = global_1;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xde,&local_30)
		            ;
		            iVar9 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar9 != 1) goto code_r0x80e7cd64;
		            goto code_r0x80e7ce7e;
		          }
		          if (uVar2 == 0) break;
		          uVar7 = *(undefined4 *)(iVar9 + 0xc);
		          piVar10 = local_10._4_4_;
		          iVar12 = *local_10._4_4_;
		          if (*(ushort *)(iVar12 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		              if (Gameplay_Collections_Controller_Filters_ICollectionFilter_TypeInfo == *piVar11) {
		                puVar6 = (undefined4 *)(piVar11[1] * 8 + iVar12 + 0xd0);
		                goto code_r0x80e7caf0;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar6 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                              Gameplay_Collections_Controller_Filters_ICollectionFilter_TypeInfo,2);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e7cb47;
		code_r0x80e7caf0:
		          DAT_ram_009d3e38 = 0;
		          iVar12 = import::env::invoke_iiii(*puVar6,piVar10,uVar7,puVar6[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e7cb47;
		        } while (iVar12 != 0);
		        uVar2 = uVar2 ^ 1;
		        iVar3 = 6;
		        iVar8 = 0;
		code_r0x80e7cba1:
		        if (iVar8 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar8);
		          iVar12 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar12 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar12 = global_1;
		          goto code_r0x80e7cd64;
		        }
		        if ((iVar3 != 0) &&
		           ((((iVar3 == 1 || (iVar3 == 2)) || (iVar3 == 3)) ||
		            (((iVar3 == 4 || (iVar3 == 5)) || (iVar3 != 6)))))) goto code_r0x80e7cdab;
		      } while (uVar2 == 0);
		      iVar12 = *(int *)(param1 + 0x1c);
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (*(undefined4 *)(iVar12 + 0xc),*(undefined4 *)(iVar12 + 0x20),
		                         *(undefined4 *)(iVar9 + 0xc),*(undefined4 *)(iVar12 + 0x14));
		      iVar8 = DAT_ram_009d3e38;
		      iVar12 = 
		      Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar12 = global_1;
		        goto code_r0x80e7cd64;
		      }
		    } while (iVar3 == 0);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar4 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar2 * 4 + 0x10) = iVar9;
		      goto code_r0x80e7c779;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar9,
		               *(undefined4 *)(*(int *)(*(int *)(iVar12 + 0x10) + 0x60) + 0x38));
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar12 != 1);
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar12 = global_1;
		code_r0x80e7cd64:
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar12) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar7);
		    local_20 = *piVar10;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 != 1) {
		code_r0x80e7cdab:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_1c;
		      if (piVar10 != (int *)0x0) {
		        uVar2 = 0;
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8)) {
		              puVar5 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80e7ce26;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80e7ce26:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		      }
		      if (local_20 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_20);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return iVar4;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xdf,&local_20);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    import::env::__resumeException(uVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80e7ce7e:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x8B62", Offset = "0x8B62", VA = "0x8B62")]
		private List<CollectionListElement.CollectionListElementArgs> FilterCollections(IList<CollectionListElement.CollectionListElementArgs> rawData)
		{
		/* --- GHIDRA: FilterCollections ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__FilterCollections
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Collections_Controller_CollectionsViewMediator__FrescoButtonClickedHandler(param1,param1)
		  ;
		  Gameplay_Collections_Controller_CollectionsViewMediator__SetFiltersData(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0x8B63", Offset = "0x8B63", VA = "0x8B63")]
		private void FiltersViewChangedEventHandler()
		{
		/* --- GHIDRA: FiltersViewChangedEventHandler ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__FiltersViewChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57ee6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Action_CollectionListElement_CollectionListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_ShowNextRankEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__GetEnumerator__
		              );
		    DAT_ram_00a57ee6 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1[2] + 0x28),
		             Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e7c1ab:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          if (iVar1 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80e7c201:
		          DAT_ram_009d3e38 = 0;
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                    (*(undefined4 *)(iVar4 + 0x40),0,0,0);
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xdd,&local_18);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
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
		    if (iVar1 == 0) goto code_r0x80e7c201;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = local_8._4_4_;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_CollectionListElement_CollectionListElementArgs__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7c199:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e7c1ab;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_ShowNextRankEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e7c199;
		    *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  } while( true );
		}
		*/

		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x8B64", Offset = "0x8B64", VA = "0x8B64")]
		private void InitEventHandler()
		{
		/* --- GHIDRA: InitEventHandler ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__InitEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param2 + 0xc);
		  param3_00 = Core_Data_CollectionData__get_MaxRank(param1_00,0);
		  Gameplay_Collections_Controller_CollectionsViewMediator__ShowNextRankEventHandler
		            (param1,param1_00,param3_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9E")]
		[Address(RVA = "0x8B65", Offset = "0x8B65", VA = "0x8B65")]
		private void ShowNextRankEventHandler(CollectionListElement.CollectionListElementArgs args)
		{
		/* --- GHIDRA: ShowNextRankEventHandler ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__ShowNextRankEventHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ee7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionInfoWindow_CollectionInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CollectionInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12599);
		    DAT_ram_00a57ee7 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar3 = *(undefined4 *)(param1[2] + 8);
		  uVar2 = System_Linq_Enumerable__FirstOrDefault_uint_(param2,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Collections_View_CollectionInfoWindow_CollectionInfoWindowArgs_TypeInfo
		                        );
		  UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x24) = param3;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  *(undefined4 *)(param1_00 + 0x18) = uVar3;
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12599,param1_00,
		             Method_UI_Windows_PopupController_Show_CollectionInfoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x8B66", Offset = "0x8B66", VA = "0x8B66")]
		private void ShowCollectionInfoWindow(CollectionData data, uint rank)
		{
		/* --- GHIDRA: ShowCollectionInfoWindow ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__ShowCollectionInfoWindow
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57ee8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__get_Model__
		              );
		    DAT_ram_00a57ee8 = '\x01';
		  }
		  param1[7] = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (*(char *)(iVar1 + 9) != '\0') {
		    Gameplay_Collections_Model_CollectionsModel__PopulateModel(param1[2],param1);
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x8B67", Offset = "0x8B67", VA = "0x8B67", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__Dispose(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ee9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo);
		    DAT_ram_00a57ee9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400217D RID: 8573
		[Token(Token = "0x400217D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, ICollectionFilter> _filters;

		// Token: 0x0400217E RID: 8574
		[Token(Token = "0x400217E")]
		[FieldOffset(Offset = "0x1C")]
		private Predicate<CollectionData> _customFilter;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ee1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_FiltersViewChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_FrescoButtonClickedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Controller_CollectionsViewMediator_RedrawCurrentTab__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57ee1 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_RedrawCurrentTab__,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_FiltersViewChangedEventHandler__
		               ,0);
		    UI_Filters_FiltersView__add_ChangedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_FrescoButtonClickedHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_RedrawCurrentTab__,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_FiltersViewChangedEventHandler__
		               ,0);
		    UI_Filters_FiltersView__get_PriceFilterButton(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Collections_Controller_CollectionsViewMediator_FrescoButtonClickedHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = UI_Filters_FiltersView__get_FiltersInfoDictionary(*(undefined4 *)(iVar2 + 0x44),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)(*(int *)(param1[2] + 8) == *(int *)(param1[2] + 0x14)),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    uVar1 = Gameplay_Collections_Model_CollectionsModel___ctor(param1[2],param1);
		    UI_Tabs_TabBar__HandleSelected(uVar3,uVar1,0);
		    Gameplay_Collections_Controller_CollectionsViewMediator__FrescoButtonClickedHandler
		              (param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 9) != '\0') {
		      Gameplay_Collections_Controller_CollectionsViewMediator__FiltersViewChangedEventHandler
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Collections_Controller_CollectionsViewMediator__set_View(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param3;
		  
		  if (DAT_ram_00a57ee2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_FrescoWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_FrescoWindow_FrescoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_FrescoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_HasOpenWindow_FrescoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_FrescoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12618);
		    DAT_ram_00a57ee2 = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80e7c37f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e7c37f:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x80e7c401;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x80e7c401:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = UI_Windows_PopupController__GetWindows_object_
		                    (param1_00,Method_UI_Windows_PopupController_HasOpenWindow_FrescoWindow___);
		  if (iVar4 != 0) {
		    uVar5 = UI_Windows_PopupController__GetLastWindow_object_
		                      (param1_00,Method_UI_Windows_PopupController_GetWindows_FrescoWindow___);
		    uVar5 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (uVar5,Method_System_Linq_Enumerable_Last_FrescoWindow___);
		    UI_Windows_PopupController__CloseAll(param1_00,uVar5,0);
		    return;
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 8) + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a8);
		        goto code_r0x80e7c4b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80e7c4b8:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  param3 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  iVar4 = unnamed_function_1417(Gameplay_Fresco_View_FrescoWindow_FrescoWindowArgs_TypeInfo);
		  Core_GameResources_BaseGameResourcesFabric_object__object___get_TotalResourceCount
		            (iVar4,uVar5,param3,0);
		  *(undefined4 *)(iVar4 + 0x10) = 0xb;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12618,iVar4,
		             Method_UI_Windows_PopupController_Show_FrescoWindow___);
		  DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (param1_00,1,Method_UI_Windows_PopupController_Close_CollectionsWindow___);
		  return;
		}
		*/

}
