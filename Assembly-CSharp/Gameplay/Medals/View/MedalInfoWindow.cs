using System;
using System.Collections.Generic;
using AssetContent.Loaders;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Collections.View;
using Gameplay.Discounts.View;
using Gameplay.Medals.Controller;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Price;
using UI.Requirements;
using UI.Rewards;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F6 RID: 1526
	[Token(Token = "0x20005F6")]
	public class MedalInfoWindow : ClosableBaseWindow<MedalInfoWindowArgs>
	{
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E3")]
		public override string WindowId
		{
			[Token(Token = "0x60024F9")]
			[Address(RVA = "0x7644", Offset = "0x7644", VA = "0x7644", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E4")]
		public Button BuyButton
		{
			[Token(Token = "0x60024FA")]
			[Address(RVA = "0x7645", Offset = "0x7645", VA = "0x7645")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E5")]
		public Price Price
		{
			[Token(Token = "0x60024FB")]
			[Address(RVA = "0x7646", Offset = "0x7646", VA = "0x7646")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E6")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x60024FC")]
			[Address(RVA = "0x7647", Offset = "0x7647", VA = "0x7647")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E7")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x60024FD")]
			[Address(RVA = "0x7648", Offset = "0x7648", VA = "0x7648")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E8")]
		public BacktimeViewUGUI DurationLabel
		{
			[Token(Token = "0x60024FE")]
			[Address(RVA = "0x7649", Offset = "0x7649", VA = "0x7649")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006E9")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x60024FF")]
			[Address(RVA = "0x764A", Offset = "0x764A", VA = "0x764A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EA")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002500")]
			[Address(RVA = "0x764B", Offset = "0x764B", VA = "0x764B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EB")]
		public TextMeshProUGUI GroupLabel
		{
			[Token(Token = "0x6002501")]
			[Address(RVA = "0x764C", Offset = "0x764C", VA = "0x764C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EC")]
		public MedalView MedalView
		{
			[Token(Token = "0x6002502")]
			[Address(RVA = "0x764D", Offset = "0x764D", VA = "0x764D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006ED")]
		public GameRawImageLoader QualityBGLoader
		{
			[Token(Token = "0x6002503")]
			[Address(RVA = "0x764E", Offset = "0x764E", VA = "0x764E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EE")]
		public DiscountGroup DiscountGroup
		{
			[Token(Token = "0x6002504")]
			[Address(RVA = "0x764F", Offset = "0x764F", VA = "0x764F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006EF")]
		public CollectionRowHelper CollectionRow
		{
			[Token(Token = "0x6002505")]
			[Address(RVA = "0x7650", Offset = "0x7650", VA = "0x7650")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x7651", Offset = "0x7651", VA = "0x7651", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002507")]
		[Address(RVA = "0x7652", Offset = "0x7652", VA = "0x7652", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x7653", Offset = "0x7653", VA = "0x7653", Slot = "22")]
		protected override void OnShow(MedalInfoWindowArgs args)
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x7654", Offset = "0x7654", VA = "0x7654")]
		public void SetDescription(string description)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x7655", Offset = "0x7655", VA = "0x7655")]
		public List<MedalViewSelectable> DrawMedals(MedalData medalData, Action<MedalViewSelectable> callback)
		{
			return null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x7656", Offset = "0x7656", VA = "0x7656")]
		public List<MedalViewSelectable> DrawMedalsClamped(MedalData medalData, Action<MedalViewSelectable> callback)
		{
			return null;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x1BED", Offset = "0x1BED", VA = "0x1BED")]
		private void PopulateMedalView(MedalData medalData, Action<MedalViewSelectable> callback, List<MedalViewSelectable> result, MedalDicWrapper md, MedalViewSelectable mv)
		{
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x7657", Offset = "0x7657", VA = "0x7657")]
		private void SetupMVC()
		{
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250E")]
		[Address(RVA = "0x7658", Offset = "0x7658", VA = "0x7658")]
		private void DestroyMVC()
		{
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600250F")]
		[Address(RVA = "0x7659", Offset = "0x7659", VA = "0x7659")]
		public MedalInfoWindow()
		{
		}

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Medals/MedalInfoWindow";

		// Token: 0x04001430 RID: 5168
		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x04001431 RID: 5169
		[Token(Token = "0x4001431")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x04001432 RID: 5170
		[Token(Token = "0x4001432")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _groupLabel;

		// Token: 0x04001433 RID: 5171
		[Token(Token = "0x4001433")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x04001434 RID: 5172
		[Token(Token = "0x4001434")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04001435 RID: 5173
		[Token(Token = "0x4001435")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _descGroup;

		// Token: 0x04001436 RID: 5174
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _buyButton;

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Price _price;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Transform _medalsContainer;

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x0400143A RID: 5178
		[Token(Token = "0x400143A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x0400143B RID: 5179
		[Token(Token = "0x400143B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x0400143C RID: 5180
		[Token(Token = "0x400143C")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x0400143D RID: 5181
		[Token(Token = "0x400143D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CollectionRowHelper _collectionRow;

		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private MedalViewSelectable _medalViewPrefab;

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0x78")]
		private MedalInfoViewMediator _mediator;
	}
}
