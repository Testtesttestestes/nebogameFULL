using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	public class GdEventsListOsaView : GridAdapter<MyGridParams, MyCellViewsHolder>
	{
		// Token: 0x14000162 RID: 354
		// (add) Token: 0x06002C0F RID: 11279 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002C10 RID: 11280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000162")]
		public event Action<CellModel> ClickEvent
		{
			[Token(Token = "0x6002C0F")]
			[Address(RVA = "0x7C9F", Offset = "0x7C9F", VA = "0x7C9F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C10")]
			[Address(RVA = "0x7CA0", Offset = "0x7CA0", VA = "0x7CA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x7CA1", Offset = "0x7CA1", VA = "0x7CA1")]
		private void InvokeClickEvent(CellModel model)
		{
		/* --- GHIDRA: InvokeClickEvent ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__InvokeClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a29a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CellModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___Start__
		              );
		    DAT_ram_00a5a29a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_CellModel__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,0,Method_System_Collections_Generic_List_CellModel___ctor__);
		  *(undefined4 *)(param1 + 0xb4) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___Start__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x7CA2", Offset = "0x7CA2", VA = "0x7CA2", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__Start
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a29b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MyGridParams__MyCellViewsHolder__Refresh__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel__get_Count__);
		    DAT_ram_00a5a29b = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xa4) = *(undefined4 *)(*(int *)(param1 + 0xb4) + 0xc);
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___RebuildLayoutDueToScrollViewSizeChange
		            (param1,0,param3,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MyGridParams__MyCellViewsHolder__Refresh__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x7CA3", Offset = "0x7CA3", VA = "0x7CA3", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		/* --- GHIDRA: Refresh ---
		undefined4
		Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__Refresh(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a29c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_TypeInfo)
		    ;
		    DAT_ram_00a5a29c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_TypeInfo);
		  if (DAT_ram_00a5a2a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		              );
		    DAT_ram_00a5a2a5 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1_00,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x7CA4", Offset = "0x7CA4", VA = "0x7CA4", Slot = "126")]
		protected override CellGroupViewsHolder<MyCellViewsHolder> GetNewCellGroupViewsHolder()
		{
		/* --- GHIDRA: GetNewCellGroupViewsHolder ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__GetNewCellGroupViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a29d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__get_ContainingCellViewsHolders__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__get_NumActiveCells__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MyGridParams__MyCellViewsHolder__UpdateViewsHolder__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___ScheduleComputeVisibilityTwinPass__
		              );
		    DAT_ram_00a5a29d = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___SmoothScrollToGroup
		            (param1,param2,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MyGridParams__MyCellViewsHolder__UpdateViewsHolder__
		            );
		  if (0 < param2[7]) {
		    piVar1 = (int *)0x0;
		    iVar4 = **(int **)(param2[5] + 0x10);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                      (*(int **)(param2[5] + 0x10),*(undefined4 *)(iVar4 + 0xe4));
		    iVar4 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0xb4),uVar2,
		                       Method_System_Collections_Generic_List_CellModel__get_Item__);
		    if (((uint)*(byte *)(Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_TypeInfo + 0xb8)
		         <= (uint)*(byte *)(*param2 + 0xb8)) &&
		       (piVar1 = param2,
		       *(int *)(*(int *)(*param2 + 100) +
		                (uint)*(byte *)(Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_TypeInfo +
		                               0xb8) * 4 + -4) !=
		       Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_TypeInfo)) {
		      piVar1 = (int *)0x0;
		    }
		    if (*(int *)(iVar4 + 0x10) == 2) {
		      uVar3 = *(undefined4 *)(*(int *)(iVar4 + 8) + 8);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (piVar1[10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar4 = *(int *)piVar1[0xb];
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                ((int *)piVar1[0xb],uVar3,*(undefined4 *)(iVar4 + 0x2d4));
		    }
		    else {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (piVar1[10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,0,0);
		    }
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___ResetItems
		            (param1,0,
		             Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___ScheduleComputeVisibilityTwinPass__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x7CA5", Offset = "0x7CA5", VA = "0x7CA5", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<MyCellViewsHolder> newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__UpdateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a29e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CellModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_EventsList_GdEventsListOsaView_InvokeClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel__get_Item__);
		    DAT_ram_00a5a29e = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0xb4);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (uVar2,uVar1,Method_System_Collections_Generic_List_CellModel__get_Item__);
		  uVar2 = unnamed_function_1417(System_Action_CellModel__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_GdEvents_View_EventsList_GdEventsListOsaView_InvokeClickEvent__,0);
		  Gameplay_GdEvents_View_EventsList_MyCellViewsHolder__CollectViews
		            (param2,uVar1,param2,uVar2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x7CA6", Offset = "0x7CA6", VA = "0x7CA6", Slot = "128")]
		protected override void UpdateCellViewsHolder(MyCellViewsHolder viewsHolder)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__UpdateCellViewsHolder
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a29f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___PostRebuildLayoutDueToScrollViewSizeChange__
		              );
		    DAT_ram_00a5a29f = '\x01';
		  }
		  param1_00 = *(int *)(param1[4] + 0x58);
		  if (param1_00 != param1[0x2f]) {
		    iVar1 = param1[0x2e];
		    if (DAT_ram_00a5a2a0 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel__get_Count__);
		      DAT_ram_00a5a2a0 = '\x01';
		      param1_00 = *(int *)(param1[4] + 0x58);
		    }
		    param1[0x2e] = iVar1;
		    iVar1 = Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_GridWithCategoriesDataUtil__CreateItemModelInRowSeparatingCategories
		                      (param1_00,iVar1,param1);
		    param1[0x2d] = iVar1;
		    param1[0x2f] = param1_00;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x340) * 4))
		              (param1,*(undefined4 *)(iVar1 + 0xc),0,1,*(undefined4 *)(*param1 + 0x344));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x7CA7", Offset = "0x7CA7", VA = "0x7CA7", Slot = "110")]
		protected override void PostRebuildLayoutDueToScrollViewSizeChange()
		{
		/* --- GHIDRA: PostRebuildLayoutDueToScrollViewSizeChange ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__PostRebuildLayoutDueToScrollViewSizeChange
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a2a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel__get_Count__);
		    DAT_ram_00a5a2a0 = '\x01';
		  }
		  param1[0x2e] = param2;
		  param1_00 = *(int *)(param1[4] + 0x58);
		  iVar1 = Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_GridWithCategoriesDataUtil__CreateItemModelInRowSeparatingCategories
		                    (param1_00,param2,param1);
		  param1[0x2d] = iVar1;
		  param1[0x2f] = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x340) * 4))
		            (param1,*(undefined4 *)(iVar1 + 0xc),0,1,*(undefined4 *)(*param1 + 0x344));
		  return;
		}
		*/

		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x7CA8", Offset = "0x7CA8", VA = "0x7CA8")]
		public void ResetData(List<CategoryModel> categories)
		{
		/* --- GHIDRA: ResetData ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__ResetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a2a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MyGridParams__MyCellViewsHolder___ctor__
		              );
		    DAT_ram_00a5a2a1 = '\x01';
		  }
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MyGridParams__MyCellViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x7CA9", Offset = "0x7CA9", VA = "0x7CA9")]
		public GdEventsListOsaView()
		{
		}

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0xB4")]
		private List<CellModel> Data;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[FieldOffset(Offset = "0xB8")]
		private List<CategoryModel> _Categories;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[FieldOffset(Offset = "0xBC")]
		private int _LastKnownNumberOfCellsPerGroup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a299 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CellModel__TypeInfo);
		    DAT_ram_00a5a299 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xb0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CellModel__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CellModel__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xb0,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_GdEvents_View_EventsList_GdEventsListOsaView__remove_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xb0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
