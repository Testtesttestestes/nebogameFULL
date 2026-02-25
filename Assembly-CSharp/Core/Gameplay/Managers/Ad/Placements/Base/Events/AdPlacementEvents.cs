using System;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Ad.Placements.Base.Events
{
	// Token: 0x0200121C RID: 4636
	[Token(Token = "0x200121C")]
	public class AdPlacementEvents : AbstractMVCEvents
	{
		// Token: 0x06006DD2 RID: 28114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0xB891", Offset = "0xB891", VA = "0xB891")]
		public AdPlacementEvents()
		{
		}

		// Token: 0x04003978 RID: 14712
		[Token(Token = "0x4003978")]
		[FieldOffset(Offset = "0x14")]
		public Action AdAvailabilityPossiblyChangedEvent;

		// Token: 0x04003979 RID: 14713
		[Token(Token = "0x4003979")]
		[FieldOffset(Offset = "0x18")]
		public Action AdRewardedEvent;
	}
}
