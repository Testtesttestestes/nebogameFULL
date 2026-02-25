using System;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Core.Data.Accounts
{
	// Token: 0x020010F2 RID: 4338
	[Token(Token = "0x20010F2")]
	public interface IAccountData
	{
		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06006561 RID: 25953
		[Token(Token = "0x1700148F")]
		AccountInfo AccountInfo { [Token(Token = "0x6006561")] get; }

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06006562 RID: 25954
		[Token(Token = "0x17001490")]
		BackTime BackTime { [Token(Token = "0x6006562")] get; }

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06006563 RID: 25955
		[Token(Token = "0x17001491")]
		bool IsExpired { [Token(Token = "0x6006563")] get; }
	}
}
