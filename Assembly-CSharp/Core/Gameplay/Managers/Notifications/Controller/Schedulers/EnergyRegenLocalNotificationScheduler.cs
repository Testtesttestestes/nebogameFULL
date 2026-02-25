using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B8 RID: 4536
	[Token(Token = "0x20011B8")]
	public class EnergyRegenLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06006BD1 RID: 27601 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x17001604")]
		public override int Id
		{
			[Token(Token = "0x6006BD1")]
			[Address(RVA = "0xB6C1", Offset = "0xB6C1", VA = "0xB6C1", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x00013F08 File Offset: 0x00012108
		[Token(Token = "0x17001605")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BD2")]
			[Address(RVA = "0xB6C2", Offset = "0xB6C2", VA = "0xB6C2", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD3")]
		[Address(RVA = "0xB6C3", Offset = "0xB6C3", VA = "0xB6C3", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD4")]
		[Address(RVA = "0xB6C4", Offset = "0xB6C4", VA = "0xB6C4")]
		private void EnergyRegenStatusChangedEvent()
		{
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD5")]
		[Address(RVA = "0xB6C5", Offset = "0xB6C5", VA = "0xB6C5", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD6")]
		[Address(RVA = "0xB6C6", Offset = "0xB6C6", VA = "0xB6C6")]
		private void ValidateNotification()
		{
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD7")]
		[Address(RVA = "0xB6C7", Offset = "0xB6C7", VA = "0xB6C7", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD8")]
		[Address(RVA = "0xB6C8", Offset = "0xB6C8", VA = "0xB6C8")]
		public EnergyRegenLocalNotificationScheduler()
		{
		}
	}
}
