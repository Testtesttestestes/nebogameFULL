using System;
using Il2CppDummyDll;
using UI.Requirements;
using UI.ToolTip.Implementations.VO.Monster;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class IslandBossMonsterToolTipView : BaseToolTip<IslandBossMonsterToolTipVO>
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x5D11", Offset = "0x5D11", VA = "0x5D11", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x5D12", Offset = "0x5D12", VA = "0x5D12")]
		public IslandBossMonsterToolTipView()
		{
		}

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/IslandBossMonsterToolTipView";

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private IslandMonsterToolTipView _monsterToolTipView;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;
	}
}
