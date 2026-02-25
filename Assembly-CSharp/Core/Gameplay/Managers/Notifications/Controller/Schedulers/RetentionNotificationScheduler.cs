using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011BA RID: 4538
	[Token(Token = "0x20011BA")]
	public class RetentionNotificationScheduler : AbstractBaseNotificationScheduler
	{
		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001608")]
		private protected LocalNotificationDic NotificationDic
		{
			[Token(Token = "0x6006BE1")]
			[Address(RVA = "0xB6D1", Offset = "0xB6D1", VA = "0xB6D1")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006BE2")]
			[Address(RVA = "0xB6D2", Offset = "0xB6D2", VA = "0xB6D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x17001609")]
		public override int Id
		{
			[Token(Token = "0x6006BE3")]
			[Address(RVA = "0xB6D3", Offset = "0xB6D3", VA = "0xB6D3", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x00013F68 File Offset: 0x00012168
		[Token(Token = "0x1700160A")]
		protected override bool IsNotificationEnabled
		{
			[Token(Token = "0x6006BE4")]
			[Address(RVA = "0xB6D4", Offset = "0xB6D4", VA = "0xB6D4", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x1700160B")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BE5")]
			[Address(RVA = "0xB6D5", Offset = "0xB6D5", VA = "0xB6D5", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE6")]
		[Address(RVA = "0xB6D6", Offset = "0xB6D6", VA = "0xB6D6", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE7")]
		[Address(RVA = "0xB6D7", Offset = "0xB6D7", VA = "0xB6D7", Slot = "10")]
		protected override void OnSettingsChanged(uint notificationId)
		{
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE8")]
		[Address(RVA = "0xB6D8", Offset = "0xB6D8", VA = "0xB6D8", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x00013F98 File Offset: 0x00012198
		[Token(Token = "0x6006BE9")]
		[Address(RVA = "0xB6D9", Offset = "0xB6D9", VA = "0xB6D9")]
		public static int GetNotificationIdByScheduleId(int scheduleId)
		{
			return 0;
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEA")]
		[Address(RVA = "0xB6DA", Offset = "0xB6DA", VA = "0xB6DA")]
		public RetentionNotificationScheduler(LocalNotificationScheduleDic scheduleDic)
		{
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEB")]
		[Address(RVA = "0xB6DB", Offset = "0xB6DB", VA = "0xB6DB")]
		private void ValidateNotification()
		{
		}

		// Token: 0x040038D5 RID: 14549
		[Token(Token = "0x40038D5")]
		public const int RetentionNotificationIdDelta = 1000000;

		// Token: 0x040038D6 RID: 14550
		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x10")]
		private LocalNotificationScheduleDic _scheduleDic;

		// Token: 0x040038D8 RID: 14552
		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x18")]
		private int _id;
	}
}
