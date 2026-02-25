using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service.WebGL
{
	// Token: 0x02001286 RID: 4742
	[Token(Token = "0x2001286")]
	public class AmplitudeAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070B3 RID: 28851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0xBADA", Offset = "0xBADA", VA = "0xBADA", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIdProvider)
		{
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B4")]
		[Address(RVA = "0xBADB", Offset = "0xBADB", VA = "0xBADB", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B5")]
		[Address(RVA = "0xBADC", Offset = "0xBADC", VA = "0xBADC", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B6")]
		[Address(RVA = "0xBADD", Offset = "0xBADD", VA = "0xBADD", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B7")]
		[Address(RVA = "0xBADE", Offset = "0xBADE", VA = "0xBADE", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B8")]
		[Address(RVA = "0xBADF", Offset = "0xBADF", VA = "0xBADF", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070B9")]
		[Address(RVA = "0xBAE0", Offset = "0xBAE0", VA = "0xBAE0", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070BA")]
		[Address(RVA = "0xBAE1", Offset = "0xBAE1", VA = "0xBAE1")]
		public AmplitudeAnalyticsService()
		{
		}
	}
}
