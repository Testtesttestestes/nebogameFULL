using System;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001133 RID: 4403
	[Token(Token = "0x2001133")]
	public interface IRegistrationProvider
	{
		// Token: 0x06006723 RID: 26403
		[Token(Token = "0x6006723")]
		void Register(string nick, uint aprId, Action<LoggedManager.RegisterCallbackInvoker, RegisterCmd.Types.Ans> resultCallback);
	}
}
