using System;
using Gameplay.ThemeDuel.Controller;
using Gameplay.ThemeDuel.Events;
using Gameplay.ThemeDuel.Model;
using Gameplay.ThemeDuel.View.RatingTab;
using Gameplay.ThemeDuel.View.RulesTab;
using Gameplay.ThemeDuel.View.ShopTab;
using Il2CppDummyDll;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.ThemeDuel.View
{
	// Token: 0x020004DB RID: 1243
	[Token(Token = "0x20004DB")]
	public class ThemeDuelWindow : ClosableBaseWindow<ThemeDuelWindow.ThemeDuelWindowArgs>
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054B")]
		public override string WindowId
		{
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x6F21", Offset = "0x6F21", VA = "0x6F21", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054C")]
		public TabBar TabBarView
		{
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0x6F22", Offset = "0x6F22", VA = "0x6F22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054D")]
		public RatingView RatingTab
		{
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0x6F23", Offset = "0x6F23", VA = "0x6F23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054E")]
		public ShopView ShopTab
		{
			[Token(Token = "0x6001DA6")]
			[Address(RVA = "0x6F24", Offset = "0x6F24", VA = "0x6F24")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700054F")]
		public RulesView RulesTab
		{
			[Token(Token = "0x6001DA7")]
			[Address(RVA = "0x6F25", Offset = "0x6F25", VA = "0x6F25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000550")]
		public TextMeshProUGUI EventTitle
		{
			[Token(Token = "0x6001DA8")]
			[Address(RVA = "0x6F26", Offset = "0x6F26", VA = "0x6F26")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x6F27", Offset = "0x6F27", VA = "0x6F27", Slot = "22")]
		protected override void OnShow(ThemeDuelWindow.ThemeDuelWindowArgs args)
		{
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAA")]
		[Address(RVA = "0x6F28", Offset = "0x6F28", VA = "0x6F28", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAB")]
		[Address(RVA = "0x6F29", Offset = "0x6F29", VA = "0x6F29")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAC")]
		[Address(RVA = "0x6F2A", Offset = "0x6F2A", VA = "0x6F2A")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DAD")]
		[Address(RVA = "0x6F2B", Offset = "0x6F2B", VA = "0x6F2B")]
		public ThemeDuelWindow()
		{
		}

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/ThemeDuel/ThemeDuelWindow";

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RulesView _rulesTab;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RatingView _ratingTab;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ShopView _shopTab;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _eventTitle;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x50")]
		private ThemeDuelModel _model;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x54")]
		private ThemeDuelEvents _events;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x58")]
		private ThemeDuelController _controller;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x5C")]
		private ThemeDuelViewMediator _mediator;

		// Token: 0x020004DC RID: 1244
		[Token(Token = "0x20004DC")]
		public class ThemeDuelWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001DAE RID: 7598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x6F2C", Offset = "0x6F2C", VA = "0x6F2C")]
			public ThemeDuelWindowArgs(ThemeDuelTargets targetForShow)
			{
			}

			// Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DAF")]
			[Address(RVA = "0x6F2D", Offset = "0x6F2D", VA = "0x6F2D")]
			public ThemeDuelWindowArgs()
			{
			}

			// Token: 0x04001020 RID: 4128
			[Token(Token = "0x4001020")]
			[FieldOffset(Offset = "0x18")]
			public readonly ThemeDuelTargets TargetForShow;
		}
	}
}
