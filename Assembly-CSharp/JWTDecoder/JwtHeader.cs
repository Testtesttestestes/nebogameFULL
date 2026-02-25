using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace JWTDecoder
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public class JwtHeader
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		[JsonProperty("alg")]
		public string Algorithm
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x5B77", Offset = "0x5B77", VA = "0x5B77")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x5B78", Offset = "0x5B78", VA = "0x5B78")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DD")]
		[JsonProperty("typ")]
		public string Type
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x5B79", Offset = "0x5B79", VA = "0x5B79")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x5B7A", Offset = "0x5B7A", VA = "0x5B7A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x5B7B", Offset = "0x5B7B", VA = "0x5B7B")]
		public JwtHeader()
		{
		}
	}
}
