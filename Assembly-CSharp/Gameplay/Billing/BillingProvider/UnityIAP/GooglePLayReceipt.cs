using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Gameplay.Billing.BillingProvider.UnityIAP
{
	// Token: 0x02000C01 RID: 3073
	[Token(Token = "0x2000C01")]
	public sealed class GooglePLayReceipt
	{
		// Token: 0x06004B35 RID: 19253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x9988", Offset = "0x9988", VA = "0x9988")]
		private GooglePLayReceipt(string store, string transactionId, GooglePLayReceipt.PurchaseData purchase, string signature, IReadOnlyCollection<GooglePLayReceipt.SkuDetail> skuDetails)
		{
		}

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Store;

		// Token: 0x040028E2 RID: 10466
		[Token(Token = "0x40028E2")]
		[FieldOffset(Offset = "0xC")]
		public readonly string TransactionID;

		// Token: 0x040028E3 RID: 10467
		[Token(Token = "0x40028E3")]
		[FieldOffset(Offset = "0x10")]
		public readonly GooglePLayReceipt.PurchaseData Purchase;

		// Token: 0x040028E4 RID: 10468
		[Token(Token = "0x40028E4")]
		[FieldOffset(Offset = "0x14")]
		public readonly string Signature;

		// Token: 0x040028E5 RID: 10469
		[Token(Token = "0x40028E5")]
		[FieldOffset(Offset = "0x18")]
		public readonly IReadOnlyCollection<GooglePLayReceipt.SkuDetail> SkuDetails;

		// Token: 0x02000C02 RID: 3074
		[Token(Token = "0x2000C02")]
		private class RootObject
		{
			// Token: 0x17000F2A RID: 3882
			// (get) Token: 0x06004B36 RID: 19254 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B37 RID: 19255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F2A")]
			[JsonProperty("Payload")]
			public string Payload
			{
				[Token(Token = "0x6004B36")]
				[Address(RVA = "0x9989", Offset = "0x9989", VA = "0x9989")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B37")]
				[Address(RVA = "0x998A", Offset = "0x998A", VA = "0x998A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F2B RID: 3883
			// (get) Token: 0x06004B38 RID: 19256 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B39 RID: 19257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F2B")]
			[JsonProperty("Store")]
			public string Store
			{
				[Token(Token = "0x6004B38")]
				[Address(RVA = "0x998B", Offset = "0x998B", VA = "0x998B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B39")]
				[Address(RVA = "0x998C", Offset = "0x998C", VA = "0x998C")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F2C RID: 3884
			// (get) Token: 0x06004B3A RID: 19258 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B3B RID: 19259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F2C")]
			[JsonProperty("TransactionID")]
			public string TransactionID
			{
				[Token(Token = "0x6004B3A")]
				[Address(RVA = "0x998D", Offset = "0x998D", VA = "0x998D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B3B")]
				[Address(RVA = "0x998E", Offset = "0x998E", VA = "0x998E")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004B3C RID: 19260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004B3C")]
			[Address(RVA = "0x998F", Offset = "0x998F", VA = "0x998F")]
			public RootObject()
			{
			}
		}

		// Token: 0x02000C03 RID: 3075
		[Token(Token = "0x2000C03")]
		private class PayloadData
		{
			// Token: 0x17000F2D RID: 3885
			// (get) Token: 0x06004B3D RID: 19261 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B3E RID: 19262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F2D")]
			[JsonProperty("json")]
			public string Json
			{
				[Token(Token = "0x6004B3D")]
				[Address(RVA = "0x9990", Offset = "0x9990", VA = "0x9990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B3E")]
				[Address(RVA = "0x9991", Offset = "0x9991", VA = "0x9991")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F2E RID: 3886
			// (get) Token: 0x06004B3F RID: 19263 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B40 RID: 19264 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F2E")]
			[JsonProperty("signature")]
			public string Signature
			{
				[Token(Token = "0x6004B3F")]
				[Address(RVA = "0x9992", Offset = "0x9992", VA = "0x9992")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B40")]
				[Address(RVA = "0x9993", Offset = "0x9993", VA = "0x9993")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F2F RID: 3887
			// (get) Token: 0x06004B41 RID: 19265 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B42 RID: 19266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F2F")]
			[JsonProperty("skuDetails")]
			public List<string> SkuDetails
			{
				[Token(Token = "0x6004B41")]
				[Address(RVA = "0x9994", Offset = "0x9994", VA = "0x9994")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B42")]
				[Address(RVA = "0x9995", Offset = "0x9995", VA = "0x9995")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004B43 RID: 19267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004B43")]
			[Address(RVA = "0x9996", Offset = "0x9996", VA = "0x9996")]
			public PayloadData()
			{
			}
		}

		// Token: 0x02000C04 RID: 3076
		[Token(Token = "0x2000C04")]
		public class PurchaseData
		{
			// Token: 0x17000F30 RID: 3888
			// (get) Token: 0x06004B44 RID: 19268 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B45 RID: 19269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F30")]
			[JsonProperty("orderId")]
			public string OrderId
			{
				[Token(Token = "0x6004B44")]
				[Address(RVA = "0x9997", Offset = "0x9997", VA = "0x9997")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B45")]
				[Address(RVA = "0x9998", Offset = "0x9998", VA = "0x9998")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F31 RID: 3889
			// (get) Token: 0x06004B46 RID: 19270 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B47 RID: 19271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F31")]
			[JsonProperty("packageName")]
			public string PackageName
			{
				[Token(Token = "0x6004B46")]
				[Address(RVA = "0x9999", Offset = "0x9999", VA = "0x9999")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B47")]
				[Address(RVA = "0x999A", Offset = "0x999A", VA = "0x999A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F32 RID: 3890
			// (get) Token: 0x06004B48 RID: 19272 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B49 RID: 19273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F32")]
			[JsonProperty("productId")]
			public string ProductId
			{
				[Token(Token = "0x6004B48")]
				[Address(RVA = "0x999B", Offset = "0x999B", VA = "0x999B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B49")]
				[Address(RVA = "0x999C", Offset = "0x999C", VA = "0x999C")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F33 RID: 3891
			// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0000DE78 File Offset: 0x0000C078
			// (set) Token: 0x06004B4B RID: 19275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F33")]
			[JsonProperty("purchaseTime")]
			public long PurchaseTime
			{
				[Token(Token = "0x6004B4A")]
				[Address(RVA = "0x999D", Offset = "0x999D", VA = "0x999D")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6004B4B")]
				[Address(RVA = "0x999E", Offset = "0x999E", VA = "0x999E")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F34 RID: 3892
			// (get) Token: 0x06004B4C RID: 19276 RVA: 0x0000DE90 File Offset: 0x0000C090
			// (set) Token: 0x06004B4D RID: 19277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F34")]
			[JsonProperty("purchaseState")]
			public int PurchaseState
			{
				[Token(Token = "0x6004B4C")]
				[Address(RVA = "0x999F", Offset = "0x999F", VA = "0x999F")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004B4D")]
				[Address(RVA = "0x99A0", Offset = "0x99A0", VA = "0x99A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F35 RID: 3893
			// (get) Token: 0x06004B4E RID: 19278 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B4F RID: 19279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F35")]
			[JsonProperty("purchaseToken")]
			public string PurchaseToken
			{
				[Token(Token = "0x6004B4E")]
				[Address(RVA = "0x99A1", Offset = "0x99A1", VA = "0x99A1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B4F")]
				[Address(RVA = "0x99A2", Offset = "0x99A2", VA = "0x99A2")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F36 RID: 3894
			// (get) Token: 0x06004B50 RID: 19280 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
			// (set) Token: 0x06004B51 RID: 19281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F36")]
			[JsonProperty("quantity")]
			public int Quantity
			{
				[Token(Token = "0x6004B50")]
				[Address(RVA = "0x99A3", Offset = "0x99A3", VA = "0x99A3")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6004B51")]
				[Address(RVA = "0x99A4", Offset = "0x99A4", VA = "0x99A4")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F37 RID: 3895
			// (get) Token: 0x06004B52 RID: 19282 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
			// (set) Token: 0x06004B53 RID: 19283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F37")]
			[JsonProperty("acknowledged")]
			public bool Acknowledged
			{
				[Token(Token = "0x6004B52")]
				[Address(RVA = "0x99A5", Offset = "0x99A5", VA = "0x99A5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6004B53")]
				[Address(RVA = "0x99A6", Offset = "0x99A6", VA = "0x99A6")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004B54 RID: 19284 RVA: 0x0000DED8 File Offset: 0x0000C0D8
			[Token(Token = "0x6004B54")]
			[Address(RVA = "0x99A7", Offset = "0x99A7", VA = "0x99A7")]
			public uint GetProductId()
			{
				return 0U;
			}

			// Token: 0x17000F38 RID: 3896
			// (get) Token: 0x06004B55 RID: 19285 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B56 RID: 19286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F38")]
			public string Raw
			{
				[Token(Token = "0x6004B55")]
				[Address(RVA = "0x99A8", Offset = "0x99A8", VA = "0x99A8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B56")]
				[Address(RVA = "0x99A9", Offset = "0x99A9", VA = "0x99A9")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004B57 RID: 19287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004B57")]
			[Address(RVA = "0x99AA", Offset = "0x99AA", VA = "0x99AA")]
			public PurchaseData()
			{
			}
		}

		// Token: 0x02000C05 RID: 3077
		[Token(Token = "0x2000C05")]
		public class SkuDetail
		{
			// Token: 0x17000F39 RID: 3897
			// (get) Token: 0x06004B58 RID: 19288 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B59 RID: 19289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F39")]
			[JsonProperty("productId")]
			public string ProductId
			{
				[Token(Token = "0x6004B58")]
				[Address(RVA = "0x99AB", Offset = "0x99AB", VA = "0x99AB")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B59")]
				[Address(RVA = "0x99AC", Offset = "0x99AC", VA = "0x99AC")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F3A RID: 3898
			// (get) Token: 0x06004B5A RID: 19290 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B5B RID: 19291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F3A")]
			[JsonProperty("type")]
			public string Type
			{
				[Token(Token = "0x6004B5A")]
				[Address(RVA = "0x99AD", Offset = "0x99AD", VA = "0x99AD")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B5B")]
				[Address(RVA = "0x99AE", Offset = "0x99AE", VA = "0x99AE")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F3B RID: 3899
			// (get) Token: 0x06004B5C RID: 19292 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B5D RID: 19293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F3B")]
			[JsonProperty("title")]
			public string Title
			{
				[Token(Token = "0x6004B5C")]
				[Address(RVA = "0x99AF", Offset = "0x99AF", VA = "0x99AF")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B5D")]
				[Address(RVA = "0x99B0", Offset = "0x99B0", VA = "0x99B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F3C RID: 3900
			// (get) Token: 0x06004B5E RID: 19294 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B5F RID: 19295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F3C")]
			[JsonProperty("name")]
			public string Name
			{
				[Token(Token = "0x6004B5E")]
				[Address(RVA = "0x99B1", Offset = "0x99B1", VA = "0x99B1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B5F")]
				[Address(RVA = "0x99B2", Offset = "0x99B2", VA = "0x99B2")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F3D RID: 3901
			// (get) Token: 0x06004B60 RID: 19296 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B61 RID: 19297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F3D")]
			[JsonProperty("description")]
			public string Description
			{
				[Token(Token = "0x6004B60")]
				[Address(RVA = "0x99B3", Offset = "0x99B3", VA = "0x99B3")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B61")]
				[Address(RVA = "0x99B4", Offset = "0x99B4", VA = "0x99B4")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F3E RID: 3902
			// (get) Token: 0x06004B62 RID: 19298 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B63 RID: 19299 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F3E")]
			[JsonProperty("price")]
			public string Price
			{
				[Token(Token = "0x6004B62")]
				[Address(RVA = "0x99B5", Offset = "0x99B5", VA = "0x99B5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B63")]
				[Address(RVA = "0x99B6", Offset = "0x99B6", VA = "0x99B6")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F3F RID: 3903
			// (get) Token: 0x06004B64 RID: 19300 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
			// (set) Token: 0x06004B65 RID: 19301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F3F")]
			[JsonProperty("price_amount_micros")]
			public long PriceAmountMicros
			{
				[Token(Token = "0x6004B64")]
				[Address(RVA = "0x99B7", Offset = "0x99B7", VA = "0x99B7")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6004B65")]
				[Address(RVA = "0x99B8", Offset = "0x99B8", VA = "0x99B8")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000F40 RID: 3904
			// (get) Token: 0x06004B66 RID: 19302 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06004B67 RID: 19303 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000F40")]
			[JsonProperty("price_currency_code")]
			public string PriceCurrencyCode
			{
				[Token(Token = "0x6004B66")]
				[Address(RVA = "0x99B9", Offset = "0x99B9", VA = "0x99B9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6004B67")]
				[Address(RVA = "0x99BA", Offset = "0x99BA", VA = "0x99BA")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06004B68 RID: 19304 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004B68")]
			[Address(RVA = "0x99BB", Offset = "0x99BB", VA = "0x99BB")]
			public SkuDetail()
			{
			}
		}

		// Token: 0x02000C06 RID: 3078
		[Token(Token = "0x2000C06")]
		public sealed class Builder
		{
			// Token: 0x06004B69 RID: 19305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004B69")]
			[Address(RVA = "0x99BC", Offset = "0x99BC", VA = "0x99BC")]
			public Builder(string source)
			{
			}

			// Token: 0x06004B6A RID: 19306 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004B6A")]
			[Address(RVA = "0x99BD", Offset = "0x99BD", VA = "0x99BD")]
			public GooglePLayReceipt Build()
			{
				return null;
			}

			// Token: 0x040028FD RID: 10493
			[Token(Token = "0x40028FD")]
			[FieldOffset(Offset = "0x8")]
			private readonly string _source;
		}
	}
}
