using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ServicesNamespace;

namespace Core.Gameplay.Tokens
{
	// Token: 0x0200112A RID: 4394
	[Token(Token = "0x200112A")]
	public class IdTokenRepository : IDisposable
	{
		// Token: 0x06006706 RID: 26374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006706")]
		[Address(RVA = "0xB241", Offset = "0xB241", VA = "0xB241")]
		public IdTokenRepository(TokenatorService service, string clientId)
		{
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006707")]
		[Address(RVA = "0x1E88", Offset = "0x1E88", VA = "0x1E88")]
		public ITokenProvider GetTokenProvider(string scope)
		{
			return null;
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006708")]
		[Address(RVA = "0xB242", Offset = "0xB242", VA = "0xB242", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, ITokenProvider> _tokens;

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0xC")]
		private readonly TokenatorService _service;

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _clientId;
	}
}
