using System;
using System.Runtime.CompilerServices;
using Gameplay.Fresco.Controller;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001167 RID: 4455
	[Token(Token = "0x2001167")]
	public class FrescoManager : IGameManager, IBaseManager
	{
		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06006921 RID: 26913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001583")]
		public string Name
		{
			[Token(Token = "0x6006921")]
			[Address(RVA = "0xB445", Offset = "0xB445", VA = "0xB445", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000286 RID: 646
		// (add) Token: 0x06006922 RID: 26914 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006923 RID: 26915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000286")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006922")]
			[Address(RVA = "0xB446", Offset = "0xB446", VA = "0xB446", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006923")]
			[Address(RVA = "0xB447", Offset = "0xB447", VA = "0xB447", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000287 RID: 647
		// (add) Token: 0x06006924 RID: 26916 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006925 RID: 26917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000287")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006924")]
			[Address(RVA = "0xB448", Offset = "0xB448", VA = "0xB448", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006925")]
			[Address(RVA = "0xB449", Offset = "0xB449", VA = "0xB449", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06006926 RID: 26918 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006927 RID: 26919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001584")]
		public FrescoController Controller
		{
			[Token(Token = "0x6006926")]
			[Address(RVA = "0xB44A", Offset = "0xB44A", VA = "0xB44A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006927")]
			[Address(RVA = "0xB44B", Offset = "0xB44B", VA = "0xB44B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006928")]
		[Address(RVA = "0xB44C", Offset = "0xB44C", VA = "0xB44C")]
		public FrescoManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_FrescoManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param7;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param5;
		  undefined4 param6;
		  undefined4 param8;
		  
		  if (DAT_ram_00a637d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_Dependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Controller_FrescoController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Events_FrescoEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_FrescoManager_InitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_FrescoService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a637d9 = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x82301735;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x82301735:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x823017b5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x823017b5:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x280);
		        goto code_r0x8230183a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x8230183a:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x823018c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x823018c2:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 400);
		        goto code_r0x82301947;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x82301947:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  param5 = *(undefined4 *)(iVar7 + 0x24);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x278);
		        goto code_r0x823019cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x37);
		code_r0x823019cf:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  param6 = *(undefined4 *)(iVar7 + 0x10);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x82301a57;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82301a57:
		  param7 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    param7 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  param8 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Fresco_Model_Dependencies_TypeInfo);
		  Gameplay_Fresco_View_Groups_FrescoListElement___c___Init_b__19_0
		            (param1_00,uVar3,uVar8,uVar4,param5,param6,param7,param8,0);
		  piVar6 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x82301b15;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82301b15:
		  uVar3 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    uVar3 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  iVar7 = unnamed_function_1417(Gameplay_Fresco_Model_FrescoModel_TypeInfo);
		  Gameplay_Fresco_Model_FrescoModel__GetAllAvailableCellsIndex(iVar7,uVar3,param1_00,0);
		  uVar3 = unnamed_function_1417(Gameplay_Fresco_Events_FrescoEvents_TypeInfo);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar8 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_FrescoService___);
		  uVar4 = *(undefined4 *)(iVar7 + 8);
		  piVar6 = (int *)unnamed_function_1417(Gameplay_Fresco_Controller_FrescoController_TypeInfo);
		  Gameplay_Fresco_Events_FrescoEvents___ctor(piVar6,iVar7,uVar3,uVar8,uVar4,0);
		  *(int **)(param1 + 0x10) = piVar6;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x110) * 4))
		                    (piVar6,*(undefined4 *)(*piVar6 + 0x114));
		  uVar8 = *(undefined4 *)(iVar5 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_FrescoManager_InitEvent__,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) || (*(int **)(iVar5 + 8) = piVar6, *piVar6 != iVar7))
		  {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06006929 RID: 26921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006929")]
		[Address(RVA = "0xB44D", Offset = "0xB44D", VA = "0xB44D", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_FrescoManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a637da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_FrescoManager_InitEvent__);
		    DAT_ram_00a637da = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_FrescoManager_InitEvent__,0);
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

		// Token: 0x0600692A RID: 26922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600692A")]
		[Address(RVA = "0xB44E", Offset = "0xB44E", VA = "0xB44E")]
		private void InitEvent()
		{
		/* --- GHIDRA: InitEvent ---
		void Core_Gameplay_Managers_FrescoManager__InitEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600692B RID: 26923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600692B")]
		[Address(RVA = "0xB44F", Offset = "0xB44F", VA = "0xB44F", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_FrescoManager__Deinit(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637db = '\x01';
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

		// Token: 0x040037D2 RID: 14290
		[Token(Token = "0x40037D2")]
		[FieldOffset(Offset = "0x14")]
		private readonly IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_FrescoManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637d5 = '\x01';
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
		void Core_Gameplay_Managers_FrescoManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637d6 = '\x01';
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
		void Core_Gameplay_Managers_FrescoManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637d7 = '\x01';
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
		void Core_Gameplay_Managers_FrescoManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637d8 = '\x01';
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
