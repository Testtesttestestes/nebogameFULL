using System;
using AssetContent;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C6D RID: 3181
	[Token(Token = "0x2000C6D")]
	public class PaymentBonusViewMediator : AbstractViewMediator<PaymentBonusModel, PaymentBonusEvents, PaymentBonusController, PaymentBonusView>
	{
		// Token: 0x06004DC1 RID: 19905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC1")]
		[Address(RVA = "0x9BF9", Offset = "0x9BF9", VA = "0x9BF9")]
		public PaymentBonusViewMediator(PaymentBonusModel model, PaymentBonusEvents events, PaymentBonusController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_PaymentBonusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5981f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_PaymentBonusViewMediator_PaymentBonusChangedEvent__)
		    ;
		    DAT_ram_00a5981f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_PaymentBonusViewMediator_PaymentBonusChangedEvent__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_PaymentBonusViewMediator_PaymentBonusChangedEvent__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x17000FBF RID: 4031
		// (set) Token: 0x06004DC2 RID: 19906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FBF")]
		public override PaymentBonusEvents Events
		{
			[Token(Token = "0x6004DC2")]
			[Address(RVA = "0x9BFA", Offset = "0x9BFA", VA = "0x9BFA", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x9BFB", Offset = "0x9BFB", VA = "0x9BFB")]
		private void PaymentBonusChangedEvent()
		{
		/* --- GHIDRA: PaymentBonusChangedEvent ---
		void Gameplay_Bank_Controller_PaymentBonusViewMediator__PaymentBonusChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59821 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimatedButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_PaymentBonusViewMediator_HandleChestClicked__);
		    DAT_ram_00a59821 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_GameAnimatedButton__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Bank_Controller_PaymentBonusViewMediator_HandleChestClicked__,0);
		    func_ii_7668(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_GameAnimatedButton__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Bank_Controller_PaymentBonusViewMediator_HandleChestClicked__,0);
		    Gameplay_AccountLinker_Control_SigninTracker__Dispose(uVar3,uVar1,0);
		    Gameplay_Bank_Controller_PaymentBonusViewMediator__set_Events(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FC0 RID: 4032
		// (set) Token: 0x06004DC4 RID: 19908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FC0")]
		public override PaymentBonusView View
		{
			[Token(Token = "0x6004DC4")]
			[Address(RVA = "0x9BFC", Offset = "0x9BFC", VA = "0x9BFC", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC5")]
		[Address(RVA = "0x9BFD", Offset = "0x9BFD", VA = "0x9BFD")]
		private void HandleChestClicked(GameAnimatedButton button)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_PaymentBonusViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  float fVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59820 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView__get_Model__
		              );
		    DAT_ram_00a59820 = '\x01';
		  }
		  if ((*(int *)(param1[2] + 0x10) == 0) ||
		     (fVar1 = func_ii_7103(*(undefined4 *)(param1[2] + 0xc),0), fVar1 <= 0.0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    AssetContent_GameAnimatedButton__get_AssetId(*(undefined4 *)(iVar2 + 0x10),0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = 0;
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x10);
		    uVar3 = Core_Extensions_Dict_PartyInfoDicExt__GetTitle(*(undefined4 *)(param1[2] + 0x10),0);
		    AssetContent_GameAnimatedButton__get_AssetId(param1_00,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(param1[2] + 0xc);
		  }
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(iVar2 + 0x14),uVar3,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_PaymentBonusViewMediator__set_View
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a59822 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__PaymentBonusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59822 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x10) + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x81075ece;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81075ece:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_BankManager__Deinit(param1_00,param2_00,6,0);
		  return;
		}
		*/

}
