using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D4 RID: 4308
	[Token(Token = "0x20010D4")]
	public class SkillData
	{
		// Token: 0x060064ED RID: 25837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x1DA6", Offset = "0x1DA6", VA = "0x1DA6")]
		public SkillData(int id)
		{
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060064EE RID: 25838 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x1700146F")]
		public bool IsZero
		{
			[Token(Token = "0x60064EE")]
			[Address(RVA = "0x1DA5", Offset = "0x1DA5", VA = "0x1DA5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x1DE0", Offset = "0x1DE0", VA = "0x1DE0")]
		public string ToFormattedString()
		{
			return null;
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0xB0CA", Offset = "0xB0CA", VA = "0xB0CA")]
		public SkillData Clone()
		{
			return null;
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0xB0CB", Offset = "0xB0CB", VA = "0xB0CB")]
		public static SkillData CreateFromRaw(int skillId, long skillRawValue)
		{
			return null;
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0xB0CC", Offset = "0xB0CC", VA = "0xB0CC")]
		public static SkillData operator +(SkillData a, SkillData b)
		{
			return null;
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0xB0CD", Offset = "0xB0CD", VA = "0xB0CD")]
		public static SkillData operator -(SkillData a, SkillData b)
		{
			return null;
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F4")]
		[Address(RVA = "0xB0CE", Offset = "0xB0CE", VA = "0xB0CE")]
		[CompilerGenerated]
		private string <ToFormattedString>g__GetRelativeStringWithSign|6_0()
		{
			return null;
		}

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x10")]
		public long AbsoluteValue;

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x18")]
		public long RelativeValue;
	}
}
