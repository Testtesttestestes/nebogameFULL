using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model;
using Gameplay.Chat.View.Messages;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AE8 RID: 2792
	[Token(Token = "0x2000AE8")]
	public class ChatMiniView : MonoBehaviourWithStates<MiniChatViewStates>, IChatView, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06004345 RID: 17221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D41")]
		public ChatMiniMessagesCarousel MessagesСarousel
		{
			[Token(Token = "0x6004345")]
			[Address(RVA = "0x91F9", Offset = "0x91F9", VA = "0x91F9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D42")]
		public CounterAutoHide NotViewedMessages
		{
			[Token(Token = "0x6004346")]
			[Address(RVA = "0x91FA", Offset = "0x91FA", VA = "0x91FA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D43")]
		public TextMeshProUGUI CurrentRoomTitle
		{
			[Token(Token = "0x6004347")]
			[Address(RVA = "0x91FB", Offset = "0x91FB", VA = "0x91FB")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001A2 RID: 418
		// (add) Token: 0x06004348 RID: 17224 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004349 RID: 17225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A2")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6004348")]
			[Address(RVA = "0x91FC", Offset = "0x91FC", VA = "0x91FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004349")]
			[Address(RVA = "0x91FD", Offset = "0x91FD", VA = "0x91FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x91FE", Offset = "0x91FE", VA = "0x91FE")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434B")]
		[Address(RVA = "0x91FF", Offset = "0x91FF", VA = "0x91FF")]
		private void Awake()
		{
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434C")]
		[Address(RVA = "0x9200", Offset = "0x9200", VA = "0x9200", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600434D")]
		[Address(RVA = "0x9201", Offset = "0x9201", VA = "0x9201")]
		public ChatMiniView()
		{
		}

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _notViewedMessages;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _currentRoomTitle;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x4002516")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _notAvailiableReasonDescription;

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x4002517")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ChatMiniMessagesCarousel _messagesСarousel;

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[FieldOffset(Offset = "0x30")]
		private ChatMiniViewMediator _mediator;
	}
}
