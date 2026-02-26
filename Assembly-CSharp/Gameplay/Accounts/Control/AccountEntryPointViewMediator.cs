using System;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE3 RID: 3555
	[Token(Token = "0x2000DE3")]
	public class AccountEntryPointViewMediator : AbstractViewMediator<AccountsModel, AccountsEvents, AccountsController, AccountsButtonView>
	{
		// Token: 0x060056C2 RID: 22210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C2")]
		[Address(RVA = "0xA441", Offset = "0xA441", VA = "0xA441")]
		public AccountEntryPointViewMediator(AccountsModel model, AccountsEvents events, AccountsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a588c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsButtonView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_EpNotificationsOnNotificationsCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a588c5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_EpNotificationsOnNotificationsCountChangedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_int__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_EpNotificationsOnNotificationsCountChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x20) = iVar4;
		    uVar2 = System_Action_int__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170011B6 RID: 4534
		// (set) Token: 0x060056C3 RID: 22211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011B6")]
		public override AccountsEvents Events
		{
			[Token(Token = "0x60056C3")]
			[Address(RVA = "0xA442", Offset = "0xA442", VA = "0xA442", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (set) Token: 0x060056C4 RID: 22212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011B7")]
		public override AccountsButtonView View
		{
			[Token(Token = "0x60056C4")]
			[Address(RVA = "0xA443", Offset = "0xA443", VA = "0xA443", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C5")]
		[Address(RVA = "0xA444", Offset = "0xA444", VA = "0xA444")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a588c8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    DAT_ram_00a588c8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__,0);
		  UI_IndexButtonBasic__get_CanvasGroup(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C6")]
		[Address(RVA = "0xA445", Offset = "0xA445", VA = "0xA445")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C7")]
		[Address(RVA = "0xA446", Offset = "0xA446", VA = "0xA446")]
		private void EpNotificationsOnNotificationsCountChangedEvent(int value)
		{
		/* --- GHIDRA: EpNotificationsOnNotificationsCountChangedEvent ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator__EpNotificationsOnNotificationsCountChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a588c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a588c9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1b0);
		        goto code_r0x80f3cf78;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80f3cf78:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowDiscountsWindow
		            (param1_00,0);
		  piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		  if (*(int *)(iVar5 + 0x38) != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		    *(undefined4 *)(iVar5 + 0x38) = 0;
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x114));
		    iVar5 = *(int *)(iVar5 + 0x20);
		    if (iVar5 != 0) {
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                        (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar3 + 0x38),
		                 *(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C8")]
		[Address(RVA = "0xA447", Offset = "0xA447", VA = "0xA447")]
		private void HandleClickEvent(IndexButtonBasic btn)
		{
		/* --- GHIDRA: HandleClickEvent ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator__HandleClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a588ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__DefaultAccountView__Dispose__
		              );
		    DAT_ram_00a588ca = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (*(char *)(iVar1 + 10) == '\0') {
		    piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    *(undefined4 *)(iVar1 + 0x1c) = 0;
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__DefaultAccountView__Dispose__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a588c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsButtonView__set_View__
		              );
		    DAT_ram_00a588c6 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a588c7 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__)
		      ;
		      Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		      DAT_ram_00a588c7 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__,0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a588c8 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__)
		      ;
		      Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		      DAT_ram_00a588c8 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Accounts_Control_AccountEntryPointViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a588c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    DAT_ram_00a588c7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Accounts_Control_AccountEntryPointViewMediator_HandleClickEvent__,0);
		  UI_IndexButtonBasic__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
