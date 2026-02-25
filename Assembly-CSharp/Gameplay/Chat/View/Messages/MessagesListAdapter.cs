using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	public class MessagesListAdapter : OSA<BaseParamsWithPrefab, MessageViewHolder>
	{
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043E1 RID: 17377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D60")]
		public SimpleDataHelper<ChatMessageItem> Data
		{
			[Token(Token = "0x60043E0")]
			[Address(RVA = "0x9293", Offset = "0x9293", VA = "0x9293")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043E1")]
			[Address(RVA = "0x9294", Offset = "0x9294", VA = "0x9294")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001AA RID: 426
		// (add) Token: 0x060043E2 RID: 17378 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043E3 RID: 17379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AA")]
		public event Action<ChatMessageItem> MessageHasBeenViewedEvent
		{
			[Token(Token = "0x60043E2")]
			[Address(RVA = "0x9295", Offset = "0x9295", VA = "0x9295")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043E3")]
			[Address(RVA = "0x9296", Offset = "0x9296", VA = "0x9296")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001AB RID: 427
		// (add) Token: 0x060043E4 RID: 17380 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043E5 RID: 17381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AB")]
		public event Action<ChatMessageItem> MessageDeleteRequestEvent
		{
			[Token(Token = "0x60043E4")]
			[Address(RVA = "0x9297", Offset = "0x9297", VA = "0x9297")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043E5")]
			[Address(RVA = "0x9298", Offset = "0x9298", VA = "0x9298")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001AC RID: 428
		// (add) Token: 0x060043E6 RID: 17382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043E7 RID: 17383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AC")]
		public event Action<ChatVisitorData, ChatMessageItem> ClickOnVisitorEvent
		{
			[Token(Token = "0x60043E6")]
			[Address(RVA = "0x9299", Offset = "0x9299", VA = "0x9299")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043E7")]
			[Address(RVA = "0x929A", Offset = "0x929A", VA = "0x929A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043E8")]
		[Address(RVA = "0x929B", Offset = "0x929B", VA = "0x929B", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043E9")]
		[Address(RVA = "0x929C", Offset = "0x929C", VA = "0x929C", Slot = "99")]
		protected override MessageViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x929D", Offset = "0x929D", VA = "0x929D", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(MessageViewHolder vh, bool isActive)
		{
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x929E", Offset = "0x929E", VA = "0x929E")]
		private void HandleClickOnUserNickEvent(ChatVisitorData visitor, ChatMessageItem messageItem)
		{
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x929F", Offset = "0x929F", VA = "0x929F")]
		private void HandleDeleteMessageEvent(ChatMessageItem messageItem)
		{
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x92A0", Offset = "0x92A0", VA = "0x92A0")]
		private void HandleMessageHasBeenViewedEvent(ChatMessageItem messageItem)
		{
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x92A1", Offset = "0x92A1", VA = "0x92A1", Slot = "100")]
		protected override void UpdateViewsHolder(MessageViewHolder newOrRecycled)
		{
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x92A2", Offset = "0x92A2", VA = "0x92A2", Slot = "112")]
		protected override void OnItemHeightChangedPreTwinPass(MessageViewHolder viewsHolder)
		{
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x92A3", Offset = "0x92A3", VA = "0x92A3", Slot = "109")]
		protected override void RebuildLayoutDueToScrollViewSizeChange()
		{
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F1")]
		[Address(RVA = "0x92A4", Offset = "0x92A4", VA = "0x92A4", Slot = "68")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F2")]
		[Address(RVA = "0x92A5", Offset = "0x92A5", VA = "0x92A5")]
		public void SetItems(IList<ChatMessageItem> items)
		{
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F3")]
		[Address(RVA = "0x92A6", Offset = "0x92A6", VA = "0x92A6")]
		public MessagesListAdapter()
		{
		}
	}
}
