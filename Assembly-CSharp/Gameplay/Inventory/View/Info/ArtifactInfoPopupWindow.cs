using System;
using AssetContent.Loaders;
using Core.Data;
using Core.Gameplay.Managers.Inventory;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Main;
using TMPro;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	public class ArtifactInfoPopupWindow : ClosableBaseWindow<ArtifactInfoPopupWindowArgs>
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700078B")]
		public override string WindowId
		{
			[Token(Token = "0x60027D8")]
			[Address(RVA = "0x78FE", Offset = "0x78FE", VA = "0x78FE", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x78FF", Offset = "0x78FF", VA = "0x78FF", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__Awake
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a5a0be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_ArtifactChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_InventoryChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_OnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo);
		    DAT_ram_00a5a0be = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs__OnShow__);
		  piVar5 = *(int **)(param2 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811c433f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811c433f:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar6 = piVar5[0x1c];
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x230);
		        goto code_r0x811c43f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811c43f0:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  if (*(int *)(*(int *)(iVar8 + 0x10) + 0x20) == iVar6) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x238);
		          goto code_r0x811c4548;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2f);
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		          goto code_r0x811c4548;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xc);
		  }
		code_r0x811c4548:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  *(undefined4 *)(param1 + 0x60) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x811c45f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811c45f7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  *(undefined4 *)(param1 + 100) = uVar3;
		  Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__HandleArtifactChanged(param1,piVar5,puVar2);
		  uVar9 = *(undefined4 *)(param1 + 0x58);
		  uVar3 = Core_Extensions_Dict_ArtikulDicExt__GetMiddleBgSubstrateAssetId
		                    (*(undefined4 *)(piVar5[2] + 0x10),0);
		  uVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar9,uVar1 ^ 1,0);
		  piVar7 = *(int **)(param1 + 0x40);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		  uVar3 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar3,0);
		  iVar8 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		            (piVar7,uVar3,*(undefined4 *)(iVar8 + 0x2d4));
		  iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x54),0);
		  if (iVar6 != 0) {
		    Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__get_ArtifactView
		              (*(undefined4 *)(param1 + 0x54),*(undefined4 *)(param1 + 0x48),iVar8);
		  }
		  piVar7 = *(int **)(param1 + 0x60);
		  iVar6 = *piVar7;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x811c4706;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo,1
		                               );
		code_r0x811c4706:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  uVar9 = *(undefined4 *)(iVar8 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_InventoryChangedEvent__,0);
		  piVar7 = (int *)UnityEngine_UI_Image__set_sprite(uVar9,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(iVar8 + 0x14) = 0;
		  }
		  else if ((*piVar7 != System_Action_TypeInfo) ||
		          (*(int **)(iVar8 + 0x14) = piVar7, *piVar7 != iVar6)) {
		    System_Activator__CreateInstance(piVar7,iVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = unnamed_function_1417(iVar6);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_ArtifactChangedEventHandler__
		             ,0);
		  Core_Data_ArtifactData__remove_IsFreshWatchedChangedEvent(piVar5,uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x150);
		        goto code_r0x811c483e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811c483e:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar8 = **(int **)(iVar6 + 0x10);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar6 + 0x10),*(undefined4 *)(iVar8 + 0x114));
		  uVar9 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_OnArtifactDropRemoveEvent__
		             ,0);
		  iVar8 = UnityEngine_UI_Image__set_sprite(uVar9,uVar3,0);
		  uVar3 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar6 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar8,System_Action_DropTypes__ArtifactData__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar6 + 0x1c) = iVar4;
		    uVar3 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar6 = func_ii_1082(iVar8,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar6 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar8,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar8,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x7900", Offset = "0x7900", VA = "0x7900", Slot = "22")]
		protected override void OnShow(ArtifactInfoPopupWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  undefined8 param2_00;
		  int *param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a5a0bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo);
		    DAT_ram_00a5a0bf = '\x01';
		  }
		  param1_02 = *(int **)(param1 + 0x60);
		  iVar4 = *param1_02;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811c53ba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,
		                                Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo,0);
		code_r0x811c53ba:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))
		                        (param1_02,CONCAT44(in_register_20000014,puVar2[1]));
		  iVar4 = **(int **)(param1 + 0x48);
		  param1_01 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x130) * 4))
		                        (*(int **)(param1 + 0x48),*(undefined4 *)(iVar4 + 0x134));
		  param2_00 = func_ii_7957(param1_01,0);
		  iVar4 = func_ii_8078(param1_00,param2_00,0);
		  if (iVar4 == 0) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,0,0);
		    return;
		  }
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x54),0);
		  if (iVar3 != 0) {
		    Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__get_ArtifactView
		              (*(undefined4 *)(param1 + 0x54),*(undefined4 *)(param1 + 0x48),iVar4);
		  }
		  Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__HandleArtifactChanged(param1,iVar4,iVar4);
		  return;
		}
		*/

		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x7901", Offset = "0x7901", VA = "0x7901")]
		protected void InventoryChangedEvent()
		{
		/* --- GHIDRA: InventoryChangedEvent ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__InventoryChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x48);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		                        (*(int **)(param1 + 0x48),*(undefined4 *)(iVar1 + 0x134));
		  Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__HandleArtifactChanged
		            (param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x7902", Offset = "0x7902", VA = "0x7902")]
		private void ArtifactChangedEventHandler()
		{
		/* --- GHIDRA: ArtifactChangedEventHandler ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__ArtifactChangedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x7903", Offset = "0x7903", VA = "0x7903")]
		protected void OnArtifactDropRemoveEvent(DropTypes dropTypes, ArtifactData artifactData)
		{
		/* --- GHIDRA: OnArtifactDropRemoveEvent ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__OnArtifactDropRemoveEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__HandleArtifactChanged(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x7904", Offset = "0x7904", VA = "0x7904")]
		private void HandleArtifactChanged(ArtifactData data)
		{
		/* --- GHIDRA: HandleArtifactChanged ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__HandleArtifactChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a0c0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Id__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ArtifactInfoPopupWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    DAT_ram_00a5a0c0 = '\x01';
		  }
		  Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__HandleDataChanged
		            (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x10),0);
		  iVar8 = **(int **)(param1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x138) * 4))
		            (*(int **)(param1 + 0x48),param2,*(undefined4 *)(iVar8 + 0x13c));
		  iVar5 = *(int *)(param1 + 0x48);
		  iVar8 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtifactInfoPopupWindowArgs__get_WindowArgs__);
		  piVar6 = *(int **)(iVar8 + 0x18);
		  iVar8 = *piVar6;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd8);
		        goto code_r0x811c49fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Gameplay_Inventory_View_IArtifactView_TypeInfo,3);
		code_r0x811c49fe:
		  (**(code **)((ulonglong)*puVar2 * 4))(&local_c,piVar6,puVar2[1]);
		  *(undefined4 *)(iVar5 + 0x58) = local_4;
		  *(undefined8 *)(iVar5 + 0x50) = local_c;
		  *(undefined1 *)(iVar5 + 0x45) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(iVar5,0);
		  piVar6 = *(int **)(param1 + 0x3c);
		  uVar3 = Core_Data_ArtikulData__get_IsSellable(param2,0);
		  iVar8 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar8 + 0x2d4));
		  uVar7 = *(undefined4 *)(param1 + 0x44);
		  uVar3 = Core_Data_ArtikulData__get_CurrentDurability(param2,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar7,uVar3,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  uVar3 = *(undefined4 *)(param2 + 0x70);
		  iVar8 = *(int *)(param1 + 0x4c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x811c4b1a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811c4b1a:
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar7 = func_ii_7112(uVar7,0);
		  iVar5 = unnamed_function_1417(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  Gameplay_Inventory_Model_ArtifactInfoProvider__Dispose(iVar5,uVar3,uVar7,param2,0);
		  if (iVar5 != *(int *)(iVar8 + 0x14)) {
		    *(int *)(iVar8 + 0x14) = iVar5;
		    iVar8 = *(int *)(iVar8 + 0x10);
		    if (*(int *)(iVar8 + 0x28) != iVar5) {
		      *(int *)(iVar8 + 0x28) = iVar5;
		      Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__set_Data(iVar8,iVar5);
		    }
		  }
		  iVar8 = *(int *)(param1 + 0x50);
		  iVar5 = *(int *)(iVar8 + 0x34);
		  if (iVar5 != param2) {
		    *(int *)(iVar8 + 0x34) = param2;
		    iVar4 = func_ii_12174(iVar8,0);
		    if (iVar4 != 0) {
		      if (iVar5 != 0) {
		        Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__StartListenEvents(iVar8,iVar5,iVar8)
		        ;
		      }
		      if (*(int *)(iVar8 + 0x34) != 0) {
		        Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__OnDisable
		                  (iVar8,*(int *)(iVar8 + 0x34),iVar8);
		      }
		      Gameplay_Inventory_View_Info_InfoBox_ArtifactNotesView__ArtifactDataOnIsFavoriteChangedEvent
		                (iVar8,iVar8);
		    }
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x5c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar6;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x811c4c6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811c4c6f:
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  piVar6 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		  local_10 = *(undefined4 *)(*(int *)(param2 + 8) + 0xc);
		  iVar8 = func_ii_1081(DAT_ram_00a66958,&local_10);
		  if ((iVar8 != 0) && (iVar5 = func_ii_1082(iVar8,*(undefined4 *)(*piVar6 + 0x20)), iVar5 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar6[4] = iVar8;
		  UI_MonoBehaviourWithStates_Int32Enum___set_CurrentState(uVar3,uVar7,piVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x7905", Offset = "0x7905", VA = "0x7905")]
		private void DrawArtifactInfo(ArtifactData artifactData)
		{
		/* --- GHIDRA: DrawArtifactInfo ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__DrawArtifactInfo
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a0c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_ArtifactChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_InventoryChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_OnArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo);
		    DAT_ram_00a5a0c1 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs__OnClose__);
		  piVar6 = *(int **)(param1 + 0x60);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x811c5594;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_Managers_Inventory_IInventoryManager_TypeInfo,1
		                               );
		code_r0x811c5594:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar3 + 0x14);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_InventoryChangedEvent__,0);
		  piVar6 = (int *)func_ii_7048(uVar8,uVar4,0);
		  iVar7 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar3 + 0x14) = piVar6, *piVar6 != iVar7)) {
		    System_Activator__CreateInstance(piVar6,iVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = **(int **)(param1 + 0x48);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x130) * 4))
		                    (*(int **)(param1 + 0x48),*(undefined4 *)(iVar7 + 0x134));
		  uVar8 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar8,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_ArtifactChangedEventHandler__
		             ,0);
		  Core_Data_ArtifactData__add_ArtifactInfoChangedEvent(uVar4,uVar8,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x811c56eb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811c56eb:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar3 = **(int **)(iVar7 + 0x10);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                    (*(int **)(iVar7 + 0x10),*(undefined4 *)(iVar3 + 0x114));
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar4 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar4,param1,
		             Method_Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow_OnArtifactDropRemoveEvent__
		             ,0);
		  iVar3 = func_ii_7048(uVar8,uVar4,0);
		  uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    return;
		  }
		  iVar5 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		  if (iVar5 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar5;
		    uVar4 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar7 = func_ii_1082(iVar3,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x7906", Offset = "0x7906", VA = "0x7906", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs___ctor__);
		    DAT_ram_00a5a0c2 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x7907", Offset = "0x7907", VA = "0x7907")]
		public ArtifactInfoPopupWindow()
		{
		}

		// Token: 0x040015D3 RID: 5587
		[Token(Token = "0x40015D3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtifactInfoPopupWindow";

		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x040015D5 RID: 5589
		[Token(Token = "0x40015D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ArtifactInfoPropertiesView _propertiesView;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactNotesView _notesView;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ArtifactInfoActionButtonsView _actionButtonsView;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _descriptionGroup;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x60")]
		private IInventoryManager _inventoryManager;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x64")]
		private UserData _user;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs__Awake__);
		    DAT_ram_00a5a0bd = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,Method_UI_Windows_ClosableBaseWindow_ArtifactInfoPopupWindowArgs__Awake__);
		  *(undefined4 *)(*(int *)(param1 + 0x48) + 0x24) = 2;
		  return;
		}
		*/

}
