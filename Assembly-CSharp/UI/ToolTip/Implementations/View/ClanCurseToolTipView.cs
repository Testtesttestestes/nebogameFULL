using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public class ClanCurseToolTipView : BaseToolTip<ClanRestrictionDic>
	{
		// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x5D09", Offset = "0x5D09", VA = "0x5D09", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x5D0A", Offset = "0x5D0A", VA = "0x5D0A")]
		public ClanCurseToolTipView()
		{
		}

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanCurseToolTipView";

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameImage _icon;
	}
}
