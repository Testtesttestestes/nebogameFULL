using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B16 RID: 2838
	[Token(Token = "0x2000B16")]
	public class ChatMessageItem
	{
		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004487 RID: 17543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8D")]
		public ChatRoomData Room
		{
			[Token(Token = "0x6004486")]
			[Address(RVA = "0x9333", Offset = "0x9333", VA = "0x9333")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004487")]
			[Address(RVA = "0x9334", Offset = "0x9334", VA = "0x9334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004489 RID: 17545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8E")]
		public ChatMessageData MessageData
		{
			[Token(Token = "0x6004488")]
			[Address(RVA = "0x9335", Offset = "0x9335", VA = "0x9335")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004489")]
			[Address(RVA = "0x9336", Offset = "0x9336", VA = "0x9336")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448A")]
		[Address(RVA = "0x9337", Offset = "0x9337", VA = "0x9337")]
		public ChatMessageItem(ChatRoomData room, ChatMessageData messageData)
		{
		}

		// Token: 0x040025CE RID: 9678
		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x10")]
		public bool IsViewed;
	}
}
