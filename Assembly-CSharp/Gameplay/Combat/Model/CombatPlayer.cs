using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Effect;
using Core.Data.Skills;
using Gameplay.Combat.Factories;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Combat.Model
{
	// Token: 0x02000998 RID: 2456
	[Token(Token = "0x2000998")]
	public class CombatPlayer : IDisposable
	{
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x17000B80")]
		public ulong UserId
		{
			[Token(Token = "0x6003A9E")]
			[Address(RVA = "0x1B1F", Offset = "0x1B1F", VA = "0x1B1F")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B81")]
		public PlayerInfo PlayerInfo
		{
			[Token(Token = "0x6003A9F")]
			[Address(RVA = "0x8A14", Offset = "0x8A14", VA = "0x8A14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA0")]
			[Address(RVA = "0x8A15", Offset = "0x8A15", VA = "0x8A15")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B82")]
		public List<CombatSpellData> Spells
		{
			[Token(Token = "0x6003AA1")]
			[Address(RVA = "0x8A16", Offset = "0x8A16", VA = "0x8A16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA2")]
			[Address(RVA = "0x8A17", Offset = "0x8A17", VA = "0x8A17")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B83")]
		public ICombatSpellDataFactory SpellFactory
		{
			[Token(Token = "0x6003AA3")]
			[Address(RVA = "0x8A18", Offset = "0x8A18", VA = "0x8A18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA4")]
			[Address(RVA = "0x8A19", Offset = "0x8A19", VA = "0x8A19")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B84")]
		public UserData User
		{
			[Token(Token = "0x6003AA5")]
			[Address(RVA = "0x8A1A", Offset = "0x8A1A", VA = "0x8A1A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA6")]
			[Address(RVA = "0x8A1B", Offset = "0x8A1B", VA = "0x8A1B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x17000B85")]
		public uint Level
		{
			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x8A1C", Offset = "0x8A1C", VA = "0x8A1C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x17000B86")]
		public RankTypes Rank
		{
			[Token(Token = "0x6003AA8")]
			[Address(RVA = "0x8A1D", Offset = "0x8A1D", VA = "0x8A1D")]
			get
			{
				return RankTypes.UnknownRankType;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x17000B87")]
		public bool HasStunned
		{
			[Token(Token = "0x6003AA9")]
			[Address(RVA = "0x8A1E", Offset = "0x8A1E", VA = "0x8A1E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x17000B88")]
		public bool HasSpellBlocked
		{
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x8A1F", Offset = "0x8A1F", VA = "0x8A1F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x8A20", Offset = "0x8A20", VA = "0x8A20", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x8A21", Offset = "0x8A21", VA = "0x8A21")]
		public CombatPlayer(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellFactory)
		{
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x8A22", Offset = "0x8A22", VA = "0x8A22")]
		private List<CombatSpellData> GetSpellsAndElixirs()
		{
			return null;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x8A23", Offset = "0x8A23", VA = "0x8A23")]
		public bool TryGetSpell(SpellKey key, out CombatSpellData spell)
		{
			return default(bool);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x8A24", Offset = "0x8A24", VA = "0x8A24", Slot = "6")]
		public virtual void SetPlayerSkills(IList<PlayerSkill> value)
		{
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x17000B89")]
		public long CurrentMana
		{
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x8A25", Offset = "0x8A25", VA = "0x8A25")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x17000B8A")]
		public long TotalMana
		{
			[Token(Token = "0x6003AB1")]
			[Address(RVA = "0x8A26", Offset = "0x8A26", VA = "0x8A26")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x17000B8B")]
		public long CurrentHealth
		{
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x8A27", Offset = "0x8A27", VA = "0x8A27")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x17000B8C")]
		public long TotalHealth
		{
			[Token(Token = "0x6003AB3")]
			[Address(RVA = "0x8A28", Offset = "0x8A28", VA = "0x8A28")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x17000B8D")]
		public long CurrentExtraHealth
		{
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x8A29", Offset = "0x8A29", VA = "0x8A29")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x17000B8E")]
		public long TotalExtraHealth
		{
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x8A2A", Offset = "0x8A2A", VA = "0x8A2A")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x17000B8F")]
		public long CurrentManaBoost
		{
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x8A2B", Offset = "0x8A2B", VA = "0x8A2B")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x17000B90")]
		public long TotalManaBoost
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x8A2C", Offset = "0x8A2C", VA = "0x8A2C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B91")]
		public virtual List<int> FiltredAbsoluteSkillsIndexes
		{
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x8A2D", Offset = "0x8A2D", VA = "0x8A2D", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<Antiq.Types.EffectsDic.Types.EffectID> AntiqEffectIndexes;

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x1C")]
		public PetData Pet;

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x20")]
		public CultDic CultDic;

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x24")]
		public List<EffectData> CurrentLongEffects;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x28")]
		public long LastHealthDelta;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x30")]
		public long LastManaDelta;

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x38")]
		public long TotalHealthDelta;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0x40")]
		public long TotalManaDelta;

		// Token: 0x0400206B RID: 8299
		[Token(Token = "0x400206B")]
		[FieldOffset(Offset = "0x48")]
		public long LastExtraHealthDelta;

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		[FieldOffset(Offset = "0x50")]
		public bool SkillsNumbersEnabled;

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		[FieldOffset(Offset = "0x54")]
		public uint LoggedUserSide;

		// Token: 0x0400206E RID: 8302
		[Token(Token = "0x400206E")]
		[FieldOffset(Offset = "0x58")]
		public Skills AbsoluteSkills;

		// Token: 0x0400206F RID: 8303
		[Token(Token = "0x400206F")]
		[FieldOffset(Offset = "0x5C")]
		public Skills ReleativeSkills;

		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		[FieldOffset(Offset = "0x60")]
		private List<int> _absoluteSkillsIndexes;
	}
}
