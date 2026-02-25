using System;
using AssetContent;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C3D RID: 3133
	[Token(Token = "0x2000C3D")]
	public class BankOptionResourceProfitView : MonoBehaviour
	{
		// Token: 0x06004C5A RID: 19546 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x9A9C", Offset = "0x9A9C", VA = "0x9A9C")]
		private Color GetBonusTextColor(Protocol.Consts.Resources resourceId)
		{
			return default(Color);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x1EF8", Offset = "0x1EF8", VA = "0x1EF8")]
		public void SetProfit(Money amount, double bonus)
		{
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x9A9D", Offset = "0x9A9D", VA = "0x9A9D")]
		public BankOptionResourceProfitView()
		{
		}

		// Token: 0x040029A7 RID: 10663
		[Token(Token = "0x40029A7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x040029A8 RID: 10664
		[Token(Token = "0x40029A8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _valueTextField;

		// Token: 0x040029A9 RID: 10665
		[Token(Token = "0x40029A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _bonusValueTextField;

		// Token: 0x040029AA RID: 10666
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ResourceColor[] _colors;
	}
}
