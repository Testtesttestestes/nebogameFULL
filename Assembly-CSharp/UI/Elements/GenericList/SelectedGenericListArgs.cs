using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UI.Elements.GenericList
{
	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	public abstract class SelectedGenericListArgs<TElementArgs> : GenericListArgs<TElementArgs> where TElementArgs : GenericListElementArgs
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE8")]
		protected SelectedGenericListArgs()
		{
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE9")]
		protected SelectedGenericListArgs(IList<TElementArgs> list)
		{
		}

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x0")]
		public int selectedIndex;
	}
}
