using System;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E20 RID: 3616
	[Token(Token = "0x2000E20")]
	public class AccountLinkerSelectUserViewMediator : AbstractViewMediator<AccountLinkerModel, AccountLinkerEvents, AccountLinkerController, SelectUserView>
	{
		// Token: 0x0600582A RID: 22570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582A")]
		[Address(RVA = "0xA599", Offset = "0xA599", VA = "0xA599", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a63b8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView___ctor__
		              );
		    DAT_ram_00a63b8e = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582B")]
		[Address(RVA = "0xA59A", Offset = "0xA59A", VA = "0xA59A")]
		public AccountLinkerSelectUserViewMediator(AccountLinkerModel model, AccountLinkerEvents events, AccountLinkerController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a63b8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleSetUserSuccessEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b8f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleSetUserSuccessEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x30) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x30);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleSetUserSuccessEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x30) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x30) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170011F4 RID: 4596
		// (set) Token: 0x0600582C RID: 22572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F4")]
		public override AccountLinkerEvents Events
		{
			[Token(Token = "0x600582C")]
			[Address(RVA = "0xA59B", Offset = "0xA59B", VA = "0xA59B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (set) Token: 0x0600582D RID: 22573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F5")]
		public override SelectUserView View
		{
			[Token(Token = "0x600582D")]
			[Address(RVA = "0xA59C", Offset = "0xA59C", VA = "0xA59C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582E")]
		[Address(RVA = "0xA59D", Offset = "0xA59D", VA = "0xA59D")]
		private void HandleSetUserSuccessEvent()
		{
		/* --- GHIDRA: HandleSetUserSuccessEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__HandleSetUserSuccessEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63b91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView__get_Model__
		              );
		    DAT_ram_00a63b91 = '\x01';
		  }
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x1c) = param2;
		  Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__HandleSetupView(param1,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600582F")]
		[Address(RVA = "0xA59E", Offset = "0xA59E", VA = "0xA59E")]
		private void HandleOnSelectUser(LinkerUser user)
		{
		/* --- GHIDRA: HandleOnSelectUser ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__HandleOnSelectUser
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63b92 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LinkerUser__ToArray__);
		    DAT_ram_00a63b92 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (*(undefined4 *)(param1[2] + 0x18),
		                         Method_System_Collections_Generic_List_LinkerUser__ToArray__);
		  Gameplay_AccountLinker_View_SelectUserView__get_Users(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005830")]
		[Address(RVA = "0xA59F", Offset = "0xA59F", VA = "0xA59F")]
		private void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__HandleSetupView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnCloseConfirmSelectedUserWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_AccountLinker_View_ConfirmSelectedUserWindow_ConfirmSelectedUserWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmSelectedUserWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12549);
		    DAT_ram_00a63b93 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_AccountLinker_View_ConfirmSelectedUserWindow_ConfirmSelectedUserWindowArgs_TypeInfo
		                    );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar2,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(iVar2 + 0x18) = uVar3;
		  iVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12549,iVar2,
		                     Method_UI_Windows_PopupController_Show_ConfirmSelectedUserWindow___);
		  param1[6] = iVar2;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnCloseConfirmSelectedUserWindow__
		             ,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005831 RID: 22577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005831")]
		[Address(RVA = "0xA5A0", Offset = "0xA5A0", VA = "0xA5A0")]
		private void ShowConfirmSelectedUserWindow()
		{
		/* --- GHIDRA: ShowConfirmSelectedUserWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__ShowConfirmSelectedUserWindow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63b94 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnCloseConfirmSelectedUserWindow__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63b94 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnCloseConfirmSelectedUserWindow__
		             ,0);
		  UI_Windows_BaseWindow__add_onClose(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005832 RID: 22578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005832")]
		[Address(RVA = "0xA5A1", Offset = "0xA5A1", VA = "0xA5A1")]
		private void HandleOnCloseConfirmSelectedUserWindow()
		{
		/* --- GHIDRA: HandleOnCloseConfirmSelectedUserWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__HandleOnCloseConfirmSelectedUserWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (iVar1 != 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x18),2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005833")]
		[Address(RVA = "0xA5A2", Offset = "0xA5A2", VA = "0xA5A2")]
		private void CloseConfirmSelectedUserWindow()
		{
		/* --- GHIDRA: CloseConfirmSelectedUserWindow ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__CloseConfirmSelectedUserWindow
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b95 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__Dispose__
		              );
		    DAT_ram_00a63b95 = '\x01';
		  }
		  Gameplay_AccountLinker_Control_AccountLinkerViewMediator__HandleOnCloseCodeDisplayWindow
		            (param1,param1);
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x20),0);
		  if (iVar1 != 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew
		              (*(undefined4 *)(param1 + 0x20),2,0);
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__AccountLinkerView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0x18")]
		private ConfirmSelectedUserWindow _confirmSelectedUserWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b90 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnSelectUser__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_LinkerUser__TypeInfo);
		    DAT_ram_00a63b90 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_LinkerUser__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnSelectUser__
		               ,0);
		    Gameplay_AccountLinker_View_SelectUserView__add_OnSelect(uVar1,uVar3,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_LinkerUser__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_Control_AccountLinkerSelectUserViewMediator_HandleOnSelectUser__
		               ,0);
		    Gameplay_AccountLinker_View_SelectUserView__HandleUsersChanged(uVar1,uVar3,0);
		    if (DAT_ram_00a63b92 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__SelectUserView__get_Model__
		                );
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LinkerUser__ToArray__);
		      DAT_ram_00a63b92 = '\x01';
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (*(undefined4 *)(param1[2] + 0x18),
		                       Method_System_Collections_Generic_List_LinkerUser__ToArray__);
		    Gameplay_AccountLinker_View_SelectUserView__get_Users(uVar1,uVar3,0);
		  }
		  return;
		}
		*/

}
