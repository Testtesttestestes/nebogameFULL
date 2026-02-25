using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.Rewarding;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	public class BossRewardingWindowMediator : AbstractViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, BossRewardingWindow>
	{
		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		[Token(Token = "0x17000EDA")]
		private ulong CurrentTeamId
		{
			[Token(Token = "0x600495C")]
			[Address(RVA = "0x97CE", Offset = "0x97CE", VA = "0x97CE")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495D")]
		[Address(RVA = "0x97CF", Offset = "0x97CF", VA = "0x97CF")]
		public BossRewardingWindowMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x17000EDB RID: 3803
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDB")]
		public override BossInstanceEvents Events
		{
			[Token(Token = "0x600495E")]
			[Address(RVA = "0x97D0", Offset = "0x97D0", VA = "0x97D0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x97D1", Offset = "0x97D1", VA = "0x97D1")]
		private void TeamAndRewardsDataReceivedEvent(TeamAndRewardsData data)
		{
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x97D2", Offset = "0x97D2", VA = "0x97D2")]
		private void RenderTeamAndRewards(TeamAndRewardsData data)
		{
		}

		// Token: 0x17000EDC RID: 3804
		// (set) Token: 0x06004961 RID: 18785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDC")]
		public bool HasChanges
		{
			[Token(Token = "0x6004961")]
			[Address(RVA = "0x97D3", Offset = "0x97D3", VA = "0x97D3")]
			set
			{
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (set) Token: 0x06004962 RID: 18786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EDD")]
		public override BossRewardingWindow View
		{
			[Token(Token = "0x6004962")]
			[Address(RVA = "0x97D4", Offset = "0x97D4", VA = "0x97D4", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x97D5", Offset = "0x97D5", VA = "0x97D5")]
		private void NextButtonClickHandler()
		{
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x97D6", Offset = "0x97D6", VA = "0x97D6")]
		private void PrevButtonClickHandler()
		{
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x97D7", Offset = "0x97D7", VA = "0x97D7")]
		private void ResetButtonClickHandler()
		{
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004966")]
		[Address(RVA = "0x97D8", Offset = "0x97D8", VA = "0x97D8")]
		private void ApplyButtonClickHandler()
		{
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004967")]
		[Address(RVA = "0x97D9", Offset = "0x97D9", VA = "0x97D9")]
		private void ConfirmApplyRewards()
		{
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004968")]
		[Address(RVA = "0x97DA", Offset = "0x97DA", VA = "0x97DA")]
		private void RewardingViewOnCaptainRewardClickEvent(BossRewardingCaptainSlotView bossRewardingCaptainSlotView)
		{
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004969")]
		[Address(RVA = "0x97DB", Offset = "0x97DB", VA = "0x97DB")]
		private void ResetSelectionMode()
		{
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x97DC", Offset = "0x97DC", VA = "0x97DC")]
		private void RewardingViewOnSelectedAssistantSlotChangedEvent(BossRewardingAssistantSlotView obj)
		{
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x97DD", Offset = "0x97DD", VA = "0x97DD")]
		private void RenderCurrentTeam()
		{
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x97DE", Offset = "0x97DE", VA = "0x97DE")]
		private void RandomButtonClickHandler()
		{
		}

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x18")]
		private TeamAndRewardsData _teamAndRewardsData;

		// Token: 0x040027FC RID: 10236
		[Token(Token = "0x40027FC")]
		[FieldOffset(Offset = "0x1C")]
		private int _currentTeamIndex;

		// Token: 0x040027FD RID: 10237
		[Token(Token = "0x40027FD")]
		[FieldOffset(Offset = "0x20")]
		private List<ulong> _teamIds;
	}
}
