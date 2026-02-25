using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Platforms.Android.Notifications
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	public struct GameNotificationChannel
	{
		// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x5B52", Offset = "0x5B52", VA = "0x5B52")]
		public GameNotificationChannel(string id, string name, string description)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x5B53", Offset = "0x5B53", VA = "0x5B53")]
		public GameNotificationChannel(string id, string name, string description, GameNotificationChannel.NotificationStyle style, bool showsBadge = true, bool showLights = false, bool vibrates = true, bool highPriority = false, GameNotificationChannel.PrivacyMode privacy = GameNotificationChannel.PrivacyMode.Public, [Optional] long[] vibrationPattern)
		{
		}

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly string Id;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly string Name;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Description;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly bool ShowsBadge;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public readonly bool ShowLights;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public readonly bool Vibrates;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public readonly bool HighPriority;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly GameNotificationChannel.NotificationStyle Style;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public readonly GameNotificationChannel.PrivacyMode Privacy;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly int[] VibrationPattern;

		// Token: 0x020000CD RID: 205
		[Token(Token = "0x20000CD")]
		public enum NotificationStyle
		{
			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			None,
			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			NoSound = 2,
			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			Default,
			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			Popup
		}

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		public enum PrivacyMode
		{
			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			Secret = -1,
			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			Private,
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			Public
		}
	}
}
