using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts.Grids
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public class BasicGridAdapter : GridAdapter<GridParams, MyGridItemViewsHolder>
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public SimpleDataHelper<MyGridItemModel> Data
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x57EF", Offset = "0x57EF", VA = "0x57EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x57F0", Offset = "0x57F0", VA = "0x57F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x57F1", Offset = "0x57F1", VA = "0x57F1", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x57F2", Offset = "0x57F2", VA = "0x57F2", Slot = "128")]
		protected override void UpdateCellViewsHolder(MyGridItemViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__UpdateCellViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6286d == '\0') {
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
		    DAT_ram_00a6286d = '\x01';
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

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x57F3", Offset = "0x57F3", VA = "0x57F3")]
		public void AddItemsAt(int index, IList<MyGridItemModel> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a6286e == '\0') {
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
		    DAT_ram_00a6286e = '\x01';
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

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x57F4", Offset = "0x57F4", VA = "0x57F4")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a6286f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__ResetItems__
		              );
		    DAT_ram_00a6286f = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xb0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x57F5", Offset = "0x57F5", VA = "0x57F5")]
		public void SetItems(IList<MyGridItemModel> items)
		{
		/* --- GHIDRA: SetItems ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__SetItems
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a62870 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		              );
		    DAT_ram_00a62870 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x57F6", Offset = "0x57F6", VA = "0x57F6")]
		private void RetrieveDataAndUpdate(int count)
		{
		/* --- GHIDRA: RetrieveDataAndUpdate ---
		int Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__RetrieveDataAndUpdate
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62870 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		              );
		    DAT_ram_00a62870 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x57F7", Offset = "0x57F7", VA = "0x57F7")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
		/* --- GHIDRA: FetchMoreItemsFromDataSourceAndUpdate ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a62871 == '\0') {
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
		    DAT_ram_00a62871 = '\x01';
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x57F8", Offset = "0x57F8", VA = "0x57F8")]
		private void OnDataRetrieved(MyGridItemModel[] newItems)
		{
		/* --- GHIDRA: OnDataRetrieved ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__OnDataRetrieved
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a62872 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__MyGridItemViewsHolder___ctor__
		              );
		    DAT_ram_00a62872 = '\x01';
		  }
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_GridParams__MyGridItemViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x57F9", Offset = "0x57F9", VA = "0x57F9")]
		public BasicGridAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a6286c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_GridParams__CellGroupViewsHolder_MyGridItemViewsHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MyGridItemModel__TypeInfo);
		    DAT_ram_00a6286c = '\x01';
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
		  if (DAT_ram_00a62870 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		              );
		    DAT_ram_00a62870 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Grids_BasicGridAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__10_TypeInfo
		                        );
		  *(int *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(char **)(param2_00 + 0x10) = s_You_can_attach_a_managed_debugge_ram_000005b4 + 0x28;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

}
