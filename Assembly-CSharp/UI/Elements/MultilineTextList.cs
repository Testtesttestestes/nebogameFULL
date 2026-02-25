using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class MultilineTextList : MonoBehaviour
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x5FD7", Offset = "0x5FD7", VA = "0x5FD7")]
		public void ChangeLine(int lineIndex, string text, Color color)
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x5FD8", Offset = "0x5FD8", VA = "0x5FD8")]
		public void ChangeLine(int lineIndex, string text)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x5FD9", Offset = "0x5FD9", VA = "0x5FD9")]
		public void SetLineActive(int lineIndex, bool enable)
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x5FDA", Offset = "0x5FDA", VA = "0x5FDA")]
		public MultilineTextList()
		{
		}

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<TextMeshProUGUI> _instances;
	}
}
