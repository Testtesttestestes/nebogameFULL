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
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x9764", Offset = "0x9764", VA = "0x9764", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x9765", Offset = "0x9765", VA = "0x9765", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x9766", Offset = "0x9766", VA = "0x9766")]
		public void RequestPossibleMercenaries()
		{
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x9767", Offset = "0x9767", VA = "0x9767")]
		public bool TryCreateTeam(out OpToken<IMessage, object> op)
		{
			return default(bool);
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x9768", Offset = "0x9768", VA = "0x9768")]
		public void InviteAssistant(ulong uid)
		{
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x9769", Offset = "0x9769", VA = "0x9769")]
		public void KickAssistant(ulong uid)
		{
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x976A", Offset = "0x976A", VA = "0x976A")]
		public void AcceptInvite(ulong captainId)
		{
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x976B", Offset = "0x976B", VA = "0x976B")]
		public void RefuseInvite(ulong captainId)
		{
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x976C", Offset = "0x976C", VA = "0x976C")]
		public void BuyLicence()
		{
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x976D", Offset = "0x976D", VA = "0x976D")]
		public void GetCaptainTeamList(ulong captainId)
		{
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60048FB")]
		[Address(RVA = "0x976E", Offset = "0x976E", VA = "0x976E")]
		public OpToken<IMessage, object> GetPlace()
		{
			return null;
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FC")]
		[Address(RVA = "0x976F", Offset = "0x976F", VA = "0x976F")]
		public void GetActiveTeamInfo(ulong captainId)
		{
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x9770", Offset = "0x9770", VA = "0x9770")]
		public void GetCaptainTeams(ulong captainId)
		{
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x9771", Offset = "0x9771", VA = "0x9771")]
		public void GetRating()
		{
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x9772", Offset = "0x9772", VA = "0x9772")]
		public void GetTeamInfoAndRewards(ulong teamId)
		{
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x9773", Offset = "0x9773", VA = "0x9773")]
		public void DistributeRewards(ulong teamId, List<DistributeRewardsCmd.Types.UserReward> rewards)
		{
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x9774", Offset = "0x9774", VA = "0x9774")]
		private void HandleServiceGetPossibleMercenaries(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x9775", Offset = "0x9775", VA = "0x9775")]
		private void HandleServiceCreateTeam(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x9776", Offset = "0x9776", VA = "0x9776")]
		private void HandleServiceInviteAssistant(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x9777", Offset = "0x9777", VA = "0x9777")]
		private void HandleServiceKickAssistant(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x9778", Offset = "0x9778", VA = "0x9778")]
		private void HandleServiceAcceptInvitation(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x9779", Offset = "0x9779", VA = "0x9779")]
		private void HandleServiceRefuseInvitation(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x977A", Offset = "0x977A", VA = "0x977A")]
		private void HandleServiceBuyLicence(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004908")]
		[Address(RVA = "0x977B", Offset = "0x977B", VA = "0x977B")]
		private void GetCaptainTeamListServiceHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x977C", Offset = "0x977C", VA = "0x977C")]
		private void HandleServiceGetPlace(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x977D", Offset = "0x977D", VA = "0x977D")]
		private void HandleServiceGetActiveTeamInfo(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x977E", Offset = "0x977E", VA = "0x977E")]
		private void HandleServiceGetCaptainTeams(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490C")]
		[Address(RVA = "0x977F", Offset = "0x977F", VA = "0x977F")]
		private void HandleServiceGetRating(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x9780", Offset = "0x9780", VA = "0x9780")]
		private void HandleServiceGetTeamRewards(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490E")]
		[Address(RVA = "0x9781", Offset = "0x9781", VA = "0x9781")]
		private void HandleServiceGetTeamInfoAndRewwards(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490F")]
		[Address(RVA = "0x9782", Offset = "0x9782", VA = "0x9782")]
		private void HandleServiceDistributeRewards(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004910")]
		[Address(RVA = "0x9783", Offset = "0x9783", VA = "0x9783")]
		private void BossServiceOnMercenaryInvitesChangedEvent(MercenaryInvitesEvt evt)
		{
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x9784", Offset = "0x9784", VA = "0x9784")]
		private void BossServiceOnTeamInfoChangedEvent(TeamInfo teamInfo)
		{
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x9785", Offset = "0x9785", VA = "0x9785")]
		private void BossServiceOnInstanceStateChangedEvent(InstanceState instanceState)
		{
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x9786", Offset = "0x9786", VA = "0x9786")]
		private void BossServiceOnMercenaryTeamsChangedEvent(MercenaryTeamsEvt evt)
		{
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x9787", Offset = "0x9787", VA = "0x9787")]
		private void BossServiceOnActiveTeamTimeoutEvent(TeamTimeoutEvt evt)
		{
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x9788", Offset = "0x9788", VA = "0x9788")]
		private void BossServiceOnActiveTeamArchivedEvent(ActiveTeamArchivedEvt evt)
		{
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x1B43", Offset = "0x1B43", VA = "0x1B43")]
		public UniTask PrepareTeam(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x18")]
		private readonly BossService _bossService;
	}
}
