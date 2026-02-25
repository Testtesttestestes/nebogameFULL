using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Events
{
	// Token: 0x02000900 RID: 2304
	[Token(Token = "0x2000900")]
	public class RatingEvents : AbstractMVCEvents
	{
		// Token: 0x06003623 RID: 13859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x8630", Offset = "0x8630", VA = "0x8630")]
		public RatingEvents(CompetitionEvents common)
		{
		}

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		[FieldOffset(Offset = "0x14")]
		public readonly CompetitionEvents Common;
	}
}
