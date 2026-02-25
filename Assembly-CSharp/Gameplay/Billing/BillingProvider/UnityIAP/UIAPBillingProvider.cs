using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider.HeavensBank;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C0B RID: 3083
	[Token(Token = "0x2000C0B")]
	public class UIAPBillingProvider : IBillingProvider, IDisposable
	{
		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x17000F45")]
		public BillingProviderId ProviderId
		{
			[Token(Token = "0x6004B78")]
			[Address(RVA = "0x99C7", Offset = "0x99C7", VA = "0x99C7", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return BillingProviderId.Unknown;
			}
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B79")]
		[Address(RVA = "0x99C8", Offset = "0x99C8", VA = "0x99C8", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0x99C9", Offset = "0x99C9", VA = "0x99C9")]
		public UIAPBillingProvider(BillingProviderId billingProviderId, IStoreProvider store)
		{
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x99CA", Offset = "0x99CA", VA = "0x99CA", Slot = "5")]
		public void SetToken(string value)
		{
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0x99CB", Offset = "0x99CB", VA = "0x99CB", Slot = "6")]
		public void GetBalance(Action<float> callback)
		{
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004B7D")]
		[Address(RVA = "0x99CC", Offset = "0x99CC", VA = "0x99CC", Slot = "7")]
		public string GetCurrencyCode(AbstractBillingModel model)
		{
			return null;
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7E")]
		[Address(RVA = "0x99CD", Offset = "0x99CD", VA = "0x99CD", Slot = "8")]
		public void RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, Action<HVBillingVo.PaymentStatusChangedResponse> callback)
		{
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x99CE", Offset = "0x99CE", VA = "0x99CE", Slot = "9")]
		public UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, CancellationToken cancellationToken)
		{
			return default(UniTask<HVBillingVo.PaymentStatusChangedResponse>);
		}

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0xC")]
		private IStoreProvider _store;
	}
}
