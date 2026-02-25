using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.History;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	public class HistoryViewMediator : AbstractViewMediator<HistoryModel, HistoryEvents, HistoryController, HistoryView>, IHideableMediator
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x6353", Offset = "0x6353", VA = "0x6353")]
		public HistoryViewMediator(HistoryModel model, HistoryEvents events, HistoryController controller)
		{
		}

		// Token: 0x17000290 RID: 656
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		public override HistoryView View
		{
			[Token(Token = "0x6001157")]
			[Address(RVA = "0x6354", Offset = "0x6354", VA = "0x6354", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x6355", Offset = "0x6355", VA = "0x6355")]
		private void ResetView()
		{
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x6356", Offset = "0x6356", VA = "0x6356")]
		private void SetupView()
		{
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x6357", Offset = "0x6357", VA = "0x6357")]
		private void ToggleChangedEventHandler()
		{
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x6358", Offset = "0x6358", VA = "0x6358")]
		private void ExtraFilterDeselectedEventHandler()
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x6359", Offset = "0x6359", VA = "0x6359")]
		private void ColossusFilterSelectedEventHandler(object data)
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x635A", Offset = "0x635A", VA = "0x635A")]
		private void RequestFirstHistory()
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x635B", Offset = "0x635B", VA = "0x635B")]
		private void BackButtonClickedEventHandler()
		{
		}

		// Token: 0x17000291 RID: 657
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000291")]
		public override HistoryEvents Events
		{
			[Token(Token = "0x600115F")]
			[Address(RVA = "0x635C", Offset = "0x635C", VA = "0x635C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x635D", Offset = "0x635D", VA = "0x635D")]
		private void BattleInfoRequestedEventHandler()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x635E", Offset = "0x635E", VA = "0x635E")]
		private void FirstHistoryRequestedEventHandler()
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x635F", Offset = "0x635F", VA = "0x635F")]
		private void HistoryRequestedEventHandler()
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x6360", Offset = "0x6360", VA = "0x6360")]
		private void MoreItemsAfterNeededEventHandler()
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x6361", Offset = "0x6361", VA = "0x6361")]
		private void UpdateOSARequestBounds()
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x6362", Offset = "0x6362", VA = "0x6362")]
		private void InjectCallback()
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x6363", Offset = "0x6363", VA = "0x6363")]
		private void ListElementClickedEventHandler(BattleHistoryListElement element)
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x6364", Offset = "0x6364", VA = "0x6364", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0x18")]
		private uint _colossusId;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isInit;
	}
}
