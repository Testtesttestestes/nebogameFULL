using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public class TitleWhitListToolTipView : BaseToolTip<TitleWhitListToolTipView.TitleWhitListToolTipData>
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x5D1E", Offset = "0x5D1E", VA = "0x5D1E", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x5D1F", Offset = "0x5D1F", VA = "0x5D1F")]
		public TitleWhitListToolTipView()
		{
		}

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/TitleWhitListToolTipView";

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _rowsContainer;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _rowPrefab;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _notEvenSprite;

		// Token: 0x0200014C RID: 332
		[Token(Token = "0x200014C")]
		public class TitleWhitListToolTipData
		{
			// Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x5D20", Offset = "0x5D20", VA = "0x5D20")]
			public TitleWhitListToolTipData()
			{
			}

			// Token: 0x040003D4 RID: 980
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x8")]
			public string Title;

			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0xC")]
			public string[] Rows;
		}
	}
}
