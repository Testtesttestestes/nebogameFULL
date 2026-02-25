using System;
using Core.Money;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Portal;
using Protocol.Rating;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	public class PortalsTotalizatorViewMediator : AbstractViewMediator<PortalsTotalizatorModel, PortalsEvents, PortalsTotalizatorController, PortalsTotalizatorView>, IHideableMediator
	{
		// Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x75BD", Offset = "0x75BD", VA = "0x75BD")]
		public PortalsTotalizatorViewMediator(PortalsTotalizatorModel model, PortalsEvents events, PortalsTotalizatorController controller)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D6")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002470")]
			[Address(RVA = "0x75BE", Offset = "0x75BE", VA = "0x75BE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		public override PortalsTotalizatorView View
		{
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x75BF", Offset = "0x75BF", VA = "0x75BF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x75C0", Offset = "0x75C0", VA = "0x75C0", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x75C1", Offset = "0x75C1", VA = "0x75C1")]
		private void ResetView()
		{
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x75C2", Offset = "0x75C2", VA = "0x75C2")]
		private void SetupView()
		{
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x75C3", Offset = "0x75C3", VA = "0x75C3")]
		private void InitText()
		{
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x75C4", Offset = "0x75C4", VA = "0x75C4")]
		private void BetRestrictedHandler()
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x75C5", Offset = "0x75C5", VA = "0x75C5")]
		private void BetRegisteredHandler()
		{
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x75C6", Offset = "0x75C6", VA = "0x75C6")]
		private void DoBetButtonClickHandler()
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x75C7", Offset = "0x75C7", VA = "0x75C7")]
		private void UpdateButtonClickHandler()
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x75C8", Offset = "0x75C8", VA = "0x75C8")]
		private void ShowConfirmWindow(string descriptionKey, Money price, Action callback)
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x75C9", Offset = "0x75C9", VA = "0x75C9")]
		private void DoBet()
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x75CA", Offset = "0x75CA", VA = "0x75CA")]
		private void RequestBetList()
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x75CB", Offset = "0x75CB", VA = "0x75CB")]
		private void ShowBets()
		{
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x75CC", Offset = "0x75CC", VA = "0x75CC")]
		private void SetNotEnough()
		{
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x75CD", Offset = "0x75CD", VA = "0x75CD")]
		private void UpdatePrices()
		{
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x75CE", Offset = "0x75CE", VA = "0x75CE")]
		private void UpdateOSAView()
		{
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x75CF", Offset = "0x75CF", VA = "0x75CF")]
		private void HandleChoice(ulong userID, Bet.Types.State choice)
		{
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x75D0", Offset = "0x75D0", VA = "0x75D0")]
		private void ValidateChoices()
		{
		}

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x18")]
		private RatingPeriods _ratingPeriod;
	}
}
