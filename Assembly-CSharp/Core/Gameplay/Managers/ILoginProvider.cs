using System;
using Core.Application.Managers;
using Il2CppDummyDll;
using Protocol.Auth2;
using Protocol.Consts;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001132 RID: 4402
	[Token(Token = "0x2001132")]
	public interface ILoginProvider
	{
		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06006721 RID: 26401
		[Token(Token = "0x17001523")]
		int SuccessLoginCount { [Token(Token = "0x6006721")] get; }

		// Token: 0x06006722 RID: 26402
		[Token(Token = "0x6006722")]
		void RequestLogin(ClientPlatform clientPlatform, SigninRecord record, Action<LoggedManager.LoginCallbackInvoker, LoginCmd.Types.Ans> callback);
	}
}
