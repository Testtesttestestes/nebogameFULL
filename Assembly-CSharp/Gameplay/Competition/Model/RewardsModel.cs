using System;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008FA RID: 2298
	[Token(Token = "0x20008FA")]
	public class RewardsModel : AbstractModel
	{
		// Token: 0x06003618 RID: 13848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x8625", Offset = "0x8625", VA = "0x8625")]
		public RewardsModel(IDictProvider dictProvider, CompetitionData competition, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Competition_Model_RewardsModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ac8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Model_RewardsModel__GetRewards_b__4_0__);
		    DAT_ram_00a63ac8 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x14);
		  if (iVar4 == 0) {
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0x10);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x82339f17;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x82339f17:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    param1_01 = *(undefined4 *)(iVar4 + 0x30c);
		    uVar3 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,param1,Method_Gameplay_Competition_Model_RewardsModel__GetRewards_b__4_0__,0);
		    uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (param1_01,uVar3,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    iVar4 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		    *(int *)(param1 + 0x14) = iVar4;
		  }
		  return iVar4;
		}
		*/

		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x8626", Offset = "0x8626", VA = "0x8626")]
		public RatingPrizeDic[] GetRewards()
		{
		/* --- GHIDRA: GetRewards ---
		uint Gameplay_Competition_Model_RewardsModel__GetRewards(int param1,int param2,undefined4 param3)
		
		{
		  return (uint)(*(int *)(param2 + 0xc) == *(int *)(*(int *)(*(int *)(param1 + 0xc) + 8) + 0xc));
		}
		*/

			return null;
		}

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		[FieldOffset(Offset = "0xC")]
		public readonly CompetitionData Competition;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x14")]
		private RatingPrizeDic[] _cachedRewards;
	}
}
