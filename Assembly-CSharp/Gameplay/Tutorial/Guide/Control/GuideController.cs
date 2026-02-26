using System;
using System.Collections;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.Tutorial.Guide.Control
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	public class GuideController : AbstractController<GuideModel, GuideEvents>
	{
		// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x6CFE", Offset = "0x6CFE", VA = "0x6CFE", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tutorial_Guide_Control_GuideController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5849e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GuideModel__GuideEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TutorialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Control_TutorialGuideObserver_TypeInfo);
		    DAT_ram_00a5849e = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_GuideModel__GuideEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TutorialService___);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x160);
		        goto code_r0x80ef55cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80ef55cf:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = unnamed_function_1417(Gameplay_Tutorial_Guide_Control_TutorialGuideObserver_TypeInfo);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x6CFF", Offset = "0x6CFF", VA = "0x6CFF")]
		public GuideController(GuideModel model, GuideEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_Control_GuideController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a5849f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TutorialStepDic__get_Count__);
		    DAT_ram_00a5849f = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58484 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a58484 = '\x01';
		  }
		  if (*(char *)(iVar2 + 0x14) != '\0') {
		    uVar1 = 0;
		    piVar5 = *(int **)(iVar2 + 0x2c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80ef56cb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80ef56cb:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		    if (iVar2 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (*(int *)(*(int *)(iVar2 + 0x20) + 0xc) == 0) {
		        *(undefined1 *)((int)param1 + 9) = 1;
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 8);
		        if (iVar2 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		          return;
		        }
		      }
		      else {
		        iVar2 = *param1;
		        uVar4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                          (param1,*(undefined4 *)(iVar2 + 0x104));
		        Gameplay_Tutorial_Guide_Model_GuideModel__TryCheckTutorials(uVar4,iVar2);
		        uVar4 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        DefaultNamespace_SceneAppManager__RemoveScene(uVar4,*(undefined4 *)(iVar2 + 0x10),0);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x6D00", Offset = "0x6D00", VA = "0x6D00", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Tutorial_Guide_Control_GuideController__HandleRun(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  *(undefined1 *)((int)param1 + 9) = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  DefaultNamespace_SceneAppManager__UnloadScene(param1_00,*(undefined4 *)(iVar1 + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x6D01", Offset = "0x6D01", VA = "0x6D01", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Tutorial_Guide_Control_GuideController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58488 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    DAT_ram_00a58488 = '\x01';
		  }
		  UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		            (*(undefined4 *)(iVar1 + 0x40),*(undefined4 *)(iVar1 + 0x30),
		             Method_System_Collections_Generic_HashSet_uint__Add__);
		  *(undefined4 *)(iVar1 + 0x38) = 0;
		  *(undefined8 *)(iVar1 + 0x30) = 0;
		  Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial(param1,0,0,param1);
		  Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1[8],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58489 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		    DAT_ram_00a58489 = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		                    (*(undefined4 *)(iVar1 + 0x3c),param2,
		                     Method_System_Collections_Generic_HashSet_uint__Add__);
		  if (((iVar1 != 0) &&
		      (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x24) == 0)) &&
		     (param1[9] == 0)) {
		    if (DAT_ram_00a584a4 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                );
		      DAT_ram_00a584a4 = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                      );
		    *(int **)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    iVar1 = Utils_CoroutineSource__GetMono(iVar1,0);
		    param1[9] = iVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x6D02", Offset = "0x6D02", VA = "0x6D02")]
		public void RunTutorial(uint tutorialId)
		{
		/* --- GHIDRA: RunTutorial ---
		undefined4
		Gameplay_Tutorial_Guide_Control_GuideController__RunTutorial(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Gameplay_Tutorial_Guide_Control_GuideController__TryAdd
		                    (param1,*(undefined4 *)(iVar1 + 0x24),param1);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x6D03", Offset = "0x6D03", VA = "0x6D03")]
		public bool TryStopCurrentTutorial()
		{
		/* --- GHIDRA: TryStopCurrentTutorial ---
		void Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(iVar1 + 0x24);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar1 + 0x28);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x24) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x28) = param3;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar1 + 0x24) != iVar2) ||
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), iVar3 != *(int *)(iVar1 + 0x28)))
		  {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar4 = *(undefined4 *)(iVar2 + 0x24);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x28),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x6D04", Offset = "0x6D04", VA = "0x6D04")]
		public void SetCurrent(IGuideTarget target, GuideConfig config)
		{
		/* --- GHIDRA: SetCurrent ---
		undefined4
		Gameplay_Tutorial_Guide_Control_GuideController__SetCurrent
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a584a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_IGuideTarget__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TutorialStepDic__get_Count__);
		    DAT_ram_00a584a0 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58484 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a58484 = '\x01';
		  }
		  if (*(char *)(iVar3 + 0x14) == '\0') {
		    return 0;
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(iVar3 + 0x2c);
		  iVar3 = *piVar5;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ef5d9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80ef5d9e:
		  uVar2 = 0;
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		  if ((iVar3 != 0) &&
		     (iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)),
		     0 < *(int *)(*(int *)(iVar3 + 0x20) + 0xc))) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = System_Collections_Generic_HashSet_object___Clear
		                      (*(undefined4 *)(iVar3 + 0x18),param2,
		                       Method_System_Collections_Generic_HashSet_IGuideTarget__Add__);
		    if (iVar3 != 0) {
		      uVar2 = 1;
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if ((*(int *)(iVar3 + 0x24) == 0) && (param1[9] == 0)) {
		        if (DAT_ram_00a584a4 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                    );
		          DAT_ram_00a584a4 = '\x01';
		        }
		        iVar3 = unnamed_function_1417
		                          (
		                          Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                          );
		        *(int **)(iVar3 + 0x10) = param1;
		        *(undefined4 *)(iVar3 + 8) = 0;
		        iVar3 = Utils_CoroutineSource__GetMono(iVar3,0);
		        param1[9] = iVar3;
		      }
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x6D05", Offset = "0x6D05", VA = "0x6D05")]
		public bool TryAdd(IGuideTarget target)
		{
		/* --- GHIDRA: TryAdd ---
		int Gameplay_Tutorial_Guide_Control_GuideController__TryAdd
		              (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a584a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_IGuideTarget__Remove__);
		    DAT_ram_00a584a1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar1 + 0x24) != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x24) == param2)
		     ) {
		    Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial(param1,0,0,param1);
		    Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1[8],param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Unity_Services_Analytics_AnalyticsService__get_Instance
		                    (*(undefined4 *)(iVar1 + 0x18),param2,
		                     Method_System_Collections_Generic_HashSet_IGuideTarget__Remove__);
		  if (((iVar1 != 0) &&
		      (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar2 + 0x24) == 0)) &&
		     (param1[9] == 0)) {
		    if (DAT_ram_00a584a4 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                );
		      DAT_ram_00a584a4 = '\x01';
		    }
		    iVar2 = unnamed_function_1417
		                      (
		                      Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                      );
		    *(int **)(iVar2 + 0x10) = param1;
		    *(undefined4 *)(iVar2 + 8) = 0;
		    iVar2 = Utils_CoroutineSource__GetMono(iVar2,0);
		    param1[9] = iVar2;
		  }
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x6D06", Offset = "0x6D06", VA = "0x6D06")]
		public bool TryRemove(IGuideTarget target)
		{
		/* --- GHIDRA: TryRemove ---
		void Gameplay_Tutorial_Guide_Control_GuideController__TryRemove(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar1 + 0x24) == 0) && (param1[9] == 0)) {
		    if (DAT_ram_00a584a4 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                );
		      DAT_ram_00a584a4 = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                      );
		    *(int **)(iVar1 + 0x10) = param1;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    iVar1 = Utils_CoroutineSource__GetMono(iVar1,0);
		    param1[9] = iVar1;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x6D07", Offset = "0x6D07", VA = "0x6D07")]
		private void TryDelayedDefineNext()
		{
		/* --- GHIDRA: TryDelayedDefineNext ---
		void Gameplay_Tutorial_Guide_Control_GuideController__TryDelayedDefineNext
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 *param2_00;
		  
		  if (DAT_ram_00a584a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_IGuideTarget___);
		    Mono_Security_ASN1__get_Item(&System_Func_IGuideTarget__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Control_GuideController___c__DisplayClass13_0__SetNextStep_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_Control_GuideController___c__DisplayClass13_0_TypeInfo);
		    DAT_ram_00a584a2 = '\x01';
		  }
		  do {
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_Tutorial_Guide_Control_GuideController___c__DisplayClass13_0_TypeInfo
		                      );
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = (undefined4 *)(iVar1 + 8);
		    iVar3 = Gameplay_Tutorial_Guide_Model_GuideModel__AddToWhiteList(uVar2,param2_00,param1);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar3 == 0) {
		      if (DAT_ram_00a58488 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Add__);
		        DAT_ram_00a58488 = '\x01';
		      }
		      UnityEngine_TextCore_LowLevel_FontEngine__GetGlyphIndex
		                (*(undefined4 *)(iVar4 + 0x40),*(undefined4 *)(iVar4 + 0x30),
		                 Method_System_Collections_Generic_HashSet_uint__Add__);
		      *(undefined4 *)(iVar4 + 0x38) = 0;
		      *(undefined8 *)(iVar4 + 0x30) = 0;
		      Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial(param1,0,0,param1);
		      Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1[8],param1);
		      return;
		    }
		    param1_00 = *(undefined4 *)(iVar4 + 0x18);
		    uVar2 = unnamed_function_1417(System_Func_IGuideTarget__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,iVar1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideController___c__DisplayClass13_0__SetNextStep_b__0__
		               ,0);
		    iVar3 = System_Func_object__bool____ctor
		                      (param1_00,uVar2,Method_System_Linq_Enumerable_FirstOrDefault_IGuideTarget___)
		    ;
		    iVar4 = param1[7];
		    uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 8) + 0x10) + 0x24);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                      (iVar4,uVar2,*(undefined4 *)(iVar1 + 8),0);
		  } while (iVar1 == 0);
		  if (iVar3 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x34) = *param2_00;
		    Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial(param1,0,0,param1);
		    Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__FinishTutorial(param1[8],param1);
		    return;
		  }
		  Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial
		            (param1,iVar3,*param2_00,param1);
		  Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__StartTutorial(param1[8],*param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x6D08", Offset = "0x6D08", VA = "0x6D08")]
		private void SetNextStep()
		{
		/* --- GHIDRA: SetNextStep ---
		undefined4
		Gameplay_Tutorial_Guide_Control_GuideController__SetNextStep(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a584a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_Control_GuideController_CheckRestrictions__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Remove__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_GuideConfig__TypeInfo);
		    DAT_ram_00a584a3 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Gameplay_Tutorial_Guide_Model_GuideModel__TryMoveToNextStep
		                    (uVar1,*(undefined4 *)(iVar2 + 0x18),&local_4,&local_8,param1);
		  if (iVar2 == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = *(undefined4 *)(iVar2 + 0x18);
		    param1_00 = unnamed_function_1417(System_Predicate_GuideConfig__TypeInfo);
		    func_ii_7297(param1_00,param1,
		                 Method_Gameplay_Tutorial_Guide_Control_GuideController_CheckRestrictions__,0);
		    iVar2 = Gameplay_Tutorial_Guide_Model_GuideModel__TryCheckWhiteList
		                      (uVar1,param2_00,param1_00,&local_4,&local_8,param1);
		    if (iVar2 == 0) {
		      return 0;
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = local_4;
		  System_Collections_Generic_HashSet_uint___OnDeserialization
		            (*(undefined4 *)(iVar3 + 0x3c),*(undefined4 *)(*(int *)(local_4 + 0x10) + 0xc),
		             Method_System_Collections_Generic_HashSet_uint__Remove__);
		  Gameplay_Tutorial_Guide_Control_GuideController__TryStopCurrentTutorial
		            (param1,local_8,iVar2,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc);
		  *(undefined4 *)(iVar3 + 0x38) = 0;
		  *(undefined4 *)(iVar3 + 0x30) = uVar1;
		  Gameplay_Tutorial_Guide_Control_TutorialGuideObserver__StartTutorial(param1[8],iVar2,param1);
		  return 1;
		}
		*/

		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x6D09", Offset = "0x6D09", VA = "0x6D09")]
		private bool TryStartNextTutorial()
		{
		/* --- GHIDRA: TryStartNextTutorial ---
		void Gameplay_Tutorial_Guide_Control_GuideController__TryStartNextTutorial
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x30) != 0) {
		    Gameplay_Tutorial_Guide_Control_GuideController__TryDelayedDefineNext(param1,param1);
		    return;
		  }
		  Gameplay_Tutorial_Guide_Control_GuideController__SetNextStep(param1,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x6D0A", Offset = "0x6D0A", VA = "0x6D0A")]
		private void DefineNext()
		{
		/* --- GHIDRA: DefineNext ---
		undefined4
		Gameplay_Tutorial_Guide_Control_GuideController__DefineNext
		          (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = param1[7];
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x24);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                    (param1_00,uVar2,*(undefined4 *)(iVar1 + 8),0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x6D0B", Offset = "0x6D0B", VA = "0x6D0B")]
		private bool CheckRestrictions(GuideConfig config)
		{
		/* --- GHIDRA: CheckRestrictions ---
		int Gameplay_Tutorial_Guide_Control_GuideController__CheckRestrictions
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a584a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		              );
		    DAT_ram_00a584a4 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tutorial_Guide_Control_GuideController__WaitEndOfFrameCoroutine_d__18_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x6D0C", Offset = "0x6D0C", VA = "0x6D0C")]
		public IEnumerator WaitEndOfFrameCoroutine()
		{
			return null;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x6D0D", Offset = "0x6D0D", VA = "0x6D0D")]
		private void HandleLogTutorialStep(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleLogTutorialStep ---
		void Gameplay_Tutorial_Guide_Control_GuideController__HandleLogTutorialStep
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined1 *)((int)param1 + 9) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x6D0E", Offset = "0x6D0E", VA = "0x6D0E")]
		public void NotifyAboutViewReady()
		{
		/* --- GHIDRA: NotifyAboutViewReady ---
		void Gameplay_Tutorial_Guide_Control_GuideController__NotifyAboutViewReady
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int local_4;
		  
		  if (DAT_ram_00a584a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_Control_GuideController_HandleLogTutorialStep__);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GuideScope_GuideEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_TriggerValue___TypeInfo);
		    DAT_ram_00a584a5 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar2 = (int *)Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar1 + 8),0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		            (piVar2,*(undefined4 *)(*(int *)(param2 + 0x10) + 0x14),&local_4,
		             *(undefined4 *)(*piVar2 + 0x104));
		  local_4 = Protocol_Common_TriggerValue___ctor(local_4,0);
		  *(longlong *)(local_4 + 0x10) = *(longlong *)(local_4 + 0x10) + 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar1 + 8),0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_TriggerValue___TypeInfo,1);
		  *(int *)(iVar1 + 0x10) = local_4;
		  Utils_Accumulators_AccumulatorBase_int__object___RunTimer
		            (uVar3,iVar1,Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		  uVar3 = ServicesNamespace_TutorialService__StartTutorial
		                    (param1[6],*(undefined4 *)(param2 + 8),*(undefined4 *)(param2 + 0xc),
		                     **(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Tutorial_Guide_Control_GuideController_HandleLogTutorialStep__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar3,uVar4,param2,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x28) + 8);
		  if (iVar1 != 0) {
		    uVar3 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar4 = unnamed_function_1417(Core_Events_Scopes_GuideScope_GuideEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(uVar4,uVar3,param3_00,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x30) == 0) {
		    Gameplay_Tutorial_Guide_Control_GuideController__SetNextStep(param1,param1);
		  }
		  else {
		    Gameplay_Tutorial_Guide_Control_GuideController__TryDelayedDefineNext(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x6D0F", Offset = "0x6D0F", VA = "0x6D0F")]
		public void Resolve(GuideConfig config)
		{
		/* --- GHIDRA: Resolve ---
		void Gameplay_Tutorial_Guide_Control_GuideController__Resolve
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  int iVar2;
		  
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  cVar1 = *(char *)(iVar2 + 0x1c);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar2 + 0x1c) = (undefined1)param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((cVar1 != '\0') != (*(char *)(iVar2 + 0x1c) != '\0')) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x6D10", Offset = "0x6D10", VA = "0x6D10")]
		public void DevEditorToolEnable(bool value)
		{
		}

		// Token: 0x04000EED RID: 3821
		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x18")]
		private TutorialService _service;

		// Token: 0x04000EEE RID: 3822
		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x1C")]
		private RequirementsManager _requirementsManager;

		// Token: 0x04000EEF RID: 3823
		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x20")]
		private readonly TutorialGuideObserver _tutorialGuideObserver;

		// Token: 0x04000EF0 RID: 3824
		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _waitEndOfFrameCoroutine;
	}
}
