using System;
using AssetContent;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Ad.DailyQuestsAd.View;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UI.Rewards;
using UI.Scroll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	public class DailyQuestReadView : MonoBehaviourWithStates<DailyQuestReadView.State>
	{
		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FC")]
		public Button ActionButton
		{
			[Token(Token = "0x60032AA")]
			[Address(RVA = "0x82FC", Offset = "0x82FC", VA = "0x82FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FD")]
		public Button ToMailButton
		{
			[Token(Token = "0x60032AB")]
			[Address(RVA = "0x82FD", Offset = "0x82FD", VA = "0x82FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FE")]
		public DailyQuestsAdView AdView
		{
			[Token(Token = "0x60032AC")]
			[Address(RVA = "0x82FE", Offset = "0x82FE", VA = "0x82FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AD")]
		[Address(RVA = "0x82FF", Offset = "0x82FF", VA = "0x82FF")]
		private void Awake()
		{
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AE")]
		[Address(RVA = "0x8300", Offset = "0x8300", VA = "0x8300")]
		public void InitDailyQuest(IDailyQuest quest, UserData user)
		{
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AF")]
		[Address(RVA = "0x8301", Offset = "0x8301", VA = "0x8301")]
		private void SetupTakeRewardView()
		{
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x8302", Offset = "0x8302", VA = "0x8302")]
		public void InitGoal(IGoal goal, UserData user)
		{
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x8303", Offset = "0x8303", VA = "0x8303")]
		private void InitInternal(IQuest quest, UserData user)
		{
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x8304", Offset = "0x8304", VA = "0x8304")]
		private void HandleDataChanged(UserData user)
		{
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x8305", Offset = "0x8305", VA = "0x8305")]
		private void DrawLargeImage()
		{
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x8306", Offset = "0x8306", VA = "0x8306")]
		public DailyQuestReadView()
		{
		}

		// Token: 0x04001BAE RID: 7086
		[Token(Token = "0x4001BAE")]
		public const string DAILY_QUEST_REWARD_HINT = "DAILY_QUESTS/REWARD_HINT";

		// Token: 0x04001BAF RID: 7087
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _desciption;

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001BB1 RID: 7089
		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImageLoader _someImageLoader;

		// Token: 0x04001BB2 RID: 7090
		[Token(Token = "0x4001BB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _timerPrefix;

		// Token: 0x04001BB3 RID: 7091
		[Token(Token = "0x4001BB3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _actionButton;

		// Token: 0x04001BB6 RID: 7094
		[Token(Token = "0x4001BB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _hint;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _largeImage;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject _defaultImage;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _toMailButton;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private DailyQuestsAdView _adView;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollWithButtons _scrollWithButtons;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		[FieldOffset(Offset = "0x54")]
		private IQuest _quest;

		// Token: 0x0200086C RID: 2156
		[Token(Token = "0x200086C")]
		public enum State
		{
			// Token: 0x04001BBF RID: 7103
			[Token(Token = "0x4001BBF")]
			UNKNOWN_STATE,
			// Token: 0x04001BC0 RID: 7104
			[Token(Token = "0x4001BC0")]
			REWARD_TAKEN = 2,
			// Token: 0x04001BC1 RID: 7105
			[Token(Token = "0x4001BC1")]
			REWARD_IN_MAIL
		}
	}
}
