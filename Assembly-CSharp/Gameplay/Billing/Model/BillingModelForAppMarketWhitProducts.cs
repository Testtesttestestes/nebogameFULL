using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE3 RID: 3043
	[Token(Token = "0x2000BE3")]
	public class BillingModelForAppMarketWhitProducts : AbstractBillingModel
	{
		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x17000F1A")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0x991F", Offset = "0x991F", VA = "0x991F", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[Token(Token = "0x17000F1B")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AC3")]
			[Address(RVA = "0x9920", Offset = "0x9920", VA = "0x9920", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x9921", Offset = "0x9921", VA = "0x9921")]
		public BillingModelForAppMarketWhitProducts(string storeName, IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Type propagation algorithm not settling */
		
		void Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts___ctor
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int local_30;
		  int **local_2c;
		  int *local_28;
		  int *local_24;
		  int *local_20;
		  int *local_1c;
		  int *local_18;
		  int *local_14;
		  int *local_10;
		  int *local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6090c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_AccountOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ColossusFragmentsOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_NewResourceOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_RegularOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_CrystalEnergyOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MarketOptionsDic__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ArtikulOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_EndlessPaymentOptionListOptionDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_DiamondOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_EndlessPaymentOptionListOptionDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_NewResourceOptionsDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_CrystalEnergyOptionsDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_DiamondOptionsDic__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulOptionsDic__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MarketOptionsDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ColossusFragmentsOptionsDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegularOptionsDic__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CurrencyExtMoney__get_Count__);
		    DAT_ram_00a6090c = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_10 = (int *)0x0;
		  local_14 = (int *)0x0;
		  local_18 = (int *)0x0;
		  local_1c = (int *)0x0;
		  local_20 = (int *)0x0;
		  local_24 = (int *)0x0;
		  local_28 = (int *)0x0;
		  piVar7 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x81cfa377;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfa377:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar8 + 0xa4),
		                              Method_Google_Protobuf_Collections_RepeatedField_DiamondOptionsDic__GetEnumerator__
		                             );
		  local_30 = 0;
		  local_2c = &local_4;
		code_r0x81cfa3b8:
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81cfa460;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfa4a8:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfa711;
		    }
		code_r0x81cfa460:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfa4a8;
		    if (iVar8 == 0) {
		      iVar8 = 5;
		      goto code_r0x81cfa75e;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerator_DiamondOptionsDic__TypeInfo == *piVar9) {
		          puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81cfa553;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_DiamondOptionsDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfa631:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfa711;
		    }
		code_r0x81cfa553:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfa631;
		    local_8 = *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_8,0);
		    iVar1 = DAT_ram_009d3e38;
		    iVar6 = Method_System_Collections_Generic_List_string__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cfa711;
		    }
		    if (*(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0x24) + 0xc) != 0) {
		      iVar8 = *(int *)(param1 + 0x3c);
		      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		      uVar2 = *(uint *)(iVar8 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		        *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		        iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd2b2:
		        *(undefined4 *)(iVar8 + 0x10) = uVar4;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cfa711;
		        }
		      }
		      goto code_r0x81cfa3b8;
		    }
		    iVar8 = *(int *)(param1 + 0x40);
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar8 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		      iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		      goto code_r0x81cfd2b2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfa711:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_30 = *piVar7;
		    iVar8 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x81cfa75e:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_2c;
		      if (piVar7 != (int *)0x0) {
		        uVar2 = 0;
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cfa7d9;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfa7d9:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (local_30 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_30);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar8 != 0) {
		        if (iVar8 == 1) {
		          return;
		        }
		        if (iVar8 == 2) {
		          return;
		        }
		        if (iVar8 == 3) {
		          return;
		        }
		        if (iVar8 == 4) {
		          return;
		        }
		        if (iVar8 != 5) {
		          return;
		        }
		      }
		      uVar2 = 0;
		      piVar7 = *(int **)(param1 + 0x10);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x178);
		            goto code_r0x81cfa873;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfa873:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		      local_c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(iVar8 + 0x20c),
		                                  Method_Google_Protobuf_Collections_RepeatedField_ColossusFragmentsOptionsDic__GetEnumerator__
		                                 );
		      local_30 = 0;
		      local_2c = &local_c;
		code_r0x81cfa8b4:
		      do {
		        piVar7 = local_c;
		        iVar8 = *local_c;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x81cfa958;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfa9a0:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cfac09;
		        }
		code_r0x81cfa958:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		        piVar7 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81cfa9a0;
		        if (iVar8 == 0) {
		          iVar8 = 9;
		          goto code_r0x81cfac56;
		        }
		        iVar8 = *local_c;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_ColossusFragmentsOptionsDic__TypeInfo ==
		                *piVar9) {
		              puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x81cfaa4b;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar5 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_ColossusFragmentsOptionsDic__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfab29:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cfac09;
		        }
		code_r0x81cfaa4b:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81cfab29;
		        local_8 = *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0xc);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_8,0);
		        iVar1 = DAT_ram_009d3e38;
		        iVar6 = Method_System_Collections_Generic_List_string__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81cfac09;
		        }
		        if (*(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0x24) + 0xc) != 0) {
		          iVar8 = *(int *)(param1 + 0x3c);
		          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		          uVar2 = *(uint *)(iVar8 + 0xc);
		          if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		            *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		            iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd24a:
		            *(undefined4 *)(iVar8 + 0x10) = uVar4;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cfac09;
		            }
		          }
		          goto code_r0x81cfa8b4;
		        }
		        iVar8 = *(int *)(param1 + 0x40);
		        *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar8 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		          *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		          iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		          goto code_r0x81cfd24a;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfac09:
		      iVar8 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_30 = *piVar7;
		        iVar8 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		code_r0x81cfac56:
		          DAT_ram_009d3e38 = 0;
		          piVar7 = *local_2c;
		          if (piVar7 != (int *)0x0) {
		            uVar2 = 0;
		            iVar6 = *piVar7;
		            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                  puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x81cfacd1;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		            }
		            puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfacd1:
		            (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		          }
		          if (local_30 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_30);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar8 != 0) {
		            if (iVar8 == 1) {
		              return;
		            }
		            if (iVar8 == 2) {
		              return;
		            }
		            if (iVar8 == 3) {
		              return;
		            }
		            if (iVar8 == 4) {
		              return;
		            }
		            if (iVar8 == 5) {
		              return;
		            }
		            if (iVar8 == 6) {
		              return;
		            }
		            if (iVar8 == 7) {
		              return;
		            }
		            if (iVar8 == 8) {
		              return;
		            }
		            if (iVar8 != 9) {
		              return;
		            }
		          }
		          uVar2 = 0;
		          piVar7 = *(int **)(param1 + 0x10);
		          iVar8 = *piVar7;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 +
		                                 0x178);
		                goto code_r0x81cfad6d;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfad6d:
		          uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		          iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		          local_10 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                      (*(undefined4 *)(iVar8 + 0x68),
		                                       Method_Google_Protobuf_Collections_RepeatedField_CrystalEnergyOptionsDic__GetEnumerator__
		                                      );
		          local_30 = 0;
		          local_2c = &local_10;
		code_r0x81cfadad:
		          do {
		            piVar7 = local_10;
		            iVar8 = *local_10;
		            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                  puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                  goto code_r0x81cfae51;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfae99:
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cfb102;
		            }
		code_r0x81cfae51:
		            DAT_ram_009d3e38 = 0;
		            iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		            piVar7 = local_10;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81cfae99;
		            if (iVar8 == 0) {
		              iVar8 = 0xd;
		              goto code_r0x81cfb14f;
		            }
		            iVar8 = *local_10;
		            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                if (System_Collections_Generic_IEnumerator_CrystalEnergyOptionsDic__TypeInfo ==
		                    *piVar9) {
		                  puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                  goto code_r0x81cfaf44;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10,
		                                System_Collections_Generic_IEnumerator_CrystalEnergyOptionsDic__TypeInfo
		                                ,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfb022:
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cfb102;
		            }
		code_r0x81cfaf44:
		            DAT_ram_009d3e38 = 0;
		            iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x81cfb022;
		            local_8 = *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0xc);
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_8,0);
		            iVar1 = DAT_ram_009d3e38;
		            iVar6 = Method_System_Collections_Generic_List_string__Add__;
		            DAT_ram_009d3e38 = 0;
		            if (iVar1 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x81cfb102;
		            }
		            if (*(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0x24) + 0xc) != 0) {
		              iVar8 = *(int *)(param1 + 0x3c);
		              *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		              uVar2 = *(uint *)(iVar8 + 0xc);
		              if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd1f9:
		                *(undefined4 *)(iVar8 + 0x10) = uVar4;
		              }
		              else {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar8 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81cfb102;
		                }
		              }
		              goto code_r0x81cfadad;
		            }
		            iVar8 = *(int *)(param1 + 0x40);
		            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		            uVar2 = *(uint *)(iVar8 + 0xc);
		            if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		              *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		              iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		              goto code_r0x81cfd1f9;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		          } while (iVar8 != 1);
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfb102:
		          iVar8 = global_1;
		          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar8 == iVar6) {
		            piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		            local_30 = *piVar7;
		            iVar8 = 0;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_v(0x123);
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 != 1) {
		code_r0x81cfb14f:
		              DAT_ram_009d3e38 = 0;
		              piVar7 = *local_2c;
		              if (piVar7 != (int *)0x0) {
		                uVar2 = 0;
		                iVar6 = *piVar7;
		                if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                  do {
		                    if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8))
		                    {
		                      puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8
		                                       + 0xc0);
		                      goto code_r0x81cfb1ca;
		                    }
		                    uVar2 = uVar2 + 1;
		                  } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                }
		                puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfb1ca:
		                (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		              }
		              if (local_30 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              if (iVar8 != 0) {
		                if (iVar8 == 1) {
		                  return;
		                }
		                if (iVar8 == 2) {
		                  return;
		                }
		                if (iVar8 == 3) {
		                  return;
		                }
		                if (iVar8 == 4) {
		                  return;
		                }
		                if (iVar8 == 5) {
		                  return;
		                }
		                if (iVar8 == 6) {
		                  return;
		                }
		                if (iVar8 == 7) {
		                  return;
		                }
		                if (iVar8 == 8) {
		                  return;
		                }
		                if (iVar8 == 9) {
		                  return;
		                }
		                if (iVar8 == 10) {
		                  return;
		                }
		                if (iVar8 == 0xb) {
		                  return;
		                }
		                if (iVar8 == 0xc) {
		                  return;
		                }
		                if (iVar8 != 0xd) {
		                  return;
		                }
		              }
		              uVar2 = 0;
		              piVar7 = *(int **)(param1 + 0x10);
		              iVar8 = *piVar7;
		              if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                do {
		                  if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8))
		                  {
		                    puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 +
		                                     0x178);
		                    goto code_r0x81cfb26a;
		                  }
		                  uVar2 = uVar2 + 1;
		                } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		              }
		              puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfb26a:
		              uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		              iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		              local_14 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                          (*(undefined4 *)(iVar8 + 0x1a4),
		                                           Method_Google_Protobuf_Collections_RepeatedField_NewResourceOptionsDic__GetEnumerator__
		                                          );
		              local_30 = 0;
		              local_2c = &local_14;
		code_r0x81cfb2ab:
		              do {
		                piVar7 = local_14;
		                iVar8 = *local_14;
		                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                  uVar2 = 0;
		                  do {
		                    piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                    if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                      puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                      goto code_r0x81cfb34f;
		                    }
		                    uVar2 = uVar2 + 1;
		                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar5 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                    System_Collections_IEnumerator_TypeInfo,0);
		                if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfb397:
		                  DAT_ram_009d3e38 = 0;
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81cfb600;
		                }
		code_r0x81cfb34f:
		                DAT_ram_009d3e38 = 0;
		                iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                piVar7 = local_14;
		                if (DAT_ram_009d3e38 == 1) goto code_r0x81cfb397;
		                if (iVar8 == 0) {
		                  iVar8 = 0x11;
		                  goto code_r0x81cfb64d;
		                }
		                iVar8 = *local_14;
		                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                  uVar2 = 0;
		                  do {
		                    piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                    if (System_Collections_Generic_IEnumerator_NewResourceOptionsDic__TypeInfo ==
		                        *piVar9) {
		                      puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                      goto code_r0x81cfb442;
		                    }
		                    uVar2 = uVar2 + 1;
		                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar5 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                                    System_Collections_Generic_IEnumerator_NewResourceOptionsDic__TypeInfo
		                                    ,0);
		                if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfb520:
		                  DAT_ram_009d3e38 = 0;
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81cfb600;
		                }
		code_r0x81cfb442:
		                DAT_ram_009d3e38 = 0;
		                iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x81cfb520;
		                local_8 = *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0xc);
		                DAT_ram_009d3e38 = 0;
		                uVar4 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,&local_8,
		                                   0);
		                iVar1 = DAT_ram_009d3e38;
		                iVar6 = Method_System_Collections_Generic_List_string__Add__;
		                DAT_ram_009d3e38 = 0;
		                if (iVar1 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81cfb600;
		                }
		                if (*(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0x24) + 0xc) != 0) {
		                  iVar8 = *(int *)(param1 + 0x3c);
		                  *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                  uVar2 = *(uint *)(iVar8 + 0xc);
		                  if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                    *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                    iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd1a8:
		                    *(undefined4 *)(iVar8 + 0x10) = uVar4;
		                  }
		                  else {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                    iVar8 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar8 == 1) {
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x81cfb600;
		                    }
		                  }
		                  goto code_r0x81cfb2ab;
		                }
		                iVar8 = *(int *)(param1 + 0x40);
		                *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                uVar2 = *(uint *)(iVar8 + 0xc);
		                if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                  *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                  iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		                  goto code_r0x81cfd1a8;
		                }
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                iVar8 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		              } while (iVar8 != 1);
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfb600:
		              iVar8 = global_1;
		              iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar8 == iVar6) {
		                piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		                local_30 = *piVar7;
		                iVar8 = 0;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_v(0x123);
		                iVar6 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar6 != 1) {
		code_r0x81cfb64d:
		                  DAT_ram_009d3e38 = 0;
		                  piVar7 = *local_2c;
		                  if (piVar7 != (int *)0x0) {
		                    uVar2 = 0;
		                    iVar6 = *piVar7;
		                    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                      do {
		                        if (System_IDisposable_TypeInfo ==
		                            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4)
		                                                    * 8 + 0xc0);
		                          goto code_r0x81cfb6c8;
		                        }
		                        uVar2 = uVar2 + 1;
		                      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                    }
		                    puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfb6c8:
		                    (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                  }
		                  if (local_30 != 0) {
		                    System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                    do {
		                      halt_trap();
		                    } while( true );
		                  }
		                  if (iVar8 != 0) {
		                    if (iVar8 == 1) {
		                      return;
		                    }
		                    if (iVar8 == 2) {
		                      return;
		                    }
		                    if (iVar8 == 3) {
		                      return;
		                    }
		                    if (iVar8 == 4) {
		                      return;
		                    }
		                    if (iVar8 == 5) {
		                      return;
		                    }
		                    if (iVar8 == 6) {
		                      return;
		                    }
		                    if (iVar8 == 7) {
		                      return;
		                    }
		                    if (iVar8 == 8) {
		                      return;
		                    }
		                    if (iVar8 == 9) {
		                      return;
		                    }
		                    if (iVar8 == 10) {
		                      return;
		                    }
		                    if (iVar8 == 0xb) {
		                      return;
		                    }
		                    if (iVar8 == 0xc) {
		                      return;
		                    }
		                    if (iVar8 == 0xd) {
		                      return;
		                    }
		                    if (iVar8 == 0xe) {
		                      return;
		                    }
		                    if (iVar8 == 0xf) {
		                      return;
		                    }
		                    if (iVar8 == 0x10) {
		                      return;
		                    }
		                    if (iVar8 != 0x11) {
		                      return;
		                    }
		                  }
		                  uVar2 = 0;
		                  piVar7 = *(int **)(param1 + 0x10);
		                  iVar8 = *piVar7;
		                  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                    do {
		                      if (Core_Gameplay_IGame_TypeInfo ==
		                          *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                          iVar8 + 0x178);
		                        goto code_r0x81cfb76c;
		                      }
		                      uVar2 = uVar2 + 1;
		                    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                  }
		                  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfb76c:
		                  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                  iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		                  local_18 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                              (*(undefined4 *)(iVar8 + 0x164),
		                                               Method_Google_Protobuf_Collections_RepeatedField_ArtikulOptionsDic__GetEnumerator__
		                                              );
		                  local_30 = 0;
		                  local_2c = &local_18;
		code_r0x81cfb7ad:
		                  do {
		                    piVar7 = local_18;
		                    iVar8 = *local_18;
		                    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                      uVar2 = 0;
		                      do {
		                        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                          puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                          goto code_r0x81cfb851;
		                        }
		                        uVar2 = uVar2 + 1;
		                      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    puVar5 = (undefined4 *)
		                             import::env::invoke_iiii
		                                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                        local_18,System_Collections_IEnumerator_TypeInfo,0);
		                    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfb899:
		                      DAT_ram_009d3e38 = 0;
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x81cfbafc;
		                    }
		code_r0x81cfb851:
		                    DAT_ram_009d3e38 = 0;
		                    iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                    piVar7 = local_18;
		                    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfb899;
		                    if (iVar8 == 0) {
		                      iVar8 = 0x15;
		                      goto code_r0x81cfbb49;
		                    }
		                    iVar8 = *local_18;
		                    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                      uVar2 = 0;
		                      do {
		                        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                        if (System_Collections_Generic_IEnumerator_ArtikulOptionsDic__TypeInfo ==
		                            *piVar9) {
		                          puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                          goto code_r0x81cfb944;
		                        }
		                        uVar2 = uVar2 + 1;
		                      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    puVar5 = (undefined4 *)
		                             import::env::invoke_iiii
		                                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                        local_18,
		                                        System_Collections_Generic_IEnumerator_ArtikulOptionsDic__TypeInfo
		                                        ,0);
		                    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfba1c:
		                      DAT_ram_009d3e38 = 0;
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x81cfbafc;
		                    }
		code_r0x81cfb944:
		                    DAT_ram_009d3e38 = 0;
		                    iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfba1c;
		                    local_8 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0xc);
		                    DAT_ram_009d3e38 = 0;
		                    uVar4 = import::env::invoke_iii
		                                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,
		                                       &local_8,0);
		                    iVar1 = DAT_ram_009d3e38;
		                    iVar6 = Method_System_Collections_Generic_List_string__Add__;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar1 == 1) {
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x81cfbafc;
		                    }
		                    if (*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0x24) + 0xc) != 0) {
		                      iVar8 = *(int *)(param1 + 0x3c);
		                      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                      uVar2 = *(uint *)(iVar8 + 0xc);
		                      if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                        *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                        iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd157:
		                        *(undefined4 *)(iVar8 + 0x10) = uVar4;
		                      }
		                      else {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,
		                                   uVar4,*(undefined4 *)
		                                          (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                        iVar8 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar8 == 1) {
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x81cfbafc;
		                        }
		                      }
		                      goto code_r0x81cfb7ad;
		                    }
		                    iVar8 = *(int *)(param1 + 0x40);
		                    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                    uVar2 = *(uint *)(iVar8 + 0xc);
		                    if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                      *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                      iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		                      goto code_r0x81cfd157;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                    iVar8 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                  } while (iVar8 != 1);
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfbafc:
		                  iVar8 = global_1;
		                  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                  if (iVar8 == iVar6) {
		                    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		                    local_30 = *piVar7;
		                    iVar8 = 0;
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_v(0x123);
		                    iVar6 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar6 != 1) {
		code_r0x81cfbb49:
		                      DAT_ram_009d3e38 = 0;
		                      piVar7 = *local_2c;
		                      if (piVar7 != (int *)0x0) {
		                        uVar2 = 0;
		                        iVar6 = *piVar7;
		                        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                          do {
		                            if (System_IDisposable_TypeInfo ==
		                                *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8
		                                                                + 4) * 8 + 0xc0);
		                              goto code_r0x81cfbbc4;
		                            }
		                            uVar2 = uVar2 + 1;
		                          } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                        }
		                        puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfbbc4:
		                        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                      }
		                      if (local_30 != 0) {
		                        System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                        do {
		                          halt_trap();
		                        } while( true );
		                      }
		                      if (iVar8 != 0 && iVar8 != 0x15) {
		                        return;
		                      }
		                      uVar2 = 0;
		                      piVar7 = *(int **)(param1 + 0x10);
		                      iVar8 = *piVar7;
		                      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                        do {
		                          if (Core_Gameplay_IGame_TypeInfo ==
		                              *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                              iVar8 + 0x178);
		                            goto code_r0x81cfbc5a;
		                          }
		                          uVar2 = uVar2 + 1;
		                        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                      }
		                      puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfbc5a:
		                      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                      iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0)
		                      ;
		                      local_1c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                                  (*(undefined4 *)(iVar8 + 0x134),
		                                                                                                      
		                                                  Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__GetEnumerator__
		                                                  );
		                      local_30 = 0;
		                      local_2c = &local_1c;
		code_r0x81cfbc9b:
		                      do {
		                        piVar7 = local_1c;
		                        iVar8 = *local_1c;
		                        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                          uVar2 = 0;
		                          do {
		                            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                              puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                              goto code_r0x81cfbd3f;
		                            }
		                            uVar2 = uVar2 + 1;
		                          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                        }
		                        DAT_ram_009d3e38 = 0;
		                        puVar5 = (undefined4 *)
		                                 import::env::invoke_iiii
		                                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                            local_1c,System_Collections_IEnumerator_TypeInfo,0);
		                        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfbd87:
		                          DAT_ram_009d3e38 = 0;
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x81cfbfea;
		                        }
		code_r0x81cfbd3f:
		                        DAT_ram_009d3e38 = 0;
		                        iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                        piVar7 = local_1c;
		                        if (DAT_ram_009d3e38 == 1) goto code_r0x81cfbd87;
		                        if (iVar8 == 0) {
		                          iVar8 = 0x19;
		                          goto code_r0x81cfc037;
		                        }
		                        iVar8 = *local_1c;
		                        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                          uVar2 = 0;
		                          do {
		                            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                            if (System_Collections_Generic_IEnumerator_AccountOptionsDic__TypeInfo
		                                == *piVar9) {
		                              puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                              goto code_r0x81cfbe32;
		                            }
		                            uVar2 = uVar2 + 1;
		                          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                        }
		                        DAT_ram_009d3e38 = 0;
		                        puVar5 = (undefined4 *)
		                                 import::env::invoke_iiii
		                                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                            local_1c,
		                                            System_Collections_Generic_IEnumerator_AccountOptionsDic__TypeInfo
		                                            ,0);
		                        if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfbf0a:
		                          DAT_ram_009d3e38 = 0;
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x81cfbfea;
		                        }
		code_r0x81cfbe32:
		                        DAT_ram_009d3e38 = 0;
		                        iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                        if (DAT_ram_009d3e38 == 1) goto code_r0x81cfbf0a;
		                        local_8 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0xc);
		                        DAT_ram_009d3e38 = 0;
		                        uVar4 = import::env::invoke_iii
		                                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x167,
		                                           &local_8,0);
		                        iVar1 = DAT_ram_009d3e38;
		                        iVar6 = Method_System_Collections_Generic_List_string__Add__;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar1 == 1) {
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x81cfbfea;
		                        }
		                        if (*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0x24) + 0xc) != 0) {
		                          iVar8 = *(int *)(param1 + 0x3c);
		                          *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                          uVar2 = *(uint *)(iVar8 + 0xc);
		                          if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                            *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                            iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd106:
		                            *(undefined4 *)(iVar8 + 0x10) = uVar4;
		                          }
		                          else {
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_viii
		                                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,
		                                       uVar4,*(undefined4 *)
		                                              (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81cfbfea;
		                            }
		                          }
		                          goto code_r0x81cfbc9b;
		                        }
		                        iVar8 = *(int *)(param1 + 0x40);
		                        *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                        uVar2 = *(uint *)(iVar8 + 0xc);
		                        if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                          *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                          iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		                          goto code_r0x81cfd106;
		                        }
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,
		                                   uVar4,*(undefined4 *)
		                                          (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                        iVar8 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                      } while (iVar8 != 1);
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfbfea:
		                      iVar8 = global_1;
		                      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                      if (iVar8 == iVar6) {
		                        piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		                        local_30 = *piVar7;
		                        iVar8 = 0;
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_v(0x123);
		                        iVar6 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar6 != 1) {
		code_r0x81cfc037:
		                          DAT_ram_009d3e38 = 0;
		                          piVar7 = *local_2c;
		                          if (piVar7 != (int *)0x0) {
		                            uVar2 = 0;
		                            iVar6 = *piVar7;
		                            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                              do {
		                                if (System_IDisposable_TypeInfo ==
		                                    *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                                  puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) +
		                                                                     uVar2 * 8 + 4) * 8 + 0xc0);
		                                  goto code_r0x81cfc0b2;
		                                }
		                                uVar2 = uVar2 + 1;
		                              } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                            }
		                            puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfc0b2:
		                            (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                          }
		                          if (local_30 != 0) {
		                            System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                            do {
		                              halt_trap();
		                            } while( true );
		                          }
		                          if (iVar8 != 0 && iVar8 != 0x19) {
		                            return;
		                          }
		                          uVar2 = 0;
		                          piVar7 = *(int **)(param1 + 0x10);
		                          iVar8 = *piVar7;
		                          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                            do {
		                              if (Core_Gameplay_IGame_TypeInfo ==
		                                  *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) *
		                                                  8 + iVar8 + 0x178);
		                                goto code_r0x81cfc148;
		                              }
		                              uVar2 = uVar2 + 1;
		                            } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                          }
		                          puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfc148:
		                          uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                          iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                                            (uVar4,0);
		                          local_20 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                                      (*(undefined4 *)(iVar8 + 0x1cc),
		                                                                                                              
		                                                  Method_Google_Protobuf_Collections_RepeatedField_MarketOptionsDic__GetEnumerator__
		                                                  );
		                          local_30 = 0;
		                          local_2c = &local_20;
		code_r0x81cfc189:
		                          do {
		                            piVar7 = local_20;
		                            iVar8 = *local_20;
		                            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                              uVar2 = 0;
		                              do {
		                                piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                                if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                                  puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                                  goto code_r0x81cfc22d;
		                                }
		                                uVar2 = uVar2 + 1;
		                              } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            puVar5 = (undefined4 *)
		                                     import::env::invoke_iiii
		                                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                0x18,local_20,
		                                                System_Collections_IEnumerator_TypeInfo,0);
		                            if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfc275:
		                              DAT_ram_009d3e38 = 0;
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81cfc4d8;
		                            }
		code_r0x81cfc22d:
		                            DAT_ram_009d3e38 = 0;
		                            iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                            piVar7 = local_20;
		                            if (DAT_ram_009d3e38 == 1) goto code_r0x81cfc275;
		                            if (iVar8 == 0) {
		                              iVar8 = 0x1d;
		                              goto code_r0x81cfc525;
		                            }
		                            iVar8 = *local_20;
		                            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                              uVar2 = 0;
		                              do {
		                                piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                                if (System_Collections_Generic_IEnumerator_MarketOptionsDic__TypeInfo
		                                    == *piVar9) {
		                                  puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                                  goto code_r0x81cfc320;
		                                }
		                                uVar2 = uVar2 + 1;
		                              } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            puVar5 = (undefined4 *)
		                                     import::env::invoke_iiii
		                                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                0x18,local_20,
		                                                System_Collections_Generic_IEnumerator_MarketOptionsDic__TypeInfo
		                                                ,0);
		                            if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfc3f8:
		                              DAT_ram_009d3e38 = 0;
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81cfc4d8;
		                            }
		code_r0x81cfc320:
		                            DAT_ram_009d3e38 = 0;
		                            iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                            if (DAT_ram_009d3e38 == 1) goto code_r0x81cfc3f8;
		                            local_8 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0xc);
		                            DAT_ram_009d3e38 = 0;
		                            uVar4 = import::env::invoke_iii
		                                              (s_struct_Uniforms___color__array<v_ram_00001b87 +
		                                               0x167,&local_8,0);
		                            iVar1 = DAT_ram_009d3e38;
		                            iVar6 = Method_System_Collections_Generic_List_string__Add__;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar1 == 1) {
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x81cfc4d8;
		                            }
		                            if (*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0x24) + 0xc) != 0) {
		                              iVar8 = *(int *)(param1 + 0x3c);
		                              *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                              uVar2 = *(uint *)(iVar8 + 0xc);
		                              if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                                *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                                iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd0b5:
		                                *(undefined4 *)(iVar8 + 0x10) = uVar4;
		                              }
		                              else {
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_viii
		                                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,
		                                           iVar8,uVar4,
		                                           *(undefined4 *)
		                                            (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                                iVar8 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar8 == 1) {
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x81cfc4d8;
		                                }
		                              }
		                              goto code_r0x81cfc189;
		                            }
		                            iVar8 = *(int *)(param1 + 0x40);
		                            *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                            uVar2 = *(uint *)(iVar8 + 0xc);
		                            if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                              *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                              iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		                              goto code_r0x81cfd0b5;
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_viii
		                                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,
		                                       uVar4,*(undefined4 *)
		                                              (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                          } while (iVar8 != 1);
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfc4d8:
		                          iVar8 = global_1;
		                          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                          if (iVar8 == iVar6) {
		                            piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		                            local_30 = *piVar7;
		                            iVar8 = 0;
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_v(0x123);
		                            iVar6 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar6 != 1) {
		code_r0x81cfc525:
		                              DAT_ram_009d3e38 = 0;
		                              piVar7 = *local_2c;
		                              if (piVar7 != (int *)0x0) {
		                                uVar2 = 0;
		                                iVar6 = *piVar7;
		                                if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                                  do {
		                                    if (System_IDisposable_TypeInfo ==
		                                        *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                                      puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) +
		                                                                         uVar2 * 8 + 4) * 8 + 0xc0);
		                                      goto code_r0x81cfc5a0;
		                                    }
		                                    uVar2 = uVar2 + 1;
		                                  } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                                }
		                                puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81cfc5a0:
		                                (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                              }
		                              if (local_30 != 0) {
		                                System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                                do {
		                                  halt_trap();
		                                } while( true );
		                              }
		                              if (iVar8 != 0 && iVar8 != 0x1d) {
		                                return;
		                              }
		                              uVar2 = 0;
		                              piVar7 = *(int **)(param1 + 0x10);
		                              iVar8 = *piVar7;
		                              if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                do {
		                                  if (Core_Gameplay_IGame_TypeInfo ==
		                                      *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                    puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 +
		                                                              4) * 8 + iVar8 + 0x178);
		                                    goto code_r0x81cfc636;
		                                  }
		                                  uVar2 = uVar2 + 1;
		                                } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                              }
		                              puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17
		                                                           );
		code_r0x81cfc636:
		                              uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                              iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                                                (uVar4,0);
		                              local_24 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                                          (*(undefined4 *)(iVar8 + 0x2f4),
		                                                                                                                      
		                                                  Method_Google_Protobuf_Collections_RepeatedField_EndlessPaymentOptionListOptionDic__GetEnumerator__
		                                                  );
		                              local_30 = 0;
		                              local_2c = &local_24;
		code_r0x81cfc677:
		                              do {
		                                piVar7 = local_24;
		                                iVar8 = *local_24;
		                                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                  uVar2 = 0;
		                                  do {
		                                    piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                                    if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                                      puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                                      goto code_r0x81cfc71b;
		                                    }
		                                    uVar2 = uVar2 + 1;
		                                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                puVar5 = (undefined4 *)
		                                         import::env::invoke_iiii
		                                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421
		                                                    + 0x18,local_24,
		                                                    System_Collections_IEnumerator_TypeInfo,0);
		                                if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfc763:
		                                  DAT_ram_009d3e38 = 0;
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x81cfc9c6;
		                                }
		code_r0x81cfc71b:
		                                DAT_ram_009d3e38 = 0;
		                                iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                                piVar7 = local_24;
		                                if (DAT_ram_009d3e38 == 1) goto code_r0x81cfc763;
		                                if (iVar8 == 0) {
		                                  iVar8 = 0x21;
		                                  goto code_r0x81cfca13;
		                                }
		                                iVar8 = *local_24;
		                                if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                  uVar2 = 0;
		                                  do {
		                                    piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                                    if (System_Collections_Generic_IEnumerator_EndlessPaymentOptionListOptionDic__TypeInfo
		                                        == *piVar9) {
		                                      puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                                      goto code_r0x81cfc80e;
		                                    }
		                                    uVar2 = uVar2 + 1;
		                                  } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                puVar5 = (undefined4 *)
		                                         import::env::invoke_iiii
		                                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421
		                                                    + 0x18,local_24,
		                                                                                                        
		                                                  System_Collections_Generic_IEnumerator_EndlessPaymentOptionListOptionDic__TypeInfo
		                                                  ,0);
		                                if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfc8e6:
		                                  DAT_ram_009d3e38 = 0;
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x81cfc9c6;
		                                }
		code_r0x81cfc80e:
		                                DAT_ram_009d3e38 = 0;
		                                iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                                if (DAT_ram_009d3e38 == 1) goto code_r0x81cfc8e6;
		                                local_8 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0xc);
		                                DAT_ram_009d3e38 = 0;
		                                uVar4 = import::env::invoke_iii
		                                                  (s_struct_Uniforms___color__array<v_ram_00001b87 +
		                                                   0x167,&local_8,0);
		                                iVar1 = DAT_ram_009d3e38;
		                                iVar6 = Method_System_Collections_Generic_List_string__Add__;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar1 == 1) {
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x81cfc9c6;
		                                }
		                                if (*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0x24) + 0xc) != 0) {
		                                  iVar8 = *(int *)(param1 + 0x3c);
		                                  *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                                  uVar2 = *(uint *)(iVar8 + 0xc);
		                                  if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                                    *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                                    iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd064:
		                                    *(undefined4 *)(iVar8 + 0x10) = uVar4;
		                                  }
		                                  else {
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_viii
		                                              (s_struct_Uniforms___color__array<v_ram_00000aff +
		                                               0x6e,iVar8,uVar4,
		                                               *(undefined4 *)
		                                                (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                                    iVar8 = DAT_ram_009d3e38;
		                                    DAT_ram_009d3e38 = 0;
		                                    if (iVar8 == 1) {
		                                      uVar4 = import::env::__cxa_find_matching_catch_3
		                                                        (&DAT_ram_0072c9c8);
		                                      goto code_r0x81cfc9c6;
		                                    }
		                                  }
		                                  goto code_r0x81cfc677;
		                                }
		                                iVar8 = *(int *)(param1 + 0x40);
		                                *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                                uVar2 = *(uint *)(iVar8 + 0xc);
		                                if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                                  *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                                  iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		                                  goto code_r0x81cfd064;
		                                }
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_viii
		                                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,
		                                           iVar8,uVar4,
		                                           *(undefined4 *)
		                                            (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                                iVar8 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                              } while (iVar8 != 1);
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cfc9c6:
		                              iVar8 = global_1;
		                              iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                              if (iVar8 == iVar6) {
		                                piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		                                local_30 = *piVar7;
		                                iVar8 = 0;
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_v(0x123);
		                                iVar6 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar6 != 1) {
		code_r0x81cfca13:
		                                  DAT_ram_009d3e38 = 0;
		                                  piVar7 = *local_2c;
		                                  if (piVar7 != (int *)0x0) {
		                                    uVar2 = 0;
		                                    iVar6 = *piVar7;
		                                    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                                      do {
		                                        if (System_IDisposable_TypeInfo ==
		                                            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                                          puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58)
		                                                                             + uVar2 * 8 + 4) * 8 +
		                                                           0xc0);
		                                          goto code_r0x81cfca8e;
		                                        }
		                                        uVar2 = uVar2 + 1;
		                                      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                                    }
		                                    puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo
		                                                                  ,0);
		code_r0x81cfca8e:
		                                    (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                                  }
		                                  if (local_30 != 0) {
		                                    System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                                    do {
		                                      halt_trap();
		                                    } while( true );
		                                  }
		                                  if (iVar8 != 0 && iVar8 != 0x21) {
		                                    return;
		                                  }
		                                  uVar2 = 0;
		                                  piVar7 = *(int **)(param1 + 0x10);
		                                  iVar8 = *piVar7;
		                                  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                    do {
		                                      if (Core_Gameplay_IGame_TypeInfo ==
		                                          *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                                        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) +
		                                                                   uVar2 * 8 + 4) * 8 + iVar8 +
		                                                         0x178);
		                                        goto code_r0x81cfcb24;
		                                      }
		                                      uVar2 = uVar2 + 1;
		                                    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                  }
		                                  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,
		                                                                0x17);
		code_r0x81cfcb24:
		                                  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                                  iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                                                    (uVar4,0);
		                                  local_28 = (int *)
		                                                  Google_Protobuf_Collections_RepeatedField_float___Equals
		                                                            (*(undefined4 *)(iVar8 + 0x334),
		                                                                                                                          
		                                                  Method_Google_Protobuf_Collections_RepeatedField_RegularOptionsDic__GetEnumerator__
		                                                  );
		                                  local_30 = 0;
		                                  local_2c = &local_28;
		code_r0x81cfcb65:
		                                  do {
		                                    piVar7 = local_28;
		                                    iVar8 = *local_28;
		                                    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                      uVar2 = 0;
		                                      do {
		                                        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                                        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                                          puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                                          goto code_r0x81cfcc0b;
		                                        }
		                                        uVar2 = uVar2 + 1;
		                                      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    puVar5 = (undefined4 *)
		                                             import::env::invoke_iiii
		                                                       (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,local_28,
		                                                  System_Collections_IEnumerator_TypeInfo,0);
		                                    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfcc53:
		                                      DAT_ram_009d3e38 = 0;
		                                      uVar4 = import::env::__cxa_find_matching_catch_3
		                                                        (&DAT_ram_0072c9c8);
		                                      goto code_r0x81cfcebc;
		                                    }
		code_r0x81cfcc0b:
		                                    DAT_ram_009d3e38 = 0;
		                                    iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                                    piVar7 = local_28;
		                                    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfcc53;
		                                    if (iVar8 == 0) {
		                                      iVar8 = 0x25;
		                                      goto code_r0x81cfcf09;
		                                    }
		                                    iVar8 = *local_28;
		                                    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		                                      uVar2 = 0;
		                                      do {
		                                        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		                                        if (System_Collections_Generic_IEnumerator_RegularOptionsDic__TypeInfo
		                                            == *piVar9) {
		                                          puVar5 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                                          goto code_r0x81cfccfe;
		                                        }
		                                        uVar2 = uVar2 + 1;
		                                      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    puVar5 = (undefined4 *)
		                                             import::env::invoke_iiii
		                                                       (
		                                                  s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                  0x18,local_28,
		                                                  System_Collections_Generic_IEnumerator_RegularOptionsDic__TypeInfo
		                                                  ,0);
		                                    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cfcddc:
		                                      DAT_ram_009d3e38 = 0;
		                                      uVar4 = import::env::__cxa_find_matching_catch_3
		                                                        (&DAT_ram_0072c9c8);
		                                      goto code_r0x81cfcebc;
		                                    }
		code_r0x81cfccfe:
		                                    DAT_ram_009d3e38 = 0;
		                                    iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		                                    if (DAT_ram_009d3e38 == 1) goto code_r0x81cfcddc;
		                                    local_8 = *(undefined4 *)
		                                               (*(int *)(*(int *)(iVar8 + 0xc) + 0xc) + 0xc);
		                                    DAT_ram_009d3e38 = 0;
		                                    uVar4 = import::env::invoke_iii
		                                                      (
		                                                  s_struct_Uniforms___color__array<v_ram_00001b87 +
		                                                  0x167,&local_8,0);
		                                    iVar1 = DAT_ram_009d3e38;
		                                    iVar6 = Method_System_Collections_Generic_List_string__Add__;
		                                    DAT_ram_009d3e38 = 0;
		                                    if (iVar1 == 1) {
		                                      uVar4 = import::env::__cxa_find_matching_catch_3
		                                                        (&DAT_ram_0072c9c8);
		                                      goto code_r0x81cfcebc;
		                                    }
		                                    if (*(int *)(*(int *)(*(int *)(*(int *)(iVar8 + 0xc) + 0xc) +
		                                                         0x24) + 0xc) != 0) {
		                                      iVar8 = *(int *)(param1 + 0x3c);
		                                      *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                                      uVar2 = *(uint *)(iVar8 + 0xc);
		                                      if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                                        *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                                        iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		code_r0x81cfd013:
		                                        *(undefined4 *)(iVar8 + 0x10) = uVar4;
		                                      }
		                                      else {
		                                        DAT_ram_009d3e38 = 0;
		                                        import::env::invoke_viii
		                                                  (s_struct_Uniforms___color__array<v_ram_00000aff +
		                                                   0x6e,iVar8,uVar4,
		                                                   *(undefined4 *)
		                                                    (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38)
		                                                  );
		                                        iVar8 = DAT_ram_009d3e38;
		                                        DAT_ram_009d3e38 = 0;
		                                        if (iVar8 == 1) {
		                                          uVar4 = import::env::__cxa_find_matching_catch_3
		                                                            (&DAT_ram_0072c9c8);
		                                          goto code_r0x81cfcebc;
		                                        }
		                                      }
		                                      goto code_r0x81cfcb65;
		                                    }
		                                    iVar8 = *(int *)(param1 + 0x40);
		                                    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		                                    uVar2 = *(uint *)(iVar8 + 0xc);
		                                    if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		                                      *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		                                      iVar8 = *(int *)(iVar8 + 8) + uVar2 * 4;
		                                      goto code_r0x81cfd013;
		                                    }
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_viii
		                                              (s_struct_Uniforms___color__array<v_ram_00000aff +
		                                               0x6e,iVar8,uVar4,
		                                               *(undefined4 *)
		                                                (*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		                                    iVar8 = DAT_ram_009d3e38;
		                                    DAT_ram_009d3e38 = 0;
		                                  } while (iVar8 != 1);
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		code_r0x81cfcebc:
		                                  iVar8 = global_1;
		                                  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                                  if (iVar8 == iVar6) {
		                                    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		                                    local_30 = *piVar7;
		                                    iVar8 = 0;
		                                    DAT_ram_009d3e38 = 0;
		                                    import::env::invoke_v(0x123);
		                                    iVar6 = DAT_ram_009d3e38;
		                                    DAT_ram_009d3e38 = 0;
		                                    if (iVar6 != 1) {
		code_r0x81cfcf09:
		                                      DAT_ram_009d3e38 = 0;
		                                      piVar7 = *local_2c;
		                                      if (piVar7 != (int *)0x0) {
		                                        uVar2 = 0;
		                                        iVar6 = *piVar7;
		                                        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		                                          do {
		                                            if (System_IDisposable_TypeInfo ==
		                                                *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		                                              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 
		                                                  0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		                                              goto code_r0x81cfcf84;
		                                            }
		                                            uVar2 = uVar2 + 1;
		                                          } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		                                        }
		                                        puVar3 = (uint *)func_ii_1080(piVar7,
		                                                  System_IDisposable_TypeInfo,0);
		code_r0x81cfcf84:
		                                        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		                                      }
		                                      if (local_30 != 0) {
		                                        System_Data_DataSet__ValidateLocaleConstraint(local_30);
		                                        do {
		                                          halt_trap();
		                                        } while( true );
		                                      }
		                                      if (iVar8 != 0 && iVar8 != 0x25) {
		                                        return;
		                                      }
		                                      func_ii_6335(*(undefined4 *)(param1 + 0x38),
		                                                   *(undefined4 *)(param1 + 0x40),
		                                                                                                      
		                                                  Method_System_Collections_Generic_List_string__AddRange__
		                                                  );
		                                      func_ii_6335(*(undefined4 *)(param1 + 0x38),
		                                                   *(undefined4 *)(param1 + 0x3c),
		                                                                                                      
		                                                  Method_System_Collections_Generic_List_string__AddRange__
		                                                  );
		                                      return;
		                                    }
		                                    uVar4 = import::env::__cxa_find_matching_catch_2();
		                                  }
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_ii
		                                            (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0xc,
		                                             &local_30);
		                                  goto joined_r0x81cfd1a3;
		                                }
		                                uVar4 = import::env::__cxa_find_matching_catch_2();
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_ii
		                                        (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0xd,
		                                         &local_30);
		                              goto joined_r0x81cfd1a3;
		                            }
		                            uVar4 = import::env::__cxa_find_matching_catch_2();
		                          }
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_ii
		                                    (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0xe,&local_30
		                                    );
		                          goto joined_r0x81cfd1a3;
		                        }
		                        uVar4 = import::env::__cxa_find_matching_catch_2();
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_ii
		                                (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0xf,&local_30);
		                      goto joined_r0x81cfd1a3;
		                    }
		                    uVar4 = import::env::__cxa_find_matching_catch_2();
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_ii
		                            (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x10,&local_30);
		                  goto joined_r0x81cfd1a3;
		                }
		                uVar4 = import::env::__cxa_find_matching_catch_2();
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii
		                        (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x11,&local_30);
		              goto joined_r0x81cfd1a3;
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x12,&local_30);
		          goto joined_r0x81cfd1a3;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x13,&local_30);
		      goto joined_r0x81cfd1a3;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x14,&local_30);
		joined_r0x81cfd1a3:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x9922", Offset = "0x9922", VA = "0x9922", Slot = "10")]
		protected override void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		undefined4
		Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts__HandleInit
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts_GetExtPriceData__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x9923", Offset = "0x9923", VA = "0x9923", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
		/* --- GHIDRA: GetExtPriceData ---
		undefined4
		Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts__GetExtPriceData
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  uVar1 = unnamed_function_2232(&System_NotImplementedException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  UnityEngine_InputSystem_InputActionRebindingExtensions__ApplyBindingOverride(uVar1,0);
		  param2_00 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts_IsOptionValid__
		                        );
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x0000DC50 File Offset: 0x0000BE50
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x9924", Offset = "0x9924", VA = "0x9924", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
		/* --- GHIDRA: IsOptionValid ---
		undefined4
		Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts__IsOptionValid
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a6090d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28724);
		    DAT_ram_00a6090d = '\x01';
		  }
		  uVar2 = func_ii_7775(param2,0);
		  uVar2 = func_ii_4419(StringLiteral_28724,uVar2,0);
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x81cfd3cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cfd3cf:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  iVar5 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar4,uVar2,0);
		  if (iVar5 == 0) {
		    uVar4 = unnamed_function_2232(&StringLiteral_17625);
		    param3_00 = unnamed_function_2232(&StringLiteral_852);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__(uVar4,uVar2,param3_00,0);
		    uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar4 = unnamed_function_1417(uVar4);
		    System_String__Concat(uVar4,uVar2,0);
		    uVar2 = unnamed_function_2232
		                      (&
		                       Method_Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts_GetRecipeValidatorEndpoint__
		                      );
		    func_ii_1050(uVar4,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = unnamed_function_1417(System_Uri_TypeInfo);
		  UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar2,iVar5,0);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x9925", Offset = "0x9925", VA = "0x9925")]
		public Uri GetRecipeValidatorEndpoint(string storeName)
		{
			return null;
		}

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x38")]
		public readonly List<string> AllOptionIds;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x3C")]
		public readonly List<string> AllExtPriceOptionIds;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x40")]
		public readonly List<string> AllResourcePriceOptionIds;

		// Token: 0x040028AD RID: 10413
		[Token(Token = "0x40028AD")]
		[FieldOffset(Offset = "0x48")]
		public readonly string StoreName;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsPurchasesAvailable ---
		void Gameplay_Billing_Model_BillingModelForAppMarketWhitProducts__get_IsPurchasesAvailable
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6090b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a6090b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  if (DAT_ram_00a60907 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_List_string____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_List_string___TypeInfo);
		    DAT_ram_00a60907 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Queue_List_string___TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,Method_System_Collections_Generic_Queue_List_string____ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param7,0);
		  *(undefined4 *)(param1 + 0x30) = param5;
		  *(undefined4 *)(param1 + 0x28) = param4;
		  *(undefined4 *)(param1 + 0x34) = param3;
		  *(undefined4 *)(param1 + 0x10) = param6;
		  Gameplay_Billing_Model_AbstractBillingModel___ctor(param1,param1);
		  *(undefined4 *)(param1 + 0x48) = param2;
		  return;
		}
		*/

}
