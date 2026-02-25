using System;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Isles.User
{
	// Token: 0x02000D0B RID: 3339
	[Token(Token = "0x2000D0B")]
	public interface IMonsterSource
	{
		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06005177 RID: 20855
		[Token(Token = "0x1700107E")]
		ulong OwnerId { [Token(Token = "0x6005177")] get; }

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06005178 RID: 20856
		[Token(Token = "0x1700107F")]
		MonsterData Monster { [Token(Token = "0x6005178")] get; }
	}
}
