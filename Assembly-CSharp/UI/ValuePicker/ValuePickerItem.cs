using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ValuePicker
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	public class ValuePickerItem : MonoBehaviour
	{
		// Token: 0x1700011E RID: 286
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		public string Text
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x5C5E", Offset = "0x5C5E", VA = "0x5C5E")]
			set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011F")]
		public bool Selected
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x5C5F", Offset = "0x5C5F", VA = "0x5C5F")]
			set
			{
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x5C60", Offset = "0x5C60", VA = "0x5C60")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x5C61", Offset = "0x5C61", VA = "0x5C61")]
		public ValuePickerItem()
		{
		}

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _colorSelected;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _color;
	}
}
