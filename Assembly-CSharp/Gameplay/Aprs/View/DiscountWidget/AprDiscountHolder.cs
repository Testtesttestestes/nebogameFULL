using System;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5C RID: 3420
	[Token(Token = "0x2000D5C")]
	public class AprDiscountHolder : MonoBehaviour, IAprDiscountWidget
	{
		// Token: 0x060053CE RID: 21454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0xA18B", Offset = "0xA18B", VA = "0xA18B", Slot = "4")]
		public void SetData(IAprDataDiscountProvider data)
		{
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0xA18C", Offset = "0xA18C", VA = "0xA18C")]
		public AprDiscountHolder()
		{
		}

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DetailAprDiscountView _discountView;
	}
}
