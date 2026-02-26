using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001055 RID: 4181
	[Token(Token = "0x2001055")]
	public static class ExpectedErrorsHandler
	{
		// Token: 0x06006231 RID: 25137 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6006231")]
		[Address(RVA = "0xAE5C", Offset = "0xAE5C", VA = "0xAE5C")]
		private static bool InternalHandler(int errorCode, Type[] errorTypes, params KeyValuePair<Type, object>[] errorsArgs)
		{
		/* --- GHIDRA: InternalHandler ---
		void Core_Errors_Expected_ExpectedErrorsHandler__InternalHandler(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a373 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo);
		    DAT_ram_00a5a373 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo);
		  **(undefined4 **)(Core_Errors_Expected_ExpectedErrorsHandler___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x6006232")]
		public static bool HandleErrorChain<E1>(int errorCode, [Optional] object errorArg) where E1 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6006233")]
		public static bool HandleErrorChain<E1, E2>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x6006234")]
		public static bool HandleErrorChain<E1, E2, E3>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2, [Optional] object errorArg3) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new() where E3 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x6006235")]
		public static bool HandleErrorChain<E1, E2, E3, E4>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2, [Optional] object errorArg3, [Optional] object errorArg4) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new() where E3 : ExpectedDefaultError, new() where E4 : ExpectedDefaultError, new()
		{
			return default(bool);
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6006236")]
		public static bool HandleErrorChain<E1, E2, E3, E4, E5>(int errorCode, [Optional] object errorArg1, [Optional] object errorArg2, [Optional] object errorArg3, [Optional] object errorArg4, [Optional] object errorArg5) where E1 : ExpectedDefaultError, new() where E2 : ExpectedDefaultError, new() where E3 : ExpectedDefaultError, new() where E4 : ExpectedDefaultError, new() where E5 : ExpectedDefaultError, new()
		{
			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: HandleErrorChain<object> ---
		undefined4
		Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		          (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  int param1_00;
		  int param1_01;
		  int *param2_00;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  puVar2 = *(undefined4 **)(param4 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_KeyValuePair_Type__object____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    puVar2 = *(undefined4 **)(param4 + 0x1c);
		    if (puVar2 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		      puVar2 = *(undefined4 **)(param4 + 0x1c);
		    }
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  param1_00 = func_ii_2734(uVar3,0);
		  param1_01 = func_ii_2734(*(undefined4 *)(*(int *)(param4 + 0x1c) + 4),0);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(System_Type___TypeInfo,2);
		  if ((param1_00 != 0) &&
		     (iVar1 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param1_00;
		  if ((param1_01 != 0) &&
		     (iVar1 = func_ii_1082(param1_01,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param1_01;
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_Type__object____TypeInfo,2);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,param1_00,param2,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,param1_01,param3,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x18) = local_10;
		  uVar3 = Core_Errors_Expected_ExpectedDefaultError___ctor(param1,param2_00,iVar1,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: HandleErrorChain<object, object> ---
		undefined4
		Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object_
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5)
		
		{
		  int param1_00;
		  int param1_01;
		  int param1_02;
		  int *param2_00;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  puVar2 = *(undefined4 **)(param5 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_KeyValuePair_Type__object____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    puVar2 = *(undefined4 **)(param5 + 0x1c);
		    if (puVar2 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param5);
		      puVar2 = *(undefined4 **)(param5 + 0x1c);
		    }
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  param1_00 = func_ii_2734(uVar3,0);
		  param1_01 = func_ii_2734(*(undefined4 *)(*(int *)(param5 + 0x1c) + 4),0);
		  param1_02 = func_ii_2734(*(undefined4 *)(*(int *)(param5 + 0x1c) + 8),0);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(System_Type___TypeInfo,3);
		  if ((param1_00 != 0) &&
		     (iVar1 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param1_00;
		  if ((param1_01 != 0) &&
		     (iVar1 = func_ii_1082(param1_01,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param1_01;
		  if ((param1_02 != 0) &&
		     (iVar1 = func_ii_1082(param1_02,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param1_02;
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_Type__object____TypeInfo,3);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,param1_00,param2,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,param1_01,param3,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x18) = local_10;
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,param1_02,param4,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x20) = local_18;
		  uVar3 = Core_Errors_Expected_ExpectedDefaultError___ctor(param1,param2_00,iVar1,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: HandleErrorChain<object, object, object> ---
		undefined4
		Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object__object_
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,int param6)
		
		{
		  int param1_00;
		  int param1_01;
		  int param1_02;
		  int param1_03;
		  int *param2_00;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  puVar2 = *(undefined4 **)(param6 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_KeyValuePair_Type__object____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    puVar2 = *(undefined4 **)(param6 + 0x1c);
		    if (puVar2 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param6);
		      puVar2 = *(undefined4 **)(param6 + 0x1c);
		    }
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  param1_00 = func_ii_2734(uVar3,0);
		  param1_01 = func_ii_2734(*(undefined4 *)(*(int *)(param6 + 0x1c) + 4),0);
		  param1_02 = func_ii_2734(*(undefined4 *)(*(int *)(param6 + 0x1c) + 8),0);
		  param1_03 = func_ii_2734(*(undefined4 *)(*(int *)(param6 + 0x1c) + 0xc),0);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(System_Type___TypeInfo,4);
		  if ((param1_00 != 0) &&
		     (iVar1 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param1_00;
		  if ((param1_01 != 0) &&
		     (iVar1 = func_ii_1082(param1_01,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param1_01;
		  if ((param1_02 != 0) &&
		     (iVar1 = func_ii_1082(param1_02,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param1_02;
		  if ((param1_03 != 0) &&
		     (iVar1 = func_ii_1082(param1_03,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = param1_03;
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_Type__object____TypeInfo,4);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,param1_00,param2,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,param1_01,param3,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x18) = local_10;
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,param1_02,param4,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x20) = local_18;
		  local_20 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,param1_03,param5,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x28) = local_20;
		  uVar3 = Core_Errors_Expected_ExpectedDefaultError___ctor(param1,param2_00,iVar1,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: HandleErrorChain<object, object, object, object> ---
		undefined4
		Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object__object__object_
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          ,undefined4 param6,int param7)
		
		{
		  int param1_00;
		  int param1_01;
		  int param1_02;
		  int param1_03;
		  int param1_04;
		  int *param2_00;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  puVar2 = *(undefined4 **)(param7 + 0x1c);
		  if (puVar2 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_KeyValuePair_Type__object____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Type___TypeInfo);
		    puVar2 = *(undefined4 **)(param7 + 0x1c);
		    if (puVar2 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param7);
		      puVar2 = *(undefined4 **)(param7 + 0x1c);
		    }
		  }
		  uVar3 = *puVar2;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  param1_00 = func_ii_2734(uVar3,0);
		  param1_01 = func_ii_2734(*(undefined4 *)(*(int *)(param7 + 0x1c) + 4),0);
		  param1_02 = func_ii_2734(*(undefined4 *)(*(int *)(param7 + 0x1c) + 8),0);
		  param1_03 = func_ii_2734(*(undefined4 *)(*(int *)(param7 + 0x1c) + 0xc),0);
		  param1_04 = func_ii_2734(*(undefined4 *)(*(int *)(param7 + 0x1c) + 0x10),0);
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(System_Type___TypeInfo,5);
		  if ((param1_00 != 0) &&
		     (iVar1 = func_ii_1082(param1_00,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[4] = param1_00;
		  if ((param1_01 != 0) &&
		     (iVar1 = func_ii_1082(param1_01,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = param1_01;
		  if ((param1_02 != 0) &&
		     (iVar1 = func_ii_1082(param1_02,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[6] = param1_02;
		  if ((param1_03 != 0) &&
		     (iVar1 = func_ii_1082(param1_03,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = param1_03;
		  if ((param1_04 != 0) &&
		     (iVar1 = func_ii_1082(param1_04,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0)) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[8] = param1_04;
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_Type__object____TypeInfo,5);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,param1_00,param2,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_8;
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,param1_01,param3,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x18) = local_10;
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,param1_02,param4,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x20) = local_18;
		  local_20 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,param1_03,param5,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x28) = local_20;
		  local_28 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_28,param1_04,param6,
		             Method_System_Collections_Generic_KeyValuePair_Type__object___ctor__);
		  *(undefined8 *)(iVar1 + 0x30) = local_28;
		  uVar3 = Core_Errors_Expected_ExpectedDefaultError___ctor(param1,param2_00,iVar1,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: HandleErrorChain<object, object, object, object, object> ---
		undefined4
		Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object__object__object__object__object_
		          (undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 uVar1;
		  
		  if ((*(int *)(param3 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&System_Linq_Expressions_Expression_TypeInfo),
		     *(int *)(param3 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  if (*(int *)(System_Linq_Expressions_Expression_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Linq_Expressions_Expression_TypeInfo);
		  }
		  uVar1 = System_Linq_Expressions_Expression__Lambda_object_
		                    (param1,0,0,param2,**(undefined4 **)(param3 + 0x1c));
		  return uVar1;
		}
		*/

}
