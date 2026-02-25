using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001129 RID: 4393
	[Token(Token = "0x2001129")]
	public interface IGameRestart
	{
		// Token: 0x06006705 RID: 26373
		[Token(Token = "0x6006705")]
		UniTask Restart(IGame game);
	}
}
