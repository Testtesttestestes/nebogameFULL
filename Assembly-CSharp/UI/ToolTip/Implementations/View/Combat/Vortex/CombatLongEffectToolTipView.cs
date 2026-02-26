using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat.Vortex
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	public class CombatLongEffectToolTipView : BaseToolTip<EffectData[]>
	{
		// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x5D53", Offset = "0x5D53", VA = "0x5D53", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Combat_Vortex_CombatLongEffectToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5998d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_EffectData_____ctor__);
		    DAT_ram_00a5998d = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_EffectData_____ctor__);
		  return;
		}
		*/

		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59984 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_EffectData___ctor__);
		    DAT_ram_00a59984 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ToolTip_BaseToolTip_EffectData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x5D54", Offset = "0x5D54", VA = "0x5D54")]
		public CombatLongEffectToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_Vortex_CombatLongEffectToolTipView___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 in_i2q;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  float param2_00;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int iVar10;
		  int *param1_00;
		  int *piVar11;
		  undefined8 uVar12;
		  int iVar13;
		  int iVar14;
		  
		  uVar8 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  iVar7 = 0;
		  if (DAT_ram_00a5998e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanCombatPlayer__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2634);
		    DAT_ram_00a5998e = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    piVar9 = *(int **)(param1 + 0x2c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_2634,1,0,1,0,0,0,0);
		    iVar13 = *piVar9;
		    uVar12 = CONCAT44(in_register_20000014,uVar3);
		    uVar2 = CONCAT44(uVar8,*(undefined4 *)(iVar13 + 0x2d4));
		    (**(code **)((ulonglong)*(uint *)(iVar13 + 0x2d0) * 4))(piVar9,uVar12,uVar2);
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar8 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar13 = *piVar9;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x140);
		          goto code_r0x8109b1dd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8109b1dd:
		    uVar12 = CONCAT44(uVar8,puVar4[1]);
		    iVar13 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar12);
		    iVar10 = *(int *)(iVar13 + 0x14);
		    iVar13 = 0;
		    piVar9 = *(int **)(param1 + 0x18);
		    uVar8 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    uVar5 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		    iVar14 = *piVar9;
		    uVar12 = CONCAT44(uVar8,uVar5);
		    (**(code **)((ulonglong)*(uint *)(iVar14 + 0x2d0) * 4))
		              (piVar9,uVar12,CONCAT44(uVar3,*(undefined4 *)(iVar14 + 0x2d4)));
		    iVar14 = **(int **)(param1 + 0x20);
		    uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),
		                      *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x14) + 0x38));
		    (**(code **)((ulonglong)*(uint *)(iVar14 + 0x138) * 4))
		              (*(int **)(param1 + 0x20),uVar12,*(undefined4 *)(iVar14 + 0x13c));
		    uVar8 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    Gameplay_UserInfo_View_CultView2__get_CultDic
		              (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x20),0);
		    uVar5 = *(undefined4 *)(param1 + 0x1c);
		    uVar3 = Core_Data_UserData__set_Level(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		    Gameplay_Combat_View_Players_CombatPlayerLevelView__SetValue(uVar5,uVar3,0);
		    uVar5 = *(undefined4 *)(param1 + 0x1c);
		    uVar3 = Gameplay_Combat_Model_CombatPlayer__set_User(*(undefined4 *)(param1 + 0x14),0);
		    Gameplay_Combat_View_Players_CombatPlayerLevelView__HandleIsPreminumExpChanged(uVar5,uVar3,0);
		    uVar3 = *(undefined4 *)(param1 + 0x1c);
		    if (*(int *)(iVar10 + 8) == *(int *)(*(int *)(param1 + 0x14) + 0x14)) {
		      param2_00 = Gameplay_User_Model_UserModel__get_AvailableCults(iVar10,0);
		    }
		    else {
		      param2_00 = 0.0;
		    }
		    Gameplay_Combat_View_Players_CombatPlayerLevelView__SetRank(uVar3,param2_00,0);
		    uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)
		                        (*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x14) + 0x34) + 0x3c),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		    UI_ToolTip_Implementations_View_Parts_MedalViewWhitTitle___ctor
		              (*(undefined4 *)(param1 + 0x28),uVar3,
		               (uint)(*(int *)(*(int *)(param1 + 0x14) + 0x14) == *(int *)(iVar10 + 8)),iVar10);
		    iVar10 = **(int **)(param1 + 0x14);
		    uVar12 = CONCAT44(uVar8,*(undefined4 *)(iVar10 + 0xfc));
		    iVar10 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0xf8) * 4))(*(int **)(param1 + 0x14),uVar12)
		    ;
		    uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),*(undefined4 *)(iVar10 + 0xc));
		    piVar9 = (int *)Mono_Security_ASN1Convert__ToOid
		                              (Core_Data_Skills_SkillData___TypeInfo,*(undefined4 *)(iVar10 + 0xc));
		    if (0 < *(int *)(iVar10 + 0xc)) {
		      do {
		        uVar8 = (undefined4)((ulonglong)uVar12 >> 0x20);
		        uVar3 = System_Linq_Enumerable__ToList_object_
		                          (iVar10,iVar13,Method_System_Collections_Generic_List_int__get_Item__);
		        iVar14 = unnamed_function_1417(Core_Data_Skills_SkillData_TypeInfo);
		        Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar14,uVar3,0);
		        iVar6 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x58),uVar3,
		                           Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		        *(undefined8 *)(iVar14 + 0x10) = *(undefined8 *)(iVar6 + 0x10);
		        iVar6 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                          (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x5c),uVar3,
		                           Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__);
		        if (iVar6 == 0) {
		          uVar12 = 0;
		        }
		        else {
		          iVar6 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x5c),uVar3,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          uVar12 = *(undefined8 *)(iVar6 + 0x10);
		        }
		        *(undefined8 *)(iVar14 + 0x18) = uVar12;
		        uVar12 = CONCAT44(uVar8,*(undefined4 *)(*piVar9 + 0x20));
		        iVar6 = func_ii_1082(iVar14,*(undefined4 *)(*piVar9 + 0x20));
		        if (iVar6 == 0) {
		          uVar8 = func_ii_1083();
		          func_ii_1050(uVar8,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar9[iVar13 + 4] = iVar14;
		        iVar13 = iVar13 + 1;
		      } while (iVar13 < *(int *)(iVar10 + 0xc));
		    }
		    if (0 < piVar9[3]) {
		      do {
		        uVar8 = (undefined4)((ulonglong)uVar12 >> 0x20);
		        iVar13 = piVar9[iVar7 + 4];
		        uVar3 = *(undefined4 *)(param1 + 0x34);
		        uVar5 = *(undefined4 *)(param1 + 0x30);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        uVar3 = func_ii_6805(uVar5,uVar3,
		                             Method_UnityEngine_Object_Instantiate_CombatSkillItemRenderer___);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar10 = *param1_00;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		              puVar4 = (uint *)(piVar11[1] * 8 + iVar10 + 0x178);
		              goto code_r0x8109b4b5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8109b4b5:
		        uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar8,puVar4[1]));
		        uVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar8,0);
		        uVar8 = System_Collections_Generic_Dictionary_int__object___get_Item
		                          (uVar8,*(int *)(iVar13 + 8) + 1,0);
		        Google_Protobuf_Collections_RepeatedField_ulong___get_Item(uVar3,iVar7,0);
		        uVar5 = func_ii_7990(uVar8,0);
		        Core_Extensions_Dict_UserRatingKindDicExt__GetTitle(uVar3,uVar5,0);
		        uVar8 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar8,0);
		        Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId(uVar3,uVar8,0);
		        uVar12 = *(undefined8 *)(iVar13 + 0x10);
		        Gameplay_Combat_View_Players_CombatPlayerView__Gameplay_Combat_View_Players_ICombatPLayerView_get_gameObject
		                  (uVar3,uVar12,(double)*(longlong *)(iVar13 + 0x18),0);
		        iVar7 = iVar7 + 1;
		      } while (iVar7 < piVar9[3]);
		    }
		    uVar1 = 0;
		    iVar7 = Core_Extensions_UriExt___c___QueryStringToDictionary_b__0_1
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		    if (iVar7 != 0) {
		      uVar1 = (uint)(*(int *)(*(int *)(param1 + 0x14) + 0x54) !=
		                    *(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x14));
		    }
		    uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x38),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar8,uVar1,0);
		    uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    if (iVar7 == 0) {
		      uVar1 = 1;
		    }
		    else {
		      uVar1 = (uint)(*(int *)(*(int *)(param1 + 0x14) + 0x54) ==
		                    *(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x14));
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar8,uVar1,0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipView___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59985 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_CombatSpellData___ctor__
		              );
		    DAT_ram_00a59985 = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___set_Selected
		            (param1,
		             Method_UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_CombatSpellData___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/VortexCombat/CombatLongEffectToolTipView";

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CombatLongEffectToolTipItemView _prefab;
	}
}
