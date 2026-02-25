using System;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Gameplay.ArtifactComparer.Model
{
	// Token: 0x02000CE9 RID: 3305
	[Token(Token = "0x2000CE9")]
	public class ComparerValueRow : ValueRow
	{
		// Token: 0x06005068 RID: 20584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005068")]
		[Address(RVA = "0x9E79", Offset = "0x9E79", VA = "0x9E79")]
		public ComparerValueRow()
		{
		}

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		[FieldOffset(Offset = "0x38")]
		public ComparedSkillData ComparisonData;
	}
}
