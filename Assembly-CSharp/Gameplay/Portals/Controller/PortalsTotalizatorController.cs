using System;
using System.Collections.Generic;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Portal;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	public class PortalsTotalizatorController : AbstractController<PortalsTotalizatorModel, PortalsEvents>
	{
		// Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x75B3", Offset = "0x75B3", VA = "0x75B3")]
		public PortalsTotalizatorController(PortalsTotalizatorModel model, PortalsEvents events, PortalsService portalsService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x75B4", Offset = "0x75B4", VA = "0x75B4")]
		public void BetRestrictedHandler()
		{
		/* --- GHIDRA: BetRestrictedHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__BetRestrictedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x48);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x75B5", Offset = "0x75B5", VA = "0x75B5")]
		public void ParticipantsForBetNotAvailHandler()
		{
		/* --- GHIDRA: ParticipantsForBetNotAvailHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__ParticipantsForBetNotAvailHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d1d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorController_OnGetBetList__);
		    DAT_ram_00a57d1d = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__ComebackToStage(*(undefined4 *)(param1 + 0x18),0,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorController_OnGetBetList__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x75B6", Offset = "0x75B6", VA = "0x75B6")]
		public void GetBetList()
		{
		/* --- GHIDRA: GetBetList ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__GetBetList
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57d1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBetsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetListAns_TypeInfo);
		    DAT_ram_00a57d1e = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoGetBetListAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoGetBetListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,param1,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBetsErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Portals_Controller_PortalsTotalizatorController__OnUpdateBetList
		              (param1,param1_00[4],param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x75B7", Offset = "0x75B7", VA = "0x75B7")]
		private void OnGetBetList(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetBetList ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__OnGetBetList
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d1f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorController_OnUpdateBetList__);
		    DAT_ram_00a57d1f = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__GetBetList(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorController_OnUpdateBetList__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x75B8", Offset = "0x75B8", VA = "0x75B8")]
		public void UpdateBetList()
		{
		/* --- GHIDRA: UpdateBetList ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__UpdateBetList
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57d20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBetsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoUpdateBetListAns_TypeInfo);
		    DAT_ram_00a57d20 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoUpdateBetListAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoUpdateBetListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,param1,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBetsErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Portals_Controller_PortalsTotalizatorController__OnUpdateBetList
		              (param1,param1_00[4],param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x75B9", Offset = "0x75B9", VA = "0x75B9")]
		private void OnUpdateBetList(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnUpdateBetList ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__OnUpdateBetList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x28) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar1 + 0x30) = *(undefined8 *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x38) = *(undefined4 *)(param2 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x3c) = *(undefined4 *)(param2 + 0x20);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Portals_Model_PortalsTotalizatorModel__set_UpdatePrice(param1_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x3c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x75BA", Offset = "0x75BA", VA = "0x75BA")]
		private void UpdateModel(BetList list)
		{
		/* --- GHIDRA: UpdateModel ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__UpdateModel
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d21 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorController_DoBetHandler__);
		    DAT_ram_00a57d21 = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__UpdateBetList(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorController_DoBetHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x75BB", Offset = "0x75BB", VA = "0x75BB")]
		public void DoBet(IEnumerable<ProtoDoBetCmd.Types.BetChoice> bet)
		{
		/* --- GHIDRA: DoBet ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__DoBet
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57d22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBetsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoDoBetAns_TypeInfo);
		    DAT_ram_00a57d22 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoDoBetAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoDoBetAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,param1,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalBetsErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined8 *)(iVar1 + 0x30) = *(undefined8 *)(param1_00 + 4);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x3c) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x44);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x75BC", Offset = "0x75BC", VA = "0x75BC")]
		private void DoBetHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: DoBetHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorController__DoBetHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57d23 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView___ctor__
		              );
		    DAT_ram_00a57d23 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0x18")]
		private PortalsService _portalsService;
	}
}
