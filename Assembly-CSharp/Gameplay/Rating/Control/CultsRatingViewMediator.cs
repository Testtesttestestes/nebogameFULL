using System;
using System.Collections.Generic;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2000598")]
	public class CultsRatingViewMediator : BaseRatingViewMediator
	{
		// Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002252")]
		[Address(RVA = "0x73A9", Offset = "0x73A9", VA = "0x73A9")]
		public CultsRatingViewMediator(RatingModel model, RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType kindType, uint ratingType)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Rating_Control_CultsRatingViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58087 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RatingRequestDto__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingController_RequestCultsRating__);
		    DAT_ram_00a58087 = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417(System_Action_RatingRequestDto__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_Rating_Control_RatingController_RequestCultsRating__,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000647")]
		protected override Action<RatingRequestDto> RequestRatingsAction
		{
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x73AA", Offset = "0x73AA", VA = "0x73AA", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000648")]
		protected override IList<RatingPrizeDic> RatingPrizes
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x73AB", Offset = "0x73AB", VA = "0x73AB", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000649")]
		public override RatingWindow View
		{
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x73AC", Offset = "0x73AC", VA = "0x73AC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x73AD", Offset = "0x73AD", VA = "0x73AD")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58089 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		    DAT_ram_00a58089 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x60),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) == '\0'),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x70),4,
		             Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x73AE", Offset = "0x73AE", VA = "0x73AE")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a5808a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_CultInRatingListElement_CultInRatingListElementArgs__CultDic___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_CultInRatingListElement_CultInRatingListElementArgs__CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_CultsRatingViewMediator___c__OnRatingsDataReceivingCompleteEvent_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a5808a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x60);
		  uVar3 = *(undefined4 *)(param2 + 0x10);
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = param1[2];
		  if (DAT_ram_00a58050 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a58050 = '\x01';
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar1 + 0x1c),uVar3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		                    );
		  uVar3 = System_Collections_Generic_List_object___get_Item
		                    (uVar3,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____get_Item__
		                    );
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 0x10)
		              * 4))(piVar2,uVar3,
		                    *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 0x14))
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar5 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = param1[2];
		  if (DAT_ram_00a58050 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a58050 = '\x01';
		  }
		  uVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar1 + 0x1c),uVar4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____get_Item__
		                    );
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (uVar4,uVar5,
		                     Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____get_Item__
		                    );
		  if (*(int *)(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar6[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar5 = *puVar6;
		    iVar1 = unnamed_function_1417
		                      (
		                      System_Func_CultInRatingListElement_CultInRatingListElementArgs__CultDic__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar1,uVar5,
		               Method_Gameplay_Rating_Control_CultsRatingViewMediator___c__OnRatingsDataReceivingCompleteEvent_b__9_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo + 0x5c) + 4) =
		         iVar1;
		  }
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,iVar1,
		                     Method_System_Linq_Enumerable_Select_CultInRatingListElement_CultInRatingListElementArgs__CultDic___
		                    );
		  UI_Elements_RatingElements_TopLeaders__Init(uVar3,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x73AF", Offset = "0x73AF", VA = "0x73AF", Slot = "28")]
		protected override void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: OnRatingsDataReceivingCompleteEvent ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__OnRatingsDataReceivingCompleteEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5808b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a5808b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x4c);
		  iVar1 = param1[2];
		  if (DAT_ram_00a58048 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods___TypeInfo);
		    DAT_ram_00a58048 = '\x01';
		  }
		  iVar3 = *(int *)(iVar1 + 0x38);
		  if (iVar3 == 0) {
		    iVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Rating_RatingPeriods___TypeInfo,2);
		    *(undefined8 *)(iVar3 + 0x10) = 0x400000005;
		    iVar3 = Gameplay_Rating_Model_RatingModel__HasCultsCache(iVar1,iVar3,iVar1);
		    *(int *)(iVar1 + 0x38) = iVar3;
		  }
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar2,iVar3,*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x73B0", Offset = "0x73B0", VA = "0x73B0", Slot = "22")]
		protected override void InitPeriodFilters()
		{
		/* --- GHIDRA: InitPeriodFilters ---
		undefined4
		Gameplay_Rating_Control_CultsRatingViewMediator__InitPeriodFilters
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5808c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_FindIndex_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_CultsRatingViewMediator___c__DisplayClass11_0__InitSubRatingsFilters_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_Control_CultsRatingViewMediator___c__DisplayClass11_0_TypeInfo);
		    DAT_ram_00a5808c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Rating_Control_CultsRatingViewMediator___c__DisplayClass11_0_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x48);
		  iVar4 = param1[2];
		  iVar2 = *(int *)(iVar4 + 0x44);
		  if (iVar2 == 0) {
		    iVar2 = Gameplay_Rating_Model_RatingModel__CreateClanSubRatingListElementArgs(iVar4,param1);
		    *(int *)(iVar4 + 0x44) = iVar2;
		  }
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent(uVar3,iVar2,0);
		  iVar4 = param1[2];
		  iVar2 = *(int *)(iVar4 + 0x44);
		  if (iVar2 == 0) {
		    iVar2 = Gameplay_Rating_Model_RatingModel__CreateClanSubRatingListElementArgs(iVar4,param1);
		    *(int *)(iVar4 + 0x44) = iVar2;
		  }
		  uVar3 = unnamed_function_1417(System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		  func_ii_7297(uVar3,iVar1,
		               Method_Gameplay_Rating_Control_CultsRatingViewMediator___c__DisplayClass11_0__InitSubRatingsFilters_b__0__
		               ,0);
		  iVar2 = System_Array__FindAll___Il2CppFullySharedGenericType_
		                    (iVar2,uVar3,Method_System_Array_FindIndex_SubFilterListElement_SubFilterData___
		                    );
		  if (iVar2 == -1) {
		    uVar3 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                      (*(undefined4 *)(iVar1 + 0x48),iVar2,0);
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600225A")]
		[Address(RVA = "0x73B1", Offset = "0x73B1", VA = "0x73B1", Slot = "23")]
		protected override SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
			return null;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x73B2", Offset = "0x73B2", VA = "0x73B2", Slot = "21")]
		protected override void InitExtraFilters()
		{
		/* --- GHIDRA: InitExtraFilters ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__InitExtraFilters
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5808d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_CultRatingKindDic_TypeInfo);
		    DAT_ram_00a5808d = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Dic_CultRatingKindDic_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Dic_CultRatingKindDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[7] = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetButton128AssetId(param1_00,0);
		  UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetTitle(param1_00,0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x73B3", Offset = "0x73B3", VA = "0x73B3", Slot = "24")]
		protected override void SelectSubRatings(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectSubRatings ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__SelectSubRatings
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225D")]
		[Address(RVA = "0x73B4", Offset = "0x73B4", VA = "0x73B4", Slot = "27")]
		protected override void HandleRewardsToggleChanged(bool active)
		{
		/* --- GHIDRA: HandleRewardsToggleChanged ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__HandleRewardsToggleChanged(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5808e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a5808e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Rating_Control_CultsRatingViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RequestRatingsAction ---
		undefined4
		Gameplay_Rating_Control_CultsRatingViewMediator__get_RequestRatingsAction
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58088 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a58088 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0x2c0);
		}
		*/


		/* --- GHIDRA: get_RatingPrizes ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__get_RatingPrizes
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x60),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  if (DAT_ram_00a5806b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__set_View__
		              );
		    DAT_ram_00a5806b = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_BaseRatingViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_BaseRatingViewMediator__ResetView(param1,param1);
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_CultsRatingViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Rating_Control_CultsRatingViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

}
