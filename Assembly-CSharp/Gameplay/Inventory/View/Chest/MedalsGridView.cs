using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000697 RID: 1687
	[Token(Token = "0x2000697")]
	public class MedalsGridView : MonoBehaviour
	{
		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B5")]
		public UserData User
		{
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x79D9", Offset = "0x79D9", VA = "0x79D9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x79DA", Offset = "0x79DA", VA = "0x79DA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B6")]
		public UserData LoggedUser
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x79DB", Offset = "0x79DB", VA = "0x79DB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028BE")]
			[Address(RVA = "0x79DC", Offset = "0x79DC", VA = "0x79DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x79DD", Offset = "0x79DD", VA = "0x79DD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a120 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Chest_MedalsGridView_TabBarOnChangeEvent__);
		    DAT_ram_00a5a120 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Inventory_View_Chest_MedalsGridView_TabBarOnChangeEvent__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x79DE", Offset = "0x79DE", VA = "0x79DE")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__Start(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a5a121 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_View_MedalsCategoryTabBarItemData_TypeInfo);
		    DAT_ram_00a5a121 = '\x01';
		  }
		  piVar1 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(param1 + 0x10),0);
		  if (piVar1 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_Medals_View_MedalsCategoryTabBarItemData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar1 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar1 + 100) +
		                 (uint)*(byte *)(Gameplay_Medals_View_MedalsCategoryTabBarItemData_TypeInfo + 0xb8)
		                 * 4 + -4) == Gameplay_Medals_View_MedalsCategoryTabBarItemData_TypeInfo)) {
		      Gameplay_Inventory_View_Chest_MedalsGridView__RenderCategories(param1,piVar1[8],param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0x79DF", Offset = "0x79DF", VA = "0x79DF")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__TabBarOnChangeEvent
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar2;
		  
		  *(undefined4 *)(param1 + 0x18) = param2;
		  iVar2 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x3bc));
		  iVar2 = *(int *)(param1 + 0x24);
		  iVar1 = *(int *)(param1 + 0x20);
		  param3_00 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = *(int **)(param1 + 0x14);
		  if (DAT_ram_00a5a11b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__get_Count__);
		    DAT_ram_00a5a11b = '\x01';
		  }
		  *(undefined1 *)(param1_00 + 0x34) = (undefined1)param4;
		  param1_00[0x33] = param3;
		  param1_00[0x31] = iVar2;
		  param1_00[0x32] = iVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x2e8) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x2ec));
		  Gameplay_Inventory_View_Chest_MedalsGridOsaView__SetData
		            (param1_00,*(undefined4 *)(param1_00[4] + 0x58),param3_00,param1_00 + 0x2c,
		             param1_00 + 0x2d,param1_00);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x340) * 4))
		            (param1_00,*(undefined4 *)(param1_00[0x2c] + 0xc),0,1,
		             *(undefined4 *)(*param1_00 + 0x344));
		  if (0 < *(int *)(param1_00[0x2c] + 0xc)) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x390) * 4))
		              (param1_00,0,0,0,*(undefined4 *)(*param1_00 + 0x394));
		  }
		  Gameplay_Inventory_View_Chest_MedalsGridView__SetData(param1,param1_00);
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(param1 + 0x10),0,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x79E0", Offset = "0x79E0", VA = "0x79E0")]
		public void SetData(List<MedalsCategoryData> data, Action<MedalView> medalViewClickCallback, bool saleEnabled)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__SetData(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5a122 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryTabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryTabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_MedalsCategoryTabBarItemData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_View_MedalsCategoryTabBarItemData_TypeInfo);
		    DAT_ram_00a5a122 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_MedalsCategoryTabBarItemData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_MedalsCategoryTabBarItemData___ctor__)
		  ;
		  iVar1 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,param2_01,
		                         Method_System_Collections_Generic_List_MedalsCategoryData__get_Item__);
		      param2_00 = unnamed_function_1417(Gameplay_Medals_View_MedalsCategoryTabBarItemData_TypeInfo);
		      *(int *)(param2_00 + 0x14) = param2_01;
		      uVar2 = *(undefined4 *)(iVar1 + 8);
		      *(int *)(param2_00 + 0x20) = iVar1;
		      *(undefined4 *)(param2_00 + 0x10) = uVar2;
		      iVar1 = Method_System_Collections_Generic_List_MedalsCategoryTabBarItemData__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar3 = *(uint *)(param1_00 + 0xc);
		      if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      param2_01 = param2_01 + 1;
		      iVar1 = *(int *)(param1 + 0x18);
		    } while (param2_01 < *(int *)(iVar1 + 0xc));
		  }
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(param1 + 0x10),param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x79E1", Offset = "0x79E1", VA = "0x79E1")]
		private void RenderCategories()
		{
		/* --- GHIDRA: RenderCategories ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__RenderCategories
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a123 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__IndexOf__);
		    DAT_ram_00a5a123 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = piVar3[0x2c];
		  param1_00 = *(int **)(param2 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_MedalData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811cf031;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_MedalData__TypeInfo,0);
		code_r0x811cf031:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  iVar4 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (iVar4,param2_00,Method_System_Collections_Generic_List_MedalData__IndexOf__);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x398) * 4))
		            (piVar3,iVar4 + -1,0x3e99999a,0,0,0,0,0,*(undefined4 *)(*piVar3 + 0x39c));
		  return;
		}
		*/

		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x79E2", Offset = "0x79E2", VA = "0x79E2")]
		private void ScrollToCategory(MedalsCategoryData cat)
		{
		/* --- GHIDRA: ScrollToCategory ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__ScrollToCategory(int param1,undefined4 param2)
		
		{
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(param1 + 0x10),0,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x79E3", Offset = "0x79E3", VA = "0x79E3")]
		public void SelectDefaultTab()
		{
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x79E4", Offset = "0x79E4", VA = "0x79E4")]
		public MedalsGridView()
		{
		}

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04001680 RID: 5760
		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MedalsGridOsaView _medalsGridOsaView;

		// Token: 0x04001681 RID: 5761
		[Token(Token = "0x4001681")]
		[FieldOffset(Offset = "0x18")]
		private List<MedalsCategoryData> _categories;

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[FieldOffset(Offset = "0x1C")]
		private TabBarItemData _currentTab;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_LoggedUser ---
		void Gameplay_Inventory_View_Chest_MedalsGridView__set_LoggedUser(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

}
