using System;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.View
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	public class BossCombatView : OneOnOneCombatView
	{
		// Token: 0x060045C9 RID: 17865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x946B", Offset = "0x946B", VA = "0x946B", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_BossCombat_View_BossCombatView__Start
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57985 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a57985 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x28);
		  param2_00 = *(undefined4 *)(param3 + 8);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		  IronSourceError__getCode(param1_00,param2_00,param2,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0xec));
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x946C", Offset = "0x946C", VA = "0x946C", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x946D", Offset = "0x946D", VA = "0x946D")]
		public BossCombatView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BossCombat_View_BossCombatView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *param1_01;
		  uint *puVar3;
		  int local_4;
		  
		  param1_01 = (int *)0x0;
		  if (DAT_ram_00a57986 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_IManageCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a57986 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar2 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,9,&local_4,
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
		          goto code_r0x80e0bea8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,param2_00,0);
		code_r0x80e0bea8:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,param1,puVar3[1]);
		  }
		  return;
		}
		*/

		}
	}
}
