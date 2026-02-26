using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Elements.RightPanel;
using UI.Elements.RightPanel.TitledList;
using UI.Elements.RightPanel.TitledList.Elements;
using UI.Price;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1E RID: 3358
	[Token(Token = "0x2000D1E")]
	public class MonsterInfoView : MonoBehaviour
	{
		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005202 RID: 20994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001099")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x6005201")]
			[Address(RVA = "0x9FD8", Offset = "0x9FD8", VA = "0x9FD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005202")]
			[Address(RVA = "0x9FD9", Offset = "0x9FD9", VA = "0x9FD9")]
			set
			{
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06005203 RID: 20995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700109A")]
		public ButtonWithCost AttackButton
		{
			[Token(Token = "0x6005203")]
			[Address(RVA = "0x9FDA", Offset = "0x9FDA", VA = "0x9FDA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700109B")]
		public ButtonWithCost KickButton
		{
			[Token(Token = "0x6005204")]
			[Address(RVA = "0x9FDB", Offset = "0x9FDB", VA = "0x9FDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700109C")]
		public Price AttackPrice
		{
			[Token(Token = "0x6005205")]
			[Address(RVA = "0x9FDC", Offset = "0x9FDC", VA = "0x9FDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700109D")]
		public Price KickPrice
		{
			[Token(Token = "0x6005206")]
			[Address(RVA = "0x9FDD", Offset = "0x9FDD", VA = "0x9FDD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109E")]
		public string MonsterImageAssetId
		{
			[Token(Token = "0x6005207")]
			[Address(RVA = "0x9FDE", Offset = "0x9FDE", VA = "0x9FDE")]
			set
			{
			}
		}

		// Token: 0x1700109F RID: 4255
		// (set) Token: 0x06005208 RID: 21000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700109F")]
		public string MonsterTitle
		{
			[Token(Token = "0x6005208")]
			[Address(RVA = "0x9FDF", Offset = "0x9FDF", VA = "0x9FDF")]
			set
			{
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A0")]
		public string MonsterDescription
		{
			[Token(Token = "0x6005209")]
			[Address(RVA = "0x9FE0", Offset = "0x9FE0", VA = "0x9FE0")]
			set
			{
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (set) Token: 0x0600520A RID: 21002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A1")]
		public uint MonsterLevel
		{
			[Token(Token = "0x600520A")]
			[Address(RVA = "0x9FE1", Offset = "0x9FE1", VA = "0x9FE1")]
			set
			{
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (set) Token: 0x0600520B RID: 21003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010A2")]
		public string Difficulty
		{
			[Token(Token = "0x600520B")]
			[Address(RVA = "0x9FE2", Offset = "0x9FE2", VA = "0x9FE2")]
			set
			{
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A3")]
		public TitledList TitledList
		{
			[Token(Token = "0x600520C")]
			[Address(RVA = "0x9FE3", Offset = "0x9FE3", VA = "0x9FE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x0600520D RID: 21005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A4")]
		public MonsterDifficultyTitledListElement MonsterDifficultyElement
		{
			[Token(Token = "0x600520D")]
			[Address(RVA = "0x9FE4", Offset = "0x9FE4", VA = "0x9FE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010A5")]
		private RewardsTitledListElement RewardsElement
		{
			[Token(Token = "0x600520E")]
			[Address(RVA = "0x9FE5", Offset = "0x9FE5", VA = "0x9FE5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600520F")]
		[Address(RVA = "0x9FE6", Offset = "0x9FE6", VA = "0x9FE6")]
		public MonsterInfoView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Isles_User_View_MonsterInfoView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Isles_User_View_MonsterInfoView2__get_MonsterDifficultyElement(param1,param1);
		  uVar1 = System_Xml_XmlElement__get_ParentNode(uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002C96 RID: 11414
		[Token(Token = "0x4002C96")]
		public const string DIFFICULTY_STATIC_KEY = "MONSTER_DIFFICULTY_KEY/DIFFICULTY";

		// Token: 0x04002C97 RID: 11415
		[Token(Token = "0x4002C97")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleWithLevel _windowTitle;

		// Token: 0x04002C98 RID: 11416
		[Token(Token = "0x4002C98")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _monsterImage;

		// Token: 0x04002C99 RID: 11417
		[Token(Token = "0x4002C99")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonWithCost _attackButton;

		// Token: 0x04002C9A RID: 11418
		[Token(Token = "0x4002C9A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _kickButton;

		// Token: 0x04002C9B RID: 11419
		[Token(Token = "0x4002C9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x04002C9C RID: 11420
		[Token(Token = "0x4002C9C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _disableDifficultyLabel;

		// Token: 0x04002C9D RID: 11421
		[Token(Token = "0x4002C9D")]
		[FieldOffset(Offset = "0x28")]
		private MonsterDifficultyTitledListElement _monsterDifficultyElement;

		// Token: 0x04002C9E RID: 11422
		[Token(Token = "0x4002C9E")]
		[FieldOffset(Offset = "0x2C")]
		private RewardsTitledListElement _rewardsElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Rewards ---
		void Gameplay_Isles_User_View_MonsterInfoView__get_Rewards
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = Gameplay_Isles_User_View_MonsterInfoView__get_MonsterDifficultyElement(param1,param2);
		  UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__get_Rewards
		            (param1_00,param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_MonsterImageAssetId ---
		void Gameplay_Isles_User_View_MonsterInfoView__set_MonsterImageAssetId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_MonsterTitle ---
		void Gameplay_Isles_User_View_MonsterInfoView__set_MonsterTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a58d65 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    DAT_ram_00a58d65 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  if (*(char *)(param1_00 + 0x2c) == '\0') {
		    param2_00 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    UI_Elements_RightPanel_TitledList_TitledList__set_Title(param1_00,param2_00,0);
		    param1_00 = *(int *)(param1 + 0x20);
		  }
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(param1_00,param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_MonsterDescription ---
		void Gameplay_Isles_User_View_MonsterInfoView__set_MonsterDescription
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_RightPanel_TitleWithLevel__set_Title(*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_MonsterLevel ---
		void Gameplay_Isles_User_View_MonsterInfoView__set_MonsterLevel
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58d64 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10784);
		    DAT_ram_00a58d64 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    param1_00 = Gameplay_Isles_User_View_MonsterInfoView__get_TitledList(param1,param1);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_10784,1,0,1,0,0,0,0);
		    param3_00 = func_ii_7508(param2,1,0,1,0,0,0,0);
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar1,StringLiteral_118,param3_00,0);
		    Core_Extensions_Dict_MonsterDictExt__GetTitle(param1_00,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Difficulty ---
		int Gameplay_Isles_User_View_MonsterInfoView__set_Difficulty(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a58d65 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    DAT_ram_00a58d65 = '\x01';
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


		/* --- GHIDRA: get_TitledList ---
		undefined4 Gameplay_Isles_User_View_MonsterInfoView__get_TitledList(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a58d66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58d66 = '\x01';
		  }
		  if (*(char *)(param1 + 0x24) == '\0') {
		    uVar2 = *(undefined4 *)(param1 + 0x28);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		    if (iVar1 == 0) {
		      if (DAT_ram_00a58d65 == '\0') {
		        Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		        DAT_ram_00a58d65 = '\x01';
		      }
		      iVar1 = *(int *)(param1 + 0x20);
		      if (*(char *)(iVar1 + 0x2c) == '\0') {
		        uVar2 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		        UI_Elements_RightPanel_TitledList_TitledList__set_Title(iVar1,uVar2,0);
		        iVar1 = *(int *)(param1 + 0x20);
		      }
		      uVar2 = unnamed_function_1417
		                        (
		                        UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElementArgs_TypeInfo
		                        );
		      param1_00 = (int *)UI_Elements_RightPanel_TitledList_TitledList__Init(iVar1,uVar2,0);
		      iVar1 = UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo
		      ;
		      if (param1_00 == (int *)0x0) {
		        *(undefined4 *)(param1 + 0x28) = 0;
		        return *(undefined4 *)(param1 + 0x28);
		      }
		      uVar3 = (uint)*(byte *)(
		                             UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo
		                             + 0xb8);
		      if ((uVar3 <= *(byte *)(*param1_00 + 0xb8)) &&
		         (*(int *)(*(int *)(*param1_00 + 100) + (uVar3 - 1) * 4) ==
		          UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo)) {
		        *(int **)(param1 + 0x28) = param1_00;
		        if ((uVar3 <= *(byte *)(*param1_00 + 0xb8)) &&
		           (*(int *)(*(int *)(*param1_00 + 100) + (uVar3 - 1) * 4) == iVar1)) goto code_r0x80fa3363;
		      }
		      System_Activator__CreateInstance(param1_00,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		code_r0x80fa3363:
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/


		/* --- GHIDRA: get_MonsterDifficultyElement ---
		int * Gameplay_Isles_User_View_MonsterInfoView__get_MonsterDifficultyElement
		                (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a58d67 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo);
		    DAT_ram_00a58d67 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a58d65 == '\0') {
		      Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		      DAT_ram_00a58d65 = '\x01';
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
