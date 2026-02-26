using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public static class Alert
	{
		// Token: 0x06000F4B RID: 3915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x6176", Offset = "0x6176", VA = "0x6176")]
		public static DialogWindow Show(Alert.AlertArgs args)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_Alert__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a639f6 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    DAT_ram_00a639f6 = '\x01';
		  }
		  func_ii_8625(param1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_9094,1,0,1,0,0,0,0);
		  *(undefined1 *)(param1 + 0x28) = 0;
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  param1_01 = *(int *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar2 = UI_Windows_DialogWindow__get_NO_LABEL(0);
		  *(undefined4 *)(param1_00 + 8) = uVar2;
		  iVar1 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
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

			return null;
		}

		// Token: 0x02000284 RID: 644
		[Token(Token = "0x2000284")]
		public class AlertArgs : DialogWindow.DialogWindowArgs
		{
			// Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F4C")]
			[Address(RVA = "0x6177", Offset = "0x6177", VA = "0x6177")]
			public AlertArgs()
			{
			}
		}
	}
}
