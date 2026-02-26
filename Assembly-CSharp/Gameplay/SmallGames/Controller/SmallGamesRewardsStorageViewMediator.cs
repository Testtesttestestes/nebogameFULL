using System;
using Core.Data;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	public class SmallGamesRewardsStorageViewMediator : AbstractViewMediator<SmallGamesModel, SmallGamesEvents, SmallGamesController, RewardsStorageWindow>
	{
		// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x717F", Offset = "0x717F", VA = "0x717F")]
		public SmallGamesRewardsStorageViewMediator(SmallGamesModel model, SmallGamesEvents events, SmallGamesController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a582e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__RewardsStorageWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_InChestButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_RenderItems__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_SellAllDropCallback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_TakeAllDropCallback__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a582e7 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_TakeAllDropCallback__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_SellAllDropCallback__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_InChestButtonClickEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_RenderItems__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_TakeAllDropCallback__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x48) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_SellAllDropCallback__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_InChestButtonClickEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xc0);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar1,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_RenderItems__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__set_View(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__InChestButtonClickEventHandler
		              (param1,(uint)*(byte *)(*(int *)(iVar2 + 0x50) + 0xc4),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170005E0 RID: 1504
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E0")]
		public override RewardsStorageWindow View
		{
			[Token(Token = "0x600201B")]
			[Address(RVA = "0x7180", Offset = "0x7180", VA = "0x7180", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x7181", Offset = "0x7181", VA = "0x7181")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__Init
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a582e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__RewardsStorageWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_ArtifactDropRemoveEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_LastDropRequestedEventHandler__
		              );
		    DAT_ram_00a582e9 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x28);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_LastDropRequestedEventHandler__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x80ecc0d1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ecc0d1:
		    iVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		    iVar3 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		    System_Action_Int32Enum__Int32Enum___Invoke
		              (uVar4,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_ArtifactDropRemoveEventHandler__
		               ,0);
		    iVar3 = func_ii_7048(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else {
		      iVar7 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		      if (iVar7 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar2 + 0x1c) = iVar7;
		      uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		      iVar2 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		      if (iVar2 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar8 = *(undefined4 *)(iVar3 + 0x28);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_LastDropRequestedEventHandler__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x28) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x28) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x80ecc297;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80ecc297:
		    iVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		    iVar3 = **(int **)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                      (*(int **)(iVar2 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		    uVar8 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar4 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		    System_Action_Int32Enum__Int32Enum___Invoke
		              (uVar4,param1,
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator_ArtifactDropRemoveEventHandler__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar8,uVar4,0);
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    iVar7 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar2 + 0x1c) = iVar7;
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar2 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170005E1 RID: 1505
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E1")]
		public override SmallGamesEvents Events
		{
			[Token(Token = "0x600201D")]
			[Address(RVA = "0x7182", Offset = "0x7182", VA = "0x7182", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x7183", Offset = "0x7183", VA = "0x7183")]
		private void ArtifactDropRemoveEventHandler(DropTypes _, ArtifactData artifact)
		{
		/* --- GHIDRA: ArtifactDropRemoveEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__ArtifactDropRemoveEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__InChestButtonClickEventHandler
		            (param1,(uint)*(byte *)(*(int *)(iVar1 + 0x50) + 0xc4),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x7184", Offset = "0x7184", VA = "0x7184")]
		private void LastDropRequestedEventHandler()
		{
		/* --- GHIDRA: LastDropRequestedEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__LastDropRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__RequestLastDropResultHandler
		            (param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x7185", Offset = "0x7185", VA = "0x7185")]
		private void TakeAllDropCallback()
		{
		/* --- GHIDRA: TakeAllDropCallback ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__TakeAllDropCallback
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__DropRemovedEventHandler(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x7186", Offset = "0x7186", VA = "0x7186")]
		private void SellAllDropCallback()
		{
		/* --- GHIDRA: SellAllDropCallback ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__SellAllDropCallback
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a582eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a582eb = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80ecc551;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ecc551:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__ShowChestWindow(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x7187", Offset = "0x7187", VA = "0x7187")]
		private void InChestButtonClickEventHandler()
		{
		/* --- GHIDRA: InChestButtonClickEventHandler ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__InChestButtonClickEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  uint param2_00;
		  
		  if (DAT_ram_00a582ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__RewardsStorageWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_ValueTuple_uint__ArtifactData___uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ValueTuple_uint__ArtifactData___ArtifactData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ValueTuple_uint__ArtifactData___uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ValueTuple_uint__ArtifactData___ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__RenderItems_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__RenderItems_b__11_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__RenderItems_b__11_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo);
		    DAT_ram_00a582ec = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x18) == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x48),0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x44),0,0);
		  }
		  else {
		    iVar3 = *(int *)(*(int *)(param1[2] + 0x18) + 0xc);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param2_00 = (uint)(0 < iVar3);
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x48),param2_00,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x44),param2_00,0);
		    if (param2_00 != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = *(undefined4 *)(iVar1 + 0x40);
		      uVar4 = *(undefined4 *)(param1[2] + 0x18);
		      if (param2 != 0) {
		        if (*(int *)(
		                    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                    + 0x74) == 0) {
		          func_ii_306000(
		                        Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                        );
		        }
		        puVar5 = *(undefined4 **)
		                  (Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                  + 0x5c);
		        iVar1 = puVar5[1];
		        if (iVar1 == 0) {
		          if (*(int *)(
		                      Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                      + 0x74) == 0) {
		            func_ii_306000(
		                          Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                          );
		            puVar5 = *(undefined4 **)
		                      (
		                      Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                      + 0x5c);
		          }
		          uVar6 = *puVar5;
		          iVar1 = unnamed_function_1417(System_Func_ValueTuple_uint__ArtifactData___uint__TypeInfo);
		          System_Func_ValueTuple_uint__object___float___Invoke
		                    (iVar1,uVar6,
		                     Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__RenderItems_b__11_0__
		                     ,0);
		          *(int *)(*(int *)(
		                           Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                           + 0x5c) + 4) = iVar1;
		        }
		        uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                          (uVar4,iVar1,
		                           Method_System_Linq_Enumerable_OrderBy_ValueTuple_uint__ArtifactData___uint___
		                          );
		        if (*(int *)(
		                    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                    + 0x74) == 0) {
		          func_ii_306000(
		                        Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                        );
		        }
		        puVar5 = *(undefined4 **)
		                  (Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                  + 0x5c);
		        iVar1 = puVar5[2];
		        if (iVar1 == 0) {
		          if (*(int *)(
		                      Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                      + 0x74) == 0) {
		            func_ii_306000(
		                          Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                          );
		            puVar5 = *(undefined4 **)
		                      (
		                      Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                      + 0x5c);
		          }
		          uVar6 = *puVar5;
		          iVar1 = unnamed_function_1417
		                            (System_Func_ValueTuple_uint__ArtifactData___ArtifactData__TypeInfo);
		          System_Func_ValueTuple_uint__object___InternedString___Invoke
		                    (iVar1,uVar6,
		                     Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__RenderItems_b__11_1__
		                     ,0);
		          *(int *)(*(int *)(
		                           Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                           + 0x5c) + 8) = iVar1;
		        }
		        uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                          (uVar4,iVar1,
		                           Method_System_Linq_Enumerable_Select_ValueTuple_uint__ArtifactData___ArtifactData___
		                          );
		        uVar4 = System_Linq_Enumerable__Select_object__object_
		                          (uVar4,Method_System_Linq_Enumerable_ToList_ArtifactData___);
		        Gameplay_SmallGames_View_RewardStorageOSAView__RemoveItemsFrom(uVar2,uVar4,0);
		        return;
		      }
		      if (*(int *)(Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                  + 0x74) == 0) {
		        func_ii_306000(
		                      Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                      );
		      }
		      puVar5 = *(undefined4 **)
		                (Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo +
		                0x5c);
		      iVar1 = puVar5[3];
		      if (iVar1 == 0) {
		        if (*(int *)(
		                    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                    + 0x74) == 0) {
		          func_ii_306000(
		                        Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                        );
		          puVar5 = *(undefined4 **)
		                    (
		                    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                    + 0x5c);
		        }
		        uVar6 = *puVar5;
		        iVar1 = unnamed_function_1417
		                          (System_Func_ValueTuple_uint__ArtifactData___ArtifactData__TypeInfo);
		        System_Func_ValueTuple_uint__object___InternedString___Invoke
		                  (iVar1,uVar6,
		                   Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__RenderItems_b__11_2__
		                   ,0);
		        *(int *)(*(int *)(
		                         Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                         + 0x5c) + 0xc) = iVar1;
		      }
		      uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                        (uVar4,iVar1,
		                         Method_System_Linq_Enumerable_Select_ValueTuple_uint__ArtifactData___ArtifactData___
		                        );
		      uVar4 = System_Linq_Enumerable__Select_object__object_
		                        (uVar4,Method_System_Linq_Enumerable_ToList_ArtifactData___);
		      Gameplay_SmallGames_View_RewardStorageOSAView__RemoveItemsFrom(uVar2,uVar4,0);
		      return;
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  Gameplay_SmallGames_View_RewardStorageOSAView__RemoveItemsFrom(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x7188", Offset = "0x7188", VA = "0x7188")]
		private void RenderItems(bool sort)
		{
		/* --- GHIDRA: RenderItems ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__RenderItems
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a582ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo);
		    DAT_ram_00a582ed = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param3;
		  longlong lVar3;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a582e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__RewardsStorageWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13839);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27277);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25147);
		    DAT_ram_00a582e8 = '\x01';
		  }
		  lVar3 = Core_Extensions_Dict_DictExt__GetDoubleParameter
		                    (*(undefined4 *)(param1[2] + 0x10),StringLiteral_27277,0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  local_8 = func_ii_7125((double)lVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x54);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13839,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_c = System_TimeSpan__get_Ticks(&local_8,0);
		  param3 = func_ii_4443(&local_c,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_25147,param3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_01,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__set_Events
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a582ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__RewardsStorageWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___RemoveAll__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_ValueTuple_uint__ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__DisplayClass6_0__ArtifactDropRemoveEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__DisplayClass6_0_TypeInfo
		              );
		    DAT_ram_00a582ea = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__DisplayClass6_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param3;
		  param1_00 = *(undefined4 *)(param1[2] + 0x18);
		  uVar2 = unnamed_function_1417(System_Predicate_ValueTuple_uint__ArtifactData___TypeInfo);
		  System_Predicate_ValueTuple_object__object____Invoke
		            (uVar2,iVar1,
		             Method_Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator___c__DisplayClass6_0__ArtifactDropRemoveEventHandler_b__0__
		             ,0);
		  System_Collections_Generic_List_XmlSchemaObjectTable_XmlSchemaObjectEntry___Remove
		            (param1_00,uVar2,
		             Method_System_Collections_Generic_List_ValueTuple_uint__ArtifactData___RemoveAll__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_SmallGames_Controller_SmallGamesRewardsStorageViewMediator__InChestButtonClickEventHandler
		            (param1,(uint)*(byte *)(*(int *)(iVar1 + 0x50) + 0xc4),param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SmallGames_Controller_SmallGamesController__ValidateInit(uVar2,param1);
		  return;
		}
		*/

}
