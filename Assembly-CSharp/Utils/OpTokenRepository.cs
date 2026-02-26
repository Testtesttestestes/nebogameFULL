using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class OpTokenRepository : IDisposable
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5750", Offset = "0x5750", VA = "0x5750", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_OpTokenRepository__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6280e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_IOpToken___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_IOpToken__TypeInfo);
		    DAT_ram_00a6280e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_IOpToken__TypeInfo);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x5751", Offset = "0x5751", VA = "0x5751")]
		public OpTokenRepository()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Utils_OpTokenRepository___ctor(int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *piVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a6280f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__get_Current__);
		    Mono_Security_ASN1__get_Item(&Utils_IOpToken_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IOpToken__GetEnumerator__);
		    DAT_ram_00a6280f = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  func_ii_16538(&local_18,*(undefined4 *)(param1 + 8),
		                Method_System_Collections_Generic_LinkedList_IOpToken__GetEnumerator__);
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                       Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__MoveNext__)
		    ;
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x820f5657:
		      iVar5 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x820f56f7:
		          DAT_ram_009d3e38 = 0;
		          *param3 = 0;
		          return 0;
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x1b,&local_20);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
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
		    if (iVar2 == 0) goto code_r0x820f56f7;
		    piVar4 = local_10._4_4_;
		    iVar5 = *local_10._4_4_;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (Utils_IOpToken_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar5 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x820f55df;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                        Utils_IOpToken_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x820f564f:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f5657;
		    }
		code_r0x820f55df:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar3,piVar4,puVar3[1]);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) goto code_r0x820f564f;
		    if (param2 == iVar2) {
		      *param3 = piVar4;
		      return 1;
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x5752", Offset = "0x5752", VA = "0x5752")]
		public bool TryGet(object index, out IOpToken token)
		{
		/* --- GHIDRA: TryGet ---
		void Utils_OpTokenRepository__TryGet(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a62810 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_IOpToken__AddLast__);
		    DAT_ram_00a62810 = '\x01';
		  }
		  System_Collections_Generic_LinkedList_object____ctor
		            (*(undefined4 *)(param1 + 8),param2,
		             Method_System_Collections_Generic_LinkedList_IOpToken__AddLast__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x5753", Offset = "0x5753", VA = "0x5753")]
		public void Add(IOpToken token)
		{
		/* --- GHIDRA: Add ---
		void Utils_OpTokenRepository__Add(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a62811 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_IOpToken__Remove__);
		    DAT_ram_00a62811 = '\x01';
		  }
		  System_Net_WebConnection__StartOperation
		            (*(undefined4 *)(param1 + 8),param2,
		             Method_System_Collections_Generic_LinkedList_IOpToken__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x5754", Offset = "0x5754", VA = "0x5754")]
		public void Remove(IOpToken token)
		{
		/* --- GHIDRA: Remove ---
		/* WARNING: Removing unreachable block (ram,0x820f5254) */
		
		void Utils_OpTokenRepository__Remove(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 *param2_00;
		  int iVar6;
		  int *piVar7;
		  int local_2c;
		  undefined8 *puStack_28;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a62812 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__get_Current__);
		    Mono_Security_ASN1__get_Item(&Utils_IOpToken_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_IOpToken__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_IOpToken__GetEnumerator__);
		    DAT_ram_00a62812 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  DAT_ram_009d3e38 = 0;
		  func_ii_16538(&local_2c,*(undefined4 *)(param1 + 8),
		                Method_System_Collections_Generic_LinkedList_IOpToken__GetEnumerator__);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar6 = global_1;
		code_r0x820f52d8:
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar4 != iVar6) {
		code_r0x820f53da:
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar5 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_InvalidOperationException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar5);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar4 != 0) {
		          import::env::__cxa_end_catch();
		          Utils_OpTokenRepository__Remove(param1,iVar6);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f5404;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) goto code_r0x820f53da;
		  }
		  else {
		    local_8 = local_1c;
		    local_10 = local_24;
		    local_18 = CONCAT44(puStack_28,local_2c);
		    local_2c = 0;
		    puStack_28 = &local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                         Method_System_Collections_Generic_LinkedList_Enumerator_IOpToken__MoveNext__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x820f51dd;
		      }
		      if (iVar4 == 0) {
		        iVar6 = 0;
		        goto code_r0x820f5228;
		      }
		      piVar3 = local_10._4_4_;
		      iVar6 = *local_10._4_4_;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (Utils_IOpToken_TypeInfo == *piVar7) {
		            puVar5 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xd8);
		            goto code_r0x820f5185;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                          Utils_IOpToken_TypeInfo,3);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x820f5185:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(*puVar5,piVar3,puVar5[1]);
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x820f51dd:
		    iVar6 = global_1;
		    iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar4) {
		      piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		      iVar6 = *piVar3;
		      DAT_ram_009d3e38 = 0;
		      local_2c = iVar6;
		      import::env::invoke_v(0x123);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 != 1) {
		code_r0x820f5228:
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 0) {
		          System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_LinkedList_IOpToken__Clear__);
		          return;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar6);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f5404;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar6 = global_1;
		        goto code_r0x820f52d8;
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x1a,&local_2c);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) goto code_r0x820f52d8;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		code_r0x820f5404:
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5755", Offset = "0x5755", VA = "0x5755")]
		public void Cancel()
		{
		/* --- GHIDRA: Cancel ---
		undefined4 Utils_OpTokenRepository__Cancel(undefined4 param1)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a62813 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_Resources__RewardTypes___RewardTypes__Resources___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_Resources__RewardTypes___Resources__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_Resources__RewardTypes___RewardTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_ResourceRewardsUtils___c__GetRewardToResourceDict_b__1_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_ResourceRewardsUtils___c__GetRewardToResourceDict_b__1_1__);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils___c_TypeInfo);
		    DAT_ram_00a62813 = '\x01';
		  }
		  if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		  }
		  uVar1 = **(undefined4 **)(Utils_ResourceRewardsUtils_TypeInfo + 0x5c);
		  if (*(int *)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  param1_00 = Utils_ResourceRewardsUtils___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_ResourceRewardsUtils___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar2;
		    param1_01 = unnamed_function_1417
		                          (System_Func_KeyValuePair_Resources__RewardTypes___RewardTypes__TypeInfo);
		    System_Func_KeyValuePair_Int32Enum__int___uint___Invoke
		              (param1_01,uVar3,
		               Method_Utils_ResourceRewardsUtils___c__GetRewardToResourceDict_b__1_0__,0);
		    param1_00 = Utils_ResourceRewardsUtils___c_TypeInfo;
		    *(int *)(*(int *)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Utils_ResourceRewardsUtils___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_02 = puVar2[2];
		  if (param1_02 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar2 = *(undefined4 **)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar2;
		    param1_02 = unnamed_function_1417
		                          (System_Func_KeyValuePair_Resources__RewardTypes___Resources__TypeInfo);
		    System_Func_KeyValuePair_Int32Enum__int___uint___Invoke
		              (param1_02,uVar3,
		               Method_Utils_ResourceRewardsUtils___c__GetRewardToResourceDict_b__1_1__,0);
		    *(int *)(*(int *)(Utils_ResourceRewardsUtils___c_TypeInfo + 0x5c) + 8) = param1_02;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_KeyValuePair_int__int___int__int_
		                    (uVar1,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_Resources__RewardTypes___RewardTypes__Resources___
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x8")]
		private readonly LinkedList<IOpToken> _tokens;
	}
}
