using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001295 RID: 4757
	[Token(Token = "0x2001295")]
	public class OkgAnalyticsService : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x0600710B RID: 28939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710B")]
		[Address(RVA = "0xBB32", Offset = "0xBB32", VA = "0xBB32", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710C")]
		[Address(RVA = "0xBB33", Offset = "0xBB33", VA = "0xBB33", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710D")]
		[Address(RVA = "0xBB34", Offset = "0xBB34", VA = "0xBB34", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x600710E")]
		[Address(RVA = "0xBB35", Offset = "0xBB35", VA = "0xBB35")]
		private bool UserIsRegistered()
		{
			return default(bool);
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600710F")]
		[Address(RVA = "0xBB36", Offset = "0xBB36", VA = "0xBB36", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007110")]
		[Address(RVA = "0xBB37", Offset = "0xBB37", VA = "0xBB37", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007111")]
		[Address(RVA = "0xBB38", Offset = "0xBB38", VA = "0xBB38", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007112")]
		[Address(RVA = "0xBB39", Offset = "0xBB39", VA = "0xBB39", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007113")]
		[Address(RVA = "0xBB3A", Offset = "0xBB3A", VA = "0xBB3A")]
		public OkgAnalyticsService()
		{
		}

		// Token: 0x04003AFF RID: 15103
		[Token(Token = "0x4003AFF")]
		[FieldOffset(Offset = "0x8")]
		private bool _globalTimeIsActual;
	}
}
