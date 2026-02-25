using System;
using AssetContent;
using Core.Data;
using Gameplay.Inventory.View;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x0200061B RID: 1563
	[Token(Token = "0x200061B")]
	public class MarketLotInfoView : MonoBehaviour
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700071F")]
		public Button BuyButton
		{
			[Token(Token = "0x60025ED")]
			[Address(RVA = "0x772B", Offset = "0x772B", VA = "0x772B")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x772C", Offset = "0x772C", VA = "0x772C")]
		public void Init()
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x772D", Offset = "0x772D", VA = "0x772D")]
		public void UpdateView(MarketLotData data, UserData user)
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x772E", Offset = "0x772E", VA = "0x772E")]
		public MarketLotInfoView()
		{
		}

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ButtonWithCost _buyButton;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MarketLotPriceView _priceView;

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _greenSprite;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _blueSprite;

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _buttonBg;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameImage _ribbon;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _buttonText;
	}
}
