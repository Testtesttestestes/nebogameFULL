using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.UserInterface.Menu.Settings.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInterface.Menu.Settings.View
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class SettingsWindow : ClosableBaseWindow<SettingsWindow.SettingsWindowArgs>
	{
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000400")]
		public override string WindowId
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x68E2", Offset = "0x68E2", VA = "0x68E2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x68E3", Offset = "0x68E3", VA = "0x68E3", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_UserInterface_Menu_Settings_View_SettingsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59887 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_SettingsWindow_SettingsWindowArgs__OnClose__);
		    DAT_ram_00a59887 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_SettingsWindow_SettingsWindowArgs__OnClose__);
		  piVar1 = *(int **)(*(int *)(param1 + 0x40) + 8);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))(piVar1,*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x40);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar2 + 0x14c));
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  iVar2 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar2 + 0x134));
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x68E4", Offset = "0x68E4", VA = "0x68E4", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_UserInterface_Menu_Settings_View_SettingsWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59888 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_SettingsWindow_SettingsWindowArgs___ctor__);
		    DAT_ram_00a59888 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_SettingsWindow_SettingsWindowArgs___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x68E5", Offset = "0x68E5", VA = "0x68E5")]
		public SettingsWindow()
		{
		}

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SettingsWindow";

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SettingsView _settingsView;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[FieldOffset(Offset = "0x40")]
		private SettingsViewMediator _mediator;

		// Token: 0x020003DD RID: 989
		[Token(Token = "0x20003DD")]
		public class SettingsWindowArgs : BaseWindowArgs
		{
			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06001727 RID: 5927 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000401")]
			public UserData User
			{
				[Token(Token = "0x6001727")]
				[Address(RVA = "0x68E6", Offset = "0x68E6", VA = "0x68E6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06001728 RID: 5928 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000402")]
			public IGame Game
			{
				[Token(Token = "0x6001728")]
				[Address(RVA = "0x68E7", Offset = "0x68E7", VA = "0x68E7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001729 RID: 5929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x68E8", Offset = "0x68E8", VA = "0x68E8")]
			public SettingsWindowArgs(IGame game, UserData user)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_UserInterface_Menu_Settings_View_SettingsWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param3_00;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59886 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_SettingsWindow_SettingsWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_SettingsWindow_SettingsWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_Settings_Control_SettingsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Menu_Settings_SettingsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInterface_Menu_Settings_Model_SettingsModel_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_TypeInfo);
		    DAT_ram_00a59886 = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,Method_UI_Windows_BaseWindow_SettingsWindow_SettingsWindowArgs__OnShow__)
		  ;
		  param3_00 = unnamed_function_1417(Gameplay_UserInterface_Menu_Settings_SettingsEvents_TypeInfo);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SettingsWindow_SettingsWindowArgs__get_WindowArgs__
		                      );
		  piVar4 = *(int **)(iVar2 + 0x1c);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SettingsWindow_SettingsWindowArgs__get_WindowArgs__
		                      );
		  uVar5 = *(undefined4 *)(iVar2 + 0x18);
		  iVar2 = unnamed_function_1417(Gameplay_UserInterface_Menu_Settings_Model_SettingsModel_TypeInfo);
		  if (DAT_ram_00a59889 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59889 = '\x01';
		  }
		  uVar1 = 0;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar2,uVar5,0);
		  *(int **)(iVar2 + 0xc) = piVar4;
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x148);
		        goto code_r0x8107ea31;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x8107ea31:
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(iVar2 + 0x10) = uVar5;
		  uVar5 = unnamed_function_1417
		                    (Gameplay_UserInterface_Menu_Settings_Control_SettingsController_TypeInfo);
		  if (DAT_ram_00a5988a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_SettingsModel__SettingsEvents___ctor__);
		    DAT_ram_00a5988a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (uVar5,iVar2,param3_00,
		             Method_MVC_AbstractController_SettingsModel__SettingsEvents___ctor__);
		  piVar4 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator_TypeInfo
		                            );
		  Gameplay_UserInterface_Menu_Settings_Control_SettingsViewMediator__Dispose
		            (piVar4,iVar2,param3_00,uVar5,piVar4);
		  *(int **)(param1 + 0x40) = piVar4;
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x160) * 4))
		            (piVar4,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(*piVar4 + 0x164));
		  return;
		}
		*/

}
