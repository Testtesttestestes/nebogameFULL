using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.ProgressBars
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	public class MaskFiller : Filler
	{
		// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x6055", Offset = "0x6055", VA = "0x6055", Slot = "4")]
		public override void UpdateLayout()
		{
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D73")]
		[Address(RVA = "0x6056", Offset = "0x6056", VA = "0x6056")]
		public MaskFiller()
		{
		}

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _mask;
	}
}
