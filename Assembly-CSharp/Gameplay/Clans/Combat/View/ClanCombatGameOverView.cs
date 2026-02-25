using System;
using Animations;
using AssetContent;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A91 RID: 2705
	[Token(Token = "0x2000A91")]
	public class ClanCombatGameOverView : CombatGameOverView
	{
		// Token: 0x060040D4 RID: 16596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x8F8B", Offset = "0x8F8B", VA = "0x8F8B", Slot = "5")]
		public override CombatGameOverView Show(CombatGameOverView.CombatGameOverViewArgs args)
		{
			return null;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040D5")]
		[Address(RVA = "0x8F8C", Offset = "0x8F8C", VA = "0x8F8C", Slot = "6")]
		protected override InIdleOutSpineAnimation CreateResultAnimation(GameOverData gameOverData, Transform parent)
		{
			return null;
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x8F8D", Offset = "0x8F8D", VA = "0x8F8D")]
		public ClanCombatGameOverView()
		{
		}

		// Token: 0x040023F6 RID: 9206
		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private InIdleOutSpineAnimation _tieAnimation;

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameAssetViewRawImage _myAvatar;

		// Token: 0x040023F8 RID: 9208
		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameAssetViewRawImage _enemyAvatar;

		// Token: 0x040023F9 RID: 9209
		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClanCombatGameOverView.TopBar _leftTopBars;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ClanCombatGameOverView.TopBar _rightTopBars;

		// Token: 0x02000A92 RID: 2706
		[Token(Token = "0x2000A92")]
		[Serializable]
		public class TopBar
		{
			// Token: 0x060040D7 RID: 16599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040D7")]
			[Address(RVA = "0x8F8E", Offset = "0x8F8E", VA = "0x8F8E")]
			public TopBar()
			{
			}

			// Token: 0x040023FB RID: 9211
			[Token(Token = "0x40023FB")]
			[FieldOffset(Offset = "0x8")]
			public TextMeshProUGUI NickField;

			// Token: 0x040023FC RID: 9212
			[Token(Token = "0x40023FC")]
			[FieldOffset(Offset = "0xC")]
			public CombatPlayerLevelView Level;

			// Token: 0x040023FD RID: 9213
			[Token(Token = "0x40023FD")]
			[FieldOffset(Offset = "0x10")]
			public CultWhitBackground СultOnNickView;
		}
	}
}
