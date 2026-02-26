using System;
using Core.Data.Spells;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UnityEngine;

namespace Gameplay.Boss.View.RolesTab
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	public class BossRoleSpellDescription : MonoBehaviour
	{
		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600464E RID: 17998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DDB")]
		public SpellData Spell
		{
			[Token(Token = "0x600464D")]
			[Address(RVA = "0x94E6", Offset = "0x94E6", VA = "0x94E6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600464E")]
			[Address(RVA = "0x94E7", Offset = "0x94E7", VA = "0x94E7")]
			set
			{
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x94E8", Offset = "0x94E8", VA = "0x94E8")]
		public BossRoleSpellDescription()
		{
		}

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		private const string LEVEL_TAG = "value";

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x1C")]
		private SpellData _spell;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Spell ---
		void Gameplay_Boss_View_RolesTab_BossRoleSpellDescription__get_Spell
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  longlong lVar7;
		  int *piVar8;
		  undefined4 param1_00;
		  int iVar9;
		  
		  if (DAT_ram_00a579c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a579c6 = '\x01';
		  }
		  *(int **)(param1 + 0x1c) = param2;
		  if (param2 != (int *)0x0) {
		    piVar8 = *(int **)(param1 + 0x10);
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0x10c));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,uVar1);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar2 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar2,0);
		    iVar9 = *piVar8;
		    uVar1 = CONCAT44(uVar6,uVar2);
		    (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		              (piVar8,uVar1,*(undefined4 *)(iVar9 + 0x2d4));
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    uVar3 = func_ii_10810(*(undefined4 *)(param1 + 0x1c),0);
		    uVar4 = Core_Extensions_Dict_ResourceSetExt__GetDelta(uVar3,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,uVar4 ^ 1,0);
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    iVar9 = **(int **)(param1 + 0x1c);
		    uVar1 = CONCAT44(uVar6,*(undefined4 *)(iVar9 + 0xe4));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0xe0) * 4))(*(int **)(param1 + 0x1c),uVar1);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = func_ii_10810(*(undefined4 *)(param1 + 0x1c),0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    UI_Price_Price__SetColor(param1_00,uVar2,uVar3,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    lVar7 = Core_Data_Spells_SpellData__get_Level(*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(0 < lVar7),0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar4 = 0;
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar4 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar4 * 8 + 4) * 8 + iVar9 + 0x178);
		          goto code_r0x80e0f3db;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar4);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e0f3db:
		    uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,CONCAT44(uVar6,puVar5[1]));
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		    uVar6 = System_Collections_Generic_Dictionary_int__object___get_Item(uVar6,5,0);
		    uVar6 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar6,0);
		    UI_Price_PriceItemRenderer__SetIcon(uVar2,uVar6,0);
		    uVar6 = *(undefined4 *)(param1 + 0x18);
		    lVar7 = Core_Data_Spells_SpellData__get_Level(*(undefined4 *)(param1 + 0x1c),0);
		    UI_Price_PriceItemRenderer__set_ValidIconEnabled(uVar6,(double)lVar7,0);
		  }
		  return;
		}
		*/

}
