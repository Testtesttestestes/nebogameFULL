using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;

namespace Gameplay.Portals.Combat
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	public class PortalCombatEvents : CombatEvents
	{
		// Token: 0x060024C2 RID: 9410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x7610", Offset = "0x7610", VA = "0x7610")]
		public PortalCombatEvents()
		{
		}

		// Token: 0x0400140E RID: 5134
		[Token(Token = "0x400140E")]
		[FieldOffset(Offset = "0x70")]
		public Action InfoChangedEvent;

		// Token: 0x0400140F RID: 5135
		[Token(Token = "0x400140F")]
		[FieldOffset(Offset = "0x74")]
		public Action DropRemovedEvent;
	}
}
