using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x02000426 RID: 1062
	[Token(Token = "0x2000426")]
	public class MessageBubbleView : MonoBehaviourWithStates<MessageBubbleView.State>
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x6ACB", Offset = "0x6ACB", VA = "0x6ACB")]
		public void SetText(string text)
		{
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x6ACC", Offset = "0x6ACC", VA = "0x6ACC")]
		public void SetPosition(Vector2 normalizedPosition)
		{
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x6ACD", Offset = "0x6ACD", VA = "0x6ACD")]
		public void Init(MessageBubbleView.MessageBubbleViewArgs args)
		{
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x6ACE", Offset = "0x6ACE", VA = "0x6ACE")]
		public MessageBubbleView()
		{
		}

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _bubbleRectTransform;

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _tailResizer;

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _minHeight;

		// Token: 0x02000427 RID: 1063
		[Token(Token = "0x2000427")]
		public enum State
		{
			// Token: 0x04000D4C RID: 3404
			[Token(Token = "0x4000D4C")]
			DEFAULT,
			// Token: 0x04000D4D RID: 3405
			[Token(Token = "0x4000D4D")]
			LEFT,
			// Token: 0x04000D4E RID: 3406
			[Token(Token = "0x4000D4E")]
			RIGHT
		}

		// Token: 0x02000428 RID: 1064
		[Token(Token = "0x2000428")]
		[Serializable]
		public class MessageBubbleViewArgs
		{
			// Token: 0x06001930 RID: 6448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001930")]
			[Address(RVA = "0x6ACF", Offset = "0x6ACF", VA = "0x6ACF")]
			public MessageBubbleViewArgs()
			{
			}

			// Token: 0x04000D4F RID: 3407
			[Token(Token = "0x4000D4F")]
			[FieldOffset(Offset = "0x8")]
			public MessageBubbleView.State State;

			// Token: 0x04000D50 RID: 3408
			[Token(Token = "0x4000D50")]
			[FieldOffset(Offset = "0xC")]
			public string Text;

			// Token: 0x04000D51 RID: 3409
			[Token(Token = "0x4000D51")]
			[FieldOffset(Offset = "0x10")]
			public float NormalizedX;

			// Token: 0x04000D52 RID: 3410
			[Token(Token = "0x4000D52")]
			[FieldOffset(Offset = "0x14")]
			public float NormalizedY;

			// Token: 0x04000D53 RID: 3411
			[Token(Token = "0x4000D53")]
			[FieldOffset(Offset = "0x18")]
			public Vector3? Size;
		}
	}
}
