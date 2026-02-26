using System;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.ProgressSaver.View
{
	// Token: 0x02000E0B RID: 3595
	[Token(Token = "0x2000E0B")]
	public class ProgressSaverViewWindow : ClosableBaseWindow<ProgressSaverViewWindow.ProgressSaverViewWindowArgs>
	{
		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011E2")]
		public override string WindowId
		{
			[Token(Token = "0x6005791")]
			[Address(RVA = "0xA50C", Offset = "0xA50C", VA = "0xA50C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005792")]
		[Address(RVA = "0xA50D", Offset = "0xA50D", VA = "0xA50D", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_AccountLinker_ProgressSaver_View_ProgressSaverViewWindow__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a58932 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ProgressSaverViewWindow_ProgressSaverViewWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_TypeInfo);
		    DAT_ram_00a58932 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ProgressSaverViewWindow_ProgressSaverViewWindowArgs__OnShow__
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
		                               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverViewMediator_TypeInfo
		                               );
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator___c___SetupView_b__18_2
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005793")]
		[Address(RVA = "0xA50E", Offset = "0xA50E", VA = "0xA50E", Slot = "22")]
		protected override void OnShow(ProgressSaverViewWindow.ProgressSaverViewWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_AccountLinker_ProgressSaver_View_ProgressSaverViewWindow__OnShow
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58933 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ProgressSaverViewWindow_ProgressSaverViewWindowArgs___ctor__
		              );
		    DAT_ram_00a58933 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ProgressSaverViewWindow_ProgressSaverViewWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005794")]
		[Address(RVA = "0xA50F", Offset = "0xA50F", VA = "0xA50F")]
		public ProgressSaverViewWindow()
		{
		}

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/ProgressSaverFeature/ProgressSaverWindow";

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ProgressSaverView _view;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x40")]
		private ProgressSaverViewMediator _mediator;

		// Token: 0x02000E0C RID: 3596
		[Token(Token = "0x2000E0C")]
		public class ProgressSaverViewWindowArgs : BaseWindowArgs
		{
			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x06005795 RID: 22421 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170011E3")]
			public ProgressSaverController Controller
			{
				[Token(Token = "0x6005795")]
				[Address(RVA = "0xA510", Offset = "0xA510", VA = "0xA510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06005796 RID: 22422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005796")]
			[Address(RVA = "0xA511", Offset = "0xA511", VA = "0xA511")]
			public ProgressSaverViewWindowArgs(ProgressSaverController controller)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_AccountLinker_ProgressSaver_View_ProgressSaverViewWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58931 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ProgressSaverViewWindow_ProgressSaverViewWindowArgs__OnClose__
		              );
		    DAT_ram_00a58931 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ProgressSaverViewWindow_ProgressSaverViewWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

}
