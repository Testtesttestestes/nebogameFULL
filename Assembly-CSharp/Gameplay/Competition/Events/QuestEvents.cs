using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Events
{
	// Token: 0x020008FF RID: 2303
	[Token(Token = "0x20008FF")]
	public class QuestEvents : AbstractMVCEvents
	{
		// Token: 0x06003622 RID: 13858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x862F", Offset = "0x862F", VA = "0x862F")]
		public QuestEvents(CompetitionEvents common)
		{
		}

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[FieldOffset(Offset = "0x14")]
		public readonly CompetitionEvents Common;
	}
}
