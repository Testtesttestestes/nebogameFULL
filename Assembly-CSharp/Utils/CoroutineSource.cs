using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class CoroutineSource : MonoBehaviour
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x56D7", Offset = "0x56D7", VA = "0x56D7")]
		private static CoroutineSource GetMono()
		{
		/* --- GHIDRA: GetMono ---
		undefined4 Utils_CoroutineSource__GetMono(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Utils_CommandsRepository__Dispose(param1);
		  uVar1 = UnityEngine_MonoBehaviour__StartCoroutine(uVar1,param1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x56D8", Offset = "0x56D8", VA = "0x56D8")]
		public static Coroutine StartCoroutine(IEnumerator routine)
		{
		/* --- GHIDRA: StartCoroutine ---
		void Utils_CoroutineSource__StartCoroutine(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a648e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineSource_TypeInfo);
		    DAT_ram_00a648e4 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (**(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c),0);
		  if (iVar1 != 0) {
		    UnityEngine_MonoBehaviour__StartCoroutine_Auto
		              (**(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c),param1,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x56D9", Offset = "0x56D9", VA = "0x56D9")]
		public static void StopCoroutine(IEnumerator routine)
		{
		/* --- GHIDRA: StopCoroutine ---
		void Utils_CoroutineSource__StopCoroutine(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineSource_TypeInfo);
		    DAT_ram_00a648e6 = '\x01';
		  }
		  **(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: StopCoroutine ---
		void Utils_CoroutineSource__StopCoroutine(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineSource_TypeInfo);
		    DAT_ram_00a648e6 = '\x01';
		  }
		  **(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1F0F", Offset = "0x1F0F", VA = "0x1F0F")]
		public static void StopCoroutine(Coroutine routine)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x56DA", Offset = "0x56DA", VA = "0x56DA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x56DB", Offset = "0x56DB", VA = "0x56DB")]
		public CoroutineSource()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Utils_CoroutineSource___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint *puVar6;
		  int iVar7;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a648e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18077);
		    DAT_ram_00a648e7 = '\x01';
		  }
		  local_4 = (int *)System_Security_Cryptography_MD5___ctor(0);
		  DAT_ram_009d3e38 = 0;
		  local_c = 0;
		  local_8 = &local_4;
		  piVar3 = (int *)import::env::invoke_ii(s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x34c,0);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (*(undefined4 *)(*piVar3 + 0x158),piVar3,param1,
		                       *(undefined4 *)(*piVar3 + 0x15c));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e5,local_4,uVar4,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        piVar3 = (int *)import::env::invoke_ii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                   System_Text_StringBuilder_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e1,piVar3,0);
		          if (DAT_ram_009d3e38 != 1) {
		            if (0 < *(int *)(iVar5 + 0xc)) {
		              iVar7 = 0;
		              do {
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iiii
		                                  (s___Scripting__UnityEngine__Compon_ram_00003f1f + 0x15,
		                                   iVar7 + iVar5 + 0x10,StringLiteral_18077,0);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x825a549d;
		                }
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_iiii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,piVar3,uVar4,0);
		                iVar1 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x825a549d;
		                }
		                iVar7 = iVar7 + 1;
		              } while (iVar7 < *(int *)(iVar5 + 0xc));
		            }
		            iVar5 = 0;
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_iii
		                              (*(undefined4 *)(*piVar3 + 0xd8),piVar3,
		                               *(undefined4 *)(*piVar3 + 0xdc));
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 != 1) goto code_r0x825a54ea;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x825a549d;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x825a549d:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar5 = *piVar3;
		    uVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar5;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x825a54ea:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar2 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x825a5562;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x825a5562:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		      }
		      if (iVar5 == 0) {
		        return uVar4;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Player_ram_00004bb3 + 7,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x0")]
		private static CoroutineSource _coroutineSource;
	}
}
