using System;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class MarkerTooltipView : BaseToolTip<AprMarkerToolTipVO>
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x5D15", Offset = "0x5D15", VA = "0x5D15", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x5D16", Offset = "0x5D16", VA = "0x5D16")]
		public MarkerTooltipView()
		{
		}

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/MarkerTooltipView";

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewards;
	}
}
