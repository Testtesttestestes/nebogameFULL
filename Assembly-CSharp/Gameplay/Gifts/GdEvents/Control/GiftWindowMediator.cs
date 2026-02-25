using System;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.GdEvents.Model;
using Gameplay.Gifts.GdEvents.View;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using MVC;
using TMPro;

namespace Gameplay.Gifts.GdEvents.Control
{
	// Token: 0x02000716 RID: 1814
	[Token(Token = "0x2000716")]
	public class GiftWindowMediator : AbstractViewMediator<GiftModel, GiftsEvents, GiftController, GiftWindow>
	{
		// Token: 0x06002B65 RID: 11109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B65")]
		[Address(RVA = "0x7BFD", Offset = "0x7BFD", VA = "0x7BFD")]
		public GiftWindowMediator(GiftModel model, GiftsEvents events, GiftController controller)
		{
		}

		// Token: 0x17000848 RID: 2120
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000848")]
		public override GiftsEvents Events
		{
			[Token(Token = "0x6002B66")]
			[Address(RVA = "0x7BFE", Offset = "0x7BFE", VA = "0x7BFE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000849 RID: 2121
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000849")]
		public override GiftWindow View
		{
			[Token(Token = "0x6002B67")]
			[Address(RVA = "0x7BFF", Offset = "0x7BFF", VA = "0x7BFF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B68")]
		[Address(RVA = "0x7C00", Offset = "0x7C00", VA = "0x7C00")]
		private void ResetView()
		{
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B69")]
		[Address(RVA = "0x7C01", Offset = "0x7C01", VA = "0x7C01")]
		private void SetupView()
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6A")]
		[Address(RVA = "0x7C02", Offset = "0x7C02", VA = "0x7C02")]
		private void SendGiftEventHandler(GiftView view)
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6B")]
		[Address(RVA = "0x7C03", Offset = "0x7C03", VA = "0x7C03")]
		private void GiftSentEventHandler()
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6C")]
		[Address(RVA = "0x7C04", Offset = "0x7C04", VA = "0x7C04")]
		private void GiftsStatusRequestedEventHandler()
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6D")]
		[Address(RVA = "0x7C05", Offset = "0x7C05", VA = "0x7C05")]
		private void RefreshAnnotation()
		{
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x7C06", Offset = "0x7C06", VA = "0x7C06")]
		private void UpdateAnnotation(TextMeshProUGUI text, string owner, int maxGifts, int giftsLeft)
		{
		}
	}
}
