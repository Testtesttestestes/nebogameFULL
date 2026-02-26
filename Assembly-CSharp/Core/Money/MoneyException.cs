using System;
using Il2CppDummyDll;

namespace Core.Money
{
	// Token: 0x02000EB9 RID: 3769
	[Token(Token = "0x2000EB9")]
	public sealed class MoneyException : Exception
	{
		// Token: 0x06005BDE RID: 23518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0xA89B", Offset = "0xA89B", VA = "0xA89B")]
		public MoneyException()
		{
		/* --- GHIDRA: .ctor ---
		double Core_Money_MoneyException___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  double dVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a60622 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_IGrouping_Money_MoneyType__Money____);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Sum_Money___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_Money_MoneyType__Money___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetValue_b__0_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetValue_b__0_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__DisplayClass0_0__GetValue_b__1__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c__DisplayClass0_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60622 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Money_MoneyExt___c__DisplayClass0_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar5,uVar2,Method_Core_Money_MoneyExt___c__GetValue_b__0_0__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  uVar2 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (param1,iVar5,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		  param1_00 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,Method_Core_Money_MoneyExt___c__DisplayClass0_0__GetValue_b__1__,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (uVar2,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_IGrouping_Money_MoneyType__Money____
		                    );
		  if (iVar1 == 0) {
		    return 0.0;
		  }
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (iVar5,uVar2,Method_Core_Money_MoneyExt___c__GetValue_b__0_2__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 8) = iVar5;
		  }
		  dVar3 = System_Linq_Enumerable__Sum_KeyValuePair_Int32Enum__int__
		                    (iVar1,iVar5,Method_System_Linq_Enumerable_Sum_Money___);
		  return dVar3;
		}
		*/

		/* --- GHIDRA: .ctor ---
		double Core_Money_MoneyException___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  double dVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a60622 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_IGrouping_Money_MoneyType__Money____);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Sum_Money___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_Money_MoneyType__Money___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetValue_b__0_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetValue_b__0_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__DisplayClass0_0__GetValue_b__1__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c__DisplayClass0_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60622 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Money_MoneyExt___c__DisplayClass0_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar5,uVar2,Method_Core_Money_MoneyExt___c__GetValue_b__0_0__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  uVar2 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (param1,iVar5,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		  param1_00 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,Method_Core_Money_MoneyExt___c__DisplayClass0_0__GetValue_b__1__,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (uVar2,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_IGrouping_Money_MoneyType__Money____
		                    );
		  if (iVar1 == 0) {
		    return 0.0;
		  }
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (iVar5,uVar2,Method_Core_Money_MoneyExt___c__GetValue_b__0_2__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 8) = iVar5;
		  }
		  dVar3 = System_Linq_Enumerable__Sum_KeyValuePair_Int32Enum__int__
		                    (iVar1,iVar5,Method_System_Linq_Enumerable_Sum_Money___);
		  return dVar3;
		}
		*/

		/* --- GHIDRA: .ctor ---
		double Core_Money_MoneyException___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  double dVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a60622 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_IGrouping_Money_MoneyType__Money____);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Sum_Money___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_Money_MoneyType__Money___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetValue_b__0_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__GetValue_b__0_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Money_MoneyExt___c__DisplayClass0_0__GetValue_b__1__);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c__DisplayClass0_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_MoneyExt___c_TypeInfo);
		    DAT_ram_00a60622 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Money_MoneyExt___c__DisplayClass0_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar5,uVar2,Method_Core_Money_MoneyExt___c__GetValue_b__0_0__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 4) = iVar5;
		  }
		  uVar2 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (param1,iVar5,Method_System_Linq_Enumerable_GroupBy_Money__Money_MoneyType___);
		  param1_00 = unnamed_function_1417(System_Func_IGrouping_Money_MoneyType__Money___bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,Method_Core_Money_MoneyExt___c__DisplayClass0_0__GetValue_b__1__,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (uVar2,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_IGrouping_Money_MoneyType__Money____
		                    );
		  if (iVar1 == 0) {
		    return 0.0;
		  }
		  if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_MoneyExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Money_MoneyExt___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__double__TypeInfo);
		    System_Func_object__bool___Invoke
		              (iVar5,uVar2,Method_Core_Money_MoneyExt___c__GetValue_b__0_2__,0);
		    *(int *)(*(int *)(Core_Money_MoneyExt___c_TypeInfo + 0x5c) + 8) = iVar5;
		  }
		  dVar3 = System_Linq_Enumerable__Sum_KeyValuePair_Int32Enum__int__
		                    (iVar1,iVar5,Method_System_Linq_Enumerable_Sum_Money___);
		  return dVar3;
		}
		*/

		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x364F", Offset = "0x364F", VA = "0x364F")]
		public MoneyException(string message)
		{
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0xA89C", Offset = "0xA89C", VA = "0xA89C")]
		public MoneyException(string message, Exception innerException)
		{
		}
	}
}
