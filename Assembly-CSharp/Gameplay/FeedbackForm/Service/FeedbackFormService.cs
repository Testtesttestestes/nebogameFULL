using System;
using BestHTTP;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.FeedbackForm.Service
{
	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	public class FeedbackFormService : AbstractHTTPService
	{
		// Token: 0x060030E3 RID: 12515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x8146", Offset = "0x8146", VA = "0x8146")]
		public FeedbackFormService(Uri uri, IAuthTokenSource authTokenSource, TimeSpan timeout)
		{
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x8147", Offset = "0x8147", VA = "0x8147")]
		public OpToken<int, HTTPResponse> SubmitForm(ServiceMessages.FeedbackFormMessage message)
		{
			return null;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x1AED", Offset = "0x1AED", VA = "0x1AED")]
		private void SubmitFormInternal(OpToken<int, HTTPResponse> token, ServiceMessages.FeedbackFormMessage message)
		{
		}
	}
}
