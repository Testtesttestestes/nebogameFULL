using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.Elements;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	public class SortCategoryListElement : SelectableListElement<SortCategoryListElement.SortCategoryListElementArgs>
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00004908 File Offset: 0x00002B08
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public SortCategoryListElement.SortOrder Order
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x63FD", Offset = "0x63FD", VA = "0x63FD")]
			[CompilerGenerated]
			get
			{
				return SortCategoryListElement.SortOrder.DEFAULT;
			}
			[Token(Token = "0x6001203")]
			[Address(RVA = "0x63FE", Offset = "0x63FE", VA = "0x63FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x63FF", Offset = "0x63FF", VA = "0x63FF")]
		public void SetOrder(SortCategoryListElement.SortOrder order)
		{
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x6400", Offset = "0x6400", VA = "0x6400")]
		public SortCategoryListElement.SortOrder SetNextSortOrder()
		{
			return SortCategoryListElement.SortOrder.DEFAULT;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x6401", Offset = "0x6401", VA = "0x6401", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x6402", Offset = "0x6402", VA = "0x6402", Slot = "10")]
		protected override void CallElementClickedEvent(SortCategoryListElement.SortCategoryListElementArgs args)
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x6403", Offset = "0x6403", VA = "0x6403")]
		public SortCategoryListElement()
		{
		}

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CommonElements.IconLabel _iconLabel;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _orderIcon;

		// Token: 0x020002FF RID: 767
		[Token(Token = "0x20002FF")]
		public enum SortOrder : byte
		{
			// Token: 0x04000970 RID: 2416
			[Token(Token = "0x4000970")]
			DEFAULT,
			// Token: 0x04000971 RID: 2417
			[Token(Token = "0x4000971")]
			ASCENDING,
			// Token: 0x04000972 RID: 2418
			[Token(Token = "0x4000972")]
			DESCENDING
		}

		// Token: 0x02000300 RID: 768
		[Token(Token = "0x2000300")]
		public class SortCategoryListElementArgs : SelectableListElementArgs<SortCategoryListElement>
		{
			// Token: 0x06001209 RID: 4617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001209")]
			[Address(RVA = "0x6404", Offset = "0x6404", VA = "0x6404")]
			public SortCategoryListElementArgs()
			{
			}

			// Token: 0x04000973 RID: 2419
			[Token(Token = "0x4000973")]
			[FieldOffset(Offset = "0x1C")]
			public string IconAssetId;

			// Token: 0x04000974 RID: 2420
			[Token(Token = "0x4000974")]
			[FieldOffset(Offset = "0x20")]
			public string Title;
		}
	}
}
