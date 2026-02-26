using System;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Core.Data.Accounts
{
	// Token: 0x020010F0 RID: 4336
	[Token(Token = "0x20010F0")]
	public class AccountData : IAccountData
	{
		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700148C")]
		public AccountInfo AccountInfo
		{
			[Token(Token = "0x6006556")]
			[Address(RVA = "0xB11F", Offset = "0xB11F", VA = "0xB11F", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006557")]
			[Address(RVA = "0xB120", Offset = "0xB120", VA = "0xB120")]
			set
			{
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700148D")]
		public BackTime BackTime
		{
			[Token(Token = "0x6006558")]
			[Address(RVA = "0xB121", Offset = "0xB121", VA = "0xB121", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06006559 RID: 25945 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x1700148E")]
		public bool IsExpired
		{
			[Token(Token = "0x6006559")]
			[Address(RVA = "0xB122", Offset = "0xB122", VA = "0xB122", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655A")]
		[Address(RVA = "0xB123", Offset = "0xB123", VA = "0xB123")]
		public AccountData(AccountInfo accountInfo)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_Accounts_AccountData___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60849 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a60849 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400362C RID: 13868
		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x8")]
		private AccountInfo _accountInfo;

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0xC")]
		private BackTime _backtime;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AccountInfo ---
		void Core_Data_Accounts_AccountData__get_AccountInfo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float fVar1;
		  int param1_01;
		  undefined8 param1_02;
		  
		  if (DAT_ram_00a60848 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a60848 = '\x01';
		  }
		  *(int *)(param1 + 8) = param2;
		  param1_02 = *(undefined8 *)(param2 + 0x18);
		  param1_01 = *(int *)(param1 + 0xc);
		  if (param1_01 == 0) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar1 = func_ii_7331(param1_02,0);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,fVar1,0);
		    *(undefined4 *)(param1 + 0xc) = param1_00;
		    return;
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar1 = func_ii_7331(param1_02,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_01,fVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_BackTime ---
		uint Core_Data_Accounts_AccountData__get_BackTime(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0xc),0);
		  return (uint)(fVar1 <= 0.0);
		}
		*/


		/* --- GHIDRA: get_IsExpired ---
		void Core_Data_Accounts_AccountData__get_IsExpired
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Data_Accounts_AccountData__get_AccountInfo(param1,param2,param1);
		  return;
		}
		*/

}
