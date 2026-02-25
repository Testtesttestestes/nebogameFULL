using System;
using Cysharp.Threading.Tasks;
using Gameplay.Portals.Model;
using Il2CppDummyDll;

namespace Gameplay.Portals
{
	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	public interface IMonsterSource
	{
		// Token: 0x060022DE RID: 8926
		[Token(Token = "0x60022DE")]
		UniTask<PortalMonsterData> GetMonster();
	}
}
