using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Cache.User
{
	// Token: 0x02001100 RID: 4352
	[Token(Token = "0x2001100")]
	public interface IUserCache : ICache<ulong, UserData>, IDisposable, IUserInfoWrapper
	{
		// Token: 0x060065A5 RID: 26021
		[Token(Token = "0x60065A5")]
		UserData GetDataKeepRatings(UserInfo userInfo);
	}
}
