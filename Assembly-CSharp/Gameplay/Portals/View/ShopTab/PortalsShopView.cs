using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Filters;
using UnityEngine;

namespace Gameplay.Portals.View.ShopTab
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	public class PortalsShopView : MonoBehaviour
	{
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068D")]
		public TextMeshProUGUI FromCount
		{
			[Token(Token = "0x6002352")]
			[Address(RVA = "0x74A6", Offset = "0x74A6", VA = "0x74A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068E")]
		public TextMeshProUGUI ToCount
		{
			[Token(Token = "0x6002353")]
			[Address(RVA = "0x74A7", Offset = "0x74A7", VA = "0x74A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700068F")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6002354")]
			[Address(RVA = "0x74A8", Offset = "0x74A8", VA = "0x74A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000690")]
		public MetaFiltersView MetaFiltersView
		{
			[Token(Token = "0x6002355")]
			[Address(RVA = "0x74A9", Offset = "0x74A9", VA = "0x74A9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000691")]
		public GameRawImage Icon
		{
			[Token(Token = "0x6002356")]
			[Address(RVA = "0x74AA", Offset = "0x74AA", VA = "0x74AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000692")]
		public RectTransform ExchangeMessage
		{
			[Token(Token = "0x6002357")]
			[Address(RVA = "0x74AB", Offset = "0x74AB", VA = "0x74AB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000693")]
		public GameObject Description
		{
			[Token(Token = "0x6002358")]
			[Address(RVA = "0x74AC", Offset = "0x74AC", VA = "0x74AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x74AD", Offset = "0x74AD", VA = "0x74AD")]
		public void Init()
		{
		}

		// Token: 0x17000694 RID: 1684
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000694")]
		public PortalsModel Model
		{
			[Token(Token = "0x600235A")]
			[Address(RVA = "0x74AE", Offset = "0x74AE", VA = "0x74AE")]
			set
			{
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x74AF", Offset = "0x74AF", VA = "0x74AF")]
		private void StopCurrentCoroutine()
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x74B0", Offset = "0x74B0", VA = "0x74B0")]
		public void PopulateGoods(List<ShopItemData> items)
		{
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x74B1", Offset = "0x74B1", VA = "0x74B1")]
		private IEnumerator DisplayCurrentBackTime()
		{
			return null;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x74B2", Offset = "0x74B2", VA = "0x74B2")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x74B3", Offset = "0x74B3", VA = "0x74B3")]
		public PortalsShopView()
		{
		}

		// Token: 0x04001368 RID: 4968
		[Token(Token = "0x4001368")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PortalsShopItemView _itemViewPrefab;

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _shopContentContainer;

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Sprite> _markerSprites;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400136B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _exchangeMessage;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _fromCount;

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _toCount;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _description;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0x3C")]
		private PortalsModel _model;

		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4001374")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _displayBackTimeCoroutine;
	}
}
