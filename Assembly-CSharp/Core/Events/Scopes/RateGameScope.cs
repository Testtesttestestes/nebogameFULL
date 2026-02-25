using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001021 RID: 4129
	[Token(Token = "0x2001021")]
	public class RateGameScope : AbstractEventBusScope
	{
		// Token: 0x0600619B RID: 24987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619B")]
		[Address(RVA = "0xADC6", Offset = "0xADC6", VA = "0xADC6", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600619C")]
		[Address(RVA = "0xADC7", Offset = "0xADC7", VA = "0xADC7")]
		public RateGameScope()
		{
		}

		// Token: 0x04003471 RID: 13425
		[Token(Token = "0x4003471")]
		[FieldOffset(Offset = "0x8")]
		public Action<BaseEventBusEventArgs> RateGameCancelEvent;

		// Token: 0x04003472 RID: 13426
		[Token(Token = "0x4003472")]
		[FieldOffset(Offset = "0xC")]
		public Action<BaseEventBusEventArgs> CloseButtonClickedAfterPositiveRateEvent;

		// Token: 0x04003473 RID: 13427
		[Token(Token = "0x4003473")]
		[FieldOffset(Offset = "0x10")]
		public Action<BaseEventBusEventArgs> StoreButtonClickEvent;

		// Token: 0x04003474 RID: 13428
		[Token(Token = "0x4003474")]
		[FieldOffset(Offset = "0x14")]
		public Action<RateGameScope.RateGameEventArgs> RateGameRequestEvent;

		// Token: 0x04003475 RID: 13429
		[Token(Token = "0x4003475")]
		[FieldOffset(Offset = "0x18")]
		public Action<RateGameScope.RateGameEventArgs> RateGameSuccessEvent;

		// Token: 0x02001022 RID: 4130
		[Token(Token = "0x2001022")]
		public class RateGameEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001372 RID: 4978
			// (get) Token: 0x0600619D RID: 24989 RVA: 0x00011F58 File Offset: 0x00010158
			[Token(Token = "0x17001372")]
			public uint Rate
			{
				[Token(Token = "0x600619D")]
				[Address(RVA = "0xADC8", Offset = "0xADC8", VA = "0xADC8")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x0600619E RID: 24990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600619E")]
			[Address(RVA = "0xADC9", Offset = "0xADC9", VA = "0xADC9")]
			public RateGameEventArgs(App app, IGame game, uint rate)
			{
			}
		}
	}
}
