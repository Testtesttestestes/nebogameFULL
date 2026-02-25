using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts2.Grids
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class BasicGridAdapter2 : GridAdapter<GridParams, MyGridItemViewsHolder>
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public SimpleDataHelper<MyGridItemModel> Data
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x57CB", Offset = "0x57CB", VA = "0x57CB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x57CC", Offset = "0x57CC", VA = "0x57CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x57CD", Offset = "0x57CD", VA = "0x57CD", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x57CE", Offset = "0x57CE", VA = "0x57CE", Slot = "128")]
		protected override void UpdateCellViewsHolder(MyGridItemViewsHolder newOrRecycled)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x57CF", Offset = "0x57CF", VA = "0x57CF")]
		public void AddItemsAt(int index, IList<MyGridItemModel> items)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x57D0", Offset = "0x57D0", VA = "0x57D0")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x57D1", Offset = "0x57D1", VA = "0x57D1")]
		public void SetItems(IList<MyGridItemModel> items)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x57D2", Offset = "0x57D2", VA = "0x57D2")]
		private void RetrieveDataAndUpdate(int count)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x57D3", Offset = "0x57D3", VA = "0x57D3")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
			return null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x57D4", Offset = "0x57D4", VA = "0x57D4")]
		private void OnDataRetrieved(MyGridItemModel[] newItems)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x57D5", Offset = "0x57D5", VA = "0x57D5")]
		public BasicGridAdapter2()
		{
		}
	}
}
