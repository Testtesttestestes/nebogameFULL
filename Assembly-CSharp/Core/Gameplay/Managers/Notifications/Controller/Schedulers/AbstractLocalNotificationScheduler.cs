using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B4 RID: 4532
	[Token(Token = "0x20011B4")]
	public abstract class AbstractLocalNotificationScheduler : AbstractBaseNotificationScheduler
	{
		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015FB")]
		private protected LocalNotificationDic NotificationDic
		{
			[Token(Token = "0x6006BAF")]
			[Address(RVA = "0xB6A1", Offset = "0xB6A1", VA = "0xB6A1")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006BB0")]
			[Address(RVA = "0xB6A2", Offset = "0xB6A2", VA = "0xB6A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x170015FC")]
		protected override bool IsNotificationEnabled
		{
			[Token(Token = "0x6006BB1")]
			[Address(RVA = "0xB6A3", Offset = "0xB6A3", VA = "0xB6A3", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0xB6A4", Offset = "0xB6A4", VA = "0xB6A4", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0xB6A5", Offset = "0xB6A5", VA = "0xB6A5", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB4")]
		[Address(RVA = "0xB6A6", Offset = "0xB6A6", VA = "0xB6A6", Slot = "10")]
		protected override void OnSettingsChanged(uint notificationId)
		{
		}

		// Token: 0x06006BB5 RID: 27573
		[Token(Token = "0x6006BB5")]
		protected abstract void HandleSettingsChanged();

		// Token: 0x06006BB6 RID: 27574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB6")]
		[Address(RVA = "0xB6A7", Offset = "0xB6A7", VA = "0xB6A7")]
		protected AbstractLocalNotificationScheduler()
		{
		}
	}
}
