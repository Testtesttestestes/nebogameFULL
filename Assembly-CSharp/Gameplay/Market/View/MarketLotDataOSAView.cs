using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	public class MarketLotDataOSAView : OSA<BaseParamsWithPrefab, MarketLotViewsHolder>
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700071B")]
		public SimpleDataHelper<MarketLotListElement.MarketLotListElementArgs> Data
		{
			[Token(Token = "0x60025D6")]
			[Address(RVA = "0x7714", Offset = "0x7714", VA = "0x7714")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60025D7")]
			[Address(RVA = "0x7715", Offset = "0x7715", VA = "0x7715")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x7716", Offset = "0x7716", VA = "0x7716", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_Market_View_MarketLotDataOSAView__Start(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57de5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_View_MarketLotViewsHolder_TypeInfo);
		    DAT_ram_00a57de5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Market_View_MarketLotViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x7717", Offset = "0x7717", VA = "0x7717", Slot = "99")]
		protected override MarketLotViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Market_View_MarketLotDataOSAView__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57de6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__get_Item__
		              );
		    DAT_ram_00a57de6 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  param2_00 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (param1_00,uVar1,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                        );
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  Gameplay_Market_View_MarketLotViewsHolder__get_MarketLotData(param2,param2_00,0);
		  UnityEngine_UI_MaskUtilities__Notify2DMaskStateChanged(*(undefined4 *)(param1 + 0xa4),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x7718", Offset = "0x7718", VA = "0x7718", Slot = "100")]
		protected override void UpdateViewsHolder(MarketLotViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Market_View_MarketLotDataOSAView__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57de7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__InsertItems__
		              );
		    DAT_ram_00a57de7 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x7719", Offset = "0x7719", VA = "0x7719")]
		public void AddItemsAt(int index, IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Market_View_MarketLotDataOSAView__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57de8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__RemoveItems__
		              );
		    DAT_ram_00a57de8 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x771A", Offset = "0x771A", VA = "0x771A")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Market_View_MarketLotDataOSAView__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57de9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__ResetItems__
		              );
		    DAT_ram_00a57de9 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x771B", Offset = "0x771B", VA = "0x771B")]
		public void SetItems(IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Market_View_MarketLotDataOSAView__SetItems
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a57dea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Market_View_MarketLotDataOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__12_TypeInfo
		              );
		    DAT_ram_00a57dea = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Market_View_MarketLotDataOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__12_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x771C", Offset = "0x771C", VA = "0x771C")]
		private void RetrieveDataAndUpdate(int count)
		{
		/* --- GHIDRA: RetrieveDataAndUpdate ---
		int Gameplay_Market_View_MarketLotDataOSAView__RetrieveDataAndUpdate
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57dea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Market_View_MarketLotDataOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__12_TypeInfo
		              );
		    DAT_ram_00a57dea = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Market_View_MarketLotDataOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__12_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x771D", Offset = "0x771D", VA = "0x771D")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
		/* --- GHIDRA: FetchMoreItemsFromDataSourceAndUpdate ---
		void Gameplay_Market_View_MarketLotDataOSAView__FetchMoreItemsFromDataSourceAndUpdate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57deb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__InsertItemsAtEnd__
		              );
		    DAT_ram_00a57deb = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertItems
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__InsertItemsAtEnd__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x771E", Offset = "0x771E", VA = "0x771E")]
		private void OnDataRetrieved(MarketLotListElement.MarketLotListElementArgs[] newItems)
		{
		/* --- GHIDRA: OnDataRetrieved ---
		void Gameplay_Market_View_MarketLotDataOSAView__OnDataRetrieved(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57dec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder___ctor__
		              );
		    DAT_ram_00a57dec = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x771F", Offset = "0x771F", VA = "0x771F")]
		public MarketLotDataOSAView()
		{
		}

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0xA4")]
		private Mask _viewportMask;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Market_View_MarketLotDataOSAView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57de4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInChildren_Mask___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    DAT_ram_00a57de4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (uVar1,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = uVar1;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder__Start__
		            );
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (param1,Method_UnityEngine_Component_GetComponentInChildren_Mask___);
		  *(undefined4 *)(param1 + 0xa4) = uVar1;
		  return;
		}
		*/

}
