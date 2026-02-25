using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Utils;

namespace UI.Scroll
{
	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	public class ScrollWithButtons : MonoBehaviour
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x17000173")]
		protected virtual float AnchoredPositionAxis
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x5E2F", Offset = "0x5E2F", VA = "0x5E2F", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x5E30", Offset = "0x5E30", VA = "0x5E30")]
		private void Awake()
		{
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x5E31", Offset = "0x5E31", VA = "0x5E31")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x5E32", Offset = "0x5E32", VA = "0x5E32", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x5E33", Offset = "0x5E33", VA = "0x5E33")]
		private IEnumerator ValidateScrollButtons()
		{
			return null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x5E34", Offset = "0x5E34", VA = "0x5E34")]
		public void ScrollToEnd()
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x5E35", Offset = "0x5E35", VA = "0x5E35")]
		public void ScrollToBeginning()
		{
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x5E36", Offset = "0x5E36", VA = "0x5E36")]
		private void Scroll(bool toEnd)
		{
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x5E37", Offset = "0x5E37", VA = "0x5E37", Slot = "6")]
		protected virtual Tweener DoMove(float scrollPosNormalized)
		{
			return null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x5E38", Offset = "0x5E38", VA = "0x5E38", Slot = "7")]
		protected virtual float GetRectAxis(Rect rect)
		{
			return 0f;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x5E39", Offset = "0x5E39", VA = "0x5E39")]
		public void Invalidate()
		{
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x5E3A", Offset = "0x5E3A", VA = "0x5E3A")]
		public ScrollWithButtons()
		{
		}

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected ScrollRect _scrollRect;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _viewport;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("_scrollLeftButton")]
		[SerializeField]
		protected Button _scrollToBeginningButton;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("_scrollRightButton")]
		[SerializeField]
		protected Button _scrollToEndButton;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x24")]
		protected RectTransform _viewportRectTransform;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x28")]
		protected RectTransform _containerRectTransform;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x2C")]
		private TweenContainer _tweenContainer;
	}
}
