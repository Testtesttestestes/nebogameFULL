using System;
using System.Collections.Generic;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.DailyQuests.Controller
{
	// Token: 0x0200088B RID: 2187
	[Token(Token = "0x200088B")]
	public class DailyQuestsViewMediator : AbstractViewMediator<DailyQuestsModel, DailyQuestEvents, DailyQuestsController, DailyQuestsView>
	{
		// Token: 0x0600339B RID: 13211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x83D5", Offset = "0x83D5", VA = "0x83D5")]
		public DailyQuestsViewMediator(DailyQuestsModel model, DailyQuestEvents events, DailyQuestsController controller, uint categoryToShow)
		{
		/* --- GHIDRA: <GetIndex>b__10_2 ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___GetIndex_b__10_2(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c97 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		    DAT_ram_00a57c97 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <GetIndex>b__10_1 ---
		uint Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___GetIndex_b__10_1
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    DAT_ram_00a57c96 = '\x01';
		  }
		  iVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetCompletedQuestsWithPendingRewardCount
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 0xc),param2);
		  return (uint)(0 < iVar1);
		}
		*/

		/* --- GHIDRA: <GetIndex>b__10_0 ---
		uint Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___GetIndex_b__10_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c95 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    DAT_ram_00a57c95 = '\x01';
		  }
		  iVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetCompletedQuestsWithPendingRewardCount
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 0xc),param2);
		  return (uint)(0 < iVar1);
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57c8b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleSetupView__);
		    DAT_ram_00a57c8b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__,
		               0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleSetupView__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleActiveQuestsCountChanged__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__,
		               0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleSetupView__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleActiveQuestsCountChanged__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000A41 RID: 2625
		// (set) Token: 0x0600339C RID: 13212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A41")]
		public override DailyQuestEvents Events
		{
			[Token(Token = "0x600339C")]
			[Address(RVA = "0x83D6", Offset = "0x83D6", VA = "0x83D6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A42")]
		public override DailyQuestsView View
		{
			[Token(Token = "0x600339D")]
			[Address(RVA = "0x83D7", Offset = "0x83D7", VA = "0x83D7", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x83D8", Offset = "0x83D8", VA = "0x83D8")]
		private void HandleQuestsUpdated()
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x83D9", Offset = "0x83D9", VA = "0x83D9")]
		private void HandleActiveQuestsCountChanged()
		{
		/* --- GHIDRA: HandleActiveQuestsCountChanged ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__HandleActiveQuestsCountChanged
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57c8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_DailyQuestCategoriesDic__TabBarItemData_DailyQuestCategoriesDic____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_TabBarItemData_DailyQuestCategoriesDic____);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_DailyQuestCategoriesDic__TabBarItemData_DailyQuestCategoriesDic___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass9_0__HandleSetupView_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass9_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_23037);
		    DAT_ram_00a57c8e = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass9_0_TypeInfo
		                    );
		  *(int **)(iVar2 + 8) = param1;
		  param1_00 = *(int **)(param1[2] + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e41ca6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e41ca6:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Core_Extensions_Dict_DictExt__GetLongParameter(uVar4,StringLiteral_23037,0);
		  *(char *)(iVar2 + 0xc) = (char)uVar4;
		  param1_01 = *(undefined4 *)(param1[2] + 0x1c);
		  uVar4 = unnamed_function_1417
		                    (
		                    System_Func_DailyQuestCategoriesDic__TabBarItemData_DailyQuestCategoriesDic___TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar4,iVar2,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass9_0__HandleSetupView_b__0__
		             ,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_01,uVar4,
		                     Method_System_Linq_Enumerable_Select_DailyQuestCategoriesDic__TabBarItemData_DailyQuestCategoriesDic____
		                    );
		  uVar4 = func_ii_6295(uVar4,
		                       Method_System_Linq_Enumerable_ToArray_TabBarItemData_DailyQuestCategoriesDic____
		                      );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar2 + 0x10),uVar4,0);
		  uVar4 = Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__HandleSetupView
		                    (param1,uVar4,uVar4);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar2 + 0x10),uVar4,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x83DA", Offset = "0x83DA", VA = "0x83DA")]
		private void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		int Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__HandleSetupView
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57c8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_FindIndex_TabBarItemData_DailyQuestCategoriesDic____);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex_b__10_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex_b__10_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex_b__10_2__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_DailyQuestCategoriesDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DailyQuestCategoriesDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_DailyQuestCategoriesDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_DailyQuestCategoriesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_TabBarItemData_DailyQuestCategoriesDic___TypeInfo);
		    DAT_ram_00a57c8f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Predicate_TabBarItemData_DailyQuestCategoriesDic___TypeInfo);
		  func_ii_7297(uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex_b__10_0__,0)
		  ;
		  iVar2 = System_Array__FindAll___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Array_FindIndex_TabBarItemData_DailyQuestCategoriesDic____);
		  if (iVar2 < 0) {
		    uVar3 = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		    uVar1 = unnamed_function_1417(System_Func_DailyQuestCategoriesDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex_b__10_1__,0)
		    ;
		    uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar3,uVar1,Method_System_Linq_Enumerable_Where_DailyQuestCategoriesDic___);
		    iVar2 = System_Linq_Enumerable__Select_object__object_
		                      (uVar1,Method_System_Linq_Enumerable_ToList_DailyQuestCategoriesDic___);
		    if (*(int *)(iVar2 + 0xc) < 1) {
		      uVar3 = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		      uVar1 = unnamed_function_1417(System_Func_DailyQuestCategoriesDic__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar1,param1,
		                 Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex_b__10_2__,
		                 0);
		      uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar3,uVar1,Method_System_Linq_Enumerable_Where_DailyQuestCategoriesDic___)
		      ;
		      iVar2 = System_Linq_Enumerable__Select_object__object_
		                        (uVar1,Method_System_Linq_Enumerable_ToList_DailyQuestCategoriesDic___);
		      if (*(int *)(iVar2 + 0xc) < 1) {
		        iVar2 = System_Linq_Enumerable__Select_object__object_
		                          (*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),
		                           Method_System_Linq_Enumerable_ToList_DailyQuestCategoriesDic___);
		      }
		    }
		    iVar2 = Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex
		                      (param1,param2,iVar2,param1);
		    if (iVar2 < 1) {
		      iVar2 = 0;
		    }
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x83DB", Offset = "0x83DB", VA = "0x83DB")]
		private int GetIndex(TabBarItemData<DailyQuestCategoriesDic>[] data)
		{
		/* --- GHIDRA: GetIndex ---
		undefined4
		Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetIndex
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a57c90 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Array_FindIndex_TabBarItemData_DailyQuestCategoriesDic____);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Aggregate_DailyQuestCategoriesDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_DailyQuestCategoriesDic__DailyQuestCategoriesDic__DailyQuestCategoriesDic__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_TabBarItemData_DailyQuestCategoriesDic___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__GetFirstSortTabIndex_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass11_0__GetFirstSortTabIndex_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass11_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		    DAT_ram_00a57c90 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass11_0_TypeInfo
		                        );
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Func_DailyQuestCategoriesDic__DailyQuestCategoriesDic__DailyQuestCategoriesDic__TypeInfo
		                          );
		    System_Threading_Tasks_Task_object___get_Factory
		              (param1_00,uVar1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__GetFirstSortTabIndex_b__11_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c) +
		            4) = param1_00;
		  }
		  uVar1 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                    (param3,param1_00,
		                     Method_System_Linq_Enumerable_Aggregate_DailyQuestCategoriesDic___);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  uVar1 = unnamed_function_1417(System_Predicate_TabBarItemData_DailyQuestCategoriesDic___TypeInfo);
		  func_ii_7297(uVar1,param2_00,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayClass11_0__GetFirstSortTabIndex_b__1__
		               ,0);
		  uVar1 = System_Array__FindAll___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Array_FindIndex_TabBarItemData_DailyQuestCategoriesDic____);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x83DC", Offset = "0x83DC", VA = "0x83DC")]
		private int GetFirstSortTabIndex(TabBarItemData<DailyQuestCategoriesDic>[] data, List<DailyQuestCategoriesDic> list)
		{
		/* --- GHIDRA: GetFirstSortTabIndex ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetFirstSortTabIndex
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *param2_00;
		  int param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  uint param3_00;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57c91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestsListElementArgs___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestsListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleItemClick__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_IQuest__IQuest___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ThenBy_IQuest__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IQuest___);
		    Mono_Security_ASN1__get_Item(&System_Func_IQuest__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IQuest__IQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayData_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayData_b__12_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a57c91 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3_00 = (uint)*(byte *)(*(int *)(iVar2 + 0x18) + 0x10);
		  uVar3 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetGoal(param1[2],param2,param3_00,iVar2);
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c);
		  iVar2 = puVar6[2];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar6;
		    iVar2 = unnamed_function_1417(System_Func_IQuest__IQuest__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar2,uVar5,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayData_b__12_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c) +
		            8) = iVar2;
		  }
		  uVar3 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar3,iVar2,param1[7],Method_System_Linq_Enumerable_OrderBy_IQuest__IQuest___);
		  if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)
		            (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c);
		  iVar2 = puVar6[3];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar6;
		    iVar2 = unnamed_function_1417(System_Func_IQuest__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,uVar5,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c__DisplayData_b__12_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Controller_DailyQuestsViewMediator___c_TypeInfo + 0x5c) +
		            0xc) = iVar2;
		  }
		  iVar1 = 0;
		  uVar3 = System_Linq_Enumerable__ThenBy_MarkToMarkAdjustmentRecord__uint_
		                    (uVar3,iVar2,Method_System_Linq_Enumerable_ThenBy_IQuest__uint___);
		  iVar2 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_IQuest___);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_DailyQuests_View_DailyQuestsListElementArgs___TypeInfo,
		                                *(undefined4 *)(iVar2 + 0xc));
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = unnamed_function_1417
		                            (Gameplay_DailyQuests_View_DailyQuestsListElementArgs_TypeInfo);
		      Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext
		                (param1_00,0);
		      *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(iVar2 + iVar1 * 4 + 0x10);
		      *(undefined4 *)(param1_00 + 0x10) = *(undefined4 *)(param1[2] + 8);
		      uVar3 = unnamed_function_1417(System_Action_IQuest__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleItemClick__,0)
		      ;
		      *(undefined4 *)(param1_00 + 0x14) = uVar3;
		      iVar4 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20));
		      if (iVar4 == 0) {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_00[iVar1 + 4] = param1_00;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar1 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar1 + 0x15c));
		  Gameplay_DailyQuests_View_DailyQuestsView__get_TabBar(uVar3,param2_00,iVar1);
		  if (param3_00 == 0) {
		    iVar1 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetGoal(param1[2],param2,1,iVar1);
		    local_8 = *(undefined4 *)(iVar1 + 0xc);
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_8);
		    local_c = *(undefined4 *)(iVar2 + 0xc);
		    uVar5 = func_ii_1081(DAT_ram_00a66954,&local_c);
		    uVar3 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28672,uVar3,uVar5,0);
		  }
		  else {
		    local_4 = *(undefined4 *)(iVar2 + 0xc);
		    uVar3 = func_ii_4443(&local_4,0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Antiq_View_Grid_GridList__SetData(*(undefined4 *)(iVar2 + 0x1c),uVar3,0);
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x83DD", Offset = "0x83DD", VA = "0x83DD")]
		private void DisplayData(uint categoryId)
		{
		/* --- GHIDRA: DisplayData ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__DisplayData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57c92 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57c92 = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x10);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x170);
		        goto code_r0x80e42559;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x80e42559:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_DailyQuestsManager__ShowDailyQuestsWindow(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x83DE", Offset = "0x83DE", VA = "0x83DE")]
		private void HandleItemClick(IQuest data)
		{
		/* --- GHIDRA: HandleItemClick ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__HandleItemClick
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57c93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    DAT_ram_00a57c93 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x10),0);
		  param2_00 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetCompletedQuestsWithPendingRewardCount
		                        (param1[2],param1[6],param1);
		  Core_Extensions_Dict_BossGroupDictExt__GetTitle(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x83DF", Offset = "0x83DF", VA = "0x83DF")]
		private void ValidateTabCounters()
		{
		/* --- GHIDRA: ValidateTabCounters ---
		uint Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__ValidateTabCounters
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57c94 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__get_Data__)
		    ;
		    DAT_ram_00a57c94 = '\x01';
		  }
		  return (uint)(*(int *)(*(int *)(param2 + 0x20) + 0xc) == *(int *)(param1 + 0x18));
		}
		*/

		}

		// Token: 0x04001C18 RID: 7192
		[Token(Token = "0x4001C18")]
		[FieldOffset(Offset = "0x18")]
		private uint _currentCategory;

		// Token: 0x04001C19 RID: 7193
		[Token(Token = "0x4001C19")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IComparer<IQuest> _questComparer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57c8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__
		              );
		    DAT_ram_00a57c8c = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__,
		               0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__,
		               0);
		    UI_Toggle_Toggle__add_ChangedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__,
		               0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_DailyQuests_Controller_DailyQuestsViewMediator_HandleQuestsUpdated__,
		               0);
		    UI_Toggle_GreenToggle___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (*(char *)(iVar2 + 9) != '\0') {
		      Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__HandleActiveQuestsCountChanged
		                (param1,param1);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57c8d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__TypeInfo);
		    DAT_ram_00a57c8d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x10),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__TypeInfo + 0xb8) *
		                 4 + -4) != UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,UI_Tabs_TabBarItemData_DailyQuestCategoriesDic__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = *(int *)(param1_00[8] + 0xc);
		  param1[6] = iVar1;
		  Gameplay_DailyQuests_Controller_DailyQuestsViewMediator__GetFirstSortTabIndex(param1,iVar1,param1)
		  ;
		  if (DAT_ram_00a57c93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestsView__get_Model__
		              );
		    DAT_ram_00a57c93 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x10),0);
		  param2_00 = Gameplay_DailyQuests_Model_DailyQuestsModel__GetCompletedQuestsWithPendingRewardCount
		                        (param1[2],param1[6],param1);
		  Core_Extensions_Dict_BossGroupDictExt__GetTitle(param1_01,param2_00,0);
		  return;
		}
		*/

}
