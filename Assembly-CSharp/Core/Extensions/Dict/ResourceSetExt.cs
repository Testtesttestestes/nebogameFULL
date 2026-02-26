using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F98 RID: 3992
	[Token(Token = "0x2000F98")]
	public static class ResourceSetExt
	{
		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0xABE0", Offset = "0xABE0", VA = "0xABE0")]
		public static ResourceSet Add(this ResourceSet v1, ResourceSet v2)
		{
		/* --- GHIDRA: Add ---
		int Core_Extensions_Dict_ResourceSetExt__Add(int param1,int param2,undefined4 param3)
		
		{
		  *(double *)(param1 + 0x10) = *(double *)(param1 + 0x10) - *(double *)(param2 + 0x10);
		  *(double *)(param1 + 0x18) = *(double *)(param1 + 0x18) - *(double *)(param2 + 0x18);
		  *(double *)(param1 + 0x20) = *(double *)(param1 + 0x20) - *(double *)(param2 + 0x20);
		  *(double *)(param1 + 0x28) = *(double *)(param1 + 0x28) - *(double *)(param2 + 0x28);
		  *(double *)(param1 + 0x30) = *(double *)(param1 + 0x30) - *(double *)(param2 + 0x30);
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0xABE1", Offset = "0xABE1", VA = "0xABE1")]
		public static ResourceSet Sub(this ResourceSet v1, ResourceSet v2)
		{
		/* --- GHIDRA: Sub ---
		int Core_Extensions_Dict_ResourceSetExt__Sub(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = Protocol_Common_ResourceSet___ctor(param2,0);
		  *(double *)(iVar1 + 0x10) = *(double *)(iVar1 + 0x10) - *(double *)(param1 + 0x10);
		  *(double *)(iVar1 + 0x18) = *(double *)(iVar1 + 0x18) - *(double *)(param1 + 0x18);
		  *(double *)(iVar1 + 0x20) = *(double *)(iVar1 + 0x20) - *(double *)(param1 + 0x20);
		  *(double *)(iVar1 + 0x28) = *(double *)(iVar1 + 0x28) - *(double *)(param1 + 0x28);
		  *(double *)(iVar1 + 0x30) = *(double *)(iVar1 + 0x30) - *(double *)(param1 + 0x30);
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0xABE2", Offset = "0xABE2", VA = "0xABE2")]
		public static ResourceSet GetDelta(this ResourceSet v1, ResourceSet v2)
		{
		/* --- GHIDRA: GetDelta ---
		uint Core_Extensions_Dict_ResourceSetExt__GetDelta(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  
		  if (param1 == 0) {
		    return 1;
		  }
		  uVar2 = 0;
		  uVar1 = 0;
		  if ((((*(double *)(param1 + 0x10) == 0.0) && (uVar2 = uVar1, *(double *)(param1 + 0x18) == 0.0))
		      && (*(double *)(param1 + 0x20) == 0.0)) && (*(double *)(param1 + 0x28) == 0.0)) {
		    uVar2 = (uint)(*(double *)(param1 + 0x30) == 0.0);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0xABE3", Offset = "0xABE3", VA = "0xABE3")]
		public static bool IsZero(this ResourceSet v1)
		{
		/* --- GHIDRA: IsZero ---
		uint Core_Extensions_Dict_ResourceSetExt__IsZero(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  
		  uVar2 = 0;
		  uVar1 = 0;
		  if ((((*(double *)(param2 + 0x10) <= *(double *)(param1 + 0x10)) &&
		       (uVar2 = uVar1, *(double *)(param2 + 0x18) <= *(double *)(param1 + 0x18))) &&
		      (*(double *)(param2 + 0x20) <= *(double *)(param1 + 0x20))) &&
		     (*(double *)(param2 + 0x28) <= *(double *)(param1 + 0x28))) {
		    uVar2 = (uint)(*(double *)(param2 + 0x30) <= *(double *)(param1 + 0x30));
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0xABE4", Offset = "0xABE4", VA = "0xABE4")]
		public static bool GreaterOrEqual(this ResourceSet moneyAvailable, ResourceSet moneyRequired)
		{
		/* --- GHIDRA: GreaterOrEqual ---
		uint Core_Extensions_Dict_ResourceSetExt__GreaterOrEqual(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  
		  uVar2 = 0;
		  uVar1 = 0;
		  if ((((*(double *)(param1 + 0x10) < *(double *)(param2 + 0x10)) &&
		       (uVar2 = uVar1, *(double *)(param1 + 0x18) < *(double *)(param2 + 0x18))) &&
		      (*(double *)(param1 + 0x20) < *(double *)(param2 + 0x20))) &&
		     (*(double *)(param1 + 0x28) < *(double *)(param2 + 0x28))) {
		    uVar2 = (uint)(*(double *)(param1 + 0x30) < *(double *)(param2 + 0x30));
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0xABE5", Offset = "0xABE5", VA = "0xABE5")]
		public static bool Less(this ResourceSet moneyAvailable, ResourceSet moneyRequired)
		{
		/* --- GHIDRA: Less ---
		int Core_Extensions_Dict_ResourceSetExt__Less(int param1,double param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a32b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Resources__TypeInfo);
		    DAT_ram_00a5a32b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Resources__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Resources___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x10)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x18)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x20)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x28)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (param2 < *(double *)(param1 + 0x30)) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 5;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,5,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0xABE6", Offset = "0xABE6", VA = "0xABE6")]
		public static List<Resources> GetResourcesIds(this ResourceSet rs, double greaterThresholdValue = 0.0)
		{
		/* --- GHIDRA: GetResourcesIds ---
		int Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a32c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Resources__TypeInfo);
		    DAT_ram_00a5a32c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Resources__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Resources___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (*(double *)(param1 + 0x10) != 0.0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (*(double *)(param1 + 0x18) != 0.0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (*(double *)(param1 + 0x20) != 0.0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (*(double *)(param1 + 0x28) != 0.0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = Method_System_Collections_Generic_List_Resources__Add__;
		  if (*(double *)(param1 + 0x30) != 0.0) {
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = 5;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,5,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0xABE7", Offset = "0xABE7", VA = "0xABE7")]
		public static List<Resources> GetNonZeroResourcesesIds(this ResourceSet rs)
		{
		/* --- GHIDRA: GetNonZeroResourcesesIds ---
		double Core_Extensions_Dict_ResourceSetExt__GetNonZeroResourcesesIds
		                 (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  double dVar9;
		  int *piVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar8 = 0;
		  dVar9 = 0.0;
		  if (DAT_ram_00a5a32d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a5a32d = '\x01';
		  }
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = param1;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x812029a9;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812029ed:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81202b6e:
		      iVar8 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar7) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar8 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar8;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) goto code_r0x81202bb7;
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29b,&local_c);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x812029a9:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812029ed;
		    if (iVar7 == 0) goto code_r0x81202bb7;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x81202a90;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81202b52:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81202b6e;
		    }
		code_r0x81202a90:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81202b52;
		    uVar3 = *(undefined4 *)(iVar7 + 8);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) goto code_r0x81202b11;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81202b6e;
		    }
		code_r0x81202b11:
		    DAT_ram_009d3e38 = 0;
		    iVar4 = func_ii_7278(uVar3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81202b6e;
		    }
		  } while (param2 != iVar4);
		  dVar9 = *(double *)(iVar7 + 0x10);
		code_r0x81202bb7:
		  piVar5 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar11 = 0;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		          puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81202c2f;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81202c2f:
		    (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		  }
		  if (iVar8 == 0) {
		    return dVar9;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0xABE8", Offset = "0xABE8", VA = "0xABE8")]
		public static double GetValue(this Money money, Resources id)
		{
		/* --- GHIDRA: GetValue ---
		undefined4 Core_Extensions_Dict_ResourceSetExt__GetValue(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acf9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Item__);
		    DAT_ram_00a5acf9 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x224) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x224),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: GetValue ---
		undefined4 Core_Extensions_Dict_ResourceSetExt__GetValue(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acf9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Item__);
		    DAT_ram_00a5acf9 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x224) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x224),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ResourcesDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return 0.0;
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0xABE9", Offset = "0xABE9", VA = "0xABE9")]
		public static bool HasNewCurrency(this Money money)
		{
		/* --- GHIDRA: HasNewCurrency ---
		double Core_Extensions_Dict_ResourceSetExt__HasNewCurrency
		                 (int param1,int param2,double param3,undefined4 param4)
		
		{
		  double *pdVar1;
		  
		  if (param2 == 1) {
		    pdVar1 = (double *)(param1 + 0x10);
		  }
		  else if (param2 == 2) {
		    pdVar1 = (double *)(param1 + 0x18);
		  }
		  else if (param2 == 3) {
		    pdVar1 = (double *)(param1 + 0x20);
		  }
		  else if (param2 == 4) {
		    pdVar1 = (double *)(param1 + 0x28);
		  }
		  else {
		    if (param2 != 5) {
		      return param3;
		    }
		    pdVar1 = (double *)(param1 + 0x30);
		  }
		  *pdVar1 = param3;
		  return param3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x1AFB", Offset = "0x1AFB", VA = "0x1AFB")]
		public static double GetValue(this ResourceSet rs, Resources id)
		{
			return 0.0;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0xABEA", Offset = "0xABEA", VA = "0xABEA")]
		public static double SetValue(this ResourceSet rs, Resources id, double value)
		{
		/* --- GHIDRA: SetValue ---
		int Core_Extensions_Dict_ResourceSetExt__SetValue(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  
		  if (DAT_ram_00a5a32f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5a32f = '\x01';
		  }
		  dVar1 = *(double *)(param1 + 0x10);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  *(double *)(param1 + 0x10) = FLOOR(dVar1);
		  *(double *)(param1 + 0x18) = FLOOR(*(double *)(param1 + 0x18));
		  *(double *)(param1 + 0x20) = FLOOR(*(double *)(param1 + 0x20));
		  *(double *)(param1 + 0x28) = FLOOR(*(double *)(param1 + 0x28));
		  *(double *)(param1 + 0x30) = FLOOR(*(double *)(param1 + 0x30));
		  return param1;
		}
		*/

			return 0.0;
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0xABEB", Offset = "0xABEB", VA = "0xABEB")]
		public static ResourceSet Floor(this ResourceSet r)
		{
		/* --- GHIDRA: Floor ---
		int Core_Extensions_Dict_ResourceSetExt__Floor(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  
		  if (DAT_ram_00a5a330 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5a330 = '\x01';
		  }
		  dVar1 = *(double *)(param1 + 0x10);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  *(double *)(param1 + 0x10) = CEIL(dVar1);
		  *(double *)(param1 + 0x18) = CEIL(*(double *)(param1 + 0x18));
		  *(double *)(param1 + 0x20) = CEIL(*(double *)(param1 + 0x20));
		  *(double *)(param1 + 0x28) = CEIL(*(double *)(param1 + 0x28));
		  *(double *)(param1 + 0x30) = CEIL(*(double *)(param1 + 0x30));
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0xABEC", Offset = "0xABEC", VA = "0xABEC")]
		public static ResourceSet Ceil(this ResourceSet r)
		{
		/* --- GHIDRA: Ceil ---
		int Core_Extensions_Dict_ResourceSetExt__Ceil(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  double dVar2;
		  double dVar3;
		  ulonglong uVar4;
		  float8 local_8;
		  
		  if (DAT_ram_00a5a331 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5a331 = '\x01';
		  }
		  dVar3 = *(double *)(param1 + 0x10);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar1 = unnamed_function_4206(dVar3,&local_8);
		  dVar2 = (double)local_8;
		  if (0.0 <= dVar3) {
		    if (dVar1 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        dVar2 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar2 = FLOOR(dVar3 + 0.5);
		    }
		  }
		  else if (dVar1 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar4 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar4 = 0;
		    }
		    if ((uVar4 & 1) != 0) {
		      dVar2 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar2 = CEIL(dVar3 + -0.5);
		  }
		  *(double *)(param1 + 0x10) = dVar2;
		  dVar1 = *(double *)(param1 + 0x18);
		  dVar2 = unnamed_function_4206(dVar1,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar1) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar1 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar4 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar4 = 0;
		    }
		    if ((uVar4 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar1 + -0.5);
		  }
		  *(double *)(param1 + 0x18) = dVar3;
		  dVar1 = *(double *)(param1 + 0x20);
		  dVar2 = unnamed_function_4206(dVar1,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar1) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar1 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar4 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar4 = 0;
		    }
		    if ((uVar4 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar1 + -0.5);
		  }
		  *(double *)(param1 + 0x20) = dVar3;
		  dVar1 = *(double *)(param1 + 0x28);
		  dVar2 = unnamed_function_4206(dVar1,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar1) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar1 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar4 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar4 = 0;
		    }
		    if ((uVar4 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar1 + -0.5);
		  }
		  *(double *)(param1 + 0x28) = dVar3;
		  dVar2 = *(double *)(param1 + 0x30);
		  dVar3 = unnamed_function_4206(dVar2,&local_8);
		  if (0.0 <= dVar2) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar4 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar4 = 0;
		      }
		      if ((uVar4 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + 1.0);
		      }
		    }
		    else {
		      local_8 = (float8)FLOOR(dVar2 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar4 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar4 = 0;
		    }
		    if ((uVar4 & 1) != 0) {
		      local_8 = (float8)((double)local_8 + -1.0);
		    }
		  }
		  else {
		    local_8 = (float8)CEIL(dVar2 + -0.5);
		  }
		  *(float8 *)(param1 + 0x30) = local_8;
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0xABED", Offset = "0xABED", VA = "0xABED")]
		public static ResourceSet Round(this ResourceSet r)
		{
		/* --- GHIDRA: Round ---
		int Core_Extensions_Dict_ResourceSetExt__Round(int param1,double param2,undefined4 param3)
		
		{
		  *(double *)(param1 + 0x10) = *(double *)(param1 + 0x10) * param2;
		  *(double *)(param1 + 0x18) = *(double *)(param1 + 0x18) * param2;
		  *(double *)(param1 + 0x20) = *(double *)(param1 + 0x20) * param2;
		  *(double *)(param1 + 0x28) = *(double *)(param1 + 0x28) * param2;
		  *(double *)(param1 + 0x30) = *(double *)(param1 + 0x30) * param2;
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0xABEE", Offset = "0xABEE", VA = "0xABEE")]
		public static ResourceSet Multiply(this ResourceSet v1, double multiplier)
		{
		/* --- GHIDRA: Multiply ---
		int Core_Extensions_Dict_ResourceSetExt__Multiply(int param1,int param2,undefined4 param3)
		
		{
		  double param2_00;
		  int iVar1;
		  int iVar2;
		  double dVar3;
		  double dVar4;
		  
		  if (DAT_ram_00a5a332 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5a332 = '\x01';
		  }
		  param2_00 = 2147483647.0;
		  if (0.0 < *(double *)(param2 + 0x10)) {
		    param2_00 = *(double *)(param1 + 0x10) / *(double *)(param2 + 0x10);
		  }
		  dVar3 = *(double *)(param2 + 0x18);
		  if (0.0 < dVar3) {
		    dVar4 = *(double *)(param1 + 0x18);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param2_00 = System_Decimal__Max(dVar4 / dVar3,param2_00,0);
		  }
		  dVar3 = *(double *)(param2 + 0x20);
		  if (0.0 < dVar3) {
		    dVar4 = *(double *)(param1 + 0x20);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param2_00 = System_Decimal__Max(dVar4 / dVar3,param2_00,0);
		  }
		  dVar3 = *(double *)(param2 + 0x28);
		  if (0.0 < dVar3) {
		    dVar4 = *(double *)(param1 + 0x28);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param2_00 = System_Decimal__Max(dVar4 / dVar3,param2_00,0);
		  }
		  dVar3 = *(double *)(param2 + 0x30);
		  if (0.0 < dVar3) {
		    dVar4 = *(double *)(param1 + 0x30);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    param2_00 = System_Decimal__Max(dVar4 / dVar3,param2_00,0);
		  }
		  if (param2_00 < 4294967296.0 && 0.0 <= param2_00) {
		    iVar1 = (int)param2_00;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (ABS(param2_00) < 2147483648.0) {
		    iVar2 = (int)param2_00;
		    if (0.0 <= param2_00) {
		      iVar2 = iVar1;
		    }
		    return iVar2;
		  }
		  iVar2 = -0x80000000;
		  if (0.0 <= param2_00) {
		    iVar2 = iVar1;
		  }
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0xABEF", Offset = "0xABEF", VA = "0xABEF")]
		public static uint GetQuotient(this ResourceSet r, ResourceSet compared)
		{
		/* --- GHIDRA: GetQuotient ---
		int Core_Extensions_Dict_ResourceSetExt__GetQuotient(int param1,undefined4 param2)
		
		{
		  double *pdVar1;
		  double param3;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  undefined1 auStack_50 [8];
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a334 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double____ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_Money_MoneyType__double___ctor__);
		    DAT_ram_00a5a334 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  iVar2 = unnamed_function_1417
		                    (System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,
		             Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double____ctor__);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(param1,auStack_50);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar3,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		  local_28 = 0;
		  local_24 = &local_20;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_20,
		                         Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81204579;
		      }
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar2;
		      }
		      iVar7 = local_18._4_4_;
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_Money_Money_MoneyType_TypeInfo);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81204579;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34d,iVar7,0);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81204579;
		      }
		      param3 = 0.0;
		      if ((param1 != 0) &&
		         ((((pdVar1 = (double *)(param1 + 0x10), iVar7 == 1 ||
		            (pdVar1 = (double *)(param1 + 0x18), iVar7 == 2)) ||
		           (pdVar1 = (double *)(param1 + 0x20), iVar7 == 3)) ||
		          ((pdVar1 = (double *)(param1 + 0x28), iVar7 == 4 ||
		           (pdVar1 = (double *)(param1 + 0x30), iVar7 == 5)))))) {
		        param3 = *pdVar1;
		      }
		      local_30 = 0;
		      local_38 = 0;
		      DAT_ram_009d3e38 = 0;
		      System_ValueTuple_int__bool___ToString
		                (&local_38,uVar3,param3,Method_System_ValueTuple_Money_MoneyType__double___ctor__);
		      iVar7 = Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81204567;
		      local_8 = local_30;
		      local_10 = local_38;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar6) break;
		      *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		      iVar7 = *(int *)(iVar2 + 8) + uVar6 * 0x10;
		      *(undefined8 *)(iVar7 + 0x18) = local_30;
		      *(undefined8 *)(iVar7 + 0x10) = local_38;
		    }
		    local_40 = local_30;
		    DAT_ram_009d3e38 = 0;
		    local_48 = local_38;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x21f,iVar2,&local_48,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x81204567:
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81204579:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a2,&local_28);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar3);
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

		/* --- GHIDRA: GetQuotient ---
		int Core_Extensions_Dict_ResourceSetExt__GetQuotient(int param1,undefined4 param2)
		
		{
		  double *pdVar1;
		  double param3;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  undefined1 auStack_50 [8];
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a334 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double____ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_Money_MoneyType__double___ctor__);
		    DAT_ram_00a5a334 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  iVar2 = unnamed_function_1417
		                    (System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,
		             Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double____ctor__);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(param1,auStack_50);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar3,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		  local_28 = 0;
		  local_24 = &local_20;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_20,
		                         Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81204579;
		      }
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar2;
		      }
		      iVar7 = local_18._4_4_;
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_Money_Money_MoneyType_TypeInfo);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81204579;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x34d,iVar7,0);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81204579;
		      }
		      param3 = 0.0;
		      if ((param1 != 0) &&
		         ((((pdVar1 = (double *)(param1 + 0x10), iVar7 == 1 ||
		            (pdVar1 = (double *)(param1 + 0x18), iVar7 == 2)) ||
		           (pdVar1 = (double *)(param1 + 0x20), iVar7 == 3)) ||
		          ((pdVar1 = (double *)(param1 + 0x28), iVar7 == 4 ||
		           (pdVar1 = (double *)(param1 + 0x30), iVar7 == 5)))))) {
		        param3 = *pdVar1;
		      }
		      local_30 = 0;
		      local_38 = 0;
		      DAT_ram_009d3e38 = 0;
		      System_ValueTuple_int__bool___ToString
		                (&local_38,uVar3,param3,Method_System_ValueTuple_Money_MoneyType__double___ctor__);
		      iVar7 = Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81204567;
		      local_8 = local_30;
		      local_10 = local_38;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar6 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar6) break;
		      *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		      iVar7 = *(int *)(iVar2 + 8) + uVar6 * 0x10;
		      *(undefined8 *)(iVar7 + 0x18) = local_30;
		      *(undefined8 *)(iVar7 + 0x10) = local_38;
		    }
		    local_40 = local_30;
		    DAT_ram_009d3e38 = 0;
		    local_48 = local_38;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x21f,iVar2,&local_48,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x81204567:
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81204579:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a2,&local_28);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar3);
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

			return 0U;
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0xABF0", Offset = "0xABF0", VA = "0xABF0")]
		public static double GetQuotient(this Money money, Money compared)
		{
			return 0.0;
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0xABF1", Offset = "0xABF1", VA = "0xABF1")]
		public static List<ValueTuple<Money.MoneyType, double>> GetResourcesAsList(this ResourceSet rs)
		{
		/* --- GHIDRA: GetResourcesAsList ---
		int Core_Extensions_Dict_ResourceSetExt__GetResourcesAsList(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  double dVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a335 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a5a335 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		  func_ii_7941(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = 0x79;
		  dVar2 = *(double *)(param1 + 0x10);
		  if (dVar2 < 4294967296.0 && 0.0 <= dVar2) {
		    iVar1 = (int)dVar2;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar3 = (int)dVar2;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (0.0 <= dVar2) {
		    iVar3 = iVar1;
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),iVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  dVar2 = *(double *)(param1 + 0x18);
		  if (dVar2 < 4294967296.0 && 0.0 <= dVar2) {
		    iVar1 = (int)dVar2;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar3 = (int)dVar2;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (0.0 <= dVar2) {
		    iVar3 = iVar1;
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),iVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  dVar2 = *(double *)(param1 + 0x20);
		  if (dVar2 < 4294967296.0 && 0.0 <= dVar2) {
		    iVar1 = (int)dVar2;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar3 = (int)dVar2;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (0.0 <= dVar2) {
		    iVar3 = iVar1;
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),iVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  dVar2 = *(double *)(param1 + 0x28);
		  if (dVar2 < 4294967296.0 && 0.0 <= dVar2) {
		    iVar1 = (int)dVar2;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar3 = (int)dVar2;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (0.0 <= dVar2) {
		    iVar3 = iVar1;
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),iVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  dVar2 = *(double *)(param1 + 0x30);
		  if (dVar2 < 4294967296.0 && 0.0 <= dVar2) {
		    iVar1 = (int)dVar2;
		  }
		  else {
		    iVar1 = 0;
		  }
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar3 = (int)dVar2;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (0.0 <= dVar2) {
		    iVar3 = iVar1;
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),iVar3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0xABF2", Offset = "0xABF2", VA = "0xABF2")]
		public static RewardInfo ToRewardInfo(this ResourceSet rs)
		{
		/* --- GHIDRA: ToRewardInfo ---
		undefined4 Core_Extensions_Dict_ResourceSetExt__ToRewardInfo(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  uint *puVar1;
		  int param1_01;
		  undefined4 param1_02;
		  int *piVar2;
		  int iVar3;
		  uint uVar4;
		  longlong lVar5;
		  
		  if (DAT_ram_00a5a336 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IRewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_RewardData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		    DAT_ram_00a5a336 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		  Core_Data_Decorators_RewardInfoDecorator___ctor(param1_00,0x79,0);
		  if (ABS(*(double *)(param1 + 0x10)) < 9.223372036854776e+18) {
		    lVar5 = (longlong)*(double *)(param1 + 0x10);
		  }
		  else {
		    lVar5 = -0x8000000000000000;
		  }
		  piVar2 = *(int **)(param1_00 + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x8120499f;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,2);
		code_r0x8120499f:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar2,lVar5,puVar1[1]);
		  if (ABS(*(double *)(param1 + 0x18)) < 9.223372036854776e+18) {
		    lVar5 = (longlong)*(double *)(param1 + 0x18);
		  }
		  else {
		    lVar5 = -0x8000000000000000;
		  }
		  piVar2 = *(int **)(param1_00 + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81204a4e;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,2);
		code_r0x81204a4e:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar2,lVar5,puVar1[1]);
		  if (ABS(*(double *)(param1 + 0x20)) < 9.223372036854776e+18) {
		    lVar5 = (longlong)*(double *)(param1 + 0x20);
		  }
		  else {
		    lVar5 = -0x8000000000000000;
		  }
		  piVar2 = *(int **)(param1_00 + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81204afd;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,2);
		code_r0x81204afd:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar2,lVar5,puVar1[1]);
		  if (ABS(*(double *)(param1 + 0x28)) < 9.223372036854776e+18) {
		    lVar5 = (longlong)*(double *)(param1 + 0x28);
		  }
		  else {
		    lVar5 = -0x8000000000000000;
		  }
		  piVar2 = *(int **)(param1_00 + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81204bac;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,2);
		code_r0x81204bac:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar2,lVar5,puVar1[1]);
		  if (ABS(*(double *)(param1 + 0x30)) < 9.223372036854776e+18) {
		    lVar5 = (longlong)*(double *)(param1 + 0x30);
		  }
		  else {
		    lVar5 = -0x8000000000000000;
		  }
		  piVar2 = *(int **)(param1_00 + 0xc);
		  iVar3 = *piVar2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x81204c5b;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,2);
		code_r0x81204c5b:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar2,lVar5,puVar1[1]);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_List_IRewardInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		  iVar3 = Method_System_Collections_Generic_List_IRewardInfo__Add__;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = param1_00;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  param1_02 = unnamed_function_1417(Core_Data_RewardData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_02,param1_01,0);
		  return param1_02;
		}
		*/

			return null;
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0xABF3", Offset = "0xABF3", VA = "0xABF3")]
		public static RewardData ToRewardData(this ResourceSet rs)
		{
		/* --- GHIDRA: ToRewardData ---
		int Core_Extensions_Dict_ResourceSetExt__ToRewardData(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  double dVar2;
		  
		  if (DAT_ram_00a5a337 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_NullableResourceSet_TypeInfo);
		    DAT_ram_00a5a337 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_NullableResourceSet_TypeInfo);
		  dVar2 = -1.0;
		  if (*(double *)(param1 + 0x18) != 0.0) {
		    dVar2 = *(double *)(param1 + 0x18);
		  }
		  *(double *)(iVar1 + 0x18) = dVar2;
		  dVar2 = -1.0;
		  if (*(double *)(param1 + 0x10) != 0.0) {
		    dVar2 = *(double *)(param1 + 0x10);
		  }
		  *(double *)(iVar1 + 0x10) = dVar2;
		  dVar2 = -1.0;
		  if (*(double *)(param1 + 0x30) != 0.0) {
		    dVar2 = *(double *)(param1 + 0x30);
		  }
		  *(double *)(iVar1 + 0x30) = dVar2;
		  dVar2 = -1.0;
		  if (*(double *)(param1 + 0x28) != 0.0) {
		    dVar2 = *(double *)(param1 + 0x28);
		  }
		  *(double *)(iVar1 + 0x28) = dVar2;
		  dVar2 = -1.0;
		  if (*(double *)(param1 + 0x20) != 0.0) {
		    dVar2 = *(double *)(param1 + 0x20);
		  }
		  *(double *)(iVar1 + 0x20) = dVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0xABF4", Offset = "0xABF4", VA = "0xABF4")]
		public static NullableResourceSet ToNullableResourceSet(this ResourceSet value)
		{
		/* --- GHIDRA: ToNullableResourceSet ---
		undefined4
		Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		          (int *param1,double param2,int param3,undefined4 param4,int param5,int param6,
		          undefined4 param7)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint *puVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int *piVar10;
		  uint uVar11;
		  double dVar12;
		  int *piVar13;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  dVar12 = param2;
		  if (DAT_ram_00a5a338 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11297);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22663);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25821);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22941);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7041);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21420);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25504);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10775);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6827);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4379);
		    DAT_ram_00a5a338 = '\x01';
		  }
		  uVar8 = (undefined4)((ulonglong)dVar12 >> 0x20);
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_string___ctor__);
		  local_10 = ZEXT48(&local_4) << 0x20;
		  local_4 = param1;
		code_r0x81204f2c:
		  do {
		    piVar10 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar2 = (undefined4 *)(iVar9 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x81204fc0;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8120574d:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		code_r0x81204fc0:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar10,puVar2[1]);
		    piVar10 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8120574d;
		    if (iVar9 == 0) goto code_r0x812057da;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8);
		        if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar13) {
		          puVar2 = (undefined4 *)(iVar9 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x8120509b;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81205757:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		code_r0x8120509b:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar10,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81205757;
		    dVar12 = *(double *)(iVar9 + 0x10);
		    if (param5 == 0) {
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Utils_StringUtils_TypeInfo);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81205791;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_idii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x337,dVar12,
		                         StringLiteral_28780,0);
		      iVar6 = DAT_ram_009d3e38;
		      uVar8 = (undefined4)((ulonglong)dVar12 >> 0x20);
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81205791;
		      }
		    }
		    else {
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Utils_StringUtils_TypeInfo);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81205791;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_idii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a3,dVar12,0,0);
		      iVar6 = DAT_ram_009d3e38;
		      uVar8 = (undefined4)((ulonglong)dVar12 >> 0x20);
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81205791;
		      }
		    }
		    if (param6 != 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,uVar5,param6,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81205791;
		      }
		    }
		    iVar6 = **(int **)(iVar9 + 8);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(iVar6 + 0xd8),*(int **)(iVar9 + 8),
		                       *(undefined4 *)(iVar6 + 0xdc));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_22051,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		    puVar2 = &StringLiteral_10774;
		    if (iVar4 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_22663,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81205791;
		      }
		      puVar2 = &StringLiteral_10775;
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_22941,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81205791;
		        }
		        puVar2 = &StringLiteral_6827;
		        if (iVar4 == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_25821,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81205791;
		          }
		          puVar2 = &StringLiteral_11297;
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            iVar4 = System_Collections_CollectionBase___ctor(uVar3,StringLiteral_21420,0);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81205791;
		            }
		            puVar2 = &StringLiteral_4379;
		            if (iVar4 == 0) {
		              uVar3 = *(undefined4 *)(iVar9 + 8);
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::invoke_ii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                 &StringLiteral_4623);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar5 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,uVar5,
		                                   uVar3,0);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar3 = import::env::invoke_ii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                     &System_NotSupportedException_TypeInfo);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    uVar3 = import::env::invoke_ii
		                                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar3
		                                      );
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_viii
		                                (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1f8,uVar3,uVar5
		                                 ,0);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        uVar5 = import::env::invoke_ii
		                                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                           &
		                                           Method_Core_Extensions_Dict_ResourceSetExt_ToLocaleString__
		                                          );
		                        if (DAT_ram_009d3e38 != 1) {
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_vii(0x41b,uVar3,uVar5);
		                          if (DAT_ram_009d3e38 != 1) {
		                            do {
		                              halt_trap();
		                            } while( true );
		                          }
		                        }
		                      }
		                    }
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81205791;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81205791;
		            }
		          }
		        }
		      }
		    }
		    uVar3 = *puVar2;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_GameLocalization_TypeInfo);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81205791;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiiiiiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ce,uVar3,1,0,1,0,0,0,0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,
		                       System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		    local_18 = 0;
		    DAT_ram_009d3e38 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_28217,uVar5,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81205791;
		    }
		    *(undefined8 *)(iVar6 + 0x10) = local_18;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xf2,uVar3,iVar6,0);
		    iVar9 = Method_System_Collections_Generic_List_string__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar1 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		      *(undefined4 *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = uVar5;
		      goto code_r0x81204f2c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar5,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81205791:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 != iVar6) {
		code_r0x812058da:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a4,&local_10);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      import::env::__resumeException(uVar5);
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
		  puVar2 = (undefined4 *)import::env::__cxa_begin_catch(uVar5);
		  DAT_ram_009d3e38 = 0;
		  local_10 = CONCAT44(local_10._4_4_,*puVar2);
		  import::env::invoke_v(0x123);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		    goto code_r0x812058da;
		  }
		code_r0x812057da:
		  DAT_ram_009d3e38 = 0;
		  piVar10 = (int *)*local_10._4_4_;
		  if (piVar10 != (int *)0x0) {
		    uVar11 = 0;
		    iVar9 = *piVar10;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		          puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81205855;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x81205855:
		    (**(code **)((ulonglong)*puVar7 * 4))
		              (CONCAT44(in_register_20000004,piVar10),CONCAT44(uVar8,puVar7[1]));
		  }
		  iVar9 = Method_System_Collections_Generic_List_string__Add__;
		  if ((int)local_10 != 0) {
		    System_Data_DataSet__ValidateLocaleConstraint((int)local_10);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if ((ulonglong)ABS(param2) < 0x7ff0000000000001) {
		    if (param5 == 0) {
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      uVar8 = UI_SimpleIconValue__set_IconAssetId(param2,StringLiteral_28780,0);
		    }
		    else {
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      uVar8 = func_ii_8614(param2,0,0);
		    }
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_7041,1,0,1,0,0,0,0);
		    iVar9 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_28217,uVar8,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(longlong *)(iVar9 + 0x10) = local_10;
		    local_18 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,StringLiteral_25504,param3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar9 + 0x18) = local_18;
		    uVar8 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar5,iVar9,0);
		    iVar9 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar1 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar11 + 1;
		      *(undefined4 *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = uVar8;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,uVar8,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  else if (param3 != 0) {
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar1 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      iVar9 = uVar11 + 1;
		      *(int *)(iVar1 + 0xc) = iVar9;
		      *(int *)(*(int *)(iVar1 + 8) + uVar11 * 4 + 0x10) = param3;
		      goto code_r0x81205a7a;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,param3,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  }
		  iVar9 = *(int *)(iVar1 + 0xc);
		code_r0x81205a7a:
		  uVar8 = StringLiteral_5;
		  if (0 < iVar9) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar8 = func_ii_7508(param4,1,0,1,0,0,0,0);
		    uVar8 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_118,uVar8,StringLiteral_118,0);
		    uVar8 = func_ii_7793(uVar8,iVar1,0);
		  }
		  return uVar8;
		}
		*/

			return null;
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0xABF5", Offset = "0xABF5", VA = "0xABF5")]
		public static string ToLocaleString(this Money money, double externalMoneyValue = double.NaN, [Optional] string externalMoneyName, string separatelocaleKey = "AND", bool numberReduction = false, [Optional] string suffix)
		{
		/* --- GHIDRA: ToLocaleString ---
		void Core_Extensions_Dict_ResourceSetExt__ToLocaleString(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a33a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_ResourceSetExt___c_TypeInfo);
		    DAT_ram_00a5a33a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Extensions_Dict_ResourceSetExt___c_TypeInfo);
		  **(undefined4 **)(Core_Extensions_Dict_ResourceSetExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: ToLocaleString ---
		void Core_Extensions_Dict_ResourceSetExt__ToLocaleString(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a33a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_ResourceSetExt___c_TypeInfo);
		    DAT_ram_00a5a33a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Extensions_Dict_ResourceSetExt___c_TypeInfo);
		  **(undefined4 **)(Core_Extensions_Dict_ResourceSetExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0xABF6", Offset = "0xABF6", VA = "0xABF6")]
		public static string ToLocaleString(this ResourceSet rs, double externalMoneyValue = double.NaN, [Optional] string externalMoneyName, string separateLocaleKey = "AND", bool numberReduction = false, [Optional] string suffix)
		{
			return null;
		}
	}
}
