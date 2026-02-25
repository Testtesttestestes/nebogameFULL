using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Scroll
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	public class ScrollWithButtonsVertical : ScrollWithButtons
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x17000176")]
		protected override float AnchoredPositionAxis
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x5E43", Offset = "0x5E43", VA = "0x5E43", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x5E44", Offset = "0x5E44", VA = "0x5E44", Slot = "6")]
		protected override Tweener DoMove(float scrollPosNormalized)
		{
			return null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x5E45", Offset = "0x5E45", VA = "0x5E45", Slot = "7")]
		protected override float GetRectAxis(Rect rect)
		{
			return 0f;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x5E46", Offset = "0x5E46", VA = "0x5E46")]
		public ScrollWithButtonsVertical()
		{
		}
	}
}
