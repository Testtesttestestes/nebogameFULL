using System;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F7E RID: 3966
	[Token(Token = "0x2000F7E")]
	public static class MedalDicExt
	{
		// Token: 0x06005F54 RID: 24404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F54")]
		[Address(RVA = "0xAB9C", Offset = "0xAB9C", VA = "0xAB9C")]
		public static string GetIconAssetId(this MedalDic medalDic)
		{
		/* --- GHIDRA: GetIconAssetId ---
		undefined4 Core_Extensions_Dict_MedalDicExt__GetIconAssetId(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x5c);
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
		      if (*(int *)(iVar1 + 0xc) == 0x2f) {
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

		// Token: 0x06005F55 RID: 24405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x36E7", Offset = "0x36E7", VA = "0x36E7")]
		public static string GetTitle(this MedalDic medalDic)
		{
			return null;
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F56")]
		[Address(RVA = "0xAB9D", Offset = "0xAB9D", VA = "0xAB9D")]
		public static string GetDescription(this MedalDic medalDic)
		{
		/* --- GHIDRA: GetDescription ---
		int Core_Extensions_Dict_MedalDicExt__GetDescription
		              (int param1,int *param2,int param3,int param4,int *param5,undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 param1_00;
		  int *piVar10;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5ad7f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5ad7f = '\x01';
		  }
		  local_8 = (int *)0x0;
		  *param5 = 0;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param1 + 0x28),
		                              Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x812dd8ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812dd906:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812dda01:
		      iVar9 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        iVar9 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_10 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) goto code_r0x812dda4e;
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x90,&local_10);
		      goto joined_r0x812ddb36;
		    }
		code_r0x812dd8ba:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812dd906;
		    if (iVar9 == 0) {
		      iVar4 = 0;
		      iVar9 = 0;
		      goto code_r0x812dda4e;
		    }
		    iVar4 = *local_4;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar4 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x812dd9a9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812dd9f9:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x812dda01;
		    }
		code_r0x812dd9a9:
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812dd9f9;
		  } while (*(int *)(iVar4 + 0xc) != 0x68);
		  iVar4 = 0;
		code_r0x812dda4e:
		  piVar5 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x812ddac6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x812ddac6:
		    (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		  }
		  if (iVar4 != 0) {
		    System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (iVar9 != 0) {
		    uVar1 = 0;
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x812ddb7f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x812ddb7f:
		    uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		    iVar4 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                      (uVar3,*(undefined4 *)(param1 + 0xc),puVar6);
		    uVar3 = *(undefined4 *)(iVar4 + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar4 = Core_Extensions_Dict_RewardInfoExt__ToRewardDataArray(uVar3,0x68,0);
		    iVar4 = *(int *)(iVar4 + 0x10);
		    if (*(int *)(iVar4 + 0xc) != 1) {
		      local_8 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (iVar4,
		                                  Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                 );
		      local_10 = 0;
		      local_c = &local_8;
		      while( true ) {
		        piVar5 = local_8;
		        iVar4 = *local_8;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar2 = (undefined4 *)(iVar4 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x812ddd34;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x812ddd34:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_8;
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) break;
		        iVar4 = 0;
		        if (iVar8 == 0) goto code_r0x812de016;
		        iVar8 = *local_8;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar10) {
		              puVar2 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x812dde1d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x812ddf8a:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812ddfcd;
		        }
		code_r0x812dde1d:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x812ddf8a;
		        iVar8 = *param2;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar5) {
		              puVar2 = (undefined4 *)(piVar5[1] * 8 + iVar8 + 0xd8);
		              goto code_r0x812ddeee;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2,
		                            Core_Dict_IDictProvider_TypeInfo,3);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x812ddf94:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812ddfcd;
		        }
		code_r0x812ddeee:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar2,param2,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x812ddf94;
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ac,
		                           *(undefined4 *)(iVar8 + 0x14),uVar3,
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                          );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x812ddfcd;
		        }
		        *param5 = iVar7;
		        iVar8 = *(int *)(*(int *)(iVar7 + 0x10) + 0x14);
		        if (((iVar8 == param3) || (iVar8 == 0)) &&
		           ((iVar8 = *(int *)(*(int *)(iVar7 + 0x10) + 0x10), iVar8 == param4 || (iVar8 == 0))))
		        goto code_r0x812de016;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x812ddfcd:
		      iVar4 = global_1;
		      iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar8) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_10 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		code_r0x812de016:
		          piVar5 = local_8;
		          if (local_8 != (int *)0x0) {
		            uVar1 = 0;
		            iVar8 = *local_8;
		            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		                  puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x812de08e;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		            }
		            puVar6 = (uint *)func_ii_1080(local_8,System_IDisposable_TypeInfo,0);
		code_r0x812de08e:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar4 == 0) {
		            return iVar9;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x91,&local_10);
		joined_r0x812ddb36:
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = 0;
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd8);
		          goto code_r0x812ddc3c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x812ddc3c:
		    iVar8 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		    param1_00 = *(undefined4 *)(iVar8 + 0x14);
		    uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (iVar4,0,Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		    iVar4 = func_ii_7730(param1_00,uVar3,
		                         Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                        );
		    *param5 = iVar4;
		  }
		  return iVar9;
		}
		*/

			return null;
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x6005F57")]
		[Address(RVA = "0xAB9E", Offset = "0xAB9E", VA = "0xAB9E")]
		public static bool TryGetApr(this MedalDic medalDic, IDictProvider dict, uint cult, uint gender, out AprDicWrapper apr)
		{
		/* --- GHIDRA: TryGetApr ---
		undefined4
		Core_Extensions_Dict_MedalDicExt__TryGetApr(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Medals_Model_MedalDicGroupStorage___ctor(param2,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6005F58")]
		[Address(RVA = "0xAB9F", Offset = "0xAB9F", VA = "0xAB9F")]
		public static bool IsMedalHasRanks(this MedalDic medalDic, MedalDicGroupStorage medalDicGroupStorage)
		{
		/* --- GHIDRA: IsMedalHasRanks ---
		undefined4
		Core_Extensions_Dict_MedalDicExt__IsMedalHasRanks(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Medals_Model_MedalDicGroupStorage__IsMedalHasRanks
		                    (param2,*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6005F59")]
		[Address(RVA = "0xABA0", Offset = "0xABA0", VA = "0xABA0")]
		public static uint GetMaxRank(this MedalDic medalDic, MedalDicGroupStorage medalDicGroupStorage)
		{
		/* --- GHIDRA: GetMaxRank ---
		undefined4 Core_Extensions_Dict_MedalDicExt__GetMaxRank(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x18);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0x4c) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return 0U;
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x1E38", Offset = "0x1E38", VA = "0x1E38")]
		public static bool IsSetDiscount(this MedalDic dict)
		{
			return default(bool);
		}
	}
}
