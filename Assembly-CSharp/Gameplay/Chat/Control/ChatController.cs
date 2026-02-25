using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Chat;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Chat.Control
{
	// Token: 0x02000B26 RID: 2854
	[Token(Token = "0x2000B26")]
	public class ChatController : AbstractController<ChatModel, ChatEvents>
	{
		// Token: 0x060044E8 RID: 17640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E8")]
		[Address(RVA = "0x938E", Offset = "0x938E", VA = "0x938E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x938F", Offset = "0x938F", VA = "0x938F")]
		public ChatController(ChatModel model, ChatEvents events)
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EA")]
		[Address(RVA = "0x9390", Offset = "0x9390", VA = "0x9390", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0x9391", Offset = "0x9391", VA = "0x9391", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x9392", Offset = "0x9392", VA = "0x9392")]
		private void ValidateInit()
		{
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x9393", Offset = "0x9393", VA = "0x9393")]
		private void StartListenServiceEvents()
		{
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x9394", Offset = "0x9394", VA = "0x9394")]
		private void StopListenServiceEvents()
		{
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x9395", Offset = "0x9395", VA = "0x9395")]
		private ChatVisitorData GetVisitor(ChatUserInfo source)
		{
			return null;
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x9396", Offset = "0x9396", VA = "0x9396")]
		private ChatVisitorData ParseVisitor(ChatUserInfo source)
		{
			return null;
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x9397", Offset = "0x9397", VA = "0x9397")]
		private ChatUserMessageData ParseMessage(ChatMessage source)
		{
			return null;
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x9398", Offset = "0x9398", VA = "0x9398")]
		private void UpdateVisitor(ChatVisitorData visitor, ChatUserInfo source)
		{
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x9399", Offset = "0x9399", VA = "0x9399")]
		private void HandleVisitorBan(ChatVisitorData visitor)
		{
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x939A", Offset = "0x939A", VA = "0x939A")]
		private void ManageBan()
		{
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x939B", Offset = "0x939B", VA = "0x939B")]
		private void ManageMaxMessages(ChatRoomData room)
		{
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x939C", Offset = "0x939C", VA = "0x939C")]
		private void ManageRights(RepeatedField<RoomRight> rights)
		{
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x939D", Offset = "0x939D", VA = "0x939D")]
		private ChatRoomData RemoveRoom(RoomKey roomKey)
		{
			return null;
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x939E", Offset = "0x939E", VA = "0x939E")]
		private ChatRoomData AddRoom(ChatRoomData room)
		{
			return null;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x939F", Offset = "0x939F", VA = "0x939F")]
		private void SetCurrentRoom(ChatRoomData room)
		{
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x93A0", Offset = "0x93A0", VA = "0x93A0")]
		private IEnumerator BanCoroutine(BackTime backTime)
		{
			return null;
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x93A1", Offset = "0x93A1", VA = "0x93A1")]
		private void StopBanCoroutine()
		{
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x93A2", Offset = "0x93A2", VA = "0x93A2")]
		private void DefineCurrentRoom()
		{
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x93A3", Offset = "0x93A3", VA = "0x93A3")]
		private void SendMessage(string text, ChatRoomData room, ChatMessage.Types.ChatMessageTypes messageType, ulong userId)
		{
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x93A4", Offset = "0x93A4", VA = "0x93A4")]
		private ChatVisitorData JoinUserToRoom(RoomKey roomKey, ChatUserInfo userInfo)
		{
			return null;
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x93A5", Offset = "0x93A5", VA = "0x93A5")]
		private List<ChatVisitorData> UpdateAttackAbility(IEnumerable<AttackabilityInfo> value)
		{
			return null;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x93A6", Offset = "0x93A6", VA = "0x93A6")]
		private ChatMessageItem AddMessage(RoomKey roomKey, ChatMessage message)
		{
			return null;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x93A7", Offset = "0x93A7", VA = "0x93A7")]
		private ChatMessageItem AddMessage(RoomKey roomKey, ChatMessageData message)
		{
			return null;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x1BB7", Offset = "0x1BB7", VA = "0x1BB7")]
		private void NotifyMessageReceived(ChatMessageItem message)
		{
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004503")]
		[Address(RVA = "0x93A8", Offset = "0x93A8", VA = "0x93A8")]
		private IList<ChatMessageItem> FilterMessage(IList<ChatMessageItem> messages)
		{
			return null;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004504")]
		[Address(RVA = "0x93A9", Offset = "0x93A9", VA = "0x93A9")]
		public IList<ChatMessageItem> GetCurrentRoomMessages()
		{
			return null;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004505")]
		[Address(RVA = "0x93AA", Offset = "0x93AA", VA = "0x93AA")]
		public IList<ChatMessageItem> GetRoomMessages(ChatRoomData room)
		{
			return null;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x6004506")]
		[Address(RVA = "0x93AB", Offset = "0x93AB", VA = "0x93AB")]
		public NotViewedMessagesInfoData GetNotViewedMessageCount(params ChatRoomData[] rooms)
		{
			return default(NotViewedMessagesInfoData);
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004507")]
		[Address(RVA = "0x93AC", Offset = "0x93AC", VA = "0x93AC")]
		private void AddToFavoritesInternal(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004508")]
		[Address(RVA = "0x93AD", Offset = "0x93AD", VA = "0x93AD")]
		private void RemoveFromFavoritesInternal(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004509")]
		[Address(RVA = "0x1BB6", Offset = "0x1BB6", VA = "0x1BB6")]
		private void IncrementNotViewMessages(ChatRoomData room)
		{
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450A")]
		[Address(RVA = "0x93AE", Offset = "0x93AE", VA = "0x93AE")]
		private void TryDecrementNotViewMessages(ChatMessageItem message)
		{
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450B")]
		[Address(RVA = "0x93AF", Offset = "0x93AF", VA = "0x93AF")]
		private void RequestGetChatInfo()
		{
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450C")]
		[Address(RVA = "0x93B0", Offset = "0x93B0", VA = "0x93B0")]
		private void RequestTakeOffBan()
		{
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450D")]
		[Address(RVA = "0x93B1", Offset = "0x93B1", VA = "0x93B1")]
		private void RequestGetRoomInfo(ChatRoomData room)
		{
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450E")]
		[Address(RVA = "0x93B2", Offset = "0x93B2", VA = "0x93B2")]
		private void RequestGetAllComplaints()
		{
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x93B3", Offset = "0x93B3", VA = "0x93B3")]
		private void RequestGetContactList()
		{
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004510")]
		[Address(RVA = "0x93B4", Offset = "0x93B4", VA = "0x93B4")]
		private void RequestAddToFavorites(ulong userId)
		{
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004511")]
		[Address(RVA = "0x93B5", Offset = "0x93B5", VA = "0x93B5")]
		private void RequestRemoveToFavorites(ulong userId)
		{
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x93B6", Offset = "0x93B6", VA = "0x93B6")]
		private void RequestSendMessage(ChatRoomData room, string text, ChatMessage.Types.ChatMessageTypes messageType, ulong toUserId)
		{
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x93B7", Offset = "0x93B7", VA = "0x93B7")]
		private void RequestSendComplaint(ChatRoomData room, uint messageId)
		{
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x93B8", Offset = "0x93B8", VA = "0x93B8")]
		private void RequestRemoveMessage(RoomKey roomKey, uint messageId, ChatComplaintData complaint)
		{
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x93B9", Offset = "0x93B9", VA = "0x93B9")]
		private void RequestProcessComplaint(uint complaintId, bool accepted)
		{
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x93BA", Offset = "0x93BA", VA = "0x93BA")]
		private void RequestBanUser(ulong userId, uint banId)
		{
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x93BB", Offset = "0x93BB", VA = "0x93BB")]
		private void HandleGetChatInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x93BC", Offset = "0x93BC", VA = "0x93BC")]
		private void HandleGetRoomInfoService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x93BD", Offset = "0x93BD", VA = "0x93BD")]
		private void HandleGetAllComplaintsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x93BE", Offset = "0x93BE", VA = "0x93BE")]
		private void HandleGetContactListService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451B")]
		[Address(RVA = "0x93BF", Offset = "0x93BF", VA = "0x93BF")]
		private void HandleAddToFavoritesService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x93C0", Offset = "0x93C0", VA = "0x93C0")]
		private void HandleRemoveFromFavoritesService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x93C1", Offset = "0x93C1", VA = "0x93C1")]
		private void HandleSendMessageService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x93C2", Offset = "0x93C2", VA = "0x93C2")]
		private void HandleSendComplaintService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451F")]
		[Address(RVA = "0x93C3", Offset = "0x93C3", VA = "0x93C3")]
		private void HandlerBanUserService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004520")]
		[Address(RVA = "0x93C4", Offset = "0x93C4", VA = "0x93C4")]
		private void HandleProcessComplaintService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004521")]
		[Address(RVA = "0x93C5", Offset = "0x93C5", VA = "0x93C5")]
		private void HandleRemoveMessageService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004522")]
		[Address(RVA = "0x93C6", Offset = "0x93C6", VA = "0x93C6")]
		private void HandleTakeOffBanService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x93C7", Offset = "0x93C7", VA = "0x93C7")]
		private void HandleRoomJoinEvent(ProtoJoinRoomEvt msg)
		{
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x93C8", Offset = "0x93C8", VA = "0x93C8")]
		private void HandleRoomUnjoinEvent(ProtoUnjoinRoomEvt msg)
		{
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x93C9", Offset = "0x93C9", VA = "0x93C9")]
		private void HandleNewMessageEvent(ProtoChatMessageEvt msg)
		{
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x93CA", Offset = "0x93CA", VA = "0x93CA")]
		private void HandleUserInfoChangedEvent(ProtoUserInfoChangedEvt msg)
		{
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x93CB", Offset = "0x93CB", VA = "0x93CB")]
		private void HandleNewComplaintEvent(ProtoNewComplaintEvt msg)
		{
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x93CC", Offset = "0x93CC", VA = "0x93CC")]
		private void HandleComplaintProcessedEvent(ProtoComplaintProcessedEvt msg)
		{
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004529")]
		[Address(RVA = "0x93CD", Offset = "0x93CD", VA = "0x93CD")]
		private void HandleAdmonitionEvent(ProtoAdmonitionEvt msg)
		{
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452A")]
		[Address(RVA = "0x93CE", Offset = "0x93CE", VA = "0x93CE")]
		private void HandleMessageRemovedEvent(ProtoRemoveMessageEvt msg)
		{
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x93CF", Offset = "0x93CF", VA = "0x93CF")]
		private void HandleNewContactEvent(ChatUserInfo msg)
		{
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x93D0", Offset = "0x93D0", VA = "0x93D0")]
		private void HandleContactRemovedEvent(ProtoContactRemovedEvt msg)
		{
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x93D1", Offset = "0x93D1", VA = "0x93D1")]
		private void HandleRightsChangedEvent(ProtoRightsChangedEvt msg)
		{
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x93D2", Offset = "0x93D2", VA = "0x93D2")]
		private void HandleAttackAbilityInfoChangedEvent(ProtoAttackabilityChangedEvt msg)
		{
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x93D3", Offset = "0x93D3", VA = "0x93D3")]
		public void RequestFavoritesList()
		{
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x93D4", Offset = "0x93D4", VA = "0x93D4")]
		public void SetRoom(RoomKey roomKey)
		{
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x93D5", Offset = "0x93D5", VA = "0x93D5")]
		public void AddToFavorites(ulong userId)
		{
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x93D6", Offset = "0x93D6", VA = "0x93D6")]
		public void AddToFavorites(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x93D7", Offset = "0x93D7", VA = "0x93D7")]
		public void RemoveFromFavorites(ulong userId)
		{
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x93D8", Offset = "0x93D8", VA = "0x93D8")]
		public void RemoveFromFavorites(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x93D9", Offset = "0x93D9", VA = "0x93D9")]
		public bool TrySendMessage(string text)
		{
			return default(bool);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x93DA", Offset = "0x93DA", VA = "0x93DA")]
		public bool TrySendMessage(InputMessage message)
		{
			return default(bool);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x93DB", Offset = "0x93DB", VA = "0x93DB")]
		public bool TrySendMessage(InputMessage message, ChatVisitorData visitor)
		{
			return default(bool);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x93DC", Offset = "0x93DC", VA = "0x93DC")]
		public void SendComplaint(ChatMessageItem message)
		{
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004539")]
		[Address(RVA = "0x93DD", Offset = "0x93DD", VA = "0x93DD")]
		public void RemoveMessage(ChatMessageItem messageItem)
		{
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x93DE", Offset = "0x93DE", VA = "0x93DE")]
		public void RejectComplaint(ChatComplaintData complaint)
		{
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x93DF", Offset = "0x93DF", VA = "0x93DF")]
		public void BanUser(ulong userId, uint banId)
		{
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x93E0", Offset = "0x93E0", VA = "0x93E0")]
		public void SetCurrentUIVisitorsState(RoomVisitorsOrContactsStates value)
		{
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x93E1", Offset = "0x93E1", VA = "0x93E1")]
		public void SetCurrentMiniChatViewState(MiniChatButtonStates value)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x93E2", Offset = "0x93E2", VA = "0x93E2")]
		public void SetCurrentPrivateOrAllMessagesState(PrivateOrAllMessagesStates value)
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x93E3", Offset = "0x93E3", VA = "0x93E3")]
		public void SetMessageAsViewed(ChatMessageItem message)
		{
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x93E4", Offset = "0x93E4", VA = "0x93E4")]
		public void StartWritePrivateMessage(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x93E5", Offset = "0x93E5", VA = "0x93E5")]
		public void StartWriteMessage(ChatVisitorData visitor)
		{
		}

		// Token: 0x040025FB RID: 9723
		[Token(Token = "0x40025FB")]
		[FieldOffset(Offset = "0x18")]
		private ChatService _service;

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _banCoroutine;
	}
}
