using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay;
using Gameplay.Bank.View;
using Gameplay.SpecialOffers.Controller;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View.Picker;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	public class OptionsOfferWindow : ClosableBaseWindow<OptionsOfferWindow.OptionsOfferWindowArgs>, IOptionsOfferWindow
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000584")]
		public override string WindowId
		{
			[Token(Token = "0x6001E65")]
			[Address(RVA = "0x6FDE", Offset = "0x6FDE", VA = "0x6FDE", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x17000585")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6001E66")]
			[Address(RVA = "0x6FDF", Offset = "0x6FDF", VA = "0x6FDF", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000586")]
		public SpecialOfferPicker Picker
		{
			[Token(Token = "0x6001E67")]
			[Address(RVA = "0x6FE0", Offset = "0x6FE0", VA = "0x6FE0", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000587")]
		public IndexButtonBasic InBankButton
		{
			[Token(Token = "0x6001E68")]
			[Address(RVA = "0x6FE1", Offset = "0x6FE1", VA = "0x6FE1", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000588")]
		public OptionBoughtView OptionBoughtView
		{
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x6FE2", Offset = "0x6FE2", VA = "0x6FE2", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x6FE3", Offset = "0x6FE3", VA = "0x6FE3", Slot = "22")]
		protected override void OnShow(OptionsOfferWindow.OptionsOfferWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_SpecialOffers_View_OptionsOfferWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58615 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__OnClose__
		              );
		    DAT_ram_00a58615 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__OnClose__
		            );
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x50),0);
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x6FE4", Offset = "0x6FE4", VA = "0x6FE4", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x6FE5", Offset = "0x6FE5", VA = "0x6FE5", Slot = "30")]
		public void Init(IList<BankOptionListElement.BankOptionListElementArgs> optionArgs)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SpecialOffers_View_OptionsOfferWindow__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  
		  if (DAT_ram_00a58616 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Controller_OptionsOfferController_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Events_OptionsOfferEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Model_OptionsOfferModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_OptionsOfferViewMediator_TypeInfo);
		    DAT_ram_00a58616 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		                      );
		  uVar3 = *(undefined4 *)(iVar1 + 0x18);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		                      );
		  uVar4 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar1 + 0x28);
		  uVar2 = unnamed_function_1417(Gameplay_SpecialOffers_Model_OptionsOfferModel_TypeInfo);
		  Gameplay_SpecialOffers_Model_OptionsOfferModel__set_Offers(uVar2,uVar3,uVar4,param4,param1);
		  *(undefined4 *)(param1 + 0x54) = uVar2;
		  uVar2 = unnamed_function_1417(Gameplay_SpecialOffers_Events_OptionsOfferEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x58) = uVar2;
		  uVar4 = *(undefined4 *)(param1 + 0x54);
		  uVar3 = unnamed_function_1417(Gameplay_SpecialOffers_Controller_OptionsOfferController_TypeInfo);
		  if (DAT_ram_00a5863b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_OptionsOfferModel__OptionsOfferEvents___ctor__
		              );
		    DAT_ram_00a5863b = '\x01';
		  }
		  UI_Windows_Buildings_BaseIsleBuildingWindowArgs___Il2CppFullySharedGenericType____ctor
		            (uVar3,uVar4,uVar2,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_OptionsOfferModel__OptionsOfferEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x50) = uVar3;
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  uVar4 = *(undefined4 *)(param1 + 0x58);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_SpecialOffers_Controller_OptionsOfferViewMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a5863e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_OptionsOfferModel__OptionsOfferEvents__OptionsOfferController__OptionsOfferWindow___ctor__
		              );
		    DAT_ram_00a5863e = '\x01';
		  }
		  Gameplay_SpecialOffers_Controller_OptionsOfferControllerBase_object__object____ctor
		            (param1_00,uVar2,uVar4,uVar3,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_OptionsOfferModel__OptionsOfferEvents__OptionsOfferController__OptionsOfferWindow___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x5c) = param1_00;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x50),0);
		  return;
		}
		*/

		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x6FE6", Offset = "0x6FE6", VA = "0x6FE6")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_SpecialOffers_View_OptionsOfferWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x50),0);
		  iVar1 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x54);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x6FE7", Offset = "0x6FE7", VA = "0x6FE7")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_SpecialOffers_View_OptionsOfferWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58617 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs___ctor__
		              );
		    DAT_ram_00a58617 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x6FE8", Offset = "0x6FE8", VA = "0x6FE8")]
		public OptionsOfferWindow()
		{
		}

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SpecialOffers/OptionsOfferWindow";

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpecialOfferPicker _picker;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IndexButtonBasic _inBankButton;

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OptionBoughtView _optionBoughtView;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x50")]
		private OptionsOfferController _controller;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x54")]
		private OptionsOfferModel _model;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x58")]
		private OptionsOfferEvents _events;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x5C")]
		private OptionsOfferViewMediator _mediator;

		// Token: 0x020004FB RID: 1275
		[Token(Token = "0x20004FB")]
		public class OptionsOfferWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001E70 RID: 7792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E70")]
			[Address(RVA = "0x6FE9", Offset = "0x6FE9", VA = "0x6FE9")]
			public OptionsOfferWindowArgs()
			{
			}

			// Token: 0x0400108B RID: 4235
			[Token(Token = "0x400108B")]
			[FieldOffset(Offset = "0x18")]
			public UserData User;

			// Token: 0x0400108C RID: 4236
			[Token(Token = "0x400108C")]
			[FieldOffset(Offset = "0x1C")]
			public IList<uint> OptionIds;

			// Token: 0x0400108D RID: 4237
			[Token(Token = "0x400108D")]
			[FieldOffset(Offset = "0x20")]
			public string Title;

			// Token: 0x0400108E RID: 4238
			[Token(Token = "0x400108E")]
			[FieldOffset(Offset = "0x24")]
			public string Description;

			// Token: 0x0400108F RID: 4239
			[Token(Token = "0x400108F")]
			[FieldOffset(Offset = "0x28")]
			public IGame Game;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OptionBoughtView ---
		void Gameplay_SpecialOffers_View_OptionsOfferWindow__get_OptionBoughtView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58614 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__OnShow__
		              );
		    DAT_ram_00a58614 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__OnShow__
		              );
		  Gameplay_SpecialOffers_View_OptionsOfferWindow__Init(param1,param1);
		  uVar2 = *(undefined4 *)(param1 + 0x44);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		                      );
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,*(undefined4 *)(iVar1 + 0x20),0);
		  uVar2 = *(undefined4 *)(param1 + 0x48);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_OptionsOfferWindow_OptionsOfferWindowArgs__get_WindowArgs__
		                      );
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,*(undefined4 *)(iVar1 + 0x24),0);
		  return;
		}
		*/

}
