using System;
using Core.Events.Scopes;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B6 RID: 4534
	[Token(Token = "0x20011B6")]
	public class CraftLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x170015FF")]
		public override int Id
		{
			[Token(Token = "0x6006BBF")]
			[Address(RVA = "0xB6B0", Offset = "0xB6B0", VA = "0xB6B0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x17001600")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BC0")]
			[Address(RVA = "0xB6B1", Offset = "0xB6B1", VA = "0xB6B1", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0xB6B2", Offset = "0xB6B2", VA = "0xB6B2", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC2")]
		[Address(RVA = "0xB6B3", Offset = "0xB6B3", VA = "0xB6B3", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC3")]
		[Address(RVA = "0xB6B4", Offset = "0xB6B4", VA = "0xB6B4")]
		private void CraftSlotsRequestedEvent(CraftScope.CraftSlotsEventArgs e)
		{
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC4")]
		[Address(RVA = "0xB6B5", Offset = "0xB6B5", VA = "0xB6B5", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0xB6B6", Offset = "0xB6B6", VA = "0xB6B6")]
		public CraftLocalNotificationScheduler()
		{
		}
	}
}
