using System;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Okg
{
	// Token: 0x0200129E RID: 4766
	[Token(Token = "0x200129E")]
	public interface ILogBuilder
	{
		// Token: 0x0600713F RID: 28991
		[Token(Token = "0x600713F")]
		bool AddLine(OkgAnalyticsData record, out string error);

		// Token: 0x06007140 RID: 28992
		[Token(Token = "0x6007140")]
		void Clear();

		// Token: 0x06007141 RID: 28993
		[Token(Token = "0x6007141")]
		string Extract();
	}
}
