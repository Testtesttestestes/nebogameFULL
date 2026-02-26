using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace I2.Loc.SimpleJSON
{
	// Token: 0x020013BF RID: 5055
	[Token(Token = "0x20013BF")]
	public class JSONClass : JSONNode, IEnumerable
	{
		// Token: 0x170017D0 RID: 6096
		[Token(Token = "0x170017D0")]
		public override JSONNode this[string aKey]
		{
			[Token(Token = "0x600785D")]
			[Address(RVA = "0xC1AF", Offset = "0xC1AF", VA = "0xC1AF", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600785E")]
			[Address(RVA = "0xC1B0", Offset = "0xC1B0", VA = "0xC1B0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170017D1 RID: 6097
		[Token(Token = "0x170017D1")]
		public override JSONNode this[int aIndex]
		{
			[Token(Token = "0x600785F")]
			[Address(RVA = "0xC1B1", Offset = "0xC1B1", VA = "0xC1B1", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007860")]
			[Address(RVA = "0xC1B2", Offset = "0xC1B2", VA = "0xC1B2", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x000161E8 File Offset: 0x000143E8
		[Token(Token = "0x170017D2")]
		public override int Count
		{
			[Token(Token = "0x6007861")]
			[Address(RVA = "0xC1B3", Offset = "0xC1B3", VA = "0xC1B3", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007862")]
		[Address(RVA = "0xC1B4", Offset = "0xC1B4", VA = "0xC1B4", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		/* --- GHIDRA: Add ---
		undefined4 I2_Loc_SimpleJSON_JSONClass__Add(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a54e66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Item__);
		    DAT_ram_00a54e66 = '\x01';
		  }
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 8),param2,
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__ContainsKey__);
		  if (iVar2 != 0) {
		    uVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 8),param2,
		                       Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Item__);
		    System_Linq_Enumerable__First_KeyValuePair_object__object__
		              (*(undefined4 *)(param1 + 8),param2,
		               Method_System_Collections_Generic_Dictionary_string__JSONNode__Remove__);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007863")]
		[Address(RVA = "0xC1B5", Offset = "0xC1B5", VA = "0xC1B5", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONClass__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e69 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass__get_Childs_d__14_TypeInfo);
		    DAT_ram_00a54e69 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass__get_Childs_d__14_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONClass__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e69 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass__get_Childs_d__14_TypeInfo);
		    DAT_ram_00a54e69 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass__get_Childs_d__14_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: Remove ---
		int I2_Loc_SimpleJSON_JSONClass__Remove(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a54e69 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass__get_Childs_d__14_TypeInfo);
		    DAT_ram_00a54e69 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass__get_Childs_d__14_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007864")]
		[Address(RVA = "0xC1B6", Offset = "0xC1B6", VA = "0xC1B6", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007865")]
		[Address(RVA = "0xC1B7", Offset = "0xC1B7", VA = "0xC1B7", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017D3")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6007866")]
			[Address(RVA = "0xC1B8", Offset = "0xC1B8", VA = "0xC1B8", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007867")]
		[Address(RVA = "0xC1B9", Offset = "0xC1B9", VA = "0xC1B9", Slot = "29")]
		public IEnumerator GetEnumerator()
		{
		/* --- GHIDRA: GetEnumerator ---
		int I2_Loc_SimpleJSON_JSONClass__GetEnumerator(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int local_30;
		  undefined1 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined1 local_18 [8];
		  undefined4 local_10;
		  undefined4 uStack_c;
		  int *local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a54e6b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__JSONNode__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Enumerator_string__JSONNode__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_string__JSONNode__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__JSONNode__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__JSONNode__get_Value__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_574);
		    Mono_Security_ASN1__get_Item(&StringLiteral_527);
		    DAT_ram_00a54e6b = '\x01';
		  }
		  iVar6 = StringLiteral_28547;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_30,*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_string__JSONNode__GetEnumerator__);
		  local_8 = (int *)local_20;
		  uStack_4 = (undefined4)((ulonglong)local_20 >> 0x20);
		  local_10 = (undefined4)local_28;
		  uStack_c = (undefined4)((ulonglong)local_28 >> 0x20);
		  local_30 = 0;
		  puStack_2c = local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_string__JSONNode__MoveNext__
		                      );
		    piVar5 = local_8;
		    uVar3 = uStack_c;
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = iVar6;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b29af8;
		    }
		    if (iVar1 == 0) {
		      iVar1 = 5;
		      iVar4 = local_30;
		      goto code_r0x80b29b45;
		    }
		    if (2 < *(int *)(iVar6 + 8)) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e4,iVar6,
		                         StringLiteral_1238,0);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar2 = iVar6;
		        goto code_r0x80b29af8;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,string___TypeInfo,5);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b29af8;
		    }
		    *(int *)(iVar4 + 0x10) = iVar2;
		    *(undefined4 *)(iVar4 + 0x14) = StringLiteral_527;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x13c,uVar3,iVar4);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b29af8;
		    }
		    *(undefined4 *)(iVar4 + 0x18) = uVar3;
		    *(undefined4 *)(iVar4 + 0x1c) = StringLiteral_574;
		    if (DAT_ram_00a54e3e == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a54e3e = '\x01';
		        goto code_r0x80b299d2;
		      }
		code_r0x80b29acb:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b29af8;
		    }
		code_r0x80b299d2:
		    uVar3 = 0;
		    if (piVar5 != (int *)0x0) {
		      iVar6 = *piVar5;
		      if (((uint)*(byte *)(iVar6 + 0xb8) <
		           (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8)) ||
		         (uVar3 = 0,
		         *(int *)(*(int *)(iVar6 + 100) +
		                  (uint)*(byte *)(I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo + 0xb8) * 4 + -4) !=
		         I2_Loc_SimpleJSON_JSONLazyCreator_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (*(undefined4 *)(iVar6 + 0x108),piVar5,*(undefined4 *)(iVar6 + 0x10c));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80b29acb;
		      }
		    }
		    *(undefined4 *)(iVar4 + 0x20) = uVar3;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x236,iVar4,0)
		    ;
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80b29af8:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar6) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    iVar1 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80b29b45:
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 0) {
		        if ((iVar1 == 0) ||
		           ((((iVar1 != 1 && (iVar1 != 2)) && (iVar1 != 3)) && ((iVar1 != 4 && (iVar1 == 5)))))) {
		          iVar6 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(iVar2,StringLiteral_28773,0);
		        }
		        return iVar6;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x13d,&local_30);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
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

		// Token: 0x06007868 RID: 30824 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007868")]
		[Address(RVA = "0xC1BA", Offset = "0xC1BA", VA = "0xC1BA", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void I2_Loc_SimpleJSON_JSONClass__ToString(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_string__JSONNode__GetEnumerator__
		              );
		    DAT_ram_00a54e6d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		            (param2,2,*(undefined4 *)(*param2 + 0x104));
		  uVar2 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x140) * 4))
		            (param2,uVar2,*(undefined4 *)(*param2 + 0x144));
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Keys__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_string__JSONNode__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x79,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2a29a;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    import::env::invoke_viii
		              (*(undefined4 *)(*param2 + 0x168),param2,local_8._4_4_,
		               *(undefined4 *)(*param2 + 0x16c));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2a29a;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,
		                               *(undefined4 *)(param1 + 8),uVar2,
		                               Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Item__
		                              );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2a29a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar4 + 0x1a0),piVar4,param2,*(undefined4 *)(*piVar4 + 0x1a4));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80b2a29a:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x13f,&local_18);
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

		/* --- GHIDRA: ToString ---
		void I2_Loc_SimpleJSON_JSONClass__ToString(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_string__JSONNode__GetEnumerator__
		              );
		    DAT_ram_00a54e6d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		            (param2,2,*(undefined4 *)(*param2 + 0x104));
		  uVar2 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x140) * 4))
		            (param2,uVar2,*(undefined4 *)(*param2 + 0x144));
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Keys__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_string__JSONNode__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x79,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_string__JSONNode__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2a29a;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    import::env::invoke_viii
		              (*(undefined4 *)(*param2 + 0x168),param2,local_8._4_4_,
		               *(undefined4 *)(*param2 + 0x16c));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2a29a;
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,
		                               *(undefined4 *)(param1 + 8),uVar2,
		                               Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Item__
		                              );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2a29a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar4 + 0x1a0),piVar4,param2,*(undefined4 *)(*piVar4 + 0x1a4));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80b2a29a:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x13f,&local_18);
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

			return null;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007869")]
		[Address(RVA = "0xC1BB", Offset = "0xC1BB", VA = "0xC1BB", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786A")]
		[Address(RVA = "0xC1BC", Offset = "0xC1BC", VA = "0xC1BC", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		/* --- GHIDRA: Serialize ---
		void I2_Loc_SimpleJSON_JSONClass__Serialize(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a54e6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__JSONNode__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a54e6e = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  if (DAT_ram_00a6628f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_StringComparer_TypeInfo);
		    DAT_ram_00a6628f = '\x01';
		  }
		  if (*(int *)(System_StringComparer_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_StringComparer_TypeInfo);
		  }
		  param2_00 = *(undefined4 *)(*(int *)(System_StringComparer_TypeInfo + 0x5c) + 8);
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_string__JSONNode__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData____ctor
		            (param1_00,param2_00,
		             Method_System_Collections_Generic_Dictionary_string__JSONNode___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786B")]
		[Address(RVA = "0xC1BD", Offset = "0xC1BD", VA = "0xC1BD")]
		public JSONClass()
		{
		}

		// Token: 0x04003F02 RID: 16130
		[Token(Token = "0x4003F02")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, JSONNode> m_Dict;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Item ---
		void I2_Loc_SimpleJSON_JSONClass__get_Item
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 local_8 [2];
		  
		  if (DAT_ram_00a54e63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ElementAt_KeyValuePair_string__JSONNode____);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__JSONNode__get_Key__);
		    DAT_ram_00a54e63 = '\x01';
		  }
		  if ((-1 < param2) &&
		     (iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (*(undefined4 *)(param1 + 8),
		                         Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__)
		     , param2 < iVar1)) {
		    System_Linq_Enumerable__DistinctIterator___Il2CppFullySharedGenericType_
		              (local_8,*(undefined4 *)(param1 + 8),param2,
		               Method_System_Linq_Enumerable_ElementAt_KeyValuePair_string__JSONNode____);
		    func_ii_2946(*(undefined4 *)(param1 + 8),local_8[0],param3,
		                 Method_System_Collections_Generic_Dictionary_string__JSONNode__set_Item__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Item ---
		undefined4 I2_Loc_SimpleJSON_JSONClass__set_Item(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		    DAT_ram_00a54e64 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Item ---
		void I2_Loc_SimpleJSON_JSONClass__get_Item
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 local_8 [2];
		  
		  if (DAT_ram_00a54e63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ElementAt_KeyValuePair_string__JSONNode____);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__JSONNode__get_Key__);
		    DAT_ram_00a54e63 = '\x01';
		  }
		  if ((-1 < param2) &&
		     (iVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (*(undefined4 *)(param1 + 8),
		                         Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__)
		     , param2 < iVar1)) {
		    System_Linq_Enumerable__DistinctIterator___Il2CppFullySharedGenericType_
		              (local_8,*(undefined4 *)(param1 + 8),param2,
		               Method_System_Linq_Enumerable_ElementAt_KeyValuePair_string__JSONNode____);
		    func_ii_2946(*(undefined4 *)(param1 + 8),local_8[0],param3,
		                 Method_System_Collections_Generic_Dictionary_string__JSONNode__set_Item__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Item ---
		undefined4 I2_Loc_SimpleJSON_JSONClass__set_Item(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54e64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		    DAT_ram_00a54e64 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__JSONNode__get_Count__);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Count ---
		void I2_Loc_SimpleJSON_JSONClass__get_Count
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__JSONNode__set_Item__);
		    DAT_ram_00a54e65 = '\x01';
		  }
		  iVar1 = func_ii_4769(param2,0);
		  param1_00 = *(undefined4 *)(param1 + 8);
		  if (iVar1 == 0) {
		    iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                      (param1_00,param2,
		                       Method_System_Collections_Generic_Dictionary_string__JSONNode__ContainsKey__)
		    ;
		    if (iVar1 == 0) {
		      System_Reflection_FieldInfo__get_IsStatic
		                (*(undefined4 *)(param1 + 8),param2,param3,
		                 Method_System_Collections_Generic_Dictionary_string__JSONNode__Add__);
		    }
		    else {
		      func_ii_2946(*(undefined4 *)(param1 + 8),param2,param3,
		                   Method_System_Collections_Generic_Dictionary_string__JSONNode__set_Item__);
		    }
		  }
		  else {
		    func_ii_20618(&local_20,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    param2_00 = System_Guid___ctor(&local_10,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (param1_00,param2_00,param3,
		               Method_System_Collections_Generic_Dictionary_string__JSONNode__Add__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Childs ---
		int I2_Loc_SimpleJSON_JSONClass__get_Childs(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a54e6a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_SimpleJSON_JSONClass__GetEnumerator_d__15_TypeInfo);
		    DAT_ram_00a54e6a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(I2_Loc_SimpleJSON_JSONClass__GetEnumerator_d__15_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

}
