using System;
using Core.Data;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab
{
	// Token: 0x02000A18 RID: 2584
	[Token(Token = "0x2000A18")]
	public class CurrentLeagueInfo : MonoBehaviour
	{
		// Token: 0x06003D72 RID: 15730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x8C31", Offset = "0x8C31", VA = "0x8C31")]
		public void Init(ClanData clanData, string honorAssetId)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_CurrentLeagueInfo__Init
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57f48 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28651);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26089);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4327);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28658);
		    DAT_ram_00a57f48 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetTitle(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar1,0);
		  uVar5 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = Core_Extensions_Dict_ClanLeagueDicExt__GetTitle(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar1,0);
		  if (*(int *)(param2 + 0x20) == 0) {
		    local_10 = CONCAT44(local_10._4_4_,*(undefined4 *)(param2 + 0x1c));
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_10);
		    uVar1 = func_ii_4419(StringLiteral_28651,uVar1,0);
		  }
		  else {
		    local_10 = CONCAT44(local_10._4_4_,*(undefined4 *)(param2 + 0x1c));
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_10);
		    local_4 = *(undefined4 *)(param2 + 0x20);
		    uVar5 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28658,uVar1,uVar5,0);
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4327,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_26089,param4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar2,0);
		  iVar3 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		            (*(int **)(param1 + 0x20),uVar1,*(undefined4 *)(iVar3 + 0xec));
		  piVar4 = (int *)func_ii_7307(*(undefined4 *)(param1 + 0x14),param3,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))(piVar4,*(undefined4 *)(*piVar4 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D73")]
		[Address(RVA = "0x8C32", Offset = "0x8C32", VA = "0x8C32")]
		public void UpdateLeagueInfo(ClanLeagueDic dic, RewardData[] rewards, string placesText)
		{
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D74")]
		[Address(RVA = "0x8C33", Offset = "0x8C33", VA = "0x8C33")]
		public CurrentLeagueInfo()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_CurrentLeagueInfo___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57f49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__get_args__
		              );
		    DAT_ram_00a57f49 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = Core_Extensions_Dict_ClanWarResultDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x24),0);
		  AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = Core_Extensions_Dict_ClanSeasonDicExt__GetTitle
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x24),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x30),
		             *(undefined4 *)(*(int *)(*(int *)(param1 + 0x18) + 0x20) + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x04002246 RID: 8774
		[Token(Token = "0x4002246")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002247 RID: 8775
		[Token(Token = "0x4002247")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04002248 RID: 8776
		[Token(Token = "0x4002248")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClanLeagueBaseInfoView _baseLeagueInfo;

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _leagueName;

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleIconValueBackground _honorRange;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _description;
	}
}
