using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public class BacktimeView : AbstractBacktimeView
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FC")]
		public TextMeshPro Text
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x5BCA", Offset = "0x5BCA", VA = "0x5BCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x5BCB", Offset = "0x5BCB", VA = "0x5BCB", Slot = "4")]
		protected override void RenderValue(string text)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x5BCC", Offset = "0x5BCC", VA = "0x5BCC")]
		public BacktimeView()
		{
		}

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshPro _text;
	}
}
