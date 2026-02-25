using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Controller;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BankOptions
{
	// Token: 0x0200121E RID: 4638
	[Token(Token = "0x200121E")]
	public class BankOptionsAdPlacementManager : AbstractAdPlacementManager<BankOptionsAdPlacementModel, BankOptionsAdPlacementController, BankOptionsAdPlacementEvents>
	{
		// Token: 0x06006DD9 RID: 28121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DD9")]
		[Address(RVA = "0xB892", Offset = "0xB892", VA = "0xB892")]
		private BankOptionsAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDA")]
		[Address(RVA = "0xB893", Offset = "0xB893", VA = "0xB893", Slot = "9")]
		protected override BankOptionsAdPlacementEvents CreateEvents()
		{
			return null;
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDB")]
		[Address(RVA = "0xB894", Offset = "0xB894", VA = "0xB894", Slot = "7")]
		protected override BankOptionsAdPlacementController CreateController(BankOptionsAdPlacementEvents events, BankOptionsAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
			return null;
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDC")]
		[Address(RVA = "0xB895", Offset = "0xB895", VA = "0xB895", Slot = "8")]
		protected override BankOptionsAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
			return null;
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DDD")]
		[Address(RVA = "0xB896", Offset = "0xB896", VA = "0xB896")]
		public static BankOptionsAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}
	}
}
