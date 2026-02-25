using System;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations.VO.Monster;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class IslandMonsterToolTipView : BaseToolTip<AbstractMonsterToolTipVO>
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x5D13", Offset = "0x5D13", VA = "0x5D13", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x5D14", Offset = "0x5D14", VA = "0x5D14")]
		public IslandMonsterToolTipView()
		{
		}

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/IslandMonsterToolTipView";

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _subDescription;
	}
}
