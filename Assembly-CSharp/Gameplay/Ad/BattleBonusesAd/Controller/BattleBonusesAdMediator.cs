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
	// Token: 0x02000DBF RID: 3519
	[Token(Token = "0x2000DBF")]
	public class BattleBonusesAdMediator : AbstractViewMediator<BattleBonusesAdModel, BattleBonusesAdEvents, BattleBonusesAdController, BattleBonusesAdEntryView>
	{
		// Token: 0x060055D6 RID: 21974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0xA376", Offset = "0xA376", VA = "0xA376", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5886e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView___ctor__
		              );
		    DAT_ram_00a5886e = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0xA377", Offset = "0xA377", VA = "0xA377")]
		public BattleBonusesAdMediator(BattleBonusesAdModel model, BattleBonusesAdEvents events, BattleBonusesAdController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5886f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_ButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5886f = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_ButtonClickHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    if (param1[6] != 0) {
		      func_ii_7950(param1[6],0);
		    }
		    param1[6] = 0;
		    if (param1[7] != 0) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      func_ii_20511(uVar1,param1[7],0);
		    }
		    param1[7] = 0;
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_ButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__StopValidateStateRoutine
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001173 RID: 4467
		// (set) Token: 0x060055D8 RID: 21976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001173")]
		public override BattleBonusesAdEntryView View
		{
			[Token(Token = "0x60055D8")]
			[Address(RVA = "0xA378", Offset = "0xA378", VA = "0xA378", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17001174 RID: 4468
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001174")]
		public override BattleBonusesAdEvents Events
		{
			[Token(Token = "0x60055D9")]
			[Address(RVA = "0xA379", Offset = "0xA379", VA = "0xA379", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0xA37A", Offset = "0xA37A", VA = "0xA37A")]
		private void BonusAchievedChangedEvent()
		{
		/* --- GHIDRA: BonusAchievedChangedEvent ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__BonusAchievedChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58872 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3822);
		    DAT_ram_00a58872 = '\x01';
		  }
		  Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__StopValidateStateRoutine
		            (param1,param1);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_3822,0);
		  return;
		}
		*/

		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0xA37B", Offset = "0xA37B", VA = "0xA37B")]
		private void AdAvailabilityPossiblyChangedEvent()
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0xA37C", Offset = "0xA37C", VA = "0xA37C")]
		private void ButtonClickHandler()
		{
		/* --- GHIDRA: ButtonClickHandler ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58873 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow_BattleBonusesAdWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BattleBonusesAdWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12557);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2521);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2519);
		    DAT_ram_00a58873 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow_BattleBonusesAdWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a58869 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdWindow_BattleBonusesAdWindowArgs___ctor__
		              );
		    DAT_ram_00a58869 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdWindow_BattleBonusesAdWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2521,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2519,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  uVar2 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel__InitBonusMedals
		                    (param1[2],0);
		  *(undefined4 *)(param1_00 + 0x2c) = uVar2;
		  *(int *)(param1_00 + 0x34) = param1[2];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  *(undefined4 *)(param1_00 + 0x38) = uVar2;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  *(undefined4 *)(param1_00 + 0x30) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12557,param1_00,
		             Method_UI_Windows_PopupController_Show_BattleBonusesAdWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0xA37D", Offset = "0xA37D", VA = "0xA37D")]
		private void ShowWatchWindow()
		{
		/* --- GHIDRA: ShowWatchWindow ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ShowWatchWindow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58874 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_BattleBonusesAdBonusWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2521);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2519);
		    DAT_ram_00a58874 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a58862 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs___ctor__
		              );
		    DAT_ram_00a58862 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2521,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2519,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  uVar2 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel__GetAppropriateBonus
		                    (*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(param1_00 + 0x2c) = uVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12556,param1_00,
		             Method_UI_Windows_PopupController_Show_BattleBonusesAdBonusWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0xA37E", Offset = "0xA37E", VA = "0xA37E")]
		private void ShowBonusInfoWindow()
		{
		/* --- GHIDRA: ShowBonusInfoWindow ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ShowBonusInfoWindow
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__StopValidateStateRoutine
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0xA37F", Offset = "0xA37F", VA = "0xA37F")]
		private void ValidateState()
		{
		/* --- GHIDRA: ValidateState ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ValidateState
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (param1[7] != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_20511(param1_00,param1[7],0);
		  }
		  param1[7] = 0;
		  return;
		}
		*/

		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0xA380", Offset = "0xA380", VA = "0xA380")]
		private void StopValidateStateRoutine()
		{
		/* --- GHIDRA: StopValidateStateRoutine ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__StopValidateStateRoutine
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (param1[7] != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    func_ii_20511(uVar1,param1[7],0);
		  }
		  param1[7] = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (DAT_ram_00a58875 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ValidateStateRoutine_d__17_TypeInfo
		              );
		    DAT_ram_00a58875 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ValidateStateRoutine_d__17_TypeInfo
		                    );
		  *(int **)(iVar2 + 0x10) = param1;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  iVar2 = UnityEngine_MonoBehaviour__StartCoroutine(uVar1,iVar2,0);
		  param1[7] = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0xA381", Offset = "0xA381", VA = "0xA381")]
		private void RunValidateStateRoutine()
		{
		/* --- GHIDRA: RunValidateStateRoutine ---
		int Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__RunValidateStateRoutine
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58875 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ValidateStateRoutine_d__17_TypeInfo
		              );
		    DAT_ram_00a58875 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ValidateStateRoutine_d__17_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0xA382", Offset = "0xA382", VA = "0xA382")]
		private IEnumerator ValidateStateRoutine()
		{
		/* --- GHIDRA: ValidateStateRoutine ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__ValidateStateRoutine
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x18),0);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0xA383", Offset = "0xA383", VA = "0xA383")]
		private void StopButtonClickRoutine()
		{
		/* --- GHIDRA: StopButtonClickRoutine ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__StopButtonClickRoutine
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x18),0);
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  if (DAT_ram_00a58876 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__HandleButtonClickedRoutine_d__20_TypeInfo
		              );
		    DAT_ram_00a58876 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__HandleButtonClickedRoutine_d__20_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x10) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0xA384", Offset = "0xA384", VA = "0xA384")]
		private void RunButtonClickRoutine()
		{
		/* --- GHIDRA: RunButtonClickRoutine ---
		int Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__RunButtonClickRoutine
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58876 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__HandleButtonClickedRoutine_d__20_TypeInfo
		              );
		    DAT_ram_00a58876 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__HandleButtonClickedRoutine_d__20_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0xA385", Offset = "0xA385", VA = "0xA385")]
		private IEnumerator HandleButtonClickedRoutine()
		{
			return null;
		}

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _buttonClickedRoutine;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _validateStateRoutine;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x20")]
		private bool _adAvailable;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58870 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_AdAvailabilityPossiblyChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_BonusAchievedChangedEvent__
		              );
		    DAT_ram_00a58870 = '\x01';
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
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_AdAvailabilityPossiblyChangedEvent__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_BonusAchievedChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_AdAvailabilityPossiblyChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_BonusAchievedChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58871 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3823);
		    DAT_ram_00a58871 = '\x01';
		  }
		  Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator__StopValidateStateRoutine
		            (param1,param1);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_3823,0);
		  return;
		}
		*/

}
