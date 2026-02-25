using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Application;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.HeavensBank.HeavensBankPage
{
	// Token: 0x02000C21 RID: 3105
	[Token(Token = "0x2000C21")]
	public class HeavensBankPageBillingProvider : IBillingProvider, IDisposable
	{
		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x17000F47")]
		public BillingProviderId ProviderId
		{
			[Token(Token = "0x6004BCB")]
			[Address(RVA = "0x9A0F", Offset = "0x9A0F", VA = "0x9A0F", Slot = "4")]
			get
			{
				return BillingProviderId.Unknown;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004BCD RID: 19405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F48")]
		public HeavensBankService BankService
		{
			[Token(Token = "0x6004BCC")]
			[Address(RVA = "0x9A10", Offset = "0x9A10", VA = "0x9A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BCD")]
			[Address(RVA = "0x9A11", Offset = "0x9A11", VA = "0x9A11")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004BCF RID: 19407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F49")]
		public IApp App
		{
			[Token(Token = "0x6004BCE")]
			[Address(RVA = "0x9A12", Offset = "0x9A12", VA = "0x9A12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BCF")]
			[Address(RVA = "0x9A13", Offset = "0x9A13", VA = "0x9A13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x9A14", Offset = "0x9A14", VA = "0x9A14", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x9A15", Offset = "0x9A15", VA = "0x9A15")]
		public HeavensBankPageBillingProvider(IApp app, Uri bankPage, HeavensBankService bankService)
		{
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x9A16", Offset = "0x9A16", VA = "0x9A16")]
		private void RunPurchaseWhitDraw(HVBillingVo.OptionItemRequest option, Action<bool> callback)
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD3")]
		[Address(RVA = "0x9A17", Offset = "0x9A17", VA = "0x9A17", Slot = "5")]
		public void SetToken(string value)
		{
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD4")]
		[Address(RVA = "0x9A18", Offset = "0x9A18", VA = "0x9A18", Slot = "6")]
		public void GetBalance(Action<float> callback)
		{
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0x9A19", Offset = "0x9A19", VA = "0x9A19", Slot = "7")]
		public string GetCurrencyCode(AbstractBillingModel model)
		{
			return null;
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x9A1A", Offset = "0x9A1A", VA = "0x9A1A", Slot = "8")]
		public void RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, Action<HVBillingVo.PaymentStatusChangedResponse> callback)
		{
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x9A1B", Offset = "0x9A1B", VA = "0x9A1B", Slot = "9")]
		public UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, CancellationToken cancellationToken)
		{
			return default(UniTask<HVBillingVo.PaymentStatusChangedResponse>);
		}

		// Token: 0x04002948 RID: 10568
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x8")]
		public readonly Uri BankPage;
	}
}
