using System;
using System.Collections.Generic;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000C89")]
	public class AuchanArtifactCategoryData
	{
		// Token: 0x06004E3F RID: 20031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0x1D63", Offset = "0x1D63", VA = "0x1D63")]
		public AuchanArtifactCategoryData()
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_Auchan_View_AuchanArtifactCategoryData___ctor(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002ABD RID: 10941
		[Token(Token = "0x4002ABD")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x04002ABE RID: 10942
		[Token(Token = "0x4002ABE")]
		[FieldOffset(Offset = "0xC")]
		public IList<AuchanArtifactData> Items;

		// Token: 0x04002ABF RID: 10943
		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x10")]
		public uint FilterId;
	}
}
