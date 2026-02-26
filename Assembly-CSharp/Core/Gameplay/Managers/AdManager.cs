using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Statistics;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113D RID: 4413
	[Token(Token = "0x200113D")]
	public class AdManager : IGameManager, IBaseManager
	{
		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06006768 RID: 26472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152B")]
		public string Name
		{
			[Token(Token = "0x6006768")]
			[Address(RVA = "0xB294", Offset = "0xB294", VA = "0xB294", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000256 RID: 598
		// (add) Token: 0x06006769 RID: 26473 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600676A RID: 26474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000256")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006769")]
			[Address(RVA = "0xB295", Offset = "0xB295", VA = "0xB295", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600676A")]
			[Address(RVA = "0xB296", Offset = "0xB296", VA = "0xB296", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000257 RID: 599
		// (add) Token: 0x0600676B RID: 26475 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600676C RID: 26476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000257")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600676B")]
			[Address(RVA = "0xB297", Offset = "0xB297", VA = "0xB297", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600676C")]
			[Address(RVA = "0xB298", Offset = "0xB298", VA = "0xB298", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600676D RID: 26477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152C")]
		public AbstractAdController Controller
		{
			[Token(Token = "0x600676D")]
			[Address(RVA = "0xB299", Offset = "0xB299", VA = "0xB299")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x0600676E RID: 26478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152D")]
		public AbstractAdModel Model
		{
			[Token(Token = "0x600676E")]
			[Address(RVA = "0xB29A", Offset = "0xB29A", VA = "0xB29A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700152E")]
		public AdEvents Events
		{
			[Token(Token = "0x600676F")]
			[Address(RVA = "0xB29B", Offset = "0xB29B", VA = "0xB29B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006770")]
		[Address(RVA = "0xB29C", Offset = "0xB29C", VA = "0xB29C", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_AdManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x1c) != 0) {
		    Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper__TransactionCreatedEvent
		              (*(int *)(param1 + 0x1c),0);
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  Core_Gameplay_Managers_AdManager__InitEvent(param1,param1);
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006771 RID: 26481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006771")]
		[Address(RVA = "0xB29D", Offset = "0xB29D", VA = "0xB29D", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_AdManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param4;
		  undefined4 param3;
		  int iVar7;
		  
		  if (DAT_ram_00a5a968 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_WebGL_AdController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Events_AdEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AdManager_InitEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Model_WebGL_AdModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a968 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar2 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Events_AdEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x18) = uVar2;
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
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x8129d1e1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8129d1e1:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar2 = func_ii_7112(uVar2,0);
		    uVar4 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel_TypeInfo);
		    Core_Gameplay_Managers_Ad_Model_AdTransaction__ToString(uVar4,piVar5,uVar2,0);
		    *(undefined4 *)(param1 + 0x14) = uVar4;
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    param4 = *(undefined4 *)(param1 + 0x18);
		    param3 = *(undefined4 *)(param1 + 0x14);
		    uVar4 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Controller_WebGL_AdController_TypeInfo);
		    Core_Gameplay_Managers_Ad_Controller_AbstractAdController__InitializeAdProviders_d__7__SetStateMachine
		              (uVar4,uVar2,param3,param4,0);
		    *(undefined4 *)(param1 + 0x10) = uVar4;
		    iVar7 = *(int *)(param1 + 0x18);
		    uVar4 = *(undefined4 *)(iVar7 + 8);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Core_Gameplay_Managers_AdManager_InitEvent__,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		    iVar6 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar7 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar7 + 8) = piVar5, *piVar5 != iVar6)) {
		      System_Activator__CreateInstance(piVar5,iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006772")]
		[Address(RVA = "0xB29E", Offset = "0xB29E", VA = "0xB29E")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_AdManager__SetupMvc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a969 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AdManager_InitEvent__);
		    DAT_ram_00a5a969 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_AdManager_InitEvent__,0);
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

		// Token: 0x06006773 RID: 26483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006773")]
		[Address(RVA = "0xB29F", Offset = "0xB29F", VA = "0xB29F")]
		private void InitEvent()
		{
		/* --- GHIDRA: InitEvent ---
		void Core_Gameplay_Managers_AdManager__InitEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a96a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AdManager_InitEvent__);
		    DAT_ram_00a5a96a = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    iVar1 = *(int *)(param1 + 0x18);
		    param1_02 = *(undefined4 *)(iVar1 + 8);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_Core_Gameplay_Managers_AdManager_InitEvent__,0);
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
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xec));
		    *(undefined4 *)(param1 + 0x18) = 0;
		    *(undefined8 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006774 RID: 26484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006774")]
		[Address(RVA = "0xB2A0", Offset = "0xB2A0", VA = "0xB2A0")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006775")]
		[Address(RVA = "0xB2A1", Offset = "0xB2A1", VA = "0xB2A1")]
		public AdManager()
		{
		}

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x10")]
		private AbstractAdController _controller;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x14")]
		private AbstractAdModel _model;

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		[FieldOffset(Offset = "0x18")]
		private AdEvents _events;

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x1C")]
		private AdStatisticsHelper _statisticsHelper;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_AdManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a963 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a963 = '\x01';
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
		void Core_Gameplay_Managers_AdManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a964 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a964 = '\x01';
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
		void Core_Gameplay_Managers_AdManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a965 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a965 = '\x01';
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
		void Core_Gameplay_Managers_AdManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a966 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a966 = '\x01';
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


		/* --- GHIDRA: get_Events ---
		void Core_Gameplay_Managers_AdManager__get_Events(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a967 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TypeInfo);
		    DAT_ram_00a5a967 = '\x01';
		  }
		  Core_Gameplay_Managers_AdManager__Deinit(param1,param1);
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Ad_Statistics_AdStatisticsHelper_TypeInfo);
		  Core_Gameplay_Managers_Audio_TutorialAudioManager__Init(param1_00,param1,0);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

}
