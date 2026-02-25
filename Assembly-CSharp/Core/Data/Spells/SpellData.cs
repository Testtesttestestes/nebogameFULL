using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Core.Data.Effect;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Data.Spells
{
	// Token: 0x020010CF RID: 4303
	[Token(Token = "0x20010CF")]
	public class SpellData
	{
		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C0 RID: 25792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001462")]
		public virtual IBalanceSource Balance
		{
			[Token(Token = "0x60064BF")]
			[Address(RVA = "0xB0A7", Offset = "0xB0A7", VA = "0xB0A7", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C0")]
			[Address(RVA = "0xB0A8", Offset = "0xB0A8", VA = "0xB0A8", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060064C1 RID: 25793 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C2 RID: 25794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001463")]
		public SpellDic SpellDic
		{
			[Token(Token = "0x60064C1")]
			[Address(RVA = "0xB0A9", Offset = "0xB0A9", VA = "0xB0A9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C2")]
			[Address(RVA = "0xB0AA", Offset = "0xB0AA", VA = "0xB0AA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060064C3 RID: 25795 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C4 RID: 25796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001464")]
		public SpellLevelDic SpellLevelDic
		{
			[Token(Token = "0x60064C3")]
			[Address(RVA = "0xB0AB", Offset = "0xB0AB", VA = "0xB0AB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C4")]
			[Address(RVA = "0xB0AC", Offset = "0xB0AC", VA = "0xB0AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060064C5 RID: 25797 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C6 RID: 25798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001465")]
		public Dictionary<uint, EffectData> Effects
		{
			[Token(Token = "0x60064C5")]
			[Address(RVA = "0xB0AD", Offset = "0xB0AD", VA = "0xB0AD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C6")]
			[Address(RVA = "0xB0AE", Offset = "0xB0AE", VA = "0xB0AE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x17001466")]
		public uint Id
		{
			[Token(Token = "0x60064C7")]
			[Address(RVA = "0x1CFD", Offset = "0x1CFD", VA = "0x1CFD")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060064C8 RID: 25800 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x17001467")]
		public virtual uint Level
		{
			[Token(Token = "0x60064C8")]
			[Address(RVA = "0xB0AF", Offset = "0xB0AF", VA = "0xB0AF", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x17001468")]
		public bool IsCultSpell
		{
			[Token(Token = "0x60064C9")]
			[Address(RVA = "0x2143", Offset = "0x2143", VA = "0x2143")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060064CA RID: 25802 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x17001469")]
		public long ManaPriceOfUse
		{
			[Token(Token = "0x60064CA")]
			[Address(RVA = "0xB0B0", Offset = "0xB0B0", VA = "0xB0B0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x1700146A")]
		public long ManaBoostPriceOfUse
		{
			[Token(Token = "0x60064CB")]
			[Address(RVA = "0xB0B1", Offset = "0xB0B1", VA = "0xB0B1")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x000132F0 File Offset: 0x000114F0
		// (set) Token: 0x060064CD RID: 25805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700146B")]
		public virtual bool Enabled
		{
			[Token(Token = "0x60064CC")]
			[Address(RVA = "0xB0B2", Offset = "0xB0B2", VA = "0xB0B2", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60064CD")]
			[Address(RVA = "0xB0B3", Offset = "0xB0B3", VA = "0xB0B3", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700146C")]
		public ResourceSet PriceOfUse
		{
			[Token(Token = "0x60064CE")]
			[Address(RVA = "0x2A3B", Offset = "0x2A3B", VA = "0x2A3B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700146D")]
		public virtual AbstractSpellsBasedDescription Description
		{
			[Token(Token = "0x60064CF")]
			[Address(RVA = "0xB0B4", Offset = "0xB0B4", VA = "0xB0B4", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D0")]
		[Address(RVA = "0xB0B5", Offset = "0xB0B5", VA = "0xB0B5")]
		public SpellData()
		{
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D1")]
		[Address(RVA = "0xB0B6", Offset = "0xB0B6", VA = "0xB0B6")]
		public SpellData(SpellDic spellDic, SpellLevelDic spellLevelDic)
		{
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D2")]
		[Address(RVA = "0xB0B7", Offset = "0xB0B7", VA = "0xB0B7")]
		public SpellData(uint spellId, uint level, Dictionaries dict)
		{
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064D3")]
		public static T Create<T>(SpellDic spellDic, SpellLevelDic spellLevelDic) where T : SpellData, new()
		{
			return null;
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064D4")]
		public static T Create<T>(uint spellId, uint spellLevel) where T : SpellData, new()
		{
			return null;
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064D5")]
		public static T Create<T>(ArtikulDic.Types.SpellInfo spellInfo) where T : SpellData, new()
		{
			return null;
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x60064D6")]
		[Address(RVA = "0xB0B8", Offset = "0xB0B8", VA = "0xB0B8")]
		public static int SortSpells(SpellData a, SpellData b)
		{
			return 0;
		}

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x18")]
		public Skills SpellSkills;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x1C")]
		public Skills SpellSkillsNext;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x24")]
		private ResourceSet _priceOfUse;

		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x28")]
		protected AbstractSpellsBasedDescription _description;
	}
}
