using System;
using System.Collections.Generic;
using Core.Money;
using Core.Sorting;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Auchan.Controller
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	public class AuchanArtifactComparers
	{
		// Token: 0x06004E7C RID: 20092 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x9CAD", Offset = "0x9CAD", VA = "0x9CAD")]
		private static int CompareQualities(AuchanArtifactData x, AuchanArtifactData y)
		{
		/* --- GHIDRA: CompareQualities ---
		undefined4
		Gameplay_Auchan_Controller_AuchanArtifactComparers__CompareQualities
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5894c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__int__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_Money__int___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceTypes_b__2_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceTypes_b__2_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		    DAT_ram_00a5894c = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_Money__int__TypeInfo);
		    func_ii_7937(iVar5,uVar1,
		                 Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceTypes_b__2_0__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c) + 4) =
		         iVar5;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                    (param1,iVar5,Method_System_Linq_Enumerable_OrderBy_Money__int___);
		  iVar5 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		  if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		  iVar6 = puVar4[2];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar4;
		    iVar6 = unnamed_function_1417(System_Func_Money__int__TypeInfo);
		    func_ii_7937(iVar6,uVar1,
		                 Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceTypes_b__2_1__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c) + 8) =
		         iVar6;
		  }
		  uVar1 = 0;
		  uVar2 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                    (param2,iVar6,Method_System_Linq_Enumerable_OrderBy_Money__int___);
		  iVar6 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar2,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar3 = Core_Money_Money__get_IsEmpty(iVar5,0,0);
		  if (iVar3 != 0) {
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar3 = Core_Money_Money__get_IsEmpty(iVar6,0,0);
		    if (iVar3 != 0) {
		      if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		      }
		      uVar1 = *(undefined4 *)(iVar5 + 8);
		      uVar2 = **(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x5c);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar1 = func_ii_7278(uVar1,0);
		      iVar5 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                        (uVar2,uVar1,&local_4,
		                         Method_System_Collections_Generic_Dictionary_Resources__int__TryGetValue__)
		      ;
		      if (iVar5 == 0) {
		        local_4 = 0x7fffffff;
		      }
		      if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		      }
		      uVar1 = *(undefined4 *)(iVar6 + 8);
		      uVar2 = **(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x5c);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar1 = func_ii_7278(uVar1,0);
		      iVar5 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                        (uVar2,uVar1,&local_8,
		                         Method_System_Collections_Generic_Dictionary_Resources__int__TryGetValue__)
		      ;
		      if (iVar5 == 0) {
		        local_8 = 0x7fffffff;
		      }
		      uVar1 = System_Data_DataTable__get_FormatProvider(&local_4,local_8,0);
		    }
		  }
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x9CAE", Offset = "0x9CAE", VA = "0x9CAE")]
		private static int CompareResourceTypes(Money x, Money y)
		{
		/* --- GHIDRA: CompareResourceTypes ---
		undefined4
		Gameplay_Auchan_Controller_AuchanArtifactComparers__CompareResourceTypes
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int iVar5;
		  float8 local_8;
		  
		  if (DAT_ram_00a5894d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_Money__int___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceAmount_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceAmount_b__3_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		    DAT_ram_00a5894d = '\x01';
		  }
		  local_8 = 0.0;
		  if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[3];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_Money__int__TypeInfo);
		    func_ii_7937(iVar4,uVar1,
		                 Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceAmount_b__3_0__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c) + 0xc)
		         = iVar4;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                    (param1,iVar4,Method_System_Linq_Enumerable_OrderBy_Money__int___);
		  iVar4 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		  if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		  iVar5 = puVar3[4];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar5 = unnamed_function_1417(System_Func_Money__int__TypeInfo);
		    func_ii_7937(iVar5,uVar1,
		                 Method_Gameplay_Auchan_Controller_AuchanArtifactComparers___c__CompareResourceAmount_b__3_1__
		                 ,0);
		    *(int *)(*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers___c_TypeInfo + 0x5c) + 0x10
		            ) = iVar5;
		  }
		  uVar1 = 0;
		  param1_00 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                        (param2,iVar5,Method_System_Linq_Enumerable_OrderBy_Money__int___);
		  iVar5 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (param1_00,Method_System_Linq_Enumerable_FirstOrDefault_Money___);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar2 = Core_Money_Money__get_IsEmpty(iVar4,0,0);
		  if (iVar2 != 0) {
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar2 = Core_Money_Money__get_IsEmpty(iVar5,0,0);
		    if (iVar2 != 0) {
		      local_8 = *(float8 *)(iVar5 + 0x10);
		      uVar1 = System_Decimal__Compare(&local_8,*(double *)(iVar4 + 0x10),0);
		    }
		  }
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x9CAF", Offset = "0x9CAF", VA = "0x9CAF")]
		private static int CompareResourceAmount(Money x, Money y)
		{
		/* --- GHIDRA: CompareResourceAmount ---
		undefined4
		Gameplay_Auchan_Controller_AuchanArtifactComparers__CompareResourceAmount
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 param2_00;
		  undefined8 local_8;
		  
		  local_8 = func_ii_7957(*(undefined4 *)(param1 + 0x1c),0);
		  param2_00 = func_ii_7957(*(undefined4 *)(param2 + 0x1c),0);
		  uVar1 = System_UInt64__CompareTo(&local_8,param2_00,0);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x9CB0", Offset = "0x9CB0", VA = "0x9CB0")]
		private static int CompareArtifactId(AuchanArtifactData x, AuchanArtifactData y)
		{
		/* --- GHIDRA: CompareArtifactId ---
		undefined4
		Gameplay_Auchan_Controller_AuchanArtifactComparers__CompareArtifactId
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5894e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    DAT_ram_00a5894e = '\x01';
		  }
		  local_4 = 0x7fffffff;
		  piVar3 = *(int **)(param1 + 0x20);
		  if (piVar3 != (int *)0x0) {
		    uVar1 = 0;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80f4c654;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,4);
		code_r0x80f4c654:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar5 == 2) {
		      local_4 = 0;
		    }
		  }
		  piVar3 = *(int **)(param2 + 0x20);
		  if (piVar3 == (int *)0x0) {
		    uVar4 = 0x7fffffff;
		  }
		  else {
		    uVar1 = 0;
		    uVar4 = 0x7fffffff;
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80f4c6f3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,4);
		code_r0x80f4c6f3:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar5 == 2) {
		      uVar4 = 0;
		    }
		  }
		  uVar4 = System_Data_DataTable__get_FormatProvider(&local_4,uVar4,0);
		  return uVar4;
		}
		*/

			return 0;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6004E80")]
		[Address(RVA = "0x9CB1", Offset = "0x9CB1", VA = "0x9CB1")]
		private static int CompareDiscount(AuchanArtifactData x, AuchanArtifactData y)
		{
			return 0;
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x9CB2", Offset = "0x9CB2", VA = "0x9CB2")]
		public AuchanArtifactComparers()
		{
		/* --- GHIDRA: .cctor ---
		int Gameplay_Auchan_Controller_AuchanArtifactComparers___cctor
		              (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined8 param2_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58950 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58950 = '\x01';
		  }
		  uVar2 = func_ii_7954(*(undefined4 *)(param2 + 0x1c),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  uVar3 = func_ii_7954(*(undefined4 *)(param3 + 0x1c),0);
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  iVar1 = Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo;
		  if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		  }
		  iVar4 = Gameplay_Auchan_Controller_AuchanArtifactComparers__CompareQualities(uVar2,uVar3,iVar1);
		  iVar1 = Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo;
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		    }
		    iVar4 = Gameplay_Auchan_Controller_AuchanArtifactComparers__CompareResourceTypes
		                      (uVar2,uVar3,iVar1);
		    if (iVar4 == 0) {
		      if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		      }
		      local_c = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x1c) + 0x14) + 0xc);
		      iVar4 = System_UInt32__CompareTo
		                        (&local_c,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x14) + 0xc),0)
		      ;
		      if (iVar4 == 0) {
		        if (*(int *)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		        }
		        local_8 = func_ii_7957(*(undefined4 *)(param2 + 0x1c),0);
		        param2_00 = func_ii_7957(*(undefined4 *)(param3 + 0x1c),0);
		        iVar4 = System_UInt64__CompareTo(&local_8,param2_00,0);
		      }
		    }
		  }
		  return iVar4;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_Controller_AuchanArtifactComparers___ctor(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5894f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__int__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__int___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_Resources__int__TypeInfo);
		    DAT_ram_00a5894f = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_Resources__int__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_Resources__int___ctor__);
		  System_Collections_Generic_Dictionary_Int32Enum__int____ctor
		            (param1_00,2,0,Method_System_Collections_Generic_Dictionary_Resources__int__Add__);
		  System_Collections_Generic_Dictionary_Int32Enum__int____ctor
		            (param1_00,4,1,Method_System_Collections_Generic_Dictionary_Resources__int__Add__);
		  System_Collections_Generic_Dictionary_Int32Enum__int____ctor
		            (param1_00,1,2,Method_System_Collections_Generic_Dictionary_Resources__int__Add__);
		  System_Collections_Generic_Dictionary_Int32Enum__int____ctor
		            (param1_00,3,3,Method_System_Collections_Generic_Dictionary_Resources__int__Add__);
		  System_Collections_Generic_Dictionary_Int32Enum__int____ctor
		            (param1_00,5,4,Method_System_Collections_Generic_Dictionary_Resources__int__Add__);
		  **(undefined4 **)(Gameplay_Auchan_Controller_AuchanArtifactComparers_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Resources, int> _sortOrder;

		// Token: 0x02000C99 RID: 3225
		[Token(Token = "0x2000C99")]
		public class ByCost : AbstractGameDataComparer<AuchanArtifactData>
		{
			// Token: 0x06004E83 RID: 20099 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
			[Token(Token = "0x6004E83")]
			[Address(RVA = "0x9CB4", Offset = "0x9CB4", VA = "0x9CB4", Slot = "8")]
			public override int Compare(AuchanArtifactData x, AuchanArtifactData y)
			{
				return 0;
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06004E84 RID: 20100 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000FE6")]
			public override string Title
			{
				[Token(Token = "0x6004E84")]
				[Address(RVA = "0x9CB5", Offset = "0x9CB5", VA = "0x9CB5", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E85")]
			[Address(RVA = "0x9CB6", Offset = "0x9CB6", VA = "0x9CB6")]
			public ByCost()
			{
			}
		}

		// Token: 0x02000C9A RID: 3226
		[Token(Token = "0x2000C9A")]
		public class ByQuality : AbstractGameDataComparer<AuchanArtifactData>
		{
			// Token: 0x06004E86 RID: 20102 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
			[Token(Token = "0x6004E86")]
			[Address(RVA = "0x9CB7", Offset = "0x9CB7", VA = "0x9CB7", Slot = "8")]
			public override int Compare(AuchanArtifactData x, AuchanArtifactData y)
			{
				return 0;
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x06004E87 RID: 20103 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000FE7")]
			public override string Title
			{
				[Token(Token = "0x6004E87")]
				[Address(RVA = "0x9CB8", Offset = "0x9CB8", VA = "0x9CB8", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004E88 RID: 20104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E88")]
			[Address(RVA = "0x9CB9", Offset = "0x9CB9", VA = "0x9CB9")]
			public ByQuality()
			{
			}
		}

		// Token: 0x02000C9B RID: 3227
		[Token(Token = "0x2000C9B")]
		public class ByDiscount : AbstractGameDataComparer<AuchanArtifactData>
		{
			// Token: 0x06004E89 RID: 20105 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
			[Token(Token = "0x6004E89")]
			[Address(RVA = "0x9CBA", Offset = "0x9CBA", VA = "0x9CBA", Slot = "8")]
			public override int Compare(AuchanArtifactData x, AuchanArtifactData y)
			{
				return 0;
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x06004E8A RID: 20106 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000FE8")]
			public override string Title
			{
				[Token(Token = "0x6004E8A")]
				[Address(RVA = "0x9CBB", Offset = "0x9CBB", VA = "0x9CBB", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004E8B RID: 20107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E8B")]
			[Address(RVA = "0x9CBC", Offset = "0x9CBC", VA = "0x9CBC")]
			public ByDiscount()
			{
			}
		}
	}
}
