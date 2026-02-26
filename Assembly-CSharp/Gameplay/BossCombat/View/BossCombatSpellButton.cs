using System;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using UI.ToolTip;

namespace Gameplay.BossCombat.View
{
	// Token: 0x02000B3A RID: 2874
	[Token(Token = "0x2000B3A")]
	public class BossCombatSpellButton : CombatSpellButton
	{
		// Token: 0x060045C7 RID: 17863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x9469", Offset = "0x9469", VA = "0x9469", Slot = "18")]
		public override BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_BossCombat_View_BossCombatSpellButton__GetData(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_Spells_CombatSpellButtonV2__LoadImage(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x946A", Offset = "0x946A", VA = "0x946A")]
		public BossCombatSpellButton()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BossCombat_View_BossCombatSpellButton___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  uint *puVar3;
		  int local_4;
		  
		  param1_01 = (int *)0x0;
		  if (DAT_ram_00a57984 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a57984 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,7,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  param2_00 = Gameplay_Combat_IManageCombat_TypeInfo;
		  if (iVar2 != 0) {
		    iVar2 = *(int *)(local_4 + 0xc);
		    if ((iVar2 != 0) &&
		       (param1_01 = (int *)func_ii_1082(iVar2,Gameplay_Combat_IManageCombat_TypeInfo),
		       param1_01 == (int *)0x0)) {
		      System_Activator__CreateInstance(iVar2,param2_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (param2_00 == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e0bd36;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,param2_00,0);
		code_r0x80e0bd36:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1,puVar3[1]);
		  }
		  return;
		}
		*/

		}
	}
}
