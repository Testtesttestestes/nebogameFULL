using System;
using Gameplay.AccountLinker.Control;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;

namespace Gameplay.AccountLinker
{
	// Token: 0x02000DF2 RID: 3570
	[Token(Token = "0x2000DF2")]
	public class AccountLinker : AccountLinkerController
	{
		// Token: 0x06005727 RID: 22311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005727")]
		[Address(RVA = "0xA4A2", Offset = "0xA4A2", VA = "0xA4A2", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_AccountLinker__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_AccountLinker_Control_AccountLinkerController__RemoveListenEventForSiteHelper
		            (param1,param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005728")]
		[Address(RVA = "0xA4A3", Offset = "0xA4A3", VA = "0xA4A3")]
		public AccountLinker(AccountLinkerModel model, AccountLinkerEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_AccountLinker___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58903 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_AccountLinker_HandleSetUserSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_AccountLinker_HandleStartResolveAdditionalUsersEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58903 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_AccountLinker_HandleStartResolveAdditionalUsersEvent__,0)
		  ;
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		    System_Activator__CreateInstance(piVar4,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  uVar5 = *(undefined4 *)(iVar2 + 0x30);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Gameplay_AccountLinker_AccountLinker_HandleSetUserSuccessEvent__,0)
		  ;
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x30) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar4) && (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar4,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005729")]
		[Address(RVA = "0xA4A4", Offset = "0xA4A4", VA = "0xA4A4", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_AccountLinker_AccountLinker__HandleRun(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58904 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_AccountLinker_HandleSetUserSuccessEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_AccountLinker_HandleStartResolveAdditionalUsersEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58904 = '\x01';
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerController__SetEmailAndPass(param1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_AccountLinker_HandleStartResolveAdditionalUsersEvent__,0)
		  ;
		  piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		    System_Activator__CreateInstance(piVar4,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  uVar5 = *(undefined4 *)(iVar2 + 0x30);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Gameplay_AccountLinker_AccountLinker_HandleSetUserSuccessEvent__,0)
		  ;
		  piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x30) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar4) && (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar4,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572A")]
		[Address(RVA = "0xA4A5", Offset = "0xA4A5", VA = "0xA4A5", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572B")]
		[Address(RVA = "0xA4A6", Offset = "0xA4A6", VA = "0xA4A6")]
		private void HandleSetUserSuccessEvent()
		{
		/* --- GHIDRA: HandleSetUserSuccessEvent ---
		void Gameplay_AccountLinker_AccountLinker__HandleSetUserSuccessEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_AccountLinker_AccountLinker__HandleStartResolveAdditionalUsersEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572C")]
		[Address(RVA = "0xA4A7", Offset = "0xA4A7", VA = "0xA4A7")]
		private void HandleStartResolveAdditionalUsersEvent()
		{
		/* --- GHIDRA: HandleStartResolveAdditionalUsersEvent ---
		void Gameplay_AccountLinker_AccountLinker__HandleStartResolveAdditionalUsersEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58905 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_AccountLinker_HandleOnCloseSelectUserWindow__);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_SelectUserWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_View_SelectUserWindow_SelectUserWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12552);
		    DAT_ram_00a58905 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_AccountLinker_View_SelectUserWindow_SelectUserWindowArgs_TypeInfo)
		  ;
		  UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		  *(int *)(param1_00 + 0x18) = param1;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12552,param1_00,
		                     Method_UI_Windows_PopupController_Show_SelectUserWindow___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Gameplay_AccountLinker_AccountLinker_HandleOnCloseSelectUserWindow__,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar1,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572D")]
		[Address(RVA = "0xA4A8", Offset = "0xA4A8", VA = "0xA4A8")]
		private void ShowSelectUserWindow()
		{
		/* --- GHIDRA: ShowSelectUserWindow ---
		void Gameplay_AccountLinker_AccountLinker__ShowSelectUserWindow(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58906 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_AccountLinker_HandleOnCloseSelectUserWindow__);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58906 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_AccountLinker_HandleOnCloseSelectUserWindow__,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600572E RID: 22318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572E")]
		[Address(RVA = "0xA4A9", Offset = "0xA4A9", VA = "0xA4A9")]
		private void HandleOnCloseSelectUserWindow()
		{
		/* --- GHIDRA: HandleOnCloseSelectUserWindow ---
		void Gameplay_AccountLinker_AccountLinker__HandleOnCloseSelectUserWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x24),0);
		  if (iVar1 != 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x24),2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600572F RID: 22319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600572F")]
		[Address(RVA = "0xA4AA", Offset = "0xA4AA", VA = "0xA4AA")]
		private void CloseSelectUserWindow()
		{
		}

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0x24")]
		private SelectUserWindow _selectUserWindow;
	}
}
