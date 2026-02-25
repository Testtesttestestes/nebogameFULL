using System;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D5 RID: 4309
	[Token(Token = "0x20010D5")]
	public class Skill
	{
		// Token: 0x060064F5 RID: 25845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0xB0CF", Offset = "0xB0CF", VA = "0xB0CF", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x17001470")]
		public bool IsProcent
		{
			[Token(Token = "0x60064F6")]
			[Address(RVA = "0x2161", Offset = "0x2161", VA = "0x2161")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0xB0D0", Offset = "0xB0D0", VA = "0xB0D0")]
		public bool EqualType(Skill skill)
		{
			return default(bool);
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x1B31", Offset = "0x1B31", VA = "0x1B31")]
		public static Skill operator +(Skill a, Skill b)
		{
			return null;
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0xB0D1", Offset = "0xB0D1", VA = "0xB0D1")]
		public static string FormatUserSkillValue(long value, bool polar)
		{
			return null;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0xB0D2", Offset = "0xB0D2", VA = "0xB0D2")]
		public Skill()
		{
		}

		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		[FieldOffset(Offset = "0x10")]
		public long Value;
	}
}
