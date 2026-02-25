using System;
using Core.Data;
using Gameplay.Aprs.View;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations.View.Parts;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public class UserToolTipView : BaseToolTip<UserData>
	{
		// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x5D21", Offset = "0x5D21", VA = "0x5D21", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x5D22", Offset = "0x5D22", VA = "0x5D22")]
		public UserToolTipView()
		{
		}

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/UserToolTipView";

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _userNick;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatPlayerLevelView _level;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AprViewSmall _aprViewSmall;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CultView _cult;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RatingBackground _headerBackground;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _ratingPointsTableTitle;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TitleIconValueBackground _ratingPontRowPrefab;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform _ratingPointsContainer;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TitleIconValueBackground _clanRow;
	}
}
