using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service
{
	// Token: 0x02001285 RID: 4741
	[Token(Token = "0x2001285")]
	public interface IAnalyticsApi
	{
		// Token: 0x060070AE RID: 28846
		[Token(Token = "0x60070AE")]
		void SetUserPropertyOnce(string property, object value);

		// Token: 0x060070AF RID: 28847
		[Token(Token = "0x60070AF")]
		void SetUserProperty(string property, object value);

		// Token: 0x060070B0 RID: 28848
		[Token(Token = "0x60070B0")]
		void AddUserProperty(string property, object value);

		// Token: 0x060070B1 RID: 28849
		[Token(Token = "0x60070B1")]
		void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties);

		// Token: 0x060070B2 RID: 28850
		[Token(Token = "0x60070B2")]
		void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties);
	}
}
