using System;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Gameplay.ArtifactComparer.Model
{
	// Token: 0x02000CE5 RID: 3301
	[Token(Token = "0x2000CE5")]
	public class ArtifactComparerRowData
	{
		// Token: 0x06005061 RID: 20577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005061")]
		[Address(RVA = "0x9E72", Offset = "0x9E72", VA = "0x9E72")]
		public ArtifactComparerRowData()
		{
		}

		// Token: 0x04002BEC RID: 11244
		[Token(Token = "0x4002BEC")]
		[FieldOffset(Offset = "0x8")]
		public ArtifactComparerRowData.RowType Type;

		// Token: 0x04002BED RID: 11245
		[Token(Token = "0x4002BED")]
		[FieldOffset(Offset = "0xC")]
		public IInformationRow Row0;

		// Token: 0x04002BEE RID: 11246
		[Token(Token = "0x4002BEE")]
		[FieldOffset(Offset = "0x10")]
		public IInformationRow Row1;

		// Token: 0x04002BEF RID: 11247
		[Token(Token = "0x4002BEF")]
		[FieldOffset(Offset = "0x14")]
		public IInformationRow Row2;

		// Token: 0x02000CE6 RID: 3302
		[Token(Token = "0x2000CE6")]
		public enum RowType
		{
			// Token: 0x04002BF1 RID: 11249
			[Token(Token = "0x4002BF1")]
			Title = 1,
			// Token: 0x04002BF2 RID: 11250
			[Token(Token = "0x4002BF2")]
			Info,
			// Token: 0x04002BF3 RID: 11251
			[Token(Token = "0x4002BF3")]
			Backtime,
			// Token: 0x04002BF4 RID: 11252
			[Token(Token = "0x4002BF4")]
			ComparedSkill,
			// Token: 0x04002BF5 RID: 11253
			[Token(Token = "0x4002BF5")]
			SpellModifier
		}
	}
}
