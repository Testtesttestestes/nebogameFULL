using System;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5F RID: 3423
	[Token(Token = "0x2000D5F")]
	public class ShortAprDiscountView : MonoBehaviour, IAprDiscountWidget
	{
		// Token: 0x060053D3 RID: 21459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0xA18F", Offset = "0xA18F", VA = "0xA18F", Slot = "4")]
		public void SetData(IAprDataDiscountProvider data)
		{
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0xA190", Offset = "0xA190", VA = "0xA190")]
		public ShortAprDiscountView()
		{
		}

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _view;
	}
}
