using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	public class FilterWithIconListElement : FilterListElement
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x6092", Offset = "0x6092", VA = "0x6092", Slot = "4")]
		public override void Init(FilterListElement.FilterData data)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x6093", Offset = "0x6093", VA = "0x6093")]
		public FilterWithIconListElement()
		{
		}

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x02000236 RID: 566
		[Token(Token = "0x2000236")]
		public class FilterWithIconData : FilterListElement.FilterData
		{
			// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E01")]
			[Address(RVA = "0x6094", Offset = "0x6094", VA = "0x6094")]
			public FilterWithIconData()
			{
			}

			// Token: 0x040006EA RID: 1770
			[Token(Token = "0x40006EA")]
			[FieldOffset(Offset = "0x10")]
			public string AssetId;
		}
	}
}
