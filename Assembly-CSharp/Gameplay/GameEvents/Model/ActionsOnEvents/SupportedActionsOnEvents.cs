using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Events;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public static class SupportedActionsOnEvents
	{
		// Token: 0x06002F1A RID: 12058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x7F87", Offset = "0x7F87", VA = "0x7F87")]
		public static List<AbstractActionOnEvent> Create(GameEventData evt)
		{
			return null;
		}

		// Token: 0x040019BB RID: 6587
		[Token(Token = "0x40019BB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<EventActions, Type> SupportedActionOnEvents;
	}
}
