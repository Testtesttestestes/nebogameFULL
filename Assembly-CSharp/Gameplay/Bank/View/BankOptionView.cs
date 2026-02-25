using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C3F RID: 3135
	[Token(Token = "0x2000C3F")]
	public class BankOptionView : AbstractDataRenderer<BankOptionViewArgs>, IBankOptionView
	{
		// Token: 0x140001D9 RID: 473
		// (add) Token: 0x06004C5E RID: 19550 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C5F RID: 19551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D9")]
		public event Action<IBankOptionView> BuyButtonClickEvent
		{
			[Token(Token = "0x6004C5E")]
			[Address(RVA = "0x9A9F", Offset = "0x9A9F", VA = "0x9A9F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C5F")]
			[Address(RVA = "0x9AA0", Offset = "0x9AA0", VA = "0x9AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001DA RID: 474
		// (add) Token: 0x06004C60 RID: 19552 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C61 RID: 19553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DA")]
		public event Action<BankOptionView> FaqButtonClickEvent
		{
			[Token(Token = "0x6004C60")]
			[Address(RVA = "0x9AA1", Offset = "0x9AA1", VA = "0x9AA1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C61")]
			[Address(RVA = "0x9AA2", Offset = "0x9AA2", VA = "0x9AA2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F67")]
		public Button FaqButton
		{
			[Token(Token = "0x6004C62")]
			[Address(RVA = "0x9AA3", Offset = "0x9AA3", VA = "0x9AA3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x17000F68")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6004C63")]
			[Address(RVA = "0x9AA4", Offset = "0x9AA4", VA = "0x9AA4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x17000F69")]
		protected virtual bool ShowFaqButton
		{
			[Token(Token = "0x6004C64")]
			[Address(RVA = "0x9AA5", Offset = "0x9AA5", VA = "0x9AA5", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004C66 RID: 19558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6A")]
		public BankOptionData BankOptionData
		{
			[Token(Token = "0x6004C65")]
			[Address(RVA = "0x9AA6", Offset = "0x9AA6", VA = "0x9AA6", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C66")]
			[Address(RVA = "0x9AA7", Offset = "0x9AA7", VA = "0x9AA7", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x9AA8", Offset = "0x9AA8", VA = "0x9AA8", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x9AA9", Offset = "0x9AA9", VA = "0x9AA9", Slot = "5")]
		protected override void CommitProperties()
		{
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x9AAA", Offset = "0x9AAA", VA = "0x9AAA", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x9AAB", Offset = "0x9AAB", VA = "0x9AAB", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x9AAC", Offset = "0x9AAC", VA = "0x9AAC")]
		public void Release()
		{
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x9AAD", Offset = "0x9AAD", VA = "0x9AAD", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x9AAE", Offset = "0x9AAE", VA = "0x9AAE")]
		private void HandlePriceButton()
		{
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x9AAF", Offset = "0x9AAF", VA = "0x9AAF")]
		private void DisplaySticker()
		{
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6F")]
		[Address(RVA = "0x9AB0", Offset = "0x9AB0", VA = "0x9AB0")]
		private void DisplayResourceProfit()
		{
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x9AB1", Offset = "0x9AB1", VA = "0x9AB1", Slot = "17")]
		protected override void StartListenEvents(BankOptionViewArgs args)
		{
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x9AB2", Offset = "0x9AB2", VA = "0x9AB2", Slot = "18")]
		protected override void StopListenEvents(BankOptionViewArgs args)
		{
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x9AB3", Offset = "0x9AB3", VA = "0x9AB3")]
		private void RenderRewards()
		{
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x9AB4", Offset = "0x9AB4", VA = "0x9AB4")]
		private void BankOptionDataOnIsProcessingChangedEvent()
		{
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x9AB5", Offset = "0x9AB5", VA = "0x9AB5")]
		private void ValidateBuyButtonInteractable()
		{
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x9AB6", Offset = "0x9AB6", VA = "0x9AB6", Slot = "25")]
		protected virtual void FaqButtonClickHandler()
		{
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x9AB7", Offset = "0x9AB7", VA = "0x9AB7", Slot = "26")]
		protected virtual void BuyButtonClickHandler()
		{
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x9AB8", Offset = "0x9AB8", VA = "0x9AB8", Slot = "22")]
		public void AddBuyButtonListener(Action<IBankOptionView> callback)
		{
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x9AB9", Offset = "0x9AB9", VA = "0x9AB9", Slot = "23")]
		public void RemoveBuyButtonListener(Action<IBankOptionView> callback)
		{
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x9ABA", Offset = "0x9ABA", VA = "0x9ABA")]
		public BankOptionView()
		{
		}

		// Token: 0x040029AD RID: 10669
		[Token(Token = "0x40029AD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewRawImage _bgGameRawImage;

		// Token: 0x040029AE RID: 10670
		[Token(Token = "0x40029AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040029AF RID: 10671
		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _buyButton;

		// Token: 0x040029B0 RID: 10672
		[Token(Token = "0x40029B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _faqButton;

		// Token: 0x040029B1 RID: 10673
		[Token(Token = "0x40029B1")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _buyButtonText;

		// Token: 0x040029B2 RID: 10674
		[Token(Token = "0x40029B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _buyButtonIcon;

		// Token: 0x040029B3 RID: 10675
		[Token(Token = "0x40029B3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _profitContainer;

		// Token: 0x040029B4 RID: 10676
		[Token(Token = "0x40029B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040029B5 RID: 10677
		[Token(Token = "0x40029B5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _optionTitle;

		// Token: 0x040029B6 RID: 10678
		[Token(Token = "0x40029B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _starsContainer;

		// Token: 0x040029B7 RID: 10679
		[Token(Token = "0x40029B7")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameRawImage _markerView;

		// Token: 0x040029B8 RID: 10680
		[Token(Token = "0x40029B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VipPointsView _vipPointsView;

		// Token: 0x040029B9 RID: 10681
		[Token(Token = "0x40029B9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private BankOptionAdPlacementView _adPlacementView;

		// Token: 0x040029BA RID: 10682
		[Token(Token = "0x40029BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BankOptionResourceProfitView resourceProfitPrefab;

		// Token: 0x040029BD RID: 10685
		[Token(Token = "0x40029BD")]
		[FieldOffset(Offset = "0x64")]
		private bool _isProcessingChanged;
	}
}
