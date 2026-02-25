using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2000AF9")]
	public class ChatMiniMessageRenderer : MonoBehaviour
	{
		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043C1 RID: 17345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5C")]
		public string Text
		{
			[Token(Token = "0x60043C0")]
			[Address(RVA = "0x9273", Offset = "0x9273", VA = "0x9273")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043C1")]
			[Address(RVA = "0x9274", Offset = "0x9274", VA = "0x9274")]
			set
			{
			}
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043C2")]
		[Address(RVA = "0x9275", Offset = "0x9275", VA = "0x9275")]
		public ChatMiniMessageRenderer()
		{
		}

		// Token: 0x04002554 RID: 9556
		[Token(Token = "0x4002554")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;
	}
}
