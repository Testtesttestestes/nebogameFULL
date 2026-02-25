using System;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control.Sections;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using MVC;
using UI.Elements.RatingElements;
using UnityEngine;

namespace Gameplay.Competition.View.Sections.Rating
{
	// Token: 0x020008E6 RID: 2278
	[Token(Token = "0x20008E6")]
	[AddComponentMenu("Competition/View/Sections/RatingView")]
	public class RatingView : BaseSectionView<RatingController>
	{
		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA4")]
		public TopLeaders TopLeaders
		{
			[Token(Token = "0x60035AD")]
			[Address(RVA = "0x85BB", Offset = "0x85BB", VA = "0x85BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA5")]
		public CommonRatingOSAView UsersOSAView
		{
			[Token(Token = "0x60035AE")]
			[Address(RVA = "0x85BC", Offset = "0x85BC", VA = "0x85BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA6")]
		public MyCommonRatingView MyRatingView
		{
			[Token(Token = "0x60035AF")]
			[Address(RVA = "0x85BD", Offset = "0x85BD", VA = "0x85BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA7")]
		public RatingsDescription Description
		{
			[Token(Token = "0x60035B0")]
			[Address(RVA = "0x85BE", Offset = "0x85BE", VA = "0x85BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0x85BF", Offset = "0x85BF", VA = "0x85BF", Slot = "6")]
		protected override void CreateController(CompetitionModel model, CompetitionEvents events, out RatingController controller)
		{
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x85C0", Offset = "0x85C0", VA = "0x85C0", Slot = "7")]
		protected override void CreateMediator(RatingController controller, out IViewMediator mediator)
		{
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x85C1", Offset = "0x85C1", VA = "0x85C1", Slot = "8")]
		protected override void RunController(RatingController controller, out AbstractMVCEvents events)
		{
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x85C2", Offset = "0x85C2", VA = "0x85C2")]
		public RatingView()
		{
		}

		// Token: 0x04001D5C RID: 7516
		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TopLeaders _topLeaders;

		// Token: 0x04001D5D RID: 7517
		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CommonRatingOSAView _usersOSAView;

		// Token: 0x04001D5E RID: 7518
		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private MyCommonRatingView _myRatingView;

		// Token: 0x04001D5F RID: 7519
		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _receivingDataView;

		// Token: 0x04001D60 RID: 7520
		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RatingsDescription _description;
	}
}
