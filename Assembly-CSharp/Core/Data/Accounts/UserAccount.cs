using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.Accounts
{
	// Token: 0x020010F4 RID: 4340
	[Token(Token = "0x20010F4")]
	public class UserAccount : AccountDataDecorator
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006566 RID: 25958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001492")]
		public List<UserAccountLevelsDic> UserLevelAccountDics
		{
			[Token(Token = "0x6006565")]
			[Address(RVA = "0xB129", Offset = "0xB129", VA = "0xB129")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006566")]
			[Address(RVA = "0xB12A", Offset = "0xB12A", VA = "0xB12A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001493")]
		public override string Title
		{
			[Token(Token = "0x6006567")]
			[Address(RVA = "0xB12B", Offset = "0xB12B", VA = "0xB12B", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006568")]
		[Address(RVA = "0xB12C", Offset = "0xB12C", VA = "0xB12C", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		/* --- GHIDRA: Init ---
		void Core_Data_Accounts_UserAccount__Init(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Accounts_Model_Data_ClanAccount__GetAutoIncome(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06006569 RID: 25961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006569")]
		[Address(RVA = "0xB12D", Offset = "0xB12D", VA = "0xB12D")]
		public UserAccount()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_UserLevelAccountDics ---
		undefined4 Core_Data_Accounts_UserAccount__set_UserLevelAccountDics(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_GameLocalization__GetValue(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Title ---
		void Core_Data_Accounts_UserAccount__get_Title
		               (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6084f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountRepository_TypeInfo);
		    DAT_ram_00a6084f = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = Core_Extensions_Dict_DictExt__GetTutorialUIPointerDic(param3,param2,0);
		  param1[6] = iVar2;
		  iVar2 = Core_Extensions_Dict_DictExt__GetClanAccountLevels(param3,param2,0);
		  param1[2] = iVar2;
		  iVar2 = Core_Extensions_Dict_DictExt__TryGetAccountDic(param3,*(undefined4 *)(iVar2 + 0x24),0);
		  param1[5] = iVar2;
		  iVar2 = *param4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Accounts_IAccountRepository_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cee0fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,Core_Data_Accounts_IAccountRepository_TypeInfo,0);
		code_r0x81cee0fe:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param4,param2,&local_4,puVar3[1]);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,local_4,*(undefined4 *)(*param1 + 0x14c));
		  }
		  return;
		}
		*/

}
