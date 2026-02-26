using System;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Windows;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x0200107E RID: 4222
	[Token(Token = "0x200107E")]
	public class ExpectedClanBillingErrors : ExpectedDefaultError
	{
		// Token: 0x0600628F RID: 25231 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x600628F")]
		[Address(RVA = "0xAEB5", Offset = "0xAEB5", VA = "0xAEB5", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		int Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a39c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5a39c = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  param1_00 = Core_Money_Money__op_Explicit(param1,0);
		  param2_00 = Core_Money_Money__op_Explicit(param2,0);
		  iVar1 = Core_Money_MoneyExt__GetValue(param1_00,param2_00,&local_4,0);
		  if (iVar1 == 0) {
		    Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Check(local_4,auStack_10);
		  }
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x6006290")]
		[Address(RVA = "0xAEB6", Offset = "0xAEB6", VA = "0xAEB6")]
		public static bool Check(ResourceSet balance, ResourceSet price)
		{
		/* --- GHIDRA: Check ---
		undefined4
		Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Check(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3;
		  int param1_01;
		  int iVar4;
		  uint uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a39d == '\0') {
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
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
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
		               Method_Core_Errors_Expected_Clans_ExpectedClanBillingErrors___c__DisplayClass2_0__ShowNotEnoughResourcesWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_Clans_ExpectedClanBillingErrors___c__DisplayClass2_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4321);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4320);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4303);
		    DAT_ram_00a5a39d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_Clans_ExpectedClanBillingErrors___c__DisplayClass2_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param1;
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4321,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4320,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                     (*(undefined4 *)(iVar1 + 8),NAN,0,StringLiteral_2556,0,0,iVar3);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,param3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar3,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4303,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar2;
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
		             Method_Core_Errors_Expected_Clans_ExpectedClanBillingErrors___c__DisplayClass2_0__ShowNotEnoughResourcesWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  *(int *)(param1_01 + 0x14) = iVar4;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar3 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = iVar3;
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006291")]
		[Address(RVA = "0xAEB7", Offset = "0xAEB7", VA = "0xAEB7")]
		public static DialogWindow ShowNotEnoughResourcesWindow(Money deficientResources)
		{
			return null;
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006292")]
		[Address(RVA = "0xAEB8", Offset = "0xAEB8", VA = "0xAEB8")]
		public ExpectedClanBillingErrors()
		{
		}
	}
}
