using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class JWT
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005B")]
		public JWT.JWTContent Content
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x56E8", Offset = "0x56E8", VA = "0x56E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x1700005C")]
		public TimeSpan Duration
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x56E9", Offset = "0x56E9", VA = "0x56E9")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x56EA", Offset = "0x56EA", VA = "0x56EA")]
		public long GetBackTime()
		{
			return 0L;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x1700005D")]
		public bool IsExpired
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x56EB", Offset = "0x56EB", VA = "0x56EB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x56EC", Offset = "0x56EC", VA = "0x56EC")]
		private JWT(string payload)
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x56ED", Offset = "0x56ED", VA = "0x56ED")]
		public static bool TryParse(string token, out JWT jwtObj)
		{
			return default(bool);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x56EE", Offset = "0x56EE", VA = "0x56EE", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Payload;

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		[Serializable]
		public class JWTContent
		{
			// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x56EF", Offset = "0x56EF", VA = "0x56EF")]
			public JWTContent()
			{
			}

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x8")]
			public long iat;

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x10")]
			public long exp;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x18")]
			public string sub;
		}
	}
}
