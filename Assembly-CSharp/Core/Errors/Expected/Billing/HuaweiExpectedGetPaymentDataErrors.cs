using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Billing
{
	// Token: 0x0200108F RID: 4239
	[Token(Token = "0x200108F")]
	public class HuaweiExpectedGetPaymentDataErrors : ExpectedGetPaymentDataErrors
	{
		// Token: 0x060062B1 RID: 25265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B1")]
		[Address(RVA = "0xAED6", Offset = "0xAED6", VA = "0xAED6", Slot = "5")]
		protected override void LogUnhandledError(ExpectedGetPaymentDataErrors.ExpectedGetPaymentDataErrorsArgs args)
		{
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062B2")]
		[Address(RVA = "0xAED7", Offset = "0xAED7", VA = "0xAED7")]
		public HuaweiExpectedGetPaymentDataErrors()
		{
		}
	}
}
