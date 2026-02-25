using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Cysharp.Threading.Tasks;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using HuaweiMobileServices.IAP;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE5 RID: 3045
	[Token(Token = "0x2000BE5")]
	public class HmsBillingModel : BillingModelForAppMarketWhitProducts
	{
		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x0000DC68 File Offset: 0x0000BE68
		[Token(Token = "0x17000F1C")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AC9")]
			[Address(RVA = "0x9926", Offset = "0x9926", VA = "0x9926", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Token(Token = "0x17000F1D")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004ACA")]
			[Address(RVA = "0x9927", Offset = "0x9927", VA = "0x9927", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004ACC RID: 19148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F1E")]
		public ProductInfo LastRequestedToPurchaseProduct
		{
			[Token(Token = "0x6004ACB")]
			[Address(RVA = "0x9928", Offset = "0x9928", VA = "0x9928")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ACC")]
			[Address(RVA = "0x9929", Offset = "0x9929", VA = "0x9929")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x992A", Offset = "0x992A", VA = "0x992A")]
		public HmsBillingModel(string storeName, IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x992B", Offset = "0x992B", VA = "0x992B", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
			return null;
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x992C", Offset = "0x992C", VA = "0x992C", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
			return default(bool);
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x992D", Offset = "0x992D", VA = "0x992D")]
		public void SetValidProducts(IList<ProductInfo> products)
		{
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x992E", Offset = "0x992E", VA = "0x992E")]
		public void AddValidProducts(IList<ProductInfo> products)
		{
		}

		// Token: 0x040028B4 RID: 10420
		[Token(Token = "0x40028B4")]
		[FieldOffset(Offset = "0x4C")]
		private readonly Dictionary<string, ProductInfo> _validExtPriceProducts;

		// Token: 0x040028B6 RID: 10422
		[Token(Token = "0x40028B6")]
		[FieldOffset(Offset = "0x54")]
		public readonly List<PurchaseDto> PurchasesAwaitRedeliveryProcess;

		// Token: 0x02000BE6 RID: 3046
		[Token(Token = "0x2000BE6")]
		public class RestoredProductDto
		{
			// Token: 0x06004AD2 RID: 19154 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AD2")]
			[Address(RVA = "0x992F", Offset = "0x992F", VA = "0x992F")]
			public RestoredProductDto(InAppPurchaseData productData, string sig, string rawJson)
			{
			}

			// Token: 0x040028B7 RID: 10423
			[Token(Token = "0x40028B7")]
			[FieldOffset(Offset = "0x8")]
			public readonly InAppPurchaseData ProductData;

			// Token: 0x040028B8 RID: 10424
			[Token(Token = "0x40028B8")]
			[FieldOffset(Offset = "0xC")]
			public readonly string Sig;

			// Token: 0x040028B9 RID: 10425
			[Token(Token = "0x40028B9")]
			[FieldOffset(Offset = "0x10")]
			public readonly string RawJson;
		}

		// Token: 0x02000BE7 RID: 3047
		[Token(Token = "0x2000BE7")]
		public class ReceiptProcessorVo
		{
			// Token: 0x06004AD3 RID: 19155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AD3")]
			[Address(RVA = "0x9930", Offset = "0x9930", VA = "0x9930")]
			public ReceiptProcessorVo(InAppPurchaseData product, string developerPayload, UniTaskCompletionSource<bool> completionSource)
			{
			}

			// Token: 0x040028BA RID: 10426
			[Token(Token = "0x40028BA")]
			[FieldOffset(Offset = "0x8")]
			public readonly InAppPurchaseData Product;

			// Token: 0x040028BB RID: 10427
			[Token(Token = "0x40028BB")]
			[FieldOffset(Offset = "0xC")]
			public readonly string DeveloperPayload;

			// Token: 0x040028BC RID: 10428
			[Token(Token = "0x40028BC")]
			[FieldOffset(Offset = "0x10")]
			public readonly UniTaskCompletionSource<bool> CompletionSource;
		}
	}
}
