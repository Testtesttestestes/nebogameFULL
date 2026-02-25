using System;
using Il2CppDummyDll;
using Protocol.Notifier;

namespace Core.Gameplay.Managers.Notifications.Controller.Schedulers
{
	// Token: 0x020011B5 RID: 4533
	[Token(Token = "0x20011B5")]
	public class BuildingUpgradedLocalNotificationScheduler : AbstractLocalNotificationScheduler
	{
		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x170015FD")]
		public override int Id
		{
			[Token(Token = "0x6006BB7")]
			[Address(RVA = "0xB6A8", Offset = "0xB6A8", VA = "0xB6A8", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06006BB8 RID: 27576 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x170015FE")]
		protected override LocalNotifications Channel
		{
			[Token(Token = "0x6006BB8")]
			[Address(RVA = "0xB6A9", Offset = "0xB6A9", VA = "0xB6A9", Slot = "7")]
			get
			{
				return LocalNotifications.UnknownLocalNotification;
			}
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BB9")]
		[Address(RVA = "0xB6AA", Offset = "0xB6AA", VA = "0xB6AA", Slot = "8")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBA")]
		[Address(RVA = "0xB6AB", Offset = "0xB6AB", VA = "0xB6AB", Slot = "11")]
		protected override void HandleSettingsChanged()
		{
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0xB6AC", Offset = "0xB6AC", VA = "0xB6AC")]
		private void ValidateNotification()
		{
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBC")]
		[Address(RVA = "0xB6AD", Offset = "0xB6AD", VA = "0xB6AD")]
		private void BuildingStateChangedEvent(uint buildingId)
		{
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0xB6AE", Offset = "0xB6AE", VA = "0xB6AE", Slot = "9")]
		protected override void HandleDispose()
		{
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0xB6AF", Offset = "0xB6AF", VA = "0xB6AF")]
		public BuildingUpgradedLocalNotificationScheduler()
		{
		}
	}
}
