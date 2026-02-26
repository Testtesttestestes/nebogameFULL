using System;
using Il2CppDummyDll;
using UI.Elements.GenericList;

namespace UI.Elements.RatingElements.SubRatings
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	public class SubRatingsList : SelectorGenericList<SubRatingsListArgs, SubRatingListElement, SubRatingListElementArgs>
	{
		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x604E", Offset = "0x604E", VA = "0x604E")]
		public SubRatingsList()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_RatingElements_SubRatings_SubRatingsList___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63979 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListArgs_SubRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a63979 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object___get_Data
		            (param1,
		             Method_UI_Elements_GenericList_SelectedGenericListArgs_SubRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
