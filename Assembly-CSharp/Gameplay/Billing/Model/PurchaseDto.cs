using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE9 RID: 3049
	[Token(Token = "0x2000BE9")]
	public class PurchaseDto
	{
		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06004ADA RID: 19162 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		// (set) Token: 0x06004ADB RID: 19163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F21")]
		public bool IsFailed
		{
			[Token(Token = "0x6004ADA")]
			[Address(RVA = "0x9937", Offset = "0x9937", VA = "0x9937")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004ADB")]
			[Address(RVA = "0x9938", Offset = "0x9938", VA = "0x9938")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06004ADC RID: 19164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004ADD RID: 19165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F22")]
		public string FailureReason
		{
			[Token(Token = "0x6004ADC")]
			[Address(RVA = "0x9939", Offset = "0x9939", VA = "0x9939")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004ADD")]
			[Address(RVA = "0x993A", Offset = "0x993A", VA = "0x993A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06004ADE RID: 19166 RVA: 0x0000DD10 File Offset: 0x0000BF10
		// (set) Token: 0x06004ADF RID: 19167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F23")]
		public int FailureReasonCode
		{
			[Token(Token = "0x6004ADE")]
			[Address(RVA = "0x993B", Offset = "0x993B", VA = "0x993B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004ADF")]
			[Address(RVA = "0x993C", Offset = "0x993C", VA = "0x993C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x993D", Offset = "0x993D", VA = "0x993D")]
		public PurchaseDto(PurchaseDto.ProductInfo product)
		{
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x993E", Offset = "0x993E", VA = "0x993E")]
		public PurchaseDto(PurchaseDto.ProductInfo product, string orderId)
		{
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x993F", Offset = "0x993F", VA = "0x993F")]
		public void SetFailureReason(string value)
		{
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x9940", Offset = "0x9940", VA = "0x9940")]
		public void SetFailureReasonCode(int value)
		{
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x9941", Offset = "0x9941", VA = "0x9941", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040028BD RID: 10429
		[Token(Token = "0x40028BD")]
		[FieldOffset(Offset = "0x8")]
		public readonly PurchaseDto.ProductInfo Product;

		// Token: 0x040028C1 RID: 10433
		[Token(Token = "0x40028C1")]
		[FieldOffset(Offset = "0x18")]
		[CanBeNull]
		public readonly string OrderId;

		// Token: 0x02000BEA RID: 3050
		[Token(Token = "0x2000BEA")]
		public class ProductInfo
		{
			// Token: 0x06004AE5 RID: 19173 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004AE5")]
			[Address(RVA = "0x9942", Offset = "0x9942", VA = "0x9942")]
			public ProductInfo(string id, double price, string currencyCode)
			{
			}

			// Token: 0x040028C2 RID: 10434
			[Token(Token = "0x40028C2")]
			[FieldOffset(Offset = "0x8")]
			public readonly string Id;

			// Token: 0x040028C3 RID: 10435
			[Token(Token = "0x40028C3")]
			[FieldOffset(Offset = "0xC")]
			public readonly string CurrencyCode;

			// Token: 0x040028C4 RID: 10436
			[Token(Token = "0x40028C4")]
			[FieldOffset(Offset = "0x10")]
			public readonly double Price;
		}
	}
}
