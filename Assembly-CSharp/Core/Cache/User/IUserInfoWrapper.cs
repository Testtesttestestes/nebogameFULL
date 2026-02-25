using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Cache.User
{
	// Token: 0x02001101 RID: 4353
	[Token(Token = "0x2001101")]
	public interface IUserInfoWrapper
	{
		// Token: 0x060065A6 RID: 26022
		[Token(Token = "0x60065A6")]
		UserData GetData(UserInfo userInfo);

		// Token: 0x060065A7 RID: 26023
		[Token(Token = "0x60065A7")]
		UserData[] GetData(params UserInfo[] userInfos);
	}
}
