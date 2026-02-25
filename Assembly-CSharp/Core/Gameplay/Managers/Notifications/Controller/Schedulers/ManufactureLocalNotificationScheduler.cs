using System;
using Gameplay.Assistants.Manufacture;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B9 RID: 4537
	[Token(Token = "0x20011B9")]
	public class ManufactureLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x00013F20 File Offset: 0x00012120
		[Token(Token = "0x17001606")]
		public override int Id
		{
			[Token(Token = "0x6006BD9")]
			[Address(RVA = "0xB6C9", Offset = "0xB6C9", VA = "0xB6C9", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x00013F38 File Offset: 0x00012138
		[Token(Token = "0x17001607")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BDA")]
			[Address(RVA = "0xB6CA", Offset = "0xB6CA", VA = "0xB6CA", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0xB6CB", Offset = "0xB6CB", VA = "0xB6CB", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDC")]
		[Address(RVA = "0xB6CC", Offset = "0xB6CC", VA = "0xB6CC")]
		private void DismantleStatusChangedEvent()
		{
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDD")]
		[Address(RVA = "0xB6CD", Offset = "0xB6CD", VA = "0xB6CD", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDE")]
		[Address(RVA = "0xB6CE", Offset = "0xB6CE", VA = "0xB6CE")]
		private void ValidateNotification()
		{
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BDF")]
		[Address(RVA = "0xB6CF", Offset = "0xB6CF", VA = "0xB6CF", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BE0")]
		[Address(RVA = "0xB6D0", Offset = "0xB6D0", VA = "0xB6D0")]
		public ManufactureLocalNotificationScheduler()
		{
		}

		// Token: 0x040038D4 RID: 14548
		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x14")]
		private ManufactureAssistant _manufactureAssistant;
	}
}
