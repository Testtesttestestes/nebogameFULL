using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Localization.Culture
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public static class Culture
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DB")]
		public static BaseCultureProvider Provider
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x5B6C", Offset = "0x5B6C", VA = "0x5B6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x5B6D", Offset = "0x5B6D", VA = "0x5B6D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x5B6E", Offset = "0x5B6E", VA = "0x5B6E")]
		public static UniTask Initialization()
		{
		/* --- GHIDRA: Initialization ---
		void Localization_Culture_Culture__Initialization(int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 *param2_00;
		  int iVar7;
		  int iVar8;
		  undefined1 *puVar9;
		  int *piVar10;
		  undefined8 local_2c;
		  int local_24;
		  undefined8 local_20;
		  int local_18;
		  undefined8 local_10;
		  ushort local_8;
		  
		  if (DAT_ram_00a5b84e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_IPlatformConfigurationProvider___Culture__Initialization_d__5___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__GetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__get_IsCompleted__
		              );
		    Mono_Security_ASN1__get_Item(&Localization_Culture_WebGL_CultureProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Platforms_WebGL_PlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_IPlatformConfigurationProvider__GetAwaiter__)
		    ;
		    DAT_ram_00a5b84e = '\x01';
		  }
		  _local_8 = 0;
		  local_10 = 0;
		  if (*param1 == 0) {
		    _local_8 = param1[5];
		    local_10 = *(undefined8 *)(param1 + 3);
		    param1[3] = 0;
		    param1[4] = 0;
		    param1[5] = 0;
		    *param1 = -1;
		    piVar10 = (int *)local_10;
		code_r0x81386e05:
		    if (piVar10 == (int *)0x0) {
		code_r0x81386e0a:
		      uVar6 = local_10._4_4_;
		code_r0x81386f78:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Localization_Culture_WebGL_CultureProvider_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_0000223f + 0x161,uVar4,uVar6,param1);
		        if (DAT_ram_009d3e38 != 1) {
		          if (DAT_ram_00a5b8f4 != '\0') {
		code_r0x81387022:
		            DAT_ram_009d3e38 = 0;
		            puVar9 = *(undefined1 **)(Localization_Culture_Culture_TypeInfo + 0x5c);
		            *puVar9 = 1;
		            *(undefined4 *)(puVar9 + 4) = uVar4;
		            *param1 = -2;
		            if (DAT_ram_00a63a15 == '\0') {
		              Mono_Security_ASN1__get_Item
		                        (&
		                         Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                        );
		              DAT_ram_00a63a15 = '\x01';
		            }
		            piVar10 = (int *)param1[1];
		            if (piVar10 == (int *)0x0) {
		              return;
		            }
		            uVar2 = 0;
		            iVar7 = *piVar10;
		            if (*(ushort *)(iVar7 + 0xb6) != 0) {
		              do {
		                if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo ==
		                    *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		                  puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 +
		                                   0xd0);
		                  goto code_r0x813870d9;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		            }
		            puVar5 = (uint *)func_ii_1080(piVar10,
		                                          Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                                          ,2);
		code_r0x813870d9:
		            (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		            return;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Localization_Culture_Culture_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a5b8f4 = '\x01';
		            goto code_r0x81387022;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      uVar1 = local_8;
		      iVar7 = *(int *)(
		                      Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__GetResult__
		                      + 0x10);
		      if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar7)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81386e61;
		      }
		      else {
		code_r0x81386e61:
		        iVar7 = *(int *)(*(int *)(iVar7 + 0x60) + 0x14);
		        if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar7);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x813870e9;
		        }
		        iVar8 = *piVar10;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar7 == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x81386f32;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,iVar7,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81386f32:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_iiii(*puVar3,piVar10,(int)(short)uVar1,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81386f78;
		        }
		      }
		code_r0x813870e9:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    if (**(char **)(Localization_Culture_Culture_TypeInfo + 0x5c) != '\0') {
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_ii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                         &System_Exception_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar6);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &StringLiteral_5992);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26f,uVar6,uVar4,0);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::invoke_ii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                 &
		                                 Method_Localization_Culture_Culture__Initialization_d__5_MoveNext__
		                                );
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii(0x41b,uVar6,uVar4);
		                if (DAT_ram_009d3e38 != 1) goto code_r0x81387218;
		              }
		            }
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x813870fb;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar10 = (int *)import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                Platforms_WebGL_PlatformConfigurationProvider_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81386da7:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x15f,piVar10,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81386da7;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (*(undefined4 *)(*piVar10 + 0x118),&local_2c,piVar10,
		                 *(undefined4 *)(*piVar10 + 0x11c));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        local_18 = local_24;
		        local_20 = local_2c;
		        if ((*(byte *)(*(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_IPlatformConfigurationProvider__GetAwaiter__
		                               + 0x10) + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                     *(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_IPlatformConfigurationProvider__GetAwaiter__
		                             + 0x10));
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x813870fb;
		          }
		        }
		        _local_8 = local_18;
		        local_10 = local_20;
		        if ((*(byte *)(*(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__get_IsCompleted__
		                               + 0x10) + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                     *(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__get_IsCompleted__
		                             + 0x10));
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81386c0c;
		        }
		        else {
		code_r0x81386c0c:
		          if (DAT_ram_00a63c4a == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81386dc5;
		            DAT_ram_00a63c4a = '\x01';
		          }
		          piVar10 = (int *)local_10;
		          if ((int *)local_10 == (int *)0x0) goto code_r0x81386e0a;
		          uVar2 = 0;
		          uVar1 = local_8;
		          iVar7 = *(int *)local_10;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            do {
		              if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                  *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		                puVar3 = (undefined4 *)
		                         (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                goto code_r0x81386cfa;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_10
		                              ,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x81386cfa:
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iiii(*puVar3,piVar10,(int)(short)uVar1,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              if (iVar7 != 0) goto code_r0x81386e05;
		              *param1 = 0;
		              *(undefined8 *)(param1 + 3) = local_10;
		              param1[5] = _local_8;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 0x160,param1 + 1,
		                         &local_10,param1,
		                         Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_IPlatformConfigurationProvider___Culture__Initialization_d__5___
		                        );
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x813870fb;
		            }
		          }
		        }
		code_r0x81386dc5:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x813870fb:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar6);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar6,
		                         *(undefined4 *)*puVar3);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar8 != 0) {
		          uVar6 = *puVar3;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          unnamed_function_126513(param1 + 1,uVar6);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81387218;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81387218:
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

			return default(UniTask);
		}

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _isInitialized;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Provider ---
		void Localization_Culture_Culture__get_Provider(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b84c == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a5b84c = '\x01';
		  }
		  *(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4) = param1;
		  return;
		}
		*/


		/* --- GHIDRA: set_Provider ---
		void Localization_Culture_Culture__set_Provider(undefined8 *param1,undefined4 param2)
		
		{
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b84d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Culture__Initialization_d__5___
		              );
		    DAT_ram_00a5b84d = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  local_14 = 0;
		  local_18 = 0xffffffff;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Culture__Initialization_d__5___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_Culture__Initialization_d__5___
		              );
		  }
		  Localization_Culture_Culture__Initialization(&local_18,&local_20);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_20,&local_14,0);
		  *param1 = local_20;
		  return;
		}
		*/

}
