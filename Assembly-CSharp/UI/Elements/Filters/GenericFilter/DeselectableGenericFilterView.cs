using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public class DeselectableGenericFilterView : GenericFilterView
	{
		// Token: 0x140000EF RID: 239
		// (add) Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EF")]
		public event Action DeselectedEvent
		{
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x6083", Offset = "0x6083", VA = "0x6083")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x6084", Offset = "0x6084", VA = "0x6084")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x6085", Offset = "0x6085", VA = "0x6085", Slot = "4")]
		public override void Init(IEnumerable<FilterListElement.FilterData> data)
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x6086", Offset = "0x6086", VA = "0x6086", Slot = "5")]
		protected override void ListElementClickedEventHandler(FilterListElement element)
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x6087", Offset = "0x6087", VA = "0x6087")]
		public DeselectableGenericFilterView()
		{
		}
	}
}
