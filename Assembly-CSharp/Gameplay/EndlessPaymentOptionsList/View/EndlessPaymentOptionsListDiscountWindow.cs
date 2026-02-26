using System;
using Gameplay.EndlessPaymentOptionsList.Control;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2000838")]
	public class EndlessPaymentOptionsListDiscountWindow : ClosableBaseWindow<EndlessPaymentOptionsListDiscountWindow.EndlessPaymentOptionsListDiscountWindowArgs>
	{
		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009BE")]
		public override string WindowId
		{
			[Token(Token = "0x6003180")]
			[Address(RVA = "0x81D8", Offset = "0x81D8", VA = "0x81D8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x170009BF")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6003181")]
			[Address(RVA = "0x81D9", Offset = "0x81D9", VA = "0x81D9", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C0")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6003182")]
			[Address(RVA = "0x81DA", Offset = "0x81DA", VA = "0x81DA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C1")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6003183")]
			[Address(RVA = "0x81DB", Offset = "0x81DB", VA = "0x81DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C2")]
		public Transform DiscountBanner
		{
			[Token(Token = "0x6003184")]
			[Address(RVA = "0x81DC", Offset = "0x81DC", VA = "0x81DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C3")]
		public Button ConfirmButton
		{
			[Token(Token = "0x6003185")]
			[Address(RVA = "0x81DD", Offset = "0x81DD", VA = "0x81DD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x81DE", Offset = "0x81DE", VA = "0x81DE", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow__OnClose
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a5762f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_TypeInfo
		              );
		    DAT_ram_00a5762f = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__OnShow__
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
		                               Gameplay_EndlessPaymentOptionsList_Control_EndlessPaymentOptionListDiscountWindowMediator_TypeInfo
		                               );
		  if (DAT_ram_00a57655 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListDiscountWindow___ctor__
		              );
		    DAT_ram_00a57655 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_EndlessPaymentOptionsListModel__EndlessPaymentOptionsListEvents__EndlessPaymentOptionsListController__EndlessPaymentOptionsListDiscountWindow___ctor__
		            );
		  *(int **)(param1 + 0x4c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x81DF", Offset = "0x81DF", VA = "0x81DF", Slot = "22")]
		protected override void OnShow(EndlessPaymentOptionsListDiscountWindow.EndlessPaymentOptionsListDiscountWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow__OnShow
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57630 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs___ctor__
		              );
		    DAT_ram_00a57630 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x81E0", Offset = "0x81E0", VA = "0x81E0")]
		public EndlessPaymentOptionsListDiscountWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined1 *)(param1 + 0xc) = 0;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  return;
		}
		*/

		}

		// Token: 0x04001B16 RID: 6934
		[Token(Token = "0x4001B16")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/EndlessPaymentOptionsList/EndlessPaymentOptionsListDiscountWindow";

		// Token: 0x04001B17 RID: 6935
		[Token(Token = "0x4001B17")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001B18 RID: 6936
		[Token(Token = "0x4001B18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001B19 RID: 6937
		[Token(Token = "0x4001B19")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _discountBanner;

		// Token: 0x04001B1A RID: 6938
		[Token(Token = "0x4001B1A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04001B1B RID: 6939
		[Token(Token = "0x4001B1B")]
		[FieldOffset(Offset = "0x4C")]
		private EndlessPaymentOptionListDiscountWindowMediator _mediator;

		// Token: 0x02000839 RID: 2105
		[Token(Token = "0x2000839")]
		public class EndlessPaymentOptionsListDiscountWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003189 RID: 12681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003189")]
			[Address(RVA = "0x81E1", Offset = "0x81E1", VA = "0x81E1")]
			public EndlessPaymentOptionsListDiscountWindowArgs(EndlessPaymentOptionListData list, EndlessPaymentOptionsListController controller)
			{
			}

			// Token: 0x04001B1C RID: 6940
			[Token(Token = "0x4001B1C")]
			[FieldOffset(Offset = "0x18")]
			public readonly EndlessPaymentOptionsListController Controller;

			// Token: 0x04001B1D RID: 6941
			[Token(Token = "0x4001B1D")]
			[FieldOffset(Offset = "0x1C")]
			public readonly EndlessPaymentOptionListData ListData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ConfirmButton ---
		void Gameplay_EndlessPaymentOptionsList_View_EndlessPaymentOptionsListDiscountWindow__get_ConfirmButton
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5762e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__OnClose__
		              );
		    DAT_ram_00a5762e = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_EndlessPaymentOptionsListDiscountWindow_EndlessPaymentOptionsListDiscountWindowArgs__OnClose__
		            );
		  piVar1 = *(int **)(param1 + 0x4c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  return;
		}
		*/

}
