using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A1C RID: 2588
	[Token(Token = "0x2000A1C")]
	public class ClanWarsHistoryOSAView : OSADynamicBase<ClanWarsHistoryViewsHolder, ClanWarHistoryListElement.ClanWarHistoryListElementArgs>
	{
		// Token: 0x06003D7D RID: 15741 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D7D")]
		[Address(RVA = "0x8C3C", Offset = "0x8C3C", VA = "0x8C3C", Slot = "119")]
		protected override ClanWarsHistoryViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f4e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_ClanWarsHistoryViewsHolder__ClanWarHistoryListElement_ClanWarHistoryListElementArgs___ctor__
		              );
		    DAT_ram_00a57f4e = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_ClanWarsHistoryViewsHolder__ClanWarHistoryListElement_ClanWarHistoryListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7E")]
		[Address(RVA = "0x8C3D", Offset = "0x8C3D", VA = "0x8C3D")]
		public ClanWarsHistoryOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__set_Data__
		              );
		    DAT_ram_00a57f4f = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}
	}
}
