using System;
using System.Collections.Generic;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDE RID: 3550
	[Token(Token = "0x2000DDE")]
	public class ClanAccountGroup : ClanAccount
	{
		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060056AE RID: 22190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011B0")]
		public override IAccountData Account
		{
			[Token(Token = "0x60056AE")]
			[Address(RVA = "0xA436", Offset = "0xA436", VA = "0xA436", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0xA437", Offset = "0xA437", VA = "0xA437", Slot = "20")]
		public override bool TryGetNested(out List<IAccountDataDecorator> accounts)
		{
		/* --- GHIDRA: TryGetNested ---
		/* WARNING: Removing unreachable block (ram,0x80f3c663) */
		
		void Gameplay_Accounts_Model_Data_ClanAccountGroup__TryGetNested
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a588c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_AccountDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_AccountDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_AccountDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_AccountDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Model_Data_ClanAccountGroup___c__Init_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo);
		    DAT_ram_00a588c0 = '\x01';
		  }
		  iVar2 = Core_Extensions_Dict_DictExt__GetClanAccountLevels(param3,param2,0);
		  *(int *)(param1 + 8) = iVar2;
		  uVar3 = Core_Extensions_Dict_DictExt__TryGetAccountDic(param3,*(undefined4 *)(iVar2 + 0x24),0);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  uVar3 = *(undefined4 *)(param3 + 0x6c);
		  if (*(int *)(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo + 0x5c);
		  iVar2 = puVar7[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo);
		      puVar7 = *(undefined4 **)(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar7;
		    iVar2 = unnamed_function_1417(System_Func_AccountDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Gameplay_Accounts_Model_Data_ClanAccountGroup___c__Init_b__4_0__,0);
		    *(int *)(*(int *)(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo + 0x5c) + 4) =
		         iVar2;
		  }
		  uVar1 = 0;
		  piVar4 = (int *)System_Linq_Enumerable__Where_PlayerLoopSystem_
		                            (uVar3,iVar2,Method_System_Linq_Enumerable_Where_AccountDic___);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_AccountDic__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f3c342;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IEnumerable_AccountDic__TypeInfo,0
		                               );
		code_r0x80f3c342:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80f3c37b:
		  do {
		    piVar4 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar7 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f3c40f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3c771:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3c779;
		    }
		code_r0x80f3c40f:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar7,piVar4,puVar7[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3c771;
		    if (iVar2 == 0) goto code_r0x80f3c7c2;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_AccountDic__TypeInfo == *piVar8) {
		          puVar7 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f3c4ec;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_AccountDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3c749:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3c779;
		    }
		code_r0x80f3c4ec:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar7,piVar4,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3c749;
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3c753:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3c779;
		    }
		    if (DAT_ram_00a588b5 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&Method_System_Collections_Generic_List_AccountOptionData___ctor__);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&System_Collections_Generic_List_AccountOptionData__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a588b5 = '\x01';
		          goto code_r0x80f3c5d1;
		        }
		      }
		      goto code_r0x80f3c753;
		    }
		code_r0x80f3c5d1:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Collections_Generic_List_AccountOptionData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3c753;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,iVar6,
		               Method_System_Collections_Generic_List_AccountOptionData___ctor__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3c753;
		    piVar4[4] = iVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (*(undefined4 *)(*piVar4 + 0x158),piVar4,*(undefined4 *)(iVar2 + 0xc),param3,param4,
		               *(undefined4 *)(*piVar4 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    iVar2 = Method_System_Collections_Generic_List_IAccountDataDecorator__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3c779;
		    }
		    iVar6 = *(int *)(param1 + 0x1c);
		    *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar6 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		      *(uint *)(iVar6 + 0xc) = uVar1 + 1;
		      *(int **)(*(int *)(iVar6 + 8) + uVar1 * 4 + 0x10) = piVar4;
		      goto code_r0x80f3c37b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,piVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f3c779:
		  iVar2 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar6) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80f3c7c2:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = *local_8;
		      if (piVar4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar2 = *piVar4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f3c83d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80f3c83d:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1b0,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar3);
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
		*/

			return default(bool);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B0")]
		[Address(RVA = "0xA438", Offset = "0xA438", VA = "0xA438", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Accounts_Model_Data_ClanAccountGroup__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a588c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a588c1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IAccountDataDecorator__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IAccountDataDecorator___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  if (DAT_ram_00a588b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AccountOptionData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AccountOptionData__TypeInfo);
		    DAT_ram_00a588b5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_AccountOptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_AccountOptionData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0xA439", Offset = "0xA439", VA = "0xA439")]
		public ClanAccountGroup()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Model_Data_ClanAccountGroup___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a588c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo);
		    DAT_ram_00a588c2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Accounts_Model_Data_ClanAccountGroup___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002EF9 RID: 12025
		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x1C")]
		private List<IAccountDataDecorator> _nested;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Account ---
		uint Gameplay_Accounts_Model_Data_ClanAccountGroup__get_Account
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a588bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__get_Count__);
		    DAT_ram_00a588bf = '\x01';
		  }
		  *param2 = *(undefined4 *)(param1 + 0x1c);
		  return (uint)(0 < *(int *)(*(int *)(param1 + 0x1c) + 0xc));
		}
		*/

}
