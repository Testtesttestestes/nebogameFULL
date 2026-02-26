using System;
using Gameplay.AccountLinker.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000DFD")]
	public class ConfirmSelectedUserWindow : ClosableBaseWindow<ConfirmSelectedUserWindow.ConfirmSelectedUserWindowArgs>
	{
		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600575B RID: 22363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D0")]
		public override string WindowId
		{
			[Token(Token = "0x600575B")]
			[Address(RVA = "0xA4D6", Offset = "0xA4D6", VA = "0xA4D6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575C")]
		[Address(RVA = "0xA4D7", Offset = "0xA4D7", VA = "0xA4D7")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserWindow__OnDestroy
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a58919 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ConfirmSelectedUserWindow_ConfirmSelectedUserWindowArgs__OnShow__
		              );
		    DAT_ram_00a58919 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ConfirmSelectedUserWindow_ConfirmSelectedUserWindowArgs__OnShow__
		              );
		  iVar1 = **(int **)(param2 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator_TypeInfo
		                               );
		  Gameplay_AccountLinker_Model_LinkerUser___ctor(param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x0600575D RID: 22365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575D")]
		[Address(RVA = "0xA4D8", Offset = "0xA4D8", VA = "0xA4D8", Slot = "22")]
		protected override void OnShow(ConfirmSelectedUserWindow.ConfirmSelectedUserWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserWindow__OnShow
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5891a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ConfirmSelectedUserWindow_ConfirmSelectedUserWindowArgs___ctor__
		              );
		    DAT_ram_00a5891a = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ConfirmSelectedUserWindow_ConfirmSelectedUserWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600575E RID: 22366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575E")]
		[Address(RVA = "0xA4D9", Offset = "0xA4D9", VA = "0xA4D9")]
		public ConfirmSelectedUserWindow()
		{
		}

		// Token: 0x04002F53 RID: 12115
		[Token(Token = "0x4002F53")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/ConfirmSelectedUserWindow";

		// Token: 0x04002F54 RID: 12116
		[Token(Token = "0x4002F54")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ConfirmSelectedUserView _view;

		// Token: 0x04002F55 RID: 12117
		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0x40")]
		private AccountLinkerConfirmSelectedUserViewMediator _mediator;

		// Token: 0x02000DFE RID: 3582
		[Token(Token = "0x2000DFE")]
		public class ConfirmSelectedUserWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600575F RID: 22367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600575F")]
			[Address(RVA = "0xA4DA", Offset = "0xA4DA", VA = "0xA4DA")]
			public ConfirmSelectedUserWindowArgs()
			{
			}

			// Token: 0x04002F56 RID: 12118
			[Token(Token = "0x4002F56")]
			[FieldOffset(Offset = "0x18")]
			public AccountLinkerController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

}
