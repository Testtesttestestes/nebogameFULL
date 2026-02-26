using System;
using Core.Data;
using Gameplay.Isles.Axis;
using Gameplay.Isles.Clan;
using Gameplay.Isles.User;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Clans;
using Protocol.World;
using ServicesNamespace;
using Utils;

namespace Gameplay.World.Controller
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public class WorldController : AbstractController<WorldModel, WorldControllerEvents>, IUserIslesWorldMovement, IClanIslesWorldMovement
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x6672", Offset = "0x6672", VA = "0x6672", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_World_Controller_WorldController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5817a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_WorldModel__WorldControllerEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CommandsRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5817a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_WorldModel__WorldControllerEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_WorldService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanIsleService___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = unnamed_function_1417(Utils_CommandsRepository_TypeInfo);
		  Utils_ColorUtil__SetRGB(uVar1,5.0,0);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x6673", Offset = "0x6673", VA = "0x6673")]
		public WorldController(WorldModel model, WorldControllerEvents controllerEvents)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Controller_WorldController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5817b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGoHomeEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_AnimationTimerExpiredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_ClansServiceOnClanUnregisteredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_ClansServiceOnTreasuryChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_ClansServiceOnUserLeftClanEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_HandleDictProviderOnChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_WorldServiceGoHomeEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterFlewAwayEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterInfoChangedEvent__
		              );
		    DAT_ram_00a5817b = '\x01';
		  }
		  iVar4 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterInfoChangedEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_IsleMonsterInfoChangedEvent(iVar4,uVar2,0);
		  iVar4 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterFlewAwayEvent__
		             ,0);
		  ServicesNamespace_WorldService__add_IsleMonsterFlewAwayEvent(iVar4,uVar2,0);
		  iVar4 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoGoHomeEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_WorldServiceGoHomeEventHandler__,0);
		  ServicesNamespace_WorldService__add_GoHomeEvent(iVar4,uVar2,0);
		  iVar4 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_ClansServiceOnClanUnregisteredEvent__,
		             0);
		  ServicesNamespace_ClansService__add_ClanUnregisteredEvent(iVar4,uVar2,0);
		  iVar4 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_ClansServiceOnTreasuryChangedEvent__,0
		            );
		  ServicesNamespace_ClansService__add_TreasuryChangedEvent(iVar4,uVar2,0);
		  iVar4 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_ClansServiceOnUserLeftClanEvent__,0);
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(iVar4,uVar2,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_AnimationTimerExpiredEventHandler__,0)
		  ;
		  Utils_Timers_TimerTracker__add_TimerExpiredEvent(param1_00,uVar2,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_HandleDictProviderOnChangedEvent__,0);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80eac6c9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x80eac6c9:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar2,puVar3[1]);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Utils_Timers_TimerTracker__ClearExpiredTimers(*(undefined4 *)(iVar4 + 0x3c),0);
		  return;
		}
		*/

		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x6674", Offset = "0x6674", VA = "0x6674", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_World_Controller_WorldController__HandleStop(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined8 uVar5;
		  longlong lVar6;
		  int iVar7;
		  undefined4 param1_00;
		  int *piVar8;
		  
		  if (DAT_ram_00a5817c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGoHomeEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_AnimationTimerExpiredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_ClansServiceOnClanUnregisteredEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_ClansServiceOnTreasuryChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_ClansServiceOnUserLeftClanEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_HandleDictProviderOnChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_WorldServiceGoHomeEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterFlewAwayEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterInfoChangedEvent__
		              );
		    DAT_ram_00a5817c = '\x01';
		  }
		  iVar7 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoIsleMonsterInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterInfoChangedEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_AnimationStartedEvent(iVar7,uVar2,0);
		  iVar7 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoIsleMonsterFlewAwayEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_WorldServiceOnIsleMonsterFlewAwayEvent__
		             ,0);
		  ServicesNamespace_WorldService__remove_UserIsleDecorationRemovedEvent(iVar7,uVar2,0);
		  iVar7 = param1[7];
		  uVar2 = unnamed_function_1417(System_Action_ProtoGoHomeEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_WorldServiceGoHomeEventHandler__,0);
		  ServicesNamespace_WorldService__remove_BuildingStartedEvent(iVar7,uVar2,0);
		  iVar7 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_ClansServiceOnClanUnregisteredEvent__,
		             0);
		  ServicesNamespace_ClansService__remove_ClanCreatedEvent(iVar7,uVar2,0);
		  iVar7 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_ClansServiceOnTreasuryChangedEvent__,0
		            );
		  ServicesNamespace_ClansService__remove_GolemSlotsChangedEvent(iVar7,uVar2,0);
		  iVar7 = param1[0xb];
		  uVar2 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_World_Controller_WorldController_ClansServiceOnUserLeftClanEvent__,0);
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(iVar7,uVar2,0);
		  uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		  uVar2 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  param1_00 = *(undefined4 *)(iVar7 + 0x3c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_World_Controller_WorldController_AnimationTimerExpiredEventHandler__,0)
		  ;
		  Utils_Timers_DelayedCall__DelayedCallAsync_d__9__SetStateMachine(param1_00,uVar3,0);
		  uVar5 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		  uVar2 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  piVar8 = *(int **)(iVar7 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_World_Controller_WorldController_HandleDictProviderOnChangedEvent__,0);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80eac998;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x80eac998:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar8,CONCAT44(uVar2,uVar3),puVar4[1]);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar7 + 8),0);
		  uVar1 = 0;
		  Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler(param1,uVar5,0,0);
		  uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		  uVar2 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  piVar8 = *(int **)(iVar7 + 0xc);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80eaca56;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80eaca56:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,CONCAT44(uVar2,puVar4[1]));
		  uVar2 = func_ii_7112(uVar2,0);
		  lVar6 = Core_Data_UserData___ctor(uVar2,0);
		  *(bool *)(param1 + 6) = lVar6 != 0;
		  return;
		}
		*/

		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x6675", Offset = "0x6675", VA = "0x6675", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x6676", Offset = "0x6676", VA = "0x6676")]
		private void HandleDictProviderOnChangedEvent()
		{
		/* --- GHIDRA: HandleDictProviderOnChangedEvent ---
		void Gameplay_World_Controller_WorldController__HandleDictProviderOnChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined8 param2_00;
		  
		  if ((char)param1[6] == '\0') {
		    *(undefined1 *)(param1 + 6) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(iVar1 + 8),0);
		    Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler
		              (param1,param2_00,1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x6677", Offset = "0x6677", VA = "0x6677")]
		private void ClansServiceOnTreasuryChangedEvent(ProtoTreasuryChangedEvt msg)
		{
		/* --- GHIDRA: ClansServiceOnTreasuryChangedEvent ---
		void Gameplay_World_Controller_WorldController__ClansServiceOnTreasuryChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  longlong lVar3;
		  undefined8 uVar4;
		  
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar2 + 8),0);
		  if (lVar3 == *(longlong *)(param2 + 0x10)) {
		    *(undefined1 *)(param1 + 6) = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar2 + 8),0);
		    Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler(param1,uVar4,1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x6678", Offset = "0x6678", VA = "0x6678")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: ClansServiceOnUserLeftClanEvent ---
		void Gameplay_World_Controller_WorldController__ClansServiceOnUserLeftClanEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined8 param2_00;
		  
		  *(undefined1 *)(param1 + 6) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler
		            (param1,param2_00,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x6679", Offset = "0x6679", VA = "0x6679")]
		private void ClansServiceOnClanUnregisteredEvent(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x667A", Offset = "0x667A", VA = "0x667A")]
		private void AnimationTimerExpiredEventHandler()
		{
		/* --- GHIDRA: AnimationTimerExpiredEventHandler ---
		void Gameplay_World_Controller_WorldController__AnimationTimerExpiredEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  undefined1 auStack_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5817d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Nullable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17950);
		    DAT_ram_00a5817d = '\x01';
		  }
		  Gameplay_World_Controller_WorldController__KickMonsterFromCurrentIsle(param1,auStack_10);
		  uVar1 = StringLiteral_17950;
		  if (param2 == 0) {
		    local_8 = 0;
		  }
		  else {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_8,*(undefined4 *)(*(int *)(param2 + 0x18) + 0xc),
		               Method_System_Nullable_uint___ctor__);
		  }
		  param2_00 = func_ii_1081(System_Nullable_uint__TypeInfo,&local_8);
		  uVar1 = func_ii_4419(uVar1,param2_00,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x667B", Offset = "0x667B", VA = "0x667B")]
		private void WorldServiceOnIsleMonsterInfoChangedEvent(ProtoIsleMonsterInfoChangedEvt msg)
		{
		/* --- GHIDRA: WorldServiceOnIsleMonsterInfoChangedEvent ---
		void Gameplay_World_Controller_WorldController__WorldServiceOnIsleMonsterInfoChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  undefined8 uVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5817e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_IsDisposed__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_UserIsle__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_UserIsle__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_UserIsle__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__get_List__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__set_IsInvalid__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserIsle__GetEnumerator__);
		    DAT_ram_00a5817e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		  uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(iVar2 + 0x30) + 0x10),
		             Method_System_Collections_Generic_List_UserIsle__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_UserIsle__MoveNext__);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ead701;
		      }
		      if (iVar3 == 0) goto code_r0x80ead759;
		    } while ((*(char *)(local_8._4_4_ + 8) != '\0') ||
		            (*(int *)(*(int *)(local_8._4_4_ + 0x10) + 0x34) == 0));
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x115,
		               *(int *)(local_8._4_4_ + 0x10),0,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ead701:
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ead759:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		      uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      if (*(int *)(iVar2 + 0x24) != 0) {
		        uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar5);
		        uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        iVar2 = *(int *)(iVar2 + 0x20);
		        if (iVar2 != 0) {
		          iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		          uVar5 = Gameplay_Isles_User_Model_UserIsleModel__set_RequestFlags
		                            (*(undefined4 *)(*(int *)(iVar3 + 0x24) + 0x10),0);
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),uVar5,2,*(undefined4 *)(iVar2 + 0x14));
		          uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        }
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		      *(undefined1 *)(*(int *)(iVar2 + 0x30) + 8) = 1;
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x116,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
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

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x667C", Offset = "0x667C", VA = "0x667C")]
		private void WorldServiceOnIsleMonsterFlewAwayEvent(ProtoIsleMonsterFlewAwayEvt evt)
		{
		/* --- GHIDRA: WorldServiceOnIsleMonsterFlewAwayEvent ---
		void Gameplay_World_Controller_WorldController__WorldServiceOnIsleMonsterFlewAwayEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined8 param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler
		            (param1,param2_00,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x667D", Offset = "0x667D", VA = "0x667D")]
		private void WorldServiceGoHomeEventHandler(ProtoGoHomeEvt evt)
		{
		/* --- GHIDRA: WorldServiceGoHomeEventHandler ---
		undefined4
		Gameplay_World_Controller_WorldController__WorldServiceGoHomeEventHandler
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5817f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster_TypeInfo);
		    DAT_ram_00a5817f = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x10);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster_TypeInfo);
		  Gameplay_ArenaCombat_Model_ArenaCombatModel_AttackRequestedMonster__get_FromCave
		            (uVar2,param2_00,0);
		  uVar2 = Gameplay_ArenaCombat_ArenaCombat__Dispose(param1_00,uVar2,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x667E", Offset = "0x667E", VA = "0x667E")]
		public bool TryAttackMonsterFromCurrentIsle([NotNull] MonsterData monster)
		{
		/* --- GHIDRA: TryAttackMonsterFromCurrentIsle ---
		void Gameplay_World_Controller_WorldController__TryAttackMonsterFromCurrentIsle
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 param2_00;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58180 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_MonsterKickedServiceHandler__);
		    DAT_ram_00a58180 = '\x01';
		  }
		  iVar3 = param1[10];
		  local_4 = 0xc;
		  uVar1 = func_ii_1081(Protocol_World_WorldCommands_TypeInfo,&local_4);
		  iVar3 = Utils_CommandsRepository___ctor(iVar3,uVar1,0);
		  if (iVar3 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    param2_00 = *(undefined8 *)(*(int *)(iVar3 + 0x24) + 0x18);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = ServicesNamespace_WorldService__AttackMonster
		                      (param1[7],param2_00,
		                       *(undefined4 *)
		                        (*(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x24) + 0x10) + 0x40) + 8) +
		                        0xc),0);
		    uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_World_Controller_WorldController_MonsterKickedServiceHandler__,0);
		    uVar1 = ServicesNamespace_MainService__GetUserStats
		                      (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_10 = param2_00;
		    uVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		    uVar1 = DG_Tweening_TweenParams__SetId
		                      (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x667F", Offset = "0x667F", VA = "0x667F")]
		public void KickMonsterFromCurrentIsle()
		{
		/* --- GHIDRA: KickMonsterFromCurrentIsle ---
		uint Gameplay_World_Controller_WorldController__KickMonsterFromCurrentIsle
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 param2_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58181 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_GetMonsterInfoServiceHandler__);
		    DAT_ram_00a58181 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = *(undefined8 *)(*(int *)(iVar2 + 0x24) + 0x18);
		    uVar3 = ServicesNamespace_WorldService__KickMonster(param1[7],param2_00,0);
		    uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_World_Controller_WorldController_GetMonsterInfoServiceHandler__,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    local_8 = param2_00;
		    uVar4 = func_ii_1081(DAT_ram_00a66968,&local_8);
		    uVar3 = DG_Tweening_TweenParams__SetId
		                      (uVar3,uVar4,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  }
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x6680", Offset = "0x6680", VA = "0x6680")]
		public bool TryRequestMonsterForCurrentUserIsle()
		{
		/* --- GHIDRA: TryRequestMonsterForCurrentUserIsle ---
		void Gameplay_World_Controller_WorldController__TryRequestMonsterForCurrentUserIsle
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined8 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined8 param2_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58182 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMonsterErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_KickMonsterEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoKickMonsterAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_WorldCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_GetMonsterInfoServiceHandler__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17949);
		    DAT_ram_00a58182 = '\x01';
		  }
		  iVar7 = param1[10];
		  local_8 = CONCAT44(local_8._4_4_,0xc);
		  uVar2 = func_ii_1081(Protocol_World_WorldCommands_TypeInfo,&local_8);
		  Utils_CommandsRepository__TryAdd(iVar7,uVar2,0);
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar8 = *(int **)(param2 + 0x20);
		  if ((piVar8 != (int *)0x0) && (Protocol_World_ProtoKickMonsterAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance(piVar8,Protocol_World_ProtoKickMonsterAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar8[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMonsterErrors___
		                    );
		  if (iVar7 == 0) {
		    piVar8 = *(int **)(param2 + 0xc);
		    if (piVar8 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar8 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		      System_Activator__CreateInstance(piVar8,DAT_ram_00a66968);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar3 = (undefined8 *)func_ii_15774(piVar8);
		    param2_00 = *puVar3;
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    uVar1 = param2_00;
		    iVar7 = Gameplay_World_Model_IsleHeap_object___Dispose
		                      (*(undefined4 *)(iVar7 + 0x30),param2_00,
		                       Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (iVar7 != 0) {
		      if (*(int *)(*(int *)(iVar7 + 0x10) + 0x40) != 0) {
		        iVar4 = System_Uri___ctor(0);
		        iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(iVar4 + 0x38) + 0x10) + 0x2c) + 0x14);
		        if (iVar4 != 0) {
		          uVar5 = System_Uri___ctor(0);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param4 = *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x40);
		          param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          uVar6 = unnamed_function_1417
		                            (Core_Events_Scopes_CombatScope_KickMonsterEventArgs_TypeInfo);
		          Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId
		                    (uVar6,uVar5,param3_00,param4,param2_00,0);
		          (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                    (*(undefined4 *)(iVar4 + 0x20),CONCAT44(uVar2,uVar6),
		                     *(undefined4 *)(iVar4 + 0x14));
		        }
		      }
		      func_ii_7323(*(undefined4 *)(iVar7 + 0x10),0,0);
		      uVar1 = param2_00;
		      uVar5 = ServicesNamespace_WorldService__KickMonster(param1[7],param2_00,0);
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar6 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_World_Controller_WorldController_GetMonsterInfoServiceHandler__,0);
		      uVar5 = ServicesNamespace_MainService__GetUserStats
		                        (uVar5,uVar6,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		      local_8 = param2_00;
		      uVar6 = func_ii_1081(DAT_ram_00a66968,&local_8);
		      uVar5 = DG_Tweening_TweenParams__SetId
		                        (uVar5,uVar6,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		      Utils_OpToken_int__object___AddHandlers(param1,uVar5,0);
		    }
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar7 = *(int *)(iVar7 + 0x20);
		    if (iVar7 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		                (*(undefined4 *)(iVar7 + 0x20),param2_00,1,*(undefined4 *)(iVar7 + 0x14));
		    }
		  }
		  else {
		    local_8 = CONCAT44(local_8._4_4_,piVar8[3]);
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_17949,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x6681", Offset = "0x6681", VA = "0x6681")]
		private void MonsterKickedServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: MonsterKickedServiceHandler ---
		void Gameplay_World_Controller_WorldController__MonsterKickedServiceHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined8 *puVar3;
		  int iVar4;
		  int *param1_00;
		  int *param1_01;
		  undefined8 param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a58183 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetMonsterInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17948);
		    DAT_ram_00a58183 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_World_ProtoGetMonsterInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_World_ProtoGetMonsterInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = param1_00[3];
		  if (local_4 < 0) {
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_17948,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  }
		  else {
		    param1_01 = *(int **)(param2 + 0xc);
		    if (param1_01 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*param1_01 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		      System_Activator__CreateInstance(param1_01,DAT_ram_00a66968);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar3 = (undefined8 *)func_ii_15774(param1_01);
		    param2_00 = *puVar3;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    uVar1 = param2_00;
		    iVar4 = Gameplay_World_Model_IsleHeap_object___Dispose
		                      (*(undefined4 *)(iVar4 + 0x30),param2_00,
		                       Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    if (iVar4 != 0) {
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      func_ii_7323(*(undefined4 *)(iVar4 + 0x10),param1_00[4],0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		      iVar4 = *(int *)(iVar4 + 0x20);
		      if (iVar4 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (*(undefined4 *)(iVar4 + 0x20),param2_00,0,*(undefined4 *)(iVar4 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x6682", Offset = "0x6682", VA = "0x6682")]
		private void GetMonsterInfoServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetMonsterInfoServiceHandler ---
		void Gameplay_World_Controller_WorldController__GetMonsterInfoServiceHandler
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58184 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_GetClanIsleInfoServiceHandler__);
		    DAT_ram_00a58184 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanIsleService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x20),param2,3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_World_Controller_WorldController_GetClanIsleInfoServiceHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x6683", Offset = "0x6683", VA = "0x6683", Slot = "14")]
		public void GoToClanIsle(ulong clanId)
		{
		/* --- GHIDRA: GoToClanIsle ---
		void Gameplay_World_Controller_WorldController__GoToClanIsle
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 param3_00;
		  undefined8 uVar11;
		  int local_4;
		  
		  if (DAT_ram_00a58185 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Clan_ClanIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__AddToHeap__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17947);
		    DAT_ram_00a58185 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = piVar6[4];
		  if (local_4 < 0) {
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_17947,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    uVar11 = *(undefined8 *)(*(int *)(piVar6[3] + 0x10) + 0x10);
		    iVar3 = Gameplay_World_Model_WorldModel__GetUserIsle(uVar2,uVar11,0);
		    uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    if (iVar3 == 0) {
		      uVar10 = *(undefined4 *)(piVar6[3] + 0x10);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar1 = 0;
		      piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar3 = *piVar8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		            goto code_r0x80eae145;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eae145:
		      uVar11 = CONCAT44(uVar2,puVar4[1]);
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar11);
		      uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		      uVar10 = func_ii_7325(uVar10,uVar5,0);
		      uVar11 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar11);
		      uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      uVar5 = *(undefined4 *)(iVar3 + 8);
		      iVar3 = unnamed_function_1417(Gameplay_Isles_Clan_ClanIsle_TypeInfo);
		      Gameplay_Isles_Clan_ClanIsle___ctor(iVar3,uVar10,uVar5,0);
		      uVar11 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar11);
		      uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      Gameplay_Isles_User_UserIsle___ctor
		                (*(undefined4 *)(iVar7 + 0x34),iVar3,
		                 Method_Gameplay_World_Model_IsleHeap_ClanIsle__AddToHeap__);
		    }
		    Gameplay_Isles_Clan_Controller_ClanIsleController__HandleStop
		              (*(undefined4 *)(iVar3 + 0x14),piVar6[3],0);
		    iVar7 = *(int *)(*(int *)(iVar3 + 0x10) + 0x30);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x158);
		          goto code_r0x80eae273;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80eae273:
		    uVar11 = CONCAT44(uVar2,puVar4[1]);
		    iVar9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar11);
		    uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    uVar1 = 0;
		    uVar10 = *(undefined4 *)(piVar6[3] + 0x2c);
		    piVar8 = *(int **)(iVar9 + 0x14);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80eae302;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar8,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80eae302:
		    uVar11 = CONCAT44(uVar2,uVar10);
		    uVar10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,uVar11,puVar4[1]);
		    uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    *(undefined4 *)(iVar7 + 0x14) = uVar10;
		    iVar7 = *(int *)(piVar6[3] + 0x30);
		    if (iVar7 != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar9 = *piVar6;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		            goto code_r0x80eae3bf;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eae3bf:
		      uVar11 = CONCAT44(uVar2,puVar4[1]);
		      uVar10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar11);
		      uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      uVar10 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar10,0);
		      uVar10 = func_ii_7325(iVar7,uVar10,0);
		      uVar11 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar11);
		      uVar2 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      param3_00 = *(undefined4 *)(iVar7 + 8);
		      uVar5 = unnamed_function_1417(Gameplay_Isles_Clan_ClanIsle_TypeInfo);
		      Gameplay_Isles_Clan_ClanIsle___ctor(uVar5,uVar10,param3_00,0);
		      puVar4 = (uint *)*param1;
		      iVar7 = (**(code **)((ulonglong)puVar4[0x40] * 4))(param1,CONCAT44(uVar2,puVar4[0x41]));
		      Gameplay_Isles_User_UserIsle___ctor
		                (*(undefined4 *)(iVar7 + 0x34),uVar5,
		                 Method_Gameplay_World_Model_IsleHeap_ClanIsle__AddToHeap__);
		    }
		    Gameplay_World_Controller_WorldController__SetCurrentUserIsleData(param1,iVar3,puVar4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x6684", Offset = "0x6684", VA = "0x6684")]
		private void GetClanIsleInfoServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetClanIsleInfoServiceHandler ---
		void Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler
		               (int *param1,longlong param2,int param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param3_00;
		  undefined4 uVar6;
		  undefined1 local_a;
		  undefined1 local_9;
		  longlong local_8;
		  
		  lVar1 = param2;
		  if (DAT_ram_00a58186 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetLastIsleFromHeap__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__IsHeapNeedUpdate__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__get_IsInvalid__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_GetUserIsleInfoServiceHandler__);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17956);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17953);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17954);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17952);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17955);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17957);
		    DAT_ram_00a58186 = '\x01';
		  }
		  uVar6 = (undefined4)((ulonglong)lVar1 >> 0x20);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar3 = func_ii_4419(StringLiteral_17952,uVar3,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  if (param1[0xc] != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17954,0);
		    iVar4 = *(int *)param1[0xc];
		    uVar2 = CONCAT44(uVar6,*(undefined4 *)(iVar4 + 0x11c));
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x118) * 4))((int *)param1[0xc],uVar2);
		    uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    param1[0xc] = 0;
		  }
		  if (param3 == 0) {
		    uVar2 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		    uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    if (*(int *)(iVar4 + 0x24) != 0) {
		      uVar2 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		      uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      if (*(longlong *)(*(int *)(iVar4 + 0x24) + 0x18) == param2) {
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17957,0);
		        return;
		      }
		    }
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104)));
		  lVar1 = param2;
		  iVar4 = Gameplay_World_Model_IsleHeap_object___Dispose
		                    (*(undefined4 *)(iVar4 + 0x30),param2,
		                     Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		  uVar2 = CONCAT44((int)((ulonglong)lVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  local_9 = *(undefined1 *)(*(int *)(iVar5 + 0x30) + 8);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar3 = func_ii_1081(DAT_ram_00a66944,&local_9);
		  local_a = (undefined1)param3;
		  param3_00 = func_ii_1081(DAT_ram_00a66944,&local_a);
		  uVar3 = func_ii_8529(StringLiteral_17953,uVar3,param3_00,iVar4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  uVar2 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  if ((((iVar4 == 0) || (*(char *)(*(int *)(iVar5 + 0x30) + 8) != '\0')) || (param3 != 0)) ||
		     ((*(int *)(*(int *)(iVar4 + 0x10) + 0x34) == 0 ||
		      (iVar5 = Gameplay_Isles_User_UserIsle__TryOpenBuildingByType(iVar4,0), iVar5 != 0)))) {
		    Gameplay_World_Controller_WorldController__GoHome(param1,param1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x114)));
		    iVar4 = *(int *)(iVar4 + 0x18);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param2,*(undefined4 *)(iVar4 + 0x14));
		    }
		    uVar6 = ServicesNamespace_WorldService__ServerEventHandler(param1[7],param2,0,0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_World_Controller_WorldController_GetUserIsleInfoServiceHandler__,0);
		    uVar6 = ServicesNamespace_MainService__GetUserStats
		                      (uVar6,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar3 = unnamed_function_1417(Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo);
		    Gameplay_World_Model_WorldModel__GetLeftOverCountOfIsleAnimationWhitOutCoolDown
		              (uVar3,param2,1,0);
		    iVar4 = DG_Tweening_TweenParams__SetId
		                      (uVar6,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    param1[0xc] = iVar4;
		    Utils_OpToken_int__object___AddHandlers(param1,iVar4,0);
		  }
		  else {
		    uVar2 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		    uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    iVar5 = Gameplay_World_Model_IsleHeap_object___GetLastIsleFromHeap
		                      (*(undefined4 *)(iVar5 + 0x30),iVar4,
		                       Method_Gameplay_World_Model_IsleHeap_UserIsle__IsHeapNeedUpdate__);
		    if (iVar5 != 0) {
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17955,0);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x104)));
		      iVar5 = Gameplay_World_Model_IsleHeap_object___GetIsle
		                        (*(undefined4 *)(iVar5 + 0x30),
		                         Method_Gameplay_World_Model_IsleHeap_UserIsle__GetLastIsleFromHeap__);
		      iVar5 = *(int *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x34) + 0x34);
		      if (iVar5 == 0) {
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7830(StringLiteral_17956,0);
		      }
		      else {
		        uVar6 = ServicesNamespace_WorldService__ServerEventHandler
		                          (param1[7],*(undefined8 *)(iVar5 + 0x10),1,0);
		        uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar3,param1,
		                   Method_Gameplay_World_Controller_WorldController_GetUserIsleInfoServiceHandler__,
		                   0);
		        uVar6 = ServicesNamespace_MainService__GetUserStats
		                          (uVar6,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		        uVar3 = unnamed_function_1417
		                          (Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo);
		        Gameplay_World_Model_WorldModel__GetLeftOverCountOfIsleAnimationWhitOutCoolDown
		                  (uVar3,param2,0,0);
		        iVar5 = DG_Tweening_TweenParams__SetId
		                          (uVar6,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		        param1[0xc] = iVar5;
		        Utils_OpToken_int__object___AddHandlers(param1,iVar5,0);
		      }
		    }
		    Gameplay_World_Controller_WorldController__GetColossusInfoServiceResultHandler
		              (param1,iVar4,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x6685", Offset = "0x6685", VA = "0x6685", Slot = "13")]
		public void GoToUserIsle(ulong userId, bool force = false)
		{
		/* --- GHIDRA: GoToUserIsle ---
		void Gameplay_World_Controller_WorldController__GoToUserIsle
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 param1_00;
		  undefined4 uVar7;
		  longlong lVar8;
		  longlong lVar9;
		  int *param1_01;
		  int *param1_02;
		  undefined4 *puVar10;
		  int iVar11;
		  int iVar12;
		  undefined4 param3_00;
		  int *piVar13;
		  int *piVar14;
		  int iVar15;
		  uint uVar16;
		  undefined8 uVar17;
		  int local_18;
		  undefined4 local_14;
		  longlong local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a58187 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_LastOrDefault_ProtoGetUserIsleInfoAns_Types_IsleInformation___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetUserIsleInfoAns_Types_IsleInformation__ulong___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGetUserIsleInfoErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetUserIsleInfoAns_Types_IsleInformation__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetUserIsleInfoAns_Types_IsleInformation__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData_IManagedClanData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__AddToHeap__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__set_HeapLimit__);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetUserIsleInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserIsleInfoAns_Types_IsleInformation__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserIsleInfoAns_Types_IsleInformation__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController___c__GetUserIsleInfoServiceHandler_b__27_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldController___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_UserIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17951);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17825);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a58187 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  if (*(int *)(param2 + 8) == 4) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17951,0);
		  }
		  else {
		    param1_01 = *(int **)(param2 + 0x20);
		    if ((param1_01 != (int *)0x0) && (Protocol_World_ProtoGetUserIsleInfoAns_TypeInfo != *param1_01)
		       ) {
		      System_Activator__CreateInstance(param1_01,Protocol_World_ProtoGetUserIsleInfoAns_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_02 = *(int **)(param1[0xc] + 0xc);
		    if (param1_02 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_02 + 0xb8) <
		           (uint)*(byte *)(Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*param1_02 + 100) +
		                      (uint)*(byte *)(
		                                     Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo
		                                     + 0xb8) * 4 + -4) !=
		             Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_02,Gameplay_World_Model_WorldModel_WorldUserIsleRequestVo_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		    local_10 = *(longlong *)(param1_02 + 2);
		    iVar2 = func_ii_1081(DAT_ram_00a66968,&local_10);
		    if ((iVar2 != 0) && (iVar11 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar11 == 0))
		    {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[4] = iVar2;
		    local_14 = *(undefined4 *)(param1_01[3] + 0xc);
		    iVar2 = func_ii_1081(DAT_ram_00a66954,&local_14);
		    if ((iVar2 != 0) && (iVar11 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar11 == 0))
		    {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[5] = iVar2;
		    local_18 = param1_01[4];
		    iVar2 = func_ii_1081(DAT_ram_00a66958,&local_18);
		    if ((iVar2 != 0) && (iVar11 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar11 == 0))
		    {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[6] = iVar2;
		    iVar2 = param1_01[3];
		    if (*(int *)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_World_Controller_WorldController___c_TypeInfo);
		    }
		    uVar7 = StringLiteral_17825;
		    uVar4 = StringLiteral_1236;
		    puVar10 = *(undefined4 **)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c);
		    iVar11 = puVar10[1];
		    if (iVar11 == 0) {
		      if (*(int *)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_World_Controller_WorldController___c_TypeInfo);
		        puVar10 = *(undefined4 **)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar10;
		      iVar11 = unnamed_function_1417
		                         (System_Func_ProtoGetUserIsleInfoAns_Types_IsleInformation__ulong__TypeInfo
		                         );
		      func_ii_7542(iVar11,uVar3,
		                   Method_Gameplay_World_Controller_WorldController___c__GetUserIsleInfoServiceHandler_b__27_0__
		                   ,0);
		      *(int *)(*(int *)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c) + 4) = iVar11
		      ;
		    }
		    uVar3 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                      (iVar2,iVar11,
		                       Method_System_Linq_Enumerable_Select_ProtoGetUserIsleInfoAns_Types_IsleInformation__ulong___
		                      );
		    uVar3 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                      (uVar3,Method_System_Linq_Enumerable_ToArray_ulong___);
		    iVar2 = System_String__Join_uint_(uVar4,uVar3,Method_System_String_Join_ulong___);
		    if ((iVar2 != 0) && (iVar11 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20)), iVar11 == 0))
		    {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar1[7] = iVar2;
		    uVar4 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName(uVar7,piVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		    iVar2 = param1_01[5];
		    uVar4 = unnamed_function_1417
		                      (
		                      Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		                      );
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar4,param1_01,0);
		    iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                      (iVar2,uVar4,
		                       Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGetUserIsleInfoErrors___
		                      );
		    if (iVar2 == 0) {
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (param1_01[3],
		                                  Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserIsleInfoAns_Types_IsleInformation__GetEnumerator__
		                                 );
		      local_10 = ZEXT48(&local_4) << 0x20;
		      do {
		        piVar1 = local_4;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar16 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar2 + 0x58) + uVar16 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		              puVar10 = (undefined4 *)(iVar2 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80eaec44;
		            }
		            uVar16 = uVar16 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar16);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar10 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                             System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eaf94b:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		code_r0x80eaec44:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar10,piVar1,puVar10[1]);
		        piVar1 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eaf94b;
		        if (iVar2 == 0) {
		          iVar11 = 0xd;
		          iVar2 = 0;
		          goto code_r0x80eaf9e4;
		        }
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar16 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar2 + 0x58) + uVar16 * 8);
		            if (System_Collections_Generic_IEnumerator_ProtoGetUserIsleInfoAns_Types_IsleInformation__TypeInfo
		                == *piVar14) {
		              puVar10 = (undefined4 *)(iVar2 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80eaed46;
		            }
		            uVar16 = uVar16 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar16);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar10 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                             System_Collections_Generic_IEnumerator_ProtoGetUserIsleInfoAns_Types_IsleInformation__TypeInfo
		                             ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eaef8c:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		code_r0x80eaed46:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar10,piVar1,puVar10[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eaef8c;
		        DAT_ram_009d3e38 = 0;
		        iVar15 = import::env::invoke_iii
		                           (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104)
		                           );
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        piVar1 = *(int **)(iVar15 + 0xc);
		        iVar11 = *piVar1;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar16 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar16 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		              puVar10 = (undefined4 *)(piVar14[1] * 8 + iVar11 + 0x158);
		              goto code_r0x80eaee60;
		            }
		            uVar16 = uVar16 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar16);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar10 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar1,
		                             Core_Gameplay_IGame_TypeInfo,0x13);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eaefa0:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		code_r0x80eaee60:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii(*puVar10,piVar1,puVar10[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eaefa0;
		        uVar4 = *(undefined4 *)(iVar2 + 0x30);
		        piVar1 = *(int **)(iVar11 + 0x14);
		        iVar11 = *piVar1;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar16 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar16 * 8);
		            if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *piVar14) {
		              puVar10 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80eaef3d;
		            }
		            uVar16 = uVar16 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar16);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar10 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar1,
		                             Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80eaefaa:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		code_r0x80eaef3d:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iiii(*puVar10,piVar1,uVar4,puVar10[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80eaefaa;
		        iVar15 = *(int *)(iVar2 + 0x38);
		        if (iVar15 != 0) {
		          piVar1 = *(int **)(iVar11 + 0x68);
		          if (piVar1 == (int *)0x0) {
		            if (DAT_ram_00a6456f == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		              iVar12 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar12 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x80eaf997;
		              }
		              DAT_ram_00a6456f = '\x01';
		            }
		            piVar1 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            iVar12 = *piVar1;
		            if (*(ushort *)(iVar12 + 0xb6) != 0) {
		              uVar16 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar12 + 0x58) + uVar16 * 8);
		                if (Core_Gameplay_IGame_TypeInfo == *piVar14) {
		                  puVar10 = (undefined4 *)(piVar14[1] * 8 + iVar12 + 0x178);
		                  goto code_r0x80eaf2f5;
		                }
		                uVar16 = uVar16 + 1;
		              } while (*(ushort *)(iVar12 + 0xb6) != uVar16);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar10 = (undefined4 *)
		                      import::env::invoke_iiii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar1,
		                                 Core_Gameplay_IGame_TypeInfo,0x17);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x80eaf2f5:
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iii(*puVar10,piVar1,puVar10[1]);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		                iVar12 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar12 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                else {
		                  DAT_ram_009d3e38 = 0;
		                  uVar4 = import::env::invoke_iiii
		                                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x117,iVar15,
		                                     uVar4,0);
		                  iVar15 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar15 != 1) goto code_r0x80eaf394;
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                goto code_r0x80eaf997;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80eaf997;
		          }
		          if (DAT_ram_00a6456f == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		            iVar12 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar12 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80eaf997;
		            }
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar14 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar12 = *piVar14;
		          if (*(ushort *)(iVar12 + 0xb6) != 0) {
		            uVar16 = 0;
		            do {
		              piVar13 = (int *)(*(int *)(iVar12 + 0x58) + uVar16 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar13) {
		                puVar10 = (undefined4 *)(piVar13[1] * 8 + iVar12 + 0x178);
		                goto code_r0x80eaf0b0;
		              }
		              uVar16 = uVar16 + 1;
		            } while (*(ushort *)(iVar12 + 0xb6) != uVar16);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar10 = (undefined4 *)
		                    import::env::invoke_iiii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar14,
		                               Core_Gameplay_IGame_TypeInfo,0x17);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x80eaf0b0:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_iii(*puVar10,piVar14,puVar10[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		              if (DAT_ram_009d3e38 != 1) {
		                iVar12 = *piVar1;
		                if (*(ushort *)(iVar12 + 0xb6) != 0) {
		                  uVar16 = 0;
		                  do {
		                    piVar14 = (int *)(*(int *)(iVar12 + 0x58) + uVar16 * 8);
		                    if (Gameplay_World_Model_ClanData_IManagedClanData_TypeInfo == *piVar14) {
		                      puVar10 = (undefined4 *)(iVar12 + piVar14[1] * 8 + 0xc0);
		                      goto code_r0x80eaf1b2;
		                    }
		                    uVar16 = uVar16 + 1;
		                  } while (*(ushort *)(iVar12 + 0xb6) != uVar16);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar10 = (undefined4 *)
		                          import::env::invoke_iiii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar1,
		                                     Gameplay_World_Model_ClanData_IManagedClanData_TypeInfo,0);
		                if (DAT_ram_009d3e38 != 1) {
		code_r0x80eaf1b2:
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viiii(*puVar10,piVar1,iVar15,uVar4,puVar10[1]);
		                  if (DAT_ram_009d3e38 != 1) goto code_r0x80eaf39c;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80eaf997;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        uVar4 = 0;
		code_r0x80eaf394:
		        *(undefined4 *)(iVar11 + 0x68) = uVar4;
		code_r0x80eaf39c:
		        DAT_ram_009d3e38 = 0;
		        lVar8 = unnamed_function_184054
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,iVar11,0);
		        iVar15 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar15 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar12 = import::env::invoke_iii
		                           (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104)
		                           );
		        iVar15 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar15 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        lVar9 = unnamed_function_184054
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                           *(undefined4 *)(iVar12 + 8),0);
		        iVar15 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar15 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        uVar4 = *(undefined4 *)(*param1 + 0x104);
		        uVar7 = *(undefined4 *)(*param1 + 0x100);
		        if (lVar8 != lVar9) {
		          DAT_ram_009d3e38 = 0;
		          iVar12 = import::env::invoke_iii(uVar7,param1,uVar4);
		          iVar15 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar15 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            uVar7 = *(undefined4 *)(iVar12 + 8);
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x100),param1,
		                               *(undefined4 *)(*param1 + 0x104));
		            iVar15 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar15 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x119,uVar4,0);
		              iVar15 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar15 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::invoke_ii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                   Gameplay_Isles_User_UserIsle_TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viiiiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11a,uVar3,iVar11,
		                             uVar7,iVar2,uVar4,0);
		                  if (DAT_ram_009d3e38 != 1) goto code_r0x80eaf87f;
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		            }
		          }
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar12 = import::env::invoke_iii(uVar7,param1,uVar4);
		        iVar15 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar15 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        uVar4 = *(undefined4 *)(*param1 + 0x104);
		        uVar7 = *(undefined4 *)(*param1 + 0x100);
		        if (*(int *)(iVar12 + 0x20) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar12 = import::env::invoke_iii(uVar7,param1,uVar4);
		          iVar15 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar15 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iii
		                              (*(undefined4 *)(*param1 + 0x100),param1,
		                               *(undefined4 *)(*param1 + 0x104));
		            iVar15 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar15 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              uVar7 = *(undefined4 *)(iVar5 + 8);
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_iii
		                                (*(undefined4 *)(*param1 + 0x100),param1,
		                                 *(undefined4 *)(*param1 + 0x104));
		              iVar15 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar15 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x119,uVar4,0);
		                iVar15 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar15 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		                else {
		                  DAT_ram_009d3e38 = 0;
		                  uVar3 = import::env::invoke_ii
		                                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                     Gameplay_Isles_User_UserIsle_TypeInfo);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viiiiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11a,uVar3,iVar11,
		                               uVar7,iVar2,uVar4,0);
		                    if (DAT_ram_009d3e38 != 1) {
		                      *(undefined4 *)(iVar12 + 0x20) = uVar3;
		                      goto code_r0x80eaf87f;
		                    }
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                }
		              }
		            }
		          }
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar15 = import::env::invoke_iii(uVar7,param1,uVar4);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x118,
		                   *(undefined4 *)(*(int *)(iVar15 + 0x20) + 0x14),iVar2,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii
		                           (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104)
		                           );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        uVar3 = *(undefined4 *)(iVar11 + 0x20);
		code_r0x80eaf87f:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii
		                           (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104)
		                           );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80eaf997;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11b,
		                   *(undefined4 *)(iVar11 + 0x30),uVar3,
		                   Method_Gameplay_World_Model_IsleHeap_UserIsle__AddToHeap__);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar2 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eaf997:
		      iVar2 = global_1;
		      iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar11) {
		        piVar1 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar1;
		        iVar11 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_10 = CONCAT44(local_10._4_4_,iVar2);
		        import::env::invoke_v(0x123);
		        iVar15 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar15 != 1) {
		code_r0x80eaf9e4:
		          piVar1 = local_4;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar16 = 0;
		            iVar15 = *local_4;
		            if (*(ushort *)(iVar15 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar15 + 0x58) + uVar16 * 8)) {
		                  puVar6 = (uint *)(iVar15 + *(int *)(*(int *)(iVar15 + 0x58) + uVar16 * 8 + 4) * 8
		                                   + 0xc0);
		                  goto code_r0x80eafa5c;
		                }
		                uVar16 = uVar16 + 1;
		              } while (*(ushort *)(iVar15 + 0xb6) != uVar16);
		            }
		            puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80eafa5c:
		            uVar17 = CONCAT44(in_register_20000014,puVar6[1]);
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar1,uVar17);
		            in_register_20000014 = (undefined4)((ulonglong)uVar17 >> 0x20);
		          }
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar11 != 0) {
		            if (iVar11 == 1) {
		              return;
		            }
		            if (iVar11 == 2) {
		              return;
		            }
		            if (iVar11 == 3) {
		              return;
		            }
		            if (iVar11 == 4) {
		              return;
		            }
		            if (iVar11 == 5) {
		              return;
		            }
		            if (iVar11 == 6) {
		              return;
		            }
		            if (iVar11 == 7) {
		              return;
		            }
		            if (iVar11 == 8) {
		              return;
		            }
		            if (iVar11 == 9) {
		              return;
		            }
		            if (iVar11 == 10) {
		              return;
		            }
		            if (iVar11 == 0xb) {
		              return;
		            }
		            if (iVar11 == 0xc) {
		              return;
		            }
		            if (iVar11 != 0xd) {
		              return;
		            }
		          }
		          if (((param1_01[4] == 0) &&
		              (iVar2 = System_Linq_Enumerable__FirstOrDefault_object_
		                                 (param1_01[3],
		                                  Method_System_Linq_Enumerable_LastOrDefault_ProtoGetUserIsleInfoAns_Types_IsleInformation___
		                                 ), iVar2 != 0)) && (*(int *)(iVar2 + 0x34) != 0)) {
		            uVar17 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		            iVar11 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar17);
		            uVar4 = (undefined4)((ulonglong)uVar17 >> 0x20);
		            uVar7 = *(undefined4 *)(iVar11 + 0x30);
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            iVar11 = Unity_Properties_PropertyMember___ctor
		                               (0x13,Core_Gameplay_IGame_TypeInfo,
		                                **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c));
		            uVar3 = Sirenix_Serialization_AnySerializer__GetBaseFormatter
		                              (0,Core_Cache_User_IUserInfoWrapper_TypeInfo,
		                               *(undefined4 *)(iVar11 + 0x14),*(undefined4 *)(iVar2 + 0x34));
		            uVar17 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		            iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar17);
		            param3_00 = *(undefined4 *)(iVar2 + 8);
		            uVar17 = CONCAT44((int)((ulonglong)uVar17 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		            uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar17);
		            in_register_20000014 = (undefined4)((ulonglong)uVar17 >> 0x20);
		            uVar4 = Gameplay_Isles_User_Controller_UserIsleController__SetIsleInformation(uVar4,0);
		            param1_00 = unnamed_function_1417(Gameplay_Isles_User_UserIsle_TypeInfo);
		            Gameplay_Isles_User_UserIsle__ToString(param1_00,uVar3,param3_00,uVar4,0);
		            Gameplay_Isles_User_UserIsle___ctor
		                      (uVar7,param1_00,Method_Gameplay_World_Model_IsleHeap_UserIsle__AddToHeap__);
		          }
		          uVar17 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar17);
		          uVar4 = (undefined4)((ulonglong)uVar17 >> 0x20);
		          *(int *)(*(int *)(iVar2 + 0x30) + 0xc) = param1_01[4];
		          if ((char)param1_02[4] != '\0') {
		            iVar11 = *param1;
		            iVar2 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                              (param1,CONCAT44(uVar4,*(undefined4 *)(iVar11 + 0x104)));
		            uVar17 = *(undefined8 *)(param1_02 + 2);
		            uVar7 = Gameplay_World_Model_IsleHeap_object___Dispose
		                              (*(undefined4 *)(iVar2 + 0x30),uVar17,
		                               Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		            uVar4 = (undefined4)((ulonglong)uVar17 >> 0x20);
		            Gameplay_World_Controller_WorldController__GetColossusInfoServiceResultHandler
		                      (param1,uVar7,iVar11);
		          }
		          if (*(char *)((int)param1 + 9) == '\0') {
		            *(undefined1 *)((int)param1 + 9) = 1;
		            iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                              (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x114)));
		            iVar2 = *(int *)(iVar2 + 8);
		            if (iVar2 != 0) {
		              (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                        (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		            }
		          }
		          param1[0xc] = 0;
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11c,&local_10);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x6686", Offset = "0x6686", VA = "0x6686")]
		private void GetUserIsleInfoServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x6687", Offset = "0x6687", VA = "0x6687")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_World_Controller_WorldController__ValidateInit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58188 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController_GetColossusInfoServiceResultHandler__
		              );
		    DAT_ram_00a58188 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__ServerEventHandler
		                        (*(undefined4 *)(param1 + 0x24),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_World_Controller_WorldController_GetColossusInfoServiceResultHandler__,
		             0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x6688", Offset = "0x6688", VA = "0x6688")]
		public void GoToAxisIsle()
		{
		/* --- GHIDRA: GoToAxisIsle ---
		void Gameplay_World_Controller_WorldController__GoToAxisIsle
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  int *param1_01;
		  
		  if (DAT_ram_00a58189 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_AxisIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusInfoAns_TypeInfo);
		    DAT_ram_00a58189 = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  param3_00 = *(undefined4 *)(iVar3 + 8);
		  uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  param4 = *(undefined4 *)(iVar3 + 0xc);
		  uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar2);
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  param1_01 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x80eafde1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eafde1:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,CONCAT44(uVar5,puVar4[1]));
		  param1_00 = unnamed_function_1417(Gameplay_Isles_Axis_AxisIsle_TypeInfo);
		  Gameplay_Isles_Base_Events_BaseIsleEvents___ctor(param1_00,0,param3_00,param4,uVar5,0);
		  Gameplay_World_Controller_WorldController__SetCurrentClanIsleData(param1,param1_00,uVar5);
		  return;
		}
		*/

		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x6689", Offset = "0x6689", VA = "0x6689")]
		private void GetColossusInfoServiceResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetColossusInfoServiceResultHandler ---
		void Gameplay_World_Controller_WorldController__GetColossusInfoServiceResultHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  longlong lVar2;
		  uint uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int *param2_00;
		  undefined4 param2_01;
		  undefined8 uVar9;
		  undefined4 local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a5818a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_WasViewed__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__get_List__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserIsle__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserIsle__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_UserIsle___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17946);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a5818a = '\x01';
		  }
		  uVar9 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar9);
		  uVar8 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  if (*(int *)(iVar4 + 0x24) == 0) {
		    uVar9 = 0;
		  }
		  else {
		    uVar9 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar9);
		    uVar8 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    uVar9 = *(undefined8 *)(*(int *)(iVar4 + 0x24) + 0x18);
		  }
		  uVar1 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  *(int **)(iVar4 + 0x24) = param2;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  lVar2 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),
		                   Method_System_Collections_Generic_List_UserIsle__ToArray__);
		  iVar4 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x30) + 0x10),
		                     Method_System_Collections_Generic_List_UserIsle__ToArray__);
		  uVar8 = (undefined4)((ulonglong)lVar2 >> 0x20);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      param2_00 = *(int **)(iVar4 + iVar6 * 4 + 0x10);
		      if ((param2_00 != param2) && ((char)param2_00[8] != '\0')) {
		        uVar1 = CONCAT44((int)((ulonglong)lVar2 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		        uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		        Gameplay_World_Model_IsleHeap_object___IsHeapNeedUpdate
		                  (*(undefined4 *)(iVar5 + 0x30),param2_00,
		                   Method_Gameplay_World_Model_IsleHeap_UserIsle__Remove__);
		        if (DAT_ram_00a5818f == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		                    );
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__set_WasViewed__
		                    );
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__SetIsCurrentIsle__
		                    );
		          DAT_ram_00a5818f = '\x01';
		        }
		        uVar1 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104));
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		        uVar3 = (uint)((ulonglong)uVar1 >> 0x20);
		        if (param2_00 == *(int **)(iVar5 + 0x20)) {
		          lVar2 = (ulonglong)uVar3 << 0x20;
		          Gameplay_Isles_Base_Controller_BaseIsleController_object__object___Dispose
		                    (param2_00[5],0,
		                     Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__SetIsCurrentIsle__
		                    );
		          *(undefined1 *)(param2_00 + 8) = 0;
		        }
		        else {
		          lVar2 = CONCAT44(uVar3,*(undefined4 *)(*param2_00 + 0x124));
		          (**(code **)((ulonglong)*(uint *)(*param2_00 + 0x120) * 4))(param2_00,lVar2);
		        }
		      }
		      uVar8 = (undefined4)((ulonglong)lVar2 >> 0x20);
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar4 + 0xc));
		  }
		  iVar4 = *param1;
		  uVar1 = CONCAT44(uVar8,*(undefined4 *)(iVar4 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))(param1,uVar1);
		  uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(iVar6 + 0x1c) != 1) {
		    Gameplay_World_Controller_WorldController__ClearUserIsleHeap(param1,iVar4);
		    uVar1 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar6 + 0x28) = 0;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar6 + 0x2c) = 0;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar6 + 0x1c) = 1;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		    uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar6 = *(int *)(iVar6 + 0x14);
		    if (iVar6 != 0) {
		      uVar1 = CONCAT44(uVar8,*(undefined4 *)(iVar6 + 0x14));
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))(*(undefined4 *)(iVar6 + 0x20),uVar1);
		      uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		  }
		  uVar1 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x114));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		  uVar8 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar6 = *(int *)(iVar6 + 0x1c);
		  if (iVar6 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		              (*(undefined4 *)(iVar6 + 0x20),uVar9,*(undefined4 *)(iVar6 + 0x14));
		    uVar8 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  }
		  uVar9 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar9);
		  param2_01 = *(undefined4 *)(iVar6 + 0x24);
		  uVar9 = CONCAT44((int)((ulonglong)uVar9 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar9);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x30) + 0x10) + 0xc);
		  uVar8 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar7 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar7 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_17946,param2_01,uVar7,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x104)));
		  uVar8 = System_String__Join_long_
		                    (StringLiteral_1236,*(undefined4 *)(*(int *)(iVar6 + 0x30) + 0x10),
		                     Method_System_String_Join_UserIsle___);
		  uVar8 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar7,uVar8,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar8,0);
		  return;
		}
		*/

		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x668A", Offset = "0x668A", VA = "0x668A")]
		private void SetCurrentUserIsleData(UserIsle userIsleData)
		{
		/* --- GHIDRA: SetCurrentUserIsleData ---
		void Gameplay_World_Controller_WorldController__SetCurrentUserIsleData
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param2_00;
		  int *param2_01;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 param2_02;
		  undefined8 uVar6;
		  undefined8 local_8;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5818b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_WasViewed__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_ClanIsle__ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanIsle__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__get_List__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ClanIsle__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Controller_WorldController___c__SetCurrentClanIsleData_b__32_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldController___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17942);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a5818b = '\x01';
		  }
		  uVar6 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  *(int **)(iVar1 + 0x28) = param2;
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),
		                   Method_System_Collections_Generic_List_ClanIsle__ToArray__);
		  iVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x10),
		                     Method_System_Collections_Generic_List_ClanIsle__ToArray__);
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar1 = *(int *)(iVar2 + 0xc);
		  if (0 < iVar1) {
		    do {
		      param2_01 = *(int **)(iVar2 + iVar3 * 4 + 0x10);
		      if ((param2_01 != param2) && ((char)param2_01[8] != '\0')) {
		        uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		        uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		        Gameplay_World_Model_IsleHeap_object___IsHeapNeedUpdate
		                  (*(undefined4 *)(iVar1 + 0x34),param2_01,
		                   Method_Gameplay_World_Model_IsleHeap_ClanIsle__Remove__);
		        uVar6 = CONCAT44(uVar4,*(undefined4 *)(*param2_01 + 0x124));
		        (**(code **)((ulonglong)*(uint *)(*param2_01 + 0x120) * 4))(param2_01,uVar6);
		        iVar1 = *(int *)(iVar2 + 0xc);
		      }
		      uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < iVar1);
		  }
		  iVar1 = *param1;
		  uVar6 = CONCAT44(uVar4,*(undefined4 *)(iVar1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))(param1,uVar6);
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  if (*(int *)(iVar3 + 0x1c) != 2) {
		    Gameplay_World_Controller_WorldController__GoHome(param1,iVar1);
		    uVar6 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    *(undefined4 *)(iVar3 + 0x24) = 0;
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    *(undefined4 *)(iVar3 + 0x2c) = 0;
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		    *(undefined4 *)(iVar3 + 0x1c) = 2;
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      uVar6 = CONCAT44(uVar4,*(undefined4 *)(iVar3 + 0x14));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))(*(undefined4 *)(iVar3 + 0x20),uVar6);
		      uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    }
		  }
		  uVar6 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar6);
		  uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar3 = *(int *)(iVar3 + 0x1c);
		  if (iVar3 != 0) {
		    uVar6 = *(undefined8 *)(param2 + 6);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar6,*(undefined4 *)(iVar3 + 0x14));
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  }
		  local_8 = *(undefined8 *)(param2 + 6);
		  param2_00 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		  uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x34) + 0x10);
		  if (*(int *)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_World_Controller_WorldController___c_TypeInfo);
		  }
		  param1_01 = StringLiteral_17942;
		  param1_00 = StringLiteral_1236;
		  puVar5 = *(undefined4 **)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c);
		  iVar3 = puVar5[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_World_Controller_WorldController___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c);
		    }
		    param2_02 = *puVar5;
		    iVar3 = unnamed_function_1417(System_Func_ClanIsle__ulong__TypeInfo);
		    func_ii_7542(iVar3,param2_02,
		                 Method_Gameplay_World_Controller_WorldController___c__SetCurrentClanIsleData_b__32_0__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar4 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (uVar4,iVar3,Method_System_Linq_Enumerable_Select_ClanIsle__ulong___);
		  uVar4 = System_String__Join_uint_(param1_00,uVar4,Method_System_String_Join_ulong___);
		  uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (param1_01,param2_00,uVar4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x668B", Offset = "0x668B", VA = "0x668B")]
		private void SetCurrentClanIsleData(ClanIsle clanIsleData)
		{
		/* --- GHIDRA: SetCurrentClanIsleData ---
		void Gameplay_World_Controller_WorldController__SetCurrentClanIsleData
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5818c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17941);
		    DAT_ram_00a5818c = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  *(int *)(iVar3 + 0x2c) = param2;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(iVar3 + 0x1c) != 4) {
		    Gameplay_World_Controller_WorldController__GoHome(param1,param1);
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar3 + 0x24) = 0;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar3 + 0x28) = 0;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar3 + 0x1c) = 4;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x14);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x14));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))(*(undefined4 *)(iVar3 + 0x20),uVar1);
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		  iVar3 = *(int *)(iVar3 + 0x1c);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined8 *)(param2 + 0x18),
		               *(undefined4 *)(iVar3 + 0x14));
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_17941,0);
		  return;
		}
		*/

		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x668C", Offset = "0x668C", VA = "0x668C")]
		private void SetCurrentAxisIsleData(AxisIsle axisIsleData)
		{
		/* --- GHIDRA: SetCurrentAxisIsleData ---
		void Gameplay_World_Controller_WorldController__SetCurrentAxisIsleData
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined8 param2_00;
		  
		  Gameplay_World_Controller_WorldController__GoHome(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  Gameplay_World_Controller_WorldController__GetClanIsleInfoServiceHandler
		            (param1,param2_00,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x668D", Offset = "0x668D", VA = "0x668D", Slot = "12")]
		public void GoHome()
		{
		/* --- GHIDRA: GoHome ---
		void Gameplay_World_Controller_WorldController__GoHome(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param2_00;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5818d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__get_List__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__set_IsInvalid__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_UserIsle__ToArray__);
		    DAT_ram_00a5818d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(*(int *)(iVar1 + 0x30) + 8) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x30) + 0x10),
		                     Method_System_Collections_Generic_List_UserIsle__ToArray__);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param2_00 = *(int **)(iVar1 + iVar3 * 4 + 0x10);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      Gameplay_World_Model_IsleHeap_object___IsHeapNeedUpdate
		                (*(undefined4 *)(iVar2 + 0x30),param2_00,
		                 Method_Gameplay_World_Model_IsleHeap_UserIsle__Remove__);
		      if (DAT_ram_00a5818f == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__set_WasViewed__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__SetIsCurrentIsle__
		                  );
		        DAT_ram_00a5818f = '\x01';
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (param2_00 == *(int **)(iVar2 + 0x20)) {
		        Gameplay_Isles_Base_Controller_BaseIsleController_object__object___Dispose
		                  (param2_00[5],0,
		                   Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__SetIsCurrentIsle__
		                  );
		        *(undefined1 *)(param2_00 + 8) = 0;
		      }
		      else {
		        (**(code **)((ulonglong)*(uint *)(*param2_00 + 0x120) * 4))
		                  (param2_00,*(undefined4 *)(*param2_00 + 0x124));
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x668E", Offset = "0x668E", VA = "0x668E")]
		private void ClearUserIsleHeap()
		{
		/* --- GHIDRA: ClearUserIsleHeap ---
		void Gameplay_World_Controller_WorldController__ClearUserIsleHeap(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param2_00;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5818e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__get_List__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ClanIsle__ToArray__);
		    DAT_ram_00a5818e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x10),
		                     Method_System_Collections_Generic_List_ClanIsle__ToArray__);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param2_00 = *(int **)(iVar1 + iVar3 * 4 + 0x10);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      Gameplay_World_Model_IsleHeap_object___IsHeapNeedUpdate
		                (*(undefined4 *)(iVar2 + 0x34),param2_00,
		                 Method_Gameplay_World_Model_IsleHeap_ClanIsle__Remove__);
		      (**(code **)((ulonglong)*(uint *)(*param2_00 + 0x120) * 4))
		                (param2_00,*(undefined4 *)(*param2_00 + 0x124));
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x668F", Offset = "0x668F", VA = "0x668F")]
		private void ClearClanIsleHeap()
		{
		/* --- GHIDRA: ClearClanIsleHeap ---
		void Gameplay_World_Controller_WorldController__ClearClanIsleHeap
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5818f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__set_WasViewed__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__SetIsCurrentIsle__
		              );
		    DAT_ram_00a5818f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param2 != *(int **)(iVar1 + 0x20)) {
		    (**(code **)((ulonglong)*(uint *)(*param2 + 0x120) * 4))
		              (param2,*(undefined4 *)(*param2 + 0x124));
		    return;
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleController_object__object___Dispose
		            (param2[5],0,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleController_UserIsleModel__UserIsleEvents__SetIsCurrentIsle__
		            );
		  *(undefined1 *)(param2 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x6690", Offset = "0x6690", VA = "0x6690")]
		private void DisposeIsle(UserIsle isle)
		{
		/* --- GHIDRA: DisposeIsle ---
		void Gameplay_World_Controller_WorldController__DisposeIsle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58190 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_HandleServiceGetAnimationsInfo__);
		    DAT_ram_00a58190 = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__CancelBuilding(*(undefined4 *)(param1 + 0x1c),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_World_Controller_WorldController_HandleServiceGetAnimationsInfo__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		/* --- GHIDRA: DisposeIsle ---
		void Gameplay_World_Controller_WorldController__DisposeIsle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58190 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_HandleServiceGetAnimationsInfo__);
		    DAT_ram_00a58190 = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__CancelBuilding(*(undefined4 *)(param1 + 0x1c),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_World_Controller_WorldController_HandleServiceGetAnimationsInfo__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x6691", Offset = "0x6691", VA = "0x6691")]
		private void DisposeIsle(ClanIsle isle)
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x6692", Offset = "0x6692", VA = "0x6692")]
		public void GetIsleAnimationsInfo()
		{
		/* --- GHIDRA: GetIsleAnimationsInfo ---
		void Gameplay_World_Controller_WorldController__GetIsleAnimationsInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 *puVar2;
		  float param3_00;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint *puVar6;
		  int *piVar7;
		  int iVar8;
		  ulonglong param1_00;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58191 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetAnimationsInfoAns_Types_UserAnimationInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetAnimationsInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetAnimationsInfoAns_Types_UserAnimationInfo__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58191 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_World_ProtoGetAnimationsInfoAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_World_ProtoGetAnimationsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar7[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_ProtoGetAnimationsInfoAns_Types_UserAnimationInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80eb021d;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb04d4:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb04dc;
		    }
		code_r0x80eb021d:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb04d4;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80eb0525;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_ProtoGetAnimationsInfoAns_Types_UserAnimationInfo__TypeInfo
		            == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80eb02f7;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProtoGetAnimationsInfoAns_Types_UserAnimationInfo__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb0498:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb04dc;
		    }
		code_r0x80eb02f7:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb0498;
		    param1_00 = (ulonglong)*(uint *)(iVar8 + 0x10);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,Utils_TimeUtils_TypeInfo);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80eb04dc;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    param3_00 = unnamed_function_184074(param1_00);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    in_register_20000004 = (undefined4)(param1_00 >> 0x20);
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb04dc;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Utils_BackTime_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eb04b6:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb04dc;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vifi
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11e,uVar4,param3_00,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eb04b6;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eb04dc;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11f,*(undefined4 *)(iVar3 + 0x3c)
		               ,*(undefined4 *)(iVar8 + 0xc),uVar4,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eb04dc:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80eb0525:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8)) {
		              puVar6 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80eb059d;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar10);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80eb059d:
		        uVar1 = CONCAT44(in_register_20000004,piVar7);
		        (**(code **)((ulonglong)*puVar6 * 4))(uVar1,puVar6[1]);
		        in_register_20000004 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      }
		      if (iVar8 == 0) {
		        uVar1 = CONCAT44(in_register_20000004,param1);
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (uVar1,*(undefined4 *)(*param1 + 0x104));
		        uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		        Utils_Timers_TimerTracker___ctor(*(undefined4 *)(iVar8 + 0x3c),0);
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (CONCAT44(uVar4,param1),*(undefined4 *)(*param1 + 0x114));
		        iVar8 = *(int *)(iVar8 + 0x24);
		        if (iVar8 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		                    (*(undefined4 *)(iVar8 + 0x20),*(undefined4 *)(iVar8 + 0x14));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x120,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x6693", Offset = "0x6693", VA = "0x6693")]
		private void HandleServiceGetAnimationsInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetAnimationsInfo ---
		void Gameplay_World_Controller_WorldController__HandleServiceGetAnimationsInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58192 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_HandleServiceStartAnimation__);
		    DAT_ram_00a58192 = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__GetAnimationsInfo
		                    (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param2 + 8),
		                     *(undefined8 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_World_Controller_WorldController_HandleServiceStartAnimation__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x6694", Offset = "0x6694", VA = "0x6694")]
		public void StartAnimation(IsleAnimationRequestVo data)
		{
		/* --- GHIDRA: StartAnimation ---
		void Gameplay_World_Controller_WorldController__StartAnimation
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar2;
		  undefined8 uVar1;
		  int iVar3;
		  float param2_00;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int *param1_01;
		  undefined4 param3_00;
		  ulonglong param1_02;
		  uint uVar8;
		  
		  if (DAT_ram_00a58193 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedWorldAnimationErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Events_Scopes_IsleScope_IsleAnimationButtonClickEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoStartAnimationAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58193 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_World_ProtoStartAnimationAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_World_ProtoStartAnimationAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar7[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedWorldAnimationErrors__ExpectedBillingErrors___
		                    );
		  if (iVar3 == 0) {
		    param1_01 = *(int **)(param2 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo + 0xb8) * 4
		                  + -4) != Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_01,Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param1_02 = (ulonglong)(uint)piVar7[4];
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(param1_02,0);
		    uVar2 = (undefined4)(param1_02 >> 0x20);
		    uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,param2_00,0);
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x104));
		    *(int **)(iVar3 + 0x18) = param1_01;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    Utils_BackTime___ctor(*(undefined4 *)(iVar3 + 0x3c),param1_01[2],uVar4,0);
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    Utils_Timers_TimerTracker___ctor(*(undefined4 *)(iVar3 + 0x3c),0);
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x114));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x24);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))(uVar1,*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    uVar1 = CONCAT44(uVar2,param1);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar8 = 0;
		    piVar7 = *(int **)(iVar3 + 0xc);
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80eb093a;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80eb093a:
		    uVar1 = CONCAT44(uVar2,piVar7);
		    piVar7 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(uVar1,puVar5[1]);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar8 = 0;
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + iVar3 + 0x100);
		          goto code_r0x80eb09bc;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,8);
		code_r0x80eb09bc:
		    uVar1 = CONCAT44(uVar2,piVar7);
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(uVar1,puVar5[1]);
		    iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x3c) + 0xc);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),param1);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (uVar1,*(undefined4 *)(*param1 + 0x104));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar8 = 0;
		      piVar7 = *(int **)(iVar6 + 0xc);
		      iVar6 = *piVar7;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + iVar6 + 0xe0);
		            goto code_r0x80eb0a61;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80eb0a61:
		      uVar1 = CONCAT44(uVar2,piVar7);
		      uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(uVar1,puVar5[1]);
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),param1);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (uVar1,*(undefined4 *)(*param1 + 0x104));
		      param3_00 = *(undefined4 *)(iVar6 + 0xc);
		      iVar6 = param1_01[2];
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_IsleScope_IsleAnimationButtonClickEventArgs_TypeInfo
		                            );
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,uVar4,param3_00,iVar6,0);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x20)),param1_00,
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x6695", Offset = "0x6695", VA = "0x6695")]
		private void HandleServiceStartAnimation(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceStartAnimation ---
		void Gameplay_World_Controller_WorldController__HandleServiceStartAnimation
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58194 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_Controller_WorldController_HandleServiceKickFromIsle__);
		    DAT_ram_00a58194 = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__StartAnimation(*(undefined4 *)(param1 + 0x1c),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_World_Controller_WorldController_HandleServiceKickFromIsle__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x6696", Offset = "0x6696", VA = "0x6696")]
		public void KickFromIsle(ulong userId)
		{
		/* --- GHIDRA: KickFromIsle ---
		void Gameplay_World_Controller_WorldController__KickFromIsle
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x6697", Offset = "0x6697", VA = "0x6697")]
		private void HandleServiceKickFromIsle(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceKickFromIsle ---
		void Gameplay_World_Controller_WorldController__HandleServiceKickFromIsle(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58195 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_WorldController___c_TypeInfo);
		    DAT_ram_00a58195 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_World_Controller_WorldController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_World_Controller_WorldController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x18")]
		private bool _userHasClan;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x1C")]
		private WorldService _worldService;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[FieldOffset(Offset = "0x20")]
		private ClanIsleService _clanIsleService;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[FieldOffset(Offset = "0x24")]
		private ColossusService _colossusService;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x28")]
		private readonly CommandsRepository _commandsRepository;

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0x2C")]
		private ClansService _clansService;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x30")]
		private OpToken<IMessage, object> _tokenOfGetUserIsleInfoRequest;
	}
}
