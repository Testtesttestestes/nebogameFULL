using System;
using Gameplay.TradeAndCraft.Controller;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.TradeAndCraft.View
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	public class CraftOptionsWindow : ClosableBaseWindow<CraftOptionsWindow.CraftWindowArgs>
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004D9")]
		public override string WindowId
		{
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x6D41", Offset = "0x6D41", VA = "0x6D41", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DA")]
		public Button CraftButton
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x6D42", Offset = "0x6D42", VA = "0x6D42")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DB")]
		public Button ManufactureButton
		{
			[Token(Token = "0x6001BC4")]
			[Address(RVA = "0x6D43", Offset = "0x6D43", VA = "0x6D43")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004DC")]
		public Button AccountsButton
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x6D44", Offset = "0x6D44", VA = "0x6D44")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x6D45", Offset = "0x6D45", VA = "0x6D45")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_TradeAndCraft_View_CraftOptionsWindow__OnDestroy
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a584c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_CraftOptionsWindow_CraftWindowArgs__OnShow__);
		    DAT_ram_00a584c0 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CraftOptionsWindow_CraftWindowArgs__OnShow__);
		  Gameplay_TradeAndCraft_View_CraftOptionsWindow__OnShow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x6D46", Offset = "0x6D46", VA = "0x6D46", Slot = "22")]
		protected override void OnShow(CraftOptionsWindow.CraftWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_TradeAndCraft_View_CraftOptionsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a584c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TradeAndCraft_Controller_TradeAndCraftController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TradeAndCraft_Events_TradeAndCraftEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TradeAndCraft_Model_TradeAndCraftModel_TypeInfo);
		    DAT_ram_00a584c1 = '\x01';
		  }
		  if (*(char *)(param1 + 0x58) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80ef811e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ef811e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    uVar4 = unnamed_function_1417(Gameplay_TradeAndCraft_Model_TradeAndCraftModel_TypeInfo);
		    Gameplay_TradeAndCraft_View_TradeOptionsWindow_TradeOptionsWindowArgs___ctor(uVar4,uVar3,uVar3);
		    *(undefined4 *)(param1 + 0x48) = uVar4;
		    uVar3 = unnamed_function_1417(Gameplay_TradeAndCraft_Events_TradeAndCraftEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x4c) = uVar3;
		    uVar7 = *(undefined4 *)(param1 + 0x48);
		    uVar4 = unnamed_function_1417
		                      (Gameplay_TradeAndCraft_Controller_TradeAndCraftController_TypeInfo);
		    if (DAT_ram_00a584d2 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_TradeAndCraftModel__TradeAndCraftEvents___ctor__);
		      DAT_ram_00a584d2 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (uVar4,uVar7,uVar3,
		               Method_MVC_AbstractController_TradeAndCraftModel__TradeAndCraftEvents___ctor__);
		    *(undefined4 *)(param1 + 0x50) = uVar4;
		    uVar3 = *(undefined4 *)(param1 + 0x48);
		    uVar7 = *(undefined4 *)(param1 + 0x4c);
		    piVar5 = (int *)unnamed_function_1417
		                              (Gameplay_TradeAndCraft_Controller_CraftOptionsViewMediator_TypeInfo);
		    if (DAT_ram_00a584cd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__CraftOptionsWindow___ctor__
		                );
		      DAT_ram_00a584cd = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar5,uVar3,uVar7,uVar4,
		               Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__CraftOptionsWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		              (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		    *(int **)(param1 + 0x54) = piVar5;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x50),0);
		    *(undefined1 *)(param1 + 0x58) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x6D47", Offset = "0x6D47", VA = "0x6D47")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x6D48", Offset = "0x6D48", VA = "0x6D48")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_TradeAndCraft_View_CraftOptionsWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_CraftOptionsWindow_CraftWindowArgs___ctor__);
		    DAT_ram_00a584c2 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_CraftOptionsWindow_CraftWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x6D49", Offset = "0x6D49", VA = "0x6D49")]
		public CraftOptionsWindow()
		{
		}

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/TradeAndCraft/CraftOptionsWindow";

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _craftButton;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _manufactureButton;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _accountsButton;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x48")]
		private TradeAndCraftModel _model;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x4C")]
		private TradeAndCraftEvents _events;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x50")]
		private TradeAndCraftController _controller;

		// Token: 0x04000F03 RID: 3843
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x54")]
		private CraftOptionsViewMediator _mediator;

		// Token: 0x04000F04 RID: 3844
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x58")]
		private bool _mvcSetUp;

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		public class CraftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x6D4A", Offset = "0x6D4A", VA = "0x6D4A")]
			public CraftWindowArgs()
			{
			}
		}
	}
}
