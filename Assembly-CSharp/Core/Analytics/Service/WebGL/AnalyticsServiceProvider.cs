using System;
using Core.Application.Managers.Analytics;
using Il2CppDummyDll;

namespace Core.Analytics.Service.WebGL
{
	// Token: 0x02001288 RID: 4744
	[Token(Token = "0x2001288")]
	public class AnalyticsServiceProvider : AbstractAnalyticsServiceProvider
	{
		// Token: 0x060070C0 RID: 28864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C0")]
		[Address(RVA = "0xBAE7", Offset = "0xBAE7", VA = "0xBAE7")]
		public AnalyticsServiceProvider(string userId, string serverName, IDeviceIDProvider deviceIDProvider)
		{
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070C1")]
		[Address(RVA = "0xBAE8", Offset = "0xBAE8", VA = "0xBAE8", Slot = "5")]
		public override void SetupListeners(IAnalyticsListenerProvider listenersProvider)
		{
		}
	}
}
