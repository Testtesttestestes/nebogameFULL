using System;
using Gameplay.Duel.Events;
using Gameplay.Duel.Model;
using Gameplay.Duel.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	public class DuelViewMediator : AbstractViewMediator<DuelModel, DuelEvents, DuelController, DuelWindow>
	{
		// Token: 0x0600329D RID: 12957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x82F2", Offset = "0x82F2", VA = "0x82F2")]
		public DuelViewMediator(DuelModel model, DuelEvents events, DuelController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_Controller_DuelViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57c07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__set_View__
		              );
		    DAT_ram_00a57c07 = '\x01';
		  }
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar4 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    func_ii_14558(*(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4),0);
		  }
		  param1[5] = param2;
		  uVar4 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Duel_Controller_DuelViewMediator__set_Events(param1,param1);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x14c)));
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 8),0);
		    param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 8),0);
		    if (DAT_ram_00a57bfa == '\0') {
		      Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		      DAT_ram_00a57bfa = '\x01';
		    }
		    Gameplay_Duel_Controller_DuelController__StartListeningForCombatStart(uVar3,param2_00,param1);
		    Gameplay_Duel_Controller_DuelController__UnsubscribeOpponentResultHandler
		              (uVar3,uVar4,param2_00,param1);
		    iVar2 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,2);
		    *(undefined8 *)(iVar2 + 0x18) = param2_00;
		    *(undefined8 *)(iVar2 + 0x10) = uVar4;
		    Gameplay_Duel_Controller_DuelController__GetDuelInfoResultHandler(uVar3,iVar2,iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170009F9 RID: 2553
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F9")]
		public override DuelWindow View
		{
			[Token(Token = "0x600329E")]
			[Address(RVA = "0x82F3", Offset = "0x82F3", VA = "0x82F3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170009FA RID: 2554
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FA")]
		public override DuelEvents Events
		{
			[Token(Token = "0x600329F")]
			[Address(RVA = "0x82F4", Offset = "0x82F4", VA = "0x82F4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x82F5", Offset = "0x82F5", VA = "0x82F5")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Duel_Controller_DuelViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57c0a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_DuelWindow_DuelWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelViewMediator_AttackButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelViewMediator_PayOffButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6234);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3631);
		    DAT_ram_00a57c0a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,
		                       Method_UI_Windows_BaseWindow_DuelWindow_DuelWindowArgs__get_WindowArgs__);
		  if (*(int *)(iVar2 + 0x1c) == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3631,1,0,1,0,0,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Duel_Controller_DuelViewMediator_AttackButtonClickedEventHandler__,0)
		    ;
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6234,1,0,1,0,0,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_Duel_Controller_DuelViewMediator_PayOffButtonClickedEventHandler__,0)
		    ;
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(iVar2 + 0x48),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x82F6", Offset = "0x82F6", VA = "0x82F6")]
		private void HandleDuelState()
		{
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x82F7", Offset = "0x82F7", VA = "0x82F7")]
		private void CloseViewEventHandler()
		{
		/* --- GHIDRA: CloseViewEventHandler ---
		void Gameplay_Duel_Controller_DuelViewMediator__CloseViewEventHandler(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57c0b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__get_Model__
		              );
		    DAT_ram_00a57c0b = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 8),0);
		  Gameplay_Duel_Controller_DuelController__GetUserInfoResultHandler
		            (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x18) + 8) + 0xc),
		             param1);
		  return;
		}
		*/

		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x82F8", Offset = "0x82F8", VA = "0x82F8")]
		private void AttackButtonClickedEventHandler()
		{
		/* --- GHIDRA: AttackButtonClickedEventHandler ---
		void Gameplay_Duel_Controller_DuelViewMediator__AttackButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57c0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__get_Model__
		              );
		    DAT_ram_00a57c0c = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 8),0);
		  Gameplay_Duel_Controller_DuelController__AttackUserResultHandler(param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x82F9", Offset = "0x82F9", VA = "0x82F9")]
		private void PayOffButtonClickedEventHandler()
		{
		/* --- GHIDRA: PayOffButtonClickedEventHandler ---
		void Gameplay_Duel_Controller_DuelViewMediator__PayOffButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined4 param5;
		  undefined4 param4;
		  double param2_00;
		  int iVar12;
		  
		  if (DAT_ram_00a57c0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_DuelWindow_DuelWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57c0d = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar4 = func_ii_8093(uVar3,
		                       Method_UI_Windows_BaseWindow_DuelWindow_DuelWindowArgs__get_WindowArgs__);
		  iVar8 = *(int *)(param1[2] + 0x18);
		  iVar10 = 0x18;
		  iVar4 = *(int *)(iVar4 + 0x1c);
		  if (iVar4 != 1) {
		    iVar10 = 0x1c;
		  }
		  uVar3 = *(undefined4 *)(*(int *)(iVar8 + 8) + iVar10);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x160);
		        goto code_r0x80e36708;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e36708:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar9,CONCAT44(uVar6,puVar5[1]));
		  iVar10 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit(uVar6,uVar3,0);
		  uVar6 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(iVar10 + 0x10),0);
		  iVar12 = 0x18;
		  if (iVar4 != 1) {
		    iVar12 = 0x1c;
		  }
		  param2_00 = (double)*(float *)(*(int *)(*(int *)(param1[2] + 0x18) + 0xc) + iVar12);
		  Core_Extensions_Dict_ResourceSetExt__Round(uVar6,param2_00,0);
		  iVar4 = param1[2];
		  uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  uVar7 = Protocol_Dic_RequirementDic___ctor(iVar10,0);
		  *(undefined4 *)(iVar4 + 0x20) = uVar7;
		  *(undefined4 *)(*(int *)(param1[2] + 0x20) + 0x10) = uVar6;
		  uVar2 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x48) + 0xb8);
		  uVar11 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		  UI_Price_Price__SetColor(uVar7,uVar11,uVar6,0);
		  uVar2 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar3 = *(undefined4 *)(iVar4 + 0x4c);
		  uVar7 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0x14);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar7 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar7,0);
		  piVar9 = (int *)func_ii_7307(uVar3,uVar7,0);
		  uVar2 = CONCAT44(uVar6,*(undefined4 *)(*piVar9 + 0xf4));
		  (**(code **)((ulonglong)*(uint *)(*piVar9 + 0xf0) * 4))(piVar9,uVar2);
		  uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar3 = *(undefined4 *)(iVar4 + 0x50);
		  uVar7 = *(undefined4 *)(param1[2] + 8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar9;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x80e368de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e368de:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar9,CONCAT44(uVar6,puVar5[1]));
		  uVar6 = func_ii_7112(uVar6,0);
		  param5 = *(undefined4 *)(iVar10 + 0x14);
		  param4 = *(undefined4 *)(iVar10 + 0x18);
		  uVar11 = unnamed_function_1417
		                     (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		            (uVar11,uVar7,uVar6,param4,param5,0);
		  UI_Requirements_RequirementsView__get_Data(uVar3,uVar11,0);
		  return;
		}
		*/

		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x82FA", Offset = "0x82FA", VA = "0x82FA")]
		private void DuelInfoRequestedEventHandler()
		{
		/* --- GHIDRA: DuelInfoRequestedEventHandler ---
		void Gameplay_Duel_Controller_DuelViewMediator__DuelInfoRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param5;
		  
		  if (DAT_ram_00a57c0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__get_Model__
		              );
		    DAT_ram_00a57c0e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param5 = param1[2];
		  Gameplay_Duel_View_SkillCompareRow___ctor
		            (*(undefined4 *)(iVar1 + 0x44),*(undefined4 *)(*(int *)(param5 + 0x10) + 0xc),
		             *(undefined4 *)(*(int *)(param5 + 0x14) + 0xc),*(undefined4 *)(param5 + 0xc),param5);
		  return;
		}
		*/

		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x82FB", Offset = "0x82FB", VA = "0x82FB")]
		private void SkillsRequestedEventHandler()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Duel_Controller_DuelViewMediator__set_View(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57c08 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelViewMediator_CloseViewEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelViewMediator_DuelInfoRequestedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelViewMediator_SkillsRequestedEventHandler__);
		    DAT_ram_00a57c08 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Duel_Controller_DuelViewMediator_SkillsRequestedEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Duel_Controller_DuelViewMediator_DuelInfoRequestedEventHandler__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Duel_Controller_DuelViewMediator_CloseViewEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Duel_Controller_DuelViewMediator_SkillsRequestedEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Duel_Controller_DuelViewMediator_DuelInfoRequestedEventHandler__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Duel_Controller_DuelViewMediator_CloseViewEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x20) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x20) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Duel_Controller_DuelViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  float fVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a57c09 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57c09 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80e35d90;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e35d90:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *(int *)(iVar7 + 0x3c);
		  iVar8 = *(int *)(*(int *)(param1[2] + 0x10) + 8);
		  if (DAT_ram_00a57bd2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57bd2 = '\x01';
		  }
		  uVar9 = *(undefined4 *)(iVar7 + 0x10);
		  uVar4 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(*(int *)(iVar8 + 0x38) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar9,uVar4,0);
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetCult
		            (*(undefined4 *)(iVar7 + 0x14),iVar8,uVar3,0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *(int *)(iVar7 + 0x40);
		  iVar8 = *(int *)(*(int *)(param1[2] + 0x14) + 8);
		  if (DAT_ram_00a57bd2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57bd2 = '\x01';
		  }
		  uVar9 = *(undefined4 *)(iVar7 + 0x10);
		  uVar4 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(*(int *)(iVar8 + 0x38) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar9,uVar4,0);
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetCult
		            (*(undefined4 *)(iVar7 + 0x14),iVar8,uVar3,0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *(int *)(iVar7 + 0x58);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar6;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x220);
		        goto code_r0x80e35f33;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80e35f33:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  *(undefined4 *)(iVar7 + 0x68) = *(undefined4 *)(iVar8 + 0x18);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar7 + 0x58);
		  fVar5 = func_ii_7103(*(undefined4 *)(param1[2] + 0x1c),0);
		  if (ABS(fVar5) < 2.1474836e+09) {
		    iVar7 = (int)fVar5;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  Gameplay_Combat_View_TurnDisplay_TurnClock__set_TurnState(uVar3,iVar7,0);
		  uVar1 = Core_Extensions_UriExt___c___QueryStringToDictionary_b__0_1
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 8),0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar7 + 0x5c),uVar1,0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar7 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1 ^ 1,0);
		  Gameplay_Duel_Controller_DuelViewMediator__Init(param1,uVar1);
		  return;
		}
		*/

}
