using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Controller;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Events;
using Core.Gameplay.Managers.Ad.Placements.DailyQuests.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.DailyQuests
{
	// Token: 0x0200120F RID: 4623
	[Token(Token = "0x200120F")]
	public class DailyQuestsAdPlacementManager : AbstractAdPlacementManager<DailyQuestsAdPlacementModel, DailyQuestsAdPlacementController, DailyQuestsAdPlacementEvents>
	{
		// Token: 0x06006DA9 RID: 28073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA9")]
		[Address(RVA = "0xB869", Offset = "0xB869", VA = "0xB869")]
		private DailyQuestsAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAA")]
		[Address(RVA = "0xB86A", Offset = "0xB86A", VA = "0xB86A", Slot = "9")]
		protected override DailyQuestsAdPlacementEvents CreateEvents()
		{
			return null;
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAB")]
		[Address(RVA = "0xB86B", Offset = "0xB86B", VA = "0xB86B", Slot = "7")]
		protected override DailyQuestsAdPlacementController CreateController(DailyQuestsAdPlacementEvents events, DailyQuestsAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
			return null;
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0xB86C", Offset = "0xB86C", VA = "0xB86C", Slot = "8")]
		protected override DailyQuestsAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
			return null;
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0xB86D", Offset = "0xB86D", VA = "0xB86D")]
		public static DailyQuestsAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}
	}
}
