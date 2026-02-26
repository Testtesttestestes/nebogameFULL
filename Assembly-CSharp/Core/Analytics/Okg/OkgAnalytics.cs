using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics.Okg.Data;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Core.Analytics.Okg
{
	// Token: 0x020012A1 RID: 4769
	[Token(Token = "0x20012A1")]
	public class OkgAnalytics : IOkgAnalytics, IDisposable
	{
		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700170C")]
		public static IOkgAnalytics Instance
		{
			[Token(Token = "0x600714D")]
			[Address(RVA = "0xBB68", Offset = "0xBB68", VA = "0xBB68")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600714E")]
		[Address(RVA = "0xBB69", Offset = "0xBB69", VA = "0xBB69")]
		public OkgAnalytics(bool restoreUserId = true, bool restoreUserLevel = true, bool restoreEventTimestamps = true, bool restoreIsTempUserId = true)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Okg_OkgAnalytics___ctor
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *param2_00;
		  undefined4 *puVar3;
		  int iVar4;
		  int param2_01;
		  undefined4 param2_02;
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  int local_10;
		  int local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__object___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__object___string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics___c__LogEvent_b__29_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics___c__LogEvent_b__29_1__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		    DAT_ram_00a594e3 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    Core_Analytics_Okg_OkgAnalytics__Dispose(param1,0);
		  }
		  if (*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) goto code_r0x810168bc;
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x810168bc:
		    puVar3 = *(undefined4 **)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c);
		    iVar4 = puVar3[2];
		    iVar2 = Core_Analytics_Okg_OkgAnalytics___c_TypeInfo;
		    if (iVar4 == 0) {
		      if (*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          puVar3 = *(undefined4 **)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c);
		          goto code_r0x8101690d;
		        }
		code_r0x81016a12:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		code_r0x8101690d:
		        uVar1 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_KeyValuePair_string__object___string__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ed,iVar4,uVar1,
		                     Method_Core_Analytics_Okg_OkgAnalytics___c__LogEvent_b__29_0__,0);
		          iVar2 = Core_Analytics_Okg_OkgAnalytics___c_TypeInfo;
		          if (DAT_ram_009d3e38 != 1) {
		            *(int *)(*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c) + 8) = iVar4;
		            goto code_r0x81016991;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		    else {
		code_r0x81016991:
		      if (*(int *)(iVar2 + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar2);
		        iVar2 = Core_Analytics_Okg_OkgAnalytics___c_TypeInfo;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81016a12;
		      }
		      puVar3 = *(undefined4 **)(iVar2 + 0x5c);
		      param2_01 = puVar3[3];
		      if (param2_01 == 0) {
		        if (*(int *)(iVar2 + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,iVar2);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81016a12;
		          puVar3 = *(undefined4 **)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c);
		        }
		        uVar1 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        param2_01 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Func_KeyValuePair_string__object___object__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ed,param2_01,uVar1,
		                     Method_Core_Analytics_Okg_OkgAnalytics___c__LogEvent_b__29_1__,0);
		          if (DAT_ram_009d3e38 != 1) {
		            *(int *)(*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c) + 0xc) =
		                 param2_01;
		            goto code_r0x81016ab8;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		code_r0x81016ab8:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ee,param3,iVar4,
		                           param2_01,
		                           Method_System_Linq_Enumerable_ToDictionary_KeyValuePair_string__object___string__object___
		                          );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          *(undefined4 *)(param2 + 0x40) = uVar1;
		          if (DAT_ram_00a594f4 == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (0x7ff,&
		                             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__DoLogEvent_d__47___
		                      );
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_00a594f4 = '\x01';
		              goto code_r0x81016b40;
		            }
		          }
		          else {
		code_r0x81016b40:
		            local_8 = 0;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ef,&local_34,0);
		            if (DAT_ram_009d3e38 != 1) {
		              local_18 = local_2c;
		              local_20 = local_34;
		              local_24 = 0xffffffff;
		              DAT_ram_009d3e38 = 0;
		              local_10 = param1;
		              local_c = param2;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f0,&local_20,&local_24
		                         ,
		                         Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__DoLogEvent_d__47___
		                        );
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		      }
		    }
		  }
		  iVar2 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar4) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar3);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        if (iVar4 != 0) {
		          param2_02 = *puVar3;
		          import::env::__cxa_end_catch();
		          uVar1 = unnamed_function_2232(&StringLiteral_11877);
		          uVar1 = func_ii_4419(uVar1,param2_02,0);
		          iVar2 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar2 + 0x74) == 0) {
		            func_ii_306000(iVar2);
		          }
		          func_ii_7109(uVar1,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81016d46;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81016d46:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600714F")]
		[Address(RVA = "0xBB6A", Offset = "0xBB6A", VA = "0xBB6A", Slot = "4")]
		public void LogEvent(OkgAnalyticsData eventHeader, IReadOnlyDictionary<string, object> data)
		{
		/* --- GHIDRA: LogEvent ---
		void Core_Analytics_Okg_OkgAnalytics__LogEvent(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a594e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder_TypeInfo);
		    DAT_ram_00a594e4 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    Core_Analytics_Okg_OkgAnalytics__Dispose(param1,param1);
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param1_00 + 0xb8)) &&
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) * 4 + -4) ==
		        Core_Analytics_Okg_TempLogBuilder_TypeInfo)) {
		      Core_Analytics_Okg_TempLogBuilder__ToString(param1_00,param2,param1);
		      *(uint *)(param1 + 0x10) = *(uint *)(param1 + 0x10) | 1;
		      Core_Analytics_Okg_OkgAnalytics__GetByteIterator(param1,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007150")]
		[Address(RVA = "0xBB6B", Offset = "0xBB6B", VA = "0xBB6B", Slot = "5")]
		public void SetUserId(long userId)
		{
		/* --- GHIDRA: SetUserId ---
		void Core_Analytics_Okg_OkgAnalytics__SetUserId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a594e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1348);
		    DAT_ram_00a594e5 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    Core_Analytics_Okg_OkgAnalytics__Dispose(param1,param1);
		  }
		  if ((*(byte *)(param1 + 0x10) & 2) == 0) {
		    param1_00 = *(int **)(param1 + 0xc);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*param1_00 + 0xb8)) &&
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) * 4 + -4) ==
		          Core_Analytics_Okg_TempLogBuilder_TypeInfo)) {
		        Core_Analytics_Okg_TempLogBuilder__SetUserId(param1_00,param2,param1);
		        *(uint *)(param1 + 0x10) = *(uint *)(param1 + 0x10) | 2;
		        Core_Analytics_Okg_OkgAnalytics__GetByteIterator(param1,param1);
		      }
		    }
		  }
		  else if (*(char *)(param1 + 0x45) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_1348,0);
		    return;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007151 RID: 29009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007151")]
		[Address(RVA = "0xBB6C", Offset = "0xBB6C", VA = "0xBB6C", Slot = "6")]
		public void SetUserLevel(int userLevel)
		{
		/* --- GHIDRA: SetUserLevel ---
		undefined4
		Core_Analytics_Okg_OkgAnalytics__SetUserLevel(int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1350);
		    DAT_ram_00a594e6 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    Core_Analytics_Okg_OkgAnalytics__Dispose(param1,param1);
		  }
		  iVar1 = Core_Analytics_Okg_TempLogBuilder_TypeInfo;
		  if ((*(byte *)(param1 + 0x10) & 4) == 0) {
		    uVar2 = 0;
		    param1_00 = *(int **)(param1 + 0xc);
		    if (param1_00 != (int *)0x0) {
		      uVar2 = 0;
		      if (((uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*param1_00 + 0xb8)) &&
		         (iVar4 = *(int *)(*(int *)(*param1_00 + 100) +
		                           (uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) * 4 +
		                          -4), iVar4 == Core_Analytics_Okg_TempLogBuilder_TypeInfo)) {
		        if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Math_TypeInfo);
		        }
		        if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_TimeSpan_TypeInfo);
		        }
		        local_8 = func_ii_11542(1.0,0);
		        dVar3 = System_Net_FtpMethodInfo__GetMethodInfo(&local_8,0);
		        if (dVar3 < ABS((double)param2)) {
		          if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_Math_TypeInfo);
		          }
		          if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_TimeSpan_TypeInfo);
		          }
		          local_10 = func_ii_7125(ABS((double)param2),0);
		          uVar2 = func_ii_1081(System_TimeSpan_TypeInfo,&local_10);
		          uVar2 = func_ii_4419(StringLiteral_1350,uVar2,0);
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            func_ii_306000(OKG_Logs_Debug_TypeInfo);
		          }
		          func_ii_7109(uVar2,0);
		          *(uint *)(param1 + 0x10) = *(uint *)(param1 + 0x10) | 4;
		        }
		        else {
		          if (iVar4 != iVar1) {
		            param1_00 = (int *)0x0;
		          }
		          Core_Analytics_Okg_TempLogBuilder__SetUserLevel(param1_00,param2,param1);
		          *(uint *)(param1 + 0x10) = *(uint *)(param1 + 0x10) | 4;
		          Core_Analytics_Okg_OkgAnalytics__GetByteIterator(param1,param1);
		        }
		        uVar2 = 1;
		      }
		    }
		  }
		  else {
		    uVar2 = 1;
		    if (*(char *)(param1 + 0x46) != '\0') {
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(StringLiteral_1349,0);
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06007152 RID: 29010 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x6007152")]
		[Address(RVA = "0xBB6D", Offset = "0xBB6D", VA = "0xBB6D", Slot = "8")]
		public bool SetServerTimeOffset(long deltaTimeMs)
		{
		/* --- GHIDRA: SetServerTimeOffset ---
		void Core_Analytics_Okg_OkgAnalytics__SetServerTimeOffset(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a594e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1347);
		    DAT_ram_00a594e7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x34) == '\0') {
		    Core_Analytics_Okg_OkgAnalytics__Dispose(param1,param1);
		  }
		  if ((*(byte *)(param1 + 0x10) & 8) == 0) {
		    param1_00 = *(int **)(param1 + 0xc);
		    if (param1_00 != (int *)0x0) {
		      if (((uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(*param1_00 + 0xb8)) &&
		         (*(int *)(*(int *)(*param1_00 + 100) +
		                   (uint)*(byte *)(Core_Analytics_Okg_TempLogBuilder_TypeInfo + 0xb8) * 4 + -4) ==
		          Core_Analytics_Okg_TempLogBuilder_TypeInfo)) {
		        Core_Analytics_Okg_TempLogBuilder__SetServerTimeOffset(param1_00,param2,param1);
		        if (param2 == 0) {
		          *(uint *)(param1 + 0x10) = *(uint *)(param1 + 0x10) | 8;
		        }
		        Core_Analytics_Okg_OkgAnalytics__GetByteIterator(param1,param1);
		      }
		    }
		  }
		  else if (*(char *)(param1 + 0x47) != '\0') {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_1347,0);
		    return;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007153")]
		[Address(RVA = "0xBB6E", Offset = "0xBB6E", VA = "0xBB6E", Slot = "7")]
		public void SetIsTempUserFlag(bool isTempUser)
		{
		/* --- GHIDRA: SetIsTempUserFlag ---
		undefined4 Core_Analytics_Okg_OkgAnalytics__SetIsTempUserFlag(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 *puVar5;
		  
		  if (DAT_ram_00a594e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19013);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19758);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19014);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25588);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25667);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24229);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26526);
		    DAT_ram_00a594e8 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Debug_TypeInfo);
		  }
		  iVar1 = UnityEngine_Debug__LogAssertionFormat(0);
		  uVar2 = unnamed_function_1417(System_Text_RegularExpressions_Regex_TypeInfo);
		  puVar5 = &StringLiteral_19013;
		  if (iVar1 == 0) {
		    puVar5 = &StringLiteral_19014;
		  }
		  System_Xml_Schema_FacetsChecker_FacetsCompiler__Preprocess(uVar2,*puVar5,0x10,0);
		  param1_00 = (int *)System_Text_RegularExpressions_Regex__Match(uVar2,param1,0);
		  iVar1 = Unity_Services_Core_Internal_UnityServicesInternal__InitializeAsync(param1_00,0);
		  if (iVar1 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		    iVar1 = System_Text_RegularExpressions_GroupCollection__get_IsReadOnly(uVar2,0);
		    if (iVar1 < 2) {
		      uVar3 = 0;
		    }
		    else {
		      uVar2 = 1;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		      uVar3 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                        (uVar3,1,0);
		      uVar3 = System_Text_RegularExpressions_Capture__set_Text(uVar3,0);
		      iVar1 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_24229,0);
		      if (iVar1 == 0) {
		        uVar2 = 2;
		        iVar1 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_19758,0);
		        if (iVar1 == 0) {
		          uVar2 = 3;
		          iVar1 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_25588,0);
		          if (iVar1 == 0) {
		            uVar2 = 5;
		            iVar1 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_26526,0);
		            if (iVar1 == 0) {
		              uVar2 = 6;
		              uVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_25667,0);
		              if (uVar4 == 0) {
		                uVar2 = 0;
		              }
		              uVar4 = uVar4 ^ 1;
		            }
		            else {
		              uVar4 = 0;
		            }
		          }
		          else {
		            uVar4 = 0;
		          }
		        }
		        else {
		          uVar4 = 0;
		        }
		      }
		      else {
		        uVar4 = 0;
		      }
		      if (*(int *)(UnityEngine_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Debug_TypeInfo);
		      }
		      iVar1 = UnityEngine_Debug__LogAssertionFormat(0);
		      uVar3 = 8;
		      if (iVar1 == 0) {
		        uVar3 = uVar2;
		      }
		      if (uVar4 == 0) {
		        uVar3 = uVar2;
		      }
		    }
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06007154 RID: 29012 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x6007154")]
		[Address(RVA = "0xBB6F", Offset = "0xBB6F", VA = "0xBB6F")]
		public static Build GetBuild(string version)
		{
		/* --- GHIDRA: GetBuild ---
		void Core_Analytics_Okg_OkgAnalytics__GetBuild(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a594e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics_ApplicationFocusHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics_ApplicationQuitHandler__);
		    DAT_ram_00a594e9 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar2,param1,Method_Core_Analytics_Okg_OkgAnalytics_ApplicationFocusHandler__,0);
		  Core_AppLoader__add_OnApplicationFocusEvent(uVar3,uVar2,0);
		  iVar1 = System_Uri___ctor(0);
		  uVar3 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Analytics_Okg_OkgAnalytics_ApplicationQuitHandler__,0);
		  Core_AppLoader__add_OnApplicationQuitEvent(uVar3,uVar2,0);
		  *(undefined1 *)(param1 + 0x34) = 0;
		  return;
		}
		*/

			return Build.undefined;
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007155")]
		[Address(RVA = "0xBB70", Offset = "0xBB70", VA = "0xBB70", Slot = "9")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		/* WARNING: Removing unreachable block (ram,0x81017662) */
		
		void Core_Analytics_Okg_OkgAnalytics__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  undefined4 *param2_00;
		  undefined8 uVar9;
		  longlong lVar10;
		  undefined4 uVar11;
		  uint uVar12;
		  undefined8 local_30;
		  undefined8 local_28;
		  int local_20;
		  int **local_1c;
		  int local_18;
		  int *local_14;
		  int *local_10;
		  int local_c;
		  undefined8 local_8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a594eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_byte___);
		    Mono_Security_ASN1__get_Item(&System_IO_FileInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ICSharpCode_SharpZipLib_GZip_GZipInputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_byte____int___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_byte____int____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ValueTuple_byte____int___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_LogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics_ApplicationFocusHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics_ApplicationQuitHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_byte____int___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15772);
		    DAT_ram_00a594eb = '\x01';
		  }
		  local_c = 0;
		  local_10 = (int *)0x0;
		  iVar2 = System_Uri___ctor(0);
		  uVar11 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar3,param1,Method_Core_Analytics_Okg_OkgAnalytics_ApplicationFocusHandler__,0);
		  Core_AppLoader__remove_OnApplicationQuitEvent(uVar11,uVar3,0);
		  iVar2 = System_Uri___ctor(0);
		  uVar11 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Core_Analytics_Okg_OkgAnalytics_ApplicationQuitHandler__,0);
		  Core_AppLoader__get_AppCanvas(uVar11,uVar3,0);
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  uVar9 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  *(undefined8 *)(param1 + 0x38) = uVar9;
		  uVar3 = func_ii_7821(param1);
		  iVar2 = func_ii_7826(uVar3,0);
		  if (iVar2 == 0) {
		    uVar11 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    goto code_r0x810178ed;
		  }
		  uVar11 = unnamed_function_1417(System_IO_FileInfo_TypeInfo);
		  System_IO_FileInfo___ctor(uVar11,uVar3,0);
		  lVar10 = System_IO_FileInfo___ctor(uVar11,0);
		  if (0xfffff < lVar10) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_15772,0);
		code_r0x810178d4:
		    uVar11 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    System_IO_File__Exists(uVar3,0);
		code_r0x810178ed:
		    uVar12 = (uint)(*(char *)(param1 + 0x44) == '\0');
		    *(uint *)(param1 + 0x10) = uVar12;
		    if (*(char *)(param1 + 0x45) == '\0') {
		      uVar12 = uVar12 | 2;
		      *(uint *)(param1 + 0x10) = uVar12;
		    }
		    if (*(char *)(param1 + 0x46) == '\0') {
		      uVar12 = uVar12 | 4;
		      *(uint *)(param1 + 0x10) = uVar12;
		    }
		    if ((*(char *)(param1 + 0x47) == '\0') &&
		       (*(uint *)(param1 + 0x10) = uVar12 | 8, (uVar12 | 8) == 0xf)) {
		      uVar3 = unnamed_function_1417(Core_Analytics_Okg_LogBuilder_TypeInfo);
		      Core_Analytics_Okg_LogBuilder___ctor(uVar3,uVar11,param1);
		    }
		    else {
		      uVar3 = unnamed_function_1417(Core_Analytics_Okg_TempLogBuilder_TypeInfo);
		      Core_Analytics_Okg_TempLogBuilder___ctor(uVar3,uVar11,param1);
		    }
		    *(undefined1 *)(param1 + 0x34) = 1;
		    *(undefined1 *)(param1 + 8) = 0;
		    *(undefined4 *)(param1 + 0xc) = uVar3;
		    return;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar11 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f1,uVar3,0);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar4 = global_1;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Collections_Generic_List_ValueTuple_byte____int___TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f2,iVar2,
		                 Method_System_Collections_Generic_List_ValueTuple_byte____int____ctor__);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_IO_MemoryStream_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x14a,iVar4,uVar11,0);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            local_18 = 0;
		            local_14 = &local_c;
		            local_c = iVar4;
		            piVar5 = (int *)import::env::invoke_ii
		                                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                       ICSharpCode_SharpZipLib_GZip_GZipInputStream_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x8101724e:
		              DAT_ram_009d3e38 = 0;
		              uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar4 = global_1;
		code_r0x81017445:
		              iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar7 == iVar4) {
		                piVar5 = (int *)import::env::__cxa_begin_catch(uVar11);
		                local_18 = *piVar5;
		                iVar7 = 0;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_v(0x123);
		                iVar4 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar4 != 1) goto code_r0x81017494;
		                uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar4 = global_1;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f7,&local_18);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) goto code_r0x810178c8;
		              goto code_r0x810177bf;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f3,piVar5,iVar4,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x8101724e;
		            local_20 = 0;
		            local_1c = &local_10;
		            local_10 = piVar5;
		            do {
		              DAT_ram_009d3e38 = 0;
		              uVar11 = import::env::invoke_iii
		                                 (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                                  byte___TypeInfo,0x400);
		              iVar4 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar4 == 1) {
		                uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8101727a:
		                iVar4 = global_1;
		                iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                if (iVar4 == iVar6) {
		                  piVar5 = (int *)import::env::__cxa_begin_catch(uVar11);
		                  local_20 = *piVar5;
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_v(0x123);
		                  iVar4 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar4 != 1) goto code_r0x810172c7;
		                  uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  iVar4 = global_1;
		                }
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f5,&local_20);
		                iVar7 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar7 == 1) goto code_r0x810178c8;
		                goto code_r0x81017445;
		              }
		              DAT_ram_009d3e38 = 0;
		              iVar6 = import::env::invoke_iiiiii
		                                (*(undefined4 *)(*local_10 + 0x1d0),local_10,uVar11,0,0x400,
		                                 *(undefined4 *)(*local_10 + 0x1d4));
		              iVar4 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar4 == 1) {
		                uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x8101727a;
		              }
		              local_28 = 0;
		              DAT_ram_009d3e38 = 0;
		              System_Text_Formatting_StringView__get_IsEmpty
		                        (&local_28,uVar11,iVar6,Method_System_ValueTuple_byte____int___ctor__);
		              iVar1 = DAT_ram_009d3e38;
		              iVar4 = Method_System_Collections_Generic_List_ValueTuple_byte____int___Add__;
		              DAT_ram_009d3e38 = 0;
		              if (iVar1 == 1) {
		code_r0x81017272:
		                DAT_ram_009d3e38 = 0;
		                uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x8101727a;
		              }
		              *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		              uVar12 = *(uint *)(iVar2 + 0xc);
		              if (uVar12 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		                *(uint *)(iVar2 + 0xc) = uVar12 + 1;
		                *(undefined8 *)(*(int *)(iVar2 + 8) + uVar12 * 8 + 0x10) = local_28;
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                local_30 = local_28;
		                local_8 = local_28;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x225,iVar2,&local_30,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		                iVar4 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar4 == 1) goto code_r0x81017272;
		              }
		            } while (0x3ff < iVar6);
		            iVar7 = 7;
		code_r0x810172c7:
		            piVar5 = *local_1c;
		            if (piVar5 != (int *)0x0) {
		              uVar12 = 0;
		              iVar4 = *piVar5;
		              if (*(ushort *)(iVar4 + 0xb6) != 0) {
		                do {
		                  if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8))
		                  {
		                    puVar8 = (undefined4 *)
		                             (iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0);
		                    goto code_r0x8101736b;
		                  }
		                  uVar12 = uVar12 + 1;
		                } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		              }
		              DAT_ram_009d3e38 = 0;
		              puVar8 = (undefined4 *)
		                       import::env::invoke_iiii
		                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                                  System_IDisposable_TypeInfo,0);
		              if (DAT_ram_009d3e38 != 1) {
		code_r0x8101736b:
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii(*puVar8,piVar5,puVar8[1]);
		                iVar4 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar4 != 1) goto code_r0x810173a7;
		              }
		code_r0x810173f6:
		              DAT_ram_009d3e38 = 0;
		              uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar4 = global_1;
		              goto code_r0x81017445;
		            }
		code_r0x810173a7:
		            if (local_20 != 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_20);
		              if (DAT_ram_009d3e38 != 1) goto code_r0x810178d2;
		              goto code_r0x810173f6;
		            }
		            if ((iVar7 == 0) ||
		               (((((iVar7 != 1 && (iVar7 != 2)) && (iVar7 != 3)) && ((iVar7 != 4 && (iVar7 != 5))))
		                && ((iVar7 != 6 && (iVar7 == 7)))))) {
		              iVar7 = 8;
		            }
		code_r0x81017494:
		            piVar5 = (int *)*local_14;
		            if (piVar5 == (int *)0x0) {
		code_r0x81017574:
		              if (local_18 == 0) {
		                if (iVar7 != 0) {
		                  if (iVar7 == 1) {
		                    return;
		                  }
		                  if (iVar7 == 2) {
		                    return;
		                  }
		                  if (iVar7 == 3) {
		                    return;
		                  }
		                  if (iVar7 == 4) {
		                    return;
		                  }
		                  if (iVar7 == 5) {
		                    return;
		                  }
		                  if (iVar7 == 6) {
		                    return;
		                  }
		                  if (iVar7 == 7) {
		                    return;
		                  }
		                  if (iVar7 != 8) {
		                    return;
		                  }
		                }
		                if (DAT_ram_00a594f2 == '\0') {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vi
		                            (0x7ff,&Core_Analytics_Okg_OkgAnalytics__GetByteIterator_d__45_TypeInfo)
		                  ;
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_00a594f2 = '\x01';
		                    goto code_r0x8101760b;
		                  }
		                }
		                else {
		code_r0x8101760b:
		                  DAT_ram_009d3e38 = 0;
		                  iVar7 = import::env::invoke_ii
		                                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                     Core_Analytics_Okg_OkgAnalytics__GetByteIterator_d__45_TypeInfo
		                                    );
		                  if (DAT_ram_009d3e38 != 1) {
		                    *(undefined4 *)(iVar7 + 8) = 0xfffffffe;
		                    DAT_ram_009d3e38 = 0;
		                    uVar11 = import::env::invoke_ii
		                                       (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x132,0);
		                    if (DAT_ram_009d3e38 != 1) {
		                      *(int *)(iVar7 + 0x18) = iVar2;
		                      *(undefined4 *)(iVar7 + 0x10) = uVar11;
		                      DAT_ram_009d3e38 = 0;
		                      uVar11 = import::env::invoke_iii
		                                         (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f6,
		                                          iVar7,Method_System_Linq_Enumerable_ToArray_byte___);
		                      iVar7 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar7 == 1) {
		                        uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        iVar4 = global_1;
		                      }
		                      else {
		                        DAT_ram_009d3e38 = 0;
		                        piVar5 = (int *)import::env::invoke_ii
		                                                  (s_struct_Uniforms___color__array<v_ram_000013c7 +
		                                                   0x22c,0);
		                        iVar7 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar7 == 1) {
		                          uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          iVar4 = global_1;
		                        }
		                        else {
		                          DAT_ram_009d3e38 = 0;
		                          uVar11 = import::env::invoke_iiii
		                                             (*(undefined4 *)(*piVar5 + 0x1e8),piVar5,uVar11,
		                                              *(undefined4 *)(*piVar5 + 0x1ec));
		                          iVar7 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar7 != 1) goto code_r0x810178ed;
		                          uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          iVar4 = global_1;
		                        }
		                      }
		                      goto code_r0x810177bf;
		                    }
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                iVar4 = global_1;
		                goto code_r0x810177bf;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_18);
		              if (DAT_ram_009d3e38 != 1) goto code_r0x810178d2;
		            }
		            else {
		              uVar12 = 0;
		              iVar4 = *piVar5;
		              if (*(ushort *)(iVar4 + 0xb6) != 0) {
		                do {
		                  if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8))
		                  {
		                    puVar8 = (undefined4 *)
		                             (iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar12 * 8 + 4) * 8 + 0xc0);
		                    goto code_r0x81017538;
		                  }
		                  uVar12 = uVar12 + 1;
		                } while (*(ushort *)(iVar4 + 0xb6) != uVar12);
		              }
		              DAT_ram_009d3e38 = 0;
		              puVar8 = (undefined4 *)
		                       import::env::invoke_iiii
		                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                                  System_IDisposable_TypeInfo,0);
		              if (DAT_ram_009d3e38 != 1) {
		code_r0x81017538:
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii(*puVar8,piVar5,puVar8[1]);
		                iVar4 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar4 != 1) goto code_r0x81017574;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar4 = global_1;
		            goto code_r0x810177bf;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar4 = global_1;
		        goto code_r0x810177bf;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar11 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar4 = global_1;
		  }
		code_r0x810177bf:
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 != iVar4) goto code_r0x810178af;
		  puVar8 = (undefined4 *)import::env::__cxa_begin_catch(uVar11);
		  DAT_ram_009d3e38 = 0;
		  iVar2 = import::env::invoke_iii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,DAT_ram_00a66938,
		                     *(undefined4 *)*puVar8);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    if (iVar2 != 0) {
		      import::env::__cxa_end_catch();
		      iVar7 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		      if (*(int *)(iVar7 + 0x74) == 0) {
		        func_ii_306000(iVar7);
		      }
		      uVar11 = unnamed_function_2232(&StringLiteral_11878);
		      func_ii_7109(uVar11,0);
		      goto code_r0x810178d4;
		    }
		    param2_00 = (undefined4 *)unnamed_function_951(4);
		    *param2_00 = *puVar8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,&DAT_ram_0072c9c8,0)
		    ;
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x810178d2:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar11 = import::env::__cxa_find_matching_catch_2();
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_v(0x123);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		code_r0x810178c8:
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x810178af:
		  import::env::__resumeException(uVar11);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007156 RID: 29014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007156")]
		[Address(RVA = "0x1E8E", Offset = "0x1E8E", VA = "0x1E8E")]
		private static string GetLogPath()
		{
		/* --- GHIDRA: GetLogPath ---
		void Core_Analytics_Okg_OkgAnalytics__GetLogPath(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (param1 == 0) {
		    uVar1 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_26041);
		    uVar3 = unnamed_function_2232(&StringLiteral_12313);
		    Spine_SkeletonJson__GetInt(uVar1,uVar2,uVar3,0);
		    uVar2 = unnamed_function_2232(&Method_System_IO_File_WriteAllBytes__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param1 + 8) == 0) {
		    uVar1 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_7257);
		    uVar3 = unnamed_function_2232(&StringLiteral_26041);
		    System_IO_EndOfStreamException___ctor(uVar1,uVar2,uVar3,0);
		    uVar2 = unnamed_function_2232(&Method_System_IO_File_WriteAllBytes__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (param2 == 0) {
		    uVar1 = unnamed_function_2232(&System_ArgumentNullException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_20838);
		    Mono_Security_X509_X509Certificate___ctor(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232(&Method_System_IO_File_WriteAllBytes__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_IO_File__InternalReadAllText(param1,param2,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007157")]
		[Address(RVA = "0xBB71", Offset = "0xBB71", VA = "0xBB71")]
		private void Initialize()
		{
		/* --- GHIDRA: Initialize ---
		void Core_Analytics_Okg_OkgAnalytics__Initialize
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__ApplicationFocusHandler_d__38___
		              );
		    DAT_ram_00a594ec = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_10 = CONCAT44(param1,(undefined4)local_10);
		  local_10 = CONCAT71(local_10._1_7_,(undefined1)param2);
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_NebogameSiteHelper__RequestSetEmailAndPass_d__9_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__ApplicationFocusHandler_d__38___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007158")]
		[Address(RVA = "0xBB72", Offset = "0xBB72", VA = "0xBB72")]
		private void ApplicationFocusHandler(bool hasFocus)
		{
		/* --- GHIDRA: ApplicationFocusHandler ---
		void Core_Analytics_Okg_OkgAnalytics__ApplicationFocusHandler(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__ApplicationQuitHandler_d__39___
		              );
		    DAT_ram_00a594ed = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_OkgAnalytics__ApplicationFocusHandler_d__38_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__ApplicationQuitHandler_d__39___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007159")]
		[Address(RVA = "0xBB73", Offset = "0xBB73", VA = "0xBB73")]
		private void ApplicationQuitHandler()
		{
		/* --- GHIDRA: ApplicationQuitHandler ---
		int Core_Analytics_Okg_OkgAnalytics__ApplicationQuitHandler
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a594f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics__GetByteIterator_d__45_TypeInfo);
		    DAT_ram_00a594f2 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics__GetByteIterator_d__45_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x18) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x0600715A RID: 29018 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x1700170D")]
		private bool IsAuthorizedUser
		{
			[Token(Token = "0x600715A")]
			[Address(RVA = "0x1E84", Offset = "0x1E84", VA = "0x1E84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x600715B")]
		[Address(RVA = "0x1E9A", Offset = "0x1E9A", VA = "0x1E9A")]
		private UniTask<string> GetToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x600715C")]
		[Address(RVA = "0x1E85", Offset = "0x1E85", VA = "0x1E85")]
		private UniTask<string> RequireToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x600715D")]
		[Address(RVA = "0x1E87", Offset = "0x1E87", VA = "0x1E87")]
		private UniTask<string> CreateTempToken()
		{
		/* --- GHIDRA: CreateTempToken ---
		undefined4
		Core_Analytics_Okg_OkgAnalytics__CreateTempToken(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param2_00;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a92b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ITokenProvider__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ITokenProvider__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Tokens_TokenProvider_TypeInfo);
		    DAT_ram_00a5a92b = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 8),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__ITokenProvider__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    param4 = *(undefined4 *)(param1 + 0xc);
		    param2_00 = *(undefined4 *)(param1 + 0x10);
		    param1_00 = unnamed_function_1417(Core_Gameplay_Tokens_TokenProvider_TypeInfo);
		    Core_Gameplay_Tokens_IdTokenRepository__Dispose(param1_00,param2_00,param2,param4,auStack_10);
		    local_4 = param1_00;
		    System_Reflection_FieldInfo__get_IsStatic
		              (*(undefined4 *)(param1 + 8),param2,param1_00,
		               Method_System_Collections_Generic_Dictionary_string__ITokenProvider__Add__);
		  }
		  return local_4;
		}
		*/

			return default(UniTask<string>);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600715E")]
		[Address(RVA = "0xBB74", Offset = "0xBB74", VA = "0xBB74")]
		private IEnumerable<byte> GetByteIterator([TupleElementNames(new string[]
		{
			"bytes",
			"len"
		})] IReadOnlyList<ValueTuple<byte[], int>> bytes)
		{
			return null;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600715F")]
		[Address(RVA = "0xBB75", Offset = "0xBB75", VA = "0xBB75")]
		private void ValidateLogBuilder()
		{
		/* --- GHIDRA: ValidateLogBuilder ---
		void Core_Analytics_Okg_OkgAnalytics__ValidateLogBuilder
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__DoLogEvent_d__47___
		              );
		    DAT_ram_00a594f4 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__DoLogEvent_d__47___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007160")]
		[Address(RVA = "0xBB76", Offset = "0xBB76", VA = "0xBB76")]
		private void DoLogEvent(OkgAnalyticsData dataBlock)
		{
		/* --- GHIDRA: DoLogEvent ---
		void Core_Analytics_Okg_OkgAnalytics__DoLogEvent(undefined8 *param1,uint param2,undefined4 param3)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  longlong local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_OkgAnalytics__ApplyLog_d__48___
		              );
		    DAT_ram_00a594f5 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_28 = 0xffffffff;
		  local_20 = (ulonglong)param2 << 0x20;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_OkgAnalytics__ApplyLog_d__48___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_OkgAnalytics__ApplyLog_d__48___
		              );
		  }
		  func_ii_7848(&local_28,&local_30);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_30,(uint)&local_28 | 4,0);
		  *param1 = local_30;
		  return;
		}
		*/

		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x6007161")]
		[Address(RVA = "0xBB77", Offset = "0xBB77", VA = "0xBB77")]
		private UniTask ApplyLog()
		{
		/* --- GHIDRA: ApplyLog ---
		void Core_Analytics_Okg_OkgAnalytics__ApplyLog
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 *param2_00;
		  uint *puVar6;
		  longlong lVar7;
		  undefined8 uVar8;
		  int *piVar9;
		  uint uVar10;
		  int local_60;
		  int **local_5c;
		  undefined8 local_58;
		  undefined8 local_50;
		  int *local_44;
		  int local_40;
		  int local_3c;
		  int *local_38;
		  int *local_34;
		  undefined8 local_30;
		  int local_28;
		  int *local_24;
		  int *local_20;
		  undefined4 uStack_1c;
		  undefined4 uStack_18;
		  int local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  
		  uVar5 = 0;
		  if (DAT_ram_00a594f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ICSharpCode_SharpZipLib_GZip_GZipInputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_ILogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IO_MemoryStream_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_475);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27657);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26069);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4640);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4639);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11882);
		    DAT_ram_00a594f8 = '\x01';
		  }
		  local_3c = 0;
		  local_40 = 0;
		  local_44 = (int *)0x0;
		  local_50 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_58 = 0;
		  iVar1 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     System_IO_MemoryStream_TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x8101e2ec:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar1 = global_1;
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x14a,iVar1,param3,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8101e2ec;
		    DAT_ram_009d3e38 = 0;
		    local_28 = 0;
		    local_24 = &local_3c;
		    local_3c = iVar1;
		    iVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       ICSharpCode_SharpZipLib_GZip_GZipInputStream_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8101e2f6:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar1 = global_1;
		code_r0x8101e6a6:
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar1) {
		        piVar9 = (int *)import::env::__cxa_begin_catch(uVar2);
		        local_28 = *piVar9;
		        iVar3 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) goto code_r0x8101e6f5;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x321,&local_28);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) goto code_r0x8101ed07;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f3,iVar3,iVar1,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8101e2f6;
		      DAT_ram_009d3e38 = 0;
		      local_38 = (int *)0x0;
		      local_34 = &local_40;
		      local_40 = iVar3;
		      piVar9 = (int *)import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 System_IO_MemoryStream_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8101e306:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		code_r0x8101e4de:
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar3 == iVar1) {
		          puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		          local_38 = (int *)*puVar4;
		          iVar3 = 0;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) goto code_r0x8101e52d;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar1 = global_1;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 800,&local_38);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) goto code_r0x8101ed07;
		        goto code_r0x8101e6a6;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x154,piVar9,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8101e306;
		      DAT_ram_009d3e38 = 0;
		      local_60 = 0;
		      local_5c = &local_44;
		      local_44 = piVar9;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x31e,local_40,piVar9,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8101e31e:
		        iVar1 = global_1;
		        iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 == iVar3) {
		          piVar9 = (int *)import::env::__cxa_begin_catch(uVar2);
		          local_60 = *piVar9;
		          uVar5 = 0;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) goto code_r0x8101e36f;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar1 = global_1;
		        }
		        uVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 799,&local_60);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) goto code_r0x8101ed07;
		        goto code_r0x8101e4de;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*local_44 + 0x218),local_44,
		                         *(undefined4 *)(*local_44 + 0x21c));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8101e31e;
		      }
		code_r0x8101e36f:
		      piVar9 = *local_5c;
		      if (piVar9 != (int *)0x0) {
		        uVar10 = 0;
		        iVar1 = *piVar9;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x8101e413;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x8101e413:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar4,piVar9,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x8101e44f;
		        }
		code_r0x8101e48e:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        goto code_r0x8101e4de;
		      }
		code_r0x8101e44f:
		      if (local_60 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_60);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8101ed11;
		        goto code_r0x8101e48e;
		      }
		      iVar3 = 3;
		code_r0x8101e52d:
		      piVar9 = (int *)*local_34;
		      if (piVar9 != (int *)0x0) {
		        uVar10 = 0;
		        iVar1 = *piVar9;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x8101e5d1;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x8101e5d1:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar4,piVar9,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x8101e60d;
		        }
		code_r0x8101e644:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        goto code_r0x8101e6a6;
		      }
		code_r0x8101e60d:
		      if (local_38 != (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_38);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8101ed11;
		        goto code_r0x8101e644;
		      }
		      if ((iVar3 == 0) || (((iVar3 != 1 && (iVar3 != 2)) && (iVar3 == 3)))) {
		        iVar3 = 4;
		      }
		code_r0x8101e6f5:
		      piVar9 = (int *)*local_24;
		      if (piVar9 == (int *)0x0) {
		code_r0x8101e7d5:
		        if (local_28 == 0) {
		          if (iVar3 != 0) {
		            if (iVar3 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar3 != 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          piVar9 = (int *)import::env::invoke_ii
		                                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x32e,0);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar1 = global_1;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_iiii
		                      (*(undefined4 *)(*piVar9 + 0x1e8),piVar9,uVar5,
		                       *(undefined4 *)(*piVar9 + 0x1ec));
		            iVar1 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar1 != 1) goto code_r0x8101e993;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar1 = global_1;
		          }
		          goto code_r0x8101e8f0;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_28);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x8101ed11;
		      }
		      else {
		        uVar10 = 0;
		        iVar1 = *piVar9;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar4 = (undefined4 *)
		                       (iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x8101e799;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,
		                            System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x8101e799:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar4,piVar9,puVar4[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x8101e7d5;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar1 = global_1;
		    }
		  }
		code_r0x8101e8f0:
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar1) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar5,
		                         *(undefined4 *)*puVar4);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar3 != 0) {
		          piVar9 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          iVar1 = *piVar9;
		          (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                    (piVar9,*(undefined4 *)(iVar1 + 0xec));
		code_r0x8101e993:
		          uVar5 = *(undefined4 *)(param1 + 0x24);
		          *(undefined4 *)(param1 + 0x24) = 0;
		          iVar1 = UnityEngine_AsyncOperation__get_isDone(*(undefined4 *)(param2 + 0x10),0);
		          lVar7 = UnityEngine_Networking_UnityWebRequest__InternalSetUrl
		                            (*(undefined4 *)(param2 + 0x10),0);
		          if (iVar1 == 1) {
		            if (lVar7 == 200) {
		              iVar1 = System_Collections_CollectionBase___ctor
		                                (param4,*(undefined4 *)(param1 + 0x14),0);
		              puVar4 = &StringLiteral_26069;
		              if (iVar1 == 0) {
		                puVar4 = &StringLiteral_27657;
		              }
		              uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                                (StringLiteral_11882,*puVar4,StringLiteral_475,0);
		              if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		                func_ii_306000(OKG_Logs_Debug_TypeInfo);
		              }
		              System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		              if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		                func_ii_306000(System_DateTimeOffset_TypeInfo);
		              }
		              OKG_Logs_Debug__LogWarning(&local_28,0);
		              local_58 = CONCAT44(local_24,local_28);
		              uVar8 = System_DateTimeOffset__get_Now(&local_58,0);
		              *(undefined8 *)(param1 + 0x28) = uVar8;
		              Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult
		                        (uVar5,1,
		                         Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__
		                        );
		              UnityEngine_Networking_UnityWebRequest__Finalize(*(undefined4 *)(param2 + 0x10),0);
		              return;
		            }
		            uVar8 = UnityEngine_Networking_UnityWebRequest__InternalSetUrl
		                              (*(undefined4 *)(param2 + 0x10),0);
		            local_28 = (int)uVar8;
		            local_24 = (int *)((ulonglong)uVar8 >> 0x20);
		            uVar2 = func_ii_1081(DAT_ram_00a66964,&local_28);
		            uVar2 = func_ii_4419(StringLiteral_4639,uVar2,0);
		            if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		              func_ii_306000(OKG_Logs_Debug_TypeInfo);
		            }
		            func_ii_7109(uVar2,0);
		          }
		          else {
		            if ((lVar7 == 0x193) && (*(int *)(param1 + 0x30) < 1)) {
		              if (*(char *)(param1 + 0x34) == '\0') {
		                Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult
		                          (uVar5,0,
		                           Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__
		                          );
		              }
		              else {
		                *(undefined4 *)(param1 + 0x24) = uVar5;
		                if (DAT_ram_00a594f9 == '\0') {
		                  Mono_Security_ASN1__get_Item
		                            (&
		                             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__UpdateTokenAndSendLogAgain_d__52___
		                            );
		                  DAT_ram_00a594f9 = '\x01';
		                }
		                local_c = 0;
		                System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_
		                          (&local_38,0);
		                uStack_1c = (undefined4)local_30;
		                uStack_18 = (undefined4)((ulonglong)local_30 >> 0x20);
		                local_28 = -1;
		                local_24 = local_38;
		                local_20 = local_34;
		                local_14 = param1;
		                local_10 = param3;
		                System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_OkgAnalytics__ApplicationQuitHandler_d__39_
		                          (&local_24,&local_28,
		                           Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__UpdateTokenAndSendLogAgain_d__52___
		                          );
		              }
		              UnityEngine_Networking_UnityWebRequest__Finalize(*(undefined4 *)(param2 + 0x10),0);
		              return;
		            }
		            lVar7 = UnityEngine_Networking_UnityWebRequest__InternalSetUrl
		                              (*(undefined4 *)(param2 + 0x10),0);
		            if (lVar7 == 400) {
		              piVar9 = *(int **)(param1 + 0xc);
		              iVar1 = *piVar9;
		              if (*(ushort *)(iVar1 + 0xb6) != 0) {
		                uVar10 = 0;
		                do {
		                  if (Core_Analytics_Okg_ILogBuilder_TypeInfo ==
		                      *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		                    puVar6 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + iVar1
		                                     + 200);
		                    goto code_r0x8101ec8f;
		                  }
		                  uVar10 = uVar10 + 1;
		                } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		              }
		              puVar6 = (uint *)func_ii_1080(piVar9,Core_Analytics_Okg_ILogBuilder_TypeInfo,1);
		code_r0x8101ec8f:
		              (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		            }
		            uVar2 = UnityEngine_Networking_UnityWebRequest__get_url
		                              (*(undefined4 *)(param2 + 0x10),0);
		            uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_4640,uVar2,0);
		            if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		              func_ii_306000(OKG_Logs_Debug_TypeInfo);
		            }
		            func_ii_7109(uVar2,0);
		          }
		          Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult
		                    (uVar5,0,
		                     Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_bool__TrySetResult__);
		          UnityEngine_Networking_UnityWebRequest__Finalize(*(undefined4 *)(param2 + 0x10),0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x8101ed11:
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		code_r0x8101ed07:
		      DAT_ram_009d3e38 = 0;
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(UniTask);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x6007162")]
		[Address(RVA = "0x1E91", Offset = "0x1E91", VA = "0x1E91")]
		private UniTask<bool> SendLog(byte[] rawLog)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x6007163")]
		[Address(RVA = "0x1E9D", Offset = "0x1E9D", VA = "0x1E9D")]
		private UniTask<bool> DoSendLog(byte[] rawLog)
		{
		/* --- GHIDRA: DoSendLog ---
		undefined4 Core_Analytics_Okg_OkgAnalytics__DoSendLog(int param1,int param2)
		
		{
		  undefined4 uVar1;
		  
		  if (*(int *)(param1 + 8) == 0) {
		    return *(undefined4 *)(param1 + 0x10);
		  }
		  uVar1 = System_Lazy_object____ctor
		                    (param1,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x60) + 0x48));
		  return uVar1;
		}
		*/

			return default(UniTask<bool>);
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007164")]
		[Address(RVA = "0xBB78", Offset = "0xBB78", VA = "0xBB78")]
		private void ApplySendLogResult(UnityWebRequestAsyncOperation operation, byte[] rawLog, string token)
		{
		/* --- GHIDRA: ApplySendLogResult ---
		void Core_Analytics_Okg_OkgAnalytics__ApplySendLogResult
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__UpdateTokenAndSendLogAgain_d__52___
		              );
		    DAT_ram_00a594f9 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_OkgAnalytics__ApplicationQuitHandler_d__39_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_OkgAnalytics__UpdateTokenAndSendLogAgain_d__52___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007165")]
		[Address(RVA = "0xBB79", Offset = "0xBB79", VA = "0xBB79")]
		private void UpdateTokenAndSendLogAgain(byte[] rawLog)
		{
		/* --- GHIDRA: UpdateTokenAndSendLogAgain ---
		void Core_Analytics_Okg_OkgAnalytics__UpdateTokenAndSendLogAgain(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a594fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		    DAT_ram_00a594fa = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003B1D RID: 15133
		[Token(Token = "0x4003B1D")]
		private const string AnonymousTokenSecret = "d058713ac7";

		// Token: 0x04003B1E RID: 15134
		[Token(Token = "0x4003B1E")]
		[FieldOffset(Offset = "0x0")]
		private static IOkgAnalytics _instance;

		// Token: 0x04003B1F RID: 15135
		[Token(Token = "0x4003B1F")]
		private const string LogFileName = "okg_analytics.log";

		// Token: 0x04003B20 RID: 15136
		[Token(Token = "0x4003B20")]
		private const long LogFileSizeLimit = 1048576L;

		// Token: 0x04003B21 RID: 15137
		[Token(Token = "0x4003B21")]
		private const int MaxUpdateTokenIterations = 1;

		// Token: 0x04003B22 RID: 15138
		[Token(Token = "0x4003B22")]
		private const long SendDataDelayTimeSeconds = 30L;

		// Token: 0x04003B23 RID: 15139
		[Token(Token = "0x4003B23")]
		private const double SendDataTimeSeconds = 180.0;

		// Token: 0x04003B24 RID: 15140
		[Token(Token = "0x4003B24")]
		[FieldOffset(Offset = "0x8")]
		private bool _invalidate;

		// Token: 0x04003B25 RID: 15141
		[Token(Token = "0x4003B25")]
		[FieldOffset(Offset = "0xC")]
		private ILogBuilder _log;

		// Token: 0x04003B26 RID: 15142
		[Token(Token = "0x4003B26")]
		[FieldOffset(Offset = "0x10")]
		private OkgAnalytics.ActualFlag _actualFlag;

		// Token: 0x04003B27 RID: 15143
		[Token(Token = "0x4003B27")]
		[FieldOffset(Offset = "0x14")]
		private string _token;

		// Token: 0x04003B28 RID: 15144
		[Token(Token = "0x4003B28")]
		[FieldOffset(Offset = "0x18")]
		private string _tempToken;

		// Token: 0x04003B29 RID: 15145
		[Token(Token = "0x4003B29")]
		[FieldOffset(Offset = "0x1C")]
		private bool _getTokenInProcess;

		// Token: 0x04003B2A RID: 15146
		[Token(Token = "0x4003B2A")]
		[FieldOffset(Offset = "0x1D")]
		private bool _getTempTokenInProcess;

		// Token: 0x04003B2B RID: 15147
		[Token(Token = "0x4003B2B")]
		[FieldOffset(Offset = "0x20")]
		private UniTaskCompletionSource<string> _getTokenCompletion;

		// Token: 0x04003B2C RID: 15148
		[Token(Token = "0x4003B2C")]
		[FieldOffset(Offset = "0x24")]
		private UniTaskCompletionSource<bool> _sendDataCompletion;

		// Token: 0x04003B2D RID: 15149
		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x28")]
		private long _sendDataTimestamp;

		// Token: 0x04003B2E RID: 15150
		[Token(Token = "0x4003B2E")]
		[FieldOffset(Offset = "0x30")]
		private int _updateTokenIterations;

		// Token: 0x04003B2F RID: 15151
		[Token(Token = "0x4003B2F")]
		[FieldOffset(Offset = "0x34")]
		private bool _isInitialized;

		// Token: 0x04003B30 RID: 15152
		[Token(Token = "0x4003B30")]
		[FieldOffset(Offset = "0x38")]
		private DateTime _lastEventTs;

		// Token: 0x04003B31 RID: 15153
		[Token(Token = "0x4003B31")]
		[FieldOffset(Offset = "0x40")]
		private readonly Lazy<string> _url;

		// Token: 0x04003B32 RID: 15154
		[Token(Token = "0x4003B32")]
		[FieldOffset(Offset = "0x44")]
		private readonly bool _restoreUserId;

		// Token: 0x04003B33 RID: 15155
		[Token(Token = "0x4003B33")]
		[FieldOffset(Offset = "0x45")]
		private readonly bool _restoreUserLevel;

		// Token: 0x04003B34 RID: 15156
		[Token(Token = "0x4003B34")]
		[FieldOffset(Offset = "0x46")]
		private readonly bool _restoreEventTimestamps;

		// Token: 0x04003B35 RID: 15157
		[Token(Token = "0x4003B35")]
		[FieldOffset(Offset = "0x47")]
		private readonly bool _restoreIsTempUserId;

		// Token: 0x020012A2 RID: 4770
		[Token(Token = "0x20012A2")]
		[Flags]
		private enum ActualFlag
		{
			// Token: 0x04003B37 RID: 15159
			[Token(Token = "0x4003B37")]
			NothingActual = 0,
			// Token: 0x04003B38 RID: 15160
			[Token(Token = "0x4003B38")]
			UserId = 1,
			// Token: 0x04003B39 RID: 15161
			[Token(Token = "0x4003B39")]
			Level = 2,
			// Token: 0x04003B3A RID: 15162
			[Token(Token = "0x4003B3A")]
			Time = 4,
			// Token: 0x04003B3B RID: 15163
			[Token(Token = "0x4003B3B")]
			IsTempId = 8,
			// Token: 0x04003B3C RID: 15164
			[Token(Token = "0x4003B3C")]
			AllActual = 15
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Instance ---
		void Core_Analytics_Okg_OkgAnalytics__get_Instance
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a594e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Lazy_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Lazy_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_OkgAnalytics___c___ctor_b__28_0__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		    DAT_ram_00a594e2 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x47) = (undefined1)param5;
		  *(undefined1 *)(param1 + 0x46) = (undefined1)param4;
		  *(undefined1 *)(param1 + 0x45) = (undefined1)param3;
		  *(undefined1 *)(param1 + 0x44) = (undefined1)param2;
		  if (*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_string__TypeInfo);
		    func_ii_19797(param1_00,uVar1,Method_Core_Analytics_Okg_OkgAnalytics___c___ctor_b__28_0__,0);
		    *(int *)(*(int *)(Core_Analytics_Okg_OkgAnalytics___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = unnamed_function_1417(System_Lazy_string__TypeInfo);
		  System_Lazy_object____ctor(uVar1,param1_00,Method_System_Lazy_string___ctor__);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: get_IsAuthorizedUser ---
		void Core_Analytics_Okg_OkgAnalytics__get_IsAuthorizedUser
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 auStack_30 [4];
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_string__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_string__Start_OkgAnalytics__RequireToken_d__43___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_string__get_Task__
		              );
		    DAT_ram_00a594f0 = '\x01';
		  }
		  local_4 = 0;
		  local_14 = 0;
		  local_c = 0;
		  local_1c = 0;
		  local_20 = 0xffffffff;
		  local_10 = param2;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_string__Start_OkgAnalytics__RequireToken_d__43___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_string__Start_OkgAnalytics__RequireToken_d__43___
		              );
		  }
		  Core_Analytics_Okg_OkgAnalytics__GetToken_d__42__SetStateMachine(&local_20,auStack_30);
		  unnamed_function_126403
		            (&local_2c,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_string__get_Task__
		            );
		  *(undefined4 *)(param1 + 1) = local_24;
		  *param1 = local_2c;
		  return;
		}
		*/


		/* --- GHIDRA: GetByteIterator ---
		void Core_Analytics_Okg_OkgAnalytics__GetByteIterator(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a594f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_ILogBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_LogBuilder_TypeInfo);
		    DAT_ram_00a594f3 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0xf) {
		    uVar1 = 0;
		    param1_01 = *(int **)(param1 + 0xc);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Analytics_Okg_ILogBuilder_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x810180d3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Analytics_Okg_ILogBuilder_TypeInfo,2);
		code_r0x810180d3:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    param1_00 = unnamed_function_1417(Core_Analytics_Okg_LogBuilder_TypeInfo);
		    Core_Analytics_Okg_LogBuilder___ctor(param1_00,param2_00,param2_00);
		    *(undefined4 *)(param1 + 0xc) = param1_00;
		  }
		  return;
		}
		*/

}
