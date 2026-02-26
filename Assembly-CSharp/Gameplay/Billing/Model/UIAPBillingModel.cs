using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Gameplay.Billing.Model.PurchasePayload;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BEB RID: 3051
	[Token(Token = "0x2000BEB")]
	public class UIAPBillingModel : BillingModelForAppMarketWhitProducts
	{
		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x17000F24")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AE6")]
			[Address(RVA = "0x9943", Offset = "0x9943", VA = "0x9943", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x17000F25")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004AE7")]
			[Address(RVA = "0x9944", Offset = "0x9944", VA = "0x9944", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004AE9 RID: 19177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F26")]
		public DevPayloadPrefs PayloadPrefs
		{
			[Token(Token = "0x6004AE8")]
			[Address(RVA = "0x9945", Offset = "0x9945", VA = "0x9945")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AE9")]
			[Address(RVA = "0x9946", Offset = "0x9946", VA = "0x9946")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x9947", Offset = "0x9947", VA = "0x9947")]
		public UIAPBillingModel(string storeName, IDictProvider dictProvider, IAuthTokenSource authTokenSource, DevPayloadPrefs devPayloadPrefs, IBillingProvider provider, IGame game, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Billing_Model_UIAPBillingModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  double param3_00;
		  double param2_00;
		  undefined4 uVar3;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a60916 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Decimal_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Product__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Product__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_123);
		    DAT_ram_00a60916 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x4c);
		  uVar1 = func_ii_14094(param2,0);
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (uVar3,uVar1,
		                     Method_System_Collections_Generic_Dictionary_string__Product__ContainsKey__);
		  if (iVar2 == 0) {
		    uVar1 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		    Gameplay_Bank_Model_BankOptionData__Create(uVar1,0.0,0.0,StringLiteral_123,0);
		  }
		  else {
		    uVar3 = *(undefined4 *)(param1 + 0x4c);
		    uVar1 = func_ii_14094(param2,0);
		    iVar2 = System_Data_DataRelationCollection__Add
		                      (uVar3,uVar1,
		                       Method_System_Collections_Generic_Dictionary_string__Product__get_Item__);
		    param3_00 = Core_Extensions_Dict_AssistantDictExt__GetDescriptionActive
		                          (*(undefined4 *)(param2 + 0x38),
		                           *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		    local_18 = *(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x20);
		    local_20 = *(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x18);
		    if (*(int *)(System_Decimal_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Decimal_TypeInfo);
		    }
		    local_38 = local_18;
		    local_40 = local_20;
		    param2_00 = System_Decimal__op_Subtraction(&local_40,0);
		    local_48 = *(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x20);
		    local_50 = *(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x18);
		    System_Decimal__op_Addition(&local_30,&local_50,2,0);
		    local_8 = local_28;
		    local_10 = local_30;
		    uVar1 = UnityEngine_Purchasing_ProductCatalog__LoadDefaultCatalog(&local_10,0);
		    uVar3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar1,StringLiteral_118,*(undefined4 *)(*(int *)(iVar2 + 0xc) + 0x14),0);
		    uVar1 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		    Gameplay_Bank_Model_BankOptionData__Create(uVar1,param2_00,param3_00,uVar3,0);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x9948", Offset = "0x9948", VA = "0x9948", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
		/* --- GHIDRA: GetExtPriceData ---
		undefined4
		Gameplay_Billing_Model_UIAPBillingModel__GetExtPriceData
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60917 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Product__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Contains__);
		    DAT_ram_00a60917 = '\x01';
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0x4c),param2,
		                     Method_System_Collections_Generic_Dictionary_string__Product__ContainsKey__);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_4685(*(undefined4 *)(param1 + 0x40),param2,
		                         Method_System_Collections_Generic_List_string__Contains__);
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x9949", Offset = "0x9949", VA = "0x9949", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
		/* --- GHIDRA: IsOptionValid ---
		void Gameplay_Billing_Model_UIAPBillingModel__IsOptionValid
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a60918 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Product__Clear__);
		    DAT_ram_00a60918 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x4c),
		             Method_System_Collections_Generic_Dictionary_string__Product__Clear__);
		  Gameplay_Billing_Model_UIAPBillingModel__SetValidProducts(param1,param2,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x994A", Offset = "0x994A", VA = "0x994A")]
		public void SetValidProducts(IList<Product> products)
		{
		/* --- GHIDRA: SetValidProducts ---
		void Gameplay_Billing_Model_UIAPBillingModel__SetValidProducts
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a60919 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Product__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_Product__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Product__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a60919 = '\x01';
		  }
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_Product__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cfe06e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_Product__TypeInfo,0);
		code_r0x81cfe06e:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x81cfe13c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfe2bb:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfe2c3;
		    }
		code_r0x81cfe13c:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfe2bb;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x81cfe30c;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_Product__TypeInfo == *piVar6) {
		          puVar3 = (undefined4 *)(iVar7 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x81cfe216;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Product__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfe2a7:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfe2c3;
		    }
		code_r0x81cfe216:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfe2a7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,*(undefined4 *)(param1 + 0x4c)
		               ,*(undefined4 *)(*(int *)(iVar7 + 8) + 8),iVar7,
		               Method_System_Collections_Generic_Dictionary_string__Product__set_Item__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfe2c3:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar7 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x81cfe30c:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cfe384;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81cfe384:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x17,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x994B", Offset = "0x994B", VA = "0x994B")]
		public void AddValidProducts(IList<Product> products)
		{
		/* --- GHIDRA: AddValidProducts ---
		undefined4 Gameplay_Billing_Model_UIAPBillingModel__AddValidProducts(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6091a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_DeveloperPayload__get_Count__);
		    DAT_ram_00a6091a = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0xc) + 8) + 0xc);
		}
		*/

		}

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<string, Product> _validExtPriceProducts;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_PayloadPrefs ---
		void Gameplay_Billing_Model_UIAPBillingModel__set_PayloadPrefs
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60915 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Product___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__Product__TypeInfo);
		    DAT_ram_00a60915 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__Product__TypeInfo)
		  ;
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__Product___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts__get_IsPurchasesAvailable
		            (param1,param2,param3,param4,param6,param7,param8,param1);
		  *(undefined4 *)(param1 + 0x50) = param5;
		  return;
		}
		*/

}
