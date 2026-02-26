using System;
using Core.Data.Balance;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UnityEngine;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	public class SpellDescriptionGroup : MonoBehaviour
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026E")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001089")]
			[Address(RVA = "0x6286", Offset = "0x6286", VA = "0x6286")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x6287", Offset = "0x6287", VA = "0x6287")]
		public void Init(SpellDic spellDic, SpellLevelDic spellLevelDic, Money cost, long manaPrice, IBalanceSource balance)
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x6288", Offset = "0x6288", VA = "0x6288")]
		public SpellDescriptionGroup()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellDescriptionGroup___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58ad5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58ad5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
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

		}

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Title ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellDescriptionGroup__get_Title
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,longlong param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  double param2_00;
		  
		  if (DAT_ram_00a58ad4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Spells_SpellData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_SpellData___);
		    Mono_Security_ASN1__get_Item(&Core_Data_Spells_SpellsBasedDescription_TypeInfo);
		    DAT_ram_00a58ad4 = '\x01';
		  }
		  uVar1 = Core_Extensions_Dict_SpellDicExt__GetTitle(param2,0);
		  piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_Spells_SpellData___TypeInfo,1);
		  iVar3 = Core_Data_Spells_SpellData__Create_object_
		                    (param2,param3,Method_Core_Data_Spells_SpellData_Create_SpellData___);
		  if ((iVar3 != 0) && (iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar2 + 0x20)), iVar4 == 0)) {
		    uVar1 = func_ii_1083();
		    func_ii_1050(uVar1,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar2[4] = iVar3;
		  uVar5 = unnamed_function_1417(Core_Data_Spells_SpellsBasedDescription_TypeInfo);
		  Core_Data_Spells_SpellData__SortSpells(uVar5,uVar1,piVar2,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  uVar6 = Core_Money_Money__op_Multiply(param4,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar6 ^ 1,0);
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x18),param6,param4,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < param5),0);
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		        puVar7 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x80f726a9;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		  }
		  puVar7 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f726a9:
		  uVar8 = (**(code **)((ulonglong)*puVar7 * 4))(piVar2,CONCAT44(in_register_20000014,puVar7[1]));
		  uVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar8,0);
		  uVar8 = System_Collections_Generic_Dictionary_int__object___get_Item(uVar8,5,0);
		  uVar8 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar8,0);
		  UI_Price_PriceItemRenderer__SetIcon(uVar1,uVar8,0);
		  param2_00 = (double)param5;
		  UI_Price_PriceItemRenderer__set_ValidIconEnabled(*(undefined4 *)(param1 + 0x1c),param2_00,0);
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  uVar5 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar5,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,CONCAT44(uVar1,uVar5),*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
