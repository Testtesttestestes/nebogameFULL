using System;
using System.Collections.Generic;
using Core.Data.Balance;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using UnityEngine;
using Utils.Cache;

namespace UI.Price
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	public class Price : MonoBehaviour
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00003CC0 File Offset: 0x00001EC0
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		public Price.PriceMode Mode
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x5EDC", Offset = "0x5EDC", VA = "0x5EDC")]
			get
			{
				return Price.PriceMode.Default;
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x5EDD", Offset = "0x5EDD", VA = "0x5EDD")]
			set
			{
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x5EDE", Offset = "0x5EDE", VA = "0x5EDE", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x5EDF", Offset = "0x5EDF", VA = "0x5EDF")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x5EE0", Offset = "0x5EE0", VA = "0x5EE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x5EE1", Offset = "0x5EE1", VA = "0x5EE1")]
		private void OnDisable()
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x5EE2", Offset = "0x5EE2", VA = "0x5EE2")]
		public void SetColor(in Color32 color)
		{
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x5EE3", Offset = "0x5EE3", VA = "0x5EE3")]
		public void Init(IBalanceSource source, Money price)
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public IBalanceSource Source
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x5EE4", Offset = "0x5EE4", VA = "0x5EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x5EE5", Offset = "0x5EE5", VA = "0x5EE5")]
			private set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		public Money PriceValue
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x5EE6", Offset = "0x5EE6", VA = "0x5EE6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x5EE7", Offset = "0x5EE7", VA = "0x5EE7")]
			private set
			{
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x5EE8", Offset = "0x5EE8", VA = "0x5EE8")]
		private void StartListenEvents(IBalanceSource source)
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x5EE9", Offset = "0x5EE9", VA = "0x5EE9")]
		private void StopListenEvents(IBalanceSource source)
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x5EEA", Offset = "0x5EEA", VA = "0x5EEA")]
		private void HandleBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x5EEB", Offset = "0x5EEB", VA = "0x5EEB")]
		private void HandleSourceChanged(IBalanceSource fromSource, IBalanceSource toSource)
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x5EEC", Offset = "0x5EEC", VA = "0x5EEC", Slot = "5")]
		protected virtual void HandleResourceSetChanged()
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x5EED", Offset = "0x5EED", VA = "0x5EED")]
		private string PriceItemTdGetAssetIdHandler(Protocol.Consts.Resources resId)
		{
			return null;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x5EEE", Offset = "0x5EEE", VA = "0x5EEE")]
		private string PriceItemTdGetAssetIdHandler(Money.MoneyType moneyType)
		{
			return null;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x5EEF", Offset = "0x5EEF", VA = "0x5EEF", Slot = "6")]
		protected virtual List<Money> GetGameResources()
		{
			return null;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x5EF0", Offset = "0x5EF0", VA = "0x5EF0")]
		private void ResetPoolObjectDelegate(PriceItemRenderer pooledObject)
		{
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x5EF1", Offset = "0x5EF1", VA = "0x5EF1")]
		private void HandleMoneyValues(ResourceSet balance)
		{
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x5EF2", Offset = "0x5EF2", VA = "0x5EF2")]
		private bool IsEnoughMoney(PriceItemRenderer view, ResourceSet balance)
		{
			return default(bool);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x5EF3", Offset = "0x5EF3", VA = "0x5EF3")]
		private void HidePrices()
		{
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x5EF4", Offset = "0x5EF4", VA = "0x5EF4")]
		public Price()
		{
		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Transform _container;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected PriceItemRenderer _priceItemPrefab;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Color32 _currentTextColor;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected bool _truncatePrice;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Price.PriceMode _mode;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly IReadOnlyList<Money.MoneyType> MoneyTypesDefaultSequence;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x24")]
		private IBalanceSource _source;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x28")]
		protected Money _priceValue;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<PriceItemRenderer> _currentPrices;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x30")]
		private GameObjectPool<PriceItemRenderer> _priceItemRenderPool;

		// Token: 0x020001BC RID: 444
		[Token(Token = "0x20001BC")]
		[Serializable]
		public enum PriceMode
		{
			// Token: 0x04000586 RID: 1414
			[Token(Token = "0x4000586")]
			Default,
			// Token: 0x04000587 RID: 1415
			[Token(Token = "0x4000587")]
			ThemeDuel
		}
	}
}
