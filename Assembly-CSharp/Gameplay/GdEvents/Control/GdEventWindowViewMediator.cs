using System;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.View.EventView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.GdEvents.Control
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	public class GdEventWindowViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, GdEventWindow>
	{
		// Token: 0x06002D0B RID: 11531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x7D89", Offset = "0x7D89", VA = "0x7D89")]
		public GdEventWindowViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		}

		// Token: 0x170008AE RID: 2222
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AE")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D0C")]
			[Address(RVA = "0x7D8A", Offset = "0x7D8A", VA = "0x7D8A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170008AF RID: 2223
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AF")]
		public override GdEventWindow View
		{
			[Token(Token = "0x6002D0D")]
			[Address(RVA = "0x7D8B", Offset = "0x7D8B", VA = "0x7D8B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x7D8C", Offset = "0x7D8C", VA = "0x7D8C")]
		private void ResetView()
		{
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x7D8D", Offset = "0x7D8D", VA = "0x7D8D")]
		private void SetupView()
		{
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x7D8E", Offset = "0x7D8E", VA = "0x7D8E")]
		private void HandleTabBarChangedEvent()
		{
		}
	}
}
