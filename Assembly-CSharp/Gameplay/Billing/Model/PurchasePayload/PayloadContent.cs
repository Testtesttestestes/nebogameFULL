using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BF4 RID: 3060
	[Token(Token = "0x2000BF4")]
	[Serializable]
	public class PayloadContent
	{
		// Token: 0x06004B0B RID: 19211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B0B")]
		[Address(RVA = "0x9968", Offset = "0x9968", VA = "0x9968")]
		public PayloadOption GetOption()
		{
			return null;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B0C")]
		[Address(RVA = "0x9969", Offset = "0x9969", VA = "0x9969")]
		public PayloadContent()
		{
		}

		// Token: 0x040028D5 RID: 10453
		[Token(Token = "0x40028D5")]
		[FieldOffset(Offset = "0x8")]
		public PayloadOption[] json_payload;
	}
}
