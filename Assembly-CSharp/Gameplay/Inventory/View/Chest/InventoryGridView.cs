using System;
using System.Collections.Generic;
using Gameplay.Inventory.Model.Tabs;
using Il2CppDummyDll;
using UI.ContextMenu;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068F RID: 1679
	[Token(Token = "0x200068F")]
	public class InventoryGridView : MonoBehaviour
	{
		// Token: 0x170007AE RID: 1966
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AE")]
		public ArtifactView.ArtifactViewArgs ArtifactViewArgs
		{
			[Token(Token = "0x600288B")]
			[Address(RVA = "0x79AA", Offset = "0x79AA", VA = "0x79AA")]
			set
			{
			}
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x79AB", Offset = "0x79AB", VA = "0x79AB")]
		private void ContextMenuControllerOnContextMenuShowEvent(IBaseContextMenu obj)
		{
		/* --- GHIDRA: ContextMenuControllerOnContextMenuShowEvent ---
		void Gameplay_Inventory_View_Chest_InventoryGridView__ContextMenuControllerOnContextMenuShowEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a106 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Chest_InventoryGridView_TabBarOnChangeEvent__);
		    DAT_ram_00a5a106 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Inventory_View_Chest_InventoryGridView_TabBarOnChangeEvent__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x79AC", Offset = "0x79AC", VA = "0x79AC")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Chest_InventoryGridView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a107 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Chest_InventoryGridView_TabBarOnChangeEvent__);
		    DAT_ram_00a5a107 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Inventory_View_Chest_InventoryGridView_TabBarOnChangeEvent__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x79AD", Offset = "0x79AD", VA = "0x79AD")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_Chest_InventoryGridView__Start(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *param3;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a108 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Inventory_InventorySubcategoriesTabBarItemData_TypeInfo);
		    DAT_ram_00a5a108 = '\x01';
		  }
		  piVar2 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(param1 + 0x10),0);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(UI_Inventory_InventorySubcategoriesTabBarItemData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar2 + 100) +
		                 (uint)*(byte *)(UI_Inventory_InventorySubcategoriesTabBarItemData_TypeInfo + 0xb8)
		                 * 4 + -4) == UI_Inventory_InventorySubcategoriesTabBarItemData_TypeInfo)) {
		      uVar1 = 0;
		      param1_00 = *(int **)(piVar2[8] + 0x10);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            param3 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811cda7e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      param3 = (uint *)func_ii_1080(param1_00,
		                                    System_Collections_Generic_ICollection_ArtifactData__TypeInfo,0)
		      ;
		code_r0x811cda7e:
		      iVar3 = (**(code **)((ulonglong)*param3 * 4))(param1_00,param3[1]);
		      if (0 < iVar3) {
		        Gameplay_Inventory_View_Chest_InventoryGridView__RenderCategories(param1,piVar2[8],param3);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x79AE", Offset = "0x79AE", VA = "0x79AE")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		void Gameplay_Inventory_View_Chest_InventoryGridView__TabBarOnChangeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Gameplay_Inventory_View_Chest_InventoryGridOsaView__UpdateCellViewsHolder
		            (*(undefined4 *)(param1 + 0x14),param2,param1);
		  Gameplay_Inventory_View_Chest_InventoryGridView__SetData(param1,param1);
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(param1 + 0x10),0,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x79AF", Offset = "0x79AF", VA = "0x79AF")]
		public void SetData(List<ArtifactCategoryData> data)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Inventory_View_Chest_InventoryGridView__SetData(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param1_01;
		  int iVar1;
		  uint uVar2;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5a109 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Inventory_InventorySubcategoriesTabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventorySubcategoriesTabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_InventorySubcategoriesTabBarItemData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_InventorySubcategoriesTabBarItemData__TypeInfo);
		    DAT_ram_00a5a109 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_InventorySubcategoriesTabBarItemData__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_InventorySubcategoriesTabBarItemData___ctor__);
		  iVar1 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,param2_00,
		                         Method_System_Collections_Generic_List_ArtifactCategoryData__get_Item__);
		      param1_01 = unnamed_function_1417(UI_Inventory_InventorySubcategoriesTabBarItemData_TypeInfo);
		      Unity_Services_Core_Registration_CorePackageInitializer__get_DiagnosticsFactory
		                (param1_01,iVar1,0);
		      *(int *)(param1_01 + 0x14) = param2_00;
		      *(undefined4 *)(param1_01 + 0x10) = *(undefined4 *)(iVar1 + 0xc);
		      iVar1 = Method_System_Collections_Generic_List_InventorySubcategoriesTabBarItemData__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar2 = *(uint *)(param1_00 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1_01;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param1_01,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x18);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(param1 + 0x10),param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x79B0", Offset = "0x79B0", VA = "0x79B0")]
		private void RenderCategories()
		{
		/* --- GHIDRA: RenderCategories ---
		void Gameplay_Inventory_View_Chest_InventoryGridView__RenderCategories
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a10a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__IndexOf__);
		    DAT_ram_00a5a10a = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = piVar3[0x2c];
		  param1_00 = *(int **)(param2 + 0x10);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_ArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811cdb4d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_ArtifactData__TypeInfo,0)
		  ;
		code_r0x811cdb4d:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  iVar4 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (iVar4,param2_00,Method_System_Collections_Generic_List_ArtifactData__IndexOf__)
		  ;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x398) * 4))
		            (piVar3,iVar4 + -1,0x3e99999a,0,0,0,0,0,*(undefined4 *)(*piVar3 + 0x39c));
		  return;
		}
		*/

		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002892")]
		[Address(RVA = "0x79B1", Offset = "0x79B1", VA = "0x79B1")]
		private void ScrollToCategory(ArtifactCategoryData cat)
		{
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x79B2", Offset = "0x79B2", VA = "0x79B2")]
		public void SelectDefaultTab()
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x79B3", Offset = "0x79B3", VA = "0x79B3")]
		public InventoryGridView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Inventory_View_Chest_InventoryGridView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a10b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12643);
		    DAT_ram_00a5a10b = '\x01';
		  }
		  return StringLiteral_12643;
		}
		*/

		}

		// Token: 0x04001663 RID: 5731
		[Token(Token = "0x4001663")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04001664 RID: 5732
		[Token(Token = "0x4001664")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private InventoryGridOsaView _inventoryGridOsaView;

		// Token: 0x04001665 RID: 5733
		[Token(Token = "0x4001665")]
		[FieldOffset(Offset = "0x18")]
		private List<ArtifactCategoryData> _categories;

		// Token: 0x04001666 RID: 5734
		[Token(Token = "0x4001666")]
		[FieldOffset(Offset = "0x1C")]
		private InventoryTabData _currentTab;
	}
}
