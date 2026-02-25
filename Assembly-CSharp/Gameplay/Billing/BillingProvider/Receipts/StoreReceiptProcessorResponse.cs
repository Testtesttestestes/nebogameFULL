using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.Receipts
{
	// Token: 0x02000C15 RID: 3093
	[Token(Token = "0x2000C15")]
	public class StoreReceiptProcessorResponse
	{
		// Token: 0x06004BB1 RID: 19377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BB1")]
		[Address(RVA = "0x99F7", Offset = "0x99F7", VA = "0x99F7", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB2")]
		[Address(RVA = "0x99F8", Offset = "0x99F8", VA = "0x99F8")]
		public StoreReceiptProcessorResponse()
		{
		}

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x8")]
		public StoreReceiptProcessorResponse.Errors error_code;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0xC")]
		public string error_msg;

		// Token: 0x02000C16 RID: 3094
		[Token(Token = "0x2000C16")]
		public enum Errors
		{
			// Token: 0x04002922 RID: 10530
			[Token(Token = "0x4002922")]
			Success,
			// Token: 0x04002923 RID: 10531
			[Token(Token = "0x4002923")]
			Fail,
			// Token: 0x04002924 RID: 10532
			[Token(Token = "0x4002924")]
			Internal
		}
	}
}
