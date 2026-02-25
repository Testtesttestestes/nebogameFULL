using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class TileAndScrollEntitieDescription : MonoBehaviour
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x5C46", Offset = "0x5C46", VA = "0x5C46")]
		private void Awake()
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x5C47", Offset = "0x5C47", VA = "0x5C47")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x5C48", Offset = "0x5C48", VA = "0x5C48")]
		private void TextFieldOnOnPreRenderText(TMP_TextInfo obj)
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x5C49", Offset = "0x5C49", VA = "0x5C49")]
		private void Update()
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x5C4A", Offset = "0x5C4A", VA = "0x5C4A", Slot = "4")]
		protected virtual void ValidateVisibleScroll()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x5C4B", Offset = "0x5C4B", VA = "0x5C4B")]
		public TileAndScrollEntitieDescription()
		{
		}

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _scrollView;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _scrollViewContent;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _maxHeight;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _rectTransform;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x24")]
		private bool _isTextChanged;
	}
}
