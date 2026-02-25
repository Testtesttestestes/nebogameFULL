using System;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.RateGame.Controller
{
	// Token: 0x020005AA RID: 1450
	[Token(Token = "0x20005AA")]
	public class RateGameController : AbstractController<RateGameModel, RateGameEvents>
	{
		// Token: 0x060022CD RID: 8909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x7424", Offset = "0x7424", VA = "0x7424")]
		public RateGameController(RateGameModel model, RateGameEvents events)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x7425", Offset = "0x7425", VA = "0x7425", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x7426", Offset = "0x7426", VA = "0x7426", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x7427", Offset = "0x7427", VA = "0x7427")]
		private bool IsNeedToShowRateGameWindow()
		{
			return default(bool);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x7428", Offset = "0x7428", VA = "0x7428")]
		private void ShowRateGameWindow()
		{
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x7429", Offset = "0x7429", VA = "0x7429")]
		public void RateGame(uint rate)
		{
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x742A", Offset = "0x742A", VA = "0x742A")]
		private void Handler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x742B", Offset = "0x742B", VA = "0x742B")]
		public void RegisterCloseButtonClicked()
		{
		}

		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x18")]
		private SocialService _socialService;
	}
}
