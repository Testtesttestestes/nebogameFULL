using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	public class ClanIsleGolemToolTipView : BaseToolTip<ClanBuildingData>
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x5D0B", Offset = "0x5D0B", VA = "0x5D0B", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x5D0C", Offset = "0x5D0C", VA = "0x5D0C")]
		public ClanIsleGolemToolTipView()
		{
		}

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanIsleGolemToolTipView";

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;
	}
}
