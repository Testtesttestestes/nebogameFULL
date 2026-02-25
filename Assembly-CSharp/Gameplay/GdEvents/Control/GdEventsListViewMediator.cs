using System;
using System.Collections.Generic;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.View.EventsList;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.GdEvents.Control
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	public class GdEventsListViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, GdEventsListView>
	{
		// Token: 0x06002D26 RID: 11558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x7DA4", Offset = "0x7DA4", VA = "0x7DA4", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x7DA5", Offset = "0x7DA5", VA = "0x7DA5")]
		public GdEventsListViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		}

		// Token: 0x170008B0 RID: 2224
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B0")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D28")]
			[Address(RVA = "0x7DA6", Offset = "0x7DA6", VA = "0x7DA6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x7DA7", Offset = "0x7DA7", VA = "0x7DA7")]
		private void HandleCurrentEventChangedEvent(GdEventData from, GdEventData to)
		{
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x7DA8", Offset = "0x7DA8", VA = "0x7DA8")]
		private void HandleCategoriesContentChangedEvent()
		{
		}

		// Token: 0x170008B1 RID: 2225
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B1")]
		public override GdEventsListView View
		{
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x7DA9", Offset = "0x7DA9", VA = "0x7DA9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0x7DAA", Offset = "0x7DAA", VA = "0x7DAA")]
		private void SetupView()
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x7DAB", Offset = "0x7DAB", VA = "0x7DAB")]
		private void ResetView()
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x7DAC", Offset = "0x7DAC", VA = "0x7DAC")]
		private void DisplayData(IList<AbstractGdEventCatData> categories)
		{
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x7DAD", Offset = "0x7DAD", VA = "0x7DAD")]
		private void HandleListClickEvent(CellModel data)
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x7DAE", Offset = "0x7DAE", VA = "0x7DAE")]
		private void ShowEvtWindow()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x7DAF", Offset = "0x7DAF", VA = "0x7DAF")]
		private void GdEventWindowOnClose()
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x7DB0", Offset = "0x7DB0", VA = "0x7DB0")]
		private bool TryClosePopupWindow()
		{
			return default(bool);
		}

		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x18")]
		private BaseWindow _gdEventWindow;
	}
}
