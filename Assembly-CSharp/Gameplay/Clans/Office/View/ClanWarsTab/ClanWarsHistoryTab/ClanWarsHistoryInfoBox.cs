using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A1B RID: 2587
	[Token(Token = "0x2000A1B")]
	public class ClanWarsHistoryInfoBox : MonoBehaviour
	{
		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C36")]
		public Button WarButton
		{
			[Token(Token = "0x6003D79")]
			[Address(RVA = "0x8C38", Offset = "0x8C38", VA = "0x8C38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7A")]
		[Address(RVA = "0x8C39", Offset = "0x8C39", VA = "0x8C39")]
		public void Init(string honorAssetId)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryInfoBox__Init
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  int *piVar7;
		  undefined8 uVar8;
		  longlong lVar9;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57f4c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21186);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2181);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4269);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2084);
		    DAT_ram_00a57f4c = '\x01';
		  }
		  local_4 = 0;
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Core_Extensions_Dict_ClanSeasonDicExt__GetTitle(param3,0);
		  uVar8 = *(undefined8 *)(param2 + 0x30);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar2 = Utils_TimeUtils__DateFormat(uVar8,0);
		  uVar5 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_118,uVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_ClanWarResultDicExt__GetTitle(param3,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_21186,*(undefined4 *)(param2 + 0x18),
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_10;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar1,0);
		  iVar3 = **(int **)(param1 + 0x1c);
		  uVar8 = CONCAT44(uVar5,*(int **)(param1 + 0x1c));
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		            (uVar8,*(undefined4 *)(param2 + 0x24),*(undefined4 *)(iVar3 + 0xe4));
		  uVar1 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  UI_Price_Price__SetColor(uVar5,0,uVar4,0);
		  lVar9 = (longlong)*(int *)(param2 + 0x2c);
		  iVar3 = **(int **)(param1 + 0x20);
		  uVar8 = CONCAT44(uVar1,*(int **)(param1 + 0x20));
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))(uVar8,lVar9,*(undefined4 *)(iVar3 + 0xe4));
		  uVar4 = (undefined4)((ulonglong)lVar9 >> 0x20);
		  uVar1 = (undefined4)((ulonglong)uVar8 >> 0x20);
		  uVar5 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4269,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_4 = *(undefined4 *)(param2 + 0x20);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_25096,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_18;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar2,0);
		  uVar6 = *(uint *)(param2 + 0x38);
		  if ((int)uVar6 < 0) {
		    iVar3 = unnamed_function_1417
		                      (
		                      Core_Errors_Expected_Clans_ExpectedClanWarErrors_ExpectedClanWarsErrorsArgs_TypeInfo
		                      );
		    *(undefined1 *)(iVar3 + 8) = 0;
		    piVar7 = *(int **)(param1 + 0x28);
		    uVar5 = Core_Errors_Expected_Clans_ExpectedClanWarErrors__Handle
		                      (*(undefined4 *)(param2 + 0x38),iVar3,0);
		    uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_2181,uVar5,StringLiteral_2084,0);
		    iVar3 = *piVar7;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf0) * 4))
		              (CONCAT44(uVar1,piVar7),CONCAT44(uVar4,uVar5),*(undefined4 *)(iVar3 + 0xf4));
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar6 >> 0x1f,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7B")]
		[Address(RVA = "0x8C3A", Offset = "0x8C3A", VA = "0x8C3A")]
		public void UpdateHistory(ProtoGetWarsHistoryAns.Types.WarHistoryRecord history, ClanWarResultDic result)
		{
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D7C")]
		[Address(RVA = "0x8C3B", Offset = "0x8C3B", VA = "0x8C3B")]
		public ClanWarsHistoryInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryInfoBox___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryViewsHolder_TypeInfo
		              );
		    DAT_ram_00a57f4d = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryViewsHolder_TypeInfo
		                    );
		  if (DAT_ram_00a57f50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_ClanWarHistoryListElement___ctor__);
		    DAT_ram_00a57f50 = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TitleIconValueBackground _enemyHonor;

		// Token: 0x04002257 RID: 8791
		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleIconValueBackground _honorDelta;

		// Token: 0x04002258 RID: 8792
		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _zigguratLevel;

		// Token: 0x04002259 RID: 8793
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TitleRowView _titleRow;

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _warButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WarButton ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarsHistoryInfoBox__get_WarButton
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId
		            (*(undefined4 *)(param1 + 0x1c),param2,0);
		  Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId
		            (*(undefined4 *)(param1 + 0x20),param2,0);
		  return;
		}
		*/

}
