using System;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Chat.View.Smiles
{
	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2000AF7")]
	public class SmileItemView : MonoBehaviour
	{
		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060043AE RID: 17326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D57")]
		public TextMeshProUGUI TextField
		{
			[Token(Token = "0x60043AE")]
			[Address(RVA = "0x9262", Offset = "0x9262", VA = "0x9262")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060043AF RID: 17327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D58")]
		public MonoPointerClickHandler ClickHandler
		{
			[Token(Token = "0x60043AF")]
			[Address(RVA = "0x9263", Offset = "0x9263", VA = "0x9263")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043B1 RID: 17329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D59")]
		public ChatSmileDic SmileDic
		{
			[Token(Token = "0x60043B0")]
			[Address(RVA = "0x9264", Offset = "0x9264", VA = "0x9264")]
			get
			{
				return null;
			}
			[Token(Token = "0x60043B1")]
			[Address(RVA = "0x9265", Offset = "0x9265", VA = "0x9265")]
			set
			{
			}
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B2")]
		[Address(RVA = "0x1BAC", Offset = "0x1BAC", VA = "0x1BAC")]
		private void HandleSmileDicChanged()
		{
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043B3")]
		[Address(RVA = "0x9266", Offset = "0x9266", VA = "0x9266")]
		public SmileItemView()
		{
		}

		// Token: 0x04002548 RID: 9544
		[Token(Token = "0x4002548")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x0400254A RID: 9546
		[Token(Token = "0x400254A")]
		[FieldOffset(Offset = "0x18")]
		private ChatSmileDic _smileDic;
	}
}
