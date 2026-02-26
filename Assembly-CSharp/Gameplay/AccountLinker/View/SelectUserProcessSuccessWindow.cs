using System;
using Gameplay.AccountLinker.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E01 RID: 3585
	[Token(Token = "0x2000E01")]
	public class SelectUserProcessSuccessWindow : BaseDialogWindow<SelectUserProcessSuccessWindow.Args>
	{
		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D1")]
		public override string WindowId
		{
			[Token(Token = "0x6005765")]
			[Address(RVA = "0xA4E0", Offset = "0xA4E0", VA = "0xA4E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005766")]
		[Address(RVA = "0xA4E1", Offset = "0xA4E1", VA = "0xA4E1", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow__HandleContent
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58921 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_SelectUserProcessSuccessWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12551);
		    DAT_ram_00a58921 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow_Args_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow___ctor(uVar1,param1,param1);
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12551,uVar1,
		                     Method_UI_Windows_PopupController_Show_SelectUserProcessSuccessWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005767")]
		[Address(RVA = "0xA4E2", Offset = "0xA4E2", VA = "0xA4E2")]
		public static SelectUserProcessSuccessWindow Show(LinkerUser user)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58922 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseDialogWindow_SelectUserProcessSuccessWindow_Args___ctor__);
		    DAT_ram_00a58922 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,Method_UI_Windows_BaseDialogWindow_SelectUserProcessSuccessWindow_Args___ctor__)
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005768")]
		[Address(RVA = "0xA4E3", Offset = "0xA4E3", VA = "0xA4E3")]
		public SelectUserProcessSuccessWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a58923 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SelectUserProcessSuccessWindow_Args___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SelectUserProcessSuccessWindow_Args___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SelectUserProcessSuccessWindow_Args__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SelectUserProcessSuccessWindow_Args___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_2500);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2501);
		    DAT_ram_00a58923 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SelectUserProcessSuccessWindow_Args___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2501,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_2500,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  param1_01 = *(int *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SelectUserProcessSuccessWindow_Args__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SelectUserProcessSuccessWindow_Args___ctor__
		            );
		  uVar2 = UI_Windows_DialogWindow__get_NO_LABEL(0);
		  *(undefined4 *)(param1_00 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SelectUserProcessSuccessWindow_Args___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = param1_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x04002F58 RID: 12120
		[Token(Token = "0x4002F58")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/SelectUserProcessSuccessDialogWindow";

		// Token: 0x04002F59 RID: 12121
		[Token(Token = "0x4002F59")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AccountLinkerUserView _widget;

		// Token: 0x02000E02 RID: 3586
		[Token(Token = "0x2000E02")]
		public class Args : BaseDialogWindow<SelectUserProcessSuccessWindow.Args>.BaseDialogWindowArgs
		{
			// Token: 0x06005769 RID: 22377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005769")]
			[Address(RVA = "0xA4E4", Offset = "0xA4E4", VA = "0xA4E4")]
			public Args(LinkerUser user)
			{
			}

			// Token: 0x04002F5A RID: 12122
			[Token(Token = "0x4002F5A")]
			[FieldOffset(Offset = "0x2C")]
			public LinkerUser User;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_AccountLinker_View_SelectUserProcessSuccessWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a58920 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectUserProcessSuccessWindow_Args__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_SelectUserProcessSuccessWindow_Args__get_WindowArgs__);
		    DAT_ram_00a58920 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SelectUserProcessSuccessWindow_Args__HandleContent__
		            );
		  param1_00 = *(int *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectUserProcessSuccessWindow_Args__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != *(int *)(param1_00 + 0x34)) {
		    *(int *)(param1_00 + 0x34) = iVar1;
		    Gameplay_AccountLinker_View_AccountLinkerUserView__set_User(param1_00,iVar1);
		  }
		  return;
		}
		*/

}
