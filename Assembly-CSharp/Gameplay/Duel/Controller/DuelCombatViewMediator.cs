using System;
using Gameplay.Combat.Control;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000865 RID: 2149
	[Token(Token = "0x2000865")]
	public class DuelCombatViewMediator : OneOnOneCombatViewMediator<CombatModel, CombatEvents, DuelCombatController>
	{
		// Token: 0x0600326E RID: 12910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326E")]
		[Address(RVA = "0x82C3", Offset = "0x82C3", VA = "0x82C3")]
		public DuelCombatViewMediator(CombatModel model, CombatEvents events, DuelCombatController controller)
		{
		/* --- GHIDRA: <HandleGameOver>b__1_0 ---
		void Gameplay_Duel_Controller_DuelCombatViewMediator___HandleGameOver_b__1_0
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57be5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_DuelModel__DuelEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_DuelService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57be5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_DuelModel__DuelEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_DuelService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_Controller_DuelCombatViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57be0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatGameOverView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelCombatViewMediator__HandleGameOver_b__1_0__);
		    DAT_ram_00a57be0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar1 + 100),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar1 + 0x68),0);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = param1[2];
		  uVar3 = *(undefined4 *)(iVar1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_CombatGameOverView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Duel_Controller_DuelCombatViewMediator__HandleGameOver_b__1_0__,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x118) * 4))
		            (piVar2,iVar1,uVar3,param1_00,*(undefined4 *)(*piVar2 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x0600326F RID: 12911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326F")]
		[Address(RVA = "0x82C4", Offset = "0x82C4", VA = "0x82C4", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		undefined4
		Gameplay_Duel_Controller_DuelCombatViewMediator__HandleGameOver
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57be1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__ShowAwaitCombatWindow__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6229);
		    DAT_ram_00a57be1 = '\x01';
		  }
		  param1_00 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___RunShowCombatViewProcess
		                        (param1,param2,
		                         Method_Gameplay_Combat_Control_AbstractCombatViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__ShowAwaitCombatWindow__
		                        );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6229,1,0,1,0,0,0,0);
		  Gameplay_Combat_View_CombatWaitingWindowMono__HideWaitingWindow(param1_00,param2_00,0);
		  Core_Extensions_StringExt__Replacer(param1_00,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003270 RID: 12912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003270")]
		[Address(RVA = "0x82C5", Offset = "0x82C5", VA = "0x82C5", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
		/* --- GHIDRA: ShowAwaitCombatWindow ---
		int Gameplay_Duel_Controller_DuelCombatViewMediator__ShowAwaitCombatWindow
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57be2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__CheckArtifactsInDrop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a57be2 = '\x01';
		  }
		  iVar2 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___AddGameProcessEventsHandlers
		                    (param1,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__CheckArtifactsInDrop__
		                    );
		  if (iVar2 == 0) {
		    uVar1 = 0;
		    param2_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		    piVar4 = *(int **)(*(int *)(*(int *)(param1 + 8) + 0x3c) + 0x14);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x80e338b0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80e338b0:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar1 = 0;
		    piVar4 = *(int **)(*(int *)(*(int *)(param1 + 8) + 0x3c) + 0x14);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e33939;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80e33939:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_00,0);
		    Gameplay_Duel_Controller_DuelCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		              (param1,puVar3);
		  }
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x6003271")]
		[Address(RVA = "0x82C6", Offset = "0x82C6", VA = "0x82C6", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView wnd)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		void Gameplay_Duel_Controller_DuelCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57be3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a57be3 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[7],0);
		  if (iVar1 != 0) {
		    iVar1 = param1[7];
		    uVar2 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,param1,*(undefined4 *)(*param1 + 0x174),0);
		    Gameplay_Combat_View_CombatGameOverView__add_CloseRequestEvent(iVar1,uVar2,0);
		    param1_00 = *(undefined4 *)(param1[7] + 0x38);
		    uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout(uVar2,param1,*(undefined4 *)(*param1 + 500),0);
		    UI_IndexButtonBasic__add_ClickEvent(param1_00,uVar2,0);
		    Core_Dev_DevMenuVideoAd___ctor(param1[7],0);
		  }
		  param1[7] = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003272")]
		[Address(RVA = "0x82C7", Offset = "0x82C7", VA = "0x82C7")]
		private void CloseGameOverWindow()
		{
		/* --- GHIDRA: CloseGameOverWindow ---
		void Gameplay_Duel_Controller_DuelCombatViewMediator__CloseGameOverWindow
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57be4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CombatModel__CombatEvents__DuelCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    DAT_ram_00a57be4 = '\x01';
		  }
		  param1[7] = param2;
		  uVar2 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,*(undefined4 *)(*param1 + 0x174),0);
		  Gameplay_Combat_View_CombatEventsToast___ctor(param2,uVar2,0);
		  param1_00 = *(undefined4 *)(param1[7] + 0x38);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout(uVar2,param1,*(undefined4 *)(*param1 + 500),0);
		  UI_IndexButtonBasic__get_CanvasGroup(param1_00,uVar2,0);
		  param1_01 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x1c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Sound_Control_IGameAudio_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x80e33b23;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Sound_Control_IGameAudio_TypeInfo,3);
		code_r0x80e33b23:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  return;
		}
		*/

		}
	}
}
