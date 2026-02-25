using System;
using System.Collections.Generic;
using Core.Events;
using Core.Events.Scopes;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D8 RID: 4824
	[Token(Token = "0x20012D8")]
	public class NotificationAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x060072B2 RID: 29362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700173C")]
		protected override string Theme
		{
			[Token(Token = "0x60072B2")]
			[Address(RVA = "0xBCBB", Offset = "0xBCBB", VA = "0xBCBB", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B3")]
		[Address(RVA = "0xBCBC", Offset = "0xBCBC", VA = "0xBCBC", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B4")]
		[Address(RVA = "0xBCBD", Offset = "0xBCBD", VA = "0xBCBD")]
		private void NotificationChannelsInitializedEvent(NotificationScope.NotificationChannelEventArgs e)
		{
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B5")]
		[Address(RVA = "0xBCBE", Offset = "0xBCBE", VA = "0xBCBE")]
		private void NotificationSettingsInitializedEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B6")]
		[Address(RVA = "0xBCBF", Offset = "0xBCBF", VA = "0xBCBF")]
		private void NotificationSettingsChangedEvent(NotificationScope.NotificationSettingsEventArgs e)
		{
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B7")]
		[Address(RVA = "0xBCC0", Offset = "0xBCC0", VA = "0xBCC0")]
		private void SetSettings(GameNotificationsModel gameNotificationsModel)
		{
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B8")]
		[Address(RVA = "0xBCC1", Offset = "0xBCC1", VA = "0xBCC1")]
		private void NotificationScopeOnNotificationReceivedEvent(NotificationScope.NotificationEventArgs e)
		{
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072B9")]
		[Address(RVA = "0xBCC2", Offset = "0xBCC2", VA = "0xBCC2")]
		private void AppendEventProperties(Dictionary<string, object> properties, NotificationScope.NotificationEventArgs e)
		{
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BA")]
		[Address(RVA = "0xBCC3", Offset = "0xBCC3", VA = "0xBCC3")]
		private void NotificationScopeOnNotificationClickedEvent(NotificationScope.NotificationEventArgs e)
		{
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BB")]
		[Address(RVA = "0xBCC4", Offset = "0xBCC4", VA = "0xBCC4", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072BC")]
		[Address(RVA = "0xBCC5", Offset = "0xBCC5", VA = "0xBCC5")]
		public NotificationAnalyticsListener()
		{
		}

		// Token: 0x04003C13 RID: 15379
		[Token(Token = "0x4003C13")]
		private const string NOTIFICATION_RECEIVED = "notification_received";

		// Token: 0x04003C14 RID: 15380
		[Token(Token = "0x4003C14")]
		private const string NOTIFICATION_CLICKED = "notification_clicked";

		// Token: 0x04003C15 RID: 15381
		[Token(Token = "0x4003C15")]
		private const string NOTIFICATION_SETTINGS_CHANGED = "notification_settings_changed";
	}
}
