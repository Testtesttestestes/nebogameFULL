using System;
using BestHTTP;
using Gameplay.FeedbackForm.Service;
using Il2CppDummyDll;
using MVC;
using Utils;

namespace Gameplay.FeedbackForm.Model.Controll
{
	// Token: 0x02000827 RID: 2087
	[Token(Token = "0x2000827")]
	public class FeedbackFormController : AbstractController<FeedbackFormModel, FeedbackFormEvents>
	{
		// Token: 0x06003128 RID: 12584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x8181", Offset = "0x8181", VA = "0x8181", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003129")]
		[Address(RVA = "0x8182", Offset = "0x8182", VA = "0x8182")]
		public FeedbackFormController(FeedbackFormService service, FeedbackFormModel model, FeedbackFormEvents events)
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x8183", Offset = "0x8183", VA = "0x8183", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312B")]
		[Address(RVA = "0x8184", Offset = "0x8184", VA = "0x8184")]
		private void RequestSubmit(FeedbackThemeOption theme, string name, string email, string message)
		{
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312C")]
		[Address(RVA = "0x8185", Offset = "0x8185", VA = "0x8185")]
		private void HandleSubmitFormSuccess(OpToken<int, HTTPResponse> op)
		{
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x8186", Offset = "0x8186", VA = "0x8186")]
		private void HandleSubmitFormFailed(OpToken<int, HTTPResponse> op)
		{
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x1AE9", Offset = "0x1AE9", VA = "0x1AE9")]
		private string GetBase64ZipContent()
		{
			return null;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600312F")]
		[Address(RVA = "0x8187", Offset = "0x8187", VA = "0x8187")]
		public void SetCurrentTheme(FeedbackThemeOption theme)
		{
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6003130")]
		[Address(RVA = "0x8188", Offset = "0x8188", VA = "0x8188")]
		public bool TrySubmit(string name, string email, string message)
		{
			return default(bool);
		}

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x18")]
		private FeedbackFormService _service;
	}
}
