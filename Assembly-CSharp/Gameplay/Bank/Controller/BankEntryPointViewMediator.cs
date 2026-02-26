using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C62 RID: 3170
	[Token(Token = "0x2000C62")]
	public class BankEntryPointViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, UserInterfaceView>
	{
		// Token: 0x06004D72 RID: 19826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x9BAA", Offset = "0x9BAA", VA = "0x9BAA")]
		public BankEntryPointViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a597e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__UserInterfaceView__set_View__
		              );
		    DAT_ram_00a597e8 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a597ea == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_BankButtonOnClickEvent__
		                );
		      DAT_ram_00a597ea = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x14) + 0x1c);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_BankButtonOnClickEvent__,0
		              );
		    UI_IndexButtonBasic__add_ClickEvent(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Bank_Controller_BankEntryPointViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FAD RID: 4013
		// (set) Token: 0x06004D73 RID: 19827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAD")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6004D73")]
			[Address(RVA = "0x9BAB", Offset = "0x9BAB", VA = "0x9BAB", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (set) Token: 0x06004D74 RID: 19828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAE")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D74")]
			[Address(RVA = "0x9BAC", Offset = "0x9BAC", VA = "0x9BAC", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D75")]
		[Address(RVA = "0x9BAD", Offset = "0x9BAD", VA = "0x9BAD")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a597eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_BankButtonOnClickEvent__)
		    ;
		    DAT_ram_00a597eb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_BankButtonOnClickEvent__,0);
		  UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1[2] + 0x2c);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar2,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x1c) + 0x14),uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D76")]
		[Address(RVA = "0x9BAE", Offset = "0x9BAE", VA = "0x9BAE")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_Collections_Generic_Dictionary_int__object___get_Count
		              (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x1c) + 0x14),param2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x9BAF", Offset = "0x9BAF", VA = "0x9BAF")]
		private void HandleNotificationCountChangedEvent(int value)
		{
		/* --- GHIDRA: HandleNotificationCountChangedEvent ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator__HandleNotificationCountChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a597ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__UserInterfaceView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a597ec = '\x01';
		  }
		  piVar3 = *(int **)(param1[2] + 0x1c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81071d9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81071d9e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Core_Gameplay_Managers_BankManager__Deinit(param1_00,0,0,0);
		  piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		  if (*(int *)(iVar4 + 0x2c) != 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		    *(undefined4 *)(iVar4 + 0x2c) = 0;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x110) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0x114));
		    iVar4 = *(int *)(iVar4 + 0x2c);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),0,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x9BB0", Offset = "0x9BB0", VA = "0x9BB0")]
		private void BankButtonOnClickEvent(IndexButtonBasic btn)
		{
		/* --- GHIDRA: BankButtonOnClickEvent ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator__BankButtonOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a597ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView___ctor__
		              );
		    DAT_ram_00a597ed = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param5;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a597e9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__UserInterfaceView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_HandleNotificationCountChangedEvent__
		              );
		    DAT_ram_00a597e9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_HandleNotificationCountChangedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x2c) = iVar4;
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x2c);
		    uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_HandleNotificationCountChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_int__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x2c) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_int__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x2c) = iVar4;
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_BankEntryPointViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a597ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_BankButtonOnClickEvent__)
		    ;
		    DAT_ram_00a597ea = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Bank_Controller_BankEntryPointViewMediator_BankButtonOnClickEvent__,0);
		  UI_IndexButtonBasic__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
