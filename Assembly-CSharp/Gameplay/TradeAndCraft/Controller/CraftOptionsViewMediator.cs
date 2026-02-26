using System;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Gameplay.TradeAndCraft.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Controller
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	public class CraftOptionsViewMediator : AbstractViewMediator<TradeAndCraftModel, TradeAndCraftEvents, TradeAndCraftController, CraftOptionsWindow>
	{
		// Token: 0x06001BE9 RID: 7145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0x6D68", Offset = "0x6D68", VA = "0x6D68")]
		public CraftOptionsViewMediator(TradeAndCraftModel model, TradeAndCraftEvents events, TradeAndCraftController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a584ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__CraftOptionsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_AccountsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_CraftButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_ManufactureButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a584ce = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_CraftButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_ManufactureButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_AccountsButtonClickedEventHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_CraftButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_ManufactureButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_AccountsButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170004E9 RID: 1257
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E9")]
		public override CraftOptionsWindow View
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x6D69", Offset = "0x6D69", VA = "0x6D69", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x6D6A", Offset = "0x6D6A", VA = "0x6D6A")]
		private void CraftButtonClickedEventHandler()
		{
		/* --- GHIDRA: CraftButtonClickedEventHandler ---
		void Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator__CraftButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a584d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584d0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x80ef8f6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80ef8f6f:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x80ef901b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80ef901b:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		  Core_Gameplay_Managers_AccountsManager__ShowAccountsListWindow
		            (param1_00,*(undefined4 *)(iVar4 + 0x2c),0);
		  return;
		}
		*/

		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x6D6B", Offset = "0x6D6B", VA = "0x6D6B")]
		private void ManufactureButtonClickedEventHandler()
		{
		/* --- GHIDRA: ManufactureButtonClickedEventHandler ---
		void Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator__ManufactureButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a584d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584d1 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x80ef910d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80ef910d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowDiscountsWindow
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x6D6C", Offset = "0x6D6C", VA = "0x6D6C")]
		private void AccountsButtonClickedEventHandler()
		{
		/* --- GHIDRA: AccountsButtonClickedEventHandler ---
		void Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator__AccountsButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a584d2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_TradeAndCraftModel__TradeAndCraftEvents___ctor__);
		    DAT_ram_00a584d2 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_TradeAndCraftModel__TradeAndCraftEvents___ctor__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator__set_View
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a584cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584cf = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x80ef8e99;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80ef8e99:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowRatingWindow
		            (param1_00,0,0);
		  return;
		}
		*/

}
