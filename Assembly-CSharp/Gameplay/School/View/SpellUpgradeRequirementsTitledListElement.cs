using System;
using Core.Data;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;
using UI.Requirements;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	public class SpellUpgradeRequirementsTitledListElement : BaseTitledListElement<SpellUpgradeRequirementsTitledListElementArgs>
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x7814", Offset = "0x7814", VA = "0x7814", Slot = "6")]
		protected override void OnInit(SpellUpgradeRequirementsTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_School_View_SpellUpgradeRequirementsTitledListElement__OnInit
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 param6;
		  undefined4 param5_00;
		  
		  if (DAT_ram_00a5a04c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a5a04c = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(param2[0xc] != 0),0);
		  if (param2[0xc] != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *param1_01;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x811b95b5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b95b5:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    iVar4 = Core_Extensions_Dict_DictExt__GetStringParameter
		                      (uVar2,*(undefined4 *)(param2[0xc] + 0x2c),0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0x114));
		    param1_00 = unnamed_function_1417
		                          (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo
		                          );
		    Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		              (param1_00,param3,param3,uVar2,0);
		    param6 = *(undefined4 *)(iVar4 + 0x14);
		    param5_00 = *(undefined4 *)(iVar4 + 0x18);
		    uVar2 = unnamed_function_1417
		                      (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		              (uVar2,param4,param3,param1_00,param5_00,param6,0);
		    UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x10),uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x7815", Offset = "0x7815", VA = "0x7815")]
		public void UpdateSpell(SchoolSpellData SpellData, UserData Player, UserData Owner)
		{
		/* --- GHIDRA: UpdateSpell ---
		void Gameplay_School_View_SpellUpgradeRequirementsTitledListElement__UpdateSpell
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a04d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_SpellUpgradeRequirementsTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a5a04d = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_SpellUpgradeRequirementsTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x7816", Offset = "0x7816", VA = "0x7816")]
		public SpellUpgradeRequirementsTitledListElement()
		{
		}

		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RequirementsView _requirements;
	}
}
