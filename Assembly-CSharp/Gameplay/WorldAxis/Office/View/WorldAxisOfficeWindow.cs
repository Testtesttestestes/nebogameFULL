using System;
using Gameplay.WorldAxis.Office.Controller;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.FrontPageTab;
using Gameplay.WorldAxis.Office.View.History;
using Gameplay.WorldAxis.Office.View.Ratings;
using Gameplay.WorldAxis.Office.View.Rewards;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	public class WorldAxisOfficeWindow : ClosableBaseWindow<WorldAxisOfficeWindow.WorldAxisOfficeWindowArgs>
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029C")]
		public override string WindowId
		{
			[Token(Token = "0x60011BB")]
			[Address(RVA = "0x63B8", Offset = "0x63B8", VA = "0x63B8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029D")]
		public TabBar TabBar
		{
			[Token(Token = "0x60011BC")]
			[Address(RVA = "0x63B9", Offset = "0x63B9", VA = "0x63B9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029E")]
		public FrontPageView FrontPageTab
		{
			[Token(Token = "0x60011BD")]
			[Address(RVA = "0x63BA", Offset = "0x63BA", VA = "0x63BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029F")]
		public WorldAxisScheduleView ScheduleTab
		{
			[Token(Token = "0x60011BE")]
			[Address(RVA = "0x63BB", Offset = "0x63BB", VA = "0x63BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A0")]
		public HistoryView HistoryTab
		{
			[Token(Token = "0x60011BF")]
			[Address(RVA = "0x63BC", Offset = "0x63BC", VA = "0x63BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A1")]
		public ClanRatingsView ClanRatingsTab
		{
			[Token(Token = "0x60011C0")]
			[Address(RVA = "0x63BD", Offset = "0x63BD", VA = "0x63BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A2")]
		public UserRatingsView UserRatingsTab
		{
			[Token(Token = "0x60011C1")]
			[Address(RVA = "0x63BE", Offset = "0x63BE", VA = "0x63BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A3")]
		public SeasonRewardsView RewardsTab
		{
			[Token(Token = "0x60011C2")]
			[Address(RVA = "0x63BF", Offset = "0x63BF", VA = "0x63BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x63C0", Offset = "0x63C0", VA = "0x63C0", Slot = "22")]
		protected override void OnShow(WorldAxisOfficeWindow.WorldAxisOfficeWindowArgs args)
		{
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x63C1", Offset = "0x63C1", VA = "0x63C1", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x63C2", Offset = "0x63C2", VA = "0x63C2")]
		private void SetupMVC()
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x63C3", Offset = "0x63C3", VA = "0x63C3")]
		private void DestroyMVC()
		{
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x63C4", Offset = "0x63C4", VA = "0x63C4")]
		public WorldAxisOfficeWindow()
		{
		}

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/WorldAxis/WorldAxisWindow";

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FrontPageView _frontPageTab;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private WorldAxisScheduleView _scheduleTab;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HistoryView _historyTab;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ClanRatingsView _clanRatingsTab;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UserRatingsView _userRatingsTab;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SeasonRewardsView _rewardsTab;

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x58")]
		private WorldAxisOfficeModel _model;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x5C")]
		private WorldAxisOfficeEvents _events;

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x60")]
		private WorldAxisOfficeController _controller;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x64")]
		private WorldAxisOfficeViewMediator _mediator;

		// Token: 0x020002EB RID: 747
		[Token(Token = "0x20002EB")]
		public enum Tab
		{
			// Token: 0x04000926 RID: 2342
			[Token(Token = "0x4000926")]
			FRONT_PAGE,
			// Token: 0x04000927 RID: 2343
			[Token(Token = "0x4000927")]
			SCHEDULE,
			// Token: 0x04000928 RID: 2344
			[Token(Token = "0x4000928")]
			HISTORY,
			// Token: 0x04000929 RID: 2345
			[Token(Token = "0x4000929")]
			CLAN_RATINGS,
			// Token: 0x0400092A RID: 2346
			[Token(Token = "0x400092A")]
			USER_RATINGS,
			// Token: 0x0400092B RID: 2347
			[Token(Token = "0x400092B")]
			REWARDS
		}

		// Token: 0x020002EC RID: 748
		[Token(Token = "0x20002EC")]
		public class WorldAxisOfficeWindowArgs : BaseWindowArgs
		{
			// Token: 0x060011C8 RID: 4552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011C8")]
			[Address(RVA = "0x63C5", Offset = "0x63C5", VA = "0x63C5")]
			public WorldAxisOfficeWindowArgs()
			{
			}

			// Token: 0x0400092C RID: 2348
			[Token(Token = "0x400092C")]
			[FieldOffset(Offset = "0x18")]
			public WorldAxisOfficeWindow.Tab TabToOpen;
		}
	}
}
