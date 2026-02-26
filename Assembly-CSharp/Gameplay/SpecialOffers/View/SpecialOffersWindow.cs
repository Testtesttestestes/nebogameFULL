using System;
using System.Collections.Generic;
using Gameplay.Bank.View;
using Gameplay.SpecialOffers.Controller;
using Gameplay.SpecialOffers.View.Picker;
using Il2CppDummyDll;
using UI;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	public class SpecialOffersWindow : ClosableBaseWindow<SpecialOffersWindow.SpecialOffersWindowArgs>, IOptionsOfferWindow
	{
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700058E")]
		public override string WindowId
		{
			[Token(Token = "0x6001E79")]
			[Address(RVA = "0x6FF2", Offset = "0x6FF2", VA = "0x6FF2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x1700058F")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x6FF3", Offset = "0x6FF3", VA = "0x6FF3", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000590")]
		public SpecialOfferPicker Picker
		{
			[Token(Token = "0x6001E7B")]
			[Address(RVA = "0x6FF4", Offset = "0x6FF4", VA = "0x6FF4", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000591")]
		public IndexButtonBasic InBankButton
		{
			[Token(Token = "0x6001E7C")]
			[Address(RVA = "0x6FF5", Offset = "0x6FF5", VA = "0x6FF5", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000592")]
		public OptionBoughtView OptionBoughtView
		{
			[Token(Token = "0x6001E7D")]
			[Address(RVA = "0x6FF6", Offset = "0x6FF6", VA = "0x6FF6", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x6FF7", Offset = "0x6FF7", VA = "0x6FF7", Slot = "22")]
		protected override void OnShow(SpecialOffersWindow.SpecialOffersWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_SpecialOffers_View_SpecialOffersWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5861b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs__OnClose__
		              );
		    DAT_ram_00a5861b = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs__OnClose__
		            );
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0x6FF8", Offset = "0x6FF8", VA = "0x6FF8", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_SpecialOffers_View_SpecialOffersWindow__OnClose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))
		            (*(int **)(param1 + 0x3c),param2,*(undefined4 *)(iVar1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x6FF9", Offset = "0x6FF9", VA = "0x6FF9", Slot = "30")]
		public void Init(IList<BankOptionListElement.BankOptionListElementArgs> optionArgs)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SpecialOffers_View_SpecialOffersWindow__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a5861c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_TypeInfo);
		    DAT_ram_00a5861c = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(int **)(iVar1 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                        (param4,*(undefined4 *)(*param4 + 0x104));
		  param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                     (param4,*(undefined4 *)(*param4 + 0x114));
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_TypeInfo
		                               );
		  if (DAT_ram_00a58653 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow___ctor__
		              );
		    DAT_ram_00a58653 = '\x01';
		  }
		  Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_object__object____ctor
		            (param1_00,param2_00,param3,param4,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x48) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x6FFA", Offset = "0x6FFA", VA = "0x6FFA")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_SpecialOffers_View_SpecialOffersWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x48) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x6FFB", Offset = "0x6FFB", VA = "0x6FFB")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_SpecialOffers_View_SpecialOffersWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5861d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs___ctor__
		              );
		    DAT_ram_00a5861d = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x6FFC", Offset = "0x6FFC", VA = "0x6FFC")]
		public SpecialOffersWindow()
		{
		}

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SpecialOffers/SpecialOffersWindow";

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpecialOfferPicker _picker;

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IndexButtonBasic _inBankButton;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private OptionBoughtView _optionBoughtView;

		// Token: 0x0400109A RID: 4250
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0x48")]
		private SpecialOffersViewMediator _mediator;

		// Token: 0x020004FE RID: 1278
		[Token(Token = "0x20004FE")]
		public class SpecialOffersWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001E84 RID: 7812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x6FFD", Offset = "0x6FFD", VA = "0x6FFD")]
			public SpecialOffersWindowArgs()
			{
			}

			// Token: 0x0400109B RID: 4251
			[Token(Token = "0x400109B")]
			[FieldOffset(Offset = "0x18")]
			public SpecialOffersController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OptionBoughtView ---
		void Gameplay_SpecialOffers_View_SpecialOffersWindow__get_OptionBoughtView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5861a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs__OnShow__
		              );
		    DAT_ram_00a5861a = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_SpecialOffersWindow_SpecialOffersWindowArgs__OnShow__
		              );
		  Gameplay_SpecialOffers_View_SpecialOffersWindow__Init(param1,param1);
		  return;
		}
		*/

}
