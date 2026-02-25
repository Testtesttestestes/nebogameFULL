using System;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public class GameEventsEnterPointViewMediator : AbstractViewMediator<GameEventsModel, GameEventsEvents, GameEventsController, UserInterfaceView>
	{
		// Token: 0x06002F64 RID: 12132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F64")]
		[Address(RVA = "0x7FCA", Offset = "0x7FCA", VA = "0x7FCA", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x7FCB", Offset = "0x7FCB", VA = "0x7FCB")]
		public GameEventsEnterPointViewMediator(GameEventsModel model, GameEventsEvents events, GameEventsController controller)
		{
		}

		// Token: 0x17000938 RID: 2360
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000938")]
		public override GameEventsEvents Events
		{
			[Token(Token = "0x6002F66")]
			[Address(RVA = "0x7FCC", Offset = "0x7FCC", VA = "0x7FCC", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000939 RID: 2361
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000939")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6002F67")]
			[Address(RVA = "0x7FCD", Offset = "0x7FCD", VA = "0x7FCD", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F68")]
		[Address(RVA = "0x7FCE", Offset = "0x7FCE", VA = "0x7FCE")]
		private void HandleSetupView()
		{
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x7FCF", Offset = "0x7FCF", VA = "0x7FCF")]
		private void ShowGameEvents(EventCategoriesDic category)
		{
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x7FD0", Offset = "0x7FD0", VA = "0x7FD0")]
		private void HandleOnCloseEventEventsWindows()
		{
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x7FD1", Offset = "0x7FD1", VA = "0x7FD1")]
		private void CloseGameEvents()
		{
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x7FD2", Offset = "0x7FD2", VA = "0x7FD2")]
		private void HandleGameEventsButtonClickedEvent(IndexButtonBasic button)
		{
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x7FD3", Offset = "0x7FD3", VA = "0x7FD3")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6E")]
		[Address(RVA = "0x7FD4", Offset = "0x7FD4", VA = "0x7FD4")]
		private void HandleOpenRequestEvent(EventCategoriesDic category)
		{
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6F")]
		[Address(RVA = "0x7FD5", Offset = "0x7FD5", VA = "0x7FD5")]
		private void HandleCloseRequestEvent()
		{
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F70")]
		[Address(RVA = "0x7FD6", Offset = "0x7FD6", VA = "0x7FD6")]
		private void HandleNotViewedEventCountChanged(int count)
		{
		}

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[FieldOffset(Offset = "0x18")]
		private GameEventsListWindow _eventsWindow;
	}
}
