using System;
using Core.Gameplay;
using DG.Tweening;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.ClanIsle;
using Protocol.Consts;
using ServicesNamespace;
using Utils;

namespace Gameplay.Isles.Clan.Controller
{
	// Token: 0x02000CF5 RID: 3317
	[Token(Token = "0x2000CF5")]
	public class ClanIsleController : BaseIsleController<ClanIsleModel, Gameplay.Isles.Clan.Events.ClanIsleEvents>
	{
		// Token: 0x060050B6 RID: 20662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x9EC5", Offset = "0x9EC5", VA = "0x9EC5")]
		public ClanIsleController(IGame game, ClanIsleModel model, Gameplay.Isles.Clan.Events.ClanIsleEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cb8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGolemStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingAcceleratedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingCanceledEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingFinishedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnGolemStateChangedEvent__
		              );
		    DAT_ram_00a58cb8 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoGolemStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnGolemStateChangedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__remove_BuildingCanceledEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingStartedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__remove_BuildingFinishedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingAcceleratedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingCanceledEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__remove_BuildingStartedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingFinishedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__remove_BuildingAcceleratedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x9EC6", Offset = "0x9EC6", VA = "0x9EC6", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cb9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGolemStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingAcceleratedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingCanceledEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingFinishedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnGolemStateChangedEvent__
		              );
		    DAT_ram_00a58cb9 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoGolemStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnGolemStateChangedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__add_GolemStateChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingStartedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__add_BuildingStartedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingAcceleratedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__add_BuildingAcceleratedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingCanceledEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__add_BuildingCanceledEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoBuildingFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_ClanIsleServiceOnBuildingFinishedEvent__
		             ,0);
		  ServicesNamespace_ClanIsleService__add_BuildingFinishedEvent(uVar2,uVar1,0);
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x20),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x9EC7", Offset = "0x9EC7", VA = "0x9EC7", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Isles_Clan_Model_ClanIsleModel__get_IsleInformation(param1_00,param2,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x9EC8", Offset = "0x9EC8", VA = "0x9EC8")]
		public void SetIsleInformation(ProtoGetIsleInfoAns.Types.ClanIsleInformation isleInformation)
		{
		/* --- GHIDRA: SetIsleInformation ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__SetIsleInformation
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58cba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_StartBuildingServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a58cba = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		        goto code_r0x80f97656;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f97656:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x18) + 8);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x138) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x13c));
		  iVar4 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(uVar5,uVar3,0);
		  if (iVar4 != 0) {
		    uVar3 = ServicesNamespace_ClanIsleService__GetClanIsleInfo
		                      (*(undefined4 *)(param1 + 0x18),param3,0);
		    uVar5 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_StartBuildingServiceHandler__
		               ,0);
		    uVar3 = ServicesNamespace_MainService__GetUserStats
		                      (uVar3,uVar5,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar3 = DG_Tweening_TweenParams__SetId
		                      (uVar3,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050BA RID: 20666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x9EC9", Offset = "0x9EC9", VA = "0x9EC9")]
		public void StartBuild(BaseBuildingData clanBuildingData, ClanBuildingTypes type)
		{
		/* --- GHIDRA: StartBuild ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__StartBuild
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cbb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_AccelerateBuildServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a58cbb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  uVar1 = ServicesNamespace_ClanIsleService__StartClanBuild(uVar2,uVar1,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_AccelerateBuildServiceHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060050BB RID: 20667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x9ECA", Offset = "0x9ECA", VA = "0x9ECA")]
		public void AccelerateBuild(BaseBuildingData data)
		{
		/* --- GHIDRA: AccelerateBuild ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__AccelerateBuild
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58cbc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanBuildingTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Clan_Controller_ClanIsleController_CancelBuildServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a58cbc = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanIsleService__AccelerateClanBuilding
		                    (*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_CancelBuildServiceHandler__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(Protocol_Consts_ClanBuildingTypes_TypeInfo,&local_4);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060050BC RID: 20668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x9ECB", Offset = "0x9ECB", VA = "0x9ECB")]
		public void CancelBuild(ClanBuildingTypes typeId)
		{
		/* --- GHIDRA: CancelBuild ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__CancelBuild(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a58cbd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_RepayCreditDebtResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58cbd = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80f9790f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f9790f:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x10) + 0x18);
		  iVar3 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		                    (*(undefined4 *)(iVar3 + 8),*(undefined4 *)(iVar3 + 0xc),0);
		  if (iVar3 != 0) {
		    param1_00 = ServicesNamespace_ClansService__OnCreateClan(*(undefined4 *)(param1 + 0x1c),0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_RepayCreditDebtResultHandler__
		               ,0);
		    ServicesNamespace_MainService__GetUserStats
		              (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050BD RID: 20669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x9ECC", Offset = "0x9ECC", VA = "0x9ECC")]
		public void RepayCreditDebt()
		{
		/* --- GHIDRA: RepayCreditDebt ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__RepayCreditDebt
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a58cbe == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_BaseBuildingData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanBuildingEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBuildingErrors__ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoStartBuildingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5450);
		    DAT_ram_00a58cbe = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_ClanIsle_ProtoStartBuildingAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_ClanIsle_ProtoStartBuildingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar3[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBuildingErrors__ExpectedClanBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_5450,0);
		    piVar3 = *(int **)(param2 + 0xc);
		    if (piVar3 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_World_Model_BaseBuildingData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(Gameplay_World_Model_BaseBuildingData_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_World_Model_BaseBuildingData_TypeInfo)) {
		        System_Activator__CreateInstance(piVar3,Gameplay_World_Model_BaseBuildingData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x18);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(undefined4 *)(iVar2 + 0x30);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_ClansScope_ClanBuildingEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,param4,piVar3,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050BE RID: 20670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x9ECD", Offset = "0x9ECD", VA = "0x9ECD")]
		private void StartBuildingServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: StartBuildingServiceHandler ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__StartBuildingServiceHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58cbf == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoAccelerateBuildingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5448);
		    DAT_ram_00a58cbf = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_ClanIsle_ProtoAccelerateBuildingAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_ClanIsle_ProtoAccelerateBuildingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_5448,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050BF RID: 20671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x9ECE", Offset = "0x9ECE", VA = "0x9ECE")]
		private void AccelerateBuildServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AccelerateBuildServiceHandler ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__AccelerateBuildServiceHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58cc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5449);
		    DAT_ram_00a58cc0 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_5449,0);
		  return;
		}
		*/

		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x9ECF", Offset = "0x9ECF", VA = "0x9ECF")]
		private void CancelBuildServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelBuildServiceHandler ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__CancelBuildServiceHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a58cc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    DAT_ram_00a58cc1 = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar4[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		                    );
		  if (iVar2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		          goto code_r0x80f97d3d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f97d3d:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    Gameplay_Clans_Model_TreasuryData__UpdateTreasury
		              (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x18),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_World_Model_ClanData__Gameplay_World_Model_ClanData_IManagedClanData_SetClanInfo
		              (*(undefined4 *)(iVar2 + 0x30),2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x9ED0", Offset = "0x9ED0", VA = "0x9ED0")]
		private void RepayCreditDebtResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RepayCreditDebtResultHandler ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__RepayCreditDebtResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  float param2_00;
		  undefined4 param1_00;
		  longlong lVar3;
		  ulonglong param1_01;
		  
		  lVar3 = *(longlong *)(param2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x104));
		  if (lVar3 == *(longlong *)(iVar2 + 0x10)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = (ulonglong)*(uint *)(param2 + 0x1c);
		    if (DAT_ram_00a58cb3 == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a58cb3 = '\x01';
		    }
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(param1_01,0);
		    uVar1 = (undefined4)(param1_01 >> 0x20);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(iVar2 + 0x34) = param1_00;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar1,param1),*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x9ED1", Offset = "0x9ED1", VA = "0x9ED1")]
		private void ClanIsleServiceOnGolemStateChangedEvent(ProtoGolemStateChangedEvt evt)
		{
		/* --- GHIDRA: ClanIsleServiceOnGolemStateChangedEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__ClanIsleServiceOnGolemStateChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58cc2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cc2 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f97f32;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f97f32:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,CONCAT44(in_register_20000014,puVar3[1]));
		  iVar4 = *(int *)(*(int *)(iVar4 + 0x14) + 0x28);
		  if (iVar4 != 0) {
		    iVar5 = *(int *)(iVar4 + 0x10);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar5 == iVar4) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar4 + 0x24),*(undefined4 *)(param2 + 0xc),
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		      uVar2 = 0;
		      Gameplay_World_Model_BaseBuildingData___ctor(param1_00,0,0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		      iVar4 = *(int *)(iVar4 + 0x14);
		      if (iVar4 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(param2 + 0xc),
		                   *(undefined4 *)(iVar4 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x9ED2", Offset = "0x9ED2", VA = "0x9ED2")]
		private void ClanIsleServiceOnBuildingCanceledEvent(ProtoBuildingCanceledEvt evt)
		{
		/* --- GHIDRA: ClanIsleServiceOnBuildingCanceledEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__ClanIsleServiceOnBuildingCanceledEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58cc3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cc3 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80f980a2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f980a2:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x14) + 0x28);
		  if (iVar3 != 0) {
		    iVar4 = *(int *)(iVar3 + 0x10);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar4 == iVar3) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar3 + 0x24),*(undefined4 *)(param2 + 0xc),
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		      Gameplay_World_Model_BaseBuildingData___ctor(param1_00,*(undefined8 *)(param2 + 0x10),0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar3 = *(int *)(iVar3 + 0x14);
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                   *(undefined4 *)(iVar3 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x9ED3", Offset = "0x9ED3", VA = "0x9ED3")]
		private void ClanIsleServiceOnBuildingAcceleratedEvent(ProtoBuildingAcceleratedEvt evt)
		{
		/* --- GHIDRA: ClanIsleServiceOnBuildingAcceleratedEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__ClanIsleServiceOnBuildingAcceleratedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58cc4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cc4 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80f98215;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f98215:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x14) + 0x28);
		  if (iVar3 != 0) {
		    iVar4 = *(int *)(iVar3 + 0x10);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar4 == iVar3) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(iVar3 + 0x24),*(undefined4 *)(param2 + 0xc),
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		      Gameplay_World_Model_BaseBuildingData___ctor(param1_00,*(undefined8 *)(param2 + 0x10),0);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar3 = *(int *)(iVar3 + 0x14);
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param2 + 0xc),
		                   *(undefined4 *)(iVar3 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x9ED4", Offset = "0x9ED4", VA = "0x9ED4")]
		private void ClanIsleServiceOnBuildingStartedEvent(ProtoBuildingStartedEvt evt)
		{
		/* --- GHIDRA: ClanIsleServiceOnBuildingStartedEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__ClanIsleServiceOnBuildingStartedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined8 uVar8;
		  
		  if (DAT_ram_00a58cc5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Clan_Controller_ClanIsleController_RequestClanIsle__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_GolemInfoWindow___);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a58cc5 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80f983a8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f983a8:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar6 = *(int *)(*(int *)(iVar6 + 0x14) + 0x28);
		  if (iVar6 != 0) {
		    iVar7 = *(int *)(iVar6 + 0x10);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar7 == iVar6) {
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar6 + 0x24),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      Gameplay_World_Model_BaseBuildingData__get_AcceleratePrice
		                (uVar3,*(undefined4 *)(param2 + 0x10),0);
		      uVar4 = 0;
		      Gameplay_World_Model_BaseBuildingData___ctor(uVar3,0,0);
		      uVar8 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x114));
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar8);
		      uVar4 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      iVar6 = *(int *)(iVar6 + 0x14);
		      if (iVar6 != 0) {
		        uVar8 = CONCAT44(uVar4,*(undefined4 *)(param2 + 0xc));
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                  (*(undefined4 *)(iVar6 + 0x20),uVar8,*(undefined4 *)(iVar6 + 0x14));
		        uVar4 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      }
		      if ((*(int *)(param2 + 0xc) == 1) && (*(int *)(param2 + 0x10) == 1)) {
		        uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		        DG_Tweening_Color2__op_Multiply
		                  (uVar3,param1,
		                   Method_Gameplay_Isles_Clan_Controller_ClanIsleController_RequestClanIsle__,0);
		        iVar6 = DG_Tweening_DOVirtual__EasedValue(1.0,uVar3,1,0);
		        param1[8] = iVar6;
		      }
		      iVar7 = *param1;
		      iVar6 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                        (param1,CONCAT44(uVar4,*(undefined4 *)(iVar7 + 0x104)));
		      uVar8 = *(undefined8 *)(*(int *)(*(int *)(*(int *)(iVar6 + 8) + 0x34) + 0x40) + 0x10);
		      Gameplay_Isles_Clan_Controller_ClanIsleController__ClanIsleServiceOnBuildingFinishedEvent
		                (param1,uVar8,iVar7);
		      uVar4 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      uVar1 = 0;
		      piVar5 = (int *)param1[9];
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		            goto code_r0x80f9853d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f9853d:
		      uVar8 = CONCAT44(uVar4,puVar2[1]);
		      piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar8);
		      uVar4 = (undefined4)((ulonglong)uVar8 >> 0x20);
		      uVar1 = 0;
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		            goto code_r0x80f985bd;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x80f985bd:
		      iVar6 = 0;
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar4,puVar2[1]));
		      iVar7 = UI_Windows_PopupController__GetLastWindow_object_
		                        (uVar4,Method_UI_Windows_PopupController_GetWindows_GolemInfoWindow___);
		      if (0 < *(int *)(iVar7 + 0xc)) {
		        do {
		          System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		                    (*(undefined4 *)(iVar7 + iVar6 * 4 + 0x10),3,0);
		          iVar6 = iVar6 + 1;
		        } while (iVar6 < *(int *)(iVar7 + 0xc));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x9ED5", Offset = "0x9ED5", VA = "0x9ED5")]
		private void ClanIsleServiceOnBuildingFinishedEvent(ProtoBuildingFinishedEvt evt)
		{
		/* --- GHIDRA: ClanIsleServiceOnBuildingFinishedEvent ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__ClanIsleServiceOnBuildingFinishedEvent
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58cc6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleController_GetClanIsleInfoServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58cc6 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanIsleService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x18),param2,3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Isles_Clan_Controller_ClanIsleController_GetClanIsleInfoServiceHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x9ED6", Offset = "0x9ED6", VA = "0x9ED6")]
		private void GoToClanIsle(ulong clanId)
		{
		/* --- GHIDRA: GoToClanIsle ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__GoToClanIsle
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int *param1_00;
		  undefined4 uVar6;
		  int local_4;
		  
		  if (DAT_ram_00a58cc7 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData_IManagedClanData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17947);
		    DAT_ram_00a58cc7 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = piVar5[4];
		  if (local_4 < 0) {
		    uVar6 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar6 = func_ii_4419(StringLiteral_17947,uVar6,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar6,0);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0x20) = *(undefined4 *)(piVar5[3] + 0x20);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = *(int **)(iVar2 + 0x30);
		    uVar6 = *(undefined4 *)(piVar5[3] + 0x10);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x80f98842;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f98842:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_World_Model_ClanData_IManagedClanData_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f988ce;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_World_Model_ClanData_IManagedClanData_TypeInfo,
		                                  0);
		code_r0x80f988ce:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar6,uVar4,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x9ED7", Offset = "0x9ED7", VA = "0x9ED7")]
		private void GetClanIsleInfoServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetClanIsleInfoServiceHandler ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__GetClanIsleInfoServiceHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58cc8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cc8 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80f989aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f989aa:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(iVar3 + 0x30),0);
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050C9")]
		[Address(RVA = "0x9ED8", Offset = "0x9ED8", VA = "0x9ED8")]
		private void RequestClanIsle()
		{
		/* --- GHIDRA: RequestClanIsle ---
		void Gameplay_Isles_Clan_Controller_ClanIsleController__RequestClanIsle
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58cc9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView___ctor__
		              );
		    DAT_ram_00a58cc9 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanIsleModel__ClanIsleEvents__ClanIsleController__ClanIsleGolemView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x18")]
		private readonly ClanIsleService _clanIsleService;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ClansService _clansService;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x20")]
		private Tween _delayedCall;

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x24")]
		private readonly IGame _game;
	}
}
