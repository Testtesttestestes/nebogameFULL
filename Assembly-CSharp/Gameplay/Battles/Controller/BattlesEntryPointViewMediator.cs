using System;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.Battles.Controller
{
	// Token: 0x02000C30 RID: 3120
	[Token(Token = "0x2000C30")]
	public class BattlesEntryPointViewMediator : AbstractViewMediator<BattlesModel, BattlesEvents, BattlesController, UserInterfaceView>
	{
		// Token: 0x06004C11 RID: 19473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x9A55", Offset = "0x9A55", VA = "0x9A55")]
		public BattlesEntryPointViewMediator(BattlesModel model, BattlesEvents events, BattlesController controller)
		{
		}

		// Token: 0x17000F55 RID: 3925
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F55")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6004C12")]
			[Address(RVA = "0x9A56", Offset = "0x9A56", VA = "0x9A56", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (set) Token: 0x06004C13 RID: 19475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F56")]
		public override BattlesEvents Events
		{
			[Token(Token = "0x6004C13")]
			[Address(RVA = "0x9A57", Offset = "0x9A57", VA = "0x9A57", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x9A58", Offset = "0x9A58", VA = "0x9A58")]
		private void ResetView()
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x9A59", Offset = "0x9A59", VA = "0x9A59")]
		private void SetupView()
		{
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x9A5A", Offset = "0x9A5A", VA = "0x9A5A")]
		private void EventsOnNotificationNumChangedEvent()
		{
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x9A5B", Offset = "0x9A5B", VA = "0x9A5B")]
		private void UserInterfaceButtonsViewOnCombatButtonClickedEvent(IndexButtonBasic indexButton)
		{
		}
	}
}
