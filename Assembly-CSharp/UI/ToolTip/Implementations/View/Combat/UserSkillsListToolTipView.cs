using System;
using Core.Data.Skills;
using Gameplay.Combat.View.Players;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public class UserSkillsListToolTipView : BaseToolTip<SkillData[]>
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x5D4F", Offset = "0x5D4F", VA = "0x5D4F", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Combat_UserSkillsListToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59989 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_SkillData_____ctor__);
		    DAT_ram_00a59989 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ToolTip_BaseToolTip_SkillData_____ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x5D50", Offset = "0x5D50", VA = "0x5D50")]
		public UserSkillsListToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_UserSkillsListToolTipView___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *param1_00;
		  int iVar10;
		  double param2_00;
		  
		  if (DAT_ram_00a5998a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_CombatSpellData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10697);
		    DAT_ram_00a5998a = '\x01';
		  }
		  uVar1 = func_ii_10810(*(undefined4 *)(param1 + 0x14),0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta(uVar1,0);
		  lVar5 = Core_Data_Spells_SpellData__get_Level(*(undefined4 *)(param1 + 0x14),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < lVar5) | uVar2 ^ 1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar2 ^ 1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < lVar5),0);
		  if (uVar2 == 0) {
		    iVar10 = *(int *)(param1 + 0x34);
		    iVar8 = *(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x34) + 0x14);
		    uVar1 = func_ii_10810(*(int *)(param1 + 0x14),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		    iVar7 = *(int *)(iVar10 + 0x24);
		    if (iVar7 != iVar8) {
		      *(int *)(iVar10 + 0x24) = iVar8;
		      iVar9 = func_ii_12174(iVar10,0);
		      if (iVar9 != 0) {
		        if (iVar7 != 0) {
		          UI_Price_Price__StartListenEvents(iVar10,iVar7,iVar10);
		        }
		        if (iVar8 != 0) {
		          UI_Price_Price__set_PriceValue(iVar10,iVar8,iVar10);
		        }
		      }
		    }
		    UI_Price_Price__get_PriceValue(iVar10,uVar1,iVar10);
		  }
		  if (0 < lVar5) {
		    iVar10 = 0;
		    UI_Price_PriceItemRenderer__SetColor(*(undefined4 *)(param1 + 0x30),1,0);
		    iVar7 = *(int *)(param1 + 0x40);
		    iVar8 = *(int *)(iVar7 + 0xc);
		    if (0 < iVar8) {
		      do {
		        iVar9 = *(int *)(iVar7 + iVar10 * 4 + 0x10);
		        if (*(int *)(iVar9 + 8) ==
		            *(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x34) + 8) + 0x30)) {
		          UI_Price_PriceItemRenderer__HandleValidIconEnabledChanged
		                    (*(undefined4 *)(param1 + 0x30),*(undefined4 *)(iVar9 + 0xc),0);
		          iVar8 = *(int *)(iVar7 + 0xc);
		        }
		        iVar10 = iVar10 + 1;
		      } while (iVar10 < iVar8);
		    }
		    uVar1 = *(undefined4 *)(param1 + 0x30);
		    lVar5 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x34),0);
		    lVar6 = Core_Data_Spells_SpellData__get_Level(*(undefined4 *)(param1 + 0x14),0);
		    UI_Price_PriceItemRenderer__set_TruncatePrice(uVar1,(uint)(lVar6 <= lVar5),0);
		    uVar1 = *(undefined4 *)(param1 + 0x30);
		    lVar5 = Core_Data_Spells_SpellData__get_Level(*(undefined4 *)(param1 + 0x14),0);
		    param2_00 = (double)lVar5;
		    UI_Price_PriceItemRenderer__set_ValidIconEnabled(uVar1,param2_00,0);
		    in_register_20000014 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  }
		  lVar5 = Core_Data_Spells_SpellData__get_ManaPriceOfUse(*(undefined4 *)(param1 + 0x14),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < lVar5),0);
		  if (0 < lVar5) {
		    UI_Price_PriceItemRenderer__SetColor(*(undefined4 *)(param1 + 0x3c),1,0);
		    uVar1 = *(undefined4 *)(param1 + 0x3c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar2 = 0;
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar10 = *param1_00;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0x178);
		          goto code_r0x8109aba5;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8109aba5:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))
		                      (param1_00,CONCAT44(in_register_20000014,puVar3[1]));
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    uVar4 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar4,StringLiteral_10697,0);
		    UI_Price_PriceItemRenderer__SetIcon(uVar1,uVar4,0);
		    uVar1 = *(undefined4 *)(param1 + 0x3c);
		    lVar5 = Gameplay_Combat_Model_CombatPlayer__get_TotalExtraHealth
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x34),0);
		    lVar6 = Core_Data_Spells_SpellData__get_ManaPriceOfUse(*(undefined4 *)(param1 + 0x14),0);
		    UI_Price_PriceItemRenderer__set_TruncatePrice(uVar1,(uint)(lVar6 <= lVar5),0);
		    uVar1 = *(undefined4 *)(param1 + 0x3c);
		    lVar5 = Core_Data_Spells_SpellData__get_ManaPriceOfUse(*(undefined4 *)(param1 + 0x14),0);
		    UI_Price_PriceItemRenderer__set_ValidIconEnabled(uVar1,(double)lVar5,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CombatSkillItemRenderer _rowPrefab;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _rowsHost;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/UserSkillsListToolTipView";
	}
}
