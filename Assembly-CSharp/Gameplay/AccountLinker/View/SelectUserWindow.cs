using System;
using Gameplay.AccountLinker.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E04 RID: 3588
	[Token(Token = "0x2000E04")]
	public class SelectUserWindow : BaseWindow<SelectUserWindow.SelectUserWindowArgs>
	{
		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D3")]
		public override string WindowId
		{
			[Token(Token = "0x6005772")]
			[Address(RVA = "0xA4ED", Offset = "0xA4ED", VA = "0xA4ED", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005773")]
		[Address(RVA = "0xA4EE", Offset = "0xA4EE", VA = "0xA4EE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_AccountLinker_View_SelectUserWindow__OnDestroy
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a58929 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_TypeInfo);
		    DAT_ram_00a58929 = '\x01';
		  }
		  iVar1 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_TypeInfo
		                               );
		  Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__Dispose
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x38) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x34),*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06005774 RID: 22388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005774")]
		[Address(RVA = "0xA4EF", Offset = "0xA4EF", VA = "0xA4EF", Slot = "22")]
		protected override void OnShow(SelectUserWindow.SelectUserWindowArgs args)
		{
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005775")]
		[Address(RVA = "0xA4F0", Offset = "0xA4F0", VA = "0xA4F0", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_AccountLinker_View_SelectUserWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5892a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_SelectUserWindow_SelectUserWindowArgs___ctor__);
		    DAT_ram_00a5892a = '\x01';
		  }
		  UnityEngine_UIElements_BaseUxmlFactory___Il2CppFullySharedGenericType__object___get_uxmlType
		            (param1,Method_UI_Windows_BaseWindow_SelectUserWindow_SelectUserWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005776")]
		[Address(RVA = "0xA4F1", Offset = "0xA4F1", VA = "0xA4F1")]
		public SelectUserWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_View_SelectUserWindow___ctor(undefined4 param1,undefined4 param2)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x04002F60 RID: 12128
		[Token(Token = "0x4002F60")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/SelectUsersWindow";

		// Token: 0x04002F61 RID: 12129
		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private SelectUserView _view;

		// Token: 0x04002F62 RID: 12130
		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x38")]
		private AccountLinkerSelectUserViewMediator _mediator;

		// Token: 0x02000E05 RID: 3589
		[Token(Token = "0x2000E05")]
		public class SelectUserWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005777 RID: 22391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005777")]
			[Address(RVA = "0xA4F2", Offset = "0xA4F2", VA = "0xA4F2")]
			public SelectUserWindowArgs()
			{
			}

			// Token: 0x04002F63 RID: 12131
			[Token(Token = "0x4002F63")]
			[FieldOffset(Offset = "0x18")]
			public AccountLinkerController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_AccountLinker_View_SelectUserWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x38);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x38),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x38) = 0;
		  return;
		}
		*/

}
