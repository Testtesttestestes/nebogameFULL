using System;
using Il2CppDummyDll;

namespace Core.Data.Accounts
{
	// Token: 0x020010F3 RID: 4339
	[Token(Token = "0x20010F3")]
	public interface IAccountRepository
	{
		// Token: 0x06006564 RID: 25956
		[Token(Token = "0x6006564")]
		bool TryGetAccount(uint id, out IAccountData account);
	}
}
