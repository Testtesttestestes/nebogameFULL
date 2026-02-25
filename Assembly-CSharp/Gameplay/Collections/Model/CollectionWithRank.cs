using System;
using Il2CppDummyDll;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D6 RID: 2518
	[Token(Token = "0x20009D6")]
	public readonly struct CollectionWithRank
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0x8B0C", Offset = "0x8B0C", VA = "0x8B0C")]
		public CollectionWithRank(uint collectionId, uint rank)
		{
		}

		// Token: 0x0400214A RID: 8522
		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0x0")]
		public readonly uint CollectionId;

		// Token: 0x0400214B RID: 8523
		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0x4")]
		public readonly uint Rank;
	}
}
