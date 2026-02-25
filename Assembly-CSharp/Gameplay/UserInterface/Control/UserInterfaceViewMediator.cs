using System;
using System.Collections.Generic;
using Core.Data;
using DefaultNamespace;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public class UserInterfaceViewMediator : AbstractViewMediator<UserInterfaceModel, UserInterfaceEvents, UserInterfaceController, UserInterfaceView>
	{
		// Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x6933", Offset = "0x6933", VA = "0x6933")]
		public UserInterfaceViewMediator(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		}

		// Token: 0x17000411 RID: 1041
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000411")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6001778")]
			[Address(RVA = "0x6934", Offset = "0x6934", VA = "0x6934", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000412 RID: 1042
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000412")]
		public override UserInterfaceEvents Events
		{
			[Token(Token = "0x6001779")]
			[Address(RVA = "0x6935", Offset = "0x6935", VA = "0x6935", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x6936", Offset = "0x6936", VA = "0x6936")]
		private void HandleApplicationScenesChangedEvent(IList<Scenes> scenes)
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x6937", Offset = "0x6937", VA = "0x6937")]
		private void HandleUserTriggerChangedEvent(UserData user)
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x6938", Offset = "0x6938", VA = "0x6938")]
		private void HandleUIElementsByRestrictions(UserData user)
		{
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x6939", Offset = "0x6939", VA = "0x6939")]
		private void ClanButtonOnClickEvent(IndexButtonBasic obj)
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x693A", Offset = "0x693A", VA = "0x693A")]
		private void MenuButtonOnClickEvent(IndexButtonBasic obj)
		{
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x693B", Offset = "0x693B", VA = "0x693B")]
		private void TradeButtonOnClickEvent(IndexButtonBasic obj)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x693C", Offset = "0x693C", VA = "0x693C")]
		private void CraftButtonOnClickEvent(IndexButtonBasic obj)
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x693D", Offset = "0x693D", VA = "0x693D")]
		private void ResetView()
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x693E", Offset = "0x693E", VA = "0x693E")]
		private void SetupView()
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x693F", Offset = "0x693F", VA = "0x693F")]
		private void SetActive(bool active)
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x6940", Offset = "0x6940", VA = "0x6940")]
		private void UserInterfaceWorldButtonsViewOnZigguratButtonClickedEvent()
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x6941", Offset = "0x6941", VA = "0x6941")]
		private void UserInterfaceWorldButtonsViewOnHomeButtonClickedEvent()
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x6942", Offset = "0x6942", VA = "0x6942")]
		private void ChestButtonOnClickEvent(IndexButtonBasic btn)
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x6943", Offset = "0x6943", VA = "0x6943")]
		private void BonusesButtonOnClickEvent(IndexButtonBasic btn)
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x6944", Offset = "0x6944", VA = "0x6944")]
		private void UserInfoChangedEventHandler()
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x6945", Offset = "0x6945", VA = "0x6945")]
		private void UserLevelChangedEventHandler()
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x6946", Offset = "0x6946", VA = "0x6946")]
		private void LocationChangedEventHandler()
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x6947", Offset = "0x6947", VA = "0x6947")]
		private void HandleNotifyUserGotNewLevelEvent(UserData user)
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x6948", Offset = "0x6948", VA = "0x6948")]
		private void HandleWorldMovementChangedEvent()
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x6949", Offset = "0x6949", VA = "0x6949")]
		private void ValidateMovementButtons()
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x694A", Offset = "0x694A", VA = "0x694A")]
		private void ShowMenuWindow()
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x694B", Offset = "0x694B", VA = "0x694B")]
		private void ShowUserGotNewLevelWindow(UserData user)
		{
		}
	}
}
