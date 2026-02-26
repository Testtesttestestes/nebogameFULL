using System;
using Gameplay.Isles.User;
using Gameplay.Tree.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows.Buildings.TreeWindow
{
	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	public class TreeWindow2 : ClosableBaseWindow<TreeWindow2.TreeWindow2Args>
	{
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000263")]
		public override string WindowId
		{
			[Token(Token = "0x6001056")]
			[Address(RVA = "0x6254", Offset = "0x6254", VA = "0x6254", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001057")]
		[Address(RVA = "0x6255", Offset = "0x6255", VA = "0x6255", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void UI_Windows_Buildings_TreeWindow_TreeWindow2__OnClose(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58ab5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_TreeWindow2_TreeWindow2Args__OnShow__);
		    DAT_ram_00a58ab5 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_TreeWindow2_TreeWindow2Args__OnShow__);
		  iVar1 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(param2 + 0x18),*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x6256", Offset = "0x6256", VA = "0x6256", Slot = "22")]
		protected override void OnShow(TreeWindow2.TreeWindow2Args args)
		{
		/* --- GHIDRA: OnShow ---
		void UI_Windows_Buildings_TreeWindow_TreeWindow2__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ab6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_TreeWindow2_TreeWindow2Args___ctor__);
		    DAT_ram_00a58ab6 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_TreeWindow2_TreeWindow2Args___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x6257", Offset = "0x6257", VA = "0x6257")]
		public TreeWindow2()
		{
		}

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tree/TreeWindow2";

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TreeView2 _treeView;

		// Token: 0x020002B7 RID: 695
		[Token(Token = "0x20002B7")]
		public class TreeWindow2Args : BaseBuildingWindowArgs
		{
			// Token: 0x0600105A RID: 4186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600105A")]
			[Address(RVA = "0x6258", Offset = "0x6258", VA = "0x6258")]
			public TreeWindow2Args(UserIsle isle, uint buildingTypeId)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_Buildings_TreeWindow_TreeWindow2__get_WindowId(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ab4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_TreeWindow2_TreeWindow2Args__OnClose__);
		    DAT_ram_00a58ab4 = '\x01';
		  }
		  Gameplay_Tree_View_TreeView2__Init(*(undefined4 *)(param1 + 0x3c),0);
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_TreeWindow2_TreeWindow2Args__OnClose__);
		  return;
		}
		*/

}
