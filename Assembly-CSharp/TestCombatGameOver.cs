using System;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
public class TestCombatGameOver : MonoBehaviour
{
	// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x5585", Offset = "0x5585", VA = "0x5585")]
	public void TestCombatProgressBar(float value)
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x5586", Offset = "0x5586", VA = "0x5586")]
	public TestCombatGameOver()
	{
		/* --- GHIDRA: .ctor ---
		void TestCombatGameOver___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x48) = 0xc61c3c00c61c3c00;
		  *(undefined8 *)(param1 + 0x40) = 0xc61c3c00c61c3c00;
		  *(undefined2 *)(param1 + 0x29) = 0x101;
		  return;
		}
		*/

	}

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private CombatProgressBar[] _pb;
}
