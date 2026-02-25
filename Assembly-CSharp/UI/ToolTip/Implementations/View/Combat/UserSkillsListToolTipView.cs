using System;
using Core.Data.Skills;
using Gameplay.Combat.View.Players;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public class UserSkillsListToolTipView : BaseToolTip<SkillData[]>
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x5D4F", Offset = "0x5D4F", VA = "0x5D4F", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x5D50", Offset = "0x5D50", VA = "0x5D50")]
		public UserSkillsListToolTipView()
		{
		}

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CombatSkillItemRenderer _rowPrefab;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _rowsHost;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/UserSkillsListToolTipView";
	}
}
