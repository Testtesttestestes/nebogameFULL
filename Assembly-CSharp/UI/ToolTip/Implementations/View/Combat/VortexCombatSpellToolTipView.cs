using System;
using Gameplay.Combat.Model;
using Gameplay.VortexCombat.View.Spells;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public class VortexCombatSpellToolTipView : AbstractCombatSpellToolTipView<CombatSpellData>
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x5D51", Offset = "0x5D51", VA = "0x5D51", Slot = "10")]
		protected override void HandlePriceOfUse()
		{
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x5D52", Offset = "0x5D52", VA = "0x5D52")]
		public VortexCombatSpellToolTipView()
		{
		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/VortexCombatSpellToolTipView";

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected PriceItemRenderer _manaBoostPriceOfUsage;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VortexCombatSpellButton.Config[] _configs;
	}
}
