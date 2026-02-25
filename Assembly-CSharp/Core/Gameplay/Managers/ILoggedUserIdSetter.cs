using System;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001131 RID: 4401
	[Token(Token = "0x2001131")]
	public interface ILoggedUserIdSetter
	{
		// Token: 0x06006720 RID: 26400
		[Token(Token = "0x6006720")]
		void RequestSetUserId(ulong userId, Action<OpToken<IMessage, object>> callback);
	}
}
