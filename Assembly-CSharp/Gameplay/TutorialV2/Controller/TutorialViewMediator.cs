using System;
using System.Collections.Generic;
using Gameplay.TutorialV2.Events;
using Gameplay.TutorialV2.Model;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	public class TutorialViewMediator : AbstractViewMediator<TutorialModel, TutorialEvents, TutorialController, TutorialView>
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x6B3F", Offset = "0x6B3F", VA = "0x6B3F", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: <SetupView>b__15_3 ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator___SetupView_b__15_3(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a583e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo);
		    DAT_ram_00a583e2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x5c) = uVar1
		  ;
		  return;
		}
		*/

		/* --- GHIDRA: <SetupView>b__15_0 ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator___SetupView_b__15_0
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = *(int *)(iVar1 + 0x1c);
		  iVar1 = *(int *)(param1_00 + 0x10);
		  if (iVar1 != 0) {
		    iVar2 = *(int *)(iVar1 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = *(int *)(param1_00 + 0x10);
		      if (iVar1 == 0) goto code_r0x80ee1ade;
		    }
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		  }
		code_r0x80ee1ade:
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (param1_00,iVar1);
		  return;
		}
		*/

		/* --- GHIDRA: <HandleCombatCompleteEvent>b__11_0 ---
		undefined4
		Gameplay_TutorialV2_Controller_TutorialViewMediator___HandleCombatCompleteEvent_b__11_0
		          (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MaskingShape___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a583e1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x14),0);
		  uVar2 = UnityEngine_Transform__set_parent(uVar2,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = func_ii_6805(param1_00,uVar2,Method_UnityEngine_Object_Instantiate_MaskingShape___);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: <HandleRequestPrepareGuideView>b__10_0 ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator___HandleRequestPrepareGuideView_b__10_0
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = *(int *)(iVar1 + 0x1c);
		  iVar1 = *(int *)(param1_01 + 0x10);
		  if (iVar1 != 0) {
		    iVar2 = *(int *)(iVar1 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = *(int *)(param1_01 + 0x10);
		      if (iVar1 == 0) goto code_r0x80ee1b68;
		    }
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		  }
		code_r0x80ee1b68:
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (param1_01,iVar1);
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__Dispose
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int *param2_00;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a583d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_CallbackQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDisposable__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_StartCombat__);
		    DAT_ram_00a583d9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IDisposable__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IDisposable___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView___ctor__
		            );
		  iVar4 = *(int *)(param4 + 0x1c);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem___TypeInfo
		                                ,1);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_StartCombat__,0
		            );
		  iVar2 = unnamed_function_1417(Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20));
		  if (iVar3 == 0) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = iVar2;
		  iVar2 = unnamed_function_1417(Gameplay_TutorialV2_Controller_CallbackQueue_TypeInfo);
		  if (DAT_ram_00a583b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		    DAT_ram_00a583b9 = '\x01';
		  }
		  *(undefined4 *)(iVar2 + 8) = 4;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (uVar1,param2_00,
		             Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		  *(undefined4 *)(iVar2 + 0xc) = uVar1;
		  if (DAT_ram_00a583d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		    DAT_ram_00a583d2 = '\x01';
		  }
		  iVar3 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		  iVar4 = *(int *)(iVar4 + 0xc);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar4,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x6B40", Offset = "0x6B40", VA = "0x6B40")]
		public TutorialViewMediator(TutorialModel model, TutorialEvents events, TutorialController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a583da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleRequestPrepareCombatView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleRequestPrepareGuideView__
		              );
		    DAT_ram_00a583da = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleInitEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleRequestPrepareCombatView__
		               ,0);
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
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleRequestPrepareGuideView__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleCombatCompleteEvent__
		               ,0);
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleInitEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleRequestPrepareCombatView__
		               ,0);
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
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleRequestPrepareGuideView__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleCombatCompleteEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000487 RID: 1159
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000487")]
		public override TutorialEvents Events
		{
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0x6B41", Offset = "0x6B41", VA = "0x6B41", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000488")]
		public override TutorialView View
		{
			[Token(Token = "0x60019AA")]
			[Address(RVA = "0x6B42", Offset = "0x6B42", VA = "0x6B42", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x6B43", Offset = "0x6B43", VA = "0x6B43")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleInitEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(iVar1 + 0x10),-435.0,1.0,0,0);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(iVar1 + 0x14),435.0,1.0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x6B44", Offset = "0x6B44", VA = "0x6B44")]
		private void StartCombat()
		{
		/* --- GHIDRA: StartCombat ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__StartCombat(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x6B45", Offset = "0x6B45", VA = "0x6B45")]
		private void HandleRequestPrepareCombatView()
		{
		/* --- GHIDRA: HandleRequestPrepareCombatView ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleRequestPrepareCombatView
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleRequestPrepareGuideView_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a583dc = '\x01';
		  }
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleRequestPrepareGuideView_b__10_0__
		             ,0);
		  DG_Tweening_DOVirtual__EasedValue(0.5,param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x6B46", Offset = "0x6B46", VA = "0x6B46")]
		private void HandleRequestPrepareGuideView()
		{
		/* --- GHIDRA: HandleRequestPrepareGuideView ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleRequestPrepareGuideView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a583dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_TutorialGameLeftPlayerAnimation___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleCombatCompleteEvent_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a583dd = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(iVar1 + 0x20),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_TutorialGameLeftPlayerAnimation___
		                    );
		  if (iVar1 != 0) {
		    Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation__ToBattle(local_4,param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(iVar1 + 0x10),-362.0,1.0,0,0);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(iVar1 + 0x14),362.0,1.0,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = DG_Tweening_DOTweenModuleSprite__DOColor
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x28) + 0x6c),0.0,1.8,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,0x1a,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		                    );
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleCombatCompleteEvent_b__11_0__
		             ,0);
		  DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar2,param1_00,
		             Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x6B47", Offset = "0x6B47", VA = "0x6B47")]
		private void HandleCombatCompleteEvent()
		{
		/* --- GHIDRA: HandleCombatCompleteEvent ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleCombatCompleteEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = *(int *)(iVar1 + 0x1c);
		  iVar1 = *(int *)(param1_00 + 0x10);
		  if (iVar1 != 0) {
		    iVar2 = *(int *)(iVar1 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = *(int *)(param1_00 + 0x10);
		      if (iVar1 == 0) goto code_r0x80ee194a;
		    }
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		  }
		code_r0x80ee194a:
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (param1_00,iVar1);
		  return;
		}
		*/

		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x6B48", Offset = "0x6B48", VA = "0x6B48")]
		private void HandleTutorialScreenClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleTutorialScreenClickEvent ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__HandleTutorialScreenClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a583de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_TutorialGameLeftPlayerAnimation___);
		    DAT_ram_00a583de = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(iVar1 + 0x20),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_TutorialGameLeftPlayerAnimation___
		                    );
		  if (iVar1 != 0) {
		    Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation__IdleToBattleAnimationCompleteEvent
		              (local_4,param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = *(int *)(iVar1 + 0x1c);
		  iVar1 = *(int *)(param1_00 + 0x10);
		  if (iVar1 != 0) {
		    iVar2 = *(int *)(iVar1 + 0xc);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),iVar1,*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = *(int *)(param1_00 + 0x10);
		      if (iVar1 == 0) goto code_r0x80ee1a13;
		    }
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		  }
		code_r0x80ee1a13:
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (param1_00,iVar1);
		  return;
		}
		*/

		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x6B49", Offset = "0x6B49", VA = "0x6B49")]
		private void StartCombatButtonClickedEventHandler()
		{
		/* --- GHIDRA: StartCombatButtonClickedEventHandler ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__StartCombatButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a583df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleTutorialScreenClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_OnRegistrationComplete__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_StartCombatButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a583df = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_OnRegistrationComplete__,0);
		  Gameplay_RegisterV2_View_RegistrationView__add_OnRegistrationComplete(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleTutorialScreenClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_StartCombatButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x6B4A", Offset = "0x6B4A", VA = "0x6B4A")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  float fVar10;
		  float fVar11;
		  float fVar12;
		  undefined4 *puVar13;
		  int iVar14;
		  undefined8 uVar15;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a583e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MaskingShape__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_AnalyticsQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_CombatOverlapQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_ProtoGetUserIsleInfoAns_Types_IsleInformation___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_MaskingShape__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDisposable__Add__);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_MessageBubbleQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Vector3___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Pool_ObjectPool_MaskingShape___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Pool_ObjectPool_MaskingShape__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_PointerQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Rect___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_ScaleQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Sprite___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_View_TutorialView_States___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleTutorialScreenClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_OnRegistrationComplete__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_StartCombatButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__SetupView_b__15_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__SetupView_b__15_3__);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_TutorialViewStatesQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator___c__SetupView_b__15_1__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialViewMediator___c__SetupView_b__15_2__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15260);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15263);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15256);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15258);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15259);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15262);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15261);
		    DAT_ram_00a583e0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar1 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_OnRegistrationComplete__,0);
		  Gameplay_RegisterV2_View_RegistrationView__remove_OnGenerateNick(uVar6,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_HandleTutorialScreenClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar6,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialViewMediator_StartCombatButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar6,uVar2,0);
		  piVar7 = *(int **)(param1[2] + 0x10);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x220);
		        goto code_r0x80edfee6;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80edfee6:
		  uVar9 = 0;
		  iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  Gameplay_Sound_Control_AudioController__PlayMusic(*(undefined4 *)(iVar1 + 0x18),0,0);
		  piVar7 = *(int **)(param1[2] + 0x10);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x220);
		        goto code_r0x80edff77;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80edff77:
		  uVar9 = 0;
		  iVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  Gameplay_Sound_Control_AudioController__PlaySound
		            (*(undefined4 *)(iVar1 + 0x18),*(undefined4 *)(param1[2] + 0x14),0);
		  piVar7 = *(int **)(param1[2] + 0x10);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x178);
		        goto code_r0x80ee000e;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ee000e:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetPortalStagesCount
		                    (uVar2,*(undefined4 *)(param1[2] + 0xc),0);
		  uVar2 = Core_Extensions_Dict_TutorialStepDicExt__GetDialog(uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0x178);
		        goto code_r0x80ee00d4;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ee00d4:
		  uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (*(undefined4 *)(param1[2] + 0x2c),
		                     Method_System_Linq_Enumerable_First_ProtoGetUserIsleInfoAns_Types_IsleInformation___
		                    );
		  iVar1 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                    (uVar6,*(undefined4 *)(*(int *)(iVar1 + 0x24) + 0xc),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar4 + 0x20);
		  uVar6 = Core_Extensions_Dict_AprDicExt__Get256AssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 8) + 0x38) + 0x10),0);
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(uVar8,uVar6,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar4 + 0x24);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar7;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar9 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80ee01f4;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ee01f4:
		  uVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar8,0);
		  uVar8 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (uVar8,*(undefined4 *)(iVar1 + 0x10),0);
		  uVar8 = Core_Extensions_Dict_AprDicExt__Get256AssetId(uVar8,0);
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(uVar6,uVar8,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_Transform__SetParent(*(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x10),uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_TutorialV2_View_PodiumTweens__get_RightPodium(*(undefined4 *)(iVar1 + 0x2c),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x38);
		  piVar7 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs___TypeInfo
		                             ,8);
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15256,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f631e323f77f65b;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[4] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15257,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f631e323d340b41;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[5] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15258,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f6a1ea23f000000;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 1;
		  local_18 = 0;
		  local_38 = 0;
		  local_20 = 0;
		  local_28 = (ulonglong)local_28._4_4_ << 0x20;
		  local_40 = 0x43070000440b0000;
		  local_30 = 0x43070000440b0000;
		  Sirenix_Serialization_NullableFormatter___Il2CppFullySharedGenericStructType___SerializeImplementation
		            (&local_20,&local_40,Method_System_Nullable_Vector3___ctor__);
		  *(undefined8 *)(iVar1 + 0x20) = local_18;
		  *(undefined8 *)(iVar1 + 0x18) = local_20;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[6] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15259,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f6a1ea23f000000;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 1;
		  local_28 = 0;
		  local_48 = 0;
		  local_30 = 0;
		  local_8 = 0;
		  local_50 = 0x43070000440b0000;
		  local_10 = 0x43070000440b0000;
		  Sirenix_Serialization_NullableFormatter___Il2CppFullySharedGenericStructType___SerializeImplementation
		            (&local_30,&local_50,Method_System_Nullable_Vector3___ctor__);
		  *(longlong *)(iVar1 + 0x20) = local_28;
		  *(undefined8 *)(iVar1 + 0x18) = local_30;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[7] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15260,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f6a1ea23f000000;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 1;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[8] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15261,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f6a1ea23f000000;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 1;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[9] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15262,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f6a1ea23f000000;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 1;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[10] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_TutorialV2_View_MessageBubbleView_MessageBubbleViewArgs_TypeInfo);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15263,1,0,1,0,0,0,0);
		  *(undefined8 *)(iVar1 + 0x10) = 0x3f5f2df33d1e68aa;
		  *(undefined4 *)(iVar1 + 0xc) = uVar6;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[0xb] = iVar1;
		  uVar6 = unnamed_function_1417(Gameplay_TutorialV2_Controller_MessageBubbleQueue_TypeInfo);
		  Gameplay_TutorialV2_Controller_MessageBubbleQueue__get_StepActionType(uVar6,uVar2,piVar7,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (DAT_ram_00a583d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		    DAT_ram_00a583d2 = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		  iVar1 = *(int *)(iVar1 + 0xc);
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar1 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = uVar6;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x34);
		  piVar7 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs___TypeInfo
		                             ,7);
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 0xc) = 0xc382000043b40000;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[4] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 0xc) = 0xc3750000c32a0000;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[5] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 0xc) = 0xc1a0000000000000;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[6] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = 0x43820000;
		  *(undefined8 *)(iVar1 + 8) = 0xc120000000000003;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[7] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = 0x43b40000;
		  *(undefined8 *)(iVar1 + 8) = 0xc120000000000003;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[8] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = 0x42a00000;
		  *(undefined8 *)(iVar1 + 8) = 0xc120000000000006;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar7[9] = iVar1;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GraphicPointerView_GraphicPointerViewArgs_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 0xc) = 0;
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar7 + 0x20));
		  if (iVar4 != 0) {
		    piVar7[10] = iVar1;
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_PointerQueue_TypeInfo);
		    if (DAT_ram_00a583bf == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__TypeInfo
		                );
		      DAT_ram_00a583bf = '\x01';
		    }
		    *(undefined4 *)(iVar1 + 8) = uVar2;
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs__TypeInfo
		                      );
		    System_Collections_Generic_Queue_JobHandle___get_Count
		              (uVar2,piVar7,
		               Method_System_Collections_Generic_Queue_GraphicPointerView_GraphicPointerViewArgs___ctor__
		              );
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar4 = *(int *)(iVar4 + 0x1c);
		    if (DAT_ram_00a583d2 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		      DAT_ram_00a583d2 = '\x01';
		    }
		    iVar14 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		    iVar4 = *(int *)(iVar4 + 0xc);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar4 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = iVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar4,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_TutorialV2_View_TutorialView_States___TypeInfo,4);
		    System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		              (uVar6,
		               Field__PrivateImplementationDetails__CF97ADEEDB59E05BFD73A2B4C2A8885708C4F4F70C84C64B27120E72AB733B72
		               ,0);
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_TutorialViewStatesQueue_TypeInfo);
		    if (DAT_ram_00a583e3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Queue_TutorialView_States___ctor__);
		      Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_TutorialView_States__TypeInfo);
		      DAT_ram_00a583e3 = '\x01';
		    }
		    uVar8 = unnamed_function_1417(System_Collections_Generic_Queue_TutorialView_States__TypeInfo);
		    System_Collections_Generic_Queue_Int32Enum____ctor
		              (uVar8,uVar6,Method_System_Collections_Generic_Queue_TutorialView_States___ctor__);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    *(undefined4 *)(iVar1 + 8) = uVar8;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar4 = *(int *)(iVar4 + 0x1c);
		    if (DAT_ram_00a583d2 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		      DAT_ram_00a583d2 = '\x01';
		    }
		    iVar14 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		    iVar4 = *(int *)(iVar4 + 0xc);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar4 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = iVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar4,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		    }
		    piVar7 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_____TypeInfo
		                               ,2);
		    piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs___TypeInfo,2
		                              );
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_TypeInfo)
		    ;
		    *(undefined4 *)(iVar1 + 0x1c) = 1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0x10);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    uVar15 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    *(undefined4 *)(iVar1 + 0x14) =
		         *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    *(undefined8 *)(iVar1 + 0xc) = uVar15;
		    *(undefined8 *)(iVar1 + 0x18) = 0x63f800000;
		    iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20));
		    if (iVar4 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar5[4] = iVar1;
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_TypeInfo)
		    ;
		    *(undefined4 *)(iVar1 + 0x1c) = 1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0x14);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    uVar15 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    *(undefined4 *)(iVar1 + 0x14) =
		         *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    *(undefined8 *)(iVar1 + 0xc) = uVar15;
		    *(undefined8 *)(iVar1 + 0x18) = 0x63f800000;
		    iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20));
		    if (iVar4 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar5[5] = iVar1;
		    iVar1 = func_ii_1082(piVar5,*(undefined4 *)(*piVar7 + 0x20));
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar7[4] = (int)piVar5;
		    piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs___TypeInfo,2
		                              );
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_TypeInfo)
		    ;
		    *(undefined4 *)(iVar1 + 0x1c) = 1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0x10);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    iVar4 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		    fVar10 = *(float *)(iVar4 + 0x10);
		    fVar11 = *(float *)(iVar4 + 0x14);
		    fVar12 = *(float *)(iVar4 + 0xc);
		    *(undefined8 *)(iVar1 + 0x18) = 0x63f800000;
		    *(float *)(iVar1 + 0xc) = fVar12 * 1.22;
		    *(float *)(iVar1 + 0x14) = fVar11 * 1.22;
		    *(float *)(iVar1 + 0x10) = fVar10 * 1.22;
		    iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20));
		    if (iVar4 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar5[4] = iVar1;
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_ScaleQueue_ScaleQueueArgs_TypeInfo)
		    ;
		    *(undefined4 *)(iVar1 + 0x1c) = 1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0x14);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    iVar4 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		    fVar10 = *(float *)(iVar4 + 0x10);
		    fVar11 = *(float *)(iVar4 + 0x14);
		    fVar12 = *(float *)(iVar4 + 0xc);
		    *(undefined8 *)(iVar1 + 0x18) = 0x63f800000;
		    *(float *)(iVar1 + 0xc) = fVar12 * 1.22;
		    *(float *)(iVar1 + 0x14) = fVar11 * 1.22;
		    *(float *)(iVar1 + 0x10) = fVar10 * 1.22;
		    iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20));
		    if (iVar4 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar5[5] = iVar1;
		    iVar1 = func_ii_1082(piVar5,*(undefined4 *)(*piVar7 + 0x20));
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar7[5] = (int)piVar5;
		    iVar1 = unnamed_function_1417(Gameplay_TutorialV2_Controller_ScaleQueue_TypeInfo);
		    if (DAT_ram_00a583c1 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs____ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs___TypeInfo
		                );
		      DAT_ram_00a583c1 = '\x01';
		    }
		    uVar2 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs___TypeInfo
		                      );
		    System_Collections_Generic_Queue_JobHandle___get_Count
		              (uVar2,piVar7,
		               Method_System_Collections_Generic_Queue_IReadOnlyList_ScaleQueue_ScaleQueueArgs____ctor__
		              );
		    *(undefined4 *)(iVar1 + 8) = uVar2;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar4 = *(int *)(iVar4 + 0x1c);
		    if (DAT_ram_00a583d2 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		      DAT_ram_00a583d2 = '\x01';
		    }
		    iVar14 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		    iVar4 = *(int *)(iVar4 + 0xc);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar4 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = iVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar4,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		    }
		    uVar2 = unnamed_function_1417(System_Func_MaskingShape__TypeInfo);
		    func_ii_19797(uVar2,param1,
		                  Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__SetupView_b__15_0__,0)
		    ;
		    if (*(int *)(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo);
		    }
		    puVar13 = *(undefined4 **)
		               (Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x5c);
		    iVar4 = puVar13[1];
		    iVar1 = Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo;
		    if (iVar4 == 0) {
		      if (*(int *)(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo);
		        puVar13 = *(undefined4 **)
		                   (Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar13;
		      iVar4 = unnamed_function_1417(System_Action_MaskingShape__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (iVar4,uVar6,
		                 Method_Gameplay_TutorialV2_Controller_TutorialViewMediator___c__SetupView_b__15_1__
		                 ,0);
		      iVar1 = Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo;
		      *(int *)(*(int *)(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x5c) + 4
		              ) = iVar4;
		    }
		    if (*(int *)(iVar1 + 0x74) == 0) {
		      func_ii_306000(iVar1);
		      iVar1 = Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo;
		    }
		    puVar13 = *(undefined4 **)(iVar1 + 0x5c);
		    iVar14 = puVar13[2];
		    if (iVar14 == 0) {
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		        puVar13 = *(undefined4 **)
		                   (Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar13;
		      iVar14 = unnamed_function_1417(System_Action_MaskingShape__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (iVar14,uVar6,
		                 Method_Gameplay_TutorialV2_Controller_TutorialViewMediator___c__SetupView_b__15_2__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_TutorialV2_Controller_TutorialViewMediator___c_TypeInfo + 0x5c) + 8
		              ) = iVar14;
		    }
		    uVar6 = unnamed_function_1417(UnityEngine_Pool_ObjectPool_MaskingShape__TypeInfo);
		    Coffee_UISoftMaskInternal_ObjectPool___Il2CppFullySharedGenericType___Return
		              (uVar6,uVar2,iVar4,iVar14,0,1,10,
		               s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1d8,
		               Method_UnityEngine_Pool_ObjectPool_MaskingShape___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_IDisposable__Add__;
		    iVar4 = param1[6];
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar9 = *(uint *)(iVar4 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = uVar6;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar4,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar1 + 0x40);
		    piVar7 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item___TypeInfo,5);
		    iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Rect___TypeInfo,2);
		    *(undefined8 *)(iVar1 + 0x28) = 0x4357000044354000;
		    *(undefined8 *)(iVar1 + 0x20) = 0x4393800043e40000;
		    *(undefined8 *)(iVar1 + 0x18) = 0x441d800043350000;
		    *(undefined8 *)(iVar1 + 0x10) = 0x42c4000042340000;
		    iVar4 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Sprite___TypeInfo,2);
		    iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x10);
		    iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x15c));
		    *(undefined4 *)(iVar4 + 0x14) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x14);
		    iVar14 = unnamed_function_1417(Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item_TypeInfo);
		    *(int *)(iVar14 + 0xc) = iVar4;
		    *(int *)(iVar14 + 8) = iVar1;
		    iVar1 = func_ii_1082(iVar14,*(undefined4 *)(*piVar7 + 0x20));
		    if (iVar1 != 0) {
		      piVar7[4] = iVar14;
		      iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Rect___TypeInfo,1);
		      *(undefined8 *)(iVar1 + 0x18) = 0x4357000044354000;
		      *(undefined8 *)(iVar1 + 0x10) = 0x43938000c3e40000;
		      iVar4 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Sprite___TypeInfo,1);
		      iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x14);
		      iVar14 = unnamed_function_1417
		                         (Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item_TypeInfo);
		      *(int *)(iVar14 + 0xc) = iVar4;
		      *(int *)(iVar14 + 8) = iVar1;
		      iVar1 = func_ii_1082(iVar14,*(undefined4 *)(*piVar7 + 0x20));
		      if (iVar1 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar7[5] = iVar14;
		      iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Rect___TypeInfo,2);
		      *(undefined8 *)(iVar1 + 0x28) = 0x4357000044354000;
		      *(undefined8 *)(iVar1 + 0x20) = 0x43938000c3e40000;
		      *(undefined8 *)(iVar1 + 0x18) = 0x441d800043350000;
		      *(undefined8 *)(iVar1 + 0x10) = 0x432a000042340000;
		      iVar4 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Sprite___TypeInfo,2);
		      iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x10);
		      iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x14) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x14);
		      iVar14 = unnamed_function_1417
		                         (Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item_TypeInfo);
		      *(int *)(iVar14 + 0xc) = iVar4;
		      *(int *)(iVar14 + 8) = iVar1;
		      iVar1 = func_ii_1082(iVar14,*(undefined4 *)(*piVar7 + 0x20));
		      if (iVar1 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar7[6] = iVar14;
		      iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Rect___TypeInfo,1);
		      *(undefined8 *)(iVar1 + 0x18) = 0x4357000044354000;
		      *(undefined8 *)(iVar1 + 0x10) = 0x43938000c3e40000;
		      iVar4 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Sprite___TypeInfo,1);
		      iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x14);
		      iVar14 = unnamed_function_1417
		                         (Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item_TypeInfo);
		      *(int *)(iVar14 + 0xc) = iVar4;
		      *(int *)(iVar14 + 8) = iVar1;
		      iVar1 = func_ii_1082(iVar14,*(undefined4 *)(*piVar7 + 0x20));
		      if (iVar1 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar7[7] = iVar14;
		      iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Rect___TypeInfo,2);
		      *(undefined8 *)(iVar1 + 0x28) = 0x4357000044354000;
		      *(undefined8 *)(iVar1 + 0x20) = 0x4393800043e40000;
		      *(undefined8 *)(iVar1 + 0x18) = 0x441d800043350000;
		      *(undefined8 *)(iVar1 + 0x10) = 0x432a000042340000;
		      iVar4 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Sprite___TypeInfo,2);
		      iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x10) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x10);
		      iVar14 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x15c));
		      *(undefined4 *)(iVar4 + 0x14) = *(undefined4 *)(*(int *)(iVar14 + 0x44) + 0x14);
		      iVar14 = unnamed_function_1417
		                         (Gameplay_TutorialV2_Controller_CombatOverlapQueue_Item_TypeInfo);
		      *(int *)(iVar14 + 0xc) = iVar4;
		      *(int *)(iVar14 + 8) = iVar1;
		      iVar1 = func_ii_1082(iVar14,*(undefined4 *)(*piVar7 + 0x20));
		      if (iVar1 != 0) {
		        piVar7[8] = iVar14;
		        uVar8 = unnamed_function_1417(Gameplay_TutorialV2_Controller_CombatOverlapQueue_TypeInfo);
		        Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem___ctor
		                  (uVar8,uVar2,uVar6,piVar7,param1);
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		        iVar1 = *(int *)(iVar1 + 0x1c);
		        if (DAT_ram_00a583d2 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		          DAT_ram_00a583d2 = '\x01';
		        }
		        iVar4 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		        iVar1 = *(int *)(iVar1 + 0xc);
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar9 = *(uint *)(iVar1 + 0xc);
		        if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = uVar8;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar1,uVar8,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		        }
		        uVar2 = unnamed_function_1417(Gameplay_TutorialV2_Controller_AnalyticsQueue_TypeInfo);
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		        iVar1 = *(int *)(iVar1 + 0x1c);
		        if (DAT_ram_00a583d2 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		          DAT_ram_00a583d2 = '\x01';
		        }
		        iVar4 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		        iVar1 = *(int *)(iVar1 + 0xc);
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar9 = *(uint *)(iVar1 + 0xc);
		        if (uVar9 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar9 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar9 * 4 + 0x10) = uVar2;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar1,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		        }
		        uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		        DG_Tweening_Color2__op_Multiply
		                  (uVar2,param1,
		                   Method_Gameplay_TutorialV2_Controller_TutorialViewMediator__SetupView_b__15_3__,0
		                  );
		        uVar2 = DG_Tweening_DOVirtual__EasedValue(1.0,uVar2,1,0);
		        uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (uVar6,0);
		        DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                  (uVar2,uVar6,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		        return;
		      }
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = func_ii_1083();
		  func_ii_1050(uVar2,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x6B4B", Offset = "0x6B4B", VA = "0x6B4B")]
		private void SetupView()
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x6B4C", Offset = "0x6B4C", VA = "0x6B4C")]
		private void OnRegistrationComplete()
		{
		}

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<IDisposable> _toDispose;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_TutorialV2_Controller_TutorialViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a583db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialModel__TutorialEvents__TutorialController__TutorialView__set_View__
		              );
		    DAT_ram_00a583db = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_TutorialV2_Controller_TutorialViewMediator__StartCombatButtonClickedEventHandler
		              (param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_TutorialV2_Controller_TutorialViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

}
