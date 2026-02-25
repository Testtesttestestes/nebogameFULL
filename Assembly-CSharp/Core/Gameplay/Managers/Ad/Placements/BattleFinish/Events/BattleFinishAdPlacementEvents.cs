using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events
{
	// Token: 0x02001215 RID: 4629
	[Token(Token = "0x2001215")]
	public class BattleFinishAdPlacementEvents : AdPlacementEvents
	{
		// Token: 0x06006DB8 RID: 28088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0xB878", Offset = "0xB878", VA = "0xB878")]
		public BattleFinishAdPlacementEvents()
		{
		}

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x1C")]
		public Action DropRemovedEvent;
	}
}
