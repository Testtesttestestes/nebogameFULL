using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model
{
	// Token: 0x0200120C RID: 4620
	[Token(Token = "0x200120C")]
	public class EnergyRegenAdPlacementModel : AbstractAdPlacementModel
	{
		// Token: 0x06006DA4 RID: 28068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA4")]
		[Address(RVA = "0xB864", Offset = "0xB864", VA = "0xB864")]
		public EnergyRegenAdPlacementModel(UserData user, IAdPlacementData placementData)
		{
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA5")]
		[Address(RVA = "0xB865", Offset = "0xB865", VA = "0xB865")]
		public ResourceSet GetEnergyRegenTargetValue()
		{
			return null;
		}

		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x10")]
		public readonly Resources TargetResource;
	}
}
