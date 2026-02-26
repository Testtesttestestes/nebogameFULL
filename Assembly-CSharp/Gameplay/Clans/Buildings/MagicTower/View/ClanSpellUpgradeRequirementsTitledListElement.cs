using System;
using Core.Data;
using Gameplay.Clans.Model;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;
using UI.Requirements;
using UnityEngine;

namespace Gameplay.Clans.Buildings.MagicTower.View
{
	// Token: 0x02000AB1 RID: 2737
	[Token(Token = "0x2000AB1")]
	public class ClanSpellUpgradeRequirementsTitledListElement : BaseTitledListElement<ClanSpellUpgradeRequirementsTitledListElement.ClanSpellUpgradeRequirementsTitledListElementArgs>
	{
		// Token: 0x0600420E RID: 16910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x90C2", Offset = "0x90C2", VA = "0x90C2", Slot = "6")]
		protected override void OnInit(ClanSpellUpgradeRequirementsTitledListElement.ClanSpellUpgradeRequirementsTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellUpgradeRequirementsTitledListElement__OnInit
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a577fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a577fb = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2[0xc] != 0),0);
		  if (param2[0xc] != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0x114));
		    param1_00 = unnamed_function_1417
		                          (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo
		                          );
		    Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		              (param1_00,param4,param3,uVar1,0);
		    UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x10),param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600420F RID: 16911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x90C3", Offset = "0x90C3", VA = "0x90C3")]
		public void UpdateSpell(SchoolSpellData spellData, UserData player, TreasuryData treasury)
		{
		/* --- GHIDRA: UpdateSpell ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellUpgradeRequirementsTitledListElement__UpdateSpell
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a577fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_ClanSpellUpgradeRequirementsTitledListElement_ClanSpellUpgradeRequirementsTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a577fc = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_ClanSpellUpgradeRequirementsTitledListElement_ClanSpellUpgradeRequirementsTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004210 RID: 16912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004210")]
		[Address(RVA = "0x90C4", Offset = "0x90C4", VA = "0x90C4")]
		public ClanSpellUpgradeRequirementsTitledListElement()
		{
		}

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x02000AB2 RID: 2738
		[Token(Token = "0x2000AB2")]
		public class ClanSpellUpgradeRequirementsTitledListElementArgs : BaseTitledListElementArgs
		{
			// Token: 0x06004211 RID: 16913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004211")]
			[Address(RVA = "0x90C5", Offset = "0x90C5", VA = "0x90C5")]
			public ClanSpellUpgradeRequirementsTitledListElementArgs(SchoolSpellData spellData, UserData player, TreasuryData treasury)
			{
			}

			// Token: 0x04002475 RID: 9333
			[Token(Token = "0x4002475")]
			[FieldOffset(Offset = "0x8")]
			public SchoolSpellData SpellData;

			// Token: 0x04002476 RID: 9334
			[Token(Token = "0x4002476")]
			[FieldOffset(Offset = "0xC")]
			public UserData Player;

			// Token: 0x04002477 RID: 9335
			[Token(Token = "0x4002477")]
			[FieldOffset(Offset = "0x10")]
			public TreasuryData Treasury;
		}
	}
}
