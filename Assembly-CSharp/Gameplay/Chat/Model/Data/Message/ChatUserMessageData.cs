using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B17 RID: 2839
	[Token(Token = "0x2000B17")]
	public class ChatUserMessageData : ChatMessageData
	{
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8F")]
		[CanBeNull]
		public ChatVisitorData Sender
		{
			[Token(Token = "0x600448B")]
			[Address(RVA = "0x9338", Offset = "0x9338", VA = "0x9338")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600448C")]
			[Address(RVA = "0x9339", Offset = "0x9339", VA = "0x9339")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D90")]
		[CanBeNull]
		public ChatVisitorData Addressee
		{
			[Token(Token = "0x600448D")]
			[Address(RVA = "0x933A", Offset = "0x933A", VA = "0x933A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600448E")]
			[Address(RVA = "0x933B", Offset = "0x933B", VA = "0x933B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448F")]
		[Address(RVA = "0x933C", Offset = "0x933C", VA = "0x933C")]
		public ChatUserMessageData(ChatMessage source, ChatVisitorData chatUser, IChatMsgPresenter presenter)
		{
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x933D", Offset = "0x933D", VA = "0x933D", Slot = "6")]
		public override string GetText(MessageDrawTarget target)
		{
			return null;
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004491")]
		[Address(RVA = "0x933E", Offset = "0x933E", VA = "0x933E", Slot = "7")]
		public override void SetText(string value)
		{
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D91")]
		public override string TimeString
		{
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x933F", Offset = "0x933F", VA = "0x933F", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x20")]
		[NotNull]
		public readonly ChatMessage SourceMessage;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<MessageDrawTarget, string> _cachedTexts;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x28")]
		private string _timeString;
	}
}
