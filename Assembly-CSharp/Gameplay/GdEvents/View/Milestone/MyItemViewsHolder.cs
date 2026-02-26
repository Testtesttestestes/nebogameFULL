using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.Milestone
{
	// Token: 0x02000722 RID: 1826
	[Token(Token = "0x2000722")]
	public class MyItemViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000853")]
		public MilestoneItemView ItemRender
		{
			[Token(Token = "0x6002BB5")]
			[Address(RVA = "0x7C4C", Offset = "0x7C4C", VA = "0x7C4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BB6")]
			[Address(RVA = "0x7C4D", Offset = "0x7C4D", VA = "0x7C4D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB7")]
		[Address(RVA = "0x7C4E", Offset = "0x7C4E", VA = "0x7C4E", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder__CollectViews
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a541ee == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a541ee = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__CollectViews(param1,0);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x1c),1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Com_TheFallenGames_OSA_Demos_Simple_MyItemViewsHolder__CollectViews
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a54094 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_145);
		    DAT_ram_00a54094 = '\x01';
		  }
		  piVar2 = (int *)param1[5];
		  param1_00 = *(undefined4 *)(param2 + 8);
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		  uVar1 = func_ii_4443(&local_4,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (param1_00,StringLiteral_145,uVar1,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x318) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x31c));
		  return;
		}
		*/

		/* --- GHIDRA: CollectViews ---
		void Gameplay_GdEvents_View_Milestone_MyItemViewsHolder__CollectViews
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  iVar1 = param1[5];
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		  if (DAT_ram_00a5a266 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a266 = '\x01';
		  }
		  piVar2 = *(int **)(iVar1 + 0x10);
		  local_4 = local_4 + 1;
		  iVar1 = func_ii_4443(&local_4,0);
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x7C4F", Offset = "0x7C4F", VA = "0x7C4F")]
		public void UpdateTitleByItemIndex(MilestoneData model)
		{
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x7C50", Offset = "0x7C50", VA = "0x7C50")]
		public MyItemViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_CustomAdapters_DateTimePicker_MyItemViewsHolder___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a542c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DateTime__TypeInfo);
		    DAT_ram_00a542c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_DateTime__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_DateTime__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  undefined4 param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a541f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_ContentSizeFitter_ContentSizeFitterSceneEntry_OnFreezeContentEndEdgeToggleValueChanged__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a541f2 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_Drawer_DrawerCommandPanel__Init
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x10),1,0,1,0,1,1,param1);
		  piVar1 = *(int **)(*(int *)(*(int *)(param1 + 0x14) + 0x74) + 0x1c);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x238) * 4))(piVar1,0,*(undefined4 *)(iVar2 + 0x23c));
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x68) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Com_TheFallenGames_OSA_Demos_ContentSizeFitter_ContentSizeFitterSceneEntry_OnFreezeContentEndEdgeToggleValueChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_MyItemViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a54179 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry_OnFreezeContentEndEdgeToggleValueChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry_OnRandomSizesForNewItemsToggleValueChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry__InitDrawer_b__2_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry__InitDrawer_b__2_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_Core_OSA_MyParams__MyItemViewsHolder__get_Parameters__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10899);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13313);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a54179 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_Drawer_DrawerCommandPanel__Init
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x10),0,0,1,1,0,0,0);
		  piVar2 = *(int **)(*(int *)(*(int *)(param1 + 0x14) + 0x74) + 0x1c);
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x238) * 4))(piVar2,0,*(undefined4 *)(iVar4 + 0x23c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x68) + 0xc0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar1,param1,
		             Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry_OnFreezeContentEndEdgeToggleValueChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x6c) + 0x10) + 0xe4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry__InitDrawer_b__2_0__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  iVar4 = Com_TheFallenGames_OSA_Demos_Common_Drawer_DrawerCommandPanel__AddButtonWithInputPanel
		                    (*(undefined4 *)(param1 + 0x14),StringLiteral_10899,0);
		  *(int *)(param1 + 0x1c) = iVar4;
		  UnityEngine_UI_InputField__get_keyboardType(*(undefined4 *)(iVar4 + 0x10),4,0);
		  UnityEngine_UI_InputField__get_characterLimit(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x10),2,0)
		  ;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x10);
		  iVar4 = func_ii_4443(*(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x10) + 0x10) + 0x5c,0);
		  if (iVar4 == 0) {
		    iVar4 = StringLiteral_5;
		  }
		  UnityEngine_UI_InputField__get_text(uVar1,iVar4,0);
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x10) + 0xe4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,
		               Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry__InitDrawer_b__2_1__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  iVar4 = Com_TheFallenGames_OSA_Demos_Common_Drawer_DrawerCommandPanel__AddButtonsWithOptionalInputPanel
		                    (*(undefined4 *)(param1 + 0x14),StringLiteral_13313,0);
		  *(int *)(param1 + 0x20) = iVar4;
		  uVar3 = *(undefined4 *)(*(int *)(iVar4 + 0x14) + 0xc0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar1,param1,
		             Method_Com_TheFallenGames_OSA_Demos_IncrementalItemFetch_IncrementalItemFetchSceneEntry_OnRandomSizesForNewItemsToggleValueChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_LoopingSpinners_MyItemViewsHolder___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a54149 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Sort_LoopingSpinnerExample___);
		    Mono_Security_ASN1__get_Item(&System_Comparison_LoopingSpinnerExample__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_LoopingSpinnerExample__MyParams__MyItemViewsHolder__InitAdapters__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c__InitAdapters_b__2_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo)
		    ;
		    DAT_ram_00a54149 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_object__object__object___Awake
		            (param1,
		             Method_Com_TheFallenGames_OSA_Demos_Common_SceneEntries_SceneEntry_LoopingSpinnerExample__MyParams__MyItemViewsHolder__InitAdapters__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(
		                  Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo
		                  );
		  }
		  puVar1 = *(undefined4 **)
		            (Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo +
		            0x5c);
		  param1_01 = puVar1[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo
		                    );
		      puVar1 = *(undefined4 **)
		                (Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo
		                + 0x5c);
		    }
		    param2_00 = *puVar1;
		    param1_01 = unnamed_function_1417(System_Comparison_LoopingSpinnerExample__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (param1_01,param2_00,
		               Method_Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c__InitAdapters_b__2_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Com_TheFallenGames_OSA_Demos_LoopingSpinners_LoopingSpinnersSceneEntry___c_TypeInfo
		                     + 0x5c) + 4) = param1_01;
		  }
		  System_Array__Sort_int_(param1_00,param1_01,Method_System_Array_Sort_LoopingSpinnerExample___);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_Simple_MyItemViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  Com_TheFallenGames_OSA_Demos_Common_Drawer_DrawerCommandPanel__Init
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x10),1,0,1,0,1,1,0);
		  piVar1 = *(int **)(*(int *)(*(int *)(param1 + 0x14) + 0x74) + 0x1c);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x238) * 4))(piVar1,0,*(undefined4 *)(iVar2 + 0x23c));
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_MyItemViewsHolder___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a270 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_ArtikulData__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtikulView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_ArtikulData__get_InteractiveMode__
		              );
		    DAT_ram_00a5a270 = '\x01';
		  }
		  if ((param3 != 0) && (iVar4 = *(int *)(param3 + 8), 0 < *(int *)(iVar4 + 0xc))) {
		    iVar1 = 0;
		    do {
		      uVar5 = *(undefined4 *)(iVar4 + iVar1 * 4 + 0x10);
		      param2_00 = *(undefined4 *)(param1 + 0x14);
		      param1_00 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      piVar2 = (int *)func_ii_6805(param1_00,param2_00,
		                                   Method_UnityEngine_Object_Instantiate_ArtikulView___);
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x138) * 4))
		                (piVar2,uVar5,*(undefined4 *)(*piVar2 + 0x13c));
		      iVar3 = Gameplay_GdEvents_Model_Milestone_StageContentData___Il2CppFullySharedGenericType____ctor
		                        (param3,
		                         Method_Gameplay_GdEvents_Model_Milestone_StageContentData_ArtikulData__get_InteractiveMode__
		                        );
		      *(bool *)(piVar2 + 0x11) = iVar3 == 0;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ItemRender ---
		void Gameplay_GdEvents_View_Milestone_MyItemViewsHolder__set_ItemRender
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a26f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_MilestoneItemView___)
		    ;
		    DAT_ram_00a5a26f = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(param1 + 8),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_MilestoneItemView___);
		  if (iVar1 != 0) {
		    *(undefined4 *)(param1 + 0x14) = local_4;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CSF ---
		void Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder__set_CSF
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a541ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_ContentSizeFitter___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_RawImage___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Text___
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_16238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9194);
		    DAT_ram_00a541ed = '\x01';
		  }
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                           Method_UnityEngine_Component_GetComponent_ContentSizeFitter___);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_Object__op_Implicit(param1_00,0,0);
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 8),StringLiteral_16238,param1 + 0x14,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Text___
		            );
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 8),StringLiteral_9194,param1 + 0x18,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_RawImage___
		            );
		  return;
		}
		*/


		/* --- GHIDRA: MarkForRebuild ---
		void Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder__MarkForRebuild
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a541ef == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a541ef = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x1c),0,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: UnmarkForRebuild ---
		void Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder__UnmarkForRebuild
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a541f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a541f0 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder__UpdateFromModel
		            (param1,param2,param1);
		  param2_00 = *(undefined4 *)(param3 + *(int *)(param2 + 8) * 4 + 0x10);
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x80);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,param2_00,0);
		  if (iVar1 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		              (*(undefined4 *)(param1 + 0x18),param2_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: UpdateFromModel ---
		void Com_TheFallenGames_OSA_Demos_ContentSizeFitter_MyItemViewsHolder__UpdateFromModel
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a541f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18842);
		    DAT_ram_00a541f1 = '\x01';
		  }
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		  uVar1 = func_ii_4443(&local_4,0);
		  uVar1 = System_Int32__ToString
		                    (StringLiteral_18842,uVar1,StringLiteral_19096,*(undefined4 *)(param2 + 0x10),0)
		  ;
		  iVar2 = *(int *)param1[5];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x310) * 4))
		                        ((int *)param1[5],*(undefined4 *)(iVar2 + 0x314));
		  iVar2 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (param1_00,uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = *(int *)param1[5];
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x318) * 4))
		              ((int *)param1[5],uVar1,*(undefined4 *)(iVar2 + 0x31c));
		  }
		  return;
		}
		*/

}
