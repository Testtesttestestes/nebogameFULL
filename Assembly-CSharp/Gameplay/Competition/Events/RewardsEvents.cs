using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Events
{
	// Token: 0x02000901 RID: 2305
	[Token(Token = "0x2000901")]
	public class RewardsEvents : AbstractMVCEvents
	{
		// Token: 0x06003624 RID: 13860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x8631", Offset = "0x8631", VA = "0x8631")]
		public RewardsEvents(CompetitionEvents common)
		{
		}

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x14")]
		public readonly CompetitionEvents Common;
	}
}
