using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F08 RID: 3848
	[Token(Token = "0x2000F08")]
	public static class DictionaryExt
	{
		// Token: 0x06005D28 RID: 23848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005D28")]
		public static string ToDebugString<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
		/* --- GHIDRA: ToDebugString<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		int * Core_Extensions_DictionaryExt__ToDebugString___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                (int *param1,int *param2,int param3)
		
		{
		  undefined4 param4;
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 local_18;
		  undefined4 local_14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = *(int *)(param3 + 0x1c);
		  if (iVar6 == 0) {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    iVar6 = *(int *)(param3 + 0x1c);
		    if (iVar6 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      iVar6 = *(int *)(param3 + 0x1c);
		    }
		  }
		  iVar6 = *(int *)(iVar6 + 4);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar6 == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x813a4e00;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,iVar6,0);
		code_r0x813a4e00:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x813a4ece;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x813a515c:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x813a5164;
		    }
		code_r0x813a4ece:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x813a515c;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x813a51ad;
		    }
		    iVar6 = *(int *)(*(int *)(param3 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x813a4f5d;
		code_r0x813a5148:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x813a5164;
		    }
		code_r0x813a4f5d:
		    iVar8 = *piVar5;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (iVar6 == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x813a4fe3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,iVar6,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x813a5148;
		code_r0x813a4fe3:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar3,&local_18,piVar5,puVar3[1]);
		    param4 = local_14;
		    uVar4 = local_18;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x813a5148;
		    iVar6 = **(int **)(param3 + 0x1c);
		    if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    iVar8 = *param1;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (iVar6 == *piVar5) {
		          puVar3 = (undefined4 *)(piVar5[1] * 8 + iVar8 + 200);
		          goto code_r0x813a50fe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param1,iVar6,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x813a50fe:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii(*puVar3,param1,uVar4,param4,puVar3[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x813a5164:
		  iVar6 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar8) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar6 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x813a51ad:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x813a5225;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x813a5225:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        return param1;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x18a,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: ToDebugString<object, object> ---
		undefined4 Core_Extensions_DictionaryExt__ToDebugString_object__object_(int param1,int param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  
		  if (*(int *)(param2 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28745);
		    if (*(int *)(param2 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		    }
		  }
		  if (param1 == 0) {
		    return StringLiteral_28745;
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  param1_00 = StringLiteral_28547;
		  uVar2 = StringLiteral_1238;
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x5c) + 4);
		  if (iVar3 == 0) {
		    iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		    }
		    iVar4 = *(int *)(param2 + 0x1c);
		    iVar3 = *(int *)(iVar4 + 0xc);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		      iVar4 = *(int *)(param2 + 0x1c);
		    }
		    uVar1 = **(undefined4 **)(iVar3 + 0x5c);
		    iVar3 = *(int *)(iVar4 + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    iVar3 = unnamed_function_1417(iVar3);
		    puVar5 = *(uint **)(*(int *)(param2 + 0x1c) + 0x14);
		    (**(code **)((ulonglong)*puVar5 * 4))
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),puVar5);
		    iVar4 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    *(int *)(*(int *)(iVar4 + 0x5c) + 4) = iVar3;
		    iVar4 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar4);
		    }
		  }
		  puVar5 = *(uint **)(*(int *)(param2 + 0x1c) + 0x18);
		  uVar1 = (**(code **)((ulonglong)*puVar5 * 4))(param1,iVar3,puVar5);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_string___);
		  uVar2 = UnityEngine_Assertions_Assert__IsFalse(uVar2,uVar1,0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (param1_00,uVar2,StringLiteral_28773,0);
		  return uVar2;
		}
		*/

			return null;
		}
	}
}
