using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.View.Lists
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public class GameEventsListAdapter : OSA<BaseParamsWithPrefab, GameEventsListItemViewsHolder>
	{
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DE0 RID: 11744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D2")]
		public SimpleDataHelper<GameEventsListView.GameEventsListItemWrapper> Data
		{
			[Token(Token = "0x6002DDF")]
			[Address(RVA = "0x7E5D", Offset = "0x7E5D", VA = "0x7E5D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DE0")]
			[Address(RVA = "0x7E5E", Offset = "0x7E5E", VA = "0x7E5E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE1")]
		[Address(RVA = "0x7E5F", Offset = "0x7E5F", VA = "0x7E5F", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_GameEvents_View_Lists_GameEventsListAdapter__Start
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a574a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_View_Lists_GameEventsListItemViewsHolder_TypeInfo);
		    DAT_ram_00a574a7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_GameEvents_View_Lists_GameEventsListItemViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DE2")]
		[Address(RVA = "0x7E60", Offset = "0x7E60", VA = "0x7E60", Slot = "99")]
		protected override GameEventsListItemViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param3_00;
		  undefined4 param1_00;
		  int param1_01;
		  int param2_01;
		  
		  if (DAT_ram_00a574a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__get_Item__
		              );
		    DAT_ram_00a574a8 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  param3_00 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (param1_00,param2_00,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__get_Item__
		                        );
		  param1_01 = param2[5];
		  param2_01 = *(int *)(param1_01 + 0x28);
		  if (param3_00 != param2_01) {
		    *(int *)(param1_01 + 0x28) = param3_00;
		    Gameplay_GameEvents_View_Lists_GameEventItemRenderer__set_Data
		              (param1_01,param2_01,param3_00,param1_01);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE3")]
		[Address(RVA = "0x7E61", Offset = "0x7E61", VA = "0x7E61", Slot = "100")]
		protected override void UpdateViewsHolder(GameEventsListItemViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a574a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__InsertItems__
		              );
		    DAT_ram_00a574a9 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE4")]
		[Address(RVA = "0x7E62", Offset = "0x7E62", VA = "0x7E62")]
		public void AddItemsAt(int index, IList<GameEventsListView.GameEventsListItemWrapper> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a574aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		              );
		    DAT_ram_00a574aa = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE5")]
		[Address(RVA = "0x7E63", Offset = "0x7E63", VA = "0x7E63")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a574ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		              );
		    DAT_ram_00a574ab = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE6")]
		[Address(RVA = "0x7E64", Offset = "0x7E64", VA = "0x7E64")]
		public void SetItems(IList<GameEventsListView.GameEventsListItemWrapper> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__SetItems
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a574ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_View_Lists_GameEventsListAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		              );
		    DAT_ram_00a574ac = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GameEvents_View_Lists_GameEventsListAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE7")]
		[Address(RVA = "0x7E65", Offset = "0x7E65", VA = "0x7E65")]
		private void RetrieveDataAndUpdate(int count)
		{
		/* --- GHIDRA: RetrieveDataAndUpdate ---
		int Gameplay_GameEvents_View_Lists_GameEventsListAdapter__RetrieveDataAndUpdate
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a574ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_View_Lists_GameEventsListAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		              );
		    DAT_ram_00a574ac = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_View_Lists_GameEventsListAdapter__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002DE8")]
		[Address(RVA = "0x7E66", Offset = "0x7E66", VA = "0x7E66")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
		/* --- GHIDRA: FetchMoreItemsFromDataSourceAndUpdate ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__FetchMoreItemsFromDataSourceAndUpdate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a574ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__InsertItemsAtEnd__
		              );
		    DAT_ram_00a574ad = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertItems
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__InsertItemsAtEnd__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DE9")]
		[Address(RVA = "0x7E67", Offset = "0x7E67", VA = "0x7E67")]
		private void OnDataRetrieved(GameEventsListView.GameEventsListItemWrapper[] newItems)
		{
		/* --- GHIDRA: OnDataRetrieved ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__OnDataRetrieved
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a574ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__GameEventsListItemViewsHolder___ctor__
		              );
		    DAT_ram_00a574ae = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__GameEventsListItemViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DEA")]
		[Address(RVA = "0x7E68", Offset = "0x7E68", VA = "0x7E68")]
		public GameEventsListAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_GameEvents_View_Lists_GameEventsListAdapter__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a574a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__GameEventsListItemViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		              );
		    DAT_ram_00a574a6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__GameEventsListItemViewsHolder__Start__
		            );
		  return;
		}
		*/

}
