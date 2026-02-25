using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Sorting;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.View.Messages;
using Gameplay.Chat.View.Smiles;
using Gameplay.Chat.View.Sorting;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Tabs;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	public class ChatView : MonoBehaviourWithStates<ChatViewStates>, IChatView
	{
		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D46")]
		public TabBar RoomsTabBar
		{
			[Token(Token = "0x600435E")]
			[Address(RVA = "0x9212", Offset = "0x9212", VA = "0x9212")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D47")]
		public SelectedButton PrivateMessagesButton
		{
			[Token(Token = "0x600435F")]
			[Address(RVA = "0x9213", Offset = "0x9213", VA = "0x9213")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D48")]
		public SelectedButton MiniChatViewSwitchButton
		{
			[Token(Token = "0x6004360")]
			[Address(RVA = "0x9214", Offset = "0x9214", VA = "0x9214")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D49")]
		public SelectedButton RoomVisitorsOrContactsButton
		{
			[Token(Token = "0x6004361")]
			[Address(RVA = "0x9215", Offset = "0x9215", VA = "0x9215")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4A")]
		public PatternTextInput MessageTextInput
		{
			[Token(Token = "0x6004362")]
			[Address(RVA = "0x9216", Offset = "0x9216", VA = "0x9216")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4B")]
		public ChatRoomVisitorsListAdapter VisitorsList
		{
			[Token(Token = "0x6004363")]
			[Address(RVA = "0x9217", Offset = "0x9217", VA = "0x9217")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4C")]
		public MessagesListAdapter MessagesList
		{
			[Token(Token = "0x6004364")]
			[Address(RVA = "0x9218", Offset = "0x9218", VA = "0x9218")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D4D")]
		public SmilesView SmilesView
		{
			[Token(Token = "0x6004365")]
			[Address(RVA = "0x9219", Offset = "0x9219", VA = "0x9219")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001A4 RID: 420
		// (add) Token: 0x06004366 RID: 17254 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004367 RID: 17255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A4")]
		public event Action SendMessageEvent
		{
			[Token(Token = "0x6004366")]
			[Address(RVA = "0x921A", Offset = "0x921A", VA = "0x921A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004367")]
			[Address(RVA = "0x921B", Offset = "0x921B", VA = "0x921B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004368")]
		[Address(RVA = "0x921C", Offset = "0x921C", VA = "0x921C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004369")]
		[Address(RVA = "0x921D", Offset = "0x921D", VA = "0x921D")]
		private void Start()
		{
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436A")]
		[Address(RVA = "0x921E", Offset = "0x921E", VA = "0x921E")]
		private void HandleMessageInputSubmit(string text)
		{
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436B")]
		[Address(RVA = "0x921F", Offset = "0x921F", VA = "0x921F")]
		private void HandleSmilesButtonClickEvent(object sender, PointerEventData e)
		{
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436C")]
		[Address(RVA = "0x9220", Offset = "0x9220", VA = "0x9220")]
		private void HandleSmilesViewItemSelectedEvent(ChatSmileDic smileDic)
		{
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436D")]
		[Address(RVA = "0x9221", Offset = "0x9221", VA = "0x9221")]
		private void HandleVisitorsSearchFieldOnValueChanged(string value)
		{
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436E")]
		[Address(RVA = "0x9222", Offset = "0x9222", VA = "0x9222")]
		private void HandleCurrentVisitorsSortComparerChanged()
		{
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x9223", Offset = "0x9223", VA = "0x9223")]
		public ChatVisitorData[] PrepareVisitorForDisplay(IEnumerable<ChatVisitorData> visitors)
		{
			return null;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x9224", Offset = "0x9224", VA = "0x9224")]
		private void HandleVisitorsSortTriggered(IGameDataComparer<ChatVisitorData> comparer)
		{
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x9225", Offset = "0x9225", VA = "0x9225")]
		private void HandleSendMessageButtonClickEvent()
		{
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x9226", Offset = "0x9226", VA = "0x9226")]
		private void HandleMessageTextInputStatusChangedEvent(bool status)
		{
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x9227", Offset = "0x9227", VA = "0x9227")]
		private IEnumerator ScrollTpSpike()
		{
			return null;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x9228", Offset = "0x9228", VA = "0x9228", Slot = "4")]
		protected override void HandleCurrentStateChanged(ChatViewStates fromState, ChatViewStates toState)
		{
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x9229", Offset = "0x9229", VA = "0x9229")]
		public void SetVisitors(List<ChatVisitorData> visitors)
		{
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x922A", Offset = "0x922A", VA = "0x922A")]
		public void AddVisitor(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x922B", Offset = "0x922B", VA = "0x922B")]
		public void RemoveVisitor(ChatVisitorData visitor)
		{
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x922C", Offset = "0x922C", VA = "0x922C")]
		public void ScrollMessagesDown()
		{
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x922D", Offset = "0x922D", VA = "0x922D")]
		public void SetBan(ChatBanData banData)
		{
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x922E", Offset = "0x922E", VA = "0x922E")]
		public void SetFocusOnTextInputField()
		{
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x922F", Offset = "0x922F", VA = "0x922F")]
		public void ShowSmilePanel()
		{
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x9230", Offset = "0x9230", VA = "0x9230")]
		public void CloseSmilePanel()
		{
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x9231", Offset = "0x9231", VA = "0x9231")]
		public ChatView()
		{
		}

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TabBar _roomsTabBar;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _sendMessageButton;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SelectedButton _privateMessagesButton;

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectedButton _smilesButton;

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SelectedButton _roomVisitorsOrContactsButton;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SelectedButton _miniChatViewSwitchButton;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private PatternTextInput _messageTextInput;

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_InputField _roomVisitorsSearchInputField;

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ChatRoomVisitorsListAdapter _visitorsList;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ChatVisitorsSort _visitorsSortControl;

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MessagesListAdapter _messagesList;

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SmilesView _smilesView;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x4C")]
		[Space(50f)]
		[SerializeField]
		private Vector3 _defaultMessagesLisPosition;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector3 _defaultMessagesLisSize;

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Vector3 _complaintsStateMessagesListPosition;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 _complaintsStateMessagesListSize;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private BanStub _banStub;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x80")]
		private ChatViewMediator _mediator;

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		private const int MIN_CHAR_COUNT_FOR_VISITOR_SEARCH = 1;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x88")]
		private IList<ChatVisitorData> _visitors;
	}
}
