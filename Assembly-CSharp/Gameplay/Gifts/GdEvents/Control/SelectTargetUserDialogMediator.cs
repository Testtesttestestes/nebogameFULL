using System;
using Core.Data;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.GdEvents.View;
using Gameplay.Gifts.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Gifts.GdEvents.Control
{
	// Token: 0x02000718 RID: 1816
	[Token(Token = "0x2000718")]
	public class SelectTargetUserDialogMediator : AbstractViewMediator<GiftsModel, GiftsEvents, GiftController, SelectTargetUserDialog>
	{
		// Token: 0x06002B71 RID: 11121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x7C08", Offset = "0x7C08", VA = "0x7C08")]
		public SelectTargetUserDialogMediator(GiftsModel model, GiftsEvents events, GiftController controller)
		{
		}

		// Token: 0x1700084A RID: 2122
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084A")]
		public override GiftsEvents Events
		{
			[Token(Token = "0x6002B72")]
			[Address(RVA = "0x7C09", Offset = "0x7C09", VA = "0x7C09", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x7C0A", Offset = "0x7C0A", VA = "0x7C0A")]
		private void HandleGiftSentEvent()
		{
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x7C0B", Offset = "0x7C0B", VA = "0x7C0B")]
		private void HandleGiftsStatusRequestedEvent()
		{
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x7C0C", Offset = "0x7C0C", VA = "0x7C0C")]
		private void UpdateView()
		{
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x7C0D", Offset = "0x7C0D", VA = "0x7C0D")]
		private void UpdateTexts()
		{
		}

		// Token: 0x1700084B RID: 2123
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084B")]
		public override SelectTargetUserDialog View
		{
			[Token(Token = "0x6002B77")]
			[Address(RVA = "0x7C0E", Offset = "0x7C0E", VA = "0x7C0E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x7C0F", Offset = "0x7C0F", VA = "0x7C0F")]
		private void ResetView()
		{
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x7C10", Offset = "0x7C10", VA = "0x7C10")]
		private void SetupView()
		{
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x7C11", Offset = "0x7C11", VA = "0x7C11")]
		private void HandleSelectEvent(UserData user)
		{
		}
	}
}
