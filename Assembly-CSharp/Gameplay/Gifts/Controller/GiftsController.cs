using System;
using Core.Data;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using ServicesNamespace;
using Utils;

namespace Gameplay.Gifts.Controller
{
	// Token: 0x0200071A RID: 1818
	[Token(Token = "0x200071A")]
	public class GiftsController : AbstractController<GiftsModel, GiftsEvents>
	{
		// Token: 0x06002B7C RID: 11132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x7C13", Offset = "0x7C13", VA = "0x7C13")]
		public GiftsController(GiftsModel model, GiftsEvents events)
		{
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x7C14", Offset = "0x7C14", VA = "0x7C14")]
		public void GetGiftsStatus()
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x7C15", Offset = "0x7C15", VA = "0x7C15")]
		private void GetGiftStatusResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x7C16", Offset = "0x7C16", VA = "0x7C16")]
		public void SendGift(SocialGiftDic giftInfo, UserData to)
		{
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B80")]
		[Address(RVA = "0x7C17", Offset = "0x7C17", VA = "0x7C17")]
		private void SendGiftResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x7C18", Offset = "0x7C18", VA = "0x7C18", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x7C19", Offset = "0x7C19", VA = "0x7C19")]
		private void ValidateInit()
		{
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x7C1A", Offset = "0x7C1A", VA = "0x7C1A", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x18")]
		private SocialService _socialService;
	}
}
