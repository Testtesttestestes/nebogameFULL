using System;
using Gameplay.Boss.Controller;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using UI;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public class BossMinionWindow : ClosableBaseWindow<BossMinionWindowArgs>
	{
		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC2")]
		public override string WindowId
		{
			[Token(Token = "0x60045F4")]
			[Address(RVA = "0x948E", Offset = "0x948E", VA = "0x948E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC3")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x60045F5")]
			[Address(RVA = "0x948F", Offset = "0x948F", VA = "0x948F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC4")]
		public BacktimeViewUGUI BacktimeViewUGUI
		{
			[Token(Token = "0x60045F6")]
			[Address(RVA = "0x9490", Offset = "0x9490", VA = "0x9490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC5")]
		public MonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x60045F7")]
			[Address(RVA = "0x9491", Offset = "0x9491", VA = "0x9491")]
			get
			{
				return null;
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x9492", Offset = "0x9492", VA = "0x9492", Slot = "22")]
		protected override void OnShow(BossMinionWindowArgs args)
		{
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x9493", Offset = "0x9493", VA = "0x9493", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x9494", Offset = "0x9494", VA = "0x9494", Slot = "17")]
		public override bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x9495", Offset = "0x9495", VA = "0x9495")]
		public BossMinionWindow()
		{
		}

		// Token: 0x0400262C RID: 9772
		[Token(Token = "0x400262C")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossMinionWindow";

		// Token: 0x0400262D RID: 9773
		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MonsterInfoView _monsterInfoView;

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x0400262F RID: 9775
		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x04002630 RID: 9776
		[Token(Token = "0x4002630")]
		[FieldOffset(Offset = "0x48")]
		private BossMinionWindowMediator _mediator;
	}
}
