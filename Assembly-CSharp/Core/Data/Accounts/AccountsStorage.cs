using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Data.Accounts
{
	// Token: 0x020010F1 RID: 4337
	[Token(Token = "0x20010F1")]
	public class AccountsStorage : IAccountRepository
	{
		// Token: 0x14000244 RID: 580
		// (add) Token: 0x0600655B RID: 25947 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600655C RID: 25948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000244")]
		public event Action AccountsChangedEvent
		{
			[Token(Token = "0x600655B")]
			[Address(RVA = "0xB124", Offset = "0xB124", VA = "0xB124")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600655C")]
			[Address(RVA = "0xB125", Offset = "0xB125", VA = "0xB125")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655D")]
		[Address(RVA = "0xB126", Offset = "0xB126", VA = "0xB126")]
		public AccountsStorage(int capacity)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_Accounts_AccountsStorage___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a6084c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData__Clear__);
		    DAT_ram_00a6084c = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655E")]
		[Address(RVA = "0xB127", Offset = "0xB127", VA = "0xB127")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Core_Data_Accounts_AccountsStorage__Reset(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar4;
		  int param2_00;
		  int *local_4;
		  
		  if (DAT_ram_00a6084e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_AccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_AccountInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData__Add__);
		    DAT_ram_00a6084e = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                    (param2,Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_AccountInfo___);
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(param2 + 0xc);
		    if (0 < iVar2) {
		      iVar1 = 0;
		      do {
		        param2_00 = *(int *)(param2 + iVar1 * 4 + 0x10);
		        iVar3 = Core_Data_UserData__get_Accounts
		                          (param1,*(undefined4 *)(param2_00 + 0x10),&local_4,iVar1);
		        if (iVar3 == 0) {
		          param1_01 = *(int *)(param1 + 0xc);
		          param1_00 = unnamed_function_1417(Core_Data_Accounts_AccountData_TypeInfo);
		          Core_Data_Accounts_AccountData__get_AccountInfo(param1_00,param2_00,iVar1);
		          iVar3 = Method_System_Collections_Generic_List_IAccountData__Add__;
		          *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		          uVar4 = *(uint *)(param1_01 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		            *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		            *(undefined4 *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = param1_00;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_01,param1_00,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		          }
		        }
		        else {
		          if (local_4 != (int *)0x0) {
		            if (((uint)*(byte *)(*local_4 + 0xb8) <
		                 (uint)*(byte *)(Core_Data_Accounts_AccountData_TypeInfo + 0xb8)) ||
		               (*(int *)(*(int *)(*local_4 + 100) +
		                         (uint)*(byte *)(Core_Data_Accounts_AccountData_TypeInfo + 0xb8) * 4 + -4)
		                != Core_Data_Accounts_AccountData_TypeInfo)) {
		              System_Activator__CreateInstance(local_4,Core_Data_Accounts_AccountData_TypeInfo);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          Core_Data_Accounts_AccountData__get_AccountInfo(local_4,param2_00,iVar1);
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar2);
		    }
		    iVar2 = *(int *)(param1 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  else {
		    if (DAT_ram_00a6084c == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData__Clear__);
		      DAT_ram_00a6084c = '\x01';
		    }
		    iVar2 = *(int *)(param1 + 0xc);
		    iVar1 = *(int *)(iVar2 + 0xc);
		    *(undefined4 *)(iVar2 + 0xc) = 0;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    if (0 < iVar1) {
		      func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600655F RID: 25951 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x600655F")]
		[Address(RVA = "0x1D52", Offset = "0x1D52", VA = "0x1D52", Slot = "4")]
		public bool TryGetAccount(uint id, out IAccountData account)
		{
		/* --- GHIDRA: TryGetAccount ---
		int * Core_Data_Accounts_AccountsStorage__TryGetAccount(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006560")]
		[Address(RVA = "0xB128", Offset = "0xB128", VA = "0xB128")]
		public void SetAccounts(params AccountInfo[] accounts)
		{
		}

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<IAccountData> _accounts;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AccountsChangedEvent ---
		void Core_Data_Accounts_AccountsStorage__add_AccountsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6084a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6084a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
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


		/* --- GHIDRA: remove_AccountsChangedEvent ---
		void Core_Data_Accounts_AccountsStorage__remove_AccountsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6084b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IAccountData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IAccountData__TypeInfo);
		    DAT_ram_00a6084b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IAccountData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,param2,Method_System_Collections_Generic_List_IAccountData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/

}
