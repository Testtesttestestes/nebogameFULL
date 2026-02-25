using System;
using Core.Data;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Collections.Controller
{
	// Token: 0x020009E7 RID: 2535
	[Token(Token = "0x20009E7")]
	public class CollectionsController : AbstractController<CollectionsModel, CollectionsEvents>
	{
		// Token: 0x06003C89 RID: 15497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x8B50", Offset = "0x8B50", VA = "0x8B50")]
		public CollectionsController(CollectionsModel model, CollectionsEvents events)
		{
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x8B51", Offset = "0x8B51", VA = "0x8B51", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x8B52", Offset = "0x8B52", VA = "0x8B52", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x8B53", Offset = "0x8B53", VA = "0x8B53")]
		public void ScheduleCheckProgress(CollectionData data)
		{
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x8B54", Offset = "0x8B54", VA = "0x8B54")]
		private void MedalAddedEventHandler(MedalInfo info)
		{
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x8B55", Offset = "0x8B55", VA = "0x8B55")]
		private void MedalRemovedEventHandler(uint medalId)
		{
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x8B56", Offset = "0x8B56", VA = "0x8B56")]
		private void DependenciesChangedEventHandler()
		{
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x8B57", Offset = "0x8B57", VA = "0x8B57")]
		private void GetUserCollections()
		{
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x8B58", Offset = "0x8B58", VA = "0x8B58")]
		private void GetUserCollectionsSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x8B59", Offset = "0x8B59", VA = "0x8B59")]
		public void ImproveUserCollection(CollectionData data)
		{
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x8B5A", Offset = "0x8B5A", VA = "0x8B5A")]
		private void ImproveUserCollectionResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x8B5B", Offset = "0x8B5B", VA = "0x8B5B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0400217B RID: 8571
		[Token(Token = "0x400217B")]
		[FieldOffset(Offset = "0x18")]
		private CollectionsService _collectionService;

		// Token: 0x0400217C RID: 8572
		[Token(Token = "0x400217C")]
		[FieldOffset(Offset = "0x1C")]
		private CollectionData _scheduledData;
	}
}
