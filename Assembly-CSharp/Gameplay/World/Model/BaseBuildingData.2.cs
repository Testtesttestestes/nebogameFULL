using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.World.Model
{
	// Token: 0x02000362 RID: 866
	[Token(Token = "0x2000362")]
	public abstract class BaseBuildingData : IDisposable
	{
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000314")]
		private protected Dictionaries Dictionaries
		{
			[Token(Token = "0x60013C5")]
			[Address(RVA = "0x65B2", Offset = "0x65B2", VA = "0x65B2")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60013C6")]
			[Address(RVA = "0x65B3", Offset = "0x65B3", VA = "0x65B3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060013C7 RID: 5063
		[Token(Token = "0x17000315")]
		public abstract string Title { [Token(Token = "0x60013C7")] get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060013C8 RID: 5064
		[Token(Token = "0x17000316")]
		public abstract string Description { [Token(Token = "0x60013C8")] get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060013C9 RID: 5065
		[Token(Token = "0x17000317")]
		public abstract string UpgradeText { [Token(Token = "0x60013C9")] get; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060013CA RID: 5066
		[Token(Token = "0x17000318")]
		public abstract string IsleViewAssetId { [Token(Token = "0x60013CA")] get; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060013CB RID: 5067
		[Token(Token = "0x17000319")]
		public abstract string IsleViewUiAssetId { [Token(Token = "0x60013CB")] get; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060013CC RID: 5068
		[Token(Token = "0x1700031A")]
		public abstract string MiniatureAssetId { [Token(Token = "0x60013CC")] get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060013CD RID: 5069
		[Token(Token = "0x1700031B")]
		public abstract ulong UpgradeTime { [Token(Token = "0x60013CD")] get; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060013CE RID: 5070
		[Token(Token = "0x1700031C")]
		public abstract bool IsMaxLevel { [Token(Token = "0x60013CE")] get; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060013CF RID: 5071
		[Token(Token = "0x1700031D")]
		public abstract RequirementDic UpgradeRequirements { [Token(Token = "0x60013CF")] get; }

		// Token: 0x060013D0 RID: 5072
		[Token(Token = "0x60013D0")]
		public abstract Dictionary<string, string> GetReplacementsForLevel(uint level, Dictionaries dictionaries);

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00004BD8 File Offset: 0x00002DD8
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031E")]
		public uint BuildingViewId
		{
			[Token(Token = "0x60013D1")]
			[Address(RVA = "0x65B4", Offset = "0x65B4", VA = "0x65B4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60013D2")]
			[Address(RVA = "0x65B5", Offset = "0x65B5", VA = "0x65B5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x1700031F")]
		public bool IsUpgrading
		{
			[Token(Token = "0x60013D3")]
			[Address(RVA = "0x2227", Offset = "0x2227", VA = "0x2227")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x17000320")]
		public uint Level
		{
			[Token(Token = "0x60013D4")]
			[Address(RVA = "0x65B6", Offset = "0x65B6", VA = "0x65B6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x17000321")]
		public uint TypeUint
		{
			[Token(Token = "0x60013D5")]
			[Address(RVA = "0x1DEC", Offset = "0x1DEC", VA = "0x1DEC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000322")]
		public BackTime UpgradeBacktime
		{
			[Token(Token = "0x60013D6")]
			[Address(RVA = "0x65B7", Offset = "0x65B7", VA = "0x65B7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013D7")]
			[Address(RVA = "0x65B8", Offset = "0x65B8", VA = "0x65B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00004C38 File Offset: 0x00002E38
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000323")]
		public double BuildPriceCoeff
		{
			[Token(Token = "0x60013D8")]
			[Address(RVA = "0x65B9", Offset = "0x65B9", VA = "0x65B9")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60013D9")]
			[Address(RVA = "0x65BA", Offset = "0x65BA", VA = "0x65BA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060013DA RID: 5082
		[Token(Token = "0x17000324")]
		public abstract ResourceSet BuildPrice { [Token(Token = "0x60013DA")] get; }

		// Token: 0x060013DB RID: 5083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x65BB", Offset = "0x65BB", VA = "0x65BB")]
		protected BaseBuildingData(Dictionaries dictionaries)
		{
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x65BC", Offset = "0x65BC", VA = "0x65BC")]
		public void SetUpgradeTimer(ulong value)
		{
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x65BD", Offset = "0x65BD", VA = "0x65BD", Slot = "16")]
		public virtual RequirementsInfoProvider GetUpgradeRequirementsProvider(UserData owner, UserData user)
		{
			return null;
		}

		// Token: 0x060013DE RID: 5086
		[Token(Token = "0x60013DE")]
		protected abstract void ValidateLevelDependentProperties();

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000325")]
		public ResourceSet AcceleratePrice
		{
			[Token(Token = "0x60013DF")]
			[Address(RVA = "0x65BE", Offset = "0x65BE", VA = "0x65BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x65BF", Offset = "0x65BF", VA = "0x65BF")]
		public void SetLevel(uint level)
		{
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x65C0", Offset = "0x65C0", VA = "0x65C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0xC")]
		protected BuildingInfo _buildingInfo;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x20")]
		private double _moneyRealToTimeRate;
	}
}
