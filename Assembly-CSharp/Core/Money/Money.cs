using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Money
{
	// Token: 0x02000EB4 RID: 3764
	[Token(Token = "0x2000EB4")]
	public class Money : IEnumerator<Money>, IEnumerator, IDisposable, IEnumerable<Money>, IEnumerable, ICloneable, IEquatable<Money>
	{
		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A3")]
		public Money.MoneyType Type
		{
			[Token(Token = "0x6005B8C")]
			[Address(RVA = "0xA84D", Offset = "0xA84D", VA = "0xA84D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06005B8D RID: 23437 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x170012A4")]
		public double Value
		{
			[Token(Token = "0x6005B8D")]
			[Address(RVA = "0xA84E", Offset = "0xA84E", VA = "0xA84E")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0xA84F", Offset = "0xA84F", VA = "0xA84F")]
		public static explicit operator ResourceSet(Money money)
		{
			return null;
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0xA850", Offset = "0xA850", VA = "0xA850")]
		public static Money FromResourceSet(ResourceSet resourceSet)
		{
		/* --- GHIDRA: FromResourceSet ---
		undefined4 Core_Money_Money__FromResourceSet(int *param1,undefined4 param2)
		
		{
		  float8 param3;
		  int iVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  undefined4 local_20 [2];
		  float8 local_18;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a605f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_KeyValuePair_Money_MoneyType__double___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_KeyValuePair_Money_MoneyType__double___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Value__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a605f9 = '\x01';
		  }
		  if (param1 == (int *)0x0) {
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    if (DAT_ram_00a605fb == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		      DAT_ram_00a605fb = '\x01';
		    }
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    uVar7 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		    uVar4 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		    Core_Money_Money__op_Equality(uVar4,uVar7,0.0,0,uVar4);
		    return uVar4;
		  }
		  uVar10 = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_Money__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar1,4,Method_System_Collections_Generic_List_Money___ctor__);
		  iVar9 = *param1;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_KeyValuePair_Money_MoneyType__double___TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cb6579;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,
		                                System_Collections_Generic_IEnumerable_KeyValuePair_Money_MoneyType__double___TypeInfo
		                                ,0);
		code_r0x81cb6579:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x81cb659e:
		  do {
		    do {
		      piVar6 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x81cb6646;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb668e:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb68ab;
		      }
		code_r0x81cb6646:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cb668e;
		      if (iVar9 == 0) {
		        iVar9 = 5;
		        goto code_r0x81cb68f8;
		      }
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_IEnumerator_KeyValuePair_Money_MoneyType__double___TypeInfo
		              == *piVar8) {
		            puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x81cb6735;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_KeyValuePair_Money_MoneyType__double___TypeInfo
		                          ,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb6789:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb68ab;
		      }
		code_r0x81cb6735:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii(*puVar3,local_20,piVar6,puVar3[1]);
		      param3 = local_18;
		      uVar4 = local_20[0];
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cb6789;
		    } while ((double)local_18 <= 0.0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,Core_Money_Money_TypeInfo);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb68ab;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iidi
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,uVar4,(double)param3,
		                       uVar4);
		    iVar9 = Method_System_Collections_Generic_List_Money__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar10 = *(uint *)(iVar1 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar10 + 1;
		      *(undefined4 *)(*(int *)(iVar1 + 8) + uVar10 * 4 + 0x10) = uVar4;
		      goto code_r0x81cb659e;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,uVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb68ab:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_c = *piVar6;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x81cb68f8:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_8;
		      if (piVar6 != (int *)0x0) {
		        uVar10 = 0;
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x81cb6973;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar10);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x81cb6973:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar9 != 0) {
		        if (iVar9 == 1) {
		          return 0;
		        }
		        if (iVar9 == 2) {
		          return 0;
		        }
		        if (iVar9 == 3) {
		          return 0;
		        }
		        if (iVar9 == 4) {
		          return 0;
		        }
		        if (iVar9 != 5) {
		          return 0;
		        }
		      }
		      if (1 < *(int *)(iVar1 + 0xc)) {
		        if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		        }
		        uVar7 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		        uVar4 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		        Core_Money_Money__op_Equality(uVar4,uVar7,0.0,iVar1,uVar4);
		        return uVar4;
		      }
		      uVar4 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                        (iVar1,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		      return uVar4;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x16,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x1F14", Offset = "0x1F14", VA = "0x1F14")]
		public static Money FromResource(Money.MoneyType type, double value)
		{
			return null;
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0xA851", Offset = "0xA851", VA = "0xA851")]
		public static Money FromResources(IReadOnlyDictionary<Money.MoneyType, double> values)
		{
		/* --- GHIDRA: FromResources ---
		undefined4 Core_Money_Money__FromResources(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 param4;
		  undefined4 param2_00;
		  undefined4 *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a605fa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Cast_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Money__object___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IReadOnlyCollection_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__FromMoney_b__15_0__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a605fa = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IReadOnlyCollection_Money__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cb6b36;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,
		                                System_Collections_Generic_IReadOnlyCollection_Money__TypeInfo,0);
		code_r0x81cb6b36:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  if (iVar5 < 2) {
		    uVar3 = 0;
		    iVar5 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                      (param1,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    if ((iVar5 != 0) &&
		       (param1_00 = (int *)Core_Money_Money__GetEnumerator(iVar5,0), param1_00 != (int *)0x0)) {
		      if (((uint)*(byte *)(Core_Money_Money_TypeInfo + 0xb8) <= (uint)*(byte *)(*param1_00 + 0xb8))
		         && (*(int *)(*(int *)(*param1_00 + 100) +
		                      (uint)*(byte *)(Core_Money_Money_TypeInfo + 0xb8) * 4 + -4) ==
		             Core_Money_Money_TypeInfo)) {
		        return param1_00;
		      }
		      System_Activator__CreateInstance(param1_00,Core_Money_Money_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    param2_00 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar4 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar5 = puVar4[1];
		    if (iVar5 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar4 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar4;
		      iVar5 = unnamed_function_1417(System_Func_Money__object__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar5,uVar3,Method_Core_Money_Money___c__FromMoney_b__15_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 4) = iVar5;
		    }
		    uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (param1,iVar5,Method_System_Linq_Enumerable_Select_Money__object___);
		    param4 = System_Linq_Enumerable__Cast_DictionaryEntry_
		                       (uVar3,Method_System_Linq_Enumerable_Cast_Money___);
		    uVar3 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		    Core_Money_Money__op_Equality(uVar3,param2_00,0.0,param4,uVar3);
		  }
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B92")]
		[Address(RVA = "0xA852", Offset = "0xA852", VA = "0xA852")]
		public static Money FromMoney(IReadOnlyList<Money> content)
		{
		/* --- GHIDRA: FromMoney ---
		undefined4 Core_Money_Money__FromMoney(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 param2;
		  
		  if (DAT_ram_00a605fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a605fb = '\x01';
		  }
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  param2 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		  Core_Money_Money__op_Equality(param1_00,param2,0.0,0,param2);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B93")]
		[Address(RVA = "0xA853", Offset = "0xA853", VA = "0xA853")]
		public static Money CreateEmpty()
		{
		/* --- GHIDRA: CreateEmpty ---
		undefined4 Core_Money_Money__CreateEmpty(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  float8 fVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  uint uVar10;
		  undefined4 uVar11;
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
		  
		  if (DAT_ram_00a605fc == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Addition_b__17_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Addition_b__17_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Addition_b__17_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Addition_b__17_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Addition_b__17_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Addition_b__17_5__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a605fc = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0.0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0.0;
		  if (param1 == 0) {
		code_r0x81cb7088:
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar7 = **(int **)(Core_Money_Money_TypeInfo + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar7 = puVar8[2];
		    if (iVar7 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar5 = *puVar8;
		      iVar7 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar7,uVar5,Method_Core_Money_Money___c__op_Addition_b__17_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 8) = iVar7;
		    }
		    uVar5 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param1,iVar7,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[3];
		    iVar7 = Core_Money_Money___c_TypeInfo;
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar9 = unnamed_function_1417
		                        (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar9,uVar11,Method_Core_Money_Money___c__op_Addition_b__17_1__,0);
		      iVar7 = Core_Money_Money___c_TypeInfo;
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0xc) = iVar9;
		    }
		    if (*(int *)(iVar7 + 0x74) == 0) {
		      func_ii_306000(iVar7);
		      iVar7 = Core_Money_Money___c_TypeInfo;
		    }
		    puVar8 = *(undefined4 **)(iVar7 + 0x5c);
		    iVar3 = puVar8[5];
		    if (iVar3 == 0) {
		      if (*(int *)(iVar7 + 0x74) == 0) {
		        func_ii_306000(iVar7);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar3 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo)
		      ;
		      System_Func_object__bool___Invoke
		                (iVar3,uVar11,Method_Core_Money_Money___c__op_Addition_b__17_2__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x14) = iVar3;
		    }
		    iVar7 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (uVar5,iVar9,iVar3,
		                       Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                      );
		    if (iVar7 == 0) goto code_r0x81cb7088;
		  }
		  if (param2 == 0) {
		code_r0x81cb7255:
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar9 = **(int **)(Core_Money_Money_TypeInfo + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[6];
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar5 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar9,uVar5,Method_Core_Money_Money___c__op_Addition_b__17_3__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x18) = iVar9;
		    }
		    uVar5 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param2,iVar9,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar3 = puVar8[7];
		    iVar9 = Core_Money_Money___c_TypeInfo;
		    if (iVar3 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar3 = unnamed_function_1417
		                        (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar3,uVar11,Method_Core_Money_Money___c__op_Addition_b__17_4__,0);
		      iVar9 = Core_Money_Money___c_TypeInfo;
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x1c) = iVar3;
		    }
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      iVar9 = Core_Money_Money___c_TypeInfo;
		    }
		    puVar8 = *(undefined4 **)(iVar9 + 0x5c);
		    iVar4 = puVar8[9];
		    if (iVar4 == 0) {
		      if (*(int *)(iVar9 + 0x74) == 0) {
		        func_ii_306000(iVar9);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar4 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo)
		      ;
		      System_Func_object__bool___Invoke
		                (iVar4,uVar11,Method_Core_Money_Money___c__op_Addition_b__17_5__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x24) = iVar4;
		    }
		    iVar9 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (uVar5,iVar3,iVar4,
		                       Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                      );
		    if (iVar9 == 0) goto code_r0x81cb7255;
		  }
		  iVar3 = unnamed_function_1417(System_Collections_Generic_List_Money__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar3,4,Method_System_Collections_Generic_List_Money___ctor__);
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_58,iVar7,
		             Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__);
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
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                        );
		      fVar2 = local_10;
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb7529;
		      }
		      if (iVar4 == 0) {
		        iVar4 = 0x12;
		        iVar7 = local_58;
		        goto code_r0x81cb7576;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = (undefined4)local_18;
		      iVar4 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29e,iVar9,
		                         (undefined4)local_18,&local_30,
		                         Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__TryGetValue__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb7529;
		      }
		      if (iVar4 == 0) {
		        local_30 = fVar2;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        local_30 = (float8)((double)fVar2 + (double)local_30);
		        import::env::invoke_iiii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29f,iVar9,uVar5,
		                   Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Remove__);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cb7529;
		        }
		      }
		      fVar2 = local_30;
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,Core_Money_Money_TypeInfo
		                  );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cb7529;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iidi
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,uVar5,(double)fVar2,
		                         auStack_60);
		      iVar7 = Method_System_Collections_Generic_List_Money__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cb750d;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      uVar10 = *(uint *)(iVar3 + 0xc);
		      if (*(uint *)(*(int *)(iVar3 + 8) + 0xc) <= uVar10) break;
		      *(uint *)(iVar3 + 0xc) = uVar10 + 1;
		      *(undefined4 *)(*(int *)(iVar3 + 8) + uVar10 * 4 + 0x10) = uVar5;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,uVar5,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x81cb750d:
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb7529:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar7 = *piVar6;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_58 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81cb7576:
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar4 != 0) &&
		         (((((((iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) || ((iVar4 == 4 || (iVar4 == 5)))) ||
		            ((iVar4 == 6 || ((iVar4 == 7 || (iVar4 == 8)))))) || (iVar4 == 9)) ||
		          (((((iVar4 == 10 || (iVar4 == 0xb)) || (iVar4 == 0xc)) ||
		            (((iVar4 == 0xd || (iVar4 == 0xe)) ||
		             ((iVar4 == 0xf || ((iVar4 == 0x10 || (iVar4 == 0x11)))))))) || (iVar4 != 0x12)))))) {
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
		          iVar9 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                             Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                            );
		          fVar2 = local_10;
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cb77b3;
		          }
		          if (iVar9 == 0) {
		            iVar9 = 0x15;
		            iVar7 = local_58;
		            goto code_r0x81cb7800;
		          }
		          uVar5 = (undefined4)local_18;
		          if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Core_Money_Money_TypeInfo);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cb77b3;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::invoke_iidi
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,uVar5,
		                             (double)fVar2,auStack_60);
		          iVar7 = Method_System_Collections_Generic_List_Money__Add__;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81cb77a1;
		          *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		          uVar10 = *(uint *)(iVar3 + 0xc);
		          if (*(uint *)(*(int *)(iVar3 + 8) + 0xc) <= uVar10) break;
		          *(uint *)(iVar3 + 0xc) = uVar10 + 1;
		          *(undefined4 *)(*(int *)(iVar3 + 8) + uVar10 * 4 + 0x10) = uVar5;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,uVar5,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      } while (DAT_ram_009d3e38 != 1);
		code_r0x81cb77a1:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb77b3:
		      iVar7 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar9) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar7 = *piVar6;
		        iVar9 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_58 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x81cb7800:
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar9 != 0 && iVar9 != 0x15) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          if (1 < *(int *)(iVar3 + 0xc)) {
		            if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		            }
		            uVar11 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		            uVar5 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		            Core_Money_Money__op_Equality(uVar5,uVar11,0.0,iVar3,auStack_60);
		            return uVar5;
		          }
		          uVar5 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                            (iVar3,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		          return uVar5;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x18,&local_58);
		      goto joined_r0x81cb7870;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x17,&local_58);
		joined_r0x81cb7870:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
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

			return null;
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B94")]
		[Address(RVA = "0xA854", Offset = "0xA854", VA = "0xA854")]
		public static Money operator +(Money a, Money b)
		{
			return null;
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B95")]
		[Address(RVA = "0xA855", Offset = "0xA855", VA = "0xA855")]
		public static Money operator -(Money a, Money b)
		{
			return null;
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B96")]
		[Address(RVA = "0xA856", Offset = "0xA856", VA = "0xA856")]
		public static Money operator *(Money a, double b)
		{
			return null;
		}

		// Token: 0x06005B97 RID: 23447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005B97")]
		[Address(RVA = "0x1B16", Offset = "0x1B16", VA = "0x1B16")]
		public Money CloneWithValue(Money.MoneyType type, double value)
		{
			return null;
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x170012A5")]
		public bool IsEmpty
		{
			[Token(Token = "0x6005B98")]
			[Address(RVA = "0xA857", Offset = "0xA857", VA = "0xA857")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x6005B99")]
		[Address(RVA = "0xA858", Offset = "0xA858", VA = "0xA858")]
		public static bool operator !=(Money a, Money b)
		{
			return default(bool);
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0xA859", Offset = "0xA859", VA = "0xA859")]
		public static bool operator ==(Money a, Money b)
		{
			return default(bool);
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0xA85A", Offset = "0xA85A", VA = "0xA85A")]
		private Money(Money.MoneyType type, double value, [Optional] IEnumerable<Money> complexContent)
		{
		/* --- GHIDRA: .cctor ---
		int Core_Money_Money___cctor(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6060b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType__GetEnumerable_d__8_TypeInfo);
		    DAT_ram_00a6060b = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Money_Money_MoneyType__GetEnumerable_d__8_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0xfffffffe;
		  uVar2 = func_ii_6393(0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Core_Money_Money___ctor(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a60602 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a60602 = '\x01';
		  }
		  if (DAT_ram_00a60600 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a60600 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  iVar6 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		  if ((iVar4 == iVar6) && (*(int *)(*(int *)(param1 + 0x18) + 0xc) == 0)) {
		    return 0;
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    iVar6 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		  }
		  if ((iVar4 == iVar6) || (0.0 < *(double *)(param1 + 0x10))) {
		    if (*(int *)(param1 + 0x20) == 0) {
		      iVar4 = 0;
		    }
		    else {
		      iVar4 = *(int *)(*(int *)(param1 + 0x20) + 8);
		    }
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    if (iVar4 == **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c)) {
		      uVar8 = 0;
		      piVar5 = *(int **)(param1 + 0x20);
		      iVar4 = *piVar5;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (System_Collections_IEnumerator_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8)) {
		            puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81cb9232;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,System_Collections_IEnumerator_TypeInfo,0);
		code_r0x81cb9232:
		      iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      if (iVar4 != 0) {
		        return 1;
		      }
		      Core_Money_Money__System_Collections_IEnumerator_Reset(*(undefined4 *)(param1 + 0x20),param1);
		    }
		    iVar4 = *(int *)(param1 + 8);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    if (iVar4 == **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c)) {
		      do {
		        iVar4 = *(int *)(param1 + 0x1c);
		        if (*(int *)(*(int *)(param1 + 0x18) + 0xc) <= iVar4) {
		          return 0;
		        }
		        *(int *)(param1 + 0x1c) = iVar4 + 1;
		        iVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(int *)(param1 + 0x18),iVar4,
		                           Method_System_Collections_Generic_List_Money__get_Item__);
		        *(int *)(param1 + 0x20) = iVar4;
		        if (iVar4 == 0) {
		          bVar1 = true;
		        }
		        else {
		          if (DAT_ram_00a60600 == '\0') {
		            Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__)
		            ;
		            Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		            DAT_ram_00a60600 = '\x01';
		          }
		          iVar6 = *(int *)(iVar4 + 8);
		          if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		          }
		          iVar7 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		          if ((iVar6 == iVar7) && (*(int *)(*(int *)(iVar4 + 0x18) + 0xc) == 0)) {
		            bVar1 = true;
		          }
		          else {
		            iVar6 = *(int *)(iVar4 + 8);
		            if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		              iVar7 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		            }
		            if (iVar7 == iVar6) {
		              bVar1 = false;
		            }
		            else {
		              bVar1 = *(double *)(iVar4 + 0x10) <= 0.0;
		            }
		          }
		        }
		      } while (bVar1);
		      iVar4 = *(int *)(*(int *)(param1 + 0x20) + 8);
		      uVar2 = 1;
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      if (iVar4 == **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c)) {
		        uVar8 = 0;
		        piVar5 = *(int **)(param1 + 0x20);
		        iVar4 = *piVar5;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_Collections_IEnumerator_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8)) {
		              puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cb9432;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar5,System_Collections_IEnumerator_TypeInfo,0);
		code_r0x81cb9432:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		        return 1;
		      }
		    }
		    else {
		      uVar2 = 0;
		      if (*(int *)(param1 + 0x1c) < 1) {
		        uVar2 = 1;
		        *(int *)(param1 + 0x1c) = *(int *)(param1 + 0x1c) + 1;
		        *(int *)(param1 + 0x20) = param1;
		      }
		    }
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0xA85B", Offset = "0xA85B", VA = "0xA85B", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9D")]
		[Address(RVA = "0xA85C", Offset = "0xA85C", VA = "0xA85C", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B9E")]
		[Address(RVA = "0xA85D", Offset = "0xA85D", VA = "0xA85D", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06005B9F RID: 23455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A6")]
		private object Current
		{
			[Token(Token = "0x6005B9F")]
			[Address(RVA = "0xA85E", Offset = "0xA85E", VA = "0xA85E", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170012A7")]
		private Money Current
		{
			[Token(Token = "0x6005BA0")]
			[Address(RVA = "0xA85F", Offset = "0xA85F", VA = "0xA85F", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0xA860", Offset = "0xA860", VA = "0xA860", Slot = "10")]
		private IEnumerator GetEnumerator()
		{
		/* --- GHIDRA: GetEnumerator ---
		undefined4 Core_Money_Money__GetEnumerator(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int param1_01;
		  undefined4 *puVar2;
		  int param1_02;
		  double param3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a60606 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Cast_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Money__object___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Clone_b__35_0__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a60606 = '\x01';
		  }
		  param3 = *(double *)(param1 + 0x10);
		  param2_00 = *(undefined4 *)(param1 + 8);
		  param1_01 = *(int *)(param1 + 0x18);
		  if (param1_01 != 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    param1_02 = puVar2[0x19];
		    if (param1_02 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar2;
		      param1_02 = unnamed_function_1417(System_Func_Money__object__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_02,uVar1,Method_Core_Money_Money___c__Clone_b__35_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 100) = param1_02;
		    }
		    uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (param1_01,param1_02,Method_System_Linq_Enumerable_Select_Money__object___);
		    uVar1 = System_Linq_Enumerable__Cast_DictionaryEntry_
		                      (uVar1,Method_System_Linq_Enumerable_Cast_Money___);
		  }
		  param1_00 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		  Core_Money_Money__op_Equality(param1_00,param2_00,param3,uVar1,param1_00);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0xA861", Offset = "0xA861", VA = "0xA861", Slot = "9")]
		public IEnumerator<Money> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0xA862", Offset = "0xA862", VA = "0xA862", Slot = "11")]
		public object Clone()
		{
		/* --- GHIDRA: Clone ---
		undefined4 Core_Money_Money__Clone(undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60607 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_ValueTuple_int__double____);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_ValueTuple_int__double___int___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_IGrouping_Money_MoneyType__Money___ValueTuple_int__double____
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ValueTuple_int__double____);
		    Mono_Security_ASN1__get_Item(&System_Func_ValueTuple_int__double___int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_IGrouping_Money_MoneyType__Money___ValueTuple_int__double___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Equals_b__36_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Equals_b__36_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Equals_b__36_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Equals_b__36_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Equals_b__36_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Equals_b__36_5__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a60607 = '\x01';
		  }
		  local_8 = 0;
		  if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[0x1a];
		  if (iVar3 == 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar1,Method_Core_Money_Money___c__Equals_b__36_0__,0);
		    *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x68) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (param1,iVar3,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		  if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[0x1c];
		  if (iVar3 == 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417
		                      (
		                      System_Func_IGrouping_Money_MoneyType__Money___ValueTuple_int__double___TypeInfo
		                      );
		    System_Func_object__ValueTuple_bool__object____Invoke
		              (iVar3,uVar4,Method_Core_Money_Money___c__Equals_b__36_1__,0);
		    *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x70) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Select_NamedValue__object_
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_Select_IGrouping_Money_MoneyType__Money___ValueTuple_int__double____
		                    );
		  if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[0x1d];
		  if (iVar3 == 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_ValueTuple_int__double___int__TypeInfo);
		    System_Func_ValueTuple_int__double___bool___Invoke
		              (iVar3,uVar4,Method_Core_Money_Money___c__Equals_b__36_2__,0);
		    *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x74) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_OrderBy_ValueTuple_int__double___int___);
		  iVar3 = System_Linq_Enumerable__ToArray_KeyValuePair_ulong__object__
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_ValueTuple_int__double____);
		  if (param2 != 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar6 = puVar2[0x1e];
		    if (iVar6 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar2;
		      iVar6 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar6,uVar1,Method_Core_Money_Money___c__Equals_b__36_3__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x78) = iVar6;
		    }
		    uVar1 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param2,iVar6,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar6 = puVar2[0x20];
		    if (iVar6 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar2;
		      iVar6 = unnamed_function_1417
		                        (
		                        System_Func_IGrouping_Money_MoneyType__Money___ValueTuple_int__double___TypeInfo
		                        );
		      System_Func_object__ValueTuple_bool__object____Invoke
		                (iVar6,uVar4,Method_Core_Money_Money___c__Equals_b__36_4__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x80) = iVar6;
		    }
		    uVar1 = System_Linq_Enumerable__Select_NamedValue__object_
		                      (uVar1,iVar6,
		                       Method_System_Linq_Enumerable_Select_IGrouping_Money_MoneyType__Money___ValueTuple_int__double____
		                      );
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar6 = puVar2[0x21];
		    if (iVar6 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar2;
		      iVar6 = unnamed_function_1417(System_Func_ValueTuple_int__double___int__TypeInfo);
		      System_Func_ValueTuple_int__double___bool___Invoke
		                (iVar6,uVar4,Method_Core_Money_Money___c__Equals_b__36_5__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x84) = iVar6;
		    }
		    uVar1 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                      (uVar1,iVar6,
		                       Method_System_Linq_Enumerable_OrderBy_ValueTuple_int__double___int___);
		    iVar6 = System_Linq_Enumerable__ToArray_KeyValuePair_ulong__object__
		                      (uVar1,Method_System_Linq_Enumerable_ToArray_ValueTuple_int__double____);
		    if (iVar6 != 0) goto code_r0x81cb8c8a;
		  }
		  iVar6 = Method_System_Array_Empty_ValueTuple_int__double____;
		  iVar5 = *(int *)(Method_System_Array_Empty_ValueTuple_int__double____ + 0x1c);
		  if (iVar5 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (Method_System_Array_Empty_ValueTuple_int__double____);
		    iVar5 = *(int *)(iVar6 + 0x1c);
		  }
		  iVar5 = *(int *)(iVar5 + 8);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  if (*(int *)(iVar5 + 0x74) == 0) {
		    func_ii_306000(iVar5);
		  }
		  iVar6 = *(int *)(*(int *)(iVar6 + 0x1c) + 8);
		  if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		    iVar6 = func_ii_1079(iVar6);
		  }
		  iVar6 = **(int **)(iVar6 + 0x5c);
		code_r0x81cb8c8a:
		  uVar1 = 0;
		  if ((*(int *)(iVar3 + 0xc) == *(int *)(iVar6 + 0xc)) && (uVar1 = 1, 0 < *(int *)(iVar3 + 0xc))) {
		    iVar5 = 0;
		    do {
		      iVar7 = iVar3 + iVar5 * 0x10;
		      local_8 = *(undefined8 *)(iVar7 + 0x18);
		      iVar8 = iVar5 * 0x10 + iVar6;
		      if (*(int *)(iVar8 + 0x10) != (int)*(undefined8 *)(iVar7 + 0x10)) {
		        return 0;
		      }
		      iVar7 = System_Double__Equals(&local_8,*(double *)(iVar8 + 0x18),0);
		      if (iVar7 == 0) {
		        return 0;
		      }
		      uVar1 = 1;
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0xA863", Offset = "0xA863", VA = "0xA863", Slot = "12")]
		public bool Equals(Money other)
		{
		/* --- GHIDRA: Equals ---
		int Core_Money_Money__Equals(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  ulonglong uVar2;
		  ulonglong uVar3;
		  
		  iVar1 = **(int **)(param1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xd0) * 4))
		                    (*(int **)(param1 + 8),*(undefined4 *)(iVar1 + 0xd4));
		  uVar2 = *(ulonglong *)(param1 + 0x10);
		  uVar3 = uVar2 & 0x7ff0000000000000;
		  if ((uVar2 - 1 & 0x7ff0000000000000) != 0x7ff0000000000000) {
		    uVar3 = uVar2;
		  }
		  return iVar1 + ((uint)(uVar3 >> 0x20) ^ (uint)uVar3);
		}
		*/

		/* --- GHIDRA: Equals ---
		int Core_Money_Money__Equals(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  ulonglong uVar2;
		  ulonglong uVar3;
		  
		  iVar1 = **(int **)(param1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xd0) * 4))
		                    (*(int **)(param1 + 8),*(undefined4 *)(iVar1 + 0xd4));
		  uVar2 = *(ulonglong *)(param1 + 0x10);
		  uVar3 = uVar2 & 0x7ff0000000000000;
		  if ((uVar2 - 1 & 0x7ff0000000000000) != 0x7ff0000000000000) {
		    uVar3 = uVar2;
		  }
		  return iVar1 + ((uint)(uVar3 >> 0x20) ^ (uint)uVar3);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0xA864", Offset = "0xA864", VA = "0xA864", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0xA865", Offset = "0xA865", VA = "0xA865", Slot = "2")]
		public override int GetHashCode()
		{
		/* --- GHIDRA: GetHashCode ---
		undefined4 Core_Money_Money__GetHashCode(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  undefined4 uVar4;
		  float8 local_8;
		  
		  if (DAT_ram_00a60609 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Money__string___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__ToString_b__39_0__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7248);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2040);
		    DAT_ram_00a60609 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar1 = StringLiteral_7248;
		  if (iVar2 == **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c)) {
		    iVar2 = *(int *)(param1 + 0x18);
		    if (*(int *)(iVar2 + 0xc) != 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		      }
		      uVar1 = StringLiteral_2040;
		      puVar3 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      param1_00 = puVar3[0x22];
		      if (param1_00 == 0) {
		        if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Money_Money___c_TypeInfo);
		          puVar3 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		        }
		        uVar4 = *puVar3;
		        param1_00 = unnamed_function_1417(System_Func_Money__string__TypeInfo);
		        System_Linq_Enumerable__Where_object_
		                  (param1_00,uVar4,Method_Core_Money_Money___c__ToString_b__39_0__,0);
		        *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x88) = param1_00;
		      }
		      uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                        (iVar2,param1_00,Method_System_Linq_Enumerable_Select_Money__string___);
		      uVar1 = func_ii_7793(uVar1,uVar4,0);
		    }
		  }
		  else {
		    local_8 = *(float8 *)(param1 + 0x10);
		    if (0.0 < (double)local_8) {
		      uVar4 = *(undefined4 *)(param1 + 8);
		      uVar1 = func_ii_1081(DAT_ram_00a66970,&local_8);
		      uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_28682,uVar4,uVar1,0);
		    }
		  }
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0xA866", Offset = "0xA866", VA = "0xA866", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Money_Money__ToString(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6060a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a6060a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__
		            );
		  **(undefined4 **)(Core_Money_Money_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<Money> _complexContent;

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _counter;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Money _current;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<Money.MoneyType, double> EmptyMoneyMap;

		// Token: 0x02000EB5 RID: 3765
		[Token(Token = "0x2000EB5")]
		public sealed class MoneyType
		{
			// Token: 0x06005BA9 RID: 23465 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005BA9")]
			[Address(RVA = "0xA868", Offset = "0xA868", VA = "0xA868")]
			public static IEnumerable<Money.MoneyType> GetEnumerable()
			{
				return null;
			}

			// Token: 0x06005BAA RID: 23466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005BAA")]
			[Address(RVA = "0xA869", Offset = "0xA869", VA = "0xA869")]
			private MoneyType(int value)
			{
			}

			// Token: 0x06005BAB RID: 23467 RVA: 0x00010560 File Offset: 0x0000E760
			[Token(Token = "0x6005BAB")]
			[Address(RVA = "0xA86A", Offset = "0xA86A", VA = "0xA86A")]
			public static implicit operator int(Money.MoneyType type)
			{
				return 0;
			}

			// Token: 0x06005BAC RID: 23468 RVA: 0x00010578 File Offset: 0x0000E778
			[Token(Token = "0x6005BAC")]
			[Address(RVA = "0x1C6F", Offset = "0x1C6F", VA = "0x1C6F")]
			public static implicit operator Resources(Money.MoneyType type)
			{
				return Resources.UnknownResource;
			}

			// Token: 0x06005BAD RID: 23469 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005BAD")]
			[Address(RVA = "0x1B15", Offset = "0x1B15", VA = "0x1B15")]
			public static implicit operator Money.MoneyType(Resources resources)
			{
				return null;
			}

			// Token: 0x06005BAE RID: 23470 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6005BAE")]
			[Address(RVA = "0xA86B", Offset = "0xA86B", VA = "0xA86B", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040031FF RID: 12799
			[Token(Token = "0x40031FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Money.MoneyType Complex;

			// Token: 0x04003200 RID: 12800
			[Token(Token = "0x4003200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly Money.MoneyType Crystals;

			// Token: 0x04003201 RID: 12801
			[Token(Token = "0x4003201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly Money.MoneyType Diamonds;

			// Token: 0x04003202 RID: 12802
			[Token(Token = "0x4003202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly Money.MoneyType Energy;

			// Token: 0x04003203 RID: 12803
			[Token(Token = "0x4003203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly Money.MoneyType Onyxes;

			// Token: 0x04003204 RID: 12804
			[Token(Token = "0x4003204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly Money.MoneyType ColossusFragments;

			// Token: 0x04003205 RID: 12805
			[Token(Token = "0x4003205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly Money.MoneyType ThemeDuelPoints;

			// Token: 0x04003206 RID: 12806
			[Token(Token = "0x4003206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly Money.MoneyType PortalPoints;

			// Token: 0x04003207 RID: 12807
			[Token(Token = "0x4003207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly int _value;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		int Core_Money_Money__get_Value(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined8 *puVar2;
		  uint uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  uint *puVar9;
		  int iVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a605f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a605f6 = '\x01';
		  }
		  iVar4 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = param1;
		  do {
		    piVar8 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar3 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x81cb5656;
		        }
		        uVar3 = uVar3 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar3);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb569e:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb5985;
		    }
		code_r0x81cb5656:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cb569e;
		    if (iVar10 == 0) {
		      iVar10 = 0;
		      goto code_r0x81cb59ce;
		    }
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar3 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar3 * 8);
		        if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x81cb574f;
		        }
		        uVar3 = uVar3 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar3);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cb57e5:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb5985;
		    }
		code_r0x81cb574f:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cb57e5;
		    iVar7 = *(int *)(iVar10 + 8);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cb5985;
		      }
		    }
		    iVar7 = *(int *)(iVar7 + 8);
		    puVar2 = (undefined8 *)(iVar4 + 0x10);
		    if ((((iVar7 != 1) && (puVar2 = (undefined8 *)(iVar4 + 0x18), iVar7 != 2)) &&
		        (puVar2 = (undefined8 *)(iVar4 + 0x20), iVar7 != 3)) &&
		       ((puVar2 = (undefined8 *)(iVar4 + 0x28), iVar7 != 4 &&
		        (puVar2 = (undefined8 *)(iVar4 + 0x30), iVar7 != 5)))) break;
		    *puVar2 = *(undefined8 *)(iVar10 + 0x10);
		  } while( true );
		  uVar11 = *(undefined4 *)(iVar10 + 8);
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,&StringLiteral_16003);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,uVar6,uVar11,0);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar11 = import::env::invoke_ii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                          &System_NotSupportedException_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar11 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar11);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1f8,uVar11,uVar6,0);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::invoke_ii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                               &Method_Core_Money_Money_op_Explicit__);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii(0x41b,uVar11,uVar6);
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
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cb5985;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb5985:
		  iVar10 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar6);
		    iVar10 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar10;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x81cb59ce:
		      piVar8 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar3 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8)) {
		              puVar9 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cb5a46;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		        }
		        puVar9 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81cb5a46:
		        (**(code **)((ulonglong)*puVar9 * 4))(piVar8,puVar9[1]);
		      }
		      if (iVar10 == 0) {
		        return iVar4;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x15,&local_c);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: op_Explicit ---
		int Core_Money_Money__op_Explicit(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  double dVar5;
		  
		  if (DAT_ram_00a605f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a605f7 = '\x01';
		  }
		  if (param1 == 0) {
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    if (DAT_ram_00a605fb == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		      DAT_ram_00a605fb = '\x01';
		    }
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    uVar3 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		    uVar4 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		    Core_Money_Money__op_Equality(uVar4,uVar3,0.0,0,uVar3);
		    return uVar4;
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Money__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,4,Method_System_Collections_Generic_List_Money___ctor__);
		  dVar5 = *(double *)(param1 + 0x10);
		  if (0.0 < dVar5) {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      dVar5 = *(double *)(param1 + 0x10);
		    }
		    uVar4 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 4);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Data_ArtifactData__get_SellPrice(uVar4,dVar5,param1_00);
		    iVar1 = Method_System_Collections_Generic_List_Money__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  dVar5 = *(double *)(param1 + 0x18);
		  if (0.0 < dVar5) {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      dVar5 = *(double *)(param1 + 0x18);
		    }
		    uVar4 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Data_ArtifactData__get_SellPrice(uVar4,dVar5,param1_00);
		    iVar1 = Method_System_Collections_Generic_List_Money__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  dVar5 = *(double *)(param1 + 0x20);
		  if (0.0 < dVar5) {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      dVar5 = *(double *)(param1 + 0x20);
		    }
		    uVar4 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Data_ArtifactData__get_SellPrice(uVar4,dVar5,param1_00);
		    iVar1 = Method_System_Collections_Generic_List_Money__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  dVar5 = *(double *)(param1 + 0x28);
		  if (0.0 < dVar5) {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      dVar5 = *(double *)(param1 + 0x28);
		    }
		    uVar4 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x10);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Data_ArtifactData__get_SellPrice(uVar4,dVar5,param1_00);
		    iVar1 = Method_System_Collections_Generic_List_Money__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  dVar5 = *(double *)(param1 + 0x30);
		  if (0.0 < dVar5) {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      dVar5 = *(double *)(param1 + 0x30);
		    }
		    uVar4 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x14);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar4 = Core_Data_ArtifactData__get_SellPrice(uVar4,dVar5,param1_00);
		    iVar1 = Method_System_Collections_Generic_List_Money__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  if (*(int *)(param1_00 + 0xc) < 2) {
		    iVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                      (param1_00,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    if (iVar1 == 0) {
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      if (DAT_ram_00a605fb == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		        Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		        DAT_ram_00a605fb = '\x01';
		      }
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar3 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		      uVar4 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		      Core_Money_Money__op_Equality(uVar4,uVar3,0.0,0,uVar3);
		      return uVar4;
		    }
		  }
		  else {
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    uVar4 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		    iVar1 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		    Core_Money_Money__op_Equality(iVar1,uVar4,0.0,param1_00,param1_00);
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: op_Addition ---
		undefined4 Core_Money_Money__op_Addition(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  float8 fVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  uint uVar10;
		  undefined4 uVar11;
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
		  
		  if (DAT_ram_00a605fd == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Subtraction_b__18_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Subtraction_b__18_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Subtraction_b__18_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Subtraction_b__18_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Subtraction_b__18_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Subtraction_b__18_5__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a605fd = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0.0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0.0;
		  if (param1 == 0) {
		code_r0x81cb7bb6:
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar7 = **(int **)(Core_Money_Money_TypeInfo + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar7 = puVar8[10];
		    if (iVar7 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar5 = *puVar8;
		      iVar7 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar7,uVar5,Method_Core_Money_Money___c__op_Subtraction_b__18_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x28) = iVar7;
		    }
		    uVar5 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param1,iVar7,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[0xb];
		    iVar7 = Core_Money_Money___c_TypeInfo;
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar9 = unnamed_function_1417
		                        (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar9,uVar11,Method_Core_Money_Money___c__op_Subtraction_b__18_1__,0);
		      iVar7 = Core_Money_Money___c_TypeInfo;
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x2c) = iVar9;
		    }
		    if (*(int *)(iVar7 + 0x74) == 0) {
		      func_ii_306000(iVar7);
		      iVar7 = Core_Money_Money___c_TypeInfo;
		    }
		    puVar8 = *(undefined4 **)(iVar7 + 0x5c);
		    iVar3 = puVar8[0xd];
		    if (iVar3 == 0) {
		      if (*(int *)(iVar7 + 0x74) == 0) {
		        func_ii_306000(iVar7);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar3 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo)
		      ;
		      System_Func_object__bool___Invoke
		                (iVar3,uVar11,Method_Core_Money_Money___c__op_Subtraction_b__18_2__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x34) = iVar3;
		    }
		    iVar7 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (uVar5,iVar9,iVar3,
		                       Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                      );
		    if (iVar7 == 0) goto code_r0x81cb7bb6;
		  }
		  if (param2 == 0) {
		code_r0x81cb7d83:
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar9 = **(int **)(Core_Money_Money_TypeInfo + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar9 = puVar8[0xe];
		    if (iVar9 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar5 = *puVar8;
		      iVar9 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar9,uVar5,Method_Core_Money_Money___c__op_Subtraction_b__18_3__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x38) = iVar9;
		    }
		    uVar5 = System_Linq_Enumerable__GroupBy_object__uint_
		                      (param2,iVar9,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___)
		    ;
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar3 = puVar8[0xf];
		    iVar9 = Core_Money_Money___c_TypeInfo;
		    if (iVar3 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar3 = unnamed_function_1417
		                        (System_Func_IGrouping_Money_MoneyType__Money___Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar3,uVar11,Method_Core_Money_Money___c__op_Subtraction_b__18_4__,0);
		      iVar9 = Core_Money_Money___c_TypeInfo;
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x3c) = iVar3;
		    }
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      iVar9 = Core_Money_Money___c_TypeInfo;
		    }
		    puVar8 = *(undefined4 **)(iVar9 + 0x5c);
		    iVar4 = puVar8[0x11];
		    if (iVar4 == 0) {
		      if (*(int *)(iVar9 + 0x74) == 0) {
		        func_ii_306000(iVar9);
		        puVar8 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar11 = *puVar8;
		      iVar4 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___double__TypeInfo)
		      ;
		      System_Func_object__bool___Invoke
		                (iVar4,uVar11,Method_Core_Money_Money___c__op_Subtraction_b__18_5__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x44) = iVar4;
		    }
		    iVar9 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (uVar5,iVar3,iVar4,
		                       Method_System_Linq_Enumerable_ToDictionary_IGrouping_Money_MoneyType__Money___Money_MoneyType__double___
		                      );
		    if (iVar9 == 0) goto code_r0x81cb7d83;
		  }
		  iVar3 = unnamed_function_1417(System_Collections_Generic_List_Money__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar3,4,Method_System_Collections_Generic_List_Money___ctor__);
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_58,iVar7,
		             Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__GetEnumerator__);
		  local_8 = local_38;
		  local_10 = local_40;
		  local_18 = local_48;
		  local_20 = local_50;
		  local_28 = CONCAT44(puStack_54,local_58);
		  local_58 = 0;
		  puStack_54 = &local_28;
		  do {
		    while( true ) {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                           Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                          );
		        fVar2 = local_10;
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cb8229;
		        }
		        if (iVar4 == 0) {
		          iVar4 = 0x15;
		          iVar7 = local_58;
		          goto code_r0x81cb8276;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar5 = (undefined4)local_18;
		        iVar4 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29e,iVar9,
		                           (undefined4)local_18,&local_30,
		                           Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__TryGetValue__
		                          );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cb8229;
		        }
		        if (iVar4 == 0) {
		          local_30 = fVar2;
		        }
		        else {
		          local_30 = (float8)((double)fVar2 - (double)local_30);
		          if ((double)local_30 < 0.0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &
		                       Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Key__
		                      );
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cb8229;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar11 = import::env::invoke_ii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                &StringLiteral_17626);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,uVar11,
		                                 uVar5,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar11 = import::env::invoke_ii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                    &Core_Money_MoneyException_TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar11 = import::env::invoke_ii
		                                     (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar11
		                                     );
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x19,uVar11,uVar5,
		                               auStack_60);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      uVar5 = import::env::invoke_ii
		                                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                         &Method_Core_Money_Money_op_Subtraction__);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_vii(0x41b,uVar11,uVar5);
		                        if (DAT_ram_009d3e38 != 1) goto code_r0x81cb867e;
		                      }
		                    }
		                  }
		                }
		                DAT_ram_009d3e38 = 0;
		                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x81cb8229;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cb8229;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29f,iVar9,uVar5,
		                     Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Remove__)
		          ;
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81cb8229;
		          }
		        }
		        fVar2 = local_30;
		      } while ((double)local_30 <= 0.0);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,Core_Money_Money_TypeInfo
		                  );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cb8229;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iidi
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,uVar5,(double)fVar2,
		                         auStack_60);
		      iVar7 = Method_System_Collections_Generic_List_Money__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81cb820d;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      uVar10 = *(uint *)(iVar3 + 0xc);
		      if (*(uint *)(*(int *)(iVar3 + 8) + 0xc) <= uVar10) break;
		      *(uint *)(iVar3 + 0xc) = uVar10 + 1;
		      *(undefined4 *)(*(int *)(iVar3 + 8) + uVar10 * 4 + 0x10) = uVar5;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,uVar5,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x81cb820d:
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cb8229:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar7 = *piVar6;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_58 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x81cb8276:
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar4 != 0 && iVar4 != 0x15) {
		        DAT_ram_009d3e38 = 0;
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
		      DAT_ram_009d3e38 = 0;
		      local_58 = 0;
		      puStack_54 = &local_28;
		      iVar9 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29d,&local_28,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__MoveNext__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        if (iVar9 == 0) goto code_r0x81cb85c4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                   &
		                   Method_System_Collections_Generic_Dictionary_Enumerator_Money_MoneyType__double__get_Current__
		                  );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar5 = (undefined4)local_18;
		          import::env::invoke_ii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                     &
		                     Method_System_Collections_Generic_KeyValuePair_Money_MoneyType__double__get_Key__
		                    );
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            uVar11 = import::env::invoke_ii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                &StringLiteral_17626);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,uVar11,
		                                 uVar5,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                uVar11 = import::env::invoke_ii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                    &Core_Money_MoneyException_TypeInfo);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar11 = import::env::invoke_ii
		                                     (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar11
		                                     );
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x19,uVar11,uVar5,
		                               auStack_60);
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      uVar5 = import::env::invoke_ii
		                                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                         &Method_Core_Money_Money_op_Subtraction__);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_vii(0x41b,uVar11,uVar5);
		                        if (DAT_ram_009d3e38 != 1) {
		code_r0x81cb867e:
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
		                goto code_r0x81cb8567;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		        }
		      }
		code_r0x81cb8567:
		      iVar7 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar9) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar9 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_58 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          if (iVar9 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x81cb85c4:
		          DAT_ram_009d3e38 = 0;
		          if (*(int *)(iVar3 + 0xc) < 2) {
		            uVar5 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                              (iVar3,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		          }
		          else {
		            if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		            }
		            uVar11 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		            uVar5 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		            Core_Money_Money__op_Equality(uVar5,uVar11,0.0,iVar3,auStack_60);
		          }
		          return uVar5;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1b,&local_58);
		      goto joined_r0x81cb8615;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x1a,&local_58);
		joined_r0x81cb8615:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
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


		/* --- GHIDRA: op_Subtraction ---
		undefined4 Core_Money_Money__op_Subtraction(int param1,double param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a605fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__op_Multiply_b__19_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__DisplayClass19_0__op_Multiply_b__1__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c__DisplayClass19_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a605fe = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Money_Money___c__DisplayClass19_0_TypeInfo);
		  *(double *)(param2_00 + 8) = param2;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = 0;
		  if ((param1 != 0) && (iVar2 = Core_Money_Money__Clone(param1,0,param1), iVar2 == 0)) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    iVar2 = puVar3[0x12];
		    if (iVar2 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar3;
		      iVar2 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar2,uVar1,Method_Core_Money_Money___c__op_Multiply_b__19_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x48) = iVar2;
		    }
		    uVar1 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (uVar1,param2_00,Method_Core_Money_Money___c__DisplayClass19_0__op_Multiply_b__1__,0);
		    uVar1 = System_Linq_Enumerable__ToDictionary_object__Int32Enum__object_
		                      (param1,iVar2,uVar1,
		                       Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType__double___)
		    ;
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar1 = Core_Money_Money__FromResourceSet(uVar1,uVar1);
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: op_Multiply ---
		uint Core_Money_Money__op_Multiply(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a60600 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a60600 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  iVar2 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		  if ((iVar1 == iVar2) && (*(int *)(*(int *)(param1 + 0x18) + 0xc) == 0)) {
		    return 1;
		  }
		  iVar1 = *(int *)(param1 + 8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    iVar2 = **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		  }
		  if (iVar1 == iVar2) {
		    return 0;
		  }
		  return (uint)(*(double *)(param1 + 0x10) <= 0.0);
		}
		*/


		/* --- GHIDRA: get_IsEmpty ---
		uint Core_Money_Money__get_IsEmpty(int param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  int iVar1;
		  uint uVar2;
		  
		  param3_00 = 1;
		  if (param1 != 0) {
		    param3_00 = Core_Money_Money__Clone(param1,0,1);
		  }
		  if (param2 == 0) {
		    iVar1 = 1;
		  }
		  else {
		    iVar1 = Core_Money_Money__Clone(param2,0,param3_00);
		  }
		  uVar2 = (uint)(iVar1 != param3_00);
		  if (uVar2 == 0 && param3_00 == 0) {
		    uVar2 = Core_Money_Money__Clone(param1,param2,param3_00);
		    uVar2 = uVar2 ^ 1;
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: op_Inequality ---
		undefined4 Core_Money_Money__op_Inequality(int param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = 1;
		  param3_00 = 1;
		  if (param1 != 0) {
		    param3_00 = Core_Money_Money__Clone(param1,0,1);
		  }
		  if (param2 != 0) {
		    iVar1 = Core_Money_Money__Clone(param2,0,param3_00);
		  }
		  if (param3_00 != iVar1 || param3_00 != 0) {
		    return (uint)(param3_00 == iVar1);
		  }
		  uVar2 = Core_Money_Money__Clone(param1,param2,param3_00);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: op_Equality ---
		void Core_Money_Money__op_Equality(int param1,int param2,double param3,int param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a60601 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a60601 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  *(double *)(param1 + 0x10) = param3;
		  *(int *)(param1 + 8) = param2;
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  iVar2 = Method_System_Array_Empty_Money___;
		  if (param2 == **(int **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c)) {
		    if (param4 == 0) {
		      iVar1 = *(int *)(Method_System_Array_Empty_Money___ + 0x1c);
		      if (iVar1 == 0) {
		        System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_Money___);
		        iVar1 = *(int *)(iVar2 + 0x1c);
		      }
		      iVar1 = *(int *)(iVar1 + 8);
		      if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		        iVar1 = func_ii_1079(iVar1);
		      }
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		      }
		      iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		      if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		        iVar2 = func_ii_1079(iVar2);
		      }
		      param4 = **(int **)(iVar2 + 0x5c);
		    }
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_Money__TypeInfo);
		    Sirenix_Utilities_LinqExtensions__Convert_object_
		              (param1_00,param4,Method_System_Collections_Generic_List_Money___ctor__);
		  }
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: System.Collections.IEnumerator.MoveNext ---
		void Core_Money_Money__System_Collections_IEnumerator_MoveNext(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 *puVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60603 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Money_Money___c__System_Collections_IEnumerator_Reset_b__27_0__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a60603 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  param1_00 = *(int *)(param1 + 0x18);
		  if (param1_00 != 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar1 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    param1_01 = puVar1[0x17];
		    if (param1_01 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar1 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar1;
		      param1_01 = unnamed_function_1417(System_Action_Money__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param2_00,
		                 Method_Core_Money_Money___c__System_Collections_IEnumerator_Reset_b__27_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x5c) = param1_01;
		    }
		    System_Collections_Generic_List_UsageHint___FindLastIndex
		              (param1_00,param1_01,Method_System_Collections_Generic_List_Money__ForEach__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: System.Collections.IEnumerator.Reset ---
		void Core_Money_Money__System_Collections_IEnumerator_Reset(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 *puVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60604 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__ForEach__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_Money___c__Dispose_b__28_0__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money___c_TypeInfo);
		    DAT_ram_00a60604 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  param1_00 = *(int *)(param1 + 0x18);
		  if (param1_00 != 0) {
		    if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money___c_TypeInfo);
		    }
		    puVar1 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		    param1_01 = puVar1[0x18];
		    if (param1_01 == 0) {
		      if (*(int *)(Core_Money_Money___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money___c_TypeInfo);
		        puVar1 = *(undefined4 **)(Core_Money_Money___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar1;
		      param1_01 = unnamed_function_1417(System_Action_Money__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param2_00,Method_Core_Money_Money___c__Dispose_b__28_0__,0);
		      *(int *)(*(int *)(Core_Money_Money___c_TypeInfo + 0x5c) + 0x60) = param1_01;
		    }
		    System_Collections_Generic_List_UsageHint___FindLastIndex
		              (param1_00,param1_01,Method_System_Collections_Generic_List_Money__ForEach__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: System.Collections.IEnumerator.get_Current ---
		int Core_Money_Money__System_Collections_IEnumerator_get_Current(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a60605 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a60605 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    if (DAT_ram_00a605fb == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		      DAT_ram_00a605fb = '\x01';
		    }
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		    }
		    param2_00 = **(undefined4 **)(Core_Money_Money_MoneyType_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Money_Money_TypeInfo);
		    Core_Money_Money__op_Equality(param1_00,param2_00,0.0,0,param1_00);
		  }
		  return param1_00;
		}
		*/

}
