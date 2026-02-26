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
	// Token: 0x02000D39 RID: 3385
	[Token(Token = "0x2000D39")]
	public class IsleMonsterInfoWindowMediator2 : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleMonsterInfoWindow2>
	{
		// Token: 0x060052CD RID: 21197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0xA0A3", Offset = "0xA0A3", VA = "0xA0A3")]
		public IsleMonsterInfoWindowMediator2(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58dc2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldControllerEvents_MonsterChangeReason__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_MonsterChangedEvent__
		              );
		    DAT_ram_00a58dc2 = '\x01';
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
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_MonsterChangedEvent__
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
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_MonsterChangedEvent__
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

		// Token: 0x170010E1 RID: 4321
		// (set) Token: 0x060052CE RID: 21198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E1")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052CE")]
			[Address(RVA = "0xA0A4", Offset = "0xA0A4", VA = "0xA0A4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0xA0A5", Offset = "0xA0A5", VA = "0xA0A5")]
		private void MonsterChangedEvent(WorldControllerEvents.MonsterChangeReason reason)
		{
		/* --- GHIDRA: MonsterChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__MonsterChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58dc4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_AttackButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_KickButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58dc4 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_AttackButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_KickButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x18) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_AttackButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x1c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2_KickButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__UpdateMonsterInfo(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010E2 RID: 4322
		// (set) Token: 0x060052D0 RID: 21200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E2")]
		public override IsleMonsterInfoWindow2 View
		{
			[Token(Token = "0x60052D0")]
			[Address(RVA = "0xA0A6", Offset = "0xA0A6", VA = "0xA0A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0xA0A7", Offset = "0xA0A7", VA = "0xA0A7")]
		private void UpdateMonsterInfo()
		{
		/* --- GHIDRA: UpdateMonsterInfo ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__UpdateMonsterInfo
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
		  
		  if (DAT_ram_00a58dc6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    DAT_ram_00a58dc6 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar2 + 0x3c);
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
		        goto code_r0x80facf17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80facf17:
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
		  iVar6 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(*(char *)(param1[2] + 0x44) == '\0'),0);
		  Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__set_View(param1,iVar6);
		  return;
		}
		*/

		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0xA0A8", Offset = "0xA0A8", VA = "0xA0A8")]
		private void ResolveMonster()
		{
		/* --- GHIDRA: ResolveMonster ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__ResolveMonster
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58dc7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58dc7 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x40) != 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		          goto code_r0x80fad8ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80fad8ba:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar4 = Core_Gameplay_Managers_WorldManager__ControllerOnInitComplete
		                      (uVar3,*(undefined4 *)(param1[2] + 0x40),0);
		    if (iVar4 != 0) {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar3,2,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0xA0A9", Offset = "0xA0A9", VA = "0xA0A9")]
		private void AttackButtonClickHandler()
		{
		/* --- GHIDRA: AttackButtonClickHandler ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__AttackButtonClickHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58dc8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58dc8 = '\x01';
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
		        goto code_r0x80fad9bf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80fad9bf:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar7 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar7 + 0x104));
		  if (*(int *)(*(int *)(param1 + 8) + 0x40) != 0) {
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
		          goto code_r0x80fada98;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fada98:
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
		            goto code_r0x80fadb67;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80fadb67:
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
		            goto code_r0x80fadc17;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80fadc17:
		      iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactData(*(undefined4 *)(iVar5 + 0x18),8,0)
		      ;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0xA0AA", Offset = "0xA0AA", VA = "0xA0AA")]
		private void KickButtonClickHandler()
		{
		/* --- GHIDRA: KickButtonClickHandler ---
		undefined4
		Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__KickButtonClickHandler
		          (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a58dc9 == '\0') {
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
		    DAT_ram_00a58dc9 = '\x01';
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

		// Token: 0x060052D5 RID: 21205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0xA0AB", Offset = "0xA0AB", VA = "0xA0AB")]
		private DialogWindow ShowMonsterFlewAwayDialogWindow()
		{
		/* --- GHIDRA: ShowMonsterFlewAwayDialogWindow ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__ShowMonsterFlewAwayDialogWindow
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58dca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__Dispose__
		              );
		    DAT_ram_00a58dca = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Utils_Trackers_AsyncLoadableContentTracker__StartTracking(*(undefined4 *)(param1_00 + 0x38),0);
		  param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_01,0,0);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__Dispose__
		            );
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58dc3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_AttackMonsterWindowArgs__get_WindowArgs__);
		    DAT_ram_00a58dc3 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x40) != 0) {
		    if (*(char *)(param1[2] + 0x44) != '\0') {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = func_ii_8093(uVar3,
		                           Method_UI_Windows_BaseWindow_AttackMonsterWindowArgs__get_WindowArgs__);
		      Gameplay_Isles_User_UserIsle__CreateMvc(*(undefined4 *)(iVar2 + 0x18),param1);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar3,0,0);
		      return;
		    }
		    Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__UpdateMonsterInfo(param1,param1);
		    return;
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x148) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x14c));
		  if ((param2 == 2) && (iVar2 != 0)) {
		    Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__KickButtonClickHandler
		              (param1,param1);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar3,0,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_IsleMonsterInfoWindowMediator2__set_View
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
		  
		  if (DAT_ram_00a58dc5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterInfoWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58dc5 = '\x01';
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
		        goto code_r0x80fad1ea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80fad1ea:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar9 = **(int **)(iVar6 + 0x14);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(iVar6 + 0x14),*(undefined4 *)(iVar9 + 0x104));
		  uVar7 = *(undefined4 *)(iVar6 + 0x28);
		  iVar6 = UnityEngine_TextEditingUtilities__set_cursorIndex(*(undefined4 *)(param1[2] + 0x40),0);
		  if ((iVar6 != 0) && (iVar6 = Core_Extensions_Dict_ResourceSetExt__GetDelta(iVar6,0), iVar6 == 0))
		  {
		    uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetArenaLevelCost
		                      (uVar7,*(undefined4 *)(*(int *)(param1[2] + 0x40) + 8),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar8 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x38) + 0x18) + 0xb8);
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
		          goto code_r0x80fad329;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fad329:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar4 = func_ii_7112(uVar4,0);
		    UI_Price_Price__SetColor(uVar8,uVar4,uVar3,0);
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
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x38) + 0x1c) + 0xb8);
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
		          goto code_r0x80fad45a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fad45a:
		    uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar8 = func_ii_7112(uVar8,0);
		    UI_Price_Price__SetColor(uVar3,uVar8,uVar7,0);
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *(int *)(iVar6 + 0x38);
		  uVar7 = Core_Extensions_Dict_AprDicExt__GetAnimationAssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x40) + 0xc) + 0x10),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(iVar6 + 0x14),uVar7,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = *(int *)(iVar6 + 0x38);
		  uVar7 = Core_Data_MonsterData__get_KickPrice(*(undefined4 *)(param1[2] + 0x40),0);
		  piVar5 = *(int **)(iVar6 + 0x10);
		  iVar6 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar5,uVar7,*(undefined4 *)(iVar6 + 0x2d4));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar6 + 0x38);
		  uVar7 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(*(undefined4 *)(param1[2] + 0x40),0);
		  iVar6 = param1[2];
		  uVar3 = Core_Data_MonsterData__GetDifficulty
		                    (*(undefined4 *)(iVar6 + 0x40),*(undefined4 *)(iVar6 + 0x48),0);
		  Gameplay_Isles_User_View_MonsterInfoView2__set_MonsterTitle(uVar8,uVar7,uVar3,iVar6);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar6 + 0x38);
		  uVar3 = *(undefined4 *)(param1[2] + 0x48);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80fad60a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fad60a:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar3 = Core_Data_MonsterData__get_Level(uVar8,uVar3,uVar4,0);
		  uVar7 = Gameplay_Isles_User_View_MonsterInfoView2__get_MonsterDifficultyElement(uVar7,uVar3);
		  UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__get_Rewards(uVar7,uVar3,0);
		  return;
		}
		*/

}
