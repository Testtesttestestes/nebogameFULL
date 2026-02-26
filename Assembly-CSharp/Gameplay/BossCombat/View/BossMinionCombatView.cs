using System;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.View
{
	// Token: 0x02000B3C RID: 2876
	[Token(Token = "0x2000B3C")]
	public class BossMinionCombatView : OneOnOneCombatView
	{
		// Token: 0x060045CC RID: 17868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x946E", Offset = "0x946E", VA = "0x946E", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_BossCombat_View_BossMinionCombatView__Start
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57987 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a57987 = '\x01';
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

		// Token: 0x060045CD RID: 17869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x946F", Offset = "0x946F", VA = "0x946F", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CE")]
		[Address(RVA = "0x9470", Offset = "0x9470", VA = "0x9470")]
		public BossMinionCombatView()
		{
		}
	}
}
