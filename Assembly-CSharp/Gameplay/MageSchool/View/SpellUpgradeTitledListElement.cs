using System;
using System.Collections.Generic;
using Core.Data.Balance;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.ProgressBars;
using UI.Elements.RightPanel.TitledList;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.MageSchool.View
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	public class SpellUpgradeTitledListElement : BaseTitledListElement<SpellUpgradeTitledListElementArgs>, IDiscountTarget
	{
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000741")]
		public Button StartLearnFirstButton
		{
			[Token(Token = "0x60026C9")]
			[Address(RVA = "0x77FE", Offset = "0x77FE", VA = "0x77FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000742")]
		public Button StartLearnButton
		{
			[Token(Token = "0x60026CA")]
			[Address(RVA = "0x77FF", Offset = "0x77FF", VA = "0x77FF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000743")]
		public ButtonWithCost BoostButton
		{
			[Token(Token = "0x60026CB")]
			[Address(RVA = "0x7800", Offset = "0x7800", VA = "0x7800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000744")]
		public Button CancelButton
		{
			[Token(Token = "0x60026CC")]
			[Address(RVA = "0x7801", Offset = "0x7801", VA = "0x7801")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x7802", Offset = "0x7802", VA = "0x7802", Slot = "6")]
		protected override void OnInit(SpellUpgradeTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_MageSchool_View_SpellUpgradeTitledListElement__OnInit(int param1,undefined4 param2)
		
		{
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x28) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x30) + 0xb4),0);
		  return;
		}
		*/

		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CE")]
		[Address(RVA = "0x7803", Offset = "0x7803", VA = "0x7803")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_MageSchool_View_SpellUpgradeTitledListElement__OnDestroy
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 in_register_20000024;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  float fVar10;
		  undefined4 uVar11;
		  int iVar12;
		  int *piVar13;
		  int *piVar14;
		  int iVar15;
		  uint uVar16;
		  undefined8 uVar17;
		  double dVar18;
		  uint uVar19;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a043 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Spells_SpellData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_SpellData___);
		    Mono_Security_ASN1__get_Item(&Core_Data_Spells_SpellsBasedDescription_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13730);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13731);
		    DAT_ram_00a5a043 = '\x01';
		  }
		  iVar12 = param2[0xc];
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar12 != 0),0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar12 == 0),0);
		  if (iVar12 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar13 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar12 = *piVar13;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar9 * 8 + 4) * 8 + iVar12 + 0x178);
		          goto code_r0x811b8758;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar13,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b8758:
		    uVar17 = CONCAT44(in_register_20000004,piVar13);
		    uVar1 = CONCAT44(in_register_20000014,puVar4[1]);
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(uVar17,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar17 >> 0x20);
		    uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		    uVar5 = Core_Extensions_Dict_DictExt__GetItemQuality(uVar5,*(undefined4 *)(param2[0xc] + 0xc),0)
		    ;
		    piVar13 = *(int **)(param1 + 0x10);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13731,1,0,1,0,0,0,0);
		    uVar7 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar7,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    local_4 = *(undefined4 *)(param2[0xc] + 0x10);
		    uVar8 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar7,StringLiteral_28217,uVar8,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar6 = Core_GameLocalization__GetTranslation(uVar6,uVar7,0);
		    iVar12 = *piVar13;
		    uVar17 = CONCAT44(uVar3,piVar13);
		    uVar1 = CONCAT44(uVar11,uVar6);
		    uVar2 = CONCAT44(in_register_20000024,*(undefined4 *)(iVar12 + 0x2d4));
		    (**(code **)((ulonglong)*(uint *)(iVar12 + 0x2d0) * 4))(uVar17,uVar1,uVar2);
		    uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    piVar13 = *(int **)(param1 + 0x14);
		    uVar17 = CONCAT44((int)((ulonglong)uVar17 >> 0x20),param2);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param2 + 0x10c));
		    uVar7 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x108) * 4))(uVar17,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar17 >> 0x20);
		    uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar7 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar7,0);
		    iVar12 = *piVar13;
		    uVar17 = CONCAT44(uVar3,piVar13);
		    uVar1 = CONCAT44(uVar11,uVar7);
		    uVar2 = CONCAT44(uVar6,*(undefined4 *)(iVar12 + 0x2d4));
		    (**(code **)((ulonglong)*(uint *)(iVar12 + 0x2d0) * 4))(uVar17,uVar1,uVar2);
		    uVar6 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    piVar14 = *(int **)(param1 + 0x14);
		    uVar3 = (undefined4)((ulonglong)uVar17 >> 0x20);
		    uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar7 = Core_Extensions_Dict_SpellDicExt__GetTitle(uVar5,0);
		    piVar13 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_Spells_SpellData___TypeInfo,1);
		    iVar12 = Core_Data_Spells_SpellData__Create_object_
		                       (uVar5,param2[0xc],Method_Core_Data_Spells_SpellData_Create_SpellData___);
		    if ((iVar12 != 0) &&
		       (iVar15 = func_ii_1082(iVar12,*(undefined4 *)(*piVar13 + 0x20)), iVar15 == 0)) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar13[4] = iVar12;
		    uVar5 = unnamed_function_1417(Core_Data_Spells_SpellsBasedDescription_TypeInfo);
		    Core_Data_Spells_SpellData__SortSpells(uVar5,uVar7,piVar13,0,0);
		    uVar5 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar5,0);
		    iVar12 = *piVar14;
		    uVar17 = CONCAT44(uVar3,piVar14);
		    uVar1 = CONCAT44(uVar11,uVar5);
		    uVar2 = CONCAT44(uVar6,*(undefined4 *)(iVar12 + 0x2d4));
		    (**(code **)((ulonglong)*(uint *)(iVar12 + 0x2d0) * 4))(uVar17,uVar1,uVar2);
		    uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar17 >> 0x20);
		    iVar12 = param2[0x10];
		    if (iVar12 == 0) {
		      iVar12 = Utils_MoneyUtils__ExtractSpellCostMoney(param2[7],0);
		    }
		    param2[0x10] = iVar12;
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar6 = Core_Money_Money__op_Explicit(iVar12,0);
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    uVar9 = Core_Money_Money__op_Multiply(uVar6,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,uVar9 ^ 1,0);
		    uVar8 = *(undefined4 *)(param1 + 0x18);
		    uVar17 = CONCAT44(uVar3,param2);
		    uVar1 = CONCAT44(uVar11,*(undefined4 *)(*param2 + 0xe4));
		    uVar7 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))(uVar17,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar17 >> 0x20);
		    uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    UI_Price_Price__SetColor(uVar8,uVar7,uVar6,0);
		    uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    if (DAT_ram_00a5a055 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		      DAT_ram_00a5a055 = '\x01';
		    }
		    iVar12 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (param2[7],0,
		                        Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar6,(uint)(0 < *(longlong *)(iVar12 + 0x10)),0);
		    uVar6 = *(undefined4 *)(param1 + 0x1c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar9 = 0;
		    piVar13 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar12 = *piVar13;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar9 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar9 * 8 + 4) * 8 + iVar12 + 0x178);
		          goto code_r0x811b8a4b;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar9);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar13,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b8a4b:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))
		                      (CONCAT44(uVar3,piVar13),CONCAT44(uVar11,puVar4[1]));
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = System_Collections_Generic_Dictionary_int__object___get_Item(uVar3,5,0);
		    uVar3 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(uVar3,0);
		    UI_Price_PriceItemRenderer__SetIcon(uVar6,uVar3,0);
		    uVar3 = *(undefined4 *)(param1 + 0x1c);
		    if (DAT_ram_00a5a055 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		      DAT_ram_00a5a055 = '\x01';
		    }
		    iVar12 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                       (param2[7],0,
		                        Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    dVar18 = (double)*(longlong *)(iVar12 + 0x10);
		    UI_Price_PriceItemRenderer__set_ValidIconEnabled(uVar3,dVar18,0);
		    uVar3 = (undefined4)((ulonglong)dVar18 >> 0x20);
		    fVar10 = func_ii_7103(param2[0xe],0);
		    fVar10 = CEIL(fVar10);
		    if (fVar10 < 4.2949673e+09 && 0.0 <= fVar10) {
		      iVar12 = (int)fVar10;
		    }
		    else {
		      iVar12 = 0;
		    }
		    if (ABS(fVar10) < 2.1474836e+09) {
		      iVar15 = (int)fVar10;
		    }
		    else {
		      iVar15 = -0x80000000;
		    }
		    uVar11 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                       (*(undefined4 *)(param1 + 0x20),0);
		    uVar11 = UnityEngine_Transform__set_parent(uVar11,0);
		    uVar11 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                       (uVar11,0);
		    if (0.0 <= fVar10) {
		      iVar15 = iVar12;
		    }
		    uVar9 = (uint)(iVar15 != 0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar11,uVar9,0);
		    if (iVar15 == 0) {
		      piVar13 = *(int **)(param1 + 0x34);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar11 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13730,1,0,1,0,0,0,0);
		      uVar17 = *(undefined8 *)(param2[0xc] + 0x20);
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      fVar10 = Utils_StringUtils___cctor(uVar17,0);
		      dVar18 = (double)fVar10;
		      uVar7 = Utils_TimeUtils__DateFormat(dVar18,0);
		      uVar6 = (undefined4)((ulonglong)dVar18 >> 0x20);
		      uVar11 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                         (uVar11,StringLiteral_118,uVar7,0);
		      iVar12 = *piVar13;
		      (**(code **)((ulonglong)*(uint *)(iVar12 + 0x2d0) * 4))
		                (CONCAT44(uVar6,piVar13),CONCAT44(uVar3,uVar11),
		                 CONCAT44(uVar5,*(undefined4 *)(iVar12 + 0x2d4)));
		    }
		    else {
		      uVar3 = *(undefined4 *)(param1 + 0x20);
		      uVar17 = *(undefined8 *)(param2[0xc] + 0x20);
		      fVar10 = func_ii_7103(param2[0xe],0);
		      fVar10 = CEIL(fVar10);
		      if (fVar10 < 4.2949673e+09 && 0.0 <= fVar10) {
		        uVar16 = (uint)fVar10;
		      }
		      else {
		        uVar16 = 0;
		      }
		      if (ABS(fVar10) < 2.1474836e+09) {
		        uVar19 = (uint)fVar10;
		      }
		      else {
		        uVar19 = 0x80000000;
		      }
		      if (0.0 <= fVar10) {
		        uVar19 = uVar16;
		      }
		      UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete(uVar3,uVar17,(ulonglong)uVar19,0)
		      ;
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(iVar15 == 0),0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x24),0);
		    if (iVar15 == 0) {
		      iVar12 = param2[4];
		    }
		    else {
		      iVar12 = 1;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(iVar12 == 0),0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    if (iVar15 == 0) {
		      uVar16 = (uint)(param2[4] != 0);
		    }
		    else {
		      uVar16 = 0;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar16,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar9,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar9,0);
		    Gameplay_MageSchool_View_SpellUpgradeTitledListElement__UpdateSpell(param1,param2,param3,iVar15)
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026CF")]
		[Address(RVA = "0x7804", Offset = "0x7804", VA = "0x7804")]
		public void UpdateSpell(SchoolSpellData spellData, IBalanceSource balance)
		{
		/* --- GHIDRA: UpdateSpell ---
		void Gameplay_MageSchool_View_SpellUpgradeTitledListElement__UpdateSpell
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  float fVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  double dVar4;
		  int iVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a5a044 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a5a044 = '\x01';
		  }
		  fVar1 = func_ii_7103(*(undefined4 *)(param2 + 0x38),0);
		  fVar1 = CEIL(fVar1);
		  if (fVar1 < 4.2949673e+09 && 0.0 <= fVar1) {
		    iVar5 = (int)fVar1;
		  }
		  else {
		    iVar5 = 0;
		  }
		  if (ABS(fVar1) < 2.1474836e+09) {
		    iVar6 = (int)fVar1;
		  }
		  else {
		    iVar6 = 0;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x811b8e14;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b8e14:
		  if (0.0 <= fVar1) {
		    iVar6 = iVar5;
		  }
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))
		                    (CONCAT44(in_register_20000004,param1_00),
		                     CONCAT44(in_register_20000014,puVar2[1]));
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  dVar4 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar3,StringLiteral_25458,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		  dVar4 = func_ii_6931((double)(uint)(iVar6 * 1000),dVar4,0);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar8 = Core_Data_ArtifactData__get_SellPrice(uVar8,CEIL(dVar4),0);
		  UI_Price_Price__SetColor(uVar3,param3,uVar8,0);
		  return;
		}
		*/

		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0x7805", Offset = "0x7805", VA = "0x7805")]
		private void UpdateBoostPrice(SchoolSpellData schoolSpellData, IBalanceSource balance)
		{
		/* --- GHIDRA: UpdateBoostPrice ---
		int Gameplay_MageSchool_View_SpellUpgradeTitledListElement__UpdateBoostPrice
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a045 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_DiscountTargets___TypeInfo);
		    DAT_ram_00a5a045 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_DiscountTargets___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = 5;
		  return iVar1;
		}
		*/

		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000745")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x60026D1")]
			[Address(RVA = "0x7806", Offset = "0x7806", VA = "0x7806", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0x7807", Offset = "0x7807", VA = "0x7807", Slot = "8")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: Setup ---
		void Gameplay_MageSchool_View_SpellUpgradeTitledListElement__Setup
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a047 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_SpellUpgradeTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a5a047 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_SpellUpgradeTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0x7808", Offset = "0x7808", VA = "0x7808")]
		public SpellUpgradeTitledListElement()
		{
		}

		// Token: 0x0400152B RID: 5419
		[Token(Token = "0x400152B")]
		private const string SPELL_UPGRADE_TO_LEVEL = "SCHOOL/SPELL/UPGRADE_TO_LEVEL";

		// Token: 0x0400152C RID: 5420
		[Token(Token = "0x400152C")]
		private const string SPELL_UPGRADE_TIME = "SCHOOL/SPELL/UPGRADE_TIME";

		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		private const string LEVEL_TAG = "value";

		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001530 RID: 5424
		[Token(Token = "0x4001530")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;

		// Token: 0x04001532 RID: 5426
		[Token(Token = "0x4001532")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressBarWithTimer _progressBar;

		// Token: 0x04001533 RID: 5427
		[Token(Token = "0x4001533")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _startLearnFirstButton;

		// Token: 0x04001534 RID: 5428
		[Token(Token = "0x4001534")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _startLearnButton;

		// Token: 0x04001535 RID: 5429
		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ButtonWithCost _boostButton;

		// Token: 0x04001536 RID: 5430
		[Token(Token = "0x4001536")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x04001537 RID: 5431
		[Token(Token = "0x4001537")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _durationUpgrade;

		// Token: 0x04001538 RID: 5432
		[Token(Token = "0x4001538")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _normalView;

		// Token: 0x04001539 RID: 5433
		[Token(Token = "0x4001539")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private RectTransform _maxLevelView;

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DiscountGroup _discountGroup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CancelButton ---
		void Gameplay_MageSchool_View_SpellUpgradeTitledListElement__get_CancelButton
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int *param2_00;
		  
		  param2_00 = *(int **)(param2 + 8);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2_00 + 0xe0) * 4))
		                        (param2_00,*(undefined4 *)(*param2_00 + 0xe4));
		  Gameplay_MageSchool_View_SpellUpgradeTitledListElement__OnDestroy
		            (param1,param2_00,param3_00,param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: get_DiscountTargets ---
		void Gameplay_MageSchool_View_SpellUpgradeTitledListElement__get_DiscountTargets
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a046 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    DAT_ram_00a5a046 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		  param2_00 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

}
