using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Clans.Office.View.ClanResumesTab
{
	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x2000A2A")]
	public class ClanResumesOSAView : OSADynamicBase<UserInRatingsViewsHolder, UserInRatingListElement.UserInRatingListElementArgs>
	{
		// Token: 0x06003DB5 RID: 15797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003DB5")]
		[Address(RVA = "0x8C74", Offset = "0x8C74", VA = "0x8C74", Slot = "119")]
		protected override UserInRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_UserInRatingsViewsHolder__UserInRatingListElement_UserInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a57f64 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_UserInRatingsViewsHolder__UserInRatingListElement_UserInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB6")]
		[Address(RVA = "0x8C75", Offset = "0x8C75", VA = "0x8C75")]
		public ClanResumesOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a57f65 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}
	}
}
