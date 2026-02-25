using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	public class ContentToScrollableContent : MonoBehaviour
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x5BE0", Offset = "0x5BE0", VA = "0x5BE0")]
		private void Awake()
		{
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x5BE1", Offset = "0x5BE1", VA = "0x5BE1")]
		private void Update()
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x5BE2", Offset = "0x5BE2", VA = "0x5BE2", Slot = "4")]
		protected virtual void ValidateVisibleScroll()
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x5BE3", Offset = "0x5BE3", VA = "0x5BE3")]
		public ContentToScrollableContent()
		{
		}

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _scrollView;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _scrollViewContent;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _maxHeight;
	}
}
