using System;
using Core.Sorting;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.InvitesTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA9 RID: 2985
	[Token(Token = "0x2000BA9")]
	public class BossAssistantViewMediator : AbstractBossWindowViewMediator<BossInvitesView>
	{
		// Token: 0x0600491D RID: 18717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x978F", Offset = "0x978F", VA = "0x978F")]
		public BossAssistantViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491E")]
		[Address(RVA = "0x9790", Offset = "0x9790", VA = "0x9790")]
		private void LicenceCountChangedEvent()
		{
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x9791", Offset = "0x9791", VA = "0x9791")]
		private void TeamInfoReceivedEvent(TeamData teamData)
		{
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x9792", Offset = "0x9792", VA = "0x9792")]
		private void ShowTeamData(TeamData teamData)
		{
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x9793", Offset = "0x9793", VA = "0x9793")]
		private void CaptainInvitesChangedEvent()
		{
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x9794", Offset = "0x9794", VA = "0x9794", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x9795", Offset = "0x9795", VA = "0x9795", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004924")]
		[Address(RVA = "0x9796", Offset = "0x9796", VA = "0x9796", Slot = "23")]
		protected override void ResetView(BossInvitesView view)
		{
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x9797", Offset = "0x9797", VA = "0x9797", Slot = "24")]
		protected override void SetupView(BossInvitesView view)
		{
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x9798", Offset = "0x9798", VA = "0x9798")]
		private void SortControlOnComparerChangedEvent(IGameDataComparer<BossInviteData> comparer)
		{
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x9799", Offset = "0x9799", VA = "0x9799")]
		private void BuyLicenceButtonClickHandler()
		{
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004928")]
		[Address(RVA = "0x979A", Offset = "0x979A", VA = "0x979A")]
		private void RefuseButtonClickHandler()
		{
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x979B", Offset = "0x979B", VA = "0x979B")]
		private void AcceptButtonClickHandler()
		{
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492A")]
		[Address(RVA = "0x979C", Offset = "0x979C", VA = "0x979C")]
		private void ListAdapterOnSelectedEvent(BossInviteData invite)
		{
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x979D", Offset = "0x979D", VA = "0x979D")]
		private void RenderInvites()
		{
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x979E", Offset = "0x979E", VA = "0x979E")]
		private void RenderLicenceCount()
		{
		}
	}
}
