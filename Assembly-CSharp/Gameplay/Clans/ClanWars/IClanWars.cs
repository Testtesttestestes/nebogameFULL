using System;
using Il2CppDummyDll;
using Protocol.ClanWar;

namespace Gameplay.Clans.ClanWars
{
	// Token: 0x02000AA5 RID: 2725
	[Token(Token = "0x2000AA5")]
	public interface IClanWars
	{
		// Token: 0x060041AB RID: 16811
		[Token(Token = "0x60041AB")]
		bool TryGetActiveWar(out ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWar);

		// Token: 0x060041AC RID: 16812
		[Token(Token = "0x60041AC")]
		void RequestUpdateActiveWar();
	}
}
