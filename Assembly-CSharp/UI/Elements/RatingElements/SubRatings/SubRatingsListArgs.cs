using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI.Elements.RatingElements.SubRatings
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	public class SubRatingsListArgs : SelectedGenericListArgs<SubRatingListElementArgs>
	{
		// Token: 0x06000D6C RID: 3436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x604F", Offset = "0x604F", VA = "0x604F")]
		public SubRatingsListArgs()
		{
		/* --- GHIDRA: .ctor ---
		float UI_Elements_RatingElements_SubRatings_SubRatingsListArgs___ctor(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = UnityEngine_UI_Scrollbar___ctor(*(undefined4 *)(param1 + 0x14),0);
		  return fVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		float UI_Elements_RatingElements_SubRatings_SubRatingsListArgs___ctor(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = UnityEngine_UI_Scrollbar___ctor(*(undefined4 *)(param1 + 0x14),0);
		  return fVar1;
		}
		*/

		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x6050", Offset = "0x6050", VA = "0x6050")]
		public SubRatingsListArgs(IList<SubRatingListElementArgs> list)
		{
		}
	}
}
