using System;
using System.Collections.Generic;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Billing.BillingProvider.Receipts
{
	// Token: 0x02000C13 RID: 3091
	[Token(Token = "0x2000C13")]
	public class ReceiptProcessorService : AbstractHTTPService
	{
		// Token: 0x06004BAC RID: 19372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x99F2", Offset = "0x99F2", VA = "0x99F2")]
		public ReceiptProcessorService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BAD")]
		[Address(RVA = "0x99F3", Offset = "0x99F3", VA = "0x99F3")]
		public OpToken<StoreReceiptProcessorResponse, HTTPResponse> SubmitReceipt(IDictionary<string, string> data)
		{
			return null;
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAE")]
		[Address(RVA = "0x99F4", Offset = "0x99F4", VA = "0x99F4")]
		private void SubmitReceiptInternal(OpToken<StoreReceiptProcessorResponse, HTTPResponse> token, IDictionary<string, string> data)
		{
		}
	}
}
