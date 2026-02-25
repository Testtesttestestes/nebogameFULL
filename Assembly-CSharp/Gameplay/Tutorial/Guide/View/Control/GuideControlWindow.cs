using System;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Control
{
	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	public class GuideControlWindow : ClosableBaseWindow<GuideControlWindow.GuideControlWindowArgs>
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B2")]
		public override string WindowId
		{
			[Token(Token = "0x6001AF4")]
			[Address(RVA = "0x6C7E", Offset = "0x6C7E", VA = "0x6C7E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x6C7F", Offset = "0x6C7F", VA = "0x6C7F", Slot = "22")]
		protected override void OnShow(GuideControlWindow.GuideControlWindowArgs args)
		{
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x6C80", Offset = "0x6C80", VA = "0x6C80", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x6C81", Offset = "0x6C81", VA = "0x6C81")]
		public GuideControlWindow()
		{
		}

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Guide/GuideControlWindow";

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GuideControlView _view;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x40")]
		private GuideControlViewMediator _viewMediator;

		// Token: 0x02000473 RID: 1139
		[Token(Token = "0x2000473")]
		public class GuideControlWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001AF8 RID: 6904 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001AF8")]
			[Address(RVA = "0x6C82", Offset = "0x6C82", VA = "0x6C82")]
			public GuideControlWindowArgs()
			{
			}
		}
	}
}
