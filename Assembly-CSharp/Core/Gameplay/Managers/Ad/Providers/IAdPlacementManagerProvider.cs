using System;
using Core.Gameplay.Managers.Ad.Placements;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Providers
{
	// Token: 0x020011FA RID: 4602
	[Token(Token = "0x20011FA")]
	public interface IAdPlacementManagerProvider
	{
		// Token: 0x06006D50 RID: 27984
		[Token(Token = "0x6006D50")]
		bool TryGetAdPlacementManager(uint adPlacement, out AbstractAdPlacementManager manager);
	}
}
