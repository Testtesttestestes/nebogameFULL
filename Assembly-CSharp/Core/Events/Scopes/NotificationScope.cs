using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001015 RID: 4117
	[Token(Token = "0x2001015")]
	public class NotificationScope : AbstractEventBusScope
	{
		// Token: 0x0600616A RID: 24938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600616A")]
		[Address(RVA = "0xAD95", Offset = "0xAD95", VA = "0xAD95", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600616B")]
		[Address(RVA = "0xAD96", Offset = "0xAD96", VA = "0xAD96")]
		public NotificationScope()
		{
		}

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x8")]
		public Action<NotificationScope.NotificationEventArgs> NotificationReceivedEvent;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0xC")]
		public Action<NotificationScope.NotificationEventArgs> NotificationClickedEvent;

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		[FieldOffset(Offset = "0x10")]
		public Action<NotificationScope.NotificationSettingsEventArgs> NotificationSettingsChangedEvent;

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x14")]
		public Action<BaseEventBusEventArgs> NotificationSettingsInitializedEvent;

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x18")]
		public Action<NotificationScope.NotificationChannelEventArgs> NotificationChannelsInitializedEvent;

		// Token: 0x02001016 RID: 4118
		[Token(Token = "0x2001016")]
		public class NotificationEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001352 RID: 4946
			// (get) Token: 0x0600616C RID: 24940 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001352")]
			public string Id
			{
				[Token(Token = "0x600616C")]
				[Address(RVA = "0xAD97", Offset = "0xAD97", VA = "0xAD97")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001353 RID: 4947
			// (get) Token: 0x0600616D RID: 24941 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001353")]
			public string Title
			{
				[Token(Token = "0x600616D")]
				[Address(RVA = "0xAD98", Offset = "0xAD98", VA = "0xAD98")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001354 RID: 4948
			// (get) Token: 0x0600616E RID: 24942 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001354")]
			public string Body
			{
				[Token(Token = "0x600616E")]
				[Address(RVA = "0xAD99", Offset = "0xAD99", VA = "0xAD99")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001355 RID: 4949
			// (get) Token: 0x0600616F RID: 24943 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001355")]
			public Dictionary<string, object> DeveloperPayload
			{
				[Token(Token = "0x600616F")]
				[Address(RVA = "0xAD9A", Offset = "0xAD9A", VA = "0xAD9A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006170 RID: 24944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006170")]
			[Address(RVA = "0xAD9B", Offset = "0xAD9B", VA = "0xAD9B")]
			public NotificationEventArgs(IApp app, IGame game, string id, string title, string body, Dictionary<string, object> developerPayload)
			{
			}
		}

		// Token: 0x02001017 RID: 4119
		[Token(Token = "0x2001017")]
		public class NotificationSettingsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001356 RID: 4950
			// (get) Token: 0x06006171 RID: 24945 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001356")]
			public NotificationGroupData GroupSettings
			{
				[Token(Token = "0x6006171")]
				[Address(RVA = "0xAD9C", Offset = "0xAD9C", VA = "0xAD9C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006172 RID: 24946 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006172")]
			[Address(RVA = "0xAD9D", Offset = "0xAD9D", VA = "0xAD9D")]
			public NotificationSettingsEventArgs(App app, IGame game, NotificationGroupData groupSettings)
			{
			}
		}

		// Token: 0x02001018 RID: 4120
		[Token(Token = "0x2001018")]
		public class NotificationChannelEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001357 RID: 4951
			// (get) Token: 0x06006173 RID: 24947 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001357")]
			public IEnumerable<string> ChannelIds
			{
				[Token(Token = "0x6006173")]
				[Address(RVA = "0xAD9E", Offset = "0xAD9E", VA = "0xAD9E")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006174 RID: 24948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006174")]
			[Address(RVA = "0xAD9F", Offset = "0xAD9F", VA = "0xAD9F")]
			public NotificationChannelEventArgs(IApp app, IGame game, IEnumerable<string> channelIds)
			{
			}
		}
	}
}
