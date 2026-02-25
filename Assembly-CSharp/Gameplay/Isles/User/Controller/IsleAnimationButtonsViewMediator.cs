using System;
using Gameplay.Isles.User.View;
using Gameplay.World.Controller;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D31 RID: 3377
	[Token(Token = "0x2000D31")]
	public class IsleAnimationButtonsViewMediator : AbstractCozyViewMediator<WorldModel, WorldControllerEvents, WorldController, IsleAnimationButtonsView>
	{
		// Token: 0x0600529A RID: 21146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529A")]
		[Address(RVA = "0xA070", Offset = "0xA070", VA = "0xA070")]
		public IsleAnimationButtonsViewMediator(IsleAnimationButtonsView view, WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529B")]
		[Address(RVA = "0xA071", Offset = "0xA071", VA = "0xA071", Slot = "21")]
		protected override void ResetEvents(WorldControllerEvents events)
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529C")]
		[Address(RVA = "0xA072", Offset = "0xA072", VA = "0xA072", Slot = "22")]
		protected override void SetupEvents(WorldControllerEvents events)
		{
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529D")]
		[Address(RVA = "0xA073", Offset = "0xA073", VA = "0xA073", Slot = "23")]
		protected override void ResetView(IsleAnimationButtonsView view)
		{
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529E")]
		[Address(RVA = "0xA074", Offset = "0xA074", VA = "0xA074", Slot = "24")]
		protected override void SetupView(IsleAnimationButtonsView view)
		{
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529F")]
		[Address(RVA = "0xA075", Offset = "0xA075", VA = "0xA075")]
		private void HandleDictChangedEvent()
		{
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0xA076", Offset = "0xA076", VA = "0xA076")]
		private void HandleWorldLocationChangedEvent()
		{
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0xA077", Offset = "0xA077", VA = "0xA077")]
		private void HandleAnimationInfoChangedEvent()
		{
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0xA078", Offset = "0xA078", VA = "0xA078")]
		private void ViewOnButtonClickedEvent(IsleAnimationsDic dict)
		{
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0xA079", Offset = "0xA079", VA = "0xA079")]
		private void SelectedLaunchValueDialogOnSelectedEvent(IsleAnimationMultipleLaunchesDialog dialog)
		{
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A4")]
		[Address(RVA = "0xA07A", Offset = "0xA07A", VA = "0xA07A")]
		private void HandleSliderButtonLongTapEvent(IsleAnimationMultipleLaunchesDialog dialog)
		{
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A5")]
		[Address(RVA = "0xA07B", Offset = "0xA07B", VA = "0xA07B")]
		private void UpdateAnimationButtons()
		{
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A6")]
		[Address(RVA = "0xA07C", Offset = "0xA07C", VA = "0xA07C")]
		private void ValidateButtonsAvailability()
		{
		}
	}
}
