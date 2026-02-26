using System;
using System.Runtime.CompilerServices;
using Gameplay.ThemeDuelState;
using Gameplay.ThemeDuelState.Control;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200117B RID: 4475
	[Token(Token = "0x200117B")]
	public class ThemeDuelStateManager : IGameManager, IBaseManager
	{
		// Token: 0x140002A2 RID: 674
		// (add) Token: 0x060069FA RID: 27130 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069FB RID: 27131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069FA")]
			[Address(RVA = "0xB51A", Offset = "0xB51A", VA = "0xB51A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069FB")]
			[Address(RVA = "0xB51B", Offset = "0xB51B", VA = "0xB51B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002A3 RID: 675
		// (add) Token: 0x060069FC RID: 27132 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069FD RID: 27133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002A3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069FC")]
			[Address(RVA = "0xB51C", Offset = "0xB51C", VA = "0xB51C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069FD")]
			[Address(RVA = "0xB51D", Offset = "0xB51D", VA = "0xB51D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x060069FE RID: 27134 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069FF RID: 27135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015AF")]
		public ThemeDuelStateController Controller
		{
			[Token(Token = "0x60069FE")]
			[Address(RVA = "0xB51E", Offset = "0xB51E", VA = "0xB51E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069FF")]
			[Address(RVA = "0xB51F", Offset = "0xB51F", VA = "0xB51F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A01 RID: 27137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B0")]
		public ThemeDuelStateModel Model
		{
			[Token(Token = "0x6006A00")]
			[Address(RVA = "0xB520", Offset = "0xB520", VA = "0xB520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A01")]
			[Address(RVA = "0xB521", Offset = "0xB521", VA = "0xB521")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A03 RID: 27139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015B1")]
		public ThemeDuelStateEvents Events
		{
			[Token(Token = "0x6006A02")]
			[Address(RVA = "0xB522", Offset = "0xB522", VA = "0xB522")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A03")]
			[Address(RVA = "0xB523", Offset = "0xB523", VA = "0xB523")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A04")]
		[Address(RVA = "0xB524", Offset = "0xB524", VA = "0xB524", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ThemeDuelStateManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a63853 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ThemeDuelStateManager_OnThemeDuelStateReceived__);
		    DAT_ram_00a63853 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ThemeDuelStateManager_OnThemeDuelStateReceived__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 0x14) = param1_01, *param1_01 != iVar2)) {
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
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A05")]
		[Address(RVA = "0xB525", Offset = "0xB525", VA = "0xB525", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_ThemeDuelStateManager__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a63854 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ThemeDuelStateManager_OnThemeDuelStateReceived__);
		    DAT_ram_00a63854 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_ThemeDuelStateManager_OnThemeDuelStateReceived__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 0x14) = param1_01, *param1_01 != iVar2)) {
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

		// Token: 0x06006A06 RID: 27142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A06")]
		[Address(RVA = "0xB526", Offset = "0xB526", VA = "0xB526")]
		private void OnThemeDuelStateReceived()
		{
		/* --- GHIDRA: OnThemeDuelStateReceived ---
		undefined4
		Core_Gameplay_Managers_ThemeDuelStateManager__OnThemeDuelStateReceived
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63855 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16076);
		    DAT_ram_00a63855 = '\x01';
		  }
		  return StringLiteral_16076;
		}
		*/

		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015B2")]
		public string Name
		{
			[Token(Token = "0x6006A07")]
			[Address(RVA = "0xB527", Offset = "0xB527", VA = "0xB527", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A08")]
		[Address(RVA = "0xB528", Offset = "0xB528", VA = "0xB528")]
		public ThemeDuelStateManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_ThemeDuelStateManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63856 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_16347);
		    DAT_ram_00a63856 = '\x01';
		  }
		  return StringLiteral_16347;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_ThemeDuelStateManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6384f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6384f = '\x01';
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
		void Core_Gameplay_Managers_ThemeDuelStateManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63850 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63850 = '\x01';
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
		void Core_Gameplay_Managers_ThemeDuelStateManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63851 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63851 = '\x01';
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


		/* --- GHIDRA: set_Events ---
		void Core_Gameplay_Managers_ThemeDuelStateManager__set_Events(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a63852 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelState_Control_ThemeDuelStateController_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelState_ThemeDuelStateEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_ThemeDuelStateManager_OnThemeDuelStateReceived__);
		    Mono_Security_ASN1__get_Item(&Gameplay_ThemeDuelState_Model_ThemeDuelStateModel_TypeInfo);
		    DAT_ram_00a63852 = '\x01';
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x82308d46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82308d46:
		  uVar2 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  uVar4 = unnamed_function_1417(Gameplay_ThemeDuelState_Model_ThemeDuelStateModel_TypeInfo);
		  Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_Price(uVar4,uVar2,uVar7,0);
		  *(undefined4 *)(param1 + 0x14) = uVar4;
		  uVar2 = unnamed_function_1417(Gameplay_ThemeDuelState_ThemeDuelStateEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar7 = *(undefined4 *)(param1 + 0x14);
		  uVar4 = unnamed_function_1417(Gameplay_ThemeDuelState_Control_ThemeDuelStateController_TypeInfo);
		  Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__UpdateBalance(uVar4,uVar7,uVar2,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  iVar8 = *(int *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(iVar8 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_ThemeDuelStateManager_OnThemeDuelStateReceived__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) ||
		          (*(int **)(iVar8 + 0x14) = piVar5, *piVar5 != iVar6)) {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

}
