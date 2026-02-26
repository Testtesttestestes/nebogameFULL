using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View;
using Gameplay.Combat;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001145 RID: 4421
	[Token(Token = "0x2001145")]
	public class BossManager : IGameManager, IBaseManager
	{
		// Token: 0x14000266 RID: 614
		// (add) Token: 0x060067E8 RID: 26600 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067E9 RID: 26601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000266")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067E8")]
			[Address(RVA = "0xB314", Offset = "0xB314", VA = "0xB314", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067E9")]
			[Address(RVA = "0xB315", Offset = "0xB315", VA = "0xB315", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000267 RID: 615
		// (add) Token: 0x060067EA RID: 26602 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067EB RID: 26603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000267")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067EA")]
			[Address(RVA = "0xB316", Offset = "0xB316", VA = "0xB316", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067EB")]
			[Address(RVA = "0xB317", Offset = "0xB317", VA = "0xB317", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001549")]
		public BossController Controller
		{
			[Token(Token = "0x60067EC")]
			[Address(RVA = "0xB318", Offset = "0xB318", VA = "0xB318")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700154A")]
		public BossEvents Events
		{
			[Token(Token = "0x60067ED")]
			[Address(RVA = "0xB319", Offset = "0xB319", VA = "0xB319")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700154B")]
		public BossModel Model
		{
			[Token(Token = "0x60067EE")]
			[Address(RVA = "0xB31A", Offset = "0xB31A", VA = "0xB31A")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EF")]
		[Address(RVA = "0xB31B", Offset = "0xB31B", VA = "0xB31B", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_BossManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a9b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_BossManager_InitEvent__);
		    DAT_ram_00a5a9b4 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_BossManager_InitEvent__,0);
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
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F0")]
		[Address(RVA = "0xB31C", Offset = "0xB31C", VA = "0xB31C")]
		private void InitEvent()
		{
		/* --- GHIDRA: InitEvent ---
		void Core_Gameplay_Managers_BossManager__InitEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a9b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Events_BossEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9b5 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x812a1fcf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a1fcf:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = unnamed_function_1417(Gameplay_Boss_Model_BossModel_TypeInfo);
		  Gameplay_Boss_Model_BossModel__set_Game(uVar4,param1_00,uVar3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_Boss_Events_BossEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  param2_00 = *(undefined4 *)(param1 + 0x18);
		  uVar4 = unnamed_function_1417(Gameplay_Boss_Controller_BossController_TypeInfo);
		  Gameplay_Boss_Controller_BossCaptainViewMediator__SetupView_d__8__SetStateMachine
		            (uVar4,param2_00,uVar3,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  return;
		}
		*/

		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F1")]
		[Address(RVA = "0xB31D", Offset = "0xB31D", VA = "0xB31D")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_BossManager__SetupMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined4 *)(param1 + 0x18) = 0;
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F2")]
		[Address(RVA = "0xB31E", Offset = "0xB31E", VA = "0xB31E")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		void Core_Gameplay_Managers_BossManager__DestroyMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined4 *)(param1 + 0x18) = 0;
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F3")]
		[Address(RVA = "0xB31F", Offset = "0xB31F", VA = "0xB31F", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_BossManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3962);
		    DAT_ram_00a5a9b6 = '\x01';
		  }
		  return StringLiteral_3962;
		}
		*/

		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060067F4 RID: 26612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700154C")]
		public string Name
		{
			[Token(Token = "0x60067F4")]
			[Address(RVA = "0xB320", Offset = "0xB320", VA = "0xB320", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F5")]
		[Address(RVA = "0xB321", Offset = "0xB321", VA = "0xB321")]
		public void ShowBossListWindow()
		{
		/* --- GHIDRA: ShowBossListWindow ---
		void Core_Gameplay_Managers_BossManager__ShowBossListWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_BossWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BossWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12581);
		    DAT_ram_00a5a9b8 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_View_BossWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param3;
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12581,param1_00,
		             Method_UI_Windows_PopupController_Show_BossWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F6")]
		[Address(RVA = "0xB322", Offset = "0xB322", VA = "0xB322")]
		public void ShowBossWindow(BossInstance bossInstance, BossWindowState tab = BossWindowState.CAPTAIN_STATE)
		{
		/* --- GHIDRA: ShowBossWindow ---
		void Core_Gameplay_Managers_BossManager__ShowBossWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_View_Rewarding_BossRewardingWindow_BossRewardingWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BossRewardingWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12580);
		    DAT_ram_00a5a9b9 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Boss_View_Rewarding_BossRewardingWindow_BossRewardingWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x20) = param4;
		  *(undefined4 *)(param1_00 + 0x1c) = param3;
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12580,param1_00,
		             Method_UI_Windows_PopupController_Show_BossRewardingWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: ShowBossWindow ---
		void Core_Gameplay_Managers_BossManager__ShowBossWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Boss_View_Rewarding_BossRewardingWindow_BossRewardingWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BossRewardingWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12580);
		    DAT_ram_00a5a9b9 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Boss_View_Rewarding_BossRewardingWindow_BossRewardingWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x20) = param4;
		  *(undefined4 *)(param1_00 + 0x1c) = param3;
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12580,param1_00,
		             Method_UI_Windows_PopupController_Show_BossRewardingWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F7")]
		[Address(RVA = "0xB323", Offset = "0xB323", VA = "0xB323")]
		public void ShowBossWindow(long instanceId, BossWindowState tab = BossWindowState.CAPTAIN_STATE)
		{
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F8")]
		[Address(RVA = "0xB324", Offset = "0xB324", VA = "0xB324")]
		public void ShowBossRewardingWindow(BossInstance bossInstance, List<ulong> teamIds, int selectedIndex = 0)
		{
		/* --- GHIDRA: ShowBossRewardingWindow ---
		void Core_Gameplay_Managers_BossManager__ShowBossRewardingWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_BossMinionWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BossMinionWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12579);
		    DAT_ram_00a5a9ba = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_View_BossMinionWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x24) = param4;
		  *(undefined4 *)(param1_00 + 0x20) = param3;
		  *(undefined4 *)(param1_00 + 0x1c) = param1;
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12579,param1_00,
		             Method_UI_Windows_PopupController_Show_BossMinionWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: ShowBossRewardingWindow ---
		void Core_Gameplay_Managers_BossManager__ShowBossRewardingWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_BossMinionWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BossMinionWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12579);
		    DAT_ram_00a5a9ba = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_View_BossMinionWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x24) = param4;
		  *(undefined4 *)(param1_00 + 0x20) = param3;
		  *(undefined4 *)(param1_00 + 0x1c) = param1;
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12579,param1_00,
		             Method_UI_Windows_PopupController_Show_BossMinionWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067F9")]
		[Address(RVA = "0xB325", Offset = "0xB325", VA = "0xB325")]
		public void ShowBossRewardingWindow(long instanceId, List<ulong> teamIds, int selectedIndex = 0)
		{
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FA")]
		[Address(RVA = "0xB326", Offset = "0xB326", VA = "0xB326")]
		public void ShowBossMinionWindow(ICombat combat, MonsterData monsterData, BackTime backTime)
		{
		/* --- GHIDRA: ShowBossMinionWindow ---
		int Core_Gameplay_Managers_BossManager__ShowBossMinionWindow
		              (int param1,int param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param4_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a9bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9bb = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		        goto code_r0x812a2513;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x812a2513:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812a2595;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x812a2595:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 != 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		          goto code_r0x812a263d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x812a263d:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		          goto code_r0x812a26bf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,3);
		code_r0x812a26bf:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  }
		  param3_00 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (param2 != 0) {
		    param3_00 = *(undefined4 *)(param2 + 8);
		  }
		  param4_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + 8);
		  uVar1 = 0;
		  piVar3 = (int *)unnamed_function_1417(Gameplay_BossCombat_BossCombat_TypeInfo);
		  Gameplay_BossCombat_BossCombat__InitMVC(piVar3,param2_00,param3_00,param4_00,param4_00,param3,0);
		  *param4 = piVar3;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x812a27a8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,2);
		code_r0x812a27a8:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    piVar3 = (int *)*param4;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x812a282c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x812a282c:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    piVar3 = (int *)*param4;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x812a28af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x812a28af:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    *param4 = 0;
		  }
		  return iVar4;
		}
		*/

		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00013860 File Offset: 0x00011A60
		[Token(Token = "0x60067FB")]
		[Address(RVA = "0xB327", Offset = "0xB327", VA = "0xB327")]
		public bool TryRunBossCombat(BossInstance bossInstance, BackTime backTime, out ICombat combat)
		{
		/* --- GHIDRA: TryRunBossCombat ---
		int Core_Gameplay_Managers_BossManager__TryRunBossCombat
		              (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a9bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9bc = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		        goto code_r0x812a29a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x812a29a7:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812a2a29;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x812a2a29:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 != 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x218);
		          goto code_r0x812a2ad1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x812a2ad1:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		          goto code_r0x812a2b53;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,3);
		code_r0x812a2b53:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + 8);
		  param2_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  piVar3 = (int *)unnamed_function_1417(Gameplay_BossCombat_BossMinionCombat_TypeInfo);
		  Gameplay_BossCombat_BossMinionCombat__InitMVC(piVar3,param2_00,param3_00,param3_00,param2,0);
		  *param3 = piVar3;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x812a2c2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,2);
		code_r0x812a2c2a:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    piVar3 = (int *)*param3;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x812a2cae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x812a2cae:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    piVar3 = (int *)*param3;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x812a2d31;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x812a2d31:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    *param3 = 0;
		  }
		  return iVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x60067FC")]
		[Address(RVA = "0xB328", Offset = "0xB328", VA = "0xB328")]
		public bool TryRunBossMinionCombat(BackTime backTime, out ICombat combat)
		{
			return default(bool);
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067FD")]
		[Address(RVA = "0xB329", Offset = "0xB329", VA = "0xB329")]
		public BossManager()
		{
		}

		// Token: 0x04003768 RID: 14184
		[Token(Token = "0x4003768")]
		[FieldOffset(Offset = "0x10")]
		private BossController _controller;

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x14")]
		private BossEvents _events;

		// Token: 0x0400376A RID: 14186
		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x18")]
		private BossModel _model;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_BossManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9b0 = '\x01';
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
		void Core_Gameplay_Managers_BossManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9b1 = '\x01';
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
		void Core_Gameplay_Managers_BossManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9b2 = '\x01';
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


		/* --- GHIDRA: get_Model ---
		void Core_Gameplay_Managers_BossManager__get_Model(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5a9b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_BossManager_InitEvent__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3963);
		    DAT_ram_00a5a9b3 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 0) {
		    Core_Gameplay_Managers_BossManager__InitEvent(param1,param1);
		    iVar1 = *(int *)(param1 + 0x14);
		    param1_02 = *(undefined4 *)(iVar1 + 8);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_Core_Gameplay_Managers_BossManager_InitEvent__,0);
		    param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		    param2_00 = System_Action_TypeInfo;
		    if (param1_01 == (int *)0x0) {
		      *(undefined4 *)(iVar1 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *param1_01) ||
		            (*(int **)(iVar1 + 8) = param1_01, *param1_01 != param2_00)) {
		      System_Activator__CreateInstance(param1_01,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		    return;
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(StringLiteral_3963,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_BossManager__get_Name(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_View_ListView_BossListWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BossListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12578);
		    DAT_ram_00a5a9b7 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_View_ListView_BossListWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x14);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12578,param1_00,
		             Method_UI_Windows_PopupController_Show_BossListWindow___);
		  return;
		}
		*/

}
