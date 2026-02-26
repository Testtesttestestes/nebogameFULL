using System;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094D RID: 2381
	[Token(Token = "0x200094D")]
	public class CombatUserBalance : MonoBehaviour
	{
		// Token: 0x0600385D RID: 14429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x8814", Offset = "0x8814", VA = "0x8814")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Combat_View_Players_CombatUserBalance__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  double param1_00;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  
		  iVar6 = 0;
		  iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar3 = *(int *)(*(int *)(param1 + 0x10) + iVar6 * 4 + 0x10);
		      iVar4 = *(int *)(iVar3 + 0xc);
		      param1_00 = func_ii_6906(param2,*(undefined4 *)(iVar3 + 8),0);
		      if (DAT_ram_00a566fd == '\0') {
		        Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		        DAT_ram_00a566fd = '\x01';
		      }
		      *(double *)(iVar4 + 0x18) = param1_00;
		      piVar5 = *(int **)(iVar4 + 0x14);
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      uVar1 = func_ii_8614(param1_00,0,0);
		      iVar3 = *piVar5;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar5,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x8815", Offset = "0x8815", VA = "0x8815")]
		public void SetBalance(ResourceSet balance)
		{
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x8816", Offset = "0x8816", VA = "0x8816")]
		public CombatUserBalance()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_CombatUserBalance___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		}

		// Token: 0x04001F33 RID: 7987
		[Token(Token = "0x4001F33")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CombatUserBalanceItem[] _balanceItems;
	}
}
