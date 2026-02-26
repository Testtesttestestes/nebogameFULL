using System;
using System.Globalization;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Protocol.Consts;
using Utils;

namespace Core.Application.Managers.Configuration.Curator
{
	// Token: 0x02001273 RID: 4723
	[Token(Token = "0x2001273")]
	public class CuratorService : AbstractHTTPService
	{
		// Token: 0x06007015 RID: 28693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007015")]
		[Address(RVA = "0xBA62", Offset = "0xBA62", VA = "0xBA62")]
		public CuratorService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Configuration_Curator_CuratorService___ctor
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int param2_00;
		  int *param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined8 local_18;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a889 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClientPlatform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Configuration_Curator_CuratorService___c__DisplayClass1_0__BootInternal_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Application_Managers_Configuration_Curator_CuratorService___c__DisplayClass1_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_UriBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Uri_UriQuery_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25023);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26101);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5999);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28661);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20699);
		    DAT_ram_00a5a889 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Core_Application_Managers_Configuration_Curator_CuratorService___c__DisplayClass1_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x14) = param4;
		  *(undefined4 *)(param2_00 + 0x10) = param3;
		  *(int **)(param2_00 + 0xc) = param1;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  iVar3 = param1[4];
		  param1_00 = (int *)unnamed_function_1417(Utils_Uri_UriQuery_TypeInfo);
		  Utils_Uri_UriQuery___ctor(param1_00,iVar3,0);
		  local_8 = 0xffffffff;
		  local_c = Protocol_Consts_ClientPlatform_TypeInfo;
		  local_4 = *(undefined4 *)(param2_00 + 0x10);
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  uVar1 = func_ii_7775(uVar1,0);
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_26101,uVar1,0);
		  iVar3 = **(int **)(param2_00 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf8) * 4))
		                    (*(int **)(param2_00 + 0x14),*(undefined4 *)(iVar3 + 0xfc));
		  uVar1 = func_ii_7775(uVar1,0);
		  Utils_Uri_UriQuery___ctor(param1_00,StringLiteral_25023,uVar1,0);
		  iVar3 = param1[4];
		  uVar1 = unnamed_function_1417(System_UriBuilder_TypeInfo);
		  System_Uri__get_IsAbsoluteUri(uVar1,iVar3,0);
		  System_UriBuilder__set_Query(uVar1,StringLiteral_20699,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  System_String__Split(uVar1,uVar2,0);
		  uVar1 = System_UriBuilder__set_Path(uVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,uVar1,*(undefined4 *)(*param1 + 0xf4));
		  uVar1 = unnamed_function_1417(BestHTTP_OnRequestFinishedDelegate_TypeInfo);
		  BestHTTP_HTTPRange__ToString
		            (uVar1,param2_00,
		             Method_Core_Application_Managers_Configuration_Curator_CuratorService___c__DisplayClass1_0__BootInternal_b__0__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x2c) = uVar1;
		  uVar2 = *(undefined4 *)(iVar3 + 8);
		  local_18 = *(undefined8 *)(param1 + 2);
		  uVar1 = func_ii_1081(System_TimeSpan_TypeInfo,&local_18);
		  uVar1 = func_ii_8529(StringLiteral_28661,StringLiteral_5999,uVar2,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  iVar4 = **(int **)(param2_00 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x110) * 4))
		            (*(int **)(param2_00 + 8),*(undefined4 *)(iVar4 + 0x114));
		  *(undefined8 *)(iVar3 + 0x98) = *(undefined8 *)(param1 + 2);
		  BestHTTP_HTTPRequest__CallCustomCertificationValidator(iVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06007016 RID: 28694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007016")]
		[Address(RVA = "0xBA63", Offset = "0xBA63", VA = "0xBA63")]
		private void BootInternal(OpToken<CuratorJsonMessages.BootAns, HTTPResponse> token, ClientPlatform platform, CultureInfo cultureInfo)
		{
		/* --- GHIDRA: BootInternal ---
		int * Core_Application_Managers_Configuration_Curator_CuratorService__BootInternal
		                (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5a88a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__TypeInfo)
		    ;
		    DAT_ram_00a5a88a = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417
		                               (Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,Method_Utils_OpToken_CuratorJsonMessages_BootAns__HTTPResponse___ctor__);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  Core_Application_Managers_Configuration_Curator_CuratorService___ctor
		            (param1,param1_00,param2,param3,param1_00);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06007017 RID: 28695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007017")]
		[Address(RVA = "0xBA64", Offset = "0xBA64", VA = "0xBA64")]
		public OpToken<CuratorJsonMessages.BootAns, HTTPResponse> Boot(ClientPlatform platform, CultureInfo cultureInfo)
		{
			return null;
		}
	}
}
