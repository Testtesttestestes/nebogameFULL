using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Data
{
	// Token: 0x020010BF RID: 4287
	[Token(Token = "0x20010BF")]
	public class ModifierData
	{
		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06006411 RID: 25617 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006412 RID: 25618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001421")]
		public ModifierDic ModifierDic
		{
			[Token(Token = "0x6006411")]
			[Address(RVA = "0xB008", Offset = "0xB008", VA = "0xB008")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006412")]
			[Address(RVA = "0xB009", Offset = "0xB009", VA = "0xB009")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06006413 RID: 25619 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006414 RID: 25620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001422")]
		public SpellModifierInfo ModifierInfo
		{
			[Token(Token = "0x6006413")]
			[Address(RVA = "0xB00A", Offset = "0xB00A", VA = "0xB00A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006414")]
			[Address(RVA = "0xB00B", Offset = "0xB00B", VA = "0xB00B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006415")]
		[Address(RVA = "0xB00C", Offset = "0xB00C", VA = "0xB00C")]
		public ModifierData(ModifierDic dict, SpellModifierInfo modInfo)
		{
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x17001423")]
		public uint SpellId
		{
			[Token(Token = "0x6006416")]
			[Address(RVA = "0xB00D", Offset = "0xB00D", VA = "0xB00D")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x17001424")]
		public uint EffectId
		{
			[Token(Token = "0x6006417")]
			[Address(RVA = "0xB00E", Offset = "0xB00E", VA = "0xB00E")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006418 RID: 25624 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6006418")]
		[Address(RVA = "0xB00F", Offset = "0xB00F", VA = "0xB00F")]
		public bool CompareTypeOfSkills(ModifierData mod)
		{
			return default(bool);
		}

		// Token: 0x06006419 RID: 25625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006419")]
		[Address(RVA = "0x36EB", Offset = "0x36EB", VA = "0x36EB")]
		public static List<ModifierData> CalculateSummMods(List<ModifierData> modifiers)
		{
			return null;
		}

		// Token: 0x0600641A RID: 25626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600641A")]
		[Address(RVA = "0x36E2", Offset = "0x36E2", VA = "0x36E2")]
		public static void SummMods(List<ModifierData> source)
		{
		}

		// Token: 0x0600641B RID: 25627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600641B")]
		[Address(RVA = "0xB010", Offset = "0xB010", VA = "0xB010")]
		public static ModifierData AddModificator(ModifierData m1, ModifierData m2)
		{
			return null;
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600641C")]
		[Address(RVA = "0xB011", Offset = "0xB011", VA = "0xB011")]
		public static List<ModifierData> ParseModifiers(IList<SpellModifierInfo> modifiers)
		{
			return null;
		}

		// Token: 0x0600641D RID: 25629 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x600641D")]
		[Address(RVA = "0xB012", Offset = "0xB012", VA = "0xB012")]
		public static bool IsProcent(long value)
		{
			return default(bool);
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x600641E")]
		[Address(RVA = "0xB013", Offset = "0xB013", VA = "0xB013")]
		public static long ConvertModificatorValueToValue(long value)
		{
			return 0L;
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x600641F")]
		[Address(RVA = "0xB014", Offset = "0xB014", VA = "0xB014")]
		public static long ConvertValueToModificatorValue(long value, bool isProcent)
		{
			return 0L;
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006420")]
		[Address(RVA = "0x2162", Offset = "0x2162", VA = "0x2162")]
		public static string FormatValue(long value)
		{
			return null;
		}

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0x10")]
		public Skills UserSkills;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x14")]
		public Skills ArtifactSkills;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x18")]
		public Skills SpellSkills;
	}
}
