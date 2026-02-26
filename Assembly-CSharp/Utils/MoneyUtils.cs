using System;
using Core.Data.Skills;
using Core.Money;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Utils
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public static class MoneyUtils
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x572D", Offset = "0x572D", VA = "0x572D")]
		public static double CalculateResource(Resources type, double value, bool isSending)
		{
		/* --- GHIDRA: CalculateResource ---
		int Utils_MoneyUtils__CalculateResource(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a62800 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x30) = 0;
		  *(undefined8 *)(iVar1 + 0x28) = 0;
		  *(undefined8 *)(iVar1 + 0x20) = 0;
		  *(undefined8 *)(iVar1 + 0x18) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = 0;
		  return iVar1;
		}
		*/

			return 0.0;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x572E", Offset = "0x572E", VA = "0x572E")]
		public static ResourceSet CreateZero()
		{
		/* --- GHIDRA: CreateZero ---
		int Utils_MoneyUtils__CreateZero(double param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a62800 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(double *)(iVar1 + 0x30) = param1;
		  *(double *)(iVar1 + 0x28) = param1;
		  *(double *)(iVar1 + 0x20) = param1;
		  *(double *)(iVar1 + 0x18) = param1;
		  *(double *)(iVar1 + 0x10) = param1;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x572F", Offset = "0x572F", VA = "0x572F")]
		public static ResourceSet Create(double value)
		{
		/* --- GHIDRA: Create ---
		undefined4 Utils_MoneyUtils__Create(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  double dVar3;
		  double dVar4;
		  longlong lVar5;
		  double dVar6;
		  double dVar7;
		  undefined4 uVar8;
		  ulonglong uVar9;
		  float8 local_8;
		  
		  if (DAT_ram_00a62801 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a62801 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,2,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar5 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar6 = (double)lVar5 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar3 = unnamed_function_4206(dVar6,&local_8);
		  dVar7 = (double)local_8;
		  if (0.0 <= dVar6) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar9 = 0;
		      }
		      if ((uVar9 & 1) != 0) {
		        dVar7 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar7 = FLOOR(dVar6 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar9 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar9 = 0;
		    }
		    if ((uVar9 & 1) != 0) {
		      dVar7 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar7 = CEIL(dVar6 + -0.5);
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,1,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar5 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar6 = (double)lVar5 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar4 = unnamed_function_4206(dVar6,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar6) {
		    if (dVar4 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar9 = 0;
		      }
		      if ((uVar9 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar6 + 0.5);
		    }
		  }
		  else if (dVar4 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar9 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar9 = 0;
		    }
		    if ((uVar9 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar6 + -0.5);
		  }
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar6 = 0.0;
		  if ((ulonglong)ABS(dVar7) < 0x7ff0000000000001) {
		    dVar6 = dVar7;
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8),
		                dVar6,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar6 = 0.0;
		  if ((ulonglong)ABS(dVar3) < 0x7ff0000000000001) {
		    dVar6 = dVar3;
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 4),
		                dVar6,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,4,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  func_ii_13907(uVar2,uVar8,(double)*(longlong *)(iVar1 + 0x10),
		                Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x10);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,6,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  func_ii_13907(uVar2,uVar8,(double)*(longlong *)(iVar1 + 0x10),
		                Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x14);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,9,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  func_ii_13907(uVar2,uVar8,(double)*(longlong *)(iVar1 + 0x10),
		                Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__FromResourceSet(uVar2,0);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: Create ---
		undefined4 Utils_MoneyUtils__Create(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  double dVar3;
		  double dVar4;
		  longlong lVar5;
		  double dVar6;
		  double dVar7;
		  undefined4 uVar8;
		  ulonglong uVar9;
		  float8 local_8;
		  
		  if (DAT_ram_00a62801 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a62801 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,2,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar5 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar6 = (double)lVar5 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar3 = unnamed_function_4206(dVar6,&local_8);
		  dVar7 = (double)local_8;
		  if (0.0 <= dVar6) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar9 = 0;
		      }
		      if ((uVar9 & 1) != 0) {
		        dVar7 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar7 = FLOOR(dVar6 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar9 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar9 = 0;
		    }
		    if ((uVar9 & 1) != 0) {
		      dVar7 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar7 = CEIL(dVar6 + -0.5);
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,1,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar5 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar6 = (double)lVar5 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar4 = unnamed_function_4206(dVar6,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar6) {
		    if (dVar4 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar9 = 0;
		      }
		      if ((uVar9 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar6 + 0.5);
		    }
		  }
		  else if (dVar4 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar9 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar9 = 0;
		    }
		    if ((uVar9 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar6 + -0.5);
		  }
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar6 = 0.0;
		  if ((ulonglong)ABS(dVar7) < 0x7ff0000000000001) {
		    dVar6 = dVar7;
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8),
		                dVar6,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar6 = 0.0;
		  if ((ulonglong)ABS(dVar3) < 0x7ff0000000000001) {
		    dVar6 = dVar3;
		  }
		  func_ii_13907(uVar2,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 4),
		                dVar6,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,4,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  func_ii_13907(uVar2,uVar8,(double)*(longlong *)(iVar1 + 0x10),
		                Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x10);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,6,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  func_ii_13907(uVar2,uVar8,(double)*(longlong *)(iVar1 + 0x10),
		                Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  uVar8 = *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x14);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,9,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  func_ii_13907(uVar2,uVar8,(double)*(longlong *)(iVar1 + 0x10),
		                Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__FromResourceSet(uVar2,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5730", Offset = "0x5730", VA = "0x5730")]
		public static ResourceSet Create(double mr = 0.0, double mg = 0.0, double e = 0.0, double nr = double.NaN, double cf = double.NaN)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5731", Offset = "0x5731", VA = "0x5731")]
		public static Money ExtractSpellCostMoney(Skills value)
		{
		/* --- GHIDRA: ExtractSpellCostMoney ---
		int Utils_MoneyUtils__ExtractSpellCostMoney(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  double dVar2;
		  double dVar3;
		  longlong lVar4;
		  double dVar5;
		  double dVar6;
		  longlong lVar7;
		  longlong lVar8;
		  ulonglong uVar9;
		  float8 local_8;
		  
		  if (DAT_ram_00a62802 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a62802 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,2,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar4 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar5 = (double)lVar4 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar2 = unnamed_function_4206(dVar5,&local_8);
		  dVar6 = (double)local_8;
		  if (0.0 <= dVar5) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar9 = 0;
		      }
		      if ((uVar9 & 1) != 0) {
		        dVar6 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar6 = FLOOR(dVar5 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar9 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar9 = 0;
		    }
		    if ((uVar9 & 1) != 0) {
		      dVar6 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar6 = CEIL(dVar5 + -0.5);
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,1,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar4 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar5 = (double)lVar4 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar3 = unnamed_function_4206(dVar5,&local_8);
		  dVar2 = (double)local_8;
		  if (0.0 <= dVar5) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar9 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar9 = 0;
		      }
		      if ((uVar9 & 1) != 0) {
		        dVar2 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar2 = FLOOR(dVar5 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar9 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar9 = 0;
		    }
		    if ((uVar9 & 1) != 0) {
		      dVar2 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar2 = CEIL(dVar5 + -0.5);
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,4,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar4 = *(longlong *)(iVar1 + 0x10);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,6,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar7 = *(longlong *)(iVar1 + 0x10);
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (param1,9,Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  lVar8 = *(longlong *)(iVar1 + 0x10);
		  if (DAT_ram_00a62800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a62800 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(double *)(iVar1 + 0x30) = (double)lVar8;
		  *(double *)(iVar1 + 0x28) = (double)lVar7;
		  *(double *)(iVar1 + 0x20) = (double)lVar4;
		  *(double *)(iVar1 + 0x18) = dVar6;
		  *(double *)(iVar1 + 0x10) = dVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5732", Offset = "0x5732", VA = "0x5732")]
		public static ResourceSet ExtractSpellCost(Skills value)
		{
		/* --- GHIDRA: ExtractSpellCost ---
		undefined4 Utils_MoneyUtils__ExtractSpellCost(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  double dVar2;
		  double dVar3;
		  double dVar4;
		  double dVar5;
		  double dVar6;
		  double param3;
		  
		  if (DAT_ram_00a62803 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a62803 = '\x01';
		  }
		  dVar2 = func_ii_7527(param1,4,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__)
		  ;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar3 = func_ii_7527(param1,3,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__)
		  ;
		  dVar4 = func_ii_7527(param1,8,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__)
		  ;
		  dVar5 = func_ii_7527(param1,10,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__
		                      );
		  dVar6 = func_ii_7527(param1,0xb,
		                       Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Money_MoneyType__double__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double___ctor__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  param3 = 0.0;
		  if ((ulonglong)ABS(FLOOR(dVar2 * 0.01)) < 0x7ff0000000000001) {
		    param3 = FLOOR(dVar2 * 0.01);
		  }
		  func_ii_13907(uVar1,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8),
		                param3,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar2 = 0.0;
		  if ((ulonglong)ABS(FLOOR(dVar3 * 0.01)) < 0x7ff0000000000001) {
		    dVar2 = FLOOR(dVar3 * 0.01);
		  }
		  func_ii_13907(uVar1,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 4),
		                dVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar2 = 0.0;
		  if ((ulonglong)ABS(dVar4) < 0x7ff0000000000001) {
		    dVar2 = dVar4;
		  }
		  func_ii_13907(uVar1,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc),
		                dVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar2 = 0.0;
		  if ((ulonglong)ABS(dVar5) < 0x7ff0000000000001) {
		    dVar2 = dVar5;
		  }
		  func_ii_13907(uVar1,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x10),
		                dVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  dVar2 = 0.0;
		  if ((ulonglong)ABS(dVar6) < 0x7ff0000000000001) {
		    dVar2 = dVar6;
		  }
		  func_ii_13907(uVar1,*(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x14),
		                dVar2,Method_System_Collections_Generic_Dictionary_Money_MoneyType__double__Add__);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__FromResourceSet(uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5733", Offset = "0x5733", VA = "0x5733")]
		public static Money ExtractArtifactCostMoney(RepeatedField<double> skills)
		{
		/* --- GHIDRA: ExtractArtifactCostMoney ---
		int Utils_MoneyUtils__ExtractArtifactCostMoney(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  double dVar2;
		  double dVar3;
		  ulonglong uVar4;
		  
		  if (DAT_ram_00a62804 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		    DAT_ram_00a62804 = '\x01';
		  }
		  if (DAT_ram_00a62800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a62800 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x20) = 0;
		  *(undefined8 *)(iVar1 + 0x18) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = 0;
		  *(undefined8 *)(iVar1 + 0x30) = 0x7ff8000000000000;
		  *(undefined8 *)(iVar1 + 0x28) = 0x7ff8000000000000;
		  dVar2 = func_ii_7527(param1,4,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__)
		  ;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  *(double *)(iVar1 + 0x18) = FLOOR(dVar2 * 0.01);
		  dVar2 = func_ii_7527(param1,3,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__)
		  ;
		  *(double *)(iVar1 + 0x10) = FLOOR(dVar2 * 0.01);
		  dVar2 = func_ii_7527(param1,8,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__)
		  ;
		  *(double *)(iVar1 + 0x20) = dVar2;
		  dVar2 = func_ii_7527(param1,10,Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__
		                      );
		  *(double *)(iVar1 + 0x28) = dVar2;
		  dVar3 = func_ii_7527(param1,0xb,
		                       Method_Google_Protobuf_Collections_RepeatedField_double__get_Item__);
		  dVar2 = 0.0;
		  if ((ulonglong)ABS(dVar3) < 0x7ff0000000000001) {
		    dVar2 = dVar3;
		  }
		  *(double *)(iVar1 + 0x30) = dVar2;
		  uVar4 = 0;
		  if ((*(ulonglong *)(iVar1 + 0x18) & 0x7fffffffffffffff) < 0x7ff0000000000001) {
		    uVar4 = *(ulonglong *)(iVar1 + 0x18);
		  }
		  *(ulonglong *)(iVar1 + 0x18) = uVar4;
		  uVar4 = 0;
		  if ((*(ulonglong *)(iVar1 + 0x10) & 0x7fffffffffffffff) < 0x7ff0000000000001) {
		    uVar4 = *(ulonglong *)(iVar1 + 0x10);
		  }
		  *(ulonglong *)(iVar1 + 0x10) = uVar4;
		  uVar4 = 0;
		  if ((*(ulonglong *)(iVar1 + 0x20) & 0x7fffffffffffffff) < 0x7ff0000000000001) {
		    uVar4 = *(ulonglong *)(iVar1 + 0x20);
		  }
		  *(ulonglong *)(iVar1 + 0x20) = uVar4;
		  uVar4 = 0;
		  if ((*(ulonglong *)(iVar1 + 0x28) & 0x7fffffffffffffff) < 0x7ff0000000000001) {
		    uVar4 = *(ulonglong *)(iVar1 + 0x28);
		  }
		  *(ulonglong *)(iVar1 + 0x28) = uVar4;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5734", Offset = "0x5734", VA = "0x5734")]
		public static ResourceSet ExtractArtifactCost(RepeatedField<double> skills)
		{
		/* --- GHIDRA: ExtractArtifactCost ---
		int Utils_MoneyUtils__ExtractArtifactCost(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  double dVar2;
		  double dVar3;
		  double dVar4;
		  ulonglong uVar5;
		  float8 local_8;
		  
		  if (DAT_ram_00a62800 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a62800 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x20) = 0;
		  *(undefined8 *)(iVar1 + 0x18) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = 0;
		  *(undefined8 *)(iVar1 + 0x30) = 0x7ff8000000000000;
		  *(undefined8 *)(iVar1 + 0x28) = 0x7ff8000000000000;
		  dVar4 = *(double *)(param1 + 0x10);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar4 = dVar4 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar2 = unnamed_function_4206(dVar4,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar4) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar4 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar4 + -0.5);
		  }
		  *(double *)(iVar1 + 0x10) = dVar3;
		  dVar4 = *(double *)(param1 + 0x18);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  dVar4 = dVar4 / 100.0;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar2 = unnamed_function_4206(dVar4,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar4) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar4 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar4 + -0.5);
		  }
		  *(double *)(iVar1 + 0x18) = dVar3;
		  dVar4 = *(double *)(param1 + 0x20);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar2 = unnamed_function_4206(dVar4,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar4) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar4 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar4 + -0.5);
		  }
		  *(double *)(iVar1 + 0x20) = dVar3;
		  dVar4 = *(double *)(param1 + 0x28);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar2 = unnamed_function_4206(dVar4,&local_8);
		  dVar3 = (double)local_8;
		  if (0.0 <= dVar4) {
		    if (dVar2 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        dVar3 = (double)local_8 + 1.0;
		      }
		    }
		    else {
		      dVar3 = FLOOR(dVar4 + 0.5);
		    }
		  }
		  else if (dVar2 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      dVar3 = (double)local_8 + -1.0;
		    }
		  }
		  else {
		    dVar3 = CEIL(dVar4 + -0.5);
		  }
		  *(double *)(iVar1 + 0x28) = dVar3;
		  dVar4 = *(double *)(param1 + 0x30);
		  if (DAT_ram_00a627ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a627ff = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar3 = unnamed_function_4206(dVar4,&local_8);
		  if (0.0 <= dVar4) {
		    if (dVar3 == 0.5) {
		      if (ABS((double)local_8) < 9.223372036854776e+18) {
		        uVar5 = (ulonglong)(double)local_8;
		      }
		      else {
		        uVar5 = 0;
		      }
		      if ((uVar5 & 1) != 0) {
		        local_8 = (float8)((double)local_8 + 1.0);
		      }
		    }
		    else {
		      local_8 = (float8)FLOOR(dVar4 + 0.5);
		    }
		  }
		  else if (dVar3 == -0.5) {
		    if (ABS((double)local_8) < 9.223372036854776e+18) {
		      uVar5 = (ulonglong)(double)local_8;
		    }
		    else {
		      uVar5 = 0;
		    }
		    if ((uVar5 & 1) != 0) {
		      local_8 = (float8)((double)local_8 + -1.0);
		    }
		  }
		  else {
		    local_8 = (float8)CEIL(dVar4 + -0.5);
		  }
		  *(float8 *)(iVar1 + 0x30) = local_8;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x5735", Offset = "0x5735", VA = "0x5735")]
		public static ResourceSet ExtractResourceSetFromArray(double[] arr)
		{
		/* --- GHIDRA: ExtractResourceSetFromArray ---
		int Utils_MoneyUtils__ExtractResourceSetFromArray(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  double dVar4;
		  undefined4 *puVar5;
		  
		  if (DAT_ram_00a62805 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11342);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1739);
		    DAT_ram_00a62805 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  param1_00 = System_Data_DataSet__ReadXmlSchema(param1,1,*(int *)(param1 + 8) + -1,0);
		  iVar2 = System_Net_WebConnection__ReadLine(param1_00,0x2c,0,0);
		  puVar5 = (undefined4 *)(iVar2 + 0x10);
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(*puVar5,0);
		  if (iVar3 == 0) {
		    puVar5 = &StringLiteral_1739;
		  }
		  dVar4 = System_Runtime_Remoting_ConfigHandler__ParseElement(*puVar5,0);
		  *(double *)(iVar1 + 0x10) = dVar4;
		  puVar5 = (undefined4 *)(iVar2 + 0x14);
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(*puVar5,0);
		  if (iVar3 == 0) {
		    puVar5 = &StringLiteral_1739;
		  }
		  dVar4 = System_Runtime_Remoting_ConfigHandler__ParseElement(*puVar5,0);
		  *(double *)(iVar1 + 0x18) = dVar4;
		  puVar5 = (undefined4 *)(iVar2 + 0x18);
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(*puVar5,0);
		  if (iVar3 == 0) {
		    puVar5 = &StringLiteral_1739;
		  }
		  dVar4 = System_Runtime_Remoting_ConfigHandler__ParseElement(*puVar5,0);
		  *(double *)(iVar1 + 0x20) = dVar4;
		  puVar5 = (undefined4 *)(iVar2 + 0x1c);
		  iVar3 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(*puVar5,0);
		  if (iVar3 == 0) {
		    puVar5 = &StringLiteral_11342;
		  }
		  dVar4 = System_Runtime_Remoting_ConfigHandler__ParseElement(*puVar5,0);
		  *(double *)(iVar1 + 0x28) = dVar4;
		  puVar5 = (undefined4 *)(iVar2 + 0x20);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(*puVar5,0);
		  if (iVar2 == 0) {
		    puVar5 = &StringLiteral_11342;
		  }
		  dVar4 = System_Runtime_Remoting_ConfigHandler__ParseElement(*puVar5,0);
		  *(double *)(iVar1 + 0x30) = dVar4;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x5736", Offset = "0x5736", VA = "0x5736")]
		public static ResourceSet StringToResourcesSet(string raw)
		{
		/* --- GHIDRA: StringToResourcesSet ---
		void Utils_MoneyUtils__StringToResourcesSet(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62808 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    DAT_ram_00a62808 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_PointerEventData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PointerEventData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}
	}
}
