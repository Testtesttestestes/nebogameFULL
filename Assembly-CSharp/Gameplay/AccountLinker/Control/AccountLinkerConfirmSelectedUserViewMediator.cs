using System;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E18 RID: 3608
	[Token(Token = "0x2000E18")]
	public class AccountLinkerConfirmSelectedUserViewMediator : AbstractViewMediator<AccountLinkerModel, AccountLinkerEvents, AccountLinkerController, ConfirmSelectedUserView>
	{
		// Token: 0x060057F4 RID: 22516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F4")]
		[Address(RVA = "0xA566", Offset = "0xA566", VA = "0xA566")]
		public AccountLinkerConfirmSelectedUserViewMediator(AccountLinkerModel model, AccountLinkerEvents events, AccountLinkerController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__ConfirmSelectedUserView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator_HandleOnSelectEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_LinkerUser__TypeInfo);
		    DAT_ram_00a63b66 = '\x01';
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
		               Method_Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator_HandleOnSelectEvent__
		               ,0);
		    Gameplay_AccountLinker_View_ConfirmSelectedUserView__add_OnSelectEvent(uVar1,uVar3,0);
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
		               Method_Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator_HandleOnSelectEvent__
		               ,0);
		    Gameplay_AccountLinker_View_CodeDisplayViewWindow_CodeDisplayWindowArgs___ctor(uVar1,uVar3,0);
		    if (DAT_ram_00a63b67 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__ConfirmSelectedUserView__get_Model__
		                );
		      DAT_ram_00a63b67 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_AccountLinker_View_AccountLinkerUserView__get_User
		              (*(undefined4 *)(iVar2 + 0x10),*(undefined4 *)(param1[2] + 0x1c),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170011F2 RID: 4594
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F2")]
		public override ConfirmSelectedUserView View
		{
			[Token(Token = "0x60057F5")]
			[Address(RVA = "0xA567", Offset = "0xA567", VA = "0xA567", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0xA568", Offset = "0xA568", VA = "0xA568")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_AccountLinker_Control_AccountLinkerController__StartRegisterProcess
		            (param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F7")]
		[Address(RVA = "0xA569", Offset = "0xA569", VA = "0xA569")]
		private void HandleOnSelectEvent(LinkerUser user)
		{
		/* --- GHIDRA: HandleOnSelectEvent ---
		void Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator__HandleOnSelectEvent
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63b68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AccountLinkerModel__AccountLinkerEvents__Dispose__);
		    DAT_ram_00a63b68 = '\x01';
		  }
		  Gameplay_AccountLinker_Control_SigninTracker__Unsubscribe(*(undefined4 *)(param1 + 0x1c),param1);
		  if (*(int *)(param1 + 0x20) != 0) {
		    Gameplay_AccountLinker_Control_AccountLinkerController__get_SiteHelper(param1,param1);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_AccountLinkerModel__AccountLinkerEvents__Dispose__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_AccountLinker_Control_AccountLinkerConfirmSelectedUserViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63b67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountLinkerModel__AccountLinkerEvents__AccountLinkerController__ConfirmSelectedUserView__get_Model__
		              );
		    DAT_ram_00a63b67 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_AccountLinker_View_AccountLinkerUserView__get_User
		            (*(undefined4 *)(iVar1 + 0x10),*(undefined4 *)(param1[2] + 0x1c),0);
		  return;
		}
		*/

}
