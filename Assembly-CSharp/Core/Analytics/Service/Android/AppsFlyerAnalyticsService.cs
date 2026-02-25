using System;
using System.Collections.Generic;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x0200128C RID: 4748
	[Token(Token = "0x200128C")]
	public class AppsFlyerAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070D5 RID: 28885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D5")]
		[Address(RVA = "0xBAFC", Offset = "0xBAFC", VA = "0xBAFC", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D6")]
		[Address(RVA = "0xBAFD", Offset = "0xBAFD", VA = "0xBAFD", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D7")]
		[Address(RVA = "0xBAFE", Offset = "0xBAFE", VA = "0xBAFE", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D8")]
		[Address(RVA = "0xBAFF", Offset = "0xBAFF", VA = "0xBAFF", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070D9")]
		[Address(RVA = "0xBB00", Offset = "0xBB00", VA = "0xBB00", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070DA")]
		[Address(RVA = "0xBB01", Offset = "0xBB01", VA = "0xBB01", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070DB")]
		[Address(RVA = "0xBB02", Offset = "0xBB02", VA = "0xBB02", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070DC")]
		[Address(RVA = "0xBB03", Offset = "0xBB03", VA = "0xBB03")]
		public AppsFlyerAnalyticsService()
		{
		}

		// Token: 0x04003AE5 RID: 15077
		[Token(Token = "0x4003AE5")]
		[FieldOffset(Offset = "0x8")]
		private readonly IReadOnlyList<BillingProviderId> CompatibleBillingProviders;
	}
}
