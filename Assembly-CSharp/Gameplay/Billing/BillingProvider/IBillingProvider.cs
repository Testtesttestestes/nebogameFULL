using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider.HeavensBank;
using Gameplay.Billing.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.Billing.BillingProvider
{
	// Token: 0x02000C00 RID: 3072
	[Token(Token = "0x2000C00")]
	public interface IBillingProvider : IDisposable
	{
		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06004B2F RID: 19247
		[Token(Token = "0x17000F29")]
		BillingProviderId ProviderId { [Token(Token = "0x6004B2F")] get; }

		// Token: 0x06004B30 RID: 19248
		[Token(Token = "0x6004B30")]
		void SetToken(string value);

		// Token: 0x06004B31 RID: 19249
		[Token(Token = "0x6004B31")]
		void GetBalance([NotNull] Action<float> callback);

		// Token: 0x06004B32 RID: 19250
		[Token(Token = "0x6004B32")]
		string GetCurrencyCode([NotNull] AbstractBillingModel model);

		// Token: 0x06004B33 RID: 19251
		[Token(Token = "0x6004B33")]
		void RunPurchase([NotNull] AbstractBillingModel model, [NotNull] BankOptionData option, [NotNull] string developPayload, [NotNull] Action<HVBillingVo.PaymentStatusChangedResponse> callback);

		// Token: 0x06004B34 RID: 19252
		[Token(Token = "0x6004B34")]
		UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase([NotNull] AbstractBillingModel model, [NotNull] BankOptionData option, [NotNull] string developPayload, CancellationToken cancellationToken);
	}
}
