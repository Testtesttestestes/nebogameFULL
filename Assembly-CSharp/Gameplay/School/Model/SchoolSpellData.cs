using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Core.Data.Effect;
using Core.Data.Spells;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.School.Model
{
	// Token: 0x02000648 RID: 1608
	[Token(Token = "0x2000648")]
	public class SchoolSpellData : SpellData
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000752")]
		public Dictionary<uint, EffectData> EffectsNextLevel
		{
			[Token(Token = "0x60026F4")]
			[Address(RVA = "0x7829", Offset = "0x7829", VA = "0x7829")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F5")]
			[Address(RVA = "0x782A", Offset = "0x782A", VA = "0x782A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000753")]
		public SpellLevelDic SpellNextLevelDic
		{
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x782B", Offset = "0x782B", VA = "0x782B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x782C", Offset = "0x782C", VA = "0x782C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x17000754")]
		public override uint Level
		{
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x782D", Offset = "0x782D", VA = "0x782D", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000755")]
		public string IconAssetId
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x782E", Offset = "0x782E", VA = "0x782E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x00007770 File Offset: 0x00005970
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000756")]
		public uint BackTime
		{
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x222B", Offset = "0x222B", VA = "0x222B")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x782F", Offset = "0x782F", VA = "0x782F")]
			set
			{
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x00007788 File Offset: 0x00005988
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000757")]
		public uint ActionBacktime
		{
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x7830", Offset = "0x7830", VA = "0x7830")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60026FD")]
			[Address(RVA = "0x7831", Offset = "0x7831", VA = "0x7831")]
			set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000758")]
		public bool IsLearning
		{
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x7832", Offset = "0x7832", VA = "0x7832")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x17000759")]
		public bool IsMaxLevel
		{
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x7833", Offset = "0x7833", VA = "0x7833")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700075A")]
		public ResourceSet PriceOfUseNext
		{
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x7834", Offset = "0x7834", VA = "0x7834")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x1700075B")]
		public long ManaPriceOfUseNext
		{
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x7835", Offset = "0x7835", VA = "0x7835")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700075C")]
		public virtual ResourceSet LearnPrice
		{
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x7836", Offset = "0x7836", VA = "0x7836", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x1700075D")]
		public virtual double PriceCoef
		{
			[Token(Token = "0x6002703")]
			[Address(RVA = "0x7837", Offset = "0x7837", VA = "0x7837", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x7838", Offset = "0x7838", VA = "0x7838")]
		public SchoolSpellData(ShortSpellInfo shortSpellInfo, Dictionaries dict)
		{
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x7839", Offset = "0x7839", VA = "0x7839")]
		public SchoolSpellData(ShortSpellInfo shortSpellInfo, IBalanceSource balance, Dictionaries dict)
		{
		}

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x34")]
		public ShortSpellInfo ShortSpellInfo;

		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x38")]
		private BackTime _backTime;

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x3C")]
		private BackTime _actionBackTime;

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x40")]
		private ResourceSet _priceOfUseNext;
	}
}
