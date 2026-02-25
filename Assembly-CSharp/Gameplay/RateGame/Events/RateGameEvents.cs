using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.RateGame.Events
{
	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	public class RateGameEvents : AbstractMVCEvents
	{
		// Token: 0x060022CC RID: 8908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x7423", Offset = "0x7423", VA = "0x7423")]
		public RateGameEvents()
		{
		}

		// Token: 0x04001303 RID: 4867
		[Token(Token = "0x4001303")]
		[FieldOffset(Offset = "0x14")]
		public Action<uint> RateGameEvent;
	}
}
