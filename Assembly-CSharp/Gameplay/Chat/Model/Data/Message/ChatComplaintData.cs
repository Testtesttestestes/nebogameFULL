using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B14 RID: 2836
	[Token(Token = "0x2000B14")]
	public class ChatComplaintData : ChatMessageData
	{
		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D87")]
		public RoomKey MessageRoomKey
		{
			[Token(Token = "0x6004477")]
			[Address(RVA = "0x9327", Offset = "0x9327", VA = "0x9327")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004478")]
			[Address(RVA = "0x9328", Offset = "0x9328", VA = "0x9328")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D88")]
		public ChatMessageData Message
		{
			[Token(Token = "0x6004479")]
			[Address(RVA = "0x9329", Offset = "0x9329", VA = "0x9329")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x932A", Offset = "0x932A", VA = "0x932A")]
		public ChatComplaintData(uint id, RoomKey messageRoomKey, ChatMessageData message, ChatVisitorData chatUser, IChatMsgPresenter presenter)
		{
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600447B")]
		[Address(RVA = "0x932B", Offset = "0x932B", VA = "0x932B", Slot = "6")]
		public override string GetText(MessageDrawTarget target)
		{
			return null;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447C")]
		[Address(RVA = "0x932C", Offset = "0x932C", VA = "0x932C", Slot = "7")]
		public override void SetText(string value)
		{
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D89")]
		public override string TimeString
		{
			[Token(Token = "0x600447D")]
			[Address(RVA = "0x932D", Offset = "0x932D", VA = "0x932D", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8A")]
		public override bool IsReDrawRequired
		{
			[Token(Token = "0x600447E")]
			[Address(RVA = "0x932E", Offset = "0x932E", VA = "0x932E", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600447F")]
			[Address(RVA = "0x932F", Offset = "0x932F", VA = "0x932F", Slot = "5")]
			set
			{
			}
		}
	}
}
