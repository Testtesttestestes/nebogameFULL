using System;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Gameplay
{
	// Token: 0x02001128 RID: 4392
	[Token(Token = "0x2001128")]
	public interface IGameResolver
	{
		// Token: 0x06006703 RID: 26371
		[Token(Token = "0x6006703")]
		void Resolve([NotNull] IGame game);

		// Token: 0x06006704 RID: 26372
		[Token(Token = "0x6006704")]
		void Resolve([NotNull] IAuthDataProvider provider);
	}
}
