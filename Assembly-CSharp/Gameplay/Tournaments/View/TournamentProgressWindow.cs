using System;
using Core.Data.Tournaments;
using Gameplay.Tournaments.Controller;
using Il2CppDummyDll;
using Protocol.Common;
using TMPro;
using UI;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	public class TournamentProgressWindow : ClosableBaseWindow<TournamentProgressWindow.TournamentProgressWindowArgs>
	{
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000510")]
		public override string WindowId
		{
			[Token(Token = "0x6001C5A")]
			[Address(RVA = "0x6DD9", Offset = "0x6DD9", VA = "0x6DD9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000511")]
		public TextMeshProUGUI TournamentStatus
		{
			[Token(Token = "0x6001C5B")]
			[Address(RVA = "0x6DDA", Offset = "0x6DDA", VA = "0x6DDA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000512")]
		public TextMeshProUGUI TournamentState
		{
			[Token(Token = "0x6001C5C")]
			[Address(RVA = "0x6DDB", Offset = "0x6DDB", VA = "0x6DDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000513")]
		public TournamentProgressInfoBox InfoBox
		{
			[Token(Token = "0x6001C5D")]
			[Address(RVA = "0x6DDC", Offset = "0x6DDC", VA = "0x6DDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000514")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6001C5E")]
			[Address(RVA = "0x6DDD", Offset = "0x6DDD", VA = "0x6DDD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000515")]
		public Button RulesButton
		{
			[Token(Token = "0x6001C5F")]
			[Address(RVA = "0x6DDE", Offset = "0x6DDE", VA = "0x6DDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000516")]
		public BacktimeViewUGUI Timer
		{
			[Token(Token = "0x6001C60")]
			[Address(RVA = "0x6DDF", Offset = "0x6DDF", VA = "0x6DDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000517")]
		public GameObject WinImage
		{
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x6DE0", Offset = "0x6DE0", VA = "0x6DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000518")]
		public GameObject LoseImage
		{
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x6DE1", Offset = "0x6DE1", VA = "0x6DE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00005EE0 File Offset: 0x000040E0
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000519")]
		public bool AllowClose
		{
			[Token(Token = "0x6001C63")]
			[Address(RVA = "0x6DE2", Offset = "0x6DE2", VA = "0x6DE2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C64")]
			[Address(RVA = "0x6DE3", Offset = "0x6DE3", VA = "0x6DE3")]
			set
			{
			}
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x6DE4", Offset = "0x6DE4", VA = "0x6DE4", Slot = "22")]
		protected override void OnShow(TournamentProgressWindow.TournamentProgressWindowArgs args)
		{
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x6DE5", Offset = "0x6DE5", VA = "0x6DE5", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x6DE6", Offset = "0x6DE6", VA = "0x6DE6")]
		public TournamentBattleInfoListElement[] Init(TournamentData tournamentData, Action<UserInfo> callback)
		{
			return null;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x6DE7", Offset = "0x6DE7", VA = "0x6DE7")]
		public void UpdateTimer(BackTime backTime)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x6DE8", Offset = "0x6DE8", VA = "0x6DE8", Slot = "17")]
		public override bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x6DE9", Offset = "0x6DE9", VA = "0x6DE9")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x6DEA", Offset = "0x6DEA", VA = "0x6DEA")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x6DEB", Offset = "0x6DEB", VA = "0x6DEB")]
		public TournamentProgressWindow()
		{
		}

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tournaments/TournamentProgressWindow";

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TournamentProgressInfoBox _infoBox;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TournamentBattleInfoListElement _listElementPrefab;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x4C")]
		[Header("General page")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _tournamentStatus;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _tournamentState;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _winImage;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _loseImage;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x64")]
		private TournamentProgressViewMediator _mediator;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x69")]
		private bool _allowClose;

		// Token: 0x020004B2 RID: 1202
		[Token(Token = "0x20004B2")]
		public class TournamentProgressWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001C6D RID: 7277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001C6D")]
			[Address(RVA = "0x6DEC", Offset = "0x6DEC", VA = "0x6DEC")]
			public TournamentProgressWindowArgs()
			{
			}

			// Token: 0x04000F78 RID: 3960
			[Token(Token = "0x4000F78")]
			[FieldOffset(Offset = "0x18")]
			public TournamentsController Controller;
		}
	}
}
