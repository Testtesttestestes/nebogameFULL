using System;
using System.Collections.Generic;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B61 RID: 2913
	[Token(Token = "0x2000B61")]
	public class BossRewardingWindow : ClosableBaseWindow<BossRewardingWindow.BossRewardingWindowArgs>
	{
		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E01")]
		public override string WindowId
		{
			[Token(Token = "0x60046A2")]
			[Address(RVA = "0x9538", Offset = "0x9538", VA = "0x9538", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E02")]
		public BossRewardingView RewardingView
		{
			[Token(Token = "0x60046A3")]
			[Address(RVA = "0x9539", Offset = "0x9539", VA = "0x9539")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x953A", Offset = "0x953A", VA = "0x953A", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Boss_View_Rewarding_BossRewardingWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a579e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BossRewardingWindow_BossRewardingWindowArgs__OnClose__
		              );
		    DAT_ram_00a579e4 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_BossRewardingWindow_BossRewardingWindowArgs__OnClose__
		            );
		  piVar1 = *(int **)(param1 + 0x40);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x953B", Offset = "0x953B", VA = "0x953B", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Boss_View_Rewarding_BossRewardingWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BossRewardingWindow_BossRewardingWindowArgs___ctor__
		              );
		    DAT_ram_00a579e5 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_BossRewardingWindow_BossRewardingWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x953C", Offset = "0x953C", VA = "0x953C")]
		public BossRewardingWindow()
		{
		}

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossRewardingWindow";

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BossRewardingView _rewardingView;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x40")]
		private BossRewardingWindowMediator _mediator;

		// Token: 0x02000B62 RID: 2914
		[Token(Token = "0x2000B62")]
		public class BossRewardingWindowArgs : BaseWindowArgs
		{
			// Token: 0x060046A7 RID: 18087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046A7")]
			[Address(RVA = "0x953D", Offset = "0x953D", VA = "0x953D")]
			public BossRewardingWindowArgs()
			{
			}

			// Token: 0x040026AD RID: 9901
			[Token(Token = "0x40026AD")]
			[FieldOffset(Offset = "0x18")]
			public BossInstance BossInstance;

			// Token: 0x040026AE RID: 9902
			[Token(Token = "0x40026AE")]
			[FieldOffset(Offset = "0x1C")]
			public List<ulong> TeamIds;

			// Token: 0x040026AF RID: 9903
			[Token(Token = "0x40026AF")]
			[FieldOffset(Offset = "0x20")]
			public int SelectedIndex;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardingView ---
		void Gameplay_Boss_View_Rewarding_BossRewardingWindow__get_RewardingView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a579e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRewardingWindowMediator_TypeInfo);
		    DAT_ram_00a579e3 = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,
		             Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__OnShow__);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__get_WindowArgs__
		                      );
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 8);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__get_WindowArgs__
		                      );
		  param3_00 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0x10);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BossRewardingWindow_BossRewardingWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0xc);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Boss_Controller_BossRewardingWindowMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossRewardingWindowMediator__get_CurrentTeamId
		            (param1_00,param2_00,param3_00,param4,0);
		  *(int **)(param1 + 0x40) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

}
