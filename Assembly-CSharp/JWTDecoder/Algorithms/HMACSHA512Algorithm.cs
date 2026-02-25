using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public sealed class HMACSHA512Algorithm : IJwtAlgorithm
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x5B8F", Offset = "0x5B8F", VA = "0x5B8F", Slot = "4")]
		public byte[] Sign(byte[] key, byte[] bytesToSign)
		{
			return null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E3")]
		public string Name
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x5B90", Offset = "0x5B90", VA = "0x5B90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x170000E4")]
		public bool IsAsymmetric
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x5B91", Offset = "0x5B91", VA = "0x5B91", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x5B92", Offset = "0x5B92", VA = "0x5B92")]
		public HMACSHA512Algorithm()
		{
		}
	}
}
