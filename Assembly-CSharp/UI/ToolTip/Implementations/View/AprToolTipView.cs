using System;
using Il2CppDummyDll;
using UI.Requirements;
using UI.Rewards;
using UI.ToolTip.Implementations.View.Parts;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	public class AprToolTipView : BaseToolTip<AprToolTipVO>
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x5D06", Offset = "0x5D06", VA = "0x5D06", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x5D07", Offset = "0x5D07", VA = "0x5D07")]
		private string FormatDuration(float msToSec)
		{
			return null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x5D08", Offset = "0x5D08", VA = "0x5D08")]
		public AprToolTipView()
		{
		}

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/AprToolTipView";

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AprViewWhitTitle _aprView;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;
	}
}
