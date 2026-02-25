using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Gifts.Events
{
	// Token: 0x02000719 RID: 1817
	[Token(Token = "0x2000719")]
	public class GiftsEvents : AbstractMVCEvents
	{
		// Token: 0x06002B7B RID: 11131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x7C12", Offset = "0x7C12", VA = "0x7C12")]
		public GiftsEvents()
		{
		}

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x14")]
		public Action GiftSentEvent;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x18")]
		public Action GiftsStatusRequestedEvent;
	}
}
