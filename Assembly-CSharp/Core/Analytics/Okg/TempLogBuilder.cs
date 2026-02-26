using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Okg
{
	// Token: 0x020012B0 RID: 4784
	[Token(Token = "0x20012B0")]
	public class TempLogBuilder : ILogBuilder
	{
		// Token: 0x0600718C RID: 29068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600718C")]
		[Address(RVA = "0xBB9A", Offset = "0xBB9A", VA = "0xBB9A")]
		public TempLogBuilder()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Okg_TempLogBuilder___ctor
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  byte *pbVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  uint uVar5;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59513 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OkgAnalyticsData__Add__);
		    DAT_ram_00a59513 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar3 = DAT_ram_009d3e38;
		  iVar1 = Method_System_Collections_Generic_List_OkgAnalyticsData__Add__;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    iVar3 = *(int *)(param1 + 0xc);
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar5 = *(uint *)(iVar3 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = param2;
		      pbVar2 = local_10;
		      goto code_r0x81021bcd;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,param2,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    pbVar2 = &local_5;
		    if (iVar1 != 1) goto code_r0x81021bcd;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    local_14 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    pbVar2 = &local_5;
		    if (iVar1 != 1) {
		code_r0x81021bcd:
		      if (*pbVar2 != 0) {
		        func_ii_21161(*local_c);
		      }
		      if (local_14 == 0) {
		        *param3 = 0;
		        return 1;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32a,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Okg_TempLogBuilder___ctor
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  byte *pbVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  uint uVar5;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59513 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OkgAnalyticsData__Add__);
		    DAT_ram_00a59513 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar3 = DAT_ram_009d3e38;
		  iVar1 = Method_System_Collections_Generic_List_OkgAnalyticsData__Add__;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    iVar3 = *(int *)(param1 + 0xc);
		    *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		    uVar5 = *(uint *)(iVar3 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		      *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = param2;
		      pbVar2 = local_10;
		      goto code_r0x81021bcd;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,param2,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    pbVar2 = &local_5;
		    if (iVar1 != 1) goto code_r0x81021bcd;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    local_14 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    pbVar2 = &local_5;
		    if (iVar1 != 1) {
		code_r0x81021bcd:
		      if (*pbVar2 != 0) {
		        func_ii_21161(*local_c);
		      }
		      if (local_14 == 0) {
		        *param3 = 0;
		        return 1;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32a,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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
		*/

		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600718D")]
		[Address(RVA = "0xBB9B", Offset = "0xBB9B", VA = "0xBB9B")]
		public TempLogBuilder(string initialString)
		{
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x00014AA8 File Offset: 0x00012CA8
		[Token(Token = "0x600718E")]
		[Address(RVA = "0xBB9C", Offset = "0xBB9C", VA = "0xBB9C", Slot = "4")]
		public bool AddLine(OkgAnalyticsData record, out string error)
		{
		/* --- GHIDRA: AddLine ---
		void Core_Analytics_Okg_TempLogBuilder__AddLine(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  int param4;
		  int iVar3;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59514 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_OkgAnalyticsData__Clear__);
		    DAT_ram_00a59514 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0xc);
		    param4 = *(int *)(iVar1 + 0xc);
		    iVar3 = 0;
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    if (param4 < 1) goto code_r0x81021da2;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,*(undefined4 *)(iVar1 + 8),0,
		               param4,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) goto code_r0x81021da2;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar3 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar1) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81021da2:
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar3 == 0) {
		        *(undefined4 *)(param1 + 8) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32b,&local_14);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
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
		*/

			return default(bool);
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600718F")]
		[Address(RVA = "0xBB9D", Offset = "0xBB9D", VA = "0xBB9D", Slot = "5")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		undefined4 Core_Analytics_Okg_TempLogBuilder__Clear(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 param3;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59515 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_OkgAnalyticsData__string___);
		    Mono_Security_ASN1__get_Item(&System_Func_OkgAnalyticsData__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_TempLogBuilder___c__Extract_b__6_0__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_92);
		    DAT_ram_00a59515 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810220b5;
		      }
		    }
		    puVar6 = *(undefined4 **)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c);
		    iVar5 = puVar6[1];
		    if (iVar5 == 0) {
		      if (*(int *)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810220b5;
		        }
		        puVar6 = *(undefined4 **)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c);
		      }
		      param3 = *puVar6;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_OkgAnalyticsData__string__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,iVar5,param3,
		                   Method_Core_Analytics_Okg_TempLogBuilder___c__Extract_b__6_0__,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(*(int *)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c) + 4) = iVar5;
		          goto code_r0x81022003;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		code_r0x81022003:
		      iVar3 = 0;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x228,uVar2,iVar5,
		                         Method_System_Linq_Enumerable_Select_OkgAnalyticsData__string___);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2eb,StringLiteral_92,
		                           uVar2,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        iVar1 = 3;
		        if (iVar5 != 1) goto code_r0x81022106;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x810220b5:
		  iVar5 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    iVar1 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = 0;
		    if (iVar5 != 1) {
		code_r0x81022106:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(*local_c);
		      }
		      if (iVar3 == 0) {
		        if (((iVar1 == 0) || (((iVar1 != 1 && (iVar1 != 2)) && (iVar1 == 3)))) &&
		           (iVar5 = func_ii_4769(*(undefined4 *)(param1 + 8),0), iVar5 == 0)) {
		          uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                            (*(undefined4 *)(param1 + 8),StringLiteral_92,uVar2,0);
		        }
		        return uVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32c,&local_14);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007190")]
		[Address(RVA = "0xBB9E", Offset = "0xBB9E", VA = "0xBB9E", Slot = "6")]
		public string Extract()
		{
		/* --- GHIDRA: Extract ---
		undefined4 Core_Analytics_Okg_TempLogBuilder__Extract(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  undefined4 param2_00;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59516 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_OkgAnalyticsData__string___);
		    Mono_Security_ASN1__get_Item(&System_Func_OkgAnalyticsData__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Analytics_Okg_TempLogBuilder___c__ToString_b__7_0__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7248);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15368);
		    DAT_ram_00a59516 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0xc);
		    if (*(int *)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8102245a;
		      }
		    }
		    puVar7 = *(undefined4 **)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c);
		    iVar5 = puVar7[2];
		    if (iVar5 == 0) {
		      if (*(int *)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8102245a;
		        }
		        puVar7 = *(undefined4 **)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar7;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_OkgAnalyticsData__string__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,iVar5,uVar6,
		                   Method_Core_Analytics_Okg_TempLogBuilder___c__ToString_b__7_0__,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(*(int *)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c) + 8) = iVar5;
		          goto code_r0x810223a8;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		code_r0x810223a8:
		      iVar3 = 0;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x228,uVar2,iVar5,
		                         Method_System_Linq_Enumerable_Select_OkgAnalyticsData__string___);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2eb,
		                           StringLiteral_1238,uVar2,0);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        iVar1 = 3;
		        if (iVar5 != 1) goto code_r0x810224ab;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x8102245a:
		  iVar5 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    iVar1 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = 0;
		    if (iVar5 != 1) {
		code_r0x810224ab:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(*local_c);
		      }
		      if (iVar3 == 0) {
		        if ((iVar1 == 0) || (((uVar6 = 0, iVar1 != 1 && (iVar1 != 2)) && (iVar1 == 3)))) {
		          param2_00 = *(undefined4 *)(param1 + 8);
		          iVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                            (uVar2,0);
		          uVar6 = StringLiteral_7248;
		          if (iVar5 == 0) {
		            uVar6 = uVar2;
		          }
		          uVar6 = System_Int32__ToString(StringLiteral_15368,param2_00,StringLiteral_1257,uVar6,0);
		        }
		        return uVar6;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32d,&local_14);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007191")]
		[Address(RVA = "0xBB9F", Offset = "0xBB9F", VA = "0xBB9F", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Analytics_Okg_TempLogBuilder__ToString(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59517 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OkgAnalyticsData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass8_0__SetUserId_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c__DisplayClass8_0_TypeInfo);
		    DAT_ram_00a59517 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Analytics_Okg_TempLogBuilder___c__DisplayClass8_0_TypeInfo);
		  *(undefined8 *)(iVar1 + 8) = param2;
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    param2_00 = *(undefined4 *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OkgAnalyticsData__TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,iVar1,
		                 Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass8_0__SetUserId_b__0__,0);
		      if (DAT_ram_009d3e38 != 1) {
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f8,param2_00,uVar2,
		                   Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81017fc2;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81017fc2:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar4 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f9,&local_14);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007192")]
		[Address(RVA = "0xBBA0", Offset = "0xBBA0", VA = "0xBBA0")]
		public void SetUserId(long userId)
		{
		/* --- GHIDRA: SetUserId ---
		void Core_Analytics_Okg_TempLogBuilder__SetUserId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59518 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OkgAnalyticsData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass9_0__SetUserLevel_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c__DisplayClass9_0_TypeInfo);
		    DAT_ram_00a59518 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Analytics_Okg_TempLogBuilder___c__DisplayClass9_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    param2_00 = *(undefined4 *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OkgAnalyticsData__TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,iVar1,
		                 Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass9_0__SetUserLevel_b__0__,
		                 0);
		      if (DAT_ram_009d3e38 != 1) {
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f8,param2_00,uVar2,
		                   Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810183b2;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x810183b2:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar4 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2fa,&local_14);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007193 RID: 29075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007193")]
		[Address(RVA = "0xBBA1", Offset = "0xBBA1", VA = "0xBBA1")]
		public void SetUserLevel(int userLevel)
		{
		/* --- GHIDRA: SetUserLevel ---
		void Core_Analytics_Okg_TempLogBuilder__SetUserLevel(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59519 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OkgAnalyticsData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass10_0__SetServerTimeOffset_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c__DisplayClass10_0_TypeInfo);
		    DAT_ram_00a59519 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Analytics_Okg_TempLogBuilder___c__DisplayClass10_0_TypeInfo);
		  *(undefined8 *)(iVar1 + 8) = param2;
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    param2_00 = *(undefined4 *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OkgAnalyticsData__TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,iVar1,
		                 Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass10_0__SetServerTimeOffset_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 != 1) {
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f8,param2_00,uVar2,
		                   Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810187f1;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x810187f1:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar4 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2fb,&local_14);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007194")]
		[Address(RVA = "0xBBA2", Offset = "0xBBA2", VA = "0xBBA2")]
		public void SetServerTimeOffset(long deltaTimeMs)
		{
		/* --- GHIDRA: SetServerTimeOffset ---
		void Core_Analytics_Okg_TempLogBuilder__SetServerTimeOffset
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5951a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OkgAnalyticsData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass11_0__SetIsTempUserFlag_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c__DisplayClass11_0_TypeInfo);
		    DAT_ram_00a5951a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Analytics_Okg_TempLogBuilder___c__DisplayClass11_0_TypeInfo);
		  *(undefined1 *)(iVar1 + 8) = (undefined1)param2;
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    param2_00 = *(undefined4 *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_OkgAnalyticsData__TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,iVar1,
		                 Method_Core_Analytics_Okg_TempLogBuilder___c__DisplayClass11_0__SetIsTempUserFlag_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 != 1) {
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2f8,param2_00,uVar2,
		                   Method_System_Collections_Generic_List_OkgAnalyticsData__ForEach__);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81018b0f;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81018b0f:
		      DAT_ram_009d3e38 = 0;
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar4 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2fc,&local_14);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007195")]
		[Address(RVA = "0xBBA3", Offset = "0xBBA3", VA = "0xBBA3")]
		public void SetIsTempUserFlag(bool isTempUser)
		{
		/* --- GHIDRA: SetIsTempUserFlag ---
		void Core_Analytics_Okg_TempLogBuilder__SetIsTempUserFlag(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5951b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		    DAT_ram_00a5951b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Okg_TempLogBuilder___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003B7E RID: 15230
		[Token(Token = "0x4003B7E")]
		[FieldOffset(Offset = "0x8")]
		private string _initialData;

		// Token: 0x04003B7F RID: 15231
		[Token(Token = "0x4003B7F")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<OkgAnalyticsData> _collector;
	}
}
