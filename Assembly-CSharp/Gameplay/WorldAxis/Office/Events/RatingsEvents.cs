using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.WorldAxis.Office.Events
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public class RatingsEvents : AbstractMVCEvents
	{
		// Token: 0x06001133 RID: 4403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x6330", Offset = "0x6330", VA = "0x6330")]
		public RatingsEvents()
		{
		}

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0x14")]
		public Action ClanRatingsRequestedEvent;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x18")]
		public Action UserRatingsRequestedEvent;
	}
}
