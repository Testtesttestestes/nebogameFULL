using System;
using Gameplay.School.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.RightPanel.TitledList;
using UI.Price;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	public class SpellCurrentDescriptionTitledListElement : BaseTitledListElement<SpellCurrentDescriptionTitledListElementArgs>
	{
		// Token: 0x060026D7 RID: 9943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x780C", Offset = "0x780C", VA = "0x780C", Slot = "6")]
		protected override void OnInit(SpellCurrentDescriptionTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_School_View_SpellCurrentDescriptionTitledListElement__OnInit
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  longlong lVar8;
		  int *piVar9;
		  int iVar10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a048 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13731);
		    DAT_ram_00a5a048 = '\x01';
		  }
		  piVar9 = *(int **)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13731,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0xf4));
		  local_4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))(param2,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar3,StringLiteral_28217,uVar4,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar3,0);
		  iVar10 = *piVar9;
		  uVar1 = CONCAT44(uVar7,uVar2);
		  (**(code **)((ulonglong)*(uint *)(iVar10 + 0x2d0) * 4))
		            (piVar9,uVar1,*(undefined4 *)(iVar10 + 0x2d4));
		  piVar9 = *(int **)(param1 + 0x14);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param2 + 0x10c));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(param2,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar2,0);
		  iVar10 = *piVar9;
		  uVar1 = CONCAT44(uVar7,uVar2);
		  (**(code **)((ulonglong)*(uint *)(iVar10 + 0x2d0) * 4))
		            (piVar9,uVar1,*(undefined4 *)(iVar10 + 0x2d4));
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = func_ii_10810(param2,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  uVar5 = Core_Money_Money__op_Multiply(uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar5 ^ 1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param2 + 0xe4));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))(param2,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  UI_Price_Price__SetColor(uVar4,uVar3,uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  lVar8 = Core_Data_Spells_SpellData__get_Level(param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0 < lVar8),0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar5 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar5 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x811b92ea;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar5);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b92ea:
		  uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,CONCAT44(uVar7,puVar6[1]));
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  uVar7 = System_Collections_Generic_Dictionary_int__object___get_Item(uVar7,5,0);
		  uVar7 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar7,0);
		  UI_Price_PriceItemRenderer__SetIcon(uVar2,uVar7,0);
		  uVar7 = *(undefined4 *)(param1 + 0x1c);
		  lVar8 = Core_Data_Spells_SpellData__get_Level(param2,0);
		  UI_Price_PriceItemRenderer__set_ValidIconEnabled(uVar7,(double)lVar8,0);
		  return;
		}
		*/

		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x780D", Offset = "0x780D", VA = "0x780D")]
		public void UpdateSpell(SchoolSpellData spellData)
		{
		/* --- GHIDRA: UpdateSpell ---
		void Gameplay_School_View_SpellCurrentDescriptionTitledListElement__UpdateSpell
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a049 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_SpellCurrentDescriptionTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a5a049 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_SpellCurrentDescriptionTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x780E", Offset = "0x780E", VA = "0x780E")]
		public SpellCurrentDescriptionTitledListElement()
		{
		}

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		private const string SPELL_UPGRADE_TO_LEVEL = "SCHOOL/SPELL/UPGRADE_TO_LEVEL";

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		private const string LEVEL_TAG = "value";

		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;
	}
}
