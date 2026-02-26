using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	public class BossRatingListAdapter : OSA<BaseParamsWithPrefab, BossRatingListItemViewHolder>
	{
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046A9 RID: 18089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E03")]
		public SimpleDataHelper<BossCaptainRatingData> Data
		{
			[Token(Token = "0x60046A8")]
			[Address(RVA = "0x953E", Offset = "0x953E", VA = "0x953E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046A9")]
			[Address(RVA = "0x953F", Offset = "0x953F", VA = "0x953F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001B8 RID: 440
		// (add) Token: 0x060046AA RID: 18090 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046AB RID: 18091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B8")]
		public event Action<BossCaptainRatingData> ClickEvent
		{
			[Token(Token = "0x60046AA")]
			[Address(RVA = "0x9540", Offset = "0x9540", VA = "0x9540")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046AB")]
			[Address(RVA = "0x9541", Offset = "0x9541", VA = "0x9541")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x9542", Offset = "0x9542", VA = "0x9542", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Boss_View_RatingTab_BossRatingListAdapter__Start
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  undefined4 param1_02;
		  int param1_03;
		  int iVar3;
		  
		  if (DAT_ram_00a579e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_RatingTab_BossRatingListAdapter_RendererOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_View_RatingTab_BossRatingListItemViewHolder_TypeInfo);
		    DAT_ram_00a579e9 = '\x01';
		  }
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Boss_View_RatingTab_BossRatingListItemViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_01,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar3 = *(int *)(param1_01 + 0x14);
		  param1_02 = unnamed_function_1417(System_Action_BossCaptainRatingData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_02,param1,
		             Method_Gameplay_Boss_View_RatingTab_BossRatingListAdapter_RendererOnClickEvent__,0);
		  if (DAT_ram_00a579f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    DAT_ram_00a579f1 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_03 = UnityEngine_UI_Image__set_sprite(param1_00,param1_02,0);
		    param2_00 = System_Action_BossCaptainRatingData__TypeInfo;
		    if ((param1_03 != 0) &&
		       (iVar2 = func_ii_1082(param1_03,System_Action_BossCaptainRatingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x3c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return param1_01;
		    }
		  }
		  System_Activator__CreateInstance(param1_03,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060046AD RID: 18093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x9543", Offset = "0x9543", VA = "0x9543", Slot = "99")]
		protected override BossRatingListItemViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x9544", Offset = "0x9544", VA = "0x9544")]
		private void RendererOnClickEvent(BossCaptainRatingData data)
		{
		/* --- GHIDRA: RendererOnClickEvent ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__RendererOnClickEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__get_Item__
		              );
		    DAT_ram_00a579ea = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__get_Item__
		                    );
		  Gameplay_Boss_View_RatingTab_BossRatingListItemView__get_CaptainRating(param2[5],uVar1,param2);
		  return;
		}
		*/

		}

		// Token: 0x060046AF RID: 18095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x9545", Offset = "0x9545", VA = "0x9545", Slot = "100")]
		protected override void UpdateViewsHolder(BossRatingListItemViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__UpdateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a579eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_RatingTab_BossRatingListAdapter_RendererOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossRatingListItemViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a579eb = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x14);
		  param1_01 = unnamed_function_1417(System_Action_BossCaptainRatingData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Boss_View_RatingTab_BossRatingListAdapter_RendererOnClickEvent__,0);
		  if (DAT_ram_00a579f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    DAT_ram_00a579f2 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_BossCaptainRatingData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_BossCaptainRatingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x3c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x9546", Offset = "0x9546", VA = "0x9546", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(BossRatingListItemViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a579ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__InsertItems__
		              );
		    DAT_ram_00a579ec = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object____ctor
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__InsertItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x9547", Offset = "0x9547", VA = "0x9547")]
		public void AddItemsAt(int index, IList<BossCaptainRatingData> items)
		{
		/* --- GHIDRA: AddItemsAt ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__AddItemsAt
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a579ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__RemoveItems__
		              );
		    DAT_ram_00a579ed = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(param1 + 0xa0),param2,param3,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__RemoveItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x9548", Offset = "0x9548", VA = "0x9548")]
		public void RemoveItemsFrom(int index, int count)
		{
		/* --- GHIDRA: RemoveItemsFrom ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__RemoveItemsFrom
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a579ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__ResetItems__
		              );
		    DAT_ram_00a579ee = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(param1 + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x9549", Offset = "0x9549", VA = "0x9549")]
		public void SetItems(IList<BossCaptainRatingData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__SetItems
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossRatingListItemViewHolder___ctor__
		              );
		    DAT_ram_00a579ef = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossRatingListItemViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x954A", Offset = "0x954A", VA = "0x954A")]
		public BossRatingListAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    DAT_ram_00a579e6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossCaptainRatingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossCaptainRatingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    DAT_ram_00a579e7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossCaptainRatingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossCaptainRatingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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
		void Gameplay_Boss_View_RatingTab_BossRatingListAdapter__remove_ClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossRatingListItemViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__TypeInfo)
		    ;
		    DAT_ram_00a579e8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossCaptainRatingData___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BossRatingListItemViewHolder__Start__
		            );
		  return;
		}
		*/

}
