using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Combat
{
	// Token: 0x02000912 RID: 2322
	[Token(Token = "0x2000912")]
	public interface ICombat : IDisposable
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06003690 RID: 13968
		[Token(Token = "0x17000ABF")]
		bool IsRun { [Token(Token = "0x6003690")] get; }

		// Token: 0x06003691 RID: 13969
		[Token(Token = "0x6003691")]
		bool TryRun(ResourceSet price);

		// Token: 0x06003692 RID: 13970
		[Token(Token = "0x6003692")]
		bool TryRun();

		// Token: 0x06003693 RID: 13971
		[Token(Token = "0x6003693")]
		void Stop();

		// Token: 0x06003694 RID: 13972
		[Token(Token = "0x6003694")]
		CombatModel.States GetState();
	}
}
