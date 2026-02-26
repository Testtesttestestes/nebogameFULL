using System;
using Core.Events.Scopes;
using Gameplay.Bank.Model;
using Gameplay.Billing.Controller;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Billing.PurchaseProcess.FewPurchaseMethods
{
	// Token: 0x020011F3 RID: 4595
	[Token(Token = "0x20011F3")]
	public class PurchaseProcess : IPurchaseProcess
	{
		// Token: 0x06006D28 RID: 27944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D28")]
		[Address(RVA = "0xB810", Offset = "0xB810", VA = "0xB810")]
		public PurchaseProcess(uint requirementId, IGame game, IGameRestart gameRestart, AbstractBillingController controller, BillingScope logBillingScope)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a5a750 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BillingProviderId__BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_BuyOptionErrorEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_BuyOptionEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_Config___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_Config_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess_Select__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3599);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3598);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13765);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13764);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28180);
		    DAT_ram_00a5a750 = '\x01';
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    uVar1 = 0;
		    piVar2 = *(int **)(param1 + 0xc);
		    iVar3 = *piVar2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x160);
		          goto code_r0x81265ec0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x81265ec0:
		    uVar1 = 0;
		    uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		    uVar4 = *(undefined4 *)(param1 + 8);
		    piVar2 = *(int **)(param1 + 0xc);
		    iVar3 = *piVar2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		          goto code_r0x81265f4c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81265f4c:
		    uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		    uVar7 = func_ii_7112(uVar7,0);
		    iVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                      (uVar8,uVar4,uVar7,puVar5);
		    if (iVar3 == 0) {
		      piVar2 = *(int **)(param1 + 0xc);
		      iVar3 = *piVar2;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		            goto code_r0x81265fe1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81265fe1:
		      uVar1 = 0;
		      uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      uVar8 = func_ii_7112(uVar8,0);
		      piVar2 = *(int **)(param1 + 0xc);
		      iVar3 = *piVar2;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		            goto code_r0x8126606c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126606c:
		      uVar1 = 0;
		      uVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      uVar4 = func_ii_7112(uVar4,0);
		      piVar2 = *(int **)(param1 + 0xc);
		      iVar3 = *piVar2;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x160);
		            goto code_r0x812660f7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x812660f7:
		      iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      uVar6 = *(undefined4 *)(param1 + 8);
		      uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                        (*(undefined4 *)(iVar3 + 0x14),0);
		      uVar7 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar7,uVar6,0);
		      uVar6 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		      UI_Windows_RequirementsWindow_RequirementsWindowArgs__set_User(uVar6,uVar8,uVar4,uVar7,0);
		      UI_Windows_RequirementsWindow__HandleContent(uVar6,0);
		      iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0x34);
		      if (iVar3 == 0) {
		        return;
		      }
		      piVar2 = *(int **)(param1 + 0xc);
		      iVar9 = *piVar2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		            goto code_r0x812661c7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812661c7:
		      uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      uVar4 = *(undefined4 *)(param1 + 0xc);
		      iVar9 = **(int **)(param1 + 0x14);
		      iVar9 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                        (*(int **)(param1 + 0x14),*(undefined4 *)(iVar9 + 0x104));
		      uVar1 = 0;
		      piVar2 = *(int **)(iVar9 + 0x30);
		      iVar9 = *piVar2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81266270;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar2,
		                                    Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo,0);
		code_r0x81266270:
		      uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		      uVar7 = unnamed_function_1417
		                        (Core_Events_Scopes_BillingScope_BuyOptionErrorEventArgs_TypeInfo);
		      Core_Events_Scopes_BillingScope_BuyOptionErrorEventArgs__set_ErrorCode
		                (uVar7,uVar8,uVar4,uVar6,param2,0x80000000,StringLiteral_28180,0);
		      goto code_r0x812664c8;
		    }
		  }
		  uVar8 = *(undefined4 *)(param1 + 0xc);
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_Config___TypeInfo
		                             ,2);
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_Config_TypeInfo
		                    );
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		            (iVar3,2,StringLiteral_3598,StringLiteral_13764,0);
		  if ((iVar3 != 0) && (iVar9 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar9 == 0)) {
		    uVar8 = func_ii_1083();
		    func_ii_1050(uVar8,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_Config_TypeInfo
		                    );
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor
		            (iVar3,1,StringLiteral_3599,StringLiteral_13765,0);
		  if ((iVar3 != 0) && (iVar9 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar9 == 0)) {
		    uVar8 = func_ii_1083();
		    func_ii_1050(uVar8,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[5] = iVar3;
		  uVar4 = unnamed_function_1417(System_Action_BillingProviderId__BankOptionData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar4,param1,
		             Method_Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess_Select__
		             ,0);
		  Gameplay_Bank_View_SelectBillingDialogWindow__HandleContent(uVar8,param2,piVar2,uVar4,0);
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0x38);
		  if (iVar3 == 0) {
		    return;
		  }
		  piVar2 = *(int **)(param1 + 0xc);
		  iVar9 = *piVar2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xe0);
		        goto code_r0x812663f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x812663f0:
		  uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		  uVar4 = *(undefined4 *)(param1 + 0xc);
		  iVar9 = **(int **)(param1 + 0x14);
		  iVar9 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar9 + 0x104));
		  uVar1 = 0;
		  piVar2 = *(int **)(iVar9 + 0x30);
		  iVar9 = *piVar2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81266499;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar2,Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo,0)
		  ;
		code_r0x81266499:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar2,puVar5[1]);
		  uVar7 = unnamed_function_1417(Core_Events_Scopes_BillingScope_BuyOptionEventArgs_TypeInfo);
		  Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		            (uVar7,uVar8,uVar4,uVar6,param2,0);
		code_r0x812664c8:
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),uVar7,*(undefined4 *)(iVar3 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D29")]
		[Address(RVA = "0xB811", Offset = "0xB811", VA = "0xB811", Slot = "4")]
		public void Run(BankOptionData option)
		{
		/* --- GHIDRA: Run ---
		void Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess__Run
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *param4_00;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5a751 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo);
		    DAT_ram_00a5a751 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0x30);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param4_00 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x812665a5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param4_00 = (uint *)func_ii_1080(param1_00,
		                                   Gameplay_Billing_BillingProvider_IBillingProvider_TypeInfo,0);
		code_r0x812665a5:
		  iVar2 = (**(code **)((ulonglong)*param4_00 * 4))(param1_00,param4_00[1]);
		  if (iVar2 == param2) {
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x128) * 4))
		              (*(int **)(param1 + 0x14),param3,*(undefined4 *)(iVar2 + 300));
		  }
		  else {
		    if (param2 == 1) {
		      Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess__ShowSelectFromHvBankToGoogle
		                (param1,1,param3,param4_00);
		      return;
		    }
		    if (param2 == 2) {
		      Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess__Select
		                (param1,2,param3,param4_00);
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2A")]
		[Address(RVA = "0xB812", Offset = "0xB812", VA = "0xB812")]
		private void Select(BillingProviderId id, BankOptionData option)
		{
		/* --- GHIDRA: Select ---
		void Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess__Select
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a752 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass8_0__ShowSelectFromHvBankToGoogle_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass8_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13763);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3597);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3600);
		    DAT_ram_00a5a752 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass8_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_3600,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_3597,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_13763,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass8_0__ShowSelectFromHvBankToGoogle_b__0__
		             ,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  *(int *)(iVar3 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar5 = *(uint *)(param1_01 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar5 = *(uint *)(param1_01 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2B")]
		[Address(RVA = "0xB813", Offset = "0xB813", VA = "0xB813")]
		private void ShowSelectFromHvBankToGoogle(BillingProviderId id, BankOptionData option)
		{
		/* --- GHIDRA: ShowSelectFromHvBankToGoogle ---
		void Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess__ShowSelectFromHvBankToGoogle
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int iVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a753 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass9_0__ShowSelectFromGoogleToHvBank_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass9_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13763);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3600);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3596);
		    DAT_ram_00a5a753 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass9_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_3600,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_3596,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_13763,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess___c__DisplayClass9_0__ShowSelectFromGoogleToHvBank_b__0__
		             ,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  *(int *)(iVar3 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar5 = *(uint *)(param1_01 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = func_ii_7508(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar5 = *(uint *)(param1_01 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2C")]
		[Address(RVA = "0xB814", Offset = "0xB814", VA = "0xB814")]
		private void ShowSelectFromGoogleToHvBank(BillingProviderId id, BankOptionData option)
		{
		/* --- GHIDRA: ShowSelectFromGoogleToHvBank ---
		void Core_Gameplay_Managers_Billing_PurchaseProcess_FewPurchaseMethods_PurchaseProcess__ShowSelectFromGoogleToHvBank
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param3_00;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a5a754 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_BillingScope_BuyOptionEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameRestart_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22571);
		    DAT_ram_00a5a754 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0x3c);
		  if (iVar3 != 0) {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0xc);
		    iVar4 = *piVar6;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x81266c3b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81266c3b:
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    param3_00 = *(undefined4 *)(param1 + 0xc);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_BillingScope_BuyOptionEventArgs_TypeInfo);
		    Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		              (param1_00,uVar5,param3_00,param2,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  uVar1 = 0;
		  UnityEngine_PlayerPrefs__TrySetSetString(StringLiteral_22571,param2,0);
		  func_ii_10838(0);
		  uVar5 = *(undefined4 *)(param1 + 0xc);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGameRestart_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81266d14;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGameRestart_TypeInfo,0);
		code_r0x81266d14:
		  (**(code **)((ulonglong)*puVar2 * 4))(auStack_8,piVar6,uVar5,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D2D")]
		[Address(RVA = "0xB815", Offset = "0xB815", VA = "0xB815")]
		private void ConfirmSelectBillingCallback(BillingProviderId id, BankOptionData option)
		{
		}

		// Token: 0x0400391D RID: 14621
		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x8")]
		public readonly uint RequirementId;

		// Token: 0x0400391E RID: 14622
		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGameRestart _gameRestart;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0x14")]
		private readonly AbstractBillingController _controller;

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x18")]
		private BillingScope _logBillingScope;
	}
}
