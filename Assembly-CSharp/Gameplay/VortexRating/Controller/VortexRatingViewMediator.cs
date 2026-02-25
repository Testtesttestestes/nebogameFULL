using System;
using System.Collections.Generic;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public class VortexRatingViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, VortexRatingWindow>
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x6761", Offset = "0x6761", VA = "0x6761")]
		public VortexRatingViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x17000391 RID: 913
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000391")]
		public override VortexRatingWindow View
		{
			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x6762", Offset = "0x6762", VA = "0x6762", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x6763", Offset = "0x6763", VA = "0x6763")]
		private void Init()
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x6764", Offset = "0x6764", VA = "0x6764")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x6765", Offset = "0x6765", VA = "0x6765")]
		private void InRatingButtonClickedEventHandler()
		{
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x6766", Offset = "0x6766", VA = "0x6766")]
		private IHideableMediator ShowVortexTab()
		{
			return null;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x6767", Offset = "0x6767", VA = "0x6767")]
		private IHideableMediator ShowGreatOnesTab()
		{
			return null;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x6768", Offset = "0x6768", VA = "0x6768")]
		private IHideableMediator ShowVoteRewardsTab()
		{
			return null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x6769", Offset = "0x6769", VA = "0x6769")]
		private IHideableMediator ShowRulesTab()
		{
			return null;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x676A", Offset = "0x676A", VA = "0x676A")]
		private IHideableMediator ShowGreatPrizesTab()
		{
			return null;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A9")]
		[Address(RVA = "0x676B", Offset = "0x676B", VA = "0x676B", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04000B73 RID: 2931
		[Token(Token = "0x4000B73")]
		[FieldOffset(Offset = "0x18")]
		private VortexViewMediator _vortexViewMediator;

		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		[FieldOffset(Offset = "0x1C")]
		private GreatOnesViewMediator _greatOnesViewMediator;

		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		[FieldOffset(Offset = "0x20")]
		private VoteRewardsViewMediator _voteRewardsViewMediator;

		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		[FieldOffset(Offset = "0x24")]
		private RulesViewMediator _rulesViewMediator;

		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		[FieldOffset(Offset = "0x28")]
		private GreatPrizesViewMediator _greatPrizesViewMediator;

		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<uint, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		[FieldOffset(Offset = "0x30")]
		private IHideableMediator _currentMediator;
	}
}
