using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001289 RID: 4745
	[Token(Token = "0x2001289")]
	public class AnalyticsEventMediator : IAnalyticsService, IAnalyticsApi, IDisposable
	{
		// Token: 0x060070C3 RID: 28867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070C3")]
		[Address(RVA = "0xBAEA", Offset = "0xBAEA", VA = "0xBAEA")]
		public static OkgAnalyticsData GetOkgAnalyticsDataTemplate()
		{
			return null;
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C4")]
		[Address(RVA = "0xBAEB", Offset = "0xBAEB", VA = "0xBAEB", Slot = "5")]
		public void SetUserPropertyOnce(string property, object value)
		{
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C5")]
		[Address(RVA = "0xBAEC", Offset = "0xBAEC", VA = "0xBAEC", Slot = "6")]
		public void SetUserProperty(string property, object value)
		{
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x60070C6")]
		[Address(RVA = "0xBAED", Offset = "0xBAED", VA = "0xBAED")]
		private bool UserIsRegistered()
		{
			return default(bool);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C7")]
		[Address(RVA = "0xBAEE", Offset = "0xBAEE", VA = "0xBAEE", Slot = "7")]
		public void AddUserProperty(string property, object value)
		{
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C8")]
		[Address(RVA = "0xBAEF", Offset = "0xBAEF", VA = "0xBAEF", Slot = "8")]
		public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
		{
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C9")]
		[Address(RVA = "0xBAF0", Offset = "0xBAF0", VA = "0xBAF0")]
		private void DoLogEvent(string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CA")]
		[Address(RVA = "0xBAF1", Offset = "0xBAF1", VA = "0xBAF1", Slot = "9")]
		public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
		{
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0xBAF2", Offset = "0xBAF2", VA = "0xBAF2", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CC")]
		[Address(RVA = "0xBAF3", Offset = "0xBAF3", VA = "0xBAF3", Slot = "4")]
		public void Init(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x00014790 File Offset: 0x00012990
		[Token(Token = "0x60070CD")]
		[Address(RVA = "0xBAF4", Offset = "0xBAF4", VA = "0xBAF4")]
		private bool TryAggregateEvent(string eventTheme, string eventName, IReadOnlyDictionary<string, object> properties)
		{
			return default(bool);
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070CE")]
		[Address(RVA = "0xBAF5", Offset = "0xBAF5", VA = "0xBAF5")]
		public AnalyticsEventMediator()
		{
		}

		// Token: 0x04003ADC RID: 15068
		[Token(Token = "0x4003ADC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly OkgAnalyticsData DataTemplate;

		// Token: 0x04003ADD RID: 15069
		[Token(Token = "0x4003ADD")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, Dictionary<string, object>> _aggregator;

		// Token: 0x04003ADE RID: 15070
		[Token(Token = "0x4003ADE")]
		[FieldOffset(Offset = "0xC")]
		private readonly AppAnalyticsListenerProcessor _appAnalyticsListenerProcessor;

		// Token: 0x04003ADF RID: 15071
		[Token(Token = "0x4003ADF")]
		[FieldOffset(Offset = "0x10")]
		private readonly AuthAnalyticsListenerProcessor _authAnalyticsListenerProcessor;

		// Token: 0x04003AE0 RID: 15072
		[Token(Token = "0x4003AE0")]
		[FieldOffset(Offset = "0x14")]
		private readonly TutorialAnalyticsListenerProcessor _tutorialAnalyticsListenerProcessor;

		// Token: 0x04003AE1 RID: 15073
		[Token(Token = "0x4003AE1")]
		[FieldOffset(Offset = "0x18")]
		private bool _isTempUserInitialized;
	}
}
