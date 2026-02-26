using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Application;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.HeavensBank.HeavensBankPage
{
	// Token: 0x02000C21 RID: 3105
	[Token(Token = "0x2000C21")]
	public class HeavensBankPageBillingProvider : IBillingProvider, IDisposable
	{
		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x17000F47")]
		public BillingProviderId ProviderId
		{
			[Token(Token = "0x6004BCB")]
			[Address(RVA = "0x9A0F", Offset = "0x9A0F", VA = "0x9A0F", Slot = "4")]
			get
			{
				return BillingProviderId.Unknown;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004BCD RID: 19405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F48")]
		public HeavensBankService BankService
		{
			[Token(Token = "0x6004BCC")]
			[Address(RVA = "0x9A10", Offset = "0x9A10", VA = "0x9A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BCD")]
			[Address(RVA = "0x9A11", Offset = "0x9A11", VA = "0x9A11")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004BCF RID: 19407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F49")]
		public IApp App
		{
			[Token(Token = "0x6004BCE")]
			[Address(RVA = "0x9A12", Offset = "0x9A12", VA = "0x9A12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BCF")]
			[Address(RVA = "0x9A13", Offset = "0x9A13", VA = "0x9A13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x9A14", Offset = "0x9A14", VA = "0x9A14", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x9A15", Offset = "0x9A15", VA = "0x9A15")]
		public HeavensBankPageBillingProvider(IApp app, Uri bankPage, HeavensBankService bankService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60963 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse__AddResultHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass13_0__RunPurchaseWhitDraw_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass13_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_18830);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a60963 = '\x01';
		  }
		  param3_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass13_0_TypeInfo
		                        );
		  *(undefined4 *)(param3_00 + 8) = param3;
		  uVar1 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor(param2,0);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_18830,uVar1,StringLiteral_19094,0);
		  uVar1 = Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService__GetBalance
		                    (uVar2,uVar1,param3_00);
		  uVar2 = unnamed_function_1417
		                    (System_Action_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param3_00,
		             Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass13_0__RunPurchaseWhitDraw_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,uVar2,0,
		             Method_Utils_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x9A16", Offset = "0x9A16", VA = "0x9A16")]
		private void RunPurchaseWhitDraw(HVBillingVo.OptionItemRequest option, Action<bool> callback)
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x9A17", Offset = "0x9A17", VA = "0x9A17", Slot = "5")]
		public void SetToken(string value)
		{
		/* --- GHIDRA: SetToken ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider__SetToken
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60964 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Utils_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse__AddResultHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass15_0__GetBalance_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass15_0_TypeInfo
		              );
		    DAT_ram_00a60964 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass15_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___ctor
		                        (*(undefined4 *)(param1 + 0xc),param2_00);
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Action_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse___TypeInfo
		                        );
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass15_0__GetBalance_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,
		             Method_Utils_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x9A18", Offset = "0x9A18", VA = "0x9A18", Slot = "6")]
		public void GetBalance(Action<float> callback)
		{
		/* --- GHIDRA: GetBalance ---
		undefined4
		Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider__GetBalance
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Billing_Model_AbstractBillingModel__Init(param2,param2);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x9A19", Offset = "0x9A19", VA = "0x9A19", Slot = "7")]
		public string GetCurrencyCode(AbstractBillingModel model)
		{
		/* --- GHIDRA: GetCurrencyCode ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider__GetCurrencyCode
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  double dVar9;
		  double dVar10;
		  uint uVar11;
		  float4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60965 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_View_HeavensBankWindow_HeavensBankWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_IManagedWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_HeavensBankWindow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_OpenPaymentWindowRequestPurchase_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Resources_Load_HeavensBankWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass17_0__RunPurchase_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass17_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_UriBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Uri_UriQuery_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22128);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27928);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26509);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12572);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a60965 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass17_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param5;
		  *(int *)(iVar1 + 0xc) = param1;
		  *(int *)(iVar1 + 8) = param2;
		  dVar9 = *(double *)(param2 + 0x18);
		  dVar10 = *(double *)(*(int *)(param3 + 0x18) + 8);
		  if (dVar10 <= dVar9) {
		    uVar4 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,iVar1,
		               Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider___c__DisplayClass17_0__RunPurchase_b__0__
		               ,0);
		    Gameplay_Bank_View_BankConfirmBuyOptionWindow__get_WindowId(param3,uVar4,0);
		  }
		  else {
		    uVar11 = 0;
		    iVar2 = unnamed_function_1417
		                      (
		                      Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_OpenPaymentWindowRequestPurchase_TypeInfo
		                      );
		    *(double *)(iVar2 + 8) = dVar10 - dVar9;
		    iVar5 = *(int *)(iVar1 + 8);
		    piVar6 = *(int **)(iVar5 + 0x30);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + iVar7 + 0xd8);
		          goto code_r0x81d05e66;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo,
		                                  3);
		code_r0x81d05e66:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,iVar5,puVar3[1]);
		    *(undefined4 *)(iVar2 + 0x10) = uVar4;
		    uVar4 = *(undefined4 *)(param1 + 8);
		    uVar11 = 0;
		    piVar6 = (int *)unnamed_function_1417(Utils_Uri_UriQuery_TypeInfo);
		    Utils_Uri_UriQuery___ctor(piVar6,uVar4,0);
		    local_8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar1 + 8) + 8),0);
		    uVar4 = func_ii_8783(&local_8,0);
		    Utils_Uri_UriQuery___ctor(piVar6,StringLiteral_27928,uVar4,0);
		    uVar4 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor(iVar2,0);
		    Utils_Uri_UriQuery___ctor(piVar6,StringLiteral_26217,uVar4,0);
		    Utils_Uri_UriQuery___ctor(piVar6,StringLiteral_22128,param4,0);
		    local_c = (float4)func_ii_18581(0);
		    iVar2 = System_Collections_Generic_List_float___GetEnumerator(&local_c,0);
		    if (iVar2 == 0) {
		      iVar2 = StringLiteral_5;
		    }
		    Utils_Uri_UriQuery___ctor(piVar6,StringLiteral_26509,iVar2,0);
		    uVar8 = *(undefined4 *)(param1 + 8);
		    uVar4 = unnamed_function_1417(System_UriBuilder_TypeInfo);
		    System_Uri__get_IsAbsoluteUri(uVar4,uVar8,0);
		    uVar8 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xd8) * 4))
		                      (piVar6,*(undefined4 *)(*piVar6 + 0xdc));
		    System_String__Split(uVar4,uVar8,0);
		    uVar8 = UnityEngine_Resources__GetBuiltinResource_object_
		                      (StringLiteral_12572,Method_UnityEngine_Resources_Load_HeavensBankWindow___);
		    piVar6 = *(int **)(param1 + 0x10);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar11 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar11 * 8 + 4) * 8 + iVar2 + 0x150);
		          goto code_r0x81d05ff1;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar11);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,0x12);
		code_r0x81d05ff1:
		    param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    piVar6 = (int *)func_ii_6805(uVar8,param2_00,
		                                 Method_UnityEngine_Object_Instantiate_HeavensBankWindow___);
		    uVar4 = System_UriBuilder__set_Path(uVar4,0);
		    iVar2 = unnamed_function_1417
		                      (Gameplay_Billing_View_HeavensBankWindow_HeavensBankWindowArgs_TypeInfo);
		    UI_Windows_BaseWindowArgs__Dispose(iVar2,0);
		    *(undefined4 *)(iVar2 + 0x18) = uVar4;
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        if (UI_Windows_IManagedWindow_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8 + 4) * 8 + iVar5 + 0xe8);
		          goto code_r0x81d060c2;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,UI_Windows_IManagedWindow_TypeInfo,5);
		code_r0x81d060c2:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,iVar2,puVar3[1]);
		    iVar1 = *(int *)(iVar1 + 0x10);
		    uVar4 = unnamed_function_1417
		                      (
		                      Gameplay_Billing_BillingProvider_HeavensBank_HVBillingVo_PaymentStatusChangedResponse_TypeInfo
		                      );
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x9A1A", Offset = "0x9A1A", VA = "0x9A1A", Slot = "8")]
		public void RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, Action<HVBillingVo.PaymentStatusChangedResponse> callback)
		{
		/* --- GHIDRA: RunPurchase ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider__RunPurchase
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider_RunPurchase__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: RunPurchase ---
		void Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider__RunPurchase
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider_RunPurchase__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x9A1B", Offset = "0x9A1B", VA = "0x9A1B", Slot = "9")]
		public UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, CancellationToken cancellationToken)
		{
			return default(UniTask<HVBillingVo.PaymentStatusChangedResponse>);
		}

		// Token: 0x04002948 RID: 10568
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x8")]
		public readonly Uri BankPage;
	}
}
