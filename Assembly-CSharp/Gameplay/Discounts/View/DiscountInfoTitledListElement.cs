using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.RightPanel.TitledList;
using UnityEngine;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	public class DiscountInfoTitledListElement : BaseTitledListElement<DiscountInfoTitledListElementArgs>
	{
		// Token: 0x060033C8 RID: 13256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x8400", Offset = "0x8400", VA = "0x8400", Slot = "6")]
		protected override void OnInit(DiscountInfoTitledListElementArgs args)
		{
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C9")]
		[Address(RVA = "0x8401", Offset = "0x8401", VA = "0x8401")]
		public DiscountInfoTitledListElement()
		{
		}

		// Token: 0x04001C30 RID: 7216
		[Token(Token = "0x4001C30")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _value;

		// Token: 0x04001C31 RID: 7217
		[Token(Token = "0x4001C31")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x04001C32 RID: 7218
		[Token(Token = "0x4001C32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _backtimeRow;
	}
}
