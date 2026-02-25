using System;
using System.Runtime.CompilerServices;
using Gameplay.SmallGames.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	public class DailyRewardsWindow : ClosableBaseWindow<DailyRewardsWindow.DailyRewardsWindowArgs>
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C1")]
		public override string WindowId
		{
			[Token(Token = "0x6001F81")]
			[Address(RVA = "0x70E6", Offset = "0x70E6", VA = "0x70E6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400013B RID: 315
		// (add) Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F83 RID: 8067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013B")]
		public event Action<RewardsTab> TabSelectedEvent
		{
			[Token(Token = "0x6001F82")]
			[Address(RVA = "0x70E7", Offset = "0x70E7", VA = "0x70E7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0x70E8", Offset = "0x70E8", VA = "0x70E8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C2")]
		public TextMeshProUGUI AdditionalBonusAnnotation
		{
			[Token(Token = "0x6001F84")]
			[Address(RVA = "0x70E9", Offset = "0x70E9", VA = "0x70E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C3")]
		public Button TakeButton
		{
			[Token(Token = "0x6001F85")]
			[Address(RVA = "0x70EA", Offset = "0x70EA", VA = "0x70EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C4")]
		public Button AccountsButton
		{
			[Token(Token = "0x6001F86")]
			[Address(RVA = "0x70EB", Offset = "0x70EB", VA = "0x70EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x70EC", Offset = "0x70EC", VA = "0x70EC")]
		public SingleRewardView[] Init(int rewardsCount)
		{
			return null;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x70ED", Offset = "0x70ED", VA = "0x70ED")]
		public void DrawPending()
		{
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x70EE", Offset = "0x70EE", VA = "0x70EE")]
		public void DrawReceived()
		{
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x70EF", Offset = "0x70EF", VA = "0x70EF", Slot = "22")]
		protected override void OnShow(DailyRewardsWindow.DailyRewardsWindowArgs args)
		{
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x70F0", Offset = "0x70F0", VA = "0x70F0", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x70F1", Offset = "0x70F1", VA = "0x70F1")]
		private void InvokeSelectedEvent(RewardsTab tab)
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x70F2", Offset = "0x70F2", VA = "0x70F2")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x70F3", Offset = "0x70F3", VA = "0x70F3")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x70F4", Offset = "0x70F4", VA = "0x70F4")]
		public DailyRewardsWindow()
		{
		}

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/DailyRewardsWindow";

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		private const string LOCALIZATION_TAKE_BONUS = "DAILY_REWARDS/TAKE_BONUS";

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		private const string LOCALIZATION_REWARD_RECEIVED_ANNOTATION = "DAILY_REWARDS/REWARD_RECEIVED_ANNOTATION";

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SingleRewardView _rewardPanelPrefab;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rewardsParent;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _activeTabsParent;

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _inactiveTabsParent;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private RewardsTab _dailyTab;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RewardsTab _hourlyTab;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RewardsTab _subscriptionTab;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _additionalBonusAnnotation;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private DoubleRewardView _doublePanel;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _accountsButton;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x6C")]
		private DailyRewardsViewMediator _mediator;

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x70")]
		private bool _mvcSetUp;

		// Token: 0x0200052E RID: 1326
		[Token(Token = "0x200052E")]
		public class DailyRewardsWindowArgs : BaseWindowArgs
		{
			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005C5")]
			public SmallGamesController Controller
			{
				[Token(Token = "0x6001F93")]
				[Address(RVA = "0x70F8", Offset = "0x70F8", VA = "0x70F8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F94")]
			[Address(RVA = "0x70F9", Offset = "0x70F9", VA = "0x70F9")]
			public DailyRewardsWindowArgs(SmallGamesController controller)
			{
			}
		}
	}
}
