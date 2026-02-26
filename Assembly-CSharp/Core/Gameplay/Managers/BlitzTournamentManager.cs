using System;
using System.Runtime.CompilerServices;
using Gameplay.BlitzTournament.Controller;
using Gameplay.BlitzTournament.Events;
using Gameplay.BlitzTournament.Model;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001144 RID: 4420
	[Token(Token = "0x2001144")]
	public class BlitzTournamentManager : IGameManager, IBaseManager
	{
		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060067DC RID: 26588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001547")]
		public string Name
		{
			[Token(Token = "0x60067DC")]
			[Address(RVA = "0xB308", Offset = "0xB308", VA = "0xB308", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000264 RID: 612
		// (add) Token: 0x060067DD RID: 26589 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067DE RID: 26590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000264")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067DD")]
			[Address(RVA = "0xB309", Offset = "0xB309", VA = "0xB309", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067DE")]
			[Address(RVA = "0xB30A", Offset = "0xB30A", VA = "0xB30A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000265 RID: 613
		// (add) Token: 0x060067DF RID: 26591 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067E0 RID: 26592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000265")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067DF")]
			[Address(RVA = "0xB30B", Offset = "0xB30B", VA = "0xB30B", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067E0")]
			[Address(RVA = "0xB30C", Offset = "0xB30C", VA = "0xB30C", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060067E1 RID: 26593 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067E2 RID: 26594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001548")]
		public BlitzTournamentController Controller
		{
			[Token(Token = "0x60067E1")]
			[Address(RVA = "0xB30D", Offset = "0xB30D", VA = "0xB30D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067E2")]
			[Address(RVA = "0xB30E", Offset = "0xB30E", VA = "0xB30E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E3")]
		[Address(RVA = "0xB30F", Offset = "0xB30F", VA = "0xB30F", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_BlitzTournamentManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5a9ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Controller_BlitzTournamentController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_Events_BlitzTournamentEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_Model_BlitzTournamentModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a9ad = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_BlitzTournament_Events_BlitzTournamentEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x812a1ae7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a1ae7:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  param1_00 = unnamed_function_1417(Gameplay_BlitzTournament_Model_BlitzTournamentModel_TypeInfo);
		  Gameplay_BlitzTournament_Model_BlitzTournamentModel__set_RoundsCount(param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  param3 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_BlitzTournament_Controller_BlitzTournamentController_TypeInfo);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentCombatMediator__ReturnToTournament
		            (uVar2,param1_00,param3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  MVC_AbstractController__Dispose(uVar2,0);
		  iVar4 = *(int *)(param1 + 8);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E4")]
		[Address(RVA = "0xB310", Offset = "0xB310", VA = "0xB310", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		undefined4
		Core_Gameplay_Managers_BlitzTournamentManager__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a9ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_BlitzTournament_View_BlitzTournamentWindow_BlitzTournamentWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BlitzTournamentWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12576);
		    DAT_ram_00a5a9ae = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_BlitzTournament_View_BlitzTournamentWindow_BlitzTournamentWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12576,param1_00,
		                     Method_UI_Windows_PopupController_Show_BlitzTournamentWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60067E5")]
		[Address(RVA = "0xB311", Offset = "0xB311", VA = "0xB311")]
		public BlitzTournamentWindow ShowBlitzTournamentWindow(BlitzTournamentWindow.WindowState windowState = BlitzTournamentWindow.WindowState.Default)
		{
		/* --- GHIDRA: ShowBlitzTournamentWindow ---
		void Core_Gameplay_Managers_BlitzTournamentManager__ShowBlitzTournamentWindow
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController__ResolveTournamentState
		            (*(undefined4 *)(param1 + 0x18),0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController___ctor
		            (*(undefined4 *)(param1 + 0x18),0);
		  Gameplay_BlitzTournament_Controller_BlitzTournamentController__GetTournamentInfoResultHandler
		            (*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E6")]
		[Address(RVA = "0xB312", Offset = "0xB312", VA = "0xB312")]
		public void ReconnectToCombat()
		{
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067E7")]
		[Address(RVA = "0xB313", Offset = "0xB313", VA = "0xB313")]
		public BlitzTournamentManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_BlitzTournamentManager___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9af = '\x01';
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

		}

		// Token: 0x04003763 RID: 14179
		[Token(Token = "0x4003763")]
		[FieldOffset(Offset = "0x10")]
		private BlitzTournamentEvents _events;

		// Token: 0x04003764 RID: 14180
		[Token(Token = "0x4003764")]
		[FieldOffset(Offset = "0x14")]
		private BlitzTournamentModel _model;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_BlitzTournamentManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9a9 = '\x01';
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
		void Core_Gameplay_Managers_BlitzTournamentManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9aa = '\x01';
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
		void Core_Gameplay_Managers_BlitzTournamentManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9ab = '\x01';
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
		void Core_Gameplay_Managers_BlitzTournamentManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9ac = '\x01';
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

}
