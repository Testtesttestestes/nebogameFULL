using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.ToolTip.Controller.Android
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public class ToolTipController : BaseToolTipController
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x5D80", Offset = "0x5D80", VA = "0x5D80", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x5D81", Offset = "0x5D81", VA = "0x5D81")]
		public ToolTipController(Canvas canvas, RectTransform layer, Vector2 padding)
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x5D82", Offset = "0x5D82", VA = "0x5D82", Slot = "10")]
		public override void Show(IToolTipSource source)
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x5D83", Offset = "0x5D83", VA = "0x5D83", Slot = "11")]
		public override void Hide(IToolTipSource source)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x5D84", Offset = "0x5D84", VA = "0x5D84")]
		private RectTransform GetAwaitAnimation()
		{
			return null;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x5D85", Offset = "0x5D85", VA = "0x5D85")]
		private void ShowAwait()
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x5D86", Offset = "0x5D86", VA = "0x5D86")]
		private void HideAwait()
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x5D87", Offset = "0x5D87", VA = "0x5D87")]
		public RectTransform GetOverlap()
		{
			return null;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x5D88", Offset = "0x5D88", VA = "0x5D88")]
		private void HandleOverlapPointerDownEvent(PointerEventData pointerEventData)
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x5D89", Offset = "0x5D89", VA = "0x5D89")]
		private void ShowOverlap()
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x5D8A", Offset = "0x5D8A", VA = "0x5D8A")]
		private void HideOverlap()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x5D8B", Offset = "0x5D8B", VA = "0x5D8B", Slot = "12")]
		protected override void GetPointerPosition(out Vector3 position)
		{
		}

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		public const string AWAIT_ANIMATION_RES_ID = "Prefabs/UI/ToolTip/AwaitCircle";

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		public const string TOOL_TIP_OVERLAP_NAME = "ToolTip Overlap";

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<IToolTipSource> _previousSources;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x34")]
		private RectTransform _awaitAnimation;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _overlap;
	}
}
