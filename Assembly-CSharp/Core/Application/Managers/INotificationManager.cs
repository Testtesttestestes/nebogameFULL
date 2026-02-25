using System;
using System.Collections.Generic;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Application.Managers
{
	// Token: 0x02001253 RID: 4691
	[Token(Token = "0x2001253")]
	public interface INotificationManager : IAppManager, IBaseManager, IDisposable
	{
		// Token: 0x06006F3C RID: 28476
		[Token(Token = "0x6006F3C")]
		void ScheduleNotification(int id, string title, string message, int delay, Dictionary<string, object> developerPayload, LocalNotifications channel);

		// Token: 0x06006F3D RID: 28477
		[Token(Token = "0x6006F3D")]
		void ClearNotification(int id);

		// Token: 0x06006F3E RID: 28478
		[Token(Token = "0x6006F3E")]
		void InitChannels(IDictProvider dictProvider);
	}
}
