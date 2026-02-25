using System;
using Core.Gameplay.Managers.Ad.Placements.Base.Events;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events
{
	// Token: 0x02001219 RID: 4633
	[Token(Token = "0x2001219")]
	public class BattleBonusesAdEvents : AdPlacementEvents
	{
		// Token: 0x06006DC8 RID: 28104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0xB887", Offset = "0xB887", VA = "0xB887")]
		public BattleBonusesAdEvents()
		{
		}

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x1C")]
		public Action BonusAchievedChangedEvent;
	}
}
