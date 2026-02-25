using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009ED RID: 2541
	[Token(Token = "0x20009ED")]
	public interface ICollectionFilter
	{
		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06003CB0 RID: 15536
		// (set) Token: 0x06003CB1 RID: 15537
		[Token(Token = "0x17000BF3")]
		FilterInfo FilterInfo { [Token(Token = "0x6003CB0")] get; [Token(Token = "0x6003CB1")] set; }

		// Token: 0x06003CB2 RID: 15538
		[Token(Token = "0x6003CB2")]
		bool Filter(CollectionData collectionData);
	}
}
