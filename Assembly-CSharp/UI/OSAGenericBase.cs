using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public abstract class OSAGenericBase<T, Y> : OSA<BaseParamsWithPrefab, T> where T : AbstractItemViewsHolder where Y : GenericListElementArgs
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		public SimpleDataHelper<Y> Data
		{
			[Token(Token = "0x600088B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600088C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088D")]
		protected override void OnInitialized()
		{
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600088E")]
		protected override T CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x0600088F RID: 2191
		[Token(Token = "0x600088F")]
		protected abstract T CreateViewsHolder();

		// Token: 0x06000890 RID: 2192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000890")]
		protected override void UpdateViewsHolder(T newOrRecycled)
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000891")]
		public void AddItemsAt(int index, IList<Y> items)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000892")]
		public virtual void AddItems(IList<Y> items, bool atEnd)
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000893")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000894")]
		public void RemoveSingle(Predicate<Y> pattern)
		{
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000895")]
		public void RemoveItems(int count, bool atEnd)
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000896")]
		public virtual void SetItems(IList<Y> items)
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000897")]
		protected OSAGenericBase()
		{
		}
	}
}
