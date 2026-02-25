using System;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Gameplay.RateGame.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.RateGame.Controller
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	public class RateGameWindowMediator : AbstractViewMediator<RateGameModel, RateGameEvents, RateGameController, RateGameWindow>
	{
		// Token: 0x060022D5 RID: 8917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x742C", Offset = "0x742C", VA = "0x742C")]
		public RateGameWindowMediator(RateGameModel model, RateGameEvents events, RateGameController controller)
		{
		}

		// Token: 0x1700065F RID: 1631
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065F")]
		public override RateGameWindow View
		{
			[Token(Token = "0x60022D6")]
			[Address(RVA = "0x742D", Offset = "0x742D", VA = "0x742D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x742E", Offset = "0x742E", VA = "0x742E")]
		private void PositiveRateButtonClickHandler()
		{
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x742F", Offset = "0x742F", VA = "0x742F")]
		private void NegativeRateButtonClickHandler()
		{
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x7430", Offset = "0x7430", VA = "0x7430")]
		private void ViewOnCloseButtonClickEvent()
		{
		}

		// Token: 0x17000660 RID: 1632
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000660")]
		public override RateGameEvents Events
		{
			[Token(Token = "0x60022DA")]
			[Address(RVA = "0x7431", Offset = "0x7431", VA = "0x7431", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x7432", Offset = "0x7432", VA = "0x7432")]
		private void RateGameEvent(uint rate)
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x7433", Offset = "0x7433", VA = "0x7433")]
		private void RateGameButtonClickHandler()
		{
		}
	}
}
