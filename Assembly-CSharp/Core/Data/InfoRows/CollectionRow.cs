using System;
using System.Collections.Generic;
using Gameplay.Collections.Model;
using Il2CppDummyDll;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E4 RID: 4324
	[Token(Token = "0x20010E4")]
	public class CollectionRow : CommonRow
	{
		// Token: 0x06006525 RID: 25893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006525")]
		[Address(RVA = "0xB0F5", Offset = "0xB0F5", VA = "0xB0F5")]
		public CollectionRow(IEnumerable<CollectionWithRank> collectionsWithRank, UserData user)
		{
		}

		// Token: 0x04003611 RID: 13841
		[Token(Token = "0x4003611")]
		[FieldOffset(Offset = "0x10")]
		public readonly IEnumerable<CollectionWithRank> CollectionsWithRank;

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0x14")]
		public readonly UserData User;
	}
}
