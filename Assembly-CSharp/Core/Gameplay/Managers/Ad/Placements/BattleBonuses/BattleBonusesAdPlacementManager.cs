using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses
{
	// Token: 0x02001217 RID: 4631
	[Token(Token = "0x2001217")]
	public class BattleBonusesAdPlacementManager : AbstractAdPlacementManager<BattleBonusesAdModel, BattleBonusesAdController, BattleBonusesAdEvents>
	{
		// Token: 0x06006DBE RID: 28094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBE")]
		[Address(RVA = "0xB87E", Offset = "0xB87E", VA = "0xB87E")]
		private BattleBonusesAdPlacementManager(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user, MedalsManager medalsManager, IDictProvider dictProvider, IRequirementValidator requirementValidator)
		{
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DBF")]
		[Address(RVA = "0xB87F", Offset = "0xB87F", VA = "0xB87F", Slot = "7")]
		protected override BattleBonusesAdController CreateController(BattleBonusesAdEvents events, BattleBonusesAdModel model, IAdController adController, AdEvents adEvents)
		{
			return null;
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC0")]
		[Address(RVA = "0xB880", Offset = "0xB880", VA = "0xB880", Slot = "8")]
		protected override BattleBonusesAdModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
			return null;
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC1")]
		[Address(RVA = "0xB881", Offset = "0xB881", VA = "0xB881", Slot = "9")]
		protected override BattleBonusesAdEvents CreateEvents()
		{
			return null;
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC2")]
		[Address(RVA = "0xB882", Offset = "0xB882", VA = "0xB882")]
		public static BattleBonusesAdPlacementManager Create(IAdPlacementData adPlacementData, IAdController adController, AdEvents adEvents, UserData user, MedalsManager medalsManager, IDictProvider dictProvider, IRequirementValidator requirementValidator)
		{
			return null;
		}

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x24")]
		private readonly MedalsManager _medalsManager;

		// Token: 0x0400396F RID: 14703
		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x28")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04003970 RID: 14704
		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IRequirementValidator _requirementValidator;
	}
}
