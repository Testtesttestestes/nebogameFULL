using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Notifications.Controller;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A9 RID: 4521
	[Token(Token = "0x20011A9")]
	public class NotificationSettingsWindow : ClosableBaseWindow<NotificationSettingsWindow.NotificationSettingsWindowArgs>
	{
		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06006B70 RID: 27504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E7")]
		public NotificationSettingsView SettingsView
		{
			[Token(Token = "0x6006B70")]
			[Address(RVA = "0xB66E", Offset = "0xB66E", VA = "0xB66E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015E8")]
		public override string WindowId
		{
			[Token(Token = "0x6006B71")]
			[Address(RVA = "0xB66F", Offset = "0xB66F", VA = "0xB66F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B72")]
		[Address(RVA = "0xB670", Offset = "0xB670", VA = "0xB670", Slot = "22")]
		protected override void OnShow(NotificationSettingsWindow.NotificationSettingsWindowArgs args)
		{
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B73")]
		[Address(RVA = "0xB671", Offset = "0xB671", VA = "0xB671", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B74")]
		[Address(RVA = "0xB672", Offset = "0xB672", VA = "0xB672")]
		public NotificationSettingsWindow()
		{
		}

		// Token: 0x040038B8 RID: 14520
		[Token(Token = "0x40038B8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private NotificationSettingsView _settingsView;

		// Token: 0x040038B9 RID: 14521
		[Token(Token = "0x40038B9")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/NotificationSettingsWindow";

		// Token: 0x040038BA RID: 14522
		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x40")]
		private GameNotificationSettingsWindowMediator _mediator;

		// Token: 0x020011AA RID: 4522
		[Token(Token = "0x20011AA")]
		public class NotificationSettingsWindowArgs : BaseWindowArgs
		{
			// Token: 0x170015E9 RID: 5609
			// (get) Token: 0x06006B75 RID: 27509 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170015E9")]
			public GameNotificationsController Controller
			{
				[Token(Token = "0x6006B75")]
				[Address(RVA = "0xB673", Offset = "0xB673", VA = "0xB673")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170015EA RID: 5610
			// (get) Token: 0x06006B76 RID: 27510 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170015EA")]
			public GameNotificationsEvents Events
			{
				[Token(Token = "0x6006B76")]
				[Address(RVA = "0xB674", Offset = "0xB674", VA = "0xB674")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170015EB RID: 5611
			// (get) Token: 0x06006B77 RID: 27511 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170015EB")]
			public GameNotificationsModel Model
			{
				[Token(Token = "0x6006B77")]
				[Address(RVA = "0xB675", Offset = "0xB675", VA = "0xB675")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B78 RID: 27512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006B78")]
			[Address(RVA = "0xB676", Offset = "0xB676", VA = "0xB676")]
			public NotificationSettingsWindowArgs(GameNotificationsController controller, GameNotificationsModel model, GameNotificationsEvents events)
			{
			}
		}
	}
}
