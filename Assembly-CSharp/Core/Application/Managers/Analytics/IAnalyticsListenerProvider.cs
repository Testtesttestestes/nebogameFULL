using System;
using Core.Analytics.Listeners;
using Il2CppDummyDll;

namespace Core.Application.Managers.Analytics
{
	// Token: 0x02001277 RID: 4727
	[Token(Token = "0x2001277")]
	public interface IAnalyticsListenerProvider
	{
		// Token: 0x0600702A RID: 28714
		[Token(Token = "0x600702A")]
		T GetAnalyticsListener<T>() where T : AbstractAnalyticsListener, new();
	}
}
