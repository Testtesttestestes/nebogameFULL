using System;
using System.Collections.Generic;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.Sections.Quests;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x2000908")]
	public class QuestsViewMediator : AbstractCozyViewMediator<QuestModel, QuestEvents, QuestController, QuestsView>
	{
		// Token: 0x06003659 RID: 13913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x8666", Offset = "0x8666", VA = "0x8666")]
		public QuestsViewMediator(QuestsView view, QuestModel model, QuestEvents events, QuestController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63aef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_DisplayData__);
		    DAT_ram_00a63aef = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_DisplayData__,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x20) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_DisplayData__,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar4 + 0x28) = piVar3, *piVar3 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x8667", Offset = "0x8667", VA = "0x8667", Slot = "21")]
		protected override void ResetEvents(QuestEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63af0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_DisplayData__);
		    DAT_ram_00a63af0 = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_DisplayData__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x20) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x20) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar4 + 0x28);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_DisplayData__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar4 + 0x28) = piVar3, *piVar3 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x8668", Offset = "0x8668", VA = "0x8668", Slot = "22")]
		protected override void SetupEvents(QuestEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a63af1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_HandleItemSelectedEvent__
		              );
		    DAT_ram_00a63af1 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(System_Action_IDailyQuest__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_HandleItemSelectedEvent__
		             ,0);
		  if (DAT_ram_00a63a9e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDailyQuest__TypeInfo);
		    DAT_ram_00a63a9e = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_IDailyQuest__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_IDailyQuest__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param2 + 0x28,iVar2,param1_00);
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

		// Token: 0x0600365C RID: 13916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x8669", Offset = "0x8669", VA = "0x8669", Slot = "23")]
		protected override void ResetView(QuestsView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator__ResetView
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a63af2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_HandleItemSelectedEvent__
		              );
		    DAT_ram_00a63af2 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(System_Action_IDailyQuest__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_HandleItemSelectedEvent__
		             ,0);
		  if (DAT_ram_00a63a9d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IDailyQuest__TypeInfo);
		    DAT_ram_00a63a9d = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_Action_IDailyQuest__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_IDailyQuest__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param2 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      Gameplay_Competition_Control_Sections_QuestsViewMediator__HandleItemSelectedEvent
		                (param1,iVar2);
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

		// Token: 0x0600365D RID: 13917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x866A", Offset = "0x866A", VA = "0x866A", Slot = "24")]
		protected override void SetupView(QuestsView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator__SetupView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63af3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_QuestModel__QuestEvents__QuestController__QuestsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_IDailyQuestExtInfoPresenter_TypeInfo);
		    DAT_ram_00a63af3 = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestExtInfoPresenter_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8233d835;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_DailyQuests_IDailyQuestExtInfoPresenter_TypeInfo,
		                                0);
		code_r0x8233d835:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x866B", Offset = "0x866B", VA = "0x866B")]
		private void HandleItemSelectedEvent(IQuest quest)
		{
		/* --- GHIDRA: HandleItemSelectedEvent ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator__HandleItemSelectedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int param2_00;
		  int *param2_01;
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63af4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_QuestModel__QuestEvents__QuestController__QuestsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestsListElementArgs___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestsListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_IDailyQuest__IQuest___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ThenBy_IDailyQuest__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IDailyQuest___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__IQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_HandleItemSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator___c__DisplayData_b__7_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator___c__DisplayData_b__7_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		    DAT_ram_00a63af4 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0x28);
		  if (*(int *)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_IDailyQuest__IQuest__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar5,
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator___c__DisplayData_b__7_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c)
		            + 4) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar4,param1[6],
		                     Method_System_Linq_Enumerable_OrderBy_IDailyQuest__IQuest___);
		  if (*(int *)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[2];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_IDailyQuest__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar4,uVar5,
		               Method_Gameplay_Competition_Control_Sections_QuestsViewMediator___c__DisplayData_b__7_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c)
		            + 8) = iVar4;
		  }
		  param2_00 = 0;
		  uVar2 = System_Linq_Enumerable__ThenBy_MarkToMarkAdjustmentRecord__uint_
		                    (uVar2,iVar4,Method_System_Linq_Enumerable_ThenBy_IDailyQuest__uint___);
		  iVar4 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_IDailyQuest___);
		  param2_01 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_DailyQuests_View_DailyQuestsListElementArgs___TypeInfo,
		                                *(undefined4 *)(iVar4 + 0xc));
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    do {
		      param1_00 = unnamed_function_1417
		                            (Gameplay_DailyQuests_View_DailyQuestsListElementArgs_TypeInfo);
		      UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		                (param1_00,0);
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (iVar4,param2_00,
		                         Method_System_Collections_Generic_List_IDailyQuest__get_Item__);
		      *(undefined4 *)(param1_00 + 0xc) = uVar2;
		      *(undefined4 *)(param1_00 + 0x10) = *(undefined4 *)(param1[2] + 8);
		      uVar2 = unnamed_function_1417(System_Action_IQuest__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_Competition_Control_Sections_QuestsViewMediator_HandleItemSelectedEvent__
		                 ,0);
		      *(undefined4 *)(param1_00 + 0x14) = uVar2;
		      iVar1 = func_ii_1082(param1_00,*(undefined4 *)(*param2_01 + 0x20));
		      if (iVar1 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_01[param2_00 + 4] = param1_00;
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar4 + 0xc));
		  }
		  iVar4 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x15c));
		  Gameplay_Competition_View_Sections_Quests_QuestsView__RunController(uVar2,param2_01,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x866C", Offset = "0x866C", VA = "0x866C")]
		private void DisplayData()
		{
		/* --- GHIDRA: DisplayData ---
		void Gameplay_Competition_Control_Sections_QuestsViewMediator__DisplayData(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63af5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		    DAT_ram_00a63af5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Competition_Control_Sections_QuestsViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[FieldOffset(Offset = "0x18")]
		private readonly IComparer<IQuest> _questComparer;
	}
}
