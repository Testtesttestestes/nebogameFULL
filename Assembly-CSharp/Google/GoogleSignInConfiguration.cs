using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google
{
	// Token: 0x020013CC RID: 5068
	[Token(Token = "0x20013CC")]
	public class GoogleSignInConfiguration
	{
		// Token: 0x060078C6 RID: 30918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078C6")]
		[Address(RVA = "0xC204", Offset = "0xC204", VA = "0xC204")]
		public GoogleSignInConfiguration()
		{
		}

		// Token: 0x04003F19 RID: 16153
		[Token(Token = "0x4003F19")]
		[FieldOffset(Offset = "0x8")]
		public bool UseGameSignIn;

		// Token: 0x04003F1A RID: 16154
		[Token(Token = "0x4003F1A")]
		[FieldOffset(Offset = "0xC")]
		public string WebClientId;

		// Token: 0x04003F1B RID: 16155
		[Token(Token = "0x4003F1B")]
		[FieldOffset(Offset = "0x10")]
		public bool RequestAuthCode;

		// Token: 0x04003F1C RID: 16156
		[Token(Token = "0x4003F1C")]
		[FieldOffset(Offset = "0x11")]
		public bool ForceTokenRefresh;

		// Token: 0x04003F1D RID: 16157
		[Token(Token = "0x4003F1D")]
		[FieldOffset(Offset = "0x12")]
		public bool RequestEmail;

		// Token: 0x04003F1E RID: 16158
		[Token(Token = "0x4003F1E")]
		[FieldOffset(Offset = "0x13")]
		public bool RequestIdToken;

		// Token: 0x04003F1F RID: 16159
		[Token(Token = "0x4003F1F")]
		[FieldOffset(Offset = "0x14")]
		public bool RequestProfile;

		// Token: 0x04003F20 RID: 16160
		[Token(Token = "0x4003F20")]
		[FieldOffset(Offset = "0x15")]
		public bool HidePopups;

		// Token: 0x04003F21 RID: 16161
		[Token(Token = "0x4003F21")]
		[FieldOffset(Offset = "0x18")]
		public string AccountName;

		// Token: 0x04003F22 RID: 16162
		[Token(Token = "0x4003F22")]
		[FieldOffset(Offset = "0x1C")]
		public IEnumerable<string> AdditionalScopes;
	}
}
