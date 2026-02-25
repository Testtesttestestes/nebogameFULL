using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	public class TokenatorService : AbstractService
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x170000B1")]
		public override short ServiceId
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x5A99", Offset = "0x5A99", VA = "0x5A99", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5A9A", Offset = "0x5A9A", VA = "0x5A9A")]
		public OpToken<IMessage, object> GenIdToken(string clientId, string scope)
		{
			return null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x5A9B", Offset = "0x5A9B", VA = "0x5A9B")]
		public TokenatorService()
		{
		}
	}
}
