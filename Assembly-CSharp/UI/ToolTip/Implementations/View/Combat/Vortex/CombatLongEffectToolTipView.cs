using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat.Vortex
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	public class CombatLongEffectToolTipView : BaseToolTip<EffectData[]>
	{
		// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x5D53", Offset = "0x5D53", VA = "0x5D53", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x5D54", Offset = "0x5D54", VA = "0x5D54")]
		public CombatLongEffectToolTipView()
		{
		}

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/VortexCombat/CombatLongEffectToolTipView";

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatLongEffectToolTipItemView _prefab;
	}
}
