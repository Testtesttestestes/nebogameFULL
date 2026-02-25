using System;
using Gameplay.Announcements.Control;
using Gameplay.Announcements.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Announcements.View
{
	// Token: 0x02000DA1 RID: 3489
	[Token(Token = "0x2000DA1")]
	public class AnnouncementsWindow : BaseWindow<AnnouncementsWindow.AnnouncementsWindowArgs>
	{
		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001151")]
		public override string WindowId
		{
			[Token(Token = "0x6005546")]
			[Address(RVA = "0xA2E7", Offset = "0xA2E7", VA = "0xA2E7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x17001152")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6005547")]
			[Address(RVA = "0xA2E8", Offset = "0xA2E8", VA = "0xA2E8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005548")]
		[Address(RVA = "0xA2E9", Offset = "0xA2E9", VA = "0xA2E9", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005549")]
		[Address(RVA = "0xA2EA", Offset = "0xA2EA", VA = "0xA2EA", Slot = "22")]
		protected override void OnShow(AnnouncementsWindow.AnnouncementsWindowArgs args)
		{
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600554A")]
		[Address(RVA = "0xA2EB", Offset = "0xA2EB", VA = "0xA2EB")]
		public AnnouncementsWindow()
		{
		}

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Announcements/AnnouncementsWindow";

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private AnnouncementsView _view;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x38")]
		private AnnouncementsViewMediator _mediator;

		// Token: 0x02000DA2 RID: 3490
		[Token(Token = "0x2000DA2")]
		public class AnnouncementsWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600554B RID: 21835 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600554B")]
			[Address(RVA = "0xA2EC", Offset = "0xA2EC", VA = "0xA2EC")]
			public AnnouncementsWindowArgs(AnnouncementsController controller, AnnouncementsData notification)
			{
			}

			// Token: 0x04002E31 RID: 11825
			[Token(Token = "0x4002E31")]
			[FieldOffset(Offset = "0x18")]
			public readonly AnnouncementsController Controller;

			// Token: 0x04002E32 RID: 11826
			[Token(Token = "0x4002E32")]
			[FieldOffset(Offset = "0x1C")]
			public readonly AnnouncementsData Notification;
		}
	}
}
