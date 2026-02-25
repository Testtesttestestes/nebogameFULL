using System;
using Core.Application;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.View.EntryPoint;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.GdEvents.Control.EntryPoint
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public class GdEventsIndexEpViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, GdEventsIndexEpView>
	{
		// Token: 0x06002D74 RID: 11636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x7DF2", Offset = "0x7DF2", VA = "0x7DF2", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x7DF3", Offset = "0x7DF3", VA = "0x7DF3")]
		public GdEventsIndexEpViewMediator(IApp app, GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		}

		// Token: 0x170008B8 RID: 2232
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B8")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D76")]
			[Address(RVA = "0x7DF4", Offset = "0x7DF4", VA = "0x7DF4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B9")]
		public override GdEventsIndexEpView View
		{
			[Token(Token = "0x6002D77")]
			[Address(RVA = "0x7DF5", Offset = "0x7DF5", VA = "0x7DF5", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x7DF6", Offset = "0x7DF6", VA = "0x7DF6")]
		private void SetupView()
		{
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x7DF7", Offset = "0x7DF7", VA = "0x7DF7")]
		private void ResetView()
		{
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x7DF8", Offset = "0x7DF8", VA = "0x7DF8")]
		private void HandleEpClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x7DF9", Offset = "0x7DF9", VA = "0x7DF9")]
		private void HandleCategoriesContentChangedEvent()
		{
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x7DFA", Offset = "0x7DFA", VA = "0x7DFA")]
		private void HandleCurrentEventChangedEvent(GdEventData from, GdEventData to)
		{
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x7DFB", Offset = "0x7DFB", VA = "0x7DFB")]
		private void ValidateNotViewedEvents(AbstractGdEventCatData category)
		{
		}

		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x18")]
		private IApp _app;
	}
}
