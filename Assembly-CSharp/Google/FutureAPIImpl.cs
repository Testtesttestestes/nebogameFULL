using System;
using Il2CppDummyDll;

namespace Google
{
	// Token: 0x020013C6 RID: 5062
	[Token(Token = "0x20013C6")]
	internal interface FutureAPIImpl<T>
	{
		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x060078A2 RID: 30882
		[Token(Token = "0x170017E1")]
		bool Pending { [Token(Token = "0x60078A2")] get; }

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x060078A3 RID: 30883
		[Token(Token = "0x170017E2")]
		GoogleSignInStatusCode Status { [Token(Token = "0x60078A3")] get; }

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x060078A4 RID: 30884
		[Token(Token = "0x170017E3")]
		T Result { [Token(Token = "0x60078A4")] get; }
	}
}
