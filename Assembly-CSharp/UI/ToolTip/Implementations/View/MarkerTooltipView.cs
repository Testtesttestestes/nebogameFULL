using System;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class MarkerTooltipView : BaseToolTip<AprMarkerToolTipVO>
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x5D15", Offset = "0x5D15", VA = "0x5D15", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_MarkerTooltipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_AprMarkerToolTipVO___ctor__);
		    DAT_ram_00a5b8eb = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_AprMarkerToolTipVO___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x5D16", Offset = "0x5D16", VA = "0x5D16")]
		public MarkerTooltipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_MarkerTooltipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  float fVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  longlong param1_00;
		  uint param2_00;
		  int iVar8;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b8ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_MedalToolTipVO__HandleDataChanged__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_MedalToolTipVO__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10733);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13144);
		    DAT_ram_00a5b8ec = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    iVar8 = **(int **)(param1 + 0x18);
		    uVar1 = CONCAT44(in_register_20000004,*(int **)(param1 + 0x18));
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x138) * 4))
		              (uVar1,*(undefined4 *)(*(int *)(param1 + 0x14) + 8),*(undefined4 *)(iVar8 + 0x13c));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle__HandleDataChanged
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x14) + 0xc),0);
		    uVar6 = *(undefined4 *)(param1 + 0x18);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_10733,1,0,1,0,0,0,0);
		    iVar8 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    uVar7 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x10) + 0x20);
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar7 = Utils_SetAsFirstSibling___ctor(uVar7,0);
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_28217,uVar7,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar8 + 0x10) = local_8;
		    uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar3,iVar8,0);
		    UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle__SetTitle(uVar6,uVar3,0);
		    iVar8 = *(int *)(*(int *)(param1 + 0x14) + 0x10);
		    uVar6 = func_ii_7508(StringLiteral_13144,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar8 + 0x24) = uVar6;
		    UI_Requirements_RequirementsView__get_Data
		              (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    if (*(int *)(*(int *)(param1 + 0x14) + 0x14) == 0) {
		      param2_00 = (uint)(*(longlong *)
		                          (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x10) + 0x40) != 0);
		    }
		    else {
		      param2_00 = 1;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,param2_00,0);
		    iVar8 = *(int *)(*(int *)(param1 + 0x14) + 0x14);
		    if (iVar8 == 0) {
		      param1_00 = *(longlong *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x10) + 0x40);
		      if (param1_00 != 0) {
		        piVar5 = *(int **)(param1 + 0x20);
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        fVar4 = Utils_StringUtils___cctor(param1_00,0);
		        uVar2 = (undefined4)((ulonglong)param1_00 >> 0x20);
		        uVar6 = UI_ToolTip_Implementations_View_MedalToolTipView__HandleDataChanged
		                          (param1,fVar4,param1);
		        if (piVar5[7] != 0) {
		          func_ii_7950(piVar5[7],0);
		          piVar5[7] = 0;
		        }
		        uVar1 = CONCAT44(uVar2,piVar5);
		        (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                  (uVar1,uVar6,*(undefined4 *)(*piVar5 + 0xe4));
		        uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      }
		    }
		    else {
		      piVar5 = *(int **)(param1 + 0x20);
		      fVar4 = func_ii_7103(iVar8,0);
		      uVar6 = UI_ToolTip_Implementations_View_MedalToolTipView__HandleDataChanged
		                        (param1,fVar4,param1);
		      if (piVar5[7] != 0) {
		        func_ii_7950(piVar5[7],0);
		        piVar5[7] = 0;
		      }
		      uVar1 = CONCAT44(uVar2,piVar5);
		      (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                (uVar1,uVar6,*(undefined4 *)(*piVar5 + 0xe4));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		    uVar6 = *(undefined4 *)(param1 + 0x24);
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x10) + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar3,0);
		    piVar5 = (int *)func_ii_7307(uVar6,uVar3,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xf0) * 4))
		              (CONCAT44(uVar2,piVar5),*(undefined4 *)(*piVar5 + 0xf4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/MarkerTooltipView";

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewards;
	}
}
