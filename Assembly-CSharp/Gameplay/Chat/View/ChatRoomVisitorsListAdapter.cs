using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AE9 RID: 2793
	[Token(Token = "0x2000AE9")]
	public class ChatRoomVisitorsListAdapter : OSA<BaseParamsWithPrefab, ChatVisitorViewsHolder>
	{
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D44")]
		public SimpleDataHelper<ChatVisitorData> Data
		{
			[Token(Token = "0x600434E")]
			[Address(RVA = "0x9202", Offset = "0x9202", VA = "0x9202")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600434F")]
			[Address(RVA = "0x9203", Offset = "0x9203", VA = "0x9203")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001A3 RID: 419
		// (add) Token: 0x06004350 RID: 17232 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004351 RID: 17233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001A3")]
		public event EventHandler<ChatVisitorData> ItemClickedEvent
		{
			[Token(Token = "0x6004350")]
			[Address(RVA = "0x9204", Offset = "0x9204", VA = "0x9204")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004351")]
			[Address(RVA = "0x9205", Offset = "0x9205", VA = "0x9205")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004352")]
		[Address(RVA = "0x9206", Offset = "0x9206", VA = "0x9206", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004353")]
		[Address(RVA = "0x9207", Offset = "0x9207", VA = "0x9207", Slot = "99")]
		protected override ChatVisitorViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004354")]
		[Address(RVA = "0x9208", Offset = "0x9208", VA = "0x9208", Slot = "100")]
		protected override void UpdateViewsHolder(ChatVisitorViewsHolder newOrRecycled)
		{
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004355")]
		[Address(RVA = "0x9209", Offset = "0x9209", VA = "0x9209", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(ChatVisitorViewsHolder vh, bool isActive)
		{
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004356")]
		[Address(RVA = "0x920A", Offset = "0x920A", VA = "0x920A")]
		private void HandleItemRendererClickEvent(object sender, ChatVisitorData visitor)
		{
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004357")]
		[Address(RVA = "0x920B", Offset = "0x920B", VA = "0x920B")]
		public void AddItemsAt(int index, IList<ChatVisitorData> items)
		{
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004358")]
		[Address(RVA = "0x920C", Offset = "0x920C", VA = "0x920C")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004359")]
		[Address(RVA = "0x920D", Offset = "0x920D", VA = "0x920D")]
		public void SetItems(IList<ChatVisitorData> items)
		{
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435A")]
		[Address(RVA = "0x920E", Offset = "0x920E", VA = "0x920E")]
		public ChatRoomVisitorsListAdapter()
		{
		}
	}
}
