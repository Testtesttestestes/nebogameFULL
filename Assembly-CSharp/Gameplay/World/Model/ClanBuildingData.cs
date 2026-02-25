using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	public class ClanBuildingData : BaseBuildingData<ClanBuildingTypes>
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x17000326")]
		public override ClanBuildingTypes Type
		{
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x65C1", Offset = "0x65C1", VA = "0x65C1", Slot = "18")]
			get
			{
				return ClanBuildingTypes.UnknownClanBuildingType;
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x65C2", Offset = "0x65C2", VA = "0x65C2")]
		private ClanBuildingData(Dictionaries dictionaries)
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013E4")]
		[Address(RVA = "0x1DEB", Offset = "0x1DEB", VA = "0x1DEB")]
		public static ClanBuildingData Create(BuildingInfo buildingInfo, uint cultId, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000327")]
		public override string Title
		{
			[Token(Token = "0x60013E5")]
			[Address(RVA = "0x65C3", Offset = "0x65C3", VA = "0x65C3", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000328")]
		public override string Description
		{
			[Token(Token = "0x60013E6")]
			[Address(RVA = "0x65C4", Offset = "0x65C4", VA = "0x65C4", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000329")]
		public override string UpgradeText
		{
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x65C5", Offset = "0x65C5", VA = "0x65C5", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032A")]
		public override string IsleViewAssetId
		{
			[Token(Token = "0x60013E8")]
			[Address(RVA = "0x65C6", Offset = "0x65C6", VA = "0x65C6", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032B")]
		public override string IsleViewUiAssetId
		{
			[Token(Token = "0x60013E9")]
			[Address(RVA = "0x65C7", Offset = "0x65C7", VA = "0x65C7", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032C")]
		public override string MiniatureAssetId
		{
			[Token(Token = "0x60013EA")]
			[Address(RVA = "0x65C8", Offset = "0x65C8", VA = "0x65C8", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x1700032D")]
		public override ulong UpgradeTime
		{
			[Token(Token = "0x60013EB")]
			[Address(RVA = "0x65C9", Offset = "0x65C9", VA = "0x65C9", Slot = "11")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x1700032E")]
		public override bool IsMaxLevel
		{
			[Token(Token = "0x60013EC")]
			[Address(RVA = "0x65CA", Offset = "0x65CA", VA = "0x65CA", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700032F")]
		public override RequirementDic UpgradeRequirements
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x65CB", Offset = "0x65CB", VA = "0x65CB", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x65CC", Offset = "0x65CC", VA = "0x65CC", Slot = "14")]
		public override Dictionary<string, string> GetReplacementsForLevel(uint level, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x65CD", Offset = "0x65CD", VA = "0x65CD", Slot = "17")]
		protected override void ValidateLevelDependentProperties()
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x65CE", Offset = "0x65CE", VA = "0x65CE", Slot = "16")]
		public override RequirementsInfoProvider GetUpgradeRequirementsProvider(UserData owner, UserData user)
		{
			return null;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000330")]
		public override ResourceSet BuildPrice
		{
			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x65CF", Offset = "0x65CF", VA = "0x65CF", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x28")]
		private ClanBuildingTypes _type;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x2C")]
		private uint _cultId;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x30")]
		private ClanBuildingViewDic _currentBuildingLevelViewDic;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x34")]
		private ClanBuildingViewDic _nextBuildingLevelViewDic;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x38")]
		private ClanBuildingLevelDic _currentClanBuildingLevelDic;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x3C")]
		private ClanBuildingLevelDic _nextClanBuildingLevelDic;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x40")]
		private ClanBuildingTypeDic _clanBuildingTypeDic;
	}
}
