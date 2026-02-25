using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Application.Managers
{
	// Token: 0x02001256 RID: 4694
	[Token(Token = "0x2001256")]
	public interface IPlatformSigninProvider
	{
		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06006F47 RID: 28487
		[Token(Token = "0x170016B5")]
		ClientPlatform Platform { [Token(Token = "0x6006F47")] get; }

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06006F48 RID: 28488
		[Token(Token = "0x170016B6")]
		string Nick { [Token(Token = "0x6006F48")] get; }

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06006F49 RID: 28489
		[Token(Token = "0x170016B7")]
		SigninRecord SigninRecord { [Token(Token = "0x6006F49")] get; }

		// Token: 0x06006F4A RID: 28490
		[Token(Token = "0x6006F4A")]
		UniTask<IPlatformSigninProvider> UpdateSigninRecord();

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06006F4B RID: 28491
		[Token(Token = "0x170016B8")]
		AbstractPlatformSigninProvider.SigninState CurrentState { [Token(Token = "0x6006F4B")] get; }

		// Token: 0x06006F4C RID: 28492
		[Token(Token = "0x6006F4C")]
		void Commit();

		// Token: 0x06006F4D RID: 28493
		[Token(Token = "0x6006F4D")]
		void Reset();

		// Token: 0x06006F4E RID: 28494
		[Token(Token = "0x6006F4E")]
		void SignOut();
	}
}
