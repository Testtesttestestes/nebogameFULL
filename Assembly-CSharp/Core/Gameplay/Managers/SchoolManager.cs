using System;
using System.Runtime.CompilerServices;
using Gameplay.MageSchool.Events;
using Gameplay.School.Controller;
using Gameplay.School.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001176 RID: 4470
	[Token(Token = "0x2001176")]
	public class SchoolManager : IGameManager, IBaseManager
	{
		// Token: 0x14000298 RID: 664
		// (add) Token: 0x060069B1 RID: 27057 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069B2 RID: 27058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000298")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069B1")]
			[Address(RVA = "0xB4D1", Offset = "0xB4D1", VA = "0xB4D1", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069B2")]
			[Address(RVA = "0xB4D2", Offset = "0xB4D2", VA = "0xB4D2", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000299 RID: 665
		// (add) Token: 0x060069B3 RID: 27059 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069B4 RID: 27060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000299")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069B3")]
			[Address(RVA = "0xB4D3", Offset = "0xB4D3", VA = "0xB4D3", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069B4")]
			[Address(RVA = "0xB4D4", Offset = "0xB4D4", VA = "0xB4D4", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x060069B5 RID: 27061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700159F")]
		public SchoolEvents Events
		{
			[Token(Token = "0x60069B5")]
			[Address(RVA = "0xB4D5", Offset = "0xB4D5", VA = "0xB4D5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x060069B6 RID: 27062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A0")]
		public SchoolModel Model
		{
			[Token(Token = "0x60069B6")]
			[Address(RVA = "0xB4D6", Offset = "0xB4D6", VA = "0xB4D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x060069B7 RID: 27063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A1")]
		public SchoolController Controller
		{
			[Token(Token = "0x60069B7")]
			[Address(RVA = "0xB4D7", Offset = "0xB4D7", VA = "0xB4D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0xB4D8", Offset = "0xB4D8", VA = "0xB4D8", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_SchoolManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a63829 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_SchoolManager_ControllerInitEvent__)
		    ;
		    DAT_ram_00a63829 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_SchoolManager_ControllerInitEvent__,0);
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

		// Token: 0x060069B9 RID: 27065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B9")]
		[Address(RVA = "0xB4D9", Offset = "0xB4D9", VA = "0xB4D9")]
		private void ControllerInitEvent()
		{
		/* --- GHIDRA: ControllerInitEvent ---
		void Core_Gameplay_Managers_SchoolManager__ControllerInitEvent(int param1,undefined4 param2)
		
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
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060069BA RID: 27066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BA")]
		[Address(RVA = "0xB4DA", Offset = "0xB4DA", VA = "0xB4DA", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_SchoolManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a6382a == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_MageSchool_Events_SchoolEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2017);
		    DAT_ram_00a6382a = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    if (DAT_ram_00a6382b == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_14087);
		      DAT_ram_00a6382b = '\x01';
		    }
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_14087,StringLiteral_2017,0)
		    ;
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar3,0);
		    return;
		  }
		  uVar3 = unnamed_function_1417(Gameplay_MageSchool_Events_SchoolEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
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
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x82306ab2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82306ab2:
		  uVar3 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    uVar3 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
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
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x82306b6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82306b6f:
		  uVar2 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
		  }
		  iVar6 = unnamed_function_1417(Gameplay_School_Model_SchoolModel_TypeInfo);
		  Gameplay_School_Model_SchoolModel__get_Dict(iVar6,uVar3,uVar2,0);
		  *(int *)(param1 + 0x14) = iVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x248);
		        goto code_r0x82306c4a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x82306c4a:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  *(undefined4 *)(iVar6 + 0xc) = uVar3;
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417(Gameplay_School_Controller_SchoolController_TypeInfo);
		  Gameplay_School_Controller_SchoolController__Dispose(uVar3,param2_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x060069BB RID: 27067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BB")]
		[Address(RVA = "0xB4DB", Offset = "0xB4DB", VA = "0xB4DB")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_SchoolManager__SetupMvc(int param1,undefined4 param2)
		
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
		  return;
		}
		*/

		}

		// Token: 0x060069BC RID: 27068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BC")]
		[Address(RVA = "0xB4DC", Offset = "0xB4DC", VA = "0xB4DC")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		undefined4 Core_Gameplay_Managers_SchoolManager__DestroyMvc(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6382b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14087);
		    DAT_ram_00a6382b = '\x01';
		  }
		  return StringLiteral_14087;
		}
		*/

		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x060069BD RID: 27069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A2")]
		public string Name
		{
			[Token(Token = "0x60069BD")]
			[Address(RVA = "0xB4DD", Offset = "0xB4DD", VA = "0xB4DD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069BE")]
		[Address(RVA = "0xB4DE", Offset = "0xB4DE", VA = "0xB4DE")]
		public SchoolManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_SchoolManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6382c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14237);
		    DAT_ram_00a6382c = '\x01';
		  }
		  return StringLiteral_14237;
		}
		*/

		}

		// Token: 0x04003810 RID: 14352
		[Token(Token = "0x4003810")]
		[FieldOffset(Offset = "0x10")]
		private SchoolEvents _events;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[FieldOffset(Offset = "0x14")]
		private SchoolModel _model;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0x18")]
		private SchoolController _controller;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_SchoolManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63825 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63825 = '\x01';
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
		void Core_Gameplay_Managers_SchoolManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63826 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63826 = '\x01';
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
		void Core_Gameplay_Managers_SchoolManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63827 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63827 = '\x01';
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
		void Core_Gameplay_Managers_SchoolManager__get_Controller(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a63828 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_SchoolManager_ControllerInitEvent__)
		    ;
		    DAT_ram_00a63828 = '\x01';
		  }
		  Core_Gameplay_Managers_SchoolManager__Deinit(param1,param1);
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_SchoolManager_ControllerInitEvent__,0);
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
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

}
