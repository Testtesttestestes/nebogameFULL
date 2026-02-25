using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B15 RID: 2837
	[Token(Token = "0x2000B15")]
	public abstract class ChatMessageData
	{
		// Token: 0x06004480 RID: 17536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004480")]
		[Address(RVA = "0x9330", Offset = "0x9330", VA = "0x9330")]
		protected ChatMessageData(uint id, ChatVisitorData chatUser, IChatMsgPresenter presenter)
		{
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x0000CF00 File Offset: 0x0000B100
		// (set) Token: 0x06004482 RID: 17538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8B")]
		public virtual bool IsReDrawRequired
		{
			[Token(Token = "0x6004481")]
			[Address(RVA = "0x9331", Offset = "0x9331", VA = "0x9331", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004482")]
			[Address(RVA = "0x9332", Offset = "0x9332", VA = "0x9332", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004483 RID: 17539
		[Token(Token = "0x6004483")]
		public abstract string GetText(MessageDrawTarget target);

		// Token: 0x06004484 RID: 17540
		[Token(Token = "0x6004484")]
		public abstract void SetText(string value);

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06004485 RID: 17541
		[Token(Token = "0x17000D8C")]
		public abstract string TimeString { [Token(Token = "0x6004485")] get; }

		// Token: 0x040025C8 RID: 9672
		[Token(Token = "0x40025C8")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint Id;

		// Token: 0x040025C9 RID: 9673
		[Token(Token = "0x40025C9")]
		[FieldOffset(Offset = "0xC")]
		protected readonly IChatMsgPresenter _messagePresenter;

		// Token: 0x040025CA RID: 9674
		[Token(Token = "0x40025CA")]
		[FieldOffset(Offset = "0x10")]
		public readonly ChatVisitorData ChatUser;
	}
}
