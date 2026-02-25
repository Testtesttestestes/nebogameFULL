using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils;

namespace Gameplay.WorldAxis.Colossus.Combat
{
	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	public interface IColossusCombatLauncher
	{
		// Token: 0x060012FB RID: 4859
		[Token(Token = "0x60012FB")]
		void NotifyAboutStop();

		// Token: 0x060012FC RID: 4860
		[Token(Token = "0x60012FC")]
		bool TryRun();

		// Token: 0x060012FD RID: 4861
		[Token(Token = "0x60012FD")]
		bool TryRun([NotNull] BackTime backTime);

		// Token: 0x060012FE RID: 4862
		[Token(Token = "0x60012FE")]
		bool TryRun([NotNull] ColossusDic colossus);
	}
}
