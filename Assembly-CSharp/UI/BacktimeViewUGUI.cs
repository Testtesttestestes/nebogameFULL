using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public class BacktimeViewUGUI : AbstractBacktimeView
	{
		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x5BCD", Offset = "0x5BCD", VA = "0x5BCD", Slot = "4")]
		protected override void RenderValue(string text)
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x5BCE", Offset = "0x5BCE", VA = "0x5BCE")]
		public BacktimeViewUGUI()
		{
		}

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}
}
