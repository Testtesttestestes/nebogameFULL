using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Utils.Timers
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public class DelayedCall : IDisposable
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000D")]
		private event Action Callback
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x5785", Offset = "0x5785", VA = "0x5785")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x5786", Offset = "0x5786", VA = "0x5786")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5787", Offset = "0x5787", VA = "0x5787")]
		public DelayedCall(Action callback)
		{
		/* --- GHIDRA: .ctor ---
		void Utils_Timers_DelayedCall___ctor(undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a62837 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a62837 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2,0);
		  Utils_Timers_DelayedCall__SetDelay(param1,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x5788", Offset = "0x5788", VA = "0x5788")]
		public void SetDelay(float seconds)
		{
		/* --- GHIDRA: SetDelay ---
		void Utils_Timers_DelayedCall__SetDelay(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if ((*(int *)(param1 + 0x10) != 0) &&
		     (iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(*(int *)(param1 + 0x10),0),
		     iVar1 == 0)) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(param1 + 0x10),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x10),0);
		  }
		  return;
		}
		*/

		/* --- GHIDRA: SetDelay ---
		void Utils_Timers_DelayedCall__SetDelay(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if ((*(int *)(param1 + 0x10) != 0) &&
		     (iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(*(int *)(param1 + 0x10),0),
		     iVar1 == 0)) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(param1 + 0x10),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x10),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5789", Offset = "0x5789", VA = "0x5789")]
		public void SetDelay(BackTime backTime)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x578A", Offset = "0x578A", VA = "0x578A")]
		public void Cancel()
		{
		/* --- GHIDRA: Cancel ---
		void Utils_Timers_DelayedCall__Cancel(undefined1 *param1,uint param2,uint param3,undefined4 param4)
		
		{
		  undefined4 local_1c;
		  longlong local_18;
		  ulonglong local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62839 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_DelayedCall__DelayedCallAsync_d__9___
		              );
		    DAT_ram_00a62839 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (ulonglong)param2;
		  local_1c = 0xffffffff;
		  local_18 = (ulonglong)param3 << 0x20;
		  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_AbstractGameTextureLoader__ProcessAssetBundle_d__4_
		            (&local_18,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_Start_DelayedCall__DelayedCallAsync_d__9___
		            );
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x578B", Offset = "0x578B", VA = "0x578B")]
		private UniTaskVoid DelayedCallAsync(CancellationToken token)
		{
		/* --- GHIDRA: DelayedCallAsync ---
		void Utils_Timers_DelayedCall__DelayedCallAsync(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 8) = 0;
		  if ((*(int *)(param1 + 0x10) != 0) &&
		     (iVar1 = System_Collections_Generic_LinkedList_object___AddFirst(*(int *)(param1 + 0x10),0),
		     iVar1 == 0)) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(undefined4 *)(param1 + 0x10),0);
		    System_Threading_CancellationTokenSource__Cancel(*(undefined4 *)(param1 + 0x10),0);
		  }
		  return;
		}
		*/

			return default(UniTaskVoid);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x578C", Offset = "0x578C", VA = "0x578C", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_Timers_DelayedCall__Dispose(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined8 uVar3;
		  int *param2_00;
		  float fVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  undefined4 *param2_01;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  param2_00 = (int *)0x0;
		  uVar6 = 0;
		  if (DAT_ram_00a6283a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__DelayedCall__DelayedCallAsync_d__9___
		              );
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationToken_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a6283a = '\x01';
		  }
		  local_8 = 0;
		  iVar8 = param1[3];
		  iVar9 = *param1;
		  if (iVar9 != 0) {
		    param1[4] = 1000;
		  }
		  else {
		    local_8 = *(undefined8 *)(param1 + 5);
		    *param1 = -1;
		    param1[5] = 0;
		    param1[6] = 0;
		    uVar6 = (undefined4)((ulonglong)local_8 >> 0x20);
		    param2_00 = (int *)local_8;
		  }
		  bVar1 = iVar9 == 0;
		code_r0x820f78f8:
		  while (bVar1) {
		    if (DAT_ram_00a63a13 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x820f7e09;
		      DAT_ram_00a63a13 = '\x01';
		    }
		    if (param2_00 != (int *)0x0) {
		      uVar10 = 0;
		      iVar9 = *param2_00;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		              *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		            puVar7 = (undefined4 *)
		                     (*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0xd0);
		            goto code_r0x820f7ce9;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_00,
		                          Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,2);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x820f7ce9:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(*puVar7,param2_00,(int)(short)uVar6,puVar7[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f7d31;
		      }
		code_r0x820f7e09:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f7e1b;
		    }
		code_r0x820f7d31:
		    if (*(int *)(System_Threading_CancellationToken_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 System_Threading_CancellationToken_TypeInfo);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x820f7e1b;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = func_ii_8047(param1 + 2,0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f7e1b;
		    }
		    if (iVar5 != 0) goto code_r0x820f7f53;
		    bVar1 = false;
		  }
		  DAT_ram_009d3e38 = 0;
		  fVar4 = import::env::invoke_fii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,
		                     *(undefined4 *)(iVar8 + 0xc),0);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (fVar4 <= 0.0) {
		      iVar8 = *(int *)(iVar8 + 8);
		      if (iVar8 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (*(undefined4 *)(iVar8 + 0xc),*(undefined4 *)(iVar8 + 0x20),
		                   *(undefined4 *)(iVar8 + 0x14));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x820f7e09;
		      }
		code_r0x820f7f53:
		      DAT_ram_009d3e38 = 0;
		      *param1 = -2;
		      unnamed_function_118874(param1 + 1);
		      return;
		    }
		    iVar9 = param1[2];
		    iVar5 = param1[4];
		    if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Cysharp_Threading_Tasks_UniTask_TypeInfo);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x820f7e1b;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x70,&local_10,iVar5,1,0xe,iVar9,0)
		    ;
		    uVar3 = local_10;
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      local_8 = local_10;
		      uVar6 = (undefined4)((ulonglong)local_10 >> 0x20);
		      param2_00 = (int *)local_10;
		      if (DAT_ram_00a63a11 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a63a11 = '\x01';
		          goto code_r0x820f7a24;
		        }
		      }
		      else {
		code_r0x820f7a24:
		        if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Cysharp_Threading_Tasks_UniTask_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x820f7bfe;
		        }
		        if (DAT_ram_00a63a12 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x820f7bfe;
		          DAT_ram_00a63a12 = '\x01';
		        }
		        if (param2_00 == (int *)0x0) {
		          param2_00 = (int *)0x0;
		code_r0x820f7f4b:
		          bVar1 = true;
		          goto code_r0x820f78f8;
		        }
		        uVar10 = 0;
		        iVar9 = *param2_00;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		              puVar7 = (undefined4 *)
		                       (iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x820f7b4a;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,param2_00,
		                            Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x820f7b4a:
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iiii
		                            (*puVar7,param2_00,(int)(short)((ulonglong)uVar3 >> 0x20),puVar7[1]);
		          if (DAT_ram_009d3e38 != 1) {
		            if (iVar9 == 0) {
		              *(undefined8 *)(param1 + 5) = uVar3;
		              *param1 = 0;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x1d,param1 + 1,&local_8,
		                         param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__DelayedCall__DelayedCallAsync_d__9___
		                        );
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x820f7e1b;
		            }
		            goto code_r0x820f7f4b;
		          }
		        }
		      }
		code_r0x820f7bfe:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x820f7e1b:
		  iVar8 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar9) {
		    puVar7 = (undefined4 *)import::env::__cxa_begin_catch(uVar6);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar6,
		                         *(undefined4 *)*puVar7);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar9 != 0) {
		          uVar6 = *puVar7;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          unnamed_function_118873(param1 + 1,uVar6);
		          return;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar7;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f7f3c;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x820f7f3c:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xC")]
		private BackTime _backtime;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x10")]
		private CancellationTokenSource _source;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_Callback ---
		void Utils_Timers_DelayedCall__add_Callback(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a62836 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a62836 = '\x01';
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

}
