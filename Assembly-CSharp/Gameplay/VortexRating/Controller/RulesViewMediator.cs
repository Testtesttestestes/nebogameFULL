using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.RulesTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	public class RulesViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, RulesView>, IHideableMediator
	{
		// Token: 0x06001587 RID: 5511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x6749", Offset = "0x6749", VA = "0x6749")]
		public RulesViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Controller_RulesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a585da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView__set_View__
		              );
		    DAT_ram_00a585da = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_ThemeDuel_Controller_RulesViewMediator__HandleHandBookClickEvent(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_ThemeDuel_Controller_RulesViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_Controller_RulesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a581e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__RulesView__set_View__
		              );
		    DAT_ram_00a581e1 = '\x01';
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000390 RID: 912
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000390")]
		public override RulesView View
		{
			[Token(Token = "0x6001588")]
			[Address(RVA = "0x674A", Offset = "0x674A", VA = "0x674A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x674B", Offset = "0x674B", VA = "0x674B", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_VortexRating_Controller_RulesViewMediator__Hide
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a581e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_VortexRatingModel__VortexRatingEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_RatingService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a581e2 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_VortexRatingModel__VortexRatingEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_RatingService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_ThemeDuel_Controller_RulesViewMediator__set_View(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  iVar1 = Gameplay_ThemeDuelCombat_ThemeDuelCombat__Dispose
		                    (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    UI_Windows_PopupController__Close(uVar2,2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: InShieldButtonClickedEventHandler ---
		void Gameplay_ThemeDuel_Controller_RulesViewMediator__InShieldButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27703);
		    DAT_ram_00a585db = '\x01';
		  }
		  param1_00 = Core_Extensions_Dict_DictExt__GetResourceSetParameter
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),StringLiteral_27703,0);
		  Core_ExternAppMethods__OpenPaymentWindow(param1_00,StringLiteral_19433,0,0);
		  return;
		}
		*/


		/* --- GHIDRA: HandleHandBookClickEvent ---
		void Gameplay_ThemeDuel_Controller_RulesViewMediator__HandleHandBookClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a585dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_HandleHandBookClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_InShieldButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a585dc = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x28) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_InShieldButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x30) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_HandleHandBookClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: ResetView ---
		void Gameplay_ThemeDuel_Controller_RulesViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  float fVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  undefined4 param1_00;
		  int iVar9;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a585dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__RulesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RulesView_RulesTabState__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_HandleHandBookClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_InShieldButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a585dd = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_InShieldButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(*(int *)(iVar2 + 0x30) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_ThemeDuel_Controller_RulesViewMediator_HandleHandBookClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar7,uVar3,0);
		  iVar2 = *(int *)(param1[2] + 0x14);
		  fVar4 = func_ii_7103(*(undefined4 *)(iVar2 + 0x34),0);
		  if (0.0 < fVar4) {
		    uVar6 = *(undefined4 *)(iVar2 + 0x10);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar8;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1f8);
		        goto code_r0x80f109b3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x80f109b3:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar9 = **(int **)(iVar2 + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x100) * 4))
		                    (*(int **)(iVar2 + 0x14),*(undefined4 *)(iVar9 + 0x104));
		  uVar3 = *(undefined4 *)(iVar2 + 0x28);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar8;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x288);
		        goto code_r0x80f10a7b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x80f10a7b:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetPartyCombatCost
		                    (uVar3,*(undefined4 *)(iVar2 + 0x14),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar8 = *(int **)(iVar2 + 0x1c);
		  uVar7 = Core_Extensions_Dict_ThemeDuelDicExt__GetTitle(uVar6,0);
		  iVar2 = *piVar8;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar8,uVar7,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x20);
		  uVar7 = Core_Extensions_Dict_ThemeDuelDicExt__GetIconForResourceCounterAssetId(uVar6,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1_00,uVar7,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar7 = *(undefined4 *)(iVar2 + 0x24);
		  uVar6 = Core_Extensions_Dict_ThemeDuelDicExt__GetAprImgAssetId(uVar6,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar7,uVar6,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(*(int *)(iVar2 + 0x28) + 0xb8);
		  uVar7 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  UI_Price_Price__SetColor(uVar6,uVar7,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar2 + 0x2c),*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x30),0);
		  if (param1[6] != 0) {
		    func_ii_7950(param1[6],0);
		  }
		  uVar6 = 2;
		  iVar2 = 0;
		  fVar4 = func_ii_7103(*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x30),0);
		  if (0.0 < fVar4) {
		    if (DAT_ram_00a585de == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_ThemeDuel_Controller_RulesViewMediator__DuelFinishedRoutine_d__8_TypeInfo
		                );
		      DAT_ram_00a585de = '\x01';
		    }
		    iVar2 = unnamed_function_1417
		                      (
		                      Gameplay_ThemeDuel_Controller_RulesViewMediator__DuelFinishedRoutine_d__8_TypeInfo
		                      );
		    *(int **)(iVar2 + 0x14) = param1;
		    *(undefined4 *)(iVar2 + 8) = 0;
		    *(float *)(iVar2 + 0x10) = fVar4;
		    iVar2 = Utils_CoroutineSource__GetMono(iVar2,0);
		    uVar6 = 1;
		  }
		  param1[6] = iVar2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar3,uVar6,
		             Method_UI_MonoBehaviourWithStates_RulesView_RulesTabState__set_CurrentState__);
		  uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar6,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar6,1,0);
		  return;
		}
		*/


		/* --- GHIDRA: SetupView ---
		int Gameplay_ThemeDuel_Controller_RulesViewMediator__SetupView
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a585de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_Controller_RulesViewMediator__DuelFinishedRoutine_d__8_TypeInfo);
		    DAT_ram_00a585de = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_ThemeDuel_Controller_RulesViewMediator__DuelFinishedRoutine_d__8_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: DuelFinishedRoutine ---
		void Gameplay_ThemeDuel_Controller_RulesViewMediator__DuelFinishedRoutine
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  if (param1[6] != 0) {
		    func_ii_7950(param1[6],0);
		    param1[6] = 0;
		  }
		  return;
		}
		*/

}
