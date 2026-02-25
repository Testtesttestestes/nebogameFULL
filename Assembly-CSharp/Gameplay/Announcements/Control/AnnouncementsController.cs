using System;
using System.Collections.Generic;
using CloudsFly.Movement;
using DG.Tweening;
using Gameplay.Announcements.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Announcements;
using ServicesNamespace;
using Utils;

namespace Gameplay.Announcements.Control
{
	// Token: 0x02000DA7 RID: 3495
	[Token(Token = "0x2000DA7")]
	public class AnnouncementsController : AbstractController<AnnouncementsModel, AnnouncementsEvents>
	{
		// Token: 0x06005567 RID: 21863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005567")]
		[Address(RVA = "0xA307", Offset = "0xA307", VA = "0xA307", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005568")]
		[Address(RVA = "0xA308", Offset = "0xA308", VA = "0xA308")]
		public AnnouncementsController(AnnouncementsService service, AnnouncementsModel model, AnnouncementsEvents events)
		{
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005569")]
		[Address(RVA = "0xA309", Offset = "0xA309", VA = "0xA309", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556A")]
		[Address(RVA = "0xA30A", Offset = "0xA30A", VA = "0xA30A", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556B")]
		[Address(RVA = "0xA30B", Offset = "0xA30B", VA = "0xA30B")]
		private void ValidateInit()
		{
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556C")]
		[Address(RVA = "0xA30C", Offset = "0xA30C", VA = "0xA30C")]
		private void WorldMoveCompleteEvent(WorldMovementTypes type)
		{
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556D")]
		[Address(RVA = "0xA30D", Offset = "0xA30D", VA = "0xA30D")]
		private void OpenNextWindow()
		{
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556E")]
		[Address(RVA = "0xA30E", Offset = "0xA30E", VA = "0xA30E")]
		private void RequestList()
		{
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556F")]
		[Address(RVA = "0xA30F", Offset = "0xA30F", VA = "0xA30F")]
		private void RequestRead(ulong id)
		{
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005570")]
		[Address(RVA = "0xA310", Offset = "0xA310", VA = "0xA310")]
		private void HandleThereIsNewAnnouncementsEvent(ProtoGetListCmd.Types.Ans msg)
		{
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005571")]
		[Address(RVA = "0xA311", Offset = "0xA311", VA = "0xA311")]
		private void HandleReadService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005572")]
		[Address(RVA = "0xA312", Offset = "0xA312", VA = "0xA312")]
		private void HandleGetListService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005573")]
		[Address(RVA = "0xA313", Offset = "0xA313", VA = "0xA313")]
		private void AddNotifications(IEnumerable<Announcement> values)
		{
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005574")]
		[Address(RVA = "0xA314", Offset = "0xA314", VA = "0xA314")]
		private void Notify()
		{
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005575")]
		[Address(RVA = "0xA315", Offset = "0xA315", VA = "0xA315")]
		public void ReadNotification(ulong id)
		{
		}

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		private const float DELAY_OPEN = 1f;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x18")]
		private AnnouncementsService _service;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x1C")]
		private Tween _delayTween;
	}
}
