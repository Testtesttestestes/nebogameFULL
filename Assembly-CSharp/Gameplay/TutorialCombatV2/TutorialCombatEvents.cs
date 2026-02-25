using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;

namespace Gameplay.TutorialCombatV2
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	public class TutorialCombatEvents : CombatEvents
	{
		// Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x6B5E", Offset = "0x6B5E", VA = "0x6B5E")]
		public TutorialCombatEvents()
		{
		}

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0x70")]
		public Action CombatComplete;
	}
}
