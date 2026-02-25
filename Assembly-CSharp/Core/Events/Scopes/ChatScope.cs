using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using Protocol.Chat;

namespace Core.Events.Scopes
{
	// Token: 0x02000FE3 RID: 4067
	[Token(Token = "0x2000FE3")]
	public class ChatScope : AbstractEventBusScope
	{
		// Token: 0x060060E2 RID: 24802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E2")]
		[Address(RVA = "0xAD0E", Offset = "0xAD0E", VA = "0xAD0E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E3")]
		[Address(RVA = "0xAD0F", Offset = "0xAD0F", VA = "0xAD0F")]
		public ChatScope()
		{
		}

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[FieldOffset(Offset = "0x8")]
		public Action<ChatScope.ChatEventArgs> SendMessageEvent;

		// Token: 0x02000FE4 RID: 4068
		[Token(Token = "0x2000FE4")]
		public class ChatEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700131D RID: 4893
			// (get) Token: 0x060060E4 RID: 24804 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700131D")]
			public ChatRoomData Room
			{
				[Token(Token = "0x60060E4")]
				[Address(RVA = "0xAD10", Offset = "0xAD10", VA = "0xAD10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700131E RID: 4894
			// (get) Token: 0x060060E5 RID: 24805 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700131E")]
			public string Text
			{
				[Token(Token = "0x60060E5")]
				[Address(RVA = "0xAD11", Offset = "0xAD11", VA = "0xAD11")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700131F RID: 4895
			// (get) Token: 0x060060E6 RID: 24806 RVA: 0x00011A78 File Offset: 0x0000FC78
			[Token(Token = "0x1700131F")]
			public ChatMessage.Types.ChatMessageTypes MessageType
			{
				[Token(Token = "0x60060E6")]
				[Address(RVA = "0xAD12", Offset = "0xAD12", VA = "0xAD12")]
				[CompilerGenerated]
				get
				{
					return ChatMessage.Types.ChatMessageTypes.UnknownChatMessageType;
				}
			}

			// Token: 0x17001320 RID: 4896
			// (get) Token: 0x060060E7 RID: 24807 RVA: 0x00011A90 File Offset: 0x0000FC90
			[Token(Token = "0x17001320")]
			public ulong ToUserId
			{
				[Token(Token = "0x60060E7")]
				[Address(RVA = "0xAD13", Offset = "0xAD13", VA = "0xAD13")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x060060E8 RID: 24808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060E8")]
			[Address(RVA = "0xAD14", Offset = "0xAD14", VA = "0xAD14")]
			public ChatEventArgs(App app, IGame game, ChatRoomData room, string text, ChatMessage.Types.ChatMessageTypes messageType, ulong toUserId)
			{
			}
		}
	}
}
