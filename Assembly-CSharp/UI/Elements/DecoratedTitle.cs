using System;
using System.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Elements
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	[ExecuteAlways]
	public class DecoratedTitle : UIBehaviour
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x5FCB", Offset = "0x5FCB", VA = "0x5FCB")]
		private IEnumerator Rebuild()
		{
			return null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x5FCC", Offset = "0x5FCC", VA = "0x5FCC")]
		public void SetText(string text)
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x5FCD", Offset = "0x5FCD", VA = "0x5FCD", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x5FCE", Offset = "0x5FCE", VA = "0x5FCE", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x5FCF", Offset = "0x5FCF", VA = "0x5FCF")]
		protected void SetDirty()
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x5FD0", Offset = "0x5FD0", VA = "0x5FD0")]
		public DecoratedTitle()
		{
		}

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _leftDecorator;

		// Token: 0x04000642 RID: 1602
		[Token(Token = "0x4000642")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04000643 RID: 1603
		[Token(Token = "0x4000643")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _rightDecorator;

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[FieldOffset(Offset = "0x20")]
		public float spacing;
	}
}
