using System;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200115F RID: 4447
	[Token(Token = "0x200115F")]
	public interface ICombatManager : IGameManager, IBaseManager
	{
		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x060068AE RID: 26798
		[Token(Token = "0x1700156B")]
		ICombat CurrentCombat { [Token(Token = "0x60068AE")] get; }

		// Token: 0x060068AF RID: 26799
		[Token(Token = "0x60068AF")]
		void Add(ICombat combat);

		// Token: 0x060068B0 RID: 26800
		[Token(Token = "0x60068B0")]
		bool TryRemove(ICombat combat);

		// Token: 0x060068B1 RID: 26801
		[Token(Token = "0x60068B1")]
		void StopCurrentCombat();
	}
}
