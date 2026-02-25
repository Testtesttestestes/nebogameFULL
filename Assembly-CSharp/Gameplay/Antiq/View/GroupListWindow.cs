using System;
using Core.Data;
using Core.Dict;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D7F RID: 3455
	[Token(Token = "0x2000D7F")]
	[AddComponentMenu("Antiq/View/GroupListWindow")]
	internal class GroupListWindow : ClosableBaseWindow<GroupListWindow.WindowArgs>
	{
		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600549B RID: 21659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001135")]
		public override string WindowId
		{
			[Token(Token = "0x600549B")]
			[Address(RVA = "0xA24A", Offset = "0xA24A", VA = "0xA24A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549C")]
		[Address(RVA = "0xA24B", Offset = "0xA24B", VA = "0xA24B", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549D")]
		[Address(RVA = "0xA24C", Offset = "0xA24C", VA = "0xA24C", Slot = "22")]
		protected override void OnShow(GroupListWindow.WindowArgs args)
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600549E")]
		[Address(RVA = "0xA24D", Offset = "0xA24D", VA = "0xA24D")]
		public GroupListWindow()
		{
		}

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Antiq/GroupListWindow";

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GroupListView _view;

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x44")]
		private Launch _launch;

		// Token: 0x02000D80 RID: 3456
		[Token(Token = "0x2000D80")]
		internal new class WindowArgs : BaseWindowArgs
		{
			// Token: 0x060054A0 RID: 21664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054A0")]
			[Address(RVA = "0xA24F", Offset = "0xA24F", VA = "0xA24F")]
			public WindowArgs(UserData user, IDictProvider dictProvider, PopupController popupController)
			{
			}

			// Token: 0x04002DCC RID: 11724
			[Token(Token = "0x4002DCC")]
			[FieldOffset(Offset = "0x18")]
			public readonly UserData User;

			// Token: 0x04002DCD RID: 11725
			[Token(Token = "0x4002DCD")]
			[FieldOffset(Offset = "0x1C")]
			public readonly IDictProvider DictProvider;

			// Token: 0x04002DCE RID: 11726
			[Token(Token = "0x4002DCE")]
			[FieldOffset(Offset = "0x20")]
			public readonly PopupController PopupController;
		}
	}
}
