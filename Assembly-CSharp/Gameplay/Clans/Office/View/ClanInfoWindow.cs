using System;
using Core.Money;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Office.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanMembersTab;
using Gameplay.Clans.Office.View.ClanOverviewTab;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Clans.Office.View.ClanTreasuryTab;
using Gameplay.Clans.Office.View.ClanWarsTab;
using Gameplay.Clans.Office.View.ClassTab;
using Gameplay.Clans.Office.View.SquadTab;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F3 RID: 2547
	[Token(Token = "0x20009F3")]
	public class ClanInfoWindow : ClosableBaseWindow<ClanInfoWindow.ClanInfoWindowArgs>
	{
		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF6")]
		public override string WindowId
		{
			[Token(Token = "0x6003CC4")]
			[Address(RVA = "0x8B87", Offset = "0x8B87", VA = "0x8B87", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF7")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003CC5")]
			[Address(RVA = "0x8B88", Offset = "0x8B88", VA = "0x8B88")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF8")]
		public ClanOverview ClanOverviewTab
		{
			[Token(Token = "0x6003CC6")]
			[Address(RVA = "0x8B89", Offset = "0x8B89", VA = "0x8B89")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF9")]
		public ClanMembersView ClanMembersTab
		{
			[Token(Token = "0x6003CC7")]
			[Address(RVA = "0x8B8A", Offset = "0x8B8A", VA = "0x8B8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFA")]
		public ClanWarsView ClanWarsTab
		{
			[Token(Token = "0x6003CC8")]
			[Address(RVA = "0x8B8B", Offset = "0x8B8B", VA = "0x8B8B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFB")]
		public ClanResumesView ClanResumesTab
		{
			[Token(Token = "0x6003CC9")]
			[Address(RVA = "0x8B8C", Offset = "0x8B8C", VA = "0x8B8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFC")]
		public ClanTreasuryView ClanTreasuryTab
		{
			[Token(Token = "0x6003CCA")]
			[Address(RVA = "0x8B8D", Offset = "0x8B8D", VA = "0x8B8D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFD")]
		public SquadView SquadTab
		{
			[Token(Token = "0x6003CCB")]
			[Address(RVA = "0x8B8E", Offset = "0x8B8E", VA = "0x8B8E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003CCC RID: 15564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFE")]
		public ClassView ClassTab
		{
			[Token(Token = "0x6003CCC")]
			[Address(RVA = "0x8B8F", Offset = "0x8B8F", VA = "0x8B8F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0x8B90", Offset = "0x8B90", VA = "0x8B90", Slot = "22")]
		protected override void OnShow(ClanInfoWindow.ClanInfoWindowArgs args)
		{
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x8B91", Offset = "0x8B91", VA = "0x8B91", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x8B92", Offset = "0x8B92", VA = "0x8B92")]
		private void SetupMVC()
		{
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x8B93", Offset = "0x8B93", VA = "0x8B93")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x8B94", Offset = "0x8B94", VA = "0x8B94")]
		public ClanInfoWindow()
		{
		}

		// Token: 0x04002192 RID: 8594
		[Token(Token = "0x4002192")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Office/ClanInfoWindow";

		// Token: 0x04002193 RID: 8595
		[Token(Token = "0x4002193")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04002194 RID: 8596
		[Token(Token = "0x4002194")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClanOverview _clanOverviewTab;

		// Token: 0x04002195 RID: 8597
		[Token(Token = "0x4002195")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ClanMembersView _clanMembersTab;

		// Token: 0x04002196 RID: 8598
		[Token(Token = "0x4002196")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClanWarsView _clanWarsTab;

		// Token: 0x04002197 RID: 8599
		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ClanResumesView _clanResumesTab;

		// Token: 0x04002198 RID: 8600
		[Token(Token = "0x4002198")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClanTreasuryView _clanTreasuryTab;

		// Token: 0x04002199 RID: 8601
		[Token(Token = "0x4002199")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SquadView _squadTab;

		// Token: 0x0400219A RID: 8602
		[Token(Token = "0x400219A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClassView _classTab;

		// Token: 0x0400219B RID: 8603
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0x5C")]
		private ClanInfoViewMediator _mediator;

		// Token: 0x0400219C RID: 8604
		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x60")]
		private ClanInfoController _controller;

		// Token: 0x0400219D RID: 8605
		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x64")]
		private ClanInfoModel _model;

		// Token: 0x0400219E RID: 8606
		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x68")]
		private ClanInfoEvents _events;

		// Token: 0x020009F4 RID: 2548
		[Token(Token = "0x20009F4")]
		public enum State
		{
			// Token: 0x040021A0 RID: 8608
			[Token(Token = "0x40021A0")]
			UNKNOWN_STATE,
			// Token: 0x040021A1 RID: 8609
			[Token(Token = "0x40021A1")]
			FOREIGN_CLAN,
			// Token: 0x040021A2 RID: 8610
			[Token(Token = "0x40021A2")]
			MY_CLAN,
			// Token: 0x040021A3 RID: 8611
			[Token(Token = "0x40021A3")]
			LEADER
		}

		// Token: 0x020009F5 RID: 2549
		[Token(Token = "0x20009F5")]
		public enum Tab
		{
			// Token: 0x040021A5 RID: 8613
			[Token(Token = "0x40021A5")]
			INFO,
			// Token: 0x040021A6 RID: 8614
			[Token(Token = "0x40021A6")]
			MEMBERS,
			// Token: 0x040021A7 RID: 8615
			[Token(Token = "0x40021A7")]
			WARS,
			// Token: 0x040021A8 RID: 8616
			[Token(Token = "0x40021A8")]
			RESUMES,
			// Token: 0x040021A9 RID: 8617
			[Token(Token = "0x40021A9")]
			TREASURY,
			// Token: 0x040021AA RID: 8618
			[Token(Token = "0x40021AA")]
			SQUAD,
			// Token: 0x040021AB RID: 8619
			[Token(Token = "0x40021AB")]
			CLASS
		}

		// Token: 0x020009F6 RID: 2550
		[Token(Token = "0x20009F6")]
		public class ClanInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003CD2 RID: 15570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CD2")]
			[Address(RVA = "0x8B95", Offset = "0x8B95", VA = "0x8B95")]
			public ClanInfoWindowArgs(ulong clanId, ClansController clansController, ClanWarsController clanWarsController)
			{
			}

			// Token: 0x040021AC RID: 8620
			[Token(Token = "0x40021AC")]
			[FieldOffset(Offset = "0x18")]
			public readonly ulong ClanId;

			// Token: 0x040021AD RID: 8621
			[Token(Token = "0x40021AD")]
			[FieldOffset(Offset = "0x20")]
			public readonly ClansController ClansController;

			// Token: 0x040021AE RID: 8622
			[Token(Token = "0x40021AE")]
			[FieldOffset(Offset = "0x24")]
			public readonly ClanWarsController ClanWarsController;

			// Token: 0x040021AF RID: 8623
			[Token(Token = "0x40021AF")]
			[FieldOffset(Offset = "0x28")]
			public Money DeficientResources;

			// Token: 0x040021B0 RID: 8624
			[Token(Token = "0x40021B0")]
			[FieldOffset(Offset = "0x2C")]
			public ClanInfoWindow.Tab TabToOpen;
		}
	}
}
