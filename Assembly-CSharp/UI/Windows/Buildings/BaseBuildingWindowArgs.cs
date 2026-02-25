using System;
using Gameplay.Isles.User;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	public abstract class BaseBuildingWindowArgs : BaseIsleBuildingWindowArgs<UserIsle>
	{
		// Token: 0x06000FFF RID: 4095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x620A", Offset = "0x620A", VA = "0x620A")]
		protected BaseBuildingWindowArgs(UserIsle isle, uint buildingTypeId)
		{
		}
	}
}
