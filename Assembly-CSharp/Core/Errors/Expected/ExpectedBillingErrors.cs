using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x02001043 RID: 4163
	[Token(Token = "0x2001043")]
	public class ExpectedBillingErrors : ExpectedDefaultError
	{
		// Token: 0x06006201 RID: 25089 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x6006201")]
		[Address(RVA = "0xAE2C", Offset = "0xAE2C", VA = "0xAE2C", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		undefined4 Core_Errors_Expected_ExpectedBillingErrors__Handle(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (param1 + 0x13U < 7) {
		    uVar1 = *(undefined4 *)(&DAT_ram_005a37d8 + (param1 + 0x13U) * 4);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x6006202")]
		[Address(RVA = "0xAE2D", Offset = "0xAE2D", VA = "0xAE2D")]
		public static Resources GetResourceIdByErrorCode(BillingErrors errorCode)
		{
		/* --- GHIDRA: GetResourceIdByErrorCode ---
		undefined4
		Core_Errors_Expected_ExpectedBillingErrors__GetResourceIdByErrorCode
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (*(double *)(param2 + 0x18) <= *(double *)(param1 + 0x18)) {
		    if (*(double *)(param2 + 0x10) <= *(double *)(param1 + 0x10)) {
		      if (*(double *)(param2 + 0x20) <= *(double *)(param1 + 0x20)) {
		        if (*(double *)(param2 + 0x28) <= *(double *)(param1 + 0x28)) {
		          if (*(double *)(param2 + 0x30) <= *(double *)(param1 + 0x30)) {
		            uVar1 = 0;
		          }
		          else {
		            uVar1 = 0xffffffed;
		          }
		        }
		        else {
		          uVar1 = 0xffffffee;
		        }
		      }
		      else {
		        uVar1 = 0xfffffff1;
		      }
		    }
		    else {
		      uVar1 = 0xfffffff3;
		    }
		  }
		  else {
		    uVar1 = 0xfffffff2;
		  }
		  return uVar1;
		}
		*/

			return Resources.UnknownResource;
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6006203")]
		[Address(RVA = "0xAE2E", Offset = "0xAE2E", VA = "0xAE2E")]
		public static BillingErrors GetErrorCode(ResourceSet current, ResourceSet required)
		{
		/* --- GHIDRA: GetErrorCode ---
		uint Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a35b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    DAT_ram_00a5a35b = '\x01';
		  }
		  if (*(double *)(param2 + 0x18) <= *(double *)(param1 + 0x18)) {
		    if (*(double *)(param2 + 0x10) <= *(double *)(param1 + 0x10)) {
		      if (*(double *)(param2 + 0x20) <= *(double *)(param1 + 0x20)) {
		        if (*(double *)(param2 + 0x28) <= *(double *)(param1 + 0x28)) {
		          if (*(double *)(param2 + 0x30) <= *(double *)(param1 + 0x30)) {
		            param1_00 = 0;
		          }
		          else {
		            param1_00 = 0xffffffed;
		          }
		        }
		        else {
		          param1_00 = 0xffffffee;
		        }
		      }
		      else {
		        param1_00 = 0xfffffff1;
		      }
		    }
		    else {
		      param1_00 = 0xfffffff3;
		    }
		  }
		  else {
		    param1_00 = 0xfffffff2;
		  }
		  uVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  return uVar1 ^ 1;
		}
		*/

			return BillingErrors.AllOkBillingError;
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6006204")]
		[Address(RVA = "0xAE2F", Offset = "0xAE2F", VA = "0xAE2F")]
		public static bool Check(ResourceSet current, ResourceSet total)
		{
		/* --- GHIDRA: Check ---
		undefined4 Core_Errors_Expected_ExpectedBillingErrors__Check(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a35c == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_NotEnoughResourcesWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12654);
		    DAT_ram_00a5a35c = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (UI_NotEnoughResourcesWindow_NotEnoughResourcesWindowArgs_TypeInfo);
		  UI_NotEnoughResourcesWindow___ctor(param1_00,param1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12654,param1_00,
		                     Method_UI_Windows_PopupController_Show_NotEnoughResourcesWindow___);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006205")]
		[Address(RVA = "0xAE30", Offset = "0xAE30", VA = "0xAE30")]
		public static BaseWindow ShowNotEnoughResourcesWindow(Resources resourceId)
		{
		/* --- GHIDRA: ShowNotEnoughResourcesWindow ---
		undefined4
		Core_Errors_Expected_ExpectedBillingErrors__ShowNotEnoughResourcesWindow(undefined4 param1)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined8 in_i1q;
		  undefined8 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int param1_00;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  undefined4 *puVar13;
		  int param1_01;
		  uint uVar14;
		  undefined8 uVar15;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar7 = (undefined4)((ulonglong)in_i1q >> 0x20);
		  if (DAT_ram_00a5a35d == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
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
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Errors_Expected_ExpectedBillingErrors___c__ShowUserBannedWindow_b__5_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Errors_Expected_ExpectedBillingErrors___c__ShowUserBannedWindow_b__5_1__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2784);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22525);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2170);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2787);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2783);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7795);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2786);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2785);
		    DAT_ram_00a5a35d = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar14 = 0;
		  piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar14 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar14 * 8 + 4) * 8 + iVar11 + 0x140);
		        goto code_r0x8120ab3a;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar14);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8120ab3a:
		  uVar15 = CONCAT44(uVar7,puVar3[1]);
		  iVar11 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(in_register_20000004,piVar10),uVar15);
		  uVar7 = (undefined4)((ulonglong)uVar15 >> 0x20);
		  iVar11 = *(int *)(*(int *)(iVar11 + 0x14) + 0x24);
		  uVar15 = *(undefined8 *)(iVar11 + 0x18);
		  iVar12 = *(int *)(iVar11 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar4 = Utils_TimeUtils__DateFormat(uVar15,0);
		  uVar1 = (undefined4)((ulonglong)uVar15 >> 0x20);
		  piVar10 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(piVar10,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2787,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_22525,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_8;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar5,iVar6,0);
		  func_ii_2010(piVar10,uVar4,0);
		  func_ii_2010(piVar10,StringLiteral_2170,0);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2783,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_25589,*(undefined4 *)(iVar11 + 0x14),
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_10;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar6,0);
		  func_ii_2010(piVar10,uVar4,0);
		  if (iVar12 != 0) {
		    func_ii_2010(piVar10,StringLiteral_2170,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2785,1,0,1,0,0,0,0);
		    iVar6 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    uVar7 = 0x7ff80000;
		    uVar5 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (*(undefined4 *)(iVar11 + 0x20),NAN,0,StringLiteral_2556,0,0,piVar10);
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_26152,uVar5,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x10) = local_8;
		    uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar4,iVar6,0);
		    func_ii_2010(piVar10,uVar4,0);
		  }
		  iVar6 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar6,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2786,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar6 + 0x18) = uVar4;
		  uVar15 = CONCAT44(uVar1,piVar10);
		  uVar2 = CONCAT44(uVar7,*(undefined4 *)(*piVar10 + 0xdc));
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*piVar10 + 0xd8) * 4))(uVar15,uVar2);
		  uVar1 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  *(undefined4 *)(iVar6 + 0x1c) = uVar7;
		  uVar7 = (undefined4)((ulonglong)uVar15 >> 0x20);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar8 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar8,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_7795,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar8 + 8) = uVar4;
		  iVar9 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  if (*(int *)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		  }
		  puVar13 = *(undefined4 **)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c);
		  param1_01 = puVar13[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		      puVar13 = *(undefined4 **)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar13;
		    param1_01 = unnamed_function_1417
		                          (
		                          UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                          );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (param1_01,uVar4,
		               Method_Core_Errors_Expected_ExpectedBillingErrors___c__ShowUserBannedWindow_b__5_0__,
		               0);
		    *(int *)(*(int *)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c) + 4) =
		         param1_01;
		  }
		  *(int *)(iVar9 + 8) = param1_01;
		  *(int *)(iVar8 + 0x14) = iVar9;
		  iVar9 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar14 = *(uint *)(param1_00 + 0xc);
		  if (uVar14 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar14 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar14 * 4 + 0x10) = iVar8;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar8,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(iVar6 + 0x24) = param1_00;
		  if (iVar12 != 0) {
		    iVar12 = unnamed_function_1417
		                       (
		                       UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                       );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar12,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2784,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar12 + 8) = uVar4;
		    iVar8 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    if (*(int *)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		    }
		    puVar13 = *(undefined4 **)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c);
		    iVar9 = puVar13[2];
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		        puVar13 = *(undefined4 **)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar13;
		      iVar9 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		                (iVar9,uVar4,
		                 Method_Core_Errors_Expected_ExpectedBillingErrors___c__ShowUserBannedWindow_b__5_1__
		                 ,0);
		      *(int *)(*(int *)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c) + 8) = iVar9
		      ;
		    }
		    *(int *)(iVar8 + 8) = iVar9;
		    *(int *)(iVar12 + 0x14) = iVar8;
		    iVar8 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar10;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar14 * 8 + 4) * 8 + iVar9 + 0x140);
		          goto code_r0x8120b0ab;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar14);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8120b0ab:
		    uVar7 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar7,piVar10),CONCAT44(uVar1,puVar3[1]))
		    ;
		    uVar7 = func_ii_7112(uVar7,0);
		    *(undefined4 *)(iVar8 + 0xc) = uVar7;
		    uVar7 = *(undefined4 *)(iVar11 + 0x20);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar7 = Core_Money_Money__op_Explicit(uVar7,0);
		    *(undefined4 *)(iVar8 + 8) = uVar7;
		    *(int *)(iVar12 + 0x10) = iVar8;
		    iVar11 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar14 = *(uint *)(param1_00 + 0xc);
		    if (uVar14 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar14 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar14 * 4 + 0x10) = iVar12;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar12,*(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  uVar7 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar6,0);
		  return uVar7;
		}
		*/

			return null;
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006206")]
		[Address(RVA = "0xAE31", Offset = "0xAE31", VA = "0xAE31")]
		public static DialogWindow ShowUserBannedWindow()
		{
			return null;
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006207")]
		[Address(RVA = "0xAE32", Offset = "0xAE32", VA = "0xAE32")]
		public ExpectedBillingErrors()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Errors_Expected_ExpectedBillingErrors___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a35e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		    DAT_ram_00a5a35e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo);
		  **(undefined4 **)(Core_Errors_Expected_ExpectedBillingErrors___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
