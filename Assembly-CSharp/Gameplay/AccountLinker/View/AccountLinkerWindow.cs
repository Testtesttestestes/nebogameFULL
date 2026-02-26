using System;
using Core.Gameplay;
using Gameplay.AccountLinker.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF7 RID: 3575
	[Token(Token = "0x2000DF7")]
	public class AccountLinkerWindow : BaseWindow<AccountLinkerWindow.AccountLinkerWindowArgs>
	{
		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06005744 RID: 22340 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CC")]
		public override string WindowId
		{
			[Token(Token = "0x6005744")]
			[Address(RVA = "0xA4BF", Offset = "0xA4BF", VA = "0xA4BF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005745")]
		[Address(RVA = "0xA4C0", Offset = "0xA4C0", VA = "0xA4C0", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_AccountLinker_View_AccountLinkerWindow__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5890c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_AccountLinker_Control_AccountLinkerViewMediator_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5890c = '\x01';
		  }
		  piVar3 = *(int **)(param2 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1a8);
		        goto code_r0x80f48e1c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x80f48e1c:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(*(int *)(iVar4 + 0x18) + 0x18);
		  iVar4 = *piVar3;
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                        (piVar3,*(undefined4 *)(iVar4 + 0x104));
		  piVar3 = *(int **)(param2 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1a8);
		        goto code_r0x80f48ebd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x80f48ebd:
		  uVar1 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(*(int *)(iVar4 + 0x18) + 0x18);
		  iVar4 = *piVar3;
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		                        (piVar3,*(undefined4 *)(iVar4 + 0x114));
		  piVar3 = *(int **)(param2 + 0x18);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1a8);
		        goto code_r0x80f48f5e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x80f48f5e:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(*(int *)(iVar4 + 0x18) + 0x18);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_AccountLinker_Control_AccountLinkerViewMediator_TypeInfo);
		  Gameplay_AccountLinker_Control_AccountLinkerViewMediator__Dispose
		            (piVar3,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x38) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,*(undefined4 *)(param1 + 0x34),*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005746")]
		[Address(RVA = "0xA4C1", Offset = "0xA4C1", VA = "0xA4C1", Slot = "22")]
		protected override void OnShow(AccountLinkerWindow.AccountLinkerWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_AccountLinker_View_AccountLinkerWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5890d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_AccountLinkerWindow_AccountLinkerWindowArgs___ctor__);
		    DAT_ram_00a5890d = '\x01';
		  }
		  UnityEngine_UIElements_BaseUxmlFactory___Il2CppFullySharedGenericType__object___get_uxmlType
		            (param1,
		             Method_UI_Windows_BaseWindow_AccountLinkerWindow_AccountLinkerWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005747")]
		[Address(RVA = "0xA4C2", Offset = "0xA4C2", VA = "0xA4C2")]
		public AccountLinkerWindow()
		{
		}

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/AccountLinkerWindow";

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AccountLinkerView _view;

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x38")]
		private AccountLinkerViewMediator _mediator;

		// Token: 0x02000DF8 RID: 3576
		[Token(Token = "0x2000DF8")]
		public class AccountLinkerWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005748 RID: 22344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005748")]
			[Address(RVA = "0xA4C3", Offset = "0xA4C3", VA = "0xA4C3")]
			public AccountLinkerWindowArgs(IGame game)
			{
			}

			// Token: 0x04002F4A RID: 12106
			[Token(Token = "0x4002F4A")]
			[FieldOffset(Offset = "0x18")]
			public readonly IGame Game;
		}
	}
}
