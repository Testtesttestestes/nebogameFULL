using System;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations.VO.Monster;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class IslandMonsterToolTipView : BaseToolTip<AbstractMonsterToolTipVO>
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x5D13", Offset = "0x5D13", VA = "0x5D13", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_IslandMonsterToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_AbstractMonsterToolTipVO___ctor__);
		    DAT_ram_00a5b8e9 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_AbstractMonsterToolTipVO___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x5D14", Offset = "0x5D14", VA = "0x5D14")]
		public IslandMonsterToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_IslandMonsterToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b8ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_AprMarkerToolTipVO__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_AprMarkerToolTipVO__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5b8ea = '\x01';
		  }
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x14) + 0xc),0);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x28);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar2,0);
		  piVar1 = (int *)func_ii_7307(param1_00,uVar2,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/IslandMonsterToolTipView";

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _subDescription;
	}
}
