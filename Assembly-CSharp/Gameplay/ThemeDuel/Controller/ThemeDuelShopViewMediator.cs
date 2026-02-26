using System;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.ShopTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	public class ThemeDuelShopViewMediator : AbstractViewMediator<ThemeDuelModel, ThemeDuelEvents, ThemeDuelShopController, ShopView>, IHideableMediator
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x6FC6", Offset = "0x6FC6", VA = "0x6FC6")]
		public ThemeDuelShopViewMediator(ThemeDuelModel model, ThemeDuelEvents events, ThemeDuelShopController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58600 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelShopController__ShopView__set_Controller__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_BuyShopItem__);
		    DAT_ram_00a58600 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar5 = **(undefined4 **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar3 = unnamed_function_1417(System_Action_IArtifactView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,uVar2,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_BuyShopItem__,0);
		    iVar1 = func_ii_7048(uVar5,uVar3,0);
		    uVar2 = System_Action_IArtifactView__TypeInfo;
		    if (iVar1 == 0) {
		      **(undefined4 **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar1,System_Action_IArtifactView__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      **(int **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) = iVar4;
		      uVar2 = System_Action_IArtifactView__TypeInfo;
		      iVar4 = func_ii_1082(iVar1,System_Action_IArtifactView__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[4] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (iVar1 != 0) {
		    uVar5 = **(undefined4 **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar3 = unnamed_function_1417(System_Action_IArtifactView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,uVar2,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopController_BuyShopItem__,0);
		    iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    uVar2 = System_Action_IArtifactView__TypeInfo;
		    if (iVar1 == 0) {
		      **(undefined4 **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar1,System_Action_IArtifactView__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    **(int **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) = iVar4;
		    uVar2 = System_Action_IArtifactView__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_IArtifactView__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700057D RID: 1405
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		public override ThemeDuelShopController Controller
		{
			[Token(Token = "0x6001E49")]
			[Address(RVA = "0x6FC7", Offset = "0x6FC7", VA = "0x6FC7", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057E")]
		public override ShopView View
		{
			[Token(Token = "0x6001E4A")]
			[Address(RVA = "0x6FC8", Offset = "0x6FC8", VA = "0x6FC8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x6FC9", Offset = "0x6FC9", VA = "0x6FC9", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__Hide(int *param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58603 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_GetStoreItemsInfoEvent__
		              );
		    DAT_ram_00a58603 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_GetStoreItemsInfoEvent__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,uVar2,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 0x14) = param1_00, *param1_00 != param2_00)) {
		    System_Activator__CreateInstance(param1_00,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_ThemeDuel_Controller_ThemeDuelShopController__set_StoreItemsInfo(uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x6FCA", Offset = "0x6FCA", VA = "0x6FCA")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  float fVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58604 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelShopController__ShopView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_GetStoreItemsInfoEvent__
		              );
		    DAT_ram_00a58604 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  uVar5 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_GetStoreItemsInfoEvent__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar3 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 0x14) = param1_00, *param1_00 != iVar3)) {
		    System_Activator__CreateInstance(param1_00,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (*(int *)(iVar3 + 0x20) == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = *(undefined4 *)(*(int *)(iVar3 + 0x20) + 0xc);
		  }
		  Gameplay_ThemeDuel_View_ShopTab_ShopView__StopCurrentCoroutine(uVar2,uVar5,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(param1[2] + 0x14);
		  fVar4 = func_ii_7103(*(undefined4 *)(iVar1 + 0x34),0);
		  if (0.0 < fVar4) {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  else {
		    uVar2 = 0;
		  }
		  uVar2 = Core_Extensions_Dict_ThemeDuelDicExt__GetIconAssetId(uVar2,0);
		  if (DAT_ram_00a585c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a585c1 = '\x01';
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (*(undefined4 *)(iVar3 + 0x1c),uVar2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(param1[2] + 0x14);
		  *(int *)(iVar3 + 0x28) = iVar1;
		  if (*(int *)(iVar3 + 0x2c) != 0) {
		    func_ii_7950(*(int *)(iVar3 + 0x2c),0);
		    *(undefined4 *)(iVar3 + 0x2c) = 0;
		    iVar1 = *(int *)(iVar3 + 0x28);
		  }
		  if (iVar1 != 0) {
		    if (DAT_ram_00a585c3 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime_d__14_TypeInfo);
		      DAT_ram_00a585c3 = '\x01';
		    }
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_ThemeDuel_View_ShopTab_ShopView__DisplayCurrentBackTime_d__14_TypeInfo
		                      );
		    *(int *)(iVar1 + 0x10) = iVar3;
		    *(undefined4 *)(iVar1 + 8) = 0;
		    uVar2 = Utils_CoroutineSource__GetMono(iVar1,0);
		    *(undefined4 *)(iVar3 + 0x2c) = uVar2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x6FCB", Offset = "0x6FCB", VA = "0x6FCB")]
		private void GetStoreItemsInfoEvent()
		{
		/* --- GHIDRA: GetStoreItemsInfoEvent ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__GetStoreItemsInfoEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58605 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_IHideableMediator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_ShowRatingTab__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_ShowRulesTab__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_ShowShopTab__);
		    DAT_ram_00a58605 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelController__ThemeDuelWindow___ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator____ctor__
		            );
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_ShowRulesTab__,0);
		  func_ii_10812(param1_00,1,uVar1,
		                Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___Add__
		               );
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_ShowRatingTab__,0);
		  func_ii_10812(param1_00,2,uVar1,
		                Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___Add__
		               );
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_ThemeDuel_Controller_ThemeDuelViewMediator_ShowShopTab__,0);
		  func_ii_10812(param1_00,3,uVar1,
		                Method_System_Collections_Generic_Dictionary_ThemeDuelTargets__Func_IHideableMediator___Add__
		               );
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Controller ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__set_Controller
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58601 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelModel__ThemeDuelEvents__ThemeDuelShopController__ShopView__set_View__
		              );
		    DAT_ram_00a58601 = '\x01';
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__Hide(param1,param1);
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


		/* --- GHIDRA: set_View ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58602 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_GetStoreItemsInfoEvent__
		              );
		    DAT_ram_00a58602 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelShopViewMediator_GetStoreItemsInfoEvent__
		             ,0);
		  param1_00 = (int *)func_ii_7048(param1_01,uVar2,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(iVar1 + 0x14) = param1_00, *param1_00 != param2_00)) {
		    System_Activator__CreateInstance(param1_00,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

}
