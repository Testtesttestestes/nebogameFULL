using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public class ClanCurseToolTipView : BaseToolTip<ClanRestrictionDic>
	{
		// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x5D09", Offset = "0x5D09", VA = "0x5D09", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_ClanCurseToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanRestrictionDic___ctor__);
		    DAT_ram_00a5b8df = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_ClanRestrictionDic___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x5D0A", Offset = "0x5D0A", VA = "0x5D0A")]
		public ClanCurseToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_ClanCurseToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int *piVar2;
		  int *piVar3;
		  int iVar4;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b8e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_ClanBuildingData__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanBuildingData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10310);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5b8e0 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x14);
		  if (piVar2 != (int *)0x0) {
		    piVar3 = *(int **)(param1 + 0x18);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		    piVar2 = *(int **)(param1 + 0x1c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_10310,1,0,1,0,0,0,0);
		    param2_00 = Mono_Security_ASN1Convert__ToOid
		                          (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                        (*(undefined4 *)(param1 + 0x14),0);
		    iVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    local_10 = 0;
		    if (iVar4 == 0) {
		      iVar4 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_28217,iVar4,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(param2_00 + 0x10) = local_10;
		    uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar1,param2_00,0);
		    iVar4 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		    piVar2 = *(int **)(param1 + 0x20);
		    iVar4 = **(int **)(param1 + 0x14);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf0) * 4))
		                      (*(int **)(param1 + 0x14),*(undefined4 *)(iVar4 + 0xf4));
		    iVar4 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ClanCurseToolTipView";

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameImage _icon;
	}
}
