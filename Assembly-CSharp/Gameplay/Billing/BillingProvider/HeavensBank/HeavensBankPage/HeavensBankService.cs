using System;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Billing.BillingProvider.HeavensBank.HeavensBankPage
{
	// Token: 0x02000C25 RID: 3109
	[Token(Token = "0x2000C25")]
	public class HeavensBankService : AbstractHTTPService
	{
		// Token: 0x06004BDF RID: 19423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x9A23", Offset = "0x9A23", VA = "0x9A23")]
		public HeavensBankService(IAuthTokenSource authTokenSource, Uri uri, TimeSpan timeout)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___ctor
		          (int *param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 param2_01;
		  int iVar2;
		  float4 local_4;
		  
		  if (DAT_ram_00a6096a == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass3_0__GetBalance_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass3_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_UriBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Uri_UriQuery_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24197);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26509);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19683);
		    DAT_ram_00a6096a = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass3_0_TypeInfo
		                        );
		  uVar1 = unnamed_function_1417
		                    (Utils_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (uVar1,Method_Utils_OpToken_HVBillingVo_GetBalanceResponse__HTTPResponse___ctor__);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  iVar2 = param1[4];
		  param1_00 = (int *)unnamed_function_1417(Utils_Uri_UriQuery_TypeInfo);
		  Utils_Uri_UriQuery___ctor(param1_00,iVar2,0);
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_19683,StringLiteral_24197,0);
		  local_4 = (float4)func_ii_18581(0);
		  iVar2 = System_Collections_Generic_List_float___GetEnumerator(&local_4,0);
		  if (iVar2 == 0) {
		    iVar2 = StringLiteral_5;
		  }
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_26509,iVar2,0);
		  iVar2 = param1[4];
		  uVar1 = unnamed_function_1417(System_UriBuilder_TypeInfo);
		  System_Uri__get_IsAbsoluteUri(uVar1,iVar2,0);
		  param2_01 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  System_String__Split(uVar1,param2_01,0);
		  uVar1 = System_UriBuilder__set_Path(uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,uVar1,*(undefined4 *)(*param1 + 0xf4));
		  *(int *)(param2_00 + 0xc) = iVar2;
		  uVar1 = unnamed_function_1417(BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		  BestHTTP_HTTPRange__ToString
		            (uVar1,param2_00,
		             Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass3_0__GetBalance_b__0__
		             ,0);
		  *(undefined4 *)(iVar2 + 0x2c) = uVar1;
		  iVar2 = **(int **)(param2_00 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		            (*(int **)(param2_00 + 8),*(undefined4 *)(iVar2 + 0x114));
		  *(undefined8 *)(*(int *)(param2_00 + 0xc) + 0x98) = *(undefined8 *)(param1 + 2);
		  BestHTTP_HTTPRequest__CallCustomCertificationValidator(*(undefined4 *)(param2_00 + 0xc),0);
		  return *(undefined4 *)(param2_00 + 8);
		}
		*/

		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x9A24", Offset = "0x9A24", VA = "0x9A24")]
		public OpToken<HVBillingVo.GetBalanceResponse, HTTPResponse> GetBalance()
		{
		/* --- GHIDRA: GetBalance ---
		undefined4
		Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService__GetBalance
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 param2_01;
		  int iVar2;
		  float4 local_4;
		  
		  if (DAT_ram_00a6096b == '\0') {
		    Mono_Security_ASN1__get_Item(&BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass4_0__DrawMoney_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass4_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_UriBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Uri_UriQuery_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22742);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26509);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26052);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19683);
		    DAT_ram_00a6096b = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass4_0_TypeInfo
		                        );
		  uVar1 = unnamed_function_1417(Utils_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse__TypeInfo)
		  ;
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (uVar1,Method_Utils_OpToken_HVBillingVo_DrawMoneyResponse__HTTPResponse___ctor__);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  iVar2 = param1[4];
		  param1_00 = (int *)unnamed_function_1417(Utils_Uri_UriQuery_TypeInfo);
		  Utils_Uri_UriQuery___ctor(param1_00,iVar2,0);
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_19683,StringLiteral_22742,0);
		  uVar1 = UnityEngine_Networking_UnityWebRequest__SetupPost(param2,0);
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_26052,uVar1,0);
		  local_4 = (float4)func_ii_18581(0);
		  iVar2 = System_Collections_Generic_List_float___GetEnumerator(&local_4,0);
		  if (iVar2 == 0) {
		    iVar2 = StringLiteral_5;
		  }
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_26509,iVar2,0);
		  iVar2 = param1[4];
		  uVar1 = unnamed_function_1417(System_UriBuilder_TypeInfo);
		  System_Uri__get_IsAbsoluteUri(uVar1,iVar2,0);
		  param2_01 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  System_String__Split(uVar1,param2_01,0);
		  uVar1 = System_UriBuilder__set_Path(uVar1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,uVar1,*(undefined4 *)(*param1 + 0xf4));
		  *(int *)(param2_00 + 0xc) = iVar2;
		  uVar1 = unnamed_function_1417(BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		  BestHTTP_HTTPRange__ToString
		            (uVar1,param2_00,
		             Method_Gameplay_Billing_BillingProvider_HeavensBank_HeavensBankPage_HeavensBankService___c__DisplayClass4_0__DrawMoney_b__0__
		             ,0);
		  *(undefined4 *)(iVar2 + 0x2c) = uVar1;
		  iVar2 = **(int **)(param2_00 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		            (*(int **)(param2_00 + 8),*(undefined4 *)(iVar2 + 0x114));
		  *(undefined8 *)(*(int *)(param2_00 + 0xc) + 0x98) = *(undefined8 *)(param1 + 2);
		  BestHTTP_HTTPRequest__CallCustomCertificationValidator(*(undefined4 *)(param2_00 + 0xc),0);
		  return *(undefined4 *)(param2_00 + 8);
		}
		*/

			return null;
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x9A25", Offset = "0x9A25", VA = "0x9A25")]
		public OpToken<HVBillingVo.DrawMoneyResponse, HTTPResponse> DrawMoney(string optionsJson)
		{
			return null;
		}

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		public const string GET_BALANCE_ACTION_VALUE = "getbalance";

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		public const string DRAW_MONEY_ACTION_VALUE = "drawmoney";
	}
}
