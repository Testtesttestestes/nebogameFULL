using System;
using System.Runtime.CompilerServices;
using Gameplay.Shop;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001178 RID: 4472
	[Token(Token = "0x2001178")]
	public class ShopManager : IGameManager, IBaseManager
	{
		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015A5")]
		public string Name
		{
			[Token(Token = "0x60069CA")]
			[Address(RVA = "0xB4EA", Offset = "0xB4EA", VA = "0xB4EA", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400029C RID: 668
		// (add) Token: 0x060069CB RID: 27083 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069CC RID: 27084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069CB")]
			[Address(RVA = "0xB4EB", Offset = "0xB4EB", VA = "0xB4EB", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069CC")]
			[Address(RVA = "0xB4EC", Offset = "0xB4EC", VA = "0xB4EC", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400029D RID: 669
		// (add) Token: 0x060069CD RID: 27085 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069CE RID: 27086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400029D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069CD")]
			[Address(RVA = "0xB4ED", Offset = "0xB4ED", VA = "0xB4ED", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069CE")]
			[Address(RVA = "0xB4EE", Offset = "0xB4EE", VA = "0xB4EE", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x060069CF RID: 27087 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069D0 RID: 27088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A6")]
		public ShopEvents Events
		{
			[Token(Token = "0x60069CF")]
			[Address(RVA = "0xB4EF", Offset = "0xB4EF", VA = "0xB4EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069D0")]
			[Address(RVA = "0xB4F0", Offset = "0xB4F0", VA = "0xB4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x060069D1 RID: 27089 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069D2 RID: 27090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A7")]
		public ShopModel Model
		{
			[Token(Token = "0x60069D1")]
			[Address(RVA = "0xB4F1", Offset = "0xB4F1", VA = "0xB4F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069D2")]
			[Address(RVA = "0xB4F2", Offset = "0xB4F2", VA = "0xB4F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x060069D3 RID: 27091 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069D4 RID: 27092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015A8")]
		public ShopController Controller
		{
			[Token(Token = "0x60069D3")]
			[Address(RVA = "0xB4F3", Offset = "0xB4F3", VA = "0xB4F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069D4")]
			[Address(RVA = "0xB4F4", Offset = "0xB4F4", VA = "0xB4F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D5")]
		[Address(RVA = "0xB4F5", Offset = "0xB4F5", VA = "0xB4F5", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_ShopManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a6383a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_ShopManager_OnInitEvent__);
		    DAT_ram_00a6383a = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_ShopManager_OnInitEvent__,0);
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

		// Token: 0x060069D6 RID: 27094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D6")]
		[Address(RVA = "0xB4F6", Offset = "0xB4F6", VA = "0xB4F6")]
		private void OnInitEvent()
		{
		/* --- GHIDRA: OnInitEvent ---
		void Core_Gameplay_Managers_ShopManager__OnInitEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x18),0);
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D7")]
		[Address(RVA = "0xB4F7", Offset = "0xB4F7", VA = "0xB4F7", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D8")]
		[Address(RVA = "0xB4F8", Offset = "0xB4F8", VA = "0xB4F8")]
		public ShopManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_ShopManager___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6383b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6383b = '\x01';
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
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_ShopManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63835 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63835 = '\x01';
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
		void Core_Gameplay_Managers_ShopManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63836 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63836 = '\x01';
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
		void Core_Gameplay_Managers_ShopManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63837 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63837 = '\x01';
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
		void Core_Gameplay_Managers_ShopManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63838 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63838 = '\x01';
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
		void Core_Gameplay_Managers_ShopManager__set_Controller(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param4;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  undefined4 param5;
		  int iVar7;
		  
		  if (DAT_ram_00a63839 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_ShopManager_OnInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel_TypeInfo);
		    DAT_ram_00a63839 = '\x01';
		  }
		  uVar3 = unnamed_function_1417(Gameplay_Shop_ShopEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
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
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x82307667;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x82307667:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
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
		        goto code_r0x82307713;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82307713:
		  uVar2 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
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
		        goto code_r0x823077d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x823077d0:
		  param4 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  if (*(int *)(iVar6 + 0x14) != 0) {
		    param4 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 8);
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
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x8230788d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8230788d:
		  iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  param5 = *(undefined4 *)(*(int *)(iVar6 + 0x14) + 0x20);
		  param1_00 = unnamed_function_1417(Gameplay_Shop_ShopModel_TypeInfo);
		  Gameplay_Shop_ShopModel__get_IsMyShop(param1_00,uVar3,uVar2,param4,param5,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(Gameplay_Shop_ShopController_TypeInfo);
		  Gameplay_Shop_ShopController__set_ItemsRequested(uVar3,param1_00,uVar2,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  iVar7 = *(int *)(param1 + 0x10);
		  uVar2 = *(undefined4 *)(iVar7 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_ShopManager_OnInitEvent__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar3,0);
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
