using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;
using TMPro;
using UI.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x2000AFC")]
	public class MessageItemRenderer : MonoBehaviour
	{
		// Token: 0x140001A7 RID: 423
		// (add) Token: 0x060043D0 RID: 17360 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D1 RID: 17361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A7")]
		public event Action<ChatMessageItem> MessageHasBeenViewedEvent
		{
			[Token(Token = "0x60043D0")]
			[Address(RVA = "0x9283", Offset = "0x9283", VA = "0x9283")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043D1")]
			[Address(RVA = "0x9284", Offset = "0x9284", VA = "0x9284")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A8 RID: 424
		// (add) Token: 0x060043D2 RID: 17362 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D3 RID: 17363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A8")]
		public event Action<ChatMessageItem> DeleteMessageEvent
		{
			[Token(Token = "0x60043D2")]
			[Address(RVA = "0x9285", Offset = "0x9285", VA = "0x9285")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043D3")]
			[Address(RVA = "0x9286", Offset = "0x9286", VA = "0x9286")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001A9 RID: 425
		// (add) Token: 0x060043D4 RID: 17364 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043D5 RID: 17365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A9")]
		public event Action<ChatVisitorData, ChatMessageItem> ClickOnUserNickEvent
		{
			[Token(Token = "0x60043D4")]
			[Address(RVA = "0x9287", Offset = "0x9287", VA = "0x9287")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043D5")]
			[Address(RVA = "0x9288", Offset = "0x9288", VA = "0x9288")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060043D6 RID: 17366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D5E")]
		public ContentSizeFitter ContentSizeFitter
		{
			[Token(Token = "0x60043D6")]
			[Address(RVA = "0x9289", Offset = "0x9289", VA = "0x9289")]
			get
			{
				return null;
			}
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x928A", Offset = "0x928A", VA = "0x928A")]
		private void OnDestroy()
		{
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x928B", Offset = "0x928B", VA = "0x928B")]
		private void Start()
		{
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5F")]
		public ChatMessageItem Data
		{
			[Token(Token = "0x60043D9")]
			[Address(RVA = "0x928C", Offset = "0x928C", VA = "0x928C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043DA")]
			[Address(RVA = "0x928D", Offset = "0x928D", VA = "0x928D")]
			set
			{
			}
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043DB")]
		[Address(RVA = "0x928E", Offset = "0x928E", VA = "0x928E")]
		public ChatUserMessageData GetUserMessage()
		{
			return null;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x928F", Offset = "0x928F", VA = "0x928F")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x9290", Offset = "0x9290", VA = "0x9290")]
		private void HandleDeleteButtonClickEvent()
		{
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x9291", Offset = "0x9291", VA = "0x9291")]
		private void HandleLinkClickEvent(object sender, TMP_LinkInfo e)
		{
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x9292", Offset = "0x9292", VA = "0x9292")]
		public MessageItemRenderer()
		{
		}

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _timestampTextField;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ContentSizeFitter _contentSizeFitter;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextLinkHandler _textFieldLinkHandler;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[FieldOffset(Offset = "0x30")]
		private ChatMessageItem _data;
	}
}
