using System;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Core.Gameplay.Managers.Notifications.View;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Notifications.Controller
{
	// Token: 0x020011B1 RID: 4529
	[Token(Token = "0x20011B1")]
	public class GameNotificationSettingsWindowMediator : AbstractViewMediator<GameNotificationsModel, GameNotificationsEvents, GameNotificationsController, NotificationSettingsView>
	{
		// Token: 0x06006B96 RID: 27542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B96")]
		[Address(RVA = "0xB690", Offset = "0xB690", VA = "0xB690")]
		public GameNotificationSettingsWindowMediator(GameNotificationsModel model, GameNotificationsEvents events, GameNotificationsController controller)
		{
		}

		// Token: 0x170015F4 RID: 5620
		// (set) Token: 0x06006B97 RID: 27543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F4")]
		public override GameNotificationsEvents Events
		{
			[Token(Token = "0x6006B97")]
			[Address(RVA = "0xB691", Offset = "0xB691", VA = "0xB691", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (set) Token: 0x06006B98 RID: 27544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F5")]
		public override NotificationSettingsView View
		{
			[Token(Token = "0x6006B98")]
			[Address(RVA = "0xB692", Offset = "0xB692", VA = "0xB692", Slot = "20")]
			set
			{
			}
		}
	}
}
