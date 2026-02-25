using System;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model;
using Gameplay.Ad.BattleFinishAd.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Ad.BattleFinishAd.Controller
{
	// Token: 0x02000DB8 RID: 3512
	[Token(Token = "0x2000DB8")]
	public class BattleFinishAdViewMediator : AbstractCozyViewMediator<BattleFinishAdPlacementModel, BattleFinishAdPlacementEvents, BattleFinishAdPlacementController, BattleFinishAdView>
	{
		// Token: 0x060055B9 RID: 21945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B9")]
		[Address(RVA = "0xA359", Offset = "0xA359", VA = "0xA359")]
		public BattleFinishAdViewMediator(BattleFinishAdView view, BattleFinishAdPlacementModel model, BattleFinishAdPlacementEvents events, BattleFinishAdPlacementController controller)
		{
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BA")]
		[Address(RVA = "0xA35A", Offset = "0xA35A", VA = "0xA35A", Slot = "21")]
		protected override void ResetEvents(BattleFinishAdPlacementEvents events)
		{
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BB")]
		[Address(RVA = "0xA35B", Offset = "0xA35B", VA = "0xA35B", Slot = "22")]
		protected override void SetupEvents(BattleFinishAdPlacementEvents events)
		{
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BC")]
		[Address(RVA = "0xA35C", Offset = "0xA35C", VA = "0xA35C", Slot = "23")]
		protected override void ResetView(BattleFinishAdView view)
		{
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BD")]
		[Address(RVA = "0xA35D", Offset = "0xA35D", VA = "0xA35D", Slot = "24")]
		protected override void SetupView(BattleFinishAdView view)
		{
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BE")]
		[Address(RVA = "0xA35E", Offset = "0xA35E", VA = "0xA35E")]
		private void HandleAdRewardedEvent()
		{
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BF")]
		[Address(RVA = "0xA35F", Offset = "0xA35F", VA = "0xA35F")]
		private void RenderReward()
		{
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C0")]
		[Address(RVA = "0xA360", Offset = "0xA360", VA = "0xA360")]
		private void WatchButtonClickHandler()
		{
		}
	}
}
