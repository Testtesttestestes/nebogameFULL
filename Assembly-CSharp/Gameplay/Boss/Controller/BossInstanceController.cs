using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Boss;
using ServicesNamespace;
using Utils;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA6 RID: 2982
	[Token(Token = "0x2000BA6")]
	public class BossInstanceController : AbstractController<BossInstanceModel, BossInstanceEvents>
	{
		// Token: 0x060048F0 RID: 18672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x9763", Offset = "0x9763", VA = "0x9763")]
		public BossInstanceController(BossInstanceModel model, BossInstanceEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossInstanceController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamTimeoutEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ActiveTeamArchivedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryTeamsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TeamInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceState__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryInvitesEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamArchivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamTimeoutEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnInstanceStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryInvitesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryTeamsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnTeamInfoChangedEvent__
		              );
		    DAT_ram_00a578c6 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_InstanceState__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnInstanceStateChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_MonsterHealthChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TeamInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnTeamInfoChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_CreateRequestEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_MercenaryTeamsEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryTeamsChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_MercenaryInvitesChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_MercenaryInvitesEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryInvitesChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_InstanceStateChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ActiveTeamArchivedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamArchivedEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_InstanceInfoEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TeamTimeoutEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamTimeoutEvent__
		             ,0);
		  ServicesNamespace_BossService__remove_ActiveTeamArchivedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x9764", Offset = "0x9764", VA = "0x9764", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamTimeoutEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ActiveTeamArchivedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryTeamsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TeamInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_InstanceState__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_MercenaryInvitesEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamArchivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamTimeoutEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnInstanceStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryInvitesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryTeamsChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnTeamInfoChangedEvent__
		              );
		    DAT_ram_00a578c7 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_InstanceState__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnInstanceStateChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__add_InstanceStateChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TeamInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnTeamInfoChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__add_TeamInfoChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_MercenaryTeamsEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryTeamsChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__add_MercenaryTeamsChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_MercenaryInvitesEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnMercenaryInvitesChangedEvent__
		             ,0);
		  ServicesNamespace_BossService__add_MercenaryInvitesChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ActiveTeamArchivedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamArchivedEvent__
		             ,0);
		  ServicesNamespace_BossService__add_ActiveTeamArchivedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TeamTimeoutEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_BossServiceOnActiveTeamTimeoutEvent__
		             ,0);
		  ServicesNamespace_BossService__add_ActiveTeamTimeoutEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x9765", Offset = "0x9765", VA = "0x9765", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleStop(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a578c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetPossibleMercenaries__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578c8 = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar2 = ServicesNamespace_BossService__GetPlace
		                    (param1_01,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetPossibleMercenaries__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x9766", Offset = "0x9766", VA = "0x9766")]
		public void RequestPossibleMercenaries()
		{
		/* --- GHIDRA: RequestPossibleMercenaries ---
		undefined4
		Gameplay_Boss_Controller_BossInstanceController__RequestPossibleMercenaries
		          (int *param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a578c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceCreateTeam__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578c9 = '\x01';
		  }
		  *param2 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (((*(char *)(*(int *)(iVar1 + 0x28) + 0x30) != '\0') &&
		      (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104)),
		      *(int *)(*(int *)(iVar1 + 0x38) + 0x18) == 1)) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x3c) == 0)) {
		    uVar2 = ServicesNamespace_BossService__GetInstanceList(param1[6],0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceCreateTeam__,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    *param2 = uVar2;
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x9767", Offset = "0x9767", VA = "0x9767")]
		public bool TryCreateTeam(out OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TryCreateTeam ---
		void Gameplay_Boss_Controller_BossInstanceController__TryCreateTeam
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceInviteAssistant__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578ca = '\x01';
		  }
		  uVar1 = ServicesNamespace_BossService__CreateTeam(*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceInviteAssistant__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x9768", Offset = "0x9768", VA = "0x9768")]
		public void InviteAssistant(ulong uid)
		{
		/* --- GHIDRA: InviteAssistant ---
		void Gameplay_Boss_Controller_BossInstanceController__InviteAssistant
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceKickAssistant__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578cb = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__InviteAssistant
		                    (param1_00,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceKickAssistant__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x9769", Offset = "0x9769", VA = "0x9769")]
		public void KickAssistant(ulong uid)
		{
		/* --- GHIDRA: KickAssistant ---
		void Gameplay_Boss_Controller_BossInstanceController__KickAssistant
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceAcceptInvitation__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578cc = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__KickAssistant
		                    (param1_00,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceAcceptInvitation__,
		             0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  DG_Tweening_TweenParams__SetId(uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x976A", Offset = "0x976A", VA = "0x976A")]
		public void AcceptInvite(ulong captainId)
		{
		/* --- GHIDRA: AcceptInvite ---
		void Gameplay_Boss_Controller_BossInstanceController__AcceptInvite
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a578cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceRefuseInvitation__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578cd = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__AcceptInvitation
		                    (param1_01,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceRefuseInvitation__,
		             0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x976B", Offset = "0x976B", VA = "0x976B")]
		public void RefuseInvite(ulong captainId)
		{
		/* --- GHIDRA: RefuseInvite ---
		void Gameplay_Boss_Controller_BossInstanceController__RefuseInvite(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceBuyLicence__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578ce = '\x01';
		  }
		  uVar1 = ServicesNamespace_BossService__GetRating(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceBuyLicence__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x976C", Offset = "0x976C", VA = "0x976C")]
		public void BuyLicence()
		{
		/* --- GHIDRA: BuyLicence ---
		void Gameplay_Boss_Controller_BossInstanceController__BuyLicence
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_GetCaptainTeamListServiceHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578cf = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__BeginBattle
		                    (param1_00,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_GetCaptainTeamListServiceHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x976D", Offset = "0x976D", VA = "0x976D")]
		public void GetCaptainTeamList(ulong captainId)
		{
		/* --- GHIDRA: GetCaptainTeamList ---
		undefined4
		Gameplay_Boss_Controller_BossInstanceController__GetCaptainTeamList(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a578d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetPlace__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578d0 = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar2 = ServicesNamespace_BossService__BuyLicence
		                    (param1_01,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetPlace__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060048FB RID: 18683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60048FB")]
		[Address(RVA = "0x976E", Offset = "0x976E", VA = "0x976E")]
		public OpToken<IMessage, object> GetPlace()
		{
		/* --- GHIDRA: GetPlace ---
		void Gameplay_Boss_Controller_BossInstanceController__GetPlace
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a578d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetActiveTeamInfo__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578d1 = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = ServicesNamespace_BossService__GetTeamInfo
		                        (param1_02,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetActiveTeamInfo__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FC")]
		[Address(RVA = "0x976F", Offset = "0x976F", VA = "0x976F")]
		public void GetActiveTeamInfo(ulong captainId)
		{
		/* --- GHIDRA: GetActiveTeamInfo ---
		void Gameplay_Boss_Controller_BossInstanceController__GetActiveTeamInfo
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetCaptainTeams__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578d2 = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__BeginBattle
		                    (param1_00,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetCaptainTeams__,0
		            );
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x9770", Offset = "0x9770", VA = "0x9770")]
		public void GetCaptainTeams(ulong captainId)
		{
		/* --- GHIDRA: GetCaptainTeams ---
		void Gameplay_Boss_Controller_BossInstanceController__GetCaptainTeams(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a578d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetRating__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a578d3 = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar2 = ServicesNamespace_BossService__GetCaptainTeamList
		                    (param1_01,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetRating__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x9771", Offset = "0x9771", VA = "0x9771")]
		public void GetRating()
		{
		/* --- GHIDRA: GetRating ---
		void Gameplay_Boss_Controller_BossInstanceController__GetRating
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetTeamInfoAndRewwards__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578d4 = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__RefuseInvitation
		                    (param1_00,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetTeamInfoAndRewwards__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x9772", Offset = "0x9772", VA = "0x9772")]
		public void GetTeamInfoAndRewards(ulong teamId)
		{
		/* --- GHIDRA: GetTeamInfoAndRewards ---
		void Gameplay_Boss_Controller_BossInstanceController__GetTeamInfoAndRewards
		               (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceDistributeRewards__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a578d5 = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_BossService__GetActiveTeamInfo
		                    (param1_00,*(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10),param2,param3,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceDistributeRewards__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar2 = DG_Tweening_TweenParams__SetId
		                    (uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x9773", Offset = "0x9773", VA = "0x9773")]
		public void DistributeRewards(ulong teamId, List<DistributeRewardsCmd.Types.UserReward> rewards)
		{
		/* --- GHIDRA: DistributeRewards ---
		void Gameplay_Boss_Controller_BossInstanceController__DistributeRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a578d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetMercenariesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578d6 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_GetMercenariesAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_GetMercenariesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00[4],*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x9774", Offset = "0x9774", VA = "0x9774")]
		private void HandleServiceGetPossibleMercenaries(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetPossibleMercenaries ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetPossibleMercenaries
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int param2_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a578d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_CreateTeamAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578d7 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Boss_CreateTeamAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Boss_CreateTeamAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = param1_01[4];
		    if (DAT_ram_00a57882 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TypeInfo);
		      DAT_ram_00a57882 = '\x01';
		    }
		    if (param2_00 == 0) {
		      *(undefined4 *)(iVar1 + 0x3c) = 0;
		    }
		    else if (*(int *)(iVar1 + 0x3c) == 0) {
		      param4 = *(undefined4 *)(iVar1 + 8);
		      param3_00 = *(undefined4 *)(iVar1 + 0x30);
		      param1_00 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TypeInfo);
		      Gameplay_Boss_Model_TeamData__get_MyRatingPlace(param1_00,param2_00,param3_00,param4,param1);
		      *(undefined4 *)(iVar1 + 0x3c) = param1_00;
		    }
		    else {
		      Gameplay_Boss_Model_TeamData__get_RawTeamInfo(*(int *)(iVar1 + 0x3c),param2_00,param1);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x9775", Offset = "0x9775", VA = "0x9775")]
		private void HandleServiceCreateTeam(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceCreateTeam ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceCreateTeam
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 *puVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  int *param1_01;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a578d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_InviteMercenaryAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578d8 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_00 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		    System_Activator__CreateInstance(param1_00,DAT_ram_00a66968);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  puVar1 = (undefined8 *)func_ii_15774(param1_00);
		  uVar4 = *puVar1;
		  if ((param1_01 != (int *)0x0) && (Protocol_Boss_InviteMercenaryAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Boss_InviteMercenaryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x114)));
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(iVar3 + 0x24);
		  }
		  else {
		    iVar2 = *(int *)(iVar3 + 0x2c);
		  }
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x9776", Offset = "0x9776", VA = "0x9776")]
		private void HandleServiceInviteAssistant(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceInviteAssistant ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceInviteAssistant
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 *puVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  int *param1_01;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a578d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_DefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578d9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_00 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		    System_Activator__CreateInstance(param1_00,DAT_ram_00a66968);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  puVar1 = (undefined8 *)func_ii_15774(param1_00);
		  uVar4 = *puVar1;
		  if ((param1_01 != (int *)0x0) && (Protocol_Boss_DefaultAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Boss_DefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x114)));
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(iVar3 + 0x24);
		  }
		  else {
		    iVar2 = *(int *)(iVar3 + 0x2c);
		  }
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x9777", Offset = "0x9777", VA = "0x9777")]
		private void HandleServiceKickAssistant(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceKickAssistant ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceKickAssistant
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 *puVar2;
		  undefined4 param2_00;
		  undefined4 param4;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 param3_00;
		  undefined8 param5;
		  
		  if (DAT_ram_00a578da == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_DefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BossScope_InviteEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578da = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) && (Protocol_Boss_DefaultAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance(piVar3,Protocol_Boss_DefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar3[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar3 = *(int **)(param2 + 0xc);
		    if (piVar3 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar3 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		      System_Activator__CreateInstance(piVar3,DAT_ram_00a66968);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar2 = (undefined8 *)func_ii_15774(piVar3);
		    param5 = *puVar2;
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x38) + 0x14);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104));
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_BossScope_InviteEventArgs_TypeInfo);
		      Core_Events_Scopes_SchoolScope_SchoolEventArgs__get_OwnerId
		                (param1_00,param2_00,param3_00,param4,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x9778", Offset = "0x9778", VA = "0x9778")]
		private void HandleServiceAcceptInvitation(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceAcceptInvitation ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceAcceptInvitation
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a578db == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_DefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578db = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_DefaultAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_DefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x9779", Offset = "0x9779", VA = "0x9779")]
		private void HandleServiceRefuseInvitation(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceRefuseInvitation ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceRefuseInvitation
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a578dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_BuyLicenseAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578dc = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_BuyLicenseAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_BuyLicenseAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[4],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if ((iVar1 == 0) && (iVar2 == 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x40) = param1_00[5];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x38);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x977A", Offset = "0x977A", VA = "0x977A")]
		private void HandleServiceBuyLicence(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceBuyLicence ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceBuyLicence
		               (int *param1,int param2,undefined4 param3)
		
		{
		  longlong *plVar1;
		  int iVar2;
		  longlong lVar3;
		  int *param1_00;
		  int *param1_01;
		  longlong lVar4;
		  
		  if (DAT_ram_00a578dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetCaptainTeamListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578dd = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_GetCaptainTeamListAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_GetCaptainTeamListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_01 + 0x20) == *(int *)(DAT_ram_00a66968 + 0x20)) {
		    plVar1 = (longlong *)func_ii_15774(param1_01);
		    lVar4 = *plVar1;
		    iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                      (param1_00[3],0,
		                       Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                      );
		    if (iVar2 == 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar2 + 8),0);
		      if (lVar3 == lVar4) {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        *(int *)(iVar2 + 0x44) = param1_00[4];
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x34);
		        if (iVar2 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		        }
		      }
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,DAT_ram_00a66968);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004908")]
		[Address(RVA = "0x977B", Offset = "0x977B", VA = "0x977B")]
		private void GetCaptainTeamListServiceHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetCaptainTeamListServiceHandler ---
		void Gameplay_Boss_Controller_BossInstanceController__GetCaptainTeamListServiceHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined8 uVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a578de == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_CaptainRating_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetPlaceAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578de = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_GetPlaceAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_GetPlaceAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(Protocol_Boss_CaptainRating_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x20) = *(undefined8 *)(param1_00 + 6);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar2 + 8),0);
		    *(undefined8 *)(iVar1 + 0x10) = uVar3;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined8 *)(iVar2 + 0x48) = *(undefined8 *)(param1_00 + 4);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(iVar2 + 0x3c);
		    *(int *)(iVar2 + 0x20) = iVar1;
		    iVar1 = *(int *)(iVar2 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined8 *)(*(int *)(iVar1 + 0x3c) + 0x28) = *(undefined8 *)(param1_00 + 4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004909 RID: 18697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x977C", Offset = "0x977C", VA = "0x977C")]
		private void HandleServiceGetPlace(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetPlace ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetPlace
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  undefined4 param3_00;
		  undefined4 param4;
		  int iVar3;
		  
		  if (DAT_ram_00a578df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetTeamInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TypeInfo);
		    DAT_ram_00a578df = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_GetTeamInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_GetTeamInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar2 = param1_00[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param3_00 = *(undefined4 *)(iVar1 + 0x30);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(iVar1 + 8);
		    iVar1 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TypeInfo);
		    Gameplay_Boss_Model_TeamData__get_MyRatingPlace(iVar1,iVar2,param3_00,param4,param1);
		    *(int *)(iVar1 + 0x20) = param1_00[5];
		    iVar2 = *(int *)(iVar1 + 0x1c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = *(int *)(iVar2 + 0x3c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined8 *)(iVar3 + 0x28) = *(undefined8 *)(iVar2 + 0x48);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x3c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x977D", Offset = "0x977D", VA = "0x977D")]
		private void HandleServiceGetActiveTeamInfo(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetActiveTeamInfo ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetActiveTeamInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  undefined8 *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined8 uVar8;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_GetCaptainTeamListAns_Types_TeamRewardInfo__TeamRewardData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_TeamRewardData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_GetCaptainTeamListAns_Types_TeamRewardInfo__TeamRewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetCaptainTeamListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController___c__DisplayClass28_0__HandleServiceGetCaptainTeams_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_Controller_BossInstanceController___c__DisplayClass28_0_TypeInfo);
		    DAT_ram_00a578e0 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Boss_Controller_BossInstanceController___c__DisplayClass28_0_TypeInfo)
		  ;
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0xc);
		  if (piVar7 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar7 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		    System_Activator__CreateInstance(piVar7,DAT_ram_00a66968);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  puVar4 = (undefined8 *)func_ii_15774(piVar7);
		  uVar8 = *puVar4;
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_Boss_GetCaptainTeamListAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Boss_GetCaptainTeamListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar7[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar5 == 0) {
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    *(bool *)(iVar3 + 8) = *(int *)(*(int *)(iVar5 + 0x38) + 0x18) == 1;
		    iVar5 = piVar7[4];
		    uVar6 = unnamed_function_1417
		                      (
		                      System_Func_GetCaptainTeamListAns_Types_TeamRewardInfo__TeamRewardData__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (uVar6,iVar3,
		               Method_Gameplay_Boss_Controller_BossInstanceController___c__DisplayClass28_0__HandleServiceGetCaptainTeams_b__0__
		               ,0);
		    uVar6 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (iVar5,uVar6,
		                       Method_System_Linq_Enumerable_Select_GetCaptainTeamListAns_Types_TeamRewardInfo__TeamRewardData___
		                      );
		    uVar6 = System_Linq_Enumerable__Select_object__object_
		                      (uVar6,Method_System_Linq_Enumerable_ToList_TeamRewardData___);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar3 = *(int *)(iVar3 + 0x40);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar8,uVar6,*(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x977E", Offset = "0x977E", VA = "0x977E")]
		private void HandleServiceGetCaptainTeams(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetCaptainTeams ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetCaptainTeams
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a578e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetRating_b__29_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_CaptainRating__BossCaptainRatingData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BossCaptainRatingData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_CaptainRating__BossCaptainRatingData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578e1 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_GetRatingAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_GetRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = param1_00[4];
		    uVar2 = unnamed_function_1417(System_Func_CaptainRating__BossCaptainRatingData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (uVar2,param1,
		               Method_Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetRating_b__29_0__
		               ,0);
		    uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (iVar1,uVar2,
		                       Method_System_Linq_Enumerable_Select_CaptainRating__BossCaptainRatingData___)
		    ;
		    uVar2 = System_Linq_Enumerable__Select_object__object_
		                      (uVar2,Method_System_Linq_Enumerable_ToList_BossCaptainRatingData___);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x44);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490C")]
		[Address(RVA = "0x977F", Offset = "0x977F", VA = "0x977F")]
		private void HandleServiceGetRating(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetRating ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int *param1_01;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a578e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetTeamInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetTeamRewardsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamAndRewardsData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TypeInfo);
		    DAT_ram_00a578e2 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Boss_GetTeamRewardsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Boss_GetTeamRewardsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if ((param1_01 != (int *)0x0) && (Protocol_Boss_GetTeamInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Boss_GetTeamInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar2 = param1_01[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = *(undefined4 *)(iVar1 + 0x30);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(iVar1 + 8);
		    iVar1 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TypeInfo);
		    Gameplay_Boss_Model_TeamData__get_MyRatingPlace(iVar1,iVar2,uVar3,param4,param1);
		    *(int *)(iVar1 + 0x20) = param1_01[5];
		    iVar2 = *(int *)(iVar1 + 0x1c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = param1_00[4];
		    uVar3 = unnamed_function_1417(Gameplay_Boss_Model_TeamAndRewardsData_TypeInfo);
		    Gameplay_Boss_Model_TeamAndRewardsData__set_RawRewards(uVar3,iVar1,iVar2,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x48);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar3,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x9780", Offset = "0x9780", VA = "0x9780")]
		private void HandleServiceGetTeamRewards(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetTeamRewards ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetTeamRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int *param1_02;
		  int param1_03;
		  undefined8 param3_00;
		  
		  if (DAT_ram_00a578e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetTeamRewards__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_GetTeamInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a578e3 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Boss_GetTeamInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Boss_GetTeamInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_02 + 0x20) == *(int *)(DAT_ram_00a66968 + 0x20)) {
		    puVar1 = (undefined8 *)func_ii_15774(param1_02);
		    param3_00 = *puVar1;
		    iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                      (param1_01[3],0,
		                       Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                      );
		    if (iVar2 == 0) {
		      param1_03 = param1[6];
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		      uVar3 = ServicesNamespace_BossService__DistributeRewards
		                        (param1_03,*(undefined8 *)(*(int *)(iVar2 + 0x28) + 0x10),param3_00,0);
		      uVar3 = DG_Tweening_TweenParams__SetId
		                        (uVar3,param1_01,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		      param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_Boss_Controller_BossInstanceController_HandleServiceGetTeamRewards__
		                 ,0);
		      ServicesNamespace_MainService__GetUserStats
		                (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_02,DAT_ram_00a66968);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490E")]
		[Address(RVA = "0x9781", Offset = "0x9781", VA = "0x9781")]
		private void HandleServiceGetTeamInfoAndRewwards(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceGetTeamInfoAndRewwards ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceGetTeamInfoAndRewwards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong *plVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  longlong lVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a578e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Boss_DefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_GetCaptainTeamListAns_Types_TeamRewardInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GetCaptainTeamListAns_Types_TeamRewardInfo__GetEnumerator__
		              );
		    DAT_ram_00a578e4 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Boss_DefaultAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_Boss_DefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar6[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBossErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar6 = *(int **)(param2 + 0xc);
		    if (piVar6 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar6 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		      System_Activator__CreateInstance(piVar6,DAT_ram_00a66968);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    plVar2 = (longlong *)func_ii_15774(piVar6);
		    lVar7 = *plVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar1 + 0x44) != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(iVar1 + 0x44),
		                                  Method_Google_Protobuf_Collections_RepeatedField_GetCaptainTeamListAns_Types_TeamRewardInfo__GetEnumerator__
		                                 );
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        piVar6 = local_4;
		        iVar1 = *local_4;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar3 = (undefined4 *)(iVar1 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80df7df0;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80df7e38:
		          DAT_ram_009d3e38 = 0;
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80df7f52:
		          iVar5 = global_1;
		          iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar5 == iVar1) {
		            piVar6 = (int *)import::env::__cxa_begin_catch(param1_00);
		            iVar5 = *piVar6;
		            DAT_ram_009d3e38 = 0;
		            local_c = iVar5;
		            import::env::invoke_v(0x123);
		            iVar9 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            iVar1 = 0;
		            if (iVar9 != 1) goto code_r0x80df7f9d;
		            param1_00 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a1,&local_c);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 == 1) {
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
		code_r0x80df7df0:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        piVar6 = local_4;
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) goto code_r0x80df7e38;
		        iVar1 = 3;
		        if (iVar9 == 0) goto code_r0x80df7f9d;
		        iVar1 = *local_4;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		            if (System_Collections_Generic_IEnumerator_GetCaptainTeamListAns_Types_TeamRewardInfo__TypeInfo
		                == *piVar8) {
		              puVar3 = (undefined4 *)(iVar1 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80df7edd;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_GetCaptainTeamListAns_Types_TeamRewardInfo__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80df7f2f:
		          DAT_ram_009d3e38 = 0;
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80df7f52;
		        }
		code_r0x80df7edd:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) goto code_r0x80df7f2f;
		      } while (*(longlong *)(iVar9 + 0x10) != lVar7);
		      *(undefined4 *)(iVar9 + 0x1c) = 2;
		      iVar1 = 3;
		code_r0x80df7f9d:
		      piVar6 = local_4;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80df8015;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80df8015:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      }
		      if (iVar5 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar1 != 0) {
		        if (iVar1 == 1) {
		          return;
		        }
		        if (iVar1 == 2) {
		          return;
		        }
		        if (iVar1 != 3) {
		          return;
		        }
		      }
		    }
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar5 = *(int *)(iVar5 + 0x34);
		    if (iVar5 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600490F RID: 18703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490F")]
		[Address(RVA = "0x9782", Offset = "0x9782", VA = "0x9782")]
		private void HandleServiceDistributeRewards(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleServiceDistributeRewards ---
		void Gameplay_Boss_Controller_BossInstanceController__HandleServiceDistributeRewards
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a578e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInviteData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_MercenaryInvitesEvt_Types_Invite__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3674);
		    DAT_ram_00a578e5 = '\x01';
		  }
		  lVar3 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar3 == *(longlong *)(*(int *)(iVar1 + 0x28) + 0x10)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar1 + 0x2c) == 0) {
		      iVar1 = 0;
		    }
		    else {
		      iVar1 = *(int *)(*(int *)(iVar1 + 0x2c) + 0xc);
		    }
		    if (iVar1 < *(int *)(*(int *)(param2 + 0x18) + 0xc)) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3674,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,5,param3_00,0);
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Boss_Model_BossInstanceModel__SetMyTeam(uVar2,*(undefined4 *)(param2 + 0x18),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x30);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004910")]
		[Address(RVA = "0x9783", Offset = "0x9783", VA = "0x9783")]
		private void BossServiceOnMercenaryInvitesChangedEvent(MercenaryInvitesEvt evt)
		{
		/* --- GHIDRA: BossServiceOnMercenaryInvitesChangedEvent ---
		void Gameplay_Boss_Controller_BossInstanceController__BossServiceOnMercenaryInvitesChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  longlong lVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined4 uVar12;
		  longlong lVar13;
		  int *piVar14;
		  uint uVar15;
		  int local_2c;
		  int **local_28;
		  int local_24;
		  undefined8 *puStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_TeamInfo_Types_MercenaryInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3648);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3647);
		    DAT_ram_00a578e6 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  lVar13 = *(longlong *)(param2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar13 == *(longlong *)(*(int *)(iVar2 + 0x28) + 0x10)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 0x3c) != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_24,*(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x14),
		                 Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__)
		      ;
		      local_8 = local_1c;
		      local_10 = CONCAT44(puStack_20,local_24);
		      local_24 = 0;
		      puStack_20 = &local_10;
		      do {
		        do {
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                              );
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar2 = global_1;
		              goto code_r0x80df8d76;
		            }
		            if (iVar3 == 0) goto code_r0x80df8e0c;
		            piVar7 = local_8._4_4_;
		          } while (1 < *(int *)(local_8._4_4_[0xc] + 0x10) - 1U);
		          DAT_ram_009d3e38 = 0;
		          piVar4 = (int *)import::env::invoke_iii
		                                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a2,
		                                     *(undefined4 *)(param2 + 0x28),
		                                     Method_Google_Protobuf_Collections_RepeatedField_TeamInfo_Types_MercenaryInfo__GetEnumerator__
		                                    );
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x80df8d76;
		          }
		          local_2c = 0;
		          local_28 = &local_14;
		          local_14 = piVar4;
		          do {
		            piVar4 = local_14;
		            iVar2 = *local_14;
		            if (*(ushort *)(iVar2 + 0xb6) != 0) {
		              uVar15 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar2 + 0x58) + uVar15 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		                  puVar5 = (undefined4 *)(iVar2 + piVar14[1] * 8 + 0xc0);
		                  goto code_r0x80df849d;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar2 + 0xb6) != uVar15);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x80df88cc:
		              bVar1 = false;
		              goto code_r0x80df88cf;
		            }
		code_r0x80df849d:
		            DAT_ram_009d3e38 = 0;
		            iVar2 = import::env::invoke_iii(*puVar5,piVar4,puVar5[1]);
		            piVar4 = local_14;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80df88cc;
		            iVar3 = 10;
		            iVar10 = 10;
		            if (iVar2 == 0) {
		              iVar2 = 0;
		              iVar3 = iVar10;
		              bVar1 = false;
		              goto code_r0x80df892b;
		            }
		            iVar2 = *local_14;
		            if (*(ushort *)(iVar2 + 0xb6) != 0) {
		              uVar15 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar2 + 0x58) + uVar15 * 8);
		                if (System_Collections_Generic_IEnumerator_TeamInfo_Types_MercenaryInfo__TypeInfo ==
		                    *piVar14) {
		                  puVar5 = (undefined4 *)(iVar2 + piVar14[1] * 8 + 0xc0);
		                  goto code_r0x80df8587;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar2 + 0xb6) != uVar15);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                System_Collections_Generic_IEnumerator_TeamInfo_Types_MercenaryInfo__TypeInfo
		                                ,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80df88cc;
		code_r0x80df8587:
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iii(*puVar5,piVar4,puVar5[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80df88cc;
		            lVar13 = *(longlong *)(*(int *)(iVar6 + 0xc) + 0x10);
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_iii
		                              (*(undefined4 *)(*piVar7 + 0xe0),piVar7,
		                               *(undefined4 *)(*piVar7 + 0xe4));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80df88cc;
		            DAT_ram_009d3e38 = 0;
		            lVar9 = unnamed_function_184054
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar8,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80df88cc;
		          } while (lVar13 != lVar9);
		          bVar1 = true;
		          iVar2 = 0;
		          if ((*(int *)(piVar7[0xc] + 0x10) == 1) &&
		             (iVar3 = iVar10, bVar1 = true, *(int *)(iVar6 + 0x10) == 2)) {
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Collections_Generic_Dictionary_string__string__TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x390,uVar8,
		                         Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar11 = import::env::invoke_iii
		                                   (*(undefined4 *)(*piVar7 + 0xe0),piVar7,
		                                    *(undefined4 *)(*piVar7 + 0xe4));
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar11 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                                     (uVar11,0);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x4b,uVar8,
		                               StringLiteral_25589,uVar11,
		                               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      uVar11 = import::env::invoke_ii
		                                         (s_struct_Uniforms___color__array<v_ram_000017c8 + 799,0);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        uVar11 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep
		                                           (uVar11,0);
		                        if (DAT_ram_009d3e38 != 1) {
		                          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_vi
		                                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                       Core_GameLocalization_TypeInfo);
		                            if (DAT_ram_009d3e38 == 1) goto code_r0x80df88c7;
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          uVar12 = import::env::invoke_iiiiiiiii
		                                             (s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                              0x392,StringLiteral_3647,1,0,1,0,0,0,0);
		                          if (DAT_ram_009d3e38 != 1) {
		                            DAT_ram_009d3e38 = 0;
		                            uVar8 = import::env::invoke_iiii
		                                              (s_struct_Uniforms___color__array<v_ram_000017c8 +
		                                               0x393,uVar12,uVar8,0);
		                            if (DAT_ram_009d3e38 != 1) {
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_viiii
		                                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a5,
		                                         uVar11,5,uVar8,0);
		                              if (DAT_ram_009d3e38 != 1) goto code_r0x80df892b;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		code_r0x80df88c7:
		            bVar1 = true;
		code_r0x80df88cf:
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		            if (iVar2 == iVar3) {
		              piVar4 = (int *)import::env::__cxa_begin_catch(uVar8);
		              iVar2 = *piVar4;
		              DAT_ram_009d3e38 = 0;
		              local_2c = iVar2;
		              import::env::invoke_v(0x123);
		              iVar10 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              iVar3 = 0;
		              if (iVar10 != 1) goto code_r0x80df892b;
		              uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar2 = global_1;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a6,&local_2c);
		            iVar3 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar3 != 1) goto code_r0x80df8d76;
		            goto code_r0x80df8ed2;
		          }
		code_r0x80df892b:
		          piVar4 = local_14;
		          if (local_14 != (int *)0x0) {
		            iVar10 = *local_14;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar15 = 0;
		              do {
		                piVar14 = (int *)(*(int *)(iVar10 + 0x58) + uVar15 * 8);
		                if (System_IDisposable_TypeInfo == *piVar14) {
		                  puVar5 = (undefined4 *)(iVar10 + piVar14[1] * 8 + 0xc0);
		                  goto code_r0x80df89c8;
		                }
		                uVar15 = uVar15 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar15);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                System_IDisposable_TypeInfo,0);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x80df89c8:
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii(*puVar5,piVar4,puVar5[1]);
		              if (DAT_ram_009d3e38 != 1) goto code_r0x80df8a04;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x80df8d76;
		          }
		code_r0x80df8a04:
		          if (iVar2 != 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar2);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar2 = global_1;
		            goto code_r0x80df8d76;
		          }
		          if (iVar3 != 0) {
		            if (iVar3 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 6) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 7) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 8) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 9) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 != 10) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		        } while (bVar1);
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_Dictionary_string__string__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80df8cff:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x80df8d76;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x390,uVar8,
		                   Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80df8cff;
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_iii
		                           (*(undefined4 *)(*piVar7 + 0xe0),piVar7,*(undefined4 *)(*piVar7 + 0xe4));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x80df8d76;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(uVar11,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80df8d13:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x80df8d76;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x4b,uVar8,StringLiteral_25589,
		                   uVar11,Method_System_Collections_Generic_Dictionary_string__string__Add__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80df8d13;
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 799,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x80df8d76;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar11,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80df8d27:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x80df8d76;
		        }
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_GameLocalization_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80df8d27;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar12 = import::env::invoke_iiiiiiiii
		                           (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,
		                            StringLiteral_3648,1,0,1,0,0,0,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x80df8d76;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x393,uVar12,uVar8,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a5,uVar11,5,uVar8,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		code_r0x80df8d76:
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 != iVar2) {
		code_r0x80df8dd6:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a7,&local_24);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          import::env::__resumeException(uVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x80df8ed2:
		        DAT_ram_009d3e38 = 0;
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar7 = (int *)import::env::__cxa_begin_catch(uVar8);
		      iVar3 = *piVar7;
		      DAT_ram_009d3e38 = 0;
		      local_24 = iVar3;
		      import::env::invoke_v(0x123);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar8 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x80df8dd6;
		      }
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		code_r0x80df8e0c:
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (DAT_ram_00a57882 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TypeInfo);
		      DAT_ram_00a57882 = '\x01';
		    }
		    if (param2 == 0) {
		      *(undefined4 *)(iVar2 + 0x3c) = 0;
		    }
		    else if (*(int *)(iVar2 + 0x3c) == 0) {
		      uVar11 = *(undefined4 *)(iVar2 + 8);
		      uVar12 = *(undefined4 *)(iVar2 + 0x30);
		      uVar8 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TypeInfo);
		      Gameplay_Boss_Model_TeamData__get_MyRatingPlace(uVar8,param2,uVar12,uVar11,iVar2);
		      *(undefined4 *)(iVar2 + 0x3c) = uVar8;
		    }
		    else {
		      Gameplay_Boss_Model_TeamData__get_RawTeamInfo(*(int *)(iVar2 + 0x3c),param2,iVar2);
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x9784", Offset = "0x9784", VA = "0x9784")]
		private void BossServiceOnTeamInfoChangedEvent(TeamInfo teamInfo)
		{
		/* --- GHIDRA: BossServiceOnTeamInfoChangedEvent ---
		void Gameplay_Boss_Controller_BossInstanceController__BossServiceOnTeamInfoChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 in_register_20000014;
		  undefined8 uVar3;
		  int iVar4;
		  float param2_00;
		  undefined4 param1_00;
		  longlong lVar5;
		  undefined8 uVar6;
		  
		  lVar5 = *(longlong *)(param2 + 0x10);
		  uVar6 = CONCAT44(in_register_20000004,param1);
		  uVar3 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar6,uVar3);
		  if (lVar5 == *(longlong *)(*(int *)(iVar4 + 0x28) + 0x10)) {
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),param1);
		    uVar3 = CONCAT44((int)((ulonglong)uVar3 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar6,uVar3);
		    uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    if (*(char *)(*(int *)(iVar4 + 0x28) + 0x30) != '\0') {
		      uVar6 = CONCAT44(uVar1,param1);
		      uVar3 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar6,uVar3);
		      uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		      uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      if ((*(int *)(*(int *)(iVar4 + 0x38) + 0x18) != 3) && (*(int *)(param2 + 0x18) == 3)) {
		        uVar6 = CONCAT44(uVar1,param1);
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (uVar6,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		        uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		        uVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(iVar4 + 8),0);
		        Gameplay_Boss_Controller_BossInstanceController__BuyLicence(param1,uVar6,param1);
		        uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      }
		    }
		    uVar6 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(CONCAT44(uVar1,param1),uVar6);
		    uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    if (DAT_ram_00a5787f == '\0') {
		      Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		      DAT_ram_00a5787f = '\x01';
		    }
		    *(int *)(iVar4 + 0x38) = param2;
		    uVar6 = *(undefined8 *)(param2 + 0x20);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = func_ii_7331(uVar6,0);
		    uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		    *(undefined4 *)(iVar4 + 0x34) = param1_00;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar2,param1),CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		    iVar4 = *(int *)(iVar4 + 0x14);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x9785", Offset = "0x9785", VA = "0x9785")]
		private void BossServiceOnInstanceStateChangedEvent(InstanceState instanceState)
		{
		/* --- GHIDRA: BossServiceOnInstanceStateChangedEvent ---
		void Gameplay_Boss_Controller_BossInstanceController__BossServiceOnInstanceStateChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  longlong lVar4;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a578e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ShortTeamInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3675);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25359);
		    DAT_ram_00a578e7 = '\x01';
		  }
		  lVar4 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar4 == *(longlong *)(*(int *)(iVar1 + 0x28) + 0x10)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    local_8 = *(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x10);
		    iVar1 = 0;
		    uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		    uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_25359,uVar2,param2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar3 + 0x50) != 0) {
		      iVar1 = *(int *)(*(int *)(iVar3 + 0x50) + 0xc);
		    }
		    if (*(int *)(*(int *)(param2 + 0x1c) + 0xc) < iVar1) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3675,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,5,param3_00,0);
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x50) = *(undefined4 *)(param2 + 0x1c);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x40) = *(undefined4 *)(param2 + 0x18);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x38);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x9786", Offset = "0x9786", VA = "0x9786")]
		private void BossServiceOnMercenaryTeamsChangedEvent(MercenaryTeamsEvt evt)
		{
		/* --- GHIDRA: BossServiceOnMercenaryTeamsChangedEvent ---
		void Gameplay_Boss_Controller_BossInstanceController__BossServiceOnMercenaryTeamsChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  longlong lVar3;
		  
		  if (DAT_ram_00a578e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3673);
		    DAT_ram_00a578e8 = '\x01';
		  }
		  lVar3 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar3 == *(longlong *)(*(int *)(iVar1 + 0x28) + 0x10)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x3c) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3673,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,5,param3_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x9787", Offset = "0x9787", VA = "0x9787")]
		private void BossServiceOnActiveTeamTimeoutEvent(TeamTimeoutEvt evt)
		{
		/* --- GHIDRA: BossServiceOnActiveTeamTimeoutEvent ---
		void Gameplay_Boss_Controller_BossInstanceController__BossServiceOnActiveTeamTimeoutEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  
		  lVar2 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar2 == *(longlong *)(*(int *)(iVar1 + 0x28) + 0x10)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x3c) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x9788", Offset = "0x9788", VA = "0x9788")]
		private void BossServiceOnActiveTeamArchivedEvent(ActiveTeamArchivedEvt evt)
		{
		/* --- GHIDRA: BossServiceOnActiveTeamArchivedEvent ---
		undefined4
		Gameplay_Boss_Controller_BossInstanceController__BossServiceOnActiveTeamArchivedEvent
		          (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a578ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossCaptainRatingData_TypeInfo);
		    DAT_ram_00a578ea = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar1 = Gameplay_Boss_Model_BossInstanceModel__set_MyCaptainsAllTeams
		                    (uVar1,*(undefined8 *)(param2 + 0x10),param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x38) + 0x18);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Model_BossCaptainRatingData_TypeInfo);
		  Gameplay_Boss_Model_BossCaptainRatingData__remove_CaptainUserDataChangedEvent
		            (param1_00,param2,uVar1,(uint)(iVar2 == 1),0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004916 RID: 18710 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x1B43", Offset = "0x1B43", VA = "0x1B43")]
		public UniTask PrepareTeam(CancellationToken cancellationToken)
		{
		/* --- GHIDRA: PrepareTeam ---
		void Gameplay_Boss_Controller_BossInstanceController__PrepareTeam
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a629af == '\0') {
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_CompletedTasks_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_IsCanceledSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Cysharp_Threading_Tasks_UniTask_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a629af = '\x01';
		  }
		  if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		  }
		  if (DAT_ram_00a63a12 == '\0') {
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		    DAT_ram_00a63a12 = '\x01';
		  }
		  param1_00 = (int *)*param2;
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = param2[1];
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82121439;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		code_r0x82121439:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,(int)(short)iVar3,puVar2[1]);
		    if (iVar3 != 1) {
		      if ((iVar3 != 2) && (iVar3 == 3)) {
		        if (*(int *)(Cysharp_Threading_Tasks_CompletedTasks_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Cysharp_Threading_Tasks_CompletedTasks_TypeInfo);
		        }
		        *(undefined8 *)param1 =
		             *(undefined8 *)(*(int *)(Cysharp_Threading_Tasks_CompletedTasks_TypeInfo + 0x5c) + 8);
		        return;
		      }
		      iVar3 = *param2;
		      iVar4 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTask_IsCanceledSource_TypeInfo);
		      *(int *)(iVar4 + 8) = iVar3;
		      iVar3 = param2[1];
		      param1[0] = 0;
		      param1[1] = 0;
		      *(short *)((int)param1 + 6) = (short)iVar3;
		      *param1 = iVar4;
		      return;
		    }
		  }
		  if (*(int *)(Cysharp_Threading_Tasks_CompletedTasks_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_CompletedTasks_TypeInfo);
		  }
		  *(undefined8 *)param1 =
		       *(undefined8 *)(*(int *)(Cysharp_Threading_Tasks_CompletedTasks_TypeInfo + 0x5c) + 0x10);
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x18")]
		private readonly BossService _bossService;
	}
}
