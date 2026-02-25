using System;
using Core.Gameplay.Managers;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x0200111C RID: 4380
	[Token(Token = "0x200111C")]
	public interface IAuthDataProvider
	{
		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x060066A0 RID: 26272
		[Token(Token = "0x170014E1")]
		AuthData AuthData { [Token(Token = "0x60066A0")] get; }
	}
}
