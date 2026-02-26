using System;
using AssetContent.Loaders;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.Discounts.View;
using Gameplay.Inventory.View.Info;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	public class ArtifactActionPopupWindow : ClosableBaseWindow<ArtifactActionPopupWindow.ArtifactActionPopupWindowArgs>
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000762")]
		public override string WindowId
		{
			[Token(Token = "0x600273F")]
			[Address(RVA = "0x7872", Offset = "0x7872", VA = "0x7872", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000763")]
		public ButtonWithCost CostButton
		{
			[Token(Token = "0x6002740")]
			[Address(RVA = "0x7873", Offset = "0x7873", VA = "0x7873")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000764")]
		public ArtifactActionsView ActionsView
		{
			[Token(Token = "0x6002741")]
			[Address(RVA = "0x7874", Offset = "0x7874", VA = "0x7874")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000765")]
		public DiscountGroup DiscountGroup
		{
			[Token(Token = "0x6002742")]
			[Address(RVA = "0x7875", Offset = "0x7875", VA = "0x7875")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000766")]
		public GameObject BattleAccountTip
		{
			[Token(Token = "0x6002743")]
			[Address(RVA = "0x7876", Offset = "0x7876", VA = "0x7876")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x7877", Offset = "0x7877", VA = "0x7877", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Inventory_View_ArtifactActionPopupWindow__Awake
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a07d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&Core_MVC_Interfaces_IViewMediator_ArtifactActionPopupWindow__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_ArtifactActionPopupWindow_ActionType__set_CurrentState__
		              );
		    DAT_ram_00a5a07d = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__OnShow__
		              );
		  param1_00 = *(int **)(param2 + 0x18);
		  *(int **)(param1 + 0x58) = param1_00;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_ArtifactActionPopupWindow__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x811bdff7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Core_MVC_Interfaces_IViewMediator_ArtifactActionPopupWindow__TypeInfo
		                                ,1);
		code_r0x811bdff7:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(param2 + 0x1c),
		             Method_UI_MonoBehaviourWithStates_ArtifactActionPopupWindow_ActionType__set_CurrentState__
		            );
		  iVar4 = **(int **)(param2 + 0x20);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x130) * 4))
		                    (*(int **)(param2 + 0x20),*(undefined4 *)(iVar4 + 0x134));
		  Gameplay_Inventory_View_ArtifactActionPopupWindow__OnShow(param1,uVar3,iVar4);
		  uVar3 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x1c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,*(undefined4 *)(param2 + 0x24),0);
		  return;
		}
		*/

		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x7878", Offset = "0x7878", VA = "0x7878", Slot = "22")]
		protected override void OnShow(ArtifactActionPopupWindow.ArtifactActionPopupWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Inventory_View_ArtifactActionPopupWindow__OnShow
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined8 uVar6;
		  uint uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a07e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a07e = '\x01';
		  }
		  Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__HandleDataChanged
		            (*(undefined4 *)(*(int *)(param1 + 0x48) + 0x10),param1);
		  iVar8 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x138) * 4))
		            (*(int **)(param1 + 0x44),param2,*(undefined4 *)(iVar8 + 0x13c));
		  iVar3 = *(int *)(param1 + 0x44);
		  iVar8 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__get_WindowArgs__
		                      );
		  uVar6 = *(undefined8 *)(*(int *)(iVar8 + 0x20) + 0x50);
		  *(undefined4 *)(iVar3 + 0x58) = *(undefined4 *)(*(int *)(iVar8 + 0x20) + 0x58);
		  *(undefined8 *)(iVar3 + 0x50) = uVar6;
		  *(undefined1 *)(iVar3 + 0x45) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(iVar3,0);
		  piVar4 = *(int **)(param1 + 0x3c);
		  uVar1 = Core_Data_ArtikulData__get_IsSellable(param2,0);
		  iVar8 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(iVar8 + 0x2d4));
		  uVar5 = *(undefined4 *)(param1 + 0x40);
		  uVar1 = Core_Data_ArtikulData__get_CurrentDurability(param2,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar5,uVar1,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  uVar1 = *(undefined4 *)(param2 + 0x70);
		  iVar8 = *(int *)(param1 + 0x48);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x811be1e7;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811be1e7:
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  iVar3 = unnamed_function_1417(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_ArtifactInfoProvider__Dispose(iVar3,uVar1,uVar5,param2,0);
		  if (iVar3 != *(int *)(iVar8 + 0x14)) {
		    *(int *)(iVar8 + 0x14) = iVar3;
		    iVar8 = *(int *)(iVar8 + 0x10);
		    if (*(int *)(iVar8 + 0x28) != iVar3) {
		      *(int *)(iVar8 + 0x28) = iVar3;
		      Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__set_Data(iVar8,iVar3);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x7879", Offset = "0x7879", VA = "0x7879")]
		public void DrawArtifactInfo(ArtifactData artifactData)
		{
		/* --- GHIDRA: DrawArtifactInfo ---
		void Gameplay_Inventory_View_ArtifactActionPopupWindow__DrawArtifactInfo
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a07f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a07f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x58);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811bfc99;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x811bfc99:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__OnClose__
		            );
		  *(undefined4 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x787A", Offset = "0x787A", VA = "0x787A", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Inventory_View_ArtifactActionPopupWindow__OnClose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x20),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x787B", Offset = "0x787B", VA = "0x787B")]
		public void EnableSale(bool enable)
		{
		/* --- GHIDRA: EnableSale ---
		undefined4
		Gameplay_Inventory_View_ArtifactActionPopupWindow__EnableSale
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a080 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ArtifactActionPopupWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_Controller_UserArtifactActionViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12632);
		    DAT_ram_00a5a080 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120);
		        goto code_r0x811bfdaf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811bfdaf:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))
		                        (piVar4,*(undefined4 *)(*piVar4 + 0x114));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Inventory_Controller_UserArtifactActionViewMediator_TypeInfo);
		  Gameplay_Inventory_Controller_InventoryEvents___ctor(param1_00,uVar3,param3_00,piVar4,0);
		  iVar5 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_View_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs_TypeInfo
		                    );
		  UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x24) = param3;
		  *(undefined4 *)(iVar5 + 0x20) = param2;
		  *(undefined4 *)(iVar5 + 0x1c) = param1;
		  *(undefined4 *)(iVar5 + 0x18) = param1_00;
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12632,iVar5,
		                     Method_UI_Windows_PopupController_Show_ArtifactActionPopupWindow___);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x787C", Offset = "0x787C", VA = "0x787C")]
		public static ArtifactActionPopupWindow Show(ArtifactActionPopupWindow.ActionType type, ArtifactView artifactView, string actionName)
		{
		/* --- GHIDRA: Show ---
		undefined4
		Gameplay_Inventory_View_ArtifactActionPopupWindow__Show
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a081 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ArtifactActionPopupWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12632);
		    DAT_ram_00a5a081 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x238);
		        goto code_r0x811bff3a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x811bff3a:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  piVar4 = *(int **)(iVar5 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))
		                        (piVar4,*(undefined4 *)(*piVar4 + 0x114));
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator_TypeInfo
		                        );
		  Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator__HandleDifferentLeagues
		            (param1_00,uVar3,param3_00,piVar4,0);
		  iVar5 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_View_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs_TypeInfo
		                    );
		  UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		  *(undefined4 *)(iVar5 + 0x24) = param3;
		  *(undefined4 *)(iVar5 + 0x20) = param2;
		  *(undefined4 *)(iVar5 + 0x1c) = param1;
		  *(undefined4 *)(iVar5 + 0x18) = param1_00;
		  uVar3 = System_Uri___ctor(0);
		  uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12632,iVar5,
		                     Method_UI_Windows_PopupController_Show_ArtifactActionPopupWindow___);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x787D", Offset = "0x787D", VA = "0x787D")]
		public static ArtifactActionPopupWindow ShowForGolem(ArtifactActionPopupWindow.ActionType type, ArtifactView artifactView, string actionName)
		{
		/* --- GHIDRA: ShowForGolem ---
		void Gameplay_Inventory_View_ArtifactActionPopupWindow__ShowForGolem
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a082 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs___ctor__
		              );
		    DAT_ram_00a5a082 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x787E", Offset = "0x787E", VA = "0x787E")]
		public ArtifactActionPopupWindow()
		{
		}

		// Token: 0x04001572 RID: 5490
		[Token(Token = "0x4001572")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtifactActionPopupWindow";

		// Token: 0x04001573 RID: 5491
		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04001576 RID: 5494
		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtifactInfoPropertiesView _propertiesView;

		// Token: 0x04001577 RID: 5495
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ArtifactActionsView _actionsView;

		// Token: 0x04001578 RID: 5496
		[Token(Token = "0x4001578")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _battleAccountTip;

		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		[FieldOffset(Offset = "0x58")]
		private IViewMediator<ArtifactActionPopupWindow> _mediator;

		// Token: 0x02000653 RID: 1619
		[Token(Token = "0x2000653")]
		public class ArtifactActionPopupWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600274C RID: 10060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600274C")]
			[Address(RVA = "0x787F", Offset = "0x787F", VA = "0x787F")]
			public ArtifactActionPopupWindowArgs()
			{
			}

			// Token: 0x0400157B RID: 5499
			[Token(Token = "0x400157B")]
			[FieldOffset(Offset = "0x18")]
			public IViewMediator<ArtifactActionPopupWindow> Mediator;

			// Token: 0x0400157C RID: 5500
			[Token(Token = "0x400157C")]
			[FieldOffset(Offset = "0x1C")]
			public ArtifactActionPopupWindow.ActionType ActionType;

			// Token: 0x0400157D RID: 5501
			[Token(Token = "0x400157D")]
			[FieldOffset(Offset = "0x20")]
			public ArtifactView ArtifactView;

			// Token: 0x0400157E RID: 5502
			[Token(Token = "0x400157E")]
			[FieldOffset(Offset = "0x24")]
			public string ActionName;
		}

		// Token: 0x02000654 RID: 1620
		[Token(Token = "0x2000654")]
		public enum ActionType
		{
			// Token: 0x04001580 RID: 5504
			[Token(Token = "0x4001580")]
			UNKNOWN_STATE,
			// Token: 0x04001581 RID: 5505
			[Token(Token = "0x4001581")]
			REFORGE,
			// Token: 0x04001582 RID: 5506
			[Token(Token = "0x4001582")]
			REPAIR
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Inventory_View_ArtifactActionPopupWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x1c);
		}
		*/


		/* --- GHIDRA: get_BattleAccountTip ---
		void Gameplay_Inventory_View_ArtifactActionPopupWindow__get_BattleAccountTip
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a07c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__Awake__
		              );
		    DAT_ram_00a5a07c = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtifactActionPopupWindow_ArtifactActionPopupWindowArgs__Awake__
		            );
		  *(undefined4 *)(*(int *)(param1 + 0x44) + 0x24) = 2;
		  return;
		}
		*/

}
