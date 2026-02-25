using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x55D2", Offset = "0x55D2", VA = "0x55D2", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x55D3", Offset = "0x55D3", VA = "0x55D3", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x55D4", Offset = "0x55D4", VA = "0x55D4", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x55D5", Offset = "0x55D5", VA = "0x55D5", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000008")]
		protected bool IsCenterAlign
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x55D6", Offset = "0x55D6", VA = "0x55D6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x17000009")]
		protected bool IsRightAlign
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x55D7", Offset = "0x55D7", VA = "0x55D7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x1700000A")]
		protected bool IsMiddleAlign
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x55D8", Offset = "0x55D8", VA = "0x55D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x1700000B")]
		protected bool IsLowerAlign
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x55D9", Offset = "0x55D9", VA = "0x55D9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x55DA", Offset = "0x55DA", VA = "0x55DA")]
		public float SetLayout(float width, int axis, bool layoutInput)
		{
			return 0f;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x55DB", Offset = "0x55DB", VA = "0x55DB")]
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			return 0f;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x55DC", Offset = "0x55DC", VA = "0x55DC")]
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x55DD", Offset = "0x55DD", VA = "0x55DD")]
		public float GetGreatestMinimumChildWidth()
		{
			return 0f;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x55DE", Offset = "0x55DE", VA = "0x55DE")]
		public FlowLayoutGroup()
		{
		}

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x3C")]
		public float SpacingX;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x40")]
		public float SpacingY;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x44")]
		public bool ExpandHorizontalSpacing;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x45")]
		public bool ChildForceExpandWidth;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x46")]
		public bool ChildForceExpandHeight;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x48")]
		private float _layoutHeight;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x4C")]
		private readonly IList<RectTransform> _rowList;
	}
}
