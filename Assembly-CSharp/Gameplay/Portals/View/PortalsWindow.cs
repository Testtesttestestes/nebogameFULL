using System;
using Gameplay.Portals.Controller;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B5 RID: 1461
	[Token(Token = "0x20005B5")]
	public class PortalsWindow : ClosableBaseWindow<PortalsWindow.PortalsWindowArgs>
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067C")]
		public PortalsView PortalsView
		{
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x746B", Offset = "0x746B", VA = "0x746B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700067D")]
		public override string WindowId
		{
			[Token(Token = "0x6002318")]
			[Address(RVA = "0x746C", Offset = "0x746C", VA = "0x746C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002319")]
		[Address(RVA = "0x746D", Offset = "0x746D", VA = "0x746D", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Portals_View_PortalsWindow__OnClose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a580ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__OnShow__);
		    DAT_ram_00a580ea = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__OnShow__);
		  Gameplay_Portals_View_PortalsWindow__OnShow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x746E", Offset = "0x746E", VA = "0x746E", Slot = "22")]
		protected override void OnShow(PortalsWindow.PortalsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Portals_View_PortalsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  int *param4;
		  
		  if (DAT_ram_00a580eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Controller_PortalsViewMediator_TypeInfo);
		    DAT_ram_00a580eb = '\x01';
		  }
		  if (*(char *)(param1 + 0x44) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x290);
		          goto code_r0x80ea1472;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea1472:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    param4 = *(int **)(iVar4 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                          (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    piVar3 = (int *)unnamed_function_1417(Gameplay_Portals_Controller_PortalsViewMediator_TypeInfo);
		    Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass21_0___HandleChoice_b__0
		              (piVar3,param2_00,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		              (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		    *(undefined1 *)(param1 + 0x44) = 1;
		    *(int **)(param1 + 0x40) = piVar3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231B")]
		[Address(RVA = "0x746F", Offset = "0x746F", VA = "0x746F")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Portals_View_PortalsWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x44) != '\0') {
		    iVar1 = **(int **)(param1 + 0x40);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x40) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231C")]
		[Address(RVA = "0x7470", Offset = "0x7470", VA = "0x7470")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Portals_View_PortalsWindow__DestroyMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__HandleBackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__get_CurrentState__);
		    DAT_ram_00a580ec = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x40);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                    (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) - 1U < 2) {
		    Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow___ctor
		              (param1,
		               Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__HandleBackButton__
		              );
		    return;
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator__set_Events(*(undefined4 *)(param1 + 0x40),0);
		  return;
		}
		*/

		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231D")]
		[Address(RVA = "0x7471", Offset = "0x7471", VA = "0x7471", Slot = "29")]
		protected override void HandleBackButton()
		{
		/* --- GHIDRA: HandleBackButton ---
		void Gameplay_Portals_View_PortalsWindow__HandleBackButton(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__HandleCloseButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsView_PortalsState__get_CurrentState__);
		    DAT_ram_00a580ed = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x40);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x158) * 4))
		                    (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x3c) + 0x18) - 1U < 2) {
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___FeedbackFormWindow__HandleCloseButton_d__12_
		              (param1,
		               Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__HandleCloseButton__
		              );
		    return;
		  }
		  Gameplay_Portals_Controller_PortalsViewMediator__set_Events(*(undefined4 *)(param1 + 0x40),0);
		  return;
		}
		*/

		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231E")]
		[Address(RVA = "0x7472", Offset = "0x7472", VA = "0x7472", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		void Gameplay_Portals_View_PortalsWindow__HandleCloseButton(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs___ctor__);
		    DAT_ram_00a580ee = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x7473", Offset = "0x7473", VA = "0x7473")]
		public PortalsWindow()
		{
		}

		// Token: 0x0400133A RID: 4922
		[Token(Token = "0x400133A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Portals/PortalsWindow";

		// Token: 0x0400133B RID: 4923
		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private PortalsView _portalsView;

		// Token: 0x0400133C RID: 4924
		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0x40")]
		private PortalsViewMediator _mediator;

		// Token: 0x0400133D RID: 4925
		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x44")]
		private bool _mvcSetUp;

		// Token: 0x020005B6 RID: 1462
		[Token(Token = "0x20005B6")]
		public class PortalsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002320 RID: 8992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x7474", Offset = "0x7474", VA = "0x7474")]
			public PortalsWindowArgs(PortalsTargets targetForShow)
			{
			}

			// Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x7475", Offset = "0x7475", VA = "0x7475")]
			public PortalsWindowArgs()
			{
			}

			// Token: 0x0400133E RID: 4926
			[Token(Token = "0x400133E")]
			[FieldOffset(Offset = "0x18")]
			public readonly PortalsTargets TargetForShow;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PortalsView ---
		undefined4 Gameplay_Portals_View_PortalsWindow__get_PortalsView(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12659);
		    DAT_ram_00a580e8 = '\x01';
		  }
		  return StringLiteral_12659;
		}
		*/


		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Portals_View_PortalsWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__OnClose__);
		    DAT_ram_00a580e9 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_PortalsWindow_PortalsWindowArgs__OnClose__)
		  ;
		  if (*(char *)(param1 + 0x44) != '\0') {
		    iVar1 = **(int **)(param1 + 0x40);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x40) = 0;
		  }
		  return;
		}
		*/

}
