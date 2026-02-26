using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C86 RID: 3206
	[Token(Token = "0x2000C86")]
	public class AuchanGridOsaView : GridAdapter<AuchanGridWithCategoriesParams, AuchanArtifactCellViewHolder>
	{
		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD6")]
		public List<AuchanArtifactData> Data
		{
			[Token(Token = "0x6004E2E")]
			[Address(RVA = "0x9C61", Offset = "0x9C61", VA = "0x9C61")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x9C62", Offset = "0x9C62", VA = "0x9C62", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Auchan_View_AuchanGridOsaView__Start
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59848 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_AuchanGridWithCategoriesParams__AuchanArtifactCellViewHolder__Refresh__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__get_Count__);
		    DAT_ram_00a59848 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xa4) = *(undefined4 *)(*(int *)(param1 + 0xb0) + 0xc);
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___RebuildLayoutDueToScrollViewSizeChange
		            (param1,0,param3,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_AuchanGridWithCategoriesParams__AuchanArtifactCellViewHolder__Refresh__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x9C63", Offset = "0x9C63", VA = "0x9C63", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		/* --- GHIDRA: Refresh ---
		undefined4 Gameplay_Auchan_View_AuchanGridOsaView__Refresh(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59849 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo);
		    DAT_ram_00a59849 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo)
		  ;
		  if (DAT_ram_00a59852 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder___ctor__
		              );
		    DAT_ram_00a59852 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1_00,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder___ctor__
		            );
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x9C64", Offset = "0x9C64", VA = "0x9C64", Slot = "126")]
		protected override CellGroupViewsHolder<AuchanArtifactCellViewHolder> GetNewCellGroupViewsHolder()
		{
		/* --- GHIDRA: GetNewCellGroupViewsHolder ---
		void Gameplay_Auchan_View_AuchanGridOsaView__GetNewCellGroupViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5984a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder__get_ContainingCellViewsHolders__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder__get_NumActiveCells__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_AuchanGridWithCategoriesParams__AuchanArtifactCellViewHolder__UpdateViewsHolder__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_AuchanGridWithCategoriesParams__CellGroupViewsHolder_AuchanArtifactCellViewHolder___ScheduleComputeVisibilityTwinPass__
		              );
		    DAT_ram_00a5984a = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_object__object___SmoothScrollToGroup
		            (param1,param2,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_AuchanGridWithCategoriesParams__AuchanArtifactCellViewHolder__UpdateViewsHolder__
		            );
		  if (0 < param2[7]) {
		    iVar4 = **(int **)(param2[5] + 0x10);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                      (*(int **)(param2[5] + 0x10),*(undefined4 *)(iVar4 + 0xe4));
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(undefined4 *)(param1 + 0xb0),uVar1,
		                       Method_System_Collections_Generic_List_AuchanArtifactData__get_Item__);
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo +
		                                0xb8) * 4 + -4) !=
		        Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar4 = func_ii_10159(*(undefined4 *)(param1 + 0xb8),uVar1,
		                          Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		    if (iVar4 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2[10],0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		    }
		    else {
		      if (DAT_ram_00a5984b == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__ContainsKey__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__get_Item__
		                  );
		        Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		        DAT_ram_00a5984b = '\x01';
		      }
		      iVar4 = System_Xml_Schema_SchemaInfo__get_Notations
		                        (*(undefined4 *)(param1 + 0xb4),uVar1,
		                         Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__ContainsKey__
		                        );
		      if (iVar4 == 0) {
		        puVar2 = &StringLiteral_1331;
		      }
		      else {
		        iVar4 = System_Data_DataRelationCollection__Add
		                          (*(undefined4 *)(param1 + 0xb4),uVar1,
		                           Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__get_Item__
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
		             Method_Com_TheFallenGames_OSA_Core_OSA_AuchanGridWithCategoriesParams__CellGroupViewsHolder_AuchanArtifactCellViewHolder___ScheduleComputeVisibilityTwinPass__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x9C65", Offset = "0x9C65", VA = "0x9C65", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<AuchanArtifactCellViewHolder> newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		undefined4
		Gameplay_Auchan_View_AuchanGridOsaView__UpdateViewsHolder
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a5984b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1331);
		    DAT_ram_00a5984b = '\x01';
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0xb4),param2,
		                     Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    puVar2 = &StringLiteral_1331;
		  }
		  else {
		    iVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 0xb4),param2,
		                       Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__get_Item__
		                      );
		    puVar2 = (undefined4 *)(iVar1 + 8);
		  }
		  return *puVar2;
		}
		*/

		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E33")]
		[Address(RVA = "0x9C66", Offset = "0x9C66", VA = "0x9C66")]
		private string GetCategoryNameByArtifact(AuchanArtifactData artifactData)
		{
		/* --- GHIDRA: GetCategoryNameByArtifact ---
		void Gameplay_Auchan_View_AuchanGridOsaView__GetCategoryNameByArtifact
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5984c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__get_Item__);
		    DAT_ram_00a5984c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xb0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (param1_00,uVar1,
		                     Method_System_Collections_Generic_List_AuchanArtifactData__get_Item__);
		  iVar2 = func_ii_10159(*(undefined4 *)(param1 + 0xb8),uVar1,
		                        Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		  if (iVar2 == 0) {
		    func_ii_10159(*(undefined4 *)(param1 + 0xbc),uVar1,
		                  Method_System_Collections_Generic_HashSet_AuchanArtifactData__Contains__);
		  }
		  Gameplay_Auchan_View_AuchanArtifactCellViewHolder__CollectViews
		            (param2,uVar1,*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0xb8),
		             *(undefined4 *)(param1 + 0xbc),param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E34")]
		[Address(RVA = "0x9C67", Offset = "0x9C67", VA = "0x9C67", Slot = "128")]
		protected override void UpdateCellViewsHolder(AuchanArtifactCellViewHolder viewsHolder)
		{
		/* --- GHIDRA: UpdateCellViewsHolder ---
		void Gameplay_Auchan_View_AuchanGridOsaView__UpdateCellViewsHolder
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5984d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__get_Count__);
		    DAT_ram_00a5984d = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Gameplay_Auchan_View_AuchanGridOsaView__SetData
		            (param1,*(undefined4 *)(param1[4] + 0x58),param2,param1 + 0x2c,param1 + 0x2d,param1);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x340) * 4))
		            (param1,*(undefined4 *)(param1[0x2c] + 0xc),0,1,*(undefined4 *)(*param1 + 0x344));
		  return;
		}
		*/

		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E35")]
		[Address(RVA = "0x9C68", Offset = "0x9C68", VA = "0x9C68")]
		public void SetData(List<AuchanArtifactCategoryData> categories)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Auchan_View_AuchanGridOsaView__SetData
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
		  if (DAT_ram_00a5984e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AuchanArtifactData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AuchanArtifactData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AuchanArtifactData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactCategoryData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactCategoryData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		    DAT_ram_00a5984e = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData___ctor__
		            );
		  *param5 = uVar1;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		  *param4 = iVar2;
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0xb8),
		             Method_System_Collections_Generic_HashSet_AuchanArtifactData__Clear__);
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 0xbc),
		             Method_System_Collections_Generic_HashSet_AuchanArtifactData__Clear__);
		  if (*(int *)(param3 + 0xc) < 1) {
		    return;
		  }
		code_r0x8107a806:
		  iVar3 = System_Linq_Enumerable__ToList_object_
		                    (param3,param2_00,
		                     Method_System_Collections_Generic_List_AuchanArtifactCategoryData__get_Item__);
		  iVar2 = 0;
		  if (0 < param2) {
		    do {
		      if (DAT_ram_00a5986d == '\0') {
		        Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		        DAT_ram_00a5986d = '\x01';
		      }
		      uVar1 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		      System_Collections_Generic_HashSet_object___Clear
		                (*(undefined4 *)(param1 + 0xb8),uVar1,
		                 Method_System_Collections_Generic_HashSet_AuchanArtifactData__Add__);
		      iVar6 = Method_System_Collections_Generic_List_AuchanArtifactData__Add__;
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
		                   Method_System_Collections_Generic_Dictionary_AuchanArtifactData__AuchanArtifactCategoryData__set_Item__
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
		        if (System_Collections_Generic_ICollection_AuchanArtifactData__TypeInfo == *piVar9) {
		          puVar4 = (uint *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8107a958;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,
		                                  System_Collections_Generic_ICollection_AuchanArtifactData__TypeInfo
		                                  ,0);
		code_r0x8107a958:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    iVar7 = *param4;
		    if (iVar6 <= iVar2) break;
		    piVar5 = *(int **)(iVar3 + 0xc);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IList_AuchanArtifactData__TypeInfo == *piVar9) {
		          puVar4 = (uint *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8107a9e7;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,
		                                  System_Collections_Generic_IList_AuchanArtifactData__TypeInfo,0);
		code_r0x8107a9e7:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,iVar2,puVar4[1]);
		    iVar6 = Method_System_Collections_Generic_List_AuchanArtifactData__Add__;
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
		    if (DAT_ram_00a5986d == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		      DAT_ram_00a5986d = '\x01';
		    }
		    uVar1 = unnamed_function_1417(Gameplay_Auchan_Model_AuchanArtifactData_TypeInfo);
		    System_Collections_Generic_HashSet_object___Clear
		              (*(undefined4 *)(param1 + 0xbc),uVar1,
		               Method_System_Collections_Generic_HashSet_AuchanArtifactData__Add__);
		    iVar2 = Method_System_Collections_Generic_List_AuchanArtifactData__Add__;
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
		  goto code_r0x8107a806;
		}
		*/

		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x9C69", Offset = "0x9C69", VA = "0x9C69")]
		private void ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<AuchanArtifactCategoryData> categories, out List<AuchanArtifactData> resultList, out Dictionary<AuchanArtifactData, AuchanArtifactCategoryData> categoriesHash)
		{
		/* --- GHIDRA: ConvertCategoriesToListOfItemModels ---
		void Gameplay_Auchan_View_AuchanGridOsaView__ConvertCategoriesToListOfItemModels
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5984f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_AuchanGridWithCategoriesParams__AuchanArtifactCellViewHolder___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_AuchanArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_AuchanArtifactData__TypeInfo);
		    DAT_ram_00a5984f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_AuchanArtifactData__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_AuchanArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0xb8) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_HashSet_AuchanArtifactData__TypeInfo);
		  func_ii_7115(uVar1,Method_System_Collections_Generic_HashSet_AuchanArtifactData___ctor__);
		  *(undefined4 *)(param1 + 0xbc) = uVar1;
		  Sirenix_Utilities_GlobalConfig_object___get_ConfigAttribute
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_GridAdapter_AuchanGridWithCategoriesParams__AuchanArtifactCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x9C6A", Offset = "0x9C6A", VA = "0x9C6A")]
		public AuchanGridOsaView()
		{
		}

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0xB0")]
		private List<AuchanArtifactData> _data;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0xB4")]
		private Dictionary<AuchanArtifactData, AuchanArtifactCategoryData> _categoriesByArtifactHash;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<AuchanArtifactData> _categorySeparateItems;

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0xBC")]
		private HashSet<AuchanArtifactData> _rowCompletionItems;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Auchan_View_AuchanGridOsaView__get_Data(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59847 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_AuchanGridWithCategoriesParams__CellGroupViewsHolder_AuchanArtifactCellViewHolder___Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_AuchanGridWithCategoriesParams__CellGroupViewsHolder_AuchanArtifactCellViewHolder___get_IsInitialized__
		              );
		    DAT_ram_00a59847 = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_AuchanArtifactData__TypeInfo);
		    Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		              (param1_00,0,Method_System_Collections_Generic_List_AuchanArtifactData___ctor__);
		    *(undefined4 *)(param1 + 0xb0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_AuchanGridWithCategoriesParams__CellGroupViewsHolder_AuchanArtifactCellViewHolder___Start__
		              );
		  }
		  return;
		}
		*/

}
