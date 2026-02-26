using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	public class CombatLongEffectToolTipItemView : MonoBehaviour
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000037E0 File Offset: 0x000019E0
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		public bool BackgroundEnabled
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x5D41", Offset = "0x5D41", VA = "0x5D41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x5D42", Offset = "0x5D42", VA = "0x5D42")]
			set
			{
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000037F8 File Offset: 0x000019F8
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public int Index
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x5D43", Offset = "0x5D43", VA = "0x5D43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x5D44", Offset = "0x5D44", VA = "0x5D44")]
			set
			{
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x5D45", Offset = "0x5D45", VA = "0x5D45")]
		private void HandleIndexChanged()
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public EffectData Data
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x5D46", Offset = "0x5D46", VA = "0x5D46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x5D47", Offset = "0x5D47", VA = "0x5D47")]
			set
			{
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x5D48", Offset = "0x5D48", VA = "0x5D48")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x5D49", Offset = "0x5D49", VA = "0x5D49")]
		public CombatLongEffectToolTipItemView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView___ctor
		               (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a59983 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_EffectData__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_EffectData__get_Data__);
		    DAT_ram_00a59983 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  param2_00 = *(int *)(param1 + 0x14);
		  if (*(int *)(param1_00 + 0x2c) != param2_00) {
		    *(int *)(param1_00 + 0x2c) = param2_00;
		    UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__set_Data
		              (param1_00,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _level;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _turns;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _background;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		public const string VALUE_TEXT_VAR = "value";

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x24")]
		private bool _backgroundEnabled;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x28")]
		private int _index;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x2C")]
		private EffectData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BackgroundEnabled ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__get_BackgroundEnabled
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 != *(byte *)(param1 + 0x24)) {
		    *(char *)(param1 + 0x24) = (char)param2;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x24),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Index ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__get_Index
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined1 uVar1;
		  undefined4 param1_00;
		  
		  if (*(uint *)(param1 + 0x28) != param2) {
		    *(uint *)(param1 + 0x28) = param2;
		    uVar1 = 1;
		    if ((param2 & 1) == 0) {
		      if (*(char *)(param1 + 0x24) != '\0') {
		        return;
		      }
		    }
		    else {
		      uVar1 = 0;
		      if (*(char *)(param1 + 0x24) == '\0') {
		        return;
		      }
		    }
		    *(undefined1 *)(param1 + 0x24) = uVar1;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x24),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Index ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__set_Index
		               (int param1,undefined4 param2)
		
		{
		  undefined1 uVar1;
		  undefined4 param1_00;
		  
		  uVar1 = 1;
		  if ((*(byte *)(param1 + 0x28) & 1) == 0) {
		    if (*(char *)(param1 + 0x24) != '\0') {
		      return;
		    }
		  }
		  else {
		    uVar1 = 0;
		    if (*(char *)(param1 + 0x24) == '\0') {
		      return;
		    }
		  }
		  *(undefined1 *)(param1 + 0x24) = uVar1;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x24),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x2c)) {
		    *(int *)(param1 + 0x2c) = param2;
		    UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__set_Data(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 param3;
		  longlong lVar4;
		  undefined8 uVar5;
		  int iVar6;
		  int *piVar7;
		  double param1_00;
		  int iVar8;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59982 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15121);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1136);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15120);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59982 = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    uVar1 = Core_Extensions_Dict_EffectDictExt__GetIcon44x44AssetId
		                      (*(undefined4 *)(*(int *)(param1 + 0x2c) + 8),0);
		    iVar6 = *(int *)(*(int *)(param1 + 0x2c) + 0x18);
		    if (1 < iVar6) {
		      local_10 = CONCAT44(local_10._4_4_,iVar6);
		      uVar2 = func_ii_1081(DAT_ram_00a66954,&local_10);
		      uVar2 = func_ii_4419(StringLiteral_1136,uVar2,0);
		      uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,uVar2,0);
		    }
		    iVar6 = **(int **)(param1 + 0x10);
		    uVar5 = CONCAT44(in_register_20000004,*(int **)(param1 + 0x10));
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (uVar5,uVar1,*(undefined4 *)(iVar6 + 0x2d4));
		    piVar7 = *(int **)(param1 + 0x14);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    uVar2 = Core_Data_Effect_EffectData__get_MaxStack(*(undefined4 *)(param1 + 0x2c),0);
		    uVar2 = Core_Data_Effect_AbstractEffectDescription__Reset(uVar2,0);
		    iVar6 = *piVar7;
		    uVar5 = CONCAT44(uVar1,piVar7);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (uVar5,uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		    piVar7 = *(int **)(param1 + 0x18);
		    local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0xc) + 0x10);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    iVar6 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    if (iVar6 == 0) {
		      iVar6 = StringLiteral_5;
		    }
		    iVar8 = *piVar7;
		    uVar5 = CONCAT44(uVar1,piVar7);
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		              (uVar5,iVar6,*(undefined4 *)(iVar8 + 0x2d4));
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    lVar4 = Core_Data_Effect_EffectData__get_Duration(*(undefined4 *)(param1 + 0x2c),0);
		    piVar7 = *(int **)(param1 + 0x1c);
		    if (lVar4 < 1) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_15121,1,0,1,0,0,0,0);
		      iVar8 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		      local_4 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x1c);
		      iVar6 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      local_10 = 0;
		      if (iVar6 == 0) {
		        iVar6 = StringLiteral_5;
		      }
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_28217,iVar6,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar8 + 0x10) = local_10;
		      uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar2,iVar8,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x2d0) * 4))
		                (CONCAT44(uVar1,piVar7),uVar2,*(undefined4 *)(*piVar7 + 0x2d4));
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = func_ii_7508(StringLiteral_15120,1,0,1,0,0,0,0);
		      iVar6 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		      uVar5 = Core_Data_Effect_EffectData__get_Duration(*(undefined4 *)(param1 + 0x2c),0);
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      fVar3 = func_ii_7331(uVar5,0);
		      param1_00 = (double)fVar3;
		      param3 = Utils_TimeUtils__DateFormat(param1_00,0);
		      local_10 = 0;
		      uVar2 = (undefined4)((ulonglong)param1_00 >> 0x20);
		      System_Text_Formatting_StringView__get_IsEmpty
		                (&local_10,StringLiteral_28217,param3,
		                 Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		      *(undefined8 *)(iVar6 + 0x10) = local_10;
		      uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                        (uVar1,iVar6,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x2d0) * 4))
		                (CONCAT44(uVar2,piVar7),uVar1,*(undefined4 *)(*piVar7 + 0x2d4));
		    }
		  }
		  return;
		}
		*/

}
