using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	public class MarketLotDataOSAView : OSA<BaseParamsWithPrefab, MarketLotViewsHolder>
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071B")]
		public SimpleDataHelper<MarketLotListElement.MarketLotListElementArgs> Data
		{
			[Token(Token = "0x60025D6")]
			[Address(RVA = "0x7714", Offset = "0x7714", VA = "0x7714")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025D7")]
			[Address(RVA = "0x7715", Offset = "0x7715", VA = "0x7715")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x7716", Offset = "0x7716", VA = "0x7716", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x7717", Offset = "0x7717", VA = "0x7717", Slot = "99")]
		protected override MarketLotViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x7718", Offset = "0x7718", VA = "0x7718", Slot = "100")]
		protected override void UpdateViewsHolder(MarketLotViewsHolder newOrRecycled)
		{
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x7719", Offset = "0x7719", VA = "0x7719")]
		public void AddItemsAt(int index, IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x771A", Offset = "0x771A", VA = "0x771A")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x771B", Offset = "0x771B", VA = "0x771B")]
		public void SetItems(IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x771C", Offset = "0x771C", VA = "0x771C")]
		private void RetrieveDataAndUpdate(int count)
		{
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x771D", Offset = "0x771D", VA = "0x771D")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
			return null;
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x771E", Offset = "0x771E", VA = "0x771E")]
		private void OnDataRetrieved(MarketLotListElement.MarketLotListElementArgs[] newItems)
		{
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x771F", Offset = "0x771F", VA = "0x771F")]
		public MarketLotDataOSAView()
		{
		}

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0xA4")]
		private Mask _viewportMask;
	}
}
