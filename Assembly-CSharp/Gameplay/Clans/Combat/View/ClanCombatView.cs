using System;
using Gameplay.Clans.Combat.Model;
using Gameplay.Clans.Combat.View.Players;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.View;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A94 RID: 2708
	[Token(Token = "0x2000A94")]
	public class ClanCombatView : AbstractTeamCombatView<ClanCombatPlayer>
	{
		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060040F6 RID: 16630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCD")]
		public Button ExitFromViewModeButton
		{
			[Token(Token = "0x60040F6")]
			[Address(RVA = "0x8FAD", Offset = "0x8FAD", VA = "0x8FAD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCE")]
		public Button StartButton
		{
			[Token(Token = "0x60040F7")]
			[Address(RVA = "0x8FAE", Offset = "0x8FAE", VA = "0x8FAE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060040F8 RID: 16632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCF")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x60040F8")]
			[Address(RVA = "0x8FAF", Offset = "0x8FAF", VA = "0x8FAF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CD0")]
		public PlayersList LeftPlayers
		{
			[Token(Token = "0x60040F9")]
			[Address(RVA = "0x8FB0", Offset = "0x8FB0", VA = "0x8FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060040FA RID: 16634 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CD1")]
		public PlayersList RightPlayers
		{
			[Token(Token = "0x60040FA")]
			[Address(RVA = "0x8FB1", Offset = "0x8FB1", VA = "0x8FB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CD2")]
		public ICombatSpellDisplay ElixirDisplay
		{
			[Token(Token = "0x60040FB")]
			[Address(RVA = "0x8FB2", Offset = "0x8FB2", VA = "0x8FB2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FC")]
		[Address(RVA = "0x8FB3", Offset = "0x8FB3", VA = "0x8FB3", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FD")]
		[Address(RVA = "0x8FB4", Offset = "0x8FB4", VA = "0x8FB4")]
		private void Awake()
		{
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0x8FB5", Offset = "0x8FB5", VA = "0x8FB5", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x8FB6", Offset = "0x8FB6", VA = "0x8FB6", Slot = "13")]
		protected override ICombatPLayerView CreatePlayerView(ClanCombatPlayer player)
		{
			return null;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004100")]
		[Address(RVA = "0x8FB7", Offset = "0x8FB7", VA = "0x8FB7", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(Gameplay.Combat.Model.GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004101")]
		[Address(RVA = "0x8FB8", Offset = "0x8FB8", VA = "0x8FB8")]
		private string FormatBacktimeCallback(float value)
		{
			return null;
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004102")]
		[Address(RVA = "0x8FB9", Offset = "0x8FB9", VA = "0x8FB9")]
		private void HandlePlayerListInitialize()
		{
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x8FBA", Offset = "0x8FBA", VA = "0x8FBA", Slot = "9")]
		public override ICombatPLayerView GetPlayer(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x8FBB", Offset = "0x8FBB", VA = "0x8FBB")]
		public CombatSpellButton AddElixir(CombatSpellData spell)
		{
			return null;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x8FBC", Offset = "0x8FBC", VA = "0x8FBC")]
		public PlayersList GetPlayerList(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x8FBD", Offset = "0x8FBD", VA = "0x8FBD")]
		public ClanTitle GetClanTitle(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x8FBE", Offset = "0x8FBE", VA = "0x8FBE")]
		public ICombatPLayerView GetPlayerSideInfo(CombatPlayer player)
		{
			return null;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x8FBF", Offset = "0x8FBF", VA = "0x8FBF", Slot = "14")]
		public override void RemovePlayer(ClanCombatPlayer player)
		{
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x8FC0", Offset = "0x8FC0", VA = "0x8FC0", Slot = "7")]
		public override void ResetSpells()
		{
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x8FC1", Offset = "0x8FC1", VA = "0x8FC1")]
		public ClanCombatView()
		{
		}

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AbstractCombatSpellsDisplay _elixirs;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private PlayersList _leftPlayers;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PlayersList _rightPlayers;

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ClanTitle _leftClanTitle;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClanTitle _rightClanTitle;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ClanCombatPlayerInfo _leftInfo;

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ClanCombatPlayerInfo _rightInfo;

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _startButton;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _exitFromViewModeButton;
	}
}
