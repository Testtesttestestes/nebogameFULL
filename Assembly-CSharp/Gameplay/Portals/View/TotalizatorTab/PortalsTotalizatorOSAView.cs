using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Portals.View.TotalizatorTab
{
	// Token: 0x020005B9 RID: 1465
	[Token(Token = "0x20005B9")]
	public class PortalsTotalizatorOSAView : OSADynamicBase<UserInPortalsTotalizatorViewsHolder, UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs>
	{
		// Token: 0x06002328 RID: 9000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x747C", Offset = "0x747C", VA = "0x747C", Slot = "119")]
		protected override UserInPortalsTotalizatorViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Portals_View_TotalizatorTab_PortalsTotalizatorOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_UserInPortalsTotalizatorViewsHolder__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___ctor__
		              );
		    DAT_ram_00a580f3 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_UserInPortalsTotalizatorViewsHolder__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x747D", Offset = "0x747D", VA = "0x747D")]
		public PortalsTotalizatorOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_TotalizatorTab_PortalsTotalizatorOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a580f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		              );
		    DAT_ram_00a580f4 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
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
