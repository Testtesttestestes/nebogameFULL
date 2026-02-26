using System;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x2000BC4")]
	public class BlitzTournamentInfoBox : MonoBehaviourWithStates<BlitzTournamentInfoBox.State>
	{
		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x060049D9 RID: 18905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEB")]
		public ButtonWithCost EnterTournamentButton
		{
			[Token(Token = "0x60049D9")]
			[Address(RVA = "0x9843", Offset = "0x9843", VA = "0x9843")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x9844", Offset = "0x9844", VA = "0x9844")]
		public void SetState(BlitzTournamentInfoBox.State state)
		{
		/* --- GHIDRA: SetState ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__SetState
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 param4_00;
		  undefined4 param1_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60897 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28697);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3618);
		    DAT_ram_00a60897 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3618,1,0,1,0,0,0,0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  local_8 = param3;
		  param4_00 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar1 = func_ii_8529(StringLiteral_28697,uVar1,param3_00,param4_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x9845", Offset = "0x9845", VA = "0x9845")]
		public void SetParticipantsCount(uint count, uint maxCount)
		{
		/* --- GHIDRA: SetParticipantsCount ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__SetParticipantsCount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  UI_Rewards_AbstractRewardsRender__get_Rewards(*(undefined4 *)(param1 + 0x24),param2,0);
		  iVar1 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(iVar1 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x060049DC RID: 18908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x9846", Offset = "0x9846", VA = "0x9846")]
		public void RenderRewards(RewardData[] rewards)
		{
		/* --- GHIDRA: RenderRewards ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__RenderRewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x1c),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x9847", Offset = "0x9847", VA = "0x9847")]
		public void SetTitle(string title)
		{
		/* --- GHIDRA: SetTitle ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__SetTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x20),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060049DE RID: 18910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x9848", Offset = "0x9848", VA = "0x9848")]
		public void SetDescription(string text)
		{
		/* --- GHIDRA: SetDescription ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__SetDescription
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60898 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    DAT_ram_00a60898 = '\x01';
		  }
		  UI_Price_Price__SetColor(*(undefined4 *)(*(int *)(param1 + 0x28) + 0xb8),param2,param3,0);
		  param1_00 = UI_Rewards_AbstractRewardsRender__SetRewards
		                        (*(undefined4 *)(param1 + 0x28),
		                         Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param4,0);
		  return;
		}
		*/

		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DF")]
		[Address(RVA = "0x9849", Offset = "0x9849", VA = "0x9849")]
		public void UpdatePriceButtonView(UserData user, Money resources, string label)
		{
		/* --- GHIDRA: UpdatePriceButtonView ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__UpdatePriceButtonView
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60899 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State___ctor__);
		    DAT_ram_00a60899 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x984A", Offset = "0x984A", VA = "0x984A")]
		public BlitzTournamentInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6089a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_BlitzTournamentData__get_TournamentData__
		              );
		    DAT_ram_00a6089a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Core_Extensions_Dict_BaseOptionExt__GetExternalPrice
		                    (*(undefined4 *)(*(int *)(param1 + 0x2c) + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = Core_Extensions_Dict_BlitzTournamentsDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x2c) + 8),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		private const string LOCALIZATION_PARTICIPANTS = "BLITZ/PARTICIPANTS";

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonWithCost _priceButton;

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _participants;

		// Token: 0x02000BC5 RID: 3013
		[Token(Token = "0x2000BC5")]
		public enum State
		{
			// Token: 0x0400282C RID: 10284
			[Token(Token = "0x400282C")]
			UNKNOWN,
			// Token: 0x0400282D RID: 10285
			[Token(Token = "0x400282D")]
			TOURNAMENT_VIEW = 3,
			// Token: 0x0400282E RID: 10286
			[Token(Token = "0x400282E")]
			IN_QUEUE
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_EnterTournamentButton ---
		void Gameplay_BlitzTournament_View_BlitzTournamentInfoBox__get_EnterTournamentButton
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a60896 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State__set_CurrentState__);
		    DAT_ram_00a60896 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,param2,
		             Method_UI_MonoBehaviourWithStates_BlitzTournamentInfoBox_State__set_CurrentState__);
		  return;
		}
		*/

}
