using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI.Elements.Buildings
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	public class SpellListArgs : SelectedGenericListArgs<SpellItemArgs>
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x60E3", Offset = "0x60E3", VA = "0x60E3")]
		public SpellListArgs()
		{
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x60E4", Offset = "0x60E4", VA = "0x60E4")]
		public SpellListArgs(List<SpellItemArgs> list)
		{
		}
	}
}
