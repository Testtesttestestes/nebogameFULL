using System;
using Gameplay.BossCombat.Model;
using Il2CppDummyDll;
using UI.ToolTip.Implementations.View.Parts.Combat;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public class BossCombatSpellToolTipView : AbstractCombatSpellToolTipView<BossCombatSpellData>
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x5D3F", Offset = "0x5D3F", VA = "0x5D3F", Slot = "11")]
		protected override void HandleModifiers()
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x5D40", Offset = "0x5D40", VA = "0x5D40")]
		public BossCombatSpellToolTipView()
		{
		}

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/BossCombatSpellToolTipView";

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _mercenariesContainerRoot;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _mercenariesContainer;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MercenarieRowView _mercenariesPrefab;
	}
}
