using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x02000973 RID: 2419
	[Token(Token = "0x2000973")]
	[Serializable]
	public class PatternElement
	{
		// Token: 0x06003992 RID: 14738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x8923", Offset = "0x8923", VA = "0x8923")]
		public PatternElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Combat_View_GameField_Hint_PatternElement___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a56768 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo);
		    DAT_ram_00a56768 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x34);
		  if (param1_00 == (int *)0x0) {
		    uVar3 = 0;
		  }
		  else {
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x80c756fb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo,4);
		code_r0x80c756fb:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x04001FDE RID: 8158
		[Token(Token = "0x4001FDE")]
		[FieldOffset(Offset = "0x8")]
		public bool Value;
	}
}
