using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009E1 RID: 2529
	[Token(Token = "0x20009E1")]
	public interface ICollectionsMaterialsStorage : IDisposable
	{
		// Token: 0x06003C71 RID: 15473
		[Token(Token = "0x6003C71")]
		bool TryGetArtikulCollections(uint artikulId, out List<CollectionWithRank> collectionsWithRank);

		// Token: 0x06003C72 RID: 15474
		[Token(Token = "0x6003C72")]
		bool TryGetMedalCollections(uint medalId, out List<CollectionWithRank> collectionsWithRank);
	}
}
