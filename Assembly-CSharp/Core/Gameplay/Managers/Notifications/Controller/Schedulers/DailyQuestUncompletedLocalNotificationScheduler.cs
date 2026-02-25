using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B7 RID: 4535
	[Token(Token = "0x20011B7")]
	public class DailyQuestUncompletedLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06006BC6 RID: 27590 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x17001601")]
		public override int Id
		{
			[Token(Token = "0x6006BC6")]
			[Address(RVA = "0xB6B7", Offset = "0xB6B7", VA = "0xB6B7", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x17001602")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BC7")]
			[Address(RVA = "0xB6B8", Offset = "0xB6B8", VA = "0xB6B8", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x17001603")]
		private float MinBacktime
		{
			[Token(Token = "0x6006BC8")]
			[Address(RVA = "0x2229", Offset = "0x2229", VA = "0x2229")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0xB6B9", Offset = "0xB6B9", VA = "0xB6B9", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCA")]
		[Address(RVA = "0xB6BA", Offset = "0xB6BA", VA = "0xB6BA")]
		private void ActiveQuestsCountChangedEvent()
		{
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0xB6BB", Offset = "0xB6BB", VA = "0xB6BB", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0xB6BC", Offset = "0xB6BC", VA = "0xB6BC")]
		private void ValidateNotification()
		{
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0xB6BD", Offset = "0xB6BD", VA = "0xB6BD")]
		private void QuestsUpdatedEvent()
		{
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCE")]
		[Address(RVA = "0xB6BE", Offset = "0xB6BE", VA = "0xB6BE")]
		private void QuestsChangedEvent()
		{
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0xB6BF", Offset = "0xB6BF", VA = "0xB6BF", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0xB6C0", Offset = "0xB6C0", VA = "0xB6C0")]
		public DailyQuestUncompletedLocalNotificationScheduler()
		{
		}

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x14")]
		private float? _minBacktime;
	}
}
