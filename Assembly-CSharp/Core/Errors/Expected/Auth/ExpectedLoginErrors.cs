using System;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Errors.Expected.Auth
{
	// Token: 0x02001091 RID: 4241
	[Token(Token = "0x2001091")]
	public static class ExpectedLoginErrors
	{
		// Token: 0x060062B5 RID: 25269 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x60062B5")]
		[Address(RVA = "0xAEDA", Offset = "0xAEDA", VA = "0xAEDA")]
		public static bool TryHandle(LoginCmd.Types.Result errorCode, out bool isCanDoContinueAuthPipeline)
		{
		/* --- GHIDRA: TryHandle ---
		void Core_Errors_Expected_Auth_ExpectedLoginErrors__TryHandle(undefined4 param1)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6073b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_ExpectedLoginErrors__HandleTestModeWindowOnClose_d__3___
		              );
		    DAT_ram_00a6073b = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_14 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_EmulateCombatForTutorialGameService__PlayerActionEmulate_d__75_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_ExpectedLoginErrors__HandleTestModeWindowOnClose_d__3___
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B6")]
		[Address(RVA = "0xAEDB", Offset = "0xAEDB", VA = "0xAEDB")]
		private static void HandleTestModeWindowOnClose()
		{
		/* --- GHIDRA: HandleTestModeWindowOnClose ---
		void Core_Errors_Expected_Auth_ExpectedLoginErrors__HandleTestModeWindowOnClose(undefined4 param1)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a6073c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_Update_AppUpdateRequired_TypeInfo);
		    DAT_ram_00a6073c = '\x01';
		  }
		  piVar1 = (int *)unnamed_function_1417(Core_Application_Update_AppUpdateRequired_TypeInfo);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xfc));
		  return;
		}
		*/

		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0xAEDC", Offset = "0xAEDC", VA = "0xAEDC")]
		private static void HandleRequiredUpdate()
		{
		/* --- GHIDRA: HandleRequiredUpdate ---
		void Core_Errors_Expected_Auth_ExpectedLoginErrors__HandleRequiredUpdate(undefined4 param1)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int param1_02;
		  int iVar2;
		  undefined4 *puVar3;
		  int param1_03;
		  uint uVar4;
		  
		  if (DAT_ram_00a6073d == '\0') {
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
		               Method_Core_Errors_Expected_Auth_ExpectedLoginErrors___c__ShowUserBannedDialogWindow_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2782);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2789);
		    DAT_ram_00a6073d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2790,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_2789,1,0,1,0,0,0,0);
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
		  uVar1 = func_ii_7508(StringLiteral_2782,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_02 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  if (*(int *)(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo + 0x5c);
		  param1_03 = puVar3[1];
		  if (param1_03 == 0) {
		    if (*(int *)(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    param1_03 = unnamed_function_1417
		                          (
		                          UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                          );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (param1_03,uVar1,
		               Method_Core_Errors_Expected_Auth_ExpectedLoginErrors___c__ShowUserBannedDialogWindow_b__5_0__
		               ,0);
		    *(int *)(*(int *)(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo + 0x5c) + 4) =
		         param1_03;
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
		  return;
		}
		*/

		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0xAEDD", Offset = "0xAEDD", VA = "0xAEDD")]
		private static void ShowUserBannedDialogWindow()
		{
		/* --- GHIDRA: ShowUserBannedDialogWindow ---
		void Core_Errors_Expected_Auth_ExpectedLoginErrors__ShowUserBannedDialogWindow(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6073e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo);
		    DAT_ram_00a6073e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo);
		  **(undefined4 **)(Core_Errors_Expected_Auth_ExpectedLoginErrors___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		public const float LOGIN_REQUEST_DELAY = 3f;

		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		public const string AUTH_FAILED_CANT_VERIFY_LOCALE_KEY = "AUTH/FAILED/CANT_VERIFY";
	}
}
