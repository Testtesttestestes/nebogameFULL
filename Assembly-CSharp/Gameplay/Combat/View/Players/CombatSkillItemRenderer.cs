using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094B RID: 2379
	[Token(Token = "0x200094B")]
	public class CombatSkillItemRenderer : TitleIconValueBackground
	{
		// Token: 0x06003859 RID: 14425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003859")]
		[Address(RVA = "0x8810", Offset = "0x8810", VA = "0x8810")]
		public void SetValues(long absolute, double relative)
		{
		/* --- GHIDRA: SetValues ---
		void Gameplay_Combat_View_Players_CombatSkillItemRenderer__SetValues
		               (int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  float8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a566fb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28648);
		    DAT_ram_00a566fb = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x20);
		  local_8 = *(undefined8 *)(param1 + 0x30);
		  uVar1 = func_ii_1081(DAT_ram_00a66964,&local_8);
		  local_10 = (float8)param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66970,&local_10);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28648,uVar1,param3_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x0600385A RID: 14426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385A")]
		[Address(RVA = "0x8811", Offset = "0x8811", VA = "0x8811")]
		public void SetRelativeValue(double value)
		{
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385B")]
		[Address(RVA = "0x8812", Offset = "0x8812", VA = "0x8812")]
		public CombatSkillItemRenderer()
		{
		}
	}
}
