using System;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	public class CommonRatingOSAView : OSADynamicBase<UserInCommonRatingsViewsHolder, UserInRatingListElement.UserInRatingListElementArgs>
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002191")]
		[Address(RVA = "0x72F0", Offset = "0x72F0", VA = "0x72F0", Slot = "119")]
		protected override UserInCommonRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Rating_View_CommonRatingOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58022 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_UserInCommonRatingsViewsHolder__UserInRatingListElement_UserInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a58022 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_UserInCommonRatingsViewsHolder__UserInRatingListElement_UserInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x72F1", Offset = "0x72F1", VA = "0x72F1")]
		public CommonRatingOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_CommonRatingOSAView___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58023 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement_UserInRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58023 = '\x01';
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
