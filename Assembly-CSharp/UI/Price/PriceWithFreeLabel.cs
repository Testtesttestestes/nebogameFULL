using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Price
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	public class PriceWithFreeLabel : Price
	{
		// Token: 0x06000BFF RID: 3071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x5F12", Offset = "0x5F12", VA = "0x5F12", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x5F13", Offset = "0x5F13", VA = "0x5F13", Slot = "5")]
		protected override void HandleResourceSetChanged()
		{
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x5F14", Offset = "0x5F14", VA = "0x5F14")]
		public PriceWithFreeLabel()
		{
		}

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _freeLabel;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _showFreeLabel;
	}
}
