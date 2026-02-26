using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F24 RID: 3876
	[Token(Token = "0x2000F24")]
	public static class AssistantDictExt
	{
		// Token: 0x06005D94 RID: 23956 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D94")]
		[Address(RVA = "0xA9FE", Offset = "0xA9FE", VA = "0xA9FE")]
		public static string GetTitle(this AssistantsDic dict)
		{
		/* --- GHIDRA: GetTitle ---
		undefined4 Core_Extensions_Dict_AssistantDictExt__GetTitle(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x2c);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x6c) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D95")]
		[Address(RVA = "0xA9FF", Offset = "0xA9FF", VA = "0xA9FF")]
		public static string GetDescriptionTeaser(this AssistantsDic dict)
		{
		/* --- GHIDRA: GetDescriptionTeaser ---
		undefined4 Core_Extensions_Dict_AssistantDictExt__GetDescriptionTeaser(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x2c);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x6b) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D96")]
		[Address(RVA = "0xAA00", Offset = "0xAA00", VA = "0xAA00")]
		public static string GetDescriptionActive(this AssistantsDic dict)
		{
		/* --- GHIDRA: GetDescriptionActive ---
		double Core_Extensions_Dict_AssistantDictExt__GetDescriptionActive
		                 (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  double dVar6;
		  int *piVar7;
		  uint uVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar5 = 0;
		  dVar6 = 0.0;
		  if (DAT_ram_00a5ace4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CurrencyExtMoney__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CurrencyExtMoney__GetEnumerator__);
		    DAT_ram_00a5ace4 = '\x01';
		  }
		  if (*(int *)(param1 + 0x24) != 0) {
		    local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                               (*(int *)(param1 + 0x24),
		                                Method_Google_Protobuf_Collections_RepeatedField_CurrencyExtMoney__GetEnumerator__
		                               );
		    local_c = 0;
		    local_8 = &local_4;
		    do {
		      piVar2 = local_4;
		      iVar4 = *local_4;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		            puVar1 = (undefined4 *)(iVar4 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x812d07cf;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar1 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x812d08fc:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812d090e:
		        iVar5 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 == iVar4) {
		          piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		          iVar5 = *piVar2;
		          DAT_ram_009d3e38 = 0;
		          local_c = iVar5;
		          import::env::invoke_v(0x123);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) goto code_r0x812d0957;
		          param1_00 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x8d,&local_c);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(param1_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x812d07cf:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii(*puVar1,piVar2,puVar1[1]);
		      piVar2 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x812d08fc;
		      if (iVar4 == 0) goto code_r0x812d0957;
		      iVar4 = *local_4;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8);
		          if (System_Collections_Generic_IEnumerator_CurrencyExtMoney__TypeInfo == *piVar7) {
		            puVar1 = (undefined4 *)(iVar4 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x812d08aa;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar1 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_CurrencyExtMoney__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x812d0906:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x812d090e;
		      }
		code_r0x812d08aa:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii(*puVar1,piVar2,puVar1[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x812d0906;
		    } while (*(int *)(iVar4 + 0xc) != param2);
		    dVar6 = *(double *)(iVar4 + 0x10);
		code_r0x812d0957:
		    piVar2 = local_4;
		    DAT_ram_009d3e38 = 0;
		    if (local_4 != (int *)0x0) {
		      uVar8 = 0;
		      iVar4 = *local_4;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8)) {
		            puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x812d09cf;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		      }
		      puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x812d09cf:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    }
		    if (iVar5 != 0) {
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return dVar6;
		}
		*/

			return null;
		}
	}
}
