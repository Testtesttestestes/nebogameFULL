using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Model;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Il2CppDummyDll;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.BankOptions.Controller
{
	// Token: 0x02001221 RID: 4641
	[Token(Token = "0x2001221")]
	public class BankOptionsAdPlacementController : AbstractAdPlacementController<BankOptionsAdPlacementModel, BankOptionsAdPlacementEvents>
	{
		// Token: 0x06006DE0 RID: 28128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0xB899", Offset = "0xB899", VA = "0xB899")]
		public BankOptionsAdPlacementController(BankOptionsAdPlacementModel model, BankOptionsAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DE1")]
		[Address(RVA = "0xB89A", Offset = "0xB89A", VA = "0xB89A")]
		public WaitForCallBack<bool> IsAdAvailable()
		{
			return null;
		}
	}
}
