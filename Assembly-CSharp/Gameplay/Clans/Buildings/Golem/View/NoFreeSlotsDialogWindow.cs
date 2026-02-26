using System;
using Il2CppDummyDll;
using UI.Windows;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC9 RID: 2761
	[Token(Token = "0x2000AC9")]
	public class NoFreeSlotsDialogWindow : BaseDialogWindow<NoFreeSlotsDialogWindow.NoFreeSlotsDialogWindowArgs>
	{
		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1B")]
		public override string WindowId
		{
			[Token(Token = "0x600428A")]
			[Address(RVA = "0x913E", Offset = "0x913E", VA = "0x913E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428B")]
		[Address(RVA = "0x913F", Offset = "0x913F", VA = "0x913F", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		undefined4
		Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow__HandleCloseButton(undefined4 param1)
		
		{
		  int param2;
		  int *param1_00;
		  int param1_01;
		  undefined4 uVar1;
		  int param1_02;
		  int param1_03;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a57845 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_NoFreeSlotsDialogWindow___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow___c__DisplayClass5_0__Show_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow___c__DisplayClass5_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4291);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9114);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12593);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4412);
		    DAT_ram_00a57845 = '\x01';
		  }
		  param2 = unnamed_function_1417
		                     (
		                     Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow___c__DisplayClass5_0_TypeInfo
		                     );
		  param1_00 = (int *)unnamed_function_1417(Utils_OpToken_int__int__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,Method_Utils_OpToken_int__int___ctor__);
		  *(int **)(param2 + 8) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  param1_01 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57847 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57847 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_01 + 0x2c) = *(undefined4 *)(param2 + 8);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9114,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4291,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 0x1c) = uVar1;
		  param1_02 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_02,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs____ctor__
		            );
		  param1_03 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_03,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4412,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_03 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param2,
		             Method_Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow___c__DisplayClass5_0__Show_b__0__
		             ,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  *(int *)(param1_03 + 0x14) = iVar2;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_03;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_03,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_01 + 0x24) = param1_02;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12593,param1_01,
		             Method_UI_Windows_PopupController_Show_NoFreeSlotsDialogWindow___);
		  return *(undefined4 *)(param2 + 8);
		}
		*/

		}

		// Token: 0x0600428C RID: 17036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600428C")]
		[Address(RVA = "0x9140", Offset = "0x9140", VA = "0x9140")]
		public static OpToken<int, int> Show()
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57846 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57846 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428D")]
		[Address(RVA = "0x9141", Offset = "0x9141", VA = "0x9141")]
		public NoFreeSlotsDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57847 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57847 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/NoFreeSlotsDialogWindow";

		// Token: 0x02000ACA RID: 2762
		[Token(Token = "0x2000ACA")]
		public class NoFreeSlotsDialogWindowArgs : BaseDialogWindow<NoFreeSlotsDialogWindow.NoFreeSlotsDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x0600428E RID: 17038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600428E")]
			[Address(RVA = "0x9142", Offset = "0x9142", VA = "0x9142")]
			public NoFreeSlotsDialogWindowArgs()
			{
			}

			// Token: 0x040024B6 RID: 9398
			[Token(Token = "0x40024B6")]
			[FieldOffset(Offset = "0x2C")]
			public OpToken<int, int> OpToken;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Clans_Buildings_Golem_View_NoFreeSlotsDialogWindow__get_WindowId
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57844 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__Fail__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__HandleCloseButton__
		              );
		    DAT_ram_00a57844 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__get_WindowArgs__
		                      );
		  Utils_OpToken_object__object___DisposeHandlers
		            (*(undefined4 *)(iVar1 + 0x2c),0,Method_Utils_OpToken_int__int__Fail__);
		  UI_Windows_WindowWhitCloseButton_object___Awake
		            (param1,
		             Method_UI_Windows_WindowWhitCloseButton_NoFreeSlotsDialogWindow_NoFreeSlotsDialogWindowArgs__HandleCloseButton__
		            );
		  return;
		}
		*/

}
