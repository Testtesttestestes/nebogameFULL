using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x0200111D RID: 4381
	[Token(Token = "0x200111D")]
	public interface IAuthTokenSource
	{
		// Token: 0x060066A1 RID: 26273
		[Token(Token = "0x60066A1")]
		UniTask<string> GetToken();
	}
}
