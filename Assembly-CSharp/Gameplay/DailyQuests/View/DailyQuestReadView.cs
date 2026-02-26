using System;
using AssetContent;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Ad.DailyQuestsAd.View;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UI.Rewards;
using UI.Scroll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	public class DailyQuestReadView : MonoBehaviourWithStates<DailyQuestReadView.State>
	{
		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FC")]
		public Button ActionButton
		{
			[Token(Token = "0x60032AA")]
			[Address(RVA = "0x82FC", Offset = "0x82FC", VA = "0x82FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FD")]
		public Button ToMailButton
		{
			[Token(Token = "0x60032AB")]
			[Address(RVA = "0x82FD", Offset = "0x82FD", VA = "0x82FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009FE")]
		public DailyQuestsAdView AdView
		{
			[Token(Token = "0x60032AC")]
			[Address(RVA = "0x82FE", Offset = "0x82FE", VA = "0x82FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AD")]
		[Address(RVA = "0x82FF", Offset = "0x82FF", VA = "0x82FF")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__Awake
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57c10 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6085);
		    DAT_ram_00a57c10 = '\x01';
		  }
		  *(int **)(param1 + 0x54) = param2;
		  Gameplay_DailyQuests_View_DailyQuestReadView__InitInternal(param1,param3,param3);
		  uVar4 = *(undefined4 *)(param1 + 0x3c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = func_ii_7508(StringLiteral_6085,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(param1 + 0x30);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e36b0b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		code_r0x80e36b0b:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060032AE RID: 12974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AE")]
		[Address(RVA = "0x8300", Offset = "0x8300", VA = "0x8300")]
		public void InitDailyQuest(IDailyQuest quest, UserData user)
		{
		/* --- GHIDRA: InitDailyQuest ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__InitDailyQuest(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57c11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14978);
		    DAT_ram_00a57c11 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  piVar3 = *(int **)(param1 + 0x54);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80e36fb2;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x80e36fb2:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 == 0) {
		    uVar6 = 0;
		  }
		  else {
		    uVar6 = 0;
		    piVar3 = *(int **)(param1 + 0x54);
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xf0);
		          goto code_r0x80e37039;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_DailyQuests_Model_IQuest_TypeInfo,6);
		code_r0x80e37039:
		    if (iVar4 == 0) {
		      uVar1 = 0;
		    }
		    uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar6 = uVar6 ^ 1;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar6,0);
		  piVar3 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                            (*(undefined4 *)(param1 + 0x34),
		                             Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___)
		  ;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar6 = 0;
		  uVar1 = func_ii_7508(StringLiteral_14978,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x2d4));
		  piVar3 = *(int **)(param1 + 0x54);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x80e37132;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_DailyQuests_Model_IQuest_TypeInfo,6);
		code_r0x80e37132:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if ((iVar4 != 0) && (*(int *)(param1 + 0x18) != 3)) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,2,
		               Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032AF")]
		[Address(RVA = "0x8301", Offset = "0x8301", VA = "0x8301")]
		private void SetupTakeRewardView()
		{
		/* --- GHIDRA: SetupTakeRewardView ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__SetupTakeRewardView
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57c12 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6084);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6083);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6085);
		    DAT_ram_00a57c12 = '\x01';
		  }
		  *(int **)(param1 + 0x54) = param2;
		  Gameplay_DailyQuests_View_DailyQuestReadView__InitInternal(param1,param3,param3);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		        goto code_r0x80e37242;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x80e37242:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  if (iVar6 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_6084,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar5,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    piVar4 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                              (*(undefined4 *)(param1 + 0x34),
		                               Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___
		                              );
		    uVar2 = func_ii_7508(StringLiteral_6083,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		              (piVar4,uVar2,*(undefined4 *)(*piVar4 + 0x2d4));
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = func_ii_7508(StringLiteral_6085,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x8302", Offset = "0x8302", VA = "0x8302")]
		public void InitGoal(IGoal goal, UserData user)
		{
		/* --- GHIDRA: InitGoal ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__InitGoal
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x54) = param2;
		  Gameplay_DailyQuests_View_DailyQuestReadView__InitInternal(param1,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x8303", Offset = "0x8303", VA = "0x8303")]
		private void InitInternal(IQuest quest, UserData user)
		{
		/* --- GHIDRA: InitInternal ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__InitInternal
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int *piVar6;
		  int param2_00;
		  int iVar7;
		  
		  if (DAT_ram_00a57c13 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57c13 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x54);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x20);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x110);
		          goto code_r0x80e36bd9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,10);
		code_r0x80e36bd9:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    iVar7 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar7 + 0x2d4));
		    uVar1 = 0;
		    piVar5 = *(int **)(param1 + 0x1c);
		    piVar6 = *(int **)(param1 + 0x54);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x108);
		          goto code_r0x80e36c73;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Gameplay_DailyQuests_Model_IQuest_TypeInfo,9);
		code_r0x80e36c73:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    iVar7 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar5,uVar3,*(undefined4 *)(iVar7 + 0x2d4));
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    piVar5 = *(int **)(param1 + 0x54);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x118);
		          goto code_r0x80e36d13;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xb);
		code_r0x80e36d13:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar3,uVar4,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    uVar1 = 0;
		    Gameplay_DailyQuests_View_DailyQuestReadView__HandleDataChanged(param1,0);
		    piVar5 = *(int **)(param1 + 0x54);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x138);
		          goto code_r0x80e36daa;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xf);
		code_r0x80e36daa:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar4 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(uVar4,param2,param2,uVar3,0)
		    ;
		    UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x2c),uVar4,0);
		    uVar3 = *(undefined4 *)(param1 + 0x38);
		    piVar5 = *(int **)(param1 + 0x54);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x80e36e5c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0x10);
		code_r0x80e36e5c:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		    UI_Rewards_AbstractRewardsRender__get_Rewards(uVar3,uVar4,0);
		    param2_00 = **(int **)(param1 + 0x38);
		    (**(code **)((ulonglong)*(uint *)(param2_00 + 0xf0) * 4))
		              (*(int **)(param1 + 0x38),*(undefined4 *)(param2_00 + 0xf4));
		    iVar7 = func_ii_12174(*(undefined4 *)(param1 + 0x50),0);
		    if (iVar7 != 0) {
		      UI_Scroll_ScrollWithButtons__GetRectAxis(*(undefined4 *)(param1 + 0x50),0);
		    }
		    Gameplay_DailyQuests_View_DailyQuestReadView__InitDailyQuest(param1,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x8304", Offset = "0x8304", VA = "0x8304")]
		private void HandleDataChanged(UserData user)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__HandleDataChanged(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 param2_00;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57c14 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c14 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x54);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8 + 4) * 8 + iVar6 + 0x148);
		        goto code_r0x80e373b4;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0x11);
		code_r0x80e373b4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = func_ii_4769(uVar3,0);
		  if (uVar4 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x44),0,0);
		    uVar3 = *(undefined4 *)(param1 + 0x40);
		    piVar5 = *(int **)(param1 + 0x54);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x148);
		          goto code_r0x80e3746a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0x11);
		code_r0x80e3746a:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar3,param2_00,0);
		  }
		  else {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x44),1,0);
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar4 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x8305", Offset = "0x8305", VA = "0x8305")]
		private void DrawLargeImage()
		{
		/* --- GHIDRA: DrawLargeImage ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__DrawLargeImage
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State___ctor__);
		    DAT_ram_00a57c15 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_DailyQuestReadView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x8306", Offset = "0x8306", VA = "0x8306")]
		public DailyQuestReadView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_DailyQuests_View_DailyQuestReadView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c16 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12607);
		    DAT_ram_00a57c16 = '\x01';
		  }
		  return StringLiteral_12607;
		}
		*/

		}

		// Token: 0x04001BAE RID: 7086
		[Token(Token = "0x4001BAE")]
		public const string DAILY_QUEST_REWARD_HINT = "DAILY_QUESTS/REWARD_HINT";

		// Token: 0x04001BAF RID: 7087
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _desciption;

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001BB1 RID: 7089
		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameRawImageLoader _someImageLoader;

		// Token: 0x04001BB2 RID: 7090
		[Token(Token = "0x4001BB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _timerPrefix;

		// Token: 0x04001BB3 RID: 7091
		[Token(Token = "0x4001BB3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _actionButton;

		// Token: 0x04001BB6 RID: 7094
		[Token(Token = "0x4001BB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _hint;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _largeImage;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject _defaultImage;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _toMailButton;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private DailyQuestsAdView _adView;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollWithButtons _scrollWithButtons;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		[FieldOffset(Offset = "0x54")]
		private IQuest _quest;

		// Token: 0x0200086C RID: 2156
		[Token(Token = "0x200086C")]
		public enum State
		{
			// Token: 0x04001BBF RID: 7103
			[Token(Token = "0x4001BBF")]
			UNKNOWN_STATE,
			// Token: 0x04001BC0 RID: 7104
			[Token(Token = "0x4001BC0")]
			REWARD_TAKEN = 2,
			// Token: 0x04001BC1 RID: 7105
			[Token(Token = "0x4001BC1")]
			REWARD_IN_MAIL
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AdView ---
		void Gameplay_DailyQuests_View_DailyQuestReadView__get_AdView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57c0f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6086);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2003);
		    DAT_ram_00a57c0f = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_6086,1,0,1,0,0,0,0);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_2003,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
