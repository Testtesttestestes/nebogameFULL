using System;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	public class LocationOwnerIndexViewMediator : AbstractViewMediator<UserInterfaceModel, UserInterfaceEvents, UserInterfaceController, LocationOwnerIndexView>
	{
		// Token: 0x06001755 RID: 5973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x6912", Offset = "0x6912", VA = "0x6912")]
		public LocationOwnerIndexViewMediator(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		}

		// Token: 0x1700040D RID: 1037
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040D")]
		public override UserInterfaceEvents Events
		{
			[Token(Token = "0x6001756")]
			[Address(RVA = "0x6913", Offset = "0x6913", VA = "0x6913", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x6914", Offset = "0x6914", VA = "0x6914")]
		private void LocationChangedEvent()
		{
		}

		// Token: 0x1700040E RID: 1038
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040E")]
		public override LocationOwnerIndexView View
		{
			[Token(Token = "0x6001758")]
			[Address(RVA = "0x6915", Offset = "0x6915", VA = "0x6915", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x6916", Offset = "0x6916", VA = "0x6916")]
		private void ResetView()
		{
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x6917", Offset = "0x6917", VA = "0x6917")]
		private void SetupView()
		{
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x6918", Offset = "0x6918", VA = "0x6918")]
		private void GiftButtonClickedEventHandler()
		{
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x6919", Offset = "0x6919", VA = "0x6919")]
		private void HandleRatingBtnClickEvent()
		{
		}
	}
}
