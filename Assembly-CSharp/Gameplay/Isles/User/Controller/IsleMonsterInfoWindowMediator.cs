using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Gameplay.World.Events;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D38 RID: 3384
	[Token(Token = "0x2000D38")]
	public class IsleMonsterInfoWindowMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleMonsterInfoWindow>
	{
		// Token: 0x060052C2 RID: 21186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C2")]
		[Address(RVA = "0xA098", Offset = "0xA098", VA = "0xA098")]
		public IsleMonsterInfoWindowMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58db7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_MonsterChangedEvent__
		              );
		    DAT_ram_00a58db7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_MonsterChangedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x24) = iVar4;
		      uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_MonsterChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x24) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x24) = iVar4;
		    uVar2 = System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo);
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

		// Token: 0x170010DF RID: 4319
		// (set) Token: 0x060052C3 RID: 21187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DF")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052C3")]
			[Address(RVA = "0xA099", Offset = "0xA099", VA = "0xA099", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0xA09A", Offset = "0xA09A", VA = "0xA09A")]
		private void MonsterChangedEvent(WorldControllerEvents.MonsterChangeReason reason)
		{
		/* --- GHIDRA: MonsterChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__MonsterChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58db9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__set_View__
		              );
		    DAT_ram_00a58db9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010E0 RID: 4320
		// (set) Token: 0x060052C5 RID: 21189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E0")]
		public override IsleMonsterInfoWindow View
		{
			[Token(Token = "0x60052C5")]
			[Address(RVA = "0xA09B", Offset = "0xA09B", VA = "0xA09B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0xA09C", Offset = "0xA09C", VA = "0xA09C")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58dbb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_AttackButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_KickButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58dbb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_AttackButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x1c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_KickButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x40) + 0x20) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_KickButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Horde_View_HordeView__OnDestroy(uVar3,uVar2,param1[2],0);
		  Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__UpdateMonsterInfo(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C7")]
		[Address(RVA = "0xA09D", Offset = "0xA09D", VA = "0xA09D")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a58dbc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58dbc = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1f8);
		        goto code_r0x80fac1d5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80fac1d5:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar9 = **(int **)(iVar6 + 0x14);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x14),*(undefined4 *)(iVar9 + 0x104));
		  uVar7 = *(undefined4 *)(iVar6 + 0x28);
		  iVar6 = UnityEngine_TextEditingUtilities__set_cursorIndex(*(undefined4 *)(param1[2] + 0x40),0);
		  if ((iVar6 != 0) && (iVar6 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar6,0), iVar6 == 0))
		  {
		    uVar8 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaLevelCost
		                      (uVar7,*(undefined4 *)(*(int *)(param1[2] + 0x40) + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar8 = Core_Money_Money__op_Explicit(uVar8,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x3c) + 0x18) + 0xb8);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80fac314;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fac314:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar4 = func_ii_7112(uVar4,0);
		    UI_Price_Price__SetColor(uVar3,uVar4,uVar8,0);
		  }
		  iVar6 = System_Linq_Expressions_Interpreter_InterpretedFrame__GetDebugInfo
		                    (*(undefined4 *)(param1[2] + 0x40),0);
		  if ((iVar6 != 0) && (iVar6 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar6,0), iVar6 == 0))
		  {
		    uVar7 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                      (uVar7,*(undefined4 *)(*(int *)(param1[2] + 0x40) + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar7 = Core_Money_Money__op_Explicit(uVar7,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x3c) + 0x1c) + 0xb8);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80fac445;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fac445:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    UI_Price_Price__SetColor(uVar8,uVar3,uVar7,0);
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *(int *)(iVar6 + 0x3c);
		  uVar7 = Core_Extensions_Dict_AprDicExt__GetImageIsleAssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x40) + 0xc) + 0x10),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(iVar6 + 0x14),uVar7,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *(int *)(iVar6 + 0x3c);
		  uVar7 = Core_Data_MonsterData__get_KickPrice(*(undefined4 *)(param1[2] + 0x40),0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(*(undefined4 *)(iVar6 + 0x10),uVar7,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *(int *)(iVar6 + 0x3c);
		  uVar7 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(*(undefined4 *)(param1[2] + 0x40),0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Title(*(undefined4 *)(iVar6 + 0x10),uVar7,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar6 + 0x3c);
		  uVar8 = *(undefined4 *)(param1[2] + 0x40);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80fac5d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fac5d2:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar8 = Core_Data_MonsterData__GetDifficulty(uVar8,uVar3,0);
		  Gameplay_Isles_User_View_MonsterInfoView__set_MonsterLevel(uVar7,uVar8,puVar2);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *(int *)(iVar6 + 0x3c);
		  uVar7 = Core_Data_MonsterData__get_Title(*(undefined4 *)(param1[2] + 0x40),0);
		  if (DAT_ram_00a58d65 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    DAT_ram_00a58d65 = '\x01';
		  }
		  iVar9 = *(int *)(iVar6 + 0x20);
		  if (*(char *)(iVar9 + 0x2c) == '\0') {
		    uVar8 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    UI_Elements_RightPanel_TitledList_TitledList__set_Title(iVar9,uVar8,0);
		    iVar9 = *(int *)(iVar6 + 0x20);
		  }
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(iVar9,uVar7,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar6 + 0x3c);
		  uVar8 = *(undefined4 *)(param1[2] + 0x48);
		  uVar3 = *(undefined4 *)(param1[2] + 0x40);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80fac739;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fac739:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar8 = Core_Data_MonsterData__get_Level(uVar3,uVar8,uVar4,0);
		  uVar7 = Gameplay_Isles_User_View_MonsterInfoView__get_MonsterDifficultyElement(uVar7,uVar8);
		  UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__get_Rewards(uVar7,uVar8,0);
		  return;
		}
		*/

		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0xA09E", Offset = "0xA09E", VA = "0xA09E")]
		private void UpdateMonsterInfo()
		{
		/* --- GHIDRA: UpdateMonsterInfo ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__UpdateMonsterInfo
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58dbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    DAT_ram_00a58dbd = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x44);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar5;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80fabfdf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fabfdf:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  piVar5 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x40) + 8) + 0xc);
		  iVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  if ((iVar2 != 0) && (iVar6 = func_ii_1082(iVar2,*(undefined4 *)(*piVar5 + 0x20)), iVar6 == 0)) {
		    uVar4 = func_ii_1083();
		    func_ii_1050(uVar4,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar5[4] = iVar2;
		  UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar4,param2_00,piVar5,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(*(char *)(param1[2] + 0x44) == '\0'),0);
		  iVar6 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)*(byte *)(param1[2] + 0x44),0);
		  if (*(char *)(param1[2] + 0x44) == '\0') {
		    Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__SetupView(param1,iVar6);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Horde_View_HordeView__remove_RequestHordeInfoEvent
		              (*(undefined4 *)(iVar2 + 0x40),
		               *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x40) + 8) + 0xc),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0xA09F", Offset = "0xA09F", VA = "0xA09F")]
		private void ResolveMonster()
		{
		/* --- GHIDRA: ResolveMonster ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__ResolveMonster
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58dbe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58dbe = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80fac82f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80fac82f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = Core_Gameplay_Managers_WorldManager__ControllerOnInitComplete
		                    (uVar3,*(undefined4 *)(param1[2] + 0x40),0);
		  if (iVar4 != 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar3,2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0xA0A0", Offset = "0xA0A0", VA = "0xA0A0")]
		private void AttackButtonClickHandler()
		{
		/* --- GHIDRA: AttackButtonClickHandler ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__AttackButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58dbf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58dbf = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x80fac933;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80fac933:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar7 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  uVar6 = *(undefined4 *)(iVar5 + 0x28);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80fac9fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fac9fb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = func_ii_7112(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar5 + 0x78);
		  uVar6 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                    (uVar6,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x40) + 8),0);
		  iVar5 = Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode(uVar3,uVar6,0);
		  if (iVar5 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		          goto code_r0x80facac9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80facac9:
		    uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    Core_Gameplay_Managers_WorldManager__TryAttackMonsterFromCurrentIsle(uVar6,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x220);
		          goto code_r0x80facb79;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80facb79:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData(*(undefined4 *)(iVar5 + 0x18),8,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0xA0A1", Offset = "0xA0A1", VA = "0xA0A1")]
		private void KickButtonClickHandler()
		{
		/* --- GHIDRA: KickButtonClickHandler ---
		undefined4
		Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__KickButtonClickHandler
		          (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a58dc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_10790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10789);
		    DAT_ram_00a58dc0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_10790,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_10789,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = UI_Windows_DialogWindow__get_NO_LABEL(0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0xA0A2", Offset = "0xA0A2", VA = "0xA0A2")]
		private DialogWindow ShowMonsterFlewAwayDialogWindow()
		{
		/* --- GHIDRA: ShowMonsterFlewAwayDialogWindow ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__ShowMonsterFlewAwayDialogWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58dc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2___ctor__
		              );
		    DAT_ram_00a58dc1 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2___ctor__
		            );
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58db8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow__get_Model__
		              );
		    DAT_ram_00a58db8 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x40) == 0) {
		    piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x148) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0x14c));
		    if (iVar2 != 0) {
		      if (param2 == 2) {
		        Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__KickButtonClickHandler
		                  (param1,param1);
		      }
		      param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1_00,0,0);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58dba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_AttackButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_KickButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58dba = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_AttackButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x1c) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_KickButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x40) + 0x20) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator_KickButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

}
