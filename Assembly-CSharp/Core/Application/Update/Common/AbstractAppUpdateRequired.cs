using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Application.Update.Common
{
	// Token: 0x0200123A RID: 4666
	[Token(Token = "0x200123A")]
	public abstract class AbstractAppUpdateRequired : IAppUpdateOperation, IDisposable
	{
		// Token: 0x06006EBB RID: 28347
		[Token(Token = "0x6006EBB")]
		public abstract void Run();

		// Token: 0x06006EBC RID: 28348
		[Token(Token = "0x6006EBC")]
		public abstract void Stop();

		// Token: 0x06006EBD RID: 28349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBD")]
		[Address(RVA = "0xB93D", Offset = "0xB93D", VA = "0xB93D", Slot = "6")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Application_Update_Common_AbstractAppUpdateRequired__Dispose
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int param1_02;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a803 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&StringLiteral_11743);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4353);
		    DAT_ram_00a5a803 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_9094,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_4353,1,0,1,0,0,0,0);
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
		  uVar1 = func_ii_7508(StringLiteral_11743,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_02 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  if (param1 != (int *)0x0) {
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (uVar1,param1,*(undefined4 *)(*param1 + 0x10c),0);
		    *(undefined4 *)(iVar2 + 8) = uVar1;
		    *(int *)(param1_02 + 0x14) = iVar2;
		    iVar2 = 
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
		                (param1_01,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38)
		                );
		    }
		    *(int *)(param1_00 + 0x24) = param1_01;
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		              (param1_00,0);
		    return;
		  }
		  System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBE")]
		[Address(RVA = "0xB93E", Offset = "0xB93E", VA = "0xB93E")]
		protected void ShowWindowAboutRequiredAppUpdate()
		{
		/* --- GHIDRA: ShowWindowAboutRequiredAppUpdate ---
		void Core_Application_Update_Common_AbstractAppUpdateRequired__ShowWindowAboutRequiredAppUpdate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(0);
		  return;
		}
		*/

		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBF")]
		[Address(RVA = "0xB93F", Offset = "0xB93F", VA = "0xB93F", Slot = "9")]
		protected virtual void ConfirmCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EC0")]
		[Address(RVA = "0xB940", Offset = "0xB940", VA = "0xB940")]
		protected AbstractAppUpdateRequired()
		{
		}
	}
}
