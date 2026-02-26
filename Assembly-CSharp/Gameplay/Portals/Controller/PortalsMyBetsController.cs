using System;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	public class PortalsMyBetsController : AbstractController<PortalsMyBetsModel, PortalsEvents>
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x757B", Offset = "0x757B", VA = "0x757B")]
		public PortalsMyBetsController(PortalsMyBetsModel model, PortalsEvents events, PortalsService portalsService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsMyBetsController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5815b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsMyBetsController_OnUpdateBetsHistory__);
		    DAT_ram_00a5815b = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__DoBet(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsMyBetsController_OnUpdateBetsHistory__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x757C", Offset = "0x757C", VA = "0x757C")]
		public void GetBetsHistory()
		{
		/* --- GHIDRA: GetBetsHistory ---
		void Gameplay_Portals_Controller_PortalsMyBetsController__GetBetsHistory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5815c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetsHistoryAns_TypeInfo);
		    DAT_ram_00a5815c = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Portal_ProtoGetBetsHistoryAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Portal_ProtoGetBetsHistoryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x48) = param1_01[3];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Portals_Model_PortalsMyBetsModel__PopulateUsers(param1_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x4c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x757D", Offset = "0x757D", VA = "0x757D")]
		private void OnUpdateBetsHistory(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnUpdateBetsHistory ---
		void Gameplay_Portals_Controller_PortalsMyBetsController__OnUpdateBetsHistory
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5815d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsMyBetsController_OnGetBetList__);
		    DAT_ram_00a5815d = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__ComebackToStage(*(undefined4 *)(param1 + 0x18),param2,0)
		  ;
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsMyBetsController_OnGetBetList__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x757E", Offset = "0x757E", VA = "0x757E")]
		public void GetBetList(ulong betId)
		{
		/* --- GHIDRA: GetBetList ---
		void Gameplay_Portals_Controller_PortalsMyBetsController__GetBetList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5815e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalBetsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetListAns_TypeInfo);
		    DAT_ram_00a5815e = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Portal_ProtoGetBetListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Portal_ProtoGetBetListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[3],param1,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalBetsErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x54) = param1_01[4];
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Portals_Model_PortalsMyBetsModel___ctor(param1_00,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x3c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x757F", Offset = "0x757F", VA = "0x757F")]
		private void OnGetBetList(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetBetList ---
		void Gameplay_Portals_Controller_PortalsMyBetsController__OnGetBetList
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5815f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView___ctor__
		              );
		    DAT_ram_00a5815f = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x18")]
		private PortalsService _portalsService;
	}
}
