using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using Protocol.Chat;
using Protocol.Dic;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2000B11")]
	public class ChatRoomData : IDisposable
	{
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D78")]
		public RoomKey RoomKey
		{
			[Token(Token = "0x6004457")]
			[Address(RVA = "0x9307", Offset = "0x9307", VA = "0x9307")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x0000CE28 File Offset: 0x0000B028
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D79")]
		public int NotViewedMessagesCount
		{
			[Token(Token = "0x6004458")]
			[Address(RVA = "0x9308", Offset = "0x9308", VA = "0x9308")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004459")]
			[Address(RVA = "0x9309", Offset = "0x9309", VA = "0x9309")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x930A", Offset = "0x930A", VA = "0x930A", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600445C RID: 17500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7A")]
		public RoomRight Rights
		{
			[Token(Token = "0x600445B")]
			[Address(RVA = "0x930B", Offset = "0x930B", VA = "0x930B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600445C")]
			[Address(RVA = "0x930C", Offset = "0x930C", VA = "0x930C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x0000CE40 File Offset: 0x0000B040
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7B")]
		public bool IsReady
		{
			[Token(Token = "0x600445D")]
			[Address(RVA = "0x930D", Offset = "0x930D", VA = "0x930D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600445E")]
			[Address(RVA = "0x930E", Offset = "0x930E", VA = "0x930E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D7C")]
		public ChatRoomDic RoomDic
		{
			[Token(Token = "0x600445F")]
			[Address(RVA = "0x930F", Offset = "0x930F", VA = "0x930F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004460")]
			[Address(RVA = "0x9310", Offset = "0x9310", VA = "0x9310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x9311", Offset = "0x9311", VA = "0x9311", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004462")]
		[Address(RVA = "0x9312", Offset = "0x9312", VA = "0x9312")]
		public ChatRoomData(RoomRight roomRight, ChatRoomDic dic, int startVisitorCapacity)
		{
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x17000D7D")]
		public bool JoinAllowed
		{
			[Token(Token = "0x6004463")]
			[Address(RVA = "0x9313", Offset = "0x9313", VA = "0x9313")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6004464")]
		[Address(RVA = "0x9314", Offset = "0x9314", VA = "0x9314")]
		public bool TryGetVisitor(string nick, out ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<ChatVisitorData> Visitors;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0xC")]
		public readonly List<ChatMessageItem> Messages;
	}
}
