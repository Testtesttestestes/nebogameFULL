using System;
using Core.Analytics.Service;
using Il2CppDummyDll;

namespace Core.Analytics
{
	// Token: 0x02001283 RID: 4739
	[Token(Token = "0x2001283")]
	public interface IAnalyticsService : IAnalyticsApi, IDisposable
	{
		// Token: 0x060070AC RID: 28844
		[Token(Token = "0x60070AC")]
		void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider);
	}
}
