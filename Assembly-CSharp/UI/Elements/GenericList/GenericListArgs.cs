using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UI.Elements.GenericList
{
	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	public abstract class GenericListArgs<TElementArgs>
	{
		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA4")]
		public GenericListArgs()
		{
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA5")]
		public GenericListArgs(IList<TElementArgs> list)
		{
		}

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x0")]
		public IList<TElementArgs> list;
	}
}
