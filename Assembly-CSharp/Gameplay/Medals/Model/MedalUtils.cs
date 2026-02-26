using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	public static class MedalUtils
	{
		// Token: 0x0600255B RID: 9563 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x1C2E", Offset = "0x1C2E", VA = "0x1C2E")]
		public static bool IsMedalHasRewardsWithSkills(MedalDic medalDic, List<int> skillIndexes)
		{
			return default(bool);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x76A2", Offset = "0x76A2", VA = "0x76A2")]
		public static bool IsMedalHasRewardsOtherThanSkills(MedalDic md)
		{
		/* --- GHIDRA: IsMedalHasRewardsOtherThanSkills ---
		void Gameplay_Medals_Model_MedalUtils__IsMedalHasRewardsOtherThanSkills(undefined4 param1)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a57daa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardTypes__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardTypes___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    DAT_ram_00a57daa = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_RewardTypes__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RewardTypes___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_RewardTypes__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  iVar3 = *(int *)(param1_00 + 8);
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar2 < uVar4) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(iVar3 + uVar2 * 4 + 0x10) = 4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar3 = *(int *)(param1_00 + 8);
		    uVar4 = *(uint *)(iVar3 + 0xc);
		    iVar1 = Method_System_Collections_Generic_List_RewardTypes__Add__;
		  }
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < uVar4) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(iVar3 + uVar2 * 4 + 0x10) = 0xe;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,0xe,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  **(int **)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<RewardTypes> SkillRewardTypes;
	}
}
