using System;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using UI.ToolTip;

namespace Gameplay.BossCombat.View
{
	// Token: 0x02000B3A RID: 2874
	[Token(Token = "0x2000B3A")]
	public class BossCombatSpellButton : CombatSpellButton
	{
		// Token: 0x060045C7 RID: 17863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x9469", Offset = "0x9469", VA = "0x9469", Slot = "18")]
		public override BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x946A", Offset = "0x946A", VA = "0x946A")]
		public BossCombatSpellButton()
		{
		}
	}
}
