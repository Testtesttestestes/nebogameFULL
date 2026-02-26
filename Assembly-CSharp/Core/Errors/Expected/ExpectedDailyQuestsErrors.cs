using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001051 RID: 4177
	[Token(Token = "0x2001051")]
	public class ExpectedDailyQuestsErrors : ExpectedDefaultError
	{
		// Token: 0x06006228 RID: 25128 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6006228")]
		[Address(RVA = "0xAE53", Offset = "0xAE53", VA = "0xAE53", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006229")]
		[Address(RVA = "0xAE54", Offset = "0xAE54", VA = "0xAE54")]
		public ExpectedDailyQuestsErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedDailyQuestsErrors___ctor
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int param1_02;
		  int iVar2;
		  undefined4 *puVar3;
		  int param1_03;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a36e == '\0') {
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
		              (&Method_Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c__Handle_b__0_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6823);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10751);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6824);
		    DAT_ram_00a5a36e = '\x01';
		  }
		  if (param2 != -0x74) {
		    if ((((((param2 != -0x73) && (param2 != -0x72)) && (param2 != -0x71)) &&
		         ((param2 != -0x70 && (param2 != -0x6f)))) &&
		        ((param2 != -0x6e && ((param2 != -0x6d && (param2 != -0x6c)))))) &&
		       ((param2 != -0x6b && (param2 == -0x6a)))) {
		      uVar1 = System_Uri___ctor(0);
		      uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      param3_00 = func_ii_7508(StringLiteral_6823,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar1,1,param3_00,0);
		      return 1;
		    }
		    uVar1 = Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c___Handle_b__0_0
		                      (param2,param2,param2);
		    return uVar1;
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_9094,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_6824,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_02 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_02,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = func_ii_7508(StringLiteral_10751,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_02 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  if (*(int *)(Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo + 0x5c);
		  param1_03 = puVar3[1];
		  if (param1_03 == 0) {
		    if (*(int *)(Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_03 = unnamed_function_1417
		                          (
		                          UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                          );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (param1_03,uVar1,
		               Method_Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c__Handle_b__0_0__,
		               0);
		    *(int *)(*(int *)(Core_Errors_Expected_ExpectedEndlessOptionsBillingErrors___c_TypeInfo + 0x5c)
		            + 4) = param1_03;
		  }
		  *(int *)(iVar2 + 8) = param1_03;
		  *(int *)(param1_02 + 0x14) = iVar2;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return 1;
		}
		*/

		}
	}
}
