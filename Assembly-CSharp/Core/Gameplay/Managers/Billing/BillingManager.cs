using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Billing.PurchaseProcess;
using Gameplay.Billing.Controller;
using Gameplay.Billing.Events;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Billing
{
	// Token: 0x020011F0 RID: 4592
	[Token(Token = "0x20011F0")]
	public class BillingManager : IGameManager, IBaseManager
	{
		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06006D14 RID: 27924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001632")]
		public string Name
		{
			[Token(Token = "0x6006D14")]
			[Address(RVA = "0xB7FD", Offset = "0xB7FD", VA = "0xB7FD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002CF RID: 719
		// (add) Token: 0x06006D15 RID: 27925 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D16 RID: 27926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CF")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006D15")]
			[Address(RVA = "0xB7FE", Offset = "0xB7FE", VA = "0xB7FE", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D16")]
			[Address(RVA = "0xB7FF", Offset = "0xB7FF", VA = "0xB7FF", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002D0 RID: 720
		// (add) Token: 0x06006D17 RID: 27927 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D18 RID: 27928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002D0")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006D17")]
			[Address(RVA = "0xB800", Offset = "0xB800", VA = "0xB800", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D18")]
			[Address(RVA = "0xB801", Offset = "0xB801", VA = "0xB801", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001633")]
		public BillingEvents Events
		{
			[Token(Token = "0x6006D19")]
			[Address(RVA = "0xB802", Offset = "0xB802", VA = "0xB802")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D1A")]
			[Address(RVA = "0xB803", Offset = "0xB803", VA = "0xB803")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D1C RID: 27932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001634")]
		public IPurchaseProcess PurchaseProcess
		{
			[Token(Token = "0x6006D1B")]
			[Address(RVA = "0xB804", Offset = "0xB804", VA = "0xB804")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D1C")]
			[Address(RVA = "0xB805", Offset = "0xB805", VA = "0xB805")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006D1E RID: 27934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001635")]
		public AbstractBillingModel Model
		{
			[Token(Token = "0x6006D1D")]
			[Address(RVA = "0xB806", Offset = "0xB806", VA = "0xB806")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D1E")]
			[Address(RVA = "0xB807", Offset = "0xB807", VA = "0xB807")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0xB808", Offset = "0xB808", VA = "0xB808")]
		public BillingManager(IGame game, IAuthDataProvider authDataProvider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Billing_BillingManager___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x1c),0);
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D20")]
		[Address(RVA = "0xB809", Offset = "0xB809", VA = "0xB809", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Billing_BillingManager__Deinit(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5a74d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Billing_BillingManager_HandleInitEvent__);
		    DAT_ram_00a5a74d = '\x01';
		  }
		  Core_Gameplay_Managers_Billing_BillingManager__HandleInitEvent(param1,param1);
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_Billing_BillingManager_HandleInitEvent__
		             ,0);
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
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0xB80A", Offset = "0xB80A", VA = "0xB80A", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Billing_BillingManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5a74e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Billing_BillingManager_HandleInitEvent__);
		    DAT_ram_00a5a74e = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_Billing_BillingManager_HandleInitEvent__
		             ,0);
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

		// Token: 0x06006D22 RID: 27938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D22")]
		[Address(RVA = "0xB80B", Offset = "0xB80B", VA = "0xB80B")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Core_Gameplay_Managers_Billing_BillingManager__HandleInitEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 param6;
		  
		  if (DAT_ram_00a5a74f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_Events_BillingEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Currencies_CurrencyConverterInfoLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Currencies_CurrencyConverter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Billing_PurchaseProcess_DefaultPurchaseProcess_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_Controller_HvBillingController_WebGL_Factory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6003);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22112);
		    DAT_ram_00a5a74f = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x81265877;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81265877:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x812658f9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,10);
		code_r0x812658f9:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8126597a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,0);
		code_r0x8126597a:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar6 = *(undefined4 *)(iVar5 + 0x14);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x81265a02;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81265a02:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81265a84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,10);
		code_r0x81265a84:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar5 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x81265b05;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,1);
		code_r0x81265b05:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar7 = *(undefined4 *)(iVar5 + 0x18);
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  uVar3 = func_ii_8896(0);
		  if (*(int *)(System_IO_Path_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_IO_Path_TypeInfo);
		  }
		  uVar3 = UnityEngine_Application__get_persistentDataPath(uVar3,StringLiteral_22112,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  if (DAT_ram_00a5a779 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a5a779 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  param6 = **(undefined4 **)(OKG_Logs_Debug_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(OKG_Currencies_CurrencyConverterInfoLoader_TypeInfo);
		  OKG_Currencies_CurrencyConverterInfoLoader__get_CurrentCurrenciesInfo
		            (param1_00,uVar6,uVar7,uVar3,StringLiteral_6003,param6,0);
		  if (DAT_ram_00a5a779 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    DAT_ram_00a5a779 = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar7 = **(undefined4 **)(OKG_Logs_Debug_TypeInfo + 0x5c);
		  uVar6 = unnamed_function_1417(OKG_Currencies_CurrencyConverter_TypeInfo);
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar6,param1_00,uVar7,0);
		  uVar7 = unnamed_function_1417(Gameplay_Billing_Events_BillingEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar7;
		  uVar7 = unnamed_function_1417
		                    (Gameplay_Billing_Controller_HvBillingController_WebGL_Factory_TypeInfo);
		  uVar6 = Gameplay_Billing_Controller_HvBillingController_HvBank_Factory___ctor
		                    (uVar7,*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param1 + 0x28),
		                     *(undefined4 *)(param1 + 0x10),uVar6,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar6;
		  iVar5 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Billing_PurchaseProcess_DefaultPurchaseProcess_TypeInfo)
		  ;
		  *(undefined4 *)(iVar5 + 8) = uVar6;
		  *(int *)(param1 + 0x14) = iVar5;
		  iVar5 = **(int **)(param1 + 0x1c);
		  uVar6 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar5 + 0x104));
		  *(undefined4 *)(param1 + 0x18) = uVar6;
		  return;
		}
		*/

		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D23")]
		[Address(RVA = "0xB80C", Offset = "0xB80C", VA = "0xB80C")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Core_Gameplay_Managers_Billing_BillingManager__SetupMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0x134));
		  return;
		}
		*/

		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D24")]
		[Address(RVA = "0xB80D", Offset = "0xB80D", VA = "0xB80D")]
		public void ConsumePurchasesIfExist()
		{
		}

		// Token: 0x04003912 RID: 14610
		[Token(Token = "0x4003912")]
		public const string DefaultBillingPlayerPrefsName = "defaultBillingId";

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0x1C")]
		private AbstractBillingController _controller;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0x20")]
		private readonly IAuthTokenSource _bankTokenSource;

		// Token: 0x0400391A RID: 14618
		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0x24")]
		private readonly IAuthDataProvider _authDataProvider;

		// Token: 0x0400391B RID: 14619
		[Token(Token = "0x400391B")]
		[FieldOffset(Offset = "0x28")]
		private readonly IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Billing_BillingManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a748 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a748 = '\x01';
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
		void Core_Gameplay_Managers_Billing_BillingManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a749 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a749 = '\x01';
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
		void Core_Gameplay_Managers_Billing_BillingManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a74a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a74a = '\x01';
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
		void Core_Gameplay_Managers_Billing_BillingManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a74b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a74b = '\x01';
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
		void Core_Gameplay_Managers_Billing_BillingManager__set_Model
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a74c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_AuthTokenSourceEternal_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_AuthTokenSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27699);
		    DAT_ram_00a5a74c = '\x01';
		  }
		  *(int **)(param1 + 0x24) = param3;
		  *(int **)(param1 + 0x28) = param2;
		  iVar5 = *param3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812654f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x812654f7:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  if (*(char *)(iVar5 + 0x29) == '\0') {
		    uVar4 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    uVar3 = unnamed_function_1417(Core_Gameplay_AuthTokenSourceEternal_TypeInfo);
		    UnityEngine_Purchasing_Default_WinProductDescription__set_platformSpecificID(uVar3,uVar4,0);
		    *(undefined4 *)(param1 + 0x20) = uVar3;
		    return;
		  }
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x81265578;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81265578:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x812655f6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0x17);
		code_r0x812655f6:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Analytics_Okg_OkgAnalytics__CreateTempToken
		                    (*(undefined4 *)(iVar5 + 0x10),StringLiteral_27699,0);
		  uVar4 = unnamed_function_1417(Core_Gameplay_AuthTokenSource_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x20) = uVar4;
		  return;
		}
		*/

}
