using System;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Dic;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.ColossusInfo.Controller.ColossusInfo
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	public class ColossusInfoController : AbstractController<ColossusInfoModel, ColossusInfoEvents>
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x64C2", Offset = "0x64C2", VA = "0x64C2")]
		public ColossusInfoController(ColossusInfoModel model, ColossusInfoEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58bfa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_ClanUnregisteredHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_UserLeftClanEventHandler__
		              );
		    DAT_ram_00a58bfa = '\x01';
		  }
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__UserLeftClanEventHandler
		            (param1,param1);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_UserLeftClanEventHandler__
		             ,0);
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_ClanUnregisteredHandler__
		             ,0);
		  ServicesNamespace_ClansService__remove_ClanCreatedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x64C3", Offset = "0x64C3", VA = "0x64C3", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58bfb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_ClanUnregisteredHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_UserLeftClanEventHandler__
		              );
		    DAT_ram_00a58bfb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_UserLeftClanEventHandler__
		             ,0);
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_ClanUnregisteredHandler__
		             ,0);
		  ServicesNamespace_ClansService__add_ClanUnregisteredEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x64C4", Offset = "0x64C4", VA = "0x64C4", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x30) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x14) + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x64C5", Offset = "0x64C5", VA = "0x64C5")]
		private void ClanUnregisteredHandler(ProtoUnregisterClanAns ans)
		{
		/* --- GHIDRA: ClanUnregisteredHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__ClanUnregisteredHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int *param1_00;
		  int iVar4;
		  longlong lVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a58bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58bfc = '\x01';
		  }
		  lVar5 = *(longlong *)(param2 + 0x10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x80f88c45;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f88c45:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		  if (lVar3 == lVar5) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x30) = 0;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar4 = *(int *)(*(int *)(iVar4 + 0x14) + 0x18);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x64C6", Offset = "0x64C6", VA = "0x64C6")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: UserLeftClanEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__UserLeftClanEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a58bfd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_GetColossusRatingResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58bfd = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = ServicesNamespace_ColossusService__GetSchedule
		                        (param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x18) + 0x10) + 0xc),0)
		  ;
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_GetColossusRatingResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x64C7", Offset = "0x64C7", VA = "0x64C7")]
		private void GetColossusRating()
		{
		/* --- GHIDRA: GetColossusRating ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__GetColossusRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58bfe == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetColossusRatingAns_TypeInfo);
		    DAT_ram_00a58bfe = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetColossusRatingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetColossusRatingAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__GetTabBarItemData
		            (param1_00,param1_01[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x64C8", Offset = "0x64C8", VA = "0x64C8")]
		private void GetColossusRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetColossusRatingResultHandler ---
		undefined4
		Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__GetColossusRatingResultHandler
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58bff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo);
		    DAT_ram_00a58bff = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(*(int *)(iVar2 + 0x10) + 0x14);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x80f88e0f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo,
		                                3);
		code_r0x80f88e0f:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param2,puVar3[1]);
		  return uVar4;
		}
		*/

		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x64C9", Offset = "0x64C9", VA = "0x64C9")]
		public bool TryRunCombat(ColossusDic colossus)
		{
		/* --- GHIDRA: TryRunCombat ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController__TryRunCombat
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58c00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow___ctor__
		              );
		    DAT_ram_00a58c00 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow___ctor__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x18")]
		private readonly ColossusService _colossusService;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ClansService _clansService;
	}
}
