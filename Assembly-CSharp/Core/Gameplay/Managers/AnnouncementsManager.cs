using System;
using System.Runtime.CompilerServices;
using Gameplay.Announcements.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113E RID: 4414
	[Token(Token = "0x200113E")]
	public class AnnouncementsManager : IGameManager, IBaseManager
	{
		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006777 RID: 26487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700152F")]
		public IGame Game
		{
			[Token(Token = "0x6006776")]
			[Address(RVA = "0xB2A2", Offset = "0xB2A2", VA = "0xB2A2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006777")]
			[Address(RVA = "0xB2A3", Offset = "0xB2A3", VA = "0xB2A3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001530")]
		public string Name
		{
			[Token(Token = "0x6006778")]
			[Address(RVA = "0xB2A4", Offset = "0xB2A4", VA = "0xB2A4", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000258 RID: 600
		// (add) Token: 0x06006779 RID: 26489 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600677A RID: 26490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000258")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006779")]
			[Address(RVA = "0xB2A5", Offset = "0xB2A5", VA = "0xB2A5", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600677A")]
			[Address(RVA = "0xB2A6", Offset = "0xB2A6", VA = "0xB2A6", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000259 RID: 601
		// (add) Token: 0x0600677B RID: 26491 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600677C RID: 26492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000259")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600677B")]
			[Address(RVA = "0xB2A7", Offset = "0xB2A7", VA = "0xB2A7", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600677C")]
			[Address(RVA = "0xB2A8", Offset = "0xB2A8", VA = "0xB2A8", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677D")]
		[Address(RVA = "0xB2A9", Offset = "0xB2A9", VA = "0xB2A9")]
		public AnnouncementsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_AnnouncementsManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param4;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param5;
		  undefined4 param6;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int iVar8;
		  undefined4 param4_00;
		  
		  if (DAT_ram_00a5a970 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Announcements_Control_AnnouncementsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Announcements_AnnouncementsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_AnnouncementsManager_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Announcements_Model_AnnouncementsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_AnnouncementsService___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a970 = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_Announcements_AnnouncementsEvents_TypeInfo);
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_Args_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(iVar2,7,0);
		  *(undefined8 *)(iVar2 + 8) = 0x7fffffff;
		  piVar7 = *(int **)(param1 + 8);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x8129d80f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129d80f:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  piVar7 = *(int **)(param1 + 8);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x2b0);
		        goto code_r0x8129d894;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x3e);
		code_r0x8129d894:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  piVar7 = *(int **)(param1 + 8);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8129d919;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8129d919:
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  param4_00 = *(undefined4 *)(iVar8 + 8);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 8);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x208);
		        goto code_r0x8129d9a1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x29);
		code_r0x8129d9a1:
		  uVar1 = 0;
		  param5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  piVar7 = *(int **)(param1 + 8);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x8129da26;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8129da26:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar1 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		        goto code_r0x8129daa6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,5);
		code_r0x8129daa6:
		  uVar1 = 0;
		  param6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  piVar7 = *(int **)(param1 + 8);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		        goto code_r0x8129db2b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8129db2b:
		  uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar6 = func_ii_7112(uVar6,0);
		  param1_00 = unnamed_function_1417(Gameplay_Announcements_Model_AnnouncementsModel_TypeInfo);
		  Gameplay_Announcements_Model_AnnouncementsModel__Dispose
		            (param1_00,uVar4,uVar5,param4_00,param5,param6,iVar2,uVar6,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_AnnouncementsService___);
		  uVar5 = unnamed_function_1417(Gameplay_Announcements_Control_AnnouncementsController_TypeInfo);
		  Gameplay_Announcements_Control_AnnouncementsController__Dispose(uVar5,uVar4,param1_00,param4,0);
		  *(undefined4 *)(param1 + 0x14) = uVar5;
		  uVar5 = *(undefined4 *)(param4 + 8);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,Method_Core_Gameplay_Managers_AnnouncementsManager_HandleInitEvent__,0);
		  piVar7 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar4,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(param4 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar7) || (*(int **)(param4 + 8) = piVar7, *piVar7 != iVar2)
		          ) {
		    System_Activator__CreateInstance(piVar7,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x0600677E RID: 26494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677E")]
		[Address(RVA = "0xB2AA", Offset = "0xB2AA", VA = "0xB2AA", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_AnnouncementsManager__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x14);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x104));
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xec));
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  iVar2 = *(int *)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600677F RID: 26495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677F")]
		[Address(RVA = "0xB2AB", Offset = "0xB2AB", VA = "0xB2AB", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_AnnouncementsManager__Deinit(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a971 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_AnnouncementsManager_HandleInitEvent__);
		    DAT_ram_00a5a971 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_AnnouncementsManager_HandleInitEvent__,0
		            );
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
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006780 RID: 26496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006780")]
		[Address(RVA = "0xB2AC", Offset = "0xB2AC", VA = "0xB2AC")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		undefined4
		Core_Gameplay_Managers_AnnouncementsManager__HandleInitEvent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a972 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3193);
		    DAT_ram_00a5a972 = '\x01';
		  }
		  return StringLiteral_3193;
		}
		*/

		}

		// Token: 0x0400373E RID: 14142
		[Token(Token = "0x400373E")]
		[FieldOffset(Offset = "0x14")]
		private AnnouncementsController _controller;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		undefined4
		Core_Gameplay_Managers_AnnouncementsManager__set_Game(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a96b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3142);
		    DAT_ram_00a5a96b = '\x01';
		  }
		  return StringLiteral_3142;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_AnnouncementsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a96c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a96c = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_AnnouncementsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a96d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a96d = '\x01';
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_AnnouncementsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a96e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a96e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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
		void Core_Gameplay_Managers_AnnouncementsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a96f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a96f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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
