using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Clans.Office.View.VacanciesTab
{
	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	public class ClansInRatingsOSAView : OSADynamicBase<ClansInRatingsViewsHolder, ClanInRatingListElement.ClanInRatingListElementArgs>
	{
		// Token: 0x06003CFB RID: 15611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x8BBB", Offset = "0x8BBB", VA = "0x8BBB", Slot = "119")]
		protected override ClansInRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Clans_Office_View_VacanciesTab_ClansInRatingsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f12 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_ClansInRatingsViewsHolder__ClanInRatingListElement_ClanInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a57f12 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_ClansInRatingsViewsHolder__ClanInRatingListElement_ClanInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x8BBC", Offset = "0x8BBC", VA = "0x8BBC")]
		public ClansInRatingsOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_VacanciesTab_ClansInRatingsOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f13 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanInRatingListElement_ClanInRatingListElementArgs__set_Data__
		              );
		    DAT_ram_00a57f13 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_ClanInRatingListElement_ClanInRatingListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}
	}
}
