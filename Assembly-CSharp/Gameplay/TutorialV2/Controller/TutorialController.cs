using System;
using System.Runtime.CompilerServices;
using Gameplay.TutorialCombatV2;
using Gameplay.TutorialV2.Events;
using Gameplay.TutorialV2.Model;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	public class TutorialController : AbstractController<TutorialModel, TutorialEvents>
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000484")]
		public TutorialStepsConveyor Conveyor
		{
			[Token(Token = "0x6001980")]
			[Address(RVA = "0x6B1F", Offset = "0x6B1F", VA = "0x6B1F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001981")]
			[Address(RVA = "0x6B20", Offset = "0x6B20", VA = "0x6B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x6B21", Offset = "0x6B21", VA = "0x6B21", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <RequestCombatStart>b__16_0 ---
		void Gameplay_TutorialV2_Controller_TutorialController___RequestCombatStart_b__16_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a583d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TutorialStepsQueueBase___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TutorialStepsQueueBase__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_StepActionType___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_StepActionType__TypeInfo);
		    DAT_ram_00a583d1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TutorialStepsQueueBase__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TutorialStepsQueueBase___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Queue_StepActionType__TypeInfo);
		  System_Collections_Generic_Queue_Int32Enum____ctor
		            (uVar1,param2,Method_System_Collections_Generic_Queue_StepActionType___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <PrepareData>b__10_2 ---
		void Gameplay_TutorialV2_Controller_TutorialController___PrepareData_b__10_2
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a583d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo);
		    DAT_ram_00a583d0 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(undefined1 *)(param1_00[6] + 0x5c) = 0;
		  iVar1 = *(int *)(param1_00[10] + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: <PrepareData>b__10_1 ---
		void Gameplay_TutorialV2_Controller_TutorialController___PrepareData_b__10_1
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *param1_00;
		  bool bVar3;
		  int local_4;
		  
		  if (DAT_ram_00a583cf == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetUserIsleInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetUserIsleInfoAns_Types_Status_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11965);
		    DAT_ram_00a583cf = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_World_ProtoGetUserIsleInfoAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_World_ProtoGetUserIsleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = param1_00[5];
		  if (local_4 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x2c) = param1_00[3];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x30) = param1_00[4];
		    if (*(char *)((int)param1 + 9) == '\0') {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (*(char *)(iVar2 + 0x34) == '\0') {
		        bVar3 = true;
		      }
		      else {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        bVar3 = *(char *)(iVar2 + 0x34) != '\0';
		      }
		      *(bool *)((int)param1 + 9) = bVar3;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 8);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  else {
		    uVar1 = func_ii_1081(Protocol_World_ProtoGetUserIsleInfoAns_Types_Status_TypeInfo,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_11965,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: <PrepareData>b__10_0 ---
		void Gameplay_TutorialV2_Controller_TutorialController___PrepareData_b__10_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a583ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoGetTutorialUserInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController__PrepareData_b__10_2__);
		    DAT_ram_00a583ce = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Tutorial_ProtoGetTutorialUserInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Tutorial_ProtoGetTutorialUserInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  *(undefined8 *)(iVar1 + 0x24) = *(undefined8 *)(param1_01 + 3);
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = ServicesNamespace_TutorialService__GetUserInfo
		                    (param1_02,*(undefined8 *)(iVar1 + 0x18),0,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController__PrepareData_b__10_2__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_TutorialV2_Controller_TutorialController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a583c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_TutorialModel__TutorialEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TutorialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a583c4 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_TutorialModel__TutorialEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TutorialService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Gameplay_TutorialV2_Controller_TutorialController___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x6B22", Offset = "0x6B22", VA = "0x6B22")]
		public TutorialController(TutorialModel model, TutorialEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_Controller_TutorialController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param2_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a583c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_CallbackQueue_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController_StartCombat__);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_TutorialStepsConveyor_TypeInfo);
		    DAT_ram_00a583c5 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a583b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_StepActionType___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__4EF49EE396181174C27A1F28E9864CDA526671E55F4A2B3DE1851382ED5945B7
		              );
		    DAT_ram_00a583b3 = '\x01';
		  }
		  uVar2 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_TutorialV2_Controller_StepActionType___TypeInfo,0xc);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (uVar2,
		             Field__PrivateImplementationDetails__4EF49EE396181174C27A1F28E9864CDA526671E55F4A2B3DE1851382ED5945B7
		             ,0);
		  iVar3 = unnamed_function_1417(Gameplay_TutorialV2_Controller_TutorialStepsConveyor_TypeInfo);
		  Gameplay_TutorialV2_Controller_TutorialController___RequestCombatStart_b__16_0(iVar3,uVar2,param1)
		  ;
		  param1[7] = iVar3;
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem___TypeInfo
		                                ,1);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_TutorialV2_Controller_TutorialController_StartCombat__,0);
		  iVar3 = unnamed_function_1417(Gameplay_TutorialV2_Controller_CallbackQueue_CallbackItem_TypeInfo);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = iVar3;
		  iVar3 = unnamed_function_1417(Gameplay_TutorialV2_Controller_CallbackQueue_TypeInfo);
		  if (DAT_ram_00a583b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		    DAT_ram_00a583b9 = '\x01';
		  }
		  *(undefined4 *)(iVar3 + 8) = 4;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Queue_CallbackQueue_CallbackItem__TypeInfo);
		  System_Collections_Generic_Queue_JobHandle___get_Count
		            (uVar2,param2_00,
		             Method_System_Collections_Generic_Queue_CallbackQueue_CallbackItem___ctor__);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  iVar4 = param1[7];
		  if (DAT_ram_00a583d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__);
		    DAT_ram_00a583d2 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_TutorialStepsQueueBase__Add__;
		  iVar4 = *(int *)(iVar4 + 0xc);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = iVar3;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar4,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x6B23", Offset = "0x6B23", VA = "0x6B23")]
		private void ConstructQueue()
		{
		/* --- GHIDRA: ConstructQueue ---
		void Gameplay_TutorialV2_Controller_TutorialController__ConstructQueue(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a583c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatRequestPrepareView__
		              );
		    DAT_ram_00a583c6 = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    iVar4 = *(int *)(*(int *)(param1 + 0x20) + 0x28);
		    uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatRequestPrepareView__
		               ,0);
		    piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x2c) = 0;
		    }
		    else if ((*piVar3 != System_Action_TypeInfo) ||
		            (*(int **)(iVar4 + 0x2c) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = *(int *)(*(int *)(param1 + 0x20) + 0x28);
		    uVar5 = *(undefined4 *)(iVar4 + 0x70);
		    uVar2 = unnamed_function_1417(iVar1);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatCompleteEvent__,
		               0);
		    piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x70) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar4 + 0x70) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		              (*(undefined4 *)(param1 + 0x20),
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__Stop__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x6B24", Offset = "0x6B24", VA = "0x6B24", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_TutorialV2_Controller_TutorialController__HandleStop
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_TutorialV2_Controller_TutorialController__HandleRun(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x6B25", Offset = "0x6B25", VA = "0x6B25", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_TutorialV2_Controller_TutorialController__HandleRun(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param3;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a583c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_IPlatformSigninProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController__PrepareData_b__10_0__);
		    DAT_ram_00a583c7 = '\x01';
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  uVar1 = 0;
		  piVar2 = (int *)Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                            (*(undefined4 *)
		                              (*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0xfc));
		  iVar4 = System_Uri___ctor(0);
		  piVar2 = *(int **)(*(int *)(iVar4 + 0x54) + 0xc);
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_IPlatformSigninProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80edddfb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar2,Core_Application_Managers_IPlatformSigninProvider_TypeInfo,0)
		  ;
		code_r0x80edddfb:
		  param3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		  uVar6 = ServicesNamespace_TutorialService__get_ServiceId(uVar6,uVar3,param3,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController__PrepareData_b__10_0__,0);
		  uVar6 = ServicesNamespace_MainService__GetUserStats
		                    (uVar6,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x6B26", Offset = "0x6B26", VA = "0x6B26")]
		private void PrepareData()
		{
		/* --- GHIDRA: PrepareData ---
		void Gameplay_TutorialV2_Controller_TutorialController__PrepareData(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  bool bVar2;
		  
		  if (*(char *)((int)param1 + 9) == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(char *)(iVar1 + 0x34) == '\0') {
		      bVar2 = true;
		    }
		    else {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      bVar2 = *(char *)(iVar1 + 0x34) != '\0';
		    }
		    *(bool *)((int)param1 + 9) = bVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x6B27", Offset = "0x6B27", VA = "0x6B27")]
		private void ValidateInit()
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000485")]
		public TutorialCombat Combat
		{
			[Token(Token = "0x6001989")]
			[Address(RVA = "0x6B28", Offset = "0x6B28", VA = "0x6B28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600198A")]
			[Address(RVA = "0x6B29", Offset = "0x6B29", VA = "0x6B29")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x6B2A", Offset = "0x6B2A", VA = "0x6B2A")]
		private void RequestCombatStart()
		{
		/* --- GHIDRA: RequestCombatStart ---
		void Gameplay_TutorialV2_Controller_TutorialController__RequestCombatStart
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  
		  if (DAT_ram_00a583c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatRequestPrepareView__
		              );
		    DAT_ram_00a583c9 = '\x01';
		  }
		  iVar2 = param1[7];
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = unnamed_function_1417(Gameplay_TutorialCombatV2_TutorialCombat_TypeInfo);
		  if (DAT_ram_00a583e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView___ctor__
		              );
		    DAT_ram_00a583e7 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (iVar1,uVar3,uVar4,param4,0,
		             Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView___ctor__
		            );
		  *(int *)(iVar1 + 0x2c) = iVar2;
		  param1[8] = iVar1;
		  iVar2 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		                    (iVar1,
		                     Method_Gameplay_Combat_AbstractCombat_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__TutorialCombatViewMediator__OneOnOneCombatView__TryRun__
		                    );
		  if (iVar2 != 0) {
		    iVar1 = *(int *)(param1[8] + 0x28);
		    uVar4 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatRequestPrepareView__
		               ,0);
		    param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		    iVar2 = System_Action_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *param1_00) ||
		       (*(int **)(iVar1 + 0x2c) = param1_00, *param1_00 != iVar2)) {
		      System_Activator__CreateInstance(param1_00,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x6B2B", Offset = "0x6B2B", VA = "0x6B2B")]
		private void StartCombat()
		{
		/* --- GHIDRA: StartCombat ---
		void Gameplay_TutorialV2_Controller_TutorialController__StartCombat(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a583ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatRequestPrepareView__
		              );
		    DAT_ram_00a583ca = '\x01';
		  }
		  iVar4 = *(int *)(param1[8] + 0x28);
		  uVar5 = *(undefined4 *)(iVar4 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatRequestPrepareView__
		             ,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x2c) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param1[8] + 0x28);
		  uVar5 = *(undefined4 *)(iVar4 + 0x70);
		  uVar1 = unnamed_function_1417(iVar3);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatCompleteEvent__,0)
		  ;
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x70) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x70) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param1[8] + 0x28);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar1 = unnamed_function_1417(iVar3);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatInitEvent__,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) || (*(int **)(iVar4 + 8) = piVar2, *piVar2 != iVar3))
		  {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  Gameplay_TutorialV2_Controller_TutorialController__set_Combat(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x6B2C", Offset = "0x6B2C", VA = "0x6B2C")]
		private void HandleCombatRequestPrepareView()
		{
		/* --- GHIDRA: HandleCombatRequestPrepareView ---
		void Gameplay_TutorialV2_Controller_TutorialController__HandleCombatRequestPrepareView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  int iVar2;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a583cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatInitEvent__);
		    DAT_ram_00a583cb = '\x01';
		  }
		  iVar2 = *(int *)(param1[8] + 0x28);
		  param1_02 = *(undefined4 *)(iVar2 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatInitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar2 + 8) = param1_01, *param1_01 != iVar1)) {
		    System_Activator__CreateInstance(param1_01,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x6B2D", Offset = "0x6B2D", VA = "0x6B2D")]
		private void HandleCombatInitEvent()
		{
		/* --- GHIDRA: HandleCombatInitEvent ---
		void Gameplay_TutorialV2_Controller_TutorialController__HandleCombatInitEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  int iVar2;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a583cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatCompleteEvent__
		              );
		    DAT_ram_00a583cc = '\x01';
		  }
		  iVar2 = *(int *)(param1[8] + 0x28);
		  param1_02 = *(undefined4 *)(iVar2 + 0x70);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController_HandleCombatCompleteEvent__,0)
		  ;
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x70) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar2 + 0x70) = param1_01, *param1_01 != iVar1)) {
		    System_Activator__CreateInstance(param1_01,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x6B2E", Offset = "0x6B2E", VA = "0x6B2E")]
		private void HandleCombatCompleteEvent()
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x6B2F", Offset = "0x6B2F", VA = "0x6B2F")]
		public void NotifyViewReady()
		{
		/* --- GHIDRA: NotifyViewReady ---
		void Gameplay_TutorialV2_Controller_TutorialController__NotifyViewReady
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  
		  param1_00 = *(int *)(param1 + 0x1c);
		  param2_00 = *(int *)(param1_00 + 0x10);
		  if (param2_00 != 0) {
		    iVar1 = *(int *)(param2_00 + 0xc);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		      param2_00 = *(int *)(param1_00 + 0x10);
		      if (param2_00 == 0) goto code_r0x80ede4ce;
		    }
		    *(undefined4 *)(param2_00 + 0xc) = 0;
		  }
		code_r0x80ede4ce:
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (param1_00,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x6B30", Offset = "0x6B30", VA = "0x6B30")]
		public void GotoNextState()
		{
		/* --- GHIDRA: GotoNextState ---
		void Gameplay_TutorialV2_Controller_TutorialController__GotoNextState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  bool bVar7;
		  int local_4;
		  
		  if (DAT_ram_00a583cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AuthData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoStartTutorialAns_Types_Errors_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Tutorial_ProtoStartTutorialAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialV2_Controller_TutorialController__PrepareData_b__10_1__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11962);
		    DAT_ram_00a583cd = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Tutorial_ProtoStartTutorialAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Tutorial_ProtoStartTutorialAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar2 + 0x18) = *(undefined8 *)(param1_00 + 4);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar2 + 0x38) = param1_00[0xb];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x80ede8fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ede8fb:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar1 = 0;
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x160);
		        goto code_r0x80ede97d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,0x14);
		code_r0x80ede97d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar6 = *(undefined4 *)(iVar2 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param3_00 = *(undefined4 *)(iVar2 + 0x38);
		  uVar4 = unnamed_function_1417(Core_Gameplay_Managers_AuthData_TypeInfo);
		  Core_Gameplay_Managers_AuthData___ctor(uVar4,param1_00,param3_00,0);
		  Core_Gameplay_Managers_LoggedManager__OnRegisterService(uVar6,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(bool *)(iVar2 + 0x34) = param1_00[3] != -1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar2 + 0x20) = param1_00[7];
		  local_4 = param1_00[3];
		  if (local_4 < 0) {
		    uVar4 = func_ii_1081(Protocol_Tutorial_ProtoStartTutorialAns_Types_Errors_TypeInfo,&local_4);
		    uVar4 = func_ii_4419(StringLiteral_11962,uVar4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(uVar4,0);
		    if (*(char *)((int)param1 + 9) == '\0') {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (*(char *)(iVar2 + 0x34) == '\0') {
		        bVar7 = true;
		      }
		      else {
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        bVar7 = *(char *)(iVar2 + 0x34) != '\0';
		      }
		      *(bool *)((int)param1 + 9) = bVar7;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 8);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  else {
		    uVar4 = ServicesNamespace_TutorialService__ResumeTutorialBattle(param1[6],0);
		    uVar6 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar6,param1,
		               Method_Gameplay_TutorialV2_Controller_TutorialController__PrepareData_b__10_1__,0);
		    uVar4 = ServicesNamespace_MainService__GetUserStats
		                      (uVar4,uVar6,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x18")]
		private TutorialService _tutorialService;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Conveyor ---
		void Gameplay_TutorialV2_Controller_TutorialController__set_Conveyor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a583c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_TutorialModel__TutorialEvents__Dispose__);
		    DAT_ram_00a583c3 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_TutorialModel__TutorialEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_Combat ---
		void Gameplay_TutorialV2_Controller_TutorialController__set_Combat(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_Controller_TutorialController__RequestCombatStart_b__16_0__
		              );
		    DAT_ram_00a583c8 = '\x01';
		  }
		  uVar1 = ServicesNamespace_TutorialService__StartTutorialBattle(*(undefined4 *)(param1 + 0x18),0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,*(undefined4 *)(param1 + 0x20),
		                     Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_Controller_TutorialController__RequestCombatStart_b__16_0__,
		             0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

}
