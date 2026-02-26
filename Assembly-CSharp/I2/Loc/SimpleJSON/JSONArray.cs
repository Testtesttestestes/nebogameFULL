using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013BC RID: 5052
	[Token(Token = "0x20013BC")]
	public class JSONArray : JSONNode, IEnumerable
	{
		// Token: 0x170017C8 RID: 6088
		[Token(Token = "0x170017C8")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600783F")]
			[Address(RVA = "0xC191", Offset = "0xC191", VA = "0xC191", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007840")]
			[Address(RVA = "0xC192", Offset = "0xC192", VA = "0xC192", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017C9 RID: 6089
		[Token(Token = "0x170017C9")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x6007841")]
			[Address(RVA = "0xC193", Offset = "0xC193", VA = "0xC193", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007842")]
			[Address(RVA = "0xC194", Offset = "0xC194", VA = "0xC194", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06007843 RID: 30787 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x170017CA")]
		public override int Count
		{
			[Token(Token = "0x6007843")]
			[Address(RVA = "0xC195", Offset = "0xC195", VA = "0xC195", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007844")]
		[Address(RVA = "0xC196", Offset = "0xC196", VA = "0xC196", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		/* --- GHIDRA: Add ---
		undefined4 I2_Loc_SimpleJSON_JSONArray__Add(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a54e53 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Item__);
		    DAT_ram_00a54e53 = '\x01';
		  }
		  if ((-1 < param2) && (param2 < *(int *)(*(int *)(param1 + 8) + 0xc))) {
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (*(int *)(param1 + 8),param2,
		                       Method_System_Collections_Generic_List_JSONNode__get_Item__);
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(param1 + 8),param2,
		               Method_System_Collections_Generic_List_JSONNode__RemoveAt__);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007845")]
		[Address(RVA = "0xC197", Offset = "0xC197", VA = "0xC197", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONArray__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e55 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray__get_Childs_d__13_TypeInfo);
		    DAT_ram_00a54e55 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray__get_Childs_d__13_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONArray__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e55 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray__get_Childs_d__13_TypeInfo);
		    DAT_ram_00a54e55 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray__get_Childs_d__13_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007846")]
		[Address(RVA = "0xC198", Offset = "0xC198", VA = "0xC198", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06007847 RID: 30791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017CB")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007847")]
			[Address(RVA = "0xC199", Offset = "0xC199", VA = "0xC199", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007848")]
		[Address(RVA = "0xC19A", Offset = "0xC19A", VA = "0xC19A", Slot = "29")]
		public IEnumerator GetEnumerator()
		{
		/* --- GHIDRA: GetEnumerator ---
		undefined4 I2_Loc_SimpleJSON_JSONArray__GetEnumerator(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_JSONNode__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_JSONNode__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_JSONNode__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18831);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_268);
		    DAT_ram_00a54e57 = '\x01';
		  }
		  iVar2 = StringLiteral_18831;
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_List_JSONNode__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    param2_00 = iVar2;
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_JSONNode__MoveNext__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b28314;
		    }
		    if (iVar1 == 0) goto code_r0x80b283b6;
		    piVar4 = local_8._4_4_;
		    iVar2 = param2_00;
		    if (2 < *(int *)(param2_00 + 8)) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,param2_00,
		                         StringLiteral_1238,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80b28314;
		      }
		    }
		    param2_00 = iVar2;
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(iVar2 + 0xd8),piVar4,*(undefined4 *)(iVar2 + 0xdc));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b28314;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,param2_00,uVar3,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80b28314:
		  iVar2 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80b283b6:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param2_00,StringLiteral_268,0);
		      return uVar3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x134,&local_18);
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

			return null;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007849")]
		[Address(RVA = "0xC19B", Offset = "0xC19B", VA = "0xC19B", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void I2_Loc_SimpleJSON_JSONArray__ToString(int param1,int *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int param1_00;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a54e59 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Item__);
		    DAT_ram_00a54e59 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		            (param2,1,*(undefined4 *)(*param2 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x140) * 4))
		            (param2,*(undefined4 *)(*(int *)(param1 + 8) + 0xc),*(undefined4 *)(*param2 + 0x144));
		  param1_00 = *(int *)(param1 + 8);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                                (param1_00,param2_00,
		                                 Method_System_Collections_Generic_List_JSONNode__get_Item__);
		      (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1a0) * 4))
		                (piVar1,param2,*(undefined4 *)(*piVar1 + 0x1a4));
		      param2_00 = param2_00 + 1;
		      param1_00 = *(int *)(param1 + 8);
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: ToString ---
		void I2_Loc_SimpleJSON_JSONArray__ToString(int param1,int *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int param1_00;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a54e59 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Item__);
		    DAT_ram_00a54e59 = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		            (param2,1,*(undefined4 *)(*param2 + 0x104));
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x140) * 4))
		            (param2,*(undefined4 *)(*(int *)(param1 + 8) + 0xc),*(undefined4 *)(*param2 + 0x144));
		  param1_00 = *(int *)(param1 + 8);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                                (param1_00,param2_00,
		                                 Method_System_Collections_Generic_List_JSONNode__get_Item__);
		      (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1a0) * 4))
		                (piVar1,param2,*(undefined4 *)(*piVar1 + 0x1a4));
		      param2_00 = param2_00 + 1;
		      param1_00 = *(int *)(param1 + 8);
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600784A")]
		[Address(RVA = "0xC19C", Offset = "0xC19C", VA = "0xC19C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600784B")]
		[Address(RVA = "0xC19D", Offset = "0xC19D", VA = "0xC19D", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		/* --- GHIDRA: Serialize ---
		void I2_Loc_SimpleJSON_JSONArray__Serialize(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a54e5a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_JSONNode__TypeInfo);
		    DAT_ram_00a54e5a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_JSONNode__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_JSONNode___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600784C")]
		[Address(RVA = "0xC19E", Offset = "0xC19E", VA = "0xC19E")]
		public JSONArray()
		{
		}

		// Token: 0x04003EF8 RID: 16120
		[Token(Token = "0x4003EF8")]
		[FieldOffset(Offset = "0x8")]
		private List<JSONNode> m_List;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Item ---
		void I2_Loc_SimpleJSON_JSONArray__get_Item
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a54e50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__Add__);
		    DAT_ram_00a54e50 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_JSONNode__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param3;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/


		/* --- GHIDRA: set_Item ---
		undefined4 I2_Loc_SimpleJSON_JSONArray__set_Item(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e51 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Count__);
		    DAT_ram_00a54e51 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0xc);
		}
		*/


		/* --- GHIDRA: get_Item ---
		void I2_Loc_SimpleJSON_JSONArray__get_Item
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a54e50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__Add__);
		    DAT_ram_00a54e50 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_JSONNode__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param3;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/


		/* --- GHIDRA: set_Item ---
		undefined4 I2_Loc_SimpleJSON_JSONArray__set_Item(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e51 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__get_Count__);
		    DAT_ram_00a54e51 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0xc);
		}
		*/


		/* --- GHIDRA: get_Count ---
		void I2_Loc_SimpleJSON_JSONArray__get_Count
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a54e52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_JSONNode__Add__);
		    DAT_ram_00a54e52 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_JSONNode__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param3;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/


		/* --- GHIDRA: get_Childs ---
		int I2_Loc_SimpleJSON_JSONArray__get_Childs(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a54e56 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONArray__GetEnumerator_d__14_TypeInfo);
		    DAT_ram_00a54e56 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONArray__GetEnumerator_d__14_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

}
