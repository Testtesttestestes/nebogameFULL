using System;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI;
using UnityEngine;
using Utils;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000891 RID: 2193
	[Token(Token = "0x2000891")]
	public class DiscountGroup : MonoBehaviourWithStates<DiscountGroup.State>
	{
		// Token: 0x060033BC RID: 13244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x83F6", Offset = "0x83F6", VA = "0x83F6")]
		public void Init(double coeff, DiscountTargets discountType)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Discounts_View_DiscountGroup__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  Gameplay_Discounts_View_DiscountGroup__DisplayDiscountAmount
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = Core_Extensions_Dict_DiscountsDicExt__GetDescription(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_Discounts_View_DiscountGroup__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  Gameplay_Discounts_View_DiscountGroup__DisplayDiscountAmount
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = Core_Extensions_Dict_DiscountsDicExt__GetDescription(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_Discounts_View_DiscountGroup__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  Gameplay_Discounts_View_DiscountGroup__DisplayDiscountAmount
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = Core_Extensions_Dict_DiscountsDicExt__GetDescription(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_Discounts_View_DiscountGroup__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  Gameplay_Discounts_View_DiscountGroup__DisplayDiscountAmount
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = Core_Extensions_Dict_DiscountsDicExt__GetDescription(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_Discounts_View_DiscountGroup__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  Gameplay_Discounts_View_DiscountGroup__DisplayDiscountAmount
		            (param1,*(undefined4 *)(param2 + 0x10),param2);
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = Core_Extensions_Dict_DiscountsDicExt__GetDescription(*(undefined4 *)(param2 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x83F7", Offset = "0x83F7", VA = "0x83F7")]
		public void Init(double coeff, DiscountTargets discountType, string key)
		{
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x83F8", Offset = "0x83F8", VA = "0x83F8")]
		public void Init(DiscountData discountData)
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x83F9", Offset = "0x83F9", VA = "0x83F9")]
		public void Init(double coeff, string key)
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x1E28", Offset = "0x1E28", VA = "0x1E28")]
		public void Init(IDiscountArgs value)
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x83FA", Offset = "0x83FA", VA = "0x83FA")]
		private void HandleDiscountType(DiscountTargets discountType)
		{
		/* --- GHIDRA: HandleDiscountType ---
		void Gameplay_Discounts_View_DiscountGroup__HandleDiscountType
		               (int param1,double param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 uVar2;
		  double dVar3;
		  undefined4 param1_00;
		  double param1_01;
		  double dVar4;
		  ulonglong uVar5;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a57ca9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26061);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28645);
		    DAT_ram_00a57ca9 = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  param1_01 = param2 * 100.0;
		  dVar3 = unnamed_function_4206(param1_01,&local_8);
		  dVar4 = (double)local_8;
		  if (0.0 <= param1_01) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        dVar4 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar4 = FLOOR(param1_01 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      dVar4 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar4 = CEIL(param1_01 + -0.5);
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(param3,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = (float8)dVar4;
		  uVar2 = func_ii_1081(DAT_ram_00a66970,&local_8);
		  uVar2 = func_ii_4419(StringLiteral_28645,uVar2,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_26061,uVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_10;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,param2_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x83FB", Offset = "0x83FB", VA = "0x83FB")]
		public void DisplayDiscountAmount(double value, string key)
		{
		/* --- GHIDRA: DisplayDiscountAmount ---
		void Gameplay_Discounts_View_DiscountGroup__DisplayDiscountAmount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57caa == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6161);
		    DAT_ram_00a57caa = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x20);
		  param1_00 = unnamed_function_1417(Core_Data_InfoRows_BackTimeRow_TypeInfo);
		  Core_Data_InfoRows_CommonRow___ctor(param1_00,param2,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6161,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0xc) = uVar1;
		  UI_Requirements_RequirementsView__GetRowPrefab(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x83FC", Offset = "0x83FC", VA = "0x83FC")]
		public void DisplayBackTime(BackTime value)
		{
		/* --- GHIDRA: DisplayBackTime ---
		void Gameplay_Discounts_View_DiscountGroup__DisplayBackTime(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DiscountGroup_State__set_CurrentState__);
		    DAT_ram_00a57cab = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,Method_UI_MonoBehaviourWithStates_DiscountGroup_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x83FD", Offset = "0x83FD", VA = "0x83FD")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Discounts_View_DiscountGroup__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DiscountGroup_State__set_CurrentState__);
		    DAT_ram_00a57cac = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,Method_UI_MonoBehaviourWithStates_DiscountGroup_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x83FE", Offset = "0x83FE", VA = "0x83FE")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Discounts_View_DiscountGroup__OnDisable(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cad == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_DiscountGroup_State___ctor__);
		    DAT_ram_00a57cad = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_DiscountGroup_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x83FF", Offset = "0x83FF", VA = "0x83FF")]
		public DiscountGroup()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_View_DiscountGroup___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a57cae == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6162);
		    DAT_ram_00a57cae = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  piVar5 = *(int **)(param2 + 8);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80e449e2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,1);
		code_r0x80e449e2:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(double *)(iVar6 + 0x10) < 1.0),0);
		  piVar5 = *(int **)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_6162,1,0,1,0,0,0,0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param1_00 = *(int **)(param2 + 8);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x80e44ac3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,1);
		code_r0x80e44ac3:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  local_8 = (float8)(*(double *)(iVar7 + 0x10) * 100.0);
		  uVar1 = 0;
		  uVar4 = func_ii_7515(&local_8,0);
		  uVar4 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar4,StringLiteral_708,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_28217,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar6,0);
		  iVar6 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar5,uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  piVar5 = *(int **)(param2 + 8);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e44bc8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,2);
		code_r0x80e44bc8:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(iVar6 != 0),0);
		  piVar5 = *(int **)(param2 + 8);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e44c56;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,2);
		code_r0x80e44c56:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (iVar6 != 0) {
		    uVar1 = 0;
		    uVar2 = *(undefined4 *)(param1 + 0x14);
		    piVar5 = *(int **)(param2 + 8);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x80e44ce2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,2);
		code_r0x80e44ce2:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar2,*(undefined4 *)(iVar6 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001C28 RID: 7208
		[Token(Token = "0x4001C28")]
		private const string DEFAULT_DISCOUNT_KEY = "DISCOUNTS/BUY_DISCOUNT";

		// Token: 0x04001C29 RID: 7209
		[Token(Token = "0x4001C29")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _discountText;

		// Token: 0x04001C2A RID: 7210
		[Token(Token = "0x4001C2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeRowViewDynamic _backtimeRow;

		// Token: 0x02000892 RID: 2194
		[Token(Token = "0x2000892")]
		public enum State
		{
			// Token: 0x04001C2C RID: 7212
			[Token(Token = "0x4001C2C")]
			UNKNOWN_STATE,
			// Token: 0x04001C2D RID: 7213
			[Token(Token = "0x4001C2D")]
			ENABLED,
			// Token: 0x04001C2E RID: 7214
			[Token(Token = "0x4001C2E")]
			DISABLED
		}
	}
}
