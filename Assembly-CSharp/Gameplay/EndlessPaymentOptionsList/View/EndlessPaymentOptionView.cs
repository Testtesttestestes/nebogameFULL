using System;
using System.Collections;
using AssetContent;
using Core.Animations;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	public class EndlessPaymentOptionView : AbstractDataRenderer<CardData>
	{
		// Token: 0x06003153 RID: 12627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x81AB", Offset = "0x81AB", VA = "0x81AB", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x81AC", Offset = "0x81AC", VA = "0x81AC")]
		private void DrawVipPoints(CardData data)
		{
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003155")]
		[Address(RVA = "0x81AD", Offset = "0x81AD", VA = "0x81AD")]
		private void DrawResourceAmount(CardData data)
		{
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003156")]
		[Address(RVA = "0x81AE", Offset = "0x81AE", VA = "0x81AE")]
		private void DrawEmptyState(CardData data)
		{
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003157")]
		[Address(RVA = "0x81AF", Offset = "0x81AF", VA = "0x81AF")]
		private void DrawLock(CardData data)
		{
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x81B0", Offset = "0x81B0", VA = "0x81B0")]
		private void DrawReward(CardData data)
		{
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003159")]
		[Address(RVA = "0x81B1", Offset = "0x81B1", VA = "0x81B1")]
		private void DrawImages(CardData data)
		{
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315A")]
		[Address(RVA = "0x81B2", Offset = "0x81B2", VA = "0x81B2")]
		private void DrawNextArrow(CardData data)
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315B")]
		[Address(RVA = "0x81B3", Offset = "0x81B3", VA = "0x81B3")]
		private void DrawLabel(CardData data)
		{
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315C")]
		[Address(RVA = "0x81B4", Offset = "0x81B4", VA = "0x81B4")]
		private void DrawDiscountTopBanner(CardData data)
		{
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x170009B3")]
		private bool IsFree
		{
			[Token(Token = "0x600315D")]
			[Address(RVA = "0x81B5", Offset = "0x81B5", VA = "0x81B5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x81B6", Offset = "0x81B6", VA = "0x81B6")]
		private IEnumerator PlayBuyRoutine(bool hide)
		{
			return null;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x81B7", Offset = "0x81B7", VA = "0x81B7")]
		public IEnumerator PlayBuy(bool hide)
		{
			return null;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x81B8", Offset = "0x81B8", VA = "0x81B8")]
		public IEnumerator ShowUnlock()
		{
			return null;
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x81B9", Offset = "0x81B9", VA = "0x81B9")]
		private IEnumerator ShowUnlockRoutine()
		{
			return null;
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x81BA", Offset = "0x81BA", VA = "0x81BA")]
		public EndlessPaymentOptionView()
		{
		}

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _vipPointsValue;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backgroundPaid;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _backgroundFree;

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _cover;

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameSpineUiAnimation _lockAnimation;

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _lockOwner;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _vipPoints;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameSpineUiAnimation _idleBlickAnimation;

		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameSpineUiAnimation _getMerkerAnimation;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _saleTopMarker;

		// Token: 0x04001AFE RID: 6910
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Image _rightArrow;

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EndlessPaymentOptionView.ResourceValueColorsConfig[] _resourceValueColors;

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private SimpleIconValue _resourceAmontPrefab;

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _amountOwner;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Transform _resourcesAmountOwner;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _optionIdDbgField;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Transform _lockWidget;

		// Token: 0x02000832 RID: 2098
		[Token(Token = "0x2000832")]
		[Serializable]
		public class ResourceValueColorsConfig
		{
			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x0000A068 File Offset: 0x00008268
			[Token(Token = "0x170009B4")]
			public Protocol.Consts.Resources ResourcesId
			{
				[Token(Token = "0x6003163")]
				[Address(RVA = "0x81BB", Offset = "0x81BB", VA = "0x81BB")]
				get
				{
					return Protocol.Consts.Resources.UnknownResource;
				}
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x06003164 RID: 12644 RVA: 0x0000A080 File Offset: 0x00008280
			[Token(Token = "0x170009B5")]
			public Color Color
			{
				[Token(Token = "0x6003164")]
				[Address(RVA = "0x81BC", Offset = "0x81BC", VA = "0x81BC")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x06003165 RID: 12645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003165")]
			[Address(RVA = "0x81BD", Offset = "0x81BD", VA = "0x81BD")]
			public ResourceValueColorsConfig()
			{
			}

			// Token: 0x04001B05 RID: 6917
			[Token(Token = "0x4001B05")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Protocol.Consts.Resources _resourcesId;

			// Token: 0x04001B06 RID: 6918
			[Token(Token = "0x4001B06")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Color _color;
		}
	}
}
