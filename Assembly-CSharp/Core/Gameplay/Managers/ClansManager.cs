using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Money;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Events;
using Gameplay.Clans.Model;
using Gameplay.Clans.Office.View;
using Gameplay.World.Controller;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200114A RID: 4426
	[Token(Token = "0x200114A")]
	public class ClansManager : IGameManager, IBaseManager
	{
		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700155B")]
		public string Name
		{
			[Token(Token = "0x6006835")]
			[Address(RVA = "0xB361", Offset = "0xB361", VA = "0xB361", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400026E RID: 622
		// (add) Token: 0x06006836 RID: 26678 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006837 RID: 26679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006836")]
			[Address(RVA = "0xB362", Offset = "0xB362", VA = "0xB362", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006837")]
			[Address(RVA = "0xB363", Offset = "0xB363", VA = "0xB363", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400026F RID: 623
		// (add) Token: 0x06006838 RID: 26680 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006839 RID: 26681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006838")]
			[Address(RVA = "0xB364", Offset = "0xB364", VA = "0xB364", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006839")]
			[Address(RVA = "0xB365", Offset = "0xB365", VA = "0xB365", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x0600683A RID: 26682 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600683B RID: 26683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700155C")]
		public ClansModel Model
		{
			[Token(Token = "0x600683A")]
			[Address(RVA = "0xB366", Offset = "0xB366", VA = "0xB366")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600683B")]
			[Address(RVA = "0xB367", Offset = "0xB367", VA = "0xB367")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600683D RID: 26685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700155D")]
		public ClansEvents Events
		{
			[Token(Token = "0x600683C")]
			[Address(RVA = "0xB368", Offset = "0xB368", VA = "0xB368")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600683D")]
			[Address(RVA = "0xB369", Offset = "0xB369", VA = "0xB369")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600683E RID: 26686 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600683F RID: 26687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700155E")]
		public ClansController Controller
		{
			[Token(Token = "0x600683E")]
			[Address(RVA = "0xB36A", Offset = "0xB36A", VA = "0xB36A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600683F")]
			[Address(RVA = "0xB36B", Offset = "0xB36B", VA = "0xB36B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x1700155F")]
		public uint LeagueId
		{
			[Token(Token = "0x6006840")]
			[Address(RVA = "0xB36C", Offset = "0xB36C", VA = "0xB36C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006841")]
		[Address(RVA = "0xB36D", Offset = "0xB36D", VA = "0xB36D", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ClansManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x18),0);
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x18) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006842 RID: 26690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006842")]
		[Address(RVA = "0xB36E", Offset = "0xB36E", VA = "0xB36E", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ClansManager__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a9de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClansManager_HandleControllerInitEvent__);
		    DAT_ram_00a5a9de = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_ClansManager_HandleControllerInitEvent__
		             ,0);
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

		// Token: 0x06006843 RID: 26691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006843")]
		[Address(RVA = "0xB36F", Offset = "0xB36F", VA = "0xB36F")]
		private void HandleControllerInitEvent()
		{
		/* --- GHIDRA: HandleControllerInitEvent ---
		void Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a5a9df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_ClanOfficeWindow_ClanOfficeWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_IWorldMovementProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ClanOfficeWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12597);
		    DAT_ram_00a5a9df = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(*(int *)(param1 + 0x10) + 8) + 0x68);
		  if (iVar5 != 0) {
		    Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		              (param1,*(undefined8 *)(*(int *)(iVar5 + 0x1c) + 0x10),0,iVar5);
		    return;
		  }
		  uVar1 = 0;
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  iVar5 = unnamed_function_1417
		                    (Gameplay_Clans_Office_View_ClanOfficeWindow_ClanOfficeWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_World_Controller_IWorldMovementProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812a569a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_World_Controller_IWorldMovementProvider_TypeInfo,
		                                0);
		code_r0x812a569a:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,CONCAT44(in_register_20000014,puVar3[1]));
		  *(undefined4 *)(iVar5 + 0x18) = uVar4;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12597,iVar5,
		             Method_UI_Windows_PopupController_Show_ClanOfficeWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006844 RID: 26692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006844")]
		[Address(RVA = "0xB370", Offset = "0xB370", VA = "0xB370")]
		public void ShowClanOfficeWindow()
		{
		/* --- GHIDRA: ShowClanOfficeWindow ---
		void Core_Gameplay_Managers_ClansManager__ShowClanOfficeWindow(int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Controller_ClansController___ctor(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006845")]
		[Address(RVA = "0xB371", Offset = "0xB371", VA = "0xB371")]
		public void AssignClanToUser()
		{
		/* --- GHIDRA: AssignClanToUser ---
		void Core_Gameplay_Managers_ClansManager__AssignClanToUser(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a9e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_ClanInfoWindow___);
		    DAT_ram_00a5a9e0 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x812a58e9;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812a58e9:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  if (*(int *)(*(int *)(iVar4 + 0x14) + 0x1c) == 2) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar5 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x140);
		          goto code_r0x812a59a0;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a59a0:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		    iVar4 = func_ii_7112(uVar2,0);
		    if (*(int *)(*(int *)(iVar4 + 0x34) + 0x40) != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar5 = 0;
		      piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar4 = *piVar3;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x140);
		            goto code_r0x812a5a58;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a5a58:
		      uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		      iVar4 = func_ii_7112(uVar2,0);
		      if (*(longlong *)(*(int *)(*(int *)(iVar4 + 0x34) + 0x40) + 0x10) !=
		          *(longlong *)(*(int *)(param1 + 0x10) + 0x10)) goto code_r0x812a5b35;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar5 = 0;
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x110);
		          goto code_r0x812a5b1d;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812a5b1d:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		    Core_Gameplay_Managers_WorldManager__TryRequestMonsterForCurrentUserIsle(uVar2,0);
		  }
		code_r0x812a5b35:
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar2,0,Method_UI_Windows_PopupController_Close_ClanInfoWindow___);
		  Gameplay_Clans_Model_ClansModel__SetClanId(*(undefined4 *)(param1 + 0x10),0);
		  Gameplay_Clans_Controller_ClansController__AssignNewClanToUser(*(undefined4 *)(param1 + 0x18),0);
		  iVar4 = *(int *)(*(int *)(param1 + 0x14) + 0x18);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006846")]
		[Address(RVA = "0xB372", Offset = "0xB372", VA = "0xB372")]
		public void DissociateClanFromUser()
		{
		/* --- GHIDRA: DissociateClanFromUser ---
		void Core_Gameplay_Managers_ClansManager__DissociateClanFromUser
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar5;
		  undefined4 uVar6;
		  
		  uVar2 = param2;
		  if (DAT_ram_00a5a9e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_ClanInfoWindow_ClanInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ClanInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12596);
		    DAT_ram_00a5a9e1 = '\x01';
		  }
		  uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  param3_00 = *(undefined4 *)(param1 + 0x18);
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
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x240);
		        goto code_r0x812a57c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x812a57c7:
		  iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar6,puVar4[1]));
		  uVar6 = *(undefined4 *)(iVar5 + 0x18);
		  iVar5 = unnamed_function_1417
		                    (Gameplay_Clans_Office_View_ClanInfoWindow_ClanInfoWindowArgs_TypeInfo);
		  Gameplay_Clans_Office_View_ClanInfoWindow___ctor(iVar5,param2,param3_00,uVar6,0);
		  *(undefined4 *)(iVar5 + 0x2c) = param3;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar3,StringLiteral_12596,iVar5,
		             Method_UI_Windows_PopupController_Show_ClanInfoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006847")]
		[Address(RVA = "0xB373", Offset = "0xB373", VA = "0xB373")]
		public void ShowClanInfoWindow(ulong clanId, ClanInfoWindow.Tab tabToOpen = ClanInfoWindow.Tab.INFO)
		{
		/* --- GHIDRA: ShowClanInfoWindow ---
		undefined4
		Core_Gameplay_Managers_ClansManager__ShowClanInfoWindow
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Gameplay_World_Model_ClanData__GetIsFraction(param3,param2,0);
		  if (iVar1 != 0) {
		    uVar2 = Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		                      (*(undefined4 *)(param1 + 0x10),0);
		    uVar2 = Core_Extensions_Dict_DictExt__GetCult(uVar2,0x66,0);
		    uVar2 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId(uVar2,0);
		    return uVar2;
		  }
		  iVar1 = Gameplay_World_Model_ClanData__GetIsLeftHandClan(param3,param2,0);
		  uVar2 = Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (iVar1 == 0) {
		    uVar2 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType(uVar2,param2,0);
		    uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(uVar2,0);
		    return uVar2;
		  }
		  uVar2 = Core_Extensions_Dict_DictExt__GetCult(uVar2,0x65,0);
		  uVar2 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId(uVar2,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006848")]
		[Address(RVA = "0xB374", Offset = "0xB374", VA = "0xB374")]
		public string GetClanCultAssetId(uint clanCultId, uint clanFlags)
		{
		/* --- GHIDRA: GetClanCultAssetId ---
		undefined4
		Core_Gameplay_Managers_ClansManager__GetClanCultAssetId(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  int param1_00;
		  uint uVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a9e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CultDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_CultDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_CultDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CultDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CultDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClansManager___c__GetCultsByClan_b__31_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClansManager___c__GetCultsByClan_b__31_1__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		    DAT_ram_00a5a9e2 = '\x01';
		  }
		  iVar2 = Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		                    (*(undefined4 *)(param1 + 0x10),0);
		  param2_00 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType(iVar2,param2,0);
		  if (param2_00 != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_CultDic__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_CultDic___ctor__);
		    iVar2 = Method_System_Collections_Generic_List_CultDic__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    return param1_00;
		  }
		  uVar1 = 0;
		  if (param2 != 0x65) {
		    if (param2 == 0x66) {
		      uVar1 = *(undefined4 *)(iVar2 + 0x30);
		      if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		      }
		      puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		      iVar2 = puVar4[2];
		      if (iVar2 == 0) {
		        if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		          puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		        }
		        uVar5 = *puVar4;
		        iVar2 = unnamed_function_1417(System_Func_CultDic__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (iVar2,uVar5,
		                   Method_Core_Gameplay_Managers_ClansManager___c__GetCultsByClan_b__31_1__,0);
		        *(int *)(*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c) + 8) = iVar2;
		      }
		      uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar1,iVar2,Method_System_Linq_Enumerable_Where_CultDic___);
		      uVar1 = System_Linq_Enumerable__Select_object__object_
		                        (uVar1,Method_System_Linq_Enumerable_ToList_CultDic___);
		    }
		    return uVar1;
		  }
		  uVar1 = *(undefined4 *)(iVar2 + 0x30);
		  if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		  iVar2 = puVar4[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    iVar2 = unnamed_function_1417(System_Func_CultDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,uVar5,Method_Core_Gameplay_Managers_ClansManager___c__GetCultsByClan_b__31_0__,
		               0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c) + 4) = iVar2;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,iVar2,Method_System_Linq_Enumerable_Where_CultDic___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_CultDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006849")]
		[Address(RVA = "0xB375", Offset = "0xB375", VA = "0xB375")]
		public List<CultDic> GetCultsByClan(uint clanCultId)
		{
		/* --- GHIDRA: GetCultsByClan ---
		undefined4
		Core_Gameplay_Managers_ClansManager__GetCultsByClan(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = Gameplay_Clans_Combat_Control_ClanCombatViewMediator___HandleGameOver_b__6_0
		                    (*(undefined4 *)(param1 + 0x10),0);
		  param2_00 = 0x65;
		  if (3 < *(uint *)(param2 + 0xc)) {
		    param2_00 = 0x66;
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetCult(uVar1,param2_00,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600684A")]
		[Address(RVA = "0xB376", Offset = "0xB376", VA = "0xB376")]
		public ClanCultDic GetFractionByCult(CultDic cultDic)
		{
		/* --- GHIDRA: GetFractionByCult ---
		void Core_Gameplay_Managers_ClansManager__GetFractionByCult
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined8 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar3;
		  undefined4 param4;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a9e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_ClanInfoWindow_ClanInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ClanInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12596);
		    DAT_ram_00a5a9e3 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param2_00 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 0x10) + 8),0);
		  param3_00 = *(undefined4 *)(param1 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar4 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x240);
		        goto code_r0x812a5f5e;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x812a5f5e:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  param4 = *(undefined4 *)(iVar3 + 0x18);
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Clans_Office_View_ClanInfoWindow_ClanInfoWindowArgs_TypeInfo);
		  Gameplay_Clans_Office_View_ClanInfoWindow___ctor(iVar3,param2_00,param3_00,param4,0);
		  *(undefined4 *)(iVar3 + 0x2c) = 4;
		  *(undefined4 *)(iVar3 + 0x28) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12596,iVar3,
		             Method_UI_Windows_PopupController_Show_ClanInfoWindow___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684B")]
		[Address(RVA = "0xB377", Offset = "0xB377", VA = "0xB377")]
		public void OpenClanTreasury([Optional] Money deficientResources)
		{
		/* --- GHIDRA: OpenClanTreasury ---
		void Core_Gameplay_Managers_ClansManager__OpenClanTreasury
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a5a9e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_View_ClanInfoDialogWindow_ClanInfoDialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClansManager___c__ShowClanInfoPopupWindow_b__34_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClansManager___c__ShowClanInfoPopupWindow_b__34_1__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4299);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12595);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10755);
		    DAT_ram_00a5a9e4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanInfoDialogWindow_ClanInfoDialogWindowArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanInfoDialogWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x2c) = param2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4299,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = 0;
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs____ctor__
		            );
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10755,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = param2;
		  if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[3];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar4;
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		              (iVar5,uVar1,
		               Method_Core_Gameplay_Managers_ClansManager___c__ShowClanInfoPopupWindow_b__34_0__,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c) + 0xc) = iVar5;
		  }
		  *(int *)(iVar3 + 0x10) = iVar5;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_01 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = param2;
		  if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[4];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar4;
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__ClanData__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		              (iVar5,uVar1,
		               Method_Core_Gameplay_Managers_ClansManager___c__ShowClanInfoPopupWindow_b__34_1__,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c) + 0x10) = iVar5;
		  }
		  *(int *)(iVar3 + 0x10) = iVar5;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_01 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12595,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600684C RID: 26700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684C")]
		[Address(RVA = "0xB378", Offset = "0xB378", VA = "0xB378")]
		public void ShowClanInfoPopupWindow(ClanData data)
		{
		/* --- GHIDRA: ShowClanInfoPopupWindow ---
		undefined4
		Core_Gameplay_Managers_ClansManager__ShowClanInfoPopupWindow
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a9e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
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
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_ClansManager___c__DisplayClass35_0__ShowKickMemberConfirmationWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_ClansManager___c__DisplayClass35_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10749);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4312);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4308);
		    DAT_ram_00a5a9e5 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Gameplay_Managers_ClansManager___c__DisplayClass35_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10749,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4312,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                        (*(undefined4 *)(iVar1 + 0xc),0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25589,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4308,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Core_Gameplay_Managers_ClansManager___c__DisplayClass35_0__ShowKickMemberConfirmationWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(undefined4 *)(iVar4 + 0xc) = 2;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar3 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar3 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = iVar3;
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600684D")]
		[Address(RVA = "0xB379", Offset = "0xB379", VA = "0xB379")]
		public DialogWindow ShowKickMemberConfirmationWindow(UserData user)
		{
			return null;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684E")]
		[Address(RVA = "0xB37A", Offset = "0xB37A", VA = "0xB37A")]
		public ClansManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ClansManager___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a9e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		    DAT_ram_00a5a9e6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ClansManager___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_ClansManager___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private IWorldMovementProvider _worldMovement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ClansManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9d9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ClansManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9da = '\x01';
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
		void Core_Gameplay_Managers_ClansManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9db = '\x01';
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
		void Core_Gameplay_Managers_ClansManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9dc = '\x01';
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


		/* --- GHIDRA: set_Controller ---
		undefined4 Core_Gameplay_Managers_ClansManager__set_Controller(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)
		          (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x1c) + 0x10) + 0x3c) + 0xc);
		}
		*/


		/* --- GHIDRA: get_LeagueId ---
		void Core_Gameplay_Managers_ClansManager__get_LeagueId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param2_00;
		  int iVar7;
		  
		  if (DAT_ram_00a5a9dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Controller_ClansController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Events_ClansEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ClansManager_HandleControllerInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Model_ClansModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9dd = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x812a5363;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812a5363:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
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
		        goto code_r0x812a5412;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a5412:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Model_ClansModel_TypeInfo);
		  Gameplay_Clans_Model_ClansModel__get_IsHead(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_Clans_Events_ClansEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(Gameplay_Clans_Controller_ClansController_TypeInfo);
		  Gameplay_Clans_Events_ClansEvents___ctor(uVar4,param2_00,uVar3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  iVar7 = *(int *)(param1 + 0x14);
		  uVar4 = *(undefined4 *)(iVar7 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_ClansManager_HandleControllerInitEvent__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar7 + 8) = piVar5, *piVar5 != iVar6))
		  {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

}
