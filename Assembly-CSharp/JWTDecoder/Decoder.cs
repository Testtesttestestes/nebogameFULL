using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace JWTDecoder
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public static class Decoder
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x5B72", Offset = "0x5B72", VA = "0x5B72")]
		public static ValueTuple<JwtHeader, string, string> DecodeToken(string token)
		{
			return default(ValueTuple<JwtHeader, string, string>);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079D")]
		public static T DecodePayload<T>(string token)
		{
			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x5B73", Offset = "0x5B73", VA = "0x5B73")]
		private static string Base64DecodeToString(string ToDecode)
		{
			return null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x5B74", Offset = "0x5B74", VA = "0x5B74")]
		public static bool Validate(string token, [Optional] string secret)
		{
			return default(bool);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x5B75", Offset = "0x5B75", VA = "0x5B75")]
		public static bool IsExpired(string token)
		{
			return default(bool);
		}
	}
}
