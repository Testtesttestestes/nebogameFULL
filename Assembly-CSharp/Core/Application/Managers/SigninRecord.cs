using System;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Application.Managers
{
	// Token: 0x02001259 RID: 4697
	[Token(Token = "0x2001259")]
	[Serializable]
	public class SigninRecord
	{
		// Token: 0x06006F5C RID: 28508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006F5C")]
		[Address(RVA = "0xB9C7", Offset = "0xB9C7", VA = "0xB9C7", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F5D")]
		[Address(RVA = "0x239A", Offset = "0x239A", VA = "0x239A")]
		public SigninRecord()
		{
		}

		// Token: 0x04003A22 RID: 14882
		[Token(Token = "0x4003A22")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		// Token: 0x04003A23 RID: 14883
		[Token(Token = "0x4003A23")]
		[FieldOffset(Offset = "0xC")]
		public Provider ProviderId;

		// Token: 0x04003A24 RID: 14884
		[Token(Token = "0x4003A24")]
		[FieldOffset(Offset = "0x10")]
		public string UserId;

		// Token: 0x04003A25 RID: 14885
		[Token(Token = "0x4003A25")]
		[FieldOffset(Offset = "0x14")]
		public string Token;
	}
}
