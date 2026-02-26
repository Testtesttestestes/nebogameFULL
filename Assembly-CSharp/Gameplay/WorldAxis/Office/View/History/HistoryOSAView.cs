using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	public class HistoryOSAView : OSADynamicBase<HistoryViewsHolder, BattleHistoryListElement.BattleHistoryListElementArgs>
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x170002C0")]
		protected override int MinElementsToUpdate
		{
			[Token(Token = "0x6001239")]
			[Address(RVA = "0x6433", Offset = "0x6433", VA = "0x6433", Slot = "122")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x6434", Offset = "0x6434", VA = "0x6434", Slot = "119")]
		protected override HistoryViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_WorldAxis_Office_View_History_HistoryOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bbe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_HistoryViewsHolder__BattleHistoryListElement_BattleHistoryListElementArgs___ctor__
		              );
		    DAT_ram_00a58bbe = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_HistoryViewsHolder__BattleHistoryListElement_BattleHistoryListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x6435", Offset = "0x6435", VA = "0x6435")]
		public HistoryOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_History_HistoryOSAView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58bbf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_BattleHistoryListElement_BattleHistoryListElementArgs__set_Data__
		              );
		    DAT_ram_00a58bbf = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_7635(*(undefined4 *)(param1 + 0x14),param2,
		               Method_UI_Elements_GenericList_SelectableListElement_BattleHistoryListElement_BattleHistoryListElementArgs__set_Data__
		              );
		  return;
		}
		*/

		}

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		private const int MIN_ELEMENTS_TO_UPDATE = 10;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MinElementsToUpdate ---
		undefined4
		Gameplay_WorldAxis_Office_View_History_HistoryOSAView__get_MinElementsToUpdate
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58bbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_History_HistoryViewsHolder_TypeInfo);
		    DAT_ram_00a58bbd = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_View_History_HistoryViewsHolder_TypeInfo);
		  if (DAT_ram_00a58bc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_BattleHistoryListElement___ctor__);
		    DAT_ram_00a58bc0 = '\x01';
		  }
		  return uVar1;
		}
		*/

}
