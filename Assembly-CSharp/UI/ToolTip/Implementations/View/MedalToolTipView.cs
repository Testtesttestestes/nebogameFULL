using System;
using Il2CppDummyDll;
using UI.Requirements;
using UI.Rewards;
using UI.ToolTip.Implementations.View.Parts;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public class MedalToolTipView : BaseToolTip<MedalToolTipVO>
	{
		// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x5D17", Offset = "0x5D17", VA = "0x5D17", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		undefined4
		UI_ToolTip_Implementations_View_MedalToolTipView__HandleDataChanged
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5b8ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2581);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a5b8ed = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2581,1,0,1,0,0,0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param3_00 = Utils_TimeUtils__DateFormat((double)param2,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_118,param3_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x5D18", Offset = "0x5D18", VA = "0x5D18")]
		private string FormatDuration(float msToSec)
		{
		/* --- GHIDRA: FormatDuration ---
		void UI_ToolTip_Implementations_View_MedalToolTipView__FormatDuration
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8ee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_MedalToolTipVO___ctor__);
		    DAT_ram_00a5b8ee = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_MedalToolTipVO___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x5D19", Offset = "0x5D19", VA = "0x5D19")]
		public MedalToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_MedalToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  longlong lVar8;
		  longlong lVar9;
		  longlong lVar10;
		  longlong lVar11;
		  longlong lVar12;
		  longlong lVar13;
		  double dVar14;
		  int iVar15;
		  undefined8 local_20;
		  undefined8 local_18;
		  longlong local_10;
		  undefined8 local_8;
		  
		  lVar11 = 0;
		  lVar12 = 0;
		  lVar8 = 0;
		  lVar9 = 0;
		  if (DAT_ram_00a5b8ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_SkillToolTipInUserInfoVO__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_SkillToolTipInUserInfoVO__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_Image___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15126);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15123);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26375);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15124);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1235);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15127);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15122);
		    DAT_ram_00a5b8ef = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0x18);
		  uVar2 = func_ii_7990(*(undefined4 *)(*(int *)(param1 + 0x14) + 8),0);
		  iVar15 = *piVar6;
		  uVar1 = CONCAT44(in_register_20000004,piVar6);
		  (**(code **)((ulonglong)*(uint *)(iVar15 + 0x2d0) * 4))
		            (uVar1,uVar2,*(undefined4 *)(iVar15 + 0x2d4));
		  piVar6 = *(int **)(param1 + 0x1c);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Core_Extensions_Dict_UserRatingKindDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 8),0);
		  iVar15 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar15 + 0x2d0) * 4))
		            (CONCAT44(uVar2,piVar6),uVar3,*(undefined4 *)(iVar15 + 0x2d4));
		  iVar15 = *(int *)(param1 + 0x14);
		  if (*(int *)(iVar15 + 0xc) == 0) {
		    if (*(int *)(iVar15 + 0x10) == 0) {
		      uVar2 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		      uVar2 = unnamed_function_1417(uVar2);
		      uVar3 = unnamed_function_2232(&StringLiteral_11515);
		      System_NonSerializedAttribute___ctor(uVar2,uVar3,0);
		      uVar3 = unnamed_function_2232
		                        (&
		                         Method_UI_ToolTip_Implementations_View_SkillToolTipInUserInfoView_HandleDataChanged__
		                        );
		      func_ii_1050(uVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    lVar13 = *(longlong *)(*(int *)(iVar15 + 0x10) + 0x10);
		    lVar10 = lVar13;
		  }
		  else {
		    uVar2 = *(undefined4 *)(*(int *)(iVar15 + 8) + 0xc);
		    iVar15 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (*(undefined4 *)(*(int *)(*(int *)(iVar15 + 0xc) + 0x44) + 0x1c),uVar2,
		                        Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    lVar8 = *(longlong *)(iVar15 + 0x10);
		    iVar15 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (*(undefined4 *)
		                         (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x44) + 0x20),uVar2,
		                        Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    lVar9 = *(longlong *)(iVar15 + 0x18);
		    iVar15 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (*(undefined4 *)
		                         (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x44) + 0x18),uVar2,
		                        Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    lVar10 = *(longlong *)(iVar15 + 0x10);
		    iVar15 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (*(undefined4 *)
		                         (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x44) + 0x10),uVar2,
		                        Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    lVar11 = *(longlong *)(iVar15 + 0x10);
		    iVar15 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (*(undefined4 *)
		                         (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x44) + 0x14),uVar2,
		                        Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    lVar12 = *(longlong *)(iVar15 + 0x10);
		    iVar15 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (*(undefined4 *)
		                         (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x44) + 0xc),uVar2,
		                        Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    lVar13 = *(longlong *)(iVar15 + 0x10);
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0 < lVar10),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0 < lVar8 || 0 < lVar9),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)((0 < lVar12 || 0 < lVar13) || 0 < lVar11),0);
		  piVar6 = *(int **)(param1 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_15127,1,0,1,0,0,0,0);
		  iVar15 = Mono_Security_ASN1Convert__ToOid
		                     (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  dVar14 = (double)lVar10;
		  uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar14,StringLiteral_28780,0);
		  local_8 = 0;
		  uVar3 = (undefined4)((ulonglong)dVar14 >> 0x20);
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_28217,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar15 + 0x10) = local_8;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar15,0);
		  iVar15 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar15 + 0x2d0) * 4))
		            (CONCAT44(uVar3,piVar6),uVar2,*(undefined4 *)(iVar15 + 0x2d4));
		  piVar6 = *(int **)(param1 + 0x24);
		  uVar3 = func_ii_7508(StringLiteral_15123,1,0,1,0,0,0,0);
		  iVar15 = Mono_Security_ASN1Convert__ToOid
		                     (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  local_10 = lVar9;
		  uVar2 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  uVar2 = func_ii_4419(StringLiteral_1235,uVar2,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_26375,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar15 + 0x10) = local_18;
		  dVar14 = (double)lVar8;
		  uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar14,StringLiteral_28780,0);
		  local_20 = 0;
		  uVar2 = (undefined4)((ulonglong)dVar14 >> 0x20);
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,StringLiteral_28217,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar15 + 0x18) = local_20;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar3,iVar15,0);
		  iVar15 = *piVar6;
		  uVar1 = CONCAT44(uVar2,piVar6);
		  (**(code **)((ulonglong)*(uint *)(iVar15 + 0x2d0) * 4))
		            (uVar1,uVar3,*(undefined4 *)(iVar15 + 0x2d4));
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar15 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  uVar1 = CONCAT44(uVar2,iVar15);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar15,Method_System_Collections_Generic_List_string___ctor__);
		  if (lVar13 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15124,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar14 = (double)lVar13;
		    uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar14,StringLiteral_28780,0);
		    local_8 = 0;
		    uVar3 = (undefined4)((ulonglong)dVar14 >> 0x20);
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_28217,uVar4,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x10) = local_8;
		    uVar1 = CONCAT44(uVar3,uVar2);
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar5,0);
		    iVar5 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(iVar15 + 0x10) = *(int *)(iVar15 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar15 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar15 + 8) + 0xc)) {
		      *(uint *)(iVar15 + 0xc) = uVar7 + 1;
		      *(undefined4 *)(*(int *)(iVar15 + 8) + uVar7 * 4 + 0x10) = uVar2;
		    }
		    else {
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),iVar15);
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar15,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  if (lVar11 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15122,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar14 = (double)lVar11;
		    uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar14,StringLiteral_28780,0);
		    local_8 = 0;
		    uVar3 = (undefined4)((ulonglong)dVar14 >> 0x20);
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_28217,uVar4,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x10) = local_8;
		    uVar1 = CONCAT44(uVar3,uVar2);
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar5,0);
		    iVar5 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(iVar15 + 0x10) = *(int *)(iVar15 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar15 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar15 + 8) + 0xc)) {
		      *(uint *)(iVar15 + 0xc) = uVar7 + 1;
		      *(undefined4 *)(*(int *)(iVar15 + 8) + uVar7 * 4 + 0x10) = uVar2;
		    }
		    else {
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),iVar15);
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar15,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  if (lVar12 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15126,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar14 = (double)lVar12;
		    uVar4 = UI_SimpleIconValue__set_IconAssetId(dVar14,StringLiteral_28780,0);
		    local_8 = 0;
		    uVar3 = (undefined4)((ulonglong)dVar14 >> 0x20);
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_28217,uVar4,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x10) = local_8;
		    uVar1 = CONCAT44(uVar3,uVar2);
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar5,0);
		    iVar5 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(iVar15 + 0x10) = *(int *)(iVar15 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar15 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar15 + 8) + 0xc)) {
		      *(uint *)(iVar15 + 0xc) = uVar7 + 1;
		      *(undefined4 *)(*(int *)(iVar15 + 8) + uVar7 * 4 + 0x10) = uVar2;
		    }
		    else {
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),iVar15);
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar15,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  if (0 < *(int *)(iVar15 + 0xc)) {
		    uVar7 = 0;
		    do {
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar3 = *(undefined4 *)(param1 + 0x40);
		      uVar4 = *(undefined4 *)(param1 + 0x34);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar3 = func_ii_6805(uVar4,uVar3,Method_UnityEngine_Object_Instantiate_Image___);
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar3,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      iVar5 = 0x3c;
		      if ((uVar7 & 1) == 0) {
		        iVar5 = 0x38;
		      }
		      func_ii_7050(uVar3,*(undefined4 *)(param1 + iVar5),0);
		      piVar6 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                                (uVar3,
		                                 Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___
		                                );
		      uVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar15,uVar7,Method_System_Collections_Generic_List_string__get_Item__);
		      uVar1 = CONCAT44(uVar2,piVar6);
		      (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2d0) * 4))
		                (uVar1,uVar3,*(undefined4 *)(*piVar6 + 0x2d4));
		      uVar7 = uVar7 + 1;
		    } while ((int)uVar7 < *(int *)(iVar15 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/MedalToolTipView";

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MedalViewWhitTitle _medalView;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;
	}
}
