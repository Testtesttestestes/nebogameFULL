using System;
using Core.MVC.Interfaces;
using Gameplay.Competition.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Competition.View
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	[AddComponentMenu("Competition/View/CompetitionWindow")]
	public class CompetitionWindow : ClosableBaseWindow<CompetitionWindow.CompetitionWindowArgs>
	{
		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A8B")]
		public override string WindowId
		{
			[Token(Token = "0x600355B")]
			[Address(RVA = "0x857E", Offset = "0x857E", VA = "0x857E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x857F", Offset = "0x857F", VA = "0x857F", Slot = "22")]
		protected override void OnShow(CompetitionWindow.CompetitionWindowArgs args)
		{
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x8580", Offset = "0x8580", VA = "0x8580", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x8581", Offset = "0x8581", VA = "0x8581")]
		public CompetitionWindow()
		{
		}

		// Token: 0x04001D2F RID: 7471
		[Token(Token = "0x4001D2F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Competition/CompetitionWindow";

		// Token: 0x04001D30 RID: 7472
		[Token(Token = "0x4001D30")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CompetitionView _view;

		// Token: 0x04001D31 RID: 7473
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x020008DB RID: 2267
		[Token(Token = "0x20008DB")]
		public class CompetitionWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600355F RID: 13663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600355F")]
			[Address(RVA = "0x8582", Offset = "0x8582", VA = "0x8582")]
			public CompetitionWindowArgs(CompetitionController controller)
			{
			}

			// Token: 0x04001D32 RID: 7474
			[Token(Token = "0x4001D32")]
			[FieldOffset(Offset = "0x18")]
			public readonly CompetitionController Controller;
		}
	}
}
