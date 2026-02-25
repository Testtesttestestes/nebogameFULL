using System;
using Gameplay.WorldAxis.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.WorldAxis.ColossusInfo.Events
{
	// Token: 0x0200032C RID: 812
	[Token(Token = "0x200032C")]
	public class ColossusInfoEvents : AbstractMVCEvents
	{
		// Token: 0x060012A6 RID: 4774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x64A0", Offset = "0x64A0", VA = "0x64A0")]
		public ColossusInfoEvents(WorldAxisEvents worldAxisEvents)
		{
		}

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x14")]
		public readonly WorldAxisEvents WorldAxisEvents;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x18")]
		public Action ColossusRatingRequestedEvent;
	}
}
