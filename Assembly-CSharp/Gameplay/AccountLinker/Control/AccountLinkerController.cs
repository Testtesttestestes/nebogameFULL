using System;
using Gameplay.AccountLinker.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using ServicesNamespace;
using Utils;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E19 RID: 3609
	[Token(Token = "0x2000E19")]
	public class AccountLinkerController : AbstractController<AccountLinkerModel, AccountLinkerEvents>
	{
		// Token: 0x060057F8 RID: 22520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F8")]
		[Address(RVA = "0xA56A", Offset = "0xA56A", VA = "0xA56A", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060057F9 RID: 22521 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011F3")]
		private NebogameSiteHelper SiteHelper
		{
			[Token(Token = "0x60057F9")]
			[Address(RVA = "0xA56B", Offset = "0xA56B", VA = "0xA56B")]
			get
			{
				return null;
			}
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FA")]
		[Address(RVA = "0xA56C", Offset = "0xA56C", VA = "0xA56C")]
		private void RemoveListenEventForSiteHelper()
		{
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0xA56D", Offset = "0xA56D", VA = "0xA56D")]
		public AccountLinkerController(AccountLinkerModel model, AccountLinkerEvents events)
		{
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0xA56E", Offset = "0xA56E", VA = "0xA56E")]
		public string GetCurrentNick()
		{
			return null;
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0xA56F", Offset = "0xA56F", VA = "0xA56F")]
		public uint GetCurrentAprId()
		{
			return 0U;
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0xA570", Offset = "0xA570", VA = "0xA570")]
		public bool TryAddRefAccount(Provider provider, string refNick)
		{
			return default(bool);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0xA571", Offset = "0xA571", VA = "0xA571")]
		private void RunResolveUsersProcess()
		{
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005800")]
		[Address(RVA = "0x488A", Offset = "0x488A", VA = "0x488A")]
		private void RunSetUserIdAfterSync(ulong userId)
		{
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005801")]
		[Address(RVA = "0xA572", Offset = "0xA572", VA = "0xA572")]
		private void RunSetUserIdAfterAppendRefAccount(ulong userId)
		{
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005802")]
		[Address(RVA = "0xA573", Offset = "0xA573", VA = "0xA573")]
		private void HandleLoggedUserUserInfoUpdated()
		{
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005803")]
		[Address(RVA = "0xA574", Offset = "0xA574", VA = "0xA574")]
		private void RequestCodeGet()
		{
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005804")]
		[Address(RVA = "0xA575", Offset = "0xA575", VA = "0xA575")]
		private void RequestTokenGen(string code)
		{
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005805")]
		[Address(RVA = "0xA576", Offset = "0xA576", VA = "0xA576")]
		private void RequestUserSkills(LinkerUser user)
		{
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005806")]
		[Address(RVA = "0xA577", Offset = "0xA577", VA = "0xA577")]
		private void HandleSetEmailAndPasswordSuccess()
		{
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005807")]
		[Address(RVA = "0xA578", Offset = "0xA578", VA = "0xA578")]
		private void HandleGetUserSkillsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005808")]
		[Address(RVA = "0xA579", Offset = "0xA579", VA = "0xA579")]
		private void HandleOtpTokenGenService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005809")]
		[Address(RVA = "0xA57A", Offset = "0xA57A", VA = "0xA57A")]
		private void HandleOtpTokenGen(OTPTokenGenCmd.Types.Ans msg)
		{
		}

		// Token: 0x0600580A RID: 22538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580A")]
		[Address(RVA = "0xA57B", Offset = "0xA57B", VA = "0xA57B")]
		private void HandleOtpCodeGetService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580B")]
		[Address(RVA = "0xA57C", Offset = "0xA57C", VA = "0xA57C")]
		private void HandleSiteHelperSetEmailCompleteEvent()
		{
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580C")]
		[Address(RVA = "0xA57D", Offset = "0xA57D", VA = "0xA57D")]
		private void HandleSiteHelperSetEmailErrorEvent(int errorCode)
		{
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580D")]
		[Address(RVA = "0xA57E", Offset = "0xA57E", VA = "0xA57E")]
		public void RequestGetCode()
		{
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580E")]
		[Address(RVA = "0xA57F", Offset = "0xA57F", VA = "0xA57F")]
		public void RequestSetCode(string code)
		{
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x600580F")]
		[Address(RVA = "0xA580", Offset = "0xA580", VA = "0xA580")]
		public bool TryRequestSigninToTargetProvider()
		{
			return default(bool);
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005810")]
		[Address(RVA = "0xA581", Offset = "0xA581", VA = "0xA581")]
		public void StartRegisterProcess(string nick, uint aprId)
		{
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005811")]
		[Address(RVA = "0xA582", Offset = "0xA582", VA = "0xA582")]
		public void RequestSetResolvedUserId(LinkerUser userWrapper)
		{
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005812")]
		[Address(RVA = "0xA583", Offset = "0xA583", VA = "0xA583")]
		public void OpenPageHowGetCodeFromWebSite()
		{
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005813")]
		[Address(RVA = "0xA584", Offset = "0xA584", VA = "0xA584")]
		public void InvokeOAuth(Provider provider)
		{
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6005814")]
		[Address(RVA = "0xA585", Offset = "0xA585", VA = "0xA585")]
		public bool SetEmailAndPass(string email, string password)
		{
			return default(bool);
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005815")]
		[Address(RVA = "0xA586", Offset = "0xA586", VA = "0xA586", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		public const string TEMP_REF_NICK = "temp_for_this_session";

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x18")]
		private Auth2Service _authService;

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x1C")]
		private SigninTracker _signinTracker;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x20")]
		private NebogameSiteHelper _siteHelper;
	}
}
