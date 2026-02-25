using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	public class UserBuildingData : BaseBuildingData<UserBuildingTypes>
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x17000345")]
		public override UserBuildingTypes Type
		{
			[Token(Token = "0x600143B")]
			[Address(RVA = "0x660A", Offset = "0x660A", VA = "0x660A", Slot = "18")]
			get
			{
				return UserBuildingTypes.UnknownUserBuildingType;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000346")]
		public override string Title
		{
			[Token(Token = "0x600143C")]
			[Address(RVA = "0x660B", Offset = "0x660B", VA = "0x660B", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000347")]
		public override string Description
		{
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x660C", Offset = "0x660C", VA = "0x660C", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000348")]
		public override string UpgradeText
		{
			[Token(Token = "0x600143E")]
			[Address(RVA = "0x660D", Offset = "0x660D", VA = "0x660D", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000349")]
		public override string IsleViewAssetId
		{
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x660E", Offset = "0x660E", VA = "0x660E", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034A")]
		public override string IsleViewUiAssetId
		{
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x660F", Offset = "0x660F", VA = "0x660F", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034B")]
		public override string MiniatureAssetId
		{
			[Token(Token = "0x6001441")]
			[Address(RVA = "0x6610", Offset = "0x6610", VA = "0x6610", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x1700034C")]
		public override ulong UpgradeTime
		{
			[Token(Token = "0x6001442")]
			[Address(RVA = "0x6611", Offset = "0x6611", VA = "0x6611", Slot = "11")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x1700034D")]
		public override bool IsMaxLevel
		{
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x6612", Offset = "0x6612", VA = "0x6612", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034E")]
		public override RequirementDic UpgradeRequirements
		{
			[Token(Token = "0x6001444")]
			[Address(RVA = "0x6613", Offset = "0x6613", VA = "0x6613", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x6614", Offset = "0x6614", VA = "0x6614")]
		private UserBuildingData(Dictionaries dictionaries)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x6615", Offset = "0x6615", VA = "0x6615", Slot = "17")]
		protected override void ValidateLevelDependentProperties()
		{
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700034F")]
		public override ResourceSet BuildPrice
		{
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x6616", Offset = "0x6616", VA = "0x6616", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001448")]
		[Address(RVA = "0x1E04", Offset = "0x1E04", VA = "0x1E04")]
		public static UserBuildingData Create(UserBuildingInfo buildingInfo, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001449")]
		[Address(RVA = "0x6617", Offset = "0x6617", VA = "0x6617", Slot = "14")]
		public override Dictionary<string, string> GetReplacementsForLevel(uint level, Dictionaries dictionaries)
		{
			return null;
		}

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x28")]
		private UserBuildingTypes _type;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x2C")]
		private UserBuildingInfo _userBuildingInfo;

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x30")]
		private UserBuildingTypeDic _userBuildingTypeDic;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x34")]
		private UserBuildingViewsDic _userBuildingViewsDic;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x38")]
		private UserBuildingLevelDic _currentUserBuildingLevelDic;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x3C")]
		private UserBuildingLevelDic _nextBuildingLevelDic;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[FieldOffset(Offset = "0x40")]
		private RequirementDic _upgradeRequirements;
	}
}
