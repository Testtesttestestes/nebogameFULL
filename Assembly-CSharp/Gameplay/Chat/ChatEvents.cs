using System;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Chat
{
	// Token: 0x02000AE5 RID: 2789
	[Token(Token = "0x2000AE5")]
	public class ChatEvents : AbstractMVCEvents
	{
		// Token: 0x0600433F RID: 17215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433F")]
		[Address(RVA = "0x91F3", Offset = "0x91F3", VA = "0x91F3")]
		public ChatEvents()
		{
		}

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x14")]
		public Action<ChatVisitorData> UserUpdatedEvent;

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x18")]
		public Action<ChatVisitorData> UserJoinedEvent;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ChatVisitorData> UserLeftEvent;

		// Token: 0x04002503 RID: 9475
		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0x20")]
		public Action<ChatVisitorData> ContactRemovedEvent;

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[FieldOffset(Offset = "0x24")]
		public Action<ChatVisitorData> ContactAddedEvent;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[FieldOffset(Offset = "0x28")]
		public Action ContactListReceivedEvent;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[FieldOffset(Offset = "0x2C")]
		public Action<ChatMessageItem> MessageContentUpdatedEvent;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[FieldOffset(Offset = "0x30")]
		public Action<ChatMessageItem> MessageReceivedEvent;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[FieldOffset(Offset = "0x34")]
		public Action<ChatMessageItem[]> MessagesRemovedEvent;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[FieldOffset(Offset = "0x38")]
		public Action<ChatRoomData> RoomRemovedEvent;

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[FieldOffset(Offset = "0x3C")]
		public Action<ChatRoomData> RoomAddedEvent;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		[FieldOffset(Offset = "0x40")]
		public Action CurrentRoomChangedEvent;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[FieldOffset(Offset = "0x44")]
		public Action CurrentRoomReadyEvent;

		// Token: 0x0400250D RID: 9485
		[Token(Token = "0x400250D")]
		[FieldOffset(Offset = "0x48")]
		public Action<NotViewedMessagesInfoData> NotViewedMessageCountChangedEvent;

		// Token: 0x0400250E RID: 9486
		[Token(Token = "0x400250E")]
		[FieldOffset(Offset = "0x4C")]
		public Action NoJoinedRoomsEvent;

		// Token: 0x0400250F RID: 9487
		[Token(Token = "0x400250F")]
		[FieldOffset(Offset = "0x50")]
		public Action<MiniChatButtonStates> SwitchMiniChatViewEvent;

		// Token: 0x04002510 RID: 9488
		[Token(Token = "0x4002510")]
		[FieldOffset(Offset = "0x54")]
		public Action<InputMessage> StartWriteMessageToUserEvent;
	}
}
