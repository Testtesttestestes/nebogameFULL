using System;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using Protocol.Combat;
using UI.Price;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.VortexCombat.View.Spells
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public class VortexCombatSpellButton : CombatSpellButton
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x67A6", Offset = "0x67A6", VA = "0x67A6", Slot = "18")]
		public override BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_VortexCombat_View_Spells_VortexCombatSpellButton__GetData
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5821a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__ValidateManaPrice__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    DAT_ram_00a5821a = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___UpdateUserBalanceChanged
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__ValidateManaPrice__
		            );
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x60),0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x60);
		    lVar2 = Gameplay_Combat_Model_CombatPlayer__get_TotalExtraHealth
		                      (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x34),0);
		    lVar3 = Core_Data_Spells_SpellData__get_ManaPriceOfUse(*(undefined4 *)(param1 + 0x4c),0);
		    iVar1 = 0x28;
		    if (lVar3 <= lVar2) {
		      iVar1 = 0x24;
		    }
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x60) + iVar1);
		    UI_Price_PriceItemRenderer__set_ResId(param1_00,&local_4,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x67A7", Offset = "0x67A7", VA = "0x67A7", Slot = "12")]
		protected override void ValidateManaPrice()
		{
		/* --- GHIDRA: ValidateManaPrice ---
		void Gameplay_VortexCombat_View_Spells_VortexCombatSpellButton__ValidateManaPrice
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  undefined8 uVar4;
		  int *param1_01;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a5821b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__DisplayPrice__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10697);
		    DAT_ram_00a5821b = '\x01';
		  }
		  lVar3 = Core_Data_Spells_SpellData__get_ManaPriceOfUse(param1[0x13],0);
		  if (0 < lVar3) {
		    uVar4 = Core_Data_Spells_SpellData__get_ManaPriceOfUse(param1[0x13],0);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                          (param1,uVar4,*(undefined4 *)(*param1 + 0x11c));
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    param1[0x18] = param1_00;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x80ebb05c;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ebb05c:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,CONCAT44(uVar2,puVar1[1]));
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    uVar2 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar2,StringLiteral_10697,0);
		    UI_Price_PriceItemRenderer__SetIcon(param1_00,uVar2,0);
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___CreateManaPrice
		            (param1,
		             Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__DisplayPrice__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x67A8", Offset = "0x67A8", VA = "0x67A8", Slot = "9")]
		protected override void DisplayPrice()
		{
		/* --- GHIDRA: DisplayPrice ---
		undefined4
		Gameplay_VortexCombat_View_Spells_VortexCombatSpellButton__DisplayPrice
		          (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined8 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5821c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Spells_AbstractCombatSpellButton_CombatSpellData__get_Data__
		              );
		    DAT_ram_00a5821c = '\x01';
		  }
		  uVar1 = Core_Data_Spells_SpellData__get_Level(param1[0x13],0);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		                        (param1,uVar1,*(undefined4 *)(*param1 + 0x11c));
		  iVar2 = param1[0x17];
		  iVar3 = *(int *)(iVar2 + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar4 = *(int *)(iVar2 + iVar5 * 4 + 0x10);
		      if (*(int *)(iVar4 + 8) == *(int *)(*(int *)(*(int *)(param1[0x13] + 0x34) + 8) + 0x30)) {
		        UI_Price_PriceItemRenderer__HandleValidIconEnabledChanged
		                  (param1_00,*(undefined4 *)(iVar4 + 0xc),0);
		        iVar3 = *(int *)(iVar2 + 0xc);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < iVar3);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x67A9", Offset = "0x67A9", VA = "0x67A9", Slot = "10")]
		protected override PriceItemRenderer CreateManaPrice()
		{
			return null;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x67AA", Offset = "0x67AA", VA = "0x67AA")]
		public VortexCombatSpellButton()
		{
		}

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private VortexCombatSpellButton.Config[] _configs;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x60")]
		private PriceItemRenderer _manaBoostPriceRender;

		// Token: 0x020003AB RID: 939
		[Token(Token = "0x20003AB")]
		[Serializable]
		public class Config
		{
			// Token: 0x1700039D RID: 925
			// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000052E0 File Offset: 0x000034E0
			[Token(Token = "0x1700039D")]
			public StonesTypes Stone
			{
				[Token(Token = "0x60015E9")]
				[Address(RVA = "0x67AB", Offset = "0x67AB", VA = "0x67AB")]
				get
				{
					return StonesTypes.Empty;
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x060015EA RID: 5610 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700039E")]
			public Sprite Icon
			{
				[Token(Token = "0x60015EA")]
				[Address(RVA = "0x67AC", Offset = "0x67AC", VA = "0x67AC")]
				get
				{
					return null;
				}
			}

			// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015EB")]
			[Address(RVA = "0x67AD", Offset = "0x67AD", VA = "0x67AD")]
			public Config()
			{
			}

			// Token: 0x04000B9D RID: 2973
			[Token(Token = "0x4000B9D")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private StonesTypes _stone;

			// Token: 0x04000B9E RID: 2974
			[Token(Token = "0x4000B9E")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Sprite _icon;
		}
	}
}
