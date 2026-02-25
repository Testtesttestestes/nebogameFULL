using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.View;
using Gameplay.Tournaments.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	public class TournamentsWindow : ClosableBaseWindow<TournamentsWindow.TournamentsWindowArgs>
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051A")]
		public override string WindowId
		{
			[Token(Token = "0x6001C70")]
			[Address(RVA = "0x6DEF", Offset = "0x6DEF", VA = "0x6DEF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		public bool AllowClose
		{
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x6DF0", Offset = "0x6DF0", VA = "0x6DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C72")]
			[Address(RVA = "0x6DF1", Offset = "0x6DF1", VA = "0x6DF1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051C")]
		public Button HistoryButton
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x6DF2", Offset = "0x6DF2", VA = "0x6DF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051D")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6001C74")]
			[Address(RVA = "0x6DF3", Offset = "0x6DF3", VA = "0x6DF3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051E")]
		public TournamentInfoBox InfoBox
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x6DF4", Offset = "0x6DF4", VA = "0x6DF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051F")]
		public Button RulesButton
		{
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x6DF5", Offset = "0x6DF5", VA = "0x6DF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000520")]
		public Button InTournamentButton
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x6DF6", Offset = "0x6DF6", VA = "0x6DF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000521")]
		public Button QuitButton
		{
			[Token(Token = "0x6001C78")]
			[Address(RVA = "0x6DF7", Offset = "0x6DF7", VA = "0x6DF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x6DF8", Offset = "0x6DF8", VA = "0x6DF8", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x6DF9", Offset = "0x6DF9", VA = "0x6DF9", Slot = "22")]
		protected override void OnShow(TournamentsWindow.TournamentsWindowArgs args)
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x6DFA", Offset = "0x6DFA", VA = "0x6DFA")]
		public TournamentListElement[] Init(IList<TournamentData> tournaments, Action<TournamentListElementBase> onClick)
		{
			return null;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x6DFB", Offset = "0x6DFB", VA = "0x6DFB", Slot = "17")]
		public override bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x6DFC", Offset = "0x6DFC", VA = "0x6DFC")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x6DFD", Offset = "0x6DFD", VA = "0x6DFD")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x6DFE", Offset = "0x6DFE", VA = "0x6DFE")]
		public TournamentsWindow()
		{
		}

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tournaments/TournamentsWindow";

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TournamentListElement _listElementPrefab;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TournamentInfoBox _infoBox;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _historyButton;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _inTournamentButton;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _quitButton;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x60")]
		private TournamentsViewMediator _mediator;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x64")]
		private bool _mvcSetUp;

		// Token: 0x020004B5 RID: 1205
		[Token(Token = "0x20004B5")]
		public class TournamentsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001C80 RID: 7296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001C80")]
			[Address(RVA = "0x6DFF", Offset = "0x6DFF", VA = "0x6DFF")]
			public TournamentsWindowArgs()
			{
			}

			// Token: 0x04000F86 RID: 3974
			[Token(Token = "0x4000F86")]
			[FieldOffset(Offset = "0x18")]
			public TournamentsController Controller;
		}
	}
}
