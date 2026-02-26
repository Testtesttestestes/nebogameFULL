using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts2.Grids
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class BasicGridAdapter2 : GridAdapter<GridParams, MyGridItemViewsHolder>
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public SimpleDataHelper<MyGridItemModel> Data
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x57CB", Offset = "0x57CB", VA = "0x57CB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x57CC", Offset = "0x57CC", VA = "0x57CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x57CD", Offset = "0x57CD", VA = "0x57CD", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x57CE", Offset = "0x57CE", VA = "0x57CE", Slot = "128")]
		protected override void UpdateCellViewsHolder(MyGridItemViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__UpdateCellViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6285b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MyGridItemModel__InsertRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__get_List__
		              );
		    DAT_ram_00a6285b = '\x01';
		  }
		  System_Collections_Generic_List_object___GetRange
		            (*(undefined4 *)(*(int *)(param1 + 0xb0) + 0xc),param2,param3,
		             Method_System_Collections_Generic_List_MyGridItemModel__InsertRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb0),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x57CF", Offset = "0x57CF", VA = "0x57CF")]
		public void AddItemsAt(int index, IList<MyGridItemModel> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6285c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MyGridItemModel__RemoveRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__get_List__
		              );
		    DAT_ram_00a6285c = '\x01';
		  }
		  System_Collections_Generic_List_RenderChain_VisualChangesProcessor_EntryProcessingInfo___RemoveAt
		            (*(undefined4 *)(*(int *)(param1 + 0xb0) + 0xc),param2,param3,
		             Method_System_Collections_Generic_List_MyGridItemModel__RemoveRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb0),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x57D0", Offset = "0x57D0", VA = "0x57D0")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6285d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__ResetItems__
		              );
		    DAT_ram_00a6285d = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xb0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x57D1", Offset = "0x57D1", VA = "0x57D1")]
		public void SetItems(IList<MyGridItemModel> items)
		{
		/* --- GHIDRA: SetItems ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__SetItems
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a6285e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		              );
		    DAT_ram_00a6285e = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x57D2", Offset = "0x57D2", VA = "0x57D2")]
		private void RetrieveDataAndUpdate(int count)
		{
		/* --- GHIDRA: RetrieveDataAndUpdate ---
		int Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__RetrieveDataAndUpdate
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6285e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		              );
		    DAT_ram_00a6285e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x57D3", Offset = "0x57D3", VA = "0x57D3")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
		/* --- GHIDRA: FetchMoreItemsFromDataSourceAndUpdate ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6285f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MyGridItemModel__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__NotifyListChangedExternally__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__get_List__
		              );
		    DAT_ram_00a6285f = '\x01';
		  }
		  func_ii_6335(*(undefined4 *)(*(int *)(param1 + 0xb0) + 0xc),param2,
		               Method_System_Collections_Generic_List_MyGridItemModel__AddRange__);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertOneAtStart
		            (*(undefined4 *)(param1 + 0xb0),0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__NotifyListChangedExternally__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x57D4", Offset = "0x57D4", VA = "0x57D4")]
		private void OnDataRetrieved(MyGridItemModel[] newItems)
		{
		/* --- GHIDRA: OnDataRetrieved ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__OnDataRetrieved
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a62860 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__MyGridItemViewsHolder___ctor__
		              );
		    DAT_ram_00a62860 = '\x01';
		  }
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__MyGridItemViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x57D5", Offset = "0x57D5", VA = "0x57D5")]
		public BasicGridAdapter2()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a6285a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_MyGridItemViewsHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__TypeInfo);
		    DAT_ram_00a6285a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel___ctor__);
		  *(undefined4 *)(param1 + 0xb0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_MyGridItemViewsHolder___Start__
		            );
		  if (DAT_ram_00a6285e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		              );
		    DAT_ram_00a6285e = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_BasicGridAdapter2__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		                        );
		  *(int *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(char **)(param2_00 + 0x10) = s_You_can_attach_a_managed_debugge_ram_000005b4 + 0x28;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

}
