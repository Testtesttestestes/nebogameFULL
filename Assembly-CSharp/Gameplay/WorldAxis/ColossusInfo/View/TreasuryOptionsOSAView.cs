using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	public class TreasuryOptionsOSAView : OSAGenericBase<ClansPoliciesViewsHolder, TreasuryOptionListElement.TreasuryOptionListElementArgs>
	{
		// Token: 0x0600128C RID: 4748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x6486", Offset = "0x6486", VA = "0x6486", Slot = "119")]
		protected override ClansPoliciesViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bd8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_ClansPoliciesViewsHolder__TreasuryOptionListElement_TreasuryOptionListElementArgs___ctor__
		              );
		    DAT_ram_00a58bd8 = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_ClansPoliciesViewsHolder__TreasuryOptionListElement_TreasuryOptionListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x6487", Offset = "0x6487", VA = "0x6487")]
		public TreasuryOptionsOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionsOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58bd9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58bd9 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement_TreasuryOptionListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}
	}
}
