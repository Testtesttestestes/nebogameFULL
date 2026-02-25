using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Data.Spells;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Dic;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099A RID: 2458
	[Token(Token = "0x200099A")]
	public class CombatSpellData : SpellData
	{
		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06003ABC RID: 15036 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003ABD RID: 15037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B92")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6003ABC")]
			[Address(RVA = "0x8A31", Offset = "0x8A31", VA = "0x8A31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003ABD")]
			[Address(RVA = "0x8A32", Offset = "0x8A32", VA = "0x8A32")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B93")]
		public ArtifactData Artifact
		{
			[Token(Token = "0x6003ABE")]
			[Address(RVA = "0x8A33", Offset = "0x8A33", VA = "0x8A33")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003ABF")]
			[Address(RVA = "0x8A34", Offset = "0x8A34", VA = "0x8A34")]
			set
			{
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B94")]
		public uint Cooldown
		{
			[Token(Token = "0x6003AC0")]
			[Address(RVA = "0x8A35", Offset = "0x8A35", VA = "0x8A35")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003AC1")]
			[Address(RVA = "0x8A36", Offset = "0x8A36", VA = "0x8A36")]
			set
			{
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x0000BD00 File Offset: 0x00009F00
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B95")]
		public int Count
		{
			[Token(Token = "0x6003AC2")]
			[Address(RVA = "0x8A37", Offset = "0x8A37", VA = "0x8A37")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003AC3")]
			[Address(RVA = "0x8A38", Offset = "0x8A38", VA = "0x8A38")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x17000B96")]
		public override uint Level
		{
			[Token(Token = "0x6003AC4")]
			[Address(RVA = "0x8A39", Offset = "0x8A39", VA = "0x8A39", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B97")]
		public override IBalanceSource Balance
		{
			[Token(Token = "0x6003AC5")]
			[Address(RVA = "0x8A3A", Offset = "0x8A3A", VA = "0x8A3A", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AC6")]
			[Address(RVA = "0x8A3B", Offset = "0x8A3B", VA = "0x8A3B", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x17000B98")]
		public bool IsUnblockable
		{
			[Token(Token = "0x6003AC7")]
			[Address(RVA = "0x8A3C", Offset = "0x8A3C", VA = "0x8A3C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06003AC8 RID: 15048 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x17000B99")]
		public bool IsBlockedByUserSkill
		{
			[Token(Token = "0x6003AC8")]
			[Address(RVA = "0x8A3D", Offset = "0x8A3D", VA = "0x8A3D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x0000BD60 File Offset: 0x00009F60
		// (set) Token: 0x06003ACA RID: 15050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9A")]
		public virtual bool Selected
		{
			[Token(Token = "0x6003AC9")]
			[Address(RVA = "0x8A3E", Offset = "0x8A3E", VA = "0x8A3E", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003ACA")]
			[Address(RVA = "0x8A3F", Offset = "0x8A3F", VA = "0x8A3F", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x17000B9B")]
		public virtual bool Visible
		{
			[Token(Token = "0x6003ACB")]
			[Address(RVA = "0x8A40", Offset = "0x8A40", VA = "0x8A40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06003ACC RID: 15052 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x17000B9C")]
		public bool Selectable
		{
			[Token(Token = "0x6003ACC")]
			[Address(RVA = "0x8A41", Offset = "0x8A41", VA = "0x8A41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x17000B9D")]
		public bool IsForceEffect
		{
			[Token(Token = "0x6003ACD")]
			[Address(RVA = "0x8A42", Offset = "0x8A42", VA = "0x8A42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06003ACE RID: 15054 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x17000B9E")]
		public bool IsFriendlyTarget
		{
			[Token(Token = "0x6003ACE")]
			[Address(RVA = "0x8A43", Offset = "0x8A43", VA = "0x8A43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x17000B9F")]
		public bool IsUserBehaviorType
		{
			[Token(Token = "0x6003ACF")]
			[Address(RVA = "0x8A44", Offset = "0x8A44", VA = "0x8A44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06003AD0 RID: 15056 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x17000BA0")]
		public bool IsFieldBehaviorType
		{
			[Token(Token = "0x6003AD0")]
			[Address(RVA = "0x8A45", Offset = "0x8A45", VA = "0x8A45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x17000BA1")]
		public override bool Enabled
		{
			[Token(Token = "0x6003AD1")]
			[Address(RVA = "0x8A46", Offset = "0x8A46", VA = "0x8A46", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06003AD2 RID: 15058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BA2")]
		public string Title
		{
			[Token(Token = "0x6003AD2")]
			[Address(RVA = "0x8A47", Offset = "0x8A47", VA = "0x8A47")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BA3")]
		public override AbstractSpellsBasedDescription Description
		{
			[Token(Token = "0x6003AD3")]
			[Address(RVA = "0x8A48", Offset = "0x8A48", VA = "0x8A48", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BA4")]
		public List<ModifierData> ModificatorsFromActiveArtifacts
		{
			[Token(Token = "0x6003AD4")]
			[Address(RVA = "0x8A49", Offset = "0x8A49", VA = "0x8A49")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BA5")]
		public virtual string AnimationAssetId
		{
			[Token(Token = "0x6003AD5")]
			[Address(RVA = "0x8A4A", Offset = "0x8A4A", VA = "0x8A4A", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x8A4B", Offset = "0x8A4B", VA = "0x8A4B")]
		public CombatSpellData()
		{
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x8A4C", Offset = "0x8A4C", VA = "0x8A4C")]
		public CombatSpellData(SpellDic spellDic, SpellLevelDic spellLevelDic)
		{
		}

		// Token: 0x04002073 RID: 8307
		[Token(Token = "0x4002073")]
		[FieldOffset(Offset = "0x2C")]
		private ArtifactData _artifact;

		// Token: 0x04002074 RID: 8308
		[Token(Token = "0x4002074")]
		[FieldOffset(Offset = "0x30")]
		private uint _cooldown;

		// Token: 0x04002076 RID: 8310
		[Token(Token = "0x4002076")]
		[FieldOffset(Offset = "0x38")]
		public SpellCombat SpellCombatInfo;

		// Token: 0x04002078 RID: 8312
		[Token(Token = "0x4002078")]
		[FieldOffset(Offset = "0x40")]
		public bool UseFlag;

		// Token: 0x04002079 RID: 8313
		[Token(Token = "0x4002079")]
		[FieldOffset(Offset = "0x41")]
		public bool ExitFromCooldownFlag;

		// Token: 0x0400207A RID: 8314
		[Token(Token = "0x400207A")]
		[FieldOffset(Offset = "0x42")]
		public bool StrodeFlag;
	}
}
