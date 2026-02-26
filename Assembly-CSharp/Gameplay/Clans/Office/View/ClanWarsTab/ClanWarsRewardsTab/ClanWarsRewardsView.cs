using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using Utils;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab
{
	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x2000A17")]
	public class ClanWarsRewardsView : MonoBehaviour
	{
		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C34")]
		public GenericSubFilterView FilterView
		{
			[Token(Token = "0x6003D6A")]
			[Address(RVA = "0x8C2A", Offset = "0x8C2A", VA = "0x8C2A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06003D6B RID: 15723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C35")]
		public CurrentLeagueInfo InfoBox
		{
			[Token(Token = "0x6003D6B")]
			[Address(RVA = "0x8C2B", Offset = "0x8C2B", VA = "0x8C2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x8C2C", Offset = "0x8C2C", VA = "0x8C2C")]
		public FilterListElement UpdateRewardsList(IList<SeasonLeagueRewardsDic> seasonRewards, Action<FilterListElement> listElementClickedEventHandler)
		{
		/* --- GHIDRA: UpdateRewardsList ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__UpdateRewardsList
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 param3_00;
		  undefined4 param4_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a57f42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_RewardInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57f42 = '\x01';
		  }
		  uVar2 = Protocol_Common_ResourceSet___ctor(param4,0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__GetResourcesAsList(uVar2,0);
		  param1_00 = System_Linq_Enumerable__Select_object__object_
		                        (*(undefined4 *)(param3 + 0x28),
		                         Method_System_Linq_Enumerable_ToList_RewardInfo___);
		  iVar1 = Method_System_Collections_Generic_List_RewardInfo__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  param3_00 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(param1_00,0);
		  param4_00 = func_ii_7287(param1_00,param3,param1_00);
		  Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_CurrentLeagueInfo__Init
		            (uVar2,param2,param3_00,param4_00,param1_00);
		  Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(param1_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x8C2D", Offset = "0x8C2D", VA = "0x8C2D")]
		public void UpdateLeagueInfo(ClanLeagueDic leagueDic, SeasonLeagueRewardsDic dic, ResourceSet bank)
		{
		/* --- GHIDRA: UpdateLeagueInfo ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__UpdateLeagueInfo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f44 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4251);
		    DAT_ram_00a57f44 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4251,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x20),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x1C78", Offset = "0x1C78", VA = "0x1C78")]
		private string GetPlacesText(SeasonLeagueRewardsDic dic)
		{
		/* --- GHIDRA: GetPlacesText ---
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined8 uVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5acdb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1162);
		    Mono_Security_ASN1__get_Item(&StringLiteral_670);
		    DAT_ram_00a5acdb = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0xc);
		  if (0 < iVar2) {
		    do {
		      uVar3 = *(undefined8 *)(param2 + iVar1 * 8 + 0x10);
		      param2_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                            (StringLiteral_670,(int)uVar3,StringLiteral_1162,0);
		      param1 = func_ii_7088(param1,param2_00,(int)((ulonglong)uVar3 >> 0x20),0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x8C2E", Offset = "0x8C2E", VA = "0x8C2E")]
		public void SetCurrentSeasonBacktime(BackTime backTime)
		{
		/* --- GHIDRA: SetCurrentSeasonBacktime ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__SetCurrentSeasonBacktime
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f45 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4247);
		    DAT_ram_00a57f45 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4247,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x20),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x8C2F", Offset = "0x8C2F", VA = "0x8C2F")]
		public void SetNextSeasonBacktime(BackTime backTime)
		{
		/* --- GHIDRA: SetNextSeasonBacktime ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__SetNextSeasonBacktime
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f46 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FilterListElement__TypeInfo);
		    DAT_ram_00a57f46 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_FilterListElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_FilterListElement___ctor__);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x8C30", Offset = "0x8C30", VA = "0x8C30")]
		public ClanWarsRewardsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f47 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4309);
		    DAT_ram_00a57f47 = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanLeagueBaseInfoView__Awake
		            (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4309,1,0,1,0,0,0,0);
		  Core_Extensions_Dict_UserRatingKindDicExt__GetTitle(param1_00,param2_00,0);
		  Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId
		            (*(undefined4 *)(param1 + 0x20),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x0400223F RID: 8767
		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FilterListElement _listElementPrefab;

		// Token: 0x04002240 RID: 8768
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04002241 RID: 8769
		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GenericSubFilterView _filtersView;

		// Token: 0x04002242 RID: 8770
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CurrentLeagueInfo _infoBox;

		// Token: 0x04002243 RID: 8771
		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x04002244 RID: 8772
		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _timerDescription;

		// Token: 0x04002245 RID: 8773
		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x28")]
		private List<FilterListElement> _instances;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_InfoBox ---
		/* WARNING: Removing unreachable block (ram,0x80e831f1) */
		
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__get_InfoBox
		          (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  undefined4 param2_00;
		  int *piVar10;
		  undefined8 local_30;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57f41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FilterListElement__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_SeasonLeagueRewardsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_SeasonLeagueRewardsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FilterListElement__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FilterListElement__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_FilterListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26089);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4322);
		    DAT_ram_00a57f41 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_FilterListElement__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FilterListElement__MoveNext__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e82c86;
		    }
		    if (iVar2 == 0) goto code_r0x80e82cdc;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e82c86:
		  iVar9 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e82cdc:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = *(int *)(param1 + 0x28);
		      iVar2 = *(int *)(iVar9 + 0xc);
		      *(undefined4 *)(iVar9 + 0xc) = 0;
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar9 + 8),0,iVar2,0);
		      }
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (System_Collections_Generic_IEnumerable_SeasonLeagueRewardsDic__TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80e82d84;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_SeasonLeagueRewardsDic__TypeInfo
		                                    ,0);
		code_r0x80e82d84:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x80e82e06:
		      do {
		        piVar4 = local_14;
		        iVar9 = *local_14;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar6 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80e82e9a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e83389:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		code_r0x80e82e9a:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		        piVar4 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e83389;
		        if (iVar9 == 0) {
		          iVar9 = 7;
		          goto code_r0x80e833de;
		        }
		        iVar9 = *local_14;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_SeasonLeagueRewardsDic__TypeInfo == *piVar10)
		            {
		              puVar6 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80e82f74;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_SeasonLeagueRewardsDic__TypeInfo,
		                            0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e83311:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		code_r0x80e82f74:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		        iVar9 = DAT_ram_009d3e38;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e83311;
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf1,iVar9,uVar3,iVar9)
		        ;
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8331b:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_GameLocalization_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e8331b;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iiiiiiiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,
		                           StringLiteral_4322,1,0,1,0,0,0,0);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                           System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        local_30 = 0;
		        DAT_ram_009d3e38 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_30,StringLiteral_26089,uVar7,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        *(undefined8 *)(iVar2 + 0x10) = local_30;
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf2,uVar8,iVar2,0);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        uVar8 = *(undefined4 *)(param1 + 0x14);
		        param2_00 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e83391;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar4 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00
		                                   ,uVar8,Method_UnityEngine_Object_Instantiate_FilterListElement___
		                                  );
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        *(undefined4 *)(iVar9 + 8) = uVar7;
		        *(undefined4 *)(iVar9 + 0xc) = uVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar4 + 0xe0),piVar4,iVar9,*(undefined4 *)(*piVar4 + 0xe4));
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf4,piVar4,param3,0);
		        iVar2 = DAT_ram_009d3e38;
		        iVar9 = Method_System_Collections_Generic_List_FilterListElement__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e83391;
		        }
		        iVar2 = *(int *)(param1 + 0x28);
		        *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar2 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		          *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		          *(int **)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = piVar4;
		          goto code_r0x80e82e06;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,piVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar9 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e83391:
		      iVar9 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        local_24 = *piVar4;
		        iVar9 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x80e833de:
		          DAT_ram_009d3e38 = 0;
		          piVar4 = *ppiStack_20;
		          if (piVar4 != (int *)0x0) {
		            uVar1 = 0;
		            iVar2 = *piVar4;
		            if (*(ushort *)(iVar2 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                  puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e83459;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		            }
		            puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80e83459:
		            (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar9 == 0) ||
		             ((((uVar3 = 0, iVar9 != 1 && (iVar9 != 2)) && (iVar9 != 3)) &&
		              (((iVar9 != 4 && (iVar9 != 5)) && ((iVar9 != 6 && (iVar9 == 7)))))))) {
		            uVar3 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x28),0,
		                               Method_System_Collections_Generic_List_FilterListElement__get_Item__)
		            ;
		          }
		          return uVar3;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf5,&local_24);
		      goto joined_r0x80e834b1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf0,&local_24);
		joined_r0x80e834b1:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
