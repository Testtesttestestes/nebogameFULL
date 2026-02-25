using System;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Services;

namespace Core.Errors.Expected.Billing
{
	// Token: 0x0200108C RID: 4236
	[Token(Token = "0x200108C")]
	public abstract class ExpectedGetPaymentDataErrors : ExpectedDefaultError
	{
		// Token: 0x060062AB RID: 25259 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x60062AB")]
		[Address(RVA = "0xAED1", Offset = "0xAED1", VA = "0xAED1", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062AC RID: 25260
		[Token(Token = "0x60062AC")]
		protected abstract void LogUnhandledError(ExpectedGetPaymentDataErrors.ExpectedGetPaymentDataErrorsArgs args);

		// Token: 0x060062AD RID: 25261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AD")]
		[Address(RVA = "0xAED2", Offset = "0xAED2", VA = "0xAED2")]
		protected ExpectedGetPaymentDataErrors()
		{
		}

		// Token: 0x0200108D RID: 4237
		[Token(Token = "0x200108D")]
		public class ExpectedGetPaymentDataErrorsArgs
		{
			// Token: 0x060062AE RID: 25262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062AE")]
			[Address(RVA = "0xAED3", Offset = "0xAED3", VA = "0xAED3")]
			public ExpectedGetPaymentDataErrorsArgs(IGame game, ProtoGetPaymentDataAns msg, BankOptionData bankOptionData)
			{
			}

			// Token: 0x040034F9 RID: 13561
			[Token(Token = "0x40034F9")]
			[FieldOffset(Offset = "0x8")]
			public IGame Game;

			// Token: 0x040034FA RID: 13562
			[Token(Token = "0x40034FA")]
			[FieldOffset(Offset = "0xC")]
			public ProtoGetPaymentDataAns Msg;

			// Token: 0x040034FB RID: 13563
			[Token(Token = "0x40034FB")]
			[FieldOffset(Offset = "0x10")]
			public BankOptionData BankOptionData;
		}
	}
}
