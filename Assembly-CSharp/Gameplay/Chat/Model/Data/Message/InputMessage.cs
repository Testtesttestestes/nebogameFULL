using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	public class InputMessage
	{
		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x0000CF18 File Offset: 0x0000B118
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D92")]
		public ChatMessage.Types.ChatMessageTypes MessageType
		{
			[Token(Token = "0x6004493")]
			[Address(RVA = "0x9340", Offset = "0x9340", VA = "0x9340")]
			[CompilerGenerated]
			get
			{
				return ChatMessage.Types.ChatMessageTypes.UnknownChatMessageType;
			}
			[Token(Token = "0x6004494")]
			[Address(RVA = "0x9341", Offset = "0x9341", VA = "0x9341")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D93")]
		public string UserNick
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0x9342", Offset = "0x9342", VA = "0x9342")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x9343", Offset = "0x9343", VA = "0x9343")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D94")]
		public string MessageText
		{
			[Token(Token = "0x6004497")]
			[Address(RVA = "0x9344", Offset = "0x9344", VA = "0x9344")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004498")]
			[Address(RVA = "0x9345", Offset = "0x9345", VA = "0x9345")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x9346", Offset = "0x9346", VA = "0x9346")]
		public InputMessage(string text)
		{
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x9347", Offset = "0x9347", VA = "0x9347")]
		public InputMessage(string text, string userNick)
		{
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x9348", Offset = "0x9348", VA = "0x9348", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x9349", Offset = "0x9349", VA = "0x9349")]
		public static string GetPayload(string text)
		{
			return null;
		}

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		public const string PRIVATE_MSG_CHARS = "/private";

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		public const string TO_MSG_CHARS = "/to";
	}
}
