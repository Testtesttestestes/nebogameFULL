using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BAD RID: 2989
	[Token(Token = "0x2000BAD")]
	public class BossMinionWindowMediator : AbstractViewMediator<BossModel, BossEvents, BossController, BossMinionWindow>
	{
		// Token: 0x06004944 RID: 18756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004944")]
		[Address(RVA = "0x97B6", Offset = "0x97B6", VA = "0x97B6")]
		public BossMinionWindowMediator(BossModel model, BossEvents events, BossController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57906 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossMinionWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionCanceledEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionSuccessAttackEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionSuccessPayoffEvent__)
		    ;
		    DAT_ram_00a57906 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionSuccessPayoffEvent__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionSuccessAttackEvent__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionCanceledEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x2c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x2c) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionSuccessPayoffEvent__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x28);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionSuccessAttackEvent__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x28) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_MinionCanceledEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x2c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x2c) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000ED8 RID: 3800
		// (set) Token: 0x06004945 RID: 18757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED8")]
		public override BossEvents Events
		{
			[Token(Token = "0x6004945")]
			[Address(RVA = "0x97B7", Offset = "0x97B7", VA = "0x97B7", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ED9")]
		public override BossMinionWindow View
		{
			[Token(Token = "0x6004946")]
			[Address(RVA = "0x97B8", Offset = "0x97B8", VA = "0x97B8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004947")]
		[Address(RVA = "0x97B9", Offset = "0x97B9", VA = "0x97B9")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  int iVar11;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57909 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossMinionWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_CombatModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_AttackButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_BossManagerOnBossMinionCombatStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_KickButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57909 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x18) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossMinionWindowMediator_AttackButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar8,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0x1c) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossMinionWindowMediator_KickButtonClickHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar8,uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar9;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1f8);
		        goto code_r0x80dfd576;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80dfd576:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		  iVar11 = **(int **)(iVar2 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0x100) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar11 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 0x28);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar3,Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		  iVar11 = *(int *)(iVar2 + 0x20);
		  iVar2 = UnityEngine_TextEditingUtilities__set_cursorIndex(iVar11,0);
		  if ((iVar2 != 0) && (iVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar2,0), iVar2 == 0))
		  {
		    uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaLevelCost
		                      (uVar8,*(undefined4 *)(iVar11 + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = Gameplay_Isles_User_View_MonsterInfoView2__get_KickButton
		                      (*(undefined4 *)(iVar2 + 0x3c),0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		          goto code_r0x80dfd6cd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dfd6cd:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    uVar5 = func_ii_7112(uVar5,0);
		    UI_Price_Price__SetColor(uVar6,uVar5,uVar3,0);
		  }
		  iVar2 = System_Linq_Expressions_Interpreter_InterpretedFrame__GetDebugInfo(iVar11,0);
		  if ((iVar2 != 0) && (iVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar2,0), iVar2 == 0))
		  {
		    uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                      (uVar8,*(undefined4 *)(iVar11 + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = Gameplay_Isles_User_View_MonsterInfoView2__get_AttackPrice
		                      (*(undefined4 *)(iVar2 + 0x3c),0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar9;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		          goto code_r0x80dfd7f1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dfd7f1:
		    uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    uVar6 = func_ii_7112(uVar6,0);
		    UI_Price_Price__SetColor(uVar8,uVar6,uVar3,0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = Core_Extensions_Dict_AprDicExt__GetImageIsleAssetId
		                    (*(undefined4 *)(*(int *)(iVar11 + 0xc) + 0x10),0);
		  Gameplay_Isles_User_View_MonsterInfoView2__get_KickPrice(uVar8,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = Core_Data_MonsterData__get_KickPrice(iVar11,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterImageAssetId(uVar8,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(iVar11,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterDescription(uVar8,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar9;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x80dfd941;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dfd941:
		  uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		  uVar8 = func_ii_7112(uVar8,0);
		  uVar8 = Core_Data_MonsterData__GetDifficulty(iVar11,uVar8,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterLevel(uVar3,uVar8,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar3 = Core_Data_MonsterData__get_Title(iVar11,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterTitle(uVar8,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar8 = *(undefined4 *)(param1[2] + 8);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar9;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80dfda4d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dfda4d:
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  uVar8 = Core_Data_MonsterData__get_Level(iVar11,uVar8,uVar6,0);
		  Gameplay_Isles_User_View_MonsterInfoView__get_Rewards(uVar3,uVar8,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar2 + 0x40);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar3,Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar8,*(undefined4 *)(iVar2 + 0x24),0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar3,Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		  piVar9 = *(int **)(iVar2 + 0x18);
		  if (piVar9 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar9 + 0xb8) <
		         (uint)*(byte *)(Gameplay_BossCombat_BossMinionCombat_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar9 + 100) +
		                 (uint)*(byte *)(Gameplay_BossCombat_BossMinionCombat_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_BossCombat_BossMinionCombat_TypeInfo)) {
		      System_Activator__CreateInstance(piVar9,Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar10 = piVar9[10];
		  uVar8 = *(undefined4 *)(iVar10 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_CombatModel__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Boss_Controller_BossMinionWindowMediator_BossManagerOnBossMinionCombatStartedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  uVar3 = System_Action_CombatModel__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar10 + 0x1c) = 0;
		  }
		  else {
		    iVar7 = func_ii_1082(iVar2,System_Action_CombatModel__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar10 + 0x1c) = iVar7;
		    uVar3 = System_Action_CombatModel__TypeInfo;
		    iVar10 = func_ii_1082(iVar2,System_Action_CombatModel__TypeInfo);
		    if (iVar10 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x44);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar9;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80dfdc46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dfdc46:
		  uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		  piVar9 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		  local_4 = *(undefined4 *)(*(int *)(iVar11 + 8) + 0xc);
		  iVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  if ((iVar2 != 0) && (iVar11 = func_ii_1082(iVar2,*(undefined4 *)(*piVar9 + 0x20)), iVar11 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9[4] = iVar2;
		  UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar3,uVar8,piVar9,0);
		  return;
		}
		*/

		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004948")]
		[Address(RVA = "0x97BA", Offset = "0x97BA", VA = "0x97BA")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5790a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		    DAT_ram_00a5790a = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_01,Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_Boss_Controller_BossController__AttackMinion
		            (param1_00,*(undefined4 *)(iVar1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004949")]
		[Address(RVA = "0x97BB", Offset = "0x97BB", VA = "0x97BB")]
		private void KickButtonClickHandler()
		{
		/* --- GHIDRA: KickButtonClickHandler ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__KickButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a5790b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		    DAT_ram_00a5790b = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_01,Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_Boss_Controller_BossController__BeginBattle
		            (param1_00,*(undefined4 *)(iVar1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494A")]
		[Address(RVA = "0x97BC", Offset = "0x97BC", VA = "0x97BC")]
		private void AttackButtonClickHandler()
		{
		/* --- GHIDRA: AttackButtonClickHandler ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__AttackButtonClickHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a5790c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Scenes__IndexOf__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3649);
		    DAT_ram_00a5790c = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3649,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar2,5,param3,0);
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  func_ii_8753(uVar2,0);
		  iVar3 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar3 = func_ii_7156(*(undefined4 *)(iVar3 + 0x10),2,
		                       Method_System_Collections_Generic_List_Scenes__IndexOf__);
		  if (iVar3 == -1) {
		    uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__LoadScene(uVar2,2,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80dfdee9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dfdee9:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  Core_Gameplay_Managers_WorldManager__TryRequestMonsterForCurrentUserIsle(uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494B")]
		[Address(RVA = "0x97BD", Offset = "0x97BD", VA = "0x97BD")]
		private void MinionSuccessPayoffEvent()
		{
		/* --- GHIDRA: MinionSuccessPayoffEvent ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__MinionSuccessPayoffEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  func_ii_8753(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494C")]
		[Address(RVA = "0x97BE", Offset = "0x97BE", VA = "0x97BE")]
		private void BossManagerOnBossMinionCombatStartedEvent(CombatModel model)
		{
		/* --- GHIDRA: BossManagerOnBossMinionCombatStartedEvent ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__BossManagerOnBossMinionCombatStartedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  func_ii_8753(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494D")]
		[Address(RVA = "0x97BF", Offset = "0x97BF", VA = "0x97BF")]
		private void MinionSuccessAttackEvent()
		{
		/* --- GHIDRA: MinionSuccessAttackEvent ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__MinionSuccessAttackEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600494E RID: 18766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600494E")]
		[Address(RVA = "0x97C0", Offset = "0x97C0", VA = "0x97C0")]
		private void MinionCanceledEvent()
		{
		/* --- GHIDRA: MinionCanceledEvent ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__MinionCanceledEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5790d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossRatingView___ctor__
		              );
		    DAT_ram_00a5790d = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_object__object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Boss_Controller_AbstractBossWindowViewMediator_BossRatingView___ctor__)
		  ;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57907 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossModel__BossEvents__BossController__BossMinionWindow__set_View__
		              );
		    DAT_ram_00a57907 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Boss_Controller_BossMinionWindowMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Boss_Controller_BossMinionWindowMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Boss_Controller_BossMinionWindowMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57908 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CombatModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_AttackButtonClickHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossMinionWindowMediator_BossManagerOnBossMinionCombatStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossMinionWindowMediator_KickButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57908 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossMinionWindowMediator_AttackButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar4,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x1c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossMinionWindowMediator_KickButtonClickHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar4,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(uVar2,Method_UI_Windows_BaseWindow_BossMinionWindowArgs__get_WindowArgs__);
		  param1_00 = *(int **)(iVar1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_BossCombat_BossMinionCombat_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_BossCombat_BossMinionCombat_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_BossCombat_BossMinionCombat_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = param1_00[10];
		  uVar4 = *(undefined4 *)(iVar5 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_CombatModel__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossMinionWindowMediator_BossManagerOnBossMinionCombatStartedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar4,uVar2,0);
		  uVar2 = System_Action_CombatModel__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar5 + 0x1c) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CombatModel__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar5 + 0x1c) = iVar3;
		    uVar2 = System_Action_CombatModel__TypeInfo;
		    iVar5 = func_ii_1082(iVar1,System_Action_CombatModel__TypeInfo);
		    if (iVar5 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
