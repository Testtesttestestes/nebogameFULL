using System;
using Core.Data.Accounts;
using Il2CppDummyDll;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DE1 RID: 3553
	[Token(Token = "0x2000DE1")]
	public class ManufactureAccount : UserAccount
	{
		// Token: 0x060056BE RID: 22206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BE")]
		[Address(RVA = "0xA43D", Offset = "0xA43D", VA = "0xA43D")]
		public ManufactureAccount()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Model_Data_ManufactureAccount___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  Core_Data_Accounts_UserAccount__get_Title(param1,param2,param3,param4,0);
		  return;
		}
		*/

		}
	}
}
