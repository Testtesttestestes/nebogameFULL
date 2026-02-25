using System;
using System.Runtime.CompilerServices;
using Gameplay.RateGame.Controller;
using Gameplay.RateGame.Events;
using Gameplay.RateGame.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.RateGame.View
{
	// Token: 0x020005A4 RID: 1444
	[Token(Token = "0x20005A4")]
	public class RateGameWindow : BaseDialogWindow<RateGameWindow.RateGameWindowArgs>
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000653")]
		public RateWindowStateController StateController
		{
			[Token(Token = "0x60022B1")]
			[Address(RVA = "0x7408", Offset = "0x7408", VA = "0x7408")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000654")]
		public Button PositiveRateButton
		{
			[Token(Token = "0x60022B2")]
			[Address(RVA = "0x7409", Offset = "0x7409", VA = "0x7409")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000655")]
		public Button NegativeRateButton
		{
			[Token(Token = "0x60022B3")]
			[Address(RVA = "0x740A", Offset = "0x740A", VA = "0x740A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000656")]
		public Button RateGameButton
		{
			[Token(Token = "0x60022B4")]
			[Address(RVA = "0x740B", Offset = "0x740B", VA = "0x740B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x17000657")]
		public int CurrentRateValue
		{
			[Token(Token = "0x60022B5")]
			[Address(RVA = "0x740C", Offset = "0x740C", VA = "0x740C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400014A RID: 330
		// (add) Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014A")]
		public event Action CloseButtonClickEvent
		{
			[Token(Token = "0x60022B6")]
			[Address(RVA = "0x740D", Offset = "0x740D", VA = "0x740D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022B7")]
			[Address(RVA = "0x740E", Offset = "0x740E", VA = "0x740E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000658")]
		public override string WindowId
		{
			[Token(Token = "0x60022B8")]
			[Address(RVA = "0x740F", Offset = "0x740F", VA = "0x740F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x7410", Offset = "0x7410", VA = "0x7410", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x7411", Offset = "0x7411", VA = "0x7411", Slot = "22")]
		protected override void OnShow(RateGameWindow.RateGameWindowArgs args)
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x7412", Offset = "0x7412", VA = "0x7412")]
		private void StateControllerOnCurrentStateChangedEvent(RateGameWindow.RateGameWindowState fromState, RateGameWindow.RateGameWindowState toState)
		{
		}

		// Token: 0x17000659 RID: 1625
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000659")]
		private string Title
		{
			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x7413", Offset = "0x7413", VA = "0x7413")]
			set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065A")]
		private string Desc
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x7414", Offset = "0x7414", VA = "0x7414")]
			set
			{
			}
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x7415", Offset = "0x7415", VA = "0x7415", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x7416", Offset = "0x7416", VA = "0x7416", Slot = "25")]
		protected override void HandleCloseButton()
		{
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x7417", Offset = "0x7417", VA = "0x7417")]
		public RateGameWindow()
		{
		}

		// Token: 0x040012F0 RID: 4848
		[Token(Token = "0x40012F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RateGameComponent _rateGameComponent;

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RateWindowStateController _stateController;

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _rateGameButton;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Button _negativeRateButton;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _positiveRateButton;

		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/RateGameWindow";

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x68")]
		private RateGameWindowMediator _mediator;

		// Token: 0x020005A5 RID: 1445
		[Token(Token = "0x20005A5")]
		public enum RateGameWindowState
		{
			// Token: 0x040012F9 RID: 4857
			[Token(Token = "0x40012F9")]
			UNKNOWN_STATE,
			// Token: 0x040012FA RID: 4858
			[Token(Token = "0x40012FA")]
			DEFAULT,
			// Token: 0x040012FB RID: 4859
			[Token(Token = "0x40012FB")]
			NEGATIVE_FEEDBACK,
			// Token: 0x040012FC RID: 4860
			[Token(Token = "0x40012FC")]
			POSITIVE_FEEDBACK
		}

		// Token: 0x020005A6 RID: 1446
		[Token(Token = "0x20005A6")]
		public class RateGameWindowArgs : BaseDialogWindow<RateGameWindow.RateGameWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0x7418", Offset = "0x7418", VA = "0x7418")]
			public RateGameWindowArgs()
			{
			}

			// Token: 0x040012FD RID: 4861
			[Token(Token = "0x40012FD")]
			[FieldOffset(Offset = "0x2C")]
			public RateGameController Controller;

			// Token: 0x040012FE RID: 4862
			[Token(Token = "0x40012FE")]
			[FieldOffset(Offset = "0x30")]
			public RateGameModel Model;

			// Token: 0x040012FF RID: 4863
			[Token(Token = "0x40012FF")]
			[FieldOffset(Offset = "0x34")]
			public RateGameEvents Events;
		}
	}
}
