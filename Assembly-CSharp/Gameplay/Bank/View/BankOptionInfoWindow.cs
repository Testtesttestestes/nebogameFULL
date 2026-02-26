using System;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C39 RID: 3129
	[Token(Token = "0x2000C39")]
	public class BankOptionInfoWindow : ClosableBaseWindow<BankOptionInfoWindowArgs>
	{
		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F5F")]
		public override string WindowId
		{
			[Token(Token = "0x6004C46")]
			[Address(RVA = "0x9A89", Offset = "0x9A89", VA = "0x9A89", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F60")]
		public TextMeshProUGUI BottomDescription
		{
			[Token(Token = "0x6004C47")]
			[Address(RVA = "0x9A8A", Offset = "0x9A8A", VA = "0x9A8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F61")]
		public BankOptionView BankOptionView
		{
			[Token(Token = "0x6004C48")]
			[Address(RVA = "0x9A8B", Offset = "0x9A8B", VA = "0x9A8B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06004C49 RID: 19529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F62")]
		public Button PrevButton
		{
			[Token(Token = "0x6004C49")]
			[Address(RVA = "0x9A8C", Offset = "0x9A8C", VA = "0x9A8C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F63")]
		public Button NextButton
		{
			[Token(Token = "0x6004C4A")]
			[Address(RVA = "0x9A8D", Offset = "0x9A8D", VA = "0x9A8D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06004C4B RID: 19531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F64")]
		public BankOptionArtikulContainerView ArtikulContainerView
		{
			[Token(Token = "0x6004C4B")]
			[Address(RVA = "0x9A8E", Offset = "0x9A8E", VA = "0x9A8E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x9A8F", Offset = "0x9A8F", VA = "0x9A8F", Slot = "22")]
		protected override void OnShow(BankOptionInfoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Bank_View_BankOptionInfoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5976b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BankOptionInfoWindowArgs__OnClose__);
		    DAT_ram_00a5976b = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_BankOptionInfoWindowArgs__OnClose__);
		  iVar1 = **(int **)(param1 + 0x50);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x50) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x9A90", Offset = "0x9A90", VA = "0x9A90", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Bank_View_BankOptionInfoWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5976c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BankOptionInfoWindowArgs___ctor__);
		    DAT_ram_00a5976c = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BankOptionInfoWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x9A91", Offset = "0x9A91", VA = "0x9A91")]
		public BankOptionInfoWindow()
		{
		}

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankOptionInfoWindow";

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BankOptionArtikulContainerView _artikulContainerView;

		// Token: 0x0400299A RID: 10650
		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x0400299B RID: 10651
		[Token(Token = "0x400299B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x0400299C RID: 10652
		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BankOptionView _bankOptionView;

		// Token: 0x0400299D RID: 10653
		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _bottomDescription;

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x50")]
		private BankOptionInfoWindowMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ArtikulContainerView ---
		void Gameplay_Bank_View_BankOptionInfoWindow__get_ArtikulContainerView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5976a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankOptionInfoWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BankOptionInfoWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5976a = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_BankOptionInfoWindowArgs__OnShow__
		              );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x810642a6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x810642a6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar4 + 0x2c);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81064355;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81064355:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3_00 = *(undefined4 *)(iVar4 + 0x28);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81064404;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81064404:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x24);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Bank_Controller_BankOptionInfoWindowMediator_TypeInfo);
		  if (DAT_ram_00a597f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankOptionInfoWindow___ctor__
		              );
		    DAT_ram_00a597f3 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankOptionInfoWindow___ctor__
		            );
		  *(int **)(param1 + 0x50) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

}
