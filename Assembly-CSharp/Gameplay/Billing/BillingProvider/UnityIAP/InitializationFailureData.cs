using System;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	public class InitializationFailureData
	{
		// Token: 0x06004B6F RID: 19311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x99BE", Offset = "0x99BE", VA = "0x99BE")]
		public InitializationFailureData(InitializationFailureReason reason, string details)
		{
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x99BF", Offset = "0x99BF", VA = "0x99BF", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x8")]
		public readonly InitializationFailureReason Reason;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Details;
	}
}
