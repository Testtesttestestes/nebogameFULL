using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model.PurchasePayload
{
	// Token: 0x02000BEC RID: 3052
	[Token(Token = "0x2000BEC")]
	public class DevPayloadPrefs
	{
		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[Token(Token = "0x17000F27")]
		public int Count
		{
			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x994C", Offset = "0x994C", VA = "0x994C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x994D", Offset = "0x994D", VA = "0x994D")]
		public DevPayloadPrefs(string nameId, string platformName)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6091c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_DeveloperPayload___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_DeveloperPayload__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass8_0__Contains_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass8_0_TypeInfo
		              );
		    DAT_ram_00a6091c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass8_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0xc) + 8);
		  param1_00 = unnamed_function_1417(System_Func_DeveloperPayload__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass8_0__Contains_b__0__
		             ,0);
		  iVar1 = UI_SimpleIconValue__set_Value
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_SingleOrDefault_DeveloperPayload___);
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0000DD88 File Offset: 0x0000BF88
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x994E", Offset = "0x994E", VA = "0x994E")]
		private bool Contains(string v)
		{
		/* --- GHIDRA: Contains ---
		uint Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__Contains
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  int param2_00;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a6091d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_Model_PurchasePayload_DeveloperPayload_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_DeveloperPayload__Add__);
		    DAT_ram_00a6091d = '\x01';
		  }
		  uVar2 = Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___ctor(param1,param2,param1);
		  if (uVar2 == 0) {
		    param1_00 = *(int *)(*(int *)(param1 + 0xc) + 8);
		    param2_00 = unnamed_function_1417
		                          (Gameplay_Billing_Model_PurchasePayload_DeveloperPayload_TypeInfo);
		    *(undefined4 *)(param2_00 + 0xc) = param2;
		    iVar1 = Method_System_Collections_Generic_List_DeveloperPayload__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                );
		    }
		  }
		  return uVar2 ^ 1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x994F", Offset = "0x994F", VA = "0x994F")]
		public bool TryAdd(string v)
		{
		/* --- GHIDRA: TryAdd ---
		uint Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__TryAdd
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint uVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a6091e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_DeveloperPayload__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_DeveloperPayload__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_DeveloperPayload__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_DeveloperPayload__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_DeveloperPayload__Remove__)
		    ;
		    DAT_ram_00a6091e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(param1 + 0xc) + 8),
		             Method_System_Collections_Generic_List_DeveloperPayload__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_DeveloperPayload__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfe7e4;
		    }
		    if (uVar3 == 0) {
		      uVar2 = 0;
		      goto code_r0x81cfe7bf;
		    }
		    iVar5 = local_8._4_4_;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = System_Collections_CollectionBase___ctor(*(undefined4 *)(local_8._4_4_ + 0xc),param2,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfe7e4;
		    }
		  } while (iVar4 == 0);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x389,
		                     *(undefined4 *)(*(int *)(param1 + 0xc) + 8),iVar5,
		                     Method_System_Collections_Generic_List_DeveloperPayload__Remove__);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfe7e4:
		    iVar1 = global_1;
		    iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar1 == iVar5) {
		      piVar6 = (int *)import::env::__cxa_begin_catch(param1_00);
		      iVar5 = *piVar6;
		      DAT_ram_009d3e38 = 0;
		      local_18 = iVar5;
		      import::env::invoke_v(0x123);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar5 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return 0;
		        }
		        System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x18,&local_18);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      import::env::__resumeException(param1_00);
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
		code_r0x81cfe7bf:
		  DAT_ram_009d3e38 = 0;
		  return uVar2 & uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x9950", Offset = "0x9950", VA = "0x9950")]
		public bool TryRemove(string v)
		{
		/* --- GHIDRA: TryRemove ---
		undefined4
		Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__TryRemove
		          (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a6091f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_DeveloperPayload__string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DeveloperPayload___);
		    Mono_Security_ASN1__get_Item(&System_Func_DeveloperPayload__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DeveloperPayload__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__GetAll_b__11_1__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass11_0__GetAll_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass11_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo);
		    DAT_ram_00a6091f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass11_0_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0xc) + 8);
		  uVar2 = unnamed_function_1417(System_Func_DeveloperPayload__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass11_0__GetAll_b__0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_DeveloperPayload___);
		  if (*(int *)(Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Func_DeveloperPayload__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar1,uVar3,
		               Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__GetAll_b__11_1__,0
		              );
		    *(int *)(*(int *)(Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c_TypeInfo + 0x5c) +
		            4) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_Select_DeveloperPayload__string___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_string___);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AF4")]
		[Address(RVA = "0x9951", Offset = "0x9951", VA = "0x9951")]
		public string[] GetAll(ulong optionId)
		{
		/* --- GHIDRA: GetAll ---
		undefined4
		Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__GetAll
		          (int param1,undefined8 param2,longlong param3,undefined4 *param4,int *param5,
		          undefined4 param6)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  longlong lVar5;
		  int iVar6;
		  int param2_00;
		  undefined4 uVar7;
		  ulonglong uVar8;
		  
		  uVar3 = 0;
		  if (DAT_ram_00a60920 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_Model_PurchasePayload_DeveloperPayloadId_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_DeveloperPayload___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DeveloperPayload___);
		    Mono_Security_ASN1__get_Item(&System_Func_DeveloperPayload__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_DeveloperPayload__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass12_0__TryGetValue_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass12_0_TypeInfo
		              );
		    DAT_ram_00a60920 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass12_0_TypeInfo
		                    );
		  *(undefined8 *)(iVar2 + 8) = param2;
		  *param4 = 0;
		  *param5 = 0;
		  iVar6 = *(int *)(*(int *)(param1 + 0xc) + 8);
		  if (*(int *)(iVar6 + 0xc) != 0) {
		    uVar3 = unnamed_function_1417(System_Func_DeveloperPayload__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,iVar2,
		               Method_Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs___c__DisplayClass12_0__TryGetValue_b__0__
		               ,0);
		    uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (iVar6,uVar3,Method_System_Linq_Enumerable_Where_DeveloperPayload___);
		    iVar2 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_DeveloperPayload___);
		    uVar3 = 0;
		    if (*(int *)(iVar2 + 0xc) != 0) {
		      iVar6 = 0;
		      lVar4 = Gameplay_Billing_Model_PurchasePayload_DeveloperPayload__GetOptionId
		                        (*(undefined4 *)(iVar2 + 0x10),0);
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      if (0 < *(int *)(iVar2 + 0xc)) {
		        uVar8 = lVar4 - param3 >> 0x3f;
		        lVar4 = (lVar4 - param3 ^ uVar8) - uVar8;
		        param2_00 = 0;
		        do {
		          lVar5 = Gameplay_Billing_Model_PurchasePayload_DeveloperPayload__GetOptionId
		                            (*(undefined4 *)(iVar2 + param2_00 * 4 + 0x10),param2_00);
		          if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_Math_TypeInfo);
		          }
		          uVar8 = lVar5 - param3 >> 0x3f;
		          lVar5 = (lVar5 - param3 ^ uVar8) - uVar8;
		          iVar1 = param2_00;
		          if (lVar4 <= lVar5) {
		            iVar1 = iVar6;
		            lVar5 = lVar4;
		          }
		          lVar4 = lVar5;
		          iVar6 = iVar1;
		          param2_00 = param2_00 + 1;
		        } while (param2_00 < *(int *)(iVar2 + 0xc));
		      }
		      iVar2 = *(int *)(iVar2 + iVar6 * 4 + 0x10);
		      *param4 = *(undefined4 *)(iVar2 + 0xc);
		      if (DAT_ram_00a60926 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		        DAT_ram_00a60926 = '\x01';
		      }
		      iVar6 = *(int *)(iVar2 + 8);
		      if (iVar6 == 0) {
		        iVar6 = func_ii_5995(*(undefined4 *)(iVar2 + 0xc),
		                             Method_UnityEngine_JsonUtility_FromJson_PayloadContent___);
		        *(int *)(iVar2 + 8) = iVar6;
		      }
		      uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar6 + 8) + 0x10) + 0x14);
		      uVar7 = *(undefined4 *)(param1 + 8);
		      iVar2 = unnamed_function_1417
		                        (Gameplay_Billing_Model_PurchasePayload_DeveloperPayloadId_TypeInfo);
		      *(undefined4 *)(iVar2 + 0xc) = uVar7;
		      *(undefined4 *)(iVar2 + 8) = uVar3;
		      *param5 = iVar2;
		      uVar3 = 1;
		    }
		  }
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x9952", Offset = "0x9952", VA = "0x9952")]
		public bool TryGetValue(ulong optionId, long timestamp, out string developerPayload, out DeveloperPayloadId developerPayloadId)
		{
		/* --- GHIDRA: TryGetValue ---
		void Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__TryGetValue
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = UI_Preloader_PreloaderBackgroundLoader_PreloaderBackgroundDto___ctor
		                        (*(undefined4 *)(param1 + 0xc),0);
		  func_ii_7893(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  func_ii_10838(0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x9953", Offset = "0x9953", VA = "0x9953")]
		public void Commit()
		{
		/* --- GHIDRA: Commit ---
		undefined4
		Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__Commit(int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60921 == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19440);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11362);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5925);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28694);
		    DAT_ram_00a60921 = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,6);
		  if (StringLiteral_11362 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_11362,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_11362;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[4] = iVar3;
		  iVar3 = *(int *)(param1 + 0x10);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar3;
		  if (StringLiteral_19440 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_19440,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_19440;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[6] = iVar3;
		  iVar3 = *(int *)(param1 + 0xc);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar3;
		  if (StringLiteral_5925 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_5925,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_5925;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[8] = iVar3;
		  if (DAT_ram_00a6091a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_DeveloperPayload__get_Count__);
		    DAT_ram_00a6091a = '\x01';
		  }
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0xc) + 8) + 0xc);
		  iVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[9] = iVar3;
		  uVar2 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28694,param2_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x9954", Offset = "0x9954", VA = "0x9954", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4
		Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__ToString(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60922 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_DeveloperPayload___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17659);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a60922 = '\x01';
		  }
		  uVar1 = System_String__Join_long_
		                    (StringLiteral_1236,*(undefined4 *)(param1 + 8),
		                     Method_System_String_Join_DeveloperPayload___);
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_17659,uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x040028C7 RID: 10439
		[Token(Token = "0x40028C7")]
		public const string NameID = "PURCHASE_DEV_PAYLOADS";

		// Token: 0x040028C8 RID: 10440
		[Token(Token = "0x40028C8")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _platformName;

		// Token: 0x040028C9 RID: 10441
		[Token(Token = "0x40028C9")]
		[FieldOffset(Offset = "0xC")]
		private readonly DevPayloadPrefs.ValuesWrapper _data;

		// Token: 0x040028CA RID: 10442
		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x10")]
		public readonly string NameId;

		// Token: 0x02000BED RID: 3053
		[Token(Token = "0x2000BED")]
		[Serializable]
		private class ValuesWrapper
		{
			// Token: 0x06004AF8 RID: 19192 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004AF8")]
			[Address(RVA = "0x9955", Offset = "0x9955", VA = "0x9955", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004AF9 RID: 19193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AF9")]
			[Address(RVA = "0x9956", Offset = "0x9956", VA = "0x9956")]
			public ValuesWrapper()
			{
			}

			// Token: 0x040028CB RID: 10443
			[Token(Token = "0x40028CB")]
			[FieldOffset(Offset = "0x8")]
			public List<DeveloperPayload> Values;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Count ---
		void Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs__get_Count
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6091b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_JsonUtility_FromJson_DevPayloadPrefs_ValuesWrapper___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs_ValuesWrapper_TypeInfo);
		    DAT_ram_00a6091b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Billing_Model_PurchasePayload_DevPayloadPrefs_ValuesWrapper_TypeInfo);
		  if (DAT_ram_00a60923 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_DeveloperPayload___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_DeveloperPayload__TypeInfo);
		    DAT_ram_00a60923 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_DeveloperPayload__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_DeveloperPayload___ctor__);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  *(int *)(param1 + 0xc) = iVar1;
		  *(undefined4 *)(param1 + 8) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  uVar2 = UnityEngine_PlayerPrefs__GetInt(param2,0);
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar2,0);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_5995(uVar2,
		                         Method_UnityEngine_JsonUtility_FromJson_DevPayloadPrefs_ValuesWrapper___);
		    *(undefined4 *)(param1 + 0xc) = uVar2;
		  }
		  return;
		}
		*/

}
