using System;
using Gameplay.Accounts.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCB RID: 3531
	[Token(Token = "0x2000DCB")]
	public class AccountsListWindow : ClosableBaseWindow<AccountsListWindow.AccountsListWindowsArgs>
	{
		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06005622 RID: 22050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001182")]
		public override string WindowId
		{
			[Token(Token = "0x6005622")]
			[Address(RVA = "0xA3C0", Offset = "0xA3C0", VA = "0xA3C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005623")]
		[Address(RVA = "0xA3C1", Offset = "0xA3C1", VA = "0xA3C1", Slot = "22")]
		protected override void OnShow(AccountsListWindow.AccountsListWindowsArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Accounts_View_AccountsListWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58896 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_AccountsListWindow_AccountsListWindowsArgs__OnClose__
		              );
		    DAT_ram_00a58896 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_AccountsListWindow_AccountsListWindowsArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005624")]
		[Address(RVA = "0xA3C2", Offset = "0xA3C2", VA = "0xA3C2", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Accounts_View_AccountsListWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58897 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_AccountsListWindow_AccountsListWindowsArgs___ctor__
		              );
		    DAT_ram_00a58897 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_AccountsListWindow_AccountsListWindowsArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005625")]
		[Address(RVA = "0xA3C3", Offset = "0xA3C3", VA = "0xA3C3")]
		public AccountsListWindow()
		{
		}

		// Token: 0x04002EB8 RID: 11960
		[Token(Token = "0x4002EB8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Accounts/AccountsListWindow";

		// Token: 0x04002EB9 RID: 11961
		[Token(Token = "0x4002EB9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private AccountsListView _view;

		// Token: 0x04002EBA RID: 11962
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x40")]
		private AccountsListViewMediator _mediator;

		// Token: 0x02000DCC RID: 3532
		[Token(Token = "0x2000DCC")]
		public class AccountsListWindowsArgs : BaseWindowArgs
		{
			// Token: 0x06005626 RID: 22054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005626")]
			[Address(RVA = "0xA3C4", Offset = "0xA3C4", VA = "0xA3C4")]
			public AccountsListWindowsArgs()
			{
			}

			// Token: 0x04002EBB RID: 11963
			[Token(Token = "0x4002EBB")]
			[FieldOffset(Offset = "0x18")]
			public AccountsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Accounts_View_AccountsListWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param4;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param5;
		  int iVar1;
		  
		  if (DAT_ram_00a58895 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Control_AccountsListViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_AccountsListWindow_AccountsListWindowsArgs__OnShow__
		              );
		    DAT_ram_00a58895 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_AccountsListWindow_AccountsListWindowsArgs__OnShow__
		              );
		  param2_00 = *(undefined4 *)(param1 + 0x3c);
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param4 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                     (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param5 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = unnamed_function_1417(Gameplay_Accounts_Control_AccountsListViewMediator_TypeInfo);
		  if (DAT_ram_00a588e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsListView___ctor__
		              );
		    DAT_ram_00a588e2 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param2_00,param3_00,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsListView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

}
