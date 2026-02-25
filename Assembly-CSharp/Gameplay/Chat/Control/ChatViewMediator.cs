using System;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Gameplay.Chat.View;
using Il2CppDummyDll;
using MVC;
using UI.Tabs;
using UnityEngine.EventSystems;

namespace Gameplay.Chat.Control
{
	// Token: 0x02000B2A RID: 2858
	[Token(Token = "0x2000B2A")]
	public class ChatViewMediator : AbstractViewMediator<ChatModel, ChatEvents, ChatController, ChatView>
	{
		// Token: 0x0600455D RID: 17757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600455D")]
		[Address(RVA = "0x9401", Offset = "0x9401", VA = "0x9401")]
		public ChatViewMediator(ChatModel model, ChatEvents events, ChatController controller)
		{
		}

		// Token: 0x17000DB1 RID: 3505
		// (set) Token: 0x0600455E RID: 17758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB1")]
		public override ChatEvents Events
		{
			[Token(Token = "0x600455E")]
			[Address(RVA = "0x9402", Offset = "0x9402", VA = "0x9402", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (set) Token: 0x0600455F RID: 17759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB2")]
		public override ChatView View
		{
			[Token(Token = "0x600455F")]
			[Address(RVA = "0x9403", Offset = "0x9403", VA = "0x9403", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004560 RID: 17760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004560")]
		[Address(RVA = "0x9404", Offset = "0x9404", VA = "0x9404")]
		private void SetupView()
		{
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004561")]
		[Address(RVA = "0x9405", Offset = "0x9405", VA = "0x9405")]
		private void SendMessage()
		{
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x9406", Offset = "0x9406", VA = "0x9406")]
		private TabBarItemData[] RoomsToTabs(ChatRoomData[] items)
		{
			return null;
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x9407", Offset = "0x9407", VA = "0x9407")]
		private void HandleRoomsChanges()
		{
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004564")]
		[Address(RVA = "0x9408", Offset = "0x9408", VA = "0x9408")]
		private void ShowVisitorContextMenu(ChatVisitorData visitor, ChatMessageItem messageItem)
		{
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004565")]
		[Address(RVA = "0x9409", Offset = "0x9409", VA = "0x9409")]
		private void HandleRoomRemovedEvent(ChatRoomData room)
		{
		}

		// Token: 0x06004566 RID: 17766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x940A", Offset = "0x940A", VA = "0x940A")]
		private void HandleRoomAddedEvent(ChatRoomData room)
		{
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x940B", Offset = "0x940B", VA = "0x940B")]
		private void HandleCurrentRoomChangedEvent()
		{
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004568")]
		[Address(RVA = "0x940C", Offset = "0x940C", VA = "0x940C")]
		private void HandleCurrentRoomReadyEvent()
		{
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004569")]
		[Address(RVA = "0x940D", Offset = "0x940D", VA = "0x940D")]
		private void HandleUserLeftEvent(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x940E", Offset = "0x940E", VA = "0x940E")]
		private void HandleContactAddedEvent(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456B")]
		[Address(RVA = "0x940F", Offset = "0x940F", VA = "0x940F")]
		private void HandleContactRemovedEvent(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456C")]
		[Address(RVA = "0x9410", Offset = "0x9410", VA = "0x9410")]
		private void HandleUserJoinedEvent(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x9411", Offset = "0x9411", VA = "0x9411")]
		private void HandleUserUpdatedEvent(ChatVisitorData visitor)
		{
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x9412", Offset = "0x9412", VA = "0x9412")]
		private void HandleMessageReceivedEvent(ChatMessageItem message)
		{
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x9413", Offset = "0x9413", VA = "0x9413")]
		private void HandleMessagesRemovedEvent(ChatMessageItem[] messages)
		{
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x9414", Offset = "0x9414", VA = "0x9414")]
		private void HandleStartWriteMessageToUserEvent(InputMessage inputMessage)
		{
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x9415", Offset = "0x9415", VA = "0x9415")]
		private void HandleNotViewedMessageCountChangedEvent(NotViewedMessagesInfoData info)
		{
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x9416", Offset = "0x9416", VA = "0x9416")]
		private void HandleSendMessageEvent()
		{
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x9417", Offset = "0x9417", VA = "0x9417")]
		private void HandleRoomsTabBarChangedEvent()
		{
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x9418", Offset = "0x9418", VA = "0x9418")]
		private void HandleRoomVisitorsOrContactsClickEvent(object sender, PointerEventData evt)
		{
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x9419", Offset = "0x9419", VA = "0x9419")]
		private void HandleContactListReceivedEvent()
		{
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x941A", Offset = "0x941A", VA = "0x941A")]
		private void HandleMiniChatViewSwitchClickEvent(object sender, PointerEventData evt)
		{
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x941B", Offset = "0x941B", VA = "0x941B")]
		private void HandlePrivateMessagesButtonClickEvent(object sender, PointerEventData evt)
		{
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x941C", Offset = "0x941C", VA = "0x941C")]
		private void HandleVisitorClickedEvent(object sender, ChatVisitorData visitor)
		{
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x941D", Offset = "0x941D", VA = "0x941D")]
		private void HandleMessageHasBeenViewedEvent(ChatMessageItem messageItem)
		{
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x941E", Offset = "0x941E", VA = "0x941E")]
		private void HandleMessageDeleteRequestEvent(ChatMessageItem messageItem)
		{
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x941F", Offset = "0x941F", VA = "0x941F")]
		private void HandleClickOnVisitorEvent(ChatVisitorData visitor, ChatMessageItem messageItem)
		{
		}
	}
}
