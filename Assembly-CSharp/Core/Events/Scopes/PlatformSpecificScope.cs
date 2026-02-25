using System;
using System.Collections.Generic;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Events.Scopes
{
	// Token: 0x02001019 RID: 4121
	[Token(Token = "0x2001019")]
	public class PlatformSpecificScope : AbstractEventBusScope
	{
		// Token: 0x06006175 RID: 24949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006175")]
		[Address(RVA = "0xADA0", Offset = "0xADA0", VA = "0xADA0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006176")]
		[Address(RVA = "0xADA1", Offset = "0xADA1", VA = "0xADA1")]
		public PlatformSpecificScope()
		{
		}

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x8")]
		public Action<BaseEventBusEventArgs> GDPRAgreedEvent;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0xC")]
		public Action<PlatformSpecificScope.AppsFlyerEventArgs> OnAppsFlyerConversionDataSuccessEvent;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x10")]
		public Action<PlatformSpecificScope.AppsFlyerEventArgs> OnAppsFlyerConversionDataFailEvent;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x14")]
		public Action<PlatformSpecificScope.AppsFlyerEventArgs> OnAppsFlyerAppOpenAttributionEvent;

		// Token: 0x0200101A RID: 4122
		[Token(Token = "0x200101A")]
		public class AppsFlyerEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x06006177 RID: 24951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006177")]
			[Address(RVA = "0xADA2", Offset = "0xADA2", VA = "0xADA2")]
			public AppsFlyerEventArgs([NotNull] IApp app, [NotNull] IGame game, [NotNull] Dictionary<string, object> afProperties)
			{
			}

			// Token: 0x06006178 RID: 24952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006178")]
			[Address(RVA = "0xADA3", Offset = "0xADA3", VA = "0xADA3")]
			public AppsFlyerEventArgs([NotNull] IApp app, [NotNull] IGame game, [NotNull] string errorText)
			{
			}

			// Token: 0x06006179 RID: 24953 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6006179")]
			[Address(RVA = "0xADA4", Offset = "0xADA4", VA = "0xADA4", Slot = "4")]
			public override Dictionary<string, object> GetEventProperties()
			{
				return null;
			}

			// Token: 0x04003451 RID: 13393
			[Token(Token = "0x4003451")]
			[FieldOffset(Offset = "0x10")]
			[NotNull]
			public readonly Dictionary<string, object> AfProperties;

			// Token: 0x04003452 RID: 13394
			[Token(Token = "0x4003452")]
			[FieldOffset(Offset = "0x14")]
			[CanBeNull]
			private readonly string _errorText;
		}
	}
}
