using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B45 RID: 2885
	[Token(Token = "0x2000B45")]
	public class BossMinionCombatViewMediator : OneOnOneCombatViewMediator<BossMinionCombatModel, BossMinionCombatEvents, BossMinionCombatController>
	{
		// Token: 0x060045E8 RID: 17896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x948A", Offset = "0x948A", VA = "0x948A")]
		public BossMinionCombatViewMediator(BossMinionCombatModel model, BossMinionCombatEvents events, BossMinionCombatController controller)
		{
		/* --- GHIDRA: <HandleGameOver>b__1_0 ---
		undefined4
		Gameplay_BossCombat_Controller_BossMinionCombatViewMediator___HandleGameOver_b__1_0
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5799b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12579);
		    DAT_ram_00a5799b = '\x01';
		  }
		  return StringLiteral_12579;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_BossCombat_Controller_BossMinionCombatViewMediator___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57998 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatGameOverView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BossCombat_Controller_BossMinionCombatViewMediator__HandleGameOver_b__1_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57998 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar2 + 100),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar2 + 0x68),0);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = param1[2];
		  uVar6 = *(undefined4 *)(iVar2 + 0x10);
		  uVar4 = unnamed_function_1417(System_Action_CombatGameOverView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_BossCombat_Controller_BossMinionCombatViewMediator__HandleGameOver_b__1_0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x118) * 4))
		            (piVar3,iVar2,uVar6,uVar4,*(undefined4 *)(*piVar3 + 0x11c));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar3;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x80e0cae5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80e0cae5:
		  uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		  Core_Gameplay_Managers_WorldManager__TryRequestMonsterForCurrentUserIsle(uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x948B", Offset = "0x948B", VA = "0x948B", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		int Gameplay_BossCombat_Controller_BossMinionCombatViewMediator__HandleGameOver
		              (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57999 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__OneOnOneCombatView__CheckArtifactsInDrop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a57999 = '\x01';
		  }
		  iVar2 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___AddGameProcessEventsHandlers
		                    (param1,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_BossMinionCombatModel__BossMinionCombatEvents__BossMinionCombatController__OneOnOneCombatView__CheckArtifactsInDrop__
		                    );
		  if (iVar2 == 0) {
		    uVar1 = 0;
		    uVar5 = *(undefined4 *)(param1[2] + 0x50);
		    piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		          goto code_r0x80e0cbde;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80e0cbde:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar1 = 0;
		    piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e0cc67;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80e0cc67:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar4 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(uVar4,uVar5,0);
		    uVar5 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		    if (param1 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar5,param1,*(undefined4 *)(*param1 + 0x174),0);
		    Gameplay_Combat_View_CombatGameOverView__add_CloseRequestEvent(param2,uVar5,0);
		    uVar4 = *(undefined4 *)(param2 + 0x38);
		    uVar5 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout(uVar5,param1,*(undefined4 *)(*param1 + 500),0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar4,uVar5,0);
		    Core_Dev_DevMenuVideoAd___ctor(param2,0);
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x948C", Offset = "0x948C", VA = "0x948C", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		void Gameplay_BossCombat_Controller_BossMinionCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5799a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a5799a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_CombatGameOverView__bool__TypeInfo);
		  if (param1 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,*(undefined4 *)(*param1 + 0x174),0);
		  Gameplay_Combat_View_CombatEventsToast___ctor(param2,uVar1,0);
		  param1_00 = *(undefined4 *)(param2 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout(uVar1,param1,*(undefined4 *)(*param1 + 500),0);
		  UI_IndexButtonBasic__get_CanvasGroup(param1_00,uVar1,0);
		  return;
		}
		*/

			return default(bool);
		}
	}
}
