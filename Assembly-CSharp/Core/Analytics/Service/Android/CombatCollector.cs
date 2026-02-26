using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001290 RID: 4752
	[Token(Token = "0x2001290")]
	public class CombatCollector : IDisposable
	{
		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x000147D8 File Offset: 0x000129D8
		// (set) Token: 0x060070EA RID: 28906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001702")]
		public bool IsFinished
		{
			[Token(Token = "0x60070E9")]
			[Address(RVA = "0xBB10", Offset = "0xBB10", VA = "0xBB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60070EA")]
			[Address(RVA = "0xBB11", Offset = "0xBB11", VA = "0xBB11")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x000147F0 File Offset: 0x000129F0
		// (set) Token: 0x060070EC RID: 28908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001703")]
		public bool? Win
		{
			[Token(Token = "0x60070EB")]
			[Address(RVA = "0xBB12", Offset = "0xBB12", VA = "0xBB12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60070EC")]
			[Address(RVA = "0xBB13", Offset = "0xBB13", VA = "0xBB13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070ED")]
		[Address(RVA = "0xBB14", Offset = "0xBB14", VA = "0xBB14", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Analytics_Service_Android_CombatCollector__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  ushort local_2;
		  
		  if (DAT_ram_00a594b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    DAT_ram_00a594b4 = '\x01';
		  }
		  if (*(char *)(param1 + 8) == '\0') {
		    local_2 = 0;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_2,param2,Method_System_Nullable_bool___ctor__);
		    *(undefined1 *)(param1 + 0x18) = 1;
		    *(ushort *)(param1 + 0x19) = local_2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060070EE RID: 28910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070EE")]
		[Address(RVA = "0xBB15", Offset = "0xBB15", VA = "0xBB15")]
		public void Finish(bool win)
		{
		/* --- GHIDRA: Finish ---
		void Core_Analytics_Service_Android_CombatCollector__Finish
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a594b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    DAT_ram_00a594b5 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		  param1_00 = *(int *)(param1 + 0xc);
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

		// Token: 0x060070EF RID: 28911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070EF")]
		[Address(RVA = "0xBB16", Offset = "0xBB16", VA = "0xBB16")]
		public void UseElixir(uint elixirId)
		{
		/* --- GHIDRA: UseElixir ---
		void Core_Analytics_Service_Android_CombatCollector__UseElixir
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a594b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    DAT_ram_00a594b6 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		  param1_00 = *(int *)(param1 + 0x10);
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

		// Token: 0x060070F0 RID: 28912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F0")]
		[Address(RVA = "0xBB17", Offset = "0xBB17", VA = "0xBB17")]
		public void UseSpell(uint spellId)
		{
		/* --- GHIDRA: UseSpell ---
		void Core_Analytics_Service_Android_CombatCollector__UseSpell
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a594b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Enum_TryParse_StonesTypes___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_StonesTypes__int___Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_StonesTypes__int___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_460);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7904);
		    DAT_ram_00a594b7 = '\x01';
		  }
		  local_c = 0;
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar1 = System_Enum__TryParse___Il2CppFullySharedGenericStructType_
		                    (param2,1,&local_c,Method_System_Enum_TryParse_StonesTypes___);
		  if (iVar1 == 0) {
		    param1_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                          (StringLiteral_7904,param2,StringLiteral_460,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(param1_00,0);
		  }
		  else {
		    param1_01 = *(int *)(param1 + 0x14);
		    local_18 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_18,local_c,param3,Method_System_ValueTuple_StonesTypes__int___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_ValueTuple_StonesTypes__int___Add__;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_01 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar2 + 1;
		      *(undefined8 *)(*(int *)(param1_01 + 8) + uVar2 * 8 + 0x10) = local_18;
		    }
		    else {
		      local_20 = local_18;
		      local_8 = local_18;
		      Core_Data_CollectionData__get_CollectionId
		                (param1_01,&local_20,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F1")]
		[Address(RVA = "0xBB18", Offset = "0xBB18", VA = "0xBB18")]
		public void Combo(string stoneType, int numStones)
		{
		/* --- GHIDRA: Combo ---
		uint * Core_Analytics_Service_Android_CombatCollector__Combo(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  int iVar12;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a594b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Count_ValueTuple_StonesTypes__int____);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_GroupBy_ValueTuple_StonesTypes__int___StonesTypes___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__string___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ValueTuple_StonesTypes__int___StonesTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_IGrouping_StonesTypes__ValueTuple_StonesTypes__int____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_IGrouping_StonesTypes__ValueTuple_StonesTypes__int____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Linq_IGrouping_StonesTypes__ValueTuple_StonesTypes__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Newtonsoft_Json_JsonConvert_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_StonesTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_CombatCollector___c__ToString_b__17_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_CombatCollector___c__ToString_b__17_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Service_Android_CombatCollector___c__ToString_b__17_2__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28347);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22869);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27346);
		    DAT_ram_00a594b8 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  uVar7 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		  }
		  uVar1 = StringLiteral_22869;
		  uVar5 = StringLiteral_19176;
		  puVar8 = *(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c);
		  iVar9 = puVar8[1];
		  if (iVar9 == 0) {
		    if (*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar8;
		    iVar9 = unnamed_function_1417(System_Func_uint__string__TypeInfo);
		    System_Linq_Enumerable__Distinct_uint_
		              (iVar9,uVar10,
		               Method_Core_Analytics_Service_Android_CombatCollector___c__ToString_b__17_1__,0);
		    *(int *)(*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c) + 4) =
		         iVar9;
		  }
		  uVar7 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar7,iVar9,Method_System_Linq_Enumerable_Select_uint__string___);
		  uVar7 = func_ii_7793(uVar5,uVar7,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,uVar7,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar7 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		  }
		  uVar1 = StringLiteral_27346;
		  uVar5 = StringLiteral_19176;
		  puVar8 = *(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c);
		  iVar9 = puVar8[2];
		  if (iVar9 == 0) {
		    if (*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar8;
		    iVar9 = unnamed_function_1417(System_Func_uint__string__TypeInfo);
		    System_Linq_Enumerable__Distinct_uint_
		              (iVar9,uVar10,
		               Method_Core_Analytics_Service_Android_CombatCollector___c__ToString_b__17_2__,0);
		    *(int *)(*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c) + 8) =
		         iVar9;
		  }
		  uVar7 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar7,iVar9,Method_System_Linq_Enumerable_Select_uint__string___);
		  uVar7 = func_ii_7793(uVar5,uVar7,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,uVar1,uVar7,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  local_18 = CONCAT31(local_18._1_3_,0xff < *(ushort *)(param1 + 0x19));
		  uVar7 = func_ii_1081(DAT_ram_00a66944,&local_18);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_28347,uVar7,
		             Method_System_Collections_Generic_Dictionary_string__object__Add__);
		  uVar7 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c);
		  iVar9 = puVar8[3];
		  if (iVar9 == 0) {
		    if (*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar8;
		    iVar9 = unnamed_function_1417(System_Func_ValueTuple_StonesTypes__int___StonesTypes__TypeInfo);
		    System_Func_ValueTuple_Int32Enum__int___ValueTuple_Int32Enum__int____Invoke
		              (iVar9,uVar5,
		               Method_Core_Analytics_Service_Android_CombatCollector___c__ToString_b__17_0__,0);
		    *(int *)(*(int *)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c) + 0xc) =
		         iVar9;
		  }
		  uVar2 = 0;
		  piVar3 = (int *)System_Linq_Enumerable__GroupBy_KeyValuePair_object__object___object_
		                            (uVar7,iVar9,
		                             Method_System_Linq_Enumerable_GroupBy_ValueTuple_StonesTypes__int___StonesTypes___
		                            );
		  iVar9 = *piVar3;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_IGrouping_StonesTypes__ValueTuple_StonesTypes__int____TypeInfo
		          == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8100ff5f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_IEnumerable_IGrouping_StonesTypes__ValueTuple_StonesTypes__int____TypeInfo
		                                ,0);
		code_r0x8100ff5f:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar3 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar8 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x81010032;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81010398:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810103a0;
		    }
		code_r0x81010032:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar9 = import::env::invoke_iii(*puVar8,piVar3,puVar8[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81010398;
		    if (iVar9 == 0) {
		      iVar6 = 7;
		      iVar9 = 0;
		      puVar4 = DAT_ram_009d3e38;
		      goto code_r0x810103ed;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerator_IGrouping_StonesTypes__ValueTuple_StonesTypes__int____TypeInfo
		            == *piVar11) {
		          puVar8 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x8101010c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_IGrouping_StonesTypes__ValueTuple_StonesTypes__int____TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x8101035c:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810103a0;
		    }
		code_r0x8101010c:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    piVar3 = (int *)import::env::invoke_iii(*puVar8,piVar3,puVar8[1]);
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x8101035c;
		    iVar9 = *piVar3;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Linq_IGrouping_StonesTypes__ValueTuple_StonesTypes__int___TypeInfo == *piVar11) {
		          puVar8 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x810101dd;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar3,
		                        System_Linq_IGrouping_StonesTypes__ValueTuple_StonesTypes__int___TypeInfo,0)
		    ;
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81010366:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810103a0;
		    }
		code_r0x810101dd:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar7 = import::env::invoke_iii(*puVar8,piVar3,puVar8[1]);
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81010366;
		    local_14 = 0xffffffff;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_18 = Protocol_Combat_StonesTypes_TypeInfo;
		    local_10 = uVar7;
		    uVar7 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x293,&local_18,0);
		    iVar9 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (iVar9 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810103a0;
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar7 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d9,uVar7,0)
		    ;
		    iVar9 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (iVar9 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810103a0;
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2da,piVar3,
		                       Method_System_Linq_Enumerable_Count_ValueTuple_StonesTypes__int____);
		    iVar9 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (iVar9 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810103a0;
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_1c = uVar5;
		    uVar5 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66954,
		                       &local_1c);
		    if (DAT_ram_009d3e38 == (uint *)0x1) break;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_00,uVar7,uVar5,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  } while (DAT_ram_009d3e38 != (uint *)0x1);
		  DAT_ram_009d3e38 = (uint *)0x0;
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810103a0:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar7);
		    iVar9 = *piVar3;
		    iVar6 = 0;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    puVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar4 != (uint *)0x1) {
		code_r0x810103ed:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar2 = 0;
		        iVar12 = *local_4;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8)) {
		              puVar4 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x81010465;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81010465:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar9 == 0) {
		        if ((iVar6 == 0) ||
		           ((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) &&
		            (((iVar6 != 4 && (iVar6 != 5)) && ((iVar6 != 6 && (iVar6 == 7)))))))) {
		          if (*(int *)(Newtonsoft_Json_JsonConvert_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Newtonsoft_Json_JsonConvert_TypeInfo);
		          }
		          puVar4 = (uint *)Newtonsoft_Json_JsonConvert__ToString(param1_00,0);
		        }
		        return puVar4;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2db,&local_c);
		  iVar9 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60070F2")]
		[Address(RVA = "0xBB19", Offset = "0xBB19", VA = "0xBB19", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Analytics_Service_Android_CombatCollector__ToString(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a594b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_StonesTypes__int____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ValueTuple_StonesTypes__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a594b9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_ValueTuple_StonesTypes__int___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ValueTuple_StonesTypes__int____ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F3")]
		[Address(RVA = "0xBB1A", Offset = "0xBB1A", VA = "0xBB1A")]
		public CombatCollector()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Analytics_Service_Android_CombatCollector___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a594ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		    DAT_ram_00a594ba = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo);
		  **(undefined4 **)(Core_Analytics_Service_Android_CombatCollector___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003AED RID: 15085
		[Token(Token = "0x4003AED")]
		[FieldOffset(Offset = "0x8")]
		private bool _isDisposed;

		// Token: 0x04003AEE RID: 15086
		[Token(Token = "0x4003AEE")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<uint> _elixirs;

		// Token: 0x04003AEF RID: 15087
		[Token(Token = "0x4003AEF")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<uint> _spells;

		// Token: 0x04003AF0 RID: 15088
		[Token(Token = "0x4003AF0")]
		[FieldOffset(Offset = "0x14")]
		[TupleElementNames(new string[]
		{
			"type",
			"numStones"
		})]
		private readonly List<ValueTuple<StonesTypes, int>> _combos;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsFinished ---
		void Core_Analytics_Service_Android_CombatCollector__set_IsFinished
		               (undefined2 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined2 *)(param2 + 0x19);
		  return;
		}
		*/


		/* --- GHIDRA: get_Win ---
		void Core_Analytics_Service_Android_CombatCollector__get_Win
		               (int param1,undefined2 *param2,undefined4 param3)
		
		{
		  *(undefined2 *)(param1 + 0x19) = *param2;
		  return;
		}
		*/

}
