using System;
using Core.Data.Skills;
using Gameplay.Medals.View;
using Il2CppDummyDll;

namespace UI.Filters
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[Serializable]
	public class SkillFilterButtonData
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x5F8A", Offset = "0x5F8A", VA = "0x5F8A")]
		public SkillFilterButtonData()
		{
		}

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x8")]
		public UserSkillsIndexes SkillIndex;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0xC")]
		public FilterButton Button;
	}
}
