using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x0200128F RID: 4751
	[Token(Token = "0x200128F")]
	public class AuthAnalyticsListenerProcessor
	{
		// Token: 0x060070E6 RID: 28902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070E6")]
		[Address(RVA = "0xBB0D", Offset = "0xBB0D", VA = "0xBB0D")]
		public void Process(Dictionary<string, Dictionary<string, object>> aggregator, OkgAnalyticsData dataTemplate, string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x60070E7")]
		[Address(RVA = "0xBB0E", Offset = "0xBB0E", VA = "0xBB0E")]
		private bool UserIsRegistered()
		{
			return default(bool);
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070E8")]
		[Address(RVA = "0xBB0F", Offset = "0xBB0F", VA = "0xBB0F")]
		public AuthAnalyticsListenerProcessor()
		{
		}
	}
}
