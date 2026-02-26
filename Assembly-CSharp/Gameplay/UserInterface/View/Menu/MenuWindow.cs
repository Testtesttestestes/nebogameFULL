using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Data;
using Core.Rounting;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInterface.View.Menu
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	public class MenuWindow : ClosableBaseWindow<MenuWindow.MenuWindowArgs>
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003ED")]
		public override string WindowId
		{
			[Token(Token = "0x60016FC")]
			[Address(RVA = "0x68BB", Offset = "0x68BB", VA = "0x68BB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003EE")]
		public MenuView MenuMenuView
		{
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x68BC", Offset = "0x68BC", VA = "0x68BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0x68BD", Offset = "0x68BD", VA = "0x68BD", Slot = "22")]
		protected override void OnShow(MenuWindow.MenuWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_UserInterface_View_Menu_MenuWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59881 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MenuWindow_MenuWindowArgs__OnClose__);
		    DAT_ram_00a59881 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_MenuWindow_MenuWindowArgs__OnClose__);
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0x68BE", Offset = "0x68BE", VA = "0x68BE", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_UserInterface_View_Menu_MenuWindow__OnClose
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (param2 == 1) {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ValidateShowProgressButton
		              (*(undefined4 *)(param1 + 0x40),0);
		    return;
		  }
		  if (param2 == 2) {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowSaveProgress
		              (*(undefined4 *)(param1 + 0x40),0);
		    return;
		  }
		  if (param2 == 3) {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowSettings
		              (*(undefined4 *)(param1 + 0x40),0);
		    return;
		  }
		  if (param2 == 4) {
		    Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator__ShowNotifications
		              (*(undefined4 *)(param1 + 0x40),0);
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  func_ii_20706(uVar1,0);
		  param2_00 = unnamed_function_2232(&Method_Gameplay_UserInterface_View_Menu_MenuWindow_SelectTab__)
		  ;
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001700")]
		[Address(RVA = "0x68BF", Offset = "0x68BF", VA = "0x68BF")]
		public void SelectTab(MenuWindow.MenuWindowArgs.SelectedTab tab, LocatorPayload payload)
		{
		/* --- GHIDRA: SelectTab ---
		void Gameplay_UserInterface_View_Menu_MenuWindow__SelectTab(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59882 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MenuWindow_MenuWindowArgs___ctor__);
		    DAT_ram_00a59882 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_MenuWindow_MenuWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001701")]
		[Address(RVA = "0x68C0", Offset = "0x68C0", VA = "0x68C0")]
		public MenuWindow()
		{
		}

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/MenuWindow";

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MenuView _menuView;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x40")]
		private ProgressSaverEnterPointFromMenuViewMediator _progresSaverMediator;

		// Token: 0x020003D5 RID: 981
		[Token(Token = "0x20003D5")]
		public class MenuWindowArgs : BaseWindowArgs
		{
			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06001702 RID: 5890 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003EF")]
			public UserData User
			{
				[Token(Token = "0x6001702")]
				[Address(RVA = "0x68C1", Offset = "0x68C1", VA = "0x68C1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06001703 RID: 5891 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F0")]
			public IPlatformSigninProvider SiginProdider
			{
				[Token(Token = "0x6001703")]
				[Address(RVA = "0x68C2", Offset = "0x68C2", VA = "0x68C2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06001704 RID: 5892 RVA: 0x00005580 File Offset: 0x00003780
			[Token(Token = "0x170003F1")]
			public MenuWindow.MenuWindowArgs.SelectedTab Selected
			{
				[Token(Token = "0x6001704")]
				[Address(RVA = "0x68C3", Offset = "0x68C3", VA = "0x68C3")]
				[CompilerGenerated]
				get
				{
					return MenuWindow.MenuWindowArgs.SelectedTab.undefined;
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170003F2")]
			public IReadOnlyDictionary<string, string> Payload
			{
				[Token(Token = "0x6001705")]
				[Address(RVA = "0x68C4", Offset = "0x68C4", VA = "0x68C4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001706")]
			[Address(RVA = "0x68C5", Offset = "0x68C5", VA = "0x68C5")]
			public MenuWindowArgs(UserData user, IPlatformSigninProvider siginProdider, MenuWindow.MenuWindowArgs.SelectedTab selectedTab, IReadOnlyDictionary<string, string> payload)
			{
			}

			// Token: 0x020003D6 RID: 982
			[Token(Token = "0x20003D6")]
			public enum SelectedTab
			{
				// Token: 0x04000C3B RID: 3131
				[Token(Token = "0x4000C3B")]
				undefined,
				// Token: 0x04000C3C RID: 3132
				[Token(Token = "0x4000C3C")]
				save_progress,
				// Token: 0x04000C3D RID: 3133
				[Token(Token = "0x4000C3D")]
				menu_settings,
				// Token: 0x04000C3E RID: 3134
				[Token(Token = "0x4000C3E")]
				notifications,
				// Token: 0x04000C3F RID: 3135
				[Token(Token = "0x4000C3F")]
				feedback
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MenuMenuView ---
		void Gameplay_UserInterface_View_Menu_MenuWindow__get_MenuMenuView
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  longlong lVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 param4;
		  undefined4 param6;
		  undefined4 param5;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a59880 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MenuWindow_MenuWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_TypeInfo
		              );
		    DAT_ram_00a59880 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_MenuWindow_MenuWindowArgs__OnShow__);
		  iVar3 = *(int *)(param1 + 0x3c);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param2 + 0x18),0);
		  if (lVar2 != *(longlong *)(iVar3 + 0x48)) {
		    *(longlong *)(iVar3 + 0x48) = lVar2;
		    Gameplay_UserInterface_View_Menu_MenuView__set_UserId(iVar3,iVar3);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0x1a8);
		        goto code_r0x8107e422;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8107e422:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  iVar5 = **(int **)(iVar3 + 0x18);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (*(int **)(iVar3 + 0x18),*(undefined4 *)(iVar5 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0x1a8);
		        goto code_r0x8107e4e7;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8107e4e7:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  iVar5 = **(int **)(iVar3 + 0x18);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                        (*(int **)(iVar3 + 0x18),*(undefined4 *)(iVar5 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0x1a8);
		        goto code_r0x8107e5ac;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1d);
		code_r0x8107e5ac:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  param4 = *(undefined4 *)(iVar3 + 0x18);
		  param6 = *(undefined4 *)(param2 + 0x24);
		  param5 = *(undefined4 *)(param2 + 0x20);
		  piVar4 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverEnterPointFromMenuViewMediator_TypeInfo
		                            );
		  Gameplay_AccountLinker_ProgressSaver_Controller_ProgressSaverController___c__DisplayClass14_0___HandleInvalidNickErrorEvent_b__0
		            (piVar4,param2_00,param3_00,param4,param5,param6,0);
		  *(int **)(param1 + 0x40) = piVar4;
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x160) * 4))
		            (piVar4,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar4 + 0x164));
		  return;
		}
		*/

}
