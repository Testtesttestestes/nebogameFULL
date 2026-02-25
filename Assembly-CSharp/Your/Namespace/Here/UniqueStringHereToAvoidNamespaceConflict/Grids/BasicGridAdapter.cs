using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts.Grids
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public class BasicGridAdapter : GridAdapter<GridParams, MyGridItemViewsHolder>
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public SimpleDataHelper<MyGridItemModel> Data
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x57EF", Offset = "0x57EF", VA = "0x57EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x57F0", Offset = "0x57F0", VA = "0x57F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x57F1", Offset = "0x57F1", VA = "0x57F1", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x57F2", Offset = "0x57F2", VA = "0x57F2", Slot = "128")]
		protected override void UpdateCellViewsHolder(MyGridItemViewsHolder newOrRecycled)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x57F3", Offset = "0x57F3", VA = "0x57F3")]
		public void AddItemsAt(int index, IList<MyGridItemModel> items)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x57F4", Offset = "0x57F4", VA = "0x57F4")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x57F5", Offset = "0x57F5", VA = "0x57F5")]
		public void SetItems(IList<MyGridItemModel> items)
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x57F6", Offset = "0x57F6", VA = "0x57F6")]
		private void RetrieveDataAndUpdate(int count)
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x57F7", Offset = "0x57F7", VA = "0x57F7")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
			return null;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x57F8", Offset = "0x57F8", VA = "0x57F8")]
		private void OnDataRetrieved(MyGridItemModel[] newItems)
		{
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x57F9", Offset = "0x57F9", VA = "0x57F9")]
		public BasicGridAdapter()
		{
		}
	}
}
