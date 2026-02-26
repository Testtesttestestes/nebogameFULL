using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View.Bag;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	public abstract class InventoryChestWindow : ClosableBaseWindow<InventoryChestWindowOptions>
	{
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A6")]
		public ChestSlotsInfoView ChestSlotsInfoView
		{
			[Token(Token = "0x600285B")]
			[Address(RVA = "0x797B", Offset = "0x797B", VA = "0x797B")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000156 RID: 342
		// (add) Token: 0x0600285C RID: 10332 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600285D RID: 10333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000156")]
		public event Action ChestClosedEvent
		{
			[Token(Token = "0x600285C")]
			[Address(RVA = "0x797C", Offset = "0x797C", VA = "0x797C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600285D")]
			[Address(RVA = "0x797D", Offset = "0x797D", VA = "0x797D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A7")]
		public TabBar TabBarView
		{
			[Token(Token = "0x600285E")]
			[Address(RVA = "0x797E", Offset = "0x797E", VA = "0x797E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A8")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x600285F")]
			[Address(RVA = "0x797F", Offset = "0x797F", VA = "0x797F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A9")]
		public InventoryBagView UserBag
		{
			[Token(Token = "0x6002860")]
			[Address(RVA = "0x7980", Offset = "0x7980", VA = "0x7980")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AA")]
		public InventoryGridView InventoryGridView
		{
			[Token(Token = "0x6002861")]
			[Address(RVA = "0x7981", Offset = "0x7981", VA = "0x7981")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x7982", Offset = "0x7982", VA = "0x7982", Slot = "22")]
		protected override void OnShow(InventoryChestWindowOptions args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Inventory_View_Chest_InventoryChestWindow__OnShow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a0ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_ArtikulMenuActionDic_Types_Actions___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_InventoryChestWindowOptions__get_WindowArgs__);
		    DAT_ram_00a5a0ed = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_InventoryChestWindowOptions__get_WindowArgs__);
		  iVar1 = System_Array__IndexOf_int_
		                    (*(undefined4 *)(iVar1 + 0x1c),param2,
		                     Method_System_Array_IndexOf_ArtikulMenuActionDic_Types_Actions___);
		  if (-1 < iVar1) {
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x7983", Offset = "0x7983", VA = "0x7983")]
		private void ArtifactContextMenuOnActionHandledEvent(ArtikulMenuActionDic.Types.Actions action)
		{
		/* --- GHIDRA: ArtifactContextMenuOnActionHandledEvent ---
		void Gameplay_Inventory_View_Chest_InventoryChestWindow__ArtifactContextMenuOnActionHandledEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a0ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_InventoryChestWindowOptions__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__OnClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Chest_InventoryChestWindow_ArtifactContextMenuOnActionHandledEvent__
		              );
		    DAT_ram_00a5a0ee = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_InventoryChestWindowOptions__get_WindowArgs__);
		  if (*(int *)(iVar1 + 0x1c) != 0) {
		    uVar2 = unnamed_function_1417(System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Inventory_View_Chest_InventoryChestWindow_ArtifactContextMenuOnActionHandledEvent__
		               ,0);
		    Gameplay_Inventory_View_ContextMenu_ArtifactContextMenu__add_ActionHandledEvent(uVar2,param1);
		    uVar2 = unnamed_function_1417(System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Inventory_View_Chest_InventoryChestWindow_ArtifactContextMenuOnActionHandledEvent__
		               ,0);
		    Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView__add_ActionHandledEvent(uVar2,0);
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__OnClose__);
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x7984", Offset = "0x7984", VA = "0x7984", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x7985", Offset = "0x7985", VA = "0x7985")]
		protected InventoryChestWindow()
		{
		}

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected TabBar _tabBarView;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected InventoryBagView _userBag;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected InventoryGridView _inventoryGridView;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected FiltersView _filtersView;

		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected ChestSlotsInfoView _chestSlotsInfoView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ChestSlotsInfoView ---
		void Gameplay_Inventory_View_Chest_InventoryChestWindow__get_ChestSlotsInfoView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a0ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a0ea = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ChestClosedEvent ---
		void Gameplay_Inventory_View_Chest_InventoryChestWindow__add_ChestClosedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a0eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a0eb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_InventoryGridView ---
		void Gameplay_Inventory_View_Chest_InventoryChestWindow__get_InventoryGridView
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a0ec == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_InventoryChestWindowOptions__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_View_Chest_InventoryChestWindow_ArtifactContextMenuOnActionHandledEvent__
		              );
		    DAT_ram_00a5a0ec = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_InventoryChestWindowOptions__OnShow__);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_InventoryChestWindowOptions__get_WindowArgs__);
		  if (*(int *)(iVar1 + 0x1c) != 0) {
		    uVar2 = unnamed_function_1417(System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Inventory_View_Chest_InventoryChestWindow_ArtifactContextMenuOnActionHandledEvent__
		               ,0);
		    Gameplay_Inventory_View_Info_InfoBox_TitleRowView___ctor(uVar2,param1);
		    uVar2 = unnamed_function_1417(System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    System_Action_int___Invoke
		              (uVar2,param1,
		               Method_Gameplay_Inventory_View_Chest_InventoryChestWindow_ArtifactContextMenuOnActionHandledEvent__
		               ,0);
		    Gameplay_Inventory_View_SplitArtifactView___ctor(uVar2,0);
		  }
		  return;
		}
		*/

}
