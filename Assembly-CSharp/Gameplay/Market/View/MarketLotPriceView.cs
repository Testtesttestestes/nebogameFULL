using System;
using Core.Data;
using Gameplay.Bank.View;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UnityEngine;

namespace Gameplay.Market.View
{
	// Token: 0x0200061E RID: 1566
	[Token(Token = "0x200061E")]
	public class MarketLotPriceView : MonoBehaviour
	{
		// Token: 0x06002602 RID: 9730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x7740", Offset = "0x7740", VA = "0x7740")]
		public void UpdatePrice(MarketLotData data, UserData user)
		{
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x7741", Offset = "0x7741", VA = "0x7741")]
		public MarketLotPriceView()
		{
		}

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Price _price;

		// Token: 0x040014C0 RID: 5312
		[Token(Token = "0x40014C0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _extPrice;

		// Token: 0x040014C1 RID: 5313
		[Token(Token = "0x40014C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VipPointsView _vipPointsView;
	}
}
