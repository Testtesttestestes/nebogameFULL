using System;
using System.Collections.Generic;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Gameplay.Chat.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Chat.Control
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	public class ChatMiniViewMediator : AbstractViewMediator<ChatModel, ChatEvents, ChatController, ChatMiniView>
	{
		// Token: 0x0600454B RID: 17739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x93EF", Offset = "0x93EF", VA = "0x93EF")]
		public ChatMiniViewMediator(ChatModel model, ChatEvents events, ChatController controller)
		{
		}

		// Token: 0x17000DAF RID: 3503
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAF")]
		public override ChatEvents Events
		{
			[Token(Token = "0x600454C")]
			[Address(RVA = "0x93F0", Offset = "0x93F0", VA = "0x93F0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (set) Token: 0x0600454D RID: 17741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB0")]
		public override ChatMiniView View
		{
			[Token(Token = "0x600454D")]
			[Address(RVA = "0x93F1", Offset = "0x93F1", VA = "0x93F1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454E")]
		[Address(RVA = "0x93F2", Offset = "0x93F2", VA = "0x93F2")]
		private void SetupView()
		{
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x93F3", Offset = "0x93F3", VA = "0x93F3")]
		private void DefineCurrentViewState()
		{
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x93F4", Offset = "0x93F4", VA = "0x93F4")]
		private void HandleLastMessagesForCurrentRoom(IList<ChatMessageItem> messages)
		{
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004551")]
		[Address(RVA = "0x93F5", Offset = "0x93F5", VA = "0x93F5")]
		private void HandleNotViewedMessages(in NotViewedMessagesInfoData info)
		{
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x93F6", Offset = "0x93F6", VA = "0x93F6")]
		private void HandleCLickEvent()
		{
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x93F7", Offset = "0x93F7", VA = "0x93F7")]
		private void HandleNoJoinedRoomsEvent()
		{
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x93F8", Offset = "0x93F8", VA = "0x93F8")]
		private void HandleSwitchMiniChatViewEvent(MiniChatButtonStates state)
		{
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x93F9", Offset = "0x93F9", VA = "0x93F9")]
		private void HandleMessageReceivedEvent(ChatMessageItem messageItem)
		{
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x93FA", Offset = "0x93FA", VA = "0x93FA")]
		private void HandleCurrentRoomChangedEvent()
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x93FB", Offset = "0x93FB", VA = "0x93FB")]
		private void HandleCurrentRoomReadyEvent()
		{
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x93FC", Offset = "0x93FC", VA = "0x93FC")]
		private void HandleNotViewedMessageCountChangedEvent(NotViewedMessagesInfoData info)
		{
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x93FD", Offset = "0x93FD", VA = "0x93FD")]
		private void AddMessageToView(params string[] texts)
		{
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x93FE", Offset = "0x93FE", VA = "0x93FE")]
		public void ShowChat()
		{
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x93FF", Offset = "0x93FF", VA = "0x93FF")]
		private void HandleCloseChatWindow()
		{
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x600455C")]
		[Address(RVA = "0x9400", Offset = "0x9400", VA = "0x9400")]
		public bool TryCloseChat()
		{
			return default(bool);
		}

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x18")]
		private ChatWindow _chatWindow;
	}
}
