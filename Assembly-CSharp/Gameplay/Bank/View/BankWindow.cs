using System;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C49 RID: 3145
	[Token(Token = "0x2000C49")]
	public class BankWindow : ClosableBaseWindow<BankWindow.BankWindowArgs>
	{
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F75")]
		public override string WindowId
		{
			[Token(Token = "0x6004CB3")]
			[Address(RVA = "0x9AF4", Offset = "0x9AF4", VA = "0x9AF4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F76")]
		public BankOptionsListView BankOptionsListView
		{
			[Token(Token = "0x6004CB4")]
			[Address(RVA = "0x9AF5", Offset = "0x9AF5", VA = "0x9AF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F77")]
		public TabBar TabBar
		{
			[Token(Token = "0x6004CB5")]
			[Address(RVA = "0x9AF6", Offset = "0x9AF6", VA = "0x9AF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0x9AF7", Offset = "0x9AF7", VA = "0x9AF7", Slot = "22")]
		protected override void OnShow(BankWindow.BankWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Bank_View_BankWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x44),0,*(undefined4 *)(iVar1 + 0x164));
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x9AF8", Offset = "0x9AF8", VA = "0x9AF8", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Bank_View_BankWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BankWindow_BankWindowArgs___ctor__);
		    DAT_ram_00a597a7 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BankWindow_BankWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x9AF9", Offset = "0x9AF9", VA = "0x9AF9")]
		public BankWindow()
		{
		}

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankWindow";

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BankOptionsListView _bankOptionsListView;

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x44")]
		private BankViewMediator _mediator;

		// Token: 0x02000C4A RID: 3146
		[Token(Token = "0x2000C4A")]
		public class BankWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004CB9 RID: 19641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CB9")]
			[Address(RVA = "0x9AFA", Offset = "0x9AFA", VA = "0x9AFA")]
			public BankWindowArgs()
			{
			}

			// Token: 0x06004CBA RID: 19642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CBA")]
			[Address(RVA = "0x9AFB", Offset = "0x9AFB", VA = "0x9AFB")]
			public BankWindowArgs(OptionTypesDic.Types.OptionType optionType)
			{
			}

			// Token: 0x040029E5 RID: 10725
			[Token(Token = "0x40029E5")]
			[FieldOffset(Offset = "0x18")]
			public readonly OptionTypesDic.Types.OptionType OptionType;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TabBar ---
		void Gameplay_Bank_View_BankWindow__get_TabBar(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a597a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BankWindow_BankWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a597a6 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_BankWindow_BankWindowArgs__OnShow__);
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
		        goto code_r0x81069856;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81069856:
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
		        goto code_r0x81069905;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81069905:
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
		        goto code_r0x810699b4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x810699b4:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x24);
		  piVar3 = (int *)unnamed_function_1417(Gameplay_Bank_Controller_BankViewMediator_TypeInfo);
		  if (DAT_ram_00a59805 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow___ctor__
		              );
		    DAT_ram_00a59805 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow___ctor__
		            );
		  *(int **)(param1 + 0x44) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

}
