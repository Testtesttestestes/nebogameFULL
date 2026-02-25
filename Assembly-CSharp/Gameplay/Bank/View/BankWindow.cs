using System;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C49 RID: 3145
	[Token(Token = "0x2000C49")]
	public class BankWindow : ClosableBaseWindow<BankWindow.BankWindowArgs>
	{
		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F75")]
		public override string WindowId
		{
			[Token(Token = "0x6004CB3")]
			[Address(RVA = "0x9AF4", Offset = "0x9AF4", VA = "0x9AF4", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F76")]
		public BankOptionsListView BankOptionsListView
		{
			[Token(Token = "0x6004CB4")]
			[Address(RVA = "0x9AF5", Offset = "0x9AF5", VA = "0x9AF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F77")]
		public TabBar TabBar
		{
			[Token(Token = "0x6004CB5")]
			[Address(RVA = "0x9AF6", Offset = "0x9AF6", VA = "0x9AF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0x9AF7", Offset = "0x9AF7", VA = "0x9AF7", Slot = "22")]
		protected override void OnShow(BankWindow.BankWindowArgs args)
		{
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x9AF8", Offset = "0x9AF8", VA = "0x9AF8", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x9AF9", Offset = "0x9AF9", VA = "0x9AF9")]
		public BankWindow()
		{
		}

		// Token: 0x040029E1 RID: 10721
		[Token(Token = "0x40029E1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankWindow";

		// Token: 0x040029E2 RID: 10722
		[Token(Token = "0x40029E2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040029E3 RID: 10723
		[Token(Token = "0x40029E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BankOptionsListView _bankOptionsListView;

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x44")]
		private BankViewMediator _mediator;

		// Token: 0x02000C4A RID: 3146
		[Token(Token = "0x2000C4A")]
		public class BankWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004CB9 RID: 19641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CB9")]
			[Address(RVA = "0x9AFA", Offset = "0x9AFA", VA = "0x9AFA")]
			public BankWindowArgs()
			{
			}

			// Token: 0x06004CBA RID: 19642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CBA")]
			[Address(RVA = "0x9AFB", Offset = "0x9AFB", VA = "0x9AFB")]
			public BankWindowArgs(OptionTypesDic.Types.OptionType optionType)
			{
			}

			// Token: 0x040029E5 RID: 10725
			[Token(Token = "0x40029E5")]
			[FieldOffset(Offset = "0x18")]
			public readonly OptionTypesDic.Types.OptionType OptionType;
		}
	}
}
