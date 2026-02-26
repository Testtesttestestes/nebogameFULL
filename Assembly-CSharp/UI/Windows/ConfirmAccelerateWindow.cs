using System;
using Il2CppDummyDll;
using Protocol.Common;

namespace UI.Windows
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	public static class ConfirmAccelerateWindow
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x6178", Offset = "0x6178", VA = "0x6178")]
		public static BaseWindow Show(ConfirmAccelerateWindow.AccelerateType type, double upgradeTime, double diamondsToTimeRate, double availableDiamonds, Action successCallback)
		{
		/* --- GHIDRA: Show ---
		undefined4
		UI_Windows_ConfirmAccelerateWindow__Show
		          (undefined4 param1,double param2,double param3,int param4,undefined4 param5,
		          undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  double dVar3;
		  undefined1 auStack_10 [8];
		  float8 local_8;
		  
		  if (DAT_ram_00a639f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a639f7 = '\x01';
		  }
		  dVar3 = func_ii_6931(param2 * 1000.0,param3,0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar1 = Utils_MathUtils_MathUtils__SaferDivide(2,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Data_ArtifactData__get_SellPrice(uVar1,CEIL(dVar3),0);
		  local_8 = (float8)FLOOR(*(double *)(param4 + 0x18));
		  iVar2 = System_Double__Equals(&local_8,0.0,0);
		  if (iVar2 == 0) {
		    uVar1 = UI_Windows_ConfirmAccelerateWindow__ShowForClan
		                      (param1,param2,param3,*(double *)(param4 + 0x18),param5,auStack_10);
		  }
		  else {
		    uVar1 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Check(uVar1,0);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x6179", Offset = "0x6179", VA = "0x6179")]
		public static DialogWindow ShowForClan(ConfirmAccelerateWindow.AccelerateType type, double upgradeTime, double diamondsToTimeRate, ResourceSet clanResources, Action successCallback)
		{
		/* --- GHIDRA: ShowForClan ---
		undefined4
		UI_Windows_ConfirmAccelerateWindow__ShowForClan
		          (int param1,double param2,double param3,double param4,undefined4 param5,undefined4 param6)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float fVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param3_00;
		  int iVar7;
		  double dVar8;
		  int iVar9;
		  int param1_00;
		  uint uVar10;
		  longlong lVar11;
		  longlong param1_01;
		  undefined8 local_20;
		  undefined8 local_18;
		  float8 local_10;
		  float8 local_8;
		  
		  local_8 = (float8)param4;
		  if (DAT_ram_00a639f8 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ConfirmAccelerateWindow___c__DisplayClass3_0__ShowWindow_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_ConfirmAccelerateWindow___c__DisplayClass3_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22656);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2473);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2474);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2472);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25457);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2475);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2476);
		    DAT_ram_00a639f8 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(UI_Windows_ConfirmAccelerateWindow___c__DisplayClass3_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param5;
		  if (param1 == 1) {
		    puVar1 = &StringLiteral_2474;
		    iVar9 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else if (param1 == 2) {
		    puVar1 = &StringLiteral_2471;
		    iVar9 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else if ((param1 == 3) || (param1 != 4)) {
		    puVar1 = &StringLiteral_2472;
		    iVar9 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    puVar1 = &StringLiteral_2473;
		    iVar9 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar9 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(*puVar1,1,0,1,0,0,0,0);
		  dVar8 = func_ii_6931(param2 * 1000.0,param3,0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  local_10 = (float8)CEIL(dVar8);
		  if ((double)local_10 <= param4) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_2475,1,0,1,0,0,0,0);
		    iVar6 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar9 = func_ii_7515(&local_10,0);
		    local_18 = 0;
		    if (iVar9 == 0) {
		      iVar9 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_25457,iVar9,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x10) = local_18;
		    uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar5,iVar6,0);
		  }
		  else {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    dVar8 = param4 * param3;
		    if (dVar8 < 1.8446744073709552e+19 && 0.0 <= dVar8) {
		      lVar11 = (longlong)dVar8;
		    }
		    else {
		      lVar11 = 0;
		    }
		    if (ABS(dVar8) < 9.223372036854776e+18) {
		      param1_01 = (longlong)dVar8;
		    }
		    else {
		      param1_01 = -0x8000000000000000;
		    }
		    if (0.0 <= dVar8) {
		      param1_01 = lVar11;
		    }
		    fVar4 = Utils_StringUtils___cctor(param1_01,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_2476,1,0,1,0,0,0,0);
		    iVar6 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		    iVar9 = func_ii_7515(&local_8,0);
		    local_18 = 0;
		    if (iVar9 == 0) {
		      iVar9 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_25457,iVar9,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x10) = local_18;
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param3_00 = Utils_TimeUtils__DateFormat((double)fVar4,0);
		    local_20 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_20,StringLiteral_27717,param3_00,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x18) = local_20;
		    uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar5,iVar6,0);
		  }
		  iVar9 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar9,0);
		  *(undefined4 *)(iVar9 + 0x1c) = uVar5;
		  *(undefined4 *)(iVar9 + 0x18) = uVar3;
		  param1_00 = *(int *)(iVar9 + 0x24);
		  iVar6 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar6,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar3 = UI_Windows_DialogWindow__get_WindowId(0);
		  *(undefined4 *)(iVar6 + 8) = uVar3;
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar3,iVar2,
		             Method_UI_Windows_ConfirmAccelerateWindow___c__DisplayClass3_0__ShowWindow_b__0__,0);
		  *(undefined4 *)(iVar7 + 8) = uVar3;
		  *(int *)(iVar6 + 0x14) = iVar7;
		  *(undefined4 *)(iVar6 + 0x18) = StringLiteral_22656;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar10 = *(uint *)(param1_00 + 0xc);
		  if (uVar10 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar10 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar10 * 4 + 0x10) = iVar6;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar3 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar9,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x617A", Offset = "0x617A", VA = "0x617A")]
		private static DialogWindow ShowWindow(ConfirmAccelerateWindow.AccelerateType type, double upgradeTime, double diamondsToTimeRate, double availableDiamonds, Action successCallback)
		{
			return null;
		}

		// Token: 0x02000286 RID: 646
		[Token(Token = "0x2000286")]
		public enum AccelerateType
		{
			// Token: 0x040007C1 RID: 1985
			[Token(Token = "0x40007C1")]
			NONE,
			// Token: 0x040007C2 RID: 1986
			[Token(Token = "0x40007C2")]
			ACCELERATE_STUDIES,
			// Token: 0x040007C3 RID: 1987
			[Token(Token = "0x40007C3")]
			ACCELERATE_BUILDING,
			// Token: 0x040007C4 RID: 1988
			[Token(Token = "0x40007C4")]
			ACCELERATE_IMPROVING,
			// Token: 0x040007C5 RID: 1989
			[Token(Token = "0x40007C5")]
			ACCELERATE_PRODUCTION
		}
	}
}
