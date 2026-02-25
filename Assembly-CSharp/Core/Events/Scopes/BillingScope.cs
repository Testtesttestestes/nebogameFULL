using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Services;

namespace Core.Events.Scopes
{
	// Token: 0x02000FD4 RID: 4052
	[Token(Token = "0x2000FD4")]
	public class BillingScope : AbstractEventBusScope
	{
		// Token: 0x060060B3 RID: 24755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B3")]
		[Address(RVA = "0xACDF", Offset = "0xACDF", VA = "0xACDF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B4")]
		[Address(RVA = "0xACE0", Offset = "0xACE0", VA = "0xACE0")]
		public BillingScope()
		{
		}

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0x8")]
		public Action<BillingScope.RequestProductsInfoArgs> InvalidProductsInfoEvent;

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0xC")]
		public Action<BillingScope.RequestProductsInfoArgs> RequestProductsErrorEvent;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0x10")]
		public Action<BillingScope.BuyOptionEventArgs> BuyOptionRequestInfoEvent;

		// Token: 0x040033A3 RID: 13219
		[Token(Token = "0x40033A3")]
		[FieldOffset(Offset = "0x14")]
		public Action<BillingScope.BuyOptionEventArgs> BuyOptionRequestMarketEvent;

		// Token: 0x040033A4 RID: 13220
		[Token(Token = "0x40033A4")]
		[FieldOffset(Offset = "0x18")]
		public Action<BillingScope.BuyOptionEventArgs> BuyOptionSuccessEvent;

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0x1C")]
		public Action<BillingScope.BuyOptionEventArgs> BuyOptionPendingPurchaseEvent;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x20")]
		public Action<BillingScope.BuyOptionEventArgs> BuyOptionCancelEvent;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x24")]
		public Action<BaseEventBusEventArgs> OnRestoreTransactionCompleteEvent;

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0x28")]
		public Action<BillingScope.BuyOptionErrorEventArgs> BuyOptionErrorEvent;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x2C")]
		public Action<BillingScope.PurchaseInfoEventArgs> PurchaseInfoEvent;

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x30")]
		public Action<BillingScope.CurrencyConverterErrorEventArgs> CurrencyConvertErrorEvent;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x34")]
		public Action<BillingScope.BuyOptionErrorEventArgs> PurchaseRequirementsErrorEvent;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x38")]
		public Action<BillingScope.BuyOptionEventArgs> ShowSelectBillingDialogEvent;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x3C")]
		public Action<BillingScope.BuyOptionEventArgs> ProviderSelectedEvent;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x40")]
		public Action<BillingScope.RefPayInfoEventArgs> RefPayEvent;

		// Token: 0x02000FD5 RID: 4053
		[Token(Token = "0x2000FD5")]
		public abstract class BaseBillingEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x060060B5 RID: 24757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060B5")]
			[Address(RVA = "0xACE1", Offset = "0xACE1", VA = "0xACE1")]
			protected BaseBillingEventArgs(IApp app, IGame game, BillingProviderId providerId)
			{
			}

			// Token: 0x060060B6 RID: 24758 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60060B6")]
			[Address(RVA = "0xACE2", Offset = "0xACE2", VA = "0xACE2", Slot = "4")]
			public override Dictionary<string, object> GetEventProperties()
			{
				return null;
			}

			// Token: 0x040033AF RID: 13231
			[Token(Token = "0x40033AF")]
			[FieldOffset(Offset = "0x10")]
			public readonly BillingProviderId ProviderId;
		}

