using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Discounts.Events
{
	// Token: 0x020008A4 RID: 2212
	[Token(Token = "0x20008A4")]
	public class DiscountsEvents : AbstractMVCEvents
	{
		// Token: 0x060033FA RID: 13306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x8427", Offset = "0x8427", VA = "0x8427")]
		public DiscountsEvents()
		{
		}

		// Token: 0x04001C49 RID: 7241
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x14")]
		public Action DiscountsRequestedEvent;
	}
}
