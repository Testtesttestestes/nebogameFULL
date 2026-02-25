using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public sealed class HMACSHA384Algorithm : IJwtAlgorithm
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5B8B", Offset = "0x5B8B", VA = "0x5B8B", Slot = "4")]
		public byte[] Sign(byte[] key, byte[] bytesToSign)
		{
			return null;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E1")]
		public string Name
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x5B8C", Offset = "0x5B8C", VA = "0x5B8C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x170000E2")]
		public bool IsAsymmetric
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x5B8D", Offset = "0x5B8D", VA = "0x5B8D", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x5B8E", Offset = "0x5B8E", VA = "0x5B8E")]
		public HMACSHA384Algorithm()
		{
		}
	}
}
