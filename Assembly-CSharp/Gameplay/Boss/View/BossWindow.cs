using System;
using Gameplay.Boss.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B4B RID: 2891
	[Token(Token = "0x2000B4B")]
	public class BossWindow : ClosableBaseWindow<BossWindowArgs>
	{
		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC6")]
		public override string WindowId
		{
			[Token(Token = "0x60045FE")]
			[Address(RVA = "0x9498", Offset = "0x9498", VA = "0x9498", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060045FF RID: 17919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC7")]
		public TabBar TabBar
		{
			[Token(Token = "0x60045FF")]
			[Address(RVA = "0x9499", Offset = "0x9499", VA = "0x9499")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DC8")]
		public BossWindowStateController BossWindowStateController
		{
			[Token(Token = "0x6004600")]
			[Address(RVA = "0x949A", Offset = "0x949A", VA = "0x949A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x949B", Offset = "0x949B", VA = "0x949B", Slot = "22")]
		protected override void OnShow(BossWindowArgs args)
		{
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x949C", Offset = "0x949C", VA = "0x949C", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x949D", Offset = "0x949D", VA = "0x949D")]
		public BossWindow()
		{
		}

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Boss/BossWindow";

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BossWindowStateController bossWindowStateController;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MonoBehaviour[] _views;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x48")]
		private BossWindowMediator _mediator;
	}
}
