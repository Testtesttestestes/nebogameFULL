using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.ProgressBars
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	public class Filler : MonoBehaviour
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00004068 File Offset: 0x00002268
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public float value
		{
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x6051", Offset = "0x6051", VA = "0x6051")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x6052", Offset = "0x6052", VA = "0x6052")]
			set
			{
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x6053", Offset = "0x6053", VA = "0x6053", Slot = "4")]
		public virtual void UpdateLayout()
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x6054", Offset = "0x6054", VA = "0x6054")]
		public Filler()
		{
		}

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected RectTransform _rectTransform;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Scrollbar _scrollbar;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x18")]
		public float overflowSize;
	}
}
