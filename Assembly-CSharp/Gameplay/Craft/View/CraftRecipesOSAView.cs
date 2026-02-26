using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.Craft.View
{
	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	public class CraftRecipesOSAView : OSA<BaseParamsWithPrefab, CraftRecipesViewsHolder>
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5A")]
		public SimpleDataHelper<CraftRecipeListElement.CraftRecipeListElementArgs> Data
		{
			[Token(Token = "0x6003430")]
			[Address(RVA = "0x845D", Offset = "0x845D", VA = "0x845D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003431")]
			[Address(RVA = "0x845E", Offset = "0x845E", VA = "0x845E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x845F", Offset = "0x845F", VA = "0x845F", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_Craft_View_CraftRecipesOSAView__Start(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ce5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftRecipesViewsHolder_TypeInfo);
		    DAT_ram_00a57ce5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Craft_View_CraftRecipesViewsHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x8460", Offset = "0x8460", VA = "0x8460", Slot = "99")]
		protected override CraftRecipesViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Craft_View_CraftRecipesOSAView__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ce6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__get_Item__
		              );
		    DAT_ram_00a57ce6 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__get_Item__
		                    );
		  Gameplay_Craft_View_CraftRecipeListElement__get_Data(param2[5],uVar1,param2);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x8461", Offset = "0x8461", VA = "0x8461", Slot = "100")]
		protected override void UpdateViewsHolder(CraftRecipesViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Craft_View_CraftRecipesOSAView__UpdateViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57ce7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__InsertItems__
		              );
		    DAT_ram_00a57ce7 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x8462", Offset = "0x8462", VA = "0x8462")]
		public void AddItemsAt(int index, IList<CraftRecipeListElement.CraftRecipeListElementArgs> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Craft_View_CraftRecipesOSAView__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57ce8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__RemoveItems__
		              );
		    DAT_ram_00a57ce8 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x8463", Offset = "0x8463", VA = "0x8463")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Craft_View_CraftRecipesOSAView__RemoveItemsFrom
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57ce9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__ResetItems__
		              );
		    DAT_ram_00a57ce9 = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x28],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__ResetItems__
		            );
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e48393;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		                                ,0);
		code_r0x80e48393:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (0 < iVar3) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x390) * 4))
		              (param1,0,0,0,*(undefined4 *)(*param1 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x8464", Offset = "0x8464", VA = "0x8464")]
		public void SetItems(IList<CraftRecipeListElement.CraftRecipeListElementArgs> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Craft_View_CraftRecipesOSAView__SetItems
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a57cea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Craft_View_CraftRecipesOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		              );
		    DAT_ram_00a57cea = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Craft_View_CraftRecipesOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x8465", Offset = "0x8465", VA = "0x8465")]
		private void RetrieveDataAndUpdate(int count)
		{
		/* --- GHIDRA: RetrieveDataAndUpdate ---
		int Gameplay_Craft_View_CraftRecipesOSAView__RetrieveDataAndUpdate
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57cea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Craft_View_CraftRecipesOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		              );
		    DAT_ram_00a57cea = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Craft_View_CraftRecipesOSAView__FetchMoreItemsFromDataSourceAndUpdate_d__11_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x8466", Offset = "0x8466", VA = "0x8466")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
		/* --- GHIDRA: FetchMoreItemsFromDataSourceAndUpdate ---
		void Gameplay_Craft_View_CraftRecipesOSAView__FetchMoreItemsFromDataSourceAndUpdate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57ceb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__InsertItemsAtEnd__
		              );
		    DAT_ram_00a57ceb = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___InsertItems
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__InsertItemsAtEnd__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x8467", Offset = "0x8467", VA = "0x8467")]
		private void OnDataRetrieved(CraftRecipeListElement.CraftRecipeListElementArgs[] newItems)
		{
		/* --- GHIDRA: OnDataRetrieved ---
		void Gameplay_Craft_View_CraftRecipesOSAView__OnDataRetrieved(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CraftRecipesViewsHolder___ctor__
		              );
		    DAT_ram_00a57cec = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CraftRecipesViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x8468", Offset = "0x8468", VA = "0x8468")]
		public CraftRecipesOSAView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Craft_View_CraftRecipesOSAView__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ce4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CraftRecipesViewsHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		              );
		    DAT_ram_00a57ce4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_CraftRecipeListElement_CraftRecipeListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CraftRecipesViewsHolder__Start__
		            );
		  return;
		}
		*/

}
