using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Events
{
	// Token: 0x02000C5F RID: 3167
	[Token(Token = "0x2000C5F")]
	public class PaymentBonusEvents : AbstractMVCEvents
	{
		// Token: 0x06004D54 RID: 19796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x9B8D", Offset = "0x9B8D", VA = "0x9B8D")]
		public PaymentBonusEvents()
		{
		}

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x14")]
		public Action PaymentBonusChangedEvent;
	}
}
