using System;
using Gameplay.Isles.User.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Tree.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tree.Control
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	public class TreeViewMediator2 : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, TreeView2>
	{
		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x6D36", Offset = "0x6D36", VA = "0x6D36")]
		public TreeViewMediator2(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tree_Control_TreeViewMediator2___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a584b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tree_Control_TreeViewMediator2_BuildingStateChangedEvent__);
		    DAT_ram_00a584b7 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Tree_Control_TreeViewMediator2_BuildingStateChangedEvent__,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Tree_Control_TreeViewMediator2_BuildingStateChangedEvent__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x14) = iVar4;
		    uVar2 = System_Action_uint__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
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

		// Token: 0x170004D7 RID: 1239
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D7")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6001BB8")]
			[Address(RVA = "0x6D37", Offset = "0x6D37", VA = "0x6D37", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x6D38", Offset = "0x6D38", VA = "0x6D38")]
		private void BuildingStateChangedEvent(uint buildingType)
		{
		/* --- GHIDRA: BuildingStateChangedEvent ---
		void Gameplay_Tree_Control_TreeViewMediator2__BuildingStateChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a584b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView2_UserIsle__get_IsleBg__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView2_UserIsle__get_TreeBg__);
		    DAT_ram_00a584b9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = Core_Extensions_Dict_IsleDecorationsDicExt__GetAnimationAssetId
		                    (*(undefined4 *)(param1[2] + 0x38),0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar4,uVar2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = *(undefined4 *)(iVar1 + 0x18);
		  piVar3 = (int *)System_Collections_Generic_List_object___get_Item
		                            (*(undefined4 *)(param1[2] + 0x24),1,
		                             Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                            );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x108) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0x10c));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x6D39", Offset = "0x6D39", VA = "0x6D39")]
		private void RenderTreeBigView()
		{
		/* --- GHIDRA: RenderTreeBigView ---
		void Gameplay_Tree_Control_TreeViewMediator2__RenderTreeBigView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a584ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2__set_View__
		              );
		    DAT_ram_00a584ba = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Tree_Control_TreeViewMediator2__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Tree_Control_TreeViewMediator2__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170004D8 RID: 1240
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D8")]
		public override TreeView2 View
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x6D3A", Offset = "0x6D3A", VA = "0x6D3A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x6D3B", Offset = "0x6D3B", VA = "0x6D3B")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Tree_Control_TreeViewMediator2__ResetView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int *param1_01;
		  int iVar4;
		  uint *param2_00;
		  int iVar5;
		  int *piVar6;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a584bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView2_UserIsle__get_BuildingItems__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnActionButtonClickedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnClickedEvent__);
		    DAT_ram_00a584bc = '\x01';
		  }
		  param2_00 = (uint *)*param1;
		  iVar2 = (**(code **)((ulonglong)param2_00[0x56] * 4))(param1,param2_00[0x57]);
		  iVar2 = *(int *)(iVar2 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(int *)(iVar2 + iVar4 * 4 + 0x10);
		      uVar3 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x24),*(undefined4 *)(param1_00 + 0x38),
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                        );
		      UI_Windows_Buildings_BaseBuildingItemView2__ActionButtonClickedEventHandler
		                (param1_00,uVar3,*(undefined4 *)(param1[2] + 8),*(undefined4 *)(param1[2] + 0x48),0)
		      ;
		      uVar3 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnActionButtonClickedEvent__,0);
		      UI_Windows_Buildings_BaseBuildingItemView2__set_BuildingTypeId(param1_00,uVar3,0);
		      uVar3 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnClickedEvent__,0)
		      ;
		      UI_Windows_Buildings_BaseBuildingItemView2__remove_ActionButtonClickedEvent(param1_00,uVar3,0)
		      ;
		      param1_01 = *(int **)(param1[2] + 0x20);
		      if (param1_01 == (int *)0x0) {
		        param2_00 = (uint *)0x0;
		      }
		      else {
		        iVar5 = *param1_01;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		            if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo == *piVar6) {
		              param2_00 = (uint *)(iVar5 + piVar6[1] * 8 + 0xc0);
		              goto code_r0x80ef7a3b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        param2_00 = (uint *)func_ii_1080(param1_01,
		                                         Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80ef7a3b:
		        (**(code **)((ulonglong)*param2_00 * 4))(param1_01,param1_00,param2_00[1]);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar2 + 0xc));
		  }
		  Gameplay_Tree_Control_TreeViewMediator2__BuildingStateChangedEvent(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x6D3C", Offset = "0x6D3C", VA = "0x6D3C")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Tree_Control_TreeViewMediator2__SetupView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a584bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_TreeWindow2___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BattlesWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12574);
		    DAT_ram_00a584bd = '\x01';
		  }
		  piVar5 = *(int **)(*(int *)(param1 + 8) + 0x28);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80ef7b2b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ef7b2b:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(in_register_20000014,puVar2[1]));
		  uVar7 = *(undefined8 *)(*(int *)(param1 + 8) + 0x10);
		  piVar5 = (int *)Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel
		                            (*(undefined4 *)(iVar6 + 0x14),uVar7,0);
		  uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar3 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  uVar7 = CONCAT44(uVar4,uVar3);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x118) * 4))
		                    (piVar5,uVar7,*(undefined4 *)(*piVar5 + 0x11c));
		  if (iVar6 == 0) {
		    uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar6 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		    if (iVar6 == 2) {
		      uVar1 = 0;
		      piVar5 = *(int **)(*(int *)(param1 + 8) + 0x28);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		            goto code_r0x80ef7bf0;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ef7bf0:
		      uVar7 = CONCAT44(uVar4,puVar2[1]);
		      piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar7);
		      uVar4 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar1 = 0;
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		            goto code_r0x80ef7c72;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x80ef7c72:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar4,puVar2[1]));
		      uVar3 = unnamed_function_1417(Gameplay_Battles_View_BattlesWindow_BattlesWindowArgs_TypeInfo);
		      Gameplay_AccountLinker_View_SelectUserWindow___ctor(uVar3,0);
		      Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                (uVar4,StringLiteral_12574,uVar3,
		                 Method_UI_Windows_PopupController_Show_BattlesWindow___);
		    }
		    uVar4 = System_Uri___ctor(0);
		    uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar4,0);
		    DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar4,0,Method_UI_Windows_PopupController_Close_TreeWindow2___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x6D3D", Offset = "0x6D3D", VA = "0x6D3D")]
		private void ItemOnClickedEvent(BaseBuildingData buildingData)
		{
		/* --- GHIDRA: ItemOnClickedEvent ---
		void Gameplay_Tree_Control_TreeViewMediator2__ItemOnClickedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int param2_00;
		  int iVar2;
		  float fVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  double param3_00;
		  int *piVar7;
		  int iVar8;
		  double param4;
		  uint uVar9;
		  
		  if (DAT_ram_00a584be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tree_Control_TreeViewMediator2___c__DisplayClass10_0__ItemOnActionButtonClickedEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tree_Control_TreeViewMediator2___c__DisplayClass10_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a584be = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Tree_Control_TreeViewMediator2___c__DisplayClass10_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  iVar2 = func_ii_8742(param2,0);
		  if (iVar2 == 0) {
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		    uVar6 = UnityEngine_AndroidJavaObject___GetRawObject(*(undefined4 *)(param2_00 + 0xc),0);
		    Gameplay_Isles_User_Controller_UserIsleController__OnDiamondIsleFound(uVar5,uVar6,0);
		    return;
		  }
		  iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                    (*(undefined4 *)(param2_00 + 0xc),0);
		  fVar3 = func_ii_7103(*(undefined4 *)(*(int *)(param2_00 + 0xc) + 0x14),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80ef7dea;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ef7dea:
		  uVar1 = CONCAT44(in_register_20000014,puVar4[1]);
		  uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  param3_00 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar6,StringLiteral_25458,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 3;
		  if (iVar2 == 0) {
		    uVar6 = 2;
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x80ef7eb3;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ef7eb3:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,CONCAT44(uVar5,puVar4[1]));
		  iVar2 = func_ii_7112(uVar5,0);
		  param4 = *(double *)(*(int *)(iVar2 + 0x78) + 0x18);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param2_00,
		             Method_Gameplay_Tree_Control_TreeViewMediator2___c__DisplayClass10_0__ItemOnActionButtonClickedEvent_b__0__
		             ,0);
		  UI_Windows_Alert_AlertArgs___ctor(uVar6,(double)fVar3,param3_00,param4,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x6D3E", Offset = "0x6D3E", VA = "0x6D3E")]
		private void ItemOnActionButtonClickedEvent(BaseBuildingData userBuildingData)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Tree_Control_TreeViewMediator2__set_Events(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a584b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__TreeView2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView2_UserIsle__GetBuildingView__);
		    DAT_ram_00a584b8 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = UI_Windows_Buildings_MainBuildingView2___Il2CppFullySharedGenericType____ctor
		                    (uVar1,param2,
		                     Method_UI_Windows_Buildings_MainBuildingView2_UserIsle__GetBuildingView__);
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    param2_00 = System_Collections_Generic_List_object___get_Item
		                          (*(undefined4 *)(param1[2] + 0x24),param2,
		                           Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                          );
		    UI_Windows_Buildings_BaseBuildingItemView2__ActionButtonClickedEventHandler
		              (uVar1,param2_00,*(undefined4 *)(param1[2] + 8),*(undefined4 *)(param1[2] + 0x48),0);
		  }
		  if (param2 == 1) {
		    Gameplay_Tree_Control_TreeViewMediator2__BuildingStateChangedEvent(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Tree_Control_TreeViewMediator2__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a584bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_MainBuildingView2_UserIsle__get_BuildingItems__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnActionButtonClickedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnClickedEvent__);
		    DAT_ram_00a584bb = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(iVar1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(iVar1 + iVar3 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnActionButtonClickedEvent__,0);
		      UI_Windows_Buildings_BaseBuildingItemView2__add_ActionButtonClickedEvent(param1_00,uVar2,0);
		      uVar2 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,Method_Gameplay_Tree_Control_TreeViewMediator2_ItemOnClickedEvent__,0)
		      ;
		      UI_Windows_Buildings_BaseBuildingItemView2__add_ClickedEvent(param1_00,uVar2,0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

}
