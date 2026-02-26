using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Consts;
using Protocol.Services;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200089A")]
	public class DiscountsModel : AbstractModel, IDiscountsProvider
	{
		// Token: 0x060033DC RID: 13276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x8414", Offset = "0x8414", VA = "0x8414")]
		public DiscountsModel(UserData user)
		{
		/* --- GHIDRA: <PopulateDiscounts>b__4_0 ---
		void Gameplay_Discounts_Model_DiscountsModel___PopulateDiscounts_b__4_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57cbf == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		    DAT_ram_00a57cbf = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_Model_DiscountsModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57cba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_Model_DiscountsModel__PopulateDiscounts_b__4_0__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_DiscountData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetDiscountsAns_Types_DiscountInfo__DiscountData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_DiscountData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DiscountData___);
		    Mono_Security_ASN1__get_Item(&System_Func_DiscountData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetDiscountsAns_Types_DiscountInfo__DiscountData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DiscountData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_Model_DiscountsModel___c__PopulateDiscounts_b__4_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_Model_DiscountsModel___c__PopulateDiscounts_b__4_2__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		    DAT_ram_00a57cba = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Func_ProtoGetDiscountsAns_Types_DiscountInfo__DiscountData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Discounts_Model_DiscountsModel__PopulateDiscounts_b__4_0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetDiscountsAns_Types_DiscountInfo__DiscountData___
		                    );
		  if (*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_DiscountData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar4,
		               Method_Gameplay_Discounts_Model_DiscountsModel___c__PopulateDiscounts_b__4_1__,0);
		    *(int *)(*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Where_DiscountData___);
		  if (*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_DiscountData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar3,uVar4,
		               Method_Gameplay_Discounts_Model_DiscountsModel___c__PopulateDiscounts_b__4_2__,0);
		    *(int *)(*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c) + 8) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_OrderBy_DiscountData__uint___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_DiscountData___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x8415", Offset = "0x8415", VA = "0x8415")]
		public void PopulateDiscounts(IList<ProtoGetDiscountsAns.Types.DiscountInfo> discounts)
		{
		/* --- GHIDRA: PopulateDiscounts ---
		void Gameplay_Discounts_Model_DiscountsModel__PopulateDiscounts(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  double dVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57cbb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_DiscountTargets__double__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25330);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21211);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21190);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28182);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28174);
		    DAT_ram_00a57cbb = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar1,StringLiteral_25330,0);
		  System_Collections_Generic_Dictionary_Int32Enum__double___get_Values
		            (uVar3,1,dVar2,
		             Method_System_Collections_Generic_Dictionary_DiscountTargets__double__set_Item__);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar1,StringLiteral_28174,0);
		  System_Collections_Generic_Dictionary_Int32Enum__double___get_Values
		            (uVar3,3,dVar2,
		             Method_System_Collections_Generic_Dictionary_DiscountTargets__double__set_Item__);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar1,StringLiteral_28182,0);
		  System_Collections_Generic_Dictionary_Int32Enum__double___get_Values
		            (uVar3,5,dVar2,
		             Method_System_Collections_Generic_Dictionary_DiscountTargets__double__set_Item__);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar1,StringLiteral_21190,0);
		  System_Collections_Generic_Dictionary_Int32Enum__double___get_Values
		            (uVar3,4,dVar2,
		             Method_System_Collections_Generic_Dictionary_DiscountTargets__double__set_Item__);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  dVar2 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar1,StringLiteral_21211,0);
		  System_Collections_Generic_Dictionary_Int32Enum__double___get_Values
		            (uVar3,6,dVar2,
		             Method_System_Collections_Generic_Dictionary_DiscountTargets__double__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x8416", Offset = "0x8416", VA = "0x8416")]
		public void RepopulateServerParams()
		{
		/* --- GHIDRA: RepopulateServerParams ---
		uint Gameplay_Discounts_Model_DiscountsModel__RepopulateServerParams
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57cbc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_DiscountData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_DiscountData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Discounts_Model_DiscountsModel___c__Gameplay_Discounts_Model_IDiscountsProvider_TryGetDiscount_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		    DAT_ram_00a57cbc = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[3];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_DiscountData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Gameplay_Discounts_Model_DiscountsModel___c__Gameplay_Discounts_Model_IDiscountsProvider_TryGetDiscount_b__6_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Discounts_Model_DiscountsModel___c_TypeInfo + 0x5c) + 0xc) = iVar2;
		  }
		  iVar2 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (param1_00,iVar2,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_DiscountData__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x8417", Offset = "0x8417", VA = "0x8417", Slot = "6")]
		private bool TryGetDiscount(DiscountTargets type, out DiscountData data)
		{
			return default(bool);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x8418", Offset = "0x8418", VA = "0x8418", Slot = "7")]
		private bool TryGetDiscountCoeff(DiscountTargets target, out double discountCoeff)
		{
			return default(bool);
		}

		// Token: 0x04001C41 RID: 7233
		[Token(Token = "0x4001C41")]
		[FieldOffset(Offset = "0xC")]
		public readonly DictManager DictManager;

		// Token: 0x04001C42 RID: 7234
		[Token(Token = "0x4001C42")]
		[FieldOffset(Offset = "0x10")]
		public DiscountData[] Discounts;

		// Token: 0x04001C43 RID: 7235
		[Token(Token = "0x4001C43")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<DiscountTargets, double> _discountsParams;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: Gameplay.Discounts.Model.IDiscountsProvider.TryGetDiscount ---
		undefined4
		Gameplay_Discounts_Model_DiscountsModel__Gameplay_Discounts_Model_IDiscountsProvider_TryGetDiscount
		          (int param1,undefined4 param2,double *param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57cbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_DiscountTargets__double__TryGetValue__)
		    ;
		    DAT_ram_00a57cbd = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__double___TryAdd
		                    (*(undefined4 *)(param1 + 0x14),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_DiscountTargets__double__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    return (uint)(*param3 < 1.0);
		  }
		  *param3 = 1.0;
		  return 0;
		}
		*/


		/* --- GHIDRA: Gameplay.Discounts.Model.IDiscountsProvider.TryGetDiscountCoeff ---
		undefined4
		Gameplay_Discounts_Model_DiscountsModel__Gameplay_Discounts_Model_IDiscountsProvider_TryGetDiscountCoeff
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float param2_00;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57cbe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_DiscountData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57cbe = '\x01';
		  }
		  uVar1 = *(uint *)(param2 + 0x10);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)uVar1,0);
		  param3_00 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                        (*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(Core_Data_DiscountData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_DiscountData_TypeInfo);
		  }
		  uVar2 = Core_Data_DiscountData___ctor(uVar2,param2_00,param3_00,0);
		  return uVar2;
		}
		*/

}
