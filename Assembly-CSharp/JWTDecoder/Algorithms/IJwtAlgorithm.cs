using System;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public interface IJwtAlgorithm
	{
		// Token: 0x060007C0 RID: 1984
		[Token(Token = "0x60007C0")]
		byte[] Sign(byte[] key, byte[] bytesToSign);

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060007C1 RID: 1985
		[Token(Token = "0x170000E5")]
		string Name { [Token(Token = "0x60007C1")] get; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060007C2 RID: 1986
		[Token(Token = "0x170000E6")]
		bool IsAsymmetric { [Token(Token = "0x60007C2")] get; }
	}
}
