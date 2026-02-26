using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.View;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Protocol.Rating;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	public class ClansRatingViewMediator : BaseRatingViewMediator
	{
		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000644")]
		protected override Action<RatingRequestDto> RequestRatingsAction
		{
			[Token(Token = "0x6002239")]
			[Address(RVA = "0x7390", Offset = "0x7390", VA = "0x7390", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000645")]
		protected override IList<RatingPrizeDic> RatingPrizes
		{
			[Token(Token = "0x600223A")]
			[Address(RVA = "0x7391", Offset = "0x7391", VA = "0x7391", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x7392", Offset = "0x7392", VA = "0x7392")]
		public ClansRatingViewMediator(RatingModel model, Gameplay.Rating.Events.RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType kindType, uint ratingType)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Control_ClansRatingViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_ClansRatingViewMediator__set_View(param1,param1);
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
		    Gameplay_Rating_Control_ClansRatingViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000646 RID: 1606
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000646")]
		public override RatingWindow View
		{
			[Token(Token = "0x600223C")]
			[Address(RVA = "0x7393", Offset = "0x7393", VA = "0x7393", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x7394", Offset = "0x7394", VA = "0x7394")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58079 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterSelectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		    DAT_ram_00a58079 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x5c),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(char *)(*(int *)(iVar1 + 0x6c) + 0xc4) == '\0'),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterDeselectedEventHandler__
		             ,0);
		  UI_Elements_GenericList_SelectableListElementArgs___ctor(uVar3,uVar2,0);
		  if ((char)param1[10] == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar1 + 0x70),3,
		               Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x7395", Offset = "0x7395", VA = "0x7395")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__SetupView(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a5807a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a5807a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  uVar2 = *(undefined8 *)(param1 + 0x18);
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  param2_00 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = uVar1;
		  *(undefined8 *)(param2_00 + 8) = uVar2;
		  Gameplay_Rating_Control_ClansRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,param2_00,*(undefined4 *)(param1 + 0x2c),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x7396", Offset = "0x7396", VA = "0x7396")]
		private void ExtraFilterDeselectedEventHandler()
		{
		/* --- GHIDRA: ExtraFilterDeselectedEventHandler ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__ExtraFilterDeselectedEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 uVar3;
		  
		  if (DAT_ram_00a5807b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ClanCultDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a5807b = '\x01';
		  }
		  iVar1 = Protocol_Dic_ClanCultDic_TypeInfo;
		  if (param2 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x2c) = 0;
		  }
		  else if ((Protocol_Dic_ClanCultDic_TypeInfo != *param2) ||
		          (*(int **)(param1 + 0x2c) = param2, *param2 != iVar1)) {
		    System_Activator__CreateInstance(param2,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = *(undefined8 *)(param1 + 0x18);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  iVar1 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  *(undefined8 *)(iVar1 + 8) = uVar3;
		  Gameplay_Rating_Control_ClansRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,iVar1,*(undefined4 *)(param1 + 0x2c),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x7397", Offset = "0x7397", VA = "0x7397")]
		private void ExtraFilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: ExtraFilterSelectedEventHandler ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__ExtraFilterSelectedEventHandler
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5807c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanInRatingListElement_ClanInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Where_ClanInRatingListElement_ClanInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanInRatingListElement_ClanInRatingListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass13_0__UpdateOsaView_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass13_0_TypeInfo);
		    DAT_ram_00a5807c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass13_0_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 8) = param3;
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  iVar4 = param1[2];
		  if (DAT_ram_00a5804f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a5804f = '\x01';
		  }
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar4 + 0x18),uVar2,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		                    );
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (uVar2,uVar3,
		                     Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		                    );
		  if (*(int *)(iVar1 + 8) != 0) {
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Func_ClanInRatingListElement_ClanInRatingListElementArgs__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,iVar1,
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass13_0__UpdateOsaView_b__0__
		               ,0);
		    uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar2,uVar3,
		                       Method_System_Linq_Enumerable_Where_ClanInRatingListElement_ClanInRatingListElementArgs___
		                      );
		    uVar2 = func_ii_6295(uVar2,
		                         Method_System_Linq_Enumerable_ToArray_ClanInRatingListElement_ClanInRatingListElementArgs___
		                        );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = **(int **)(iVar1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar4 + 0x10)
		              * 4))(*(int **)(iVar1 + 0x5c),uVar2,
		                    *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar4 + 0x14))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x7398", Offset = "0x7398", VA = "0x7398")]
		private void UpdateOsaView([NotNull] RatingRequestDto rating, [CanBeNull] ClanCultDic cultDic)
		{
		/* --- GHIDRA: UpdateOsaView ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__UpdateOsaView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a5807d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_ClansRatingViewMediator_ShowClanInfoPopupWindow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ClanInRatingListElement_ClanInRatingListElementArgs__ClanData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ClanInRatingListElement_ClanInRatingListElementArgs__ClanData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator___c__OnRatingsDataReceivingCompleteEvent_b__14_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a5807d = '\x01';
		  }
		  Gameplay_Rating_Control_ClansRatingViewMediator__InitExtraFilters
		            (param1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),param1);
		  Gameplay_Rating_Control_ClansRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,param2,param1[0xb],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar5 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = param1[2];
		  if (DAT_ram_00a5804f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a5804f = '\x01';
		  }
		  uVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar1 + 0x18),uVar4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		                    );
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (uVar4,uVar5,
		                     Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		                    );
		  if (*(int *)(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar6[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar5 = *puVar6;
		    iVar1 = unnamed_function_1417
		                      (
		                      System_Func_ClanInRatingListElement_ClanInRatingListElementArgs__ClanData__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar1,uVar5,
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator___c__OnRatingsDataReceivingCompleteEvent_b__14_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo + 0x5c) + 4) =
		         iVar1;
		  }
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,iVar1,
		                     Method_System_Linq_Enumerable_Select_ClanInRatingListElement_ClanInRatingListElementArgs__ClanData___
		                    );
		  uVar5 = unnamed_function_1417(System_Action_ClanData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Rating_Control_ClansRatingViewMediator_ShowClanInfoPopupWindow__,0);
		  UI_Elements_RatingElements_TopLeaders__Init(uVar3,uVar4,uVar5,0);
		  if ((char)param1[10] != '\0') {
		    uVar3 = *(undefined4 *)(param2 + 0x10);
		    uVar4 = *(undefined4 *)(param2 + 0xc);
		    iVar1 = param1[2];
		    if (DAT_ram_00a5804d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__get_Item__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                );
		      DAT_ram_00a5804d = '\x01';
		    }
		    uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar1 + 0x24),uVar3,
		                       Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                      );
		    iVar1 = System_Collections_Generic_List_object___get_Item
		                      (uVar3,uVar4,
		                       Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__get_Item__
		                      );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    if (iVar1 != 0) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (*(undefined4 *)(iVar2 + 0x70),2,
		                 Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      UI_Elements_Buildings_SpellItemArgs___ctor
		                (*(undefined4 *)(*(int *)(iVar2 + 0x70) + 0x20),iVar1,
		                 Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__Init__
		                );
		      return;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x70),4,
		               Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x7399", Offset = "0x7399", VA = "0x7399", Slot = "28")]
		protected override void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: OnRatingsDataReceivingCompleteEvent ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__OnRatingsDataReceivingCompleteEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5807e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a5807e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x4c);
		  iVar1 = param1[2];
		  if (DAT_ram_00a58047 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_RatingPeriods___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D
		              );
		    DAT_ram_00a58047 = '\x01';
		  }
		  iVar3 = *(int *)(iVar1 + 0x34);
		  if (iVar3 == 0) {
		    param1_00 = Mono_Security_ASN1Convert__ToOid(Protocol_Rating_RatingPeriods___TypeInfo,3);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (param1_00,
		               Field__PrivateImplementationDetails__4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D
		               ,0);
		    iVar3 = Gameplay_Rating_Model_RatingModel__HasCultsCache(iVar1,param1_00,iVar1);
		    *(int *)(iVar1 + 0x34) = iVar3;
		  }
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar2,iVar3,*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x739A", Offset = "0x739A", VA = "0x739A", Slot = "22")]
		protected override void InitPeriodFilters()
		{
		/* --- GHIDRA: InitPeriodFilters ---
		undefined4
		Gameplay_Rating_Control_ClansRatingViewMediator__InitPeriodFilters
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5807f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_FindIndex_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass16_0__InitSubRatingsFilters_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass16_0_TypeInfo);
		    DAT_ram_00a5807f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass16_0_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x48);
		  iVar4 = param1[2];
		  iVar2 = *(int *)(iVar4 + 0x40);
		  if (iVar2 == 0) {
		    iVar2 = Gameplay_Rating_Model_RatingModel__CreateUserSubRatingListElementArgs(iVar4,param1);
		    *(int *)(iVar4 + 0x40) = iVar2;
		  }
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent(uVar3,iVar2,0);
		  iVar4 = param1[2];
		  iVar2 = *(int *)(iVar4 + 0x40);
		  if (iVar2 == 0) {
		    iVar2 = Gameplay_Rating_Model_RatingModel__CreateUserSubRatingListElementArgs(iVar4,param1);
		    *(int *)(iVar4 + 0x40) = iVar2;
		  }
		  uVar3 = unnamed_function_1417(System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		  func_ii_7297(uVar3,iVar1,
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator___c__DisplayClass16_0__InitSubRatingsFilters_b__0__
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

		// Token: 0x06002244 RID: 8772 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x739B", Offset = "0x739B", VA = "0x739B", Slot = "23")]
		protected override SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
		/* --- GHIDRA: InitSubRatingsFilters ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__InitSubRatingsFilters
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58080 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a58080 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x50);
		  iVar3 = param1[2];
		  iVar1 = *(int *)(iVar3 + 0x2c);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Rating_Model_RatingModel__CreateCultFilterDatas(iVar3,0);
		    *(int *)(iVar3 + 0x2c) = iVar1;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))(piVar2,iVar1,*(undefined4 *)(iVar3 + 0xe4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x739C", Offset = "0x739C", VA = "0x739C", Slot = "21")]
		protected override void InitExtraFilters()
		{
		/* --- GHIDRA: InitExtraFilters ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__InitExtraFilters
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58081 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ClanInRatingListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator_ClanContextClickedEventHandler__
		              );
		    DAT_ram_00a58081 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5804f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		              );
		    DAT_ram_00a5804f = '\x01';
		  }
		  iVar1 = 0;
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar3 + 0x18),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____get_Item__
		                    );
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (uVar2,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____get_Item__
		                    );
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_ClanInRatingListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_Rating_Control_ClansRatingViewMediator_ClanContextClickedEventHandler__
		                 ,0);
		      *(undefined4 *)(iVar4 + 0x18) = uVar2;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5804d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a5804d = '\x01';
		  }
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar3 + 0x24),param3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                    );
		  iVar3 = System_Collections_Generic_List_object___get_Item
		                    (uVar2,param2,
		                     Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs__get_Item__
		                    );
		  if (iVar3 != 0) {
		    uVar2 = unnamed_function_1417(System_Action_ClanInRatingListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator_ClanContextClickedEventHandler__
		               ,0);
		    *(undefined4 *)(iVar3 + 0x18) = uVar2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002246")]
		[Address(RVA = "0x739D", Offset = "0x739D", VA = "0x739D")]
		private void InjectClansCallback(uint ratingType, RatingPeriods ratingPeriods)
		{
		/* --- GHIDRA: InjectClansCallback ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__InjectClansCallback
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58082 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanInRatingListElement_ClanInRatingListElementArgs__get_Data__
		              );
		    DAT_ram_00a58082 = '\x01';
		  }
		  Gameplay_Rating_Control_ClansRatingViewMediator__HandleRewardsToggleChanged
		            (param2,*(undefined4 *)(*(int *)(param2 + 0x18) + 0x1c),param2);
		  return;
		}
		*/

		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x739E", Offset = "0x739E", VA = "0x739E")]
		private void ClanContextClickedEventHandler(ClanInRatingListElement element)
		{
		/* --- GHIDRA: ClanContextClickedEventHandler ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__ClanContextClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58083 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ClanRatingKindDic_TypeInfo);
		    DAT_ram_00a58083 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Dic_ClanRatingKindDic_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Dic_ClanRatingKindDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[7] = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = Core_Extensions_Dict_ClanRatingKindDicExt__GetButton128AssetId(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Core_Extensions_Dict_ClanRatingKindDicExt__GetButton128AssetId(param1_00,0);
		  UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Core_Extensions_Dict_ClanRatingKindDicExt__GetTitle(param1_00,0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x739F", Offset = "0x739F", VA = "0x739F", Slot = "24")]
		protected override void SelectSubRatings(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectSubRatings ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__SelectSubRatings
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x73A0", Offset = "0x73A0", VA = "0x73A0", Slot = "27")]
		protected override void HandleRewardsToggleChanged(bool active)
		{
		/* --- GHIDRA: HandleRewardsToggleChanged ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__HandleRewardsToggleChanged
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58084 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58084 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80e9b74b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e9b74b:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__OpenClanTreasury(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224A")]
		[Address(RVA = "0x73A1", Offset = "0x73A1", VA = "0x73A1")]
		private void ShowClanInfoPopupWindow(ClanData data)
		{
		/* --- GHIDRA: ShowClanInfoPopupWindow ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__ShowClanInfoPopupWindow(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58085 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a58085 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Rating_Control_ClansRatingViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _hasClan;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0x2C")]
		private ClanCultDic _clanCultDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RequestRatingsAction ---
		undefined4
		Gameplay_Rating_Control_ClansRatingViewMediator__get_RequestRatingsAction
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58076 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a58076 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 700);
		}
		*/


		/* --- GHIDRA: get_RatingPrizes ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__get_RatingPrizes
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a58077 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a58077 = '\x01';
		  }
		  if (DAT_ram_00a5806a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		              );
		    DAT_ram_00a5806a = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = param6;
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(bool *)(param1 + 0x28) = *(int *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x68) != 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Rating_Control_ClansRatingViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58078 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterSelectedEventHandler__
		              );
		    DAT_ram_00a58078 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_ClansRatingViewMediator_ExtraFilterDeselectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		            (uVar3,uVar2,0);
		  param1[0xb] = 0;
		  return;
		}
		*/

}
