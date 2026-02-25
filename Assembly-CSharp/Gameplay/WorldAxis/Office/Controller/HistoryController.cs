using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.History;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	public class HistoryController : AbstractController<HistoryModel, HistoryEvents>
	{
		// Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114D")]
		[Address(RVA = "0x634A", Offset = "0x634A", VA = "0x634A")]
		public HistoryController(HistoryModel model, HistoryEvents events)
		{
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x634B", Offset = "0x634B", VA = "0x634B", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x634C", Offset = "0x634C", VA = "0x634C")]
		public void GetFirstHistory(uint colossusId, bool clanBattles)
		{
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x634D", Offset = "0x634D", VA = "0x634D")]
		private void GetFirstHistoryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x634E", Offset = "0x634E", VA = "0x634E")]
		public void GetHistory(uint pageNumber, uint colossusId, bool clanBattles)
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x634F", Offset = "0x634F", VA = "0x634F")]
		private void GetHistoryResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x6350", Offset = "0x6350", VA = "0x6350")]
		public void GetBattleInfo(BattleHistoryListElement.BattleHistoryListElementArgs args)
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x6351", Offset = "0x6351", VA = "0x6351")]
		private void GetBattleInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x6352", Offset = "0x6352", VA = "0x6352", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
