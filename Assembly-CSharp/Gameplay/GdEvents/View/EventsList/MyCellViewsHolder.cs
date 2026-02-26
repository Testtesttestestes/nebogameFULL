using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	public class MyCellViewsHolder : CellViewsHolder
	{
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000864")]
		public GdEventItemView ItemRender
		{
			[Token(Token = "0x6002C20")]
			[Address(RVA = "0x7CB0", Offset = "0x7CB0", VA = "0x7CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C21")]
			[Address(RVA = "0x7CB1", Offset = "0x7CB1", VA = "0x7CB1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x7CB2", Offset = "0x7CB2", VA = "0x7CB2", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellViewsHolder__CollectViews
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a541b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_596);
		    Mono_Security_ASN1__get_Item(&StringLiteral_267);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a541b9 = '\x01';
		  }
		  if (*(uint *)(param2 + 0x20) == 0) {
		    UnityEngine_Object__op_Implicit(param1[7],1,0);
		    UnityEngine_Object__op_Implicit(param1[6],1,0);
		    iVar3 = *(int *)param1[5];
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x1a0) * 4))
		              ((int *)param1[5],0,*(undefined4 *)(iVar3 + 0x1a4));
		    piVar2 = (int *)param1[6];
		    iVar3 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		    *(undefined4 *)(iVar3 + 0x10) = StringLiteral_596;
		    local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4));
		    uVar1 = func_ii_4443(&local_4,0);
		    *(undefined4 *)(iVar3 + 0x14) = uVar1;
		    *(undefined4 *)(iVar3 + 0x18) = StringLiteral_267;
		    uVar1 = func_ii_4443(param2 + 0xc,0);
		    *(undefined4 *)(iVar3 + 0x1c) = uVar1;
		    *(undefined4 *)(iVar3 + 0x20) = StringLiteral_19094;
		    uVar1 = System_Single__ToString(iVar3,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x318) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x31c));
		    iVar3 = *(int *)param1[7];
		    local_10 = *(undefined8 *)(param2 + 0x18);
		    local_18 = *(undefined8 *)(param2 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x178) * 4))
		              ((int *)param1[7],&local_18,*(undefined4 *)(iVar3 + 0x17c));
		  }
		  else if (*(uint *)(param2 + 0x20) < 3) {
		    UnityEngine_Object__op_Implicit(param1[7],0,0);
		    UnityEngine_Object__op_Implicit(param1[6],0,0);
		    iVar3 = *(int *)param1[5];
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x1a0) * 4))
		              ((int *)param1[5],1,*(undefined4 *)(iVar3 + 0x1a4));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_NestedScrollViews_MyCellViewsHolder__CollectViews
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x318) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(param2 + 8),*(undefined4 *)(iVar1 + 0x31c));
		  func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param2 + 0xc),0);
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_NestedScrollViewsSameDirection_MyCellViewsHolder__CollectViews
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x318) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(param2 + 8),*(undefined4 *)(iVar1 + 0x31c));
		  iVar1 = **(int **)(param1 + 0x1c);
		  local_8 = *(undefined8 *)(param2 + 0x14);
		  local_10 = *(undefined8 *)(param2 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x1c),&local_10,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyCellViewsHolder__CollectViews
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a540cf == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_596);
		    Mono_Security_ASN1__get_Item(&StringLiteral_267);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a540cf = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		  *(undefined4 *)(iVar1 + 0x10) = StringLiteral_596;
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		  uVar2 = func_ii_4443(&local_4,0);
		  *(undefined4 *)(iVar1 + 0x14) = uVar2;
		  *(undefined4 *)(iVar1 + 0x18) = StringLiteral_267;
		  uVar2 = func_ii_4443(param2 + 8,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  *(undefined4 *)(iVar1 + 0x20) = StringLiteral_19094;
		  uVar2 = System_Single__ToString(iVar1,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x318) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x31c));
		  iVar1 = *(int *)param1[7];
		  local_10 = *(undefined8 *)(param2 + 0x14);
		  local_18 = *(undefined8 *)(param2 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            ((int *)param1[7],&local_18,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_SelectAndDelete_MyCellViewsHolder__CollectViews
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a540b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_596);
		    Mono_Security_ASN1__get_Item(&StringLiteral_267);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19094);
		    DAT_ram_00a540b2 = '\x01';
		  }
		  piVar3 = (int *)param1[6];
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		  *(undefined4 *)(iVar1 + 0x10) = StringLiteral_596;
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		  uVar2 = func_ii_4443(&local_4,0);
		  *(undefined4 *)(iVar1 + 0x14) = uVar2;
		  *(undefined4 *)(iVar1 + 0x18) = StringLiteral_267;
		  uVar2 = func_ii_4443(param2 + 8,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  *(undefined4 *)(iVar1 + 0x20) = StringLiteral_19094;
		  uVar2 = System_Single__ToString(iVar1,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x318) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x31c));
		  iVar1 = *(int *)param1[9];
		  local_10 = *(undefined8 *)(param2 + 0x14);
		  local_18 = *(undefined8 *)(param2 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            ((int *)param1[9],&local_18,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Gameplay_GdEvents_View_EventsList_MyCellViewsHolder__CollectViews
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (*(uint *)(param2 + 0x10) == 0) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x18),1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1a0) * 4))
		              (*(int **)(param1 + 0x14),0,*(undefined4 *)(iVar2 + 0x1a4));
		    iVar2 = *(int *)(param1 + 0x18);
		    *(undefined4 *)(iVar2 + 0x30) = param4;
		    if (*(int *)(iVar2 + 0x34) != param2) {
		      *(int *)(iVar2 + 0x34) = param2;
		      Gameplay_GdEvents_View_EventsList_GdEventItemView__set_Data(iVar2,iVar2);
		    }
		  }
		  else if (*(uint *)(param2 + 0x10) < 3) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x18),0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    iVar2 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x1a0) * 4))
		              (*(int **)(param1 + 0x14),1,*(undefined4 *)(iVar2 + 0x1a4));
		    return;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x7CB3", Offset = "0x7CB3", VA = "0x7CB3")]
		public void UpdateViews(CellModel model, MyGridParams parameters, Action<CellModel> clickCallback)
		{
		/* --- GHIDRA: UpdateViews ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellViewsHolder__UpdateViews
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x1c),param2,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x18),param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: UpdateViews ---
		void Gameplay_GdEvents_View_EventsList_MyCellViewsHolder__UpdateViews
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x7CB4", Offset = "0x7CB4", VA = "0x7CB4")]
		private void SetVisible(bool enabled)
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x7CB5", Offset = "0x7CB5", VA = "0x7CB5")]
		public MyCellViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_Grid_MyCellViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  undefined4 param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a541ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_Grid_GridSceneEntry_OnFreezeContentEndEdgeToggleValueChanged__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a541ca = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_Drawer_DrawerCommandPanel__Init
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x10),1,0,1,0,0,0,0);
		  piVar1 = *(int **)(*(int *)(*(int *)(param1 + 0x14) + 0x74) + 0x1c);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x238) * 4))
		            (piVar1,0x3dcccccd,*(undefined4 *)(iVar2 + 0x23c));
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x68) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Com_TheFallenGames_OSA_Demos_Grid_GridSceneEntry_OnFreezeContentEndEdgeToggleValueChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyCellViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a541ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__CollectViews__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Text___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Transform___
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_8811);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8810);
		    DAT_ram_00a541ba = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_object____ctor
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__CollectViews__
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  UnityEngine_UI_ContentSizeFitter__get_verticalFit(uVar1,2,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x24),1,0);
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 8),StringLiteral_8810,param1 + 0x28,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Transform___
		            );
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 0x28),StringLiteral_8811,param1 + 0x2c,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Text___
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyCellViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a540d0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__CollectViews__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		    DAT_ram_00a540d0 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_object____ctor
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__CollectViews__
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  UnityEngine_UI_ContentSizeFitter__get_verticalFit(uVar1,2,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x24),1,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_SelectAndDelete_MyCellViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param2_00;
		  
		  if (DAT_ram_00a540b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_int__BasicModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_SelectAndDeleteExample__MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___InitAdapters__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_SelectAndDelete_SelectAndDeleteSceneEntry_CreateNewModel__
		              );
		    DAT_ram_00a540b3 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_object__object__object___Awake
		            (param1,
		             Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_SelectAndDeleteExample__MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___InitAdapters__
		            );
		  param2_00 = *(int *)(*(int *)(param1 + 0x10) + 0x10);
		  param1_00 = unnamed_function_1417(System_Func_int__BasicModel__TypeInfo);
		  System_Func_int__InternedString___Invoke
		            (param1_00,param1,
		             Method_Com_TheFallenGames_OSA_Demos_SelectAndDelete_SelectAndDeleteSceneEntry_CreateNewModel__
		             ,0);
		  param1_01 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel__TypeInfo);
		  UnityEngine_UIElements_Layout_LayoutList___Il2CppFullySharedGenericStructType___get_Item
		            (param1_01,param2_00,param1_00,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_LazyDataHelper_BasicModel___ctor__);
		  *(undefined4 *)(param2_00 + 0xb4) = param1_01;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (param2_00,
		             Method_Com_TheFallenGames_OSA_Core_OSA_MyGridParams__CellGroupViewsHolder_MyCellViewsHolder___Init__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_EventsList_MyCellViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__CollectViews__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_TextMeshProUGUI___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Transform___
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_8810);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8813);
		    DAT_ram_00a5a2a4 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_object____ctor
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MyCellViewsHolder__CollectViews__
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  UnityEngine_UI_ContentSizeFitter__get_verticalFit(uVar1,2,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x24),1,0);
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 8),StringLiteral_8810,param1 + 0x28,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Transform___
		            );
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 0x28),StringLiteral_8813,param1 + 0x2c,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_TextMeshProUGUI___
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ItemRender ---
		void Gameplay_GdEvents_View_EventsList_MyCellViewsHolder__set_ItemRender
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a2a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_GdEventItemView___);
		    DAT_ram_00a5a2a3 = '\x01';
		  }
		  local_4 = 0;
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellViewsHolder__InitWithExistingRootPrefab
		            (param1,0);
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(param1 + 8),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_GdEventItemView___);
		  if (iVar1 != 0) {
		    *(undefined4 *)(param1 + 0x18) = local_4;
		  }
		  return;
		}
		*/

}
