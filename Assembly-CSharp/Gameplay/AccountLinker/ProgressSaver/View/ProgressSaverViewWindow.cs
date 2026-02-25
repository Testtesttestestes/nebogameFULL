using System;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.AccountLinker.ProgressSaver.View
{
	// Token: 0x02000E0B RID: 3595
	[Token(Token = "0x2000E0B")]
	public class ProgressSaverViewWindow : ClosableBaseWindow<ProgressSaverViewWindow.ProgressSaverViewWindowArgs>
	{
		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011E2")]
		public override string WindowId
		{
			[Token(Token = "0x6005791")]
			[Address(RVA = "0xA50C", Offset = "0xA50C", VA = "0xA50C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005792")]
		[Address(RVA = "0xA50D", Offset = "0xA50D", VA = "0xA50D", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005793")]
		[Address(RVA = "0xA50E", Offset = "0xA50E", VA = "0xA50E", Slot = "22")]
		protected override void OnShow(ProgressSaverViewWindow.ProgressSaverViewWindowArgs args)
		{
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005794")]
		[Address(RVA = "0xA50F", Offset = "0xA50F", VA = "0xA50F")]
		public ProgressSaverViewWindow()
		{
		}

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/AccountLinker/ProgressSaverFeature/ProgressSaverWindow";

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ProgressSaverView _view;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x40")]
		private ProgressSaverViewMediator _mediator;

		// Token: 0x02000E0C RID: 3596
		[Token(Token = "0x2000E0C")]
		public class ProgressSaverViewWindowArgs : BaseWindowArgs
		{
			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x06005795 RID: 22421 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170011E3")]
			public ProgressSaverController Controller
			{
				[Token(Token = "0x6005795")]
				[Address(RVA = "0xA510", Offset = "0xA510", VA = "0xA510")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06005796 RID: 22422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005796")]
			[Address(RVA = "0xA511", Offset = "0xA511", VA = "0xA511")]
			public ProgressSaverViewWindowArgs(ProgressSaverController controller)
			{
			}
		}
	}
}
