using System;
using Gameplay.AccountLinker.Control;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using Protocol.Common;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E0F RID: 3599
	[Token(Token = "0x2000E0F")]
	public class ProgressSaverController : AbstractController<ProgressSaverModel, ProgressSaverEvents>
	{
		// Token: 0x060057AA RID: 22442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AA")]
		[Address(RVA = "0xA51D", Offset = "0xA51D", VA = "0xA51D", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AB")]
		[Address(RVA = "0xA51E", Offset = "0xA51E", VA = "0xA51E")]
		public ProgressSaverController(AccountLinker accountLinker, ProgressSaverModel model, ProgressSaverEvents events)
		{
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0xA51F", Offset = "0xA51F", VA = "0xA51F")]
		private void RemoveListenEventForSiteHelper()
		{
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011EA")]
		private NebogameSiteHelper SiteHelper
		{
			[Token(Token = "0x60057AD")]
			[Address(RVA = "0xA520", Offset = "0xA520", VA = "0xA520")]
			get
			{
				return null;
			}
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0xA521", Offset = "0xA521", VA = "0xA521", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0xA522", Offset = "0xA522", VA = "0xA522", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0xA523", Offset = "0xA523", VA = "0xA523")]
		private void HandleSigninTargetProviderStartedEvent()
		{
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0xA524", Offset = "0xA524", VA = "0xA524")]
		private void HandleSiteHelperSetEmailErrorEvent(int errorCode)
		{
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0xA525", Offset = "0xA525", VA = "0xA525")]
		private void HandleSiteHelperSetEmailCompleteEvent()
		{
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0xA526", Offset = "0xA526", VA = "0xA526")]
		private void StartAccountLinkerEvents()
		{
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B4")]
		[Address(RVA = "0xA527", Offset = "0xA527", VA = "0xA527")]
		private void StopAccountLinkerEvents()
		{
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B5")]
		[Address(RVA = "0xA528", Offset = "0xA528", VA = "0xA528")]
		private void HandleInvalidNickErrorEvent(string nick, uint aprId, RepeatedField<string> nickVariants)
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B6")]
		[Address(RVA = "0xA529", Offset = "0xA529", VA = "0xA529")]
		private void HandleSetUserSuccessEvent()
		{
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0xA52A", Offset = "0xA52A", VA = "0xA52A")]
		private void HandleSigninTargetProviderFailedEvent()
		{
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0xA52B", Offset = "0xA52B", VA = "0xA52B")]
		private void HandleLinkageProcessSuccessEvent()
		{
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0xA52C", Offset = "0xA52C", VA = "0xA52C")]
		public void SetEmailAndPassword(string email, string password)
		{
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057BA")]
		[Address(RVA = "0xA52D", Offset = "0xA52D", VA = "0xA52D")]
		public void InvokeOAuth(Provider provider)
		{
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60057BB")]
		[Address(RVA = "0xA52E", Offset = "0xA52E", VA = "0xA52E")]
		public RefAccountInfo GetAnyUserLinkedProvider(params Provider[] providers)
		{
			return null;
		}

		// Token: 0x04002F82 RID: 12162
		[Token(Token = "0x4002F82")]
		[FieldOffset(Offset = "0x18")]
		public readonly AccountLinker AccountLinker;

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x1C")]
		private NebogameSiteHelper _siteHelper;
	}
}
