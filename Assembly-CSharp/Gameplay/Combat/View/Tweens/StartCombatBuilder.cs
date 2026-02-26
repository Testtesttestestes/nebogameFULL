using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000933 RID: 2355
	[Token(Token = "0x2000933")]
	public class StartCombatBuilder : MonoBehaviour
	{
		// Token: 0x0600378D RID: 14221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x8778", Offset = "0x8778", VA = "0x8778")]
		public void Play()
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Combat_View_Tweens_StartCombatBuilder__Play(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  
		  iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar1) {
		    param2_00 = 0;
		    do {
		      Gameplay_Combat_View_Tweens_FromToTweener__Start
		                (*(undefined4 *)(*(int *)(param1 + 0x10) + param2_00 * 4 + 0x10),param2_00);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x8779", Offset = "0x8779", VA = "0x8779")]
		public void Rollback()
		{
		/* --- GHIDRA: Rollback ---
		void Gameplay_Combat_View_Tweens_StartCombatBuilder__Rollback(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar2) {
		    iVar1 = 0;
		    do {
		      Gameplay_Combat_View_Tweens_FromToTweener__Start
		                (*(undefined4 *)(*(int *)(param1 + 0x10) + iVar1 * 4 + 0x10),iVar1);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar2);
		    iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		    if (0 < iVar2) {
		      iVar1 = 0;
		      do {
		        Gameplay_Combat_View_Tweens_FromToTweener__Rollback
		                  (*(undefined4 *)(*(int *)(param1 + 0x10) + iVar1 * 4 + 0x10),iVar1);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar2);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x877A", Offset = "0x877A", VA = "0x877A")]
		public void Test()
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x877B", Offset = "0x877B", VA = "0x877B")]
		public StartCombatBuilder()
		{
		}

		// Token: 0x04001EAC RID: 7852
		[Token(Token = "0x4001EAC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FromToTweener[] _elements;
	}
}
