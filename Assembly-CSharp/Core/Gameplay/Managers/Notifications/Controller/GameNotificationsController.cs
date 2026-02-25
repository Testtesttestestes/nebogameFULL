using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Notifications.Controller.Schedulers;
using Core.Gameplay.Managers.Notifications.Events;
using Core.Gameplay.Managers.Notifications.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Managers.Notifications.Controller
{
	// Token: 0x020011B2 RID: 4530
	[Token(Token = "0x20011B2")]
	public class GameNotificationsController : AbstractController<GameNotificationsModel, GameNotificationsEvents>
	{
		// Token: 0x06006B99 RID: 27545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B99")]
		[Address(RVA = "0xB693", Offset = "0xB693", VA = "0xB693")]
		public GameNotificationsController(GameNotificationsModel model, GameNotificationsEvents events)
		{
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9A")]
		[Address(RVA = "0xB694", Offset = "0xB694", VA = "0xB694", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9B")]
		[Address(RVA = "0xB695", Offset = "0xB695", VA = "0xB695", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9C")]
		[Address(RVA = "0xB696", Offset = "0xB696", VA = "0xB696")]
		private void InitSchedulers()
		{
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9D")]
		[Address(RVA = "0xB697", Offset = "0xB697", VA = "0xB697")]
		private void HandleGetGroupsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9E")]
		[Address(RVA = "0xB698", Offset = "0xB698", VA = "0xB698")]
		private void OnGroupEnabledChangedEvent(NotificationGroupData group)
		{
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B9F")]
		[Address(RVA = "0xB699", Offset = "0xB699", VA = "0xB699", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0x18")]
		private List<AbstractBaseNotificationScheduler> _schedulers;

		// Token: 0x040038CF RID: 14543
		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x1C")]
		private NotifierService _notifierService;
	}
}
