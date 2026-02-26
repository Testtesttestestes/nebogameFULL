using System;
using System.Threading;
using Animations;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x20001A5")]
	public class ArtifactViewAnimationHandler
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x5EA1", Offset = "0x5EA1", VA = "0x5EA1")]
		public UniTask HandleAnimation(IAnimationProvider provider, Transform target)
		{
		/* --- GHIDRA: HandleAnimation ---
		void UI_Rewards_Renderers_ArtifactViewAnimationHandler__HandleAnimation
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,uint param5
		               ,undefined4 param6)
		
		{
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 uStack_10;
		  ulonglong local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59a27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__1___
		              );
		    DAT_ram_00a59a27 = '\x01';
		  }
		  local_4 = 0;
		  local_c = (ulonglong)param5;
		  local_1c = 0;
		  local_20 = 0xffffffff;
		  _local_14 = CONCAT44(param4,param3);
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__1___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__1___
		              );
		  }
		  System_Threading_CancellationToken__get_IsCancellationRequested(&local_20,auStack_30);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_28,&local_1c,0);
		  *param1 = local_28;
		  return;
		}
		*/

		/* --- GHIDRA: HandleAnimation ---
		void UI_Rewards_Renderers_ArtifactViewAnimationHandler__HandleAnimation
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,uint param5
		               ,undefined4 param6)
		
		{
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 uStack_10;
		  ulonglong local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59a27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__1___
		              );
		    DAT_ram_00a59a27 = '\x01';
		  }
		  local_4 = 0;
		  local_c = (ulonglong)param5;
		  local_1c = 0;
		  local_20 = 0xffffffff;
		  _local_14 = CONCAT44(param4,param3);
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__1___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__1___
		              );
		  }
		  System_Threading_CancellationToken__get_IsCancellationRequested(&local_20,auStack_30);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_28,&local_1c,0);
		  *param1 = local_28;
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x5EA2", Offset = "0x5EA2", VA = "0x5EA2")]
		public UniTask HandleAnimation(IAnimationProvider provider, Transform target, CancellationToken token)
		{
			return default(UniTask);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x5EA3", Offset = "0x5EA3", VA = "0x5EA3")]
		public ArtifactViewAnimationHandler()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_ArtifactViewAnimationHandler___ctor(int *param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 *param2_00;
		  short sVar6;
		  int *piVar7;
		  int iVar8;
		  uint uVar9;
		  undefined8 local_18;
		  undefined8 local_10;
		  float4 local_4;
		  
		  if (DAT_ram_00a59a28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__ArtifactViewAnimationHandler__HandleAnimation_d__0___
		              );
		    Mono_Security_ASN1__get_Item(&Animations_IAnimationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a59a28 = '\x01';
		  }
		  local_4 = 0.0;
		  local_10 = 0;
		  if (*param1 == 0) {
		    local_10 = *(undefined8 *)(param1 + 5);
		    *param1 = -1;
		    param1[5] = 0;
		    param1[6] = 0;
		    sVar6 = (short)((ulonglong)local_10 >> 0x20);
		    piVar7 = (int *)local_10;
		    goto code_r0x810adbe5;
		  }
		  uVar9 = 0;
		  iVar8 = param1[4];
		  piVar7 = (int *)param1[3];
		  iVar5 = *piVar7;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Animations_IAnimationProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		        puVar2 = (undefined4 *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		        ;
		        goto code_r0x810ad890;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar2 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                      Animations_IAnimationProvider_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x810addc3:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x810ad890:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiiii(*puVar2,piVar7,iVar8,&local_4,puVar2[1]);
		    fVar1 = local_4;
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) goto code_r0x810addc3;
		    if (iVar5 == 0) goto code_r0x810add15;
		    if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Cysharp_Threading_Tasks_UniTask_TypeInfo);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) goto code_r0x810ad923;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		code_r0x810ad923:
		      DAT_ram_009d3e38 = 0;
		      if (ABS((float)fVar1 * 1000.0) < 2.1474836e+09) {
		        iVar8 = (int)((float)fVar1 * 1000.0);
		      }
		      else {
		        iVar8 = -0x80000000;
		      }
		      import::env::invoke_viiiiii
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x70,&local_18,iVar8,0,8,0,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        local_10 = local_18;
		        if (DAT_ram_00a63a11 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a63a11 = '\x01';
		            goto code_r0x810ad9cd;
		          }
		        }
		        else {
		code_r0x810ad9cd:
		          if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Cysharp_Threading_Tasks_UniTask_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x810adbb1;
		          }
		          if (DAT_ram_00a63a12 == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x810adbb1;
		            DAT_ram_00a63a12 = '\x01';
		          }
		          DAT_ram_009d3e38 = 0;
		          sVar6 = (short)((ulonglong)local_18 >> 0x20);
		          piVar7 = (int *)local_18;
		          if (piVar7 == (int *)0x0) {
		            piVar7 = (int *)0x0;
		code_r0x810adbe5:
		            if (DAT_ram_00a63a13 == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		              iVar8 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar8 != 1) {
		                DAT_ram_00a63a13 = '\x01';
		                goto code_r0x810adc2a;
		              }
		            }
		            else {
		code_r0x810adc2a:
		              if (piVar7 == (int *)0x0) {
		code_r0x810add15:
		                *param1 = -2;
		                if (DAT_ram_00a63a15 == '\0') {
		                  Mono_Security_ASN1__get_Item
		                            (&
		                             Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                            );
		                  DAT_ram_00a63a15 = '\x01';
		                }
		                piVar7 = (int *)param1[1];
		                if (piVar7 == (int *)0x0) {
		                  return;
		                }
		                uVar9 = 0;
		                iVar8 = *piVar7;
		                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                  do {
		                    if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                        == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		                      puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8
		                                       + 0xd0);
		                      goto code_r0x810addb3;
		                    }
		                    uVar9 = uVar9 + 1;
		                  } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		                }
		                puVar4 = (uint *)func_ii_1080(piVar7,
		                                              Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                                              ,2);
		code_r0x810addb3:
		                (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		                return;
		              }
		              uVar9 = 0;
		              iVar8 = *piVar7;
		              if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                do {
		                  if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                      *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		                    puVar2 = (undefined4 *)
		                             (*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0xd0);
		                    goto code_r0x810adcc7;
		                  }
		                  uVar9 = uVar9 + 1;
		                } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		              }
		              DAT_ram_009d3e38 = 0;
		              puVar2 = (undefined4 *)
		                       import::env::invoke_iiii
		                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                                  Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,2);
		              if (DAT_ram_009d3e38 != 1) {
		code_r0x810adcc7:
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii(*puVar2,piVar7,(int)sVar6,puVar2[1]);
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar8 != 1) goto code_r0x810add15;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810addcb;
		          }
		          uVar9 = 0;
		          iVar8 = *piVar7;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		                puVar2 = (undefined4 *)
		                         (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x810adafe;
		              }
		              uVar9 = uVar9 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                              Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x810adafe:
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iiii(*puVar2,piVar7,(int)sVar6,puVar2[1]);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 != 1) {
		              if (iVar5 == 0) {
		                *(undefined8 *)(param1 + 5) = local_18;
		                *param1 = 0;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x72,param1 + 1,
		                           &local_10,param1,
		                           Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__ArtifactViewAnimationHandler__HandleAnimation_d__0___
		                          );
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar8 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  return;
		                }
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x810addcb;
		              }
		              goto code_r0x810adbe5;
		            }
		          }
		        }
		code_r0x810adbb1:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x810addcb:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    puVar2 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar3,
		                         *(undefined4 *)*puVar2);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar5 != 0) {
		          uVar3 = *puVar2;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          unnamed_function_126513(param1 + 1,uVar3);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar2;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810adef8;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x810adef8:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
