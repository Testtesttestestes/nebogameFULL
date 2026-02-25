using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200114D RID: 4429
	[Token(Token = "0x200114D")]
	public interface IClientState
	{
		// Token: 0x06006857 RID: 26711
		[Token(Token = "0x6006857")]
		UniTask ForceRequestClientState();
	}
}
