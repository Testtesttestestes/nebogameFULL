using System;
using Gameplay.Combat.Control;
using Gameplay.TutorialCombatV2.Model;
using Il2CppDummyDll;

namespace Gameplay.TutorialCombatV2.Control
{
	// Token: 0x02000454 RID: 1108
	[Token(Token = "0x2000454")]
	public class TutorialCombatViewMediator : OneOnOneCombatViewMediator<TutorialCombatModel, TutorialCombatEvents, TutorialCombatController>
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x6BD7", Offset = "0x6BD7", VA = "0x6BD7")]
		public TutorialCombatViewMediator(TutorialCombatModel model, TutorialCombatEvents events, TutorialCombatController controller)
		{
		/* --- GHIDRA: <HandleGameOver>b__2_0 ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator___HandleGameOver_b__2_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5842f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideControlView___ctor__
		              );
		    DAT_ram_00a5842f = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GuideModel__GuideEvents__GuideController__GuideControlView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5842c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    DAT_ram_00a5842c = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(int **)(iVar2 + 0x50);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		        goto code_r0x80ee93a2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,5)
		  ;
		code_r0x80ee93a2:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,&local_4,puVar3[1]);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_View_ClanNickCultIndexView___ctor(local_4,1.0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x6BD8", Offset = "0x6BD8", VA = "0x6BD8", Slot = "39")]
		protected override void UpdateExperience()
		{
		/* --- GHIDRA: UpdateExperience ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator__UpdateExperience
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5842d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatGameOverView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator__HandleGameOver_b__2_0__
		              );
		    DAT_ram_00a5842d = '\x01';
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
		             Method_Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator__HandleGameOver_b__2_0__
		             ,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x118) * 4))
		            (piVar2,iVar1,uVar3,param1_00,*(undefined4 *)(*piVar2 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x6BD9", Offset = "0x6BD9", VA = "0x6BD9", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator__HandleGameOver
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5842e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TutorialCombatModel__TutorialCombatEvents__TutorialCombatController__OneOnOneCombatView__get_Model__
		              );
		    DAT_ram_00a5842e = '\x01';
		  }
		  param1_00 = param1[2];
		  iVar1 = Gameplay_Combat_Model_CombatModel__GetTurnState(param1_00,0);
		  if (((iVar1 != 0) && (*(int *)(param1_00 + 0x28) == 0)) && (*(int *)(param1_00 + 0x10) == 0)) {
		    param2_00 = (uint)(*(char *)(param1_00 + 0x5c) == '\0');
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  func_ii_14245(*(undefined4 *)(iVar1 + 0x14),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x6BDA", Offset = "0x6BDA", VA = "0x6BDA", Slot = "34")]
		protected override void HandleFieldInteraction()
		{
		/* --- GHIDRA: HandleFieldInteraction ---
		void Gameplay_TutorialCombatV2_Control_TutorialCombatViewMediator__HandleFieldInteraction
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a58429 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_TutorialCombatV2_Control_TutorialCombatController__CombatCompleteCoroutine_d__8_TypeInfo
		              );
		    DAT_ram_00a58429 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_TutorialCombatV2_Control_TutorialCombatController__CombatCompleteCoroutine_d__8_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = iVar1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = 0x40200000;
		  uVar2 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(iVar1 + 0x20) = uVar2;
		  return;
		}
		*/

		}
	}
}
