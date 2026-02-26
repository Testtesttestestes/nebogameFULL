using System;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.Events;
using Gameplay.Billing.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using OKG.Currencies;
using Protocol.Services;
using Utils;

namespace Gameplay.Billing.Controller
{
	// Token: 0x02000BF8 RID: 3064
	[Token(Token = "0x2000BF8")]
	public class HvBillingController : AbstractBillingController
	{
		// Token: 0x06004B19 RID: 19225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x9973", Offset = "0x9973", VA = "0x9973")]
		private HvBillingController(CurrencyConverter currencyConverter, AbstractBillingModel model, BillingEvents events)
		{
		/* --- GHIDRA: <HandleGetPaymentDataService>b__9_0 ---
		int Gameplay_Billing_Controller_HvBillingController___HandleGetPaymentDataService_b__9_0
		              (undefined4 param1,undefined4 param2,int *param3,undefined4 param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined8 uVar7;
		  int iVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a60936 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_Controller_HvBillingController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_Model_HvBillingModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24470);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24469);
		    DAT_ram_00a60936 = '\x01';
		  }
		  iVar8 = *param3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x81d00769;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81d00769:
		  uVar1 = 0;
		  uVar7 = CONCAT44(in_register_20000004,param3);
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(uVar7,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_24470,0);
		  iVar8 = *param3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x81d007ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81d007ff:
		  uVar7 = CONCAT44(uVar5,param3);
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(uVar7,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar4,StringLiteral_24469,0);
		  iVar8 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		  if ((iVar8 != 0) ||
		     (iVar8 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar4,0)
		     , iVar8 != 0)) {
		    uVar5 = unnamed_function_2232(&StringLiteral_3877);
		    uVar6 = unnamed_function_2232(&StringLiteral_1277);
		    uVar5 = System_Int32__ToString(uVar5,uVar3,uVar6,uVar4,0);
		    uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar3 = unnamed_function_1417(uVar3);
		    System_String__Concat(uVar3,uVar5,0);
		    uVar5 = unnamed_function_2232
		                      (&
		                       Method_Gameplay_Billing_Controller_HvBillingController_HvBank_Factory_Create__
		                      );
		    func_ii_1050(uVar3,uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = 0;
		  iVar8 = *param3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x81d008a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81d008a5:
		  uVar1 = 0;
		  uVar7 = CONCAT44(uVar5,param3);
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(uVar7,puVar2[1]);
		  uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  iVar8 = *param3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x81d00927;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81d00927:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar5,param3),puVar2[1]);
		  param1_00 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(param1_00,uVar3,0);
		  uVar3 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar3,uVar4,0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  uVar4 = 0x404e0000;
		  uVar7 = System_Threading_CancellationTokenSource___ctor(60.0,0);
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService_TypeInfo
		                        );
		  Core_Gameplay_AuthTokenSourceEternal___ctor(param1_01,uVar3,param2,uVar7,0);
		  iVar8 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankPageBillingProvider_TypeInfo
		                    );
		  *(undefined4 *)(iVar8 + 0xc) = param1_01;
		  *(undefined4 *)(iVar8 + 8) = param1_00;
		  *(undefined4 *)(iVar8 + 0x10) = uVar5;
		  iVar9 = *param3;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x140);
		        goto code_r0x81d00a30;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81d00a30:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar4,param3),puVar2[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  iVar9 = unnamed_function_1417(Gameplay_Billing_Model_HvBillingModel_TypeInfo);
		  if (DAT_ram_00a60907 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_List_string____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_List_string___TypeInfo);
		    DAT_ram_00a60907 = '\x01';
		  }
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Queue_List_string___TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar3,Method_System_Collections_Generic_Queue_List_string____ctor__);
		  *(undefined4 *)(iVar9 + 0x2c) = uVar3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar9,uVar5,0);
		  *(int *)(iVar9 + 0x30) = iVar8;
		  *(undefined4 *)(iVar9 + 0x28) = param2;
		  *(undefined4 *)(iVar9 + 0x34) = uVar6;
		  *(int **)(iVar9 + 0x10) = param3;
		  Gameplay_Billing_Model_AbstractBillingModel___ctor(iVar9,iVar9);
		  iVar8 = unnamed_function_1417(Gameplay_Billing_Controller_HvBillingController_TypeInfo);
		  if (DAT_ram_00a6092a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AbstractBillingModel__BillingEvents___ctor__);
		    DAT_ram_00a6092a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar8,iVar9,param4,
		             Method_MVC_AbstractController_AbstractBillingModel__BillingEvents___ctor__);
		  *(undefined4 *)(iVar8 + 0x18) = param5;
		  return iVar8;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Billing_Controller_HvBillingController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6092e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_Controller_HvBillingController_OnExternalMoneyChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6092e = '\x01';
		  }
		  Gameplay_Billing_Controller_AbstractBillingController___ctor(param1,param1);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  param1_01 = unnamed_function_1417(System_Action_double__TypeInfo);
		  System_Action_DictionaryEntry___Invoke
		            (param1_01,param1,
		             Method_Gameplay_Billing_Controller_HvBillingController_OnExternalMoneyChangedEvent__,0)
		  ;
		  ServicesNamespace_BalanceService__add_ExternalMoneyChangedEvent(param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x9974", Offset = "0x9974", VA = "0x9974", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Billing_Controller_HvBillingController__HandleStop
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6092f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_double__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_Controller_HvBillingController_OnExternalMoneyChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6092f = '\x01';
		  }
		  Gameplay_Billing_Controller_AbstractBillingController__HandleStop(param1,param1);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param1_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  param1_01 = unnamed_function_1417(System_Action_double__TypeInfo);
		  System_Action_DictionaryEntry___Invoke
		            (param1_01,param1,
		             Method_Gameplay_Billing_Controller_HvBillingController_OnExternalMoneyChangedEvent__,0)
		  ;
		  ServicesNamespace_BalanceService__remove_BalanceChangedEvent(param1_00,param1_01,0);
		  Gameplay_Billing_Controller_HvBillingController__OnExternalMoneyChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x9975", Offset = "0x9975", VA = "0x9975", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Billing_Controller_HvBillingController__HandleRun
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 param5;
		  undefined4 uVar8;
		  double dVar9;
		  uint uVar10;
		  
		  if (DAT_ram_00a60930 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_BuyOptionEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Currencies_CurrencyConverter_CurrencyErrorDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Currencies_CurrencyConverter_CurrencySuccessDelegate_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_RefPayInfoEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Controller_HvBillingController___c__DisplayClass3_0__RefPayHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Controller_HvBillingController___c__DisplayClass3_0__RefPayHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_Controller_HvBillingController___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a60930 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_Controller_HvBillingController___c__DisplayClass3_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2_00 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar10 = 0;
		  piVar7 = *(int **)(iVar1 + 0x10);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xe0);
		        goto code_r0x81cff72b;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cff72b:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar10 = 0;
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0x100);
		        goto code_r0x81cff7ad;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,8);
		code_r0x81cff7ad:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  iVar1 = *(int *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x20) + 0x40);
		  if (iVar1 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar10 = 0;
		    piVar7 = *(int **)(iVar3 + 0x10);
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x81cff851;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cff851:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar6 = *(undefined4 *)(iVar3 + 0x10);
		    uVar8 = *(undefined4 *)(param3 + 0x10);
		    param5 = *(undefined4 *)(param2_00 + 0xc);
		    uVar5 = unnamed_function_1417(Core_Events_Scopes_BillingScope_RefPayInfoEventArgs_TypeInfo);
		    Core_Events_Scopes_BillingScope_BuyOptionEventArgs___ctor(uVar5,uVar4,uVar6,1,param5,uVar8,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar5,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar10 = 0;
		  piVar7 = *(int **)(iVar1 + 0x10);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0xe0);
		        goto code_r0x81cff949;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cff949:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar10 = 0;
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1 + 0x100);
		        goto code_r0x81cff9cb;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,8);
		code_r0x81cff9cb:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  iVar1 = *(int *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x20) + 0x18);
		  if (iVar1 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar10 = 0;
		    piVar7 = *(int **)(iVar3 + 0x10);
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x81cffa6f;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81cffa6f:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar6 = *(undefined4 *)(iVar3 + 0x10);
		    uVar8 = *(undefined4 *)(param2_00 + 0xc);
		    uVar5 = unnamed_function_1417(Core_Events_Scopes_BillingScope_BuyOptionEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (uVar5,uVar4,uVar6,1,uVar8,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar5,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = param1[6];
		  if (iVar1 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar7 = *(int **)(iVar3 + 0x30);
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar10 = 0;
		    iVar3 = *piVar7;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + iVar3 + 0xd8);
		          goto code_r0x81cffb81;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo,
		                                  3);
		code_r0x81cffb81:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar4,puVar2[1]);
		    dVar9 = *(double *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x18) + 8);
		    uVar5 = unnamed_function_1417(OKG_Currencies_CurrencyConverter_CurrencySuccessDelegate_TypeInfo)
		    ;
		    OKG_Currencies_CurrencyConverter__HandleQueue
		              (uVar5,param2_00,
		               Method_Gameplay_Billing_Controller_HvBillingController___c__DisplayClass3_0__RefPayHandler_b__0__
		               ,0);
		    uVar6 = unnamed_function_1417(OKG_Currencies_CurrencyConverter_CurrencyErrorDelegate_TypeInfo);
		    OKG_Currencies_CurrencyConverter_CurrencySuccessDelegate__EndInvoke
		              (uVar6,param2_00,
		               Method_Gameplay_Billing_Controller_HvBillingController___c__DisplayClass3_0__RefPayHandler_b__1__
		               ,0);
		    OKG_Currencies_CurrencyConverter___ctor(iVar1,uVar4,(float)dVar9,uVar5,uVar6,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x9976", Offset = "0x9976", VA = "0x9976", Slot = "12")]
		protected override void RefPayHandler(BankOptionData option, RefPayEvt msg)
		{
		/* --- GHIDRA: RefPayHandler ---
		void Gameplay_Billing_Controller_HvBillingController__RefPayHandler
		               (int *param1,double param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(double *)(iVar1 + 0x18) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x9977", Offset = "0x9977", VA = "0x9977")]
		private void OnExternalMoneyChangedEvent(double balance)
		{
		/* --- GHIDRA: OnExternalMoneyChangedEvent ---
		void Gameplay_Billing_Controller_HvBillingController__OnExternalMoneyChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  int *param1_01;
		  
		  if (DAT_ram_00a60931 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Controller_HvBillingController_GetBankBalanceResponseHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo);
		    DAT_ram_00a60931 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0x30);
		  param1_00 = unnamed_function_1417(System_Action_float__TypeInfo);
		  System_Action_SerializedCommand___Invoke
		            (param1_00,param1,
		             Method_Gameplay_Billing_Controller_HvBillingController_GetBankBalanceResponseHandler__,
		             0);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x81cff5d8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo
		                                ,2);
		code_r0x81cff5d8:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1_00,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x9978", Offset = "0x9978", VA = "0x9978")]
		private void RequestBankBalance()
		{
		/* --- GHIDRA: RequestBankBalance ---
		void Gameplay_Billing_Controller_HvBillingController__RequestBankBalance
		               (int *param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(bool *)(iVar1 + 0x20) = (uint)ABS(param2) < 0x7f800001;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(double *)(iVar1 + 0x18) = (double)param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x9979", Offset = "0x9979", VA = "0x9979")]
		private void GetBankBalanceResponseHandler(float value)
		{
		/* --- GHIDRA: GetBankBalanceResponseHandler ---
		int Gameplay_Billing_Controller_HvBillingController__GetBankBalanceResponseHandler
		              (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60932 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60932 = '\x01';
		  }
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0xfc));
		  if (iVar3 == 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar2 = *(int **)(iVar4 + 0x10);
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1a8);
		          goto code_r0x81cffd8f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x81cffd8f:
		    param1_00 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		    Core_Gameplay_Managers_ProgressSaverManager__ShowProgressSaverWindow(param1_00,0);
		  }
		  return iVar3;
		}
		*/

		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x997A", Offset = "0x997A", VA = "0x997A")]
		private bool ValidatePurchasesAvail()
		{
		/* --- GHIDRA: ValidatePurchasesAvail ---
		void Gameplay_Billing_Controller_HvBillingController__ValidatePurchasesAvail
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  uint uVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60933 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_Controller_HvBillingController_HandleGetPaymentDataService__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OptionEntry__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OptionEntry___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_OptionEntry__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_OptionEntry_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24502);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1288);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8818);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27735);
		    DAT_ram_00a60933 = '\x01';
		  }
		  iVar1 = Gameplay_Billing_Controller_HvBillingController__GetBankBalanceResponseHandler(param1,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x24) = param2;
		    iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,6);
		    *(undefined4 *)(iVar1 + 0x10) = StringLiteral_8818;
		    local_4 = Com_TheFallenGames_OSA_Core_OSA_object__object___get_Parameters(param2,0);
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_24502,uVar2,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    *(undefined4 *)(iVar1 + 0x18) = StringLiteral_27735;
		    *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(param2 + 0x48);
		    *(undefined4 *)(iVar1 + 0x20) = StringLiteral_1288;
		    *(undefined4 *)(iVar1 + 0x24) = *(undefined4 *)(param2 + 0x4c);
		    uVar2 = System_Single__ToString(iVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar1 = unnamed_function_1417(Protocol_Services_OptionEntry_TypeInfo);
		    Protocol_Services_OptionEntry__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_02 = *(int **)(iVar3 + 0x10);
		    iVar3 = *param1_02;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar5 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x198);
		          goto code_r0x81cfffbe;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x1b);
		code_r0x81cfffbe:
		    iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		    Protocol_Services_OptionEntry__get_CurrencyCode
		              (iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x18) + 0xc) + 0x10),0);
		    *(undefined8 *)(iVar1 + 0x18) = *(undefined8 *)(*(int *)(param2 + 0x18) + 8);
		    uVar2 = Com_TheFallenGames_OSA_Core_OSA_object__object___get_Parameters(param2,0);
		    *(undefined4 *)(iVar1 + 0xc) = uVar2;
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_OptionEntry__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_OptionEntry___ctor__);
		    iVar3 = Method_System_Collections_Generic_List_OptionEntry__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = iVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		    uVar2 = ServicesNamespace_ServicesService__GetPaymentBonus(uVar2,param1_00,0,0);
		    param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,param1,
		               Method_Gameplay_Billing_Controller_HvBillingController_HandleGetPaymentDataService__,
		               0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x997B", Offset = "0x997B", VA = "0x997B")]
		private void BuyOptionInternal(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: BuyOptionInternal ---
		void Gameplay_Billing_Controller_HvBillingController__BuyOptionInternal
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int *param1_01;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_02;
		  
		  if (DAT_ram_00a60934 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_HVBillingVo_PaymentStatusChangedResponse__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_HvExpectedGetPaymentDataErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Controller_HvBillingController__HandleGetPaymentDataService_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetPaymentDataAns_TypeInfo);
		    DAT_ram_00a60934 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoGetPaymentDataAns_TypeInfo != *param1_00)
		     ) {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoGetPaymentDataAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Bank_Model_BankOptionData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Gameplay_Bank_Model_BankOptionData_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Bank_Model_BankOptionData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Gameplay_Bank_Model_BankOptionData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = *(undefined4 *)(iVar2 + 0x10);
		  uVar3 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		                    );
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar3,uVar5,param1_00,param1_01,0);
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[4],uVar3,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_HvExpectedGetPaymentDataErrors___
		                    );
		  iVar6 = *param1;
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                      (param1,*(undefined4 *)(iVar6 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_01,*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x24) = 0;
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x104));
		  param1_02 = *(int **)(iVar2 + 0x30);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = param1_00[3];
		  uVar1 = 0;
		  uVar5 = unnamed_function_1417(System_Action_HVBillingVo_PaymentStatusChangedResponse__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Billing_Controller_HvBillingController__HandleGetPaymentDataService_b__9_0__
		             ,0);
		  iVar6 = *param1_02;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x81d00316;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_02,Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo
		                                ,4);
		code_r0x81d00316:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_02,uVar3,param1_01,iVar2,uVar5,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x997C", Offset = "0x997C", VA = "0x997C")]
		private void HandleGetPaymentDataService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetPaymentDataService ---
		void Gameplay_Billing_Controller_HvBillingController__HandleGetPaymentDataService
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Billing_Controller_HvBillingController__ValidatePurchasesAvail(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x997D", Offset = "0x997D", VA = "0x997D", Slot = "13")]
		public override void BuyOption(BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x997E", Offset = "0x997E", VA = "0x997E", Slot = "14")]
		public override void ConsumeIfExist()
		{
		/* --- GHIDRA: ConsumeIfExist ---
		void Gameplay_Billing_Controller_HvBillingController__ConsumeIfExist
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param3_00;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a60935 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3533);
		    DAT_ram_00a60935 = '\x01';
		  }
		  if (DAT_ram_00a6095c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Enum_TryParse_HVBillingVo_PaymentStatusChangedResponse_Status___);
		    DAT_ram_00a6095c = '\x01';
		  }
		  local_8 = 0;
		  uVar5 = *(undefined4 *)(param2 + 8);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar2 = Sirenix_Utilities_EmitUtilities__CreateWeakInstanceMethodCallerFunc___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar5,&local_8,
		                     Method_System_Enum_TryParse_HVBillingVo_PaymentStatusChangedResponse_Status___)
		  ;
		  if ((iVar2 == 0) || (local_8 != 1)) {
		    if (DAT_ram_00a6095c == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Enum_TryParse_HVBillingVo_PaymentStatusChangedResponse_Status___);
		      DAT_ram_00a6095c = '\x01';
		    }
		    local_4 = 0;
		    uVar5 = *(undefined4 *)(param2 + 8);
		    if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a6697c);
		    }
		    iVar2 = Sirenix_Utilities_EmitUtilities__CreateWeakInstanceMethodCallerFunc___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (uVar5,&local_4,
		                       Method_System_Enum_TryParse_HVBillingVo_PaymentStatusChangedResponse_Status___
		                      );
		    if ((iVar2 != 0) && (local_4 == 3)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x18);
		      if (iVar2 != 0) {
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar4 + 0x24),
		                   *(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x10);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x81d00479;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81d00479:
		    piVar6 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    uVar1 = 0;
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x81d004fb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,6);
		code_r0x81d004fb:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3533,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar5,0xc,param3_00,0);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar2 + 0x24) = 0;
		  return;
		}
		*/

		}

		// Token: 0x02000BF9 RID: 3065
		[Token(Token = "0x2000BF9")]
		public static class HvBank
		{
			// Token: 0x02000BFA RID: 3066
			[Token(Token = "0x2000BFA")]
			public sealed class Factory : IControllerFactory
			{
				// Token: 0x06004B26 RID: 19238 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x6004B26")]
				[Address(RVA = "0x9980", Offset = "0x9980", VA = "0x9980", Slot = "4")]
				public AbstractBillingController Create(IAuthTokenSource authTokenSource, IGame game, BillingEvents events, CurrencyConverter currencyConverter)
				{
					return null;
				}

				// Token: 0x06004B27 RID: 19239 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004B27")]
				[Address(RVA = "0x9981", Offset = "0x9981", VA = "0x9981")]
				public Factory()
				{
				}
			}
		}

		// Token: 0x02000BFB RID: 3067
		[Token(Token = "0x2000BFB")]
		public static class WebGL
		{
			// Token: 0x02000BFC RID: 3068
			[Token(Token = "0x2000BFC")]
			public sealed class Factory : IControllerFactory
			{
				// Token: 0x06004B28 RID: 19240 RVA: 0x00002052 File Offset: 0x00000252
				[Token(Token = "0x6004B28")]
				[Address(RVA = "0x9982", Offset = "0x9982", VA = "0x9982", Slot = "4")]
				public AbstractBillingController Create(IAuthTokenSource authTokenSource, IGame game, BillingEvents events, CurrencyConverter currencyConverter)
				{
					return null;
				}

				// Token: 0x06004B29 RID: 19241 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004B29")]
				[Address(RVA = "0x9983", Offset = "0x9983", VA = "0x9983")]
				public Factory()
				{
				}
			}
		}
	}
}
