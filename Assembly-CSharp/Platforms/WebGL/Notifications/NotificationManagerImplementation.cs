using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Core.Application.Managers;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Platforms.WebGL.Notifications
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	public class NotificationManagerImplementation : INotificationManager, IAppManager, IBaseManager, IDisposable
	{
		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x5B33", Offset = "0x5B33", VA = "0x5B33", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x5B34", Offset = "0x5B34", VA = "0x5B34", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x5B35", Offset = "0x5B35", VA = "0x5B35", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x5B36", Offset = "0x5B36", VA = "0x5B36", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x5B37", Offset = "0x5B37", VA = "0x5B37", Slot = "11")]
		public void Init()
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x5B38", Offset = "0x5B38", VA = "0x5B38", Slot = "12")]
		public void Deinit()
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CA")]
		public string Name
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x5B39", Offset = "0x5B39", VA = "0x5B39", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x5B3A", Offset = "0x5B3A", VA = "0x5B3A", Slot = "14")]
		public void Dispose()
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x5B3B", Offset = "0x5B3B", VA = "0x5B3B", Slot = "4")]
		public void ScheduleNotification(int id, string title, string message, int delay, Dictionary<string, object> developerPayload, LocalNotifications channel)
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x5B3C", Offset = "0x5B3C", VA = "0x5B3C", Slot = "5")]
		public void ClearNotification(int id)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x5B3D", Offset = "0x5B3D", VA = "0x5B3D", Slot = "6")]
		public void InitChannels(IDictProvider dictProvider)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x5B3E", Offset = "0x5B3E", VA = "0x5B3E")]
		public NotificationManagerImplementation()
		{
		}
	}
}
