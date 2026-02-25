using System;
using Core.Animations;
using Gameplay.Portals.View.MyBetsTab;
using Gameplay.Portals.View.RatingTab;
using Gameplay.Portals.View.ShopTab;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Tabs;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B3 RID: 1459
	[Token(Token = "0x20005B3")]
	public class PortalsView : MonoBehaviourWithStates<PortalsView.PortalsState>
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000663")]
		public PortalsRewardView PortalsRewardView
		{
			[Token(Token = "0x60022FD")]
			[Address(RVA = "0x7451", Offset = "0x7451", VA = "0x7451")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000664")]
		public StageProgressView NavigationProgressView
		{
			[Token(Token = "0x60022FE")]
			[Address(RVA = "0x7452", Offset = "0x7452", VA = "0x7452")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000665")]
		public StageProgressView MonsterProgressView
		{
			[Token(Token = "0x60022FF")]
			[Address(RVA = "0x7453", Offset = "0x7453", VA = "0x7453")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000666")]
		public TabBar TabBarView
		{
			[Token(Token = "0x6002300")]
			[Address(RVA = "0x7454", Offset = "0x7454", VA = "0x7454")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000667")]
		public PortalsMonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x6002301")]
			[Address(RVA = "0x7455", Offset = "0x7455", VA = "0x7455")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000668")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6002302")]
			[Address(RVA = "0x7456", Offset = "0x7456", VA = "0x7456")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000669")]
		public PortalsShopView ShopTab
		{
			[Token(Token = "0x6002303")]
			[Address(RVA = "0x7457", Offset = "0x7457", VA = "0x7457")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700066A")]
		public PortalsRatingView RatingTab
		{
			[Token(Token = "0x6002304")]
			[Address(RVA = "0x7458", Offset = "0x7458", VA = "0x7458")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700066B")]
		public PortalsTotalizatorView TotalizatorTab
		{
			[Token(Token = "0x6002305")]
			[Address(RVA = "0x7459", Offset = "0x7459", VA = "0x7459")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700066C")]
		public PortalsMyBetsView MyBetsTab
		{
			[Token(Token = "0x6002306")]
			[Address(RVA = "0x745A", Offset = "0x745A", VA = "0x745A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700066D")]
		public TextMeshProUGUI LeftTitle
		{
			[Token(Token = "0x6002307")]
			[Address(RVA = "0x745B", Offset = "0x745B", VA = "0x745B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700066E")]
		public TextMeshProUGUI RightTitle
		{
			[Token(Token = "0x6002308")]
			[Address(RVA = "0x745C", Offset = "0x745C", VA = "0x745C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700066F")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002309")]
			[Address(RVA = "0x745D", Offset = "0x745D", VA = "0x745D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000670")]
		public Button RegisterButton
		{
			[Token(Token = "0x600230A")]
			[Address(RVA = "0x745E", Offset = "0x745E", VA = "0x745E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000671")]
		public Button RightButton
		{
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x745F", Offset = "0x745F", VA = "0x745F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000672")]
		public Button LeftButton
		{
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x7460", Offset = "0x7460", VA = "0x7460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000673")]
		public Button RatingButton
		{
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x7461", Offset = "0x7461", VA = "0x7461")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000674")]
		public Button TotalButton
		{
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x7462", Offset = "0x7462", VA = "0x7462")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000675")]
		public Button MyBetsButton
		{
			[Token(Token = "0x600230F")]
			[Address(RVA = "0x7463", Offset = "0x7463", VA = "0x7463")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000676")]
		public Button ShopButton
		{
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x7464", Offset = "0x7464", VA = "0x7464")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000677")]
		public Button BattleButton
		{
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x7465", Offset = "0x7465", VA = "0x7465")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000678")]
		public Button PortalInfoButton
		{
			[Token(Token = "0x6002312")]
			[Address(RVA = "0x7466", Offset = "0x7466", VA = "0x7466")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000679")]
		public Button TotalizatorInfoButton
		{
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x7467", Offset = "0x7467", VA = "0x7467")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067A")]
		public GameSpineUiAnimation PortalAnimation
		{
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x7468", Offset = "0x7468", VA = "0x7468")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067B")]
		public GameSpineUiAnimation SealAnimation
		{
			[Token(Token = "0x6002315")]
			[Address(RVA = "0x7469", Offset = "0x7469", VA = "0x7469")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002316")]
		[Address(RVA = "0x746A", Offset = "0x746A", VA = "0x746A")]
		public PortalsView()
		{
		}

		// Token: 0x04001319 RID: 4889
		[Token(Token = "0x4001319")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PortalsRewardView _portalsRewardView;

		// Token: 0x0400131A RID: 4890
		[Token(Token = "0x400131A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageProgressView _navigationProgressView;

		// Token: 0x0400131B RID: 4891
		[Token(Token = "0x400131B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private StageProgressView _monsterProgressView;

		// Token: 0x0400131C RID: 4892
		[Token(Token = "0x400131C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x0400131D RID: 4893
		[Token(Token = "0x400131D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameSpineUiAnimation _portalAnimation;

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameSpineUiAnimation _sealAnimation;

		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private PortalsMonsterInfoView _monsterInfoView;

		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x4001320")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private PortalsShopView _shopTab;

		// Token: 0x04001322 RID: 4898
		[Token(Token = "0x4001322")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PortalsRatingView _ratingTab;

		// Token: 0x04001323 RID: 4899
		[Token(Token = "0x4001323")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private PortalsTotalizatorView _totalizatorTab;

		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PortalsMyBetsView _myBetsTab;

		// Token: 0x04001325 RID: 4901
		[Token(Token = "0x4001325")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _leftTitle;

		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _rightTitle;

		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001328 RID: 4904
		[Token(Token = "0x4001328")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _registerButton;

		// Token: 0x04001329 RID: 4905
		[Token(Token = "0x4001329")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Button _rightButton;

		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _leftButton;

		// Token: 0x0400132B RID: 4907
		[Token(Token = "0x400132B")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Button _ratingButton;

		// Token: 0x0400132C RID: 4908
		[Token(Token = "0x400132C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _totalButton;

		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _myBetsButton;

		// Token: 0x0400132E RID: 4910
		[Token(Token = "0x400132E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _shopButton;

		// Token: 0x0400132F RID: 4911
		[Token(Token = "0x400132F")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Button _battleButton;

		// Token: 0x04001330 RID: 4912
		[Token(Token = "0x4001330")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _portalInfoButton;

		// Token: 0x04001331 RID: 4913
		[Token(Token = "0x4001331")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Button _totalizatorInfoButton;

		// Token: 0x020005B4 RID: 1460
		[Token(Token = "0x20005B4")]
		public enum PortalsState
		{
			// Token: 0x04001333 RID: 4915
			[Token(Token = "0x4001333")]
			UNKNOWN_STATE,
			// Token: 0x04001334 RID: 4916
			[Token(Token = "0x4001334")]
			INFO,
			// Token: 0x04001335 RID: 4917
			[Token(Token = "0x4001335")]
			NAVIGATION,
			// Token: 0x04001336 RID: 4918
			[Token(Token = "0x4001336")]
			MONSTER,
			// Token: 0x04001337 RID: 4919
			[Token(Token = "0x4001337")]
			STAGE_WAIT,
			// Token: 0x04001338 RID: 4920
			[Token(Token = "0x4001338")]
			STAGE_NOT_AVAIL,
			// Token: 0x04001339 RID: 4921
			[Token(Token = "0x4001339")]
			RIGHT
		}
	}
}
