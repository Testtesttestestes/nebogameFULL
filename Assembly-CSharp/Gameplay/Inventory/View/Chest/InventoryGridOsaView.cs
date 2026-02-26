using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068B RID: 1675
	[Token(Token = "0x200068B")]
	public class InventoryGridOsaView : GridAdapter<InventoryGridWithCategoriesParams, ArtifactCellViewHolder>
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AC")]
		public List<ArtifactData> Data
		{
			[Token(Token = "0x6002878")]
			[Address(RVA = "0x7998", Offset = "0x7998", VA = "0x7998")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x00007AB8 File Offset: 0x00005CB8
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AD")]
		public ArtifactView.ArtifactViewArgs ArtifactViewArgs
		{
			[Token(Token = "0x6002879")]
			[Address(RVA = "0x7999", Offset = "0x7999", VA = "0x7999")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x600287A")]
			[Address(RVA = "0x799A", Offset = "0x799A", VA = "0x799A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x799B", Offset = "0x799B", VA = "0x799B", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__Start
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a0fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_InventoryGridWithCategoriesParams__ArtifactCellViewHolder__Refresh__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    DAT_ram_00a5a0fc = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xa4) = *(undefined4 *)(*(int *)(param1 + 0xb0) + 0xc);
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___RebuildLayoutDueToScrollViewSizeChange
		            (param1,0,param3,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_InventoryGridWithCategoriesParams__ArtifactCellViewHolder__Refresh__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x799C", Offset = "0x799C", VA = "0x799C", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		/* --- GHIDRA: Refresh ---
		undefined4
		Gameplay_Inventory_View_Chest_InventoryGridOsaView__Refresh(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a0fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo);
		    DAT_ram_00a5a0fd = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo);
		  if (DAT_ram_00a5a105 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_ArtifactCellViewHolder___ctor__
		              );
		    DAT_ram_00a5a105 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1_00,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_ArtifactCellViewHolder___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x799D", Offset = "0x799D", VA = "0x799D", Slot = "126")]
		protected override CellGroupViewsHolder<ArtifactCellViewHolder> GetNewCellGroupViewsHolder()
		{
		/* --- GHIDRA: GetNewCellGroupViewsHolder ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__GetNewCellGroupViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a0fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_ArtifactCellViewHolder__get_ContainingCellViewsHolders__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_ArtifactCellViewHolder__get_NumActiveCells__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_InventoryGridWithCategoriesParams__ArtifactCellViewHolder__UpdateViewsHolder__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_InventoryGridWithCategoriesParams__CellGroupViewsHolder_ArtifactCellViewHolder___ScheduleComputeVisibilityTwinPass__
		              );
		    DAT_ram_00a5a0fe = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___SmoothScrollToGroup
		            (param1,param2,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_InventoryGridWithCategoriesParams__ArtifactCellViewHolder__UpdateViewsHolder__
		            );
		  if (0 < param2[7]) {
		    iVar4 = **(int **)(param2[5] + 0x10);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                      (*(int **)(param2[5] + 0x10),*(undefined4 *)(iVar4 + 0xe4));
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0xb0),uVar1,
		                       Method_System_Collections_Generic_List_ArtifactData__get_Item__);
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param2 + 100) +
		                    (uint)*(byte *)(
		                                   Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = func_ii_10159(*(undefined4 *)(param1 + 0xb8),uVar1,
		                          Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		    if (iVar4 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2[10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		    }
		    else {
		      if (DAT_ram_00a5a0ff == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__ContainsKey__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__get_Item__
		                  );
		        Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		        DAT_ram_00a5a0ff = '\x01';
		      }
		      iVar4 = System_Xml_Schema_SchemaInfo__get_Notations
		                        (*(undefined4 *)(param1 + 0xb4),uVar1,
		                         Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__ContainsKey__
		                        );
		      if (iVar4 == 0) {
		        puVar2 = &StringLiteral_1331;
		      }
		      else {
		        iVar4 = System_Data_DataRelationCollection__Add
		                          (*(undefined4 *)(param1 + 0xb4),uVar1,
		                           Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__get_Item__
		                          );
		        puVar2 = (undefined4 *)(iVar4 + 0xc);
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
		             Method_Com_TheFallenGames_OSA_Core_OSA_InventoryGridWithCategoriesParams__CellGroupViewsHolder_ArtifactCellViewHolder___ScheduleComputeVisibilityTwinPass__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x799E", Offset = "0x799E", VA = "0x799E", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<ArtifactCellViewHolder> newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		undefined4
		Gameplay_Inventory_View_Chest_InventoryGridOsaView__UpdateViewsHolder
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a5a0ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    DAT_ram_00a5a0ff = '\x01';
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0xb4),param2,
		                     Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    puVar2 = &StringLiteral_1331;
		  }
		  else {
		    iVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 0xb4),param2,
		                       Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__get_Item__
		                      );
		    puVar2 = (undefined4 *)(iVar1 + 0xc);
		  }
		  return *puVar2;
		}
		*/

		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x799F", Offset = "0x799F", VA = "0x799F")]
		private string GetCategoryNameByArtifact(ArtifactData artifactData)
		{
		/* --- GHIDRA: GetCategoryNameByArtifact ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__GetCategoryNameByArtifact
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5a100 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Item__);
		    DAT_ram_00a5a100 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xb0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1_00,uVar1,Method_System_Collections_Generic_List_ArtifactData__get_Item__
		                    );
		  iVar2 = func_ii_10159(*(undefined4 *)(param1 + 0xb8),uVar1,
		                        Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		  if (iVar2 == 0) {
		    func_ii_10159(*(undefined4 *)(param1 + 0xbc),uVar1,
		                  Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		  }
		  local_8 = *(undefined4 *)(param1 + 0xd4);
		  local_10 = *(undefined8 *)(param1 + 0xcc);
		  Gameplay_Inventory_View_Chest_ArtifactCellViewHolder__CollectViews
		            (param2,uVar1,param1,*(undefined4 *)(param1 + 0xb8),*(undefined4 *)(param1 + 0xbc),
		             &local_10,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x79A0", Offset = "0x79A0", VA = "0x79A0", Slot = "128")]
		protected override void UpdateCellViewsHolder(ArtifactCellViewHolder viewsHolder)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__UpdateCellViewsHolder
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a101 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__get_Item__);
		    DAT_ram_00a5a101 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  param2_00 = *(undefined4 *)(param1[4] + 0x58);
		  param1[0x35] = param1[0x32];
		  *(undefined8 *)(param1 + 0x33) = *(undefined8 *)(param1 + 0x30);
		  if (0 < *(int *)(param2 + 0xc)) {
		    uVar2 = param1[0x32];
		    iVar1 = System_Linq_Enumerable__ToList_object_
		                      (param2,0,
		                       Method_System_Collections_Generic_List_ArtifactCategoryData__get_Item__);
		    param1[0x35] = uVar2 | *(uint *)(iVar1 + 0x14);
		  }
		  Gameplay_Inventory_View_Chest_InventoryGridOsaView__SetData
		            (param1,param2_00,param2,param1 + 0x2c,param1 + 0x2d,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x340) * 4))
		            (param1,*(undefined4 *)(param1[0x2c] + 0xc),0,1,*(undefined4 *)(*param1 + 0x344));
		  return;
		}
		*/

		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x79A1", Offset = "0x79A1", VA = "0x79A1")]
		public void SetData(List<ArtifactCategoryData> categories)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__SetData
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
		  if (DAT_ram_00a5a102 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ArtifactData__Clear__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactCategoryData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    DAT_ram_00a5a102 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData___ctor__
		            );
		  *param5 = uVar1;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  *param4 = iVar2;
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0xb8),
		             Method_System_Collections_Generic_HashSet_ArtifactData__Clear__);
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0xbc),
		             Method_System_Collections_Generic_HashSet_ArtifactData__Clear__);
		  if (*(int *)(param3 + 0xc) < 1) {
		    return;
		  }
		code_r0x811cd350:
		  iVar3 = System_Linq_Enumerable__ToList_object_
		                    (param3,param2_00,
		                     Method_System_Collections_Generic_List_ArtifactCategoryData__get_Item__);
		  iVar2 = 0;
		  if (0 < param2) {
		    do {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		            puVar4 = (uint *)(piVar9[1] * 8 + iVar6 + 0x178);
		            goto code_r0x811cd401;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811cd401:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      uVar1 = Core_Data_ArtifactData__Create(uVar1,0);
		      System_Collections_Generic_HashSet_object___Clear
		                (*(undefined4 *)(param1 + 0xb8),uVar1,
		                 Method_System_Collections_Generic_HashSet_ArtifactData__Add__);
		      iVar6 = Method_System_Collections_Generic_List_ArtifactData__Add__;
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
		                   Method_System_Collections_Generic_Dictionary_ArtifactData__ArtifactCategoryData__set_Item__
		                  );
		      iVar2 = iVar2 + 1;
		    } while (iVar2 != param2);
		  }
		  iVar2 = 0;
		  do {
		    piVar5 = *(int **)(iVar3 + 0x10);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_ICollection_ArtifactData__TypeInfo == *piVar9) {
		          puVar4 = (uint *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811cd525;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,
		                                  System_Collections_Generic_ICollection_ArtifactData__TypeInfo,0);
		code_r0x811cd525:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    iVar7 = *param4;
		    if (iVar6 <= iVar2) break;
		    piVar5 = *(int **)(iVar3 + 0x10);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IList_ArtifactData__TypeInfo == *piVar9) {
		          puVar4 = (uint *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811cd5b4;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IList_ArtifactData__TypeInfo,0);
		code_r0x811cd5b4:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,iVar2,puVar4[1]);
		    iVar6 = Method_System_Collections_Generic_List_ArtifactData__Add__;
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
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar8 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		          puVar4 = (uint *)(piVar9[1] * 8 + iVar2 + 0x178);
		          goto code_r0x811cd6cf;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811cd6cf:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    uVar1 = Core_Data_ArtifactData__Create(uVar1,0);
		    System_Collections_Generic_HashSet_object___Clear
		              (*(undefined4 *)(param1 + 0xbc),uVar1,
		               Method_System_Collections_Generic_HashSet_ArtifactData__Add__);
		    iVar2 = Method_System_Collections_Generic_List_ArtifactData__Add__;
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
		  goto code_r0x811cd350;
		}
		*/

		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x79A2", Offset = "0x79A2", VA = "0x79A2")]
		private void ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<ArtifactCategoryData> categories, out List<ArtifactData> resultList, out Dictionary<ArtifactData, ArtifactCategoryData> categoriesHash)
		{
		/* --- GHIDRA: ConvertCategoriesToListOfItemModels ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__ConvertCategoriesToListOfItemModels
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a103 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_InventoryGridWithCategoriesParams__ArtifactCellViewHolder___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_ArtifactData__TypeInfo);
		    DAT_ram_00a5a103 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_ArtifactData__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0xb8) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_ArtifactData__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_ArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0xbc) = uVar1;
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_InventoryGridWithCategoriesParams__ArtifactCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x79A3", Offset = "0x79A3", VA = "0x79A3")]
		public InventoryGridOsaView()
		{
		}

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[FieldOffset(Offset = "0xB0")]
		private List<ArtifactData> _data;

		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		[FieldOffset(Offset = "0xB4")]
		private Dictionary<ArtifactData, ArtifactCategoryData> _categoriesByArtifactHash;

		// Token: 0x04001657 RID: 5719
		[Token(Token = "0x4001657")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<ArtifactData> _categorySeparateItems;

		// Token: 0x04001658 RID: 5720
		[Token(Token = "0x4001658")]
		[FieldOffset(Offset = "0xBC")]
		private HashSet<ArtifactData> _rowCompletionItems;

		// Token: 0x0400165A RID: 5722
		[Token(Token = "0x400165A")]
		[FieldOffset(Offset = "0xCC")]
		private ArtifactView.ArtifactViewArgs _currentArtifactViewArgs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__get_Data
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined8 *)(param2 + 0xc0);
		  *(undefined4 *)(param1 + 1) = *(undefined4 *)(param2 + 200);
		  return;
		}
		*/


		/* --- GHIDRA: get_ArtifactViewArgs ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__get_ArtifactViewArgs
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  *(undefined8 *)(param1 + 0xc0) = *param2;
		  *(undefined4 *)(param1 + 200) = *(undefined4 *)(param2 + 1);
		  return;
		}
		*/


		/* --- GHIDRA: set_ArtifactViewArgs ---
		void Gameplay_Inventory_View_Chest_InventoryGridOsaView__set_ArtifactViewArgs
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a0fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_InventoryGridWithCategoriesParams__CellGroupViewsHolder_ArtifactCellViewHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_InventoryGridWithCategoriesParams__CellGroupViewsHolder_ArtifactCellViewHolder___get_IsInitialized__
		              );
		    DAT_ram_00a5a0fb = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		              (param1_00,0,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    *(undefined4 *)(param1 + 0xb0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_InventoryGridWithCategoriesParams__CellGroupViewsHolder_ArtifactCellViewHolder___Start__
		              );
		  }
		  return;
		}
		*/

}
