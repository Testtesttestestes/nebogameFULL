using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.ClanWars.Events
{
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	public class ClanWarsEvents : AbstractMVCEvents
	{
		// Token: 0x060041C2 RID: 16834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x9076", Offset = "0x9076", VA = "0x9076")]
		public ClanWarsEvents()
		{
		}

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x14")]
		public Action WarStateChangedEvent;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x18")]
		public Action ClanWarDeclaredEvent;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x1C")]
		public Action SeasonChangedEvent;
	}
}
