using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Gameplay.Ad.BattleBonusesAd.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.Controller
{
	// Token: 0x02000DC2 RID: 3522
	[Token(Token = "0x2000DC2")]
	public class BattleBonusesAdWindowMediator : AbstractCozyViewMediator<BattleBonusesAdModel, BattleBonusesAdEvents, BattleBonusesAdController, BattleBonusesAdWindow>
	{
		// Token: 0x060055F2 RID: 22002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F2")]
		[Address(RVA = "0xA392", Offset = "0xA392", VA = "0xA392")]
		public BattleBonusesAdWindowMediator(BattleBonusesAdWindow view, BattleBonusesAdModel model, BattleBonusesAdEvents events, BattleBonusesAdController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5887a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_AdAvailabilityPossiblyChangedEvent__
		              );
		    DAT_ram_00a5887a = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_AdAvailabilityPossiblyChangedEvent__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 0x14) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F3")]
		[Address(RVA = "0xA393", Offset = "0xA393", VA = "0xA393", Slot = "21")]
		protected override void ResetEvents(BattleBonusesAdEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5887b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_AdAvailabilityPossiblyChangedEvent__
		              );
		    DAT_ram_00a5887b = '\x01';
		  }
		  param1_02 = *(undefined4 *)(param2 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_AdAvailabilityPossiblyChangedEvent__
		             ,0);
		  param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(param2 + 0x14) = param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F4")]
		[Address(RVA = "0xA394", Offset = "0xA394", VA = "0xA394", Slot = "22")]
		protected override void SetupEvents(BattleBonusesAdEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__SetupEvents
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5887c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_WatchButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5887c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param2 + 0x54) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_WatchButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_20511(param2,*(int *)(param1 + 0x18),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F5")]
		[Address(RVA = "0xA395", Offset = "0xA395", VA = "0xA395", Slot = "23")]
		protected override void ResetView(BattleBonusesAdWindow view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5887d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_WatchButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5887d = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param2 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_WatchButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_00,uVar1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a5887e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability_d__8_TypeInfo
		              );
		    DAT_ram_00a5887e = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability_d__8_TypeInfo
		                    );
		  *(int **)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  iVar2 = UnityEngine_MonoBehaviour__StartCoroutine(uVar1,iVar2,0);
		  param1[6] = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F6")]
		[Address(RVA = "0xA396", Offset = "0xA396", VA = "0xA396", Slot = "24")]
		protected override void SetupView(BattleBonusesAdWindow view)
		{
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0xA397", Offset = "0xA397", VA = "0xA397")]
		private void ValidateState()
		{
		/* --- GHIDRA: ValidateState ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__ValidateState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a5887e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability_d__8_TypeInfo
		              );
		    DAT_ram_00a5887e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability_d__8_TypeInfo
		                    );
		  *(int **)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  iVar1 = UnityEngine_MonoBehaviour__StartCoroutine(param1_00,iVar1,0);
		  param1[6] = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055F8")]
		[Address(RVA = "0xA398", Offset = "0xA398", VA = "0xA398")]
		private void AdAvailabilityPossiblyChangedEvent()
		{
		/* --- GHIDRA: AdAvailabilityPossiblyChangedEvent ---
		int Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__AdAvailabilityPossiblyChangedEvent
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5887e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability_d__8_TypeInfo
		              );
		    DAT_ram_00a5887e = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability_d__8_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0xA399", Offset = "0xA399", VA = "0xA399")]
		private IEnumerator HandleAdAvailability()
		{
		/* --- GHIDRA: HandleAdAvailability ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator__HandleAdAvailability
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a5887f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    DAT_ram_00a5887f = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = *(int **)(iVar2 + 0x18);
		  uVar3 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__IsAdAvailable
		                    (param1[2],0);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f3798b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,
		                                Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo,0);
		code_r0x80f3798b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,0,puVar4[1]);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0xA39A", Offset = "0xA39A", VA = "0xA39A")]
		private void WatchButtonClickHandler()
		{
		}

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _handleAdAvailabilityRoutine;
	}
}
