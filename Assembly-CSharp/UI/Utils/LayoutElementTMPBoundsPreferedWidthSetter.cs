using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Utils
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	[RequireComponent(typeof(LayoutElement))]
	public class LayoutElementTMPBoundsPreferedWidthSetter : MonoBehaviour
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x5C76", Offset = "0x5C76", VA = "0x5C76")]
		private void Start()
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x5C77", Offset = "0x5C77", VA = "0x5C77")]
		private void TextFiledOnOnPreRenderText(TMP_TextInfo info)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x5C78", Offset = "0x5C78", VA = "0x5C78")]
		public LayoutElementTMPBoundsPreferedWidthSetter()
		{
		}

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform _textFieldRectTransform;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x14")]
		private TextMeshProUGUI _textFiled;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x18")]
		private LayoutElement _layoutElement;
	}
}
