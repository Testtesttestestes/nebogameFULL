using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D6 RID: 4310
	[Token(Token = "0x20010D6")]
	public class Skills : Dictionary<int, Skill>
	{
		// Token: 0x060064FB RID: 25851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FB")]
		[Address(RVA = "0xB0D3", Offset = "0xB0D3", VA = "0xB0D3")]
		public void AddSkill(Skill value)
		{
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FC")]
		[Address(RVA = "0xB0D4", Offset = "0xB0D4", VA = "0xB0D4")]
		public Skills AddMods(Skills s1, Skills s2)
		{
			return null;
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FD")]
		[Address(RVA = "0xB0D5", Offset = "0xB0D5", VA = "0xB0D5")]
		public static Skills ParseSkills(List<long> value)
		{
			return null;
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0xB0D6", Offset = "0xB0D6", VA = "0xB0D6")]
		public static Skills ParseSkills(IList<uint> value)
		{
			return null;
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0xB0D7", Offset = "0xB0D7", VA = "0xB0D7")]
		public static Skill ParseSkill(int id, long value)
		{
			return null;
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006500")]
		[Address(RVA = "0xB0D8", Offset = "0xB0D8", VA = "0xB0D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006501")]
		[Address(RVA = "0xB0D9", Offset = "0xB0D9", VA = "0xB0D9")]
		public Skills()
		{
		}
	}
}
