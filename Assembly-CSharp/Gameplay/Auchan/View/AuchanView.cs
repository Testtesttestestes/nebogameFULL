using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	public class AuchanView : MonoBehaviour
	{
		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD8")]
		public SearchInput SearchInput
		{
			[Token(Token = "0x6004E42")]
			[Address(RVA = "0x9C74", Offset = "0x9C74", VA = "0x9C74")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06004E43 RID: 20035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD9")]
		public GreenToggle Toggle
		{
			[Token(Token = "0x6004E43")]
			[Address(RVA = "0x9C75", Offset = "0x9C75", VA = "0x9C75")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06004E44 RID: 20036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FDA")]
		public AuchanSortingFilter SortingFilter
		{
			[Token(Token = "0x6004E44")]
			[Address(RVA = "0x9C76", Offset = "0x9C76", VA = "0x9C76")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x9C77", Offset = "0x9C77", VA = "0x9C77")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Auchan_View_AuchanView__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59856 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Auchan_View_AuchanView_TabBarOnChangeEvent__);
		    DAT_ram_00a59856 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Auchan_View_AuchanView_TabBarOnChangeEvent__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x9C78", Offset = "0x9C78", VA = "0x9C78")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Auchan_View_AuchanView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a59857 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData_TypeInfo);
		    DAT_ram_00a59857 = '\x01';
		  }
		  piVar1 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(param1 + 0x10),0);
		  if (piVar1 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar1 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar1 + 100) +
		                 (uint)*(byte *)(Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData_TypeInfo +
		                                0xb8) * 4 + -4) ==
		        Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData_TypeInfo)) {
		      Gameplay_Auchan_View_AuchanView__RenderCategories(param1,piVar1[8],param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x9C79", Offset = "0x9C79", VA = "0x9C79")]
		private void TabBarOnChangeEvent()
		{
		/* --- GHIDRA: TabBarOnChangeEvent ---
		void Gameplay_Auchan_View_AuchanView__TabBarOnChangeEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  *(undefined4 *)(param1 + 0x24) = param2;
		  param1_00 = *(int **)(param1 + 0x14);
		  if (DAT_ram_00a5984d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__get_Count__);
		    DAT_ram_00a5984d = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x2e8) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x2ec));
		  Gameplay_Auchan_View_AuchanGridOsaView__SetData
		            (param1_00,*(undefined4 *)(param1_00[4] + 0x58),param2,param1_00 + 0x2c,param1_00 + 0x2d
		             ,param1_00);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x340) * 4))
		            (param1_00,*(undefined4 *)(param1_00[0x2c] + 0xc),0,1,
		             *(undefined4 *)(*param1_00 + 0x344));
		  Gameplay_Auchan_View_AuchanView__SetData(param1,param1_00);
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(param1 + 0x10),0,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x9C7A", Offset = "0x9C7A", VA = "0x9C7A")]
		public void SetData(List<AuchanArtifactCategoryData> data)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Auchan_View_AuchanView__SetData(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a59858 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanSubcategoriesTabBarItemData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanSubcategoriesTabBarItemData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactCategoryData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_AuchanSubcategoriesTabBarItemData__TypeInfo);
		    DAT_ram_00a59858 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_AuchanSubcategoriesTabBarItemData__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_AuchanSubcategoriesTabBarItemData___ctor__);
		  iVar1 = *(int *)(param1 + 0x24);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,param2_01,
		                         Method_System_Collections_Generic_List_AuchanArtifactCategoryData__get_Item__
		                        );
		      param2_00 = unnamed_function_1417
		                            (Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData_TypeInfo);
		      *(undefined4 *)(param2_00 + 0x14) = *(undefined4 *)(iVar1 + 0x10);
		      uVar2 = *(undefined4 *)(iVar1 + 8);
		      *(int *)(param2_00 + 0x20) = iVar1;
		      *(undefined4 *)(param2_00 + 0x10) = uVar2;
		      iVar1 = Method_System_Collections_Generic_List_AuchanSubcategoriesTabBarItemData__Add__;
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
		      iVar1 = *(int *)(param1 + 0x24);
		    } while (param2_01 < *(int *)(iVar1 + 0xc));
		  }
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(param1 + 0x10),param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x9C7B", Offset = "0x9C7B", VA = "0x9C7B")]
		private void RenderCategories()
		{
		/* --- GHIDRA: RenderCategories ---
		void Gameplay_Auchan_View_AuchanView__RenderCategories(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59859 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__IndexOf__);
		    DAT_ram_00a59859 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = piVar3[0x2c];
		  param1_00 = *(int **)(param2 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_AuchanArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107b08c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_AuchanArtifactData__TypeInfo,0);
		code_r0x8107b08c:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0,puVar2[1]);
		  iVar4 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (iVar4,param2_00,
		                     Method_System_Collections_Generic_List_AuchanArtifactData__IndexOf__);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x398) * 4))
		            (piVar3,iVar4 + -1,0x3e99999a,0,0,0,0,0,*(undefined4 *)(*piVar3 + 0x39c));
		  return;
		}
		*/

		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x9C7C", Offset = "0x9C7C", VA = "0x9C7C")]
		private void ScrollToCategory(AuchanArtifactCategoryData cat)
		{
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x9C7D", Offset = "0x9C7D", VA = "0x9C7D")]
		public AuchanView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Auchan_View_AuchanView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5985a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12566);
		    DAT_ram_00a5985a = '\x01';
		  }
		  return StringLiteral_12566;
		}
		*/

		}

		// Token: 0x04002AC0 RID: 10944
		[Token(Token = "0x4002AC0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04002AC1 RID: 10945
		[Token(Token = "0x4002AC1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AuchanGridOsaView _gridView;

		// Token: 0x04002AC2 RID: 10946
		[Token(Token = "0x4002AC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x04002AC3 RID: 10947
		[Token(Token = "0x4002AC3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GreenToggle _toggle;

		// Token: 0x04002AC4 RID: 10948
		[Token(Token = "0x4002AC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AuchanSortingFilter _sortingFilter;

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x24")]
		private List<AuchanArtifactCategoryData> _categories;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortingFilter ---
		void Gameplay_Auchan_View_AuchanView__get_SortingFilter(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59855 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Auchan_View_AuchanView_TabBarOnChangeEvent__);
		    DAT_ram_00a59855 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Auchan_View_AuchanView_TabBarOnChangeEvent__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

}
