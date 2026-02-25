using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Controller
{
	// Token: 0x0200120E RID: 4622
	[Token(Token = "0x200120E")]
	public class EnergyRegenAdPlacementController : AbstractAdPlacementController<EnergyRegenAdPlacementModel, EnergyRegenAdPlacementEvents>
	{
		// Token: 0x06006DA7 RID: 28071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA7")]
		[Address(RVA = "0xB867", Offset = "0xB867", VA = "0xB867")]
		public EnergyRegenAdPlacementController(EnergyRegenAdPlacementModel model, EnergyRegenAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DA8")]
		[Address(RVA = "0xB868", Offset = "0xB868", VA = "0xB868")]
		public WaitForCallBack<bool> IsAdAvailable(Resources resourceId)
		{
			return null;
		}
	}
}
