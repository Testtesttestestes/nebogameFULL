using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013A9 RID: 5033
	[Token(Token = "0x20013A9")]
	[Serializable]
	public struct LocalizedString
	{
		// Token: 0x060077C6 RID: 30662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077C6")]
		[Address(RVA = "0xC121", Offset = "0xC121", VA = "0xC121")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00015FD8 File Offset: 0x000141D8
		[Token(Token = "0x60077C7")]
		[Address(RVA = "0xC122", Offset = "0xC122", VA = "0xC122")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C8")]
		[Address(RVA = "0xC123", Offset = "0xC123", VA = "0xC123")]
		public LocalizedString(LocalizedString str)
		{
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077C9")]
		[Address(RVA = "0xC124", Offset = "0xC124", VA = "0xC124", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		[FieldOffset(Offset = "0x0")]
		public string mTerm;

		// Token: 0x04003E81 RID: 16001
		[Token(Token = "0x4003E81")]
		[FieldOffset(Offset = "0x4")]
		public bool mRTL_IgnoreArabicFix;

		// Token: 0x04003E82 RID: 16002
		[Token(Token = "0x4003E82")]
		[FieldOffset(Offset = "0x8")]
		public int mRTL_MaxLineLength;

		// Token: 0x04003E83 RID: 16003
		[Token(Token = "0x4003E83")]
		[FieldOffset(Offset = "0xC")]
		public bool mRTL_ConvertNumbers;

		// Token: 0x04003E84 RID: 16004
		[Token(Token = "0x4003E84")]
		[FieldOffset(Offset = "0xD")]
		public bool m_DontLocalizeParameters;
	}
}
