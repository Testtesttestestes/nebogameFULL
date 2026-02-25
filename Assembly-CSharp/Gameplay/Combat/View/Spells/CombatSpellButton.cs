using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using UI.ToolTip;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000943 RID: 2371
	[Token(Token = "0x2000943")]
	public class CombatSpellButton : AbstractCombatSpellButton<CombatSpellData>
	{
		// Token: 0x0600381A RID: 14362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600381A")]
		[Address(RVA = "0x87D1", Offset = "0x87D1", VA = "0x87D1", Slot = "18")]
		public override BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600381B")]
		[Address(RVA = "0x87D2", Offset = "0x87D2", VA = "0x87D2")]
		public CombatSpellButton()
		{
		}
	}
}
