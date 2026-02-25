using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class TextToolTipView : BaseToolTip<string>
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x5D1C", Offset = "0x5D1C", VA = "0x5D1C", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x5D1D", Offset = "0x5D1D", VA = "0x5D1D")]
		public TextToolTipView()
		{
		}

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _textField;
	}
}
