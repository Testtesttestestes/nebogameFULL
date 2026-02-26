using System;
using System.Runtime.CompilerServices;
using Gameplay.Battles.Controller;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001143 RID: 4419
	[Token(Token = "0x2001143")]
	public class BattlesManager : IGameManager, IBaseManager
	{
		// Token: 0x14000262 RID: 610
		// (add) Token: 0x060067D0 RID: 26576 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067D1 RID: 26577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000262")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067D0")]
			[Address(RVA = "0xB2FC", Offset = "0xB2FC", VA = "0xB2FC", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067D1")]
			[Address(RVA = "0xB2FD", Offset = "0xB2FD", VA = "0xB2FD", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000263 RID: 611
		// (add) Token: 0x060067D2 RID: 26578 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067D3 RID: 26579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000263")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067D2")]
			[Address(RVA = "0xB2FE", Offset = "0xB2FE", VA = "0xB2FE", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067D3")]
			[Address(RVA = "0xB2FF", Offset = "0xB2FF", VA = "0xB2FF", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001543")]
		public BattlesModel Model
		{
			[Token(Token = "0x60067D4")]
			[Address(RVA = "0xB300", Offset = "0xB300", VA = "0xB300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001544")]
		public BattlesEvents Events
		{
			[Token(Token = "0x60067D5")]
			[Address(RVA = "0xB301", Offset = "0xB301", VA = "0xB301")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001545")]
		public BattlesController Controller
		{
			[Token(Token = "0x60067D6")]
			[Address(RVA = "0xB302", Offset = "0xB302", VA = "0xB302")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D7")]
		[Address(RVA = "0xB303", Offset = "0xB303", VA = "0xB303", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_BattlesManager__Init(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  puVar1 = (undefined8 *)(param1 + 0x18);
		  MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		  iVar2 = **(int **)puVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x134));
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		  *puVar1 = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D8")]
		[Address(RVA = "0xB304", Offset = "0xB304", VA = "0xB304", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067D9")]
		[Address(RVA = "0xB305", Offset = "0xB305", VA = "0xB305")]
		public void SetView(UserInterfaceView view)
		{
		/* --- GHIDRA: SetView ---
		undefined4 Core_Gameplay_Managers_BattlesManager__SetView(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3834);
		    DAT_ram_00a5a9a7 = '\x01';
		  }
		  return StringLiteral_3834;
		}
		*/

		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060067DA RID: 26586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001546")]
		public string Name
		{
			[Token(Token = "0x60067DA")]
			[Address(RVA = "0xB306", Offset = "0xB306", VA = "0xB306", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067DB")]
		[Address(RVA = "0xB307", Offset = "0xB307", VA = "0xB307")]
		public BattlesManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_BattlesManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a9a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3919);
		    DAT_ram_00a5a9a8 = '\x01';
		  }
		  return StringLiteral_3919;
		}
		*/

		}

		// Token: 0x0400375D RID: 14173
		[Token(Token = "0x400375D")]
		[FieldOffset(Offset = "0x10")]
		private BattlesModel _model;

		// Token: 0x0400375E RID: 14174
		[Token(Token = "0x400375E")]
		[FieldOffset(Offset = "0x14")]
		private BattlesEvents _events;

		// Token: 0x0400375F RID: 14175
		[Token(Token = "0x400375F")]
		[FieldOffset(Offset = "0x18")]
		private BattlesController _controller;

		// Token: 0x04003760 RID: 14176
		[Token(Token = "0x4003760")]
		[FieldOffset(Offset = "0x1C")]
		private BattlesEntryPointViewMediator _entryPointViewMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_BattlesManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9a3 = '\x01';
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
		void Core_Gameplay_Managers_BattlesManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9a4 = '\x01';
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
		void Core_Gameplay_Managers_BattlesManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9a5 = '\x01';
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


		/* --- GHIDRA: get_Controller ---
		void Core_Gameplay_Managers_BattlesManager__get_Controller(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a5a9a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_Controller_BattlesController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Battles_Controller_BattlesEntryPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_Events_BattlesEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_Model_BattlesModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__5B3F9EC0646608DAE43294162F92F82B97E7011A2BFA51A25FE477D18BDC6B21
		              );
		    Mono_Security_ASN1__get_Item(&uint___TypeInfo);
		    DAT_ram_00a5a9a6 = '\x01';
		  }
		  uVar2 = Mono_Security_ASN1Convert__ToOid(uint___TypeInfo,4);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (uVar2,
		             Field__PrivateImplementationDetails__5B3F9EC0646608DAE43294162F92F82B97E7011A2BFA51A25FE477D18BDC6B21
		             ,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *param1_01;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x812a1473;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x812a1473:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x812a151f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a151f:
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x812a15cb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a15cb:
		  uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  uVar6 = func_ii_7112(uVar6,0);
		  param1_00 = unnamed_function_1417(Gameplay_Battles_Model_BattlesModel_TypeInfo);
		  Gameplay_Battles_View_ThemeDuelBattlesWndButton___ctor
		            (param1_00,uVar2,param1_01,uVar4,uVar5,uVar6,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  uVar2 = unnamed_function_1417(Gameplay_Battles_Events_BattlesEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(Gameplay_Battles_Controller_BattlesController_TypeInfo);
		  Gameplay_Battles_Events_BattlesEvents___ctor(uVar4,uVar5,uVar2,0);
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar6 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(Gameplay_Battles_Controller_BattlesEntryPointViewMediator_TypeInfo);
		  Gameplay_Battles_Controller_BattlesController__SetNotificationCount(uVar2,uVar5,uVar6,uVar4,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  iVar7 = *(int *)(param1 + 8);
		  if (iVar7 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		              (*(undefined4 *)(iVar7 + 0x20),param1,*(undefined4 *)(iVar7 + 0x14));
		  }
		  return;
		}
		*/

}
