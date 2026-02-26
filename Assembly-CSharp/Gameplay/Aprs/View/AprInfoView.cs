using System;
using Gameplay.Aprs.Model;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4F RID: 3407
	[Token(Token = "0x2000D4F")]
	public class AprInfoView : MonoBehaviour
	{
		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F1")]
		private string DurationPrefix
		{
			[Token(Token = "0x6005374")]
			[Address(RVA = "0xA133", Offset = "0xA133", VA = "0xA133")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010F2")]
		public AprData AprData
		{
			[Token(Token = "0x6005375")]
			[Address(RVA = "0xA134", Offset = "0xA134", VA = "0xA134")]
			set
			{
			}
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005376")]
		[Address(RVA = "0xA135", Offset = "0xA135", VA = "0xA135")]
		private string FormatDuration(float rawValue)
		{
		/* --- GHIDRA: FormatDuration ---
		void Gameplay_Aprs_View_AprInfoView__FormatDuration(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a593f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_View_CollectionRowHelper_TypeInfo);
		    DAT_ram_00a593f0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Collections_View_CollectionRowHelper_TypeInfo);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005377")]
		[Address(RVA = "0xA136", Offset = "0xA136", VA = "0xA136")]
		public AprInfoView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Aprs_View_AprInfoView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a593f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12561);
		    DAT_ram_00a593f1 = '\x01';
		  }
		  return StringLiteral_12561;
		}
		*/

		}

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _desc;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _legendaryViewStub;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CollectionRowHelper _collectionRow;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x2C")]
		private AprData _aprData;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x30")]
		private string _durationPrefix;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DurationPrefix ---
		void Gameplay_Aprs_View_AprInfoView__get_DurationPrefix(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float param2_00;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 param4;
		  int param1_00;
		  undefined8 uVar6;
		  uint uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a593ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprInfoView_FormatDuration__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13144);
		    DAT_ram_00a593ee = '\x01';
		  }
		  *(int *)(param1 + 0x2c) = param2;
		  piVar4 = *(int **)(param1 + 0x10);
		  if (DAT_ram_00a5942a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a5942a = '\x01';
		  }
		  uVar1 = func_ii_14054(*(undefined4 *)(*(int *)(param2 + 0x14) + 0x10),0);
		  iVar8 = *piVar4;
		  uVar6 = CONCAT44(in_register_20000004,piVar4);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))(uVar6,uVar1,*(undefined4 *)(iVar8 + 0x2d4))
		  ;
		  piVar4 = *(int **)(param1 + 0x14);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar2 = Core_Extensions_Dict_MedalDicExt__GetIconAssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x14) + 0x10),0);
		  iVar8 = *piVar4;
		  uVar6 = CONCAT44(uVar1,piVar4);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))(uVar6,uVar2,*(undefined4 *)(iVar8 + 0x2d4))
		  ;
		  uVar5 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  uVar2 = Core_Extensions_Dict_AprDicExt__IsIndividual
		                    (*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,uVar2,0);
		  uVar2 = *(undefined4 *)(param2 + 0x20);
		  uVar5 = *(undefined4 *)(param2 + 0x24);
		  param4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0x10) + 0x2c);
		  iVar8 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(iVar8,uVar5,uVar2,param4,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_13144,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar8 + 0x24) = uVar2;
		  UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x1c),iVar8,0);
		  iVar8 = Core_Extensions_Dict_AprDicExt__IsIndividual
		                    (*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (iVar8 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar5 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0x10) + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar5 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar5,0);
		    UI_Rewards_AbstractRewardsRender__get_Rewards(uVar2,uVar5,0);
		    iVar8 = **(int **)(param1 + 0x18);
		    uVar6 = CONCAT44(uVar1,*(int **)(param1 + 0x18));
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0xf0) * 4))(uVar6,*(undefined4 *)(iVar8 + 0xf4));
		    uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  }
		  else {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  if ((*(longlong *)(*(int *)(*(int *)(param2 + 0x14) + 0x10) + 0x40) == 0) &&
		     (*(int *)(param2 + 0x2c) == 0)) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  else {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    param1_00 = *(int *)(param1 + 0x24);
		    iVar8 = *(int *)(param2 + 0x2c);
		    if (iVar8 == 0) {
		      uVar6 = *(undefined8 *)(*(int *)(*(int *)(param2 + 0x14) + 0x10) + 0x40);
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      param2_00 = Utils_StringUtils___cctor(uVar6,0);
		      uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      uVar2 = Gameplay_Aprs_View_AprInfoView__set_AprData(param1,param2_00,param1);
		      UI_AbstractBacktimeView__set_FormatBackTimeCallback(param1_00,uVar2,0);
		    }
		    else {
		      if (*(int *)(param1_00 + 0x14) == 0) {
		        uVar2 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		        UI_AbstractBacktimeView___ctor
		                  (uVar2,param1,Method_Gameplay_Aprs_View_AprInfoView_FormatDuration__,0);
		        *(undefined4 *)(param1_00 + 0x14) = uVar2;
		        iVar8 = *(int *)(param2 + 0x2c);
		        param1_00 = *(int *)(param1 + 0x24);
		      }
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(param1_00,iVar8,0);
		    }
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar7 * 8 + 4) * 8 + iVar8 + 0x280);
		        goto code_r0x80ffd8c8;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x80ffd8c8:
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar1,piVar4),puVar3[1]);
		  Gameplay_Collections_View_CollectionRowHelper__RenderMedalCollectionRow
		            (uVar2,uVar5,*(undefined4 *)(iVar8 + 0x20),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_AprData ---
		undefined4 Gameplay_Aprs_View_AprInfoView__set_AprData(int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a593ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a593ef = '\x01';
		  }
		  if (DAT_ram_00a593ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2581);
		    DAT_ram_00a593ed = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x30);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2581,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1 + 0x30) = uVar2;
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param3_00 = Utils_TimeUtils__DateFormat((double)param2,0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar2,StringLiteral_118,param3_00,0);
		  return uVar2;
		}
		*/

}
