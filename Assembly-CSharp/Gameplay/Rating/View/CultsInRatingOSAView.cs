using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	public class CultsInRatingOSAView : OSAGenericBase<CultInRatingsViewsHolder, CultInRatingListElement.CultInRatingListElementArgs>
	{
		// Token: 0x0600219C RID: 8604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600219C")]
		[Address(RVA = "0x72FB", Offset = "0x72FB", VA = "0x72FB", Slot = "119")]
		protected override CultInRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Rating_View_CultsInRatingOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5802a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_CultInRatingsViewsHolder__CultInRatingListElement_CultInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a5802a = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_CultInRatingsViewsHolder__CultInRatingListElement_CultInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219D")]
		[Address(RVA = "0x72FC", Offset = "0x72FC", VA = "0x72FC")]
		public CultsInRatingOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_CultsInRatingOSAView___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5802b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_View_CultInRatingListElement_CultInRatingListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_CultInRatingListElement_CultInRatingListElementArgs__set_Data__
		              );
		    DAT_ram_00a5802b = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Rating_View_CultInRatingListElement_CultInRatingListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Rating_View_CultInRatingListElement_CultInRatingListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Rating_View_CultInRatingListElement_CultInRatingListElementArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Rating_View_CultInRatingListElement_CultInRatingListElementArgs_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_CultInRatingListElement_CultInRatingListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}
	}
}
