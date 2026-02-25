using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.ProgressBars
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	public class ProgressBarLiquidWithEdge : ProgressBarWithText
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x6060", Offset = "0x6060", VA = "0x6060", Slot = "4")]
		protected override void OnValidateSafety()
		{
		}

		// Token: 0x170001C6 RID: 454
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public override float Value
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x6061", Offset = "0x6061", VA = "0x6061", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x6062", Offset = "0x6062", VA = "0x6062")]
		public ProgressBarLiquidWithEdge()
		{
		}

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _value;

		// Token: 0x040006B7 RID: 1719
		[Token(Token = "0x40006B7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Scrollbar _fillScrollbar;
	}
}
