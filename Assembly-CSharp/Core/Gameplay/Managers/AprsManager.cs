using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Controller;
using Gameplay.Aprs.Discounts;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113F RID: 4415
	[Token(Token = "0x200113F")]
	public class AprsManager : IGameManager, IBaseManager
	{
		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001531")]
		public string Name
		{
			[Token(Token = "0x6006781")]
			[Address(RVA = "0xB2AD", Offset = "0xB2AD", VA = "0xB2AD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400025A RID: 602
		// (add) Token: 0x06006782 RID: 26498 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006783 RID: 26499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025A")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006782")]
			[Address(RVA = "0xB2AE", Offset = "0xB2AE", VA = "0xB2AE", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006783")]
			[Address(RVA = "0xB2AF", Offset = "0xB2AF", VA = "0xB2AF", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400025B RID: 603
		// (add) Token: 0x06006784 RID: 26500 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006785 RID: 26501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025B")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006784")]
			[Address(RVA = "0xB2B0", Offset = "0xB2B0", VA = "0xB2B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006785")]
			[Address(RVA = "0xB2B1", Offset = "0xB2B1", VA = "0xB2B1", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06006786 RID: 26502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001532")]
		public AprsController Controller
		{
			[Token(Token = "0x6006786")]
			[Address(RVA = "0xB2B2", Offset = "0xB2B2", VA = "0xB2B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06006787 RID: 26503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001533")]
		public AprsModel Model
		{
			[Token(Token = "0x6006787")]
			[Address(RVA = "0xB2B3", Offset = "0xB2B3", VA = "0xB2B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06006788 RID: 26504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001534")]
		public AprsEvents Events
		{
			[Token(Token = "0x6006788")]
			[Address(RVA = "0xB2B4", Offset = "0xB2B4", VA = "0xB2B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001535")]
		public IGame Game
		{
			[Token(Token = "0x6006789")]
			[Address(RVA = "0xB2B5", Offset = "0xB2B5", VA = "0xB2B5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600678A")]
			[Address(RVA = "0xB2B6", Offset = "0xB2B6", VA = "0xB2B6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001536")]
		public AprDicGroupStorage AprDicGroupStorage
		{
			[Token(Token = "0x600678B")]
			[Address(RVA = "0xB2B7", Offset = "0xB2B7", VA = "0xB2B7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600678C")]
			[Address(RVA = "0xB2B8", Offset = "0xB2B8", VA = "0xB2B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600678D RID: 26509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678D")]
		[Address(RVA = "0xB2B9", Offset = "0xB2B9", VA = "0xB2B9")]
		public AprsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_AprsManager___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a977 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprDicGroupStorage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AprsManager_ControllerInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_AprsManager_HandleDictProviderChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_AprsManager_ResolveDiscountsProvider__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a977 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x20);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8129e061;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129e061:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = unnamed_function_1417(Gameplay_Aprs_Model_AprDicGroupStorage_TypeInfo);
		  Gameplay_Aprs_Model_AprDicGroupStorage__set_AprDicGroups(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x24) = uVar4;
		  Core_Gameplay_Managers_AprsManager__ResolveDiscountsProvider(param1,uVar3);
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(iVar7 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_AprsManager_ControllerInitEvent__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else if ((*piVar5 != System_Action_TypeInfo) || (*(int **)(iVar7 + 8) = piVar5, *piVar5 != iVar6))
		  {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(iVar6);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_AprsManager_HandleDictProviderChanged__,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) ||
		          (*(int **)(iVar7 + 0x1c) = piVar5, *piVar5 != iVar6)) {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Gameplay_Managers_AprsManager_ResolveDiscountsProvider__,0);
		  Core_Data_UserData__remove_UserSkillsChangedEvent(uVar4,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x0600678E RID: 26510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678E")]
		[Address(RVA = "0xB2BA", Offset = "0xB2BA", VA = "0xB2BA", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_AprsManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a978 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a978 = '\x01';
		  }
		  iVar2 = Core_Gameplay_Managers_DiscountsManager__Handle
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 8),0);
		  iVar5 = *(int *)(param1 + 0x14);
		  if (iVar2 != 0) {
		    *(undefined4 *)(iVar5 + 0x2c) = *(undefined4 *)(param1 + 0x1c);
		    return;
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0x20);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x248);
		        goto code_r0x8129e6cb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x8129e6cb:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(iVar5 + 0x2c) = uVar4;
		  return;
		}
		*/

		}

		// Token: 0x0600678F RID: 26511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600678F")]
		[Address(RVA = "0xB2BB", Offset = "0xB2BB", VA = "0xB2BB")]
		private void ResolveDiscountsProvider()
		{
		/* --- GHIDRA: ResolveDiscountsProvider ---
		void Core_Gameplay_Managers_AprsManager__ResolveDiscountsProvider(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 param6;
		  int iVar8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a979 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_AprsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Events_AprsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Discounts_DiscountCache_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Discounts_Discounts_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2017);
		    DAT_ram_00a5a979 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    if (DAT_ram_00a5a972 == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_3193);
		      DAT_ram_00a5a972 = '\x01';
		    }
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3193,StringLiteral_2017,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		    return;
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Aprs_Events_AprsEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8129e2f1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8129e2f1:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8129e37c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8129e37c:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8129e407;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129e407:
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  param6 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(Gameplay_Aprs_Model_AprsModel_TypeInfo);
		  Gameplay_Aprs_Model_AprsModel__Dispose(param1_00,uVar2,uVar4,piVar6,uVar5,param6,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  piVar6 = *(int **)(param1 + 0x20);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x248);
		        goto code_r0x8129e4b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x8129e4b7:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar5 = *(undefined4 *)(iVar7 + 0x20);
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(Gameplay_Aprs_Discounts_DiscountCache_TypeInfo);
		  Gameplay_Aprs_Discounts_DiscountCache__Dispose(uVar2,uVar4,120.0,0);
		  uVar4 = unnamed_function_1417(Gameplay_Aprs_Discounts_Discounts_TypeInfo);
		  UnityEngine_Purchasing_PurchasingManager___c__DisplayClass27_0___OnAllPurchasesRetrieved_b__0
		            (uVar4,param1_00,uVar5,uVar2,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  if (DAT_ram_00a5a978 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a978 = '\x01';
		  }
		  iVar7 = Core_Gameplay_Managers_DiscountsManager__Handle
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 8),0);
		  iVar8 = *(int *)(param1 + 0x14);
		  if (iVar7 == 0) {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x20);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x248);
		          goto code_r0x8129e5c7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x8129e5c7:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = *(int *)(param1 + 0x14);
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0x1c);
		    iVar7 = iVar8;
		  }
		  *(undefined4 *)(iVar8 + 0x2c) = uVar2;
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_Aprs_Controller_AprsController_TypeInfo);
		  Gameplay_Aprs_Controller_AprsController__Dispose(uVar2,iVar7,uVar4,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x06006790 RID: 26512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006790")]
		[Address(RVA = "0xB2BC", Offset = "0xB2BC", VA = "0xB2BC")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_AprsManager__SetupMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0xec));
		  Gameplay_Aprs_Discounts_Discounts__set_IsDisposed(*(undefined4 *)(param1 + 0x1c),0);
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006791 RID: 26513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006791")]
		[Address(RVA = "0xB2BD", Offset = "0xB2BD", VA = "0xB2BD")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		void Core_Gameplay_Managers_AprsManager__DestroyMvc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a97a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AprsManager_ControllerInitEvent__);
		    DAT_ram_00a5a97a = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_AprsManager_ControllerInitEvent__,0);
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

		// Token: 0x06006792 RID: 26514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006792")]
		[Address(RVA = "0xB2BE", Offset = "0xB2BE", VA = "0xB2BE")]
		private void ControllerInitEvent()
		{
		/* --- GHIDRA: ControllerInitEvent ---
		void Core_Gameplay_Managers_AprsManager__ControllerInitEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a97b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a97b = '\x01';
		  }
		  Gameplay_Aprs_Discounts_Discounts__Handle(*(undefined4 *)(param1 + 0x1c),0);
		  Gameplay_Aprs_Model_AprDicGroupStorage__Collect(*(undefined4 *)(param1 + 0x24),0);
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  param1_01 = *(int **)(param1 + 0x20);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x8129e8af;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129e8af:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Gameplay_Aprs_Model_AprDicGroupStorage___ctor(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006793 RID: 26515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006793")]
		[Address(RVA = "0xB2BF", Offset = "0xB2BF", VA = "0xB2BF")]
		private void HandleDictProviderChanged()
		{
		/* --- GHIDRA: HandleDictProviderChanged ---
		void Core_Gameplay_Managers_AprsManager__HandleDictProviderChanged(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a97c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_AprsManager_HandleDictProviderChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_AprsManager_ResolveDiscountsProvider__);
		    DAT_ram_00a5a97c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_AprsManager_ResolveDiscountsProvider__,0);
		  Core_Data_UserData__add_OnUserLevelChangedEvent(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x18);
		  uVar2 = *(undefined4 *)(iVar3 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_AprsManager_HandleDictProviderChanged__,0);
		  param1_00 = (int *)func_ii_7048(uVar2,uVar1,0);
		  iVar4 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar3 + 0x1c) = param1_00, *param1_00 != iVar4)) {
		    System_Activator__CreateInstance(param1_00,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar4 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar4 + 0xec));
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xec));
		  Gameplay_Aprs_Discounts_Discounts__set_IsDisposed(*(undefined4 *)(param1 + 0x1c),0);
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  Gameplay_Aprs_Model_AprDicGroupStorage__Reset(*(undefined4 *)(param1 + 0x24),0);
		  *(undefined4 *)(param1 + 0x24) = 0;
		  iVar4 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		            (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006794 RID: 26516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006794")]
		[Address(RVA = "0xB2C0", Offset = "0xB2C0", VA = "0xB2C0", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_AprsManager__Deinit
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  uint uVar4;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a97d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    DAT_ram_00a5a97d = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Aprs_Model_AprsModel__TryGetAprDataByAprId
		                    (*(undefined4 *)(param1 + 0x14),param2,*(undefined4 *)(param3 + 0xc),&local_4,0)
		  ;
		  uVar2 = local_4;
		  if (iVar1 != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_AprData___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_AprData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = local_4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,local_4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		              (param1_00,uVar2,param1_00,*(undefined4 *)(param1 + 0x10),
		               *(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x14),param1_00);
		    return;
		  }
		  local_8 = *(undefined4 *)(param3 + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  local_c = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  param1_01 = unnamed_function_2232(&StringLiteral_3184);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey(param1_01,uVar2,uVar3,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Gameplay_Managers_AprsManager_ShowOwnAprInfoWindow__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006795 RID: 26517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006795")]
		[Address(RVA = "0xB2C1", Offset = "0xB2C1", VA = "0xB2C1")]
		public void ShowOwnAprInfoWindow(uint medalId, AprDic dict)
		{
		/* --- GHIDRA: ShowOwnAprInfoWindow ---
		void Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a97e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    DAT_ram_00a5a97e = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Aprs_Model_AprsModel___ctor
		                    (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param2 + 0xc),&local_4,0);
		  uVar2 = local_4;
		  if (iVar1 != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_AprData___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_AprData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = local_4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,local_4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		              (param1_00,uVar2,param1_00,*(undefined4 *)(param1 + 0x10),
		               *(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x14),param1_00);
		    return;
		  }
		  local_8 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar3 = unnamed_function_2232(&StringLiteral_3183);
		  uVar2 = func_ii_4419(uVar3,uVar2,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Gameplay_Managers_AprsManager_ShowOwnAprInfoWindow__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: ShowOwnAprInfoWindow ---
		void Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a97e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    DAT_ram_00a5a97e = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Aprs_Model_AprsModel___ctor
		                    (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param2 + 0xc),&local_4,0);
		  uVar2 = local_4;
		  if (iVar1 != 0) {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_AprData___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_AprData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = local_4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,local_4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		              (param1_00,uVar2,param1_00,*(undefined4 *)(param1 + 0x10),
		               *(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x14),param1_00);
		    return;
		  }
		  local_8 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar3 = unnamed_function_2232(&StringLiteral_3183);
		  uVar2 = func_ii_4419(uVar3,uVar2,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Gameplay_Managers_AprsManager_ShowOwnAprInfoWindow__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006796 RID: 26518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006796")]
		[Address(RVA = "0xB2C2", Offset = "0xB2C2", VA = "0xB2C2")]
		public void ShowOwnAprInfoWindow(AprDic aprDic)
		{
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006797")]
		[Address(RVA = "0xB2C3", Offset = "0xB2C3", VA = "0xB2C3")]
		public void ShowAprInfoWindow(AprData aprData, List<AprData> currentAprListList, AprsController controller, AprsEvents events, AprsModel model)
		{
		/* --- GHIDRA: ShowAprInfoWindow ---
		void Core_Gameplay_Managers_AprsManager__ShowAprInfoWindow(undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_AprsManager__ShowAprsWindow(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006798 RID: 26520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006798")]
		[Address(RVA = "0xB2C4", Offset = "0xB2C4", VA = "0xB2C4")]
		public void ShowAprsWindow()
		{
		/* --- GHIDRA: ShowAprsWindow ---
		undefined4 Core_Gameplay_Managers_AprsManager__ShowAprsWindow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a981 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3292);
		    DAT_ram_00a5a981 = '\x01';
		  }
		  return StringLiteral_3292;
		}
		*/

		/* --- GHIDRA: ShowAprsWindow ---
		undefined4 Core_Gameplay_Managers_AprsManager__ShowAprsWindow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a981 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3292);
		    DAT_ram_00a5a981 = '\x01';
		  }
		  return StringLiteral_3292;
		}
		*/

		}

		// Token: 0x06006799 RID: 26521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006799")]
		[Address(RVA = "0xB2C5", Offset = "0xB2C5", VA = "0xB2C5")]
		public void ShowAprsWindow(Predicate<AprData> customFilter)
		{
		}

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x10")]
		private AprsController _controller;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x14")]
		private AprsModel _model;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x18")]
		private AprsEvents _events;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x1C")]
		private Discounts _discounts;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_AprsManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a973 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a973 = '\x01';
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
		void Core_Gameplay_Managers_AprsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a974 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a974 = '\x01';
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
		void Core_Gameplay_Managers_AprsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a975 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a975 = '\x01';
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
		void Core_Gameplay_Managers_AprsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a976 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a976 = '\x01';
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
