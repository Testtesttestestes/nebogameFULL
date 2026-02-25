using System;
using Gameplay.BlitzTournament.Controller;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using TMPro;
using UI;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC7 RID: 3015
	[Token(Token = "0x2000BC7")]
	public class BlitzTournamentProgressWindow : ClosableBaseWindow<BlitzTournamentProgressWindow.BlitzTournamentProgressWindowArgs>
	{
		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEC")]
		public override string WindowId
		{
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x984D", Offset = "0x984D", VA = "0x984D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EED")]
		public BacktimeViewUGUI Timer
		{
			[Token(Token = "0x60049E4")]
			[Address(RVA = "0x984E", Offset = "0x984E", VA = "0x984E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060049E5 RID: 18917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEE")]
		public TextMeshProUGUI TournamentStatus
		{
			[Token(Token = "0x60049E5")]
			[Address(RVA = "0x984F", Offset = "0x984F", VA = "0x984F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEF")]
		public TextMeshProUGUI RoundStatus
		{
			[Token(Token = "0x60049E6")]
			[Address(RVA = "0x9850", Offset = "0x9850", VA = "0x9850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF0")]
		public BlitzTournamentBracketInfoBox InfoBox
		{
			[Token(Token = "0x60049E7")]
			[Address(RVA = "0x9851", Offset = "0x9851", VA = "0x9851")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF1")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x60049E8")]
			[Address(RVA = "0x9852", Offset = "0x9852", VA = "0x9852")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF2")]
		public Button RulesButton
		{
			[Token(Token = "0x60049E9")]
			[Address(RVA = "0x9853", Offset = "0x9853", VA = "0x9853")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EA")]
		[Address(RVA = "0x9854", Offset = "0x9854", VA = "0x9854")]
		private void OnDestroy()
		{
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EB")]
		[Address(RVA = "0x9855", Offset = "0x9855", VA = "0x9855", Slot = "22")]
		protected override void OnShow(BlitzTournamentProgressWindow.BlitzTournamentProgressWindowArgs args)
		{
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x9856", Offset = "0x9856", VA = "0x9856")]
		public BattleInfoListElement[] Init(ProtoGetTournamentInfoAns.Types.TournamentInfo tournamentInfo)
		{
			return null;
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x9857", Offset = "0x9857", VA = "0x9857")]
		public void ShowLosePage()
		{
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EE")]
		[Address(RVA = "0x9858", Offset = "0x9858", VA = "0x9858")]
		public void ShowWinPage()
		{
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EF")]
		[Address(RVA = "0x9859", Offset = "0x9859", VA = "0x9859")]
		private void SetupMVC()
		{
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x985A", Offset = "0x985A", VA = "0x985A")]
		private void DestroyMVC()
		{
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x985B", Offset = "0x985B", VA = "0x985B")]
		public BlitzTournamentProgressWindow()
		{
		}

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/BlitzTournament/BlitzTournamentProgressWindow";

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BattleInfoListElement _listElementPrefab;

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BlitzTournamentBracketInfoBox _infoBox;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _generalPage;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameObject _endPage;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x54")]
		[Header("General page")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _tournamentStatus;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _roundStatus;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[FieldOffset(Offset = "0x64")]
		[Header("End page")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		[FieldOffset(Offset = "0x6C")]
		private BlitzTournamentProgressMediator _mediator;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x70")]
		private bool _mvcSetUp;

		// Token: 0x02000BC8 RID: 3016
		[Token(Token = "0x2000BC8")]
		public class BlitzTournamentProgressWindowArgs : BaseWindowArgs
		{
			// Token: 0x060049F3 RID: 18931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049F3")]
			[Address(RVA = "0x985D", Offset = "0x985D", VA = "0x985D")]
			public BlitzTournamentProgressWindowArgs()
			{
			}

			// Token: 0x0400283E RID: 10302
			[Token(Token = "0x400283E")]
			[FieldOffset(Offset = "0x18")]
			public BlitzTournamentController Controller;

			// Token: 0x0400283F RID: 10303
			[Token(Token = "0x400283F")]
			[FieldOffset(Offset = "0x1C")]
			public BlitzTournamentWindow.WindowState WindowState;
		}
	}
}
