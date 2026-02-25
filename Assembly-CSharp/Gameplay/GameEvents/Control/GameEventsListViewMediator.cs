using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	public class GameEventsListViewMediator : AbstractCozyViewMediator<GameEventsModel, GameEventsEvents, GameEventsController, GameEventsListView>
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0x7FD7", Offset = "0x7FD7", VA = "0x7FD7", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F72")]
		[Address(RVA = "0x7FD8", Offset = "0x7FD8", VA = "0x7FD8")]
		public GameEventsListViewMediator(GameEventsModel model, GameEventsEvents events, GameEventsController controller)
		{
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x7FD9", Offset = "0x7FD9", VA = "0x7FD9")]
		private void HandleEventProcessCompleteEvent(GameEventData evt)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x7FDA", Offset = "0x7FDA", VA = "0x7FDA")]
		private void HandleEventsHasBeenDeletedEvent(IList<GameEventData> items)
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x7FDB", Offset = "0x7FDB", VA = "0x7FDB", Slot = "21")]
		protected override void ResetEvents(GameEventsEvents events)
		{
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x7FDC", Offset = "0x7FDC", VA = "0x7FDC", Slot = "22")]
		protected override void SetupEvents(GameEventsEvents events)
		{
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F77")]
		[Address(RVA = "0x7FDD", Offset = "0x7FDD", VA = "0x7FDD", Slot = "23")]
		protected override void ResetView(GameEventsListView view)
		{
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F78")]
		[Address(RVA = "0x7FDE", Offset = "0x7FDE", VA = "0x7FDE", Slot = "24")]
		protected override void SetupView(GameEventsListView view)
		{
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x7FDF", Offset = "0x7FDF", VA = "0x7FDF")]
		private void HandleClickCancelEditEvent()
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x7FE0", Offset = "0x7FE0", VA = "0x7FE0")]
		private void HandleClickDeleteEvent()
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0x7FE1", Offset = "0x7FE1", VA = "0x7FE1")]
		private void HandleClickSelectAllEvent(bool selected)
		{
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0x7FE2", Offset = "0x7FE2", VA = "0x7FE2")]
		private void HandleTabBarChangedEvent()
		{
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0x7FE3", Offset = "0x7FE3", VA = "0x7FE3")]
		private void HandleItemClick(object sender, GameEventData evt)
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0x7FE4", Offset = "0x7FE4", VA = "0x7FE4")]
		private void HandleItemSelect(object sender, GameEventsListView.GameEventsListItemWrapper wrapper)
		{
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0x7FE5", Offset = "0x7FE5", VA = "0x7FE5")]
		private void HandleNotViewedEventInCategoryCountChanged(EventCategoriesDic.Types.Category category, int count)
		{
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0x7FE6", Offset = "0x7FE6", VA = "0x7FE6")]
		private void HandleCurrentReadEventChanged(GameEventData evt)
		{
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x7FE7", Offset = "0x7FE7", VA = "0x7FE7")]
		private void SetSelectAll(bool value)
		{
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x7FE8", Offset = "0x7FE8", VA = "0x7FE8")]
		private void SetViewState(GameEventsListView.GameEventsListViewStates state)
		{
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x7FE9", Offset = "0x7FE9", VA = "0x7FE9")]
		private void DefineSelectedTabContainsRewards()
		{
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x7FEA", Offset = "0x7FEA", VA = "0x7FEA")]
		private void DisplayList(List<GameEventData> events)
		{
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x7FEB", Offset = "0x7FEB", VA = "0x7FEB")]
		private TabBarItemData[] CategoriesToTabs(List<EventCategoriesDic> items)
		{
			return null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x7FEC", Offset = "0x7FEC", VA = "0x7FEC")]
		private void ShowReadWindow(GameEventData evt)
		{
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x7FED", Offset = "0x7FED", VA = "0x7FED")]
		private void HandleOnCloseReadWindow()
		{
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x7FEE", Offset = "0x7FEE", VA = "0x7FEE")]
		private void CloseReadWindow()
		{
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x7FEF", Offset = "0x7FEF", VA = "0x7FEF")]
		private void DeleteWhitConfirm(IList<GameEventsListView.GameEventsListItemWrapper> events)
		{
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x7FF0", Offset = "0x7FF0", VA = "0x7FF0")]
		private void Delete(IList<GameEventsListView.GameEventsListItemWrapper> events)
		{
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x7FF1", Offset = "0x7FF1", VA = "0x7FF1")]
		private List<GameEventData> GetSelectedEvents(IList<GameEventsListView.GameEventsListItemWrapper> eventsForDelete)
		{
			return null;
		}

		// Token: 0x040019DC RID: 6620
		[Token(Token = "0x40019DC")]
		[FieldOffset(Offset = "0x18")]
		public int CurrentCountSelectedItemsForDelete;

		// Token: 0x040019DD RID: 6621
		[Token(Token = "0x40019DD")]
		[FieldOffset(Offset = "0x1C")]
		private GameEventReadViewWindow _eventReadViewWindow;
	}
}
