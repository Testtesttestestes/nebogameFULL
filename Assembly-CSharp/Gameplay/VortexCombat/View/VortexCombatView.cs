using System;
using AssetContent;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.View;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View.Player;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexCombat.View
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class VortexCombatView : AbstractTeamCombatView<VortexCombatPlayer>
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000397")]
		public Toggle ShowHideSkillsNumbersButton
		{
			[Token(Token = "0x60015C2")]
			[Address(RVA = "0x6784", Offset = "0x6784", VA = "0x6784")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x6785", Offset = "0x6785", VA = "0x6785", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x6786", Offset = "0x6786", VA = "0x6786", Slot = "13")]
		protected override ICombatPLayerView CreatePlayerView(VortexCombatPlayer player)
		{
			return null;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x6787", Offset = "0x6787", VA = "0x6787", Slot = "9")]
		public override ICombatPLayerView GetPlayer(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x6788", Offset = "0x6788", VA = "0x6788", Slot = "11")]
		public override void ShowGameOver(CombatModel model, GameOverData gameOver, Action<CombatGameOverView> callback)
		{
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x6789", Offset = "0x6789", VA = "0x6789", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x678A", Offset = "0x678A", VA = "0x678A")]
		public VortexCombatView()
		{
		}

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected VortexCombatPlayerView _mySidePlayerPrefab;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected VortexCombatPlayerView _otherSidePlayerPrefab;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform _leftSidePlayers;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected Transform _rightSidePlayers;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle _showHideSkillsNumbersButton;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private CombatPlayerLevelView _level;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CultWhitBackground _cultOnNickView;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private TextMeshProUGUI _opponentSquadNickField;
	}
}
