using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Collections.Model.Factories
{
	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20009E4")]
	public interface ICollectionDataFactory : IDisposable
	{
		// Token: 0x06003C7B RID: 15483
		[Token(Token = "0x6003C7B")]
		CollectionData Create(CollectionsDic collectionsDict);
	}
}
