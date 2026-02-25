using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BF5 RID: 3061
	[Token(Token = "0x2000BF5")]
	[Serializable]
	public class PayloadOption
	{
		// Token: 0x06004B0D RID: 19213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x996A", Offset = "0x996A", VA = "0x996A")]
		public PayloadOption()
		{
		}

		// Token: 0x040028D6 RID: 10454
		[Token(Token = "0x40028D6")]
		[FieldOffset(Offset = "0x8")]
		public ulong option_id;

		// Token: 0x040028D7 RID: 10455
		[Token(Token = "0x40028D7")]
		[FieldOffset(Offset = "0x10")]
		public string timestamp_value;

		// Token: 0x040028D8 RID: 10456
		[Token(Token = "0x40028D8")]
		[FieldOffset(Offset = "0x14")]
		public string signature;
	}
}
