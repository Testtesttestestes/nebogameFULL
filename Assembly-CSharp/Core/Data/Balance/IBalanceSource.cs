using System;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Data.Balance
{
	// Token: 0x020010E6 RID: 4326
	[Token(Token = "0x20010E6")]
	public interface IBalanceSource
	{
		// Token: 0x14000243 RID: 579
		// (add) Token: 0x06006526 RID: 25894
		// (remove) Token: 0x06006527 RID: 25895
		[Token(Token = "0x14000243")]
		event IBalanceSource.BalanceChangedDelegate BalanceChangedEvent;

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06006528 RID: 25896
		[Token(Token = "0x1700147B")]
		ResourceSet Money { [Token(Token = "0x6006528")] get; }

		// Token: 0x020010E7 RID: 4327
		// (Invoke) Token: 0x0600652A RID: 25898
		[Token(Token = "0x20010E7")]
		public delegate void BalanceChangedDelegate(ResourceSet balance, ResourceSet delta);
	}
}
