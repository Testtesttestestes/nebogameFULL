using System;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using UI.Rewards;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public class CollectionToolTipView : BaseToolTip<CollectionToolTipVO>
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x5D0F", Offset = "0x5D0F", VA = "0x5D0F", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x5D10", Offset = "0x5D10", VA = "0x5D10")]
		public CollectionToolTipView()
		{
		}

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/CollectionToolTipView";

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CollectionView _header;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewards;
	}
}
