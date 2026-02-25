using System;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using MVC;

namespace Core.Gameplay.Managers.Notifications.Events
{
	// Token: 0x020011B0 RID: 4528
	[Token(Token = "0x20011B0")]
	public class GameNotificationsEvents : AbstractMVCEvents
	{
		// Token: 0x06006B95 RID: 27541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B95")]
		[Address(RVA = "0xB68F", Offset = "0xB68F", VA = "0xB68F")]
		public GameNotificationsEvents()
		{
		}

		// Token: 0x040038CC RID: 14540
		[Token(Token = "0x40038CC")]
		[FieldOffset(Offset = "0x14")]
		public Action<NotificationGroupData> GroupEnabledChangedEvent;

		// Token: 0x040038CD RID: 14541
		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint> NotificationEnabledChangedEvent;
	}
}
