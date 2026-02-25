using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.UserInfo.Model;
using Gameplay.UserInfo.View;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public class UserInfoEditViewMediator : AbstractViewMediator<UserInfoModel, UserInfoEvents, UserInfoController, CultGenderNickSettingsView>
	{
		// Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x6A52", Offset = "0x6A52", VA = "0x6A52")]
		public UserInfoEditViewMediator(UserInfoModel model, UserInfoEvents events, UserInfoController controller)
		{
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x6A53", Offset = "0x6A53", VA = "0x6A53", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x17000459 RID: 1113
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000459")]
		public override UserInfoEvents Events
		{
			[Token(Token = "0x60018B5")]
			[Address(RVA = "0x6A54", Offset = "0x6A54", VA = "0x6A54", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x6A55", Offset = "0x6A55", VA = "0x6A55")]
		private void HandleUserNickPriceChangedEvent()
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x6A56", Offset = "0x6A56", VA = "0x6A56")]
		private void UserAprSelectedEvent()
		{
		}

		// Token: 0x1700045A RID: 1114
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045A")]
		public override CultGenderNickSettingsView View
		{
			[Token(Token = "0x60018B8")]
			[Address(RVA = "0x6A57", Offset = "0x6A57", VA = "0x6A57", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x6A58", Offset = "0x6A58", VA = "0x6A58")]
		private void ResetView()
		{
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x6A59", Offset = "0x6A59", VA = "0x6A59")]
		private void SetupView()
		{
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x6A5A", Offset = "0x6A5A", VA = "0x6A5A")]
		private void SetCurrentAvatar()
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x6A5B", Offset = "0x6A5B", VA = "0x6A5B")]
		private void HandleHideAprsCheckBoxValueChangedEvent(bool value)
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x6A5C", Offset = "0x6A5C", VA = "0x6A5C")]
		private void HandleHideMedalsCheckBoxValueChangedEvent(bool value)
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x6A5D", Offset = "0x6A5D", VA = "0x6A5D")]
		private void HandleOnGenderOrCultSelected()
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x6A5E", Offset = "0x6A5E", VA = "0x6A5E")]
		private void HandleChangeCultGenderButtonClickEvent()
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x6A5F", Offset = "0x6A5F", VA = "0x6A5F")]
		private void HandleChangeNickButtonClickEvent()
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x6A60", Offset = "0x6A60", VA = "0x6A60")]
		private void HandleGenerateNickButtonClickEvent()
		{
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x6A61", Offset = "0x6A61", VA = "0x6A61")]
		private void HandleUserNickGenerateCompleteEvent(string nick)
		{
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x6A62", Offset = "0x6A62", VA = "0x6A62")]
		private void HandleUserNickVariantsCompleteEvent(string sourceNick, RepeatedField<string> nickVariants)
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x6A63", Offset = "0x6A63", VA = "0x6A63")]
		private void HandleNickVariantsOnCloseEvent()
		{
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x6A64", Offset = "0x6A64", VA = "0x6A64")]
		private void NickSelectedFromVariantsCallback(string nick)
		{
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x6A65", Offset = "0x6A65", VA = "0x6A65")]
		private void SetAvatar(string assetId)
		{
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x6A66", Offset = "0x6A66", VA = "0x6A66")]
		private DialogWindow ShowConfirmChangeCult(AprDicWrapper apr)
		{
			return null;
		}
	}
}
