using System;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x20002A7")]
	public abstract class BaseClanBuildingWindowArgs : BaseIsleBuildingWindowArgs<ClanIsle>
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x620B", Offset = "0x620B", VA = "0x620B")]
		protected BaseClanBuildingWindowArgs(ClanIsle isle, uint buildingTypeId)
		{
		}
	}
}
