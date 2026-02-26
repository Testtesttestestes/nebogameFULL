using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F9B RID: 3995
	[Token(Token = "0x2000F9B")]
	public static class NullableResourceSetExt
	{
		// Token: 0x06005FC8 RID: 24520 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0xAC03", Offset = "0xAC03", VA = "0xAC03")]
		public static ResourceSet ToResourceSet(this NullableResourceSet value)
		{
		/* --- GHIDRA: ToResourceSet ---
		int Core_Extensions_Dict_NullableResourceSetExt__ToResourceSet
		              (int param1,double param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a33f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Resources__TypeInfo);
		    DAT_ram_00a5a33f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Resources__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Resources___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x10)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x18)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x20)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x28)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x30)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 5;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,5,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x00011910 File Offset: 0x0000FB10
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x1B0F", Offset = "0x1B0F", VA = "0x1B0F")]
		public static double GetValue(this NullableResourceSet rs, Resources id)
		{
		/* --- GHIDRA: GetValue ---
		undefined4
		Core_Extensions_Dict_NullableResourceSetExt__GetValue
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4,double param5,
		          undefined4 param6)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int param1_02;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57696 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanInfoModel__ClanInfoEvents__ClanInfoController__ClanTreasuryView__get_Model__
		              );
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
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass21_0__ShowExceedingOperationDialogWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass21_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2171);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4341);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10748);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2337);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4337);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2169);
		    DAT_ram_00a57696 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass21_0_TypeInfo
		                    );
		  *(double *)(iVar1 + 0x18) = param5;
		  *(undefined4 *)(iVar1 + 0x14) = param4;
		  *(undefined4 *)(iVar1 + 0x10) = param3;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int *)(iVar1 + 8) = param1;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4341,1,0,1,0,0,0,0);
		  func_ii_2010(param1_00,uVar2,0);
		  func_ii_2010(param1_00,StringLiteral_2337,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt___c__DisplayClass9_0___HasNewCurrency_b__0
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x28) + 0x14),0);
		  uVar2 = 0x7ff80000;
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar3,NAN,0,StringLiteral_2169,0,0,0);
		  func_ii_2010(param1_00,uVar3,0);
		  func_ii_2010(param1_00,StringLiteral_2171,0);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4337,1,0,1,0,0,0,0);
		  func_ii_2010(param1_00,uVar3,0);
		  param1_01 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_01,0);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 0x18) = uVar3;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,CONCAT44(uVar2,*(undefined4 *)(*param1_00 + 0xdc)));
		  *(undefined4 *)(param1_01 + 0x1c) = uVar2;
		  param1_02 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_02,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10748,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar2,iVar1,
		             Method_Gameplay_Clans_Office_Controller_ClanTreasuryViewMediator___c__DisplayClass21_0__ShowExceedingOperationDialogWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar5 + 8) = uVar2;
		  *(int *)(iVar4 + 0x14) = iVar5;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_02 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar4,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar6 = *(uint *)(param1_02 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar6 * 4 + 0x10) = iVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,iVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_01 + 0x24) = param1_02;
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_01,0);
		  return uVar2;
		}
		*/

			return 0.0;
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0xAC04", Offset = "0xAC04", VA = "0xAC04")]
		public static List<Resources> GetResourcesesIds(this NullableResourceSet rs, double greaterThresholdValue = 0.0)
		{
		/* --- GHIDRA: GetResourcesesIds ---
		undefined4
		Core_Extensions_Dict_NullableResourceSetExt__GetResourcesesIds(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x10),0x30,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}
	}
}
