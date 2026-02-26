using System;
using System.Runtime.CompilerServices;
using Gameplay.Experiments.Controller;
using Gameplay.Experiments.Events;
using Gameplay.Experiments.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001166 RID: 4454
	[Token(Token = "0x2001166")]
	public class ExperimentsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001582")]
		public string Name
		{
			[Token(Token = "0x6006917")]
			[Address(RVA = "0xB43B", Offset = "0xB43B", VA = "0xB43B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000284 RID: 644
		// (add) Token: 0x06006918 RID: 26904 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006919 RID: 26905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000284")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006918")]
			[Address(RVA = "0xB43C", Offset = "0xB43C", VA = "0xB43C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006919")]
			[Address(RVA = "0xB43D", Offset = "0xB43D", VA = "0xB43D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000285 RID: 645
		// (add) Token: 0x0600691A RID: 26906 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600691B RID: 26907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000285")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600691A")]
			[Address(RVA = "0xB43E", Offset = "0xB43E", VA = "0xB43E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600691B")]
			[Address(RVA = "0xB43F", Offset = "0xB43F", VA = "0xB43F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691C")]
		[Address(RVA = "0xB440", Offset = "0xB440", VA = "0xB440")]
		public ExperimentsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ExperimentsManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_ExperimentsManager__Init(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691D")]
		[Address(RVA = "0xB441", Offset = "0xB441", VA = "0xB441", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ExperimentsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param3;
		  int iVar7;
		  
		  if (DAT_ram_00a637d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Experiments_Controller_ExperimentsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Experiments_Events_ExperimentsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ExperimentsManager_ControllerOnInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Experiments_Model_ExperimentsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a637d2 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Experiments_Events_ExperimentsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  piVar5 = *(int **)(param1 + 0x1c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x823011ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x823011ff:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (iVar6 == 0) {
		    uVar2 = 0;
		  }
		  else if (*(int *)(iVar6 + 0x14) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
		  }
		  uVar4 = unnamed_function_1417(Gameplay_Experiments_Model_ExperimentsModel_TypeInfo);
		  Gameplay_FeedbackForm_Model_Controll_FeedbackFormViewMediator___c__DisplayClass16_0___ShowCloseWarning_b__0
		            (uVar4,uVar2,0);
		  *(undefined4 *)(param1 + 0x14) = uVar4;
		  param3 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(Gameplay_Experiments_Controller_ExperimentsController_TypeInfo);
		  Gameplay_Experiments_Events_ExperimentsEvents___ctor(uVar2,uVar4,param3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  iVar7 = *(int *)(param1 + 0x10);
		  uVar4 = *(undefined4 *)(iVar7 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_ExperimentsManager_ControllerOnInitEvent__,0
		            );
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
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

		// Token: 0x0600691E RID: 26910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691E")]
		[Address(RVA = "0xB442", Offset = "0xB442", VA = "0xB442")]
		private void CreateMvc()
		{
		/* --- GHIDRA: CreateMvc ---
		void Core_Gameplay_Managers_ExperimentsManager__CreateMvc(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(int *)(param1 + 0x18),0);
		    piVar1 = *(int **)(param1 + 0x18);
		    if (piVar1 != (int *)0x0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))
		                (piVar1,*(undefined4 *)(*piVar1 + 0xec));
		    }
		  }
		  piVar1 = *(int **)(param1 + 0x14);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  *(undefined8 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600691F RID: 26911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600691F")]
		[Address(RVA = "0xB443", Offset = "0xB443", VA = "0xB443", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ExperimentsManager__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a637d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ExperimentsManager_ControllerOnInitEvent__);
		    DAT_ram_00a637d3 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ExperimentsManager_ControllerOnInitEvent__,0);
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

		// Token: 0x06006920 RID: 26912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006920")]
		[Address(RVA = "0xB444", Offset = "0xB444", VA = "0xB444")]
		private void ControllerOnInitEvent()
		{
		/* --- GHIDRA: ControllerOnInitEvent ---
		undefined4
		Core_Gameplay_Managers_ExperimentsManager__ControllerOnInitEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8164);
		    DAT_ram_00a637d4 = '\x01';
		  }
		  return StringLiteral_8164;
		}
		*/

		}

		// Token: 0x040037CB RID: 14283
		[Token(Token = "0x40037CB")]
		[FieldOffset(Offset = "0x10")]
		private ExperimentsEvents _events;

		// Token: 0x040037CC RID: 14284
		[Token(Token = "0x40037CC")]
		[FieldOffset(Offset = "0x14")]
		private ExperimentsModel _model;

		// Token: 0x040037CD RID: 14285
		[Token(Token = "0x40037CD")]
		[FieldOffset(Offset = "0x18")]
		private ExperimentsController _controller;

		// Token: 0x040037CE RID: 14286
		[Token(Token = "0x40037CE")]
		[FieldOffset(Offset = "0x1C")]
		private IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ExperimentsManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ce = '\x01';
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
		void Core_Gameplay_Managers_ExperimentsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637cf = '\x01';
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
		void Core_Gameplay_Managers_ExperimentsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637d0 = '\x01';
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
		void Core_Gameplay_Managers_ExperimentsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637d1 = '\x01';
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
