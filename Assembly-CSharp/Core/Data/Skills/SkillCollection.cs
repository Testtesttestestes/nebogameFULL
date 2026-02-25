using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D2 RID: 4306
	[Token(Token = "0x20010D2")]
	public class SkillCollection : Dictionary<int, SkillData>
	{
		// Token: 0x060064DA RID: 25818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DA")]
		[Address(RVA = "0xB0BC", Offset = "0xB0BC", VA = "0xB0BC")]
		public SkillCollection()
		{
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DB")]
		[Address(RVA = "0x1F79", Offset = "0x1F79", VA = "0x1F79")]
		public SkillCollection(IList<long> raw)
		{
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DC")]
		[Address(RVA = "0x36DE", Offset = "0x36DE", VA = "0x36DE")]
		public SkillCollection(IList<uint> raw)
		{
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DD")]
		[Address(RVA = "0xB0BD", Offset = "0xB0BD", VA = "0xB0BD")]
		public SkillCollection(IList<int> raw)
		{
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064DE")]
		[Address(RVA = "0xB0BE", Offset = "0xB0BE", VA = "0xB0BE")]
		public SkillCollection GetAbsolute()
		{
			return null;
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x60064DF")]
		[Address(RVA = "0xB0BF", Offset = "0xB0BF", VA = "0xB0BF")]
		public bool HasAnyAbsolute()
		{
			return default(bool);
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x60064E0")]
		[Address(RVA = "0x36DF", Offset = "0x36DF", VA = "0x36DF")]
		public bool HasAnyRelative()
		{
			return default(bool);
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064E1")]
		[Address(RVA = "0x36E0", Offset = "0x36E0", VA = "0x36E0")]
		public SkillCollection GetRelative()
		{
			return null;
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0xB0C0", Offset = "0xB0C0", VA = "0xB0C0")]
		public SkillCollection Clone()
		{
			return null;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0xB0C1", Offset = "0xB0C1", VA = "0xB0C1")]
		public void CopyFrom(SkillCollection original)
		{
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0x1F7A", Offset = "0x1F7A", VA = "0x1F7A")]
		public static SkillCollection operator +(SkillCollection a, SkillCollection b)
		{
			return null;
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0xB0C2", Offset = "0xB0C2", VA = "0xB0C2")]
		public static SkillCollection operator -(SkillCollection a, SkillCollection b)
		{
			return null;
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0xB0C3", Offset = "0xB0C3", VA = "0xB0C3")]
		public SkillCollection MultiplyThisAbsoluteByRelative(SkillCollection multiplier)
		{
			return null;
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064E7")]
		[Address(RVA = "0xB0C4", Offset = "0xB0C4", VA = "0xB0C4")]
		public SkillCollection MultiplyByFloat(float multiplier)
		{
			return null;
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x60064E8")]
		[Address(RVA = "0xB0C5", Offset = "0xB0C5", VA = "0xB0C5")]
		public long GetAbsoluteTotal()
		{
			return 0L;
		}
	}
}
