using System;
using Gameplay.RegisterV2.Model;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Gameplay.RegisterV2.Control
{
	// Token: 0x0200056C RID: 1388
	[Token(Token = "0x200056C")]
	public interface IRegistration
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002161 RID: 8545
		[Token(Token = "0x1700061E")]
		RegisterModel Model { [Token(Token = "0x6002161")] get; }

		// Token: 0x06002162 RID: 8546
		[Token(Token = "0x6002162")]
		void HandleRegisterResult(RegisterCmd.Types.Result result);

		// Token: 0x06002163 RID: 8547
		[Token(Token = "0x6002163")]
		void Complete();
	}
}
