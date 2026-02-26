using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using HuaweiMobileServices.IAP;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE5 RID: 3045
	[Token(Token = "0x2000BE5")]
	public class HmsBillingModel : BillingModelForAppMarketWhitProducts
	{
		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[Token(Token = "0x17000F1C")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AC9")]
			[Address(RVA = "0x9926", Offset = "0x9926", VA = "0x9926", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x17000F1D")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004ACA")]
			[Address(RVA = "0x9927", Offset = "0x9927", VA = "0x9927", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004ACC RID: 19148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F1E")]
		public ProductInfo LastRequestedToPurchaseProduct
		{
			[Token(Token = "0x6004ACB")]
			[Address(RVA = "0x9928", Offset = "0x9928", VA = "0x9928")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ACC")]
			[Address(RVA = "0x9929", Offset = "0x9929", VA = "0x9929")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x992A", Offset = "0x992A", VA = "0x992A")]
		public HmsBillingModel(string storeName, IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Billing_Model_HmsBillingModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  double param3_00;
		  longlong lVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a6090f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ProductInfo__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ProductInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_123);
		    DAT_ram_00a6090f = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x4c);
		  uVar1 = func_ii_14094(param2,0);
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (uVar4,uVar1,
		                     Method_System_Collections_Generic_Dictionary_string__ProductInfo__ContainsKey__
		                    );
		  if (iVar2 != 0) {
		    uVar4 = *(undefined4 *)(param1 + 0x4c);
		    uVar1 = func_ii_14094(param2,0);
		    uVar1 = System_Data_DataRelationCollection__Add
		                      (uVar4,uVar1,
		                       Method_System_Collections_Generic_Dictionary_string__ProductInfo__get_Item__)
		    ;
		    param3_00 = Core_Extensions_Dict_AssistantDictExt__GetDescriptionActive
		                          (*(undefined4 *)(param2 + 0x38),
		                           *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		    lVar3 = HuaweiMobileServices_IAP_ProductInfo__get_Price(uVar1,0);
		    uVar1 = HuaweiMobileServices_IAP_ProductInfo__get_PriceType(uVar1,0);
		    uVar4 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		    Gameplay_Bank_Model_BankOptionData__Create(uVar4,(double)lVar3 / 1000000.0,param3_00,uVar1,0);
		    return uVar4;
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		  Gameplay_Bank_Model_BankOptionData__Create(uVar1,0.0,0.0,StringLiteral_123,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x992B", Offset = "0x992B", VA = "0x992B", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
		/* --- GHIDRA: GetExtPriceData ---
		undefined4
		Gameplay_Billing_Model_HmsBillingModel__GetExtPriceData
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60910 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ProductInfo__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Contains__);
		    DAT_ram_00a60910 = '\x01';
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0x4c),param2,
		                     Method_System_Collections_Generic_Dictionary_string__ProductInfo__ContainsKey__
		                    );
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

		// Token: 0x06004ACF RID: 19151 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x992C", Offset = "0x992C", VA = "0x992C", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
		/* --- GHIDRA: IsOptionValid ---
		void Gameplay_Billing_Model_HmsBillingModel__IsOptionValid
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a60911 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ProductInfo__Clear__);
		    DAT_ram_00a60911 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x4c),
		             Method_System_Collections_Generic_Dictionary_string__ProductInfo__Clear__);
		  Gameplay_Billing_Model_HmsBillingModel__SetValidProducts(param1,param2,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x992D", Offset = "0x992D", VA = "0x992D")]
		public void SetValidProducts(IList<ProductInfo> products)
		{
		/* --- GHIDRA: SetValidProducts ---
		void Gameplay_Billing_Model_HmsBillingModel__SetValidProducts
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param3_00;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 param2_00;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a60912 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ProductInfo__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ProductInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ProductInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a60912 = '\x01';
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ProductInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cfd718;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_ProductInfo__TypeInfo,
		                                0);
		code_r0x81cfd718:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81cfd7e8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfd998:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfd9a0;
		    }
		code_r0x81cfd7e8:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfd998;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x81cfd9e9;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ProductInfo__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81cfd8c2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProductInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfd97a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfd9a0;
		    }
		code_r0x81cfd8c2:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfd97a;
		    param2_00 = *(undefined4 *)(param1 + 0x4c);
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x15,uVar4,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfd9a0;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param2_00,param3_00,uVar4,
		               Method_System_Collections_Generic_Dictionary_string__ProductInfo__set_Item__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfd9a0:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x81cfd9e9:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cfda61;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81cfda61:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x16,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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

		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x992E", Offset = "0x992E", VA = "0x992E")]
		public void AddValidProducts(IList<ProductInfo> products)
		{
		}

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x4C")]
		private readonly Dictionary<string, ProductInfo> _validExtPriceProducts;

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x54")]
		public readonly List<PurchaseDto> PurchasesAwaitRedeliveryProcess;

		// Token: 0x02000BE6 RID: 3046
		[Token(Token = "0x2000BE6")]
		public class RestoredProductDto
		{
			// Token: 0x06004AD2 RID: 19154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AD2")]
			[Address(RVA = "0x992F", Offset = "0x992F", VA = "0x992F")]
			public RestoredProductDto(InAppPurchaseData productData, string sig, string rawJson)
			{
			}

			// Token: 0x040028B7 RID: 10423
			[Token(Token = "0x40028B7")]
			[FieldOffset(Offset = "0x8")]
			public readonly InAppPurchaseData ProductData;

			// Token: 0x040028B8 RID: 10424
			[Token(Token = "0x40028B8")]
			[FieldOffset(Offset = "0xC")]
			public readonly string Sig;

			// Token: 0x040028B9 RID: 10425
			[Token(Token = "0x40028B9")]
			[FieldOffset(Offset = "0x10")]
			public readonly string RawJson;
		}

		// Token: 0x02000BE7 RID: 3047
		[Token(Token = "0x2000BE7")]
		public class ReceiptProcessorVo
		{
			// Token: 0x06004AD3 RID: 19155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AD3")]
			[Address(RVA = "0x9930", Offset = "0x9930", VA = "0x9930")]
			public ReceiptProcessorVo(InAppPurchaseData product, string developerPayload, UniTaskCompletionSource<bool> completionSource)
			{
			}

			// Token: 0x040028BA RID: 10426
			[Token(Token = "0x40028BA")]
			[FieldOffset(Offset = "0x8")]
			public readonly InAppPurchaseData Product;

			// Token: 0x040028BB RID: 10427
			[Token(Token = "0x40028BB")]
			[FieldOffset(Offset = "0xC")]
			public readonly string DeveloperPayload;

			// Token: 0x040028BC RID: 10428
			[Token(Token = "0x40028BC")]
			[FieldOffset(Offset = "0x10")]
			public readonly UniTaskCompletionSource<bool> CompletionSource;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_LastRequestedToPurchaseProduct ---
		void Gameplay_Billing_Model_HmsBillingModel__set_LastRequestedToPurchaseProduct
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6090e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ProductInfo___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__ProductInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PurchaseDto___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PurchaseDto__TypeInfo);
		    DAT_ram_00a6090e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__ProductInfo__TypeInfo)
		  ;
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_string__ProductInfo___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_PurchaseDto__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_PurchaseDto___ctor__);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts__get_IsPurchasesAvailable
		            (param1,param2,param3,param4,param5,param6,param7,param1);
		  return;
		}
		*/

}
