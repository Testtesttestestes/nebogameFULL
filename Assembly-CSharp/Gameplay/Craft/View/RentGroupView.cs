using System;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	public class RentGroupView : MonoBehaviour
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6F")]
		public ButtonWithCost RentButton
		{
			[Token(Token = "0x600348E")]
			[Address(RVA = "0x84B8", Offset = "0x84B8", VA = "0x84B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x84B9", Offset = "0x84B9", VA = "0x84B9")]
		public void ShowDisabledRent(UserData user, CraftSlotListElement element)
		{
		/* --- GHIDRA: ShowDisabledRent ---
		void Gameplay_Craft_View_RentGroupView__ShowDisabledRent
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63a20 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4454);
		    DAT_ram_00a63a20 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4454,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  TMPro_TMP_Text__get_alignment(*(undefined4 *)(param1 + 0x14),0x201,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  Gameplay_Craft_View_RentGroupView__ShowFilledRent(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x84BA", Offset = "0x84BA", VA = "0x84BA")]
		public void ShowEmptyRent(long expirationTime)
		{
		/* --- GHIDRA: ShowEmptyRent ---
		void Gameplay_Craft_View_RentGroupView__ShowEmptyRent(int param1,longlong param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  if (param2 < 1) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x18),0,0);
		    return;
		  }
		  Gameplay_Craft_View_RentGroupView__ShowFilledRent(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x84BB", Offset = "0x84BB", VA = "0x84BB")]
		public void ShowFilledRent(long expirationTime)
		{
		/* --- GHIDRA: ShowFilledRent ---
		void Gameplay_Craft_View_RentGroupView__ShowFilledRent
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  float param2_00;
		  
		  if (DAT_ram_00a63a21 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_GetComponentInChildren_BacktimeViewUGUI___);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a63a21 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x18),1,0);
		  param1_00 = UnityEngine_GameObject__GetComponent___Il2CppFullySharedGenericType_
		                        (*(undefined4 *)(param1 + 0x18),
		                         Method_UnityEngine_GameObject_GetComponentInChildren_BacktimeViewUGUI___);
		  param1_01 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_01,0.0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param2,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_01,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x84BC", Offset = "0x84BC", VA = "0x84BC")]
		private void ShowTimer(long expirationTime)
		{
		/* --- GHIDRA: ShowTimer ---
		void Gameplay_Craft_View_RentGroupView__ShowTimer
		               (int param1,undefined4 param2,int param3,longlong param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a63a22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__get_CurrentState__);
		    DAT_ram_00a63a22 = '\x01';
		  }
		  iVar2 = *(int *)(param3 + 0x18);
		  if (iVar2 != 1) {
		    if (iVar2 == 2) {
		      Gameplay_Craft_View_RentGroupView__ShowDisabledRent(param1,param4,param1);
		      return;
		    }
		    if (iVar2 == 3) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		      if (0 < param4) {
		        Gameplay_Craft_View_RentGroupView__ShowFilledRent(param1,param4,param1);
		        return;
		      }
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x18),0,0);
		    }
		    return;
		  }
		  Gameplay_Craft_View_RentGroupView__get_RentButton(param1,param2,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x84BD", Offset = "0x84BD", VA = "0x84BD")]
		public void ResolveSlot(UserData user, CraftSlotListElement element, long expirationTime)
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x84BE", Offset = "0x84BE", VA = "0x84BE")]
		public RentGroupView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Craft_View_RentGroupView___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a63a23 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63a23 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8232bd93;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8232bd93:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x04001CC7 RID: 7367
		[Token(Token = "0x4001CC7")]
		private const string LOCALIZATION_RENT_SLOT_ANNOTATION = "CRAFT/RENT_SLOT_ANNOTATION";

		// Token: 0x04001CC8 RID: 7368
		[Token(Token = "0x4001CC8")]
		private const string LOCALIZATION_CRAFT_START_CONDITION = "CRAFT/CRAFT_START_CONDITION";

		// Token: 0x04001CC9 RID: 7369
		[Token(Token = "0x4001CC9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ButtonWithCost _rentButton;

		// Token: 0x04001CCA RID: 7370
		[Token(Token = "0x4001CCA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001CCB RID: 7371
		[Token(Token = "0x4001CCB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _timer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RentButton ---
		void Gameplay_Craft_View_RentGroupView__get_RentButton
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  int *param1_01;
		  int iVar6;
		  double param1_02;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63a1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4477);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24333);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    DAT_ram_00a63a1f = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  uVar4 = *(uint *)(*(int *)(param3 + 0x48) + 0x10);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  param1_02 = (double)uVar4;
		  local_8 = func_ii_7125(param1_02,0);
		  uVar3 = (undefined4)((ulonglong)param1_02 >> 0x20);
		  uVar5 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4477,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = System_TimeSpan__ToString(&local_8,StringLiteral_24333,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_22759,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar1,0);
		  TMPro_TMP_Text__get_alignment(*(undefined4 *)(param1 + 0x14),0x202,0);
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar4 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_01;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8 + 4) * 8 + iVar6 + 0x160);
		        goto code_r0x8232ba61;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8232ba61:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(uVar3,param1_01),puVar2[1]);
		  iVar6 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit
		                    (uVar3,*(undefined4 *)(*(int *)(param3 + 0x48) + 0x14),0);
		  uVar3 = *(undefined4 *)(iVar6 + 0x10);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  UI_Price_Price__SetColor(*(undefined4 *)(*(int *)(param1 + 0x10) + 0xb8),param2,uVar3,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  return;
		}
		*/

}
