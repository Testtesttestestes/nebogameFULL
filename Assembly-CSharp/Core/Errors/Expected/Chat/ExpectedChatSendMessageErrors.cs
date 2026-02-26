using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Chat
{
	// Token: 0x0200108B RID: 4235
	[Token(Token = "0x200108B")]
	public class ExpectedChatSendMessageErrors : ExpectedDefaultError
	{
		// Token: 0x060062A9 RID: 25257 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x60062A9")]
		[Address(RVA = "0xAECF", Offset = "0xAECF", VA = "0xAECF", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AA")]
		[Address(RVA = "0xAED0", Offset = "0xAED0", VA = "0xAED0")]
		public ExpectedChatSendMessageErrors()
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Errors_Expected_Chat_ExpectedChatSendMessageErrors___ctor
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a60737 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3594);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3593);
		    DAT_ram_00a60737 = '\x01';
		  }
		  if ((int)param2 < 0) {
		    if (param2 == 0xfffffff3) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3594,1,0,1,0,0,0,0);
		      param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3593,1,0,1,0,0,0,0);
		      UI_Windows_DialogWindow__Show(param1_00,param2_00,0);
		    }
		    else {
		      param1_01 = (int *)param1[2];
		      if (param1_01 != (int *)0x0) {
		        if (((uint)*(byte *)(*param1_01 + 0xb8) <
		             (uint)*(byte *)(
		                            Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		                            + 0xb8)) ||
		           (*(int *)(*(int *)(*param1_01 + 100) +
		                     (uint)*(byte *)(
		                                    Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		                                    + 0xb8) * 4 + -4) !=
		            Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		           )) {
		          System_Activator__CreateInstance
		                    (param1_01,
		                     Core_Errors_Expected_Billing_ExpectedGetPaymentDataErrors_ExpectedGetPaymentDataErrorsArgs_TypeInfo
		                    );
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                (param1,param1_01,*(undefined4 *)(*param1 + 0xec));
		    }
		  }
		  return param2 >> 0x1f;
		}
		*/

		}
	}
}
