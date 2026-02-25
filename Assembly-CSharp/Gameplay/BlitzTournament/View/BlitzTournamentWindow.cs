using System;
using System.Collections.Generic;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC9 RID: 3017
	[Token(Token = "0x2000BC9")]
	public class BlitzTournamentWindow : ClosableBaseWindow<BlitzTournamentWindow.BlitzTournamentWindowArgs>
	{
		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060049F4 RID: 18932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF3")]
		public override string WindowId
		{
			[Token(Token = "0x60049F4")]
			[Address(RVA = "0x985E", Offset = "0x985E", VA = "0x985E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF4")]
		public BlitzTournamentInfoBox InfoBox
		{
			[Token(Token = "0x60049F5")]
			[Address(RVA = "0x985F", Offset = "0x985F", VA = "0x985F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF5")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x60049F6")]
			[Address(RVA = "0x9860", Offset = "0x9860", VA = "0x9860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF6")]
		public Button RulesButton
		{
			[Token(Token = "0x60049F7")]
			[Address(RVA = "0x9861", Offset = "0x9861", VA = "0x9861")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x9862", Offset = "0x9862", VA = "0x9862", Slot = "22")]
		protected override void OnShow(BlitzTournamentWindow.BlitzTournamentWindowArgs args)
		{
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x9863", Offset = "0x9863", VA = "0x9863", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x9864", Offset = "0x9864", VA = "0x9864")]
		public BlitzTournamentListElement[] Init(IList<BlitzTournamentData> tournaments, Action<TournamentListElementBase> onClick)
		{
			return null;
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x9865", Offset = "0x9865", VA = "0x9865", Slot = "17")]
		public override bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x9866", Offset = "0x9866", VA = "0x9866")]
		private void SetupMVC()
		{
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x9867", Offset = "0x9867", VA = "0x9867")]
		private void DestroyMVC()
		{
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x9868", Offset = "0x9868", VA = "0x9868")]
		public BlitzTournamentWindow()
		{
		}

		// Token: 0x04002840 RID: 10304
		[Token(Token = "0x4002840")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/BlitzTournament/BlitzTournamentWindow";

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BlitzTournamentListElement _listElementPrefab;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BlitzTournamentInfoBox _infoBox;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x50")]
		public Func<bool> CheckForClosePermission;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x54")]
		private BlitzTournamentViewMediator _mediator;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x58")]
		private bool _mvcSetUp;

		// Token: 0x02000BCA RID: 3018
		[Token(Token = "0x2000BCA")]
		public class BlitzTournamentWindowArgs : BaseWindowArgs
		{
			// Token: 0x060049FF RID: 18943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049FF")]
			[Address(RVA = "0x9869", Offset = "0x9869", VA = "0x9869")]
			public BlitzTournamentWindowArgs()
			{
			}

			// Token: 0x04002849 RID: 10313
			[Token(Token = "0x4002849")]
			[FieldOffset(Offset = "0x18")]
			public BlitzTournamentController Controller;

			// Token: 0x0400284A RID: 10314
			[Token(Token = "0x400284A")]
			[FieldOffset(Offset = "0x1C")]
			public BlitzTournamentWindow.WindowState WindowState;
		}

		// Token: 0x02000BCB RID: 3019
		[Token(Token = "0x2000BCB")]
		public enum WindowState
		{
			// Token: 0x0400284C RID: 10316
			[Token(Token = "0x400284C")]
			Default,
			// Token: 0x0400284D RID: 10317
			[Token(Token = "0x400284D")]
			Win,
			// Token: 0x0400284E RID: 10318
			[Token(Token = "0x400284E")]
			Lose
		}
	}
}
