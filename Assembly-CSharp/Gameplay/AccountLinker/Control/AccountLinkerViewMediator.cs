using System;
using Gameplay.AccountLinker.Model;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.AccountLinker.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using Protocol.Common;
using UnityEngine.EventSystems;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E21 RID: 3617
	[Token(Token = "0x2000E21")]
	public class AccountLinkerViewMediator : AbstractViewMediator<AccountLinkerModel, AccountLinkerEvents, AccountLinkerController, AccountLinkerView>
	{
		// Token: 0x06005834 RID: 22580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005834")]
		[Address(RVA = "0xA5A3", Offset = "0xA5A3", VA = "0xA5A3", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005835")]
		[Address(RVA = "0xA5A4", Offset = "0xA5A4", VA = "0xA5A4")]
		public AccountLinkerViewMediator(AccountLinkerModel model, AccountLinkerEvents events, AccountLinkerController controller)
		{
		}

		// Token: 0x170011F6 RID: 4598
		// (set) Token: 0x06005836 RID: 22582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F6")]
		public override AccountLinkerEvents Events
		{
			[Token(Token = "0x6005836")]
			[Address(RVA = "0xA5A5", Offset = "0xA5A5", VA = "0xA5A5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (set) Token: 0x06005837 RID: 22583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F7")]
		public override AccountLinkerView View
		{
			[Token(Token = "0x6005837")]
			[Address(RVA = "0xA5A6", Offset = "0xA5A6", VA = "0xA5A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005838")]
		[Address(RVA = "0xA5A7", Offset = "0xA5A7", VA = "0xA5A7")]
		private void HandleSetupView()
		{
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005839")]
		[Address(RVA = "0xA5A8", Offset = "0xA5A8", VA = "0xA5A8")]
		private void UpdateSigninState()
		{
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600583A")]
		[Address(RVA = "0xA5A9", Offset = "0xA5A9", VA = "0xA5A9")]
		public RefAccountInfo GetAnyUserLinkedProvider(params Provider[] providers)
		{
			return null;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583B")]
		[Address(RVA = "0xA5AA", Offset = "0xA5AA", VA = "0xA5AA")]
		private void UpdateTabs()
		{
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583C")]
		[Address(RVA = "0xA5AB", Offset = "0xA5AB", VA = "0xA5AB")]
		private void ShowCodeWindow(string code)
		{
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583D")]
		[Address(RVA = "0xA5AC", Offset = "0xA5AC", VA = "0xA5AC")]
		private void HandleOnCloseCodeDisplayWindow()
		{
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583E")]
		[Address(RVA = "0xA5AD", Offset = "0xA5AD", VA = "0xA5AD")]
		private void CloseCodeWindow()
		{
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583F")]
		[Address(RVA = "0xA5AE", Offset = "0xA5AE", VA = "0xA5AE")]
		private void ShowSelectUserWindow()
		{
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005840")]
		[Address(RVA = "0xA5AF", Offset = "0xA5AF", VA = "0xA5AF")]
		private void HandleOnCloseSelectUserWindow()
		{
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005841")]
		[Address(RVA = "0xA5B0", Offset = "0xA5B0", VA = "0xA5B0")]
		private void CloseSelectUserWindow()
		{
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005842")]
		[Address(RVA = "0xA5B1", Offset = "0xA5B1", VA = "0xA5B1")]
		private void HandleSetUserSuccessEvent()
		{
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005843")]
		[Address(RVA = "0xA5B2", Offset = "0xA5B2", VA = "0xA5B2")]
		private void HandleStartResolveAdditionalUsersEvent()
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005844")]
		[Address(RVA = "0xA5B3", Offset = "0xA5B3", VA = "0xA5B3")]
		private void HandleSetEmailErrorEvent(int errorCode)
		{
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005845")]
		[Address(RVA = "0xA5B4", Offset = "0xA5B4", VA = "0xA5B4")]
		private void LinkageProcessSuccessEvent()
		{
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005846")]
		[Address(RVA = "0xA5B5", Offset = "0xA5B5", VA = "0xA5B5")]
		private void HandleSigninTargetProviderSuccessEvent()
		{
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005847")]
		[Address(RVA = "0xA5B6", Offset = "0xA5B6", VA = "0xA5B6")]
		private void HandleSigninTargetProviderFailedEvent()
		{
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005848")]
		[Address(RVA = "0xA5B7", Offset = "0xA5B7", VA = "0xA5B7")]
		private void HandleTokenGetErrorEvent(OTPTokenGenCmd.Types.Result obj)
		{
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005849")]
		[Address(RVA = "0xA5B8", Offset = "0xA5B8", VA = "0xA5B8")]
		private void HandleCodeReadyEvent(string code)
		{
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584A")]
		[Address(RVA = "0xA5B9", Offset = "0xA5B9", VA = "0xA5B9")]
		private void HandleOnClickHowGetCodeText(PointerEventData obj)
		{
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584B")]
		[Address(RVA = "0xA5BA", Offset = "0xA5BA", VA = "0xA5BA")]
		private void HandleOnClickSetCodeBtnBtn()
		{
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584C")]
		[Address(RVA = "0xA5BB", Offset = "0xA5BB", VA = "0xA5BB")]
		private void HandleOnClickCodeGetButton()
		{
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584D")]
		[Address(RVA = "0xA5BC", Offset = "0xA5BC", VA = "0xA5BC")]
		private void HandleOnOAuthEvent(Provider provider)
		{
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584E")]
		[Address(RVA = "0xA5BD", Offset = "0xA5BD", VA = "0xA5BD")]
		private void HandleOnClickGPGSButton()
		{
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600584F")]
		[Address(RVA = "0xA5BE", Offset = "0xA5BE", VA = "0xA5BE")]
		private void HandleOnClickSaveEmailPasswordButton()
		{
		}

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		[FieldOffset(Offset = "0x18")]
		private readonly ProgressSaverModel _progressSaverModel;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x1C")]
		private CodeDisplayViewWindow _codeDisplayWindow;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x20")]
		private SelectUserWindow _selectUserWindow;
	}
}
