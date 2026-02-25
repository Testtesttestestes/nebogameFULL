using System;
using Core.Data.Balance;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UnityEngine;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	public class SpellDescriptionGroup : MonoBehaviour
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026E")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001089")]
			[Address(RVA = "0x6286", Offset = "0x6286", VA = "0x6286")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x6287", Offset = "0x6287", VA = "0x6287")]
		public void Init(SpellDic spellDic, SpellLevelDic spellLevelDic, Money cost, long manaPrice, IBalanceSource balance)
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x6288", Offset = "0x6288", VA = "0x6288")]
		public SpellDescriptionGroup()
		{
		}

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;
	}
}
