using System;
using System.Collections.Generic;
using Gameplay.Tournaments.Controller;
using Il2CppDummyDll;
using Protocol.Tournaments;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public class TournamentHistoryWindow : ClosableBaseWindow<TournamentHistoryWindow.TournamentHistoryWindowArgs>
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F6")]
		public override string WindowId
		{
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x6DA9", Offset = "0x6DA9", VA = "0x6DA9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F7")]
		public TextMeshProUGUI TournamentStatus
		{
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x6DAA", Offset = "0x6DAA", VA = "0x6DAA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F8")]
		public Button NextButton
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x6DAB", Offset = "0x6DAB", VA = "0x6DAB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F9")]
		public Button PrevButton
		{
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x6DAC", Offset = "0x6DAC", VA = "0x6DAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FA")]
		public TournamentHistoryInfoBox InfoBox
		{
			[Token(Token = "0x6001C2E")]
			[Address(RVA = "0x6DAD", Offset = "0x6DAD", VA = "0x6DAD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FB")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6001C2F")]
			[Address(RVA = "0x6DAE", Offset = "0x6DAE", VA = "0x6DAE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FC")]
		public Button RulesButton
		{
			[Token(Token = "0x6001C30")]
			[Address(RVA = "0x6DAF", Offset = "0x6DAF", VA = "0x6DAF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FD")]
		public GameObject WinImage
		{
			[Token(Token = "0x6001C31")]
			[Address(RVA = "0x6DB0", Offset = "0x6DB0", VA = "0x6DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FE")]
		public GameObject LoseImage
		{
			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x6DB1", Offset = "0x6DB1", VA = "0x6DB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x6DB2", Offset = "0x6DB2", VA = "0x6DB2")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x6DB3", Offset = "0x6DB3", VA = "0x6DB3", Slot = "22")]
		protected override void OnShow(TournamentHistoryWindow.TournamentHistoryWindowArgs args)
		{
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x6DB4", Offset = "0x6DB4", VA = "0x6DB4")]
		public void Init(IList<Fighter> fightersList, TnmRound round)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x6DB5", Offset = "0x6DB5", VA = "0x6DB5")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x6DB6", Offset = "0x6DB6", VA = "0x6DB6")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x6DB7", Offset = "0x6DB7", VA = "0x6DB7")]
		public TournamentHistoryWindow()
		{
		}

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tournaments/TournamentHistoryWindow";

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TournamentHistoryInfoBox _infoBox;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TournamentBattleInfoListElement _listElementPrefab;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _tournamentStatus;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _winImage;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _loseImage;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x64")]
		private TournamentHistoryViewMediator _mediator;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x020004A9 RID: 1193
		[Token(Token = "0x20004A9")]
		public class TournamentHistoryWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x6DB8", Offset = "0x6DB8", VA = "0x6DB8")]
			public TournamentHistoryWindowArgs()
			{
			}

			// Token: 0x04000F45 RID: 3909
			[Token(Token = "0x4000F45")]
			[FieldOffset(Offset = "0x18")]
			public TournamentsController Controller;
		}
	}
}
