using System;
using Core.Gameplay;
using Il2CppDummyDll;
using Utils;

namespace Core.Rounting
{
	// Token: 0x02000E7E RID: 3710
	[Token(Token = "0x2000E7E")]
	public interface IPathNodeFactory
	{
		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06005A52 RID: 23122
		[Token(Token = "0x17001268")]
		string Name { [Token(Token = "0x6005A52")] get; }

		// Token: 0x06005A53 RID: 23123
		[Token(Token = "0x6005A53")]
		AbstractPathNode Create(string name, IGame game, OpTokenRepository tokenRepository);
	}
}
