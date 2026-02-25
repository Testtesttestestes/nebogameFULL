using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Decorators
{
	// Token: 0x020010ED RID: 4333
	[Token(Token = "0x20010ED")]
	public interface IRewardInfo
	{
		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x0600654A RID: 25930
		[Token(Token = "0x17001486")]
		uint RewardId { [Token(Token = "0x600654A")] get; }

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x0600654B RID: 25931
		[Token(Token = "0x17001487")]
		uint SortIndex { [Token(Token = "0x600654B")] get; }

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600654C RID: 25932
		[Token(Token = "0x17001488")]
		IList<long> Params { [Token(Token = "0x600654C")] get; }
	}
}
