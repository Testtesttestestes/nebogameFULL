using System;
using System.Collections.Generic;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using Scripts.UI.Filters;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanTreasuryTab
{
	// Token: 0x02000A0C RID: 2572
	[Token(Token = "0x2000A0C")]
	public class ResourceInputTable : MonoBehaviour
	{
		// Token: 0x06003D1E RID: 15646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1E")]
		[Address(RVA = "0x8BDE", Offset = "0x8BDE", VA = "0x8BDE")]
		public void Init(Dictionaries dict)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a57f1d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a57f1d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  iVar1 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar3 = iVar1 + iVar2 * 8;
		      Core_Extensions_Dict_ResourceSetExt__HasNewCurrency
		                (param1_00,*(undefined4 *)(iVar3 + 0x10),
		                 (double)*(longlong *)(*(int *)(iVar3 + 0x14) + 0x38),0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return param1_00;
		}
		*/

		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a57f1d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a57f1d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		  iVar1 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar3 = iVar1 + iVar2 * 8;
		      Core_Extensions_Dict_ResourceSetExt__HasNewCurrency
		                (param1_00,*(undefined4 *)(iVar3 + 0x10),
		                 (double)*(longlong *)(*(int *)(iVar3 + 0x14) + 0x38),0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1F")]
		[Address(RVA = "0x8BDF", Offset = "0x8BDF", VA = "0x8BDF")]
		public void Init(Dictionaries dict, ResourceSet maxLimits)
		{
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D20")]
		[Address(RVA = "0x8BE0", Offset = "0x8BE0", VA = "0x8BE0")]
		public ResourceSet GetInputResources()
		{
		/* --- GHIDRA: GetInputResources ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__GetInputResources
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateUpperBound
		            (param1,param2,param1);
		  Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateBounds(param1,param3,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D21")]
		[Address(RVA = "0x8BE1", Offset = "0x8BE1", VA = "0x8BE1")]
		public void UpdateBounds(Money lowerBound, Money upperBound)
		{
		/* --- GHIDRA: UpdateBounds ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateBounds
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 param2_00;
		  int *piVar7;
		  uint uVar8;
		  longlong param3_00;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57f1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a57f1e = '\x01';
		  }
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = param2;
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e806a5;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e80905:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e8090d;
		    }
		code_r0x80e806a5:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e80905;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x80e80956;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e8077f;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e808d3:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e8090d;
		    }
		code_r0x80e8077f:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e808d3;
		    uVar2 = *(undefined4 *)(iVar6 + 8);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e8090d;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = func_ii_7278(uVar2,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e8090d;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param2_00,uVar2,
		                       Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__get_Item__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e8090d;
		    }
		    DAT_ram_009d3e38 = 0;
		    if (ABS(*(double *)(iVar6 + 0x10)) < 9.223372036854776e+18) {
		      param3_00 = (longlong)*(double *)(iVar6 + 0x10);
		    }
		    else {
		      param3_00 = -0x8000000000000000;
		    }
		    unnamed_function_184058
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xec,uVar2,param3_00,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e8090d:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar6 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80e80956:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		              puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e809ce;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e809ce:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xed,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x8BE2", Offset = "0x8BE2", VA = "0x8BE2")]
		public void UpdateUpperBound(Money resourceSet)
		{
		/* --- GHIDRA: UpdateUpperBound ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateUpperBound
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 param2_00;
		  int *piVar7;
		  uint uVar8;
		  longlong param3_00;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57f1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a57f1f = '\x01';
		  }
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = param2;
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e801fc;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8045c:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80464;
		    }
		code_r0x80e801fc:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8045c;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x80e804ad;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e802d6;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8042a:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80464;
		    }
		code_r0x80e802d6:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8042a;
		    uVar2 = *(undefined4 *)(iVar6 + 8);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e80464;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = func_ii_7278(uVar2,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80464;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param2_00,uVar2,
		                       Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__get_Item__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80464;
		    }
		    DAT_ram_009d3e38 = 0;
		    if (ABS(*(double *)(iVar6 + 0x10)) < 9.223372036854776e+18) {
		      param3_00 = (longlong)*(double *)(iVar6 + 0x10);
		    }
		    else {
		      param3_00 = -0x8000000000000000;
		    }
		    unnamed_function_184058
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xea,uVar2,param3_00,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e80464:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar6 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80e804ad:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		              puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e80525;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e80525:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xeb,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D23")]
		[Address(RVA = "0x8BE3", Offset = "0x8BE3", VA = "0x8BE3")]
		public void UpdateLowerBound(Money resourceSet)
		{
		/* --- GHIDRA: UpdateLowerBound ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__UpdateLowerBound
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 param2_00;
		  int *piVar7;
		  uint uVar8;
		  longlong param3_00;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57f20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a57f20 = '\x01';
		  }
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = param2;
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e80b4e;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e80dae:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80db6;
		    }
		code_r0x80e80b4e:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e80dae;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x80e80dff;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar7) {
		          puVar1 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e80c28;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e80d7c:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80db6;
		    }
		code_r0x80e80c28:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e80d7c;
		    uVar2 = *(undefined4 *)(iVar6 + 8);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e80db6;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = func_ii_7278(uVar2,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80db6;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param2_00,uVar2,
		                       Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__get_Item__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e80db6;
		    }
		    DAT_ram_009d3e38 = 0;
		    if (ABS(*(double *)(iVar6 + 0x10)) < 9.223372036854776e+18) {
		      param3_00 = (longlong)*(double *)(iVar6 + 0x10);
		    }
		    else {
		      param3_00 = -0x8000000000000000;
		    }
		    unnamed_function_184058
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xee,uVar2,param3_00,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e80db6:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar6 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80e80dff:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		              puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e80e77;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e80e77:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xef,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D24")]
		[Address(RVA = "0x8BE4", Offset = "0x8BE4", VA = "0x8BE4")]
		public void PopulateResources(Money money)
		{
		/* --- GHIDRA: PopulateResources ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable__PopulateResources
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__TypeInfo);
		    DAT_ram_00a57f21 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput___ctor__);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D25")]
		[Address(RVA = "0x8BE5", Offset = "0x8BE5", VA = "0x8BE5")]
		public ResourceInputTable()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ResourceInputTable___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		    DAT_ram_00a57f24 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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

		}

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceInputTable.ResourceInput[] _inputs;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Protocol.Consts.Resources, ClampedNumberInput> _inputsByResourceId;

		// Token: 0x02000A0D RID: 2573
		[Token(Token = "0x2000A0D")]
		[Serializable]
		public struct ResourceInput
		{
			// Token: 0x040021F5 RID: 8693
			[Token(Token = "0x40021F5")]
			[FieldOffset(Offset = "0x0")]
			public Protocol.Consts.Resources ResourceId;

			// Token: 0x040021F6 RID: 8694
			[Token(Token = "0x40021F6")]
			[FieldOffset(Offset = "0x4")]
			public ClampedNumberInput Input;
		}
	}
}
