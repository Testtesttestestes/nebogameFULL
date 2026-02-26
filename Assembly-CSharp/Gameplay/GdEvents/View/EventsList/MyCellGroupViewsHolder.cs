using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	public class MyCellGroupViewsHolder : CellGroupViewsHolder<MyCellViewsHolder>
	{
		// Token: 0x06002C26 RID: 11302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x7CB6", Offset = "0x7CB6", VA = "0x7CB6", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellGroupViewsHolder__CollectViews
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  iVar1 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x318) * 4))
		            (*(int **)(param1 + 0x2c),param2,*(undefined4 *)(iVar1 + 0x31c));
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyCellGroupViewsHolder__CollectViews
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a540d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		              );
		    DAT_ram_00a540d1 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder__CollectViews
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  iVar1 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x2c),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x7CB7", Offset = "0x7CB7", VA = "0x7CB7")]
		public void ShowHeader(string text)
		{
		/* --- GHIDRA: ShowHeader ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellGroupViewsHolder__ShowHeader
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x7CB8", Offset = "0x7CB8", VA = "0x7CB8")]
		public void ClearHeader()
		{
		/* --- GHIDRA: ClearHeader ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellGroupViewsHolder__ClearHeader
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a541bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		              );
		    DAT_ram_00a541bb = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: ClearHeader ---
		void Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder__ClearHeader
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a2a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		              );
		    DAT_ram_00a5a2a5 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x7CB9", Offset = "0x7CB9", VA = "0x7CB9")]
		public MyCellGroupViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellGroupViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a541bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_GridWithCategoriesExample__MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___InitAdapters__
		              );
		    DAT_ram_00a541bc = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_object__object__object___Awake
		            (param1,
		             Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_GridWithCategoriesExample__MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___InitAdapters__
		            );
		  *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x10);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyCellGroupViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param2_00;
		  
		  if (DAT_ram_00a540d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_int__BasicModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_PackedGridSceneEntry_CreateNewModel__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_PackedGridExample__MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___InitAdapters__
		              );
		    DAT_ram_00a540d2 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_object__object__object___Awake
		            (param1,
		             Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_PackedGridExample__MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___InitAdapters__
		            );
		  param2_00 = *(int *)(*(int *)(param1 + 0x10) + 0x10);
		  param1_00 = unnamed_function_1417(System_Func_int__BasicModel__TypeInfo);
		  System_Func_int__InternedString___Invoke
		            (param1_00,param1,
		             Method_Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_PackedGridSceneEntry_CreateNewModel__
		             ,0);
		  param1_01 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel__TypeInfo);
		  UnityEngine_UIElements_Layout_LayoutList___Il2CppFullySharedGenericStructType___get_Item
		            (param1_01,param2_00,param1_00,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel___ctor__);
		  *(undefined4 *)(param2_00 + 0xb0) = param1_01;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (param2_00,
		             Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___Init__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a2a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_View_EventsList_CellModel_TypeInfo);
		    DAT_ram_00a5a2a6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_GdEvents_View_EventsList_CellModel_TypeInfo);
		  *(undefined8 *)(iVar1 + 0xc) = 0x1ffffffff;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x24")]
		public ContentSizeFitter contentSizeFitterComponent;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x28")]
		private Transform _HeaderPanel;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x2C")]
		private TextMeshProUGUI _HeaderText;

		// Token: 0x0200073E RID: 1854
		[Token(Token = "0x200073E")]
		public static class GridWithCategoriesDataUtil
		{
			// Token: 0x06002C2A RID: 11306 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002C2A")]
			[Address(RVA = "0x7CBA", Offset = "0x7CBA", VA = "0x7CBA")]
			private static CellModel CreateItemModelForRowCompletion(CategoryModel parentCategory)
			{
				return null;
			}

			// Token: 0x06002C2B RID: 11307 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002C2B")]
			[Address(RVA = "0x7CBB", Offset = "0x7CBB", VA = "0x7CBB")]
			private static CellModel CreateItemModelInRowSeparatingCategories(CategoryModel parentCategory)
			{
				return null;
			}

			// Token: 0x06002C2C RID: 11308 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002C2C")]
			[Address(RVA = "0x7CBC", Offset = "0x7CBC", VA = "0x7CBC")]
			public static List<CellModel> ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<CategoryModel> categories)
			{
				return null;
			}
		}
	}
}
