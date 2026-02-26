using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.RightPanel.TitledList;
using UI.Elements.RightPanel.TitledList.Elements;
using UI.Price;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1F RID: 3359
	[Token(Token = "0x2000D1F")]
	public class MonsterInfoView2 : MonoBehaviour
	{
		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A6")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6005210")]
			[Address(RVA = "0x9FE7", Offset = "0x9FE7", VA = "0x9FE7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005211")]
			[Address(RVA = "0x9FE8", Offset = "0x9FE8", VA = "0x9FE8")]
			set
			{
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A7")]
		public ButtonWithCost AttackButton
		{
			[Token(Token = "0x6005212")]
			[Address(RVA = "0x9FE9", Offset = "0x9FE9", VA = "0x9FE9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A8")]
		public ButtonWithCost KickButton
		{
			[Token(Token = "0x6005213")]
			[Address(RVA = "0x9FEA", Offset = "0x9FEA", VA = "0x9FEA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A9")]
		public Price AttackPrice
		{
			[Token(Token = "0x6005214")]
			[Address(RVA = "0x9FEB", Offset = "0x9FEB", VA = "0x9FEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AA")]
		public Price KickPrice
		{
			[Token(Token = "0x6005215")]
			[Address(RVA = "0x9FEC", Offset = "0x9FEC", VA = "0x9FEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AB")]
		public string MonsterImageAssetId
		{
			[Token(Token = "0x6005216")]
			[Address(RVA = "0x9FED", Offset = "0x9FED", VA = "0x9FED")]
			set
			{
			}
		}

		// Token: 0x170010AC RID: 4268
		// (set) Token: 0x06005217 RID: 21015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AC")]
		public string MonsterTitle
		{
			[Token(Token = "0x6005217")]
			[Address(RVA = "0x9FEE", Offset = "0x9FEE", VA = "0x9FEE")]
			set
			{
			}
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005218")]
		[Address(RVA = "0x9FEF", Offset = "0x9FEF", VA = "0x9FEF")]
		public void SetDifficultyAndLevel(uint level, string difficulty)
		{
		/* --- GHIDRA: SetDifficultyAndLevel ---
		int Gameplay_Isles_User_View_MonsterInfoView2__SetDifficultyAndLevel(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a58d69 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    DAT_ram_00a58d69 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  if (*(char *)(param1_00 + 0x2c) == '\0') {
		    param2_00 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    UI_Elements_RightPanel_TitledList_TitledList__set_Title(param1_00,param2_00,0);
		    param1_00 = *(int *)(param1 + 0x20);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AD")]
		public TitledList TitledList
		{
			[Token(Token = "0x6005219")]
			[Address(RVA = "0x9FF0", Offset = "0x9FF0", VA = "0x9FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AE")]
		public MonsterDifficultyAndLevelTitledListElement MonsterDifficultyElement
		{
			[Token(Token = "0x600521A")]
			[Address(RVA = "0x9FF1", Offset = "0x9FF1", VA = "0x9FF1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010AF")]
		private RewardsTitledListElement RewardsElement
		{
			[Token(Token = "0x600521B")]
			[Address(RVA = "0x9FF2", Offset = "0x9FF2", VA = "0x9FF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600521C")]
		[Address(RVA = "0x9FF3", Offset = "0x9FF3", VA = "0x9FF3")]
		public MonsterInfoView2()
		{
		}

		// Token: 0x04002C9F RID: 11423
		[Token(Token = "0x4002C9F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002CA0 RID: 11424
		[Token(Token = "0x4002CA0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _monsterImage;

		// Token: 0x04002CA1 RID: 11425
		[Token(Token = "0x4002CA1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonWithCost _attackButton;

		// Token: 0x04002CA2 RID: 11426
		[Token(Token = "0x4002CA2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _kickButton;

		// Token: 0x04002CA3 RID: 11427
		[Token(Token = "0x4002CA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x04002CA4 RID: 11428
		[Token(Token = "0x4002CA4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _disableDifficultyLabel;

		// Token: 0x04002CA5 RID: 11429
		[Token(Token = "0x4002CA5")]
		[FieldOffset(Offset = "0x28")]
		private MonsterDifficultyAndLevelTitledListElement _monsterDifficultyElement;

		// Token: 0x04002CA6 RID: 11430
		[Token(Token = "0x4002CA6")]
		[FieldOffset(Offset = "0x2C")]
		private RewardsTitledListElement _rewardsElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Rewards ---
		void Gameplay_Isles_User_View_MonsterInfoView2__get_Rewards
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = Gameplay_Isles_User_View_MonsterInfoView2__get_MonsterDifficultyElement(param1,param2)
		  ;
		  UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__get_Rewards
		            (param1_00,param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_KickButton ---
		undefined4 Gameplay_Isles_User_View_MonsterInfoView2__get_KickButton(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb8);
		}
		*/


		/* --- GHIDRA: get_AttackPrice ---
		undefined4 Gameplay_Isles_User_View_MonsterInfoView2__get_AttackPrice(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb8);
		}
		*/


		/* --- GHIDRA: get_KickPrice ---
		void Gameplay_Isles_User_View_MonsterInfoView2__get_KickPrice
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_MonsterTitle ---
		void Gameplay_Isles_User_View_MonsterInfoView2__set_MonsterTitle
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 param4_00;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d68 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2621);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28691);
		    DAT_ram_00a58d68 = '\x01';
		  }
		  param1_00 = Gameplay_Isles_User_View_MonsterInfoView2__get_TitledList(param1,auStack_10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2621,1,0,1,0,0,0,0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  param4_00 = Core_Extensions_Dict_CultDicExt__GetTitle(param3,1,0,1,0,0,0,0);
		  uVar1 = func_ii_8529(StringLiteral_28691,uVar1,param3_00,param4_00,0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(param1_00,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_TitledList ---
		int * Gameplay_Isles_User_View_MonsterInfoView2__get_TitledList(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a58d6a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyAndLevelTitledListElement_MonsterDifficultyAndLevelTitledListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyAndLevelTitledListElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58d6a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 != 0) {
		    if (DAT_ram_00a58d69 == '\0') {
		      Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		      DAT_ram_00a58d69 = '\x01';
		    }
		    iVar1 = *(int *)(param1 + 0x20);
		    if (*(char *)(iVar1 + 0x2c) == '\0') {
		      uVar2 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		      UI_Elements_RightPanel_TitledList_TitledList__set_Title(iVar1,uVar2,0);
		      iVar1 = *(int *)(param1 + 0x20);
		    }
		    uVar2 = unnamed_function_1417
		                      (
		                      UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyAndLevelTitledListElement_MonsterDifficultyAndLevelTitledListElementArgs_TypeInfo
		                      );
		    param1_00 = (int *)UI_Elements_RightPanel_TitledList_TitledList__Init(iVar1,uVar2,0);
		    iVar1 = 
		    UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyAndLevelTitledListElement_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      *(undefined4 *)(param1 + 0x28) = 0;
		      return (int *)0;
		    }
		    uVar3 = (uint)*(byte *)(
		                           UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyAndLevelTitledListElement_TypeInfo
		                           + 0xb8);
		    if ((uVar3 <= *(byte *)(*param1_00 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1_00 + 100) + (uVar3 - 1) * 4) ==
		        UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyAndLevelTitledListElement_TypeInfo
		       )) {
		      *(int **)(param1 + 0x28) = param1_00;
		      if ((uVar3 <= *(byte *)(*param1_00 + 0xb8)) &&
		         (*(int *)(*(int *)(*param1_00 + 100) + (uVar3 - 1) * 4) == iVar1)) {
		        return param1_00;
		      }
		    }
		    System_Activator__CreateInstance(param1_00,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return (int *)*(undefined4 *)(param1 + 0x28);
		}
		*/


		/* --- GHIDRA: get_MonsterDifficultyElement ---
		int * Gameplay_Isles_User_View_MonsterInfoView2__get_MonsterDifficultyElement
		                (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a58d6b == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo);
		    DAT_ram_00a58d6b = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a58d69 == '\0') {
		      Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		      DAT_ram_00a58d69 = '\x01';
		    }
		    iVar1 = *(int *)(param1 + 0x20);
		    if (*(char *)(iVar1 + 0x2c) == '\0') {
		      uVar2 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		      UI_Elements_RightPanel_TitledList_TitledList__set_Title(iVar1,uVar2,0);
		      iVar1 = *(int *)(param1 + 0x20);
		    }
		    uVar2 = unnamed_function_1417
		                      (
		                      UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElementArgs_TypeInfo
		                      );
		    param1_00 = (int *)UI_Elements_RightPanel_TitledList_TitledList__Init(iVar1,uVar2,0);
		    iVar1 = UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      *(undefined4 *)(param1 + 0x2c) = 0;
		      return (int *)0;
		    }
		    uVar3 = (uint)*(byte *)(
		                           UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo
		                           + 0xb8);
		    if ((uVar3 <= *(byte *)(*param1_00 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1_00 + 100) + (uVar3 - 1) * 4) ==
		        UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo)) {
		      *(int **)(param1 + 0x2c) = param1_00;
		      if ((uVar3 <= *(byte *)(*param1_00 + 0xb8)) &&
		         (*(int *)(*(int *)(*param1_00 + 100) + (uVar3 - 1) * 4) == iVar1)) {
		        return param1_00;
		      }
		    }
		    System_Activator__CreateInstance(param1_00,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return (int *)*(undefined4 *)(param1 + 0x2c);
		}
		*/

}
