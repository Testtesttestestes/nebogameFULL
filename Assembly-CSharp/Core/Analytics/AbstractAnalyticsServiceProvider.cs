using System;
using System.Collections.Generic;
using Core.Application.Managers.Analytics;
using Il2CppDummyDll;

namespace Core.Analytics
{
	// Token: 0x02001281 RID: 4737
	[Token(Token = "0x2001281")]
	public abstract class AbstractAnalyticsServiceProvider : IDisposable
	{
		// Token: 0x060070A4 RID: 28836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A4")]
		[Address(RVA = "0xBAD4", Offset = "0xBAD4", VA = "0xBAD4")]
		protected AbstractAnalyticsServiceProvider(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070A5")]
		protected T GetOrCreateAnalyticsService<T>() where T : IAnalyticsService, new()
		{
			return null;
		}

		// Token: 0x060070A6 RID: 28838
		[Token(Token = "0x60070A6")]
		public abstract void SetupListeners(IAnalyticsListenerProvider listenersProvider);

		// Token: 0x060070A7 RID: 28839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A7")]
		[Address(RVA = "0xBAD5", Offset = "0xBAD5", VA = "0xBAD5", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A8")]
		[Address(RVA = "0xBAD6", Offset = "0xBAD6", VA = "0xBAD6")]
		protected void SetupListenersForDefaultAnalyticsService(IAnalyticsListenerProvider listenersProvider, IAnalyticsService defaultAnalyticsService)
		{
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070A9")]
		[Address(RVA = "0xBAD7", Offset = "0xBAD7", VA = "0xBAD7")]
		protected void SetupListenersForOkgAnalyticsService(IAnalyticsListenerProvider listenersProvider, IAnalyticsService okgAnalyticsService)
		{
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070AA")]
		[Address(RVA = "0xBAD8", Offset = "0xBAD8", VA = "0xBAD8")]
		protected void SetupListenersForAnalyticsEventMediator(IAnalyticsListenerProvider listenersProvider, IAnalyticsService analyticsEventMediator)
		{
		}

		// Token: 0x04003AB4 RID: 15028
		[Token(Token = "0x4003AB4")]
		[FieldOffset(Offset = "0x8")]
		private string _userId;

		// Token: 0x04003AB5 RID: 15029
		[Token(Token = "0x4003AB5")]
		[FieldOffset(Offset = "0xC")]
		private string _serverName;

		// Token: 0x04003AB6 RID: 15030
		[Token(Token = "0x4003AB6")]
		[FieldOffset(Offset = "0x10")]
		private IDeviceIDProvider _deviceIDProvider;

		// Token: 0x04003AB7 RID: 15031
		[Token(Token = "0x4003AB7")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Type, IAnalyticsService> _services;
	}
}
