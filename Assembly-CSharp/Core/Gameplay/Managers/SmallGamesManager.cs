using System;
using System.Runtime.CompilerServices;
using Gameplay.SmallGames.Controller;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.SmallGames;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001179 RID: 4473
	[Token(Token = "0x2001179")]
	public class SmallGamesManager : IGameManager, IBaseManager
	{
		// Token: 0x1400029E RID: 670
		// (add) Token: 0x060069D9 RID: 27097 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069DA RID: 27098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069D9")]
			[Address(RVA = "0xB4F9", Offset = "0xB4F9", VA = "0xB4F9", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069DA")]
			[Address(RVA = "0xB4FA", Offset = "0xB4FA", VA = "0xB4FA", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400029F RID: 671
		// (add) Token: 0x060069DB RID: 27099 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069DC RID: 27100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069DB")]
			[Address(RVA = "0xB4FB", Offset = "0xB4FB", VA = "0xB4FB", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069DC")]
			[Address(RVA = "0xB4FC", Offset = "0xB4FC", VA = "0xB4FC", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069DD")]
		[Address(RVA = "0xB4FD", Offset = "0xB4FD", VA = "0xB4FD", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x060069DE RID: 27102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A9")]
		public SmallGamesController Controller
		{
			[Token(Token = "0x60069DE")]
			[Address(RVA = "0xB4FE", Offset = "0xB4FE", VA = "0xB4FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069DF")]
		[Address(RVA = "0xB4FF", Offset = "0xB4FF", VA = "0xB4FF")]
		public void SetView(UserInterfaceView view)
		{
		/* --- GHIDRA: SetView ---
		void Core_Gameplay_Managers_SmallGamesManager__SetView(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a63840 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_SmallGamesManager_HandleFeatureInitEvent__);
		    DAT_ram_00a63840 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_SmallGamesManager_HandleFeatureInitEvent__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E0")]
		[Address(RVA = "0xB500", Offset = "0xB500", VA = "0xB500")]
		private void HandleFeatureInitEvent()
		{
		/* --- GHIDRA: HandleFeatureInitEvent ---
		void Core_Gameplay_Managers_SmallGamesManager__HandleFeatureInitEvent(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  puVar1 = (undefined8 *)(param1 + 0x18);
		  MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)puVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x134));
		  *puVar1 = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E1")]
		[Address(RVA = "0xB501", Offset = "0xB501", VA = "0xB501", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_SmallGamesManager__Deinit
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a63841 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_SmallGamesWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SmallGamesWindow_SmallGamesWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12667);
		    DAT_ram_00a63841 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param3_00 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_SmallGames_View_SmallGamesWindow_SmallGamesWindowArgs_TypeInfo);
		  Core_GameResources_BaseGameResourcesFabric_object__object___get_TotalResourceCount
		            (param1_00,param2,param3_00,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12667,param1_00,
		             Method_UI_Windows_PopupController_Show_SmallGamesWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E2")]
		[Address(RVA = "0xB502", Offset = "0xB502", VA = "0xB502")]
		public void ShowSmallGamesWindow(SlotMachineType slotMachineType = SlotMachineType.UnknownMachine)
		{
		/* --- GHIDRA: ShowSmallGamesWindow ---
		void Core_Gameplay_Managers_SmallGamesManager__ShowSmallGamesWindow(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63842 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow_DailyRewardsWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_DailyRewardsWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_HasOpenWindow_DailyRewardsWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DailyRewardsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12665);
		    DAT_ram_00a63842 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  iVar2 = UI_Windows_PopupController__GetWindows_object_
		                    (uVar1,Method_UI_Windows_PopupController_HasOpenWindow_DailyRewardsWindow___);
		  if (iVar2 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		    DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar1,0,Method_UI_Windows_PopupController_Close_DailyRewardsWindow___);
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param2_00 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow_DailyRewardsWindowArgs_TypeInfo
		                        );
		  Core_Browser_BrowserWindow___ctor(param1_00,param2_00,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12665,param1_00,
		             Method_UI_Windows_PopupController_Show_DailyRewardsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E3")]
		[Address(RVA = "0xB503", Offset = "0xB503", VA = "0xB503")]
		public void ShowDailyRewardsWindow()
		{
		/* --- GHIDRA: ShowDailyRewardsWindow ---
		undefined4
		Core_Gameplay_Managers_SmallGamesManager__ShowDailyRewardsWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63843 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14440);
		    DAT_ram_00a63843 = '\x01';
		  }
		  return StringLiteral_14440;
		}
		*/

		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x060069E4 RID: 27108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015AA")]
		public string Name
		{
			[Token(Token = "0x60069E4")]
			[Address(RVA = "0xB504", Offset = "0xB504", VA = "0xB504", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0xB505", Offset = "0xB505", VA = "0xB505")]
		public SmallGamesManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_SmallGamesManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63844 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14531);
		    DAT_ram_00a63844 = '\x01';
		  }
		  return StringLiteral_14531;
		}
		*/

		}

		// Token: 0x0400381D RID: 14365
		[Token(Token = "0x400381D")]
		[FieldOffset(Offset = "0x10")]
		private Gameplay.SmallGames.Events.SmallGamesEvents _events;

		// Token: 0x0400381E RID: 14366
		[Token(Token = "0x400381E")]
		[FieldOffset(Offset = "0x14")]
		private SmallGamesModel _model;

		// Token: 0x0400381F RID: 14367
		[Token(Token = "0x400381F")]
		[FieldOffset(Offset = "0x18")]
		private SmallGamesController _controller;

		// Token: 0x04003820 RID: 14368
		[Token(Token = "0x4003820")]
		[FieldOffset(Offset = "0x1C")]
		private SmallGamesEnterPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_SmallGamesManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6383c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6383c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_SmallGamesManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6383d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6383d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_SmallGamesManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6383e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6383e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_SmallGamesManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 param3;
		  
		  if (DAT_ram_00a6383f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_Model_SmallGamesModel_DailyRewardsInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Controller_SmallGamesController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Events_SmallGamesEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_SmallGamesManager_HandleFeatureInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Model_SmallGamesModel_TypeInfo);
		    DAT_ram_00a6383f = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_SmallGames_Events_SmallGamesEvents_TypeInfo);
		  *(int *)(param1 + 0x10) = iVar2;
		  uVar7 = *(undefined4 *)(iVar2 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_SmallGamesManager_HandleFeatureInitEvent__,0
		            );
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar3,0);
		  iVar8 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 8) = piVar4, *piVar4 != iVar8))
		  {
		    System_Activator__CreateInstance(piVar4,iVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = unnamed_function_1417(Gameplay_SmallGames_Model_SmallGamesModel_DailyRewardsInfo_TypeInfo)
		  ;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		        goto code_r0x82307e0a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82307e0a:
		  uVar7 = 0;
		  iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  if (*(int *)(iVar8 + 0x14) != 0) {
		    uVar7 = *(undefined4 *)(*(int *)(iVar8 + 0x14) + 8);
		  }
		  uVar6 = unnamed_function_1417(Gameplay_SmallGames_Model_SmallGamesModel_TypeInfo);
		  Gameplay_SmallGames_Model_SmallGamesModel__Dispose(uVar6,uVar3,uVar7,0);
		  *(undefined4 *)(param1 + 0x14) = uVar6;
		  uVar7 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(Gameplay_SmallGames_Controller_SmallGamesController_TypeInfo);
		  Gameplay_SmallGames_Controller_SmallGamesController__Dispose(uVar3,uVar6,uVar7,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  uVar6 = *(undefined4 *)(param1 + 0x14);
		  param3 = *(undefined4 *)(param1 + 0x10);
		  uVar7 = unnamed_function_1417
		                    (Gameplay_SmallGames_Controller_SmallGamesEnterPointViewMediator_TypeInfo);
		  Gameplay_SmallGames_Controller_SmallGamesController__CheckIfNotificationsNeedToUpdate
		            (uVar7,uVar6,param3,uVar3,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar7;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Controller ---
		void Core_Gameplay_Managers_SmallGamesManager__get_Controller
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x1c),param2,*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/

}
