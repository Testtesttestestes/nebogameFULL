using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public class DeselectableGenericFilterView : GenericFilterView
	{
		// Token: 0x140000EF RID: 239
		// (add) Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EF")]
		public event Action DeselectedEvent
		{
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x6083", Offset = "0x6083", VA = "0x6083")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x6084", Offset = "0x6084", VA = "0x6084")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x6085", Offset = "0x6085", VA = "0x6085", Slot = "4")]
		public override void Init(IEnumerable<FilterListElement.FilterData> data)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a63987 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63987 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 != 0) {
		    UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		              (param1,param2,1,param1);
		    return;
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,param2,0);
		  param1_00 = *(int *)(param1 + 0x20);
		  if (iVar1 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1_00 + 0x14),0,0);
		    *(undefined1 *)(param1_00 + 0x1c) = 0;
		    UI_Elements_Filters_GenericFilter_GenericFilterView__ListElementClickedEventHandler
		              (param1,param2,1,param1);
		    return;
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(param1_00,param2,0);
		  if (iVar1 != 0) {
		    iVar1 = *(int *)(param1 + 0x20);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(iVar1 + 0x14),0,0);
		    *(undefined1 *)(iVar1 + 0x1c) = 0;
		    *(undefined4 *)(param1 + 0x20) = 0;
		    iVar1 = *(int *)(param1 + 0x24);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x6086", Offset = "0x6086", VA = "0x6086", Slot = "5")]
		protected override void ListElementClickedEventHandler(FilterListElement element)
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x6087", Offset = "0x6087", VA = "0x6087")]
		public DeselectableGenericFilterView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63989 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterListElement__TypeInfo);
		    DAT_ram_00a63989 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_FilterListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_FilterListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_DeselectedEvent ---
		void UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63986 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63986 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x24,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeselectedEvent ---
		void UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__remove_DeselectedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_Filters_GenericFilter_GenericFilterView__get_CurrentIndex(param1,param2,param2);
		  return;
		}
		*/

}
