using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Gameplay.School.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	public class SpellUpgradeInfo : MonoBehaviourWithStates<SpellUpgradeInfo.State>
	{
		// Token: 0x14000105 RID: 261
		// (add) Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600108D RID: 4237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000105")]
		private event Action Learn
		{
			[Token(Token = "0x600108C")]
			[Address(RVA = "0x6289", Offset = "0x6289", VA = "0x6289")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600108D")]
			[Address(RVA = "0x628A", Offset = "0x628A", VA = "0x628A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000106 RID: 262
		// (add) Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000106")]
		private event Action Accelerate
		{
			[Token(Token = "0x600108E")]
			[Address(RVA = "0x628B", Offset = "0x628B", VA = "0x628B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600108F")]
			[Address(RVA = "0x628C", Offset = "0x628C", VA = "0x628C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x628D", Offset = "0x628D", VA = "0x628D")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58ada == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58ada = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x24) + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo_ButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x628E", Offset = "0x628E", VA = "0x628E")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__OnDestroy
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58adb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__HandleCurrentStateChanged__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13735);
		    DAT_ram_00a58adb = '\x01';
		  }
		  UI_MonoBehaviourWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__HandleCurrentStateChanged__);
		  if (param3 == 2) {
		    param1_00 = *(undefined4 *)(param1 + 0x34);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13735,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x628F", Offset = "0x628F", VA = "0x628F", Slot = "4")]
		protected override void HandleCurrentStateChanged(SpellUpgradeInfo.State fromState, SpellUpgradeInfo.State toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__HandleCurrentStateChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58adc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__get_CurrentState__);
		    DAT_ram_00a58adc = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x24) + 0x18);
		  if (iVar1 - 3U < 0xfffffffe) {
		    if (iVar1 != 3) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x40);
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x3c);
		  }
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001093")]
		[Address(RVA = "0x6290", Offset = "0x6290", VA = "0x6290")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__ButtonClickedEventHandler
		               (int param1,int *param2,int *param3,int param4,int param5,undefined4 param6)
		
		{
		  undefined4 in_register_20000004;
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  float fVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  int *piVar8;
		  undefined4 param1_00;
		  int iVar9;
		  undefined8 param1_01;
		  uint param2_00;
		  int iVar10;
		  double param1_02;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58add == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3699);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25096);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10753);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13736);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13726);
		    DAT_ram_00a58add = '\x01';
		  }
		  uVar2 = 3;
		  uVar1 = Gameplay_School_Model_SchoolSpellData__set_ActionBacktime(param2,0);
		  if (uVar1 == 0) {
		    uVar2 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar2,
		             Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		  piVar8 = *(int **)(param1 + 0x34);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13726,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_4 = *(undefined4 *)(param2[0xc] + 0x10);
		  uVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_25096,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  iVar3 = *piVar8;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (CONCAT44(in_register_20000004,piVar8),uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  param2_00 = param4 == param5 | uVar1;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  param1_01 = *(undefined8 *)(param2[0xc] + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar5 = Utils_StringUtils___cctor(param1_01,0);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10753,1,0,1,0,0,0,0);
		  param1_02 = (double)fVar5;
		  uVar6 = Utils_TimeUtils__DateFormat(param1_02,0);
		  uVar2 = (undefined4)((ulonglong)param1_02 >> 0x20);
		  UI_Rewards_RewardsRender_ContainerSeparatorConfig___ctor(param1_00,uVar4,uVar6,0);
		  if (uVar1 == 0) {
		    if (param4 == param5) {
		      uVar1 = 0;
		      uVar4 = *(undefined4 *)(param2[0xc] + 0x2c);
		      iVar3 = *param3;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		              *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar7 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		            goto code_r0x80f72da2;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar7 = (uint *)func_ii_1080(param3,
		                                    Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                    ,1);
		code_r0x80f72da2:
		      iVar3 = (**(code **)((ulonglong)*puVar7 * 4))(CONCAT44(uVar2,param3),uVar4,param4,puVar7[1]);
		    }
		    else {
		      iVar3 = 0;
		    }
		  }
		  else {
		    uVar1 = func_ii_8746(param2,0);
		    uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,(float)uVar1,0);
		    if (fVar5 < 4.2949673e+09 && 0.0 <= fVar5) {
		      iVar3 = (int)fVar5;
		    }
		    else {
		      iVar3 = 0;
		    }
		    iVar9 = *(int *)(param1 + 0x38);
		    if (ABS(fVar5) < 2.1474836e+09) {
		      iVar10 = (int)fVar5;
		    }
		    else {
		      iVar10 = -0x80000000;
		    }
		    if (0.0 <= fVar5) {
		      iVar10 = iVar3;
		    }
		    *(int *)(iVar9 + 0x2c) = iVar10;
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(iVar9,uVar4,0);
		    uVar4 = *(undefined4 *)(param5 + 0x78);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                      (CONCAT44(uVar2,param2),*(undefined4 *)(*param2 + 0x114));
		    iVar3 = Core_Extensions_Dict_ResourceSetExt__IsZero(uVar4,uVar2,0);
		  }
		  local_10 = CONCAT44(local_10._4_4_,*(undefined4 *)(param2[0xc] + 0x28));
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3699,1,0,1,0,0,0,0);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28637,uVar2,uVar4,0);
		  uVar6 = *(undefined4 *)(param1 + 0x20);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13736,1,0,1,0,0,0,0);
		  UI_Rewards_RewardsRender_ContainerSeparatorConfig___ctor(uVar6,uVar4,uVar2,0);
		  iVar9 = 0x28;
		  if (iVar3 == 0) {
		    iVar9 = 0x2c;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x30),*(undefined4 *)(param1 + iVar9),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__Init(param1,param2,param5,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x6291", Offset = "0x6291", VA = "0x6291")]
		public void Init(SchoolSpellData spellData, IRequirementValidator validator, UserData user, UserData loggedUser)
		{
		/* --- GHIDRA: Init ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__Init
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  double dVar6;
		  int *param1_00;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  uint uVar10;
		  
		  if (DAT_ram_00a58ade == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a58ade = '\x01';
		  }
		  iVar3 = Gameplay_School_Model_SchoolSpellData__set_ActionBacktime(param2,0);
		  if (iVar3 == 0) {
		    uVar1 = CONCAT44(in_register_20000004,param2);
		    uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0xf4));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))(uVar1,uVar2);
		    uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    if (iVar3 == 0) {
		      UI_Elements_ImageWithStates_Int32Enum___get_CurrentState
		                (*(undefined4 *)(param1 + 0x24),1,
		                 Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__set_CurrentState__)
		      ;
		      uVar9 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x24) + 0x1c) + 0xb8);
		      uVar5 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (CONCAT44(uVar5,param2),CONCAT44(uVar8,*(undefined4 *)(*param2 + 0x114)));
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		      UI_Price_Price__SetColor(uVar9,param3,uVar5,0);
		      return;
		    }
		    UI_Elements_ImageWithStates_Int32Enum___get_CurrentState
		              (*(undefined4 *)(param1 + 0x24),2,
		               Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__set_CurrentState__);
		    uVar9 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x24) + 0x1c) + 0xb8);
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                      (CONCAT44(uVar5,param2),CONCAT44(uVar8,*(undefined4 *)(*param2 + 0x114)));
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		    UI_Price_Price__SetColor(uVar9,param3,uVar5,0);
		    return;
		  }
		  UI_Elements_ImageWithStates_Int32Enum___get_CurrentState
		            (*(undefined4 *)(param1 + 0x24),3,
		             Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__set_CurrentState__);
		  iVar3 = func_ii_8746(param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80f72f88;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f72f88:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))
		                    (CONCAT44(in_register_20000004,param1_00),
		                     CONCAT44(in_register_20000014,puVar4[1]));
		  uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  dVar6 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar5,StringLiteral_25458,0);
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x24) + 0x1c) + 0xb8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		  dVar6 = func_ii_6931((double)(uint)(iVar3 * 1000),dVar6,0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar8 = Core_Data_ArtifactData__get_SellPrice(uVar8,CEIL(dVar6),0);
		  UI_Price_Price__SetColor(uVar5,param3,uVar8,0);
		  return;
		}
		*/

		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x6292", Offset = "0x6292", VA = "0x6292")]
		private void ResolveButtonState(SchoolSpellData spellData, UserData loggedUser)
		{
		/* --- GHIDRA: ResolveButtonState ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__ResolveButtonState
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x40) = param3;
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x6293", Offset = "0x6293", VA = "0x6293")]
		public void BindCallbacks(Action learn, Action accelerate)
		{
		/* --- GHIDRA: BindCallbacks ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__BindCallbacks
		               (int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x3c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x6294", Offset = "0x6294", VA = "0x6294")]
		public void UnbindCallbacks()
		{
		/* --- GHIDRA: UnbindCallbacks ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__UnbindCallbacks
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58adf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State___ctor__)
		    ;
		    DAT_ram_00a58adf = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x6295", Offset = "0x6295", VA = "0x6295")]
		public SpellUpgradeInfo()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ae0 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12648);
		    DAT_ram_00a58ae0 = '\x01';
		  }
		  return StringLiteral_12648;
		}
		*/

		}

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TitleValueRender _upgradeTime;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitleValueRender _schoolLevel;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SpellButtonWithStates _spellButton;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _isOkImage;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _isNotOkImage;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BacktimeViewUGUIFill _backtimeView;

		// Token: 0x020002C0 RID: 704
		[Token(Token = "0x20002C0")]
		public enum State
		{
			// Token: 0x04000891 RID: 2193
			[Token(Token = "0x4000891")]
			UNKNOWN_STATE,
			// Token: 0x04000892 RID: 2194
			[Token(Token = "0x4000892")]
			DEFAULT,
			// Token: 0x04000893 RID: 2195
			[Token(Token = "0x4000893")]
			EMPTY,
			// Token: 0x04000894 RID: 2196
			[Token(Token = "0x4000894")]
			LEARNING
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_Learn ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__add_Learn
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58ad6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58ad6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x3c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_Learn ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__remove_Learn
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58ad7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58ad7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_Accelerate ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__add_Accelerate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58ad8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58ad8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x40,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_Accelerate ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__remove_Accelerate
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58ad9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58ad9 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x24) + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo_ButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
