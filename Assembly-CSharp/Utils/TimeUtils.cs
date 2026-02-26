using System;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public static class TimeUtils
	{
		// Token: 0x060002EA RID: 746 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5763", Offset = "0x5763", VA = "0x5763")]
		public static float MsToSec(ulong ms)
		{
		/* --- GHIDRA: MsToSec ---
		float Utils_TimeUtils__MsToSec(ulonglong param1,undefined4 param2)
		
		{
		  return (float)param1 * 1000.0;
		}
		*/

		/* --- GHIDRA: MsToSec ---
		float Utils_TimeUtils__MsToSec(ulonglong param1,undefined4 param2)
		
		{
		  return (float)param1 * 1000.0;
		}
		*/

			return 0f;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1CA4", Offset = "0x1CA4", VA = "0x1CA4")]
		public static float MsToSec(long ms)
		{
			return 0f;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x5764", Offset = "0x5764", VA = "0x5764")]
		public static float SecToMs(ulong sec)
		{
		/* --- GHIDRA: SecToMs ---
		undefined4 Utils_TimeUtils__SecToMs(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a62820 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28569);
		    DAT_ram_00a62820 = '\x01';
		  }
		  local_4 = param1;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_28569,uVar1,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: SecToMs ---
		undefined4 Utils_TimeUtils__SecToMs(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a62820 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28569);
		    DAT_ram_00a62820 = '\x01';
		  }
		  local_4 = param1;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_28569,uVar1,0);
		  return uVar1;
		}
		*/

			return 0f;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x5765", Offset = "0x5765", VA = "0x5765")]
		public static float SecToMs(long sec)
		{
			return 0f;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x5766", Offset = "0x5766", VA = "0x5766")]
		public static string FormatTwoDigits(int value)
		{
		/* --- GHIDRA: FormatTwoDigits ---
		undefined4 Utils_TimeUtils__FormatTwoDigits(double param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62821 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24333);
		    DAT_ram_00a62821 = '\x01';
		  }
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  local_8 = System_Threading_CancellationTokenSource___ctor(param1,0);
		  uVar1 = System_TimeSpan__ToString(&local_8,StringLiteral_24333,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5767", Offset = "0x5767", VA = "0x5767")]
		public static string TimerFormat(double seconds)
		{
		/* --- GHIDRA: TimerFormat ---
		undefined4 Utils_TimeUtils__TimerFormat(undefined8 param1,undefined4 param2)
		
		{
		  int param3;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a62822 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22543);
		    DAT_ram_00a62822 = '\x01';
		  }
		  param3 = Utils_TimeUtils_TypeInfo;
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar1 = Utils_TimeUtils__DateTimeFormat(param1,StringLiteral_22543,param3);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x5768", Offset = "0x5768", VA = "0x5768")]
		public static string DateFormat(long seconds)
		{
		/* --- GHIDRA: DateFormat ---
		undefined4 Utils_TimeUtils__DateFormat(double param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  int *piVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62825 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15059);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15060);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15061);
		    DAT_ram_00a62825 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0xc),0);
		  if (iVar1 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15059,1,0,1,0,0,0,0);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0xc) = uVar2;
		    uVar2 = func_ii_7508(StringLiteral_15060,1,0,1,0,0,0,0);
		    *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x10) = uVar2;
		    uVar2 = func_ii_7508(StringLiteral_15061,1,0,1,0,0,0,0);
		    *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x14) = uVar2;
		  }
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_TimeSpan_TypeInfo);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x820f66f8;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x820f66f8:
		    DAT_ram_009d3e38 = 0;
		    local_8 = unnamed_function_184075(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xb7,param1)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    in_register_20000014 = (undefined4)((ulonglong)param1 >> 0x20);
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_TimeSpan_TypeInfo);
		      }
		      iVar1 = System_TimeSpan__get_Ticks(&local_8,0);
		      if (iVar1 < 1) {
		        if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_TimeSpan_TypeInfo);
		        }
		        iVar1 = System_TimeSpan__get_Days(&local_8,0);
		        if (iVar1 < 1) {
		          if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Utils_TimeUtils_TypeInfo);
		          }
		          uVar2 = *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x14);
		          if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_TimeSpan_TypeInfo);
		          }
		          uVar2 = System_TimeSpan__ToString(&local_8,uVar2,0);
		          return uVar2;
		        }
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        uVar2 = *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x10);
		        if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_TimeSpan_TypeInfo);
		        }
		        uVar2 = System_TimeSpan__ToString(&local_8,uVar2,0);
		        return uVar2;
		      }
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      uVar2 = *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0xc);
		      if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_TimeSpan_TypeInfo);
		      }
		      uVar2 = System_TimeSpan__ToString(&local_8,uVar2,0);
		      return uVar2;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_OverflowException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar3 != 0) {
		          piVar5 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          iVar1 = *piVar5;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                            (piVar5,CONCAT44(in_register_20000014,*(undefined4 *)(iVar1 + 0xec)));
		          return uVar2;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f69af;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x820f69af:
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

		/* --- GHIDRA: DateFormat ---
		undefined4 Utils_TimeUtils__DateFormat(double param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  int *piVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62825 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15059);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15060);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15061);
		    DAT_ram_00a62825 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0xc),0);
		  if (iVar1 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_15059,1,0,1,0,0,0,0);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0xc) = uVar2;
		    uVar2 = func_ii_7508(StringLiteral_15060,1,0,1,0,0,0,0);
		    *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x10) = uVar2;
		    uVar2 = func_ii_7508(StringLiteral_15061,1,0,1,0,0,0,0);
		    *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x14) = uVar2;
		  }
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_TimeSpan_TypeInfo);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x820f66f8;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		code_r0x820f66f8:
		    DAT_ram_009d3e38 = 0;
		    local_8 = unnamed_function_184075(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xb7,param1)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    in_register_20000014 = (undefined4)((ulonglong)param1 >> 0x20);
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_TimeSpan_TypeInfo);
		      }
		      iVar1 = System_TimeSpan__get_Ticks(&local_8,0);
		      if (iVar1 < 1) {
		        if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_TimeSpan_TypeInfo);
		        }
		        iVar1 = System_TimeSpan__get_Days(&local_8,0);
		        if (iVar1 < 1) {
		          if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Utils_TimeUtils_TypeInfo);
		          }
		          uVar2 = *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x14);
		          if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_TimeSpan_TypeInfo);
		          }
		          uVar2 = System_TimeSpan__ToString(&local_8,uVar2,0);
		          return uVar2;
		        }
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Utils_TimeUtils_TypeInfo);
		        }
		        uVar2 = *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0x10);
		        if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_TimeSpan_TypeInfo);
		        }
		        uVar2 = System_TimeSpan__ToString(&local_8,uVar2,0);
		        return uVar2;
		      }
		      if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_TimeUtils_TypeInfo);
		      }
		      uVar2 = *(undefined4 *)(*(int *)(Utils_TimeUtils_TypeInfo + 0x5c) + 0xc);
		      if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_TimeSpan_TypeInfo);
		      }
		      uVar2 = System_TimeSpan__ToString(&local_8,uVar2,0);
		      return uVar2;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_OverflowException_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar3 != 0) {
		          piVar5 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          iVar1 = *piVar5;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                            (piVar5,CONCAT44(in_register_20000014,*(undefined4 *)(iVar1 + 0xec)));
		          return uVar2;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f69af;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x820f69af:
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

			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x5769", Offset = "0x5769", VA = "0x5769")]
		public static string DateTimeFormat(ulong milliseconds)
		{
		/* --- GHIDRA: DateTimeFormat ---
		undefined4 Utils_TimeUtils__DateTimeFormat(undefined8 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62824 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a62824 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  System_DateTimeOffset__Equals(&local_20,param1,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  System_DateTimeOffset__ParseExact(&local_30,&local_10,0);
		  local_8 = local_28;
		  local_10 = local_30;
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  uVar1 = Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                    (*(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		  uVar1 = System_DateTimeOffset__ToString(&local_10,param2,uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x576A", Offset = "0x576A", VA = "0x576A")]
		public static string DateFormat(long seconds, string format)
		{
			return null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x576B", Offset = "0x576B", VA = "0x576B")]
		public static string Format(double seconds)
		{
		/* --- GHIDRA: Format ---
		undefined8 Utils_TimeUtils__Format(undefined4 param1)
		
		{
		  undefined8 uVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62826 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a62826 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  uVar1 = System_DateTimeOffset__get_Now(&local_10,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x17000074")]
		public static long UnixTimestamp
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x576C", Offset = "0x576C", VA = "0x576C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x17000075")]
		public static long UnixTimestampMilliseconds
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x4475", Offset = "0x4475", VA = "0x4475")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		public const float SEC_ONE = 1f;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		public const float MS_IN_SEC = 1000f;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x0")]
		public static float SEC_IN_HOUR;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x4")]
		public static float SEC_IN_MINUTE;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8")]
		public static float SEC_IN_DAY;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		public const string DATE_TIME_FORMAT = "dd MMMM yyyy, HH:mm";

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		public const string DATE_FORMAT = "dd.MM.yyyy";

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		public const string TIMER_FORMAT = "hh':'mm':'ss";

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		public const string TIMER_FORMAT_24 = "HH':'mm':'ss";

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		public const string ONLY_SECONDS_TIMER_FORMAT = "ss";

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC")]
		private static string _timerFormatDays;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x10")]
		private static string _timerFormatHours;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x14")]
		private static string _timerFormatMinutes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_UnixTimestamp ---
		void Utils_TimeUtils__get_UnixTimestamp(undefined4 param1)
		
		{
		  undefined8 *puVar1;
		  
		  if (DAT_ram_00a62828 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a62828 = '\x01';
		  }
		  puVar1 = *(undefined8 **)(Utils_TimeUtils_TypeInfo + 0x5c);
		  *(undefined4 *)(puVar1 + 1) = 0x47a8c000;
		  *puVar1 = 0x4270000045610000;
		  return;
		}
		*/


		/* --- GHIDRA: get_UnixTimestampMilliseconds ---
		/* WARNING: Removing unreachable block (ram,0x82316648) */
		/* WARNING: Removing unreachable block (ram,0x823165cf) */
		
		void Utils_TimeUtils__get_UnixTimestampMilliseconds(int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  undefined4 *puVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  undefined4 *param2_01;
		  uint *puVar5;
		  short sVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  uint uVar10;
		  undefined8 local_38;
		  int local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  int local_18;
		  undefined8 local_10;
		  ushort local_8;
		  
		  if (DAT_ram_00a63900 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AssetBundle__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_AssetBundles_WebGL_AssetBundleLoader_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_IPlatformConfigurationProvider___PreloaderBackgroundLoader__LoadBackground_d__4___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader__LoadBackground_d__4___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__GetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__get_IsCompleted__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Files_WebGL_FileManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Platforms_WebGL_PlatformConfigurationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Preloader_PreloaderBackgroundLoader___c__DisplayClass4_0__LoadBackground_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Preloader_PreloaderBackgroundLoader___c__DisplayClass4_0__LoadBackground_g__SuccessCallback_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Preloader_PreloaderBackgroundLoader___c__DisplayClass4_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_IPlatformConfigurationProvider__GetAwaiter__)
		    ;
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    DAT_ram_00a63900 = '\x01';
		  }
		  _local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  if (*param1 != 0) {
		    if (*param1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         UI_Preloader_PreloaderBackgroundLoader___c__DisplayClass4_0_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        param1[6] = iVar7;
		        *(int *)(iVar7 + 0xc) = param1[3];
		        iVar7 = param1[6];
		        *(int *)(iVar7 + 0x10) = param1[4];
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          *(undefined4 *)(iVar7 + 8) = uVar4;
		          DAT_ram_009d3e38 = 0;
		          piVar3 = (int *)import::env::invoke_ii
		                                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                     Platforms_WebGL_PlatformConfigurationProvider_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x1f,piVar3,0)
		            ;
		            if (DAT_ram_009d3e38 != 1) {
		              param1[7] = (int)piVar3;
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (*(undefined4 *)(*piVar3 + 0x118),&local_38,piVar3,
		                         *(undefined4 *)(*piVar3 + 0x11c));
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) {
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x8231728a;
		              }
		              local_18 = local_30;
		              local_20 = local_38;
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
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x8231728a;
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
		                if (DAT_ram_009d3e38 != 1) goto code_r0x823167b9;
		              }
		              else {
		code_r0x823167b9:
		                if (DAT_ram_00a63c4a == '\0') {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		                  if (DAT_ram_009d3e38 == 1) goto code_r0x82316986;
		                  DAT_ram_00a63c4a = '\x01';
		                }
		                piVar3 = (int *)local_10;
		                if ((int *)local_10 == (int *)0x0) goto code_r0x823169cb;
		                uVar10 = 0;
		                uVar1 = local_8;
		                iVar7 = *(int *)local_10;
		                if (*(ushort *)(iVar7 + 0xb6) != 0) {
		                  do {
		                    if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                        *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		                      puVar2 = (undefined4 *)
		                               (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		                      goto code_r0x823168a7;
		                    }
		                    uVar10 = uVar10 + 1;
		                  } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar2 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                    (int *)local_10,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,
		                                    0);
		                if (DAT_ram_009d3e38 != 1) {
		code_r0x823168a7:
		                  DAT_ram_009d3e38 = 0;
		                  iVar7 = import::env::invoke_iiii(*puVar2,piVar3,(int)(short)uVar1,puVar2[1]);
		                  if (DAT_ram_009d3e38 != 1) {
		                    if (iVar7 != 0) goto code_r0x823169c6;
		                    *param1 = 0;
		                    *(undefined8 *)(param1 + 8) = local_10;
		                    param1[10] = _local_8;
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viiii
		                              (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x2d,param1 + 1,
		                               &local_10,param1,
		                               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter_IPlatformConfigurationProvider___PreloaderBackgroundLoader__LoadBackground_d__4___
		                              );
		                    iVar7 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar7 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      return;
		                    }
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x8231728a;
		                  }
		                }
		              }
		code_r0x82316986:
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8231728a;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		      }
		      goto code_r0x8231728a;
		    }
		    local_28 = *(undefined8 *)(param1 + 0xb);
		    *param1 = -1;
		    param1[0xb] = 0;
		    param1[0xc] = 0;
		    sVar6 = (short)((ulonglong)local_28 >> 0x20);
		    piVar3 = (int *)local_28;
		    goto code_r0x8231715c;
		  }
		  _local_8 = param1[10];
		  local_10 = *(undefined8 *)(param1 + 8);
		  param1[8] = 0;
		  param1[9] = 0;
		  param1[10] = 0;
		  *param1 = -1;
		  piVar3 = (int *)local_10;
		code_r0x823169c6:
		  if (piVar3 == (int *)0x0) {
		code_r0x823169cb:
		    piVar3 = local_10._4_4_;
		code_r0x82316b39:
		    uVar10 = 0;
		    iVar7 = *piVar3;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		          puVar2 = (undefined4 *)
		                   (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82316bd1;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,
		                        Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x82316bd1:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar2,piVar3,puVar2[1]);
		      if (DAT_ram_009d3e38 != 1) {
		        uVar9 = *(undefined4 *)(iVar7 + 0x18);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Core_Files_WebGL_FileManager_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x2e,uVar4,uVar9,0);
		          if (DAT_ram_009d3e38 != 1) {
		            iVar7 = param1[5];
		            iVar8 = param1[7];
		            DAT_ram_009d3e38 = 0;
		            uVar9 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               Core_AssetBundles_WebGL_AssetBundleLoader_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiiiii
		                        (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x2f,uVar9,uVar4,iVar8,
		                         iVar7,0,0);
		              if (DAT_ram_009d3e38 != 1) {
		                iVar7 = param1[6];
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_ii
		                                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                   System_Action_AssetBundle__TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viiii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,iVar7,
		                             Method_UI_Preloader_PreloaderBackgroundLoader___c__DisplayClass4_0__LoadBackground_g__SuccessCallback_1__
		                             ,0);
		                  if (DAT_ram_009d3e38 != 1) {
		                    iVar7 = param1[6];
		                    DAT_ram_009d3e38 = 0;
		                    param2_00 = import::env::invoke_ii
		                                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                           System_Action_TypeInfo);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_viiii
		                                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x381,param2_00,
		                                 iVar7,
		                                 Method_UI_Preloader_PreloaderBackgroundLoader___c__DisplayClass4_0__LoadBackground_b__0__
		                                 ,0);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viiii
		                                  (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x30,uVar9,
		                                   uVar4,param2_00,0);
		                        if (DAT_ram_009d3e38 != 1) {
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_vii
		                                    (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0x31,uVar9,0)
		                          ;
		                          if (DAT_ram_009d3e38 != 1) {
		                            DAT_ram_009d3e38 = 0;
		                            Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult
		                                      (&local_38,*(undefined4 *)(param1[6] + 8),0);
		                            iVar7 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar7 == 1) {
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x8231728a;
		                            }
		                            if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_vi
		                                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                         Cysharp_Threading_Tasks_UniTask_TypeInfo);
		                              iVar7 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar7 == 1) {
		                                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                                goto code_r0x8231728a;
		                              }
		                            }
		                            local_28 = local_38;
		                            if (DAT_ram_00a63a11 == '\0') {
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_vi
		                                        (0x7ff,&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		                              if (DAT_ram_009d3e38 != 1) {
		                                DAT_ram_00a63a11 = '\x01';
		                                goto code_r0x82316f07;
		                              }
		                            }
		                            else {
		code_r0x82316f07:
		                              if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_vi
		                                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                           Cysharp_Threading_Tasks_UniTask_TypeInfo);
		                                if (DAT_ram_009d3e38 == 1) goto code_r0x82317128;
		                              }
		                              if (DAT_ram_00a63a12 == '\0') {
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_vi
		                                          (0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		                                if (DAT_ram_009d3e38 == 1) goto code_r0x82317128;
		                                DAT_ram_00a63a12 = '\x01';
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              sVar6 = (short)((ulonglong)local_38 >> 0x20);
		                              piVar3 = (int *)local_38;
		                              if (piVar3 == (int *)0x0) {
		                                piVar3 = (int *)0x0;
		code_r0x8231715c:
		                                if (DAT_ram_00a63a13 == '\0') {
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_vi
		                                            (0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo)
		                                  ;
		                                  iVar7 = DAT_ram_009d3e38;
		                                  DAT_ram_009d3e38 = 0;
		                                  if (iVar7 != 1) {
		                                    DAT_ram_00a63a13 = '\x01';
		                                    goto code_r0x823171a1;
		                                  }
		                                }
		                                else {
		code_r0x823171a1:
		                                  if (piVar3 == (int *)0x0) {
		code_r0x823173ac:
		                                    param1[6] = 0;
		                                    param1[7] = 0;
		                                    *param1 = -2;
		                                    if (DAT_ram_00a63a15 == '\0') {
		                                      Mono_Security_ASN1__get_Item
		                                                (&
		                                                 Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                                                );
		                                      DAT_ram_00a63a15 = '\x01';
		                                    }
		                                    piVar3 = (int *)param1[1];
		                                    if (piVar3 == (int *)0x0) {
		                                      return;
		                                    }
		                                    uVar10 = 0;
		                                    iVar7 = *piVar3;
		                                    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		                                      do {
		                                        if (Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                                            == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		                                          puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) +
		                                                                     uVar10 * 8 + 4) * 8 + iVar7 +
		                                                           0xd0);
		                                          goto code_r0x82317451;
		                                        }
		                                        uVar10 = uVar10 + 1;
		                                      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		                                    }
		                                    puVar5 = (uint *)func_ii_1080(piVar3,
		                                                  Cysharp_Threading_Tasks_CompilerServices_IStateMachineRunnerPromise_TypeInfo
		                                                  ,2);
		code_r0x82317451:
		                                    (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		                                    return;
		                                  }
		                                  uVar10 = 0;
		                                  iVar7 = *piVar3;
		                                  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		                                    do {
		                                      if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                                          *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		                                        puVar2 = (undefined4 *)
		                                                 (*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4)
		                                                  * 8 + iVar7 + 0xd0);
		                                        goto code_r0x8231723e;
		                                      }
		                                      uVar10 = uVar10 + 1;
		                                    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		                                  }
		                                  DAT_ram_009d3e38 = 0;
		                                  puVar2 = (undefined4 *)
		                                           import::env::invoke_iiii
		                                                     (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar3,
		                                                  Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,2)
		                                  ;
		                                  if (DAT_ram_009d3e38 != 1) {
		code_r0x8231723e:
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_viii(*puVar2,piVar3,(int)sVar6,puVar2[1]);
		                                    iVar7 = DAT_ram_009d3e38;
		                                    DAT_ram_009d3e38 = 0;
		                                    if (iVar7 != 1) goto code_r0x823173ac;
		                                  }
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                                goto code_r0x8231728a;
		                              }
		                              uVar10 = 0;
		                              iVar7 = *piVar3;
		                              if (*(ushort *)(iVar7 + 0xb6) != 0) {
		                                do {
		                                  if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                                      *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		                                    puVar2 = (undefined4 *)
		                                             (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 +
		                                                              4) * 8 + 0xc0);
		                                    goto code_r0x82317038;
		                                  }
		                                  uVar10 = uVar10 + 1;
		                                } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              puVar2 = (undefined4 *)
		                                       import::env::invoke_iiii
		                                                 (s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,piVar3,
		                                                  Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0)
		                              ;
		                              if (DAT_ram_009d3e38 != 1) {
		code_r0x82317038:
		                                DAT_ram_009d3e38 = 0;
		                                iVar8 = import::env::invoke_iiii
		                                                  (*puVar2,piVar3,(int)sVar6,puVar2[1]);
		                                iVar7 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar7 != 1) {
		                                  if (iVar8 == 0) {
		                                    *(undefined8 *)(param1 + 0xb) = local_38;
		                                    *param1 = 1;
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_viiii
		                                              (s___Scripting__UnityEngine__XR__Me_ram_0000443a +
		                                               0x32,param1 + 1,&local_28,param1,
		                                               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_AwaitUnsafeOnCompleted_UniTask_Awaiter__PreloaderBackgroundLoader__LoadBackground_d__4___
		                                              );
		                                    iVar7 = DAT_ram_009d3e38;
		                                    DAT_ram_009d3e38 = 0;
		                                    if (iVar7 != 1) {
		                                      DAT_ram_009d3e38 = 0;
		                                      return;
		                                    }
		                                    uVar4 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                    goto code_r0x8231728a;
		                                  }
		                                  goto code_r0x8231715c;
		                                }
		                              }
		                            }
		code_r0x82317128:
		                            DAT_ram_009d3e38 = 0;
		                            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            goto code_r0x8231728a;
		                          }
		                        }
		                      }
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    goto code_r0x8231728a;
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x8231728a;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8231728a;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8231728a;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    uVar1 = local_8;
		    iVar7 = *(int *)(
		                    Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IPlatformConfigurationProvider__GetResult__
		                    + 0x10);
		    if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar7);
		      if (DAT_ram_009d3e38 != 1) goto code_r0x82316a22;
		    }
		    else {
		code_r0x82316a22:
		      iVar7 = *(int *)(*(int *)(iVar7 + 0x60) + 0x14);
		      if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar7)
		        ;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x823170d8;
		      }
		      iVar8 = *piVar3;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          if (iVar7 == *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8)) {
		            puVar2 = (undefined4 *)
		                     (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x82316af3;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,iVar7,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x82316af3:
		        DAT_ram_009d3e38 = 0;
		        piVar3 = (int *)import::env::invoke_iiii(*puVar2,piVar3,(int)(short)uVar1,puVar2[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x82316b39;
		      }
		    }
		code_r0x823170d8:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x8231728a:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    puVar2 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar2);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		        if (iVar8 != 0) {
		          uVar4 = *puVar2;
		          import::env::__cxa_end_catch();
		          param1[6] = 0;
		          param1[7] = 0;
		          *param1 = -2;
		          unnamed_function_126513(param1 + 1,uVar4);
		          return;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar2;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x82317471;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x82317471:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: .cctor ---
		void Utils_TimeUtils___cctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a62829 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    DAT_ram_00a62829 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_Tween__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

}
