using System;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.Combat.Control;
using Il2CppDummyDll;
using Protocol.Tournaments;

namespace Gameplay.BlitzTournament.Controller
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	public class BlitzTournamentCombatMediator : OneOnOneCombatViewMediator<BlitzTournamentCombatModel, BlitzTournamentCombatEvents, BlitzTournamentCombatController>
	{
		// Token: 0x06004A46 RID: 19014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x98A8", Offset = "0x98A8", VA = "0x98A8")]
		public BlitzTournamentCombatMediator(BlitzTournamentCombatModel model, BlitzTournamentCombatEvents events, BlitzTournamentCombatController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a608ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__OneOnOneCombatView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_CurrentBattleCompletedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_FinalBattleCompletedEventHandler__
		              );
		    DAT_ram_00a608ba = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x74);
		    uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_CurrentBattleCompletedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x74) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x74) = iVar4;
		      uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x70);
		    uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_FinalBattleCompletedEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x70) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x70) = iVar4;
		      uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___ValidateUserBalance
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__OneOnOneCombatView__set_Events__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x74);
		    uVar2 = unnamed_function_1417(System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_CurrentBattleCompletedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x74) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x74) = iVar4;
		      uVar2 = System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ProtoCurrentTnmCombatCompleteEvt__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x70);
		    uVar2 = unnamed_function_1417(System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_FinalBattleCompletedEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x70) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x70) = iVar4;
		    uVar2 = System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ProtoFinalTnmCombatCompleteEvt__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000F08 RID: 3848
		// (set) Token: 0x06004A47 RID: 19015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F08")]
		public override BlitzTournamentCombatEvents Events
		{
			[Token(Token = "0x6004A47")]
			[Address(RVA = "0x98A9", Offset = "0x98A9", VA = "0x98A9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x98AA", Offset = "0x98AA", VA = "0x98AA")]
		private void CurrentBattleCompletedEventHandler(ProtoCurrentTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: CurrentBattleCompletedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__CurrentBattleCompletedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(undefined1 *)(param1 + 0x34) = 1;
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  local_10 = *(undefined8 *)(param2 + 0x10);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__FinalBattleCompletedEventHandler
		            (param1,&local_8,&local_10,&local_10);
		  return;
		}
		*/

		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x98AB", Offset = "0x98AB", VA = "0x98AB")]
		private void FinalBattleCompletedEventHandler(ProtoFinalTnmCombatCompleteEvt evt)
		{
		/* --- GHIDRA: FinalBattleCompletedEventHandler ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__FinalBattleCompletedEventHandler
		               (int *param1,longlong *param2,longlong *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  
		  if (DAT_ram_00a608bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_ReturnToTournament__
		              );
		    DAT_ram_00a608bb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    lVar4 = *param2;
		    iVar1 = *(int *)param1[2];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                      ((int *)param1[2],*(undefined4 *)(iVar1 + 0x104));
		    lVar3 = Core_Data_UserData__get_UserId(uVar2,0);
		    if (lVar4 != lVar3) {
		      lVar4 = *param3;
		      iVar1 = *(int *)param1[2];
		      uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        ((int *)param1[2],*(undefined4 *)(iVar1 + 0x104));
		      lVar3 = Core_Data_UserData__get_UserId(uVar2,0);
		      if (lVar4 != lVar3) {
		        return;
		      }
		    }
		    iVar1 = param1[10];
		    if (0 < *(int *)(iVar1 + 8)) {
		      uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar2,param1,
		                 Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_ReturnToTournament__
		                 ,0);
		      Gameplay_Combat_View_Animations_CombatAnimationCounter__remove__completeEvent(iVar1,uVar2,0);
		      return;
		    }
		    Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__HandleGameOver(param1,param1)
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4A")]
		[Address(RVA = "0x98AC", Offset = "0x98AC", VA = "0x98AC")]
		private void HandleBattleComplete(in ulong loserId, in ulong winnerId)
		{
		/* --- GHIDRA: HandleBattleComplete ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__HandleBattleComplete
		               (int *param1,undefined4 param2)
		
		{
		  uint param2_00;
		  undefined4 in_register_20000014;
		  int iVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  longlong lVar3;
		  undefined8 uVar4;
		  undefined4 param2_01;
		  undefined4 param1_01;
		  int *piVar5;
		  undefined4 uVar6;
		  longlong lVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a608bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BlitzTournamentCombatModel__BlitzTournamentCombatEvents__BlitzTournamentCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a608bc = '\x01';
		  }
		  param2_00 = 2;
		  lVar7 = *(longlong *)(param1[2] + 0x60);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 8),0);
		  if (lVar7 != lVar3) {
		    param2_00 = (uint)*(byte *)(param1 + 0xd);
		  }
		  uVar8 = 0;
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar1 + 100),0);
		  uVar4 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Gameplay_Combat_View_PlayerChatBubble__AddText(*(undefined4 *)(iVar1 + 0x68),0);
		  iVar1 = param1[2];
		  param2_01 = *(undefined4 *)(iVar1 + 0x50);
		  param1_01 = *(undefined4 *)(iVar1 + 8);
		  piVar5 = *(int **)(*(int *)(iVar1 + 0x3c) + 0x14);
		  iVar1 = *piVar5;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0xd8);
		        goto code_r0x81cf4ec2;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x81cf4ec2:
		  uVar4 = CONCAT44(uVar6,puVar2[1]);
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar8 = 0;
		  piVar5 = *(int **)(*(int *)(param1[2] + 0x3c) + 0x14);
		  iVar1 = *piVar5;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cf4f4b;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x81cf4f4b:
		  uVar4 = CONCAT44(uVar6,puVar2[1]);
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_01,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *piVar5;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x110);
		        goto code_r0x81cf5003;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81cf5003:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar6,puVar2[1]));
		  uVar6 = *(undefined4 *)(iVar1 + 0x14);
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1_01,0);
		  iVar1 = Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel(uVar6,uVar4,0);
		  uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (iVar1 != 0) {
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (iVar1,2,
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar1 = *piVar5;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x1c0);
		        goto code_r0x81cf50d4;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x20);
		code_r0x81cf50d4:
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar6,puVar2[1]));
		  Core_Gameplay_Managers_BlitzTournamentManager__Init(uVar6,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4B")]
		[Address(RVA = "0x98AD", Offset = "0x98AD", VA = "0x98AD", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__HandleGameOver
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a608bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_ReturnToTournament__
		              );
		    DAT_ram_00a608bd = '\x01';
		  }
		  param1_00 = param1[10];
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator_ReturnToTournament__
		             ,0);
		  Gameplay_Combat_View_Animations_CombatAnimationCounter__add_CompleteEvent(param1_00,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_BlitzTournament_Controller_BlitzTournamentCombatController__CurrentBattleCompleteEventHandler
		            (uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x98AE", Offset = "0x98AE", VA = "0x98AE")]
		private void ReturnToTournament()
		{
		/* --- GHIDRA: ReturnToTournament ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__ReturnToTournament
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a608be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_BlitzTournamentModel__BlitzTournamentEvents___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_ServiceFactory_GetService_BlitzTournamentService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a608be = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_BlitzTournamentModel__BlitzTournamentEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BlitzTournamentService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x34")]
		private bool _finalCombat;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__set_Events
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(undefined1 *)(param1 + 0x34) = 0;
		  local_8 = *(undefined8 *)(param2 + 0x18);
		  local_10 = *(undefined8 *)(param2 + 0x10);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__FinalBattleCompletedEventHandler
		            (param1,&local_8,&local_10,&local_10);
		  return;
		}
		*/

}
