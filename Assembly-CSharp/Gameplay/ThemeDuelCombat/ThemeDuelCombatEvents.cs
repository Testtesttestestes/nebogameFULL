using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.ThemeDuelCombat
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	public class ThemeDuelCombatEvents : Gameplay.Combat.Events.CombatEvents
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x6EF4", Offset = "0x6EF4", VA = "0x6EF4")]
		public ThemeDuelCombatEvents()
		{
		}

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0x70")]
		public Action<ProtoThemeScoreChangedEvt> ThemeScoreChangedEvent;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0x74")]
		public Action<bool> RunNextCombatAbilityChangedEvent;
	}
}
