using System;
using System.Runtime.CompilerServices;
using Gameplay.RateGame.Controller;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001175 RID: 4469
	[Token(Token = "0x2001175")]
	public class RateGameManager : IGameManager, IBaseManager
	{
		// Token: 0x14000296 RID: 662
		// (add) Token: 0x060069A1 RID: 27041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069A2 RID: 27042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000296")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60069A1")]
			[Address(RVA = "0xB4C1", Offset = "0xB4C1", VA = "0xB4C1", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069A2")]
			[Address(RVA = "0xB4C2", Offset = "0xB4C2", VA = "0xB4C2", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000297 RID: 663
		// (add) Token: 0x060069A3 RID: 27043 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060069A4 RID: 27044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000297")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60069A3")]
			[Address(RVA = "0xB4C3", Offset = "0xB4C3", VA = "0xB4C3", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60069A4")]
			[Address(RVA = "0xB4C4", Offset = "0xB4C4", VA = "0xB4C4", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069A6 RID: 27046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700159B")]
		public RateGameController Controller
		{
			[Token(Token = "0x60069A5")]
			[Address(RVA = "0xB4C5", Offset = "0xB4C5", VA = "0xB4C5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069A6")]
			[Address(RVA = "0xB4C6", Offset = "0xB4C6", VA = "0xB4C6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069A8 RID: 27048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700159C")]
		public RateGameEvents Events
		{
			[Token(Token = "0x60069A7")]
			[Address(RVA = "0xB4C7", Offset = "0xB4C7", VA = "0xB4C7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069A8")]
			[Address(RVA = "0xB4C8", Offset = "0xB4C8", VA = "0xB4C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060069AA RID: 27050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700159D")]
		public RateGameModel Model
		{
			[Token(Token = "0x60069A9")]
			[Address(RVA = "0xB4C9", Offset = "0xB4C9", VA = "0xB4C9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60069AA")]
			[Address(RVA = "0xB4CA", Offset = "0xB4CA", VA = "0xB4CA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0xB4CB", Offset = "0xB4CB", VA = "0xB4CB", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_RateGameManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined8 *)(param1 + 0x10) = 0;
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AC")]
		[Address(RVA = "0xB4CC", Offset = "0xB4CC", VA = "0xB4CC", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_RateGameManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63822 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RateGame_Controller_RateGameController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RateGame_Events_RateGameEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RateGame_Model_RateGameModel_TypeInfo);
		    DAT_ram_00a63822 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x82306533;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x82306533:
		    uVar2 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (*(int *)(iVar5 + 0x14) != 0) {
		      uVar2 = *(undefined4 *)(*(int *)(iVar5 + 0x14) + 8);
		    }
		    uVar4 = unnamed_function_1417(Gameplay_RateGame_Model_RateGameModel_TypeInfo);
		    Gameplay_RateGame_Model_RateGameModel__Dispose(uVar4,param1_00,uVar2,0);
		    *(undefined4 *)(param1 + 0x18) = uVar4;
		    uVar2 = unnamed_function_1417(Gameplay_RateGame_Events_RateGameEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x14) = uVar2;
		    param2_00 = *(undefined4 *)(param1 + 0x18);
		    uVar4 = unnamed_function_1417(Gameplay_RateGame_Controller_RateGameController_TypeInfo);
		    Gameplay_RateGame_Events_RateGameEvents___ctor(uVar4,param2_00,uVar2,0);
		    *(undefined4 *)(param1 + 0x10) = uVar4;
		    MVC_AbstractController__Dispose(uVar4,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AD")]
		[Address(RVA = "0xB4CD", Offset = "0xB4CD", VA = "0xB4CD")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Core_Gameplay_Managers_RateGameManager__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined8 *)(param1 + 0x10) = 0;
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060069AE RID: 27054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AE")]
		[Address(RVA = "0xB4CE", Offset = "0xB4CE", VA = "0xB4CE")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		undefined4 Core_Gameplay_Managers_RateGameManager__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63823 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_13321);
		    DAT_ram_00a63823 = '\x01';
		  }
		  return StringLiteral_13321;
		}
		*/

		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700159E")]
		public string Name
		{
			[Token(Token = "0x60069AF")]
			[Address(RVA = "0xB4CF", Offset = "0xB4CF", VA = "0xB4CF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B0")]
		[Address(RVA = "0xB4D0", Offset = "0xB4D0", VA = "0xB4D0")]
		public RateGameManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_RateGameManager___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63824 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63824 = '\x01';
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

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_RateGameManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6381f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6381f = '\x01';
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
		void Core_Gameplay_Managers_RateGameManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63820 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63820 = '\x01';
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
		void Core_Gameplay_Managers_RateGameManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63821 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63821 = '\x01';
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


		/* --- GHIDRA: set_Model ---
		void Core_Gameplay_Managers_RateGameManager__set_Model(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Core_Gameplay_Managers_RateGameManager__Deinit(param1,param1);
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