		// Token: 0x02000FD6 RID: 4054
		[Token(Token = "0x2000FD6")]
		public class RequestProductsInfoArgs : BillingScope.BaseBillingEventArgs
		{
			// Token: 0x17001309 RID: 4873
			// (get) Token: 0x060060B7 RID: 24759 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001309")]
			public string Error
			{
				[Token(Token = "0x60060B7")]
				[Address(RVA = "0xACE3", Offset = "0xACE3", VA = "0xACE3")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700130A RID: 4874
			// (get) Token: 0x060060B8 RID: 24760 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700130A")]
			public IEnumerable<string> InvalidProducts
			{
				[Token(Token = "0x60060B8")]
				[Address(RVA = "0xACE4", Offset = "0xACE4", VA = "0xACE4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060060B9 RID: 24761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060B9")]
			[Address(RVA = "0xACE5", Offset = "0xACE5", VA = "0xACE5")]
			public RequestProductsInfoArgs(IApp app, IGame game, BillingProviderId providerId, string error, IEnumerable<string> invalidProducts)
			{
			}
		}

		// Token: 0x02000FD7 RID: 4055
		[Token(Token = "0x2000FD7")]
		public class BuyOptionEventArgs : BillingScope.BaseBillingEventArgs
		{
			// Token: 0x1700130B RID: 4875
			// (get) Token: 0x060060BA RID: 24762 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060BB RID: 24763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700130B")]
			[CanBeNull]
			public PurchaseDto Purchase
			{
				[Token(Token = "0x60060BA")]
				[Address(RVA = "0xACE6", Offset = "0xACE6", VA = "0xACE6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060BB")]
				[Address(RVA = "0xACE7", Offset = "0xACE7", VA = "0xACE7")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700130C RID: 4876
			// (get) Token: 0x060060BC RID: 24764 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060BD RID: 24765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700130C")]
			[CanBeNull]
			public string DevPayload
			{
				[Token(Token = "0x60060BC")]
				[Address(RVA = "0xACE8", Offset = "0xACE8", VA = "0xACE8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060BD")]
				[Address(RVA = "0xACE9", Offset = "0xACE9", VA = "0xACE9")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060060BE RID: 24766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060BE")]
			[Address(RVA = "0xACEA", Offset = "0xACEA", VA = "0xACEA")]
			public BuyOptionEventArgs(IApp app, IGame game, BillingProviderId providerId, BankOptionData bankOptionData)
			{
			}

			// Token: 0x040033B2 RID: 13234
			[Token(Token = "0x40033B2")]
			[FieldOffset(Offset = "0x14")]
			public readonly BankOptionData BankOptionData;
		}

		// Token: 0x02000FD8 RID: 4056
		[Token(Token = "0x2000FD8")]
		public class RefPayInfoEventArgs : BillingScope.BaseBillingEventArgs
		{
			// Token: 0x060060BF RID: 24767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060BF")]
			[Address(RVA = "0xACEB", Offset = "0xACEB", VA = "0xACEB")]
			public RefPayInfoEventArgs(IApp app, [NotNull] IGame game, BillingProviderId providerId, [NotNull] BankOptionData optionData, [NotNull] UserPayments userPayments)
			{
			}

			// Token: 0x060060C0 RID: 24768 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60060C0")]
			[Address(RVA = "0xACEC", Offset = "0xACEC", VA = "0xACEC", Slot = "4")]
			public override Dictionary<string, object> GetEventProperties()
			{
				return null;
			}

			// Token: 0x040033B5 RID: 13237
			[Token(Token = "0x40033B5")]
			[FieldOffset(Offset = "0x14")]
			public readonly UserPayments UserPayments;

			// Token: 0x040033B6 RID: 13238
			[Token(Token = "0x40033B6")]
			[FieldOffset(Offset = "0x18")]
			public readonly BankOptionData BankOptionData;
		}

		// Token: 0x02000FD9 RID: 4057
		[Token(Token = "0x2000FD9")]
		public class PurchaseInfoEventArgs : BillingScope.BuyOptionEventArgs
		{
			// Token: 0x060060C1 RID: 24769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060C1")]
			[Address(RVA = "0xACED", Offset = "0xACED", VA = "0xACED")]
			public PurchaseInfoEventArgs(IApp app, IGame game, BillingProviderId providerId, BankOptionData bankOptionData, float usdAmount)
			{
			}

			// Token: 0x040033B7 RID: 13239
			[Token(Token = "0x40033B7")]
			[FieldOffset(Offset = "0x20")]
			public readonly float UsdAmount;
		}

		// Token: 0x02000FDA RID: 4058
		[Token(Token = "0x2000FDA")]
		public class CurrencyConverterErrorEventArgs : BillingScope.BuyOptionEventArgs
		{
			// Token: 0x1700130D RID: 4877
			// (get) Token: 0x060060C2 RID: 24770 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060C3 RID: 24771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700130D")]
			public string Date
			{
				[Token(Token = "0x60060C2")]
				[Address(RVA = "0xACEE", Offset = "0xACEE", VA = "0xACEE")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060C3")]
				[Address(RVA = "0xACEF", Offset = "0xACEF", VA = "0xACEF")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700130E RID: 4878
			// (get) Token: 0x060060C4 RID: 24772 RVA: 0x000119B8 File Offset: 0x0000FBB8
			// (set) Token: 0x060060C5 RID: 24773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700130E")]
			public long Timestamp
			{
				[Token(Token = "0x60060C4")]
				[Address(RVA = "0xACF0", Offset = "0xACF0", VA = "0xACF0")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x60060C5")]
				[Address(RVA = "0xACF1", Offset = "0xACF1", VA = "0xACF1")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700130F RID: 4879
			// (get) Token: 0x060060C6 RID: 24774 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060C7 RID: 24775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700130F")]
			public string Code
			{
				[Token(Token = "0x60060C6")]
				[Address(RVA = "0xACF2", Offset = "0xACF2", VA = "0xACF2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060C7")]
				[Address(RVA = "0xACF3", Offset = "0xACF3", VA = "0xACF3")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060C8 RID: 24776 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060C8")]
			[Address(RVA = "0xACF4", Offset = "0xACF4", VA = "0xACF4")]
			public CurrencyConverterErrorEventArgs(IApp app, IGame game, BillingProviderId providerId, BankOptionData bankOptionData, string date, long timestamp, string code)
			{
			}
		}

		// Token: 0x02000FDB RID: 4059
		[Token(Token = "0x2000FDB")]
		public class BuyOptionErrorEventArgs : BillingScope.BuyOptionEventArgs
		{
			// Token: 0x17001310 RID: 4880
			// (get) Token: 0x060060C9 RID: 24777 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060060CA RID: 24778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001310")]
			public string ErrorMessage
			{
				[Token(Token = "0x60060C9")]
				[Address(RVA = "0xACF5", Offset = "0xACF5", VA = "0xACF5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60060CA")]
				[Address(RVA = "0xACF6", Offset = "0xACF6", VA = "0xACF6")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001311 RID: 4881
			// (get) Token: 0x060060CB RID: 24779 RVA: 0x000119D0 File Offset: 0x0000FBD0
			// (set) Token: 0x060060CC RID: 24780 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001311")]
			public int ErrorCode
			{
				[Token(Token = "0x60060CB")]
				[Address(RVA = "0xACF7", Offset = "0xACF7", VA = "0xACF7")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60060CC")]
				[Address(RVA = "0xACF8", Offset = "0xACF8", VA = "0xACF8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060060CD RID: 24781 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60060CD")]
			[Address(RVA = "0xACF9", Offset = "0xACF9", VA = "0xACF9")]
			public BuyOptionErrorEventArgs(IApp app, IGame game, BillingProviderId providerId, BankOptionData bankOptionData, int errorCode, string errorMessage)
			{
			}
		}
	}
}
