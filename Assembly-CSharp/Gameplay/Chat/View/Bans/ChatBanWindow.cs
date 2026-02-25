using System;
using System.Collections.Generic;
using Gameplay.Chat.Control;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Chat.View.Bans
{
	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x2000B03")]
	public class ChatBanWindow : ClosableBaseWindow<ChatBanWindow.ChatBanWindowArgs>
	{
		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D66")]
		public override string WindowId
		{
			[Token(Token = "0x6004412")]
			[Address(RVA = "0x92C5", Offset = "0x92C5", VA = "0x92C5", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x92C6", Offset = "0x92C6", VA = "0x92C6", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x92C7", Offset = "0x92C7", VA = "0x92C7", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x92C8", Offset = "0x92C8", VA = "0x92C8")]
		private void HandleConfirmButtonClickEvent()
		{
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x92C9", Offset = "0x92C9", VA = "0x92C9")]
		private void HandleSelectedEvent(object sender, ChatBanArticleData e)
		{
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x92CA", Offset = "0x92CA", VA = "0x92CA")]
		public ChatBanWindow()
		{
		}

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Chat/ChatBanWindow";

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _descriptionContainer;

		// Token: 0x04002580 RID: 9600
		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04002581 RID: 9601
		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ChatBanListAdapter _list;

		// Token: 0x02000B04 RID: 2820
		[Token(Token = "0x2000B04")]
		public class ChatBanWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004418 RID: 17432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004418")]
			[Address(RVA = "0x92CB", Offset = "0x92CB", VA = "0x92CB")]
			public ChatBanWindowArgs()
			{
			}

			// Token: 0x04002582 RID: 9602
			[Token(Token = "0x4002582")]
			[FieldOffset(Offset = "0x18")]
			public ChatVisitorData Visitor;

			// Token: 0x04002583 RID: 9603
			[Token(Token = "0x4002583")]
			[FieldOffset(Offset = "0x1C")]
			public IList<ChatBanArticleData> BanArtles;

			// Token: 0x04002584 RID: 9604
			[Token(Token = "0x4002584")]
			[FieldOffset(Offset = "0x20")]
			public ChatController ChatController;
		}
	}
}
