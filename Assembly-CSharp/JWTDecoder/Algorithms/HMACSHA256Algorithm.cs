using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public sealed class HMACSHA256Algorithm : IJwtAlgorithm
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x5B87", Offset = "0x5B87", VA = "0x5B87", Slot = "4")]
		public byte[] Sign(byte[] key, byte[] bytesToSign)
		{
			return null;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DF")]
		public string Name
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x5B88", Offset = "0x5B88", VA = "0x5B88", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x170000E0")]
		public bool IsAsymmetric
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x5B89", Offset = "0x5B89", VA = "0x5B89", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x5B8A", Offset = "0x5B8A", VA = "0x5B8A")]
		public HMACSHA256Algorithm()
		{
		}
	}
}
