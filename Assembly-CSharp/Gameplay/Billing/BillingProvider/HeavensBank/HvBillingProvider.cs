using System;
using System.Runtime.InteropServices;
using System.Threading;
using Core.Gameplay;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;

namespace Gameplay.Billing.BillingProvider.HeavensBank
{
	// Token: 0x02000C1E RID: 3102
	[Token(Token = "0x2000C1E")]
	public class HvBillingProvider : IBillingProvider, IDisposable
	{
		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06004BBF RID: 19391 RVA: 0x0000DF80 File Offset: 0x0000C180
		[Token(Token = "0x17000F46")]
		public BillingProviderId ProviderId
		{
			[Token(Token = "0x6004BBF")]
			[Address(RVA = "0x9A05", Offset = "0x9A05", VA = "0x9A05", Slot = "4")]
			get
			{
				return BillingProviderId.Unknown;
			}
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x9A06", Offset = "0x9A06", VA = "0x9A06", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x9A07", Offset = "0x9A07", VA = "0x9A07")]
		public HvBillingProvider(IAuthTokenSource authTokenSource)
		{
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x9A08", Offset = "0x9A08", VA = "0x9A08", Slot = "5")]
		public void SetToken(string value)
		{
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x9A09", Offset = "0x9A09", VA = "0x9A09", Slot = "6")]
		public void GetBalance(Action<float> callback)
		{
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x9A0A", Offset = "0x9A0A", VA = "0x9A0A", Slot = "7")]
		public string GetCurrencyCode(AbstractBillingModel model)
		{
			return null;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x9A0B", Offset = "0x9A0B", VA = "0x9A0B", Slot = "8")]
		public void RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, [Optional] Action<HVBillingVo.PaymentStatusChangedResponse> callback)
		{
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x9A0C", Offset = "0x9A0C", VA = "0x9A0C", Slot = "9")]
		public UniTask<HVBillingVo.PaymentStatusChangedResponse> RunPurchase(AbstractBillingModel model, BankOptionData option, string developPayload, CancellationToken cancellationToken)
		{
			return default(UniTask<HVBillingVo.PaymentStatusChangedResponse>);
		}

		// Token: 0x0400293A RID: 10554
		[Token(Token = "0x400293A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IAuthTokenSource _authTokenSource;

		// Token: 0x0400293B RID: 10555
		[Token(Token = "0x400293B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string _currencyCode;
	}
}
