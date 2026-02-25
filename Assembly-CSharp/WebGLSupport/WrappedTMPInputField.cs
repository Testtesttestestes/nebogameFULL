using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using WebGLSupport.Detail;

namespace WebGLSupport
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	internal class WrappedTMPInputField : IInputField
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000048")]
		public bool ReadOnly
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x568F", Offset = "0x568F", VA = "0x568F", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public string text
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5690", Offset = "0x5690", VA = "0x5690", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5691", Offset = "0x5691", VA = "0x5691", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004A")]
		public string placeholder
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x5692", Offset = "0x5692", VA = "0x5692", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x1700004B")]
		public int fontSize
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x5693", Offset = "0x5693", VA = "0x5693", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700004C")]
		public ContentType contentType
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x5694", Offset = "0x5694", VA = "0x5694", Slot = "4")]
			get
			{
				return ContentType.Standard;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x1700004D")]
		public LineType lineType
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x5695", Offset = "0x5695", VA = "0x5695", Slot = "5")]
			get
			{
				return LineType.SingleLine;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x1700004E")]
		public int characterLimit
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x5696", Offset = "0x5696", VA = "0x5696", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x1700004F")]
		public int caretPosition
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x5697", Offset = "0x5697", VA = "0x5697", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000050")]
		public bool isFocused
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x5698", Offset = "0x5698", VA = "0x5698", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x5699", Offset = "0x5699", VA = "0x5699", Slot = "13")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x569A", Offset = "0x569A", VA = "0x569A", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x569B", Offset = "0x569B", VA = "0x569B", Slot = "15")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x569C", Offset = "0x569C", VA = "0x569C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x17000053")]
		public bool OnFocusSelectAll
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x569D", Offset = "0x569D", VA = "0x569D", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x569E", Offset = "0x569E", VA = "0x569E")]
		public WrappedTMPInputField(TMP_InputField input)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x569F", Offset = "0x569F", VA = "0x569F", Slot = "19")]
		public RectTransform RectTransform()
		{
			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x56A0", Offset = "0x56A0", VA = "0x56A0", Slot = "20")]
		public void ActivateInputField()
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x56A1", Offset = "0x56A1", VA = "0x56A1", Slot = "21")]
		public void DeactivateInputField()
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x56A2", Offset = "0x56A2", VA = "0x56A2", Slot = "22")]
		public void Rebuild()
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x56A3", Offset = "0x56A3", VA = "0x56A3")]
		private bool rectOverlaps(RectTransform rectTrans1, RectTransform rectTrans2)
		{
			return default(bool);
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x8")]
		private TMP_InputField input;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xC")]
		private RebuildChecker checker;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		private Coroutine delayedGraphicRebuild;
	}
}
