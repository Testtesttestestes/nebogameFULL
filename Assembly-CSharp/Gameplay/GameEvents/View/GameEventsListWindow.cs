using System;
using Gameplay.GameEvents.Control;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GameEvents.View
{
	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	public class GameEventsListWindow : ClosableBaseWindow<GameEventsListWindow.GameEventsListWindowArgs>
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C9")]
		public override string WindowId
		{
			[Token(Token = "0x6002DB4")]
			[Address(RVA = "0x7E32", Offset = "0x7E32", VA = "0x7E32", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB5")]
		[Address(RVA = "0x7E33", Offset = "0x7E33", VA = "0x7E33", Slot = "22")]
		protected override void OnShow(GameEventsListWindow.GameEventsListWindowArgs args)
		{
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB6")]
		[Address(RVA = "0x7E34", Offset = "0x7E34", VA = "0x7E34")]
		private void HandleListOnReadyEvent(GameEventsListView listView)
		{
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB7")]
		[Address(RVA = "0x7E35", Offset = "0x7E35", VA = "0x7E35")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DB8")]
		[Address(RVA = "0x7E36", Offset = "0x7E36", VA = "0x7E36")]
		public GameEventsListWindow()
		{
		}

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GameEvents/GameEventsListWindow";

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameEventsListView eventsListView;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x40")]
		private GameEventsListViewMediator _mediator;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x44")]
		private GameEventsListWindow.GameEventsListWindowArgs _listWindowArgs;

		// Token: 0x02000780 RID: 1920
		[Token(Token = "0x2000780")]
		public class GameEventsListWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002DB9 RID: 11705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DB9")]
			[Address(RVA = "0x7E37", Offset = "0x7E37", VA = "0x7E37")]
			public GameEventsListWindowArgs()
			{
			}

			// Token: 0x04001916 RID: 6422
			[Token(Token = "0x4001916")]
			[FieldOffset(Offset = "0x18")]
			public GameEventsModel Model;

			// Token: 0x04001917 RID: 6423
			[Token(Token = "0x4001917")]
			[FieldOffset(Offset = "0x1C")]
			public GameEventsController Controller;
		}
	}
}
