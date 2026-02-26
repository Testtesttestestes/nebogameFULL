using System;
using Il2CppDummyDll;
using UI.Requirements;
using UI.ToolTip.Implementations.VO.Monster;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class IslandBossMonsterToolTipView : BaseToolTip<IslandBossMonsterToolTipVO>
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x5D11", Offset = "0x5D11", VA = "0x5D11", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_IslandBossMonsterToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_IslandBossMonsterToolTipVO___ctor__)
		    ;
		    DAT_ram_00a5b8e7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_IslandBossMonsterToolTipVO___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x5D12", Offset = "0x5D12", VA = "0x5D12")]
		public IslandBossMonsterToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_IslandBossMonsterToolTipView___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b8e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_AbstractMonsterToolTipVO__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_AbstractMonsterToolTipVO__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10310);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15119);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5b8e8 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  if (piVar4 != (int *)0x0) {
		    piVar5 = *(int **)(param1 + 0x18);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe8) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xec));
		    iVar6 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar5,uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		    piVar4 = *(int **)(param1 + 0x1c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_10310,1,0,1,0,0,0,0);
		    iVar2 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar6 = **(int **)(param1 + 0x14);
		    local_4 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xe0) * 4))
		                        (*(int **)(param1 + 0x14),*(undefined4 *)(iVar6 + 0xe4));
		    iVar6 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    local_10 = 0;
		    if (iVar6 == 0) {
		      iVar6 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_28217,iVar6,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar2 + 0x10) = local_10;
		    uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar1,iVar2,0);
		    iVar6 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar4,uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		    piVar4 = *(int **)(param1 + 0x20);
		    iVar6 = **(int **)(param1 + 0x14);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xf0) * 4))
		                      (*(int **)(param1 + 0x14),*(undefined4 *)(iVar6 + 0xf4));
		    iVar6 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar4,uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		    piVar4 = *(int **)(param1 + 0x24);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_15119,1,0,1,0,0,0,0);
		    iVar6 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar2 = **(int **)(param1 + 0x14);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf8) * 4))
		                      (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0xfc));
		    uVar3 = func_ii_7508(uVar3,1,0,1,0,0,0,0);
		    local_18 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_28217,uVar3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x10) = local_18;
		    uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar1,iVar6,0);
		    iVar6 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (piVar4,uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/IslandBossMonsterToolTipView";

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private IslandMonsterToolTipView _monsterToolTipView;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;
	}
}
