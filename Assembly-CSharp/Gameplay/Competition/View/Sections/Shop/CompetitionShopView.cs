using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Filters;
using UnityEngine;

namespace Gameplay.Competition.View.Sections.Shop
{
	// Token: 0x020008E3 RID: 2275
	[Token(Token = "0x20008E3")]
	public class CompetitionShopView : MonoBehaviour
	{
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A99")]
		public TextMeshProUGUI FromCount
		{
			[Token(Token = "0x6003592")]
			[Address(RVA = "0x85A0", Offset = "0x85A0", VA = "0x85A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9A")]
		public TextMeshProUGUI ToCount
		{
			[Token(Token = "0x6003593")]
			[Address(RVA = "0x85A1", Offset = "0x85A1", VA = "0x85A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9B")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6003594")]
			[Address(RVA = "0x85A2", Offset = "0x85A2", VA = "0x85A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9C")]
		public MetaFiltersView MetaFiltersView
		{
			[Token(Token = "0x6003595")]
			[Address(RVA = "0x85A3", Offset = "0x85A3", VA = "0x85A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9D")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6003596")]
			[Address(RVA = "0x85A4", Offset = "0x85A4", VA = "0x85A4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9E")]
		public RectTransform ExchangeMessage
		{
			[Token(Token = "0x6003597")]
			[Address(RVA = "0x85A5", Offset = "0x85A5", VA = "0x85A5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A9F")]
		public GameObject Description
		{
			[Token(Token = "0x6003598")]
			[Address(RVA = "0x85A6", Offset = "0x85A6", VA = "0x85A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x85A7", Offset = "0x85A7", VA = "0x85A7")]
		public void Init()
		{
		}

		// Token: 0x17000AA0 RID: 2720
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA0")]
		public CompetitionModel Model
		{
			[Token(Token = "0x600359A")]
			[Address(RVA = "0x85A8", Offset = "0x85A8", VA = "0x85A8")]
			set
			{
			}
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x85A9", Offset = "0x85A9", VA = "0x85A9")]
		private void StopCurrentCoroutine()
		{
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x85AA", Offset = "0x85AA", VA = "0x85AA")]
		public void PopulateGoods(List<ShopItemData> items)
		{
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x85AB", Offset = "0x85AB", VA = "0x85AB")]
		private IEnumerator DisplayCurrentBackTime()
		{
			return null;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x85AC", Offset = "0x85AC", VA = "0x85AC")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x85AD", Offset = "0x85AD", VA = "0x85AD")]
		public CompetitionShopView()
		{
		}

		// Token: 0x04001D4A RID: 7498
		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CompetitionShopItemView _itemViewPrefab;

		// Token: 0x04001D4B RID: 7499
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _shopContentContainer;

		// Token: 0x04001D4C RID: 7500
		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Sprite> _markerSprites;

		// Token: 0x04001D4D RID: 7501
		[Token(Token = "0x4001D4D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x04001D4E RID: 7502
		[Token(Token = "0x4001D4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _exchangeMessage;

		// Token: 0x04001D4F RID: 7503
		[Token(Token = "0x4001D4F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _fromCount;

		// Token: 0x04001D50 RID: 7504
		[Token(Token = "0x4001D50")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _toCount;

		// Token: 0x04001D51 RID: 7505
		[Token(Token = "0x4001D51")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _description;

		// Token: 0x04001D52 RID: 7506
		[Token(Token = "0x4001D52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001D53 RID: 7507
		[Token(Token = "0x4001D53")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x04001D54 RID: 7508
		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001D55 RID: 7509
		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x3C")]
		private CompetitionModel _model;

		// Token: 0x04001D56 RID: 7510
		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _displayBackTimeCoroutine;
	}
}
