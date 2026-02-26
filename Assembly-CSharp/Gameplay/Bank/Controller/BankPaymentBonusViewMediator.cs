using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C66 RID: 3174
	[Token(Token = "0x2000C66")]
	public class BankPaymentBonusViewMediator : AbstractViewMediator<PaymentBonusModel, PaymentBonusEvents, PaymentBonusController, BankPaymentBonusView>
	{
		// Token: 0x06004D8E RID: 19854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x9BC6", Offset = "0x9BC6", VA = "0x9BC6")]
		public BankPaymentBonusViewMediator(PaymentBonusModel model, PaymentBonusEvents events, PaymentBonusController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankPaymentBonusViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a597fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankPaymentBonusViewMediator_PaymentBonusChangedEvent__
		              );
		    DAT_ram_00a597fd = '\x01';
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
		               Method_Gameplay_Bank_Controller_BankPaymentBonusViewMediator_PaymentBonusChangedEvent__
		               ,0);
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
		               Method_Gameplay_Bank_Controller_BankPaymentBonusViewMediator_PaymentBonusChangedEvent__
		               ,0);
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

		// Token: 0x17000FB5 RID: 4021
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB5")]
		public override PaymentBonusEvents Events
		{
			[Token(Token = "0x6004D8F")]
			[Address(RVA = "0x9BC7", Offset = "0x9BC7", VA = "0x9BC7", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D90")]
		[Address(RVA = "0x9BC8", Offset = "0x9BC8", VA = "0x9BC8")]
		private void PaymentBonusChangedEvent()
		{
		/* --- GHIDRA: PaymentBonusChangedEvent ---
		void Gameplay_Bank_Controller_BankPaymentBonusViewMediator__PaymentBonusChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a597fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView__set_View__
		              );
		    DAT_ram_00a597fe = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Bank_Controller_BankPaymentBonusViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FB6 RID: 4022
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB6")]
		public override BankPaymentBonusView View
		{
			[Token(Token = "0x6004D91")]
			[Address(RVA = "0x9BC9", Offset = "0x9BC9", VA = "0x9BC9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D92")]
		[Address(RVA = "0x9BCA", Offset = "0x9BCA", VA = "0x9BCA")]
		private void DisplayCurrentPaymentBonus()
		{
		/* --- GHIDRA: DisplayCurrentPaymentBonus ---
		void Gameplay_Bank_Controller_BankPaymentBonusViewMediator__DisplayCurrentPaymentBonus
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a59800 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView___ctor__
		              );
		    DAT_ram_00a59800 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_BankPaymentBonusViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Bank_Controller_BankPaymentBonusViewMediator__set_View(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_BankPaymentBonusViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  float fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a597ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a597ff = '\x01';
		  }
		  local_4 = 0;
		  if ((*(int *)(param1[2] + 0x10) != 0) &&
		     (fVar1 = func_ii_7103(*(undefined4 *)(param1[2] + 0xc),0), 0.0 < fVar1)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(iVar2 + 0x18),*(undefined4 *)(param1[2] + 0xc),0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = Core_Extensions_Dict_PaymentBonusesDicExt__GetAnimationAssetId
		                      (*(undefined4 *)(param1[2] + 0x10),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar4,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar4 = *(undefined4 *)(param1[2] + 0x14);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		    UI_Rewards_AbstractRewardsRender__get_Rewards(uVar3,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = **(int **)(iVar2 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0xf0) * 4))
		              (*(int **)(iVar2 + 0x1c),*(undefined4 *)(iVar6 + 0xf4));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar5 = *(int **)(iVar2 + 0x20);
		    uVar3 = Core_Extensions_Dict_PaymentBonusesDicExt__GetToolTipText
		                      (*(undefined4 *)(param1[2] + 0x10),&local_4,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(uVar3,1,0,1,0,0,0,0);
		    uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar3,local_4,0);
		    iVar2 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar5,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  return;
		}
		*/

}
