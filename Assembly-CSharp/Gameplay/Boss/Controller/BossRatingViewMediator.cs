using System;
using System.Collections.Generic;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.RatingTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BAE RID: 2990
	[Token(Token = "0x2000BAE")]
	public class BossRatingViewMediator : AbstractBossWindowViewMediator<BossRatingView>
	{
		// Token: 0x0600494F RID: 18767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494F")]
		[Address(RVA = "0x97C1", Offset = "0x97C1", VA = "0x97C1")]
		public BossRatingViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossRatingViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5790e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_List_BossCaptainRatingData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRatingViewMediator_RatingReceivedEvent__);
		    DAT_ram_00a5790e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x44);
		  uVar1 = unnamed_function_1417(System_Action_List_BossCaptainRatingData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRatingViewMediator_RatingReceivedEvent__,0);
		  param1_00 = func_ii_7048(param1_01,uVar1,0);
		  uVar1 = System_Action_List_BossCaptainRatingData___TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x44) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Action_List_BossCaptainRatingData___TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x44) = iVar2;
		  uVar1 = System_Action_List_BossCaptainRatingData___TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_List_BossCaptainRatingData___TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004950")]
		[Address(RVA = "0x97C2", Offset = "0x97C2", VA = "0x97C2", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5790f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_List_BossCaptainRatingData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRatingViewMediator_RatingReceivedEvent__);
		    DAT_ram_00a5790f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x44);
		  uVar1 = unnamed_function_1417(System_Action_List_BossCaptainRatingData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRatingViewMediator_RatingReceivedEvent__,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar1,0);
		  uVar1 = System_Action_List_BossCaptainRatingData___TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x44) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,System_Action_List_BossCaptainRatingData___TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x44) = iVar2;
		  uVar1 = System_Action_List_BossCaptainRatingData___TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_List_BossCaptainRatingData___TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004951")]
		[Address(RVA = "0x97C3", Offset = "0x97C3", VA = "0x97C3", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57910 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRatingViewMediator_GreenToggleOnChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRatingViewMediator_ListAdapterOnClickEvent__);
		    DAT_ram_00a57910 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_BossCaptainRatingData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRatingViewMediator_ListAdapterOnClickEvent__,0);
		  Gameplay_Boss_View_RatingTab_BossRatingListAdapter__add_ClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x48);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRatingViewMediator_GreenToggleOnChangedEvent__,0);
		  UI_Toggle_GreenToggle__add_ChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004952")]
		[Address(RVA = "0x97C4", Offset = "0x97C4", VA = "0x97C4", Slot = "23")]
		protected override void ResetView(BossRatingView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57911 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRatingViewMediator_GreenToggleOnChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossRatingViewMediator_ListAdapterOnClickEvent__);
		    DAT_ram_00a57911 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_BossCaptainRatingData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRatingViewMediator_ListAdapterOnClickEvent__,0);
		  Gameplay_Boss_View_RatingTab_BossRatingListAdapter__set_Data(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x48);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossRatingViewMediator_GreenToggleOnChangedEvent__,0);
		  UI_ToolTip_Controller_Android_ToolTipController__GetPointerPosition(uVar2,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Boss_Controller_BossInstanceController__GetCaptainTeams(uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004953")]
		[Address(RVA = "0x97C5", Offset = "0x97C5", VA = "0x97C5", Slot = "24")]
		protected override void SetupView(BossRatingView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__SetupView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Gameplay_Boss_Controller_BossRatingViewMediator__RatingReceivedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004954")]
		[Address(RVA = "0x97C6", Offset = "0x97C6", VA = "0x97C6")]
		private void RatingReceivedEvent(List<BossCaptainRatingData> captainRatings)
		{
		/* --- GHIDRA: RatingReceivedEvent ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__RatingReceivedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a57912 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_BossCaptainRatingData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BossCaptainRatingData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_BossCaptainRatingData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BossCaptainRatingData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossCaptainRatingData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossCaptainRatingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRatingViewMediator___c__RenderRatingList_b__7_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossRatingViewMediator___c__RenderRatingList_b__7_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3654);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3652);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3655);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3653);
		    DAT_ram_00a57912 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    if ((param1[6] != 0) && (0 < *(int *)(param1[6] + 0xc))) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (*(undefined4 *)(iVar1 + 0x3c),2,
		                 Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		                );
		      iVar2 = *(int *)(param1[6] + 0xc);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar1 + 0x24);
		      if (0 < iVar2) {
		        uVar4 = System_Linq_Enumerable__ToList_object_
		                          (param1[6],0,
		                           Method_System_Collections_Generic_List_BossCaptainRatingData__get_Item__)
		        ;
		        Gameplay_Boss_View_RatingTab_BossTopLeaderView__get_CaptainRating(uVar3,uVar4,0);
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar3 = *(undefined4 *)(iVar1 + 0x24);
		      }
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(0 < iVar2),0);
		      iVar1 = *param1;
		      iVar2 = *(int *)(param1[6] + 0xc);
		      if (1 < iVar2) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(iVar1 + 0x15c));
		        uVar4 = *(undefined4 *)(iVar1 + 0x28);
		        uVar3 = System_Linq_Enumerable__ToList_object_
		                          (param1[6],1,
		                           Method_System_Collections_Generic_List_BossCaptainRatingData__get_Item__)
		        ;
		        Gameplay_Boss_View_RatingTab_BossTopLeaderView__get_CaptainRating(uVar4,uVar3,0);
		        iVar1 = *param1;
		      }
		      iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(iVar1 + 0x15c));
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x28),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(1 < iVar2),0);
		      iVar1 = *param1;
		      iVar2 = *(int *)(param1[6] + 0xc);
		      if (2 < iVar2) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(iVar1 + 0x15c));
		        uVar4 = *(undefined4 *)(iVar1 + 0x2c);
		        uVar3 = System_Linq_Enumerable__ToList_object_
		                          (param1[6],2,
		                           Method_System_Collections_Generic_List_BossCaptainRatingData__get_Item__)
		        ;
		        Gameplay_Boss_View_RatingTab_BossTopLeaderView__get_CaptainRating(uVar4,uVar3,0);
		        iVar1 = *param1;
		      }
		      iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(iVar1 + 0x15c));
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x2c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(2 < iVar2),0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar1 = param1[6];
		      if (*(char *)(*(int *)(iVar2 + 0x48) + 0x48) != '\0') {
		        if (*(int *)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		        }
		        puVar5 = *(undefined4 **)
		                  (Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c);
		        iVar2 = puVar5[1];
		        if (iVar2 == 0) {
		          if (*(int *)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		            puVar5 = *(undefined4 **)
		                      (Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c);
		          }
		          uVar3 = *puVar5;
		          iVar2 = unnamed_function_1417(System_Func_BossCaptainRatingData__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (iVar2,uVar3,
		                     Method_Gameplay_Boss_Controller_BossRatingViewMediator___c__RenderRatingList_b__7_0__
		                     ,0);
		          *(int *)(*(int *)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c) + 4
		                  ) = iVar2;
		        }
		        uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                          (iVar1,iVar2,Method_System_Linq_Enumerable_Where_BossCaptainRatingData___)
		        ;
		        iVar1 = System_Linq_Enumerable__Select_object__object_
		                          (uVar3,Method_System_Linq_Enumerable_ToList_BossCaptainRatingData___);
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_RatingTab_BossRatingListAdapter__RemoveItemsFrom
		                (*(undefined4 *)(iVar2 + 0x30),iVar1,0);
		      iVar1 = param1[6];
		      if (*(int *)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		      }
		      puVar5 = *(undefined4 **)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c)
		      ;
		      iVar2 = puVar5[2];
		      if (iVar2 == 0) {
		        if (*(int *)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		          puVar5 = *(undefined4 **)
		                    (Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c);
		        }
		        uVar3 = *puVar5;
		        iVar2 = unnamed_function_1417(System_Func_BossCaptainRatingData__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (iVar2,uVar3,
		                   Method_Gameplay_Boss_Controller_BossRatingViewMediator___c__RenderRatingList_b__7_1__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c) + 8)
		             = iVar2;
		      }
		      iVar1 = System_Func_object__bool____ctor
		                        (iVar1,iVar2,
		                         Method_System_Linq_Enumerable_FirstOrDefault_BossCaptainRatingData___);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar2 + 0x34);
		      if (iVar1 != 0) {
		        Gameplay_Boss_View_RatingTab_BossRatingListItemView__get_CaptainRating(uVar3,iVar1,0);
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar3 = *(undefined4 *)(iVar2 + 0x34);
		      }
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(iVar1 != 0),0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x38),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(iVar1 == 0),0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = *(int **)(iVar1 + 0x40);
		      puVar5 = &StringLiteral_3654;
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1[6],0,
		                         Method_System_Collections_Generic_List_BossCaptainRatingData__get_Item__);
		      if (*(char *)(iVar1 + 0x10) == '\0') {
		        puVar5 = &StringLiteral_3655;
		      }
		      uVar3 = *puVar5;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		      iVar1 = *piVar6;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (piVar6,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = *(int **)(iVar1 + 0x44);
		      puVar5 = &StringLiteral_3652;
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1[6],0,
		                         Method_System_Collections_Generic_List_BossCaptainRatingData__get_Item__);
		      if (*(char *)(iVar1 + 0x10) == '\0') {
		        puVar5 = &StringLiteral_3653;
		      }
		      uVar3 = *puVar5;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		      iVar1 = *piVar6;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (piVar6,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		      return;
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar1 + 0x3c),1,
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x97C7", Offset = "0x97C7", VA = "0x97C7")]
		private void RenderRatingList()
		{
		/* --- GHIDRA: RenderRatingList ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__RenderRatingList
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_Controller_BossRatingViewMediator__RatingReceivedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x97C8", Offset = "0x97C8", VA = "0x97C8")]
		private void GreenToggleOnChangedEvent()
		{
		/* --- GHIDRA: GreenToggleOnChangedEvent ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__GreenToggleOnChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57913 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossRatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57913 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1e0);
		        goto code_r0x80dfe853;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80dfe853:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_01,CONCAT44(in_register_20000014,puVar2[1]));
		  Core_Gameplay_Managers_BossManager__ShowBossRewardingWindow
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(param1 + 8) + 0x28) + 0x10),
		             *(undefined4 *)(param2 + 0xc),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004957")]
		[Address(RVA = "0x97C9", Offset = "0x97C9", VA = "0x97C9")]
		private void ListAdapterOnClickEvent(BossCaptainRatingData data)
		{
		/* --- GHIDRA: ListAdapterOnClickEvent ---
		void Gameplay_Boss_Controller_BossRatingViewMediator__ListAdapterOnClickEvent(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57914 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		    DAT_ram_00a57914 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Boss_Controller_BossRatingViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040027F7 RID: 10231
		[Token(Token = "0x40027F7")]
		[FieldOffset(Offset = "0x18")]
		private List<BossCaptainRatingData> _currentRatings;
	}
}
