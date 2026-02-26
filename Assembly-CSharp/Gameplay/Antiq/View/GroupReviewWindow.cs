using System;
using Core.MVC.Interfaces;
using Gameplay.Antiq.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D85 RID: 3461
	[Token(Token = "0x2000D85")]
	[AddComponentMenu("Antiq/View/GroupReviewWindow")]
	internal class GroupReviewWindow : ClosableBaseWindow<GroupReviewWindow.WindowArgs>
	{
		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001145")]
		public override string WindowId
		{
			[Token(Token = "0x60054B8")]
			[Address(RVA = "0xA265", Offset = "0xA265", VA = "0xA265", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0xA266", Offset = "0xA266", VA = "0xA266", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Antiq_View_GroupReviewWindow__OnClose(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param4;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param5;
		  int iVar1;
		  
		  if (DAT_ram_00a59488 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GroupReviewWindow_WindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Antiq_Control_GroupReviewViewMediator_TypeInfo);
		    DAT_ram_00a59488 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_GroupReviewWindow_WindowArgs__OnShow__);
		  param2_00 = *(undefined4 *)(param1 + 0x3c);
		  iVar1 = **(int **)(param2 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param2 + 0x18);
		  param4 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                     (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0x114));
		  param5 = *(undefined4 *)(param2 + 0x18);
		  param1_00 = unnamed_function_1417(Gameplay_Antiq_Control_GroupReviewViewMediator_TypeInfo);
		  Gameplay_Antiq_Control_GroupListViewMediator__HandleSearchInputChangedEvent_d__9__SetStateMachine
		            (param1_00,param2_00,param3_00,param4,param5,0);
		  *(undefined4 *)(param1 + 0x40) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0xA267", Offset = "0xA267", VA = "0xA267", Slot = "22")]
		protected override void OnShow(GroupReviewWindow.WindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Antiq_View_GroupReviewWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59489 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GroupReviewWindow_WindowArgs___ctor__);
		    DAT_ram_00a59489 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_GroupReviewWindow_WindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0xA268", Offset = "0xA268", VA = "0xA268")]
		public GroupReviewWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_View_GroupReviewWindow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5948a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    DAT_ram_00a5948a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GroupData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GroupData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Antiq/GroupReviewWindow";

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GroupReviewView _view;

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x02000D86 RID: 3462
		[Token(Token = "0x2000D86")]
		internal new class WindowArgs : BaseWindowArgs
		{
			// Token: 0x060054BC RID: 21692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054BC")]
			[Address(RVA = "0x1F41", Offset = "0x1F41", VA = "0x1F41")]
			public WindowArgs(AntiqController controller)
			{
			}

			// Token: 0x04002DE9 RID: 11753
			[Token(Token = "0x4002DE9")]
			[FieldOffset(Offset = "0x18")]
			public readonly AntiqController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Antiq_View_GroupReviewWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a59487 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GroupReviewWindow_WindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a59487 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_GroupReviewWindow_WindowArgs__OnClose__);
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8100d1de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x8100d1de:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

}
