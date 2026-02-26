using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public class DialogWindow : BaseDialogWindow<DialogWindow.DialogWindowArgs>
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000228")]
		public override string WindowId
		{
			[Token(Token = "0x6000F79")]
			[Address(RVA = "0x61A4", Offset = "0x61A4", VA = "0x61A4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000229")]
		public static string YES_LABEL
		{
			[Token(Token = "0x6000F7A")]
			[Address(RVA = "0x61A5", Offset = "0x61A5", VA = "0x61A5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022A")]
		public static string NO_LABEL
		{
			[Token(Token = "0x6000F7B")]
			[Address(RVA = "0x61A6", Offset = "0x61A6", VA = "0x61A6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022B")]
		public static string OK_LABEL
		{
			[Token(Token = "0x6000F7C")]
			[Address(RVA = "0x61A7", Offset = "0x61A7", VA = "0x61A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700022C")]
		public static string CANCEL_LABEL
		{
			[Token(Token = "0x6000F7D")]
			[Address(RVA = "0x61A8", Offset = "0x61A8", VA = "0x61A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x21B6", Offset = "0x21B6", VA = "0x21B6")]
		public static DialogWindow Show(DialogWindow.DialogWindowArgs args)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_DialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_02;
		  int iVar5;
		  undefined4 *puVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a58a54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__int__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int__TypeInfo
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
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
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_DialogWindow___c__TestDialogWnd_b__15_0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14814);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6042);
		    DAT_ram_00a58a54 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  if (DAT_ram_00a58a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58a57 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_14461;
		  *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_14814;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  if (DAT_ram_00a58a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    DAT_ram_00a58a4e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_18331,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc),
		                12.0,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8),21.0
		                ,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__FromResourceSet(uVar2,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_02;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f689fc;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f689fc:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  *(int *)(iVar1 + 0x10) = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = 1;
		  if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		      puVar6 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar6;
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__int__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object___Invoke
		              (iVar5,uVar2,Method_UI_Windows_DialogWindow___c__TestDialogWnd_b__15_0__,0);
		    *(int *)(*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  *(int *)(iVar3 + 0x10) = iVar5;
		  *(int *)(iVar1 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = StringLiteral_6042;
		  *(undefined4 *)(iVar3 + 0xc) = 2;
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
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
		  *(undefined4 *)(iVar3 + 0xc) = 3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  if (DAT_ram_00a58a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58a52 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12610,param1_00,
		             Method_UI_Windows_PopupController_Show_DialogWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_Windows_DialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_02;
		  int iVar5;
		  undefined4 *puVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a58a54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__int__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int__TypeInfo
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
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
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_DialogWindow___c__TestDialogWnd_b__15_0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14814);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6042);
		    DAT_ram_00a58a54 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  if (DAT_ram_00a58a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58a57 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_14461;
		  *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_14814;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  if (DAT_ram_00a58a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    DAT_ram_00a58a4e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_18331,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc),
		                12.0,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8),21.0
		                ,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__FromResourceSet(uVar2,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_02;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f689fc;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f689fc:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  *(int *)(iVar1 + 0x10) = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = 1;
		  if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		      puVar6 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar6;
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__int__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object___Invoke
		              (iVar5,uVar2,Method_UI_Windows_DialogWindow___c__TestDialogWnd_b__15_0__,0);
		    *(int *)(*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  *(int *)(iVar3 + 0x10) = iVar5;
		  *(int *)(iVar1 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = StringLiteral_6042;
		  *(undefined4 *)(iVar3 + 0xc) = 2;
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
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
		  *(undefined4 *)(iVar3 + 0xc) = 3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  if (DAT_ram_00a58a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58a52 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12610,param1_00,
		             Method_UI_Windows_PopupController_Show_DialogWindow___);
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_Windows_DialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_02;
		  int iVar5;
		  undefined4 *puVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a58a54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__int__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int__TypeInfo
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
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
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_DialogWindow___c__TestDialogWnd_b__15_0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14814);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6042);
		    DAT_ram_00a58a54 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  if (DAT_ram_00a58a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58a57 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_14461;
		  *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_14814;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  if (DAT_ram_00a58a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    DAT_ram_00a58a4e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_18331,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc),
		                12.0,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8),21.0
		                ,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__FromResourceSet(uVar2,0);
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_02;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f689fc;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f689fc:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_02,puVar4[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  *(undefined4 *)(iVar3 + 0xc) = uVar2;
		  *(int *)(iVar1 + 0x10) = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__int__TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 0xc) = 1;
		  if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		      puVar6 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar6;
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__int__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object___Invoke
		              (iVar5,uVar2,Method_UI_Windows_DialogWindow___c__TestDialogWnd_b__15_0__,0);
		    *(int *)(*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  *(int *)(iVar3 + 0x10) = iVar5;
		  *(int *)(iVar1 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = StringLiteral_6042;
		  *(undefined4 *)(iVar3 + 0xc) = 2;
		  *(undefined4 *)(iVar3 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
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
		  *(undefined4 *)(iVar3 + 0xc) = 3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_01 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  if (DAT_ram_00a58a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58a52 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar2,StringLiteral_12610,param1_00,
		             Method_UI_Windows_PopupController_Show_DialogWindow___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x61A9", Offset = "0x61A9", VA = "0x61A9")]
		public static DialogWindow Show(string title, string description, string label)
		{
			return null;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x61AA", Offset = "0x61AA", VA = "0x61AA")]
		public static DialogWindow Show(string title, string description)
		{
			return null;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x61AB", Offset = "0x61AB", VA = "0x61AB")]
		public void TestDialogWnd()
		{
		/* --- GHIDRA: TestDialogWnd ---
		void UI_Windows_DialogWindow__TestDialogWnd(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  undefined4 param1_02;
		  int param1_03;
		  uint uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58a55 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_DialogWindow___c__TestAlert_b__16_0__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3002);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3177);
		    DAT_ram_00a58a55 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_3002;
		  param1_03 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_01 + 8) = StringLiteral_3177;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_03 + 0x10) = *(int *)(param1_03 + 0x10) + 1;
		  uVar1 = *(uint *)(param1_03 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(param1_03 + 8) + 0xc)) {
		    *(uint *)(param1_03 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(param1_03 + 8) + uVar1 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_03,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  param1_02 = UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Windows_DialogWindow___c_TypeInfo);
		      puVar2 = *(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (iVar3,param2_00,Method_UI_Windows_DialogWindow___c__TestAlert_b__16_0__,0);
		    *(int *)(*(int *)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(param1_02,iVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x61AC", Offset = "0x61AC", VA = "0x61AC")]
		public void TestAlert()
		{
		/* --- GHIDRA: TestAlert ---
		void UI_Windows_DialogWindow__TestAlert(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseDialogWindow_DialogWindow_DialogWindowArgs___ctor__);
		    DAT_ram_00a58a56 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,Method_UI_Windows_BaseDialogWindow_DialogWindow_DialogWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x61AD", Offset = "0x61AD", VA = "0x61AD")]
		public DialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_DialogWindow___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a58 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow___c_TypeInfo);
		    DAT_ram_00a58a58 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Windows_DialogWindow___c_TypeInfo);
		  **(undefined4 **)(UI_Windows_DialogWindow___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/DialogWindow";

		// Token: 0x02000292 RID: 658
		[Token(Token = "0x2000292")]
		public class DialogWindowArgs : BaseDialogWindow<DialogWindow.DialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F84 RID: 3972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F84")]
			[Address(RVA = "0x21B2", Offset = "0x21B2", VA = "0x21B2")]
			public DialogWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4 UI_Windows_DialogWindow__get_WindowId(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18331);
		    DAT_ram_00a58a4e = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_18331,1,0,1,0,0,0,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_YES_LABEL ---
		undefined4 UI_Windows_DialogWindow__get_YES_LABEL(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a4f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11304);
		    DAT_ram_00a58a4f = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_11304,1,0,1,0,0,0,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_NO_LABEL ---
		undefined4 UI_Windows_DialogWindow__get_NO_LABEL(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11743);
		    DAT_ram_00a58a50 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_11743,1,0,1,0,0,0,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_OK_LABEL ---
		undefined4 UI_Windows_DialogWindow__get_OK_LABEL(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a51 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    DAT_ram_00a58a51 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_4107,1,0,1,0,0,0,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_CANCEL_LABEL ---
		undefined4
		UI_Windows_DialogWindow__get_CANCEL_LABEL
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a58a53 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
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
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    DAT_ram_00a58a53 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  if (DAT_ram_00a58a57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58a57 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x18) = param1;
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
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
		  *(undefined4 *)(param1_02 + 8) = param3;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12610,param1_00,
		                     Method_UI_Windows_PopupController_Show_DialogWindow___);
		  return uVar2;
		}
		*/

}
