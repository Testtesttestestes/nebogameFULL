using System;
using System.Collections;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tutorial.Guide.Control
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	public class GuideViewMediator : AbstractViewMediator<GuideModel, GuideEvents, GuideController, GuideView>
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x6D19", Offset = "0x6D19", VA = "0x6D19", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a584a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView___ctor__
		              );
		    DAT_ram_00a584a8 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x6D1A", Offset = "0x6D1A", VA = "0x6D1A")]
		public GuideViewMediator(GuideModel model, GuideEvents events, GuideController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a584a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTarget__GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleCurrentStepChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleDevEditorToolEnabledChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleInitEvent__);
		    DAT_ram_00a584a9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleInitEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_IGuideTarget__GuideConfig__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleCurrentStepChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_IGuideTarget__GuideConfig__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_IGuideTarget__GuideConfig__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar5;
		      uVar3 = System_Action_IGuideTarget__GuideConfig__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_IGuideTarget__GuideConfig__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleDevEditorToolEnabledChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    uVar6 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleInitEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_IGuideTarget__GuideConfig__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleCurrentStepChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_IGuideTarget__GuideConfig__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_IGuideTarget__GuideConfig__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar5;
		      uVar3 = System_Action_IGuideTarget__GuideConfig__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_IGuideTarget__GuideConfig__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleDevEditorToolEnabledChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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

		// Token: 0x170004D3 RID: 1235
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D3")]
		public override GuideEvents Events
		{
			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x6D1B", Offset = "0x6D1B", VA = "0x6D1B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D4")]
		public override GuideView View
		{
			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x6D1C", Offset = "0x6D1C", VA = "0x6D1C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x6D1D", Offset = "0x6D1D", VA = "0x6D1D")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleInitEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Tutorial_Guide_Control_GuideViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x6D1E", Offset = "0x6D1E", VA = "0x6D1E")]
		private void HandleDevEditorToolEnabledChangedEvent()
		{
		/* --- GHIDRA: HandleDevEditorToolEnabledChangedEvent ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleDevEditorToolEnabledChangedEvent
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  Gameplay_Tutorial_Guide_Control_GuideViewMediator__SetupView(param1,param1);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 != 0),0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Tutorial_Guide_View_GuideView__UpdateMessageBubble(uVar1,0);
		  if (param2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Tutorial_Guide_View_GuideView__set_Target(uVar1,param2,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x6D1F", Offset = "0x6D1F", VA = "0x6D1F")]
		private void HandleCurrentStepChangedEvent(IGuideTarget target, GuideConfig config)
		{
		/* --- GHIDRA: HandleCurrentStepChangedEvent ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleCurrentStepChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a584ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleResolveEvent__);
		    DAT_ram_00a584ac = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar2 = unnamed_function_1417(System_Action_GuideConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleResolveEvent__,0);
		  param1_00 = func_ii_7048(param1_01,uVar2,0);
		  uVar2 = System_Action_GuideConfig__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar1 + 0x2c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(param1_00,System_Action_GuideConfig__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar1 + 0x2c) = iVar3;
		  uVar2 = System_Action_GuideConfig__TypeInfo;
		  iVar1 = func_ii_1082(param1_00,System_Action_GuideConfig__TypeInfo);
		  if (iVar1 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x6D20", Offset = "0x6D20", VA = "0x6D20")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a584ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GuideConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleResolveEvent__);
		    DAT_ram_00a584ad = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined1 *)((int)piVar1 + 9) = 1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar2 + 0x2c);
		  uVar3 = unnamed_function_1417(System_Action_GuideConfig__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleResolveEvent__,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_GuideConfig__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(iVar2 + 0x2c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(param1_00,System_Action_GuideConfig__TypeInfo);
		  if (iVar4 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar2 + 0x2c) = iVar4;
		  uVar3 = System_Action_GuideConfig__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,System_Action_GuideConfig__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x6D21", Offset = "0x6D21", VA = "0x6D21")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a584ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView__get_Model__
		              );
		    DAT_ram_00a584ae = '\x01';
		  }
		  if (*(char *)(param1[2] + 0x1c) != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView__get_GuideConfig
		              (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(param1[2] + 0x28),0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1[2] + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x6D22", Offset = "0x6D22", VA = "0x6D22")]
		private void HandleDevEditorToolEnabledChanged()
		{
		/* --- GHIDRA: HandleDevEditorToolEnabledChanged ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleDevEditorToolEnabledChanged
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Tutorial_Guide_Control_GuideController__NotifyAboutViewReady(param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x6D23", Offset = "0x6D23", VA = "0x6D23")]
		private void HandleResolveEvent(GuideConfig config)
		{
		/* --- GHIDRA: HandleResolveEvent ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleResolveEvent
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a584af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView__get_Model__
		              );
		    DAT_ram_00a584af = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 8) + 0x24) != 0) {
		    if (DAT_ram_00a584b0 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Tutorial_Guide_Control_GuideViewMediator__UpdateViewCoroutine_d__14_TypeInfo
		                );
		      DAT_ram_00a584b0 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Tutorial_Guide_Control_GuideViewMediator__UpdateViewCoroutine_d__14_TypeInfo
		                          );
		    *(int *)(param1_00 + 0x10) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		    Utils_CoroutineSource__GetMono(param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x6D24", Offset = "0x6D24", VA = "0x6D24")]
		private void HandleGameContentScaledEvent()
		{
		/* --- GHIDRA: HandleGameContentScaledEvent ---
		int Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleGameContentScaledEvent
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a584b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Tutorial_Guide_Control_GuideViewMediator__UpdateViewCoroutine_d__14_TypeInfo
		              );
		    DAT_ram_00a584b0 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Tutorial_Guide_Control_GuideViewMediator__UpdateViewCoroutine_d__14_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x6D25", Offset = "0x6D25", VA = "0x6D25")]
		private IEnumerator UpdateViewCoroutine()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a584aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView__set_View__
		              );
		    DAT_ram_00a584aa = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleCurrentStepChangedEvent(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Tutorial_Guide_Control_GuideViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Tutorial_Guide_Control_GuideViewMediator__set_View(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a584ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleGameContentScaledEvent__
		              );
		    DAT_ram_00a584ab = '\x01';
		  }
		  Gameplay_Tutorial_Guide_Control_GuideViewMediator__HandleDevEditorToolEnabledChangedEvent
		            (param1,*(undefined4 *)(*(int *)(param1 + 8) + 0x24),
		             *(undefined4 *)(*(int *)(param1 + 8) + 0x28),param1);
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  param1_01 = **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Tutorial_Guide_Control_GuideViewMediator_HandleGameContentScaledEvent__
		             ,0);
		  ScreenAdaptation_Scale_GameScaler__Awake(param1_01,param1_00,0);
		  return;
		}
		*/

}
