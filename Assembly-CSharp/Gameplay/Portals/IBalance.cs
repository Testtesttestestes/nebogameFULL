using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Gameplay.Portals
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	public interface IBalance
	{
		// Token: 0x060022DD RID: 8925
		[Token(Token = "0x60022DD")]
		UniTask<ulong> GetValue();
	}
}
