using System;
using Core.Application;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.View.EntryPoint;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.Control.EntryPoint
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public class GdEventsIndexEpViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, GdEventsIndexEpView>
	{
		// Token: 0x06002D74 RID: 11636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x7DF2", Offset = "0x7DF2", VA = "0x7DF2", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a57479 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView___ctor__
		              );
		    DAT_ram_00a57479 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param3,param4,param5,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x7DF3", Offset = "0x7DF3", VA = "0x7DF3")]
		public GdEventsIndexEpViewMediator(IApp app, GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5747a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventData__GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleCategoriesContentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleCurrentEventChangedEvent__
		              );
		    DAT_ram_00a5747a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleCategoriesContentChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_GdEventData__GdEventData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleCurrentEventChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_GdEventData__GdEventData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_GdEventData__GdEventData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_GdEventData__GdEventData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_GdEventData__GdEventData__TypeInfo);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleCategoriesContentChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_GdEventData__GdEventData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleCurrentEventChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_GdEventData__GdEventData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_GdEventData__GdEventData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar5;
		    uVar3 = System_Action_GdEventData__GdEventData__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_GdEventData__GdEventData__TypeInfo);
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

		// Token: 0x170008B8 RID: 2232
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B8")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D76")]
			[Address(RVA = "0x7DF4", Offset = "0x7DF4", VA = "0x7DF4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B9")]
		public override GdEventsIndexEpView View
		{
			[Token(Token = "0x6002D77")]
			[Address(RVA = "0x7DF5", Offset = "0x7DF5", VA = "0x7DF5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x7DF6", Offset = "0x7DF6", VA = "0x7DF6")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5747d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleEpClickEvent__
		              );
		    DAT_ram_00a5747d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleEpClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x7DF7", Offset = "0x7DF7", VA = "0x7DF7")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5747e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_View_EventsList_GdEventListWindow_GdEventListWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GdEventListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12621);
		    DAT_ram_00a5747e = '\x01';
		  }
		  param1_02 = (int *)param1[6];
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x80d8cf84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Application_IApp_TypeInfo,5);
		code_r0x80d8cf84:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_View_EventsList_GdEventListWindow_GdEventListWindowArgs_TypeInfo
		                        );
		  Core_Browser_BrowserWindow___ctor(param1_01,param2_00,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12621,param1_01,
		             Method_UI_Windows_PopupController_Show_GdEventListWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x7DF8", Offset = "0x7DF8", VA = "0x7DF8")]
		private void HandleEpClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleEpClickEvent ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__HandleEpClickEvent
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5747f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__get_Model__
		              );
		    DAT_ram_00a5747f = '\x01';
		  }
		  Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__HandleCurrentEventChangedEvent
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0xc),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x7DF9", Offset = "0x7DF9", VA = "0x7DF9")]
		private void HandleCategoriesContentChangedEvent()
		{
		/* --- GHIDRA: HandleCategoriesContentChangedEvent ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__HandleCategoriesContentChangedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57480 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__get_Model__
		              );
		    DAT_ram_00a57480 = '\x01';
		  }
		  Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__HandleCurrentEventChangedEvent
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0xc),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x7DFA", Offset = "0x7DFA", VA = "0x7DFA")]
		private void HandleCurrentEventChangedEvent(GdEventData from, GdEventData to)
		{
		/* --- GHIDRA: HandleCurrentEventChangedEvent ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__HandleCurrentEventChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57481 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57481 = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_GdEventData__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80d8cacf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IEnumerable_GdEventData__TypeInfo,
		                                0);
		code_r0x80d8cacf:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80d8cba9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80d8cbf5:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80d8cd7d;
		    }
		code_r0x80d8cba9:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80d8cbf5;
		    if (iVar6 == 0) {
		      iVar4 = 5;
		      iVar6 = 0;
		      goto code_r0x80d8cdca;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_GdEventData__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80d8cc98;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_GdEventData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80d8cd6b:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80d8cd7d;
		    }
		code_r0x80d8cc98:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80d8cd6b;
		  } while (*(char *)(iVar6 + 0x18) == '\0');
		  iVar6 = 0;
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iii
		                    (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2cc,*(undefined4 *)(iVar8 + 0x18)
		               ,1,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = 4;
		    if (iVar8 != 1) goto code_r0x80d8cdca;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x80d8cd7d:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar6 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80d8cdca:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80d8ce42;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80d8ce42:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        if ((iVar4 == 0) ||
		           ((((iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) && ((iVar4 != 4 && (iVar4 == 5)))))) {
		          iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          System_Collections_Generic_Dictionary_int__object___get_Count
		                    (*(undefined4 *)(iVar6 + 0x18),0,0);
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2cd,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(param1_00);
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

		// Token: 0x06002D7D RID: 11645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x7DFB", Offset = "0x7DFB", VA = "0x7DFB")]
		private void ValidateNotViewedEvents(AbstractGdEventCatData category)
		{
		}

		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x18")]
		private IApp _app;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5747b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__set_View__
		              );
		    DAT_ram_00a5747b = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5747d == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleEpClickEvent__
		                );
		      DAT_ram_00a5747d = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleEpClickEvent__
		               ,0);
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  
		  if (DAT_ram_00a5747c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsIndexEpView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleEpClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_IListExt_GetRandom_GdEventData___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7022);
		    DAT_ram_00a5747c = '\x01';
		  }
		  Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__HandleCurrentEventChangedEvent
		            (param1,*(undefined4 *)(param1[2] + 0xc),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_HandleEpClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar6,uVar3,0);
		  piVar7 = *(int **)(*(int *)(param1[2] + 0xc) + 0xc);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_GdEventData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80d8c894;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_ICollection_GdEventData__TypeInfo,
		                                0);
		code_r0x80d8c894:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  if ((0 < iVar2) &&
		     (iVar2 = Core_Extensions_IListExt__GetIndexRandom___Il2CppFullySharedGenericType_
		                        (*(undefined4 *)(*(int *)(param1[2] + 0xc) + 0xc),
		                         Method_Core_Extensions_IListExt_GetRandom_GdEventData___), iVar2 != 0)) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = *(undefined4 *)(iVar5 + 0x14);
		    uVar3 = Core_Extensions_Dict_GameEventExt__GetSmallBannerAssetId
		                      (*(undefined4 *)(iVar2 + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar6,uVar3,0);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x14);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1[2] + 0x18);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80d8c984;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d8c984:
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar6 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar6,StringLiteral_7022,0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar3,uVar6,0);
		  return;
		}
		*/

}
