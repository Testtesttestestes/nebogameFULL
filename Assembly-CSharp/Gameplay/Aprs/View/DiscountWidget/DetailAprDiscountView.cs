using System;
using AssetContent;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Aprs.View.DiscountWidget
{
	// Token: 0x02000D5D RID: 3421
	[Token(Token = "0x2000D5D")]
	public class DetailAprDiscountView : MonoBehaviour, IAprDiscountWidget
	{
		// Token: 0x060053D0 RID: 21456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0xA18D", Offset = "0xA18D", VA = "0xA18D", Slot = "4")]
		public void SetData(IAprDataDiscountProvider data)
		{
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0xA18E", Offset = "0xA18E", VA = "0xA18E")]
		public DetailAprDiscountView()
		{
		}

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _saleWidgetText;
	}
}
