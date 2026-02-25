using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Events
{
	// Token: 0x02000902 RID: 2306
	[Token(Token = "0x2000902")]
	public class ShopEvents : AbstractMVCEvents
	{
		// Token: 0x06003625 RID: 13861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x8632", Offset = "0x8632", VA = "0x8632")]
		public ShopEvents(CompetitionEvents common)
		{
		}

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x14")]
		public readonly CompetitionEvents Common;
	}
}
