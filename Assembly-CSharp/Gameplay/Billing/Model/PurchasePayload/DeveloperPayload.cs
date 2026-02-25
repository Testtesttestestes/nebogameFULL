using System;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BF2 RID: 3058
	[Token(Token = "0x2000BF2")]
	[Serializable]
	public class DeveloperPayload
	{
		// Token: 0x06004B03 RID: 19203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x9960", Offset = "0x9960", VA = "0x9960")]
		public DeveloperPayload(string raw)
		{
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x9961", Offset = "0x9961", VA = "0x9961")]
		public ulong GetOptionId()
		{
			return 0UL;
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x9962", Offset = "0x9962", VA = "0x9962")]
		public long GetTimestamp()
		{
			return 0L;
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B06")]
		[Address(RVA = "0x9963", Offset = "0x9963", VA = "0x9963")]
		public PayloadContent GetPayload()
		{
			return null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x9964", Offset = "0x9964", VA = "0x9964", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028D1 RID: 10449
		[Token(Token = "0x40028D1")]
		[FieldOffset(Offset = "0x8")]
		private PayloadContent _payloadContent;

		// Token: 0x040028D2 RID: 10450
		[Token(Token = "0x40028D2")]
		[FieldOffset(Offset = "0xC")]
		public string Raw;
	}
}
