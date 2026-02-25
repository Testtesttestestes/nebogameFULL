using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.View.Lists
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public class GameEventsListAdapter : OSA<BaseParamsWithPrefab, GameEventsListItemViewsHolder>
	{
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DE0 RID: 11744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D2")]
		public SimpleDataHelper<GameEventsListView.GameEventsListItemWrapper> Data
		{
			[Token(Token = "0x6002DDF")]
			[Address(RVA = "0x7E5D", Offset = "0x7E5D", VA = "0x7E5D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DE0")]
			[Address(RVA = "0x7E5E", Offset = "0x7E5E", VA = "0x7E5E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x7E5F", Offset = "0x7E5F", VA = "0x7E5F", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x7E60", Offset = "0x7E60", VA = "0x7E60", Slot = "99")]
		protected override GameEventsListItemViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x7E61", Offset = "0x7E61", VA = "0x7E61", Slot = "100")]
		protected override void UpdateViewsHolder(GameEventsListItemViewsHolder newOrRecycled)
		{
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x7E62", Offset = "0x7E62", VA = "0x7E62")]
		public void AddItemsAt(int index, IList<GameEventsListView.GameEventsListItemWrapper> items)
		{
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x7E63", Offset = "0x7E63", VA = "0x7E63")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x7E64", Offset = "0x7E64", VA = "0x7E64")]
		public void SetItems(IList<GameEventsListView.GameEventsListItemWrapper> items)
		{
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x7E65", Offset = "0x7E65", VA = "0x7E65")]
		private void RetrieveDataAndUpdate(int count)
		{
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x7E66", Offset = "0x7E66", VA = "0x7E66")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
			return null;
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE9")]
		[Address(RVA = "0x7E67", Offset = "0x7E67", VA = "0x7E67")]
		private void OnDataRetrieved(GameEventsListView.GameEventsListItemWrapper[] newItems)
		{
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DEA")]
		[Address(RVA = "0x7E68", Offset = "0x7E68", VA = "0x7E68")]
		public GameEventsListAdapter()
		{
		}
	}
}
