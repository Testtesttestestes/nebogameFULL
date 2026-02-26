using System;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFA RID: 3578
	[Token(Token = "0x2000DFA")]
	public class CodeDisplayViewWindow : ClosableBaseWindow<CodeDisplayViewWindow.CodeDisplayWindowArgs>
	{
		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CE")]
		public override string WindowId
		{
			[Token(Token = "0x6005750")]
			[Address(RVA = "0xA4CB", Offset = "0xA4CB", VA = "0xA4CB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005751")]
		[Address(RVA = "0xA4CC", Offset = "0xA4CC", VA = "0xA4CC", Slot = "22")]
		protected override void OnShow(CodeDisplayViewWindow.CodeDisplayWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_AccountLinker_View_CodeDisplayViewWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58913 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CodeDisplayViewWindow_CodeDisplayWindowArgs___ctor__
		              );
		    DAT_ram_00a58913 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CodeDisplayViewWindow_CodeDisplayWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005752 RID: 22354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005752")]
		[Address(RVA = "0xA4CD", Offset = "0xA4CD", VA = "0xA4CD")]
		public CodeDisplayViewWindow()
		{
		}

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/CodeDisplayViewWindow";

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CodeDisplayView _codeDisplayView;

		// Token: 0x02000DFB RID: 3579
		[Token(Token = "0x2000DFB")]
		public class CodeDisplayWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005753 RID: 22355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005753")]
			[Address(RVA = "0xA4CE", Offset = "0xA4CE", VA = "0xA4CE")]
			public CodeDisplayWindowArgs()
			{
			}

			// Token: 0x04002F50 RID: 12112
			[Token(Token = "0x4002F50")]
			[FieldOffset(Offset = "0x18")]
			public string Code;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_AccountLinker_View_CodeDisplayViewWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58912 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CodeDisplayViewWindow_CodeDisplayWindowArgs__OnShow__
		              );
		    DAT_ram_00a58912 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CodeDisplayViewWindow_CodeDisplayWindowArgs__OnShow__
		              );
		  iVar2 = *(int *)(param1 + 0x3c);
		  param2_00 = *(undefined4 *)(param2 + 0x18);
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar2 + 0x18),param2_00,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar2 + 0x18) = param2_00;
		    iVar1 = **(int **)(iVar2 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(iVar2 + 0x10),param2_00,*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/

}
