using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using DG.Tweening;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000693 RID: 1683
	[Token(Token = "0x2000693")]
	public class MedalsGridOsaView : GridAdapter<MedalsGridWithCategoriesParams, MedalCellViewHolder>
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007B4")]
		public List<MedalData> Data
		{
			[Token(Token = "0x60028A8")]
			[Address(RVA = "0x79C7", Offset = "0x79C7", VA = "0x79C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x79C8", Offset = "0x79C8", VA = "0x79C8", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__Start
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a114 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MedalsGridWithCategoriesParams__MedalCellViewHolder__Refresh__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__get_Count__);
		    DAT_ram_00a5a114 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xa4) = *(undefined4 *)(*(int *)(param1 + 0xb0) + 0xc);
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___RebuildLayoutDueToScrollViewSizeChange
		            (param1,0,param3,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MedalsGridWithCategoriesParams__MedalCellViewHolder__Refresh__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x79C9", Offset = "0x79C9", VA = "0x79C9", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		/* --- GHIDRA: Refresh ---
		undefined4
		Gameplay_Inventory_View_Chest_MedalsGridOsaView__Refresh(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a115 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo);
		    DAT_ram_00a5a115 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo)
		  ;
		  if (DAT_ram_00a5a11f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MedalCellViewHolder___ctor__
		              );
		    DAT_ram_00a5a11f = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1_00,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MedalCellViewHolder___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x79CA", Offset = "0x79CA", VA = "0x79CA", Slot = "126")]
		protected override CellGroupViewsHolder<MedalCellViewHolder> GetNewCellGroupViewsHolder()
		{
		/* --- GHIDRA: GetNewCellGroupViewsHolder ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__GetNewCellGroupViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a116 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MedalCellViewHolder__get_ContainingCellViewsHolders__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MedalCellViewHolder__get_NumActiveCells__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MedalsGridWithCategoriesParams__MedalCellViewHolder__UpdateViewsHolder__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___ScheduleComputeVisibilityTwinPass__
		              );
		    DAT_ram_00a5a116 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___SmoothScrollToGroup
		            (param1,param2,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MedalsGridWithCategoriesParams__MedalCellViewHolder__UpdateViewsHolder__
		            );
		  if (0 < param2[7]) {
		    iVar4 = **(int **)(param2[5] + 0x10);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                      (*(int **)(param2[5] + 0x10),*(undefined4 *)(iVar4 + 0xe4));
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0xb0),uVar1,
		                       Method_System_Collections_Generic_List_MedalData__get_Item__);
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo +
		                                0xb8) * 4 + -4) !=
		        Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Inventory_View_Chest_MedalCellGroupViewHolder_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = func_ii_10159(*(undefined4 *)(param1 + 0xb8),uVar1,
		                          Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		    if (iVar4 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2[10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		    }
		    else {
		      if (DAT_ram_00a5a117 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__ContainsKey__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__get_Item__
		                  );
		        Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		        DAT_ram_00a5a117 = '\x01';
		      }
		      iVar4 = System_Xml_Schema_SchemaInfo__get_Notations
		                        (*(undefined4 *)(param1 + 0xb4),uVar1,
		                         Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__ContainsKey__
		                        );
		      if (iVar4 == 0) {
		        puVar2 = &StringLiteral_1331;
		      }
		      else {
		        iVar4 = System_Data_DataRelationCollection__Add
		                          (*(undefined4 *)(param1 + 0xb4),uVar1,
		                           Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__get_Item__
		                          );
		        puVar2 = (undefined4 *)(iVar4 + 8);
		      }
		      param1_00 = *puVar2;
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2[10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		      piVar3 = (int *)param2[0xb];
		      uVar1 = System_Uri__get_Authority(param1_00,0);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                (piVar3,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		    }
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___ResetItems
		            (param1,0,
		             Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___ScheduleComputeVisibilityTwinPass__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AC")]
		[Address(RVA = "0x79CB", Offset = "0x79CB", VA = "0x79CB", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<MedalCellViewHolder> newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		undefined4
		Gameplay_Inventory_View_Chest_MedalsGridOsaView__UpdateViewsHolder
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a5a117 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    DAT_ram_00a5a117 = '\x01';
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0xb4),param2,
		                     Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    puVar2 = &StringLiteral_1331;
		  }
		  else {
		    iVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 0xb4),param2,
		                       Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__get_Item__
		                      );
		    puVar2 = (undefined4 *)(iVar1 + 8);
		  }
		  return *puVar2;
		}
		*/

		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x79CC", Offset = "0x79CC", VA = "0x79CC")]
		private string GetCategoryNameByArtifact(MedalData medalData)
		{
		/* --- GHIDRA: GetCategoryNameByArtifact ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__GetCategoryNameByArtifact
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a118 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_Chest_MedalsGridOsaView_NotifyStencilDelayed__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a5a118 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xb0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1_00,uVar1,Method_System_Collections_Generic_List_MedalData__get_Item__);
		  iVar2 = func_ii_10159(*(undefined4 *)(param1 + 0xb8),uVar1,
		                        Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		  if (iVar2 == 0) {
		    func_ii_10159(*(undefined4 *)(param1 + 0xbc),uVar1,
		                  Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		  }
		  if (*(char *)(param1 + 0xd0) == '\0') {
		    Gameplay_Inventory_View_Chest_MedalCellViewHolder__CollectViews
		              (param2,uVar1,*(undefined4 *)(param1 + 200),*(undefined4 *)(param1 + 0xc4),
		               *(undefined4 *)(param1 + 0xb8),*(undefined4 *)(param1 + 0xbc),
		               *(undefined4 *)(param1 + 0xcc),param1);
		  }
		  else {
		    Gameplay_Inventory_View_Chest_MedalCellViewHolder__UpdateViews
		              (param2,uVar1,*(undefined4 *)(param1 + 200),*(undefined4 *)(param1 + 0xc4),
		               *(undefined4 *)(param1 + 0xb8),*(undefined4 *)(param1 + 0xbc),
		               *(undefined4 *)(param1 + 0xcc),1,param1);
		  }
		  if (*(int *)(param1 + 0xd4) == 0) {
		    uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar1,param1,
		               Method_Gameplay_Inventory_View_Chest_MedalsGridOsaView_NotifyStencilDelayed__,0);
		    uVar1 = DG_Tweening_DOVirtual__EasedValue(0.2,uVar1,1,0);
		    *(undefined4 *)(param1 + 0xd4) = uVar1;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x79CD", Offset = "0x79CD", VA = "0x79CD", Slot = "128")]
		protected override void UpdateCellViewsHolder(MedalCellViewHolder viewsHolder)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__UpdateCellViewsHolder
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a119 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___OnDestroy__
		              );
		    DAT_ram_00a5a119 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___OnCumulatedSizesOfAllItemsChanged
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___OnDestroy__
		            );
		  *(undefined4 *)(param1 + 0xc0) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x79CE", Offset = "0x79CE", VA = "0x79CE", Slot = "73")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a11a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a11a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xd4) = 0;
		  param1_00 = *(undefined4 *)(param1 + 0xc0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    UnityEngine_UI_MaskUtilities__Notify2DMaskStateChanged(*(undefined4 *)(param1 + 0xc0),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x79CF", Offset = "0x79CF", VA = "0x79CF")]
		private void NotifyStencilDelayed()
		{
		/* --- GHIDRA: NotifyStencilDelayed ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__NotifyStencilDelayed
		               (int *param1,undefined4 param2,int param3,int param4,int param5,undefined4 param6,
		               undefined4 param7)
		
		{
		  if (DAT_ram_00a5a11b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__get_Count__);
		    DAT_ram_00a5a11b = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x34) = (undefined1)param6;
		  param1[0x33] = param5;
		  param1[0x31] = param4;
		  param1[0x32] = param3;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Gameplay_Inventory_View_Chest_MedalsGridOsaView__SetData
		            (param1,*(undefined4 *)(param1[4] + 0x58),param2,param1 + 0x2c,param1 + 0x2d,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x340) * 4))
		            (param1,*(undefined4 *)(param1[0x2c] + 0xc),0,1,*(undefined4 *)(*param1 + 0x344));
		  if (0 < *(int *)(param1[0x2c] + 0xc)) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x390) * 4))
		              (param1,0,0,0,*(undefined4 *)(*param1 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x79D0", Offset = "0x79D0", VA = "0x79D0")]
		public void SetData(List<MedalsCategoryData> categories, UserData user, UserData loggedUser, Action<MedalView> medalViewClickCallback, bool saleEnabled)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__SetData
		               (int param1,int param2,int param3,int *param4,undefined4 *param5,undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  int param2_00;
		  int *piVar9;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5a11c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_MedalData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_MedalData__Clear__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalsCategoryData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalData__TypeInfo);
		    DAT_ram_00a5a11c = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData___ctor__);
		  *param5 = uVar1;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_MedalData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_MedalData___ctor__);
		  *param4 = iVar2;
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0xb8),
		             Method_System_Collections_Generic_HashSet_MedalData__Clear__);
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0xbc),
		             Method_System_Collections_Generic_HashSet_MedalData__Clear__);
		  if (*(int *)(param3 + 0xc) < 1) {
		    return;
		  }
		code_r0x811cea81:
		  iVar3 = System_Linq_Enumerable__ToList_object_
		                    (param3,param2_00,
		                     Method_System_Collections_Generic_List_MedalsCategoryData__get_Item__);
		  iVar2 = 0;
		  if (0 < param2) {
		    do {
		      uVar1 = Core_Data_MedalData__get_NextMedal(0);
		      System_Collections_Generic_HashSet_object___Clear
		                (*(undefined4 *)(param1 + 0xb8),uVar1,
		                 Method_System_Collections_Generic_HashSet_MedalData__Add__);
		      iVar6 = Method_System_Collections_Generic_List_MedalData__Add__;
		      iVar7 = *param4;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		        *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar1;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar7,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      }
		      func_ii_2946(*param5,uVar1,iVar3,
		                   Method_System_Collections_Generic_Dictionary_MedalData__MedalsCategoryData__set_Item__
		                  );
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != param2);
		  }
		  iVar2 = 0;
		  do {
		    piVar5 = *(int **)(iVar3 + 0xc);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_ICollection_MedalData__TypeInfo == *piVar9) {
		          puVar4 = (uint *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811cebb0;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_ICollection_MedalData__TypeInfo,
		                                  0);
		code_r0x811cebb0:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    iVar7 = *param4;
		    if (iVar6 <= iVar2) break;
		    piVar5 = *(int **)(iVar3 + 0xc);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IList_MedalData__TypeInfo == *piVar9) {
		          puVar4 = (uint *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811cec3f;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IList_MedalData__TypeInfo,0);
		code_r0x811cec3f:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,iVar2,puVar4[1]);
		    iVar6 = Method_System_Collections_Generic_List_MedalData__Add__;
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar7 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = uVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar7,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    }
		    iVar2 = iVar2 + 1;
		  } while( true );
		  iVar2 = *(int *)(iVar7 + 0xc);
		  while (iVar2 % param2 != 0) {
		    uVar1 = Core_Data_MedalData__get_NextMedal(0);
		    System_Collections_Generic_HashSet_object___Clear
		              (*(undefined4 *)(param1 + 0xbc),uVar1,
		               Method_System_Collections_Generic_HashSet_MedalData__Add__);
		    iVar2 = Method_System_Collections_Generic_List_MedalData__Add__;
		    iVar3 = *param4;
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar3 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(*(int *)(iVar3 + 8) + uVar8 * 4 + 0x10) = uVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		    iVar2 = *(int *)(*param4 + 0xc);
		  }
		  param2_00 = param2_00 + 1;
		  if (*(int *)(param3 + 0xc) <= param2_00) {
		    return;
		  }
		  goto code_r0x811cea81;
		}
		*/

		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x79D1", Offset = "0x79D1", VA = "0x79D1")]
		private void ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<MedalsCategoryData> categories, out List<MedalData> resultList, out Dictionary<MedalData, MedalsCategoryData> categoriesHash)
		{
		/* --- GHIDRA: ConvertCategoriesToListOfItemModels ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__ConvertCategoriesToListOfItemModels
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a11d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MedalsGridWithCategoriesParams__MedalCellViewHolder___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_MedalData__TypeInfo);
		    DAT_ram_00a5a11d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_MedalData__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_MedalData___ctor__);
		  *(undefined4 *)(param1 + 0xb8) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_MedalData__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_MedalData___ctor__);
		  *(undefined4 *)(param1 + 0xbc) = uVar1;
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_MedalsGridWithCategoriesParams__MedalCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x79D2", Offset = "0x79D2", VA = "0x79D2")]
		public MedalsGridOsaView()
		{
		}

		// Token: 0x0400166F RID: 5743
		[Token(Token = "0x400166F")]
		[FieldOffset(Offset = "0xB0")]
		private List<MedalData> _data;

		// Token: 0x04001670 RID: 5744
		[Token(Token = "0x4001670")]
		[FieldOffset(Offset = "0xB4")]
		private Dictionary<MedalData, MedalsCategoryData> _categoriesByMedalsHash;

		// Token: 0x04001671 RID: 5745
		[Token(Token = "0x4001671")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<MedalData> _categorySeparateItems;

		// Token: 0x04001672 RID: 5746
		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0xBC")]
		private HashSet<MedalData> _rowCompletionItems;

		// Token: 0x04001673 RID: 5747
		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0xC0")]
		public Component MaskOnTop;

		// Token: 0x04001674 RID: 5748
		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0xC4")]
		private UserData _loggedUser;

		// Token: 0x04001675 RID: 5749
		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0xC8")]
		private UserData _user;

		// Token: 0x04001676 RID: 5750
		[Token(Token = "0x4001676")]
		[FieldOffset(Offset = "0xCC")]
		private Action<MedalView> _medalViewClickCallback;

		// Token: 0x04001677 RID: 5751
		[Token(Token = "0x4001677")]
		[FieldOffset(Offset = "0xD0")]
		private bool _saleEnabled;

		// Token: 0x04001678 RID: 5752
		[Token(Token = "0x4001678")]
		[FieldOffset(Offset = "0xD4")]
		private Tween _delayedCall;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Inventory_View_Chest_MedalsGridOsaView__get_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a113 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___get_IsInitialized__
		              );
		    DAT_ram_00a5a113 = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_MedalData__TypeInfo);
		    Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		              (param1_00,0,Method_System_Collections_Generic_List_MedalData___ctor__);
		    *(undefined4 *)(param1 + 0xb0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_MedalsGridWithCategoriesParams__CellGroupViewsHolder_MedalCellViewHolder___Start__
		              );
		  }
		  return;
		}
		*/

}
