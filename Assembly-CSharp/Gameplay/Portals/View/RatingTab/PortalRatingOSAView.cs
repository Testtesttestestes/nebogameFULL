using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Portals.View.RatingTab
{
	// Token: 0x020005C2 RID: 1474
	[Token(Token = "0x20005C2")]
	public class PortalRatingOSAView : OSADynamicBase<UserInPortalRatingsViewsHolder, UserInPortalRatingListElement.UserInPortalRatingListElementArgs>
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002366")]
		[Address(RVA = "0x74BA", Offset = "0x74BA", VA = "0x74BA", Slot = "119")]
		protected override UserInPortalRatingsViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Portals_View_RatingTab_PortalRatingOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58107 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_UserInPortalRatingsViewsHolder__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a58107 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_UserInPortalRatingsViewsHolder__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002367")]
		[Address(RVA = "0x74BB", Offset = "0x74BB", VA = "0x74BB")]
		public PortalRatingOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_RatingTab_PortalRatingOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58108 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58108 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
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
