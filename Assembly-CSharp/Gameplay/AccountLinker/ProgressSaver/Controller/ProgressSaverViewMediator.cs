using System;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.AccountLinker.ProgressSaver.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E13 RID: 3603
	[Token(Token = "0x2000E13")]
	public class ProgressSaverViewMediator : AbstractViewMediator<ProgressSaverModel, ProgressSaverEvents, ProgressSaverController, ProgressSaverView>
	{
		// Token: 0x060057D7 RID: 22487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D7")]
		[Address(RVA = "0xA54A", Offset = "0xA54A", VA = "0xA54A")]
		public ProgressSaverViewMediator(ProgressSaverModel model, ProgressSaverEvents events, ProgressSaverController controller)
		{
		}

		// Token: 0x170011EC RID: 4588
		// (set) Token: 0x060057D8 RID: 22488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EC")]
		public override ProgressSaverView View
		{
			[Token(Token = "0x60057D8")]
			[Address(RVA = "0xA54B", Offset = "0xA54B", VA = "0xA54B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170011ED RID: 4589
		// (set) Token: 0x060057D9 RID: 22489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011ED")]
		public override ProgressSaverEvents Events
		{
			[Token(Token = "0x60057D9")]
			[Address(RVA = "0xA54C", Offset = "0xA54C", VA = "0xA54C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DA")]
		[Address(RVA = "0xA54D", Offset = "0xA54D", VA = "0xA54D")]
		private void HandleSetupView()
		{
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DB")]
		[Address(RVA = "0xA54E", Offset = "0xA54E", VA = "0xA54E")]
		private void UpdateSignState()
		{
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DC")]
		[Address(RVA = "0xA54F", Offset = "0xA54F", VA = "0xA54F")]
		private void HandleOnOAuthEvent(Provider provider)
		{
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DD")]
		[Address(RVA = "0xA550", Offset = "0xA550", VA = "0xA550")]
		private void HandleGpgsSigninButtonClickEvent()
		{
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DE")]
		[Address(RVA = "0xA551", Offset = "0xA551", VA = "0xA551")]
		private void HandleSetEmailPasswordSuccessEvent()
		{
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057DF")]
		[Address(RVA = "0xA552", Offset = "0xA552", VA = "0xA552")]
		private void HandleProgressSavedSuccessEvent()
		{
		}
	}
}
