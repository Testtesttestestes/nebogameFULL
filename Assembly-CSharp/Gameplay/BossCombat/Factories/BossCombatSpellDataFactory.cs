using System;
using Gameplay.Boss.Model;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.BossCombat.Factories
{
	// Token: 0x02000B40 RID: 2880
	[Token(Token = "0x2000B40")]
	public class BossCombatSpellDataFactory : ICombatSpellDataFactory, IDisposable
	{
		// Token: 0x060045D8 RID: 17880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x947A", Offset = "0x947A", VA = "0x947A", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x947B", Offset = "0x947B", VA = "0x947B")]
		public BossCombatSpellDataFactory(BossInstanceModel bossInstanceModel)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_BossCombat_Factories_BossCombatSpellDataFactory___ctor
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5798b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SingleOrDefault_BossInfo_BossCultSpellData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BossInfo_BossCultSpellData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_Create_BossCombatSpellData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BossCombat_Factories_BossCombatSpellDataFactory___c__DisplayClass3_0__Create_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_BossCombat_Factories_BossCombatSpellDataFactory___c__DisplayClass3_0_TypeInfo
		              );
		    DAT_ram_00a5798b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_BossCombat_Factories_BossCombatSpellDataFactory___c__DisplayClass3_0_TypeInfo
		                    );
		  uVar4 = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		  *(undefined4 *)(iVar1 + 8) = uVar4;
		  iVar2 = Core_Data_Spells_SpellData__Create_object_
		                    (uVar4,*(undefined4 *)(param2 + 0x10),
		                     Method_Core_Data_Spells_SpellData_Create_BossCombatSpellData___);
		  *(int *)(iVar2 + 0x38) = param2;
		  if (*(int *)(param1 + 8) != 0) {
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0x48);
		    uVar4 = unnamed_function_1417(System_Func_BossInfo_BossCultSpellData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar1,
		               Method_Gameplay_BossCombat_Factories_BossCombatSpellDataFactory___c__DisplayClass3_0__Create_b__0__
		               ,0);
		    iVar1 = UI_SimpleIconValue__set_Value
		                      (uVar3,uVar4,
		                       Method_System_Linq_Enumerable_SingleOrDefault_BossInfo_BossCultSpellData___);
		    if (iVar1 != 0) {
		      uVar3 = *(undefined4 *)(param1 + 8);
		      uVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                        (iVar1,0);
		      uVar4 = func_ii_7040(uVar3,uVar4,0);
		      *(undefined4 *)(iVar2 + 0x48) = uVar4;
		    }
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x947C", Offset = "0x947C", VA = "0x947C", Slot = "4")]
		public CombatSpellData Create(SpellCombat spell)
		{
			return null;
		}

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x8")]
		private BossInstanceModel _bossInstanceModel;
	}
}
