using System;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Gameplay.UserInterface.View.UserGotNewLevel;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	public class UserGotNewLevelWindowViewMediator : AbstractViewMediator<UserInterfaceModel, UserInterfaceEvents, UserInterfaceController, UserGotNewLevelWindow>
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x691A", Offset = "0x691A", VA = "0x691A")]
		public UserGotNewLevelWindowViewMediator(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040F")]
		public override UserInterfaceEvents Events
		{
			[Token(Token = "0x600175E")]
			[Address(RVA = "0x691B", Offset = "0x691B", VA = "0x691B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000410")]
		public override UserGotNewLevelWindow View
		{
			[Token(Token = "0x600175F")]
			[Address(RVA = "0x691C", Offset = "0x691C", VA = "0x691C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x691D", Offset = "0x691D", VA = "0x691D")]
		private void SetupView()
		{
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x691E", Offset = "0x691E", VA = "0x691E")]
		private void ResetView()
		{
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x691F", Offset = "0x691F", VA = "0x691F")]
		private void HandleGetRewardButtonClickEvent()
		{
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x6920", Offset = "0x6920", VA = "0x6920")]
		private void HandleUserLevelRewardGetSuccessEvent(bool isSuccess)
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x6921", Offset = "0x6921", VA = "0x6921")]
		private void HandleGetReward()
		{
		}
	}
}
