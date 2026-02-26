using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	public class CombatSpellToolTipView : AbstractCombatSpellToolTipView<CombatSpellData>
	{
		// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x5D4C", Offset = "0x5D4C", VA = "0x5D4C")]
		public CombatSpellToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_CombatSpellToolTipView___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  int *piVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59986 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_PetData__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_PetData__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28637);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4382);
		    DAT_ram_00a59986 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x18);
		  uVar1 = Gameplay_Combat_Model_PetData__set_Artifact(*(undefined4 *)(param1 + 0x14),0);
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  piVar2 = *(int **)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_4382,1,0,1,0,0,0,0);
		  local_4 = Core_Data_ArtifactData__get_StackLimit(*(undefined4 *)(*(int *)(param1 + 0x14) + 8),0);
		  param3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28637,uVar1,param3,0);
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  piVar2 = *(int **)(param1 + 0x20);
		  piVar3 = *(int **)(*(int *)(param1 + 0x14) + 8);
		  iVar4 = *piVar3;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                    (piVar3,*(undefined4 *)(iVar4 + 0xe4));
		  uVar1 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar1,0);
		  iVar4 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/CombatSpellToolTipViewV2";
	}
}
