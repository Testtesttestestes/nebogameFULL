using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001293 RID: 4755
	[Token(Token = "0x2001293")]
	public class MyTrackerAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070FB RID: 28923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FB")]
		[Address(RVA = "0xBB22", Offset = "0xBB22", VA = "0xBB22", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FC")]
		[Address(RVA = "0xBB23", Offset = "0xBB23", VA = "0xBB23", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FD")]
		[Address(RVA = "0xBB24", Offset = "0xBB24", VA = "0xBB24", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FE")]
		[Address(RVA = "0xBB25", Offset = "0xBB25", VA = "0xBB25", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070FF")]
		[Address(RVA = "0xBB26", Offset = "0xBB26", VA = "0xBB26", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007100")]
		[Address(RVA = "0xBB27", Offset = "0xBB27", VA = "0xBB27", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007101")]
		[Address(RVA = "0xBB28", Offset = "0xBB28", VA = "0xBB28", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007102")]
		[Address(RVA = "0xBB29", Offset = "0xBB29", VA = "0xBB29")]
		public MyTrackerAnalyticsService()
		{
		}
	}
}
