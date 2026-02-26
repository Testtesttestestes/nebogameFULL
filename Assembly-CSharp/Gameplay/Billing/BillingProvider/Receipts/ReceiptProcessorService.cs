using System;
using System.Collections.Generic;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Billing.BillingProvider.Receipts
{
	// Token: 0x02000C13 RID: 3091
	[Token(Token = "0x2000C13")]
	public class ReceiptProcessorService : AbstractHTTPService
	{
		// Token: 0x06004BAC RID: 19372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x99F2", Offset = "0x99F2", VA = "0x99F2")]
		public ReceiptProcessorService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService___ctor
		                (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a60954 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_StoreReceiptProcessorResponse__HTTPResponse___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_OpToken_StoreReceiptProcessorResponse__HTTPResponse__TypeInfo);
		    DAT_ram_00a60954 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417
		                               (Utils_OpToken_StoreReceiptProcessorResponse__HTTPResponse__TypeInfo)
		  ;
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,Method_Utils_OpToken_StoreReceiptProcessorResponse__HTTPResponse___ctor__);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService__SubmitReceipt
		            (param1,param1_00,param2,param1_00);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x99F3", Offset = "0x99F3", VA = "0x99F3")]
		public OpToken<StoreReceiptProcessorResponse, HTTPResponse> SubmitReceipt(IDictionary<string, string> data)
		{
		/* --- GHIDRA: SubmitReceipt ---
		void Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService__SubmitReceipt
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 *puVar5;
		  undefined4 param1_01;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  undefined4 local_18;
		  undefined4 local_14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a60955 == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_Forms_HTTPUrlEncodedForm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_KeyValuePair_string__string___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_KeyValuePair_string__string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string__get_Value__);
		    Mono_Security_ASN1__get_Item(&BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService___c__DisplayClass2_0__SubmitReceiptInternal_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService___c__DisplayClass2_0_TypeInfo
		              );
		    DAT_ram_00a60955 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService___c__DisplayClass2_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 0x10) = param3;
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int **)(iVar2 + 8) = param1;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                        (param1,param1[4],*(undefined4 *)(*param1 + 0xfc));
		  uVar3 = unnamed_function_1417(BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		  BestHTTP_HTTPRange__ToString
		            (uVar3,iVar2,
		             Method_Gameplay_Billing_BillingProvider_Receipts_ReceiptProcessorService___c__DisplayClass2_0__SubmitReceiptInternal_b__0__
		             ,0);
		  *(undefined4 *)(param1_00 + 0x2c) = uVar3;
		  uVar3 = unnamed_function_1417(BestHTTP_Forms_HTTPUrlEncodedForm_TypeInfo);
		  piVar7 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_KeyValuePair_string__string___TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81d02e68;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,
		                                System_Collections_Generic_IEnumerable_KeyValuePair_string__string___TypeInfo
		                                ,0);
		code_r0x81d02e68:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar5 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81d02f3c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81d030ae:
		      DAT_ram_009d3e38 = 0;
		      param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81d030b6;
		    }
		code_r0x81d02f3c:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81d030ae;
		    if (iVar2 == 0) {
		      iVar2 = 0;
		      goto code_r0x81d030ff;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_KeyValuePair_string__string___TypeInfo == *piVar8
		           ) {
		          puVar5 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81d03016;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_KeyValuePair_string__string___TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81d0309a:
		      DAT_ram_009d3e38 = 0;
		      param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81d030b6;
		    }
		code_r0x81d03016:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar5,&local_18,piVar7,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81d0309a;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x1c,uVar3,local_18,local_14,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81d030b6:
		  iVar2 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(param1_01);
		    iVar2 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x81d030ff:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81d03177;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81d03177:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      }
		      if (iVar2 == 0) {
		        *(undefined4 *)(param1_00 + 200) = uVar3;
		        *(undefined8 *)(param1_00 + 0x98) = *(undefined8 *)(param1 + 2);
		        BestHTTP_HTTPRequest__CallCustomCertificationValidator(param1_00,0);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_01 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x1d,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_01);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x99F4", Offset = "0x99F4", VA = "0x99F4")]
		private void SubmitReceiptInternal(OpToken<StoreReceiptProcessorResponse, HTTPResponse> token, IDictionary<string, string> data)
		{
		}
	}
}
