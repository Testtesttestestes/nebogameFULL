using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Billing.BillingProvider.HeavensBank
{
	// Token: 0x02000C17 RID: 3095
	[Token(Token = "0x2000C17")]
	public static class HVBillingVo
	{
		// Token: 0x02000C18 RID: 3096
		[Token(Token = "0x2000C18")]
		[Serializable]
		public class GetBalanceResponse
		{
			// Token: 0x06004BB3 RID: 19379 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004BB3")]
			[Address(RVA = "0x99F9", Offset = "0x99F9", VA = "0x99F9", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004BB4 RID: 19380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BB4")]
			[Address(RVA = "0x99FA", Offset = "0x99FA", VA = "0x99FA")]
			public GetBalanceResponse()
			{
			}

			// Token: 0x04002925 RID: 10533
			[Token(Token = "0x4002925")]
			[FieldOffset(Offset = "0x8")]
			public int error_code;

			// Token: 0x04002926 RID: 10534
			[Token(Token = "0x4002926")]
			[FieldOffset(Offset = "0xC")]
			public string currency;

			// Token: 0x04002927 RID: 10535
			[Token(Token = "0x4002927")]
			[FieldOffset(Offset = "0x10")]
			public float balance;

			// Token: 0x04002928 RID: 10536
			[Token(Token = "0x4002928")]
			[FieldOffset(Offset = "0x14")]
			public string message;
		}

		// Token: 0x02000C19 RID: 3097
		[Token(Token = "0x2000C19")]
		[Serializable]
		public class OptionItemRequest
		{
			// Token: 0x06004BB5 RID: 19381 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004BB5")]
			[Address(RVA = "0x99FB", Offset = "0x99FB", VA = "0x99FB", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004BB6 RID: 19382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BB6")]
			[Address(RVA = "0x99FC", Offset = "0x99FC", VA = "0x99FC")]
			public OptionItemRequest()
			{
			}

			// Token: 0x04002929 RID: 10537
			[Token(Token = "0x4002929")]
			[FieldOffset(Offset = "0x8")]
			public uint service_id;

			// Token: 0x0400292A RID: 10538
			[Token(Token = "0x400292A")]
			[FieldOffset(Offset = "0xC")]
			public string service_name;

			// Token: 0x0400292B RID: 10539
			[Token(Token = "0x400292B")]
			[FieldOffset(Offset = "0x10")]
			public double other_price;

			// Token: 0x0400292C RID: 10540
			[Token(Token = "0x400292C")]
			[FieldOffset(Offset = "0x18")]
			public string currency_code;

			// Token: 0x0400292D RID: 10541
			[Token(Token = "0x400292D")]
			[FieldOffset(Offset = "0x1C")]
			public bool isPromo;
		}

		// Token: 0x02000C1A RID: 3098
		[Token(Token = "0x2000C1A")]
		[Serializable]
		public class DrawMoneyResponse
		{
			// Token: 0x06004BB7 RID: 19383 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004BB7")]
			[Address(RVA = "0x99FD", Offset = "0x99FD", VA = "0x99FD", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004BB8 RID: 19384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BB8")]
			[Address(RVA = "0x99FE", Offset = "0x99FE", VA = "0x99FE")]
			public DrawMoneyResponse()
			{
			}

			// Token: 0x0400292E RID: 10542
			[Token(Token = "0x400292E")]
			[FieldOffset(Offset = "0x8")]
			public bool Result;
		}

		// Token: 0x02000C1B RID: 3099
		[Token(Token = "0x2000C1B")]
		[Serializable]
		public class OpenPaymentWindowRequestPurchase
		{
			// Token: 0x06004BB9 RID: 19385 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004BB9")]
			[Address(RVA = "0x99FF", Offset = "0x99FF", VA = "0x99FF", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004BBA RID: 19386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BBA")]
			[Address(RVA = "0x9A00", Offset = "0x9A00", VA = "0x9A00")]
			public OpenPaymentWindowRequestPurchase()
			{
			}

			// Token: 0x0400292F RID: 10543
			[Token(Token = "0x400292F")]
			[FieldOffset(Offset = "0x8")]
			public double amount;

			// Token: 0x04002930 RID: 10544
			[Token(Token = "0x4002930")]
			[FieldOffset(Offset = "0x10")]
			public string currency;
		}

		// Token: 0x02000C1C RID: 3100
		[Token(Token = "0x2000C1C")]
		[Serializable]
		public class PaymentStatusChangedResponse
		{
			// Token: 0x06004BBB RID: 19387 RVA: 0x0000DF68 File Offset: 0x0000C168
			[Token(Token = "0x6004BBB")]
			[Address(RVA = "0x9A01", Offset = "0x9A01", VA = "0x9A01")]
			public HVBillingVo.PaymentStatusChangedResponse.Status GetStatus()
			{
				return HVBillingVo.PaymentStatusChangedResponse.Status.Unknown;
			}

			// Token: 0x06004BBC RID: 19388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BBC")]
			[Address(RVA = "0x9A02", Offset = "0x9A02", VA = "0x9A02")]
			public void SetStatus(HVBillingVo.PaymentStatusChangedResponse.Status value)
			{
			}

			// Token: 0x06004BBD RID: 19389 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6004BBD")]
			[Address(RVA = "0x9A03", Offset = "0x9A03", VA = "0x9A03", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004BBE RID: 19390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004BBE")]
			[Address(RVA = "0x9A04", Offset = "0x9A04", VA = "0x9A04")]
			public PaymentStatusChangedResponse()
			{
			}

			// Token: 0x04002931 RID: 10545
			[Token(Token = "0x4002931")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string status;

			// Token: 0x04002932 RID: 10546
			[Token(Token = "0x4002932")]
			[FieldOffset(Offset = "0xC")]
			public string result;

			// Token: 0x04002933 RID: 10547
			[Token(Token = "0x4002933")]
			[FieldOffset(Offset = "0x10")]
			public string info;

			// Token: 0x02000C1D RID: 3101
			[Token(Token = "0x2000C1D")]
			public enum Status
			{
				// Token: 0x04002935 RID: 10549
				[Token(Token = "0x4002935")]
				Unknown,
				// Token: 0x04002936 RID: 10550
				[Token(Token = "0x4002936")]
				Success,
				// Token: 0x04002937 RID: 10551
				[Token(Token = "0x4002937")]
				Cancel,
				// Token: 0x04002938 RID: 10552
				[Token(Token = "0x4002938")]
				Fail,
				// Token: 0x04002939 RID: 10553
				[Token(Token = "0x4002939")]
				Pending
			}
		}
	}
}
