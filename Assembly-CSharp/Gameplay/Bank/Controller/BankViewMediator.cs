using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C69 RID: 3177
	[Token(Token = "0x2000C69")]
	public class BankViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, BankWindow>
	{
		// Token: 0x06004D98 RID: 19864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x9BD0", Offset = "0x9BD0", VA = "0x9BD0", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Bank_Controller_BankViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a59805 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow___ctor__
		              );
		    DAT_ram_00a59805 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D99")]
		[Address(RVA = "0x9BD1", Offset = "0x9BD1", VA = "0x9BD1")]
		public BankViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Controller_BankViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a59806 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankViewMediator_HandleAvailOptionsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankViewMediator_HandleOptionsRewardsChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankViewMediator_SingleTimeSellOptionPurchaseStatusChangedEvent__
		              );
		    DAT_ram_00a59806 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator_HandleOptionsRewardsChangedEvent__,0
		              );
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator_HandleAvailOptionsChangedEvent__,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator_SingleTimeSellOptionPurchaseStatusChangedEvent__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar5;
		      uVar3 = System_Action_BankOptionData__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator_HandleOptionsRewardsChangedEvent__,0
		              );
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x24);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator_HandleAvailOptionsChangedEvent__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x24) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_BankOptionData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator_SingleTimeSellOptionPurchaseStatusChangedEvent__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar5;
		    uVar3 = System_Action_BankOptionData__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_BankOptionData__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FB9 RID: 4025
		// (set) Token: 0x06004D9A RID: 19866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB9")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D9A")]
			[Address(RVA = "0x9BD2", Offset = "0x9BD2", VA = "0x9BD2", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9B")]
		[Address(RVA = "0x9BD3", Offset = "0x9BD3", VA = "0x9BD3")]
		private void SingleTimeSellOptionPurchaseStatusChangedEvent(BankOptionData bankOptionData)
		{
		/* --- GHIDRA: SingleTimeSellOptionPurchaseStatusChangedEvent ---
		void Gameplay_Bank_Controller_BankViewMediator__SingleTimeSellOptionPurchaseStatusChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Utils_CoroutineSource__StopCoroutine(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0x9BD4", Offset = "0x9BD4", VA = "0x9BD4")]
		private void HandleAvailOptionsChangedEvent()
		{
		/* --- GHIDRA: HandleAvailOptionsChangedEvent ---
		void Gameplay_Bank_Controller_BankViewMediator__HandleAvailOptionsChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint *puVar6;
		  int *piVar7;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a59808 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_BankWindow_BankWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_BankTabData__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		    DAT_ram_00a59808 = '\x01';
		  }
		  iVar5 = param1[7];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *(int *)(iVar3 + 0x3c);
		  if ((char)iVar5 == '\0') {
		    uVar4 = Gameplay_Bank_Controller_BankViewMediator__BankOptionsListViewOnBuyButtonClickedEvent
		                      (param1,0);
		    UI_Tabs_TabBar__HandleSelected(iVar3,uVar4,0);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_01 = *(int **)(*(int *)(iVar5 + 0x3c) + 0x40);
		code_r0x81073e71:
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_TabBarItemData__TypeInfo == *piVar7) {
		          puVar6 = (uint *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81073edc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(param1_01,
		                                  System_Collections_Generic_ICollection_TabBarItemData__TypeInfo,0)
		    ;
		code_r0x81073edc:
		    iVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param1_01,puVar6[1]);
		    if (iVar2 < iVar5) {
		      iVar5 = *param1_01;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_TabBarItemData__TypeInfo == *piVar7) {
		            puVar6 = (uint *)(iVar5 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x81073f5b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param1_01,
		                                    System_Collections_Generic_IList_TabBarItemData__TypeInfo,0);
		code_r0x81073f5b:
		      piVar7 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param1_01,iVar2,puVar6[1]);
		      if (piVar7 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar7 + 0xb8) <
		             (uint)*(byte *)(UI_Tabs_TabBarItemData_BankTabData__TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar7 + 100) +
		                     (uint)*(byte *)(UI_Tabs_TabBarItemData_BankTabData__TypeInfo + 0xb8) * 4 + -4)
		            != UI_Tabs_TabBarItemData_BankTabData__TypeInfo)) {
		          System_Activator__CreateInstance(piVar7,UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      iVar3 = *(int *)(piVar7[8] + 8);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar5 = func_ii_8093(uVar4,
		                           Method_UI_Windows_BaseWindow_BankWindow_BankWindowArgs__get_WindowArgs__)
		      ;
		      if (iVar3 == *(int *)(iVar5 + 0x18)) goto code_r0x81073fe1;
		      iVar2 = iVar2 + 1;
		      goto code_r0x81073e71;
		    }
		    iVar2 = 0;
		code_r0x81073fe1:
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar5 + 0x3c),iVar2,0,0);
		    *(undefined1 *)(param1 + 7) = 1;
		  }
		  else {
		    param2_00 = *(undefined4 *)(iVar3 + 0x3c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar4 = Gameplay_Bank_Controller_BankViewMediator__BankOptionsListViewOnBuyButtonClickedEvent
		                      (param1,param2_00);
		    UI_Tabs_TabBar__HandleSelected(param1_00,uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar2 + 0x3c),param2_00,0,0);
		    Gameplay_Bank_Controller_BankViewMediator__TabBarOnChangeEvent(param1,0,param2_00);
		  }
		  if (param1[6] != 0) {
		    func_ii_7950(param1[6],0);
		  }
		  param1[6] = 0;
		  if (DAT_ram_00a5980c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_Controller_BankViewMediator__CheckBackTimersCoroutine_d__14_TypeInfo);
		    DAT_ram_00a5980c = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Bank_Controller_BankViewMediator__CheckBackTimersCoroutine_d__14_TypeInfo
		                    );
		  *(int **)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  iVar2 = Utils_CoroutineSource__GetMono(iVar2,0);
		  param1[6] = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x9BD5", Offset = "0x9BD5", VA = "0x9BD5")]
		private void HandleOptionsRewardsChangedEvent()
		{
		/* --- GHIDRA: HandleOptionsRewardsChangedEvent ---
		void Gameplay_Bank_Controller_BankViewMediator__HandleOptionsRewardsChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_01 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x3c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		  param2_00 = Gameplay_Bank_Controller_BankViewMediator__BankOptionsListViewOnBuyButtonClickedEvent
		                        (param1,param1);
		  UI_Tabs_TabBar__HandleSelected(param1_00,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x3c),param2_01,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x9BD6", Offset = "0x9BD6", VA = "0x9BD6")]
		private void ReDrawTabs()
		{
		/* --- GHIDRA: ReDrawTabs ---
		void Gameplay_Bank_Controller_BankViewMediator__ReDrawTabs(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59809 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__set_View__
		              );
		    DAT_ram_00a59809 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Bank_Controller_BankViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Bank_Controller_BankViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000FBA RID: 4026
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FBA")]
		public override BankWindow View
		{
			[Token(Token = "0x6004D9F")]
			[Address(RVA = "0x9BD7", Offset = "0x9BD7", VA = "0x9BD7", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA0")]
		[Address(RVA = "0x9BD8", Offset = "0x9BD8", VA = "0x9BD8")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Bank_Controller_BankViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  int *param1_00;
		  int iVar9;
		  
		  if (DAT_ram_00a5980b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankViewMediator_TabBarOnChangeEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5980b = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar8 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,Method_Gameplay_Bank_Controller_BankViewMediator_TabBarOnChangeEvent__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar8,uVar5,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *(int *)(iVar4 + 0x40);
		  uVar5 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		             ,0);
		  if (DAT_ram_00a59783 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59783 = '\x01';
		  }
		  iVar9 = *(int *)(iVar4 + 0x30);
		  do {
		    iVar3 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar9,uVar5,0);
		    uVar8 = System_Action_IBankOptionView__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar3 = func_ii_1082(iVar6,System_Action_IBankOptionView__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(iVar6,uVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar4 + 0x30,iVar3,iVar9);
		    bVar1 = iVar3 != iVar9;
		    iVar9 = iVar3;
		  } while (bVar1);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *(int *)(iVar4 + 0x40);
		  uVar5 = unnamed_function_1417(System_Action_BankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		             ,0);
		  if (DAT_ram_00a59785 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    DAT_ram_00a59785 = '\x01';
		  }
		  iVar9 = *(int *)(iVar4 + 0x34);
		  do {
		    iVar3 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar9,uVar5,0);
		    uVar8 = System_Action_BankOptionView__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar3 = func_ii_1082(iVar6,System_Action_BankOptionView__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(iVar6,uVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar4 + 0x34,iVar3,iVar9);
		    bVar1 = iVar3 != iVar9;
		    iVar9 = iVar3;
		  } while (bVar1);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *(int *)(iVar4 + 0x40);
		  uVar2 = 0;
		  uVar5 = *(undefined4 *)(param1[2] + 0x18);
		  param1_00 = *(int **)(param1[2] + 0x1c);
		  iVar9 = *param1_00;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0x268);
		        goto code_r0x81074b44;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  puVar7 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x81074b44:
		  iVar9 = (**(code **)((ulonglong)*puVar7 * 4))(param1_00,puVar7[1]);
		  *(undefined4 *)(iVar4 + 0x24) = *(undefined4 *)(iVar9 + 0x14);
		  *(undefined4 *)(iVar4 + 0x20) = uVar5;
		  iVar4 = *param1;
		  uVar5 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar4 + 0x14c));
		  Utils_CoroutineSource__StopCoroutine(uVar5,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA1")]
		[Address(RVA = "0x9BD9", Offset = "0x9BD9", VA = "0x9BD9")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		int Gameplay_Bank_Controller_BankViewMediator__SetupView(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5980c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_Controller_BankViewMediator__CheckBackTimersCoroutine_d__14_TypeInfo);
		    DAT_ram_00a5980c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Bank_Controller_BankViewMediator__CheckBackTimersCoroutine_d__14_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DA2")]
		[Address(RVA = "0x9BDA", Offset = "0x9BDA", VA = "0x9BDA")]
		private IEnumerator CheckBackTimersCoroutine()
		{
			return null;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0x9BDB", Offset = "0x9BDB", VA = "0x9BDB")]
		private void StopCheckBacktimersCoroutine()
		{
		/* --- GHIDRA: StopCheckBacktimersCoroutine ---
		void Gameplay_Bank_Controller_BankViewMediator__StopCheckBacktimersCoroutine
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  float fVar6;
		  int iVar7;
		  int *piVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5980d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a5980d = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar2 + 0x40) + 0x1c) == 0) {
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = 0;
		  piVar8 = *(int **)(*(int *)(iVar2 + 0x40) + 0x1c);
		  iVar2 = *piVar8;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_BankOptionData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81074c88;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,
		                                System_Collections_Generic_IEnumerable_BankOptionData__TypeInfo,0);
		code_r0x81074c88:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar8 = local_4;
		      iVar2 = *local_4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81074d59;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81074da1:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81074fa9;
		      }
		code_r0x81074d59:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		      piVar8 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81074da1;
		      if (iVar2 == 0) {
		        iVar2 = 0;
		        goto code_r0x81074ff2;
		      }
		      iVar2 = *local_4;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_BankOptionData__TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x81074e48;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_BankOptionData__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81074e91:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81074fa9;
		      }
		code_r0x81074e48:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81074e91;
		    } while (*(int *)(iVar2 + 0x58) == 0);
		    DAT_ram_009d3e38 = 0;
		    fVar6 = import::env::invoke_fii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,*(int *)(iVar2 + 0x58)
		                       ,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81074fa9;
		    }
		  } while (fVar6 != 0.0);
		  if (param1[6] == 0) {
		code_r0x81074f0f:
		    iVar2 = 0;
		    param1[6] = 0;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x148),param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar7 = DAT_ram_009d3e38;
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0xc,uVar5,iVar7);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x81074ff2;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0xb,param1[6],0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) goto code_r0x81074f0f;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x81074fa9:
		  iVar2 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar2 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x81074ff2:
		      piVar8 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8107506a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8107506a:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      }
		      if (iVar2 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0xd,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0x9BDC", Offset = "0x9BDC", VA = "0x9BDC")]
		private void CheckBackTimers()
		{
		/* --- GHIDRA: CheckBackTimers ---
		void Gameplay_Bank_Controller_BankViewMediator__CheckBackTimers
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5980e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5980e = '\x01';
		  }
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
		        goto code_r0x8107519b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x8107519b:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x134));
		  Core_Gameplay_Managers_BankManager__ShowBankWindow(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0x9BDD", Offset = "0x9BDD", VA = "0x9BDD")]
		private void BankOptionsListViewOnFaqButtonClickedEvent(BankOptionView bankOptionView)
		{
		/* --- GHIDRA: BankOptionsListViewOnFaqButtonClickedEvent ---
		void Gameplay_Bank_Controller_BankViewMediator__BankOptionsListViewOnFaqButtonClickedEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param3_00;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5980f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_View_IBankOptionView_TypeInfo);
		    DAT_ram_00a5980f = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Bank_View_IBankOptionView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81075275;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param2,Gameplay_Bank_View_IBankOptionView_TypeInfo,0);
		code_r0x81075275:
		  param2_00 = (**(code **)((ulonglong)*param3_00 * 4))(param2,param3_00[1]);
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions(param1_00,param2_00,param3_00);
		  return;
		}
		*/

		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x9BDE", Offset = "0x9BDE", VA = "0x9BDE")]
		private void BankOptionsListViewOnBuyButtonClickedEvent(IBankOptionView bankOptionView)
		{
		/* --- GHIDRA: BankOptionsListViewOnBuyButtonClickedEvent ---
		/* WARNING: Removing unreachable block (ram,0x810743ca) */
		
		int Gameplay_Bank_Controller_BankViewMediator__BankOptionsListViewOnBuyButtonClickedEvent
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint uVar7;
		  int iVar8;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59810 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankViewMediator__GetCurrentTabs_b__19_0__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_BankOptionData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankTabData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankTabData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankTabData__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankTabData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_BankTabData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_BankTabData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		    DAT_ram_00a59810 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_TabBarItemData___ctor__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(*(int *)(param1 + 8) + 0x10),
		             Method_System_Collections_Generic_List_BankTabData__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                         Method_System_Collections_Generic_List_Enumerator_BankTabData__MoveNext__);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810744d8;
		      }
		      iVar8 = local_20;
		      if (iVar3 == 0) goto code_r0x81074521;
		      iVar8 = local_8._4_4_;
		      uVar5 = *(undefined4 *)(local_8._4_4_ + 8);
		      iVar3 = *(int *)(param1 + 8);
		      if (DAT_ram_00a597b9 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a597b9 = '\x01';
		            goto code_r0x81074232;
		          }
		        }
		code_r0x810744d0:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810744d8;
		      }
		code_r0x81074232:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13d,
		                         *(undefined4 *)(iVar3 + 0x28),uVar5,
		                         Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		                        );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810744d0;
		      iVar1 = 0;
		      if (iVar4 != 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                           *(undefined4 *)(iVar3 + 0x28),uVar5,
		                           Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x810744d0;
		      }
		    } while (iVar1 == 0);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_BankOptionData__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81074453:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810744d8;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,param1,
		               Method_Gameplay_Bank_Controller_BankViewMediator__GetCurrentTabs_b__19_0__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81074453;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf6,iVar1,uVar5,
		                       Method_System_Linq_Enumerable_Any_BankOptionData___);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810744d8;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810744d8;
		    }
		    iVar1 = *(int *)(iVar8 + 0xc);
		    *(undefined4 *)(iVar3 + 0x10) = *(undefined4 *)(iVar1 + 0x10);
		    uVar5 = *(undefined4 *)(iVar1 + 0xc);
		    *(int *)(iVar3 + 0x20) = iVar8;
		    *(undefined4 *)(iVar3 + 0x14) = uVar5;
		    uVar5 = 2;
		    if (iVar4 == 0) {
		      uVar5 = 0;
		    }
		    *(undefined4 *)(iVar3 + 0x18) = uVar5;
		    iVar8 = Method_System_Collections_Generic_List_TabBarItemData__Add__;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar2 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = iVar3;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar3,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810744d8:
		        iVar8 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar8 == iVar3) {
		          piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		          iVar8 = *piVar6;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar8;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x81074521:
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            return iVar2;
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 10,&local_20);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          import::env::__resumeException(uVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004DA7")]
		[Address(RVA = "0x9BDF", Offset = "0x9BDF", VA = "0x9BDF")]
		private IEnumerable<TabBarItemData> GetCurrentTabs()
		{
		/* --- GHIDRA: GetCurrentTabs ---
		void Gameplay_Bank_Controller_BankViewMediator__GetCurrentTabs(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  undefined4 param3;
		  
		  if (DAT_ram_00a59811 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UiScope_BankTabChangedArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		    DAT_ram_00a59811 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_BankTabData__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_BankTabData__TypeInfo + 0xb8) * 4 + -4) !=
		        UI_Tabs_TabBarItemData_BankTabData__TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Bank_Controller_BankViewMediator__TabBarOnChangeEvent(param1,param1_00,param1);
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x44) + 0x1c);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_01 = unnamed_function_1417(Core_Events_Scopes_UiScope_BankTabChangedArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_01,param2_00,param3,param1_00,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_01,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x9BE0", Offset = "0x9BE0", VA = "0x9BE0")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		void Gameplay_Bank_Controller_BankViewMediator__TabBarOnChangeEvent
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_01;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59812 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_BankTabData__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		    DAT_ram_00a59812 = '\x01';
		  }
		  iVar2 = param1[2];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UnityEngine_UI_ScrollRect__UpdateScrollbars
		            (&local_8,*(undefined4 *)(*(int *)(iVar1 + 0x40) + 0x14),0);
		  if (DAT_ram_00a597b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__set_Item__);
		    DAT_ram_00a597b4 = '\x01';
		  }
		  local_18 = local_8;
		  System_Collections_Generic_Dictionary_int__Vector2___get_Values
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x30),&local_18,
		             Method_System_Collections_Generic_Dictionary_int__Vector2__set_Item__);
		  iVar2 = param1[2];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined4 *)(iVar2 + 0x30) = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x3c);
		  if (param2 == (int *)0x0) {
		    param2 = (int *)0x0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x3c),0);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_00 + 0xb8) <
		           (uint)*(byte *)(UI_Tabs_TabBarItemData_BankTabData__TypeInfo + 0xb8)) ||
		         (param2 = param1_00,
		         *(int *)(*(int *)(*param1_00 + 100) +
		                  (uint)*(byte *)(UI_Tabs_TabBarItemData_BankTabData__TypeInfo + 0xb8) * 4 + -4) !=
		         UI_Tabs_TabBarItemData_BankTabData__TypeInfo)) {
		        System_Activator__CreateInstance(param1_00,UI_Tabs_TabBarItemData_BankTabData__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  iVar1 = param1[2];
		  param2_01 = *(undefined4 *)(param2[8] + 8);
		  if (DAT_ram_00a597b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		              );
		    DAT_ram_00a597b9 = '\x01';
		  }
		  param2_00 = 0;
		  iVar2 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(iVar1 + 0x28),param2_01,
		                     Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		                    );
		  if (iVar2 != 0) {
		    param2_00 = GAFInternal_Reader_GAFReader__OpenTag
		                          (*(undefined4 *)(iVar1 + 0x28),param2_01,
		                           Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                          );
		  }
		  Gameplay_Bank_View_BankOptionsListView__get_Data(uVar3,param2_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  Gameplay_Bank_Model_BankModel__get_OptionValidator(&local_10,param1[2],param1);
		  local_20 = local_10;
		  Gameplay_Bank_View_BankOptionsListView__set_ScrollPosition(uVar3,&local_20,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x9BE1", Offset = "0x9BE1", VA = "0x9BE1")]
		private void RedrawCurrentTab([Optional] TabBarItemData<BankTabData> tab)
		{
		/* --- GHIDRA: RedrawCurrentTab ---
		undefined4
		Gameplay_Bank_Controller_BankViewMediator__RedrawCurrentTab(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a59813 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_IOptionValidator_TypeInfo);
		    DAT_ram_00a59813 = '\x01';
		  }
		  if (*(int *)(param2 + 0x28) == 0) {
		    uVar4 = 0;
		  }
		  else {
		    param1_00 = *(int **)(*(int *)(param1 + 8) + 0x18);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Bank_Model_IOptionValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81075444;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Bank_Model_IOptionValidator_TypeInfo,0);
		code_r0x81075444:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Coroutine _checkBackTimersCoroutine;

		// Token: 0x04002A4E RID: 10830
		[Token(Token = "0x4002A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _isInitialized;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Bank_Controller_BankViewMediator__set_Events(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param2_00;
		  undefined1 auStack_10 [10];
		  undefined1 local_6;
		  undefined1 local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59807 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28638);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24761);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3786);
		    DAT_ram_00a59807 = '\x01';
		  }
		  param2_00 = *(int *)(param2 + 0x30);
		  if (param2_00 == 0) {
		    local_4 = *(undefined4 *)(*(int *)(param2 + 0x38) + 0xc);
		    param2_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    *(int *)(param2 + 0x30) = param2_00;
		  }
		  local_5 = *(undefined1 *)(param2 + 0x6d);
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_5);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28638,param2_00,uVar1,0);
		  local_6 = *(undefined1 *)(param1 + 0x1c);
		  uVar2 = func_ii_1081(DAT_ram_00a66944,&local_6);
		  uVar2 = func_ii_4419(StringLiteral_24761,uVar2,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_3786,uVar1,uVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    Gameplay_Bank_Controller_BankViewMediator__TabBarOnChangeEvent(param1,0,auStack_10);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Bank_Controller_BankViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a5980a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Controller_BankViewMediator_TabBarOnChangeEvent__);
		    DAT_ram_00a5980a = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar4 + 0x3c);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,Method_Gameplay_Bank_Controller_BankViewMediator_TabBarOnChangeEvent__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar7,uVar5,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar4 = *(int *)(iVar4 + 0x40);
		  uVar5 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnBuyButtonClickedEvent__
		             ,0);
		  if (DAT_ram_00a59784 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59784 = '\x01';
		  }
		  iVar2 = *(int *)(iVar4 + 0x30);
		  while( true ) {
		    iVar3 = 0;
		    iVar6 = func_ii_7048(iVar2,uVar5,0);
		    uVar7 = System_Action_IBankOptionView__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar3 = func_ii_1082(iVar6,System_Action_IBankOptionView__TypeInfo), iVar3 == 0)) break;
		    iVar3 = func_ii_4329(iVar4 + 0x30,iVar3,iVar2);
		    bVar1 = iVar3 == iVar2;
		    iVar2 = iVar3;
		    if (bVar1) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar4 = *(int *)(iVar4 + 0x40);
		      uVar5 = unnamed_function_1417(System_Action_BankOptionView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Bank_Controller_BankViewMediator_BankOptionsListViewOnFaqButtonClickedEvent__
		                 ,0);
		      if (DAT_ram_00a59786 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		        DAT_ram_00a59786 = '\x01';
		      }
		      iVar2 = *(int *)(iVar4 + 0x34);
		      while( true ) {
		        iVar3 = 0;
		        iVar6 = func_ii_7048(iVar2,uVar5,0);
		        uVar7 = System_Action_BankOptionView__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar3 = func_ii_1082(iVar6,System_Action_BankOptionView__TypeInfo), iVar3 == 0)) break;
		        iVar3 = func_ii_4329(iVar4 + 0x34,iVar3,iVar2);
		        bVar1 = iVar3 == iVar2;
		        iVar2 = iVar3;
		        if (bVar1) {
		          return;
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
