using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class LoadingImageRotator : MonoBehaviour
{
	// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x5582", Offset = "0x5582", VA = "0x5582")]
	private void Start()
	{
		/* --- GHIDRA: Start ---
		void LoadingImageRotator__Start(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  float fVar1;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  fVar1 = UnityEngine_Time__get_timeAsRational(0);
		  UnityEngine_Transform__Rotate(param1_00,0.0,0.0,fVar1 * -300.0,0);
		  return;
		}
		*/

	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x5583", Offset = "0x5583", VA = "0x5583")]
	private void Update()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x5584", Offset = "0x5584", VA = "0x5584")]
	public LoadingImageRotator()
	{
		/* --- GHIDRA: .ctor ---
		void LoadingImageRotator___ctor(int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      piVar3 = *(int **)(iVar2 + iVar1 * 4 + 0x10);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x108) * 4))
		                (piVar3,param2,*(undefined4 *)(iVar4 + 0x10c));
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

	}
}
