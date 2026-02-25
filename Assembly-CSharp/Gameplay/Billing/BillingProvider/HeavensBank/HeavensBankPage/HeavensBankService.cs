using System;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Billing.BillingProvider.HeavensBank.HeavensBankPage
{
	// Token: 0x02000C25 RID: 3109
	[Token(Token = "0x2000C25")]
	public class HeavensBankService : AbstractHTTPService
	{
		// Token: 0x06004BDF RID: 19423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDF")]
		[Address(RVA = "0x9A23", Offset = "0x9A23", VA = "0x9A23")]
		public HeavensBankService(IAuthTokenSource authTokenSource, Uri uri, TimeSpan timeout)
		{
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BE0")]
		[Address(RVA = "0x9A24", Offset = "0x9A24", VA = "0x9A24")]
		public OpToken<HVBillingVo.GetBalanceResponse, HTTPResponse> GetBalance()
		{
			return null;
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x9A25", Offset = "0x9A25", VA = "0x9A25")]
		public OpToken<HVBillingVo.DrawMoneyResponse, HTTPResponse> DrawMoney(string optionsJson)
		{
			return null;
		}

		// Token: 0x04002951 RID: 10577
		[Token(Token = "0x4002951")]
		public const string GET_BALANCE_ACTION_VALUE = "getbalance";

		// Token: 0x04002952 RID: 10578
		[Token(Token = "0x4002952")]
		public const string DRAW_MONEY_ACTION_VALUE = "drawmoney";
	}
}
