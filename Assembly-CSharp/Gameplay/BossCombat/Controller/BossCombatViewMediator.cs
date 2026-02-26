using System;
using Gameplay.BossCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.Controller
{
	// Token: 0x02000B43 RID: 2883
	[Token(Token = "0x2000B43")]
	public class BossCombatViewMediator : OneOnOneCombatViewMediator<BossCombatModel, BossCombatEvents, BossCombatController>
	{
		// Token: 0x060045DF RID: 17887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045DF")]
		[Address(RVA = "0x9481", Offset = "0x9481", VA = "0x9481")]
		public BossCombatViewMediator(BossCombatModel model, BossCombatEvents events, BossCombatController controller)
		{
		/* --- GHIDRA: <HandleGameOver>b__1_0 ---
		void Gameplay_BossCombat_Controller_BossCombatViewMediator___HandleGameOver_b__1_0
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57992 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents__Dispose__
		              );
		    DAT_ram_00a57992 = '\x01';
		  }
		  Gameplay_Combat_Control_CombatController_object__object___CompleteQueueCallback
		            (param1,
		             Method_Gameplay_Combat_Control_CombatController_BossMinionCombatModel__BossMinionCombatEvents__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_BossCombat_Controller_BossCombatViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5798f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossCombatModel__BossCombatEvents__BossCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatGameOverView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BossCombat_Controller_BossCombatViewMediator__HandleGameOver_b__1_0__
		              );
		    DAT_ram_00a5798f = '\x01';
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
		             Method_Gameplay_BossCombat_Controller_BossCombatViewMediator__HandleGameOver_b__1_0__,0
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x118) * 4))
		            (piVar2,iVar1,uVar3,param1_00,*(undefined4 *)(*piVar2 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E0")]
		[Address(RVA = "0x9482", Offset = "0x9482", VA = "0x9482", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		int Gameplay_BossCombat_Controller_BossCombatViewMediator__HandleGameOver
		              (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57990 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_BossCombatModel__BossCombatEvents__BossCombatController__OneOnOneCombatView__CheckArtifactsInDrop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossCombatModel__BossCombatEvents__BossCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a57990 = '\x01';
		  }
		  iVar2 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___AddGameProcessEventsHandlers
		                    (param1,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_BossCombatModel__BossCombatEvents__BossCombatController__OneOnOneCombatView__CheckArtifactsInDrop__
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
		          goto code_r0x80e0c4a8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x80e0c4a8:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar1 = 0;
		    piVar6 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e0c531;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80e0c531:
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

		// Token: 0x060045E1 RID: 17889 RVA: 0x0000D188 File Offset: 0x0000B388
		[Token(Token = "0x60045E1")]
		[Address(RVA = "0x9483", Offset = "0x9483", VA = "0x9483", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		void Gameplay_BossCombat_Controller_BossCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57991 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a57991 = '\x01';
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
