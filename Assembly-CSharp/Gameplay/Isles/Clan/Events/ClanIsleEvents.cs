using System;
using Gameplay.Isles.Base.Events;
using Il2CppDummyDll;

namespace Gameplay.Isles.Clan.Events
{
	// Token: 0x02000CF4 RID: 3316
	[Token(Token = "0x2000CF4")]
	public class ClanIsleEvents : BaseIsleEvents
	{
		// Token: 0x060050B5 RID: 20661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x9EC4", Offset = "0x9EC4", VA = "0x9EC4")]
		public ClanIsleEvents()
		{
		}

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x24")]
		public Action GolemStateChangedEvent;
	}
}
