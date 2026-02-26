using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab
{
	// Token: 0x02000A21 RID: 2593
	[Token(Token = "0x2000A21")]
	public class ClanPoliciesOSAView : OSADynamicBase<ClansPoliciesViewsHolder, ClanPolicyListElement.ClanPolicyListElementArgs>
	{
		// Token: 0x06003D8E RID: 15758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D8E")]
		[Address(RVA = "0x8C4D", Offset = "0x8C4D", VA = "0x8C4D", Slot = "119")]
		protected override ClansPoliciesViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliciesOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_ClansPoliciesViewsHolder__ClanPolicyListElement_ClanPolicyListElementArgs___ctor__
		              );
		    DAT_ram_00a57f56 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_ClansPoliciesViewsHolder__ClanPolicyListElement_ClanPolicyListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8F")]
		[Address(RVA = "0x8C4E", Offset = "0x8C4E", VA = "0x8C4E")]
		public ClanPoliciesOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPoliciesOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__set_Data__
		              );
		    DAT_ram_00a57f57 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanPolicyListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}
	}
}
