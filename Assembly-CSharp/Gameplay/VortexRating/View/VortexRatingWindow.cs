using System;
using Gameplay.VortexRating.Controller;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.GreatOnesTab;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Gameplay.VortexRating.View.RulesTab;
using Gameplay.VortexRating.View.VortexTab;
using Gameplay.VortexRating.View.VoteRewardsTab;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	public class VortexRatingWindow : ClosableBaseWindow<VortexRatingWindow.VortexWindowArgs>
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036C")]
		public override string WindowId
		{
			[Token(Token = "0x60014F8")]
			[Address(RVA = "0x66BA", Offset = "0x66BA", VA = "0x66BA", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036D")]
		public TabBar TabBarView
		{
			[Token(Token = "0x60014F9")]
			[Address(RVA = "0x66BB", Offset = "0x66BB", VA = "0x66BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036E")]
		public GreatOnesView GreatOnesTab
		{
			[Token(Token = "0x60014FA")]
			[Address(RVA = "0x66BC", Offset = "0x66BC", VA = "0x66BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036F")]
		public VoteRewardsView VoteRewardsTab
		{
			[Token(Token = "0x60014FB")]
			[Address(RVA = "0x66BD", Offset = "0x66BD", VA = "0x66BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000370")]
		public RulesView RulesTab
		{
			[Token(Token = "0x60014FC")]
			[Address(RVA = "0x66BE", Offset = "0x66BE", VA = "0x66BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000371")]
		public GreatPrizesView GreatPrizesTab
		{
			[Token(Token = "0x60014FD")]
			[Address(RVA = "0x66BF", Offset = "0x66BF", VA = "0x66BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000372")]
		public VortexView VortexTab
		{
			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x66C0", Offset = "0x66C0", VA = "0x66C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000373")]
		public Button InRatingButton
		{
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x66C1", Offset = "0x66C1", VA = "0x66C1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x66C2", Offset = "0x66C2", VA = "0x66C2", Slot = "22")]
		protected override void OnShow(VortexRatingWindow.VortexWindowArgs args)
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x66C3", Offset = "0x66C3", VA = "0x66C3", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x66C4", Offset = "0x66C4", VA = "0x66C4")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x66C5", Offset = "0x66C5", VA = "0x66C5")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x66C6", Offset = "0x66C6", VA = "0x66C6")]
		public VortexRatingWindow()
		{
		}

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Vortex/VortexRatingWindow";

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GreatOnesView _greatOnesTab;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private VoteRewardsView _voteRewardsTab;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RulesView _rulesTab;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GreatPrizesView _greatPrizesTab;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VortexView _vortexTab;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _inRatingButton;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x58")]
		private VortexRatingModel _model;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x5C")]
		private VortexRatingEvents _events;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x60")]
		private VortexRatingController _controller;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x64")]
		private VortexRatingViewMediator _mediator;

		// Token: 0x02000385 RID: 901
		[Token(Token = "0x2000385")]
		public class VortexWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001505")]
			[Address(RVA = "0x66C7", Offset = "0x66C7", VA = "0x66C7")]
			public VortexWindowArgs()
			{
			}
		}
	}
}
