using System;
using Cysharp.Threading.Tasks;
using Gameplay.FeedbackForm.View;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.FeedbackForm.Model.Controll
{
	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	public class FeedbackFormViewMediator : AbstractViewMediator<FeedbackFormModel, FeedbackFormEvents, FeedbackFormController, FeedbackFormView>
	{
		// Token: 0x06003131 RID: 12593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x8189", Offset = "0x8189", VA = "0x8189")]
		public FeedbackFormViewMediator(FeedbackFormModel model, FeedbackFormEvents events, FeedbackFormController controller)
		{
		}

		// Token: 0x170009B0 RID: 2480
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B0")]
		public override FeedbackFormEvents Events
		{
			[Token(Token = "0x6003132")]
			[Address(RVA = "0x818A", Offset = "0x818A", VA = "0x818A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B1")]
		public override FeedbackFormView View
		{
			[Token(Token = "0x6003133")]
			[Address(RVA = "0x818B", Offset = "0x818B", VA = "0x818B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6003134")]
		[Address(RVA = "0x818C", Offset = "0x818C", VA = "0x818C")]
		private UniTask<bool> HandleCloseFormRequestEvent(FeedbackFormWindow form)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003135")]
		[Address(RVA = "0x818D", Offset = "0x818D", VA = "0x818D")]
		private void SetupView()
		{
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003136")]
		[Address(RVA = "0x818E", Offset = "0x818E", VA = "0x818E")]
		private void HandleSubmitClickEvent()
		{
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003137")]
		[Address(RVA = "0x818F", Offset = "0x818F", VA = "0x818F")]
		private void HandleThemeValueChangedEvent(int index)
		{
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003138")]
		[Address(RVA = "0x8190", Offset = "0x8190", VA = "0x8190")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003139")]
		[Address(RVA = "0x8191", Offset = "0x8191", VA = "0x8191")]
		private void HandleStartRequestEvent()
		{
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313A")]
		[Address(RVA = "0x8192", Offset = "0x8192", VA = "0x8192")]
		private void HandleFinishRequestEvent()
		{
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313B")]
		[Address(RVA = "0x8193", Offset = "0x8193", VA = "0x8193")]
		private void HandleFormErrorEvent(string text)
		{
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313C")]
		[Address(RVA = "0x8194", Offset = "0x8194", VA = "0x8194")]
		private void HandleSubmitCompleteEvent(string text)
		{
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313D")]
		[Address(RVA = "0x8195", Offset = "0x8195", VA = "0x8195")]
		private void HandleSubmitCompleteSuccessEvent()
		{
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600313E")]
		[Address(RVA = "0x8196", Offset = "0x8196", VA = "0x8196")]
		private void ShowCloseWarning(FeedbackFormWindow feedbackFormWindow, UniTaskCompletionSource<bool> completionSource)
		{
		}

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x18")]
		private DialogWindow _submitDialogWindow;
	}
}
