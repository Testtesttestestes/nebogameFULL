using System;
using Il2CppDummyDll;

namespace UI.Filters
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	public class MetaFilterData<TFilter, TSubFilter>
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C87")]
		public MetaFilterData()
		{
		}

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x0")]
		public TFilter Filter;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x0")]
		public TSubFilter[] SubFilters;
	}
}
