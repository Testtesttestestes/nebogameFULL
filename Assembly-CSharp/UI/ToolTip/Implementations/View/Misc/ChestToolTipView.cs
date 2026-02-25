using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Misc
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public class ChestToolTipView : BaseToolTip<PaymentBonusModel>
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x5D3A", Offset = "0x5D3A", VA = "0x5D3A", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x5D3B", Offset = "0x5D3B", VA = "0x5D3B")]
		public ChestToolTipView()
		{
		}

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ChestToolTipView";

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardsRender _rewards;
	}
}
