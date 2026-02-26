using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Money
{
	// Token: 0x02000EBA RID: 3770
	[Token(Token = "0x2000EBA")]
	public static class MoneyExt
	{
		// Token: 0x06005BE1 RID: 23521 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0xA89D", Offset = "0xA89D", VA = "0xA89D")]
		public static double GetValue(this Money money, Money.MoneyType type)
		{
		/* --- GHIDRA: GetValue ---
		undefined4 Core_Money_MoneyExt__GetValue(undefined4 param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  float8 fVar2;
		  float8 fVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  undefined4 uVar12;
		  uint uVar13;
		  undefined1 auStack_60 [8];
		  int local_58;
		  undefined8 *puStack_54;
		  undefined8 local_50;
		  undefined8 local_48;
		  float8 local_40;
		  undefined8 local_38;
		  float8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  float8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60623 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__TryGetValue__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Value__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__IsEnough_b__1_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__IsEnough_b__1_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__IsEnough_b__1_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__IsEnough_b__1_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__IsEnough_b__1_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__IsEnough_b__1_5__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60623 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0.0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0.0;
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar9 = puVar8[3];
		  if (iVar9 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar8;
		    iVar9 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar9,uVar4,Method_Core_Money_MoneyExt___c__IsEnough_b__1_0__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0xc) = iVar9;
		  }
		  uVar4 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (param1,iVar9,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar10 = puVar8[4];
		  iVar9 = Core_Money_MoneyExt___c_TypeInfo;
		  if (iVar10 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar8;
		    iVar10 = unnamed_function_1417
		                       (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar10,uVar6,Method_Core_Money_MoneyExt___c__IsEnough_b__1_1__,0);
		    iVar9 = Core_Money_MoneyExt___c_TypeInfo;
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x10) = iVar10;
		  }
		  if (*(int *)(iVar9 + 0x74) == 0) {
		    func_ii_306000(iVar9);
		    iVar9 = Core_Money_MoneyExt___c_TypeInfo;
		  }
		  puVar8 = *(undefined4 **)(iVar9 + 0x5c);
		  iVar11 = puVar8[6];
		  if (iVar11 == 0) {
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar8;
		    iVar11 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (iVar11,uVar6,Method_Core_Money_MoneyExt___c__IsEnough_b__1_2__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x18) = iVar11;
		  }
		  uVar4 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                    (uVar4,iVar10,iVar11,
		                     Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                    );
		  if (param2 == 0) {
		code_r0x81cbb1ae:
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar9 = **(int **)(Core_Money_Money_TypeInfo + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[7];
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		      }
		      uVar6 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar9,uVar6,Method_Core_Money_MoneyExt___c__IsEnough_b__1_3__,0);
		      *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x1c) = iVar9;
		    }
		    uVar6 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param2,iVar9,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    iVar10 = puVar8[8];
		    iVar9 = Core_Money_MoneyExt___c_TypeInfo;
		    if (iVar10 == 0) {
		      if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		      }
		      uVar12 = *puVar8;
		      iVar10 = unnamed_function_1417
		                         (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar10,uVar12,Method_Core_Money_MoneyExt___c__IsEnough_b__1_4__,0);
		      iVar9 = Core_Money_MoneyExt___c_TypeInfo;
		      *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x20) = iVar10;
		    }
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      iVar9 = Core_Money_MoneyExt___c_TypeInfo;
		    }
		    puVar8 = *(undefined4 **)(iVar9 + 0x5c);
		    iVar11 = puVar8[10];
		    if (iVar11 == 0) {
		      if (*(int *)(iVar9 + 0x74) == 0) {
		        func_ii_306000(iVar9);
		        puVar8 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		      }
		      uVar12 = *puVar8;
		      iVar11 = unnamed_function_1417
		                         (System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo);
		      System_Func_object__bool___Invoke
		                (iVar11,uVar12,Method_Core_Money_MoneyExt___c__IsEnough_b__1_5__,0);
		      *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x28) = iVar11;
		    }
		    iVar9 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (uVar6,iVar10,iVar11,
		                       Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                      );
		    if (iVar9 == 0) goto code_r0x81cbb1ae;
		  }
		  iVar10 = unnamed_function_1417(System_Collections_Generic_List_Money__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar10,4,Method_System_Collections_Generic_List_Money___ctor__);
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_58,uVar4,
		             Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__);
		  local_8 = local_38;
		  local_10 = local_40;
		  local_18 = local_48;
		  local_20 = local_50;
		  local_28 = CONCAT44(puStack_54,local_58);
		  local_58 = 0;
		  puStack_54 = &local_28;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                        );
		      fVar3 = local_10;
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cbb477;
		      }
		      if (iVar5 == 0) {
		        iVar5 = 0xe;
		        iVar11 = local_58;
		        goto code_r0x81cbb4c4;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = (undefined4)local_18;
		      iVar5 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29e,iVar9,
		                         (undefined4)local_18,&local_30,
		                         Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__TryGetValue__
		                        );
		      fVar2 = local_30;
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cbb477;
		      }
		    } while (iVar5 == 0);
		    if ((double)fVar3 < (double)local_30) {
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,Core_Money_Money_TypeInfo
		                  );
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cbb477;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::invoke_iidi
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,uVar4,
		                         (double)fVar2 - (double)fVar3,auStack_60);
		      iVar11 = Method_System_Collections_Generic_List_Money__Add__;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81cbb451:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cbb477;
		      }
		      *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		      uVar13 = *(uint *)(iVar10 + 0xc);
		      if (uVar13 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		        *(uint *)(iVar10 + 0xc) = uVar13 + 1;
		        *(undefined4 *)(*(int *)(iVar10 + 8) + uVar13 * 4 + 0x10) = uVar6;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,uVar6,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81cbb451;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29f,iVar9,uVar4,
		               Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Remove__);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cbb477:
		  iVar11 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar5) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar11 = *piVar7;
		    iVar5 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_58 = iVar11;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81cbb4c4:
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar5 != 0) &&
		         ((((((iVar5 == 1 || (iVar5 == 2)) || (iVar5 == 3)) || ((iVar5 == 4 || (iVar5 == 5)))) ||
		           ((iVar5 == 6 || ((iVar5 == 7 || (iVar5 == 8)))))) ||
		          ((iVar5 == 9 ||
		           ((((iVar5 == 10 || (iVar5 == 0xb)) || (iVar5 == 0xc)) ||
		            ((iVar5 == 0xd || (iVar5 != 0xe)))))))))) {
		        return 0;
		      }
		      System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		                (&local_58,iVar9,
		                 Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__
		                );
		      local_8 = local_38;
		      local_10 = local_40;
		      local_18 = local_48;
		      local_20 = local_50;
		      local_28 = CONCAT44(puStack_54,local_58);
		      local_58 = 0;
		      puStack_54 = &local_28;
		      do {
		        while( true ) {
		          DAT_ram_009d3e38 = 0;
		          iVar11 = import::env::invoke_iii
		                             (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                              Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                             );
		          fVar3 = local_10;
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cbb6fd;
		          }
		          if (iVar11 == 0) {
		            iVar11 = 0x11;
		            iVar9 = local_58;
		            goto code_r0x81cbb74a;
		          }
		          uVar4 = (undefined4)local_18;
		          if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Core_Money_Money_TypeInfo);
		            iVar9 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar9 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cbb6fd;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iidi
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,uVar4,
		                             (double)fVar3,auStack_60);
		          iVar9 = Method_System_Collections_Generic_List_Money__Add__;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cbb6eb;
		          *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		          uVar13 = *(uint *)(iVar10 + 0xc);
		          if (*(uint *)(*(int *)(iVar10 + 8) + 0xc) <= uVar13) break;
		          *(uint *)(iVar10 + 0xc) = uVar13 + 1;
		          *(undefined4 *)(*(int *)(iVar10 + 8) + uVar13 * 4 + 0x10) = uVar4;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		      } while (DAT_ram_009d3e38 != 1);
		code_r0x81cbb6eb:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cbb6fd:
		      iVar9 = global_1;
		      iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar11) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar9 = *piVar7;
		        iVar11 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_58 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		code_r0x81cbb74a:
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar11 != 0) {
		            if (iVar11 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 5) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 6) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 7) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 8) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 9) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 10) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 0xb) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 0xc) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 0xd) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 0xe) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 0xf) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 == 0x10) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            if (iVar11 != 0x11) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		          }
		          if (*(int *)(iVar10 + 0xc) < 2) {
		            iVar9 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                              (iVar10,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		          }
		          else {
		            if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_Money_Money_TypeInfo);
		            }
		            iVar9 = Core_Money_Money__FromResources(iVar10,auStack_60);
		          }
		          *param3 = iVar9;
		          if (iVar9 == 0) {
		            return 1;
		          }
		          if (DAT_ram_00a60600 == '\0') {
		            Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__)
		            ;
		            Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		            DAT_ram_00a60600 = '\x01';
		          }
		          iVar10 = *(int *)(iVar9 + 8);
		          if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		          }
		          iVar11 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		          if ((iVar10 == iVar11) && (*(int *)(*(int *)(iVar9 + 0x18) + 0xc) == 0)) {
		            return 1;
		          }
		          iVar10 = *(int *)(iVar9 + 8);
		          if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		            iVar11 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		          }
		          if (iVar11 != iVar10) {
		            return (uint)(*(double *)(iVar9 + 0x10) <= 0.0);
		          }
		          return 0;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1d,&local_58);
		      goto joined_r0x81cbb7a9;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1c,&local_58);
		joined_r0x81cbb7a9:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0.0;
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0xA89E", Offset = "0xA89E", VA = "0xA89E")]
		public static bool IsEnough(this Money money, Money required, out Money lack)
		{
		/* --- GHIDRA: IsEnough ---
		undefined4 Core_Money_MoneyExt__IsEnough(undefined4 param1,int param2,undefined4 param3)
		
		{
		  float8 fVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int local_58;
		  undefined8 *puStack_54;
		  undefined8 local_50;
		  undefined8 local_48;
		  float8 local_40;
		  undefined8 local_38;
		  float8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  float8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60624 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__TryGetValue__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Value__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetDelta_b__2_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetDelta_b__2_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetDelta_b__2_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetDelta_b__2_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetDelta_b__2_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetDelta_b__2_5__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60624 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0.0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0.0;
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar6 = puVar5[0xb];
		  if (iVar6 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar6,uVar2,Method_Core_Money_MoneyExt___c__GetDelta_b__2_0__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x2c) = iVar6;
		  }
		  uVar2 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (param1,iVar6,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar7 = puVar5[0xc];
		  iVar6 = Core_Money_MoneyExt___c_TypeInfo;
		  if (iVar7 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar5;
		    iVar7 = unnamed_function_1417
		                      (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar7,uVar3,Method_Core_Money_MoneyExt___c__GetDelta_b__2_1__,0);
		    iVar6 = Core_Money_MoneyExt___c_TypeInfo;
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x30) = iVar7;
		  }
		  if (*(int *)(iVar6 + 0x74) == 0) {
		    func_ii_306000(iVar6);
		    iVar6 = Core_Money_MoneyExt___c_TypeInfo;
		  }
		  puVar5 = *(undefined4 **)(iVar6 + 0x5c);
		  iVar8 = puVar5[0xe];
		  if (iVar8 == 0) {
		    if (*(int *)(iVar6 + 0x74) == 0) {
		      func_ii_306000(iVar6);
		      puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar5;
		    iVar8 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (iVar8,uVar3,Method_Core_Money_MoneyExt___c__GetDelta_b__2_2__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x38) = iVar8;
		  }
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                    (uVar2,iVar7,iVar8,
		                     Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                    );
		  if (param2 == 0) {
		code_r0x81cbbd20:
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar6 = **(int **)(Core_Money_Money_TypeInfo + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    iVar6 = puVar5[0xf];
		    if (iVar6 == 0) {
		      if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar5;
		      iVar6 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar6,uVar3,Method_Core_Money_MoneyExt___c__GetDelta_b__2_3__,0);
		      *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x3c) = iVar6;
		    }
		    uVar3 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param2,iVar6,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    iVar7 = puVar5[0x10];
		    iVar6 = Core_Money_MoneyExt___c_TypeInfo;
		    if (iVar7 == 0) {
		      if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		      }
		      uVar9 = *puVar5;
		      iVar7 = unnamed_function_1417
		                        (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar7,uVar9,Method_Core_Money_MoneyExt___c__GetDelta_b__2_4__,0);
		      iVar6 = Core_Money_MoneyExt___c_TypeInfo;
		      *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x40) = iVar7;
		    }
		    if (*(int *)(iVar6 + 0x74) == 0) {
		      func_ii_306000(iVar6);
		      iVar6 = Core_Money_MoneyExt___c_TypeInfo;
		    }
		    puVar5 = *(undefined4 **)(iVar6 + 0x5c);
		    iVar8 = puVar5[0x12];
		    if (iVar8 == 0) {
		      if (*(int *)(iVar6 + 0x74) == 0) {
		        func_ii_306000(iVar6);
		        puVar5 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		      }
		      uVar9 = *puVar5;
		      iVar8 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo)
		      ;
		      System_Func_object__bool___Invoke
		                (iVar8,uVar9,Method_Core_Money_MoneyExt___c__GetDelta_b__2_5__,0);
		      *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x48) = iVar8;
		    }
		    iVar6 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (uVar3,iVar7,iVar8,
		                       Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                      );
		    if (iVar6 == 0) goto code_r0x81cbbd20;
		  }
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_58,uVar2,
		             Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__);
		  local_8 = local_38;
		  local_10 = local_40;
		  local_18 = local_48;
		  local_20 = local_50;
		  local_28 = CONCAT44(puStack_54,local_58);
		  local_58 = 0;
		  puStack_54 = &local_28;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                        );
		      fVar1 = local_10;
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cbbf38;
		      }
		      if (iVar8 == 0) goto code_r0x81cbbf8e;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (undefined4)local_18;
		      iVar8 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29e,iVar6,
		                         (undefined4)local_18,&local_30,
		                         Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__TryGetValue__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cbbf38;
		      }
		      if (iVar8 == 0) {
		        local_30 = fVar1;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        local_30 = (float8)((double)fVar1 - (double)local_30);
		        import::env::invoke_iiii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29f,iVar6,uVar2,
		                   Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Remove__);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cbbf38;
		        }
		      }
		    } while ((double)local_30 == 0.0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viidi
		              (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1e,uVar3,uVar2,(double)local_30,
		               Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cbbf38:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_58 = iVar8;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81cbbf8e:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		                (&local_58,iVar6,
		                 Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__
		                );
		      local_8 = local_38;
		      local_10 = local_40;
		      local_18 = local_48;
		      local_20 = local_50;
		      local_28 = CONCAT44(puStack_54,local_58);
		      local_58 = 0;
		      puStack_54 = &local_28;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                          );
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cbc0ca;
		        }
		        if (iVar7 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return uVar3;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viidi
		                  (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1e,uVar3,(undefined4)local_18
		                   ,-(double)local_10,
		                   Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar6 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cbc0ca:
		      iVar6 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar7) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar7 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_58 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar7 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return uVar3;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x20,&local_58);
		      goto joined_r0x81cbc15b;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1f,&local_58);
		joined_r0x81cbc15b:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0xA89F", Offset = "0xA89F", VA = "0xA89F")]
		public static IReadOnlyDictionary<Money.MoneyType, double> GetDelta(this Money money, Money other)
		{
		/* --- GHIDRA: GetDelta ---
		undefined4 Core_Money_MoneyExt__GetDelta(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a60625 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__Floor_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__Floor_b__3_1__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60625 = '\x01';
		  }
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[0x13];
		  param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,uVar1,Method_Core_Money_MoneyExt___c__Floor_b__3_0__,0);
		    param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x4c) = param1_01;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_02 = puVar2[0x14];
		  if (param1_02 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_02 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (param1_02,uVar1,Method_Core_Money_MoneyExt___c__Floor_b__3_1__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x50) = param1_02;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                    (param1,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__FromResourceSet(uVar1,uVar1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0xA8A0", Offset = "0xA8A0", VA = "0xA8A0")]
		public static Money Floor(this Money money)
		{
		/* --- GHIDRA: Floor ---
		undefined4 Core_Money_MoneyExt__Floor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a60626 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__Ceiling_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__Ceiling_b__4_1__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60626 = '\x01';
		  }
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[0x15];
		  param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,uVar1,Method_Core_Money_MoneyExt___c__Ceiling_b__4_0__,0);
		    param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x54) = param1_01;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_02 = puVar2[0x16];
		  if (param1_02 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_02 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (param1_02,uVar1,Method_Core_Money_MoneyExt___c__Ceiling_b__4_1__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x58) = param1_02;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                    (param1,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__FromResourceSet(uVar1,uVar1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0xA8A1", Offset = "0xA8A1", VA = "0xA8A1")]
		public static Money Ceiling(this Money money)
		{
		/* --- GHIDRA: Ceiling ---
		undefined4 Core_Money_MoneyExt__Ceiling(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a60627 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__Round_b__5_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__Round_b__5_1__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60627 = '\x01';
		  }
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[0x17];
		  param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (param1_01,uVar1,Method_Core_Money_MoneyExt___c__Round_b__5_0__,0);
		    param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x5c) = param1_01;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Money_MoneyExt___c_TypeInfo;
		  }
		  puVar2 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_02 = puVar2[0x18];
		  if (param1_02 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar2 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_02 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (param1_02,uVar1,Method_Core_Money_MoneyExt___c__Round_b__5_1__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 0x60) = param1_02;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                    (param1,param1_01,param1_02,
		                     Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__FromResourceSet(uVar1,uVar1);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0xA8A2", Offset = "0xA8A2", VA = "0xA8A2")]
		public static Money Round(this Money money)
		{
		/* --- GHIDRA: Round ---
		void Core_Money_MoneyExt__Round(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60628 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60628 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Money_MoneyExt___c_TypeInfo);
		  **(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}
	}
}
