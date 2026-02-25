using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011BB RID: 4539
	[Token(Token = "0x20011BB")]
	public class SpellLeanedLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x00013FB0 File Offset: 0x000121B0
		[Token(Token = "0x1700160C")]
		public override int Id
		{
			[Token(Token = "0x6006BEC")]
			[Address(RVA = "0xB6DC", Offset = "0xB6DC", VA = "0xB6DC", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06006BED RID: 27629 RVA: 0x00013FC8 File Offset: 0x000121C8
		[Token(Token = "0x1700160D")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BED")]
			[Address(RVA = "0xB6DD", Offset = "0xB6DD", VA = "0xB6DD", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEE")]
		[Address(RVA = "0xB6DE", Offset = "0xB6DE", VA = "0xB6DE", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BEF")]
		[Address(RVA = "0xB6DF", Offset = "0xB6DF", VA = "0xB6DF")]
		private void SpellStateChanged(uint spellId)
		{
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF0")]
		[Address(RVA = "0xB6E0", Offset = "0xB6E0", VA = "0xB6E0", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF1")]
		[Address(RVA = "0xB6E1", Offset = "0xB6E1", VA = "0xB6E1")]
		private void ValidateNotification()
		{
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF2")]
		[Address(RVA = "0xB6E2", Offset = "0xB6E2", VA = "0xB6E2", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF3")]
		[Address(RVA = "0xB6E3", Offset = "0xB6E3", VA = "0xB6E3")]
		public SpellLeanedLocalNotificationScheduler()
		{
		}
	}
}
