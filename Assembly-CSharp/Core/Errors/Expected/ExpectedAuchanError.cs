using System;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x02001041 RID: 4161
	[Token(Token = "0x2001041")]
	public class ExpectedAuchanError : ExpectedDefaultError
	{
		// Token: 0x060061FC RID: 25084 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x60061FC")]
		[Address(RVA = "0xAE27", Offset = "0xAE27", VA = "0xAE27", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		void Core_Errors_Expected_ExpectedAuchanError__Handle
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param3_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5a358 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    DAT_ram_00a5a358 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = *(undefined4 *)(param2 + 8);
		  param3_00 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,1);
		  param1_01 = *(int *)(param2 + 0x10);
		  if ((param1_01 != 0) &&
		     (iVar1 = func_ii_1082(param1_01,*(undefined4 *)(*param3_00 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param3_00[4] = param1_01;
		  Gameplay_Auchan_View_NoTradeAccountDialogWindow__get_WindowId(param1_00,uVar2,param3_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FD")]
		[Address(RVA = "0xAE28", Offset = "0xAE28", VA = "0xAE28")]
		private void ShowNoTradeAccountDialogWindow(ExpectedAuchanError.ErrorArgs args)
		{
		/* --- GHIDRA: ShowNoTradeAccountDialogWindow ---
		undefined4
		Core_Errors_Expected_ExpectedAuchanError__ShowNoTradeAccountDialogWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a359 == '\0') {
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
		    Mono_Security_ASN1__get_Item(&StringLiteral_2767);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2768);
		    DAT_ram_00a5a359 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_2768,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = func_ii_7508(StringLiteral_2767,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
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
		  uVar2 = UI_Windows_DialogWindow__get_NO_LABEL(0);
		  *(undefined4 *)(param1_02 + 8) = uVar2;
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
		  uVar2 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060061FE RID: 25086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60061FE")]
		[Address(RVA = "0xAE29", Offset = "0xAE29", VA = "0xAE29")]
		public DialogWindow ShowActionIsOverWindow()
		{
			return null;
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061FF")]
		[Address(RVA = "0xAE2A", Offset = "0xAE2A", VA = "0xAE2A")]
		public ExpectedAuchanError()
		{
		}

		// Token: 0x02001042 RID: 4162
		[Token(Token = "0x2001042")]
		internal class ErrorArgs
		{
			// Token: 0x06006200 RID: 25088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006200")]
			[Address(RVA = "0xAE2B", Offset = "0xAE2B", VA = "0xAE2B")]
			public ErrorArgs(UserData user, AccountsManager accountsManager, ArtifactData artifactData)
			{
			}

			// Token: 0x040034CF RID: 13519
			[Token(Token = "0x40034CF")]
			[FieldOffset(Offset = "0x8")]
			public readonly UserData User;

			// Token: 0x040034D0 RID: 13520
			[Token(Token = "0x40034D0")]
			[FieldOffset(Offset = "0xC")]
			public readonly AccountsManager AccountsManager;

			// Token: 0x040034D1 RID: 13521
			[Token(Token = "0x40034D1")]
			[FieldOffset(Offset = "0x10")]
			public readonly ArtifactData ArtifactData;
		}
	}
}
