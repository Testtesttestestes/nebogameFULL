using System;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Controller;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001142 RID: 4418
	[Token(Token = "0x2001142")]
	public class BankManager : IGameManager, IBaseManager
	{
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153B")]
		public string Name
		{
			[Token(Token = "0x60067B3")]
			[Address(RVA = "0xB2DF", Offset = "0xB2DF", VA = "0xB2DF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000260 RID: 608
		// (add) Token: 0x060067B4 RID: 26548 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067B5 RID: 26549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000260")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067B4")]
			[Address(RVA = "0xB2E0", Offset = "0xB2E0", VA = "0xB2E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067B5")]
			[Address(RVA = "0xB2E1", Offset = "0xB2E1", VA = "0xB2E1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000261 RID: 609
		// (add) Token: 0x060067B6 RID: 26550 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067B7 RID: 26551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000261")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067B6")]
			[Address(RVA = "0xB2E2", Offset = "0xB2E2", VA = "0xB2E2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067B7")]
			[Address(RVA = "0xB2E3", Offset = "0xB2E3", VA = "0xB2E3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153C")]
		public PaymentBonusController PaymentBonusController
		{
			[Token(Token = "0x60067B8")]
			[Address(RVA = "0xB2E4", Offset = "0xB2E4", VA = "0xB2E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153D")]
		public PaymentBonusEvents PaymentBonusEvents
		{
			[Token(Token = "0x60067B9")]
			[Address(RVA = "0xB2E5", Offset = "0xB2E5", VA = "0xB2E5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153E")]
		public PaymentBonusModel PaymentBonusModel
		{
			[Token(Token = "0x60067BA")]
			[Address(RVA = "0xB2E6", Offset = "0xB2E6", VA = "0xB2E6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700153F")]
		public IGame Game
		{
			[Token(Token = "0x60067BB")]
			[Address(RVA = "0xB2E7", Offset = "0xB2E7", VA = "0xB2E7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067BC")]
			[Address(RVA = "0xB2E8", Offset = "0xB2E8", VA = "0xB2E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067BD")]
		[Address(RVA = "0xB2E9", Offset = "0xB2E9", VA = "0xB2E9")]
		public BankManager(IGame game)
		{
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001540")]
		public BankController BankController
		{
			[Token(Token = "0x60067BE")]
			[Address(RVA = "0xB2EA", Offset = "0xB2EA", VA = "0xB2EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067BF")]
			[Address(RVA = "0xB2EB", Offset = "0xB2EB", VA = "0xB2EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067C1 RID: 26561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001541")]
		public BankEvents BankEvents
		{
			[Token(Token = "0x60067C0")]
			[Address(RVA = "0xB2EC", Offset = "0xB2EC", VA = "0xB2EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067C1")]
			[Address(RVA = "0xB2ED", Offset = "0xB2ED", VA = "0xB2ED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001542")]
		public BankModel BankModel
		{
			[Token(Token = "0x60067C2")]
			[Address(RVA = "0xB2EE", Offset = "0xB2EE", VA = "0xB2EE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067C3")]
			[Address(RVA = "0xB2EF", Offset = "0xB2EF", VA = "0xB2EF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C4")]
		[Address(RVA = "0xB2F0", Offset = "0xB2F0", VA = "0xB2F0", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_BankManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a99c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_BankManager_BankInitEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_BankManager_PaymentBonusInitEvent__)
		    ;
		    DAT_ram_00a5a99c = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x18);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_BankManager_PaymentBonusInitEvent__,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) || (*(int **)(iVar4 + 8) = piVar3, *piVar3 != iVar1))
		  {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param1 + 0x28);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_BankManager_BankInitEvent__,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar4 + 8) = piVar3, *piVar3 != iVar1))
		  {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/

		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C5")]
		[Address(RVA = "0xB2F1", Offset = "0xB2F1", VA = "0xB2F1")]
		private void PaymentBonusInitEvent()
		{
		/* --- GHIDRA: PaymentBonusInitEvent ---
		void Core_Gameplay_Managers_BankManager__PaymentBonusInitEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a99d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_BankManager_BankInitEvent__);
		    DAT_ram_00a5a99d = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x28);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_BankManager_BankInitEvent__,0);
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

		// Token: 0x060067C6 RID: 26566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0xB2F2", Offset = "0xB2F2", VA = "0xB2F2")]
		private void BankInitEvent()
		{
		/* --- GHIDRA: BankInitEvent ---
		void Core_Gameplay_Managers_BankManager__BankInitEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a99e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankEntryPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Events_BankEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3780);
		    DAT_ram_00a5a99e = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_3780,0);
		    return;
		  }
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x812a0ae3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a0ae3:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x812a0b6e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812a0b6e:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = 0;
		  uVar5 = unnamed_function_1417(Gameplay_Bank_Model_BankModel_TypeInfo);
		  Gameplay_Bank_Model_BankModel__Dispose(uVar5,uVar3,uVar4,uVar8,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar5;
		  uVar3 = unnamed_function_1417(Gameplay_Bank_Events_BankEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  uVar4 = *(undefined4 *)(param1 + 0x2c);
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x198);
		        goto code_r0x812a0c33;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x812a0c33:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x10);
		  uVar5 = unnamed_function_1417(Gameplay_Bank_Controller_BankController_TypeInfo);
		  Gameplay_Bank_Controller_BankController__Dispose(uVar5,uVar4,uVar3,uVar8,0);
		  *(undefined4 *)(param1 + 0x24) = uVar5;
		  uVar4 = *(undefined4 *)(param1 + 0x2c);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  uVar3 = unnamed_function_1417(Gameplay_Bank_Controller_BankEntryPointViewMediator_TypeInfo);
		  Gameplay_Bank_Controller_BankController__SetEpNotifications(uVar3,uVar4,uVar8,uVar5,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C7")]
		[Address(RVA = "0xB2F3", Offset = "0xB2F3", VA = "0xB2F3")]
		private void SetupBankMvc()
		{
		/* --- GHIDRA: SetupBankMvc ---
		void Core_Gameplay_Managers_BankManager__SetupBankMvc(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  piVar1 = *(int **)(param1 + 0x2c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		    iVar2 = **(int **)(param1 + 0x24);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x24),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x134));
		    *(undefined4 *)(param1 + 0x2c) = 0;
		    *(undefined8 *)(param1 + 0x24) = 0;
		    *(undefined4 *)(param1 + 0x10) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C8")]
		[Address(RVA = "0xB2F4", Offset = "0xB2F4", VA = "0xB2F4")]
		private void DestroyBankMvc()
		{
		/* --- GHIDRA: DestroyBankMvc ---
		void Core_Gameplay_Managers_BankManager__DestroyBankMvc(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a99f == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_PaymentBonusController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Events_PaymentBonusEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_PaymentBonusModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3781);
		    DAT_ram_00a5a99f = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_3781,0);
		    return;
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0x20);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x812a0983;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x812a0983:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = unnamed_function_1417(Gameplay_Bank_Model_PaymentBonusModel_TypeInfo);
		  System_Xml_XmlAttribute__get_XmlLang(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_Bank_Events_PaymentBonusEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  param2_00 = *(undefined4 *)(param1 + 0x1c);
		  uVar4 = unnamed_function_1417(Gameplay_Bank_Controller_PaymentBonusController_TypeInfo);
		  Gameplay_Bank_Controller_BankViewMediator__CheckBackTimersCoroutine_d__14__System_Collections_IEnumerator_get_Current
		            (uVar4,param2_00,uVar3,0);
		  *(undefined4 *)(param1 + 0x14) = uVar4;
		  return;
		}
		*/

		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C9")]
		[Address(RVA = "0xB2F5", Offset = "0xB2F5", VA = "0xB2F5")]
		private void SetupPaymentBonusMvc()
		{
		/* --- GHIDRA: SetupPaymentBonusMvc ---
		void Core_Gameplay_Managers_BankManager__SetupPaymentBonusMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x1c) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		    iVar1 = **(int **)(param1 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    *(undefined8 *)(param1 + 0x14) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067CA RID: 26570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CA")]
		[Address(RVA = "0xB2F6", Offset = "0xB2F6", VA = "0xB2F6")]
		private void DestroyPaymentBonusMvc()
		{
		/* --- GHIDRA: DestroyPaymentBonusMvc ---
		void Core_Gameplay_Managers_BankManager__DestroyPaymentBonusMvc(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x24),0);
		  piVar1 = *(int **)(param1 + 0x2c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		    iVar2 = **(int **)(param1 + 0x24);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x24),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0x134));
		    *(undefined4 *)(param1 + 0x2c) = 0;
		    *(undefined8 *)(param1 + 0x24) = 0;
		    *(undefined4 *)(param1 + 0x10) = 0;
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		    iVar2 = **(int **)(param1 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xec));
		    *(undefined4 *)(param1 + 0x1c) = 0;
		    *(undefined8 *)(param1 + 0x14) = 0;
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060067CB RID: 26571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CB")]
		[Address(RVA = "0xB2F7", Offset = "0xB2F7", VA = "0xB2F7", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_BankManager__Deinit
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_BankWindow_BankWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BankWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12571);
		    DAT_ram_00a5a9a0 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Bank_View_BankWindow_BankWindowArgs_TypeInfo);
		  Gameplay_Bank_View_BankWindow_BankWindowArgs___ctor(param1_00,param2,0);
		  *(undefined4 *)(param1_00 + 0x10) = param3;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12571,param1_00,
		             Method_UI_Windows_PopupController_Show_BankWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060067CC RID: 26572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CC")]
		[Address(RVA = "0xB2F8", Offset = "0xB2F8", VA = "0xB2F8")]
		public void ShowBankWindow(OptionTypesDic.Types.OptionType optionType = OptionTypesDic.Types.OptionType.Diamond, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		/* --- GHIDRA: ShowBankWindow ---
		void Core_Gameplay_Managers_BankManager__ShowBankWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_BankOptionInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BankOptionInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12569);
		    DAT_ram_00a5a9a1 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Bank_View_BankOptionInfoWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12569,param1_00,
		             Method_UI_Windows_PopupController_Show_BankOptionInfoWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: ShowBankWindow ---
		void Core_Gameplay_Managers_BankManager__ShowBankWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a9a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_BankOptionInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BankOptionInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12569);
		    DAT_ram_00a5a9a1 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Bank_View_BankOptionInfoWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12569,param1_00,
		             Method_UI_Windows_PopupController_Show_BankOptionInfoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060067CD RID: 26573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CD")]
		[Address(RVA = "0xB2F9", Offset = "0xB2F9", VA = "0xB2F9")]
		public void ShowBankWindow(Resources resourceId, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CE")]
		[Address(RVA = "0xB2FA", Offset = "0xB2FA", VA = "0xB2FA")]
		public void ShowBankOptionInfoWindow(BankOptionViewArgs bankOptionDataWrapper)
		{
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CF")]
		[Address(RVA = "0xB2FB", Offset = "0xB2FB", VA = "0xB2FB")]
		public void SetView(UserInterfaceView view)
		{
		/* --- GHIDRA: SetView ---
		void Core_Gameplay_Managers_BankManager__SetView(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a9a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a9a2 = '\x01';
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

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x10")]
		private BankEntryPointViewMediator _entryPointViewMediator;

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x14")]
		private PaymentBonusController _paymentBonusController;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x18")]
		private PaymentBonusEvents _paymentBonusEvents;

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x1C")]
		private PaymentBonusModel _paymentBonusModel;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_BankManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a997 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a997 = '\x01';
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
		void Core_Gameplay_Managers_BankManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a998 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a998 = '\x01';
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
		void Core_Gameplay_Managers_BankManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a999 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a999 = '\x01';
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
		void Core_Gameplay_Managers_BankManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a99a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a99a = '\x01';
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


		/* --- GHIDRA: set_BankModel ---
		void Core_Gameplay_Managers_BankManager__set_BankModel(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5a99b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_BankManager_PaymentBonusInitEvent__)
		    ;
		    DAT_ram_00a5a99b = '\x01';
		  }
		  Core_Gameplay_Managers_BankManager__DestroyBankMvc(param1,param1);
		  Core_Gameplay_Managers_BankManager__BankInitEvent(param1,param1);
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_BankManager_PaymentBonusInitEvent__,0);
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
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

}
