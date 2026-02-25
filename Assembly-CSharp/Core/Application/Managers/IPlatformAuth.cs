using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Utils;

namespace Core.Application.Managers
{
	// Token: 0x02001255 RID: 4693
	[Token(Token = "0x2001255")]
	public interface IPlatformAuth
	{
		// Token: 0x06006F43 RID: 28483
		[Token(Token = "0x6006F43")]
		string GetNick();

		// Token: 0x06006F44 RID: 28484
		[Token(Token = "0x6006F44")]
		bool TryGetIdToken(out JWT token);

		// Token: 0x06006F45 RID: 28485
		[Token(Token = "0x6006F45")]
		UniTask<SigninRecord> SignInOrUpdate();

		// Token: 0x06006F46 RID: 28486
		[Token(Token = "0x6006F46")]
		void SignOut();
	}
}
