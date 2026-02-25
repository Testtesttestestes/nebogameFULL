using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Chat.View.Bans
{
	// Token: 0x02000B01 RID: 2817
	[Token(Token = "0x2000B01")]
	public class ChatBanListAdapter : OSA<BaseParamsWithPrefab, ChatBanListAdapter.ChatBanViewHolder>
	{
		// Token: 0x140001AE RID: 430
		// (add) Token: 0x06004402 RID: 17410 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004403 RID: 17411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AE")]
		public event EventHandler<ChatBanArticleData> SelectedEvent
		{
			[Token(Token = "0x6004402")]
			[Address(RVA = "0x92B5", Offset = "0x92B5", VA = "0x92B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004403")]
			[Address(RVA = "0x92B6", Offset = "0x92B6", VA = "0x92B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004405 RID: 17413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D63")]
		public SimpleDataHelper<ChatBanArticleData> Data
		{
			[Token(Token = "0x6004404")]
			[Address(RVA = "0x92B7", Offset = "0x92B7", VA = "0x92B7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004405")]
			[Address(RVA = "0x92B8", Offset = "0x92B8", VA = "0x92B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004407 RID: 17415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D64")]
		public ChatBanArticleData SelectedData
		{
			[Token(Token = "0x6004406")]
			[Address(RVA = "0x92B9", Offset = "0x92B9", VA = "0x92B9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004407")]
			[Address(RVA = "0x92BA", Offset = "0x92BA", VA = "0x92BA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x92BB", Offset = "0x92BB", VA = "0x92BB", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004409")]
		[Address(RVA = "0x92BC", Offset = "0x92BC", VA = "0x92BC", Slot = "99")]
		protected override ChatBanListAdapter.ChatBanViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440A")]
		[Address(RVA = "0x92BD", Offset = "0x92BD", VA = "0x92BD", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(ChatBanListAdapter.ChatBanViewHolder vh, bool isActive)
		{
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x92BE", Offset = "0x92BE", VA = "0x92BE", Slot = "100")]
		protected override void UpdateViewsHolder(ChatBanListAdapter.ChatBanViewHolder newOrRecycled)
		{
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x92BF", Offset = "0x92BF", VA = "0x92BF")]
		private void HandleClickEventEvent(object sender, ChatBanArticleData e)
		{
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440D")]
		[Address(RVA = "0x92C0", Offset = "0x92C0", VA = "0x92C0")]
		public void SetItems(IList<ChatBanArticleData> items)
		{
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x92C1", Offset = "0x92C1", VA = "0x92C1")]
		public ChatBanListAdapter()
		{
		}

		// Token: 0x02000B02 RID: 2818
		[Token(Token = "0x2000B02")]
		public class ChatBanViewHolder : BaseItemViewsHolder
		{
			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x0600440F RID: 17423 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000D65")]
			public ChatBanItemRenderer ItemRenderer
			{
				[Token(Token = "0x600440F")]
				[Address(RVA = "0x92C2", Offset = "0x92C2", VA = "0x92C2")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004410 RID: 17424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004410")]
			[Address(RVA = "0x92C3", Offset = "0x92C3", VA = "0x92C3", Slot = "7")]
			public override void CollectViews()
			{
			}

			// Token: 0x06004411 RID: 17425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004411")]
			[Address(RVA = "0x92C4", Offset = "0x92C4", VA = "0x92C4")]
			public ChatBanViewHolder()
			{
			}

			// Token: 0x0400257C RID: 9596
			[Token(Token = "0x400257C")]
			[FieldOffset(Offset = "0x14")]
			private ChatBanItemRenderer _itemRenderer;
		}
	}
}
