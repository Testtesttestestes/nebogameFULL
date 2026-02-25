using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model
{
	// Token: 0x02001218 RID: 4632
	[Token(Token = "0x2001218")]
	public class BattleBonusesAdModel : AbstractAdPlacementModel
	{
		// Token: 0x06006DC3 RID: 28099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC3")]
		[Address(RVA = "0xB883", Offset = "0xB883", VA = "0xB883")]
		public BattleBonusesAdModel(UserData user, IAdPlacementData placementData, IDictProvider dictionaries, MedalsManager medalsManager, IRequirementValidator requirementsValidator)
		{
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC4")]
		[Address(RVA = "0xB884", Offset = "0xB884", VA = "0xB884")]
		private void InitBonusMedals()
		{
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC5")]
		[Address(RVA = "0xB885", Offset = "0xB885", VA = "0xB885")]
		public MedalData GetAppropriateBonus()
		{
			return null;
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DC6")]
		[Address(RVA = "0xB886", Offset = "0xB886", VA = "0xB886")]
		public List<MedalData> GetAchievedBonuses()
		{
			return null;
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x00014238 File Offset: 0x00012438
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x2241", Offset = "0x2241", VA = "0x2241")]
		private bool CheckRestrictionsProxy(IList<RestrictionInfo> restrictionsInfo, UserData user)
		{
			return default(bool);
		}

		// Token: 0x04003971 RID: 14705
		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x10")]
		public HashSet<uint> BonusMedalIds;

		// Token: 0x04003972 RID: 14706
		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x14")]
		private List<MedalData> _bonusMedals;

		// Token: 0x04003973 RID: 14707
		[Token(Token = "0x4003973")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDictProvider _dictionaries;

		// Token: 0x04003974 RID: 14708
		[Token(Token = "0x4003974")]
		[FieldOffset(Offset = "0x1C")]
		private readonly MedalsManager _medalsManager;

		// Token: 0x04003975 RID: 14709
		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0x20")]
		private readonly IRequirementValidator _requirementsValidator;
	}
}
