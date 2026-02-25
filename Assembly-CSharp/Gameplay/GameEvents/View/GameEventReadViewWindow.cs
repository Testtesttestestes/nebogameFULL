using System;
using Gameplay.GameEvents.Control;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GameEvents.View
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	public class GameEventReadViewWindow : ClosableBaseWindow<GameEventReadViewWindow.GameEventReadViewWindowArgs>
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C1")]
		public override string WindowId
		{
			[Token(Token = "0x6002D93")]
			[Address(RVA = "0x7E11", Offset = "0x7E11", VA = "0x7E11", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x7E12", Offset = "0x7E12", VA = "0x7E12")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x7E13", Offset = "0x7E13", VA = "0x7E13", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x7E14", Offset = "0x7E14", VA = "0x7E14", Slot = "22")]
		protected override void OnShow(GameEventReadViewWindow.GameEventReadViewWindowArgs args)
		{
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x7E15", Offset = "0x7E15", VA = "0x7E15")]
		public GameEventReadViewWindow()
		{
		}

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GameEvents/GameEventReadViewWindow";

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameEventReadView _view;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0x40")]
		private GameEventReadViewMediator _mediator;

		// Token: 0x0200077B RID: 1915
		[Token(Token = "0x200077B")]
		public class GameEventReadViewWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002D98 RID: 11672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002D98")]
			[Address(RVA = "0x7E16", Offset = "0x7E16", VA = "0x7E16")]
			public GameEventReadViewWindowArgs()
			{
			}

			// Token: 0x040018FB RID: 6395
			[Token(Token = "0x40018FB")]
			[FieldOffset(Offset = "0x18")]
			public GameEventsModel Model;

			// Token: 0x040018FC RID: 6396
			[Token(Token = "0x40018FC")]
			[FieldOffset(Offset = "0x1C")]
			public GameEventsController Controller;

			// Token: 0x040018FD RID: 6397
			[Token(Token = "0x40018FD")]
			[FieldOffset(Offset = "0x20")]
			public GameEventData EventData;
		}
	}
}
