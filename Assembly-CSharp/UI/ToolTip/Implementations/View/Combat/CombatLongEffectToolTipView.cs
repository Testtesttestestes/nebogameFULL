using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	public class CombatLongEffectToolTipView : BaseToolTip<EffectData>
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x5D4A", Offset = "0x5D4A", VA = "0x5D4A", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x5D4B", Offset = "0x5D4B", VA = "0x5D4B")]
		public CombatLongEffectToolTipView()
		{
		}

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/CombatLongEffectToolTipView";

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CombatLongEffectToolTipItemView _combatLongEffectItemView;
	}
}
