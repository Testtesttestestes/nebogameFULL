using System;
using System.Collections.Generic;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;

namespace Core.Sorting
{
	// Token: 0x02000E74 RID: 3700
	[Token(Token = "0x2000E74")]
	public class QuestComparer : IComparer<IQuest>
	{
		// Token: 0x06005A27 RID: 23079 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0xA731", Offset = "0xA731", VA = "0xA731", Slot = "4")]
		public int Compare(IQuest x, IQuest y)
		{
		/* --- GHIDRA: Compare ---
		undefined4 Core_Sorting_QuestComparer__Compare(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a60565 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a60565 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x81ca6687;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x81ca6687:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar3 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar1 = 0;
		    uVar4 = 1;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		          goto code_r0x81ca6711;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_DailyQuests_Model_IQuest_TypeInfo,6);
		code_r0x81ca6711:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar3 == 0) {
		      uVar4 = 0xffffffff;
		    }
		  }
		  return uVar4;
		}
		*/

			return 0;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0xA732", Offset = "0xA732", VA = "0xA732")]
		private int GetImportance(IQuest quest)
		{
			return 0;
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0xA733", Offset = "0xA733", VA = "0xA733")]
		public QuestComparer()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Sorting_QuestComparer___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = Core_Data_UserData__set_LevelDic(param1,0);
		  uVar1 = Core_Data_UserData__set_LevelDic(param2,0);
		  uVar1 = System_UInt32__CompareTo(&local_4,uVar1,0);
		  return uVar1;
		}
		*/

		}
	}
}
