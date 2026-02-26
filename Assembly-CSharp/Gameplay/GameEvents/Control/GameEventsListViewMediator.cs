using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	public class GameEventsListViewMediator : AbstractCozyViewMediator<GameEventsModel, GameEventsEvents, GameEventsController, GameEventsListView>
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0x7FD7", Offset = "0x7FD7", VA = "0x7FD7", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5753b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView___ctor__
		              );
		    DAT_ram_00a5753b = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F72")]
		[Address(RVA = "0x7FD8", Offset = "0x7FD8", VA = "0x7FD8")]
		public GameEventsListViewMediator(GameEventsModel model, GameEventsEvents events, GameEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5753c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Item__
		              );
		    DAT_ram_00a5753c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x3c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(iVar2 + 0x3c),param2_00,
		                         Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Item__
		                        );
		      if (param2 == *(int *)(iVar2 + 0x18)) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        if (DAT_ram_00a57493 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__RemoveAt__
		                    );
		          DAT_ram_00a57493 = '\x01';
		        }
		        iVar2 = *(int *)(iVar1 + 0x20);
		        if (DAT_ram_00a574aa == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		                    );
		          DAT_ram_00a574aa = '\x01';
		        }
		        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		                  (*(undefined4 *)(iVar2 + 0xa0),param2_00,1,0,
		                   Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		                  );
		        UnityEngine_TextCore_Glyph__set_atlasIndex
		                  (*(undefined4 *)(iVar1 + 0x3c),param2_00,
		                   Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__RemoveAt__
		                  );
		        Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(iVar1,param2_00);
		        return;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x7FD9", Offset = "0x7FD9", VA = "0x7FD9")]
		private void HandleEventProcessCompleteEvent(GameEventData evt)
		{
		/* --- GHIDRA: HandleEventProcessCompleteEvent ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleEventProcessCompleteEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5753d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    DAT_ram_00a5753d = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_int___ctor__);
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_GameEventData__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da5565;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_GameEventData__TypeInfo,0);
		code_r0x80da5565:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  while( true ) {
		    piVar9 = local_4;
		    iVar12 = *local_4;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80da5634;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80da5634:
		    DAT_ram_009d3e38 = 0;
		    iVar12 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    piVar9 = local_4;
		    if (DAT_ram_009d3e38 == 1) break;
		    if (iVar12 == 0) {
		      iVar8 = 7;
		      iVar12 = 0;
		      goto code_r0x80da5967;
		    }
		    iVar12 = *local_4;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_GameEventData__TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80da5727;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_GameEventData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80da5769:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80da591a;
		    }
		code_r0x80da5727:
		    iVar12 = 0;
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80da5769;
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80da591a;
		      }
		      if (*(int *)(*(int *)(iVar6 + 0x3c) + 0xc) <= iVar12) break;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80da591a;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,
		                         *(undefined4 *)(iVar6 + 0x3c),iVar12,
		                         Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Item__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      iVar11 = Method_System_Collections_Generic_List_int__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80da591a;
		      }
		      if (*(int *)(iVar7 + 0x18) == iVar8) {
		        *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar2 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		          *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		          *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar12;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x9a,iVar2,iVar12,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80da591a;
		          }
		        }
		      }
		      iVar12 = iVar12 + 1;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80da591a:
		  iVar12 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar12 == iVar8) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar12 = *piVar9;
		    iVar8 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar12;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x80da5967:
		      piVar9 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar11 = *local_4;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80da59df;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80da59df:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar9,puVar3[1]);
		      }
		      if (iVar12 == 0) {
		        if ((iVar8 == 0) ||
		           ((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) &&
		            (((iVar8 != 4 && (iVar8 != 5)) && ((iVar8 != 6 && (iVar8 == 7)))))))) {
		          iVar12 = *param1;
		          uVar5 = (**(code **)((ulonglong)*(uint *)(iVar12 + 0x158) * 4))
		                            (param1,*(undefined4 *)(iVar12 + 0x15c));
		          Gameplay_GameEvents_View_GameEventsListView__ValidateEmptyList(uVar5,iVar2,iVar12);
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar12);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x304,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar5);
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

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x7FDA", Offset = "0x7FDA", VA = "0x7FDA")]
		private void HandleEventsHasBeenDeletedEvent(IList<GameEventData> items)
		{
		/* --- GHIDRA: HandleEventsHasBeenDeletedEvent ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleEventsHasBeenDeletedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5753e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IList_GameEventData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleCurrentReadEventChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventProcessCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventsHasBeenDeletedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleNotViewedEventInCategoryCountChanged__
		              );
		    DAT_ram_00a5753e = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_GameEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleCurrentReadEventChanged__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_GameEventData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x20) = iVar3;
		    uVar1 = System_Action_GameEventData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		  System_Action_int__float___Invoke
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleNotViewedEventInCategoryCountChanged__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_EventCategoriesDic_Types_Category__int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x1c) = iVar3;
		    uVar1 = System_Action_EventCategoriesDic_Types_Category__int__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_GameEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventProcessCompleteEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_GameEventData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x28) = iVar3;
		    uVar1 = System_Action_GameEventData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x34);
		  uVar1 = unnamed_function_1417(System_Action_IList_GameEventData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventsHasBeenDeletedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_IList_GameEventData___TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x34) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_IList_GameEventData___TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x34) = iVar3;
		    uVar1 = System_Action_IList_GameEventData___TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_IList_GameEventData___TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x7FDB", Offset = "0x7FDB", VA = "0x7FDB", Slot = "21")]
		protected override void ResetEvents(GameEventsEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5753f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IList_GameEventData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleCurrentReadEventChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventProcessCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventsHasBeenDeletedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleNotViewedEventInCategoryCountChanged__
		              );
		    DAT_ram_00a5753f = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_GameEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleCurrentReadEventChanged__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_GameEventData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x20) = iVar3;
		    uVar1 = System_Action_GameEventData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		  System_Action_int__float___Invoke
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleNotViewedEventInCategoryCountChanged__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_EventCategoriesDic_Types_Category__int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x1c) = iVar3;
		    uVar1 = System_Action_EventCategoriesDic_Types_Category__int__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_EventCategoriesDic_Types_Category__int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar1 = unnamed_function_1417(System_Action_GameEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventProcessCompleteEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_GameEventData__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x28) = iVar3;
		    uVar1 = System_Action_GameEventData__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_GameEventData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x34);
		  uVar1 = unnamed_function_1417(System_Action_IList_GameEventData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleEventsHasBeenDeletedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_IList_GameEventData___TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x34) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_IList_GameEventData___TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x34) = iVar3;
		    uVar1 = System_Action_IList_GameEventData___TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_IList_GameEventData___TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x7FDC", Offset = "0x7FDC", VA = "0x7FDC", Slot = "22")]
		protected override void SetupEvents(GameEventsEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57540 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickCancelEditEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickDeleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickSelectAllEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleTabBarChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a57540 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleTabBarChangedEvent__
		             ,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0xc0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickSelectAllEvent__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickDeleteEvent__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x2c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickCancelEditEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F77")]
		[Address(RVA = "0x7FDD", Offset = "0x7FDD", VA = "0x7FDD", Slot = "23")]
		protected override void ResetView(GameEventsListView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a57541 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickCancelEditEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickDeleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickSelectAllEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleTabBarChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_EventCategoriesDic__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a57541 = '\x01';
		  }
		  param2_00 = Gameplay_GameEvents_Control_GameEventsListViewMediator__DisplayList
		                        (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x10),0);
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(param2 + 0x1c),param2_00,0);
		  iVar3 = *(int *)(*(int *)(param1 + 8) + 0x38);
		  if (iVar3 == 0) {
		    Gameplay_GameEvents_Control_GameEventsListViewMediator__SetViewState(param1,0);
		    iVar4 = *(int *)(param1 + 8);
		    piVar1 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(param2 + 0x1c),0);
		    if (piVar1 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar1 + 0xb8) <
		           (uint)*(byte *)(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar1 + 100) +
		                   (uint)*(byte *)(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo + 0xb8) * 4 +
		                  -4) != UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo)) {
		        System_Activator__CreateInstance(piVar1,UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo)
		        ;
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(int *)(iVar4 + 0x38) = piVar1[8];
		  }
		  else if (0 < *(int *)(param2_00 + 0xc)) {
		    do {
		      piVar1 = *(int **)(param2_00 + iVar4 * 4 + 0x10);
		      if (piVar1 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar1 + 0xb8) <
		             (uint)*(byte *)(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar1 + 100) +
		                     (uint)*(byte *)(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo + 0xb8) * 4
		                    + -4) != UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo)) {
		          System_Activator__CreateInstance
		                    (piVar1,UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      if (iVar3 == piVar1[8]) {
		        Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                  (*(undefined4 *)(param2 + 0x1c),iVar4,0,0);
		        break;
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != *(int *)(param2_00 + 0xc));
		  }
		  iVar4 = *(int *)(param1 + 8);
		  uVar2 = Gameplay_GameEvents_Model_GameEventsModel___ctor
		                    (iVar4,*(undefined4 *)(iVar4 + 0x38),iVar4);
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__DefineSelectedTabContainsRewards
		            (param1,uVar2,iVar4);
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleTabBarChangedEvent__
		             ,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0xc0);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickSelectAllEvent__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar5,uVar2,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  uVar5 = *(undefined4 *)(*(int *)(param2 + 0x28) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickDeleteEvent__,
		             0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(*(int *)(param2 + 0x2c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleClickCancelEditEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F78")]
		[Address(RVA = "0x7FDE", Offset = "0x7FDE", VA = "0x7FDE", Slot = "24")]
		protected override void SetupView(GameEventsListView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__SetSelectAll(param1,1,param1);
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleCurrentReadEventChanged
		            (param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x7FDF", Offset = "0x7FDF", VA = "0x7FDF")]
		private void HandleClickCancelEditEvent()
		{
		/* --- GHIDRA: HandleClickCancelEditEvent ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleClickCancelEditEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57542 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__get_Count__)
		    ;
		    DAT_ram_00a57542 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Gameplay_GameEvents_Control_GameEventsListViewMediator__Delete
		                    (param1,*(undefined4 *)(iVar1 + 0x3c),param1);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Control_GameEventsListViewMediator__CloseReadWindow
		              (param1,*(undefined4 *)(iVar1 + 0x3c),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x7FE0", Offset = "0x7FE0", VA = "0x7FE0")]
		private void HandleClickDeleteEvent()
		{
		/* --- GHIDRA: HandleClickDeleteEvent ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleClickDeleteEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleCurrentReadEventChanged
		            (param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0x7FE1", Offset = "0x7FE1", VA = "0x7FE1")]
		private void HandleClickSelectAllEvent(bool selected)
		{
		/* --- GHIDRA: HandleClickSelectAllEvent ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleClickSelectAllEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57543 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_EventCategoriesDic__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo);
		    DAT_ram_00a57543 = '\x01';
		  }
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__SetSelectAll(param1,1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x1c),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo + 0xb8) * 4 +
		                -4) != UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00 = Gameplay_GameEvents_Model_GameEventsModel___ctor(param1[2],param1_00[8],param1);
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__DefineSelectedTabContainsRewards
		            (param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0x7FE2", Offset = "0x7FE2", VA = "0x7FE2")]
		private void HandleTabBarChangedEvent()
		{
		/* --- GHIDRA: HandleTabBarChangedEvent ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleTabBarChangedEvent
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  if (*(int *)(iVar2 + 0x34) != param3) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		    *(int *)(iVar2 + 0x34) = param3;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar3 + 0x34),
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0x7FE3", Offset = "0x7FE3", VA = "0x7FE3")]
		private void HandleItemClick(object sender, GameEventData evt)
		{
		/* --- GHIDRA: HandleItemClick ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleItemClick
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57544 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Count__
		              );
		    DAT_ram_00a57544 = '\x01';
		  }
		  iVar1 = param1[6];
		  iVar3 = 1;
		  if (*(char *)(param3 + 0x14) == '\0') {
		    iVar3 = -1;
		  }
		  param1[6] = iVar1 + iVar3;
		  uVar2 = 1;
		  if (0 < iVar1 + iVar3) {
		    uVar2 = 2;
		  }
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__SetSelectAll(param1,uVar2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x24);
		  iVar3 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_7603(uVar2,(uint)(iVar3 == *(int *)(*(int *)(iVar1 + 0x3c) + 0xc)),0);
		  return;
		}
		*/

		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0x7FE4", Offset = "0x7FE4", VA = "0x7FE4")]
		private void HandleItemSelect(object sender, GameEventsListView.GameEventsListItemWrapper wrapper)
		{
		/* --- GHIDRA: HandleItemSelect ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleItemSelect
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57545 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBar_GetItem_EventCategoriesDic___);
		    DAT_ram_00a57545 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = param1[2];
		  if (DAT_ram_00a574c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		    DAT_ram_00a574c3 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(iVar1 + 0x10) + 0xc);
		  if (iVar4 < 1) {
		    param2_01 = 0;
		  }
		  else {
		    param2_00 = 0;
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(iVar1 + 0x10),param2_00,
		                         Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        param2_01 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(iVar1 + 0x10),param2_00,
		                               Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__
		                              );
		        goto code_r0x80da76ea;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar4);
		    param2_01 = 0;
		  }
		code_r0x80da76ea:
		  uVar3 = UI_Tabs_TabBar__GetItem_ByteEnum_
		                    (uVar3,param2_01,Method_UI_Tabs_TabBar_GetItem_EventCategoriesDic___);
		  Core_Extensions_Dict_BossGroupDictExt__GetTitle(uVar3,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0x7FE5", Offset = "0x7FE5", VA = "0x7FE5")]
		private void HandleNotViewedEventInCategoryCountChanged(EventCategoriesDic.Types.Category category, int count)
		{
		/* --- GHIDRA: HandleNotViewedEventInCategoryCountChanged ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleNotViewedEventInCategoryCountChanged
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 0) {
		    Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleOnCloseReadWindow(param1,0);
		    return;
		  }
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__CategoriesToTabs(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0x7FE6", Offset = "0x7FE6", VA = "0x7FE6")]
		private void HandleCurrentReadEventChanged(GameEventData evt)
		{
		/* --- GHIDRA: HandleCurrentReadEventChanged ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleCurrentReadEventChanged
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57546 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Count__
		              );
		    DAT_ram_00a57546 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(iVar1 + 0x3c),
		             Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__MoveNext__
		                          );
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80da6e96;
		        }
		        if (iVar2 == 0) goto code_r0x80da6eec;
		      } while (*(byte *)(local_8._4_4_ + 0x14) == param2);
		      *(char *)(local_8._4_4_ + 0x14) = (char)param2;
		      iVar1 = *(int *)(local_8._4_4_ + 0x10);
		    } while (iVar1 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(iVar1 + 0xc),*(undefined4 *)(iVar1 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80da6e96:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80da6eec:
		      DAT_ram_009d3e38 = 0;
		      if (param2 == 0) {
		        iVar1 = 0;
		      }
		      else {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar1 = *(int *)(*(int *)(iVar1 + 0x3c) + 0xc);
		      }
		      param1[6] = iVar1;
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x309,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x7FE7", Offset = "0x7FE7", VA = "0x7FE7")]
		private void SetSelectAll(bool value)
		{
		/* --- GHIDRA: SetSelectAll ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__SetSelectAll
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57547 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates__get_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates__set_CurrentState__
		              );
		    DAT_ram_00a57547 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(iVar2 + 0x18) == param2) {
		    return;
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar3,param2,
		             Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates__set_CurrentState__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(iVar2 + 0x18) != 2) {
		    param1[6] = 0;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(iVar2 + 0x3c),
		             Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GameEventsListView_GameEventsListItemWrapper__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80da6c3a;
		    }
		    if (iVar4 == 0) goto code_r0x80da6c90;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = local_8._4_4_;
		    iVar5 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) break;
		    bVar1 = *(int *)(iVar5 + 0x18) == 2;
		    if (bVar1 != (bool)*(char *)(iVar4 + 8)) {
		      *(bool *)(iVar4 + 8) = bVar1;
		      iVar2 = *(int *)(iVar4 + 0xc);
		      if (iVar2 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (*(undefined4 *)(iVar2 + 0xc),*(undefined4 *)(iVar2 + 0x20),
		                   *(undefined4 *)(iVar2 + 0x14));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80da6c3a:
		          iVar2 = global_1;
		          iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar2 == iVar4) {
		            piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar4 = *piVar6;
		            DAT_ram_009d3e38 = 0;
		            local_18 = iVar4;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		              if (iVar4 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		code_r0x80da6c90:
		              DAT_ram_009d3e38 = 0;
		              iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		              if (*(int *)(iVar2 + 0x18) != 1) {
		                return;
		              }
		              Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleCurrentReadEventChanged
		                        (param1,0,param1);
		              iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		              func_ii_7603(*(undefined4 *)(iVar2 + 0x24),0,0);
		              return;
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x308,&local_18);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
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
		      }
		    }
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80da6c3a;
		}
		*/

		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x7FE8", Offset = "0x7FE8", VA = "0x7FE8")]
		private void SetViewState(GameEventsListView.GameEventsListViewStates state)
		{
		/* --- GHIDRA: SetViewState ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__SetViewState
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  int param1_00;
		  int iVar6;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a57548 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GameEventData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GameEventData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GameEventData__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameEventData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		    DAT_ram_00a57548 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  param1_00 = *(int *)(param1[2] + 0x10);
		  iVar6 = *(int *)(param1_00 + 0xc);
		  if (0 < iVar6) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,iVar5,
		                         Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) != 0) {
		        uVar2 = Gameplay_GameEvents_Model_GameEventsModel___ctor(param1[2],iVar1,&local_20);
		        System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                  (&local_20,uVar2,
		                   Method_System_Collections_Generic_List_GameEventData__GetEnumerator__);
		        local_8 = local_18;
		        local_10 = CONCAT44(puStack_1c,local_20);
		        local_20 = 0;
		        puStack_1c = &local_10;
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                             Method_System_Collections_Generic_List_Enumerator_GameEventData__MoveNext__
		                            );
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) goto code_r0x80da6677;
		          if (iVar3 == 0) goto code_r0x80da66e5;
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x305,local_8._4_4_,
		                             &local_20);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80da6677;
		        } while (iVar1 == 0);
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c))
		        ;
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x306,
		                     *(undefined4 *)(iVar1 + 0x1c),iVar5,0,0);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		        }
		code_r0x80da6677:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 != iVar3) {
		code_r0x80da67a4:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x307,&local_20);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
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
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x80da67a4;
		        }
		        if (iVar3 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		code_r0x80da66e5:
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar6);
		    iVar5 = *(int *)(param1_00 + 0xc);
		    if (0 < iVar5) {
		      iVar6 = 0;
		      do {
		        iVar1 = System_Linq_Enumerable__ToList_object_
		                          (param1_00,iVar6,
		                           Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		        if ((*(int *)(iVar1 + 0xc) != 0) &&
		           (iVar1 = Gameplay_GameEvents_Model_GameEventsModel___ctor(param1[2],iVar1,&local_20),
		           0 < *(int *)(iVar1 + 0xc))) {
		          iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                    (*(undefined4 *)(iVar5 + 0x1c),iVar6,0,0);
		          return;
		        }
		        iVar6 = iVar6 + 1;
		      } while (iVar6 != iVar5);
		    }
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar5 + 0x1c),0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x7FE9", Offset = "0x7FE9", VA = "0x7FE9")]
		private void DefineSelectedTabContainsRewards()
		{
		/* --- GHIDRA: DefineSelectedTabContainsRewards ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__DefineSelectedTabContainsRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57549 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_EventHandler_GameEventsListView_GameEventsListItemWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_View_GameEventsListView_GameEventsListItemWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleItemClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleItemSelect__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              );
		    DAT_ram_00a57549 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper___ctor__
		            );
		  iVar2 = *(int *)(param2 + 0xc);
		  if (0 < iVar2) {
		    do {
		      param2_00 = unnamed_function_1417
		                            (
		                            Gameplay_GameEvents_View_GameEventsListView_GameEventsListItemWrapper_TypeInfo
		                            );
		      uVar5 = System_Linq_Enumerable__ToList_object_
		                        (param2,iVar1,
		                         Method_System_Collections_Generic_List_GameEventData__get_Item__);
		      *(undefined4 *)(param2_00 + 0x18) = uVar5;
		      uVar5 = unnamed_function_1417(System_EventHandler_GameEventData__TypeInfo);
		      UnityEngine_Object__Instantiate_object_
		                (uVar5,param1,
		                 Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleItemClick__,0);
		      *(undefined4 *)(param2_00 + 0x1c) = uVar5;
		      uVar5 = unnamed_function_1417
		                        (System_EventHandler_GameEventsListView_GameEventsListItemWrapper__TypeInfo)
		      ;
		      UnityEngine_Object__Instantiate_object_
		                (uVar5,param1,
		                 Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleItemSelect__,0)
		      ;
		      *(undefined4 *)(param2_00 + 0x20) = uVar5;
		      iVar4 = 
		      Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar3 = *(uint *)(param1_00 + 0xc);
		      if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      }
		      iVar4 = *(int *)(param2_00 + 0x18);
		      if (*(int *)(iVar4 + 0x10) == 0) {
		        Gameplay_GameEvents_Control_GameEventsController__RequestOpenListView(iVar4,iVar4);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (param1_00 != *(int *)(iVar1 + 0x3c)) {
		    *(int *)(iVar1 + 0x3c) = param1_00;
		    Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(iVar1,iVar1);
		    uVar5 = *(undefined4 *)(iVar1 + 0x3c);
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (DAT_ram_00a574ab == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		                );
		      DAT_ram_00a574ab = '\x01';
		    }
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		              (*(undefined4 *)(iVar1 + 0xa0),uVar5,0,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x7FEA", Offset = "0x7FEA", VA = "0x7FEA")]
		private void DisplayList(List<GameEventData> events)
		{
		/* --- GHIDRA: DisplayList ---
		undefined4
		Gameplay_GameEvents_Control_GameEventsListViewMediator__DisplayList
		          (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int iVar1;
		  int param1_01;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  int param2_00;
		  undefined4 local_4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5754a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_EventCategoriesDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_EventCategoriesDic__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo);
		    DAT_ram_00a5754a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  iVar3 = *(int *)(param2 + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param2,param2_00,
		                         Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) != 0) {
		        param1_01 = unnamed_function_1417(UI_Tabs_TabBarItemData_EventCategoriesDic__TypeInfo);
		        uVar2 = Core_Extensions_Dict_EventActionDicExt__GetLabel(iVar1,0);
		        *(int *)(param1_01 + 0x20) = iVar1;
		        *(undefined4 *)(param1_01 + 0x10) = uVar2;
		        uVar2 = *(undefined4 *)(iVar1 + 0xc);
		        iVar1 = *(int *)(param1 + 8);
		        if (DAT_ram_00a574bc == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                    );
		          DAT_ram_00a574bc = '\x01';
		        }
		        local_4 = 0;
		        iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                          (*(undefined4 *)(iVar1 + 0x2c),uVar2,&local_4,
		                           Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                          );
		        uVar2 = local_4;
		        if (iVar1 == 0) {
		          uVar2 = 0;
		        }
		        Core_Extensions_Dict_BossGroupDictExt__GetTitle(param1_01,uVar2,0);
		        iVar1 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar4 = *(uint *)(param1_00 + 0xc);
		        if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = param1_01;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param1_01,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param1_00,Method_System_Collections_Generic_List_TabBarItemData__ToArray__);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x7FEB", Offset = "0x7FEB", VA = "0x7FEB")]
		private TabBarItemData[] CategoriesToTabs(List<EventCategoriesDic> items)
		{
		/* --- GHIDRA: CategoriesToTabs ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__CategoriesToTabs
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5754b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GameEventsModel__GameEventsEvents__GameEventsController__GameEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_View_GameEventReadViewWindow_GameEventReadViewWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleOnCloseReadWindow__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GameEventReadViewWindow___)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12619);
		    DAT_ram_00a5754b = '\x01';
		  }
		  if (param1[7] == 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		    iVar2 = unnamed_function_1417
		                      (
		                      Gameplay_GameEvents_View_GameEventReadViewWindow_GameEventReadViewWindowArgs_TypeInfo
		                      );
		    UI_Windows_BaseWindowArgs__Dispose(iVar2,0);
		    *(int *)(iVar2 + 0x18) = param1[2];
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    *(undefined4 *)(iVar2 + 0x20) = param2;
		    *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		    iVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                      (uVar1,StringLiteral_12619,iVar2,
		                       Method_UI_Windows_PopupController_Show_GameEventReadViewWindow___);
		    param1[7] = iVar2;
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleOnCloseReadWindow__
		               ,0);
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar2,uVar1,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x7FEC", Offset = "0x7FEC", VA = "0x7FEC")]
		private void ShowReadWindow(GameEventData evt)
		{
		/* --- GHIDRA: ShowReadWindow ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__ShowReadWindow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5754c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleOnCloseReadWindow__
		              );
		    DAT_ram_00a5754c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleOnCloseReadWindow__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x7FED", Offset = "0x7FED", VA = "0x7FED")]
		private void HandleOnCloseReadWindow()
		{
		/* --- GHIDRA: HandleOnCloseReadWindow ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__HandleOnCloseReadWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5754d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleOnCloseReadWindow__
		              );
		    DAT_ram_00a5754d = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  if (iVar1 != 0) {
		    param1_01 = *(undefined4 *)(param1 + 0x1c);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator_HandleOnCloseReadWindow__
		               ,0);
		    UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x1c),0,0);
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x7FEE", Offset = "0x7FEE", VA = "0x7FEE")]
		private void CloseReadWindow()
		{
		/* --- GHIDRA: CloseReadWindow ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__CloseReadWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int iVar3;
		  int param1_02;
		  uint uVar4;
		  
		  if (DAT_ram_00a5754e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsListViewMediator___c__DisplayClass26_0__DeleteWhitConfirm_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Control_GameEventsListViewMediator___c__DisplayClass26_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_8260);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8259);
		    DAT_ram_00a5754e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Control_GameEventsListViewMediator___c__DisplayClass26_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_8260,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_8259,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = UI_Windows_DialogWindow__get_WindowId(0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_GameEvents_Control_GameEventsListViewMediator___c__DisplayClass26_0__DeleteWhitConfirm_b__0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  *(int *)(param1_01 + 0x14) = iVar3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_02 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar4 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x7FEF", Offset = "0x7FEF", VA = "0x7FEF")]
		private void DeleteWhitConfirm(IList<GameEventsListView.GameEventsListItemWrapper> events)
		{
		/* --- GHIDRA: DeleteWhitConfirm ---
		void Gameplay_GameEvents_Control_GameEventsListViewMediator__DeleteWhitConfirm
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a5754f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameEventData__TypeInfo);
		    DAT_ram_00a5754f = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		          == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da792e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                ,0);
		code_r0x80da792e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = unnamed_function_1417(System_Collections_Generic_List_GameEventData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar5,uVar3,Method_System_Collections_Generic_List_GameEventData___ctor__);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		          == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da79c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                ,0);
		code_r0x80da79c8:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar6 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar6,uVar3,Method_System_Collections_Generic_List_int___ctor__);
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		          == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da7a64;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                ,0);
		code_r0x80da7a64:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar7) {
		    do {
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              == *piVar10) {
		            puVar2 = (uint *)(iVar9 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80da7ae9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IList_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                    ,0);
		code_r0x80da7ae9:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar8,puVar2[1]);
		      iVar9 = Method_System_Collections_Generic_List_int__Add__;
		      if (*(char *)(iVar4 + 0x14) != '\0') {
		        *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar6 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		          *(uint *)(iVar6 + 0xc) = uVar1 + 1;
		          *(int *)(*(int *)(iVar6 + 8) + uVar1 * 4 + 0x10) = iVar8;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar6,iVar8,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        }
		        iVar9 = Method_System_Collections_Generic_List_GameEventData__Add__;
		        uVar3 = *(undefined4 *)(iVar4 + 0x18);
		        *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar5 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		          *(uint *)(iVar5 + 0xc) = uVar1 + 1;
		          *(undefined4 *)(*(int *)(iVar5 + 8) + uVar1 * 4 + 0x10) = uVar3;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar5,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      iVar8 = iVar8 + 1;
		    } while (iVar8 != iVar7);
		  }
		  iVar8 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar8 + 0x15c));
		  Gameplay_GameEvents_View_GameEventsListView__ValidateEmptyList(uVar3,iVar6,iVar8);
		  Gameplay_GameEvents_Control_GameEventsListViewMediator__SetSelectAll(param1,1,iVar8);
		  iVar8 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar8 + 0x14c));
		  Gameplay_GameEvents_Control_GameEventsController__SetCurrentReadEvent(uVar3,iVar5,iVar8);
		  return;
		}
		*/

		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x7FF0", Offset = "0x7FF0", VA = "0x7FF0")]
		private void Delete(IList<GameEventsListView.GameEventsListItemWrapper> events)
		{
		/* --- GHIDRA: Delete ---
		int Gameplay_GameEvents_Control_GameEventsListViewMediator__Delete
		              (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a57550 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameEventData__TypeInfo);
		    DAT_ram_00a57550 = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		          == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da70ac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                ,0);
		code_r0x80da70ac:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = unnamed_function_1417(System_Collections_Generic_List_GameEventData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar5,uVar3,Method_System_Collections_Generic_List_GameEventData___ctor__);
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		          == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da7148;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                ,0);
		code_r0x80da7148:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar7) {
		    do {
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              == *piVar9) {
		            puVar2 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80da71cd;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IList_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                                    ,0);
		code_r0x80da71cd:
		      iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar6,puVar2[1]);
		      iVar8 = Method_System_Collections_Generic_List_GameEventData__Add__;
		      if (*(char *)(iVar4 + 0x14) != '\0') {
		        uVar3 = *(undefined4 *)(iVar4 + 0x18);
		        *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar5 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		          *(uint *)(iVar5 + 0xc) = uVar1 + 1;
		          *(undefined4 *)(*(int *)(iVar5 + 8) + uVar1 * 4 + 0x10) = uVar3;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar5,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar7);
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x7FF1", Offset = "0x7FF1", VA = "0x7FF1")]
		private List<GameEventData> GetSelectedEvents(IList<GameEventsListView.GameEventsListItemWrapper> eventsForDelete)
		{
			return null;
		}

		// Token: 0x040019DC RID: 6620
		[Token(Token = "0x40019DC")]
		[FieldOffset(Offset = "0x18")]
		public int CurrentCountSelectedItemsForDelete;

		// Token: 0x040019DD RID: 6621
		[Token(Token = "0x40019DD")]
		[FieldOffset(Offset = "0x1C")]
		private GameEventReadViewWindow _eventReadViewWindow;
	}
}
