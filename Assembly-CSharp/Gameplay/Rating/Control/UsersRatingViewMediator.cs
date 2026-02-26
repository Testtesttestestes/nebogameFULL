using System;
using System.Collections.Generic;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Rating.Control
{
	// Token: 0x0200059D RID: 1437
	[Token(Token = "0x200059D")]
	public class UsersRatingViewMediator : BaseRatingViewMediator
	{
		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700064B")]
		protected override Action<RatingRequestDto> RequestRatingsAction
		{
			[Token(Token = "0x6002278")]
			[Address(RVA = "0x73CF", Offset = "0x73CF", VA = "0x73CF", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700064C")]
		protected override IList<RatingPrizeDic> RatingPrizes
		{
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x73D0", Offset = "0x73D0", VA = "0x73D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x73D1", Offset = "0x73D1", VA = "0x73D1")]
		public UsersRatingViewMediator(RatingModel model, RatingEvents events, RatingController controller, RatingKindTypeDic.Types.RatingKindType ratingKindType, uint ratingType)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Control_UsersRatingViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Rating_Control_UsersRatingViewMediator__set_View(param1,param1);
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
		    Gameplay_Rating_Control_UsersRatingViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700064D RID: 1613
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064D")]
		public override RatingWindow View
		{
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x73D2", Offset = "0x73D2", VA = "0x73D2", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x73D3", Offset = "0x73D3", VA = "0x73D3")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a580a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterSelectedEventHandler__
		              );
		    DAT_ram_00a580a5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x58),0);
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
		             Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterDeselectedEventHandler__
		             ,0);
		  UI_Elements_GenericList_SelectableListElementArgs___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x73D4", Offset = "0x73D4", VA = "0x73D4")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__SetupView(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a580a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a580a6 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  uVar2 = *(undefined8 *)(param1 + 0x18);
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  param2_00 = unnamed_function_1417(Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = uVar1;
		  *(undefined8 *)(param2_00 + 8) = uVar2;
		  Gameplay_Rating_Control_UsersRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,param2_00,*(undefined4 *)(param1 + 0x28),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x73D5", Offset = "0x73D5", VA = "0x73D5")]
		private void ExtraFilterDeselectedEventHandler()
		{
		/* --- GHIDRA: ExtraFilterDeselectedEventHandler ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__ExtraFilterDeselectedEventHandler
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 uVar3;
		  
		  if (DAT_ram_00a580a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_CultDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a580a7 = '\x01';
		  }
		  iVar1 = Protocol_Dic_CultDic_TypeInfo;
		  if (param2 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x28) = 0;
		  }
		  else if ((Protocol_Dic_CultDic_TypeInfo != *param2) ||
		          (*(int **)(param1 + 0x28) = param2, *param2 != iVar1)) {
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
		  Gameplay_Rating_Control_UsersRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,iVar1,*(undefined4 *)(param1 + 0x28),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x73D6", Offset = "0x73D6", VA = "0x73D6")]
		private void ExtraFilterSelectedEventHandler(object data)
		{
		/* --- GHIDRA: ExtraFilterSelectedEventHandler ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__ExtraFilterSelectedEventHandler
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a580a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Where_UserInRatingListElement_UserInRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserInRatingListElement_UserInRatingListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass12_0__UpdateOsaView_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass12_0_TypeInfo);
		    DAT_ram_00a580a8 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass12_0_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 8) = param3;
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  iVar4 = param1[2];
		  if (DAT_ram_00a5804e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____get_Item__
		              );
		    DAT_ram_00a5804e = '\x01';
		  }
		  uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar4 + 0x14),uVar2,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		                    );
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (uVar2,uVar3,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____get_Item__
		                    );
		  if (*(int *)(iVar1 + 8) != 0) {
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Func_UserInRatingListElement_UserInRatingListElementArgs__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,iVar1,
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass12_0__UpdateOsaView_b__0__
		               ,0);
		    uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar2,uVar3,
		                       Method_System_Linq_Enumerable_Where_UserInRatingListElement_UserInRatingListElementArgs___
		                      );
		    uVar2 = func_ii_6295(uVar2,
		                         Method_System_Linq_Enumerable_ToArray_UserInRatingListElement_UserInRatingListElementArgs___
		                        );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = **(int **)(iVar1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar4 + 0x10)
		              * 4))(*(int **)(iVar1 + 0x58),uVar2,
		                    *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar4 + 0x14))
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x73D7", Offset = "0x73D7", VA = "0x73D7")]
		private void UpdateOsaView([NotNull] RatingRequestDto rating, [CanBeNull] CultDic cultDic)
		{
		/* --- GHIDRA: UpdateOsaView ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__UpdateOsaView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a580a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInRatingListElement_UserInRatingListElementArgs__UserData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserInRatingListElement_UserInRatingListElementArgs__UserData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator___c__OnRatingsDataReceivingCompleteEvent_b__13_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a580a9 = '\x01';
		  }
		  Gameplay_Rating_Control_UsersRatingViewMediator__ExtraFilterSelectedEventHandler
		            (param1,param2,param1[10],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x44);
		  uVar4 = *(undefined4 *)(param2 + 0x10);
		  uVar5 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = param1[2];
		  if (DAT_ram_00a5804e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____get_Item__
		              );
		    DAT_ram_00a5804e = '\x01';
		  }
		  uVar4 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar1 + 0x14),uVar4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____get_Item__
		                    );
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (uVar4,uVar5,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____get_Item__
		                    );
		  if (*(int *)(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar6[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar5 = *puVar6;
		    iVar1 = unnamed_function_1417
		                      (
		                      System_Func_UserInRatingListElement_UserInRatingListElementArgs__UserData__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar1,uVar5,
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator___c__OnRatingsDataReceivingCompleteEvent_b__13_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo + 0x5c) + 4) =
		         iVar1;
		  }
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,iVar1,
		                     Method_System_Linq_Enumerable_Select_UserInRatingListElement_UserInRatingListElementArgs__UserData___
		                    );
		  UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0___Init_b__0(uVar3,uVar4,0);
		  uVar3 = *(undefined4 *)(param2 + 0x10);
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = param1[2];
		  if (DAT_ram_00a5804c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a5804c = '\x01';
		  }
		  uVar3 = GAFInternal_Reader_GAFReader__OpenTag
		                    (*(undefined4 *)(iVar1 + 0x20),uVar3,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs___get_Item__
		                    );
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (uVar3,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs__get_Item__
		                    );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x70),1,
		               Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (*(undefined4 *)(*(int *)(iVar2 + 0x70) + 0x1c),iVar1,
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__Init__
		              );
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x70),4,
		             Method_UI_MonoBehaviourWithStates_MyRatingView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x73D8", Offset = "0x73D8", VA = "0x73D8", Slot = "28")]
		protected override void OnRatingsDataReceivingCompleteEvent(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: OnRatingsDataReceivingCompleteEvent ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__OnRatingsDataReceivingCompleteEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a580aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a580aa = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x4c);
		  iVar1 = *(int *)param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                    ((int *)param1[2],*(undefined4 *)(iVar1 + 0xf4));
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))(piVar3,uVar2,*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x73D9", Offset = "0x73D9", VA = "0x73D9", Slot = "22")]
		protected override void InitPeriodFilters()
		{
		/* --- GHIDRA: InitPeriodFilters ---
		undefined4
		Gameplay_Rating_Control_UsersRatingViewMediator__InitPeriodFilters
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a580ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_FindIndex_SubFilterListElement_SubFilterData___);
		    Mono_Security_ASN1__get_Item(&System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass15_0__InitSubRatingsFilters_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a580ab = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass15_0_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x48);
		  iVar4 = param1[2];
		  iVar2 = *(int *)(iVar4 + 0x3c);
		  if (iVar2 == 0) {
		    iVar2 = Gameplay_Rating_Model_RatingModel__CreateClanCultFilterDatas(iVar4,param1);
		    *(int *)(iVar4 + 0x3c) = iVar2;
		  }
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent(uVar3,iVar2,0);
		  iVar4 = param1[2];
		  iVar2 = *(int *)(iVar4 + 0x3c);
		  if (iVar2 == 0) {
		    iVar2 = Gameplay_Rating_Model_RatingModel__CreateClanCultFilterDatas(iVar4,param1);
		    *(int *)(iVar4 + 0x3c) = iVar2;
		  }
		  uVar3 = unnamed_function_1417(System_Predicate_SubFilterListElement_SubFilterData__TypeInfo);
		  func_ii_7297(uVar3,iVar1,
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator___c__DisplayClass15_0__InitSubRatingsFilters_b__0__
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

		// Token: 0x06002283 RID: 8835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x73DA", Offset = "0x73DA", VA = "0x73DA", Slot = "23")]
		protected override SubFilterListElement InitSubRatingsFilters(uint ratingType)
		{
		/* --- GHIDRA: InitSubRatingsFilters ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__InitSubRatingsFilters
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a580ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a580ac = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x50);
		  iVar3 = param1[2];
		  iVar1 = *(int *)(iVar3 + 0x28);
		  if (iVar1 == 0) {
		    iVar1 = Gameplay_Rating_Model_RatingModel__CreatePeriodFilterDatas(iVar3,0);
		    *(int *)(iVar3 + 0x28) = iVar1;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))(piVar2,iVar1,*(undefined4 *)(iVar3 + 0xe4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x73DB", Offset = "0x73DB", VA = "0x73DB", Slot = "21")]
		protected override void InitExtraFilters()
		{
		/* --- GHIDRA: InitExtraFilters ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__InitExtraFilters
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a580ad == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_UserRatingKindDic_TypeInfo);
		    DAT_ram_00a580ad = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Dic_UserRatingKindDic_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Dic_UserRatingKindDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1[7] = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x40);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar1 + 0x40);
		    uVar2 = Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(param1_00,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(param1_00,0);
		  UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		            (uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = Core_Extensions_Dict_UserRatingKindDicExt__GetButton128AssetId(param1_00,0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x73DC", Offset = "0x73DC", VA = "0x73DC", Slot = "24")]
		protected override void SelectSubRatings(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectSubRatings ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__SelectSubRatings
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x73DD", Offset = "0x73DD", VA = "0x73DD", Slot = "27")]
		protected override void HandleRewardsToggleChanged(bool active)
		{
		/* --- GHIDRA: HandleRewardsToggleChanged ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__HandleRewardsToggleChanged(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a580ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a580ae = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Rating_Control_UsersRatingViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x28")]
		private CultDic _cultDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RequestRatingsAction ---
		undefined4
		Gameplay_Rating_Control_UsersRatingViewMediator__get_RequestRatingsAction
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__get_Model__
		              );
		    DAT_ram_00a580a3 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0x2a8);
		}
		*/


		/* --- GHIDRA: get_RatingPrizes ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__get_RatingPrizes
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
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
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Rating_Control_UsersRatingViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a580a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterDeselectedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterSelectedEventHandler__
		              );
		    DAT_ram_00a580a4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x58),0);
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
		             Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterSelectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x50);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Rating_Control_UsersRatingViewMediator_ExtraFilterDeselectedEventHandler__
		             ,0);
		  UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		            (uVar3,uVar2,0);
		  param1[10] = 0;
		  return;
		}
		*/

}
