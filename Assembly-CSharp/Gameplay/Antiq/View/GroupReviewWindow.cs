using System;
using Core.MVC.Interfaces;
using Gameplay.Antiq.Control;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D85 RID: 3461
	[Token(Token = "0x2000D85")]
	[AddComponentMenu("Antiq/View/GroupReviewWindow")]
	internal class GroupReviewWindow : ClosableBaseWindow<GroupReviewWindow.WindowArgs>
	{
		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001145")]
		public override string WindowId
		{
			[Token(Token = "0x60054B8")]
			[Address(RVA = "0xA265", Offset = "0xA265", VA = "0xA265", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0xA266", Offset = "0xA266", VA = "0xA266", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0xA267", Offset = "0xA267", VA = "0xA267", Slot = "22")]
		protected override void OnShow(GroupReviewWindow.WindowArgs args)
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0xA268", Offset = "0xA268", VA = "0xA268")]
		public GroupReviewWindow()
		{
		}

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Antiq/GroupReviewWindow";

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GroupReviewView _view;

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x40")]
		private IViewMediator _mediator;

		// Token: 0x02000D86 RID: 3462
		[Token(Token = "0x2000D86")]
		internal new class WindowArgs : BaseWindowArgs
		{
			// Token: 0x060054BC RID: 21692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60054BC")]
			[Address(RVA = "0x1F41", Offset = "0x1F41", VA = "0x1F41")]
			public WindowArgs(AntiqController controller)
			{
			}

			// Token: 0x04002DE9 RID: 11753
			[Token(Token = "0x4002DE9")]
			[FieldOffset(Offset = "0x18")]
			public readonly AntiqController Controller;
		}
	}
}
