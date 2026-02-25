using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.ConfirmationMessage
{
	// Token: 0x02000258 RID: 600
	[Token(Token = "0x2000258")]
	public class ConfirmationMessageRenderer : MonoBehaviour
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x6103", Offset = "0x6103", VA = "0x6103")]
		public void Show(string message, float duration)
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x6104", Offset = "0x6104", VA = "0x6104")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x6105", Offset = "0x6105", VA = "0x6105")]
		public ConfirmationMessageRenderer()
		{
		}

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _message;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x18")]
		private TweenContainer _tweenContainer;
	}
}
