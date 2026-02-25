using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Model;
using Il2CppDummyDll;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.DailyQuests.Controller
{
	// Token: 0x02001212 RID: 4626
	[Token(Token = "0x2001212")]
	public class DailyQuestsAdPlacementController : AbstractAdPlacementController<DailyQuestsAdPlacementModel, DailyQuestsAdPlacementEvents>
	{
		// Token: 0x06006DB0 RID: 28080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB0")]
		[Address(RVA = "0xB870", Offset = "0xB870", VA = "0xB870")]
		public DailyQuestsAdPlacementController(DailyQuestsAdPlacementModel model, DailyQuestsAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0xB871", Offset = "0xB871", VA = "0xB871")]
		public WaitForCallBack<bool> IsAdAvailable()
		{
			return null;
		}
	}
}
