using System;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public class AlgorithmFactory : IAlgorithmFactory
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5B84", Offset = "0x5B84", VA = "0x5B84", Slot = "4")]
		public IJwtAlgorithm Create(string algorithmName)
		{
			return null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x5B85", Offset = "0x5B85", VA = "0x5B85", Slot = "6")]
		public virtual IJwtAlgorithm Create(HashAlgorithm algorithm)
		{
			return null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x5B86", Offset = "0x5B86", VA = "0x5B86")]
		public AlgorithmFactory()
		{
		}
	}
}
