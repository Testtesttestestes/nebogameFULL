using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Okg
{
	// Token: 0x020012A0 RID: 4768
	[Token(Token = "0x20012A0")]
	public sealed class LogBuilder : ILogBuilder
	{
		// Token: 0x06007147 RID: 28999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007147")]
		[Address(RVA = "0xBB62", Offset = "0xBB62", VA = "0xBB62")]
		public LogBuilder()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Okg_LogBuilder___ctor
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  byte *pbVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  uint uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    DAT_ram_00a594dd = '\x01';
		  }
		  local_4 = 0;
		  local_5 = 0;
		  if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               Newtonsoft_Json_JsonConvert_TypeInfo);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) goto code_r0x81015ee9;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar8 = global_1;
		code_r0x8101615f:
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar3 != iVar8) {
		code_r0x8101627a:
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar3 != 0) {
		          piVar6 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          iVar8 = *piVar6;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0xd8) * 4))
		                            (piVar6,*(undefined4 *)(iVar8 + 0xdc));
		          uVar7 = 0;
		code_r0x81016287:
		          *param3 = uVar2;
		          return uVar7;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810162a4;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) goto code_r0x8101627a;
		  }
		  else {
		code_r0x81015ee9:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2e8,param2,0,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x8101615f;
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
		    iVar8 = Method_System_Collections_Generic_List_string__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      iVar3 = *(int *)(param1 + 0xc);
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      uVar5 = *(uint *)(iVar3 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		        *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = uVar2;
		        pbVar1 = local_10;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,uVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        pbVar1 = &local_5;
		        if (iVar8 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81016045;
		        }
		      }
		code_r0x81016099:
		      if (*pbVar1 == 0) {
		code_r0x810160d9:
		        if (local_14 == 0) {
		          uVar2 = 0;
		          uVar7 = 1;
		          goto code_r0x81016287;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_14);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810162a4;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000f84 + 0x168,*local_c,0);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) goto code_r0x810160d9;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x8101615f;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81016045:
		    iVar8 = global_1;
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar8 == iVar3) {
		      piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		      local_14 = *piVar6;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      pbVar1 = &local_5;
		      if (iVar8 != 1) goto code_r0x81016099;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2e9,&local_14);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) goto code_r0x8101615f;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		code_r0x810162a4:
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Okg_LogBuilder___ctor
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  byte *pbVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 *param2_00;
		  uint uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    DAT_ram_00a594dd = '\x01';
		  }
		  local_4 = 0;
		  local_5 = 0;
		  if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		               Newtonsoft_Json_JsonConvert_TypeInfo);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) goto code_r0x81015ee9;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar8 = global_1;
		code_r0x8101615f:
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar3 != iVar8) {
		code_r0x8101627a:
		      import::env::__resumeException(uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar2,
		                         *(undefined4 *)*puVar4);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar3 != 0) {
		          piVar6 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          iVar8 = *piVar6;
		          uVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0xd8) * 4))
		                            (piVar6,*(undefined4 *)(iVar8 + 0xdc));
		          uVar7 = 0;
		code_r0x81016287:
		          *param3 = uVar2;
		          return uVar7;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810162a4;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) goto code_r0x8101627a;
		  }
		  else {
		code_r0x81015ee9:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2e8,param2,0,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x8101615f;
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
		    iVar8 = Method_System_Collections_Generic_List_string__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      iVar3 = *(int *)(param1 + 0xc);
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      uVar5 = *(uint *)(iVar3 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		        *(uint *)(iVar3 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(iVar3 + 8) + uVar5 * 4 + 0x10) = uVar2;
		        pbVar1 = local_10;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,uVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        pbVar1 = &local_5;
		        if (iVar8 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81016045;
		        }
		      }
		code_r0x81016099:
		      if (*pbVar1 == 0) {
		code_r0x810160d9:
		        if (local_14 == 0) {
		          uVar2 = 0;
		          uVar7 = 1;
		          goto code_r0x81016287;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_14);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810162a4;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000f84 + 0x168,*local_c,0);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) goto code_r0x810160d9;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		      goto code_r0x8101615f;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81016045:
		    iVar8 = global_1;
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar8 == iVar3) {
		      piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		      local_14 = *piVar6;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      pbVar1 = &local_5;
		      if (iVar8 != 1) goto code_r0x81016099;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2e9,&local_14);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) goto code_r0x8101615f;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		code_r0x810162a4:
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007148 RID: 29000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007148")]
		[Address(RVA = "0xBB63", Offset = "0xBB63", VA = "0xBB63")]
		public LogBuilder(string initialString)
		{
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x6007149")]
		[Address(RVA = "0xBB64", Offset = "0xBB64", VA = "0xBB64", Slot = "4")]
		public bool AddLine(OkgAnalyticsData record, out string error)
		{
		/* --- GHIDRA: AddLine ---
		void Core_Analytics_Okg_LogBuilder__AddLine(int param1,undefined4 param2)
		
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
		  
		  if (DAT_ram_00a594de == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Clear__);
		    DAT_ram_00a594de = '\x01';
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
		  if (iVar3 != 1) {
		    iVar1 = *(int *)(param1 + 0xc);
		    param4 = *(int *)(iVar1 + 0xc);
		    iVar3 = 0;
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    if (0 < param4) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,*(undefined4 *)(iVar1 + 8),
		                 0,param4,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810163d0;
		      }
		    }
		    *(undefined4 *)(param1 + 8) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		code_r0x81016419:
		    if (local_5 != 0) {
		      func_ii_21161(local_4);
		    }
		    if (iVar3 == 0) {
		      return;
		    }
		    System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810163d0:
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
		    if (iVar1 != 1) goto code_r0x81016419;
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ea,&local_14);
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

		// Token: 0x0600714A RID: 29002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600714A")]
		[Address(RVA = "0xBB65", Offset = "0xBB65", VA = "0xBB65", Slot = "5")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		undefined4 Core_Analytics_Okg_LogBuilder__Clear(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int param4;
		  int local_14;
		  byte *local_10;
		  undefined4 *local_c;
		  byte local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a594df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_92);
		    DAT_ram_00a594df = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xc);
		  local_5 = 0;
		  DAT_ram_009d3e38 = 0;
		  local_c = &local_4;
		  local_14 = 0;
		  local_10 = &local_5;
		  import::env::invoke_viii
		            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x48,local_4,&local_5,0);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    iVar1 = 5;
		    if (*(int *)(*(int *)(param1 + 0xc) + 0xc) < 1) {
		      iVar4 = 0;
		      goto code_r0x810166ed;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2eb,StringLiteral_92,
		                       *(int *)(param1 + 0xc),0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = func_ii_4769(*(undefined4 *)(param1 + 8),0);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar3 == 0) {
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,
		                             *(undefined4 *)(param1 + 8),StringLiteral_92,uVar2,0);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810166a0;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        *(undefined4 *)(param1 + 8) = uVar2;
		        iVar3 = *(int *)(param1 + 0xc);
		        param4 = *(int *)(iVar3 + 0xc);
		        iVar4 = 0;
		        *(undefined4 *)(iVar3 + 0xc) = 0;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        if (param4 < 1) goto code_r0x810166ed;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,
		                   *(undefined4 *)(iVar3 + 8),0,param4,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) goto code_r0x810166ed;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		code_r0x810166a0:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar4 = *piVar5;
		    iVar1 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_14 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x810166ed:
		      if (local_5 != 0) {
		        func_ii_21161(local_4);
		      }
		      if (iVar4 == 0) {
		        if ((iVar1 == 0) ||
		           ((((uVar2 = 0, iVar1 != 1 && (iVar1 != 2)) && (iVar1 != 3)) &&
		            ((iVar1 != 4 && (iVar1 == 5)))))) {
		          uVar2 = *(undefined4 *)(param1 + 8);
		        }
		        return uVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ec,&local_14);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
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

		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600714B")]
		[Address(RVA = "0xBB66", Offset = "0xBB66", VA = "0xBB66", Slot = "6")]
		public string Extract()
		{
		/* --- GHIDRA: Extract ---
		undefined4 Core_Analytics_Okg_LogBuilder__Extract(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a594e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1257);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7248);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10645);
		    DAT_ram_00a594e0 = '\x01';
		  }
		  param1_00 = func_ii_7793(StringLiteral_1238,*(undefined4 *)(param1 + 0xc),0);
		  param2_00 = *(undefined4 *)(param1 + 8);
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1_00,0)
		  ;
		  uVar2 = StringLiteral_7248;
		  if (iVar1 == 0) {
		    uVar2 = param1_00;
		  }
		  uVar2 = System_Int32__ToString(StringLiteral_10645,param2_00,StringLiteral_1257,uVar2,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600714C")]
		[Address(RVA = "0xBB67", Offset = "0xBB67", VA = "0xBB67", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		int Core_Analytics_Okg_LogBuilder__ToString(undefined4 param1)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a594e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		    DAT_ram_00a594e1 = '\x01';
		  }
		  param1_00 = **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(Core_Analytics_Okg_OkgAnalytics_TypeInfo);
		    Core_Analytics_Okg_OkgAnalytics__get_Instance(param1_00,1,1,1,1,param1_00);
		    **(int **)(Core_Analytics_Okg_OkgAnalytics_TypeInfo + 0x5c) = param1_00;
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x04003B1B RID: 15131
		[Token(Token = "0x4003B1B")]
		[FieldOffset(Offset = "0x8")]
		private string _initialData;

		// Token: 0x04003B1C RID: 15132
		[Token(Token = "0x4003B1C")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<string> _log;
	}
}
