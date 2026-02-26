using System;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.FeedbackForm.Service
{
	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	public class FeedbackFormService : AbstractHTTPService
	{
		// Token: 0x060030E3 RID: 12515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x8146", Offset = "0x8146", VA = "0x8146")]
		public FeedbackFormService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_FeedbackForm_Service_FeedbackFormService___ctor
		                (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a575f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__HTTPResponse___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_int__HTTPResponse__TypeInfo);
		    DAT_ram_00a575f6 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(Utils_OpToken_int__HTTPResponse__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,Method_Utils_OpToken_int__HTTPResponse___ctor__);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		  Utils_OpToken_int__object____ctor(param1,param1_00,param2,param1_00);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x8147", Offset = "0x8147", VA = "0x8147")]
		public OpToken<int, HTTPResponse> SubmitForm(ServiceMessages.FeedbackFormMessage message)
		{
			return null;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x1AED", Offset = "0x1AED", VA = "0x1AED")]
		private void SubmitFormInternal(OpToken<int, HTTPResponse> token, ServiceMessages.FeedbackFormMessage message)
		{
		/* --- GHIDRA: SubmitFormInternal ---
		undefined4
		Gameplay_FeedbackForm_Service_FeedbackFormService__SubmitFormInternal
		          (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (param1,param2,0,
		                     *(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x2c));
		  uVar1 = Utils_OpToken_object__object____ctor
		                    (uVar1,param3,*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x30));
		  return uVar1;
		}
		*/

		}
	}
}
