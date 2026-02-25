using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FBF RID: 4031
	[Token(Token = "0x2000FBF")]
	public class AnalyticsEventMediatorScope : AbstractEventBusScope
	{
		// Token: 0x06006082 RID: 24706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006082")]
		[Address(RVA = "0xACAE", Offset = "0xACAE", VA = "0xACAE", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006083")]
		[Address(RVA = "0xACAF", Offset = "0xACAF", VA = "0xACAF")]
		public AnalyticsEventMediatorScope()
		{
		}

		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		[FieldOffset(Offset = "0x8")]
		public Action<AnalyticsEventMediatorScope.AnalyticsEventMediatorArgs> GameLoadingEvent;

		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		[FieldOffset(Offset = "0xC")]
		public Action<AnalyticsEventMediatorScope.AnalyticsEventMediatorArgs> TutorialStepEvent;

		// Token: 0x02000FC0 RID: 4032
		[Token(Token = "0x2000FC0")]
		public class AnalyticsEventMediatorArgs
		{
			// Token: 0x06006084 RID: 24708 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006084")]
			[Address(RVA = "0xACB0", Offset = "0xACB0", VA = "0xACB0")]
			public AnalyticsEventMediatorArgs()
			{
			}

			// Token: 0x04003371 RID: 13169
			[Token(Token = "0x4003371")]
			[FieldOffset(Offset = "0x8")]
			public string EventTheme;

			// Token: 0x04003372 RID: 13170
			[Token(Token = "0x4003372")]
			[FieldOffset(Offset = "0xC")]
			public IReadOnlyDictionary<string, object> Properties;
		}
	}
}
