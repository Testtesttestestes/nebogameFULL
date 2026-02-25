using System;
using Gameplay.Aprs.View;
using Gameplay.Clans.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations.View.Parts;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat.Clan
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public class ClanCombatPlayerToolTip : BaseToolTip<ClanCombatPlayer>
	{
		// Token: 0x060009F5 RID: 2549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x5D55", Offset = "0x5D55", VA = "0x5D55", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x5D56", Offset = "0x5D56", VA = "0x5D56")]
		public ClanCombatPlayerToolTip()
		{
		}

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanCombat/ClanPlayerToolTipView";

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _userNick;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatPlayerLevelView _level;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AprViewSmall _aprViewSmall;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CultView _cult;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RatingBackground _headerBackground;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _skillsTableTitle;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CombatSkillItemRenderer _rowPrefab;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform _rowsHost;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _legendaryUserStub;
	}
}
