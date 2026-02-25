using System;
using Il2CppDummyDll;
using UI.Requirements;
using UI.Rewards;
using UI.ToolTip.Implementations.View.Parts;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public class MedalToolTipView : BaseToolTip<MedalToolTipVO>
	{
		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x5D17", Offset = "0x5D17", VA = "0x5D17", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x5D18", Offset = "0x5D18", VA = "0x5D18")]
		private string FormatDuration(float msToSec)
		{
			return null;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x5D19", Offset = "0x5D19", VA = "0x5D19")]
		public MedalToolTipView()
		{
		}

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/MedalToolTipView";

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MedalViewWhitTitle _medalView;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;
	}
}
