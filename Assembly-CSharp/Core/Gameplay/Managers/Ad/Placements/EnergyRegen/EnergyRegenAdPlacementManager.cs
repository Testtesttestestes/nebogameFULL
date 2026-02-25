using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Controller;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen
{
	// Token: 0x0200120B RID: 4619
	[Token(Token = "0x200120B")]
	public class EnergyRegenAdPlacementManager : AbstractAdPlacementManager<EnergyRegenAdPlacementModel, EnergyRegenAdPlacementController, EnergyRegenAdPlacementEvents>
	{
		// Token: 0x06006D9F RID: 28063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D9F")]
		[Address(RVA = "0xB85F", Offset = "0xB85F", VA = "0xB85F")]
		private EnergyRegenAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA0")]
		[Address(RVA = "0xB860", Offset = "0xB860", VA = "0xB860", Slot = "7")]
		protected override EnergyRegenAdPlacementController CreateController(EnergyRegenAdPlacementEvents events, EnergyRegenAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
			return null;
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA1")]
		[Address(RVA = "0xB861", Offset = "0xB861", VA = "0xB861", Slot = "8")]
		protected override EnergyRegenAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
			return null;
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA2")]
		[Address(RVA = "0xB862", Offset = "0xB862", VA = "0xB862", Slot = "9")]
		protected override EnergyRegenAdPlacementEvents CreateEvents()
		{
			return null;
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA3")]
		[Address(RVA = "0xB863", Offset = "0xB863", VA = "0xB863")]
		public static EnergyRegenAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}
	}
}
