using System;
using Il2CppDummyDll;
using UI.Requirements;
using UI.Rewards;
using UI.ToolTip.Implementations.View.Parts;
using UI.ToolTip.Implementations.VO;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	public class AprToolTipView : BaseToolTip<AprToolTipVO>
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x5D06", Offset = "0x5D06", VA = "0x5D06", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		undefined4
		UI_ToolTip_Implementations_View_AprToolTipView__HandleDataChanged
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5b8dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2581);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a5b8dc = '\x01';
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

		// Token: 0x0600099F RID: 2463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x5D07", Offset = "0x5D07", VA = "0x5D07")]
		private string FormatDuration(float msToSec)
		{
		/* --- GHIDRA: FormatDuration ---
		void UI_ToolTip_Implementations_View_AprToolTipView__FormatDuration
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_AprToolTipVO___ctor__);
		    DAT_ram_00a5b8dd = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_AprToolTipVO___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x5D08", Offset = "0x5D08", VA = "0x5D08")]
		public AprToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_AprToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b8de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_ClanRestrictionDic__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanRestrictionDic__get_Data__);
		    DAT_ram_00a5b8de = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = Core_Extensions_Dict_ClanRatingKindDicExt__GetDescription(*(int *)(param1 + 0x14),0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x1c);
		    uVar1 = Core_Extensions_Dict_ClanRestrictionDicExt__GetTitle(*(undefined4 *)(param1 + 0x14),0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x20);
		    uVar1 = Core_Extensions_Dict_ClanRestrictionDicExt__GetDescription
		                      (*(undefined4 *)(param1 + 0x14),0);
		    AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/AprToolTipView";

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AprViewWhitTitle _aprView;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;
	}
}
