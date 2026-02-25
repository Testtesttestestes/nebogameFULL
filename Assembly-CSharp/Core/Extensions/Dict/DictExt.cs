using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Chat;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.SmallGames;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F46 RID: 3910
	[Token(Token = "0x2000F46")]
	public static class DictExt
	{
		// Token: 0x06005E16 RID: 24086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E16")]
		[Address(RVA = "0xAA7D", Offset = "0xAA7D", VA = "0xAA7D")]
		private static void LogGetWarning(object id, string msg)
		{
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xAA7E", Offset = "0xAA7E", VA = "0xAA7E")]
		public static ArtikulTypeDic GetArtikulType(this Dictionaries dict, uint typeId)
		{
			return null;
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0xAA7F", Offset = "0xAA7F", VA = "0xAA7F")]
		public static ItemQualityDic GetItemQuality(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x445B", Offset = "0x445B", VA = "0x445B")]
		public static ArtikulDic GetArtikul(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x36DD", Offset = "0x36DD", VA = "0x36DD")]
		public static ModifierDic GetModifier(this Dictionaries dict, uint modifierId)
		{
			return null;
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0xAA80", Offset = "0xAA80", VA = "0xAA80")]
		public static SpellDic GetSpell(this Dictionaries dict, uint spellId)
		{
			return null;
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0xAA81", Offset = "0xAA81", VA = "0xAA81")]
		public static SpellLevelDic GetSpellLevelDic(this Dictionaries dict, uint spellId, uint level)
		{
			return null;
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0xAA82", Offset = "0xAA82", VA = "0xAA82")]
		public static EffectDic GetEffect(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0xAA83", Offset = "0xAA83", VA = "0xAA83")]
		public static EffectLevelDic GetEffectLevelDic(this Dictionaries dict, uint effectId, uint level)
		{
			return null;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0xAA84", Offset = "0xAA84", VA = "0xAA84")]
		public static CombatTypeGemSetsDic GetGemsSetByCombatType(this Dictionaries dict, int combatType)
		{
			return null;
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0xAA85", Offset = "0xAA85", VA = "0xAA85")]
		public static GameFieldGemSetsDic GetGameFiledGems(this Dictionaries dict, CombatTypeGemSetsDic gemSet)
		{
			return null;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0xAA86", Offset = "0xAA86", VA = "0xAA86")]
		public static List<ArtikulTypeFilters> GetArtikulTypeFiltersByFilterType(this Dictionaries dict, ArtikulTypeFilters.Types.FilterType filterType)
		{
			return null;
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x216E", Offset = "0x216E", VA = "0x216E")]
		public static ArtikulTypeFilters GetArtikulTypeFiltersByFilterId(this Dictionaries dict, uint filterId)
		{
			return null;
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E23")]
		[Address(RVA = "0xAA87", Offset = "0xAA87", VA = "0xAA87")]
		public static AprDic GetApr(this Dictionaries dict, uint aprId)
		{
			return null;
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x1F34", Offset = "0x1F34", VA = "0x1F34")]
		public static AprMarkersDic GetAprMarker(this Dictionaries dict, uint markerId)
		{
			return null;
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0xAA88", Offset = "0xAA88", VA = "0xAA88")]
		public static ContentResourceAsset GetAsset(this RepeatedField<ContentResourceAsset> content, uint id)
		{
			return null;
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0xAA89", Offset = "0xAA89", VA = "0xAA89")]
		public static string GetString(this RepeatedField<ContentStringMessage> content, uint id)
		{
			return null;
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0xAA8A", Offset = "0xAA8A", VA = "0xAA8A")]
		public static List<ArtikulTypeMetaFilterDic> GetAllArtikulTypeMetaFilterByType(this Dictionaries dic, ArtikulTypeFilters.Types.FilterType filterType)
		{
			return null;
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0xAA8B", Offset = "0xAA8B", VA = "0xAA8B")]
		public static CultDic GetCult(this Dictionaries dicts, uint cultId)
		{
			return null;
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E29")]
		[Address(RVA = "0xAA8C", Offset = "0xAA8C", VA = "0xAA8C")]
		public static ClanCultDic GetClanCult(this Dictionaries dicts, uint cultId)
		{
			return null;
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0x1AFC", Offset = "0x1AFC", VA = "0x1AFC")]
		public static ResourcesDic GetResourcesDic(this Dictionaries dicts, Resources id)
		{
			return null;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x1BBA", Offset = "0x1BBA", VA = "0x1BBA")]
		public static UserSkillDic GetUserSkillDic(this Dictionaries dicts, int id)
		{
			return null;
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0xAA8D", Offset = "0xAA8D", VA = "0xAA8D")]
		public static IsleInfoDic GetIsleInfoDicByIsleId(this Dictionaries dictionaries, uint isleId)
		{
			return null;
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0xAA8E", Offset = "0xAA8E", VA = "0xAA8E")]
		public static IsleInfoDic GetIsleInfoDicByUserId(this Dictionaries dictionaries, ulong userId)
		{
			return null;
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0xAA8F", Offset = "0xAA8F", VA = "0xAA8F")]
		public static UserBuildingTypeDic GetUserBuildingTypeDic(this Dictionaries dictionaries, UserBuildingTypes buildingType)
		{
			return null;
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0xAA90", Offset = "0xAA90", VA = "0xAA90")]
		public static UserBuildingViewsDic GetUserBuildingViewsDic(this Dictionaries dict, uint buildingViewId)
		{
			return null;
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0xAA91", Offset = "0xAA91", VA = "0xAA91")]
		public static UserBuildingLevelDic GetUserBuildingLevelDic(this Dictionaries dictionaries, UserBuildingTypes buildingType, uint level)
		{
			return null;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0xAA92", Offset = "0xAA92", VA = "0xAA92")]
		public static int GetIntParameter(this Dictionaries dict, string paramName)
		{
			return 0;
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00010E00 File Offset: 0x0000F000
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0xAA93", Offset = "0xAA93", VA = "0xAA93")]
		public static double GetDoubleParameter(this Dictionaries dict, string paramName)
		{
			return 0.0;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00010E18 File Offset: 0x0000F018
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0xAA94", Offset = "0xAA94", VA = "0xAA94")]
		public static long GetLongParameter(this Dictionaries dict, string paramName)
		{
			return 0L;
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00010E30 File Offset: 0x0000F030
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0xAA95", Offset = "0xAA95", VA = "0xAA95")]
		public static bool GetBoolParameter(this Dictionaries dict, string paramName)
		{
			return default(bool);
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E35")]
		public static T[] GetArrayParameter<T>(this Dictionaries dict, string paramName)
		{
			return null;
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0xAA96", Offset = "0xAA96", VA = "0xAA96")]
		public static ResourceSet GetResourceSetParameter(this Dictionaries dict, string paramName)
		{
			return null;
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0xAA97", Offset = "0xAA97", VA = "0xAA97")]
		public static string GetStringParameter(this Dictionaries dict, string paramName)
		{
			return null;
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0xAA98", Offset = "0xAA98", VA = "0xAA98")]
		public static RequirementDic GetRequirementDic(this Dictionaries dict, uint requirementId)
		{
			return null;
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0xAA99", Offset = "0xAA99", VA = "0xAA99")]
		public static UserMenuActionDic GetUserMenuActionDic(this Dictionaries dict, uint actionId)
		{
			return null;
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0xAA9A", Offset = "0xAA9A", VA = "0xAA9A")]
		public static ArtikulMenuActionDic GetArtikulMenuActionDic(this Dictionaries dict, uint actionId)
		{
			return null;
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0xAA9B", Offset = "0xAA9B", VA = "0xAA9B")]
		public static ArtikulTypeMenuActionDic GetArtikulTypeMenuActionDic(this Dictionaries dict, uint actionId, uint artikulTypeId)
		{
			return null;
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0xAA9C", Offset = "0xAA9C", VA = "0xAA9C")]
		public static ExperienceDic GetExperienceDic(this Dictionaries dict, ExperienceDic.Types.ExperienceTypes expId)
		{
			return null;
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0xAA9D", Offset = "0xAA9D", VA = "0xAA9D")]
		public static UserRatingKindDic GetUserRatingKindDic(this Dictionaries dict, uint kindId)
		{
			return null;
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0xAA9E", Offset = "0xAA9E", VA = "0xAA9E")]
		public static ClanRatingKindDic GetClanRatingKindDic(this Dictionaries dict, uint kindId)
		{
			return null;
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0xAA9F", Offset = "0xAA9F", VA = "0xAA9F")]
		public static CultRatingKindDic GetCultRatingKindDic(this Dictionaries dict, uint kindId)
		{
			return null;
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0xAAA0", Offset = "0xAAA0", VA = "0xAAA0")]
		public static RatingKindTypeDic GetRatingKindDic(this Dictionaries dict, RatingKindTypeDic.Types.RatingKindType kindTypeId)
		{
			return null;
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E41")]
		[Address(RVA = "0xAAA1", Offset = "0xAAA1", VA = "0xAAA1")]
		public static RewardDic GetRewardDic(this Dictionaries dict, RewardTypes rewardType)
		{
			return null;
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E42")]
		[Address(RVA = "0xAAA2", Offset = "0xAAA2", VA = "0xAAA2")]
		public static RewardDic GetRewardDic(this Dictionaries dict, uint rewardId)
		{
			return null;
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00010E48 File Offset: 0x0000F048
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0xAAA3", Offset = "0xAAA3", VA = "0xAAA3")]
		public static bool TryGetArtikulDismantleInfoDic(this Dictionaries dict, uint artikulId, out ArtikulDismantleInfoDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E44")]
		[Address(RVA = "0x2243", Offset = "0x2243", VA = "0x2243")]
		public static TriggerDic GetTriggerDic(this Dictionaries dict, uint triggerId)
		{
			return null;
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x445E", Offset = "0x445E", VA = "0x445E")]
		public static MedalDic GetMedalDic(this Dictionaries dict, uint medalId)
		{
			return null;
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x1BF0", Offset = "0x1BF0", VA = "0x1BF0")]
		public static MedalCategoryDic GetMedalCategory(this Dictionaries dict, uint categoryId)
		{
			return null;
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x1BF1", Offset = "0x1BF1", VA = "0x1BF1")]
		public static MedalTypeDic GetMedalType(this Dictionaries dict, uint typeId)
		{
			return null;
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E48")]
		[Address(RVA = "0xAAA4", Offset = "0xAAA4", VA = "0xAAA4")]
		public static MedalRanks GetMedalRank(this Dictionaries dict, uint rankId)
		{
			return null;
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E49")]
		[Address(RVA = "0xAAA5", Offset = "0xAAA5", VA = "0xAAA5")]
		public static TreeLevelDic GetTreeLevelDic(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0xAAA6", Offset = "0xAAA6", VA = "0xAAA6")]
		public static ArenaLevelDic GetArenaLevelDic(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0xAAA7", Offset = "0xAAA7", VA = "0xAAA7")]
		public static ShopLevelDic GetShopLevelDic(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0xAAA8", Offset = "0xAAA8", VA = "0xAAA8")]
		public static CaveLevelDic GetCaveLevel(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0xAAA9", Offset = "0xAAA9", VA = "0xAAA9")]
		public static UserLevelDic GetUserLevelDic(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0xAAAA", Offset = "0xAAAA", VA = "0xAAAA")]
		public static SlotArtikulTypesDic GetArtikulTypesBySlotId(this Dictionaries dict, int slotId)
		{
			return null;
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0xAAAB", Offset = "0xAAAB", VA = "0xAAAB")]
		public static GenderDic GetGenderDic(this Dictionaries dict, uint gender)
		{
			return null;
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E50")]
		[Address(RVA = "0xAAAC", Offset = "0xAAAC", VA = "0xAAAC")]
		public static ServiceOptionsDic GetServiceOptionDic(this Dictionaries dict, ServiceOptionsDic.Types.ServiceTypes serviceId)
		{
			return null;
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E51")]
		[Address(RVA = "0xAAAD", Offset = "0xAAAD", VA = "0xAAAD")]
		public static string GetUIResourceAssetId(this Dictionaries dict, string key)
		{
			return null;
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E52")]
		[Address(RVA = "0xAAAE", Offset = "0xAAAE", VA = "0xAAAE")]
		public static BattleAccountCoefs GetBattleAccountCoeffsDic(this Dictionaries dict)
		{
			return null;
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E53")]
		[Address(RVA = "0xAAAF", Offset = "0xAAAF", VA = "0xAAAF")]
		public static MonsterDic GetMonsterDic(this Dictionaries dict, uint monsterId)
		{
			return null;
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E54")]
		[Address(RVA = "0x1AAE", Offset = "0x1AAE", VA = "0x1AAE")]
		public static EventTypeDic GetEventTypeDic(this Dictionaries dict, uint type)
		{
			return null;
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E55")]
		[Address(RVA = "0xAAB0", Offset = "0xAAB0", VA = "0xAAB0")]
		public static EventCategoriesDic GetEventCategoriesDic(this Dictionaries dict, EventCategoriesDic.Types.Category id)
		{
			return null;
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E56")]
		[Address(RVA = "0xAAB1", Offset = "0xAAB1", VA = "0xAAB1")]
		public static EventTypeActionDic GetEventTypeActionDic(this Dictionaries dict, uint eventId, uint actionId)
		{
			return null;
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E57")]
		[Address(RVA = "0xAAB2", Offset = "0xAAB2", VA = "0xAAB2")]
		public static EventActionDic GetEventActionDic(this Dictionaries dict, uint actionId)
		{
			return null;
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E58")]
		[Address(RVA = "0xAAB3", Offset = "0xAAB3", VA = "0xAAB3")]
		public static EventTagDic GetEventTagDic(this Dictionaries dict, uint tagId)
		{
			return null;
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x1AA1", Offset = "0x1AA1", VA = "0x1AA1")]
		public static CollectionsDic GetCollectionsDic(this Dictionaries dict, uint collectionId)
		{
			return null;
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0xAAB4", Offset = "0xAAB4", VA = "0xAAB4")]
		public static CollectionRanksInfoDic GetCollectionRankInfoDic(this Dictionaries dict, uint rank)
		{
			return null;
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0xAAB5", Offset = "0xAAB5", VA = "0xAAB5")]
		public static bool TryGetDailyQuestsDic(this Dictionaries dict, uint questId, out DailyQuestsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0xAAB6", Offset = "0xAAB6", VA = "0xAAB6")]
		public static bool TryGetDailyGoalDic(this Dictionaries dict, uint questId, out DailyGoalDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0xAAB7", Offset = "0xAAB7", VA = "0xAAB7")]
		public static DailyQuestCategoriesDic GetDailyQuestCategoriesDic(this Dictionaries dict, uint categoryId)
		{
			return null;
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0x1D49", Offset = "0x1D49", VA = "0x1D49")]
		public static PromotionsDic GetPromotionsDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5F")]
		[Address(RVA = "0xAAB8", Offset = "0xAAB8", VA = "0xAAB8")]
		public static OptionTypesDic GetOptionTypesDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x6005E60")]
		[Address(RVA = "0xAAB9", Offset = "0xAAB9", VA = "0xAAB9")]
		public static bool TryGetDiamondOptionsDic(this Dictionaries dict, uint optionId, out DiamondOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x6005E61")]
		[Address(RVA = "0xAABA", Offset = "0xAABA", VA = "0xAABA")]
		public static bool TryGetCrystalEnergyOptionsDic(this Dictionaries dict, uint optionId, out CrystalEnergyOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x6005E62")]
		[Address(RVA = "0xAABB", Offset = "0xAABB", VA = "0xAABB")]
		public static bool TryGetNewResourceOptionsDic(this Dictionaries dict, uint optionId, out NewResourceOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[Token(Token = "0x6005E63")]
		[Address(RVA = "0xAABC", Offset = "0xAABC", VA = "0xAABC")]
		public static bool TryGetColossusFragmentsOptionsDic(this Dictionaries dict, uint optionId, out ColossusFragmentsOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Token(Token = "0x6005E64")]
		[Address(RVA = "0xAABD", Offset = "0xAABD", VA = "0xAABD")]
		public static bool TryGetArtikulOptionsDic(this Dictionaries dict, uint optionId, out ArtikulOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E65")]
		[Address(RVA = "0xAABE", Offset = "0xAABE", VA = "0xAABE")]
		public static StoneDic GetStoneDic(this Dictionaries dict, StonesTypes stone)
		{
			return null;
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E66")]
		[Address(RVA = "0xAABF", Offset = "0xAABF", VA = "0xAABF")]
		public static BossTypeDic GetBossTypeDic(this Dictionaries dict, int typeId)
		{
			return null;
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E67")]
		[Address(RVA = "0xAAC0", Offset = "0xAAC0", VA = "0xAAC0")]
		public static BonusDic GetBonusDic(this Dictionaries dict, uint bonusId)
		{
			return null;
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E68")]
		[Address(RVA = "0xAAC1", Offset = "0xAAC1", VA = "0xAAC1")]
		public static CurrenciesDic GetCurrenciesDic(this Dictionaries dict, uint currencyId)
		{
			return null;
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E69")]
		[Address(RVA = "0xAAC2", Offset = "0xAAC2", VA = "0xAAC2")]
		public static CurrenciesDic GetCurrenciesDic(this Dictionaries dict, string currencyCode)
		{
			return null;
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6A")]
		[Address(RVA = "0xAAC3", Offset = "0xAAC3", VA = "0xAAC3")]
		public static PaymentBonusesDic GetPaymentBonusDic(this Dictionaries dict, uint paymentBonusId)
		{
			return null;
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0x1D40", Offset = "0x1D40", VA = "0x1D40")]
		public static OptionStickerDic GetOptionStickerDic(this Dictionaries dict, uint stickerId)
		{
			return null;
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x00010F08 File Offset: 0x0000F108
		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0xAAC4", Offset = "0xAAC4", VA = "0xAAC4")]
		public static bool TryGetScriptsConstDic(this Dictionaries dict, string constName, out ScriptsConstsDic dic)
		{
			return default(bool);
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0xAAC5", Offset = "0xAAC5", VA = "0xAAC5")]
		public static ClanSeasonDic GetClanSeasonDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0xAAC6", Offset = "0xAAC6", VA = "0xAAC6")]
		public static SeasonLeagueDic GetSeasonLeagueDic(this Dictionaries dict, uint seasonId, uint leagueId)
		{
			return null;
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0xAAC7", Offset = "0xAAC7", VA = "0xAAC7")]
		public static CraftSchemeDic GetCraftSchemeDic(this Dictionaries dict, uint schemeId)
		{
			return null;
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E70")]
		[Address(RVA = "0xAAC8", Offset = "0xAAC8", VA = "0xAAC8")]
		public static SlotMachineSymbolDic GetSlotMachineSymbolDic(this Dictionaries dict, ulong symbolId)
		{
			return null;
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E71")]
		[Address(RVA = "0xAAC9", Offset = "0xAAC9", VA = "0xAAC9")]
		public static SlotMachineSymbolDic GetSlotMachineSymbolDic(this Dictionaries dict, SlotMachineSymbol symbol)
		{
			return null;
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E72")]
		[Address(RVA = "0xAACA", Offset = "0xAACA", VA = "0xAACA")]
		public static ChatRoomDic GetChatRoomDic(this Dictionaries dict, RoomKey.Types.ChatRoomTypes type)
		{
			return null;
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E73")]
		[Address(RVA = "0xAACB", Offset = "0xAACB", VA = "0xAACB")]
		public static ChatRoomDic GetDefaultChatRoomDic(this Dictionaries dict)
		{
			return null;
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E74")]
		[Address(RVA = "0xAACC", Offset = "0xAACC", VA = "0xAACC")]
		public static ChatBanDic GetChatBanDic(this Dictionaries dict, uint banId)
		{
			return null;
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E75")]
		[Address(RVA = "0xAACD", Offset = "0xAACD", VA = "0xAACD")]
		public static BlitzTournamentsDic GetBlitzTournamentsDic(this Dictionaries dict, uint typeId)
		{
			return null;
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E76")]
		[Address(RVA = "0xAACE", Offset = "0xAACE", VA = "0xAACE")]
		public static TournamentDic GetTournamentDic(this Dictionaries dict, uint type)
		{
			return null;
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E77")]
		[Address(RVA = "0x1E14", Offset = "0x1E14", VA = "0x1E14")]
		public static IsleDecorationsDic GetIsleDecorationsDic(this Dictionaries dictionaries, uint decorationId)
		{
			return null;
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E78")]
		[Address(RVA = "0xAACF", Offset = "0xAACF", VA = "0xAACF")]
		public static IsleAnimationsDic GetIsleAnimationDic(this Dictionaries dictionaries, uint animationId)
		{
			return null;
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E79")]
		[Address(RVA = "0x1B76", Offset = "0x1B76", VA = "0x1B76")]
		public static BossGroupDic GetBossGroupDic(this Dictionaries dict, uint groupId)
		{
			return null;
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0x1B70", Offset = "0x1B70", VA = "0x1B70")]
		public static BossCategoryDic GetBossCategoryDic(this Dictionaries dict, int category)
		{
			return null;
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0xAAD0", Offset = "0xAAD0", VA = "0xAAD0")]
		public static ProfessionDic GetProfessionDic(this Dictionaries dict, uint professionId)
		{
			return null;
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0xAAD1", Offset = "0xAAD1", VA = "0xAAD1")]
		public static DiscountsDic GetDiscountsDic(this Dictionaries dict, uint discountId)
		{
			return null;
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0xAAD2", Offset = "0xAAD2", VA = "0xAAD2")]
		public static ArtikulDismantleInfoDic GetDismantleInfoDic(this Dictionaries dict, uint artikulId)
		{
			return null;
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x00010F20 File Offset: 0x0000F120
		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0x1F77", Offset = "0x1F77", VA = "0x1F77")]
		public static bool TryGetMarketOptionsDic(this Dictionaries dict, uint optionId, out MarketOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x00010F38 File Offset: 0x0000F138
		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0xAAD3", Offset = "0xAAD3", VA = "0xAAD3")]
		public static bool TryGetHordeDic(this Dictionaries dict, uint mainMonsterId, out HordeDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E80")]
		[Address(RVA = "0xAAD4", Offset = "0xAAD4", VA = "0xAAD4")]
		public static MonsterHordesDic GetHordeMonsterDic(this Dictionaries dict, uint monsterId)
		{
			return null;
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E81")]
		[Address(RVA = "0xAAD5", Offset = "0xAAD5", VA = "0xAAD5")]
		public static MonsterHordesDic[] GetHordeMonstersByMainMonsterIdSorted(this Dictionaries dict, uint mainMonsterId)
		{
			return null;
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E82")]
		[Address(RVA = "0xAAD6", Offset = "0xAAD6", VA = "0xAAD6")]
		public static DuelTypesDict GetDuelTypeDic(this Dictionaries dict, uint duelType)
		{
			return null;
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E83")]
		[Address(RVA = "0xAAD7", Offset = "0xAAD7", VA = "0xAAD7")]
		public static DuelUserStateFlags[] GetDuelUserStateFlags(this Dictionaries dict, int flags)
		{
			return null;
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E84")]
		[Address(RVA = "0xAAD8", Offset = "0xAAD8", VA = "0xAAD8")]
		public static GreatRewardSets GetGreatRewardSet(this Dictionaries dict, uint setId)
		{
			return null;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E85")]
		[Address(RVA = "0xAAD9", Offset = "0xAAD9", VA = "0xAAD9")]
		public static RatingPrizeDic[] GetUserPrizesByKindId(this Dictionaries dict, uint kindId)
		{
			return null;
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E86")]
		[Address(RVA = "0xAADA", Offset = "0xAADA", VA = "0xAADA")]
		public static RatingPrizeDic[] GetClanPrizesByKindId(this Dictionaries dict, uint kindId)
		{
			return null;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E87")]
		[Address(RVA = "0x1DCA", Offset = "0x1DCA", VA = "0x1DCA")]
		public static RatingTypesDic GetRatingTypeDic(this Dictionaries dict, uint typeId)
		{
			return null;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E88")]
		[Address(RVA = "0xAADB", Offset = "0xAADB", VA = "0xAADB")]
		public static ClanLeagueDic GetClanLeagueDic(this Dictionaries dict, uint leagueId)
		{
			return null;
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0xAADC", Offset = "0xAADC", VA = "0xAADC")]
		public static ZigguratLevelDic GetZigguratLevelDic(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0xAADD", Offset = "0xAADD", VA = "0xAADD")]
		public static SeasonLeagueRewardsDic[] GetSeasonLeagueRewardsSorted(this Dictionaries dict, uint leagueId)
		{
			return null;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0xAADE", Offset = "0xAADE", VA = "0xAADE")]
		public static UserLevelsDiffShoppingDic GetShoppingDiff(this Dictionaries dict, uint level)
		{
			return null;
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0xAADF", Offset = "0xAADF", VA = "0xAADF")]
		public static ColossusDic GetColossusDic(this Dictionaries dict, uint colossusId)
		{
			return null;
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0xAAE0", Offset = "0xAAE0", VA = "0xAAE0")]
		public static DollsInfoDic GetDollInfoDic(this Dictionaries dict, ulong dollId)
		{
			return null;
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0xAAE1", Offset = "0xAAE1", VA = "0xAAE1")]
		public static ColossusPartiesInfoDic GetPartyInfoDic(this Dictionaries dict, uint partyId)
		{
			return null;
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x6005E8F")]
		[Address(RVA = "0xAAE2", Offset = "0xAAE2", VA = "0xAAE2")]
		public static int GetPortalStagesCount(this Dictionaries dict, uint portalId)
		{
			return 0;
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E90")]
		public static TListElement BinarySearch<TListElement, SValue>(in IList<TListElement> list, Func<TListElement, SValue> getter, SValue searchValue) where TListElement : class where SValue : IComparable
		{
			return null;
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E91")]
		[Address(RVA = "0xAAE3", Offset = "0xAAE3", VA = "0xAAE3")]
		public static TutorialUIPointerDic GetTutorialUIPointerDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E92")]
		[Address(RVA = "0xAAE4", Offset = "0xAAE4", VA = "0xAAE4")]
		public static List<UserAccountLevelsDic> GetUserAccountLevels(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E93")]
		[Address(RVA = "0xAAE5", Offset = "0xAAE5", VA = "0xAAE5")]
		public static List<ClanAccountLevelsDic> GetClanAccountLevels(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E94")]
		[Address(RVA = "0xAAE6", Offset = "0xAAE6", VA = "0xAAE6")]
		public static AccountDic GetAccountDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x6005E95")]
		[Address(RVA = "0x1D3F", Offset = "0x1D3F", VA = "0x1D3F")]
		public static bool TryGetAccountDic(this Dictionaries dict, uint id, out AccountDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x6005E96")]
		[Address(RVA = "0x1D43", Offset = "0x1D43", VA = "0x1D43")]
		public static bool TryGetAccountOptionsDicByAccountId(this Dictionaries dict, uint accountId, out List<AccountOptionsDic> result)
		{
			return default(bool);
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x6005E97")]
		[Address(RVA = "0xAAE7", Offset = "0xAAE7", VA = "0xAAE7")]
		public static bool TryGetAccountOptionsDicByOptionId(this Dictionaries dict, uint optionId, out AccountOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x6005E98")]
		[Address(RVA = "0xAAE8", Offset = "0xAAE8", VA = "0xAAE8")]
		public static bool TryGetEndlessPaymentOptionDicByOptionId(this Dictionaries dict, uint optionId, out EndlessPaymentOptionListOptionDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x6005E99")]
		[Address(RVA = "0xAAE9", Offset = "0xAAE9", VA = "0xAAE9")]
		public static bool TryGetRegularOptionsDicByOptionId(this Dictionaries dict, uint optionId, out RegularOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0xAAEA", Offset = "0xAAEA", VA = "0xAAEA")]
		public static AccountOptionsDic GetAccountOptionsDicByOptionId(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0xAAEB", Offset = "0xAAEB", VA = "0xAAEB")]
		public static UserSlotsDic GetUserSlotsDic(this Dictionaries dict, uint slotId)
		{
			return null;
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0xAAEC", Offset = "0xAAEC", VA = "0xAAEC")]
		public static PointsForMonsterDic GetPointPointsForMonsterDic(this Dictionaries dict, PointsForMonsterDic.Types.HzTypes type)
		{
			return null;
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9D")]
		[Address(RVA = "0xAAED", Offset = "0xAAED", VA = "0xAAED")]
		public static ClanBuildingLevelDic GetClanBuildingLevel(this Dictionaries dict, uint type, uint level)
		{
			return null;
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0xAAEE", Offset = "0xAAEE", VA = "0xAAEE")]
		public static SocialGiftDic GetGiftDic(this Dictionaries dict, uint giftId)
		{
			return null;
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0xAAEF", Offset = "0xAAEF", VA = "0xAAEF")]
		public static ClanBuildingViewDic GetClanBuildingView(this Dictionaries dict, uint type, uint level, uint cultId)
		{
			return null;
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0xAAF0", Offset = "0xAAF0", VA = "0xAAF0")]
		public static ClanBuildingTypeDic GetClanBuildingTypeDic(this Dictionaries dict, uint typeId)
		{
			return null;
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0xAAF1", Offset = "0xAAF1", VA = "0xAAF1")]
		public static UIElementsDic GetUIElementsDic(this Dictionaries dict, UIElementsDic.Types.UIElementId elementId)
		{
			return null;
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0xAAF2", Offset = "0xAAF2", VA = "0xAAF2")]
		public static LocalNotificationDic GetLocalNotificationDic(this Dictionaries dict, int id)
		{
			return null;
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0xAAF3", Offset = "0xAAF3", VA = "0xAAF3")]
		public static LocalNotificationScheduleDic GetLocalNotificationScheduleDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0xAAF4", Offset = "0xAAF4", VA = "0xAAF4")]
		public static NotificationGroupDic GetNotificationGroupDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0xAAF5", Offset = "0xAAF5", VA = "0xAAF5")]
		public static NotificationCategoryDic GetNotificationCategoryDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA6")]
		[Address(RVA = "0x1DDB", Offset = "0x1DDB", VA = "0x1DDB")]
		public static DollSkillDic GetDollSkillDic(this Dictionaries dict, uint skillId)
		{
			return null;
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA7")]
		[Address(RVA = "0x2240", Offset = "0x2240", VA = "0x2240")]
		public static BattleBonusMedal GetBattleBonusMedal(this Dictionaries dict, uint medalId)
		{
			return null;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0xAAF6", Offset = "0xAAF6", VA = "0xAAF6")]
		public static ClanRestrictionDic GetClanRestriction(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0xAAF7", Offset = "0xAAF7", VA = "0xAAF7")]
		public static bool TryGetGameEventDic(this Dictionaries dict, uint id, out GameEventDic evtDic)
		{
			return default(bool);
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0xAAF8", Offset = "0xAAF8", VA = "0xAAF8")]
		public static bool TryGetThemeDuelDic(this Dictionaries dict, ulong id, out ThemeDuelDic themeDuelDic)
		{
			return default(bool);
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x00011010 File Offset: 0x0000F210
		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0xAAF9", Offset = "0xAAF9", VA = "0xAAF9")]
		public static bool TryGetAnnouncementsDic(this Dictionaries dict, ulong id, out AnnouncementsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0xAAFA", Offset = "0xAAFA", VA = "0xAAFA")]
		public static bool TryGetCompetitionDic(this Dictionaries dict, uint id, out CompetitionDic result)
		{
			return default(bool);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0xAAFB", Offset = "0xAAFB", VA = "0xAAFB")]
		public static bool TryGetCompetitionRatingKindDic(this Dictionaries dict, uint id, out CompetitionRatingKindDic result)
		{
			return default(bool);
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x6005EAE")]
		[Address(RVA = "0x1D18", Offset = "0x1D18", VA = "0x1D18")]
		public static bool TryGetAntiqArtifact(this Dictionaries dicts, ulong id, out Antiq.Types.ArtifactsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00011070 File Offset: 0x0000F270
		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0x2A42", Offset = "0x2A42", VA = "0x2A42")]
		public static bool TryGetAntiqEffect(this Dictionaries dicts, ulong id, out Antiq.Types.EffectsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0xAAFC", Offset = "0xAAFC", VA = "0xAAFC")]
		public static Fresco.Types.GroupsDic GetFrescoGroupDic(this Dictionaries dict, ulong frescoGroupId)
		{
			return null;
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0xAAFD", Offset = "0xAAFD", VA = "0xAAFD")]
		public static Fresco.Types.FrescoDic GetFrescoDic(this Dictionaries dict, ulong frescoId)
		{
			return null;
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EB2")]
		[Address(RVA = "0xAAFE", Offset = "0xAAFE", VA = "0xAAFE")]
		public static IEnumerable<RegularOptionsDic> GetRegularOptionsDic(this Dictionaries dict, RegularOptionsDic.Types.Kind kindId)
		{
			return null;
		}
	}
}
