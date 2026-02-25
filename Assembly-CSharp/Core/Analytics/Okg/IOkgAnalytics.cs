using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Okg
{
	// Token: 0x0200129F RID: 4767
	[Token(Token = "0x200129F")]
	public interface IOkgAnalytics
	{
		// Token: 0x06007142 RID: 28994
		[Token(Token = "0x6007142")]
		void LogEvent(OkgAnalyticsData eventHeader, IReadOnlyDictionary<string, object> data);

		// Token: 0x06007143 RID: 28995
		[Token(Token = "0x6007143")]
		void SetUserId(long userId);

		// Token: 0x06007144 RID: 28996
		[Token(Token = "0x6007144")]
		void SetUserLevel(int userLevel);

		// Token: 0x06007145 RID: 28997
		[Token(Token = "0x6007145")]
		void SetIsTempUserFlag(bool isTempUser);

		// Token: 0x06007146 RID: 28998
		[Token(Token = "0x6007146")]
		bool SetServerTimeOffset(long deltaTimeMs);
	}
}
