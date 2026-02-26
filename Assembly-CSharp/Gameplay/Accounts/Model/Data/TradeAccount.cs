using System;
using Core.Data;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DE2 RID: 3554
	[Token(Token = "0x2000DE2")]
	public class TradeAccount : UserAccount
	{
		// Token: 0x060056BF RID: 22207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BF")]
		[Address(RVA = "0xA43E", Offset = "0xA43E", VA = "0xA43E", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Accounts_Model_Data_TradeAccount__Init
		          (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  double param2_00;
		  uint uVar6;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a588c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_20459);
		    DAT_ram_00a588c3 = '\x01';
		  }
		  if (*(int *)(param3 + 0x6c) != 0) {
		    if (DAT_ram_00a588b4 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		      DAT_ram_00a588b4 = '\x01';
		    }
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x144));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))(param1,uVar1);
		    if (iVar2 != 0) {
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x144));
		      param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))(param1,uVar1);
		      uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar6 = 0;
		      iVar2 = *param1_00;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Data_Accounts_IAccountData_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8 + 4) * 8 + iVar2 + 0xd0);
		            goto code_r0x80f3ca7d;
		          }
		          uVar6 = uVar6 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar6);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3ca7d:
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,CONCAT44(uVar5,puVar3[1]));
		      if (iVar2 == 0) {
		        param2_00 = Core_Extensions_Dict_DictExt__GetIntParameter(param1[7],StringLiteral_20459,0);
		        uVar5 = Core_Extensions_Dict_ResourceSetExt___c__DisplayClass9_0___HasNewCurrency_b__0
		                          (*(undefined4 *)(*(int *)(param3 + 0x6c) + 0x30),0);
		        uVar4 = Core_Extensions_Dict_ResourceSetExt___c__DisplayClass9_0___HasNewCurrency_b__0
		                          (*(undefined4 *)(*(int *)(param3 + 0x6c) + 0x30),0);
		        uVar4 = Core_Extensions_Dict_ResourceSetExt__Round(uVar4,param2_00,0);
		        uVar4 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar4,0);
		        uVar5 = Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(uVar5,uVar4,0);
		        return uVar5;
		      }
		    }
		    uVar5 = Core_Extensions_Dict_ResourceSetExt___c__DisplayClass9_0___HasNewCurrency_b__0
		                      (*(undefined4 *)(*(int *)(param3 + 0x6c) + 0x30),0);
		  }
		  return uVar5;
		}
		*/

		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056C0")]
		[Address(RVA = "0xA43F", Offset = "0xA43F", VA = "0xA43F")]
		public ResourceSet GetBalanceLimit(Resources resourceId, UserData user)
		{
		/* --- GHIDRA: GetBalanceLimit ---
		void Gameplay_Accounts_Model_Data_TradeAccount__GetBalanceLimit(undefined4 param1,undefined4 param2)
		
		{
		  Core_Data_Accounts_UserAccount__Init(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C1")]
		[Address(RVA = "0xA440", Offset = "0xA440", VA = "0xA440")]
		public TradeAccount()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Model_Data_TradeAccount___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a588c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsButtonView___ctor__
		              );
		    DAT_ram_00a588c4 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AccountsModel__AccountsEvents__AccountsController__AccountsButtonView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002EFC RID: 12028
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x1C")]
		private Dictionaries _dictionaries;
	}
}
