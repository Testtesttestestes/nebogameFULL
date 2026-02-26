using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDD RID: 3549
	[Token(Token = "0x2000DDD")]
	public class ClanAccount : AccountDataDecorator
	{
		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060056A7 RID: 22183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AE")]
		public List<ClanAccountLevelsDic> LevelsDics
		{
			[Token(Token = "0x60056A6")]
			[Address(RVA = "0xA42E", Offset = "0xA42E", VA = "0xA42E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60056A7")]
			[Address(RVA = "0xA42F", Offset = "0xA42F", VA = "0xA42F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011AF")]
		public override string Title
		{
			[Token(Token = "0x60056A8")]
			[Address(RVA = "0xA430", Offset = "0xA430", VA = "0xA430", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0xA431", Offset = "0xA431", VA = "0xA431", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		/* --- GHIDRA: Init ---
		undefined4 Gameplay_Accounts_Model_Data_ClanAccount__Init(int param1,uint param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  uint uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a588bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Item__);
		    DAT_ram_00a588bc = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  if (0 < iVar3) {
		    iVar3 = iVar3 + -1;
		    if (param2 == 0) {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x18),iVar3,
		                           Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Item__);
		        if (*(int *)(*(int *)(iVar2 + 0xc) + 0x10) == 0) goto code_r0x80f3bda5;
		        bVar1 = 0 < iVar3;
		        iVar3 = iVar3 + -1;
		      } while (bVar1);
		    }
		    else {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x18),iVar3,
		                           Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Item__);
		        uVar4 = *(uint *)(*(int *)(iVar2 + 0xc) + 0x14);
		        uVar5 = *(uint *)(*(int *)(iVar2 + 0xc) + 0x10);
		        uVar6 = uVar5;
		        if (uVar4 == 0) {
		          uVar6 = 0;
		        }
		        if (uVar6 == 0) {
		          if (uVar5 == 0) goto joined_r0x80f3bd8c;
		          if (uVar5 <= param2) {
		code_r0x80f3bda5:
		            return *(undefined4 *)(iVar2 + 0x14);
		          }
		        }
		        else if (uVar5 <= param2) {
		joined_r0x80f3bd8c:
		          if (param2 <= uVar4) goto code_r0x80f3bda5;
		        }
		        bVar1 = 0 < iVar3;
		        iVar3 = iVar3 + -1;
		      } while (bVar1);
		    }
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056AA")]
		[Address(RVA = "0xA432", Offset = "0xA432", VA = "0xA432")]
		public ResourceSet GetAutoIncomeCoeff(uint zigguratLevel)
		{
		/* --- GHIDRA: GetAutoIncomeCoeff ---
		undefined4
		Gameplay_Accounts_Model_Data_ClanAccount__GetAutoIncomeCoeff
		          (int param1,uint param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  uint uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a588bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Item__);
		    DAT_ram_00a588bd = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  if (0 < iVar3) {
		    iVar3 = iVar3 + -1;
		    if (param2 == 0) {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x18),iVar3,
		                           Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Item__);
		        if (*(int *)(*(int *)(iVar2 + 0xc) + 0x10) == 0) goto code_r0x80f3bea3;
		        bVar1 = 0 < iVar3;
		        iVar3 = iVar3 + -1;
		      } while (bVar1);
		    }
		    else {
		      do {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x18),iVar3,
		                           Method_System_Collections_Generic_List_ClanAccountLevelsDic__get_Item__);
		        uVar4 = *(uint *)(*(int *)(iVar2 + 0xc) + 0x14);
		        uVar5 = *(uint *)(*(int *)(iVar2 + 0xc) + 0x10);
		        uVar6 = uVar5;
		        if (uVar4 == 0) {
		          uVar6 = 0;
		        }
		        if (uVar6 == 0) {
		          if (uVar5 == 0) goto joined_r0x80f3be8a;
		          if (uVar5 <= param2) {
		code_r0x80f3bea3:
		            return *(undefined4 *)(iVar2 + 0x10);
		          }
		        }
		        else if (uVar5 <= param2) {
		joined_r0x80f3be8a:
		          if (param2 <= uVar4) goto code_r0x80f3bea3;
		        }
		        bVar1 = 0 < iVar3;
		        iVar3 = iVar3 + -1;
		      } while (bVar1);
		    }
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0xA433", Offset = "0xA433", VA = "0xA433")]
		public ResourceSet GetJoinPriceCoeff(uint zigguratLevel)
		{
		/* --- GHIDRA: GetJoinPriceCoeff ---
		undefined4
		Gameplay_Accounts_Model_Data_ClanAccount__GetJoinPriceCoeff
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Accounts_Model_Data_ClanAccount__Init(param1,param2,param2);
		  uVar1 = Protocol_Common_ResourceSet___ctor(uVar1,0);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__Round(uVar1,100.0,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056AC")]
		[Address(RVA = "0xA434", Offset = "0xA434", VA = "0xA434")]
		public ResourceSet GetAutoIncome(uint zigguratLevel)
		{
		/* --- GHIDRA: GetAutoIncome ---
		void Gameplay_Accounts_Model_Data_ClanAccount__GetAutoIncome(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AccountOptionData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AccountOptionData__TypeInfo);
		    DAT_ram_00a588b5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AccountOptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AccountOptionData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AD")]
		[Address(RVA = "0xA435", Offset = "0xA435", VA = "0xA435")]
		public ClanAccount()
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_Accounts_Model_Data_ClanAccount___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int *piVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  piVar5 = (int *)0x0;
		  if (DAT_ram_00a588be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    DAT_ram_00a588be = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x160) * 4))
		                    (param1,&local_4,*(undefined4 *)(*param1 + 0x164));
		  if (iVar2 != 0) {
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_18,local_4,
		               Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    local_20 = 0;
		    local_1c = &local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                         Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                        );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f3c0c0;
		      }
		      if (iVar3 == 0) {
		        piVar5 = (int *)0x0;
		        break;
		      }
		      piVar5 = local_10._4_4_;
		      iVar2 = *local_10._4_4_;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (Core_Data_Accounts_IAccountData_TypeInfo == *piVar6) {
		            puVar4 = (undefined4 *)(piVar6[1] * 8 + iVar2 + 0xd0);
		            goto code_r0x80f3c057;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                          Core_Data_Accounts_IAccountData_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3c0b8:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f3c0c0:
		        iVar2 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 == iVar3) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		          iVar3 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar3;
		          import::env::invoke_v(0x123);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            if (iVar3 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return (int *)0;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          param1_00 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1af,&local_20);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          import::env::__resumeException(param1_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f3c057:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3c0b8;
		    } while (iVar2 != 0);
		    DAT_ram_009d3e38 = 0;
		  }
		  return piVar5;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_LevelsDics ---
		undefined4 Gameplay_Accounts_Model_Data_ClanAccount__set_LevelsDics(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_UserDataExt___IsLegendaryUser_g__CheckApr_0_0
		                    (*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Title ---
		void Gameplay_Accounts_Model_Data_ClanAccount__get_Title
		               (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a588bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountRepository_TypeInfo);
		    DAT_ram_00a588bb = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = Core_Extensions_Dict_DictExt__GetUserAccountLevels(param3,param2,0);
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
		        goto code_r0x80f3bc7f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param4,Core_Data_Accounts_IAccountRepository_TypeInfo,0);
		code_r0x80f3bc7f:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param4,param2,&local_4,puVar3[1]);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		              (param1,local_4,*(undefined4 *)(*param1 + 0x14c));
		  }
		  return;
		}
		*/

}
