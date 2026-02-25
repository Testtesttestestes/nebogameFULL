using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	public class DiscountListElement : GenericListElement<DiscountListElement.DiscountListElementArgs>
	{
		// Token: 0x060033CA RID: 13258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x8402", Offset = "0x8402", VA = "0x8402", Slot = "4")]
		protected override void OnInit(DiscountListElement.DiscountListElementArgs args)
		{
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x8403", Offset = "0x8403", VA = "0x8403")]
		private void ButtonClickedEventHandler(DiscountListElement.DiscountListElementArgs args)
		{
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x8404", Offset = "0x8404", VA = "0x8404")]
		public DiscountListElement()
		{
		}

		// Token: 0x04001C33 RID: 7219
		[Token(Token = "0x4001C33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _bg;

		// Token: 0x04001C34 RID: 7220
		[Token(Token = "0x4001C34")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001C35 RID: 7221
		[Token(Token = "0x4001C35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001C36 RID: 7222
		[Token(Token = "0x4001C36")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BacktimeViewUGUI _backTime;

		// Token: 0x02000896 RID: 2198
		[Token(Token = "0x2000896")]
		public class DiscountListElementArgs : GenericListElementArgs
		{
			// Token: 0x060033CD RID: 13261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60033CD")]
			[Address(RVA = "0x8405", Offset = "0x8405", VA = "0x8405")]
			public DiscountListElementArgs()
			{
			}

			// Token: 0x04001C37 RID: 7223
			[Token(Token = "0x4001C37")]
			[FieldOffset(Offset = "0xC")]
			public DiscountData DiscountData;
		}
	}
}
