using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Extensions
{
	// Token: 0x02000F0A RID: 3850
	[Token(Token = "0x2000F0A")]
	public static class ICollectionExt
	{
		// Token: 0x06005D2C RID: 23852 RVA: 0x00010C98 File Offset: 0x0000EE98
		[Token(Token = "0x6005D2C")]
		public static bool ContainsAny<T>(this ICollection<T> collection, IEnumerable<T> values)
		{
		/* --- GHIDRA: ContainsAny<__Il2CppFullySharedGenericType> ---
		float Core_Extensions_ICollectionExt__ContainsAny___Il2CppFullySharedGenericType_
		                (undefined4 param1,undefined4 param2,int param3)
		
		{
		  float fVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  iVar2 = System_Linq_Enumerable__OrderBy_object__ulong_(param1,*(undefined4 *)(iVar2 + 4));
		  if (iVar2 == 0) {
		    fVar1 = 0.0;
		  }
		  else {
		    fVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType_
		                      (param1,param2,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0xc));
		  }
		  return fVar1;
		}
		*/

		/* --- GHIDRA: ContainsAny<uint> ---
		int Core_Extensions_ICollectionExt__ContainsAny_uint_(int *param1,int *param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  undefined4 *param6;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  int *piVar9;
		  int iVar10;
		  int local_20 [4];
		  int **local_10;
		  int *local_c;
		  undefined4 *local_8;
		  byte local_1;
		  
		  piVar4 = *(int **)(param3 + 0x1c);
		  if (piVar4 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    piVar4 = *(int **)(param3 + 0x1c);
		    if (piVar4 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      piVar4 = *(int **)(param3 + 0x1c);
		    }
		  }
		  iVar7 = *(int *)(piVar4[4] + 0x84);
		  uVar8 = iVar7 + 0xfU & 0xfffffff0;
		  param6 = (undefined4 *)((int)local_20 - uVar8);
		  iVar5 = *piVar4;
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar5 == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8206bd2b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,iVar5,0);
		code_r0x8206bd2b:
		  local_c = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_20[3] = 0;
		  local_10 = &local_c;
		  do {
		    piVar4 = local_c;
		    iVar5 = *local_c;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar5 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8206bdfb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8206be47:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8206c0e4:
		      iVar5 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar7) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar7 = *piVar4;
		        iVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_20[3] = iVar7;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) goto code_r0x8206c131;
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Vector_ram_00003fea + 9,local_20 + 3);
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
		code_r0x8206bdfb:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar3,piVar4,puVar3[1]);
		    piVar4 = local_c;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206be47;
		    if (iVar5 == 0) {
		      iVar7 = 0;
		      iVar5 = 0;
		      goto code_r0x8206c131;
		    }
		    iVar10 = *(int *)(*(int *)(param3 + 0x1c) + 8);
		    if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar10)
		      ;
		      if (DAT_ram_009d3e38 != 1) goto code_r0x8206be9f;
		code_r0x8206c0d2:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8206c0e4;
		    }
		code_r0x8206be9f:
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (iVar10 == *piVar9) {
		          iVar10 = iVar6 + piVar9[1] * 8 + 0xc0;
		          goto code_r0x8206bf25;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,iVar10,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206c0d2;
		code_r0x8206bf25:
		    iVar10 = *(int *)(iVar10 + 4);
		    DAT_ram_009d3e38 = 0;
		    local_8 = param6;
		    import::env::invoke_viiiii
		              (*(undefined4 *)(iVar10 + 8),*(undefined4 *)(iVar10 + 4),iVar10,piVar4,&local_8,param6
		              );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) goto code_r0x8206c0d2;
		    piVar4 = (int *)unnamed_function_713((int)param6 - uVar8,param6,iVar7);
		    iVar6 = *(int *)(param3 + 0x1c);
		    iVar10 = *(int *)(iVar6 + 0x14);
		    if ((*(byte *)(iVar10 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar10)
		      ;
		      if (DAT_ram_009d3e38 != 1) {
		        iVar6 = *(int *)(param3 + 0x1c);
		        goto code_r0x8206bfcc;
		      }
		code_r0x8206c0dc:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8206c0e4;
		    }
		code_r0x8206bfcc:
		    if (-1 < *(int *)(*(int *)(iVar6 + 0x10) + 0x14)) {
		      piVar4 = (int *)*piVar4;
		    }
		    iVar6 = *param1;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (iVar10 == *piVar9) {
		          iVar10 = piVar9[1] * 8 + iVar6 + 0xe0;
		          goto code_r0x8206c06f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param1,iVar10,4);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206c0dc;
		code_r0x8206c06f:
		    iVar10 = *(int *)(iVar10 + 4);
		    DAT_ram_009d3e38 = 0;
		    local_8 = piVar4;
		    import::env::invoke_viiiii
		              (*(undefined4 *)(iVar10 + 8),*(undefined4 *)(iVar10 + 4),iVar10,param1,&local_8,
		               &local_1);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8206c0dc;
		  } while (local_1 == 0);
		  iVar7 = 0;
		code_r0x8206c131:
		  piVar4 = local_c;
		  DAT_ram_009d3e38 = 0;
		  if (local_c != (int *)0x0) {
		    uVar8 = 0;
		    iVar10 = *local_c;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8206c1a9;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x8206c1a9:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  }
		  if (iVar7 == 0) {
		    return iVar5;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}
	}
}
