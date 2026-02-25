using System;
using DG.Tweening;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x02000510 RID: 1296
	[Token(Token = "0x2000510")]
	public class SpecialOffersEnterPointViewMediator : AbstractViewMediator<SpecialOffersModel, SpecialOffersEvents, SpecialOffersController, SpecialOffersButtonView>
	{
		// Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x7047", Offset = "0x7047", VA = "0x7047")]
		public SpecialOffersEnterPointViewMediator(SpecialOffersModel model, SpecialOffersEvents events, SpecialOffersController controller)
		{
		}

		// Token: 0x1700059D RID: 1437
		// (set) Token: 0x06001EE1 RID: 7905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059D")]
		public override SpecialOffersButtonView View
		{
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x7048", Offset = "0x7048", VA = "0x7048", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700059E RID: 1438
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059E")]
		public override SpecialOffersEvents Events
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x7049", Offset = "0x7049", VA = "0x7049", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0x704A", Offset = "0x704A", VA = "0x704A")]
		private void HandleNeedValidateEntryPointEvent()
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x704B", Offset = "0x704B", VA = "0x704B")]
		private void UnseenOptionsCountChangedEventHandler()
		{
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x704C", Offset = "0x704C", VA = "0x704C")]
		private void SpecialOffersRequestedEventHandler()
		{
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x704D", Offset = "0x704D", VA = "0x704D")]
		private void UpdateView()
		{
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x704E", Offset = "0x704E", VA = "0x704E")]
		private void ValidateEp()
		{
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE8")]
		[Address(RVA = "0x704F", Offset = "0x704F", VA = "0x704F")]
		private void ScheduleTween()
		{
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE9")]
		[Address(RVA = "0x7050", Offset = "0x7050", VA = "0x7050")]
		private void UpdateBanner()
		{
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x7051", Offset = "0x7051", VA = "0x7051")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		private const float MIN_REFRESH_INTERVAL = 60f;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x18")]
		private int _index;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x1C")]
		private Tween _tween;
	}
}
