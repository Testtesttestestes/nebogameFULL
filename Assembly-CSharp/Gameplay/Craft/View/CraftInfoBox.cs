using System;
using Core.Data;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Craft;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	public class CraftInfoBox : MonoBehaviourWithStates<CraftInfoBox.State>
	{
		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A50")]
		public Button CraftButton
		{
			[Token(Token = "0x6003410")]
			[Address(RVA = "0x843D", Offset = "0x843D", VA = "0x843D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A51")]
		public Button DeleteButton
		{
			[Token(Token = "0x6003411")]
			[Address(RVA = "0x843E", Offset = "0x843E", VA = "0x843E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A52")]
		public Button TakeButton
		{
			[Token(Token = "0x6003412")]
			[Address(RVA = "0x843F", Offset = "0x843F", VA = "0x843F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A53")]
		public Button SellAllButton
		{
			[Token(Token = "0x6003413")]
			[Address(RVA = "0x8440", Offset = "0x8440", VA = "0x8440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A54")]
		public ButtonWithCost AccelerateButton
		{
			[Token(Token = "0x6003414")]
			[Address(RVA = "0x8441", Offset = "0x8441", VA = "0x8441")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A55")]
		public Button CancelButton
		{
			[Token(Token = "0x6003415")]
			[Address(RVA = "0x8442", Offset = "0x8442", VA = "0x8442")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A56")]
		public ManufactureGroupView ManufactureGroup
		{
			[Token(Token = "0x6003416")]
			[Address(RVA = "0x8443", Offset = "0x8443", VA = "0x8443")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A57")]
		public RentGroupView RentGroup
		{
			[Token(Token = "0x6003417")]
			[Address(RVA = "0x8444", Offset = "0x8444", VA = "0x8444")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003418")]
		[Address(RVA = "0x8445", Offset = "0x8445", VA = "0x8445")]
		public void UpdateInfo(UserData user, CraftSchemeData data, bool achieved)
		{
		/* --- GHIDRA: UpdateInfo ---
		void Gameplay_Craft_View_CraftInfoBox__UpdateInfo
		               (int param1,undefined4 param2,int param3,undefined8 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57cd7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__get_CurrentState__);
		    DAT_ram_00a57cd7 = '\x01';
		  }
		  if (*(char *)(param3 + 0x50) != '\0') {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Craft_View_ManufactureGroupView__ShowDisabledFilledState
		              (*(undefined4 *)(param1 + 0x50),param2,param3,param4,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  iVar2 = *(int *)(*(int *)(param3 + 0x48) + 0x14);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  if (iVar2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Craft_View_RentGroupView__ShowTimer
		              (*(undefined4 *)(param1 + 0x54),param2,param3,param4,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param3 + 0x18) == 2),0);
		  return;
		}
		*/

		/* --- GHIDRA: UpdateInfo ---
		void Gameplay_Craft_View_CraftInfoBox__UpdateInfo
		               (int param1,undefined4 param2,int param3,undefined8 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57cd7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__get_CurrentState__);
		    DAT_ram_00a57cd7 = '\x01';
		  }
		  if (*(char *)(param3 + 0x50) != '\0') {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Craft_View_ManufactureGroupView__ShowDisabledFilledState
		              (*(undefined4 *)(param1 + 0x50),param2,param3,param4,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  iVar2 = *(int *)(*(int *)(param3 + 0x48) + 0x14);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  if (iVar2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Craft_View_RentGroupView__ShowTimer
		              (*(undefined4 *)(param1 + 0x54),param2,param3,param4,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param3 + 0x18) == 2),0);
		  return;
		}
		*/

		/* --- GHIDRA: UpdateInfo ---
		void Gameplay_Craft_View_CraftInfoBox__UpdateInfo
		               (int param1,undefined4 param2,int param3,undefined8 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57cd7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__get_CurrentState__);
		    DAT_ram_00a57cd7 = '\x01';
		  }
		  if (*(char *)(param3 + 0x50) != '\0') {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Craft_View_ManufactureGroupView__ShowDisabledFilledState
		              (*(undefined4 *)(param1 + 0x50),param2,param3,param4,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  iVar2 = *(int *)(*(int *)(param3 + 0x48) + 0x14);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  if (iVar2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Craft_View_RentGroupView__ShowTimer
		              (*(undefined4 *)(param1 + 0x54),param2,param3,param4,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x50),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x58),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param3 + 0x18) == 2),0);
		  return;
		}
		*/

		}

		// Token: 0x06003419 RID: 13337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x8446", Offset = "0x8446", VA = "0x8446")]
		private void DrawArtikulInfo(CraftSchemeData.CraftSchemeInfo info)
		{
		/* --- GHIDRA: DrawArtikulInfo ---
		void Gameplay_Craft_View_CraftInfoBox__DrawArtikulInfo
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  float fVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  ulonglong uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  undefined4 uVar8;
		  undefined8 param1_01;
		  longlong lVar9;
		  uint uVar10;
		  longlong local_8;
		  
		  if (DAT_ram_00a57cd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23073);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4457);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27345);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4459);
		    DAT_ram_00a57cd5 = '\x01';
		  }
		  local_8 = 0;
		  uVar6 = 5;
		  if (*(longlong *)(*(int *)(param2 + 0x44) + 0x20) != 0) {
		    uVar6 = 3;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar6,Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		  uVar6 = *(undefined4 *)(param2 + 0x4c);
		  if (*(int *)(*(int *)(*(int *)(param2 + 0x44) + 0x38) + 0xc) < 1) {
		    Gameplay_Craft_View_CraftInfoBox__UpdateInfo(param1,uVar6,uVar6);
		  }
		  else {
		    Gameplay_Craft_View_CraftInfoBox__DrawArtikulInfo(param1,uVar6,*(int *)(param2 + 0x44),uVar6);
		  }
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
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e475db;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e475db:
		  uVar6 = (**(code **)((ulonglong)*puVar1 * 4))
		                    (CONCAT44(in_register_20000004,param1_00),
		                     CONCAT44(in_register_20000014,puVar1[1]));
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  uVar5 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar6,StringLiteral_27345,0);
		  fVar2 = UnityEngine_Camera__set_orthographicSize
		                    ((float)*(ulonglong *)(*(int *)(param2 + 0x44) + 0x20),(float)uVar5,0);
		  if (ABS(fVar2) < 2.1474836e+09) {
		    iVar7 = (int)fVar2;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar6 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Data_ArtifactData__get_SellPrice(uVar6,(double)(iVar7 + 1),0);
		  UI_Price_Price__SetColor(*(undefined4 *)(*(int *)(param1 + 0x40) + 0xb8),param3,uVar6,0);
		  param1_01 = *(undefined8 *)(*(int *)(param2 + 0x44) + 0x30);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar2 = Utils_StringUtils___cctor(param1_01,0);
		  uVar6 = Utils_TimeUtils__DateFormat((double)fVar2,0);
		  uVar8 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4457,1,0,1,0,0,0,0);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,StringLiteral_22759,uVar6,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = Core_GameLocalization__GetTranslation(uVar3,uVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar6,0);
		  iVar7 = *(int *)(*(int *)(param2 + 0x4c) + 8);
		  uVar10 = *(uint *)(iVar7 + 0x1c);
		  fVar2 = Utils_MathUtils_MathUtils__SaferDivide
		                    ((float)*(ulonglong *)(*(int *)(param2 + 0x44) + 0x30),
		                     *(undefined4 *)(iVar7 + 0x18),0);
		  if (fVar2 < 1.8446744e+19 && 0.0 <= fVar2) {
		    lVar9 = (longlong)fVar2;
		  }
		  else {
		    lVar9 = 0;
		  }
		  if (ABS(fVar2) < 9.223372e+18) {
		    local_8 = (longlong)fVar2;
		  }
		  else {
		    local_8 = -0x8000000000000000;
		  }
		  if (0.0 <= fVar2) {
		    local_8 = lVar9;
		  }
		  local_8 = local_8 * (ulonglong)uVar10;
		  uVar4 = *(undefined4 *)(param1 + 0x34);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4459,1,0,1,0,0,0,0);
		  uVar8 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar8,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = func_ii_8783(&local_8,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar8,StringLiteral_23073,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar6,0);
		  return;
		}
		*/

		/* --- GHIDRA: DrawArtikulInfo ---
		void Gameplay_Craft_View_CraftInfoBox__DrawArtikulInfo
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  float fVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  ulonglong uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  undefined4 uVar8;
		  undefined8 param1_01;
		  longlong lVar9;
		  uint uVar10;
		  longlong local_8;
		  
		  if (DAT_ram_00a57cd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23073);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4457);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27345);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4459);
		    DAT_ram_00a57cd5 = '\x01';
		  }
		  local_8 = 0;
		  uVar6 = 5;
		  if (*(longlong *)(*(int *)(param2 + 0x44) + 0x20) != 0) {
		    uVar6 = 3;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar6,Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		  uVar6 = *(undefined4 *)(param2 + 0x4c);
		  if (*(int *)(*(int *)(*(int *)(param2 + 0x44) + 0x38) + 0xc) < 1) {
		    Gameplay_Craft_View_CraftInfoBox__UpdateInfo(param1,uVar6,uVar6);
		  }
		  else {
		    Gameplay_Craft_View_CraftInfoBox__DrawArtikulInfo(param1,uVar6,*(int *)(param2 + 0x44),uVar6);
		  }
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
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e475db;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e475db:
		  uVar6 = (**(code **)((ulonglong)*puVar1 * 4))
		                    (CONCAT44(in_register_20000004,param1_00),
		                     CONCAT44(in_register_20000014,puVar1[1]));
		  uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		  uVar5 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar6,StringLiteral_27345,0);
		  fVar2 = UnityEngine_Camera__set_orthographicSize
		                    ((float)*(ulonglong *)(*(int *)(param2 + 0x44) + 0x20),(float)uVar5,0);
		  if (ABS(fVar2) < 2.1474836e+09) {
		    iVar7 = (int)fVar2;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar6 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar6 = Core_Data_ArtifactData__get_SellPrice(uVar6,(double)(iVar7 + 1),0);
		  UI_Price_Price__SetColor(*(undefined4 *)(*(int *)(param1 + 0x40) + 0xb8),param3,uVar6,0);
		  param1_01 = *(undefined8 *)(*(int *)(param2 + 0x44) + 0x30);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar2 = Utils_StringUtils___cctor(param1_01,0);
		  uVar6 = Utils_TimeUtils__DateFormat((double)fVar2,0);
		  uVar8 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4457,1,0,1,0,0,0,0);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,StringLiteral_22759,uVar6,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = Core_GameLocalization__GetTranslation(uVar3,uVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar6,0);
		  iVar7 = *(int *)(*(int *)(param2 + 0x4c) + 8);
		  uVar10 = *(uint *)(iVar7 + 0x1c);
		  fVar2 = Utils_MathUtils_MathUtils__SaferDivide
		                    ((float)*(ulonglong *)(*(int *)(param2 + 0x44) + 0x30),
		                     *(undefined4 *)(iVar7 + 0x18),0);
		  if (fVar2 < 1.8446744e+19 && 0.0 <= fVar2) {
		    lVar9 = (longlong)fVar2;
		  }
		  else {
		    lVar9 = 0;
		  }
		  if (ABS(fVar2) < 9.223372e+18) {
		    local_8 = (longlong)fVar2;
		  }
		  else {
		    local_8 = -0x8000000000000000;
		  }
		  if (0.0 <= fVar2) {
		    local_8 = lVar9;
		  }
		  local_8 = local_8 * (ulonglong)uVar10;
		  uVar4 = *(undefined4 *)(param1 + 0x34);
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4459,1,0,1,0,0,0,0);
		  uVar8 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar8,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = func_ii_8783(&local_8,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar8,StringLiteral_23073,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x0600341A RID: 13338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x8447", Offset = "0x8447", VA = "0x8447")]
		public void DrawArtikulInfo(CraftSchemeData.CraftSchemeInfo info, UserCraftSlotInfo slotInfo)
		{
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x8448", Offset = "0x8448", VA = "0x8448")]
		public void UpdateInfo(CraftSlotListElement element, UserData user)
		{
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341C")]
		[Address(RVA = "0x8449", Offset = "0x8449", VA = "0x8449")]
		public void UpdateInfo(UserData user, CraftSlotListElement element, long expirationTime)
		{
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341D")]
		[Address(RVA = "0x844A", Offset = "0x844A", VA = "0x844A")]
		private void DetermineActiveGroups(UserData user, CraftSlotListElement element, long expirationTime)
		{
		/* --- GHIDRA: DetermineActiveGroups ---
		void Gameplay_Craft_View_CraftInfoBox__DetermineActiveGroups
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57cd8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		    DAT_ram_00a57cd8 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341E")]
		[Address(RVA = "0x844B", Offset = "0x844B", VA = "0x844B")]
		private void HandleEmptySlot(CraftSlotListElement element)
		{
		/* --- GHIDRA: HandleEmptySlot ---
		void Gameplay_Craft_View_CraftInfoBox__HandleEmptySlot
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57cd9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		    DAT_ram_00a57cd9 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341F")]
		[Address(RVA = "0x844C", Offset = "0x844C", VA = "0x844C")]
		private void HandleInactiveSlot(UserData user, CraftSlotListElement element)
		{
		/* --- GHIDRA: HandleInactiveSlot ---
		void Gameplay_Craft_View_CraftInfoBox__HandleInactiveSlot(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cda == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_CraftInfoBox_State___ctor__);
		    DAT_ram_00a57cda = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_CraftInfoBox_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x844D", Offset = "0x844D", VA = "0x844D")]
		public CraftInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Craft_View_CraftInfoBox___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cdb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CraftRecipeListElement_CraftRecipeListElementArgs__get_args__
		              );
		    DAT_ram_00a57cdb = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x18);
		}
		*/

		}

		// Token: 0x04001C53 RID: 7251
		[Token(Token = "0x4001C53")]
		private const string LOCALIZATION_DURATION = "CRAFT/DURATION";

		// Token: 0x04001C54 RID: 7252
		[Token(Token = "0x4001C54")]
		private const string LOCALIZATION_EXPERIENCE = "CRAFT/EXPERIENCE";

		// Token: 0x04001C55 RID: 7253
		[Token(Token = "0x4001C55")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001C56 RID: 7254
		[Token(Token = "0x4001C56")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _artikulTitle;

		// Token: 0x04001C57 RID: 7255
		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _artikulDescription;

		// Token: 0x04001C58 RID: 7256
		[Token(Token = "0x4001C58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoaderValueRowView _valueRow;

		// Token: 0x04001C59 RID: 7257
		[Token(Token = "0x4001C59")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04001C5A RID: 7258
		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _duration;

		// Token: 0x04001C5B RID: 7259
		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _experience;

		// Token: 0x04001C5C RID: 7260
		[Token(Token = "0x4001C5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _craftButton;

		// Token: 0x04001C5D RID: 7261
		[Token(Token = "0x4001C5D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x04001C5E RID: 7262
		[Token(Token = "0x4001C5E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ButtonWithCost _accelerateButton;

		// Token: 0x04001C5F RID: 7263
		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x04001C60 RID: 7264
		[Token(Token = "0x4001C60")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x04001C61 RID: 7265
		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _sellAllButton;

		// Token: 0x04001C62 RID: 7266
		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ManufactureGroupView _manufactureGroup;

		// Token: 0x04001C63 RID: 7267
		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RentGroupView _rentGroup;

		// Token: 0x04001C64 RID: 7268
		[Token(Token = "0x4001C64")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _freeSlotDescription;

		// Token: 0x020008AB RID: 2219
		[Token(Token = "0x20008AB")]
		public enum State
		{
			// Token: 0x04001C66 RID: 7270
			[Token(Token = "0x4001C66")]
			UNKNOWN_STATE,
			// Token: 0x04001C67 RID: 7271
			[Token(Token = "0x4001C67")]
			EMPTY_SLOT_INFO,
			// Token: 0x04001C68 RID: 7272
			[Token(Token = "0x4001C68")]
			INACTIVE_SLOT_INFO,
			// Token: 0x04001C69 RID: 7273
			[Token(Token = "0x4001C69")]
			CRAFT_SLOT_INFO,
			// Token: 0x04001C6A RID: 7274
			[Token(Token = "0x4001C6A")]
			RECIPE_INFO,
			// Token: 0x04001C6B RID: 7275
			[Token(Token = "0x4001C6B")]
			CRAFT_COMPLETED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RentGroup ---
		void Gameplay_Craft_View_CraftInfoBox__get_RentGroup
		               (int param1,undefined4 param2,int param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  undefined1 auStack_10 [10];
		  ushort local_6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57cd2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23073);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4458);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4471);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4457);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4459);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26268);
		    DAT_ram_00a57cd2 = '\x01';
		  }
		  local_4 = 0;
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,4,Method_UI_MonoBehaviourWithStates_CraftInfoBox_State__set_CurrentState__);
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0xc) + 0xc) + 0x10);
		  uVar2 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (uVar2,param2,param2,uVar4,0);
		  iVar5 = *(int *)(*(int *)(param3 + 0xc) + 0xc);
		  uVar6 = *(undefined4 *)(iVar5 + 0x14);
		  uVar7 = *(undefined4 *)(iVar5 + 0x18);
		  uVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (uVar4,param2,param2,uVar2,uVar7,uVar6,0);
		  UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x2c),uVar4,0);
		  puVar8 = &StringLiteral_4458;
		  if (param4 == 0) {
		    puVar8 = &StringLiteral_4471;
		  }
		  uVar2 = *puVar8;
		  uVar4 = *(undefined4 *)(param1 + 0x28);
		  iVar5 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		  System_Collections_Generic_List_object____ctor(iVar5,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  uVar6 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar6,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar6,StringLiteral_26268,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar6,0);
		  *(undefined4 *)(iVar5 + 0x18) = uVar2;
		  local_6 = 0;
		  System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_6,param4,Method_System_Nullable_bool___ctor__);
		  *(ushort *)(iVar5 + 0x10) = local_6;
		  UI_Requirements_RequirementsView__GetRowPrefab(uVar4,iVar5,0);
		  Gameplay_Craft_View_CraftInfoBox__UpdateInfo(param1,*(undefined4 *)(param3 + 0xc),auStack_10);
		  uVar1 = *(uint *)(*(int *)(*(int *)(param3 + 0xc) + 8) + 0x18);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = func_ii_7331((ulonglong)uVar1,0);
		  uVar2 = Utils_TimeUtils__DateFormat((double)fVar3,0);
		  uVar7 = *(undefined4 *)(param1 + 0x30);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4457,1,0,1,0,0,0,0);
		  uVar6 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar6,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar6,StringLiteral_22759,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar4,uVar6,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar7,uVar2,0);
		  uVar7 = *(undefined4 *)(param1 + 0x34);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4459,1,0,1,0,0,0,0);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0xc) + 8) + 0x1c);
		  uVar6 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar4,StringLiteral_23073,uVar6,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar7,uVar2,0);
		  return;
		}
		*/

}
