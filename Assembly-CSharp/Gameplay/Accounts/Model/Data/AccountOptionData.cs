using System;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDB RID: 3547
	[Token(Token = "0x2000DDB")]
	public class AccountOptionData : BankOptionData
	{
		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AA")]
		public AccountOptionsDic AccountOptionsDic
		{
			[Token(Token = "0x6005692")]
			[Address(RVA = "0xA41A", Offset = "0xA41A", VA = "0xA41A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005693")]
			[Address(RVA = "0xA41B", Offset = "0xA41B", VA = "0xA41B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AB")]
		public AccountOptionData ParentAccountOption
		{
			[Token(Token = "0x6005694")]
			[Address(RVA = "0xA41C", Offset = "0xA41C", VA = "0xA41C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005695")]
			[Address(RVA = "0xA41D", Offset = "0xA41D", VA = "0xA41D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005696")]
		[Address(RVA = "0xA41E", Offset = "0xA41E", VA = "0xA41E")]
		public AccountOptionData(AccountOptionsDic optionsDic)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Accounts_Model_Data_AccountOptionData___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a588b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		    DAT_ram_00a588b6 = '\x01';
		  }
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 != 0) {
		    param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                                 (param1,*(undefined4 *)(*param1 + 0x144));
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80f3af12;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3af12:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if (iVar2 == 0) {
		      return param1[7];
		    }
		  }
		  if (*(int *)(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		  }
		  if (DAT_ram_00a58947 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		    DAT_ram_00a58947 = '\x01';
		  }
		  if (*(int *)(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo);
		  }
		  return **(undefined4 **)(Gameplay_Accounts_Model_Data_BattleAccount_TypeInfo + 0x5c);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ParentAccountOption ---
		void Gameplay_Accounts_Model_Data_AccountOptionData__set_ParentAccountOption
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Sirenix_OdinInspector_ListDrawerSettingsAttribute__get_OnTitleBarGUI(param1,1,0);
		  *(undefined4 *)(param1 + 0x70) = param2;
		  return;
		}
		*/

}
