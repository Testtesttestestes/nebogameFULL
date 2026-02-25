using System;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public interface IAlgorithmFactory
	{
		// Token: 0x060007BE RID: 1982
		[Token(Token = "0x60007BE")]
		IJwtAlgorithm Create(string algorithmName);

		// Token: 0x060007BF RID: 1983
		[Token(Token = "0x60007BF")]
		IJwtAlgorithm Create(HashAlgorithm algorithm);
	}
}
