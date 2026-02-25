using System;
using AssetContent;
using Core.Data;
using Gameplay.Inventory.View.Info.InfoBox;
using Gameplay.WorldAxis.ColossusInfo.Controller.ColossusInfo;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.Controller;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	public class ColossusInfoWindow : ClosableBaseWindow<ColossusInfoWindow.ColossusInfoWindowArgs>
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CA")]
		public override string WindowId
		{
			[Token(Token = "0x600125D")]
			[Address(RVA = "0x6457", Offset = "0x6457", VA = "0x6457", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CB")]
		public ColossusRatingTable RatingTable
		{
			[Token(Token = "0x600125E")]
			[Address(RVA = "0x6458", Offset = "0x6458", VA = "0x6458")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CC")]
		public TabBar TabBar
		{
			[Token(Token = "0x600125F")]
			[Address(RVA = "0x6459", Offset = "0x6459", VA = "0x6459")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CD")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x645A", Offset = "0x645A", VA = "0x645A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CE")]
		public ColossusDescription ColossusDescription
		{
			[Token(Token = "0x6001261")]
			[Address(RVA = "0x645B", Offset = "0x645B", VA = "0x645B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CF")]
		public ColossusTreasuryView TreasuryTab
		{
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x645C", Offset = "0x645C", VA = "0x645C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D0")]
		public GameObject InfoTab
		{
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x645D", Offset = "0x645D", VA = "0x645D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D1")]
		public TitleRowView ClassRow
		{
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x645E", Offset = "0x645E", VA = "0x645E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D2")]
		public TitleRowView PartyRow
		{
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x645F", Offset = "0x645F", VA = "0x645F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D3")]
		public TextMeshProUGUI BattleStatusText
		{
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x6460", Offset = "0x6460", VA = "0x6460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D4")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x6461", Offset = "0x6461", VA = "0x6461")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D5")]
		public Button AttackButton
		{
			[Token(Token = "0x6001268")]
			[Address(RVA = "0x6462", Offset = "0x6462", VA = "0x6462")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D6")]
		public Button JoinSquadButton
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x6463", Offset = "0x6463", VA = "0x6463")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D7")]
		public Button CreateClanButton
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x6464", Offset = "0x6464", VA = "0x6464")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D8")]
		public IndexButtonBasic SquadButton
		{
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x6465", Offset = "0x6465", VA = "0x6465")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D9")]
		public IndexButtonBasic ClassButton
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x6466", Offset = "0x6466", VA = "0x6466")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x6467", Offset = "0x6467", VA = "0x6467", Slot = "22")]
		protected override void OnShow(ColossusInfoWindow.ColossusInfoWindowArgs args)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x6468", Offset = "0x6468", VA = "0x6468", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x6469", Offset = "0x6469", VA = "0x6469")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x646A", Offset = "0x646A", VA = "0x646A")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x646B", Offset = "0x646B", VA = "0x646B")]
		public ColossusInfoWindow()
		{
		}

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/WorldAxis/ColossusInfoWindow";

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ColossusRatingTable _ratingTable;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _bigAvatar;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ColossusDescription _colossusDescription;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ColossusTreasuryView _treasuryTab;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _infoTab;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TitleRowView _classRow;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TitleRowView _partyRow;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _battleStatus;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _joinSquadButton;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _createClanButton;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private IndexButtonBasic _squadButton;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private IndexButtonBasic _classButton;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x7C")]
		private ColossusInfoModel _model;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x80")]
		private ColossusInfoEvents _events;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x84")]
		private ColossusInfoController _controller;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x88")]
		private ColossusInfoViewMediator _mediator;

		// Token: 0x0200031D RID: 797
		[Token(Token = "0x200031D")]
		public enum Tab
		{
			// Token: 0x040009E7 RID: 2535
			[Token(Token = "0x40009E7")]
			RATING,
			// Token: 0x040009E8 RID: 2536
			[Token(Token = "0x40009E8")]
			DESCRIPTION,
			// Token: 0x040009E9 RID: 2537
			[Token(Token = "0x40009E9")]
			TREASURY
		}

		// Token: 0x0200031E RID: 798
		[Token(Token = "0x200031E")]
		public class ColossusInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001272 RID: 4722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x646C", Offset = "0x646C", VA = "0x646C")]
			public ColossusInfoWindowArgs()
			{
			}

			// Token: 0x040009EA RID: 2538
			[Token(Token = "0x40009EA")]
			[FieldOffset(Offset = "0x18")]
			public ColossusInfoWindow.Tab TabToOpen;

			// Token: 0x040009EB RID: 2539
			[Token(Token = "0x40009EB")]
			[FieldOffset(Offset = "0x1C")]
			public ColossusBattleData ColossusBattleData;

			// Token: 0x040009EC RID: 2540
			[Token(Token = "0x40009EC")]
			[FieldOffset(Offset = "0x20")]
			public WorldAxisController WorldAxisController;
		}
	}
}
