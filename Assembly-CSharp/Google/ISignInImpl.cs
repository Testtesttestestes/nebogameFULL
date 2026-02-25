using System;
using Il2CppDummyDll;

namespace Google
{
	// Token: 0x020013CB RID: 5067
	[Token(Token = "0x20013CB")]
	internal interface ISignInImpl
	{
		// Token: 0x060078C1 RID: 30913
		[Token(Token = "0x60078C1")]
		Future<GoogleSignInUser> SignIn();

		// Token: 0x060078C2 RID: 30914
		[Token(Token = "0x60078C2")]
		Future<GoogleSignInUser> SignInSilently();

		// Token: 0x060078C3 RID: 30915
		[Token(Token = "0x60078C3")]
		void EnableDebugLogging(bool flag);

		// Token: 0x060078C4 RID: 30916
		[Token(Token = "0x60078C4")]
		void SignOut();

		// Token: 0x060078C5 RID: 30917
		[Token(Token = "0x60078C5")]
		void Disconnect();
	}
}
