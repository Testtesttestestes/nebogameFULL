using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay.Tokens
{
	// Token: 0x0200112B RID: 4395
	[Token(Token = "0x200112B")]
	public interface ITokenProvider
	{
		// Token: 0x06006709 RID: 26377
		[Token(Token = "0x6006709")]
		UniTask<string> GetTokenAsync();

		// Token: 0x0600670A RID: 26378
		[Token(Token = "0x600670A")]
		void Cancel();
	}
}
