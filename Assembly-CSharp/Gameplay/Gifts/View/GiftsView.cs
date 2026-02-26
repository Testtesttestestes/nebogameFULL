using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Gifts.View
{
	// Token: 0x02000709 RID: 1801
	[Token(Token = "0x2000709")]
	public class GiftsView : MonoBehaviour
	{
		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000830")]
		public RectTransform Content
		{
			[Token(Token = "0x6002B1A")]
			[Address(RVA = "0x7BB5", Offset = "0x7BB5", VA = "0x7BB5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002B1B RID: 11035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000831")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6002B1B")]
			[Address(RVA = "0x7BB6", Offset = "0x7BB6", VA = "0x7BB6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000832")]
		public GiftView GiftUIPrefab
		{
			[Token(Token = "0x6002B1C")]
			[Address(RVA = "0x7BB7", Offset = "0x7BB7", VA = "0x7BB7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x7BB8", Offset = "0x7BB8", VA = "0x7BB8")]
		public GiftsView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Gifts_View_GiftsView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a220 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12627);
		    DAT_ram_00a5a220 = '\x01';
		  }
		  return StringLiteral_12627;
		}
		*/

		}

		// Token: 0x0400178C RID: 6028
		[Token(Token = "0x400178C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GiftView _giftUIPrefab;

		// Token: 0x0400178D RID: 6029
		[Token(Token = "0x400178D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400178E RID: 6030
		[Token(Token = "0x400178E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _annotation;
	}
}
