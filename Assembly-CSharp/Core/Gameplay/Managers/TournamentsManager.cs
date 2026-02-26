using System;
using System.Runtime.CompilerServices;
using Gameplay.Tournaments.Controller;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117D RID: 4477
	[Token(Token = "0x200117D")]
	public class TournamentsManager : IGameManager, IBaseManager
	{
		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06006A13 RID: 27155 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B5")]
		public string Name
		{
			[Token(Token = "0x6006A13")]
			[Address(RVA = "0xB533", Offset = "0xB533", VA = "0xB533", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002A6 RID: 678
		// (add) Token: 0x06006A14 RID: 27156 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A15 RID: 27157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A6")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A14")]
			[Address(RVA = "0xB534", Offset = "0xB534", VA = "0xB534", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A15")]
			[Address(RVA = "0xB535", Offset = "0xB535", VA = "0xB535", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A7 RID: 679
		// (add) Token: 0x06006A16 RID: 27158 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A17 RID: 27159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A7")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A16")]
			[Address(RVA = "0xB536", Offset = "0xB536", VA = "0xB536", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A17")]
			[Address(RVA = "0xB537", Offset = "0xB537", VA = "0xB537", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06006A18 RID: 27160 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A19 RID: 27161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B6")]
		public TournamentsController Controller
		{
			[Token(Token = "0x6006A18")]
			[Address(RVA = "0xB538", Offset = "0xB538", VA = "0xB538")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A19")]
			[Address(RVA = "0xB539", Offset = "0xB539", VA = "0xB539")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1A")]
		[Address(RVA = "0xB53A", Offset = "0xB53A", VA = "0xB53A", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_TournamentsManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a63861 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Controller_TournamentsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Events_TournamentsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Model_TournamentsModel_TypeInfo);
		    DAT_ram_00a63861 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Tournaments_Events_TournamentsEvents_TypeInfo);
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
		        goto code_r0x8230976d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8230976d:
		  uVar2 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  if (*(int *)(iVar4 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar4 + 0x14) + 8);
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Tournaments_Model_TournamentsModel_TypeInfo);
		  Gameplay_Tournaments_Model_TournamentsModel__get_Dict(param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  param3 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(Gameplay_Tournaments_Controller_TournamentsController_TypeInfo);
		  Gameplay_Tournaments_Controller_TournamentProgressViewMediator___c__DisplayClass51_0___DisplayOpponentName_b__0
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

		// Token: 0x06006A1B RID: 27163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0xB53B", Offset = "0xB53B", VA = "0xB53B", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		undefined4 Core_Gameplay_Managers_TournamentsManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a63862 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_TournamentsWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_View_TournamentsWindow_TournamentsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12675);
		    DAT_ram_00a63862 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Tournaments_View_TournamentsWindow_TournamentsWindowArgs_TypeInfo)
		  ;
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12675,param1_00,
		                     Method_UI_Windows_PopupController_Show_TournamentsWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006A1C")]
		[Address(RVA = "0xB53C", Offset = "0xB53C", VA = "0xB53C")]
		public TournamentsWindow ShowTournamentWindow()
		{
		/* --- GHIDRA: ShowTournamentWindow ---
		void Core_Gameplay_Managers_TournamentsManager__ShowTournamentWindow(int param1,undefined4 param2)
		
		{
		  Gameplay_Tournaments_Controller_TournamentsController__UnsubscribeResultHandler
		            (*(undefined4 *)(param1 + 0x18),0);
		  Gameplay_Tournaments_Controller_TournamentsController___ctor(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1D")]
		[Address(RVA = "0xB53D", Offset = "0xB53D", VA = "0xB53D")]
		public void ReconnectToCombat()
		{
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A1E")]
		[Address(RVA = "0xB53E", Offset = "0xB53E", VA = "0xB53E")]
		public TournamentsManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_TournamentsManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63863 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_17356);
		    DAT_ram_00a63863 = '\x01';
		  }
		  return StringLiteral_17356;
		}
		*/

		}

		// Token: 0x04003832 RID: 14386
		[Token(Token = "0x4003832")]
		[FieldOffset(Offset = "0x10")]
		private TournamentsEvents _events;

		// Token: 0x04003833 RID: 14387
		[Token(Token = "0x4003833")]
		[FieldOffset(Offset = "0x14")]
		private TournamentsModel _model;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_TournamentsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6385d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6385d = '\x01';
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
		void Core_Gameplay_Managers_TournamentsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6385e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6385e = '\x01';
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
		void Core_Gameplay_Managers_TournamentsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6385f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6385f = '\x01';
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
		void Core_Gameplay_Managers_TournamentsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63860 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63860 = '\x01';
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
		void Core_Gameplay_Managers_TournamentsManager__set_Controller(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x18),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
