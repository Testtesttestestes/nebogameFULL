using System;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.WorldAxis.ColossusInfo.Controller.ColossusInfo
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	public class ColossusInfoViewMediator : AbstractViewMediator<ColossusInfoModel, ColossusInfoEvents, ColossusInfoController, ColossusInfoWindow>
	{
		// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x64CA", Offset = "0x64CA", VA = "0x64CA")]
		public ColossusInfoViewMediator(ColossusInfoModel model, ColossusInfoEvents events, ColossusInfoController controller)
		{
		/* --- GHIDRA: <Init>b__7_0 ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator___Init_b__7_0
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58c10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo);
		    DAT_ram_00a58c10 = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 0x30) + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f8a91e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo,
		                                0);
		code_r0x80f8a91e:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar3 = **(int **)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		            (*(int **)(param1 + 0x28),*(undefined4 *)(iVar3 + 0xec));
		  iVar3 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		            (*(int **)(param1 + 0x2c),*(undefined4 *)(iVar3 + 0x134));
		  iVar3 = *(int *)(param1 + 0x30);
		  *(undefined4 *)(iVar3 + 0x10) = 0;
		  *(undefined8 *)(iVar3 + 8) = 0;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x30) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58c01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_AttackButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ClassButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_CreateClanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_JoinSquadButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_JoinSquadButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_TabBarChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58c01 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_TabBarChangedEventHandler__
		               ,0);
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x68) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_AttackButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x6c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_JoinSquadButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x70) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x74);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_JoinSquadButtonClickedEventHandler__
		               ,0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x78);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ClassButtonClickedEventHandler__
		               ,0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x44);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_TabBarChangedEventHandler__
		               ,0);
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x68) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_AttackButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x6c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_JoinSquadButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x70) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_CreateClanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x74);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_JoinSquadButtonClickedEventHandler__
		               ,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x78);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ClassButtonClickedEventHandler__
		               ,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		    Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__set_View
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170002E9 RID: 745
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		public override ColossusInfoWindow View
		{
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x64CB", Offset = "0x64CB", VA = "0x64CB", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x64CC", Offset = "0x64CC", VA = "0x64CC")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58c03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17791);
		    DAT_ram_00a58c03 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(iVar1 + 100),*(undefined4 *)(*(int *)(param1[2] + 0x18) + 0x18),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 100),0);
		  uVar3 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync
		                    (*(undefined4 *)(param1[2] + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar3,0);
		  iVar1 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync
		                    (*(undefined4 *)(param1[2] + 0x18),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar4 + 0x60);
		  if (iVar1 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17791,1,0,1,0,0,0,0);
		  }
		  else {
		    uVar3 = Core_Data_ColossusBattleData__get_IsValid(*(undefined4 *)(param1[2] + 0x18),0);
		  }
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x64CD", Offset = "0x64CD", VA = "0x64CD")]
		private void DrawBattleStatus()
		{
		/* --- GHIDRA: DrawBattleStatus ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__DrawBattleStatus
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58c04 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c04 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80f8975d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f8975d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x64CE", Offset = "0x64CE", VA = "0x64CE")]
		private void CreateClanButtonClickedEventHandler()
		{
		/* --- GHIDRA: CreateClanButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__CreateClanButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58c05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c05 = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x68) == 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		          goto code_r0x80f8984f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f8984f:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		    Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(uVar3,0);
		    return;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80f898ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f898ff:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser(uVar3,param2_00,5,0);
		  return;
		}
		*/

		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x64CF", Offset = "0x64CF", VA = "0x64CF")]
		private void JoinSquadButtonClickedEventHandler()
		{
		/* --- GHIDRA: JoinSquadButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__JoinSquadButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58c06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c06 = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x68) == 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		          goto code_r0x80f89a0c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f89a0c:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		    Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(uVar3,0);
		    return;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80f89abc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f89abc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser(uVar3,param2_00,6,0);
		  return;
		}
		*/

		/* --- GHIDRA: JoinSquadButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__JoinSquadButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58c06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c06 = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1 + 8) + 8) + 0x68) == 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		          goto code_r0x80f89a0c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f89a0c:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		    Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(uVar3,0);
		    return;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80f89abc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f89abc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		  param2_00 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  Core_Gameplay_Managers_ClansManager__DissociateClanFromUser(uVar3,param2_00,6,0);
		  return;
		}
		*/

		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x64D0", Offset = "0x64D0", VA = "0x64D0")]
		private void JoinSquadButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x64D1", Offset = "0x64D1", VA = "0x64D1")]
		private void ClassButtonClickedEventHandler(IndexButtonBasic btn)
		{
		/* --- GHIDRA: ClassButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ClassButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  longlong lVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  longlong lVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a58c07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    DAT_ram_00a58c07 = '\x01';
		  }
		  iVar4 = param1[2];
		  iVar5 = *(int *)(*(int *)(iVar4 + 0x18) + 0x14);
		  if (iVar5 != 0) {
		    lVar7 = *(longlong *)(*(int *)(iVar5 + 0x1c) + 0x10);
		    lVar3 = Core_Data_UserData___ctor(*(undefined4 *)(iVar4 + 8),0);
		    iVar4 = param1[2];
		    if (lVar7 == lVar3) {
		      uVar1 = Gameplay_WorldAxis_Model_WorldAxisModel__get_AttackPrice
		                        (*(undefined4 *)(iVar4 + 0x10),0);
		      goto code_r0x80f89b66;
		    }
		  }
		  uVar1 = Gameplay_WorldAxis_Model_WorldAxisModel__set_SelectedParty
		                    (*(undefined4 *)(iVar4 + 0x10),0);
		code_r0x80f89b66:
		  uVar8 = 0;
		  piVar6 = *(int **)(param1[2] + 0x14);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f89bdd;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Data_Balance_IBalanceSource_TypeInfo,2);
		code_r0x80f89bdd:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar4 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(param1_00,uVar1,0);
		  if (iVar4 != 0) {
		    piVar6 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar1 = *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0x10);
		    if (DAT_ram_00a58bff == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo);
		      DAT_ram_00a58bff = '\x01';
		    }
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x100) * 4))
		                      (piVar6,*(undefined4 *)(*piVar6 + 0x104));
		    uVar8 = 0;
		    piVar6 = *(int **)(*(int *)(iVar4 + 0x10) + 0x14);
		    iVar4 = *piVar6;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 + iVar4 + 0xd8);
		          goto code_r0x80f89cc8;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,
		                                  Gameplay_WorldAxis_Colossus_Combat_IColossusCombatLauncher_TypeInfo
		                                  ,3);
		code_r0x80f89cc8:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar1,puVar2[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x64D2", Offset = "0x64D2", VA = "0x64D2")]
		private void AttackButtonClickedEventHandler()
		{
		/* --- GHIDRA: AttackButtonClickedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__AttackButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58c08 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    DAT_ram_00a58c08 = '\x01';
		  }
		  iVar2 = param1[2];
		  if (*(int *)(*(int *)(iVar2 + 8) + 0x68) == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x70),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x6c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x68),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  if (*(int *)(*(int *)(iVar2 + 0x10) + 0x30) == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x70),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x6c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x68),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  iVar3 = *(int *)(*(int *)(iVar2 + 0x18) + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x70),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x6c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x68),0);
		  if (iVar3 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x64D3", Offset = "0x64D3", VA = "0x64D3")]
		private void HandleActionButtons()
		{
		/* --- GHIDRA: HandleActionButtons ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__HandleActionButtons
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58c09 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    DAT_ram_00a58c09 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x44) + 0x3c);
		  if (iVar1 != 0) {
		    if (iVar1 == 1) {
		      piVar3 = (int *)param1[9];
		      if (piVar3 != (int *)0x0) {
		        (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		                  (piVar3,0,*(undefined4 *)(*piVar3 + 0x164));
		        (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		                  (piVar3,0,*(undefined4 *)(*piVar3 + 0x144));
		      }
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar1 + 0x54),1,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x4c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x3c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,0,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar4 = param1[2];
		      Gameplay_WorldAxis_Office_View_FrontPageTab_FrontPageView___ctor
		                (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(*(int *)(iVar4 + 0x18) + 0x10),
		                 *(undefined4 *)(iVar4 + 0x20),iVar4);
		      return;
		    }
		    if (iVar1 == 2) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar1 + 0x54),0,0);
		      piVar3 = (int *)param1[9];
		      if (piVar3 == (int *)0x0) {
		        Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ShowTreasuryTab
		                  (param1,param1);
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		                (piVar3,param1[7],*(undefined4 *)(*piVar3 + 0x144));
		      piVar3 = (int *)param1[9];
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x160) * 4))
		                (piVar3,*(undefined4 *)(iVar1 + 0x50),*(undefined4 *)(iVar4 + 0x164));
		    }
		    return;
		  }
		  piVar3 = (int *)param1[9];
		  if (piVar3 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		              (piVar3,0,*(undefined4 *)(*piVar3 + 0x164));
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x140) * 4))
		              (piVar3,0,*(undefined4 *)(*piVar3 + 0x144));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x54),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x4c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x64D4", Offset = "0x64D4", VA = "0x64D4")]
		private void TabBarChangedEventHandler()
		{
		/* --- GHIDRA: TabBarChangedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__TabBarChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[9];
		  if (piVar2 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x140) * 4))
		              (piVar2,param1[7],*(undefined4 *)(*piVar2 + 0x144));
		    piVar2 = (int *)param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x160) * 4))
		              (piVar2,*(undefined4 *)(iVar1 + 0x50),*(undefined4 *)(iVar3 + 0x164));
		    return;
		  }
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ShowTreasuryTab
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x64D5", Offset = "0x64D5", VA = "0x64D5")]
		private void ShowTreasuryTab()
		{
		/* --- GHIDRA: ShowTreasuryTab ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ShowTreasuryTab
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58c0a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Events_ColossusTreasuryEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58c0a = '\x01';
		  }
		  iVar4 = param1[2];
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  iVar2 = unnamed_function_1417
		                    (Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel_TypeInfo);
		  Gameplay_WorldAxis_ColossusInfo_Model_ColossusTreasuryModel__get_DictProvider
		            (iVar2,uVar5,iVar4,iVar4);
		  param1[6] = iVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x238);
		        goto code_r0x80f8a208;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80f8a208:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar5 = *(undefined4 *)(iVar2 + 0x18);
		  iVar2 = unnamed_function_1417
		                    (Gameplay_WorldAxis_ColossusInfo_Events_ColossusTreasuryEvents_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = uVar5;
		  param1[7] = iVar2;
		  iVar7 = param1[6];
		  iVar4 = unnamed_function_1417
		                    (Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController_TypeInfo)
		  ;
		  if (DAT_ram_00a58bf1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ColossusTreasuryModel__ColossusTreasuryEvents___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58bf1 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar4,iVar7,iVar2,
		             Method_MVC_AbstractController_ColossusTreasuryModel__ColossusTreasuryEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar5 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(iVar4 + 0x18) = uVar5;
		  param1[8] = iVar4;
		  iVar2 = param1[6];
		  iVar7 = param1[7];
		  piVar6 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryViewMediator_TypeInfo
		                            );
		  if (DAT_ram_00a58be3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView___ctor__
		              );
		    DAT_ram_00a58be3 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar6,iVar2,iVar7,iVar4,
		             Method_MVC_AbstractViewMediator_ColossusTreasuryModel__ColossusTreasuryEvents__ColossusTreasuryController__ColossusTreasuryView___ctor__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,*(undefined4 *)(iVar2 + 0x50),*(undefined4 *)(*piVar6 + 0x164));
		  param1[9] = (int)piVar6;
		  MVC_AbstractController__Dispose(param1[8],0);
		  return;
		}
		*/

		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x64D6", Offset = "0x64D6", VA = "0x64D6")]
		private void CreateTreasuryMVC()
		{
		/* --- GHIDRA: CreateTreasuryMVC ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__CreateTreasuryMVC
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58c0b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ColossusRatingRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_PartyChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ScheduleChangedEventHandler__
		              );
		    DAT_ram_00a58c0b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ColossusRatingRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_PartyChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ScheduleChangedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ColossusRatingRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_PartyChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    iVar2 = *(int *)(iVar1 + 0x14);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_ScheduleChangedEventHandler__
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

		// Token: 0x170002EA RID: 746
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		public override ColossusInfoEvents Events
		{
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x64D7", Offset = "0x64D7", VA = "0x64D7", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x64D8", Offset = "0x64D8", VA = "0x64D8")]
		private void ScheduleChangedEventHandler()
		{
		/* --- GHIDRA: ScheduleChangedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ScheduleChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined8 local_8;
		  
		  uVar4 = 0;
		  if (DAT_ram_00a58c0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21216);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17788);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17789);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27362);
		    DAT_ram_00a58c0c = '\x01';
		  }
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__AttackButtonClickedEventHandler
		            (param1,param1);
		  iVar5 = *(int *)(*(int *)(param1[2] + 0x10) + 0x30);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar1 + 0x5c);
		  if (iVar5 == 0) {
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (piVar6,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17789,1,0,1,0,0,0,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    uVar3 = Core_Extensions_Dict_OptionsMenuButtonExt__GetIcon
		                      (*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x30),0);
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_27362,uVar3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar1 + 0x10) = local_8;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar1,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xf0) * 4))
		              (piVar6,uVar2,*(undefined4 *)(*piVar6 + 0xf4));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar6 = *(int **)(iVar1 + 0x58);
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17788,1,0,1,0,0,0,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    uVar2 = StringLiteral_21216;
		    iVar5 = *(int *)(*(int *)(param1[2] + 0x10) + 0x24);
		    if (iVar5 != 0) {
		      uVar4 = Core_Extensions_Dict_DiscountsDicExt__GetDiscountDescription(iVar5,0);
		    }
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,uVar2,uVar4,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar1 + 0x10) = local_8;
		    uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar3,iVar1,0);
		    iVar1 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		              (piVar6,uVar4,*(undefined4 *)(iVar1 + 0xf4));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x5c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,1,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x64D9", Offset = "0x64D9", VA = "0x64D9")]
		private void PartyChangedEventHandler()
		{
		/* --- GHIDRA: PartyChangedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__PartyChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param4;
		  
		  if (DAT_ram_00a58c0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    DAT_ram_00a58c0d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param4 = param1[2];
		  Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow_ColossusInfoWindowArgs___ctor
		            (*(undefined4 *)(iVar1 + 0x3c),*(undefined4 *)(param4 + 0x1c),
		             *(undefined4 *)(param4 + 8),param4);
		  return;
		}
		*/

		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x64DA", Offset = "0x64DA", VA = "0x64DA")]
		private void ColossusRatingRequestedEventHandler()
		{
		/* --- GHIDRA: ColossusRatingRequestedEventHandler ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ColossusRatingRequestedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__Dispose__
		              );
		    DAT_ram_00a58c0e = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__Dispose__
		            );
		  if (*(int *)(param1 + 0x24) != 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x20),0);
		    iVar1 = **(int **)(param1 + 0x24);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x24),*(undefined4 *)(iVar1 + 0x134));
		    iVar1 = **(int **)(param1 + 0x20);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x20),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x64DB", Offset = "0x64DB", VA = "0x64DB", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		uint Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58c0f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a58c0f = '\x01';
		  }
		  uVar1 = *(uint *)(param2 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		                      );
		  return (uint)((ulonglong)uVar1 == (longlong)*(int *)(iVar2 + 0x18));
		}
		*/

		}

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x18")]
		private ColossusTreasuryModel _treasuryModel;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x1C")]
		private ColossusTreasuryEvents _treasuryEvents;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x20")]
		private ColossusTreasuryController _treasuryController;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x24")]
		private ColossusTreasuryViewMediator _treasuryMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58c02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__Init_b__7_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData__FindIndex__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_TabBarItemData__TypeInfo);
		    DAT_ram_00a58c02 = '\x01';
		  }
		  uVar1 = Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel___ctor(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar2 + 0x44),uVar1,0);
		  uVar3 = unnamed_function_1417(System_Predicate_TabBarItemData__TypeInfo);
		  func_ii_7297(uVar3,param1,
		               Method_Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__Init_b__7_0__
		               ,0);
		  iVar2 = System_Collections_Generic_List_UsageHint___FindAll
		                    (uVar1,uVar3,Method_System_Collections_Generic_List_TabBarItemData__FindIndex__)
		  ;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 < 1) {
		    iVar2 = 0;
		  }
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar4 + 0x44),iVar2,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar2 + 0x48);
		  uVar1 = Core_Extensions_Dict_CollectionsDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x18) + 0x10),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__Init
		            (param1,param1);
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ScheduleChangedEventHandler
		            (param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__Init
		            (param1,param1);
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator__ScheduleChangedEventHandler
		            (param1,param1);
		  return;
		}
		*/

}
