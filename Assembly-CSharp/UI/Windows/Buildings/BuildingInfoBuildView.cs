using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	public class BuildingInfoBuildView : MonoBehaviourWithStates<BuildingInfoBuildView.BuildingInfoBuildViewStates>, IDiscountTarget
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000246")]
		public Button BuildButton
		{
			[Token(Token = "0x6001006")]
			[Address(RVA = "0x6210", Offset = "0x6210", VA = "0x6210")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x6211", Offset = "0x6211", VA = "0x6211")]
		public void SetData(BaseBuildingData buildingData, UserData ownerUserData, UserData ownUserData)
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000247")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6001008")]
			[Address(RVA = "0x6212", Offset = "0x6212", VA = "0x6212", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001009")]
			[Address(RVA = "0x6213", Offset = "0x6213", VA = "0x6213")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x6214", Offset = "0x6214", VA = "0x6214", Slot = "6")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: Setup ---
		void UI_Windows_Buildings_BuildingInfoBuildView__Setup(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BuildingInfoBuildView_BuildingInfoBuildViewStates___ctor__
		              );
		    DAT_ram_00a58a91 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_BuildingInfoBuildView_BuildingInfoBuildViewStates___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x6215", Offset = "0x6215", VA = "0x6215")]
		public BuildingInfoBuildView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_Buildings_BuildingInfoBuildView___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a92 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    DAT_ram_00a58a92 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0x3c) + 0x10) + 8);
		}
		*/

		}

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _upgradeTextLabel;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _buildButton;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _durationLabel;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DiscountInfoTitledListElement _discountInfo;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x34")]
		private BaseBuildingData _buildingData;

		// Token: 0x020002AB RID: 683
		[Token(Token = "0x20002AB")]
		public enum BuildingInfoBuildViewStates
		{
			// Token: 0x04000836 RID: 2102
			[Token(Token = "0x4000836")]
			Default,
			// Token: 0x04000837 RID: 2103
			[Token(Token = "0x4000837")]
			Sale
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BuildButton ---
		void UI_Windows_Buildings_BuildingInfoBuildView__get_BuildButton
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  float fVar6;
		  undefined4 uVar7;
		  longlong lVar8;
		  longlong lVar9;
		  undefined8 uVar10;
		  int *piVar11;
		  int iVar12;
		  undefined4 *puVar13;
		  double param1_00;
		  uint uVar14;
		  int local_4;
		  
		  if (DAT_ram_00a58a8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3695);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3703);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3704);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3701);
		    DAT_ram_00a58a8f = '\x01';
		  }
		  *(int **)(param1 + 0x34) = param2;
		  if (param2 != (int *)0x0) {
		    uVar10 = CONCAT44(in_register_20000004,param2);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x120) * 4))
		                      (uVar10,*(undefined4 *)(*param2 + 0x124));
		    if (iVar1 == 0) {
		      uVar7 = (undefined4)((ulonglong)uVar10 >> 0x20);
		      iVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                        (*(undefined4 *)(param1 + 0x34),0);
		      iVar1 = iVar1 + 1;
		      local_4 = iVar1;
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar12 = *piVar11;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar14 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar14 * 8 + 4) * 8 + iVar12 +
		                             0x178);
		            goto code_r0x80f6c2a6;
		          }
		          uVar14 = uVar14 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar14);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f6c2a6:
		      uVar10 = CONCAT44(uVar7,piVar11);
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(uVar10,puVar2[1]);
		      uVar7 = (undefined4)((ulonglong)uVar10 >> 0x20);
		      uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		      uVar10 = CONCAT44(uVar7,param2);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                        (uVar10,iVar1,uVar3,*(undefined4 *)(*param2 + 0x134));
		      uVar7 = (undefined4)((ulonglong)uVar10 >> 0x20);
		      piVar11 = *(int **)(param1 + 0x1c);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3704,1,0,1,0,0,0,0);
		      piVar5 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		      iVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      if ((iVar1 != 0) &&
		         (iVar12 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20)), iVar12 == 0)) {
		        uVar7 = func_ii_1083();
		        func_ii_1050(uVar7,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5[4] = iVar1;
		      uVar4 = Locale__GetText(uVar4,piVar5,0);
		      iVar1 = *piVar11;
		      uVar10 = CONCAT44(uVar7,piVar11);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (uVar10,uVar4,*(undefined4 *)(iVar1 + 0x2d4));
		      piVar11 = *(int **)(param1 + 0x20);
		      iVar1 = **(int **)(param1 + 0x34);
		      uVar10 = CONCAT44((int)((ulonglong)uVar10 >> 0x20),*(int **)(param1 + 0x34));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf8) * 4))
		                        (uVar10,*(undefined4 *)(iVar1 + 0xfc));
		      uVar7 = (undefined4)((ulonglong)uVar10 >> 0x20);
		      if (iVar1 == 0) {
		        uVar3 = 0;
		      }
		      else {
		        uVar3 = Core_GameLocalization__GetTranslation(iVar1,uVar3,0);
		      }
		      iVar1 = *piVar11;
		      uVar10 = CONCAT44(uVar7,piVar11);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (uVar10,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		      uVar7 = (undefined4)((ulonglong)uVar10 >> 0x20);
		      lVar8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param3,0);
		      lVar9 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param4,0);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		      if (lVar8 == lVar9) {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,1,0);
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x24),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,1,0);
		        piVar11 = *(int **)(param1 + 0x28);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3703,1,0,1,0,0,0,0);
		        piVar5 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		        iVar1 = **(int **)(param1 + 0x34);
		        uVar10 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x118) * 4))
		                           (CONCAT44(uVar7,*(int **)(param1 + 0x34)),*(undefined4 *)(iVar1 + 0x11c))
		        ;
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        fVar6 = Utils_StringUtils___cctor(uVar10,0);
		        param1_00 = (double)fVar6;
		        iVar1 = Utils_TimeUtils__DateFormat(param1_00,0);
		        uVar7 = (undefined4)((ulonglong)param1_00 >> 0x20);
		        if ((iVar1 != 0) &&
		           (iVar12 = func_ii_1082(iVar1,*(undefined4 *)(*piVar5 + 0x20)), iVar12 == 0)) {
		          uVar7 = func_ii_1083();
		          func_ii_1050(uVar7,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5[4] = iVar1;
		        uVar3 = Locale__GetText(uVar3,piVar5,0);
		        iVar1 = *piVar11;
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                  (CONCAT44(uVar7,piVar11),uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		        iVar1 = **(int **)(param1 + 0x34);
		        iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x140) * 4))
		                          (*(int **)(param1 + 0x34),param3,param4,*(undefined4 *)(iVar1 + 0x144));
		        uVar7 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3701,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar1 + 0x24) = uVar7;
		        UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x2c),iVar1,0);
		        puVar13 = &StringLiteral_3702;
		        iVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                          (*(undefined4 *)(param1 + 0x34),0);
		        if (iVar1 == 0) {
		          puVar13 = &StringLiteral_3695;
		        }
		        uVar3 = *puVar13;
		        uVar7 = UI_Rewards_AbstractRewardsRender__SetRewards
		                          (*(undefined4 *)(param1 + 0x24),
		                           Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		        UnityEngine_Component__GetComponentInChildren_object_(uVar7,uVar3,0);
		      }
		      else {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,0,0);
		        uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x24),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar7,0,0);
		      }
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_DiscountTargets ---
		void UI_Windows_Buildings_BuildingInfoBuildView__set_DiscountTargets
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param2_00;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a58a90 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Discounts_View_DiscountInfoTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BuildingInfoBuildView_BuildingInfoBuildViewStates__set_CurrentState__
		              );
		    DAT_ram_00a58a90 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = System_Linq_Enumerable__OrderBy_object__ulong_
		                    (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  if (iVar2 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,0,
		               Method_UI_MonoBehaviourWithStates_BuildingInfoBuildView_BuildingInfoBuildViewStates__set_CurrentState__
		              );
		  }
		  else {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,1,
		               Method_UI_MonoBehaviourWithStates_BuildingInfoBuildView_BuildingInfoBuildViewStates__set_CurrentState__
		              );
		    iVar2 = *(int *)(param1 + 0x38);
		    if (0 < *(int *)(iVar2 + 0xc)) {
		      do {
		        iVar7 = *(int *)(iVar2 + iVar8 * 4 + 0x10);
		        iVar10 = *param2;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar6 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo == *piVar6) {
		              puVar3 = (uint *)(iVar10 + piVar6[1] * 8 + 0xc0);
		              goto code_r0x80f6c6ca;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo
		                                      ,0);
		code_r0x80f6c6ca:
		        local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		        local_c = 0;
		        local_8 = &local_4;
		        do {
		          do {
		            piVar6 = local_4;
		            iVar10 = *local_4;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		                  puVar4 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                  goto code_r0x80f6c789;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar4 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f6ca28;
		code_r0x80f6c789:
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		            piVar6 = local_4;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f6ca28;
		            if (iVar10 == 0) {
		              iVar10 = 7;
		              iVar7 = 0;
		              goto code_r0x80f6ca7c;
		            }
		            iVar10 = *local_4;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		                if (System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo == *piVar11) {
		                  puVar4 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                  goto code_r0x80f6c863;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar4 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                                System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f6ca28;
		code_r0x80f6c863:
		            DAT_ram_009d3e38 = 0;
		            piVar6 = (int *)import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f6ca28;
		            iVar10 = *piVar6;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		                if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo == *piVar11) {
		                  puVar4 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                  goto code_r0x80f6c934;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar4 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                                Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f6ca28;
		code_r0x80f6c934:
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80f6ca28;
		          } while (iVar10 != iVar7);
		          param2_00 = *(undefined4 *)(param1 + 0x30);
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             Gameplay_Discounts_View_DiscountInfoTitledListElementArgs_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar5,piVar6,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x232,param2_00,uVar5,0);
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x80f6ca28:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar7 = global_1;
		        iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 != iVar10) {
		code_r0x80f6cb2a:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x233,&local_c);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) {
		            import::env::__resumeException(uVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar7 = *piVar6;
		        iVar10 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar7;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x80f6cb2a;
		        }
		code_r0x80f6ca7c:
		        piVar6 = local_4;
		        DAT_ram_009d3e38 = 0;
		        if (local_4 != (int *)0x0) {
		          iVar9 = *local_4;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		              if (System_IDisposable_TypeInfo == *piVar11) {
		                puVar3 = (uint *)(iVar9 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x80f6caf0;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f6caf0:
		          (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		        }
		        if (iVar7 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      } while (((iVar10 == 0) ||
		               ((((iVar10 != 1 && (iVar10 != 2)) && (iVar10 != 3)) &&
		                (((iVar10 != 4 && (iVar10 != 5)) && ((iVar10 != 6 && (iVar10 == 7)))))))) &&
		              (iVar8 = iVar8 + 1, iVar8 < *(int *)(iVar2 + 0xc)));
		    }
		  }
		  return;
		}
		*/

}
